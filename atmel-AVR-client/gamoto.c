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
#include "gamoto.h"

int Reset(){
	return WriteReg(gxReset,1,0);
}
int FactoryReset(){
	return WriteReg(gxFactoryReset,1,0);
}
int SaveParams(){
	return WriteReg(gxSaveParams,1,0);
}
int SetHome(){
	return WriteReg(gxSetHome,1,0);
}
int setKp(int kp){
   return WriteReg(gxKp,2,kp);
}
int setKi(int ki){
   return WriteReg(gxKi,2,ki);
}
int setKd(int kd){
   return WriteReg(gxKd,2,kd);
}
int setdS(int ds){
   return WriteReg(gxdS,2,ds);
}
int setiL(int il){
   return WriteReg(gxiL,2,il);
}
int setMode(int newMode){
   /* set drive mode of Gamoto */
   return WriteReg(gxMode,1,newMode);
}
int setsetPosition(int pos){
/* Writes to the set position of the motor. This value is used by the PID in absolute
mode to drive the motor to a particular absolute position. The set position is also updated
by some internal functions of the Gamoto board, see Gamoto documentation for full details.  */
   return WriteReg(gxsetPosition,3,pos);
}
int setTrajectory(int traj){
   return WriteReg(gxTrajectory,1,traj);
}
int setpwrLimit(int pl){
   return WriteReg(gxpwrLimit,1,pl);
}
int setmPosition(int mp){
   return WriteReg(gxmPosition,3,mp);
}
int setsetVelocity(int sv){
   return WriteReg(gxsetVelocity,2,sv);
}
int setmPower(int mp){
   return WriteReg(gxmPower,1,mp);
}
int setTrajx(int tx,int profile){
   return WriteReg(gxTrajx+7*profile,3,tx);
}
int setTrajv(int tv,int profile){
   return WriteReg(gxTrajv+7*profile,2,tv);
}
int setTraja(int ta,int profile){
   return WriteReg(gxTraja+7*profile,2,ta);
}
int getKp(){
   return ReadReg(gxKp,2);
}
int getKi(){
   return ReadReg(gxKi,2);
}
int getKd(){
   return ReadReg(gxKd,2);
}
int getiL(){
   return ReadReg(gxiL,2);
}
int getdS(){
   return ReadReg(gxdS,1);
}
int getMode(){
   return ReadReg(gxMode,1);
}
int getpwrLimit(){
   return ReadReg(gxpwrLimit,1);
}
int getsetPosition(){
   /* Reads the current value of the setPosition register in the Gamoto  */
   return ReadReg(gxsetPosition,3);
}
int getmPosition(){
   return ReadReg(gxmPosition,3);
}
int getsetVelocity(){
   return ReadReg(gxsetVelocity,2);
}
int getmVelocity(){
   return ReadReg(gxmVelocity,2);
}
int getTrajectory(){
   return ReadReg(gxTrajectory,1);
}
int getmPower(){
   return ReadReg(gxmPower,1);
}
int getVersion(){
   return ReadReg(gxVersion,1);
}
int getmCurrent(){
   return ReadReg(gxAnalog0,2);
}
int getAnalog0(){
   return ReadReg(gxAnalog0,2);
}
int getAnalog1(){
   return ReadReg(gxAnalog1,2);
}
int getAnalog2(){
   return ReadReg(gxAnalog2,2);
}
int getAnalog3(){
   return ReadReg(gxAnalog3,2);
}
int getAnalog4(){
   return ReadReg(gxAnalog4,2);
}

/**************************************************************/
/* Lower level register access routines  */

int WriteReg(int RegAdr,int RegLen,int Regvalue)
{
	// Write to a Gamoto Register, given the register, length, and
	// data to write.  Check for an ACK response when done.
	// Returns 1 if ACK received,
	// Returns 0 if no ACK (timeout) or invalid ACK

   int bytes_read;
   int i;
	// Build the message
	wBuffer[0]= gxHEADER;
    wBuffer[1]= RegLen+1;
	wBuffer[2]= RegAdr;
	for (i=0;i<RegLen;i++) {
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
int ReadReg(int RegAdr, int RegLen) {
	// Reads a value from a Gamoto Register
    int Regvalue=0;
    int bytes_read;
    int i;
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
		for (i=0;i<RegLen;i++) {
			Regvalue += rBuffer[i+1] * (1<<(8*i));
		}
		// Handle negative case
		if (Regvalue >= (1<<(8*RegLen))/2)
			Regvalue -= 1<<(8*RegLen);
	}
	return Regvalue;
}

byte CheckSum(byte* Buffer,int Len) {
	// Calculate the checksum of a read or write buffer
	byte sum=0;
	int i;
	for (i=1;i<Len;i++)
		sum += Buffer[i];
	return sum;
}

void WriteBytes(char* buffer, int len)
{
    int i;
    for (i=0; i<len; i++)
    {
        putchar(buffer[i]);
    }
}

void ReadBytes(char* buffer, int* bytes_read, int len)
{
    int i;
    *bytes_read=0;
    for (i=0; i<len; i++)
    {
        buffer[i] = getchar();
        *bytes_read++;
    }
}
