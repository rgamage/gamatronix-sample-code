VERSION 5.00
Begin VB.Form frmAbout 
   BackColor       =   &H80000005&
   Caption         =   "Gamatronix"
   ClientHeight    =   4020
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   5625
   Icon            =   "frmAbout.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4020
   ScaleWidth      =   5625
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox Picture1 
      AutoSize        =   -1  'True
      BackColor       =   &H80000009&
      BorderStyle     =   0  'None
      Height          =   1140
      Left            =   240
      Picture         =   "frmAbout.frx":1042
      ScaleHeight     =   1140
      ScaleWidth      =   3780
      TabIndex        =   5
      Top             =   240
      Width           =   3780
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Height          =   495
      Left            =   4080
      TabIndex        =   0
      Top             =   3240
      Width           =   1215
   End
   Begin VB.Label Label1 
      BackColor       =   &H80000005&
      Caption         =   "Copyright (C) 2004 Gamatronix"
      Height          =   255
      Left            =   480
      TabIndex        =   7
      Top             =   3600
      Width           =   3015
   End
   Begin VB.Label txtVersion 
      BackColor       =   &H80000005&
      Caption         =   "Firmware Version:"
      Height          =   255
      Left            =   480
      TabIndex        =   6
      Top             =   3240
      Width           =   3375
   End
   Begin VB.Label Label4 
      BackColor       =   &H80000005&
      Caption         =   "Configuration / Control software for the Gamoto PID motor controller"
      Height          =   255
      Left            =   480
      TabIndex        =   4
      Top             =   2520
      Width           =   5295
   End
   Begin VB.Label Label3 
      BackColor       =   &H80000005&
      Caption         =   "www.gamatronix.com"
      Height          =   255
      Left            =   480
      TabIndex        =   3
      Top             =   2880
      Width           =   1575
   End
   Begin VB.Label lblVersion 
      BackColor       =   &H80000005&
      Caption         =   "Version"
      Height          =   255
      Left            =   480
      TabIndex        =   2
      Top             =   2160
      Width           =   1575
   End
   Begin VB.Label lblAppName 
      BackColor       =   &H80000005&
      Caption         =   "App Name"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   24
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Left            =   480
      TabIndex        =   1
      Top             =   1560
      Width           =   3015
   End
End
Attribute VB_Name = "frmAbout"
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
Dim InData As String    ' temp storage of response string
Dim Cmd As String       ' Command string

Private Sub cmdOK_Click()
Unload Me
End Sub

Private Sub Form_Load()
lblVersion = "Version " & App.Major & "." & App.Minor & "." & App.Revision
lblAppName = App.EXEName
Me.Caption = App.CompanyName
If frmMain.MSComm1.PortOpen Then
    ReadVersion
Else
    txtVersion = "Firmware Version: NOT CONNECTED"
End If
End Sub
Private Sub ReadVersion()
Dim qIndex As Integer    ' Stores current queue item for calling routine
Dim i As Integer        'loop index var
Dim strBin As String    'binary string

'Read 1 byte, starting at Version
Cmd = Chr(&H82) & Chr(Version) & Chr(1)
qIndex = frmMain.SendSerial(Cmd)
'Wait for our response to be completed
While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
  DoEvents
Wend
If Fifo(qIndex).Error Then Exit Sub
InData = Fifo(qIndex).Response
InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
txtVersion = "Firmware Version: " & CStr(Asc(Mid(InData, 1, 1)))
End Sub

