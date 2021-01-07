;CodeVisionAVR C Compiler V1.24.7d Standard
;(C) Copyright 1998-2005 Pavel Haiduc, HP InfoTech s.r.l.
;http://www.hpinfotech.com

;Chip type              : ATmega168
;Program type           : Application
;Clock frequency        : 20.000000 MHz
;Memory model           : Small
;Optimize for           : Size
;(s)printf features     : int, width
;(s)scanf features      : int, width
;External SRAM size     : 0
;Data Stack size        : 256 byte(s)
;Heap size              : 0 byte(s)
;Promote char to int    : No
;char is unsigned       : Yes
;8 bit enums            : Yes
;Word align FLASH struct: No
;Enhanced core instructions    : On
;Automatic register allocation : On

	#pragma AVRPART ADMIN PART_NAME ATmega168
	#pragma AVRPART MEMORY PROG_FLASH 16384
	#pragma AVRPART MEMORY EEPROM 512
	#pragma AVRPART MEMORY INT_SRAM SIZE 1024
	#pragma AVRPART MEMORY INT_SRAM START_ADDR 0x100

	.EQU EERE=0x0
	.EQU EEWE=0x1
	.EQU EEMWE=0x2
	.EQU UDRE=0x5
	.EQU RXC=0x7
	.EQU EECR=0x1F
	.EQU EEDR=0x20
	.EQU EEARL=0x21
	.EQU EEARH=0x22
	.EQU SPSR=0x2D
	.EQU SPDR=0x2E
	.EQU SMCR=0x33
	.EQU MCUSR=0x34
	.EQU MCUCR=0x35
	.EQU WDTCSR=0x60
	.EQU UCSR0A=0xC0
	.EQU UDR0=0xC6
	.EQU SPL=0x3D
	.EQU SPH=0x3E
	.EQU SREG=0x3F
	.EQU GPIOR0=0x1E
	.EQU GPIOR1=0x2A
	.EQU GPIOR2=0x2B

	.DEF R0X0=R0
	.DEF R0X1=R1
	.DEF R0X2=R2
	.DEF R0X3=R3
	.DEF R0X4=R4
	.DEF R0X5=R5
	.DEF R0X6=R6
	.DEF R0X7=R7
	.DEF R0X8=R8
	.DEF R0X9=R9
	.DEF R0XA=R10
	.DEF R0XB=R11
	.DEF R0XC=R12
	.DEF R0XD=R13
	.DEF R0XE=R14
	.DEF R0XF=R15
	.DEF R0X10=R16
	.DEF R0X11=R17
	.DEF R0X12=R18
	.DEF R0X13=R19
	.DEF R0X14=R20
	.DEF R0X15=R21
	.DEF R0X16=R22
	.DEF R0X17=R23
	.DEF R0X18=R24
	.DEF R0X19=R25
	.DEF R0X1A=R26
	.DEF R0X1B=R27
	.DEF R0X1C=R28
	.DEF R0X1D=R29
	.DEF R0X1E=R30
	.DEF R0X1F=R31

	.EQU __se_bit=0x01
	.EQU __sm_mask=0x0E
	.EQU __sm_adc_noise_red=0x02
	.EQU __sm_powerdown=0x04
	.EQU __sm_powersave=0x06
	.EQU __sm_standby=0x0C

	.MACRO __CPD1N
	CPI  R30,LOW(@0)
	LDI  R26,HIGH(@0)
	CPC  R31,R26
	LDI  R26,BYTE3(@0)
	CPC  R22,R26
	LDI  R26,BYTE4(@0)
	CPC  R23,R26
	.ENDM

	.MACRO __CPD2N
	CPI  R26,LOW(@0)
	LDI  R30,HIGH(@0)
	CPC  R27,R30
	LDI  R30,BYTE3(@0)
	CPC  R24,R30
	LDI  R30,BYTE4(@0)
	CPC  R25,R30
	.ENDM

	.MACRO __CPWRR
	CP   R@0,R@2
	CPC  R@1,R@3
	.ENDM

	.MACRO __CPWRN
	CPI  R@0,LOW(@2)
	LDI  R30,HIGH(@2)
	CPC  R@1,R30
	.ENDM

	.MACRO __ADDB1MN
	SUBI R30,LOW(-@0-(@1))
	.ENDM
	.MACRO __ADDB2MN
	SUBI R26,LOW(-@0-(@1))
	.ENDM
	.MACRO __ADDW1MN
	SUBI R30,LOW(-@0-(@1))
	SBCI R31,HIGH(-@0-(@1))
	.ENDM
	.MACRO __ADDW2MN
	SUBI R26,LOW(-@0-(@1))
	SBCI R27,HIGH(-@0-(@1))
	.ENDM
	.MACRO __ADDW1FN
	SUBI R30,LOW(-2*@0-(@1))
	SBCI R31,HIGH(-2*@0-(@1))
	.ENDM
	.MACRO __ADDD1FN
	SUBI R30,LOW(-2*@0-(@1))
	SBCI R31,HIGH(-2*@0-(@1))
	SBCI R24,BYTE3(-2*@0-(@1))
	.ENDM
	.MACRO __ADDD1N
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	SBCI R22,BYTE3(-@0)
	SBCI R23,BYTE4(-@0)
	.ENDM

	.MACRO __ADDD2N
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	SBCI R24,BYTE3(-@0)
	SBCI R25,BYTE4(-@0)
	.ENDM

	.MACRO __SUBD1N
	SUBI R30,LOW(@0)
	SBCI R31,HIGH(@0)
	SBCI R22,BYTE3(@0)
	SBCI R23,BYTE4(@0)
	.ENDM

	.MACRO __SUBD2N
	SUBI R26,LOW(@0)
	SBCI R27,HIGH(@0)
	SBCI R24,BYTE3(@0)
	SBCI R25,BYTE4(@0)
	.ENDM

	.MACRO __ANDD1N
	ANDI R30,LOW(@0)
	ANDI R31,HIGH(@0)
	ANDI R22,BYTE3(@0)
	ANDI R23,BYTE4(@0)
	.ENDM

	.MACRO __ORD1N
	ORI  R30,LOW(@0)
	ORI  R31,HIGH(@0)
	ORI  R22,BYTE3(@0)
	ORI  R23,BYTE4(@0)
	.ENDM

	.MACRO __DELAY_USB
	LDI  R24,LOW(@0)
__DELAY_USB_LOOP:
	DEC  R24
	BRNE __DELAY_USB_LOOP
	.ENDM

	.MACRO __DELAY_USW
	LDI  R24,LOW(@0)
	LDI  R25,HIGH(@0)
__DELAY_USW_LOOP:
	SBIW R24,1
	BRNE __DELAY_USW_LOOP
	.ENDM

	.MACRO __CLRD1S
	LDI  R30,0
	STD  Y+@0,R30
	STD  Y+@0+1,R30
	STD  Y+@0+2,R30
	STD  Y+@0+3,R30
	.ENDM

	.MACRO __GETD1S
	LDD  R30,Y+@0
	LDD  R31,Y+@0+1
	LDD  R22,Y+@0+2
	LDD  R23,Y+@0+3
	.ENDM

	.MACRO __PUTD1S
	STD  Y+@0,R30
	STD  Y+@0+1,R31
	STD  Y+@0+2,R22
	STD  Y+@0+3,R23
	.ENDM

	.MACRO __PUTD2S
	STD  Y+@0,R26
	STD  Y+@0+1,R27
	STD  Y+@0+2,R24
	STD  Y+@0+3,R25
	.ENDM

	.MACRO __POINTB1MN
	LDI  R30,LOW(@0+@1)
	.ENDM

	.MACRO __POINTW1MN
	LDI  R30,LOW(@0+@1)
	LDI  R31,HIGH(@0+@1)
	.ENDM

	.MACRO __POINTW1FN
	LDI  R30,LOW(2*@0+@1)
	LDI  R31,HIGH(2*@0+@1)
	.ENDM

	.MACRO __POINTD1FN
	LDI  R30,LOW(2*@0+@1)
	LDI  R31,HIGH(2*@0+@1)
	LDI  R22,BYTE3(2*@0+@1)
	.ENDM

	.MACRO __POINTB2MN
	LDI  R26,LOW(@0+@1)
	.ENDM

	.MACRO __POINTW2MN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	.ENDM

	.MACRO __POINTBRM
	LDI  R@0,LOW(@1)
	.ENDM

	.MACRO __POINTWRM
	LDI  R@0,LOW(@2)
	LDI  R@1,HIGH(@2)
	.ENDM

	.MACRO __POINTBRMN
	LDI  R@0,LOW(@1+@2)
	.ENDM

	.MACRO __POINTWRMN
	LDI  R@0,LOW(@2+@3)
	LDI  R@1,HIGH(@2+@3)
	.ENDM

	.MACRO __POINTWRFN
	LDI  R@0,LOW(@2*2+@3)
	LDI  R@1,HIGH(@2*2+@3)
	.ENDM

	.MACRO __GETD1N
	LDI  R30,LOW(@0)
	LDI  R31,HIGH(@0)
	LDI  R22,BYTE3(@0)
	LDI  R23,BYTE4(@0)
	.ENDM

	.MACRO __GETD2N
	LDI  R26,LOW(@0)
	LDI  R27,HIGH(@0)
	LDI  R24,BYTE3(@0)
	LDI  R25,BYTE4(@0)
	.ENDM

	.MACRO __GETD2S
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	LDD  R24,Y+@0+2
	LDD  R25,Y+@0+3
	.ENDM

	.MACRO __GETB1MN
	LDS  R30,@0+@1
	.ENDM

	.MACRO __GETB1HMN
	LDS  R31,@0+@1
	.ENDM

	.MACRO __GETW1MN
	LDS  R30,@0+@1
	LDS  R31,@0+@1+1
	.ENDM

	.MACRO __GETD1MN
	LDS  R30,@0+@1
	LDS  R31,@0+@1+1
	LDS  R22,@0+@1+2
	LDS  R23,@0+@1+3
	.ENDM

	.MACRO __GETBRMN
	LDS  R@0,@1+@2
	.ENDM

	.MACRO __GETWRMN
	LDS  R@0,@2+@3
	LDS  R@1,@2+@3+1
	.ENDM

	.MACRO __GETWRZ
	LDD  R@0,Z+@2
	LDD  R@1,Z+@2+1
	.ENDM

	.MACRO __GETD2Z
	LDD  R26,Z+@0
	LDD  R27,Z+@0+1
	LDD  R24,Z+@0+2
	LDD  R25,Z+@0+3
	.ENDM

	.MACRO __GETB2MN
	LDS  R26,@0+@1
	.ENDM

	.MACRO __GETW2MN
	LDS  R26,@0+@1
	LDS  R27,@0+@1+1
	.ENDM

	.MACRO __GETD2MN
	LDS  R26,@0+@1
	LDS  R27,@0+@1+1
	LDS  R24,@0+@1+2
	LDS  R25,@0+@1+3
	.ENDM

	.MACRO __PUTB1MN
	STS  @0+@1,R30
	.ENDM

	.MACRO __PUTW1MN
	STS  @0+@1,R30
	STS  @0+@1+1,R31
	.ENDM

	.MACRO __PUTD1MN
	STS  @0+@1,R30
	STS  @0+@1+1,R31
	STS  @0+@1+2,R22
	STS  @0+@1+3,R23
	.ENDM

	.MACRO __PUTDZ2
	STD  Z+@0,R26
	STD  Z+@0+1,R27
	STD  Z+@0+2,R24
	STD  Z+@0+3,R25
	.ENDM

	.MACRO __PUTBMRN
	STS  @0+@1,R@2
	.ENDM

	.MACRO __PUTWMRN
	STS  @0+@1,R@2
	STS  @0+@1+1,R@3
	.ENDM

	.MACRO __PUTBZR
	STD  Z+@1,R@0
	.ENDM

	.MACRO __PUTWZR
	STD  Z+@2,R@0
	STD  Z+@2+1,R@1
	.ENDM

	.MACRO __GETW1R
	MOV  R30,R@0
	MOV  R31,R@1
	.ENDM

	.MACRO __GETW2R
	MOV  R26,R@0
	MOV  R27,R@1
	.ENDM

	.MACRO __GETWRN
	LDI  R@0,LOW(@2)
	LDI  R@1,HIGH(@2)
	.ENDM

	.MACRO __PUTW1R
	MOV  R@0,R30
	MOV  R@1,R31
	.ENDM

	.MACRO __PUTW2R
	MOV  R@0,R26
	MOV  R@1,R27
	.ENDM

	.MACRO __ADDWRN
	SUBI R@0,LOW(-@2)
	SBCI R@1,HIGH(-@2)
	.ENDM

	.MACRO __ADDWRR
	ADD  R@0,R@2
	ADC  R@1,R@3
	.ENDM

	.MACRO __SUBWRN
	SUBI R@0,LOW(@2)
	SBCI R@1,HIGH(@2)
	.ENDM

	.MACRO __SUBWRR
	SUB  R@0,R@2
	SBC  R@1,R@3
	.ENDM

	.MACRO __ANDWRN
	ANDI R@0,LOW(@2)
	ANDI R@1,HIGH(@2)
	.ENDM

	.MACRO __ANDWRR
	AND  R@0,R@2
	AND  R@1,R@3
	.ENDM

	.MACRO __ORWRN
	ORI  R@0,LOW(@2)
	ORI  R@1,HIGH(@2)
	.ENDM

	.MACRO __ORWRR
	OR   R@0,R@2
	OR   R@1,R@3
	.ENDM

	.MACRO __EORWRR
	EOR  R@0,R@2
	EOR  R@1,R@3
	.ENDM

	.MACRO __GETWRS
	LDD  R@0,Y+@2
	LDD  R@1,Y+@2+1
	.ENDM

	.MACRO __PUTWSR
	STD  Y+@2,R@0
	STD  Y+@2+1,R@1
	.ENDM

	.MACRO __MOVEWRR
	MOV  R@0,R@2
	MOV  R@1,R@3
	.ENDM

	.MACRO __INWR
	IN   R@0,@2
	IN   R@1,@2+1
	.ENDM

	.MACRO __OUTWR
	OUT  @2+1,R@1
	OUT  @2,R@0
	.ENDM

	.MACRO __CALL1MN
	LDS  R30,@0+@1
	LDS  R31,@0+@1+1
	ICALL
	.ENDM

	.MACRO __CALL1FN
	LDI  R30,LOW(2*@0+@1)
	LDI  R31,HIGH(2*@0+@1)
	CALL __GETW1PF
	ICALL
	.ENDM

	.MACRO __CALL2EN
	LDI  R26,LOW(@0+@1)
	LDI  R27,HIGH(@0+@1)
	CALL __EEPROMRDW
	ICALL
	.ENDM

	.MACRO __GETW1STACK
	IN   R26,SPL
	IN   R27,SPH
	ADIW R26,@0+1
	LD   R30,X+
	LD   R31,X
	.ENDM

	.MACRO __NBST
	BST  R@0,@1
	IN   R30,SREG
	LDI  R31,0x40
	EOR  R30,R31
	OUT  SREG,R30
	.ENDM


	.MACRO __PUTB1SN
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SN
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SN
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1SNS
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	ADIW R26,@1
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SNS
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	ADIW R26,@1
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SNS
	LDD  R26,Y+@0
	LDD  R27,Y+@0+1
	ADIW R26,@1
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1PMN
	LDS  R26,@0
	LDS  R27,@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1PMN
	LDS  R26,@0
	LDS  R27,@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1PMN
	LDS  R26,@0
	LDS  R27,@0+1
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1PMNS
	LDS  R26,@0
	LDS  R27,@0+1
	ADIW R26,@1
	ST   X,R30
	.ENDM

	.MACRO __PUTW1PMNS
	LDS  R26,@0
	LDS  R27,@0+1
	ADIW R26,@1
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1PMNS
	LDS  R26,@0
	LDS  R27,@0+1
	ADIW R26,@1
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RN
	MOVW R26,R@0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RN
	MOVW R26,R@0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RN
	MOVW R26,R@0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RNS
	MOVW R26,R@0
	ADIW R26,@1
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RNS
	MOVW R26,R@0
	ADIW R26,@1
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RNS
	MOVW R26,R@0
	ADIW R26,@1
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RON
	MOV  R26,R@0
	MOV  R27,R@1
	SUBI R26,LOW(-@2)
	SBCI R27,HIGH(-@2)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RON
	MOV  R26,R@0
	MOV  R27,R@1
	SUBI R26,LOW(-@2)
	SBCI R27,HIGH(-@2)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RON
	MOV  R26,R@0
	MOV  R27,R@1
	SUBI R26,LOW(-@2)
	SBCI R27,HIGH(-@2)
	CALL __PUTDP1
	.ENDM

	.MACRO __PUTB1RONS
	MOV  R26,R@0
	MOV  R27,R@1
	ADIW R26,@2
	ST   X,R30
	.ENDM

	.MACRO __PUTW1RONS
	MOV  R26,R@0
	MOV  R27,R@1
	ADIW R26,@2
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1RONS
	MOV  R26,R@0
	MOV  R27,R@1
	ADIW R26,@2
	CALL __PUTDP1
	.ENDM


	.MACRO __GETB1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R30,Z
	.ENDM

	.MACRO __GETB1HSX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R31,Z
	.ENDM

	.MACRO __GETW1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R0,Z+
	LD   R31,Z
	MOV  R30,R0
	.ENDM

	.MACRO __GETD1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R0,Z+
	LD   R1,Z+
	LD   R22,Z+
	LD   R23,Z
	MOVW R30,R0
	.ENDM

	.MACRO __GETB2SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R26,X
	.ENDM

	.MACRO __GETW2SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	.ENDM

	.MACRO __GETD2SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R1,X+
	LD   R24,X+
	LD   R25,X
	MOVW R26,R0
	.ENDM

	.MACRO __GETBRSX
	MOVW R30,R28
	SUBI R30,LOW(-@1)
	SBCI R31,HIGH(-@1)
	LD   R@0,Z
	.ENDM

	.MACRO __GETWRSX
	MOVW R30,R28
	SUBI R30,LOW(-@2)
	SBCI R31,HIGH(-@2)
	LD   R@0,Z+
	LD   R@1,Z
	.ENDM

	.MACRO __LSLW8SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	LD   R31,Z
	CLR  R30
	.ENDM

	.MACRO __PUTB1SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	ST   X+,R30
	ST   X+,R31
	ST   X+,R22
	ST   X,R23
	.ENDM

	.MACRO __CLRW1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	CLR  R0
	ST   Z+,R0
	ST   Z,R0
	.ENDM

	.MACRO __CLRD1SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	CLR  R0
	ST   Z+,R0
	ST   Z+,R0
	ST   Z+,R0
	ST   Z,R0
	.ENDM

	.MACRO __PUTB2SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z,R26
	.ENDM

	.MACRO __PUTW2SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z+,R26
	ST   Z,R27
	.ENDM

	.MACRO __PUTD2SX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z+,R26
	ST   Z+,R27
	ST   Z+,R24
	ST   Z,R25
	.ENDM

	.MACRO __PUTBSRX
	MOVW R30,R28
	SUBI R30,LOW(-@0)
	SBCI R31,HIGH(-@0)
	ST   Z,R@1
	.ENDM

	.MACRO __PUTWSRX
	MOVW R30,R28
	SUBI R30,LOW(-@2)
	SBCI R31,HIGH(-@2)
	ST   Z+,R@0
	ST   Z,R@1
	.ENDM

	.MACRO __PUTB1SNX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X,R30
	.ENDM

	.MACRO __PUTW1SNX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X,R31
	.ENDM

	.MACRO __PUTD1SNX
	MOVW R26,R28
	SUBI R26,LOW(-@0)
	SBCI R27,HIGH(-@0)
	LD   R0,X+
	LD   R27,X
	MOV  R26,R0
	SUBI R26,LOW(-@1)
	SBCI R27,HIGH(-@1)
	ST   X+,R30
	ST   X+,R31
	ST   X+,R22
	ST   X,R23
	.ENDM

	.MACRO __MULBRR
	MULS R@0,R@1
	MOV  R30,R0
	.ENDM

	.MACRO __MULBRRU
	MUL  R@0,R@1
	MOV  R30,R0
	.ENDM

	.CSEG
	.ORG 0

	.INCLUDE "main.vec"
	.INCLUDE "main.inc"

__RESET:
	CLI
	CLR  R30
	OUT  EECR,R30

;INTERRUPT VECTORS ARE PLACED
;AT THE START OF FLASH
	LDI  R31,1
	OUT  MCUCR,R31
	OUT  MCUCR,R30

;DISABLE WATCHDOG
	LDI  R31,0x18
	WDR
	IN   R26,MCUSR
	CBR  R26,8
	OUT  MCUSR,R26
	STS  WDTCSR,R31
	STS  WDTCSR,R30

;CLEAR R2-R14
	LDI  R24,13
	LDI  R26,2
	CLR  R27
__CLEAR_REG:
	ST   X+,R30
	DEC  R24
	BRNE __CLEAR_REG

;CLEAR SRAM
	LDI  R24,LOW(0x400)
	LDI  R25,HIGH(0x400)
	LDI  R26,LOW(0x100)
	LDI  R27,HIGH(0x100)
__CLEAR_SRAM:
	ST   X+,R30
	SBIW R24,1
	BRNE __CLEAR_SRAM

;GLOBAL VARIABLES INITIALIZATION
	LDI  R30,LOW(__GLOBAL_INI_TBL*2)
	LDI  R31,HIGH(__GLOBAL_INI_TBL*2)
__GLOBAL_INI_NEXT:
	LPM  R24,Z+
	LPM  R25,Z+
	SBIW R24,0
	BREQ __GLOBAL_INI_END
	LPM  R26,Z+
	LPM  R27,Z+
	LPM  R0,Z+
	LPM  R1,Z+
	MOVW R22,R30
	MOVW R30,R0
__GLOBAL_INI_LOOP:
	LPM  R0,Z+
	ST   X+,R0
	SBIW R24,1
	BRNE __GLOBAL_INI_LOOP
	MOVW R30,R22
	RJMP __GLOBAL_INI_NEXT
__GLOBAL_INI_END:

;GPIOR0-GPIOR2 INITIALIZATION
	LDI  R30,__GPIOR0_INIT
	OUT  GPIOR0,R30
	LDI  R30,__GPIOR1_INIT
	OUT  GPIOR1,R30
	LDI  R30,__GPIOR2_INIT
	OUT  GPIOR2,R30

;STACK POINTER INITIALIZATION
	LDI  R30,LOW(0x4FF)
	OUT  SPL,R30
	LDI  R30,HIGH(0x4FF)
	OUT  SPH,R30

;DATA STACK POINTER INITIALIZATION
	LDI  R28,LOW(0x200)
	LDI  R29,HIGH(0x200)

	JMP  _main

	.ESEG
	.ORG 0

	.DSEG
	.ORG 0x200
;       1 /*****************************************************
;       2 This program was produced by the
;       3 CodeWizardAVR V1.24.7d Standard
;       4 Automatic Program Generator
;       5 © Copyright 1998-2005 Pavel Haiduc, HP InfoTech s.r.l.
;       6 http://www.hpinfotech.com
;       7 e-mail:office@hpinfotech.com
;       8 
;       9 Project : Movieboard
;      10 Version : 
;      11 Date    : 2/18/2008
;      12 Author  : Randy Gamage
;      13 Company : Gamatronix
;      14 Comments: 
;      15 For MovieStuff - Roger Evans
;      16 
;      17 
;      18 Chip type           : ATmega168
;      19 Program type        : Application
;      20 Clock frequency     : 20.000000 MHz
;      21 Memory model        : Small
;      22 External SRAM size  : 0
;      23 Data Stack size     : 256
;      24 
;      25 Revision History:
;      26 3/7/2008 11:30AM Got working for light flashing use with Rev B board,
;      27                 saved as rev 2.
;      28 3/9/2008 12:40PM Refactored to allow different config files depending
;      29                 upon PCB board revision.  Saved as rev 3
;      30 3/15/2008 11:12AM Started reworking motor control to be scaled to time, so no matter
;      31                 what the PID update rate is, the gains should remain the same.   
;      32 3/16/2008 4:44PM Saved as version 4 - working well, just need to add bias values
;      33                 for each speed, maybe some auto-save feature to save bias to eeprom
;      34                 when the error stabilizes to zero.         
;      35 3/18/2008 8:53PM Fixed some problems with light flasher logic.  Light now is on when motor idle,
;      36                 dimming resolution is improved, and debounce has been reduced that should allow
;      37                 running at higher speeds.
;      38                 Got analog smoothing working, cleaned up light on/off logic
;      39                 To Do: Investigate 5V supply glitches and missing Light control pulses.
;      40                 Scope on the pot wiper and ground, set to 500mV sensitivity.
;      41                 Negative spikes are regular, at ~1.95kHz, asynchronous with LED output pulsing ???
;      42 3/20/2008 9:35PM Fixed the 5V spike issue- was caused by reading an ADC channel while that channel
;      43                 was configured as an output.  Apparently it's a bad thing to do.
;      44                 New problem: Motor control is missing timing pulses periodically. Need to find & fix.
;      45 3/22/2008 10:30AM Fixed it! Sensor pulse was lower voltage because it was connected to an unpowered
;      46                 Gamoto board, and that was dragging it down.     
;      47 3/26/2008 7:42PM Changed this code to the test code, for board verification by the contract manufacturer
;      48 /               Changed config reference to config_c                           
;      49 *****************************************************/
;      50 
;      51 #include <mega168.h>
;      52 #include <delay.h>
;      53 
;      54 #define TMR1FREQ _MCU_CLOCK_FREQUENCY_
;      55 #define TMR0FREQ _MCU_CLOCK_FREQUENCY_/8
;      56 #define PWMFREQ 15734
;      57 #define PWMRESOLUTION 1000
;      58 #define ADCRESOLUTION 1024
;      59 #define SYSTICKFREQ 10000  //10000 = 0.1ms ticks      
;      60 #define high 1
;      61 #define low 0
;      62 #define true 1
;      63 #define false 0    
;      64 #define intsoff #asm("cli")   //turn off interrupts
;      65 #define intson  #asm("sei")   //turn on interrupts
;      66 //#define REV_A_BOARD 1
;      67 //#define REV_B_BOARD 1
;      68 #define REV_C_BOARD 1
;      69 
;      70 //Fuses: Need to turn on 4V undervoltage fuse to protect FETS from under-voltage operation
;      71 
;      72 // Standard Input/Output functions
;      73 #include <stdio.h>
;      74 #include "serial.c"
;      75 //serial port routines
;      76 
;      77 #define RXB8 1
;      78 #define TXB8 0
;      79 #define UPE 2
;      80 #define OVR 3
;      81 #define FE 4
;      82 #define UDRE 5
;      83 #define RXC 7
;      84 
;      85 #define FRAMING_ERROR (1<<FE)
;      86 #define PARITY_ERROR (1<<UPE)
;      87 #define DATA_OVERRUN (1<<OVR)
;      88 #define DATA_REGISTER_EMPTY (1<<UDRE)
;      89 #define RX_COMPLETE (1<<RXC)
;      90 
;      91 // USART Receiver buffer
;      92 #define RX_BUFFER_SIZE0 8
;      93 char rx_buffer0[RX_BUFFER_SIZE0];
_rx_buffer0:
	.BYTE 0x8
;      94 
;      95 #if RX_BUFFER_SIZE0<256
;      96 unsigned char rx_wr_index0,rx_rd_index0,rx_counter0;
;      97 #else
;      98 unsigned int rx_wr_index0,rx_rd_index0,rx_counter0;
;      99 #endif
;     100 
;     101 // This flag is set on USART Receiver buffer overflow
;     102 bit rx_buffer_overflow0;
;     103 
;     104 // USART Receiver interrupt service routine
;     105 interrupt [USART_RXC] void usart_rx_isr(void)
;     106 {

	.CSEG
_usart_rx_isr:
	ST   -Y,R26
	ST   -Y,R27
	ST   -Y,R30
	IN   R30,SREG
	ST   -Y,R30
;     107 char status,data;
;     108 status=UCSR0A;
	ST   -Y,R17
	ST   -Y,R16
;	status -> R16
;	data -> R17
	LDS  R16,192
;     109 data=UDR0;
	LDS  R17,198
;     110 if ((status & (FRAMING_ERROR | PARITY_ERROR | DATA_OVERRUN))==0)
	MOV  R30,R16
	ANDI R30,LOW(0x1C)
	BRNE _0x3
;     111    {
;     112    rx_buffer0[rx_wr_index0]=data;
	MOV  R26,R2
	LDI  R27,0
	SUBI R26,LOW(-_rx_buffer0)
	SBCI R27,HIGH(-_rx_buffer0)
	ST   X,R17
;     113    if (++rx_wr_index0 == RX_BUFFER_SIZE0) rx_wr_index0=0;
	INC  R2
	LDI  R30,LOW(8)
	CP   R30,R2
	BRNE _0x4
	CLR  R2
;     114    if (++rx_counter0 == RX_BUFFER_SIZE0)
_0x4:
	INC  R4
	LDI  R30,LOW(8)
	CP   R30,R4
	BRNE _0x5
;     115       {
;     116       rx_counter0=0;
	CLR  R4
;     117       rx_buffer_overflow0=1;
	SBI  0x1E,0
;     118       };
_0x5:
;     119    };
_0x3:
;     120 }
	LD   R16,Y+
	LD   R17,Y+
	LD   R30,Y+
	OUT  SREG,R30
	LD   R30,Y+
	LD   R27,Y+
	LD   R26,Y+
	RETI
;     121 
;     122 #ifndef _DEBUG_TERMINAL_IO_
;     123 // Get a character from the USART Receiver buffer
;     124 #define _ALTERNATE_GETCHAR_
;     125 #pragma used+
;     126 char getchar(void)
;     127 {
_getchar:
;     128 char data;
;     129 while (rx_counter0==0);
	ST   -Y,R16
;	data -> R16
_0x6:
	TST  R4
	BREQ _0x6
;     130 data=rx_buffer0[rx_rd_index0];
	MOV  R30,R3
	LDI  R31,0
	SUBI R30,LOW(-_rx_buffer0)
	SBCI R31,HIGH(-_rx_buffer0)
	LD   R16,Z
;     131 if (++rx_rd_index0 == RX_BUFFER_SIZE0) rx_rd_index0=0;
	INC  R3
	LDI  R30,LOW(8)
	CP   R30,R3
	BRNE _0x9
	CLR  R3
;     132 #asm("cli")
_0x9:
	cli
;     133 --rx_counter0;
	DEC  R4
;     134 #asm("sei")
	sei
;     135 return data;
	MOV  R30,R16
	LD   R16,Y+
	RET
;     136 }
;     137 #pragma used-
;     138 #endif
;     139 #include "gamoto.c"
;     140 /*
;     141 Gamoto Class, to provide serial access to the Gamoto PID Motor Controller
;     142 More info on the Gamoto here: http://www.gamatronix.com
;     143 Written by: Randy Gamage
;     144 16-June-2005
;     145 Written in C++ using MS Visual Studio .NET 7.1
;     146 
;     147 DriveMode Set this property to the desired drive mode. Accepts a value of enum 
;     148 Gamoto.DriveModes  
;     149 
;     150 DriveModePower Set the Gamoto for power mode. Cancels any currently executing trajectories
;     151 or sets velocity mode to false if it is enabled.  
;     152 
;     153 */
;     154 #include "gamoto.h"

	.DSEG
_wBuffer:
	.BYTE 0x14
_rBuffer:
	.BYTE 0x14
;     155 
;     156 int Reset(){

	.CSEG
;     157 	return WriteReg(gxReset,1,0);
;     158 }
;     159 int FactoryReset(){
;     160 	return WriteReg(gxFactoryReset,1,0);
;     161 }
;     162 int SaveParams(){
;     163 	return WriteReg(gxSaveParams,1,0);
;     164 }
;     165 int SetHome(){
;     166 	return WriteReg(gxSetHome,1,0);
;     167 }
;     168 int setKp(int kp){
;     169    return WriteReg(gxKp,2,kp);
;     170 }
;     171 int setKi(int ki){
;     172    return WriteReg(gxKi,2,ki);
;     173 }
;     174 int setKd(int kd){
;     175    return WriteReg(gxKd,2,kd);
;     176 }
;     177 int setdS(int ds){
;     178    return WriteReg(gxdS,2,ds);
;     179 }
;     180 int setiL(int il){
;     181    return WriteReg(gxiL,2,il);
;     182 }
;     183 int setMode(int newMode){
;     184    /* set drive mode of Gamoto */
;     185    return WriteReg(gxMode,1,newMode);
;     186 }
;     187 int setsetPosition(int pos){
;     188 /* Writes to the set position of the motor. This value is used by the PID in absolute
;     189 mode to drive the motor to a particular absolute position. The set position is also updated
;     190 by some internal functions of the Gamoto board, see Gamoto documentation for full details.  */
;     191    return WriteReg(gxsetPosition,3,pos);
;     192 }
;     193 int setTrajectory(int traj){
;     194    return WriteReg(gxTrajectory,1,traj);
;     195 }
;     196 int setpwrLimit(int pl){
;     197    return WriteReg(gxpwrLimit,1,pl);
;     198 }
;     199 int setmPosition(int mp){
;     200    return WriteReg(gxmPosition,3,mp);
;     201 }
;     202 int setsetVelocity(int sv){
;     203    return WriteReg(gxsetVelocity,2,sv);
;     204 }
;     205 int setmPower(int mp){
_setmPower:
;     206    return WriteReg(gxmPower,1,mp);
	LDI  R30,LOW(60)
	LDI  R31,HIGH(60)
	ST   -Y,R31
	ST   -Y,R30
	LDI  R30,LOW(1)
	LDI  R31,HIGH(1)
	ST   -Y,R31
	ST   -Y,R30
	LDD  R30,Y+4
	LDD  R31,Y+4+1
	ST   -Y,R31
	ST   -Y,R30
	RCALL _WriteReg
	ADIW R28,2
	RET
;     207 }
;     208 int setTrajx(int tx,int profile){
;     209    return WriteReg(gxTrajx+7*profile,3,tx);
;     210 }
;     211 int setTrajv(int tv,int profile){
;     212    return WriteReg(gxTrajv+7*profile,2,tv);
;     213 }
;     214 int setTraja(int ta,int profile){
;     215    return WriteReg(gxTraja+7*profile,2,ta);
;     216 }
;     217 int getKp(){
;     218    return ReadReg(gxKp,2);
;     219 }
;     220 int getKi(){
;     221    return ReadReg(gxKi,2);
;     222 }
;     223 int getKd(){
;     224    return ReadReg(gxKd,2);
;     225 }
;     226 int getiL(){
;     227    return ReadReg(gxiL,2);
;     228 }
;     229 int getdS(){
;     230    return ReadReg(gxdS,1);
;     231 }
;     232 int getMode(){
;     233    return ReadReg(gxMode,1);
;     234 }
;     235 int getpwrLimit(){
;     236    return ReadReg(gxpwrLimit,1);
;     237 }
;     238 int getsetPosition(){
;     239    /* Reads the current value of the setPosition register in the Gamoto  */
;     240    return ReadReg(gxsetPosition,3);
;     241 }
;     242 int getmPosition(){
;     243    return ReadReg(gxmPosition,3);
;     244 }
;     245 int getsetVelocity(){
;     246    return ReadReg(gxsetVelocity,2);
;     247 }
;     248 int getmVelocity(){
;     249    return ReadReg(gxmVelocity,2);
;     250 }
;     251 int getTrajectory(){
;     252    return ReadReg(gxTrajectory,1);
;     253 }
;     254 int getmPower(){
;     255    return ReadReg(gxmPower,1);
;     256 }
;     257 int getVersion(){
;     258    return ReadReg(gxVersion,1);
;     259 }
;     260 int getmCurrent(){
;     261    return ReadReg(gxAnalog0,2);
;     262 }
;     263 int getAnalog0(){
;     264    return ReadReg(gxAnalog0,2);
;     265 }
;     266 int getAnalog1(){
;     267    return ReadReg(gxAnalog1,2);
;     268 }
;     269 int getAnalog2(){
;     270    return ReadReg(gxAnalog2,2);
;     271 }
;     272 int getAnalog3(){
;     273    return ReadReg(gxAnalog3,2);
;     274 }
;     275 int getAnalog4(){
;     276    return ReadReg(gxAnalog4,2);
;     277 }
;     278 
;     279 /**************************************************************/
;     280 /* Lower level register access routines  */
;     281 
;     282 int WriteReg(int RegAdr,int RegLen,int Regvalue)
;     283 {
_WriteReg:
;     284 	// Write to a Gamoto Register, given the register, length, and
;     285 	// data to write.  Check for an ACK response when done.
;     286 	// Returns 1 if ACK received,
;     287 	// Returns 0 if no ACK (timeout) or invalid ACK
;     288 
;     289    int bytes_read;
;     290    int i;
;     291 	// Build the message
;     292 	wBuffer[0]= gxHEADER;
	CALL __SAVELOCR4
;	RegAdr -> Y+8
;	RegLen -> Y+6
;	Regvalue -> Y+4
;	bytes_read -> R16,R17
;	i -> R18,R19
	LDI  R30,LOW(170)
	STS  _wBuffer,R30
;     293     wBuffer[1]= RegLen+1;
	LDD  R30,Y+6
	LDD  R31,Y+6+1
	ADIW R30,1
	__PUTB1MN _wBuffer,1
;     294 	wBuffer[2]= RegAdr;
	LDD  R30,Y+8
	__PUTB1MN _wBuffer,2
;     295 	for (i=0;i<RegLen;i++) {
	__GETWRN 18,19,0
_0xB:
	LDD  R30,Y+6
	LDD  R31,Y+6+1
	CP   R18,R30
	CPC  R19,R31
	BRGE _0xC
;     296 		wBuffer[3+i] = Regvalue % 256;
	MOVW R30,R18
	__ADDW1MN _wBuffer,3
	MOVW R22,R30
	LDD  R26,Y+4
	LDD  R27,Y+4+1
	LDI  R30,LOW(256)
	LDI  R31,HIGH(256)
	CALL __MODW21
	MOVW R26,R22
	ST   X,R30
;     297 		Regvalue = Regvalue >> 8;
	LDD  R30,Y+4
	LDD  R31,Y+4+1
	CALL __ASRW8
	STD  Y+4,R30
	STD  Y+4+1,R31
;     298 	}
	__ADDWRN 18,19,1
	RJMP _0xB
_0xC:
;     299 	// Add the checksum as the last byte
;     300 	wBuffer[3+RegLen]= CheckSum(wBuffer,3+RegLen);
	LDD  R30,Y+6
	LDD  R31,Y+6+1
	__ADDW1MN _wBuffer,3
	PUSH R31
	PUSH R30
	RCALL SUBOPT_0x0
	ADIW R30,3
	ST   -Y,R31
	ST   -Y,R30
	RCALL _CheckSum
	POP  R26
	POP  R27
	ST   X,R30
;     301 	// Send the command
;     302 	WriteBytes(wBuffer,RegLen+4);
	RCALL SUBOPT_0x0
	ADIW R30,4
	ST   -Y,R31
	ST   -Y,R30
	RCALL _WriteBytes
;     303 	// Receive the ACK response
;     304 	ReadBytes(rBuffer,&bytes_read,2);
	LDI  R30,LOW(_rBuffer)
	LDI  R31,HIGH(_rBuffer)
	ST   -Y,R31
	ST   -Y,R30
	IN   R30,SPL
	IN   R31,SPH
	SBIW R30,1
	ST   -Y,R31
	ST   -Y,R30
	PUSH R17
	PUSH R16
	LDI  R30,LOW(2)
	LDI  R31,HIGH(2)
	ST   -Y,R31
	ST   -Y,R30
	RCALL _ReadBytes
	POP  R16
	POP  R17
;     305 
;     306 	if (rBuffer[0]==ACK && rBuffer[1]==ACK)
	LDS  R26,_rBuffer
	CPI  R26,LOW(0x41)
	BRNE _0xE
	__GETB1MN _rBuffer,1
	CPI  R30,LOW(0x41)
	BREQ _0xF
_0xE:
	RJMP _0xD
_0xF:
;     307 		return 1;
	LDI  R30,LOW(1)
	LDI  R31,HIGH(1)
	RJMP _0xA5
;     308 	else
_0xD:
;     309 		return 0;
	LDI  R30,LOW(0)
	LDI  R31,HIGH(0)
;     310 }
_0xA5:
	CALL __LOADLOCR4
	ADIW R28,10
	RET
;     311 int ReadReg(int RegAdr, int RegLen) {
;     312 	// Reads a value from a Gamoto Register
;     313     int Regvalue=0;
;     314     int bytes_read;
;     315     int i;
;     316 	// Build the command
;     317 	wBuffer[0]= gxHEADER;
;	RegAdr -> Y+8
;	RegLen -> Y+6
;	Regvalue -> R16,R17
;	bytes_read -> R18,R19
;	i -> R20,R21
;     318     wBuffer[1]= gxWRITE;
;     319 	wBuffer[2]= RegAdr;
;     320 	wBuffer[3]= RegLen;
;     321 	wBuffer[4]= CheckSum(wBuffer,4);
;     322 	// Send the command
;     323 	WriteBytes(wBuffer,5);
;     324 	// Get the response
;     325 	ReadBytes(rBuffer,&bytes_read,RegLen+2);
;     326 	if (bytes_read>0){
;     327 		// We got a response - now parse the result
;     328 		for (i=0;i<RegLen;i++) {
;     329 			Regvalue += rBuffer[i+1] * (1<<(8*i));
;     330 		}
;     331 		// Handle negative case
;     332 		if (Regvalue >= (1<<(8*RegLen))/2)
;     333 			Regvalue -= 1<<(8*RegLen);
;     334 	}
;     335 	return Regvalue;
;     336 }
;     337 
;     338 byte CheckSum(byte* Buffer,int Len) {
_CheckSum:
;     339 	// Calculate the checksum of a read or write buffer
;     340 	byte sum=0;
;     341 	int i;
;     342 	for (i=1;i<Len;i++)
	CALL __SAVELOCR3
;	*Buffer -> Y+5
;	Len -> Y+3
;	sum -> R16
;	i -> R17,R18
	LDI  R16,0
	__GETWRN 17,18,1
_0x17:
	LDD  R30,Y+3
	LDD  R31,Y+3+1
	CP   R17,R30
	CPC  R18,R31
	BRGE _0x18
;     343 		sum += Buffer[i];
	__GETW1R 17,18
	LDD  R26,Y+5
	LDD  R27,Y+5+1
	ADD  R26,R30
	ADC  R27,R31
	LD   R30,X
	ADD  R16,R30
;     344 	return sum;
	__ADDWRN 17,18,1
	RJMP _0x17
_0x18:
	MOV  R30,R16
	CALL __LOADLOCR3
	ADIW R28,7
	RET
;     345 }
;     346 
;     347 void WriteBytes(char* buffer, int len)
;     348 {
_WriteBytes:
;     349     int i;
;     350     for (i=0; i<len; i++)
	ST   -Y,R17
	ST   -Y,R16
;	*buffer -> Y+4
;	len -> Y+2
;	i -> R16,R17
	__GETWRN 16,17,0
_0x1A:
	LDD  R30,Y+2
	LDD  R31,Y+2+1
	CP   R16,R30
	CPC  R17,R31
	BRGE _0x1B
;     351     {
;     352         putchar(buffer[i]);
	MOVW R30,R16
	LDD  R26,Y+4
	LDD  R27,Y+4+1
	ADD  R26,R30
	ADC  R27,R31
	LD   R30,X
	ST   -Y,R30
	RCALL _putchar
;     353     }
	__ADDWRN 16,17,1
	RJMP _0x1A
_0x1B:
;     354 }
	LDD  R17,Y+1
	LDD  R16,Y+0
	ADIW R28,6
	RET
;     355 
;     356 void ReadBytes(char* buffer, int* bytes_read, int len)
;     357 {
_ReadBytes:
;     358     int i;
;     359     *bytes_read=0;
	ST   -Y,R17
	ST   -Y,R16
;	*buffer -> Y+6
;	*bytes_read -> Y+4
;	len -> Y+2
;	i -> R16,R17
	LDD  R26,Y+4
	LDD  R27,Y+4+1
	LDI  R30,LOW(0)
	LDI  R31,HIGH(0)
	ST   X+,R30
	ST   X,R31
;     360     for (i=0; i<len; i++)
	__GETWRN 16,17,0
_0x1D:
	LDD  R30,Y+2
	LDD  R31,Y+2+1
	CP   R16,R30
	CPC  R17,R31
	BRGE _0x1E
;     361     {
;     362         buffer[i] = getchar();
	MOVW R30,R16
	LDD  R26,Y+6
	LDD  R27,Y+6+1
	ADD  R30,R26
	ADC  R31,R27
	PUSH R31
	PUSH R30
	RCALL _getchar
	POP  R26
	POP  R27
	ST   X,R30
;     363         *bytes_read++;
	LDD  R26,Y+4
	LDD  R27,Y+4+1
	LD   R30,X+
	LD   R31,X+
	STD  Y+4,R26
	STD  Y+4+1,R27
;     364     }
	__ADDWRN 16,17,1
	RJMP _0x1D
_0x1E:
;     365 }
	LDD  R17,Y+1
	LDD  R16,Y+0
	ADIW R28,8
	RET
;     366 
;     367 // Global variables here          
;     368     unsigned long SysTicks=0;           //Master timer counter, in units of 0.1ms    

	.DSEG
_SysTicks:
	.BYTE 0x4
;     369     int i,j;
;     370     long pwmfreq = PWMFREQ;
_pwmfreq:
	.BYTE 0x4
;     371     int PWMout1=0;
;     372     int PWMout2=512;
;     373     
;     374 //function prototypes    
;     375 void PWM1setduty(int duty);
;     376 void PWMinit();
;     377 unsigned int read_adc(unsigned char adc_input);
;     378 void PWMinit();
;     379 void PWM1setduty(int duty);
;     380 void PrintAnalogs();
;     381 void PrintDips();
;     382 void PrintD1D2();
;     383 
;     384 void main(void)
;     385 {

	.CSEG
_main:
;     386 // Declare your local variables here
;     387 #ifdef REV_A_BOARD
;     388     #include <config_revA.c>
;     389 #endif
;     390 #ifdef REV_B_BOARD                                      
;     391     #include <config_revB.c>
;     392 #endif
;     393 #ifdef REV_C_BOARD
;     394     #include <config_revC.c>
;     395 //Hardware configuration for Rev A boards
;     396 
;     397 // Crystal Oscillator division factor: 1
;     398 #pragma optsize-
;     399 CLKPR=0x80;
	LDI  R30,LOW(128)
	STS  97,R30
;     400 CLKPR=0x00;
	LDI  R30,LOW(0)
	STS  97,R30
;     401 #ifdef _OPTIMIZE_SIZE_
;     402 #pragma optsize+
;     403 #endif
;     404 
;     405 #define OUT 1
;     406 #define PULLUP 1
;     407 #define ALL_INPUTS 0
;     408 
;     409 // Input/Output Ports initialization
;     410 // Port B initialization
;     411 // Func7=In Func6=In Func5=In Func4=In Func3=In Func2=Out Func1=Out Func0=In 
;     412 // State7=T State6=T State5=T State4=T State3=T State2=0 State1=0 State0=T 
;     413 #define D2 PINB.0
;     414 #define PWM1_PIN PORTB.1
;     415 #define PWM2_PIN PORTB.2
;     416 PORTB = PULLUP<<0;
	LDI  R30,LOW(1)
	OUT  0x5,R30
;     417 DDRB =  OUT<<1 | OUT<<2;
	LDI  R30,LOW(6)
	OUT  0x4,R30
;     418 
;     419 // Port C initialization
;     420 // Func6=In Func5=In Func4=In Func3=In Func2=In Func1=In Func0=Out 
;     421 // State6=T State5=T State4=P State3=T State2=T State1=T State0=T 
;     422 #define OUT1 PORTC.3
;     423 #define DIP1 PINC.4
;     424 #define DIP2 PINC.5
;     425 PORTC = PULLUP<<4 | PULLUP<<5;
	LDI  R30,LOW(48)
	OUT  0x8,R30
;     426 DDRC = OUT<<3;
	LDI  R30,LOW(8)
	OUT  0x7,R30
;     427 
;     428 // Port D initialization
;     429 // Func7=In Func6=In Func5=In Func4=In Func3=Out Func2=In Func1=In Func0=In 
;     430 // State7=P State6=T State5=P State4=P State3=0 State2=T State1=T State0=T 
;     431 #define SHUTTERPIN PIND.2
;     432 #define D1 PIND.2
;     433 #define DIP3 PIND.4
;     434 #define DIP4 PIND.5
;     435 #define OUT2 PORTD.6
;     436 #define DIP5 PIND.7
;     437 PORTD = PULLUP << 0 | PULLUP<<4 | PULLUP<<5 | PULLUP<<7;
	LDI  R30,LOW(177)
	OUT  0xB,R30
;     438 DDRD = OUT<<6;
	LDI  R30,LOW(64)
	OUT  0xA,R30
;     439 
;     440 // Timer/Counter 0 initialization
;     441 // Clock source: System Clock
;     442 // Clock value: 2500.000 kHz
;     443 // Mode: CTC top=OCR0A
;     444 // OC0A output: Disconnected
;     445 // OC0B output: Disconnected
;     446 TCCR0A=0x02;
	LDI  R30,LOW(2)
	OUT  0x24,R30
;     447 TCCR0B=0x02;
	OUT  0x25,R30
;     448 TCNT0=0x00;
	LDI  R30,LOW(0)
	OUT  0x26,R30
;     449 OCR0A=0xF9;  //2,500,000 / 0xF9 = 10kHz
	LDI  R30,LOW(249)
	OUT  0x27,R30
;     450 OCR0B=0x00;
	LDI  R30,LOW(0)
	OUT  0x28,R30
;     451 
;     452 // Timer/Counter 1 initialization
;     453 // Clock source: System Clock
;     454 // Clock value: 20000.000 kHz
;     455 // Mode: Fast PWM top=ICR1
;     456 // OC1A output: Non-Inv.
;     457 // OC1B output: Non-Inv.
;     458 // Noise Canceler: Off
;     459 // Input Capture on Falling Edge
;     460 // Timer 1 Overflow Interrupt: Off
;     461 // Input Capture Interrupt: Off
;     462 // Compare A Match Interrupt: Off
;     463 // Compare B Match Interrupt: Off
;     464 TCCR1A=0xA2;
	LDI  R30,LOW(162)
	STS  128,R30
;     465 TCCR1B=0x19;
	LDI  R30,LOW(25)
	STS  129,R30
;     466 TCNT1H=0x00;
	LDI  R30,LOW(0)
	STS  133,R30
;     467 TCNT1L=0x00;
	STS  132,R30
;     468 ICR1H=0x00;
	STS  135,R30
;     469 ICR1L=0x00;
	STS  134,R30
;     470 OCR1AH=0x00;
	STS  137,R30
;     471 OCR1AL=0x00;
	STS  136,R30
;     472 OCR1BH=0x00;
	STS  139,R30
;     473 OCR1BL=0x00;
	STS  138,R30
;     474 
;     475 // Timer/Counter 2 initialization
;     476 // Clock source: System Clock
;     477 // Clock value: Timer 2 Stopped
;     478 // Mode: Normal top=FFh
;     479 // OC2A output: Disconnected
;     480 // OC2B output: Disconnected
;     481 ASSR=0x00;
	STS  182,R30
;     482 TCCR2A=0x00;
	STS  176,R30
;     483 TCCR2B=0x00;
	STS  177,R30
;     484 TCNT2=0x00;
	STS  178,R30
;     485 OCR2A=0x00;
	STS  179,R30
;     486 OCR2B=0x00;
	STS  180,R30
;     487 
;     488 // External Interrupt(s) initialization
;     489 // INT0: On
;     490 // INT0 Mode: Any change
;     491 // INT1: Off
;     492 // Interrupt on any change on pins PCINT0-7: Off
;     493 // Interrupt on any change on pins PCINT8-14: Off
;     494 // Interrupt on any change on pins PCINT16-23: Off
;     495 EICRA=0x01;
	LDI  R30,LOW(1)
	STS  105,R30
;     496 EIMSK=0x01;
	OUT  0x1D,R30
;     497 EIFR=0x01;
	OUT  0x1C,R30
;     498 PCICR=0x00;
	LDI  R30,LOW(0)
	STS  104,R30
;     499 
;     500 
;     501 // Timer/Counter 0 Interrupt(s) initialization
;     502 TIMSK0=0x02;
	LDI  R30,LOW(2)
	STS  110,R30
;     503 // Timer/Counter 1 Interrupt(s) initialization
;     504 TIMSK1=0x00;
	LDI  R30,LOW(0)
	STS  111,R30
;     505 // Timer/Counter 2 Interrupt(s) initialization
;     506 TIMSK2=0x00;
	STS  112,R30
;     507 
;     508 // USART initialization
;     509 // Communication Parameters: 8 Data, 1 Stop, No Parity
;     510 // USART Receiver: On
;     511 // USART Transmitter: On
;     512 // USART0 Mode: Asynchronous
;     513 // USART Baud rate: 19200
;     514 //for 20Mhz:
;     515 UCSR0A=0x00;
	STS  192,R30
;     516 UCSR0B=0x98;
	LDI  R30,LOW(152)
	STS  193,R30
;     517 UCSR0C=0x06;
	LDI  R30,LOW(6)
	STS  194,R30
;     518 UBRR0H=0x00;
	LDI  R30,LOW(0)
	STS  197,R30
;     519 //UBRR0L=0x40; //19200 baud
;     520 UBRR0L=0x0A; //115200 baud
	LDI  R30,LOW(10)
	STS  196,R30
;     521 //for 8Mhz:
;     522 //UCSR0A=0x00;
;     523 //UCSR0B=0x98;
;     524 //UCSR0C=0x06;
;     525 //UBRR0H=0x00;
;     526 //UBRR0L=0x19;
;     527 
;     528 // Analog Comparator initialization
;     529 // Analog Comparator: Off
;     530 // Analog Comparator Input Capture by Timer/Counter 1: Off
;     531 ACSR=0x80;
	LDI  R30,LOW(128)
	OUT  0x30,R30
;     532 ADCSRB=0x00;
	LDI  R30,LOW(0)
	STS  123,R30
;     533 
;     534 // ADC initialization
;     535 // ADC Clock frequency: 156.250 kHz
;     536 // ADC Voltage Reference: AVCC pin
;     537 // ADC Auto Trigger Source: None
;     538 // Digital input buffers on ADC0: On, ADC1: On, ADC2: On, ADC3: On
;     539 // ADC4: On, ADC5: On
;     540 #define ADC_VREF_TYPE 0x40
;     541 DIDR0=0x00;
	STS  126,R30
;     542 ADMUX=ADC_VREF_TYPE;
	LDI  R30,LOW(64)
	STS  124,R30
;     543 ADCSRA=0x87;
	LDI  R30,LOW(135)
	STS  122,R30
;     544 #define ADC_DIMMER 0       //adc channel used to set light brightness
;     545 #define ADC_PHASEDELAY 1   //adc channel used to set phase delay
;     546 //Define analog channels according to analog pin labeling on PCB
;     547 #define ANALOG1 0
;     548 #define ANALOG2 1
;     549 #define ANALOG3 2
;     550 #define ANALOG4 7
;     551 #endif
;     552     i=0;
	CLR  R5
	CLR  R6
;     553     j=0;
	CLR  R7
	CLR  R8
;     554 
;     555     TCCR1A=0;
	LDI  R30,LOW(0)
	STS  128,R30
;     556     
;     557 // Global enable interrupts
;     558 #asm("sei")
	sei
;     559 
;     560 //simulator code 
;     561 #define PULSE_OUT PORTC.4
;     562 DDRC |= OUT<<4;  //make it an output pin
	SBI  0x7,4
;     563 TCCR0A=0;
	LDI  R30,LOW(0)
	OUT  0x24,R30
;     564 TCCR0B=0;
	OUT  0x25,R30
;     565 TIMSK0=0;
	STS  110,R30
;     566 
;     567 while (0) {
;     568     PULSE_OUT=low;
;     569     delay_us(5);
;     570     PULSE_OUT=high;
;     571     delay_us(59);
;     572 }
;     573 //end simulator code
;     574 while (1) {
_0x24:
;     575     //gamoto client test
;     576 //     setKp(456);
;     577 //     i = getMode();
;     578      OUT1 = low;
	CBI  0x8,3
;     579      OUT2 = high;
	SBI  0xB,6
;     580      setmPower(500);
	LDI  R30,LOW(500)
	LDI  R31,HIGH(500)
	ST   -Y,R31
	ST   -Y,R30
	RCALL _setmPower
;     581      OUT1 = high;
	SBI  0x8,3
;     582      OUT2 = low;
	CBI  0xB,6
;     583      setmPower(700);
	LDI  R30,LOW(700)
	LDI  R31,HIGH(700)
	ST   -Y,R31
	ST   -Y,R30
	RCALL _setmPower
;     584 //     delay_ms(500);
;     585 //     i = getMode();
;     586 //     setmPower(500);
;     587 //     setmPower(700);
;     588 //     delay_ms(500);
;     589 }
	RJMP _0x24
;     590 //board test mode
;     591 while (0) {
;     592     
;     593      //flash SSR LEDs alternately
;     594      delay_ms(500);
;     595      OUT1 = low;
;     596      OUT2 = high;
;     597      PWM1_PIN = low;
;     598      PWM2_PIN = low;
;     599      PrintAnalogs();
;     600      PrintDips();
;     601      PrintD1D2();
;     602      delay_ms(500);
;     603      OUT1 = high;
;     604      OUT2 = low;
;     605      PWM1_PIN = low;
;     606      PWM2_PIN = low;
;     607      PrintAnalogs();
;     608      PrintDips();
;     609      PrintD1D2();
;     610      delay_ms(500);
;     611      PWM1_PIN = high;
;     612      PWM2_PIN = low;
;     613      OUT1 = high;
;     614      OUT2 = high;
;     615      PrintAnalogs();
;     616      PrintDips();
;     617      PrintD1D2();
;     618      delay_ms(500);
;     619      PWM2_PIN = high;     
;     620      PWM1_PIN = low;     
;     621      OUT1 = high;
;     622      OUT2 = high;
;     623      PrintAnalogs();
;     624      PrintDips();
;     625      PrintD1D2();
;     626      }          
;     627 }
_0x2A:
	RJMP _0x2A
;     628 void PrintD1D2(){
_PrintD1D2:
;     629     unsigned char d;
;     630     d = (D1 << 1) | D2;
	ST   -Y,R16
;	d -> R16
	LDI  R30,0
	SBIC 0x9,2
	LDI  R30,1
	LSL  R30
	MOV  R26,R30
	LDI  R30,0
	SBIC 0x3,0
	LDI  R30,1
	RCALL SUBOPT_0x1
;     631     switch (d){
;     632         case 0b11:
	CPI  R30,LOW(0x3)
	BRNE _0x2E
;     633             printf("D1: Open / D2: Open");
	__POINTW1FN _0,0
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RCALL _printf
	ADIW R28,2
;     634             break;
	RJMP _0x2D
;     635         case 0b10:
_0x2E:
	CPI  R30,LOW(0x2)
	BRNE _0x2F
;     636             printf("D1: Open / D2: Shorted");
	__POINTW1FN _0,20
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RCALL _printf
	ADIW R28,2
;     637             break;
	RJMP _0x2D
;     638         case 0b01:
_0x2F:
	CPI  R30,LOW(0x1)
	BRNE _0x30
;     639             printf("D1: Shorted / D2: Open");
	__POINTW1FN _0,43
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RCALL _printf
	ADIW R28,2
;     640             break;
	RJMP _0x2D
;     641         case 0b00:
_0x30:
	CPI  R30,0
	BRNE _0x32
;     642             printf("D1: Shorted / D2: Shorted");
	__POINTW1FN _0,66
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RCALL _printf
	ADIW R28,2
;     643             break;
;     644         default:
_0x32:
;     645     }
_0x2D:
;     646     printf("\n\r");
	__POINTW1FN _0,92
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RCALL _printf
	ADIW R28,2
;     647 }
	RJMP _0xA4
;     648 void PrintDips(){
_PrintDips:
;     649     unsigned char dips;
;     650     dips = DIP1<<4 | DIP2<<3 | DIP3<<2 | DIP4<<1 | DIP5;
	ST   -Y,R16
;	dips -> R16
	LDI  R30,0
	SBIC 0x6,4
	LDI  R30,1
	SWAP R30
	ANDI R30,0xF0
	MOV  R26,R30
	LDI  R30,0
	SBIC 0x6,5
	LDI  R30,1
	LSL  R30
	LSL  R30
	LSL  R30
	OR   R30,R26
	MOV  R26,R30
	LDI  R30,0
	SBIC 0x9,4
	LDI  R30,1
	LSL  R30
	LSL  R30
	OR   R30,R26
	MOV  R26,R30
	LDI  R30,0
	SBIC 0x9,5
	LDI  R30,1
	LSL  R30
	OR   R30,R26
	MOV  R26,R30
	LDI  R30,0
	SBIC 0x9,7
	LDI  R30,1
	RCALL SUBOPT_0x1
;     651     dips = ~dips & 0b00011111; 
	COM  R30
	ANDI R30,LOW(0x1F)
	MOV  R16,R30
;     652     switch (dips){
	MOV  R30,R16
;     653         case 0b00000 : 
	CPI  R30,0
	BRNE _0x36
;     654             printf("DIPSWITCHES: 00000  ");
	__POINTW1FN _0,95
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RJMP _0xA6
;     655             break;
;     656         case 0b10000 :
_0x36:
	CPI  R30,LOW(0x10)
	BRNE _0x37
;     657             printf("DIPSWITCHES: 10000  ");
	__POINTW1FN _0,116
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RJMP _0xA6
;     658             break;
;     659         case 0b01000 :
_0x37:
	CPI  R30,LOW(0x8)
	BRNE _0x38
;     660             printf("DIPSWITCHES: 01000  ");
	__POINTW1FN _0,137
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RJMP _0xA6
;     661             break;
;     662         case 0b00100 :
_0x38:
	CPI  R30,LOW(0x4)
	BRNE _0x39
;     663             printf("DIPSWITCHES: 00100  ");
	__POINTW1FN _0,158
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RJMP _0xA6
;     664             break;
;     665         case 0b00010 :
_0x39:
	CPI  R30,LOW(0x2)
	BRNE _0x3A
;     666             printf("DIPSWITCHES: 00010  ");
	__POINTW1FN _0,179
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RJMP _0xA6
;     667             break;
;     668         case 0b00001 :
_0x3A:
	CPI  R30,LOW(0x1)
	BRNE _0x3C
;     669             printf("DIPSWITCHES: 00001  ");
	__POINTW1FN _0,200
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
	RJMP _0xA6
;     670             break;
;     671         default :
_0x3C:
;     672             printf("DIPSWITCHES: INVALID  ");
	__POINTW1FN _0,221
	ST   -Y,R31
	ST   -Y,R30
	LDI  R24,0
_0xA6:
	RCALL _printf
	ADIW R28,2
;     673     }
;     674 }
_0xA4:
	LD   R16,Y+
	RET
;     675 
;     676 void PrintAnalogs(){
_PrintAnalogs:
;     677      //show analog readouts through serial port
;     678      printf("AN1/AN2/AN3/AN4: %d/%d/%d/%d   ",read_adc(ANALOG1),read_adc(ANALOG2),read_adc(ANALOG3),read_adc(ANALOG4));
	__POINTW1FN _0,244
	ST   -Y,R31
	ST   -Y,R30
	LDI  R30,LOW(0)
	RCALL SUBOPT_0x2
	LDI  R30,LOW(1)
	RCALL SUBOPT_0x2
	LDI  R30,LOW(2)
	RCALL SUBOPT_0x2
	LDI  R30,LOW(7)
	RCALL SUBOPT_0x2
	LDI  R24,16
	RCALL _printf
	ADIW R28,18
;     679      }
	RET
;     680 
;     681 // External Interrupt 0 service routine
;     682 interrupt [EXT_INT0] void ext_int0_isr(void) 
;     683 {
_ext_int0_isr:
;     684 
;     685 }
	RETI
;     686 
;     687 // Timer 0 output compare A interrupt service routine
;     688 interrupt [TIM0_COMPA] void timer0_compa_isr(void)
;     689 {
_timer0_compa_isr:
	ST   -Y,R22
	ST   -Y,R23
	ST   -Y,R30
	ST   -Y,R31
	IN   R30,SREG
	ST   -Y,R30
;     690     SysTicks++;
	LDS  R30,_SysTicks
	LDS  R31,_SysTicks+1
	LDS  R22,_SysTicks+2
	LDS  R23,_SysTicks+3
	__SUBD1N -1
	STS  _SysTicks,R30
	STS  _SysTicks+1,R31
	STS  _SysTicks+2,R22
	STS  _SysTicks+3,R23
;     691 }
	LD   R30,Y+
	OUT  SREG,R30
	LD   R31,Y+
	LD   R30,Y+
	LD   R23,Y+
	LD   R22,Y+
	RETI
;     692 
;     693 // Read the AD conversion result
;     694 unsigned int read_adc(unsigned char adc_input)
;     695 {
_read_adc:
;     696     ADMUX=adc_input|ADC_VREF_TYPE;
	LD   R30,Y
	ORI  R30,0x40
	STS  124,R30
;     697     // Start the AD conversion
;     698     ADCSRA|=0x40;
	LDS  R30,122
	ORI  R30,0x40
	STS  122,R30
;     699     // Wait for the AD conversion to complete
;     700     while ((ADCSRA & 0x10)==0);
_0x3D:
	LDS  R30,122
	ANDI R30,LOW(0x10)
	BREQ _0x3D
;     701     ADCSRA|=0x10;
	LDS  R30,122
	ORI  R30,0x10
	STS  122,R30
;     702     return ADCW;
	LDS  R30,120
	LDS  R31,120+1
	RJMP _0xA3
;     703 }
;     704 
;     705 void PWMinit()
;     706 {
;     707     //Initialize hardware PWM
;     708     int period;
;     709     period = TMR1FREQ/pwmfreq-1;
;	period -> R16,R17
;     710     intsoff
;     711     //set PWM base frequency
;     712     ICR1H = period>>8;  
;     713     ICR1L = period % 256;
;     714     //set duty to 50%
;     715     OCR1AH = (period/2)>>8;  //0x03
;     716     OCR1AL = (period/2) % 256;   //0xE7
;     717     intson
;     718 }
;     719 void PWM1setduty(int duty)
;     720 {
;     721     //set PWM duty cycle, from 0 to PWMRESOLUTION
;     722     long period;
;     723     if (duty>PWMRESOLUTION) duty=PWMRESOLUTION;
;	duty -> Y+4
;	period -> Y+0
;     724     if (duty<0) duty = 0;
;     725     period = TMR1FREQ/pwmfreq-1;
;     726     period = (duty*period)/PWMRESOLUTION;
;     727     intsoff
;     728     OCR1AH = period>>8; 
;     729     OCR1AL = period % 256;  
;     730     intson
;     731 }  

_putchar:
_0x42:
	LDS  R30,192
	ANDI R30,LOW(0x20)
	BREQ _0x42
	LD   R30,Y
	STS  198,R30
_0xA3:
	ADIW R28,1
	RET
__put_G2:
	LD   R26,Y
	LDD  R27,Y+1
	CALL __GETW1P
	SBIW R30,0
	BREQ _0x45
	CALL __GETW1P
	ADIW R30,1
	ST   X+,R30
	ST   X,R31
	SBIW R30,1
	LDD  R26,Y+2
	STD  Z+0,R26
	RJMP _0x46
_0x45:
	LDD  R30,Y+2
	ST   -Y,R30
	RCALL _putchar
_0x46:
	ADIW R28,3
	RET
__print_G2:
	SBIW R28,6
	CALL __SAVELOCR6
	LDI  R16,0
_0x47:
	LDD  R30,Y+16
	LDD  R31,Y+16+1
	ADIW R30,1
	STD  Y+16,R30
	STD  Y+16+1,R31
	SBIW R30,1
	LPM  R30,Z
	MOV  R19,R30
	CPI  R30,0
	BRNE PC+3
	JMP _0x49
	MOV  R30,R16
	CPI  R30,0
	BRNE _0x4D
	CPI  R19,37
	BRNE _0x4E
	LDI  R16,LOW(1)
	RJMP _0x4F
_0x4E:
	RCALL SUBOPT_0x3
_0x4F:
	RJMP _0x4C
_0x4D:
	CPI  R30,LOW(0x1)
	BRNE _0x50
	CPI  R19,37
	BRNE _0x51
	RCALL SUBOPT_0x3
	LDI  R16,LOW(0)
	RJMP _0x4C
_0x51:
	LDI  R16,LOW(2)
	LDI  R21,LOW(0)
	LDI  R17,LOW(0)
	CPI  R19,45
	BRNE _0x52
	LDI  R17,LOW(1)
	RJMP _0x4C
_0x52:
	CPI  R19,43
	BRNE _0x53
	LDI  R21,LOW(43)
	RJMP _0x4C
_0x53:
	CPI  R19,32
	BRNE _0x54
	LDI  R21,LOW(32)
	RJMP _0x4C
_0x54:
	RJMP _0x55
_0x50:
	CPI  R30,LOW(0x2)
	BRNE _0x56
_0x55:
	LDI  R20,LOW(0)
	LDI  R16,LOW(3)
	CPI  R19,48
	BRNE _0x57
	ORI  R17,LOW(128)
	RJMP _0x4C
_0x57:
	RJMP _0x58
_0x56:
	CPI  R30,LOW(0x3)
	BREQ PC+3
	JMP _0x4C
_0x58:
	CPI  R19,48
	BRLO _0x5B
	CPI  R19,58
	BRLO _0x5C
_0x5B:
	RJMP _0x5A
_0x5C:
	MOV  R26,R20
	LDI  R30,LOW(10)
	MUL  R30,R26
	MOV  R30,R0
	MOV  R20,R30
	MOV  R30,R19
	SUBI R30,LOW(48)
	ADD  R20,R30
	RJMP _0x4C
_0x5A:
	MOV  R30,R19
	CPI  R30,LOW(0x63)
	BRNE _0x60
	RCALL SUBOPT_0x4
	LD   R30,X
	RCALL SUBOPT_0x5
	RJMP _0x61
_0x60:
	CPI  R30,LOW(0x73)
	BRNE _0x63
	RCALL SUBOPT_0x4
	RCALL SUBOPT_0x6
	CALL _strlen
	MOV  R16,R30
	RJMP _0x64
_0x63:
	CPI  R30,LOW(0x70)
	BRNE _0x66
	RCALL SUBOPT_0x4
	RCALL SUBOPT_0x6
	CALL _strlenf
	MOV  R16,R30
	ORI  R17,LOW(8)
_0x64:
	ORI  R17,LOW(2)
	ANDI R17,LOW(127)
	LDI  R18,LOW(0)
	RJMP _0x67
_0x66:
	CPI  R30,LOW(0x64)
	BREQ _0x6A
	CPI  R30,LOW(0x69)
	BRNE _0x6B
_0x6A:
	ORI  R17,LOW(4)
	RJMP _0x6C
_0x6B:
	CPI  R30,LOW(0x75)
	BRNE _0x6D
_0x6C:
	LDI  R30,LOW(_tbl10_G2*2)
	LDI  R31,HIGH(_tbl10_G2*2)
	STD  Y+6,R30
	STD  Y+6+1,R31
	LDI  R16,LOW(5)
	RJMP _0x6E
_0x6D:
	CPI  R30,LOW(0x58)
	BRNE _0x70
	ORI  R17,LOW(8)
	RJMP _0x71
_0x70:
	CPI  R30,LOW(0x78)
	BREQ PC+3
	JMP _0xA2
_0x71:
	LDI  R30,LOW(_tbl16_G2*2)
	LDI  R31,HIGH(_tbl16_G2*2)
	STD  Y+6,R30
	STD  Y+6+1,R31
	LDI  R16,LOW(4)
_0x6E:
	SBRS R17,2
	RJMP _0x73
	RCALL SUBOPT_0x4
	CALL __GETW1P
	STD  Y+10,R30
	STD  Y+10+1,R31
	LDD  R26,Y+10
	LDD  R27,Y+10+1
	SBIW R26,0
	BRGE _0x74
	CALL __ANEGW1
	STD  Y+10,R30
	STD  Y+10+1,R31
	LDI  R21,LOW(45)
_0x74:
	CPI  R21,0
	BREQ _0x75
	SUBI R16,-LOW(1)
	RJMP _0x76
_0x75:
	ANDI R17,LOW(251)
_0x76:
	RJMP _0x77
_0x73:
	RCALL SUBOPT_0x4
	CALL __GETW1P
	STD  Y+10,R30
	STD  Y+10+1,R31
_0x77:
_0x67:
	SBRC R17,0
	RJMP _0x78
_0x79:
	CP   R16,R20
	BRSH _0x7B
	SBRS R17,7
	RJMP _0x7C
	SBRS R17,2
	RJMP _0x7D
	ANDI R17,LOW(251)
	MOV  R19,R21
	SUBI R16,LOW(1)
	RJMP _0x7E
_0x7D:
	LDI  R19,LOW(48)
_0x7E:
	RJMP _0x7F
_0x7C:
	LDI  R19,LOW(32)
_0x7F:
	RCALL SUBOPT_0x3
	SUBI R20,LOW(1)
	RJMP _0x79
_0x7B:
_0x78:
	MOV  R18,R16
	SBRS R17,1
	RJMP _0x80
_0x81:
	CPI  R18,0
	BREQ _0x83
	SBRS R17,3
	RJMP _0x84
	LDD  R30,Y+6
	LDD  R31,Y+6+1
	ADIW R30,1
	STD  Y+6,R30
	STD  Y+6+1,R31
	SBIW R30,1
	LPM  R30,Z
	RJMP _0xA7
_0x84:
	LDD  R26,Y+6
	LDD  R27,Y+6+1
	LD   R30,X+
	STD  Y+6,R26
	STD  Y+6+1,R27
_0xA7:
	ST   -Y,R30
	RCALL SUBOPT_0x7
	CPI  R20,0
	BREQ _0x86
	SUBI R20,LOW(1)
_0x86:
	SUBI R18,LOW(1)
	RJMP _0x81
_0x83:
	RJMP _0x87
_0x80:
_0x89:
	LDI  R19,LOW(48)
	LDD  R30,Y+6
	LDD  R31,Y+6+1
	ADIW R30,2
	STD  Y+6,R30
	STD  Y+6+1,R31
	SBIW R30,2
	CALL __GETW1PF
	STD  Y+8,R30
	STD  Y+8+1,R31
_0x8B:
	LDD  R30,Y+8
	LDD  R31,Y+8+1
	LDD  R26,Y+10
	LDD  R27,Y+10+1
	CP   R26,R30
	CPC  R27,R31
	BRLO _0x8D
	SUBI R19,-LOW(1)
	LDD  R26,Y+8
	LDD  R27,Y+8+1
	LDD  R30,Y+10
	LDD  R31,Y+10+1
	SUB  R30,R26
	SBC  R31,R27
	STD  Y+10,R30
	STD  Y+10+1,R31
	RJMP _0x8B
_0x8D:
	CPI  R19,58
	BRLO _0x8E
	SBRS R17,3
	RJMP _0x8F
	SUBI R19,-LOW(7)
	RJMP _0x90
_0x8F:
	SUBI R19,-LOW(39)
_0x90:
_0x8E:
	SBRC R17,4
	RJMP _0x92
	CPI  R19,49
	BRSH _0x94
	LDD  R26,Y+8
	LDD  R27,Y+8+1
	SBIW R26,1
	BRNE _0x93
_0x94:
	ORI  R17,LOW(16)
	RJMP _0x96
_0x93:
	CP   R20,R18
	BRLO _0x98
	SBRS R17,0
	RJMP _0x99
_0x98:
	RJMP _0x97
_0x99:
	LDI  R19,LOW(32)
	SBRS R17,7
	RJMP _0x9A
	LDI  R19,LOW(48)
	ORI  R17,LOW(16)
_0x96:
	SBRS R17,2
	RJMP _0x9B
	ANDI R17,LOW(251)
	ST   -Y,R21
	RCALL SUBOPT_0x7
	CPI  R20,0
	BREQ _0x9C
	SUBI R20,LOW(1)
_0x9C:
_0x9B:
_0x9A:
_0x92:
	RCALL SUBOPT_0x3
	CPI  R20,0
	BREQ _0x9D
	SUBI R20,LOW(1)
_0x9D:
_0x97:
	SUBI R18,LOW(1)
	LDD  R26,Y+8
	LDD  R27,Y+8+1
	SBIW R26,2
	BRLO _0x8A
	RJMP _0x89
_0x8A:
_0x87:
	SBRS R17,0
	RJMP _0x9E
_0x9F:
	CPI  R20,0
	BREQ _0xA1
	SUBI R20,LOW(1)
	LDI  R30,LOW(32)
	RCALL SUBOPT_0x5
	RJMP _0x9F
_0xA1:
_0x9E:
_0xA2:
_0x61:
	LDI  R16,LOW(0)
_0x4C:
	RJMP _0x47
_0x49:
	CALL __LOADLOCR6
	ADIW R28,18
	RET
_printf:
	PUSH R15
	MOV  R15,R24
	SBIW R28,2
	ST   -Y,R17
	ST   -Y,R16
	MOVW R26,R28
	CALL __ADDW2R15
	MOVW R16,R26
	LDI  R30,0
	STD  Y+2,R30
	STD  Y+2+1,R30
	MOVW R26,R28
	ADIW R26,4
	CALL __ADDW2R15
	CALL __GETW1P
	ST   -Y,R31
	ST   -Y,R30
	ST   -Y,R17
	ST   -Y,R16
	MOVW R30,R28
	ADIW R30,6
	ST   -Y,R31
	ST   -Y,R30
	RCALL __print_G2
	LDD  R17,Y+1
	LDD  R16,Y+0
	ADIW R28,4
	POP  R15
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 2 TIMES
SUBOPT_0x0:
	LDI  R30,LOW(_wBuffer)
	LDI  R31,HIGH(_wBuffer)
	ST   -Y,R31
	ST   -Y,R30
	LDD  R30,Y+8
	LDD  R31,Y+8+1
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 2 TIMES
SUBOPT_0x1:
	OR   R30,R26
	MOV  R16,R30
	MOV  R30,R16
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 4 TIMES
SUBOPT_0x2:
	ST   -Y,R30
	RCALL _read_adc
	CLR  R22
	CLR  R23
	CALL __PUTPARD1
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 4 TIMES
SUBOPT_0x3:
	ST   -Y,R19
	LDD  R30,Y+13
	LDD  R31,Y+13+1
	ST   -Y,R31
	ST   -Y,R30
	RJMP __put_G2

;OPTIMIZER ADDED SUBROUTINE, CALLED 5 TIMES
SUBOPT_0x4:
	LDD  R26,Y+14
	LDD  R27,Y+14+1
	SBIW R26,4
	STD  Y+14,R26
	STD  Y+14+1,R27
	ADIW R26,4
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 2 TIMES
SUBOPT_0x5:
	ST   -Y,R30
	LDD  R30,Y+13
	LDD  R31,Y+13+1
	ST   -Y,R31
	ST   -Y,R30
	RJMP __put_G2

;OPTIMIZER ADDED SUBROUTINE, CALLED 2 TIMES
SUBOPT_0x6:
	CALL __GETW1P
	STD  Y+6,R30
	STD  Y+6+1,R31
	ST   -Y,R31
	ST   -Y,R30
	RET

;OPTIMIZER ADDED SUBROUTINE, CALLED 2 TIMES
SUBOPT_0x7:
	LDD  R30,Y+13
	LDD  R31,Y+13+1
	ST   -Y,R31
	ST   -Y,R30
	RJMP __put_G2

_strlen:
	ld   r26,y+
	ld   r27,y+
	clr  r30
	clr  r31
__strlen0:
	ld   r22,x+
	tst  r22
	breq __strlen1
	adiw r30,1
	rjmp __strlen0
__strlen1:
	ret

_strlenf:
	clr  r26
	clr  r27
	ld   r30,y+
	ld   r31,y+
__strlenf0:
	lpm  r0,z+
	tst  r0
	breq __strlenf1
	adiw r26,1
	rjmp __strlenf0
__strlenf1:
	movw r30,r26
	ret

_delay_ms:
	ld   r30,y+
	ld   r31,y+
	adiw r30,0
	breq __delay_ms1
__delay_ms0:
	__DELAY_USW 0x1388
	wdr
	sbiw r30,1
	brne __delay_ms0
__delay_ms1:
	ret

__ADDW2R15:
	CLR  R0
	ADD  R26,R15
	ADC  R27,R0
	RET

__ANEGW1:
	COM  R30
	COM  R31
	ADIW R30,1
	RET

__ASRW8:
	MOV  R30,R31
	CLR  R31
	SBRC R30,7
	SER  R31
	RET

__DIVW21U:
	CLR  R0
	CLR  R1
	LDI  R25,16
__DIVW21U1:
	LSL  R26
	ROL  R27
	ROL  R0
	ROL  R1
	SUB  R0,R30
	SBC  R1,R31
	BRCC __DIVW21U2
	ADD  R0,R30
	ADC  R1,R31
	RJMP __DIVW21U3
__DIVW21U2:
	SBR  R26,1
__DIVW21U3:
	DEC  R25
	BRNE __DIVW21U1
	MOVW R30,R26
	MOVW R26,R0
	RET

__MODW21:
	CLT
	SBRS R27,7
	RJMP __MODW211
	COM  R26
	COM  R27
	ADIW R26,1
	SET
__MODW211:
	SBRC R31,7
	RCALL __ANEGW1
	RCALL __DIVW21U
	MOVW R30,R26
	BRTC __MODW212
	RCALL __ANEGW1
__MODW212:
	RET

__GETW1P:
	LD   R30,X+
	LD   R31,X
	SBIW R26,1
	RET

__GETW1PF:
	LPM  R0,Z+
	LPM  R31,Z
	MOV  R30,R0
	RET

__PUTPARD1:
	ST   -Y,R23
	ST   -Y,R22
	ST   -Y,R31
	ST   -Y,R30
	RET

__SAVELOCR6:
	ST   -Y,R21
__SAVELOCR5:
	ST   -Y,R20
__SAVELOCR4:
	ST   -Y,R19
__SAVELOCR3:
	ST   -Y,R18
__SAVELOCR2:
	ST   -Y,R17
	ST   -Y,R16
	RET

__LOADLOCR6:
	LDD  R21,Y+5
__LOADLOCR5:
	LDD  R20,Y+4
__LOADLOCR4:
	LDD  R19,Y+3
__LOADLOCR3:
	LDD  R18,Y+2
__LOADLOCR2:
	LDD  R17,Y+1
	LD   R16,Y
	RET

;END OF CODE MARKER
__END_OF_CODE:
