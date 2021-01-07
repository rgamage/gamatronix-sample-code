VERSION 5.00
Begin VB.Form frmComm 
   Caption         =   "Communication Settings"
   ClientHeight    =   3465
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3330
   Icon            =   "frmComm.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   3465
   ScaleWidth      =   3330
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton cmdHelp 
      Caption         =   "?"
      Height          =   375
      Left            =   2880
      TabIndex        =   9
      Top             =   1440
      Width           =   375
   End
   Begin VB.ComboBox cboNode 
      Height          =   315
      Left            =   1560
      TabIndex        =   8
      Text            =   "Combo1"
      Top             =   1470
      Width           =   1095
   End
   Begin VB.CommandButton cmdOK 
      Caption         =   "OK"
      Default         =   -1  'True
      Height          =   375
      Left            =   1680
      TabIndex        =   6
      Top             =   2880
      Width           =   1095
   End
   Begin VB.CommandButton cmdCancel 
      Caption         =   "Cancel"
      Height          =   375
      Left            =   360
      TabIndex        =   5
      Top             =   2880
      Width           =   1095
   End
   Begin VB.ComboBox cboBaud 
      Height          =   315
      Left            =   1560
      TabIndex        =   4
      Text            =   "Combo2"
      Top             =   960
      Width           =   1095
   End
   Begin VB.ComboBox cboPort 
      Height          =   315
      Left            =   1560
      TabIndex        =   3
      Text            =   "Combo1"
      Top             =   480
      Width           =   1095
   End
   Begin VB.CheckBox chkOpen 
      Caption         =   "Open this COM port at startup"
      Height          =   255
      Left            =   360
      TabIndex        =   2
      Top             =   2040
      Width           =   2655
   End
   Begin VB.Label Label3 
      Caption         =   "Address:"
      Height          =   255
      Left            =   360
      TabIndex        =   7
      Top             =   1500
      Width           =   975
   End
   Begin VB.Label Label2 
      Caption         =   "Baud Rate:"
      Height          =   255
      Left            =   360
      TabIndex        =   1
      Top             =   960
      Width           =   975
   End
   Begin VB.Label Label1 
      Caption         =   "Com Port:"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   480
      Width           =   975
   End
End
Attribute VB_Name = "frmComm"
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

Private Sub cmdCancel_Click()
Unload Me
End Sub

Private Sub cmdHelp_Click()
MsgBox "The Gamoto Address setting allows MotoView to communicate with up to 8 Gamotos on the same RS-485 serial line.  This Address should correspond to switches 3,4, and 5 of Dipswitch 1.  It is normally set to 0 (all three switches in the OFF position), in the case of a normal RS-232 serial connection. Note that to use this feature, you must have firmware version 7 or higher (Help-About will display firmware version). See the user manual for more information.", vbOKOnly, "Help with Address setting"
End Sub

Private Sub cmdOK_Click()
frmMain.Baud = cboBaud.Text
frmMain.COMport = cboPort.Text
frmMain.Node = cboNode.Text
HEADER = &HAA + Val(frmMain.Node)
If chkOpen = 1 Then
   frmMain.OpenPortOnStart = True
Else
   frmMain.OpenPortOnStart = False
End If
Unload Me
End Sub
Private Sub Form_Load()
cboPort.AddItem "1"
cboPort.AddItem "2"
cboPort.AddItem "3"
cboPort.AddItem "4"
cboPort.Text = frmMain.COMport

cboBaud.AddItem "4800"
cboBaud.AddItem "9600"
cboBaud.AddItem "19200"
'debug
cboBaud.AddItem "115200"
'end debug
cboBaud.Text = frmMain.Baud

cboNode.AddItem "0"
cboNode.AddItem "1"
cboNode.AddItem "2"
cboNode.AddItem "3"
cboNode.AddItem "4"
cboNode.AddItem "5"
cboNode.AddItem "6"
cboNode.AddItem "7"

cboNode.Text = frmMain.Node

If frmMain.OpenPortOnStart Then
    chkOpen = 1
Else
    chkOpen = 0
End If

End Sub

