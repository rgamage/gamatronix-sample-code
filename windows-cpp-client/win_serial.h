/*
serial.h
Header file for Serial driver
Randy Gamage
6/10/2005
*/

#ifndef _SERIAL_H_
#define _SERIAL_H_
//#define WIN32_LEAN_AND_MEAN
#include <windows.h>

// CONSTANTS FOR BAUD RATES (TO BE COMPATIBLE WITH termios.h)
#define B2400 2400
#define B4800 4800
#define B9600 9600
#define B19200 19200
#define B38400 38400
#define B57600 57600
#define B115200 115200

// GLOBAL DEFINES
//

#define MAX_STATUS_BUFFER       20000
#define MAX_WRITE_BUFFER        1024
#define MAX_READ_BUFFER         2048
#define PURGE_FLAGS             PURGE_TXABORT | PURGE_TXCLEAR | PURGE_RXABORT | PURGE_RXCLEAR 
#define EVENTFLAGS_DEFAULT      EV_BREAK | EV_CTS | EV_DSR | EV_ERR | EV_RING | EV_RLSD
#define FLAGCHAR_DEFAULT        '\n'

//
// Write request types
//
#define WRITE_CHAR          0x01
#define WRITE_FILE          0x02
#define WRITE_FILESTART     0x03
#define WRITE_FILEEND       0x04
#define WRITE_ABORT         0x05
#define WRITE_BLOCK         0x06

//
// Read states
//
#define RECEIVE_TTY         0x01
#define RECEIVE_CAPTURED    0x02
#define AMOUNT_TO_READ      512
//
// COMMTIMEOUTS is init'd in Init.c


//
//  Error functions
//
/*
void ErrorReporter( char * szMessage );
void ErrorHandler( char * szMessage );
void ErrorInComm( char * szMessage );
*/
//
//  Initialization/deinitialization/settings functions
//
HANDLE SetupCommPort( char* gszPort, int baudrate );
UINT ReadByte(unsigned char* lpBuf,DWORD * dwRead);
UINT ReadBytes(unsigned char* lpBuf,DWORD * dwRead,int maxsize);
UINT WriteBytes(unsigned char * lpBuf, DWORD dwToWrite);
UINT WriteString(char* wstr);
void setBlocking();
void setNonBlocking();
bool CloseCommPort( void );
BOOL UpdateConnection( void );
void InitTTYInfo( int );

//
// ascii definitions
//
#define ASCII_BEL       0x07
#define ASCII_BS        0x08
#define ASCII_LF        0x0A
#define ASCII_CR        0x0D
#define ASCII_XON       0x11
#define ASCII_XOFF      0x13

//
// data structures
//
struct TTYInfoStruct
{
    HANDLE  hCommPort, hReaderStatus, hWriter ;
    DWORD   dwEventFlags;
    CHAR    chFlag, chXON, chXOFF;
    WORD    wXONLimit, wXOFFLimit;
    DWORD   fRtsControl;
    DWORD   fDtrControl;
    BOOL    fConnected, fTransferring, fRepeating,
            fLocalEcho, fNewLine,
            fDisplayErrors, fAutowrap,
            fCTSOutFlow, fDSROutFlow, fDSRInFlow, 
            fXonXoffOutFlow, fXonXoffInFlow,
            fTXafterXoffSent,
            fNoEvents, fNoStatus,
            fDisplayTimeouts;
    BYTE    bPort, bByteSize, bParity, bStopBits ;
    DWORD   dwBaudRate ;
    WORD    wCursorState ;
    HFONT   hTTYFont ;
    LOGFONT lfTTYFont ;
    DWORD   rgbFGColor ;
    COMMTIMEOUTS timeoutsorig;
    COMMTIMEOUTS timeoutsnew;
    int     xSize, ySize, xScroll, yScroll, xOffset, yOffset,
            nColumn, nRow, xChar, yChar , nCharPos;

};
//
// macros ( for easier readability )
//
#define COMDEV( x )         (x.hCommPort)
#define PORT( x )           (x.bPort)
#define CONNECTED( x )      (x.fConnected)
#define BYTESIZE( x )       (x.bByteSize)
#define PARITY( x )         (x.bParity)
#define STOPBITS( x )       (x.bStopBits)
#define BAUDRATE( x )       (x.dwBaudRate)
#define TIMEOUTSORIG( x )   (x.timeoutsorig)
#define TIMEOUTSNEW( x )    (x.timeoutsnew)
#define EVENTFLAGS( x )     (x.dwEventFlags)
#define FLAGCHAR( x )       (x.chFlag)

#define DTRCONTROL( x )     (x.fDtrControl)
#define RTSCONTROL( x )     (x.fRtsControl)
#define XONCHAR( x )        (x.chXON)
#define XOFFCHAR( x )       (x.chXOFF)
#define XONLIMIT( x )       (x.wXONLimit)
#define XOFFLIMIT( x )      (x.wXOFFLimit)
#define CTSOUTFLOW( x )     (x.fCTSOutFlow)
#define DSROUTFLOW( x )     (x.fDSROutFlow)
#define DSRINFLOW( x )      (x.fDSRInFlow)
#define XONXOFFOUTFLOW( x ) (x.fXonXoffOutFlow)
#define XONXOFFINFLOW( x )  (x.fXonXoffInFlow)
#define TXAFTERXOFFSENT(x)  (x.fTXafterXoffSent)

#define NOEVENTS( x )       (x.fNoEvents)
#define NOSTATUS( x )       (x.fNoStatus)

#endif

