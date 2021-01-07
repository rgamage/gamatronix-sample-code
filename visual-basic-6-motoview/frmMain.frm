VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Begin VB.MDIForm frmMain 
   BackColor       =   &H8000000C&
   Caption         =   "Gamatronix"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   Icon            =   "frmMain.frx":0000
   LinkTopic       =   "MDIForm1"
   Begin VB.Timer Timeout1 
      Left            =   1440
      Top             =   360
   End
   Begin MSCommLib.MSComm MSComm1 
      Left            =   360
      Top             =   240
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   -1  'True
      RThreshold      =   1
   End
   Begin VB.Menu mnuFile 
      Caption         =   "&File"
      Begin VB.Menu mnuExit 
         Caption         =   "E&xit"
      End
   End
   Begin VB.Menu mnuTools 
      Caption         =   "&Tools"
      Begin VB.Menu mnuPID 
         Caption         =   "&PID Settings"
      End
      Begin VB.Menu mnuAnalog 
         Caption         =   "Analog Values"
      End
      Begin VB.Menu mnuMotion 
         Caption         =   "Motion Profiles"
      End
      Begin VB.Menu mnuRegView 
         Caption         =   "Register View"
      End
      Begin VB.Menu mnuRCPconfig 
         Caption         =   "R/C Pulse Configure"
      End
   End
   Begin VB.Menu mnuCommunication 
      Caption         =   "Communication"
      Begin VB.Menu mnuSettings 
         Caption         =   "Settings"
      End
      Begin VB.Menu mnuConnect 
         Caption         =   "Connect"
      End
      Begin VB.Menu mnuDisconnect 
         Caption         =   "Disconnect"
      End
      Begin VB.Menu mnuLog 
         Caption         =   "Logging"
      End
   End
   Begin VB.Menu mnuHelp 
      Caption         =   "Help"
      Begin VB.Menu mnuAbout 
         Caption         =   "About"
      End
   End
End
Attribute VB_Name = "frmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'MotoView - A configuration / testing tool for the Gamoto PID Motor Controller
'Copyright (C) 2004 Randy Gamage
'Compiled under MS Visual Basic 6.0, SP6
'
'This program is free software; you can redistribute it and/or
'modify it under the terms of the GNU General Public License
'as published by the Free Software Foundation.
'
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'
'You should have received a copy of the GNU General Public License
'along with this program; if not, write to the Free Software
'Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
'
'Version Tracking
'2/4/04 Compiled & posted version 1.0.1
'2/4/04 Added Firmware version display in the Help - About box
'1.0.1 - 2/4/04 Initial Release
'1.0.2 - 3/12/04 Added new logo, fixed var declaration error in module2
'1.0.3 - 3/12/04 Fixed Motion profile numbering - now starts at zero, as in manual
'1.0.4 - 3/31/04
'Changed profiles to 24-bit distance profiles.  Now this MotoView will only work
'with Firmware v. 4 and up.
'Packaged as v. 1.0.4
'1.0.4 Posted on the Web
'5/14/04: Made change to program ending tasks.  Moved them from Exit_Click to Unload,
'to cover the case where the user clicks on the X in the upper right of the window.
'Fixed bug in Analog display window
'Released 1.0.5, posted to the web
'Fixed Bad Help About dialog formatting in WinXP.
'6/21/04 Fixed Profile calculations - major corrections to the formulas
'Released 1.0.6, posted to the web
'9/26/04 Changed all reads to max 4 bytes at a time, to comply with new firmware (v7)
'that protects the data integrity during a write or read
'9/26/04 Added Node (Address) setting in Comm dialog, defaults to "0"
'and changed the way the Header is defined.  Header = $AA + Node address
'10/11/04 Built version 1.0.7, posted to web
'12/30/04 Added a new form, frmLogging, for logging communications, at the
'request of a customer.
'Fixed some persistence issues with RegView and Analog windows.
'If they were closed in the middle of a transaction, then when the
'function call returned a value to the unloaded form, it would re-load the
'form, which would re-start the timer.
'12/30/04 Built version 1.0.8, posted to web
'2/18/05 Added Mode2 bit checkbox, to enable Homing
'4/2/05 Added Mode2 bit checkbox, to enable MotionDone signal
'and added buttons for SetHome and Reset
'5/3/05: Bug Report: Register View dialog crashes on latest version of MotoView
'Probably due to re-ordering of registers, conflicts with previous version's
'Windows registry entries. Need to add check - if MotoView version is different,
'start with new defaults.
'5/3/05: Added checks for version number, and also did bounds checking on watchlist array
'5/3/05: Released as version 1.0.13, posted to web
'5/7/05: Added two Mode2 bits, Enable115200 and StepDirEnable. Added 115200 baud choice in Comm window.
'5/10/05: Idea - Make text in PID form RED when it's not current with the device, so
'user knows he needs to press enter.
' Idea - Add two items to HELP menu - one to open the MotoView manual, another to open
' the Gamoto user manual.  Maybe a third to go to the Gamoto product web page
' Added Mode2 bit for AnalogFeedback
' 5/25/05 starting to make changes for R/C pulse introduction
' 12/6/05 Added StepSize register setting on PID screen, to adjust step/dir step size
' 1/13/06 Added lots of limits on all register entries, to only allow legal values.
' 4/11/07 Changed limit on iL value, from 65536 to 32767

Option Explicit

Public Baud As String
Public COMport As String
Dim COMsettings As String
Dim i As Integer
Public Logging As Boolean
Public Node As String
Public OpenPortOnStart As Boolean
Public qLow As Integer
Public qHi As Integer
Public MV_version As String
Public MV_stored_version As String


Private Sub MDIForm_Load()
MV_version = App.Major & "." & App.Minor & "." & App.Revision
MV_stored_version = GetSetting(App.Title, "Startup", "Version", "1.0.0")
If MV_version = MV_stored_version Then
    OpenPortOnStart = GetSetting(App.Title, "Startup", "OpenPortOnStart", "False")
    Baud = GetSetting(App.Title, "Startup", "Baud", "19200")
    COMport = GetSetting(App.Title, "Startup", "COMport", "1")
    Node = GetSetting(App.Title, "Startup", "Node", "0")
    For i = 0 To 9
        WatchList(i) = GetSetting(App.Title, "Startup", "WatchList" & i, -1)
    Next i
    Me.Left = GetSetting(App.Title, Me.Name, "left", 5000)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 3000)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 3495)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 795)
Else
    OpenPortOnStart = False
    Baud = "19200"
    COMport = "1"
    Node = "0"
    For i = 0 To 9
        WatchList(i) = -1
    Next i
    Me.Left = 5000
    Me.Top = 3000
    Me.Width = 3495
    Me.Height = 795
End If

HEADER = &HAA + Val(Node)
Logging = False
If OpenPortOnStart Then
  mnuConnect_Click
Else
  mnuDisconnect.Enabled = False
  mnuConnect.Enabled = True
End If
MSComm1.RThreshold = 1
Timeout1.Enabled = False
Timeout1.Interval = TIMEOUT
qLow = 0    'qHi is index of next item in the FIFO to be processed.  Processing takes place from
            'the "bottom" of the queue and works up (first added is first processed)
            'As soon as this item is processed, qLow gets incremented
qHi = 0     'qHi is index of next available slot in the Queue. It normally points to
            'and empty slot.  A new item gets added here, then qHi is incremented.



End Sub

Private Sub MDIForm_Unload(Cancel As Integer)
SaveSetting App.Title, "Startup", "Version", MV_version
SaveSetting App.Title, "Startup", "OpenPortOnStart", OpenPortOnStart
SaveSetting App.Title, "Startup", "Baud", Baud
SaveSetting App.Title, "Startup", "COMport", COMport
SaveSetting App.Title, "Startup", "Node", Node
If (Me.WindowState = vbNormal) Then
    SaveSetting App.Title, Me.Name, "left", Me.Left
    SaveSetting App.Title, Me.Name, "top", Me.Top
    SaveSetting App.Title, Me.Name, "width", Me.Width
    SaveSetting App.Title, Me.Name, "height", Me.Height
End If
For i = 0 To 9
    SaveSetting App.Title, "Startup", "WatchList" & i, WatchList(i)
Next i
End Sub

Private Sub mnuAbout_Click()
frmAbout.Show
End Sub

Private Sub mnuAnalog_Click()
Load frmAnalog
frmAnalog.SetSize
frmAnalog.Show
End Sub

Private Sub mnuExit_Click()
Unload Me
End
End Sub
Public Function SendSerial(strCmd As String) As Integer
'This routine takes a Gamoto command string as its input
'It then adds the required header and checksum, does some
'basic syntax checking of the command, and throws an error
'if the command is invalid.
'It then adds this serial request to the FIFO queue, and returns
'a Queue item number to the calling routine.  The calling routine
'then monitors this element of the queue to know when the request
'has been completed.
Dim rtnBytes As Integer
Dim qLen As Integer

'Figure out how many bytes to expect in return
If Asc(Mid(strCmd, 1, 1)) > 127 Then
    'It's a read command, so find out how many bytes are being read
    rtnBytes = Asc(Mid(strCmd, 3, 1)) + 2
Else
    'It's a write command, so always expect only two bytes back (ACK + Checksum)
    rtnBytes = 2
End If

'Add header and checksum
strCmd = Chr(HEADER) & strCmd
strCmd = AddCS(strCmd)

'Return queue item number to calling routine
SendSerial = qHi

'Populate element in Queue with command string
Fifo(qHi).Cmd = strCmd

'Populate element in Queue with expected number of return bytes
Fifo(qHi).bytesWaiting = rtnBytes

'Clear way for new response
Fifo(qHi).Response = ""
Fifo(qHi).Error = False

'Increment index to circular FIFO queue
qHi = (qHi + 1) Mod UBound(Fifo)

qLen = qHi - qLow
If qLen < 0 Then    'Deal with wrap (this is a circular queue)
    qLen = qLen + 20
End If

'Debug
'Debug.Print qLen

'Check if this is the only item in the Queue
If qLen = 1 Then
    MSComm1.RThreshold = rtnBytes
    MSComm1.Output = strCmd     ' Go ahead and send it
    If Logging Then frmLogging.ShowTX (strCmd)
    Timeout1.Enabled = True     ' Start timeout timer
End If
'Otherwise, we must wait.  Data will be sent by MSComm routine when slot opens up
End Function


Private Sub mnuConnect_Click()
On Error GoTo ComError
COMsettings = Baud & ",N,8,1"
MSComm1.Settings = COMsettings
MSComm1.CommPort = COMport
MSComm1.PortOpen = True
mnuDisconnect.Enabled = True
mnuConnect.Enabled = False
Exit Sub

ComError:
MsgBox Err.Description & ": Check values and try again", vbCritical
End Sub

Private Sub mnuDisconnect_Click()
On Error Resume Next
MSComm1.PortOpen = False
mnuDisconnect.Enabled = False
mnuConnect.Enabled = True
End Sub



Private Sub mnuLog_Click()
frmLogging.Show
End Sub

Private Sub mnuRegView_Click()
Load frmRegView
frmRegView.SetSize
frmRegView.Show
End Sub

Private Sub mnuMotion_Click()
frmProfiles.Show
End Sub

Private Sub mnuPID_Click()
frmPID.Show
End Sub

Private Sub mnuRCPconfig_Click()
Load frmRCPconfig
frmRCPconfig.SetSize
frmRCPconfig.Show
End Sub

Private Sub mnuSettings_Click()
frmComm.Show vbModal, Me
End Sub

Private Sub MSComm1_OnComm()
Dim newData As String
Dim qLen As Integer
Dim CS As Integer
Dim InData As String
Dim cmd_sent As String
If MSComm1.CommEvent = comEvReceive Then
  newData = MSComm1.Input
  If Logging Then frmLogging.ShowRX (newData)
  Fifo(qLow).Response = Fifo(qLow).Response & newData
  'Deduct number of outstanding bytes by number just received
  Fifo(qLow).bytesWaiting = Fifo(qLow).bytesWaiting - Len(newData)
  'If we got everything we expected, then increment the queue
  If Fifo(qLow).bytesWaiting = 0 Then
    Timeout1.Enabled = False    'Don't time out - we got our response
    InData = Fifo(qLow).Response
    'Check response header (ACK)
    If Asc(Mid(InData, 1, 1)) <> ACK Then
       MsgBox "Error - Bad ACK in response header", vbCritical
    End If
    'Check length
    If Len(InData) < 2 Then
        MsgBox "Error - Bad length of response", vbCritical
        Exit Sub
    End If
    'Check checksum
    CS = 0
    For i = 1 To Len(InData) - 1
      CS = (CS + Asc(Mid(InData, i, 1))) Mod 256
    Next i
    If CS <> Asc(Right(InData, 1)) Then
       MsgBox "Error - Bad Checksum in response", vbCritical
       Exit Sub
    End If
    'Now check if this was a SaveToFlash command. If so, wait an extra amount of time
    cmd_sent = Fifo(qLow).Cmd
    If Asc(Mid(cmd_sent, 3, 1)) = StoreFlashCmd Then
        Delay (500)
    End If
    qLow = (qLow + 1) Mod UBound(Fifo)
   'Check if there is another message waiting in the queue
    qLen = qHi - qLow
    If qLen < 0 Then    'Deal with wrap (this is a circular queue)
       qLen = qLen + 20
    End If
    If qLen > 0 Then
       MSComm1.RThreshold = Fifo(qLow).bytesWaiting
       MSComm1.Output = Fifo(qLow).Cmd
       If Logging Then frmLogging.ShowTX (Fifo(qLow).Cmd)
       Timeout1.Enabled = True    'Start comm timeout timer
    End If
  Else
    If Fifo(qLow).bytesWaiting < 0 Then
       MsgBox "Error - Unexpected data received", vbCritical
       InData = frmMain.MSComm1.Input   'Read the rest of whatever garbage is in buffer
    End If
  End If
End If

End Sub

Private Sub MSComm2_OnComm()

End Sub

Private Sub Timeout1_Timer()
Dim InData As String
MsgBox "Error - Response Timeout.  " & Fifo(qLow).bytesWaiting & " bytes outstanding.  Check connections", vbCritical
InData = MSComm1.Input      'Read to clear out whatever may be left in the buffer
Timeout1.Enabled = False
Fifo(qLow).Error = True
qLow = (qLow + 1) Mod UBound(Fifo)  'Remove this item from the FIFO queue
End Sub
