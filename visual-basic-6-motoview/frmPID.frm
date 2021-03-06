VERSION 5.00
Object = "{648A5603-2C6E-101B-82B6-000000000014}#1.1#0"; "MSCOMM32.OCX"
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form frmPID 
   Caption         =   "MotoView"
   ClientHeight    =   8190
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   9030
   Icon            =   "frmPID.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   8190
   ScaleWidth      =   9030
   Begin VB.Frame Frame5 
      Caption         =   "Gamoto Commands"
      Height          =   1695
      Left            =   4080
      TabIndex        =   54
      Top             =   4920
      Width           =   4695
      Begin VB.CommandButton cmdSaveToFlash 
         Caption         =   "Save Settings in Flash"
         Height          =   495
         Left            =   240
         TabIndex        =   58
         Top             =   360
         Width           =   2055
      End
      Begin VB.CommandButton cmdFactoryReset 
         Caption         =   "Reset to Factory Default"
         Height          =   495
         Left            =   240
         TabIndex        =   57
         Top             =   960
         Width           =   2055
      End
      Begin VB.CommandButton cmdReset 
         Caption         =   "Reset Gamoto"
         Height          =   495
         Left            =   2520
         TabIndex        =   56
         Top             =   360
         Width           =   1935
      End
      Begin VB.CommandButton cmdSetHome 
         Caption         =   "Set Home"
         Height          =   495
         Left            =   2520
         TabIndex        =   55
         Top             =   960
         Width           =   1935
      End
   End
   Begin VB.PictureBox Picture1 
      AutoSize        =   -1  'True
      BorderStyle     =   0  'None
      Height          =   420
      Left            =   240
      Picture         =   "frmPID.frx":1042
      ScaleHeight     =   420
      ScaleWidth      =   1500
      TabIndex        =   53
      Top             =   120
      Width           =   1500
   End
   Begin VB.Frame Frame3 
      Caption         =   "Mode2 Control"
      Height          =   3735
      Left            =   6480
      TabIndex        =   48
      Top             =   720
      Width           =   2295
      Begin VB.CheckBox Check1 
         Caption         =   "Reverse Motor*"
         Height          =   255
         Index           =   15
         Left            =   240
         TabIndex        =   68
         Top             =   2880
         Width           =   1935
      End
      Begin VB.CheckBox Check1 
         Caption         =   "R/C Pulse Input*"
         Height          =   255
         Index           =   14
         Left            =   240
         TabIndex        =   64
         Top             =   2520
         Width           =   1935
      End
      Begin VB.CheckBox Check1 
         Caption         =   "AnalogFeedback*"
         Height          =   255
         Index           =   13
         Left            =   240
         TabIndex        =   63
         Top             =   2160
         Width           =   1935
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Step/Dir Input Enable*"
         Height          =   255
         Index           =   12
         Left            =   240
         TabIndex        =   61
         Top             =   1800
         Width           =   1935
      End
      Begin VB.CheckBox Check1 
         Caption         =   "115200 Baud rate*"
         Height          =   255
         Index           =   11
         Left            =   240
         TabIndex        =   60
         Top             =   1440
         Width           =   1815
      End
      Begin VB.CheckBox Check1 
         Caption         =   "SerialShare Enable*"
         Height          =   255
         Index           =   10
         Left            =   240
         TabIndex        =   59
         Top             =   1080
         Width           =   1815
      End
      Begin VB.CheckBox Check1 
         Caption         =   "MotionDone Enable"
         Height          =   255
         Index           =   9
         Left            =   240
         TabIndex        =   52
         Top             =   720
         Width           =   1815
      End
      Begin VB.TextBox txtMode2 
         Height          =   285
         Left            =   240
         TabIndex        =   51
         Top             =   3240
         Width           =   615
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   9
         Left            =   1320
         TabIndex        =   50
         Top             =   3240
         Width           =   735
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Homing Mode"
         Height          =   255
         Index           =   8
         Left            =   240
         TabIndex        =   49
         Top             =   360
         Width           =   1455
      End
   End
   Begin VB.CommandButton mdClose 
      Caption         =   "Close"
      CausesValidation=   0   'False
      Height          =   495
      Left            =   6720
      TabIndex        =   46
      Top             =   6840
      Width           =   2055
   End
   Begin VB.CommandButton cmdReadRegisters 
      Caption         =   "Refresh Registers"
      Height          =   495
      Left            =   4080
      TabIndex        =   44
      Top             =   6840
      Width           =   2295
   End
   Begin VB.Frame Frame2 
      Caption         =   "Mode Control"
      Height          =   3735
      Left            =   4080
      TabIndex        =   35
      Top             =   720
      Width           =   2295
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   7
         Left            =   1200
         TabIndex        =   23
         Top             =   3240
         Width           =   735
      End
      Begin VB.TextBox txtMode 
         Height          =   285
         Left            =   240
         TabIndex        =   12
         Top             =   3240
         Width           =   615
      End
      Begin VB.CheckBox Check1 
         Caption         =   "LAP PWM Mode*"
         Height          =   255
         Index           =   7
         Left            =   240
         TabIndex        =   43
         Top             =   2880
         Width           =   1815
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Overtemp Condition"
         Height          =   255
         Index           =   6
         Left            =   240
         TabIndex        =   42
         Top             =   2520
         Width           =   1935
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Brake On"
         Height          =   255
         Index           =   5
         Left            =   240
         TabIndex        =   41
         Top             =   2160
         Width           =   1575
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Power Mode"
         Height          =   255
         Index           =   4
         Left            =   240
         TabIndex        =   40
         Top             =   1800
         Width           =   1575
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Stop Gracefully"
         Height          =   255
         Index           =   3
         Left            =   240
         TabIndex        =   39
         Top             =   1440
         Width           =   1575
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Velocity Mode"
         Height          =   255
         Index           =   2
         Left            =   240
         TabIndex        =   38
         Top             =   1080
         Width           =   1575
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Trajectory Mode"
         Height          =   255
         Index           =   1
         Left            =   240
         TabIndex        =   37
         Top             =   720
         Width           =   1575
      End
      Begin VB.CheckBox Check1 
         Caption         =   "Motor Power Enable"
         Height          =   255
         Index           =   0
         Left            =   240
         TabIndex        =   36
         Top             =   360
         Width           =   1935
      End
   End
   Begin MSCommLib.MSComm MSComm1 
      Left            =   7680
      Top             =   120
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      DTREnable       =   -1  'True
      RThreshold      =   1
      BaudRate        =   19200
   End
   Begin VB.Frame Frame4 
      Caption         =   "Interactive Position Control"
      Height          =   2175
      Left            =   240
      TabIndex        =   26
      Top             =   5640
      Width           =   3615
      Begin VB.CommandButton cmdStop 
         Caption         =   "STOP"
         Height          =   375
         Left            =   2160
         TabIndex        =   47
         Top             =   1560
         Width           =   975
      End
      Begin VB.CommandButton cmdStart 
         Caption         =   "START"
         Height          =   375
         Left            =   240
         TabIndex        =   32
         Top             =   1560
         Width           =   975
      End
      Begin VB.TextBox txtSetpoint 
         Height          =   285
         Left            =   1320
         TabIndex        =   28
         Top             =   1080
         Width           =   975
      End
      Begin MSComctlLib.Slider Slider1 
         Height          =   255
         Left            =   240
         TabIndex        =   27
         Top             =   360
         Width           =   2895
         _ExtentX        =   5106
         _ExtentY        =   450
         _Version        =   393216
         Max             =   50
      End
      Begin VB.Label lblMax 
         Alignment       =   1  'Right Justify
         Caption         =   "100"
         Height          =   255
         Left            =   2520
         TabIndex        =   31
         Top             =   720
         Width           =   615
      End
      Begin VB.Label lblMin 
         Caption         =   "-100"
         Height          =   255
         Left            =   120
         TabIndex        =   30
         Top             =   720
         Width           =   615
      End
      Begin VB.Label Label7 
         Caption         =   "Setpoint:"
         Height          =   255
         Left            =   480
         TabIndex        =   29
         Top             =   1080
         Width           =   735
      End
   End
   Begin MSComctlLib.StatusBar StatusBar1 
      Align           =   2  'Align Bottom
      Height          =   255
      Left            =   0
      TabIndex        =   25
      Top             =   7935
      Width           =   9030
      _ExtentX        =   15928
      _ExtentY        =   450
      _Version        =   393216
      BeginProperty Panels {8E3867A5-8586-11D1-B16A-00C0F0283628} 
         NumPanels       =   2
         BeginProperty Panel1 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            AutoSize        =   1
            Object.Width           =   11853
         EndProperty
         BeginProperty Panel2 {8E3867AB-8586-11D1-B16A-00C0F0283628} 
            Object.Width           =   3528
            MinWidth        =   3528
         EndProperty
      EndProperty
   End
   Begin VB.Frame Frame1 
      Caption         =   "Registers"
      Height          =   4815
      Left            =   240
      TabIndex        =   0
      Top             =   720
      Width           =   3615
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   10
         Left            =   2400
         TabIndex        =   67
         Top             =   4320
         Width           =   735
      End
      Begin VB.TextBox txtStepSize 
         Height          =   285
         Left            =   1200
         TabIndex        =   66
         Top             =   4320
         Width           =   975
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   8
         Left            =   2400
         TabIndex        =   22
         Top             =   3840
         Width           =   735
      End
      Begin VB.TextBox txtpwrLimit 
         Height          =   285
         Left            =   1200
         TabIndex        =   11
         Top             =   3840
         Width           =   975
      End
      Begin VB.TextBox txtVel 
         Height          =   285
         Left            =   1200
         TabIndex        =   10
         Top             =   3360
         Width           =   975
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   6
         Left            =   2400
         TabIndex        =   21
         Top             =   3360
         Width           =   735
      End
      Begin VB.TextBox txtmP 
         Height          =   285
         Left            =   1200
         TabIndex        =   9
         Top             =   2880
         Width           =   975
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   5
         Left            =   2400
         TabIndex        =   20
         Top             =   2880
         Width           =   735
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   4
         Left            =   2400
         TabIndex        =   19
         Top             =   2400
         Width           =   735
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   3
         Left            =   2400
         TabIndex        =   18
         Top             =   1920
         Width           =   735
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   2
         Left            =   2400
         TabIndex        =   17
         Top             =   1440
         Width           =   735
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   1
         Left            =   2400
         TabIndex        =   16
         Top             =   960
         Width           =   735
      End
      Begin VB.CommandButton cmdEnter 
         Caption         =   "Enter"
         Height          =   255
         Index           =   0
         Left            =   2400
         TabIndex        =   15
         Top             =   480
         Width           =   735
      End
      Begin VB.TextBox txtdS 
         Height          =   285
         Left            =   1200
         TabIndex        =   8
         Top             =   2400
         Width           =   975
      End
      Begin VB.TextBox txtiL 
         Height          =   285
         Left            =   1200
         TabIndex        =   7
         Top             =   1920
         Width           =   975
      End
      Begin VB.TextBox txtD 
         Height          =   285
         Left            =   1200
         TabIndex        =   6
         Top             =   1440
         Width           =   975
      End
      Begin VB.TextBox txtI 
         Height          =   285
         Left            =   1200
         TabIndex        =   5
         Top             =   960
         Width           =   975
      End
      Begin VB.TextBox txtP 
         Height          =   285
         Left            =   1200
         TabIndex        =   4
         Top             =   480
         Width           =   975
      End
      Begin VB.Label Label12 
         Caption         =   "StepSize:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   65
         Top             =   4320
         Width           =   1095
      End
      Begin VB.Label Label11 
         Caption         =   "pwrLim"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   45
         Top             =   3840
         Width           =   855
      End
      Begin VB.Label Label10 
         Caption         =   "Veloc:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   34
         Top             =   3360
         Width           =   855
      End
      Begin VB.Label Label9 
         Caption         =   "mPwr:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   33
         Top             =   2880
         Width           =   615
      End
      Begin VB.Label Label5 
         Caption         =   "dS:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   14
         Top             =   2400
         Width           =   375
      End
      Begin VB.Label Label4 
         Caption         =   "iL:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   1920
         Width           =   375
      End
      Begin VB.Label Label3 
         Caption         =   "Kd:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   1440
         Width           =   375
      End
      Begin VB.Label Label2 
         Caption         =   "Ki:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   960
         Width           =   255
      End
      Begin VB.Label Label1 
         Caption         =   "Kp:"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   480
         Width           =   375
      End
   End
   Begin VB.Timer Timer1 
      Interval        =   100
      Left            =   8400
      Top             =   120
   End
   Begin VB.Label Label8 
      Caption         =   "* Need to Save To Flash, then Reset before these take effect"
      Height          =   255
      Left            =   3960
      TabIndex        =   62
      Top             =   4560
      Width           =   4575
   End
   Begin VB.Label Label6 
      Caption         =   "Gamoto-1 Motor Control Panel"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   13.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2520
      TabIndex        =   24
      Top             =   240
      Width           =   4215
   End
End
Attribute VB_Name = "frmPID"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'MotoView - A configuration / testing tool for the Gamoto PID Motor Controller
'2004 Randy Gamage
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

Dim i As Long           ' general index
Dim numAxes As Long     ' number of axes added to form
Dim bStream As Boolean  ' Enable streaming of position data to controller
Dim SliderX As Single   ' X position of mouse over slider control
Dim checksum As Byte    ' byte checksum
Dim InData As String    ' temp storage of response string
Dim Cmd As String       ' Command string
                    
Private Sub Check1_Click(Index As Integer)
Dim i As Integer
Dim newMode As Integer
Dim newMode2 As Integer
For i = 0 To 7
 If Check1(i).Value = 1 Then newMode = newMode + 2 ^ i
Next i
txtMode = newMode
For i = 0 To 7
  If Check1(i + 8).Value = 1 Then newMode2 = newMode2 + 2 ^ i
Next i
txtMode2 = newMode2
End Sub

Private Sub cmdEnter_Click(Index As Integer)
Dim qIndex As Integer    ' Stores current queue item for calling routine
 Select Case Index
 Case 0 'P
  Cmd = Chr(&H3) & Chr(Kp) & DecToHexchars16(Val(txtP))
  qIndex = frmMain.SendSerial(Cmd)
 Case 1 'I
  Cmd = Chr(&H3) & Chr(Ki) & DecToHexchars16(Val(txtI))
  qIndex = frmMain.SendSerial(Cmd)
 Case 2 'D
  Cmd = Chr(&H3) & Chr(Kd) & DecToHexchars16(Val(txtD))
  qIndex = frmMain.SendSerial(Cmd)
 Case 3 'iL
  Cmd = Chr(&H3) & Chr(iL) & DecToHexchars16(Val(txtiL))
  qIndex = frmMain.SendSerial(Cmd)
 Case 4 'dS
  Cmd = Chr(&H2) & Chr(dS) & DecToHexchars8(Val(txtdS))
  qIndex = frmMain.SendSerial(Cmd)
 Case 5 'mPower
  Cmd = Chr(&H2) & Chr(mPower) & DecToHexchars8(Val(txtmP))
  qIndex = frmMain.SendSerial(Cmd)
 Case 6 'Velocity
  Cmd = Chr(&H3) & Chr(setVelocity) & DecToHexchars16(Val(txtVel))
  qIndex = frmMain.SendSerial(Cmd)
 Case 7 'Mode from checkboxes
  Cmd = Chr(&H2) & Chr(Mode) & DecToHexchars8(Val(txtMode))
  qIndex = frmMain.SendSerial(Cmd)
 Case 8 'pwrLimit
  Cmd = Chr(&H2) & Chr(pwrLimit) & DecToHexchars8(Val(txtpwrLimit))
  qIndex = frmMain.SendSerial(Cmd)
 Case 9 'Mode2 from checkboxes
  Cmd = Chr(&H2) & Chr(Mode2) & DecToHexchars8(Val(txtMode2))
  qIndex = frmMain.SendSerial(Cmd)
 Case 10 'StepSize
  Cmd = Chr(&H2) & Chr(StepSize) & DecToHexchars8(Val(txtStepSize))
  qIndex = frmMain.SendSerial(Cmd)
 End Select
'Wait for our command to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
End Sub

Private Sub cmdFactoryReset_Click()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Cmd = Chr(&H1) & Chr(FactoryResetCmd)
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
GetParms
End Sub

Private Sub cmdReset_Click()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Cmd = Chr(&H1) & Chr(ResetCmd)
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
GetParms
End Sub

Private Sub cmdSaveToFlash_Click()
Dim qIndex As Integer    ' Stores current queue item for calling routine
  Cmd = Chr(&H1) & Chr(StoreFlashCmd)
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
cmdReset_Click
GetParms
End Sub

Private Sub cmdSetHome_Click()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Cmd = Chr(&H1) & Chr(SetHomeCmd)
qIndex = frmMain.SendSerial(Cmd)
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
End Sub

Private Sub cmdStart_Click()
bStream = True
cmdStart.Enabled = False
cmdStop.Enabled = True
Slider1.Enabled = True
txtSetpoint.Enabled = True
cmdStop.SetFocus
End Sub

Private Sub cmdStop_Click()
bStream = False
cmdStart.Enabled = True
cmdStop.Enabled = False
Slider1.Enabled = False
txtSetpoint.Enabled = False
cmdStart.SetFocus
End Sub

Private Sub cmdTest_Click()
'Internal Verification test: Try writing to 4 consecutive bytes, then reading back

Dim qIndex As Integer    ' Stores current queue item for calling routine

  Cmd = Chr(&H5) & Chr(setPosition - 1) & Chr(1) & Chr(2) & Chr(3) & Chr(4)
  qIndex = frmMain.SendSerial(Cmd)

'Wait for our command to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend

'Read 4 bytes, starting at Kp
Cmd = Chr(&H82) & Chr(setPosition - 1) & Chr(4)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtP = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1)))
Debug.Print Asc(Mid(InData, 1, 1))
Debug.Print Asc(Mid(InData, 2, 1))
Debug.Print Asc(Mid(InData, 3, 1))
Debug.Print Asc(Mid(InData, 4, 1))
End Sub

Private Sub cmdTest2_Click()
'TEST CODE ADDED FOR DEBUGGING - Stresses serial communication
Dim angle As Single
Dim sinPos As Long
Const PI = 3.1415927
Dim qIndex As Integer
Dim Cmd As String
While 1 'Do forever
  angle = angle + 1 Mod 360
  sinPos = Sin(angle * PI / 180) * 500
  Cmd = Chr(&H4) & Chr(setPosition) & DecToHexchars24(Val(sinPos))
  qIndex = frmMain.SendSerial(Cmd)
  While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
     DoEvents
  Wend
  If Fifo(qIndex).Error Then MsgBox "ERROR!", vbCritical
  'Read 3 bytes, starting at mPosition
  Cmd = Chr(&H82) & Chr(mPosition) & Chr(3)
  qIndex = frmMain.SendSerial(Cmd)
  'Wait for our response to be completed
  While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
    DoEvents
  Wend
  If Fifo(qIndex).Error Then Exit Sub
Wend
'END TEST CODE
End Sub


Private Sub Form_Load()
On Error GoTo err1
   ' Start with timer disabled
   Timer1.Enabled = False
   Slider1.Value = CInt((Slider1.Max - Slider1.Min) / 2)
   SliderX = Slider1.Width / 2
  lblMax.MousePointer = 14
  lblMin.MousePointer = 14
  If frmMain.MSComm1.PortOpen Then
      StatusBar1.Panels(2) = "Connected"
      GetParms
  Else
      StatusBar1.Panels(2) = "NOT CONNECTED"
  End If
  ' Start the timer
  Timer1.Enabled = True

If frmMain.MV_version = frmMain.MV_stored_version Then
    Me.Left = GetSetting(App.Title, Me.Name, "left", 4410)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 1740)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 9150)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 8280)
Else
    Me.Left = 4410
    Me.Top = 1740
    Me.Width = 9150
    Me.Height = 8700
End If

Me.Show         'Have to show form before doing a setFocus command
cmdStop_Click   'Stop streaming position data, setfocus, disable some controls

Exit Sub
err1:
MsgBox Err.Number & ": " & Err.Description
End Sub

Private Sub cmdReadRegisters_Click()
GetParms
End Sub
Private Sub GetParms()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Dim i As Integer        'loop index var
Dim strBin As String    'binary string
Dim tmpMode2 As String   'temporary mode2 holder
Dim version_num As Integer  'firmware version number
'Read 4 bytes, starting at Kp
Cmd = Chr(&H82) & Chr(Kp) & Chr(4)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtP = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1)))
txtI = Asc(Mid(InData, 3, 1)) + 256 * CLng(Asc(Mid(InData, 4, 1)))

'Read 4 bytes, starting at Kd
Cmd = Chr(&H82) & Chr(Kd) & Chr(4)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtD = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1)))
txtiL = Asc(Mid(InData, 3, 1)) + 256 * CLng(Asc(Mid(InData, 4, 1)))

'Read 4 bytes, starting at dS
Cmd = Chr(&H82) & Chr(dS) & Chr(4)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtdS = Asc(Mid(InData, 1, 1))
txtMode = Asc(Mid(InData, 2, 1))
txtpwrLimit = Asc(Mid(InData, 3, 1))
txtMode2 = Asc(Mid(InData, 4, 1))
'Read 2 bytes, starting at setVelocity
Cmd = Chr(&H82) & Chr(setVelocity) & Chr(2)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtVel = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1)))
'Read 1 byte, starting at mPower
Cmd = Chr(&H82) & Chr(mPower) & Chr(1)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtmP = Asc(Mid(InData, 1, 1))

'Read 2 bytes, starting at Version
Cmd = Chr(&H82) & Chr(Version) & Chr(2)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
version_num = Asc(Mid(InData, 1, 1))
txtStepSize = Asc(Mid(InData, 2, 1))

'Check firmware version.  If early version, disable homing mode
If version_num < 8 Then
    Check1(8).Enabled = False
    txtMode2.Enabled = False
    cmdEnter(9).Enabled = False
End If
'Check firmware version.  If early version, disable MotionDone enable
If version_num < 9 Then
    Check1(9).Enabled = False
    cmdSetHome.Enabled = False
    cmdReset.Enabled = False
End If

'Check firmware version.  If early version, disable SerialShare enable
If version_num < 10 Then
    Check1(10).Enabled = False
End If

'Check firmware version.  If early version, disable SerialShare enable
If version_num < 11 Then
    Check1(11).Enabled = False
    Check1(12).Enabled = False
    Check1(13).Enabled = False
End If

'Check firmware version.  If early version, disable StepSize parameter
If version_num < 14 Then
    txtStepSize.Visible = False
    cmdEnter(10).Visible = False
    Label12.Visible = False
End If

'Check firmware version.  If early version, disable Motor Reverse
If version_num < 16 Then
    Check1(15).Enabled = False
End If

'Check firmware version.  If early version, disable R/C Pulse
If version_num < 13 Then
    Check1(14).Enabled = False
End If

tmpMode2 = txtMode2
'Fill in check boxes for Mode status
strBin = DecToBin(Val(txtMode))
For i = 0 To 7
    If Mid(strBin, 8 - i, 1) = "1" Then
        Check1(i).Value = 1
    Else
        Check1(i).Value = 0
    End If
Next i
'Fill in check boxes for Mode2 status
txtMode2 = tmpMode2
strBin = DecToBin(Val(txtMode2))
For i = 0 To 7
    If Mid(strBin, 8 - i, 1) = "1" Then
        Check1(i + 8).Value = 1
    Else
        Check1(i + 8).Value = 0
    End If
Next i
End Sub


Private Sub lblMax_Click()
Dim InVar As String
InVar = InputBox("Enter New Max:", "Set Value", lblMax)
If InVar <> "" Then lblMax = InVar

End Sub

Private Sub lblMin_Click()
Dim InVar As String
InVar = InputBox("Enter New Min:", "Set Value", lblMin)
If InVar <> "" Then lblMin = InVar
End Sub

Private Sub mdClose_Click()
SaveSetting App.Title, Me.Name, "left", Me.Left
SaveSetting App.Title, Me.Name, "top", Me.Top
SaveSetting App.Title, Me.Name, "width", Me.Width
SaveSetting App.Title, Me.Name, "height", Me.Height
Timer1.Enabled = False
Unload Me
End Sub
Private Sub Slider1_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)
Slider1.Value = x / Slider1.Width * Slider1.Max
SliderX = x
End Sub

Private Sub Timer1_Timer()
Dim qIndex As Integer    ' Stores current queue item for calling routine
If frmMain.MSComm1.PortOpen Then
    StatusBar1.Panels(2) = "Connected"
Else
    StatusBar1.Panels(2) = "NOT CONNECTED"
End If
txtSetpoint = CInt((lblMax - lblMin) * SliderX / Slider1.Width) + lblMin
If bStream Then
  Cmd = Chr(&H4) & Chr(setPosition) & DecToHexchars24(Val(txtSetpoint))
  qIndex = frmMain.SendSerial(Cmd)
  While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
     DoEvents
  Wend
  If Fifo(qIndex).Error Then MsgBox "ERROR!", vbCritical
  If Fifo(qIndex).Error Then cmdStop_Click 'Stop streaming in the case of an error
End If
End Sub

Private Sub txtD_Validate(Cancel As Boolean)
If (Val(txtD) < 0) Or (Val(txtD) > 65535) Then
   MsgBox "Invalid register setting.  Must be from 0 to 65535", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtdS_Validate(Cancel As Boolean)
If (Val(txtdS) < 0) Or (Val(txtdS) > 255) Then
   MsgBox "Invalid register setting.  Must be from 0 to 255", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtI_Validate(Cancel As Boolean)
If (Val(txtI) < 0) Or (Val(txtI) > 32767) Then
   MsgBox "Invalid register setting.  Must be from 0 to 32767", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtiL_Validate(Cancel As Boolean)
If (Val(txtiL) < 0) Or (Val(txtiL) > 32767) Then
   MsgBox "Invalid register setting.  Must be from 0 to 32767", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtMode_Validate(Cancel As Boolean)
If (Val(txtMode) < 0) Or (Val(txtMode) > 255) Then
   MsgBox "Invalid register setting.  Must be from 0 to 255", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtMode2_Validate(Cancel As Boolean)
If (Val(txtMode2) < 0) Or (Val(txtMode2) > 255) Then
   MsgBox "Invalid register setting.  Must be from 0 to 255", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtmP_Validate(Cancel As Boolean)
If (Val(txtmP) < -127) Or (Val(txtmP) > 127) Then
   MsgBox "Invalid register setting.  Must be from -127 to +127", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtP_GotFocus()
  cmdEnter(0).Default = True
  txtP.SelStart = 0
  txtP.SelLength = Len(txtP)
End Sub
Private Sub txtI_GotFocus()
  cmdEnter(1).Default = True
  txtI.SelStart = 0
  txtI.SelLength = Len(txtI)
End Sub
Private Sub txtD_GotFocus()
  cmdEnter(2).Default = True
  txtD.SelStart = 0
  txtD.SelLength = Len(txtD)
End Sub
Private Sub txtiL_GotFocus()
  cmdEnter(3).Default = True
  txtiL.SelStart = 0
  txtiL.SelLength = Len(txtiL)
End Sub
Private Sub txtdS_GotFocus()
  cmdEnter(4).Default = True
  txtdS.SelStart = 0
  txtdS.SelLength = Len(txtdS)
End Sub
Private Sub txtmP_GotFocus()
  cmdEnter(5).Default = True
  txtmP.SelStart = 0
  txtmP.SelLength = Len(txtmP)
End Sub

Private Sub txtP_Validate(Cancel As Boolean)
If Val(txtP) < 0 Or Val(txtP) > 65535 Then
   Cancel = True
End If
End Sub

Private Sub txtpwrLimit_Validate(Cancel As Boolean)
If (Val(txtpwrLimit) < 0) Or (Val(txtpwrLimit) > 255) Then
   MsgBox "Invalid register setting.  Must be from 0 to 255", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtStepSize_Validate(Cancel As Boolean)
If (Val(txtStepSize) < 0) Or (Val(txtStepSize) > 255) Then
   MsgBox "Invalid register setting.  Must be from 0 to 255", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtVel_GotFocus()
  cmdEnter(6).Default = True
  txtVel.SelStart = 0
  txtVel.SelLength = Len(txtVel)
End Sub
Private Sub txtMode_GotFocus()
  cmdEnter(7).Default = True
  txtMode.SelStart = 0
  txtMode.SelLength = Len(txtMode)
End Sub

Private Sub txtpwrLimit_GotFocus()
  cmdEnter(8).Default = True
  txtpwrLimit.SelStart = 0
  txtpwrLimit.SelLength = Len(txtpwrLimit)
End Sub
Private Sub txtMode2_GotFocus()
  cmdEnter(9).Default = True
  txtMode2.SelStart = 0
  txtMode2.SelLength = Len(txtMode2)
End Sub

Private Sub txtVel_Validate(Cancel As Boolean)
If (Val(txtVel) < -32767) Or (Val(txtVel) > 32767) Then
   MsgBox "Invalid register setting.  Must be from -32767 to +32767", , "Out of Range"
   Cancel = True
End If
End Sub
