Attribute VB_Name = "Module2"
Option Explicit
Type mcRegList
    RegName As String       'Descriptive name of register
    RegAddress As Integer   'Byte address of register
    Reglen As Integer       'Length in bytes of this register
End Type
Public WatchList(9) As Integer
Type qItem
  bytesWaiting As Integer
  Cmd As String
  Response As String
  Error As Boolean
End Type
Public Const TIMEOUT = 500     ' Time out in ms for response from MC-1
Public Const TRAJ_UPDATE_PERIOD = 0.51 'Trajectory update period in milliseconds
Public Fifo(20) As qItem
Public Const RegBase = 34      ' Start of motor registers
Public Const FactoryResetCmd = 0
Public Const StoreFlashCmd = 1
Public Const ResetCmd = 2
Public Const SetHomeCmd = 3
Public Const Kp = 34
Public Const Ki = 36
Public Const Kd = 38
Public Const iL = 40
Public Const dS = 42
Public Const Mode = 43
Public Const pwrLimit = 44
Public Const Mode2 = 45
Public Const setPosition = 47
Public Const mPosition = 51
Public Const setVelocity = 54
Public Const mVelocity = 57
Public Const segnum = 59
Public Const mPower = 60
Public Const UpCount = 70
Public Const DnCount = 71
Public Const u0 = 97
Public Const Ypid = 101
Public Const dBug1 = 122
Public Const dBug2 = 123
Public Const Analog0 = 160
Public Const Analog1 = 162
Public Const Analog2 = 164
Public Const Analog3 = 166
Public Const Analog4 = 168
Public Const Profile0 = 180
Public Const Version = 178
Public Const StepSize = 179

Public Const SPmin = 226
Public Const SPmax = 228
Public Const RCPmin = 230
Public Const RCPmax = 232

Public Const RCPraw = 90

Public Const ACK = &H41
Public Const NUM_PROFILES = 8       'Number of unique profiles storeable in memory
Public Const PROFILE_LEN = 7        'Each profile is seven bytes long
Public HEADER As Integer
Public Declare Function timeGetTime Lib "winmm.dll" () As Long


Public Sub Delay(wait_time As Long)
'Waits a specified wait time (in ms)
Dim now As Long
now = timeGetTime
Do Until (timeGetTime - now) = wait_time
  DoEvents
Loop
End Sub


Function AddCS(strIn As String) As String
'This function takes a Gamoto command string and computes
'the checksum.  The output is the original command string,
'plus the correct checksum appended to it
'Example:
' AA 20 25 02  => AA 20 25 02 47

Dim i As Integer
Dim j As Byte
j = 0
If Len(strIn) < 2 Then Exit Function
For i = 2 To Len(strIn)
  j = (j + Asc(Mid(strIn, i, 1))) Mod 256
Next i
AddCS = strIn & Chr(j)
End Function

Function DecToHexchars24(inDec As Long) As String
'This function converts a decimal value into a string
'of hex characters, in 24-bit signed notation
'least significant byte first (little-endian)
'Example
'DecToHexchars24(520) => chr(8) & chr(2) & chr(0)
'DecToHexchars24(-2) => chr(FE) & chr(FF) & chr(FF)

'If negative, convert to two's complement:
If inDec < 0 Then inDec = 2 ^ 24 + inDec

Dim strTemp As String
Dim i As Integer
strTemp = ""

For i = 1 To 3
  strTemp = strTemp & Chr(inDec Mod 256)
  inDec = inDec \ 256
Next i

DecToHexchars24 = strTemp
End Function

Function DecToHexchars16(inDec As Long) As String
'This function converts a decimal value into a string
'of hex characters, in 16-bit signed notation,
'least significant byte first (little-endian)
'Example
'DecToHexchars16(520) => chr(8) & chr(2)
'DecToHexchars16(-2) => chr(FE) & chr(FF)

'If negative, convert to two's complement:
If inDec < 0 Then inDec = 2 ^ 16 + inDec

Dim strTemp As String
Dim i As Integer
strTemp = ""

For i = 1 To 2
  strTemp = strTemp & Chr(inDec Mod 256)
  inDec = inDec \ 256
Next i

DecToHexchars16 = strTemp
End Function
Function DecToHexchars8(inDec As Long) As String
'This function converts a decimal value into a string
'of hex characters, in 8-bit signed notation,
'least significant byte first (little-endian)
'Example
'DecToHexchars8(127) => chr(127)
'DecToHexchars8(-2) => chr(FE)

'If negative, convert to two's complement:
If inDec < 0 Then inDec = 2 ^ 8 + inDec

Dim strTemp As String
Dim i As Integer
strTemp = ""

strTemp = strTemp & Chr(inDec Mod 256)
inDec = inDec \ 256
'If inDec > 256, then only the modulo will be considered
DecToHexchars8 = strTemp
End Function
Function Hex2Dec(inHex As String) As Long
'This function takes a Hexadecimal string
'and outputs a decimal (long) result
Dim i As Integer
Dim j As Long
Dim ch As String
Dim k As Integer
For i = 1 To Len(inHex)
 ch = Mid(inHex, Len(inHex) - i + 1, 1)
 k = Asc(ch)
  Select Case k
    Case 48 To 57
      j = j + k - 48
    Case 65 To 70
      j = j + k - 55
    Case 97 To 102
      j = j + k - 87
    Case Else
      MsgBox ("Invalid data for Hex2Dec function")
  End Select
 j = j * 16 ^ (i - 1)
 Hex2Dec = Hex2Dec + j
 j = 0
Next i
End Function

Public Function DecToBin(InByte As Integer) As String
Dim Float As Single
Dim i As Integer
'This routine takes a byte value (0-255) as an input,
'and returns a string containing the binary representation
'of that number.  Example:
' DecToBin(4) = "00000100"
DecToBin = ""
If InByte < 0 Or InByte > 255 Then Exit Function
For i = 1 To 8
  Float = CSng(InByte) / CSng(2)
  InByte = InByte \ 2
  If Float = InByte Then
    DecToBin = "0" & DecToBin
  Else
    DecToBin = "1" & DecToBin
  End If
Next i
End Function

Public Function Min(x, y)
If x < y Then
    Min = x
Else
    Min = y
End If
End Function

