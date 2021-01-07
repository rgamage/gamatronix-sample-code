VERSION 5.00
Begin VB.Form frmProfiles 
   Caption         =   "Motion Profiles"
   ClientHeight    =   4005
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5490
   Icon            =   "frmProfiles.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4005
   ScaleWidth      =   5490
   Begin VB.Frame Frame2 
      Caption         =   "Controls"
      Height          =   3015
      Left            =   3000
      TabIndex        =   13
      Top             =   240
      Width           =   2295
      Begin VB.CommandButton cmdReset 
         Caption         =   "Reset to Home"
         Height          =   375
         Left            =   360
         TabIndex        =   20
         Top             =   1920
         Width           =   1575
      End
      Begin VB.CommandButton cmdDecelerate 
         Caption         =   "Decelerate"
         Height          =   375
         Left            =   360
         TabIndex        =   17
         Top             =   1440
         Width           =   1575
      End
      Begin VB.CommandButton cmdSave 
         Caption         =   "Save All To Flash"
         Height          =   375
         Left            =   360
         TabIndex        =   16
         Top             =   2400
         Width           =   1575
      End
      Begin VB.CommandButton cmdStop 
         Caption         =   "Stop"
         Height          =   375
         Left            =   600
         TabIndex        =   15
         Top             =   840
         Width           =   1095
      End
      Begin VB.CommandButton cmdRun 
         Caption         =   "Run"
         Height          =   375
         Left            =   600
         TabIndex        =   14
         Top             =   360
         Width           =   1095
      End
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      CausesValidation=   0   'False
      Height          =   375
      Left            =   4080
      TabIndex        =   12
      Top             =   3480
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Motion Profile Data"
      Height          =   3615
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   2535
      Begin VB.TextBox txtTotalTime 
         Height          =   285
         Left            =   1440
         Locked          =   -1  'True
         TabIndex        =   18
         Top             =   2520
         Width           =   855
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   375
         Left            =   1200
         TabIndex        =   11
         Top             =   3000
         Width           =   1095
      End
      Begin VB.TextBox txtAccelTime 
         Height          =   285
         Left            =   1440
         Locked          =   -1  'True
         TabIndex        =   10
         Top             =   2160
         Width           =   855
      End
      Begin VB.TextBox txtA 
         Height          =   285
         Left            =   1440
         TabIndex        =   8
         Top             =   1680
         Width           =   855
      End
      Begin VB.TextBox txtV 
         Height          =   285
         Left            =   1440
         TabIndex        =   7
         Top             =   1320
         Width           =   855
      End
      Begin VB.TextBox txtX 
         Height          =   285
         Left            =   1440
         TabIndex        =   6
         Top             =   960
         Width           =   855
      End
      Begin VB.ComboBox cboProfile 
         Height          =   315
         Left            =   1200
         TabIndex        =   2
         Top             =   360
         Width           =   855
      End
      Begin VB.Label Label6 
         Caption         =   "Total Time (s):"
         Height          =   255
         Left            =   120
         TabIndex        =   19
         Top             =   2520
         Width           =   1215
      End
      Begin VB.Label Label5 
         Caption         =   "Accel Time (ms):"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   2160
         Width           =   1215
      End
      Begin VB.Label Label4 
         Caption         =   "Acceleration:"
         Height          =   255
         Left            =   360
         TabIndex        =   5
         Top             =   1680
         Width           =   975
      End
      Begin VB.Label Label3 
         Caption         =   "Velocity:"
         Height          =   255
         Left            =   360
         TabIndex        =   4
         Top             =   1320
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Distance:"
         Height          =   255
         Left            =   360
         TabIndex        =   3
         Top             =   960
         Width           =   735
      End
      Begin VB.Label Label1 
         Caption         =   "Profile:"
         Height          =   255
         Left            =   360
         TabIndex        =   1
         Top             =   390
         Width           =   615
      End
   End
End
Attribute VB_Name = "frmProfiles"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'MotoView - A configuration / testing tool for the Gamoto PID Motor Controller
'Copyright (C) 2004 Randy Gamage
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
Option Explicit
Dim qIndex As Integer
Dim i As Integer
Dim Cmd As String
Dim InData As String
Dim dS_current As Long  'Current value of dS, read from device

'end of declarations


Private Sub cboProfile_Click()
If frmMain.MSComm1.PortOpen Then GetProfile
End Sub

Private Sub cmdClose_Click()
SaveSetting App.Title, Me.Name, "left", Me.Left
SaveSetting App.Title, Me.Name, "top", Me.Top
SaveSetting App.Title, Me.Name, "width", Me.Width
SaveSetting App.Title, Me.Name, "height", Me.Height
Unload Me
End Sub

Private Sub cmdDecelerate_Click()
Dim qIndex As Integer
Dim mcMode As Integer
'Now modify the current mode by Setting the Decelerate bit, keeping motor power on
mcMode = 8 + 2 + 1
Cmd = Chr(&H2) & Chr(Mode) & Chr(mcMode)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend

End Sub

Private Sub cmdEnter_Click()
If Not frmMain.MSComm1.PortOpen Then Exit Sub
i = cboProfile.ListIndex
'Write Distance
Cmd = Chr(&H4) & Chr(Profile0 + PROFILE_LEN * i) & DecToHexchars24(Val(txtX))
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
'Write Velocity
Cmd = Chr(&H3) & Chr(Profile0 + PROFILE_LEN * i + 3) & DecToHexchars16(Val(txtV))
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
'Write Acceleration
Cmd = Chr(&H3) & Chr(Profile0 + PROFILE_LEN * i + 5) & DecToHexchars16(Val(txtA))
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
cmdRun.Enabled = True
End Sub

Private Sub cmdReset_Click()
'This command resets the setPosition and mPosition position to 0
Dim qIndex As Integer    ' Stores current queue item for calling routine

'Set Mode to zero to turn off motor
Cmd = Chr(&H2) & Chr(Mode) & DecToHexchars8(0)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our command to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend

'Set target position to zero
Cmd = Chr(&H4) & Chr(setPosition) & DecToHexchars24(0)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our command to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend

'Set actual position to zero
Cmd = Chr(&H4) & Chr(mPosition) & DecToHexchars24(0)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our command to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend

'Set Mode to one to turn on motor
Cmd = Chr(&H2) & Chr(Mode) & DecToHexchars8(1)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our command to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
End Sub

Private Sub cmdRun_Click()
Dim InData As String
Dim mcMode As Integer
'Read what the current Mode is set to
'Cmd = Chr(&H82) & Chr(Mode) & Chr(1)
'qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
'While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
'  DoEvents
'Wend
'If Fifo(qIndex).Error Then Exit Sub
'InData = Fifo(qIndex).Response
'InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
'mcMode = Asc(Mid(InData, 1, 1))

'Set the profile number
Cmd = Chr(&H2) & Chr(segnum) & Chr(cboProfile.ListIndex)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub

'Now set the Trajectory ON bit, Motor ON
mcMode = 3
Cmd = Chr(&H2) & Chr(Mode) & Chr(mcMode)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
End Sub

Private Sub cmdStop_Click()
Dim InData As String
Dim mcMode As Integer
Dim mcPosition As Long
'Read what the current Mode is set to
Cmd = Chr(&H82) & Chr(Mode) & Chr(1)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
mcMode = Asc(Mid(InData, 1, 1))
'Now modify the current mode by Clearing the Trajectory ON bit
mcMode = mcMode And (255 - (2 ^ 1))
Cmd = Chr(&H2) & Chr(Mode) & Chr(mcMode)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
'Now modify the current mode by Clearing the Trajectory ON bit, keeping motor power on
mcMode = 1
Cmd = Chr(&H2) & Chr(Mode) & Chr(mcMode)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
'Read what the current Position is set to
Cmd = Chr(&H82) & Chr(setPosition) & Chr(3)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
mcPosition = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1))) + 65536 * CLng(Asc(Mid(InData, 3, 1)))
'Now set target position = actual position, so motor will stop, but still be controlling
Cmd = Chr(&H4) & Chr(setPosition) & DecToHexchars24(mcPosition)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
End Sub

Private Sub cmdSave_Click()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Dim vbResponse As Variant
cmdEnter_Click  'Make sure the current settings have been sent to the Gamoto
Cmd = Chr(&H1) & Chr(StoreFlashCmd)
vbResponse = MsgBox("This will save profiles AND all key PID parameters to Flash (Kp, Ki, Kd, etc.).  Are you sure?", vbOKCancel)
If vbResponse = vbOK Then
  qIndex = frmMain.SendSerial(Cmd)
  While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
    DoEvents
  Wend
End If
End Sub


Private Sub Form_Load()
For i = 0 To 5
  cboProfile.AddItem i
Next i
cboProfile.ListIndex = 0
If frmMain.MV_version = frmMain.MV_stored_version Then
    Me.Left = GetSetting(App.Title, Me.Name, "left", 4875)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 3555)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 5610)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 4410)
Else
    Me.Left = 4875
    Me.Top = 3555
    Me.Width = 5610
    Me.Height = 4410
End If
cmdRun.Enabled = True
End Sub

Private Sub GetProfile()
'On Error GoTo GP_Error
'Read Selected Profile
i = cboProfile.ListIndex
'Read X from profile (3 bytes)
Cmd = Chr(&H82) & Chr(Profile0 + PROFILE_LEN * i) & Chr(3)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtX = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1))) + 65536 * CLng(Asc(Mid(InData, 3, 1)))

'Read V, A from profile (4 bytes)
Cmd = Chr(&H82) & Chr(Profile0 + PROFILE_LEN * i + 3) & Chr(4)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtV = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1)))
txtA = Asc(Mid(InData, 3, 1)) + 256 * CLng(Asc(Mid(InData, 4, 1)))

'Now read dS from the device, to use later in accel time calcs
Cmd = Chr(&H82) & Chr(dS) & Chr(1)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
dS_current = Asc(Mid(InData, 1, 1))
UpdateTime
Exit Sub
GP_Error:
MsgBox "Error: " & Err.Description, vbCritical
 End Sub

Private Sub txtA_Change()
cmdRun.Enabled = False
End Sub

Private Sub txtA_LostFocus()
UpdateTime
End Sub

Private Sub txtA_Validate(Cancel As Boolean)
If (Val(txtA) < 0) Or (Val(txtA) > 32767) Then
   MsgBox "Invalid register setting.  Must be from 0 to 32767", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub UpdateTime()
Dim acps2, vMax, xA, tA, v
'Exit if any of the parameters are = 0
If Val(txtX) * Val(txtV) * Val(txtA) * dS_current = 0 Then Exit Sub
acps2 = (Abs(Val(txtA)) / 256) / ((TRAJ_UPDATE_PERIOD / 1000) * dS_current) ^ 2
tA = Min(Abs(Val(txtV)) / Val(txtA) * (TRAJ_UPDATE_PERIOD / 1000) * dS_current _
            , (Abs(Val(txtX)) / acps2) ^ 0.5)
txtAccelTime = tA * 1000
v = Abs((Val(txtV) / 256) / (TRAJ_UPDATE_PERIOD * dS_current) * 1000)
vMax = Min(v, acps2 * tA)
xA = 0.5 * acps2 * tA ^ 2
If vMax = v Then
    txtTotalTime = 2 * tA + ((Val(txtX) - 2 * xA) / vMax)
Else
    txtTotalTime = 2 * tA
End If
End Sub

Private Sub txtV_Change()
cmdRun.Enabled = False

End Sub

Private Sub txtV_LostFocus()
UpdateTime
End Sub

Private Sub txtV_Validate(Cancel As Boolean)
If (Val(txtV) < 0) Or (Val(txtV) > 32767) Then
   MsgBox "Invalid register setting.  Must be from 0 to 32767", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtX_Change()
cmdRun.Enabled = False
End Sub

Private Sub txtX_GotFocus()
txtX.SelStart = 0
txtX.SelLength = Len(txtX)
End Sub
Private Sub txtV_GotFocus()
txtV.SelStart = 0
txtV.SelLength = Len(txtV)
End Sub
Private Sub txtA_GotFocus()
txtA.SelStart = 0
txtA.SelLength = Len(txtA)
End Sub

Private Sub txtX_LostFocus()
UpdateTime
End Sub

Private Sub txtX_Validate(Cancel As Boolean)
If (Val(txtX) < -8388607) Or (Val(txtX) > 8388607) Then
   MsgBox "Invalid register setting.  Must be from -8388607 to 8388607", , "Out of Range"
   Cancel = True
End If
End Sub
