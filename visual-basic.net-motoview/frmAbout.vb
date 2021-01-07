Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmAbout
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
				Catch
				End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents txtVersion As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents lblAppName As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Picture1 = New System.Windows.Forms.PictureBox
		Me.cmdOK = New System.Windows.Forms.Button
		Me.Label1 = New System.Windows.Forms.Label
		Me.txtVersion = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.lblVersion = New System.Windows.Forms.Label
		Me.lblAppName = New System.Windows.Forms.Label
		Me.BackColor = System.Drawing.SystemColors.Window
		Me.Text = "Gamatronix"
		Me.ClientSize = New System.Drawing.Size(375, 268)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmAbout.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAbout"
		Me.Picture1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.Picture1.Size = New System.Drawing.Size(252, 76)
		Me.Picture1.Location = New System.Drawing.Point(16, 16)
		Me.Picture1.Image = CType(resources.GetObject("Picture1.Image"), System.Drawing.Image)
		Me.Picture1.TabIndex = 5
		Me.Picture1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Picture1.Name = "Picture1"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "OK"
		Me.cmdOK.Size = New System.Drawing.Size(81, 33)
		Me.cmdOK.Location = New System.Drawing.Point(272, 216)
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.Label1.BackColor = System.Drawing.SystemColors.Window
		Me.Label1.Text = "Copyright (C) 2004 Gamatronix"
		Me.Label1.Size = New System.Drawing.Size(201, 17)
		Me.Label1.Location = New System.Drawing.Point(32, 240)
		Me.Label1.TabIndex = 7
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.txtVersion.BackColor = System.Drawing.SystemColors.Window
		Me.txtVersion.Text = "Firmware Version:"
		Me.txtVersion.Size = New System.Drawing.Size(225, 17)
		Me.txtVersion.Location = New System.Drawing.Point(32, 216)
		Me.txtVersion.TabIndex = 6
		Me.txtVersion.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVersion.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.txtVersion.Enabled = True
		Me.txtVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txtVersion.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVersion.UseMnemonic = True
		Me.txtVersion.Visible = True
		Me.txtVersion.AutoSize = False
		Me.txtVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtVersion.Name = "txtVersion"
		Me.Label4.BackColor = System.Drawing.SystemColors.Window
		Me.Label4.Text = "Configuration / Control software for the Gamoto PID motor controller"
		Me.Label4.Size = New System.Drawing.Size(353, 17)
		Me.Label4.Location = New System.Drawing.Point(32, 168)
		Me.Label4.TabIndex = 4
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.BackColor = System.Drawing.SystemColors.Window
		Me.Label3.Text = "www.gamatronix.com"
		Me.Label3.Size = New System.Drawing.Size(105, 17)
		Me.Label3.Location = New System.Drawing.Point(32, 192)
		Me.Label3.TabIndex = 3
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.lblVersion.BackColor = System.Drawing.SystemColors.Window
		Me.lblVersion.Text = "Version"
		Me.lblVersion.Size = New System.Drawing.Size(105, 17)
		Me.lblVersion.Location = New System.Drawing.Point(32, 144)
		Me.lblVersion.TabIndex = 2
		Me.lblVersion.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVersion.Enabled = True
		Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersion.UseMnemonic = True
		Me.lblVersion.Visible = True
		Me.lblVersion.AutoSize = False
		Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersion.Name = "lblVersion"
		Me.lblAppName.BackColor = System.Drawing.SystemColors.Window
		Me.lblAppName.Text = "App Name"
		Me.lblAppName.Font = New System.Drawing.Font("Arial", 24!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAppName.Size = New System.Drawing.Size(201, 41)
		Me.lblAppName.Location = New System.Drawing.Point(32, 104)
		Me.lblAppName.TabIndex = 1
		Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblAppName.Enabled = True
		Me.lblAppName.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblAppName.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblAppName.UseMnemonic = True
		Me.lblAppName.Visible = True
		Me.lblAppName.AutoSize = False
		Me.lblAppName.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblAppName.Name = "lblAppName"
		Me.Controls.Add(Picture1)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(Label1)
		Me.Controls.Add(txtVersion)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(lblVersion)
		Me.Controls.Add(lblAppName)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAbout
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAbout
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAbout()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
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
	Dim InData As String ' temp storage of response string
	Dim Cmd As String ' Command string
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'UPGRADE_ISSUE: App property App.Revision was not upgraded. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2069"'
        lblVersion.Text = "Version " & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMajorPart & "." & System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).FileMinorPart & "." & "7" 'App.Revision
		lblAppName.Text = VB6.GetExeName()
		Me.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly.Location).CompanyName
		If frmMain.DefInstance.MSComm1.PortOpen Then
			ReadVersion()
		Else
			txtVersion.Text = "Firmware Version: NOT CONNECTED"
		End If
	End Sub
	Private Sub ReadVersion()
		Dim qIndex As Short ' Stores current queue item for calling routine
		Dim i As Short 'loop index var
		Dim strBin As String 'binary string
		
		'Read 1 byte, starting at Version
		Cmd = Chr(&H82s) & Chr(Version) & Chr(1)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtVersion.Text = "Firmware Version: " & CStr(Asc(Mid(InData, 1, 1)))
	End Sub
End Class