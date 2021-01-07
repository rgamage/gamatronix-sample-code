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
#include "gamoto.c"

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
    //Note - this loop was used to test comms speeds.  This loop executed at
    // 136 Hz running at 19200 baud
    // 744 Hz running at 115200 baud
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
