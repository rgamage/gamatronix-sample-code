VERSION 5.00
Begin VB.Form frmRCPconfig 
   Caption         =   "R/C Pulse Config"
   ClientHeight    =   7290
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5505
   Icon            =   "frmRCPconfig.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   7290
   ScaleWidth      =   5505
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdSaveToFlash 
      Caption         =   "Save to Flash"
      Height          =   495
      Left            =   960
      TabIndex        =   26
      Top             =   6600
      Width           =   1335
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Default         =   -1  'True
      Height          =   495
      Left            =   3960
      TabIndex        =   5
      Top             =   6600
      Width           =   1215
   End
   Begin VB.CommandButton cmdApply 
      Caption         =   "Apply"
      Height          =   495
      Left            =   2520
      TabIndex        =   4
      Top             =   6600
      Width           =   1215
   End
   Begin VB.Frame Frame2 
      Caption         =   "Config Settings"
      Height          =   3255
      Left            =   240
      TabIndex        =   15
      Top             =   3120
      Width           =   5055
      Begin VB.TextBox txtRCPmin 
         Height          =   285
         Left            =   1560
         TabIndex        =   0
         Text            =   "Text3"
         Top             =   360
         Width           =   1215
      End
      Begin VB.TextBox txtRCPmax 
         Height          =   285
         Left            =   1560
         TabIndex        =   2
         Text            =   "Text3"
         Top             =   1920
         Width           =   1215
      End
      Begin VB.TextBox txtSPmin 
         Height          =   285
         Left            =   1560
         TabIndex        =   1
         Text            =   "Text5"
         Top             =   1080
         Width           =   1215
      End
      Begin VB.TextBox txtSPmax 
         Height          =   285
         Left            =   1560
         TabIndex        =   3
         Text            =   "Text5"
         Top             =   2640
         Width           =   1215
      End
      Begin VB.Line Line1 
         X1              =   2040
         X2              =   2040
         Y1              =   720
         Y2              =   960
      End
      Begin VB.Line Line2 
         X1              =   2160
         X2              =   2040
         Y1              =   840
         Y2              =   960
      End
      Begin VB.Line Line3 
         X1              =   1920
         X2              =   2040
         Y1              =   840
         Y2              =   960
      End
      Begin VB.Line Line4 
         X1              =   2040
         X2              =   2040
         Y1              =   2280
         Y2              =   2520
      End
      Begin VB.Line Line5 
         X1              =   2160
         X2              =   2040
         Y1              =   2400
         Y2              =   2520
      End
      Begin VB.Line Line6 
         X1              =   1920
         X2              =   2040
         Y1              =   2400
         Y2              =   2520
      End
      Begin VB.Label Label4 
         Caption         =   "R/C Pulse Min:"
         Height          =   255
         Left            =   240
         TabIndex        =   23
         Top             =   360
         Width           =   1215
      End
      Begin VB.Label Label5 
         Caption         =   "R/C Pulse Max:"
         Height          =   255
         Left            =   240
         TabIndex        =   22
         Top             =   1920
         Width           =   1215
      End
      Begin VB.Label Label6 
         Caption         =   "(0 to 15000 counts)"
         Height          =   255
         Left            =   2880
         TabIndex        =   21
         Top             =   360
         Width           =   1695
      End
      Begin VB.Label Label7 
         Caption         =   "(0 to 15000 counts)"
         Height          =   255
         Left            =   2880
         TabIndex        =   20
         Top             =   1920
         Width           =   1575
      End
      Begin VB.Label Label9 
         Caption         =   "Setpoint Min:"
         Height          =   255
         Left            =   240
         TabIndex        =   19
         Top             =   1080
         Width           =   1215
      End
      Begin VB.Label Label10 
         Caption         =   "(-32767 to 32767)"
         Height          =   255
         Left            =   3000
         TabIndex        =   18
         Top             =   1080
         Width           =   1575
      End
      Begin VB.Label Label12 
         Caption         =   "Setpoint Max:"
         Height          =   255
         Left            =   240
         TabIndex        =   17
         Top             =   2640
         Width           =   1215
      End
      Begin VB.Label Label13 
         Caption         =   "(-32767 to 32767)"
         Height          =   255
         Left            =   3000
         TabIndex        =   16
         Top             =   2640
         Width           =   1575
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "R/C Pulse Readings"
      Height          =   2295
      Left            =   240
      TabIndex        =   6
      Top             =   600
      Width           =   5055
      Begin VB.TextBox txtsetPosition 
         Height          =   285
         Left            =   2520
         TabIndex        =   14
         Text            =   "Text6"
         Top             =   1680
         Width           =   1335
      End
      Begin VB.TextBox txtRCPrawms 
         Height          =   285
         Left            =   2520
         TabIndex        =   9
         Text            =   "Text2"
         Top             =   1320
         Width           =   1335
      End
      Begin VB.TextBox txtRCPraw 
         Height          =   285
         Left            =   2520
         TabIndex        =   8
         Text            =   "Text1"
         Top             =   960
         Width           =   1335
      End
      Begin VB.Label Label11 
         Caption         =   "Current setPosition:"
         Height          =   255
         Left            =   360
         TabIndex        =   13
         Top             =   1680
         Width           =   1575
      End
      Begin VB.Label Label8 
         Caption         =   "(5000 counts = 1 millisecond)"
         Height          =   255
         Left            =   1080
         TabIndex        =   12
         Top             =   480
         Width           =   2295
      End
      Begin VB.Label Label3 
         Caption         =   "ms"
         Height          =   255
         Left            =   3960
         TabIndex        =   11
         Top             =   1320
         Width           =   495
      End
      Begin VB.Label Label2 
         Caption         =   "counts"
         Height          =   255
         Left            =   3960
         TabIndex        =   10
         Top             =   960
         Width           =   495
      End
      Begin VB.Label Label1 
         Caption         =   "Current R/C Pulse Width:"
         Height          =   255
         Left            =   360
         TabIndex        =   7
         Top             =   960
         Width           =   1935
      End
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Left            =   0
      Top             =   0
   End
   Begin VB.Label Label14 
      Caption         =   "Remote Control Pulse Input Configuration"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   360
      TabIndex        =   27
      Top             =   120
      Width           =   4575
   End
   Begin VB.Label lblRCPwarn 
      Caption         =   "WARNING: R/C Pulse Input Mode is NOT enabled!"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000C0&
      Height          =   255
      Left            =   240
      TabIndex        =   25
      Top             =   120
      Visible         =   0   'False
      Width           =   4455
   End
   Begin VB.Label lblAnalogwarn 
      Caption         =   "WARNING: Analog Feedback Mode is NOT enabled!"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000C0&
      Height          =   255
      Left            =   240
      TabIndex        =   24
      Top             =   360
      Visible         =   0   'False
      Width           =   4695
   End
End
Attribute VB_Name = "frmRCPconfig"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub cmdApply_Click()
Write_Reg RCPmin, 2, CLng(Val(txtRCPmin))
Write_Reg RCPmax, 2, CLng(Val(txtRCPmax))
Write_Reg SPmin, 2, CLng(Val(txtSPmin))
Write_Reg SPmax, 2, CLng(Val(txtSPmax))

End Sub

Private Sub cmdClose_Click()
Timer1.Enabled = False
SaveSetting App.Title, Me.Name, "left", Me.Left
SaveSetting App.Title, Me.Name, "top", Me.Top
SaveSetting App.Title, Me.Name, "width", Me.Width
SaveSetting App.Title, Me.Name, "height", Me.Height
Unload Me
End Sub

Private Sub cmdSaveToFlash_Click()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Dim vbResponse As Variant
Dim Cmd As String
Timer1.Enabled = False
cmdApply_Click  'Make sure the current settings have been sent to the Gamoto
Cmd = Chr(&H1) & Chr(StoreFlashCmd)
vbResponse = MsgBox("This will save profiles AND all key PID parameters to Flash (Kp, Ki, Kd, etc.).  Are you sure?", vbOKCancel)
If vbResponse = vbOK Then
  qIndex = frmMain.SendSerial((Cmd))
  While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
    DoEvents
  Wend
End If
Timer1.Enabled = True
End Sub

Private Sub Form_Load()
Timer1.Interval = 100
If frmMain.MSComm1.PortOpen = True Then GetParms
lblRCPwarn.Visible = False
lblAnalogwarn.Visible = False
End Sub
Public Sub SetSize()
If frmMain.MV_version = frmMain.MV_stored_version Then
    Me.Left = GetSetting(App.Title, Me.Name, "left", 5685)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 2850)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 5625)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 7800)
Else
    Me.Left = 5685
    Me.Top = 2850
    Me.Width = 5625
    Me.Height = 7800
End If
End Sub
Private Sub Form_Resize()
If frmMain.MSComm1.PortOpen = True Then
    Timer1.Enabled = True
End If
End Sub
Private Function Read_Reg(RegAddress, Reglen) As Long
'Reads a Gamoto register, returns the value
Dim Cmd As String
Dim qIndex As Integer
Dim InData As String
Dim regData As Long

Cmd = Chr(&H82) & Chr(RegAddress) & Chr(Reglen)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend

If Fifo(qIndex).Error Then
   Timer1.Enabled = False
   Exit Function
End If
        
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)

Select Case Reglen
   Case 1
       regData = Asc(Mid(InData, 1, 1))
   Case 2
       regData = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1)))
   Case 3
       regData = Asc(Mid(InData, 1, 1)) + 256 * CLng(Asc(Mid(InData, 2, 1))) + 65536 * CLng(Asc(Mid(InData, 3, 1)))
End Select
        
If regData >= (2 ^ (8 * Reglen) / 2) Then
    regData = regData - 2 ^ (8 * Reglen)
End If
        
Read_Reg = regData
End Function

Private Sub Write_Reg(RegAddress, Reglen, RegValue)
'Writes to a Gamoto register
Dim Cmd As String
Dim qIndex As Integer
Dim InData As String
Dim regData As Long

Cmd = Chr(Reglen + 1) & Chr(RegAddress)
Select Case Reglen
  Case 1
     Cmd = Cmd & DecToHexchars8((RegValue))
  Case 2
     Cmd = Cmd & DecToHexchars16((RegValue))
  Case 3
    Cmd = Cmd & DecToHexchars24((RegValue))
End Select
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
   DoEvents
Wend
If Fifo(qIndex).Error Then
    Timer1.Enabled = False
    Exit Sub
End If
End Sub

Private Sub Timer1_Timer()

Dim gxMode2 As Integer

'Updates the raw R/C pulse value and setPosition value
txtRCPraw = Read_Reg(RCPraw, 2)
txtRCPrawms = Format(CSng(txtRCPraw) / 5000#, "0.000")
txtsetPosition = Read_Reg(setPosition, 3)
gxMode2 = Read_Reg(Mode2, 1)
If (gxMode2 And 32) <> 32 Then
   lblAnalogwarn.Visible = True
   Label14.Visible = False
Else
    lblAnalogwarn.Visible = False
End If
If (gxMode2 And 64) <> 64 Then
   lblRCPwarn.Visible = True
   Label14.Visible = False
Else
    lblRCPwarn.Visible = False
End If
If lblRCPwarn.Visible = False And lblAnalogwarn.Visible = False Then
   Label14.Visible = True
End If

End Sub

Private Sub GetParms()
'Loads all fields with current values in Gamoto
txtRCPraw = Read_Reg(RCPraw, 2)
txtRCPrawms = Format(CSng(txtRCPraw) / 5000#, "0.00")
txtsetPosition = Read_Reg(setPosition, 3)
txtRCPmax = Read_Reg(RCPmax, 2)
txtRCPmin = Read_Reg(RCPmin, 2)
txtSPmin = Read_Reg(SPmin, 2)
txtSPmax = Read_Reg(SPmax, 2)
End Sub

Private Sub txtRCPmax_GotFocus()
txtRCPmax.SelStart = 0
txtRCPmax.SelLength = Len(txtRCPmax)
End Sub

Private Sub txtRCPmax_Validate(Cancel As Boolean)
If (Val(txtRCPmax) < 0) Or (Val(txtRCPmax) > 15000) Then
   MsgBox "Invalid register setting.  Must be from 0 to 15000", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtRCPmin_Validate(Cancel As Boolean)
If (Val(txtRCPmin) < 0) Or (Val(txtRCPmin) > 15000) Then
   MsgBox "Invalid register setting.  Must be from 0 to 15000", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtSPmax_GotFocus()
txtSPmax.SelStart = 0
txtSPmax.SelLength = Len(txtSPmax)
End Sub

Private Sub txtSPmax_Validate(Cancel As Boolean)
If (Val(txtSPmax) < -32767) Or (Val(txtSPmax) > 32767) Then
   MsgBox "Invalid register setting.  Must be from -32767 to 32767", , "Out of Range"
   Cancel = True
End If
End Sub

Private Sub txtSPmin_GotFocus()
txtSPmin.SelStart = 0
txtSPmin.SelLength = Len(txtSPmin)
End Sub
Private Sub txtRCPmin_GotFocus()
txtRCPmin.SelStart = 0
txtRCPmin.SelLength = Len(txtRCPmin)
End Sub
Private Sub txtSPmin_Validate(Cancel As Boolean)
If (Val(txtSPmin) < -32767) Or (Val(txtSPmin) > 32767) Then
   MsgBox "Invalid register setting.  Must be from -32767 to 32767", , "Out of Range"
   Cancel = True
End If
End Sub
