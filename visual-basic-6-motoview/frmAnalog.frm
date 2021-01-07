VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "mscomctl.ocx"
Begin VB.Form frmAnalog 
   Caption         =   "Analog Readings"
   ClientHeight    =   4260
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5100
   Icon            =   "frmAnalog.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4260
   ScaleWidth      =   5100
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Default         =   -1  'True
      Height          =   375
      Left            =   3600
      TabIndex        =   0
      Top             =   3720
      Width           =   1095
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Left            =   0
      Top             =   1560
   End
   Begin VB.TextBox txtAnalog 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   4
      Left            =   3840
      TabIndex        =   14
      Text            =   "Text1"
      Top             =   3000
      Width           =   735
   End
   Begin VB.TextBox txtAnalog 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   3
      Left            =   2880
      TabIndex        =   11
      Text            =   "Text1"
      Top             =   3000
      Width           =   735
   End
   Begin VB.TextBox txtAnalog 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   2
      Left            =   2040
      TabIndex        =   8
      Text            =   "Text1"
      Top             =   3000
      Width           =   735
   End
   Begin VB.TextBox txtAnalog 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   1
      Left            =   1200
      TabIndex        =   5
      Text            =   "Text1"
      Top             =   3000
      Width           =   735
   End
   Begin VB.TextBox txtAnalog 
      Alignment       =   2  'Center
      Height          =   285
      Index           =   0
      Left            =   360
      TabIndex        =   2
      Text            =   "Text1"
      Top             =   3000
      Width           =   735
   End
   Begin MSComctlLib.Slider sldAnalog 
      Height          =   2535
      Index           =   0
      Left            =   600
      TabIndex        =   1
      Top             =   360
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   4471
      _Version        =   393216
      Orientation     =   1
      Max             =   1024
      TickFrequency   =   102
   End
   Begin MSComctlLib.Slider sldAnalog 
      Height          =   2535
      Index           =   1
      Left            =   1440
      TabIndex        =   4
      Top             =   360
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   4471
      _Version        =   393216
      Orientation     =   1
      Max             =   1024
      TickFrequency   =   102
   End
   Begin MSComctlLib.Slider sldAnalog 
      Height          =   2535
      Index           =   2
      Left            =   2280
      TabIndex        =   7
      Top             =   360
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   4471
      _Version        =   393216
      Orientation     =   1
      Max             =   1024
      TickFrequency   =   102
   End
   Begin MSComctlLib.Slider sldAnalog 
      Height          =   2535
      Index           =   3
      Left            =   3120
      TabIndex        =   10
      Top             =   360
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   4471
      _Version        =   393216
      Orientation     =   1
      Max             =   1024
      TickFrequency   =   102
   End
   Begin MSComctlLib.Slider sldAnalog 
      Height          =   2535
      Index           =   4
      Left            =   4080
      TabIndex        =   13
      Top             =   360
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   4471
      _Version        =   393216
      Orientation     =   1
      Max             =   1024
      TickFrequency   =   102
   End
   Begin VB.Label Label8 
      Alignment       =   2  'Center
      Caption         =   "Current"
      Height          =   255
      Left            =   360
      TabIndex        =   22
      Top             =   3840
      Width           =   615
   End
   Begin VB.Label Label7 
      Alignment       =   2  'Center
      Caption         =   "Motor"
      Height          =   255
      Left            =   360
      TabIndex        =   21
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label6 
      Alignment       =   2  'Center
      Caption         =   "1024"
      Height          =   255
      Left            =   3840
      TabIndex        =   20
      Top             =   120
      Width           =   615
   End
   Begin VB.Label Label5 
      Alignment       =   2  'Center
      Caption         =   "1024"
      Height          =   255
      Left            =   2880
      TabIndex        =   19
      Top             =   120
      Width           =   615
   End
   Begin VB.Label Label4 
      Alignment       =   2  'Center
      Caption         =   "1024"
      Height          =   255
      Left            =   2040
      TabIndex        =   18
      Top             =   120
      Width           =   615
   End
   Begin VB.Label Label3 
      Alignment       =   2  'Center
      Caption         =   "1024"
      Height          =   255
      Left            =   1200
      TabIndex        =   17
      Top             =   120
      Width           =   615
   End
   Begin VB.Label Label2 
      Alignment       =   2  'Center
      Caption         =   "1024"
      Height          =   255
      Left            =   360
      TabIndex        =   16
      Top             =   120
      Width           =   615
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "A4"
      Height          =   255
      Index           =   4
      Left            =   3960
      TabIndex        =   15
      Top             =   3360
      Width           =   375
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "A3"
      Height          =   255
      Index           =   3
      Left            =   3000
      TabIndex        =   12
      Top             =   3360
      Width           =   375
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "A2"
      Height          =   255
      Index           =   2
      Left            =   2160
      TabIndex        =   9
      Top             =   3360
      Width           =   375
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "A1"
      Height          =   255
      Index           =   1
      Left            =   1320
      TabIndex        =   6
      Top             =   3360
      Width           =   375
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "A0"
      Height          =   255
      Index           =   0
      Left            =   480
      TabIndex        =   3
      Top             =   3360
      Width           =   375
   End
End
Attribute VB_Name = "frmAnalog"
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

Option Explicit
Dim qIndex As Integer
Dim Cmd As String
Dim InData As String
Dim i As Integer

Private Sub cmdClose_Click()
SaveSetting App.Title, Me.Name, "left", Me.Left
SaveSetting App.Title, Me.Name, "top", Me.Top
SaveSetting App.Title, Me.Name, "width", Me.Width
SaveSetting App.Title, Me.Name, "height", Me.Height
Timer1.Enabled = False
Unload Me
End Sub

Public Sub SetSize()
If frmMain.MV_version = frmMain.MV_stored_version Then
    Me.Left = GetSetting(App.Title, Me.Name, "left", 5070)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 3435)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 5220)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 4665)
Else
    Me.Left = 5070
    Me.Top = 3435
    Me.Width = 5220
    Me.Height = 4665
End If

End Sub
Private Sub Form_Load()
Timer1.Interval = 100
End Sub

Private Sub Form_Resize()
If frmMain.MSComm1.PortOpen Then
  Timer1.Enabled = True
End If
End Sub

Private Sub Timer1_Timer()
Dim j As Integer
Dim InData2 As String
InData = ""
InData2 = ""
'Read 12 bytes, starting at Analog0, in 3 blocks of 4
For j = 0 To 2
    Cmd = Chr(&H82) & Chr(Analog0 + j * 4) & Chr(4)
    qIndex = frmMain.SendSerial(Cmd)
    'Wait for our response to be completed
    While Fifo(qIndex).bytesWaiting > 0
      DoEvents
    Wend
    InData2 = Fifo(qIndex).Response
    InData2 = Mid(InData2, 2, Len(InData2) - 2) 'strip off header (ACK) & CS
    InData = InData & InData2
Next j
For i = 0 To 4
    txtAnalog(i) = Asc(Mid(InData, 2 * i + 1, 1)) + 256 * CLng(Asc(Mid(InData, 2 * i + 2, 1)))
    sldAnalog(i).Value = sldAnalog(i).Max - Val(txtAnalog(i))
Next i
End Sub
