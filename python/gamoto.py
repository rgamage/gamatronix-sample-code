#!/usr/bin/python
""" Sample code to control a Gamatronix Gamoto motor controller
    written by Randy Gamage
    version 1.0 - beta release 3/27/07

    This is truly a bare-bones implementation, with no error-checking
    or error handling, and no checksum confirmations.
    It is not a particularly 'pythonic' implementation, but it should
    serve to demonstrate communication with a Gamoto board.
    
    Requirements:
    pyserial (http://pyserial.sourceforge.net/)
"""
import serial
import time

#header
gxHEADER = 170
#special command codes
gxFactoryReset=0
gxSaveToFlash=1
gxReset=2
gxSetHome=3
#common modes
gxDisabledMode=0
gxPositionMode=1
gxTrajMode=3
gxVelocityMode=5
gxPowerMode=17
#mode2 modes
gxHomingMode=1
gxMotionDoneEnable=2
gxSerialShareEnable=4
gx115200Baud=8
gxStepDirEnable=16
gxAnalogFeedbackEnable=32
gxRCPulseIn=64
gxReverseMotor=128
#define Gamatronix register addresses
gxKp=34
gxKi=36
gxKd=38
gxiL=40
gxdS=42
gxMode=43
gxpwrLimit=44
gxMode2=45
gxsetPosition=47
gxmPosition=51
gxsetVelocity=54
gxmVelocity=57
gxTrajectory=59
gxmPower=60
gxError=98
gxAnalog0=160
gxAnalog1=162
gxAnalog2=164
gxAnalog3=166
gxAnalog4=168
gxProfile0=180
gxVersion=178
gxStepSize=179
gxTrajx=180
gxTrajv=183
gxTraja=185
gxSPmin=226
gxSPmax=228
gxRCPmin=230
gxRCPmax=232

class Gamoto:
    "Gamoto Motor Controller class"
    def __init__(self,serport,addr=0):
        #you must pass a serial port object (pySerial)
        self.s = serport
        self.address = addr
    def readReg(self,reg,length):
        #reads a register from Gamoto (len=1,2, or 3)
        #header char and cmd/len byte:
        packet = [chr(gxHEADER+self.address),'\x82']
        packet.append(chr(reg))
        #reading len bytes:
        packet.append(chr(length))
        #calc checksum, cs
        cs = 0
        for ch in packet[1:]:
            cs += ord(ch[0])
        #add cs to packet
        packet.append(chr(cs % 256))
        #send packet
        self.s.write(''.join(packet))
        #get response
        response = self.s.read(2+length)
        answer = 0
        if len(response) > length:
            for i in xrange(length):
                answer += ord(response[i+1])*(256**i)
            return answer
        print "Bad response from Read, reg=%d, addr=%d" % (reg,self.address)
        return 0
    def writeReg(self,reg,length,value):
        #writes a len-byte register to the Gamoto (length=1,2, or 3)
        #header char and cmd/len byte:
        packet = [chr(gxHEADER+self.address),chr(1+length)]
        #register number
        packet.append(chr(reg))
        #add data
        val_bytes = value
        for i in xrange(length):
            packet.append(chr(val_bytes % 256))
            val_bytes = val_bytes >> 8
        #calc checksum, cs
        cs = 0
        for ch in packet[1:]:
            cs += ord(ch[0])
        #add cs to packet
        packet.append(chr(cs % 256))
        #send packet
        self.s.write(''.join(packet))
        #get response
        response = self.s.read(2)
        if response!='\x41\x41':
            print "Bad response from Write, reg=%d, addr=%d" % (reg,self.address)
            
    def readVersion(self):
        return self.readReg(gxVersion,1)
    def reset(self):
        self.writeReg(gxReset,1,0)
    def saveToFlash(self):
        self.writeReg(gxSaveToFlash,1,0)
    def factoryReset(self):
        self.writeReg(gxFactoryReset,1,0)
    def setHome(self):
        self.writeReg(gxSetHome,1,0)
    def setModePosition(self):
        self.writeReg(gxMode,1,gxPositionMode)
    def setModeVelocity(self):
        self.writeReg(gxMode,1,gxVelocityMode)
    def setModeDisabled(self):
        self.writeReg(gxMode,1,gxDisabledMode)
    def setModeTrajectory(self):
        self.writeReg(gxMode,1,gxTrajMode)
    def setModePower(self):
        self.writeReg(gxMode,1,gxPowerMode)
    def setMode(self,mode):
        self.writeReg(gxMode,1,mode)
    def setMode2(self,mode2):
        self.writeReg(gxMode2,1,mode2)
    def setTrajectory(self,traj):
        self.writeReg(gxTrajectory,1,traj)
    def setPosition(self,pos):
        self.writeReg(gxsetPosition,3,pos)
    def setKp(self,Kp):
        self.writeReg(gxKp,2,Kp)
    def setKi(self,Ki):
        self.writeReg(gxKi,2,Ki)
    def setKd(self,Kd):
        self.writeReg(gxKd,2,Kd)
    def setiL(self,iL):
        self.writeReg(gxiL,2,iL)
    def setdS(self,dS):
        self.writeReg(gxdS,1,dS)
    def setpwrLimit(self,pl):
        self.writeReg(gxpwrLimit,1,pl)
    def setVelocity(self,vel):
        self.writeReg(gxsetVelocity,2,vel)
    def setmPower(self,pwr):
        self.writeReg(gxmPower,1,pwr)
    def setTrajx(self,x):
        self.writeReg(gxTrajx,3,x)
    def setTrajv(self,v):
        self.writeReg(gxTrajv,2,v)
    def setTraja(self,a):
        self.writeReg(gxTraja,2,a)
    def getKp(self):
        return self.readReg(gxKp,2)
    def getKi(self):
        return self.readReg(gxKi,2)          
    def getKd(self):
        return self.readReg(gxKd,2)          
    def getiL(self):
        return self.readReg(gxiL,2)          
    def getdS(self):
        return self.readReg(gxdS,1)          
    def getMode(self):
        return self.readReg(gxMode,1)
    def getpwrLimit(self):
        return self.readReg(gxpwrLimit,1)
    def getsetPosition(self):
        return self.readReg(gxsetPosition,3)
    def getmPosition(self):
        return self.readReg(gxmPosition,3)
    def getError(self):
        return self.readReg(gxError,3)
    def getsetVelocity(self):
        return self.readReg(gxsetVelocity,2)
    def getmVelocity(self):
        return self.readReg(gxmVelocity,2)
    def getmPower(self):
        return self.readReg(gxmPower,1)
    def getmCurrent(self):
        return self.readReg(gxAnalog0,2)
    def getAnalog1(self):
        return self.readReg(gxAnalog1,2)
    def getAnalog2(self):
        return self.readReg(gxAnalog2,2)
    def getAnalog3(self):
        return self.readReg(gxAnalog3,2)
    def getAnalog4(self):
        return self.readReg(gxAnalog4,2)
    def trajInProgress(self):
        #test mode bit, return True if traj in progress
        mymode = self.readReg(gxMode,1)
        if (mymode & 0x02) > 0:
            return True
        return False

#-------- End Gamoto Class --------------------

# create / configure / open serial port
ser = serial.Serial()
ser.baudrate = 19200
ser.port = 0     # Port 0 = Windows COM1, Linux tty0, etc
ser.bytesize = 8 #8 bits in a byte
ser.timeout = 1  #To check: is this in seconds, milliseconds???
ser.open()

# Create Gamoto object for left wheel (Gamoto w/dipswitches = 000)
LeftWheel = Gamoto(ser,0)
# Create Gamoto object for left wheel (Gamoto w/dipswitches = 001)
RightWheel = Gamoto(ser,1)
# read Gamoto firmware versions
print "Left Wheel Version = %d" % LeftWheel.readVersion()
print "Right Wheel Version = %d" % RightWheel.readVersion()

# set up PID constants (optional - you can also use MotoView for this)
LeftWheel.setKp(500)
LeftWheel.setKi(3)
LeftWheel.setKd(200)
RightWheel.setKp(500)
RightWheel.setKi(3)
RightWheel.setKd(200)

#examples below are just for left wheel - feel free to add right wheel!

#set to home just in case motor is not home already
LeftWheel.setHome()

#test position mode
print "Testing position mode..."
LeftWheel.setModePosition()
LeftWheel.setPosition(300)
time.sleep(3)
LeftWheel.setPosition(0)
time.sleep(3)

#test velocity mode
print "Testing velocity mode..."
LeftWheel.setModeVelocity()
LeftWheel.setVelocity(5000)
time.sleep(5)
LeftWheel.setVelocity(0)
LeftWheel.setModeDisabled()
time.sleep(3)

#test trajectory mode
print "Testing trajectory mode..."
LeftWheel.setTrajectory(0)
LeftWheel.setTrajx(10000)
LeftWheel.setTrajv(5000)
LeftWheel.setTraja(10)
#Go!
LeftWheel.setModeTrajectory()
#wait for trajectory completion
while LeftWheel.trajInProgress():
    time.sleep(1)  # you don't have to sleep here, it just reduces serial traffic.  You could do a pass instead.

#example how to set some different modes using mode2 byte
LeftWheel.setMode2(gxSerialShareEnable | gxReverseMotor | gxHomingMode)

#clear mode2 byte back to normal
LeftWheel.setMode2(0)

#disable motor
print "Disabling motor..."
LeftWheel.setModeDisabled()

#close serial port
ser.close()


    


