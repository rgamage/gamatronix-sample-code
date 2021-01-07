/*****************************************************
This program was produced by the
CodeWizardAVR V1.24.7d Standard
Automatic Program Generator
© Copyright 1998-2005 Pavel Haiduc, HP InfoTech s.r.l.
http://www.hpinfotech.com
e-mail:office@hpinfotech.com

Project : Movieboard
Version : 
Date    : 2/18/2008
Author  : Randy Gamage
Company : Gamatronix
Comments: 
For MovieStuff - Roger Evans


Chip type           : ATmega168
Program type        : Application
Clock frequency     : 20.000000 MHz
Memory model        : Small
External SRAM size  : 0
Data Stack size     : 256

Revision History:
3/7/2008 11:30AM Got working for light flashing use with Rev B board,
                saved as rev 2.
3/9/2008 12:40PM Refactored to allow different config files depending
                upon PCB board revision.  Saved as rev 3
3/15/2008 11:12AM Started reworking motor control to be scaled to time, so no matter
                what the PID update rate is, the gains should remain the same.   
3/16/2008 4:44PM Saved as version 4 - working well, just need to add bias values
                for each speed, maybe some auto-save feature to save bias to eeprom
                when the error stabilizes to zero.         
3/18/2008 8:53PM Fixed some problems with light flasher logic.  Light now is on when motor idle,
                dimming resolution is improved, and debounce has been reduced that should allow
                running at higher speeds.
                Got analog smoothing working, cleaned up light on/off logic
                To Do: Investigate 5V supply glitches and missing Light control pulses.
                Scope on the pot wiper and ground, set to 500mV sensitivity.
                Negative spikes are regular, at ~1.95kHz, asynchronous with LED output pulsing ???
3/20/2008 9:35PM Fixed the 5V spike issue- was caused by reading an ADC channel while that channel
                was configured as an output.  Apparently it's a bad thing to do.
                New problem: Motor control is missing timing pulses periodically. Need to find & fix.
3/22/2008 10:30AM Fixed it! Sensor pulse was lower voltage because it was connected to an unpowered
                Gamoto board, and that was dragging it down.     
3/26/2008 7:42PM Changed this code to the test code, for board verification by the contract manufacturer
/               Changed config reference to config_c                           
*****************************************************/

#include <mega168.h>
#include <delay.h>

#define TMR1FREQ _MCU_CLOCK_FREQUENCY_
#define TMR0FREQ _MCU_CLOCK_FREQUENCY_/8
#define PWMFREQ 15734
#define PWMRESOLUTION 1000
#define ADCRESOLUTION 1024
#define SYSTICKFREQ 10000  //10000 = 0.1ms ticks      
#define high 1
#define low 0
#define true 1
#define false 0    
#define intsoff #asm("cli")   //turn off interrupts
#define intson  #asm("sei")   //turn on interrupts
//#define REV_A_BOARD 1
//#define REV_B_BOARD 1
#define REV_C_BOARD 1

//Fuses: Need to turn on 4V undervoltage fuse to protect FETS from under-voltage operation

// Standard Input/Output functions
#include <stdio.h>
#include "serial.c"
//serial port routines

#define RXB8 1
#define TXB8 0
#define UPE 2
#define OVR 3
#define FE 4
#define UDRE 5
#define RXC 7

#define FRAMING_ERROR (1<<FE)
#define PARITY_ERROR (1<<UPE)
#define DATA_OVERRUN (1<<OVR)
#define DATA_REGISTER_EMPTY (1<<UDRE)
#define RX_COMPLETE (1<<RXC)

// USART Receiver buffer
#define RX_BUFFER_SIZE0 8
char rx_buffer0[RX_BUFFER_SIZE0];

#if RX_BUFFER_SIZE0<256
unsigned char rx_wr_index0,rx_rd_index0,rx_counter0;
#else
unsigned int rx_wr_index0,rx_rd_index0,rx_counter0;
#endif

// This flag is set on USART Receiver buffer overflow
bit rx_buffer_overflow0;

// USART Receiver interrupt service routine
interrupt [USART_RXC] void usart_rx_isr(void)
{
char status,data;
status=UCSR0A;
data=UDR0;
if ((status & (FRAMING_ERROR | PARITY_ERROR | DATA_OVERRUN))==0)
   {
   rx_buffer0[rx_wr_index0]=data;
   if (++rx_wr_index0 == RX_BUFFER_SIZE0) rx_wr_index0=0;
   if (++rx_counter0 == RX_BUFFER_SIZE0)
      {
      rx_counter0=0;
      rx_buffer_overflow0=1;
      };
   };
}

#ifndef _DEBUG_TERMINAL_IO_
// Get a character from the USART Receiver buffer
#define _ALTERNATE_GETCHAR_
#pragma used+
char getchar(void)
{
char data;
while (rx_counter0==0);
data=rx_buffer0[rx_rd_index0];
if (++rx_rd_index0 == RX_BUFFER_SIZE0) rx_rd_index0=0;
#asm("cli")
--rx_counter0;
#asm("sei")
return data;
}
#pragma used-
#endif
#include "gamoto.c"
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

// Global variables here          
    unsigned long SysTicks=0;           //Master timer counter, in units of 0.1ms    
    int i,j;
    long pwmfreq = PWMFREQ;
    int PWMout1=0;
    int PWMout2=512;
    
//function prototypes    
void PWM1setduty(int duty);
void PWMinit();
unsigned int read_adc(unsigned char adc_input);
void PWMinit();
void PWM1setduty(int duty);
void PrintAnalogs();
void PrintDips();
void PrintD1D2();

void main(void)
{
// Declare your local variables here
#ifdef REV_A_BOARD
    #include <config_revA.c>
#endif
#ifdef REV_B_BOARD                                      
    #include <config_revB.c>
#endif
#ifdef REV_C_BOARD
    #include <config_revC.c>
//Hardware configuration for Rev A boards

// Crystal Oscillator division factor: 1
#pragma optsize-
CLKPR=0x80;
CLKPR=0x00;
#ifdef _OPTIMIZE_SIZE_
#pragma optsize+
#endif

#define OUT 1
#define PULLUP 1
#define ALL_INPUTS 0

// Input/Output Ports initialization
// Port B initialization
// Func7=In Func6=In Func5=In Func4=In Func3=In Func2=Out Func1=Out Func0=In 
// State7=T State6=T State5=T State4=T State3=T State2=0 State1=0 State0=T 
#define D2 PINB.0
#define PWM1_PIN PORTB.1
#define PWM2_PIN PORTB.2
PORTB = PULLUP<<0;
DDRB =  OUT<<1 | OUT<<2;

// Port C initialization
// Func6=In Func5=In Func4=In Func3=In Func2=In Func1=In Func0=Out 
// State6=T State5=T State4=P State3=T State2=T State1=T State0=T 
#define OUT1 PORTC.3
#define DIP1 PINC.4
#define DIP2 PINC.5
PORTC = PULLUP<<4 | PULLUP<<5;
DDRC = OUT<<3;

// Port D initialization
// Func7=In Func6=In Func5=In Func4=In Func3=Out Func2=In Func1=In Func0=In 
// State7=P State6=T State5=P State4=P State3=0 State2=T State1=T State0=T 
#define SHUTTERPIN PIND.2
#define D1 PIND.2
#define DIP3 PIND.4
#define DIP4 PIND.5
#define OUT2 PORTD.6
#define DIP5 PIND.7
PORTD = PULLUP << 0 | PULLUP<<4 | PULLUP<<5 | PULLUP<<7;
DDRD = OUT<<6;

// Timer/Counter 0 initialization
// Clock source: System Clock
// Clock value: 2500.000 kHz
// Mode: CTC top=OCR0A
// OC0A output: Disconnected
// OC0B output: Disconnected
TCCR0A=0x02;
TCCR0B=0x02;
TCNT0=0x00;
OCR0A=0xF9;  //2,500,000 / 0xF9 = 10kHz
OCR0B=0x00;

// Timer/Counter 1 initialization
// Clock source: System Clock
// Clock value: 20000.000 kHz
// Mode: Fast PWM top=ICR1
// OC1A output: Non-Inv.
// OC1B output: Non-Inv.
// Noise Canceler: Off
// Input Capture on Falling Edge
// Timer 1 Overflow Interrupt: Off
// Input Capture Interrupt: Off
// Compare A Match Interrupt: Off
// Compare B Match Interrupt: Off
TCCR1A=0xA2;
TCCR1B=0x19;
TCNT1H=0x00;
TCNT1L=0x00;
ICR1H=0x00;
ICR1L=0x00;
OCR1AH=0x00;
OCR1AL=0x00;
OCR1BH=0x00;
OCR1BL=0x00;

// Timer/Counter 2 initialization
// Clock source: System Clock
// Clock value: Timer 2 Stopped
// Mode: Normal top=FFh
// OC2A output: Disconnected
// OC2B output: Disconnected
ASSR=0x00;
TCCR2A=0x00;
TCCR2B=0x00;
TCNT2=0x00;
OCR2A=0x00;
OCR2B=0x00;

// External Interrupt(s) initialization
// INT0: On
// INT0 Mode: Any change
// INT1: Off
// Interrupt on any change on pins PCINT0-7: Off
// Interrupt on any change on pins PCINT8-14: Off
// Interrupt on any change on pins PCINT16-23: Off
EICRA=0x01;
EIMSK=0x01;
EIFR=0x01;
PCICR=0x00;


// Timer/Counter 0 Interrupt(s) initialization
TIMSK0=0x02;
// Timer/Counter 1 Interrupt(s) initialization
TIMSK1=0x00;
// Timer/Counter 2 Interrupt(s) initialization
TIMSK2=0x00;

// USART initialization
// Communication Parameters: 8 Data, 1 Stop, No Parity
// USART Receiver: On
// USART Transmitter: On
// USART0 Mode: Asynchronous
// USART Baud rate: 19200
//for 20Mhz:
UCSR0A=0x00;
UCSR0B=0x98;
UCSR0C=0x06;
UBRR0H=0x00;
//UBRR0L=0x40; //19200 baud
UBRR0L=0x0A; //115200 baud
//for 8Mhz:
//UCSR0A=0x00;
//UCSR0B=0x98;
//UCSR0C=0x06;
//UBRR0H=0x00;
//UBRR0L=0x19;

// Analog Comparator initialization
// Analog Comparator: Off
// Analog Comparator Input Capture by Timer/Counter 1: Off
ACSR=0x80;
ADCSRB=0x00;

// ADC initialization
// ADC Clock frequency: 156.250 kHz
// ADC Voltage Reference: AVCC pin
// ADC Auto Trigger Source: None
// Digital input buffers on ADC0: On, ADC1: On, ADC2: On, ADC3: On
// ADC4: On, ADC5: On
#define ADC_VREF_TYPE 0x40
DIDR0=0x00;
ADMUX=ADC_VREF_TYPE;
ADCSRA=0x87;
#define ADC_DIMMER 0       //adc channel used to set light brightness
#define ADC_PHASEDELAY 1   //adc channel used to set phase delay
//Define analog channels according to analog pin labeling on PCB
#define ANALOG1 0
#define ANALOG2 1
#define ANALOG3 2
#define ANALOG4 7
#endif
    i=0;
    j=0;

    TCCR1A=0;
    
// Global enable interrupts
#asm("sei")

//simulator code 
#define PULSE_OUT PORTC.4
DDRC |= OUT<<4;  //make it an output pin
TCCR0A=0;
TCCR0B=0;
TIMSK0=0;

while (0) {
    PULSE_OUT=low;
    delay_us(5);
    PULSE_OUT=high;
    delay_us(59);
}
//end simulator code
while (1) {
    //gamoto client test
//     setKp(456);
//     i = getMode();
     OUT1 = low;
     OUT2 = high;
     setmPower(500);
     OUT1 = high;
     OUT2 = low;
     setmPower(700);
//     delay_ms(500);
//     i = getMode();
//     setmPower(500);
//     setmPower(700);
//     delay_ms(500);
}
//board test mode
while (0) {
    
     //flash SSR LEDs alternately
     delay_ms(500);
     OUT1 = low;
     OUT2 = high;
     PWM1_PIN = low;
     PWM2_PIN = low;
     PrintAnalogs();
     PrintDips();
     PrintD1D2();
     delay_ms(500);
     OUT1 = high;
     OUT2 = low;
     PWM1_PIN = low;
     PWM2_PIN = low;
     PrintAnalogs();
     PrintDips();
     PrintD1D2();
     delay_ms(500);
     PWM1_PIN = high;
     PWM2_PIN = low;
     OUT1 = high;
     OUT2 = high;
     PrintAnalogs();
     PrintDips();
     PrintD1D2();
     delay_ms(500);
     PWM2_PIN = high;     
     PWM1_PIN = low;     
     OUT1 = high;
     OUT2 = high;
     PrintAnalogs();
     PrintDips();
     PrintD1D2();
     }          
}
void PrintD1D2(){
    unsigned char d;
    d = (D1 << 1) | D2;
    switch (d){
        case 0b11:
            printf("D1: Open / D2: Open");
            break;
        case 0b10:
            printf("D1: Open / D2: Shorted");
            break;
        case 0b01:
            printf("D1: Shorted / D2: Open");
            break;
        case 0b00:
            printf("D1: Shorted / D2: Shorted");
            break;
        default:
    }
    printf("\n\r");
}
void PrintDips(){
    unsigned char dips;
    dips = DIP1<<4 | DIP2<<3 | DIP3<<2 | DIP4<<1 | DIP5;
    dips = ~dips & 0b00011111; 
    switch (dips){
        case 0b00000 : 
            printf("DIPSWITCHES: 00000  ");
            break;
        case 0b10000 :
            printf("DIPSWITCHES: 10000  ");
            break;
        case 0b01000 :
            printf("DIPSWITCHES: 01000  ");
            break;
        case 0b00100 :
            printf("DIPSWITCHES: 00100  ");
            break;
        case 0b00010 :
            printf("DIPSWITCHES: 00010  ");
            break;
        case 0b00001 :
            printf("DIPSWITCHES: 00001  ");
            break;
        default :
            printf("DIPSWITCHES: INVALID  ");
    }
}

void PrintAnalogs(){
     //show analog readouts through serial port
     printf("AN1/AN2/AN3/AN4: %d/%d/%d/%d   ",read_adc(ANALOG1),read_adc(ANALOG2),read_adc(ANALOG3),read_adc(ANALOG4));
     }

// External Interrupt 0 service routine
interrupt [EXT_INT0] void ext_int0_isr(void) 
{

}

// Timer 0 output compare A interrupt service routine
interrupt [TIM0_COMPA] void timer0_compa_isr(void)
{
    SysTicks++;
}

// Read the AD conversion result
unsigned int read_adc(unsigned char adc_input)
{
    ADMUX=adc_input|ADC_VREF_TYPE;
    // Start the AD conversion
    ADCSRA|=0x40;
    // Wait for the AD conversion to complete
    while ((ADCSRA & 0x10)==0);
    ADCSRA|=0x10;
    return ADCW;
}

void PWMinit()
{
    //Initialize hardware PWM
    int period;
    period = TMR1FREQ/pwmfreq-1;
    intsoff
    //set PWM base frequency
    ICR1H = period>>8;  
    ICR1L = period % 256;
    //set duty to 50%
    OCR1AH = (period/2)>>8;  //0x03
    OCR1AL = (period/2) % 256;   //0xE7
    intson
}
void PWM1setduty(int duty)
{
    //set PWM duty cycle, from 0 to PWMRESOLUTION
    long period;
    if (duty>PWMRESOLUTION) duty=PWMRESOLUTION;
    if (duty<0) duty = 0;
    period = TMR1FREQ/pwmfreq-1;
    period = (duty*period)/PWMRESOLUTION;
    intsoff
    OCR1AH = period>>8; 
    OCR1AL = period % 256;  
    intson
}  
