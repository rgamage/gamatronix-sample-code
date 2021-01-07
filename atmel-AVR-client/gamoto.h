/*
Gamoto Class header file
Provides serial access to the Gamoto PID Motor Controller
More info on the Gamoto here: http://www.gamatronix.com
Written by: Randy Gamage
*/

#ifndef GAMOTOH
#define GAMOTOH 1

// TYPEDEF FOR BYTES
typedef unsigned char byte;

// Constants
#define ACK			0x41
#define gxHEADER	0xAA
#define gxWRITE   0x82

enum DriveModes {
   POSITION_MODE=1,
   TRAJECTORY_MODE=3,
   VELOCITY_MODE=5,
   POWER_MODE=17
};

#define gxFactoryReset 0
#define gxSaveParams 1
#define gxReset 2
#define gxSetHome 3
#define gxKp 34
#define gxKi 36
#define gxKd 38
#define gxiL 40
#define gxdS 42
#define gxMode 43
#define gxPositionMode 1
#define gxTrajMode 3
#define gxVelocityMode 5
#define gxPowerMode 17
#define gxpwrLimit 44
#define gxdummy1 45
#define gxsetPosition 47
#define gxmPosition 51
#define gxsetVelocity 54
#define gxmVelocity 57
#define gxTrajectory 59
#define gxmPower 60

#define dBug1 122
#define dBug2 123

#define gxAnalog0 160
#define gxAnalog1 162
#define gxAnalog2 164
#define gxAnalog3 166
#define gxAnalog4 168
#define gxProfile0 180
#define gxVersion 178
#define gxTrajx 180
#define gxTrajv 183
#define gxTraja 185

	//function prototypes
   int WriteReg(int reg,int len,int data);
   int ReadReg(int reg,int len);
   int Init(byte PortNum,int BaudRate,byte MotoAddress);
   int Reset();
   int FactoryReset();
   int SaveParams();
   int SetHome();
   int setMode(int newMode);
   int setTrajectory(int);
   int setsetPosition(int pos);
   int setKp(int);
   int setKi(int);
   int setKd(int);
   int setdS(int);
   int setiL(int);
   int setpwrLimit(int);
   int setmPosition(int);
   int setsetVelocity(int);
   int setmPower(int);
   int setTrajx(int tx,int profile);
   int setTrajv(int tv,int profile);
   int setTraja(int ta,int profile);
   int getKp();
   int getKi();
   int getKd();
   int getiL();
   int getdS();
   int getMode();
   int getpwrLimit();
   int getsetPosition();
   int getmPosition();
   int getsetVelocity();
   int getmVelocity();
   int getTrajectory();
   int getmPower();
   int getVersion();
   int getmCurrent();
   int getAnalog0();
   int getAnalog1();
   int getAnalog2();
   int getAnalog3();
   int getAnalog4();
   void WriteBytes(char* buffer, int len);
   void ReadBytes(char* buffer, int* bytes_read, int len);
   unsigned char CheckSum(unsigned char* Buffer,int Len); 
   unsigned char wBuffer[20];  //write buffer used to construct messages
   unsigned char rBuffer[20];  //read buffer used to parse messages

#endif //GAMOTOH
