/*
Gamoto Class, to provide serial access to the Gamoto PID Motor Controller
More info on the Gamoto here: http://www.gamatronix.com
Written by: Randy Gamage
16-June-2005
Written in C++ using MS Visual Studio .NET 7.1

DriveMode Set this property to the desired drive mode. Accepts a value of enum 
Gamoto.DriveModes  

DriveModePower Set the Gamoto for power mode. Cancels any currently executing trajectories
or sets velocity mode to false if it is enabled.  

*/
#include "win_serial.h"
#include "gamoto.h"
#include <iostream>
using namespace std;


Gamoto::Gamoto()
{
//Default Constructor for Gamoto object
}

Gamoto::~Gamoto(void)
{
	//Gamoto::ClosePort();
}

int Gamoto::Init(byte PortNum,int BaudRate,byte MotoAddress){
   char port[8]="COM";
   char portnum[3];
   _itoa_s(PortNum,portnum,10);
   strcat_s(port,portnum);
   if (SetupCommPort(port,BaudRate))
      return 1;
   else
      return 0;
}
int Gamoto::Reset(){
	return WriteReg(gxReset,1,0);
}
int Gamoto::FactoryReset(){
	return WriteReg(gxFactoryReset,1,0);
}
int Gamoto::SaveParams(){
	return WriteReg(gxSaveParams,1,0);
}
int Gamoto::SetHome(){
	return WriteReg(gxSetHome,1,0);
}
int Gamoto::setKp(int kp){
   return WriteReg(gxKp,2,kp);
}
int Gamoto::setKi(int ki){
   return WriteReg(gxKi,2,ki);
}
int Gamoto::setKd(int kd){
   return WriteReg(gxKd,2,kd);
}
int Gamoto::setdS(int ds){
   return WriteReg(gxdS,2,ds);
}
int Gamoto::setiL(int il){
   return WriteReg(gxiL,2,il);
}
int Gamoto::setMode(DriveModes newMode){
   /* set drive mode of Gamoto */
   return WriteReg(gxMode,1,newMode);
}
int Gamoto::setsetPosition(int pos){
/* Writes to the set position of the motor. This value is used by the PID in absolute
mode to drive the motor to a particular absolute position. The set position is also updated
by some internal functions of the Gamoto board, see Gamoto documentation for full details.  */
   return WriteReg(gxsetPosition,3,pos);
}
int Gamoto::setTrajectory(int traj){
   return WriteReg(gxTrajectory,1,traj);
}
int Gamoto::setpwrLimit(int pl){
   return WriteReg(gxpwrLimit,1,pl);
}
int Gamoto::setmPosition(int mp){
   return WriteReg(gxmPosition,3,mp);
}
int Gamoto::setsetVelocity(int sv){
   return WriteReg(gxsetVelocity,2,sv);
}
int Gamoto::setmPower(int mp){
   return WriteReg(gxmPower,1,mp);
}
int Gamoto::setTrajx(int tx,int profile){
   return WriteReg(gxTrajx+7*profile,3,tx);
}
int Gamoto::setTrajv(int tv,int profile){
   return WriteReg(gxTrajv+7*profile,2,tv);
}
int Gamoto::setTraja(int ta,int profile){
   return WriteReg(gxTraja+7*profile,2,ta);
}
int Gamoto::getKp(){
   return ReadReg(gxKp,2);
}
int Gamoto::getKi(){
   return ReadReg(gxKi,2);
}
int Gamoto::getKd(){
   return ReadReg(gxKd,2);
}
int Gamoto::getiL(){
   return ReadReg(gxiL,2);
}
int Gamoto::getdS(){
   return ReadReg(gxdS,1);
}
int Gamoto::getMode(){
   return ReadReg(gxMode,1);
}
int Gamoto::getpwrLimit(){
   return ReadReg(gxpwrLimit,1);
}
int Gamoto::getsetPosition(){
   /* Reads the current value of the setPosition register in the Gamoto  */
   return ReadReg(gxsetPosition,3);
}
int Gamoto::getmPosition(){
   return ReadReg(gxmPosition,3);
}
int Gamoto::getsetVelocity(){
   return ReadReg(gxsetVelocity,2);
}
int Gamoto::getmVelocity(){
   return ReadReg(gxmVelocity,2);
}
int Gamoto::getTrajectory(){
   return ReadReg(gxTrajectory,1);
}
int Gamoto::getmPower(){
   return ReadReg(gxmPower,1);
}
int Gamoto::getVersion(){
   return ReadReg(gxVersion,1);
}
int Gamoto::getmCurrent(){
   return ReadReg(gxAnalog0,2);
}
int Gamoto::getAnalog0(){
   return ReadReg(gxAnalog0,2);
}
int Gamoto::getAnalog1(){
   return ReadReg(gxAnalog1,2);
}
int Gamoto::getAnalog2(){
   return ReadReg(gxAnalog2,2);
}
int Gamoto::getAnalog3(){
   return ReadReg(gxAnalog3,2);
}
int Gamoto::getAnalog4(){
   return ReadReg(gxAnalog4,2);
}



/**************************************************************/
/* Lower level register access routines  */

int Gamoto::WriteReg(int RegAdr,int RegLen,int Regvalue)
{
	// Write to a Gamoto Register, given the register, length, and
	// data to write.  Check for an ACK response when done.
	// Returns 1 if ACK received,
	// Returns 0 if no ACK (timeout) or invalid ACK

   DWORD bytes_read;
	// Build the message
	wBuffer[0]= gxHEADER;
   wBuffer[1]= RegLen+1;
	wBuffer[2]= RegAdr;
	for (int i=0;i<RegLen;i++) {
		wBuffer[3+i] = Regvalue % 256;
		Regvalue = Regvalue >> 8;
	}
	// Add the checksum as the last byte
	wBuffer[3+RegLen]= CheckSum(wBuffer,3+RegLen);
	// Send the command
	WriteBytes(wBuffer,RegLen+4);
	// Receive the ACK response
	ReadBytes(rBuffer,&bytes_read,2);

	if (rBuffer[0]==ACK && rBuffer[1]==ACK)
		return 1;
	else
		return 0;
}
int Gamoto::ReadReg(int RegAdr, int RegLen) {
	// Reads a value from a Gamoto Register
   int Regvalue=0;
    DWORD bytes_read;
	// Build the command
	wBuffer[0]= gxHEADER;
   wBuffer[1]= gxWRITE;
	wBuffer[2]= RegAdr;
	wBuffer[3]= RegLen;
	wBuffer[4]= CheckSum(wBuffer,4);
	// Send the command
	WriteBytes(wBuffer,5);
	// Get the response
	ReadBytes(rBuffer,&bytes_read,RegLen+2);
	if (bytes_read>0){
		// We got a response - now parse the result
		for (int i=0;i<RegLen;i++) {
			Regvalue += rBuffer[i+1] * (1<<(8*i));
		}
		// Handle negative case
		if (Regvalue >= (1<<(8*RegLen))/2)
			Regvalue -= 1<<(8*RegLen);
	}
	return Regvalue;
}

byte Gamoto::CheckSum(byte* Buffer,int Len) {
	// Calculate the checksum of a read or write buffer
	byte sum=0;
	for (int i=1;i<Len;i++)
		sum += Buffer[i];
	return sum;
}

