Option Strict Off
Option Explicit On
Module Module2
	Structure mcRegList
		Dim RegName As String 'Descriptive name of register
		Dim RegAddress As Short 'Byte address of register
		Dim RegLen As Short 'Length in bytes of this register
	End Structure
	Public WatchList(9) As Short
	Structure qItem
		Dim bytesWaiting As Short
		Dim Cmd As String
		Dim Response As String
		'UPGRADE_NOTE: Error was upgraded to Error_Renamed. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1061"'
		Dim Error_Renamed As Boolean
	End Structure
	Public Const TIMEOUT As Short = 500 ' Time out in ms for response from MC-1
	Public Const TRAJ_UPDATE_PERIOD As Double = 0.51 'Trajectory update period in milliseconds
	Public Fifo(20) As qItem
	Public Const RegBase As Short = 34 ' Start of motor registers
	Public Const FactoryResetCmd As Short = 0
	Public Const StoreFlashCmd As Short = 1
	Public Const Kp As Short = 34
	Public Const Ki As Short = 36
	Public Const Kd As Short = 38
	Public Const iL As Short = 40
	Public Const dS As Short = 42
	Public Const Mode As Short = 43
	Public Const pwrLimit As Short = 44
	Public Const dummy1 As Short = 45
	Public Const setPosition As Short = 47
	Public Const mPosition As Short = 51
	Public Const setVelocity As Short = 54
	Public Const mVelocity As Short = 57
	Public Const segnum As Short = 59
	Public Const mPower As Short = 60
	Public Const UpCount As Short = 70
	Public Const DnCount As Short = 71
	Public Const Ypid As Short = 101
	Public Const dBug1 As Short = 122
	Public Const dBug2 As Short = 123
	Public Const Analog0 As Short = 160
	Public Const Analog1 As Short = 162
	Public Const Analog2 As Short = 164
	Public Const Analog3 As Short = 166
	Public Const Analog4 As Short = 168
	Public Const Profile0 As Short = 180
	Public Const Version As Short = 178
	Public Const ACK As Short = &H41s
	Public Const NUM_PROFILES As Short = 8 'Number of unique profiles storeable in memory
	Public Const PROFILE_LEN As Short = 7 'Each profile is seven bytes long
	Public HEADER As Short
	
	
	Function AddCS(ByRef strIn As String) As String
		'This function takes a Gamoto command string and computes
		'the checksum.  The output is the original command string,
		'plus the correct checksum appended to it
		'Example:
		' AA 20 25 02  => AA 20 25 02 47
		
		Dim i As Short
		Dim j As Byte
		j = 0
		If Len(strIn) < 2 Then Exit Function
		For i = 2 To Len(strIn)
			j = (j + Asc(Mid(strIn, i, 1))) Mod 256
		Next i
		AddCS = strIn & Chr(j)
	End Function
	
	Function DecToHexchars24(ByRef inDec As Integer) As String
		'This function converts a decimal value into a string
		'of hex characters, in 24-bit signed notation
		'least significant byte first (little-endian)
		'Example
		'DecToHexchars24(520) => chr(8) & chr(2) & chr(0)
		'DecToHexchars24(-2) => chr(FE) & chr(FF) & chr(FF)
		
		'If negative, convert to two's complement:
		If inDec < 0 Then inDec = 2 ^ 24 + inDec
		
		Dim strTemp As String
		Dim i As Short
		strTemp = ""
		
		For i = 1 To 3
			strTemp = strTemp & Chr(inDec Mod 256)
			inDec = inDec \ 256
		Next i
		
		DecToHexchars24 = strTemp
	End Function
	
	Function DecToHexchars16(ByRef inDec As Integer) As String
		'This function converts a decimal value into a string
		'of hex characters, in 16-bit signed notation,
		'least significant byte first (little-endian)
		'Example
		'DecToHexchars16(520) => chr(8) & chr(2)
		'DecToHexchars16(-2) => chr(FE) & chr(FF)
		
		'If negative, convert to two's complement:
		If inDec < 0 Then inDec = 2 ^ 16 + inDec
		
		Dim strTemp As String
		Dim i As Short
		strTemp = ""
		
		For i = 1 To 2
			strTemp = strTemp & Chr(inDec Mod 256)
			inDec = inDec \ 256
		Next i
		
		DecToHexchars16 = strTemp
	End Function
	Function DecToHexchars8(ByRef inDec As Integer) As String
		'This function converts a decimal value into a string
		'of hex characters, in 8-bit signed notation,
		'least significant byte first (little-endian)
		'Example
		'DecToHexchars8(127) => chr(127)
		'DecToHexchars8(-2) => chr(FE)
		
		'If negative, convert to two's complement:
		If inDec < 0 Then inDec = 2 ^ 8 + inDec
		
		Dim strTemp As String
		Dim i As Short
		strTemp = ""
		
		strTemp = strTemp & Chr(inDec Mod 256)
		inDec = inDec \ 256
		'If inDec > 256, then only the modulo will be considered
		DecToHexchars8 = strTemp
	End Function
	Function Hex2Dec(ByRef inHex As String) As Integer
		'This function takes a Hexadecimal string
		'and outputs a decimal (long) result
		Dim i As Short
		Dim j As Integer
		Dim ch As String
		Dim k As Short
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
					MsgBox("Invalid data for Hex2Dec function")
			End Select
			j = j * 16 ^ (i - 1)
			Hex2Dec = Hex2Dec + j
			j = 0
		Next i
	End Function
	
	Public Function DecToBin(ByRef InByte As Short) As String
		Dim Float As Single
		Dim i As Short
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
	
	Public Function Min(ByRef x As Object, ByRef y As Object) As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If x < y Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Min. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Min = x
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object y. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Min. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			Min = y
		End If
	End Function
End Module