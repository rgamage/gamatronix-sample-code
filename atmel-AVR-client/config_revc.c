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
