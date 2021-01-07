VERSION 5.00
Object = "{65E121D4-0C60-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCHRT20.OCX"
Begin VB.Form frmRegView 
   Caption         =   "Register View"
   ClientHeight    =   5640
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3870
   Icon            =   "frmRegView.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   5640
   ScaleWidth      =   3870
   Begin VB.Frame Frame2 
      Caption         =   "Graph of Values"
      Height          =   5055
      Left            =   3960
      TabIndex        =   22
      Top             =   240
      Width           =   5175
      Begin VB.CommandButton cmdStop 
         Caption         =   "Stop"
         Height          =   375
         Left            =   2040
         TabIndex        =   26
         Top             =   4560
         Width           =   1215
      End
      Begin VB.CommandButton cmdStart 
         Caption         =   "Start"
         Height          =   375
         Left            =   360
         TabIndex        =   25
         Top             =   4560
         Width           =   1215
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Clear"
         Height          =   375
         Left            =   3720
         TabIndex        =   24
         Top             =   4560
         Width           =   1215
      End
      Begin MSChart20Lib.MSChart MSChart1 
         Height          =   4335
         Left            =   120
         OleObjectBlob   =   "frmRegView.frx":1042
         TabIndex        =   23
         Top             =   240
         Width           =   4815
      End
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Left            =   120
      Top             =   5040
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   9
      Left            =   480
      TabIndex        =   21
      Top             =   3960
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   9
      Left            =   2160
      TabIndex        =   20
      Top             =   3960
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   8
      Left            =   480
      TabIndex        =   19
      Top             =   3600
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   8
      Left            =   2160
      TabIndex        =   18
      Top             =   3600
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   7
      Left            =   480
      TabIndex        =   17
      Top             =   3240
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   7
      Left            =   2160
      TabIndex        =   16
      Top             =   3240
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   6
      Left            =   480
      TabIndex        =   15
      Top             =   2880
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   6
      Left            =   2160
      TabIndex        =   14
      Top             =   2880
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   5
      Left            =   480
      TabIndex        =   13
      Top             =   2520
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   5
      Left            =   2160
      TabIndex        =   12
      Top             =   2520
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   4
      Left            =   480
      TabIndex        =   11
      Top             =   2160
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   4
      Left            =   2160
      TabIndex        =   10
      Top             =   2160
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   3
      Left            =   480
      TabIndex        =   9
      Top             =   1800
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   3
      Left            =   2160
      TabIndex        =   8
      Top             =   1800
      Width           =   1095
   End
   Begin VB.ComboBox cboRegName 
      Height          =   315
      Index           =   2
      Left            =   480
      TabIndex        =   7
      Top             =   1440
      Width           =   1455
   End
   Begin VB.TextBox txtRegValue 
      Height          =   285
      Index           =   2
      Left            =   2160
      TabIndex        =   6
      Top             =   1440
      Width           =   1095
   End
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   375
      Left            =   2520
      TabIndex        =   3
      Top             =   5160
      Width           =   1215
   End
   Begin VB.Frame Frame1 
      Caption         =   "Register Values"
      Height          =   4815
      Left            =   240
      TabIndex        =   0
      Top             =   240
      Width           =   3495
      Begin VB.TextBox txtReglen 
         Height          =   285
         Left            =   1200
         TabIndex        =   28
         Top             =   4080
         Width           =   495
      End
      Begin VB.TextBox txtRegValue 
         Height          =   285
         Index           =   10
         Left            =   1920
         TabIndex        =   29
         Top             =   4080
         Width           =   1095
      End
      Begin VB.TextBox txtRegnum 
         Height          =   285
         Left            =   240
         TabIndex        =   27
         Top             =   4080
         Width           =   735
      End
      Begin VB.ComboBox cboRegName 
         Height          =   315
         Index           =   1
         Left            =   240
         TabIndex        =   5
         Top             =   840
         Width           =   1455
      End
      Begin VB.TextBox txtRegValue 
         Height          =   285
         Index           =   1
         Left            =   1920
         TabIndex        =   4
         Top             =   840
         Width           =   1095
      End
      Begin VB.TextBox txtRegValue 
         Height          =   285
         Index           =   0
         Left            =   1920
         TabIndex        =   2
         Top             =   480
         Width           =   1095
      End
      Begin VB.ComboBox cboRegName 
         Height          =   315
         Index           =   0
         Left            =   240
         TabIndex        =   1
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label3 
         Caption         =   "Reading"
         Height          =   255
         Left            =   1920
         TabIndex        =   32
         Top             =   4440
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Len"
         Height          =   255
         Left            =   1200
         TabIndex        =   31
         Top             =   4440
         Width           =   495
      End
      Begin VB.Label Label1 
         Caption         =   "Reg"
         Height          =   255
         Left            =   240
         TabIndex        =   30
         Top             =   4440
         Width           =   495
      End
   End
End
Attribute VB_Name = "frmRegView"
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
Option Compare Text     'for case-insensitive string comparisons
Dim mcRegs(21) As mcRegList
Dim PlotOn As Boolean
Dim Pending As Boolean

Private Sub FillRegList()
mcRegs(0).RegName = "Kp"
mcRegs(0).RegAddress = Kp
mcRegs(0).Reglen = 2
mcRegs(1).RegName = "Ki"
mcRegs(1).RegAddress = Ki
mcRegs(1).Reglen = 2
mcRegs(2).RegName = "Kd"
mcRegs(2).RegAddress = Kd
mcRegs(2).Reglen = 2
mcRegs(3).RegName = "iLimit"
mcRegs(3).RegAddress = iL
mcRegs(3).Reglen = 2
mcRegs(4).RegName = "dS"
mcRegs(4).RegAddress = dS
mcRegs(4).Reglen = 1
mcRegs(5).RegName = "Mode"
mcRegs(5).RegAddress = Mode
mcRegs(5).Reglen = 1
mcRegs(6).RegName = "pwrLimit"
mcRegs(6).RegAddress = pwrLimit
mcRegs(6).Reglen = 1
mcRegs(7).RegName = "setPosition"
mcRegs(7).RegAddress = setPosition
mcRegs(7).Reglen = 3
mcRegs(8).RegName = "mPosition"
mcRegs(8).RegAddress = mPosition
mcRegs(8).Reglen = 3
mcRegs(9).RegName = "setVelocity"
mcRegs(9).RegAddress = setVelocity
mcRegs(9).Reglen = 2
mcRegs(10).RegName = "mVelocity"
mcRegs(10).RegAddress = mVelocity
mcRegs(10).Reglen = 2
mcRegs(11).RegName = "Trajectory"
mcRegs(11).RegAddress = segnum
mcRegs(11).Reglen = 1
mcRegs(12).RegName = "mPower"
mcRegs(12).RegAddress = mPower
mcRegs(12).Reglen = 1
mcRegs(13).RegName = "Error"
mcRegs(13).RegAddress = u0
mcRegs(13).Reglen = 3
mcRegs(14).RegName = "Analog0"
mcRegs(14).RegAddress = Analog0
mcRegs(14).Reglen = 2
mcRegs(15).RegName = "Analog1"
mcRegs(15).RegAddress = Analog1
mcRegs(15).Reglen = 2
mcRegs(16).RegName = "Analog2"
mcRegs(16).RegAddress = Analog2
mcRegs(16).Reglen = 2
mcRegs(17).RegName = "Analog3"
mcRegs(17).RegAddress = Analog3
mcRegs(17).Reglen = 2
mcRegs(18).RegName = "Analog4"
mcRegs(18).RegAddress = Analog4
mcRegs(18).Reglen = 2
mcRegs(19).RegName = "Integral"
mcRegs(19).RegAddress = 67
mcRegs(19).Reglen = 2
mcRegs(20).RegName = "Mode2"
mcRegs(20).RegAddress = Mode2
mcRegs(20).Reglen = 1
mcRegs(21).RegName = "Version"
mcRegs(21).RegAddress = Version
mcRegs(21).Reglen = 1
'mcRegs(22).RegName = "fPosition"
'mcRegs(22).RegLen = 3
'mcRegs(22).RegAddress = 87
End Sub
Private Sub SortList()
Dim i As Integer
Dim mcReg As mcRegList
Dim Done As Boolean
Do
  Done = True
  For i = 0 To UBound(mcRegs) - 1
    If mcRegs(i).RegName > mcRegs(i + 1).RegName Then
        'swap these two items
       mcReg = mcRegs(i)
       mcRegs(i) = mcRegs(i + 1)
       mcRegs(i + 1) = mcReg
       Done = False
    End If
  Next i
Loop Until Done
End Sub
Private Sub cmdClose_Click()
Dim i As Integer
'Save watch list settings
For i = 0 To 9
    WatchList(i) = cboRegName(i).ListIndex
Next i
SaveSetting App.Title, Me.Name, "left", Me.Left
SaveSetting App.Title, Me.Name, "top", Me.Top
SaveSetting App.Title, Me.Name, "width", Me.Width
SaveSetting App.Title, Me.Name, "height", Me.Height
Timer1.Enabled = False
Unload Me
End Sub

Private Sub cmdStart_Click()
PlotOn = True

End Sub

Private Sub cmdStop_Click()
PlotOn = False
End Sub

Private Sub Command1_Click()
MSChart1.RowCount = 0
MSChart1.ColumnCount = 0

End Sub

Private Sub Form_Load()
Dim i As Integer
Dim j As Integer
Dim cBox As ComboBox
PlotOn = False
Timer1.Interval = 100
FillRegList
SortList
For i = 0 To 9
    For j = 0 To UBound(mcRegs)
        cboRegName(i).AddItem mcRegs(j).RegName
    Next j
Next
For i = 0 To 9
    cboRegName(i).ListIndex = Min(WatchList(i), cboRegName(i).ListCount - 1)
Next i
MSChart1.ColumnCount = 0
MSChart1.RowCount = 0

End Sub
Public Sub SetSize()
If frmMain.MV_version = frmMain.MV_stored_version Then
    Me.Left = GetSetting(App.Title, Me.Name, "left", 5685)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 2850)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 3990)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 6150)
Else
    Me.Left = 5685
    Me.Top = 2850
    Me.Width = 3990
    Me.Height = 6150
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

Private Sub Label3_Click()

End Sub

Private Sub Timer1_Timer()
Dim i As Integer
Dim lIndex As Integer
Dim Cmd As String
Dim qIndex As Integer
Dim InData As String
Dim regData As Long
Dim L As Integer
Dim R As Integer
Dim Reglen As Integer
Dim Regnum As Integer

If PlotOn Then
    MSChart1.RowCount = MSChart1.RowCount + 1
    MSChart1.Row = MSChart1.RowCount
End If

For i = 0 To 9
    lIndex = cboRegName(i).ListIndex
    regData = 0
    If lIndex >= 0 Then
        R = mcRegs(lIndex).RegAddress
        L = mcRegs(lIndex).Reglen
        txtRegValue(i) = Read_Reg(R, L)
    End If
    If i < 4 Then
        If PlotOn Then
            'Update chart
            MSChart1.ColumnCount = MSChart1.ColumnCount + 1
            MSChart1.Column = MSChart1.ColumnCount
            MSChart1.Data = regData
        End If
    End If
Next i
Regnum = Val(txtRegnum)
Reglen = Val(txtReglen)
If (Regnum > 3) And (Regnum < 240) And (Reglen > 0) And (Reglen < 5) Then
    txtRegValue(10) = Read_Reg(Regnum, Reglen)
End If
    
End Sub

Private Sub txtReglen_Change()

End Sub

Private Sub txtReglen_Validate(Cancel As Boolean)
If (Val(txtReglen) < 1 Or Val(txtReglen) > 4) Then
   Cancel = True
   MsgBox "Invalid register length.  Must be from 1 to 4", , "Out of Range"
End If
End Sub

Private Sub txtRegnum_Change()

End Sub

Private Sub txtRegnum_Validate(Cancel As Boolean)
If (Val(txtRegnum) < 0 Or Val(txtRegnum) > 255) Then
   Cancel = True
   MsgBox "Invalid register address.  Must be from 0 to 255", , "Out of Range"
End If
End Sub
