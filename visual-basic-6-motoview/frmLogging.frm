VERSION 5.00
Begin VB.Form frmLogging 
   Caption         =   "Communication Log"
   ClientHeight    =   4830
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   8565
   Icon            =   "frmLogging.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   4830
   ScaleWidth      =   8565
   StartUpPosition =   3  'Windows Default
   Begin VB.CommandButton cmdClose 
      Caption         =   "Close"
      Height          =   495
      Left            =   6720
      TabIndex        =   3
      Top             =   4080
      Width           =   1455
   End
   Begin VB.TextBox Text1 
      BeginProperty Font 
         Name            =   "Courier New"
         Size            =   9
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   3135
      Left            =   240
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   2
      Text            =   "frmLogging.frx":1042
      Top             =   720
      Width           =   7935
   End
   Begin VB.CommandButton cmdStop 
      Caption         =   "Stop"
      Height          =   375
      Left            =   2040
      TabIndex        =   1
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton cmdStart 
      Caption         =   "Start"
      Height          =   375
      Left            =   240
      TabIndex        =   0
      Top             =   120
      Width           =   1575
   End
End
Attribute VB_Name = "frmLogging"
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
Const COL_WIDTH = 8
Dim rxCol As Integer
Dim txCol As Integer
Dim Spaces As String

Public Sub ShowRX(rxData As String)
Dim strHex As String
Dim ch As Integer
Dim i As Integer

If Len(rxData) = 0 Then Exit Sub

If txCol <> 0 Then
  txCol = 0   'reset TX column when we get RX data
  Text1 = Text1 & vbCrLf
End If

'Loop through new data, one byte at a time:
For i = 1 To Len(rxData)
  If rxCol = 0 Then Text1 = Text1 & Left(Spaces, COL_WIDTH * 3) & " RX: "
  ch = Asc(Mid(rxData, i, 1))
  If (ch < 16) And (ch > 9) Then
    strHex = "0"  'Need to add a leading zero to hex codes $A thru $F
  Else
    strHex = ""
  End If
  strHex = strHex & Format(Hex(ch), "00")
  Text1 = Text1 & " " & strHex
  rxCol = rxCol + 1
  If (rxCol Mod COL_WIDTH = 0) Then
    Text1 = Text1 & "    " & vbCrLf
    rxCol = 0
    Text1.SelStart = Len(Text1) - 1
    Text1.SelLength = 1
  End If
  Text1.SelStart = Len(Text1) - 1
  Text1.SelLength = 0
Next 'i
End Sub

Public Sub ShowTX(txData As String)
Dim strHex As String
Dim ch As Integer
Dim i As Integer

If Len(txData) = 0 Then Exit Sub

If rxCol <> 0 Then
  rxCol = 0   'reset RX column when we get TX data
  Text1 = Text1 & vbCrLf
End If
'Loop through new data, one byte at a time:
For i = 1 To Len(txData)
  If txCol = 0 Then Text1 = Text1 & "TX:"
  ch = Asc(Mid(txData, i, 1))
  If (ch < 16) And (ch > 9) Then
    strHex = "0"  'Need to add a leading zero to hex codes $A thru $F
  Else
    strHex = ""
  End If
  strHex = strHex & Format(Hex(ch), "00")
  Text1 = Text1 & " " & strHex
  txCol = rxCol + 1
  If (txCol Mod COL_WIDTH = 0) Then
    Text1 = Text1 & "    " & vbCrLf
    txCol = 0
  End If
  Text1.SelStart = Len(Text1) - 1
  Text1.SelLength = 0
Next 'i
End Sub


Private Sub cmdClose_Click()
SaveSetting App.Title, Me.Name, "left", Me.Left
SaveSetting App.Title, Me.Name, "top", Me.Top
SaveSetting App.Title, Me.Name, "width", Me.Width
SaveSetting App.Title, Me.Name, "height", Me.Height
frmMain.Logging = False
Unload Me
End Sub

Private Sub cmdStart_Click()
frmMain.Logging = True
cmdStart.Enabled = False
cmdStop.Enabled = True
End Sub

Private Sub cmdStop_Click()
frmMain.Logging = False
cmdStop.Enabled = False
cmdStart.Enabled = True
End Sub

Private Sub Form_Load()
If frmMain.MV_version = frmMain.MV_stored_version Then
    Me.Left = GetSetting(App.Title, Me.Name, "left", 2000)
    Me.Top = GetSetting(App.Title, Me.Name, "top", 1000)
    Me.Width = GetSetting(App.Title, Me.Name, "width", 6495)
    Me.Height = GetSetting(App.Title, Me.Name, "height", 5295)
Else
    Me.Left = 2000
    Me.Top = 1000
    Me.Width = 6495
    Me.Height = 5295
End If

cmdStart.Enabled = False
frmMain.Logging = True
Text1 = ""
rxCol = 0
txCol = 0
Spaces = "                                                            "
End Sub

Private Sub Form_Resize()
If Me.Width < 3870 Then Me.Width = 3870: Exit Sub
If Me.Height < 2210 Then Me.Height = 2210: Exit Sub
Text1.Width = Me.Width - 675
Text1.Height = Me.Height - 2160
cmdClose.Left = Me.Width - 1890
cmdClose.Top = Me.Height - 1215
End Sub

Private Sub Form_Terminate()
frmMain.Logging = False
End Sub

Private Sub Form_Unload(Cancel As Integer)
frmMain.Logging = False
End Sub
