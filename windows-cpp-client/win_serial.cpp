// serial.cpp : Defines the entry point for the console application.
//
#include <iostream>
#include "win_serial.h"

using namespace std;

//Global variables
TTYInfoStruct TTYInfo;
/*
    TimeoutsDefault
        We need ReadIntervalTimeout here to cause the read operations
        that we do to actually timeout and become overlapped.
        Specifying 1 here causes ReadFile to return very quickly
        so that our reader thread will continue execution.

		* NOTE: Setting to all zeros causes blocking behavior *

		COMMTIMEOUTS timeouts;
		timeouts.ReadIntervalTimeout = 1; 
		timeouts.ReadTotalTimeoutMultiplier = 1;
		timeouts.ReadTotalTimeoutConstant = 1;
		timeouts.WriteTotalTimeoutMultiplier = 1;
		timeouts.WriteTotalTimeoutConstant = 50;
*/


COMMTIMEOUTS gTimeoutsDefault = { 20, 20, 20, 20, 50 };

DWORD  gdwReceiveState;
char gszPort[10] = "COM1"; 

void ErrorReporter(const char* ErrMessage) {
	// Error Reporting function
	cout << "Error code " << GetLastError() << " in following area: " << ErrMessage << endl;
}

void setBlocking(){
	/* sets timeouts for comm port to blocking mode (no timeouts) */
  COMMTIMEOUTS TimeoutsBlocking = { 0, 0, 0, 0, 0 };
  if (!SetCommTimeouts(COMDEV(TTYInfo), &TimeoutsBlocking))
        ErrorReporter("SetCommTimeouts (Set to Blocking mode)");
}

void setNonBlocking(){
	/* sets timeouts for comm port to non-blocking mode (with timeouts) */
  if (!SetCommTimeouts(COMDEV(TTYInfo), &gTimeoutsDefault))
        ErrorReporter("SetCommTimeouts (Set to default (non-blocking) mode)");
}

/*-----------------------------------------------------------------------------

FUNCTION: SetupCommPort( char* gszPort, int baudrate )

PURPOSE: Setup Communication Port with our settings

RETURN: 
    Handle of comm port is successful
    NULL is error occurs

HISTORY:   Date:      Author:     Comment:
           10/27/95   AllenD      Wrote it

-----------------------------------------------------------------------------*/
HANDLE SetupCommPort(char* gszPort, int baudrate=9600)
{
    //
    // set initial settings for com port
    //
    InitTTYInfo(baudrate);

    wchar_t wtext[10];
    size_t result;
    mbstowcs_s(&result, wtext, 5, gszPort, 5); //Plus null
    LPWSTR port = wtext;

    //
    // open communication port handle
    //
    COMDEV( TTYInfo ) = CreateFile( port,  
                                      GENERIC_READ | GENERIC_WRITE, 
                                      0, 
                                      0, 
                                      OPEN_EXISTING,
                                      FILE_ATTRIBUTE_NORMAL,
                                      0);

    if (COMDEV(TTYInfo) == INVALID_HANDLE_VALUE) {   
        ErrorReporter("CreateFile");
        return NULL;
    }

    //
    // Save original comm timeouts and set new ones
    //
    if (!GetCommTimeouts( COMDEV(TTYInfo), &(TIMEOUTSORIG(TTYInfo))))
        ErrorReporter("GetCommTimeouts");

    //
    // Set port state
    //
    UpdateConnection();

    //
    // set comm buffer sizes
    //
    SetupComm(COMDEV(TTYInfo), MAX_READ_BUFFER, MAX_WRITE_BUFFER);

    //
    // raise DTR
    //
    if (!EscapeCommFunction(COMDEV(TTYInfo), SETDTR))
        ErrorReporter("EscapeCommFunction (SETDTR)");

    //
    // set overall connect flag
    //
    CONNECTED( TTYInfo ) = TRUE ;

    return COMDEV(TTYInfo);
}

/*-----------------------------------------------------------------------------

FUNCTION: CloseCommPort

PURPOSE: Closes a connection to a comm port

RETURN:
    TRUE  - successful Close of port
    FALSE - port isn't connected

COMMENTS: Waits for threads to exit,
          clears DTR, restores comm port timeouts, purges any i/o
          and closes all pertinent handles

HISTORY:   Date:      Author:     Comment:
           10/27/95   AllenD      Wrote it

-----------------------------------------------------------------------------*/
bool CloseCommPort()
{
    if (!CONNECTED(TTYInfo))
        return FALSE;

    CONNECTED( TTYInfo ) = FALSE;

    //
    // lower DTR
    //
    if (!EscapeCommFunction(COMDEV(TTYInfo), CLRDTR))
        ErrorReporter("EscapeCommFunction(CLRDTR)");

    //
    // restore original comm timeouts
    //
    if (!SetCommTimeouts(COMDEV(TTYInfo),  &(TIMEOUTSORIG(TTYInfo))))
        ErrorReporter("SetCommTimeouts (Restoration to original)");

    //
    // Purge reads/writes, input buffer and output buffer
    //
    if (!PurgeComm(COMDEV(TTYInfo), PURGE_FLAGS))
        ErrorReporter("PurgeComm");

    CloseHandle(COMDEV(TTYInfo));

	return TRUE;
}
// **************************


void InitTTYInfo(int baudrate=9600)
{
    //
    // initialize generial TTY info
    //
    COMDEV( TTYInfo )        = NULL ;
    CONNECTED( TTYInfo )     = FALSE ;
    PORT( TTYInfo )          = 1 ;  //COM 1
    BAUDRATE( TTYInfo )      = baudrate; //CBR_19200 ;
    BYTESIZE( TTYInfo )      = 8 ;
    PARITY( TTYInfo )        = NOPARITY ;
    STOPBITS( TTYInfo )      = ONESTOPBIT ;

    //
    // timeouts
    //
    TIMEOUTSNEW( TTYInfo )   = gTimeoutsDefault;

    //
    // read state and status events
    //
    gdwReceiveState          = RECEIVE_TTY;
    EVENTFLAGS( TTYInfo )    = EVENTFLAGS_DEFAULT;
    FLAGCHAR( TTYInfo )      = FLAGCHAR_DEFAULT;

    //
    // Flow Control Settings
    //
    DTRCONTROL( TTYInfo )    = DTR_CONTROL_ENABLE;
    RTSCONTROL( TTYInfo )    = RTS_CONTROL_ENABLE;
    XONCHAR( TTYInfo )       = ASCII_XON;
    XOFFCHAR( TTYInfo )      = ASCII_XOFF;
    XONLIMIT( TTYInfo )      = 0;
    XOFFLIMIT( TTYInfo )     = 0;
    CTSOUTFLOW( TTYInfo )    = FALSE;
    DSROUTFLOW( TTYInfo )    = FALSE;
    DSRINFLOW( TTYInfo )     = FALSE;
    XONXOFFOUTFLOW(TTYInfo)  = FALSE;
    XONXOFFINFLOW(TTYInfo)   = FALSE;
    TXAFTERXOFFSENT(TTYInfo) = FALSE;

    NOEVENTS(TTYInfo)        = FALSE;
    NOSTATUS(TTYInfo)        = FALSE;

}


BOOL UpdateConnection()
{
    DCB dcb = {0};
    
    dcb.DCBlength = sizeof(dcb);

    //
    // get current DCB settings
    //
    if (!GetCommState(COMDEV(TTYInfo), &dcb))
	ErrorReporter("GetCommState");

    //
    // update DCB rate, byte size, parity, and stop bits size
    //
    dcb.BaudRate = BAUDRATE(TTYInfo);
    dcb.ByteSize = BYTESIZE(TTYInfo);
    dcb.Parity   = PARITY(TTYInfo);
    dcb.StopBits = STOPBITS(TTYInfo);

    //
    // update event flags
    //
    if (EVENTFLAGS(TTYInfo) & EV_RXFLAG)
	dcb.EvtChar = FLAGCHAR(TTYInfo);      
    else
	dcb.EvtChar = '\0';

    //
    // update flow control settings
    //
    dcb.fDtrControl     = DTRCONTROL(TTYInfo);
    dcb.fRtsControl     = RTSCONTROL(TTYInfo);

    dcb.fOutxCtsFlow    = CTSOUTFLOW(TTYInfo);
    dcb.fOutxDsrFlow    = DSROUTFLOW(TTYInfo);
    dcb.fDsrSensitivity = DSRINFLOW(TTYInfo);
    dcb.fOutX           = XONXOFFOUTFLOW(TTYInfo);
    dcb.fInX            = XONXOFFINFLOW(TTYInfo);
    dcb.fTXContinueOnXoff = TXAFTERXOFFSENT(TTYInfo);
    dcb.XonChar         = XONCHAR(TTYInfo);
    dcb.XoffChar        = XOFFCHAR(TTYInfo);
    dcb.XonLim          = XONLIMIT(TTYInfo);
    dcb.XoffLim         = XOFFLIMIT(TTYInfo);
    
    // This was added as a countermeasure for intermittant 995 error codes
//    dcb.fAbortOnError   = 0;
    //
    // DCB settings not in the user's control
    //
    dcb.fParity = TRUE;

    //
    // set new state
    //
    if (!SetCommState(COMDEV(TTYInfo), &dcb))
	ErrorReporter("SetCommState");

    //
    // set new timeouts
    //
    if (!SetCommTimeouts(COMDEV(TTYInfo), &(TIMEOUTSNEW(TTYInfo))))
	ErrorReporter("SetCommTimeouts");

    return TRUE;
}

/*-----------------------------------------------------------------------------

FUNCTION: WriteBytes(unsigned char*, DWORD)

PURPOSE: Handles sending all types of data

PARAMETER:
    lpBuf     - pointer to data buffer
    dwToWrite - size of buffer

HISTORY:   Date:      Author:     Comment:
           10/27/95   AllenD      Wrote it
        06-JUL-2005   R.Gamage    Modified name, function slightly

-----------------------------------------------------------------------------*/
UINT WriteBytes(unsigned char * lpBuf, DWORD dwToWrite)
{
	// Writes some bytes out the COM port.  Returns 0 if successful, error code of LastError if not
	// lpBuf = pointer to array of bytes
	// dwToWrite = how many bytes to write

	DWORD dwWritten;
    //
    // issue write
    //
	if (!WriteFile(COMDEV(TTYInfo), lpBuf, dwToWrite, &dwWritten, NULL))
		return GetLastError();
	else
        return (0);
}

UINT WriteString(char* wstr){
    //writes a zero-terminated string to the com port
    return (WriteBytes((unsigned char*)wstr,(DWORD)strlen(wstr)));
}

UINT ReadByte(unsigned char* lpBuf,DWORD * dwRead) {
	// Read byte from the COM port
	// Returns 0 if successful
	// dwRead = number bytes that were actually read, this is set by the ReadFile routine
    // for this function, dwRead will be either 0 or 1
//	UINT result;   //return value from this function (0 = OK, else error code)
	if (!ReadFile(COMDEV(TTYInfo), lpBuf, 1, dwRead, NULL))
        return GetLastError();
	else return 0;
}	

UINT ReadBytes(unsigned char* lpBuf,DWORD * dwRead,int maxsize) {
	// Read multiple bytes from the COM port
	// Returns 0 if successful
	// dwRead = number bytes that were actually read, this is set by the ReadFile routine
    // maxsize = maximum number of bytes to read (MUST be <= size of lpBuf passed in)
    // NOTE: buffer (lpBuf) is not returned with a zero terminator (not a string)
//	UINT result;   //return value from this function (0 = OK, else error code)
	if (!ReadFile(COMDEV(TTYInfo), lpBuf, maxsize, dwRead, NULL))
        return GetLastError();
	else return 0;
}	






