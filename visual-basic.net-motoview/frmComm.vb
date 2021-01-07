Option Strict Off
Option Explicit On
Friend Class frmComm
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
	Public WithEvents cmdHelp As System.Windows.Forms.Button
	Public WithEvents cboNode As System.Windows.Forms.ComboBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cboBaud As System.Windows.Forms.ComboBox
	Public WithEvents cboPort As System.Windows.Forms.ComboBox
	Public WithEvents chkOpen As System.Windows.Forms.CheckBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmComm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.cmdHelp = New System.Windows.Forms.Button
		Me.cboNode = New System.Windows.Forms.ComboBox
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdCancel = New System.Windows.Forms.Button
		Me.cboBaud = New System.Windows.Forms.ComboBox
		Me.cboPort = New System.Windows.Forms.ComboBox
		Me.chkOpen = New System.Windows.Forms.CheckBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Text = "Communication Settings"
		Me.ClientSize = New System.Drawing.Size(222, 231)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmComm.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.Control
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
		Me.Name = "frmComm"
		Me.cmdHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdHelp.Text = "?"
		Me.cmdHelp.Size = New System.Drawing.Size(25, 25)
		Me.cmdHelp.Location = New System.Drawing.Point(192, 96)
		Me.cmdHelp.TabIndex = 9
		Me.cmdHelp.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdHelp.BackColor = System.Drawing.SystemColors.Control
		Me.cmdHelp.CausesValidation = True
		Me.cmdHelp.Enabled = True
		Me.cmdHelp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdHelp.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdHelp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdHelp.TabStop = True
		Me.cmdHelp.Name = "cmdHelp"
		Me.cboNode.Size = New System.Drawing.Size(73, 21)
		Me.cboNode.Location = New System.Drawing.Point(104, 98)
		Me.cboNode.TabIndex = 8
		Me.cboNode.Text = "Combo1"
		Me.cboNode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboNode.BackColor = System.Drawing.SystemColors.Window
		Me.cboNode.CausesValidation = True
		Me.cboNode.Enabled = True
		Me.cboNode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboNode.IntegralHeight = True
		Me.cboNode.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboNode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboNode.Sorted = False
		Me.cboNode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboNode.TabStop = True
		Me.cboNode.Visible = True
		Me.cboNode.Name = "cboNode"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.Text = "OK"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(73, 25)
		Me.cmdOK.Location = New System.Drawing.Point(112, 192)
		Me.cmdOK.TabIndex = 6
		Me.cmdOK.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.Text = "Cancel"
		Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
		Me.cmdCancel.Location = New System.Drawing.Point(24, 192)
		Me.cmdCancel.TabIndex = 5
		Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cboBaud.Size = New System.Drawing.Size(73, 21)
		Me.cboBaud.Location = New System.Drawing.Point(104, 64)
		Me.cboBaud.TabIndex = 4
		Me.cboBaud.Text = "Combo2"
		Me.cboBaud.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBaud.BackColor = System.Drawing.SystemColors.Window
		Me.cboBaud.CausesValidation = True
		Me.cboBaud.Enabled = True
		Me.cboBaud.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboBaud.IntegralHeight = True
		Me.cboBaud.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboBaud.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboBaud.Sorted = False
		Me.cboBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboBaud.TabStop = True
		Me.cboBaud.Visible = True
		Me.cboBaud.Name = "cboBaud"
		Me.cboPort.Size = New System.Drawing.Size(73, 21)
		Me.cboPort.Location = New System.Drawing.Point(104, 32)
		Me.cboPort.TabIndex = 3
		Me.cboPort.Text = "Combo1"
		Me.cboPort.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPort.BackColor = System.Drawing.SystemColors.Window
		Me.cboPort.CausesValidation = True
		Me.cboPort.Enabled = True
		Me.cboPort.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboPort.IntegralHeight = True
		Me.cboPort.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboPort.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboPort.Sorted = False
		Me.cboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboPort.TabStop = True
		Me.cboPort.Visible = True
		Me.cboPort.Name = "cboPort"
		Me.chkOpen.Text = "Open this COM port at startup"
		Me.chkOpen.Size = New System.Drawing.Size(177, 17)
		Me.chkOpen.Location = New System.Drawing.Point(24, 136)
		Me.chkOpen.TabIndex = 2
		Me.chkOpen.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkOpen.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkOpen.BackColor = System.Drawing.SystemColors.Control
		Me.chkOpen.CausesValidation = True
		Me.chkOpen.Enabled = True
		Me.chkOpen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkOpen.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkOpen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkOpen.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkOpen.TabStop = True
		Me.chkOpen.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkOpen.Visible = True
		Me.chkOpen.Name = "chkOpen"
		Me.Label3.Text = "Address:"
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 100)
		Me.Label3.TabIndex = 7
		Me.Label3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Baud Rate:"
		Me.Label2.Size = New System.Drawing.Size(65, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 64)
		Me.Label2.TabIndex = 1
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Com Port:"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 32)
		Me.Label1.TabIndex = 0
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmdHelp)
		Me.Controls.Add(cboNode)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cboBaud)
		Me.Controls.Add(cboPort)
		Me.Controls.Add(chkOpen)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmComm
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmComm
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmComm()
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
	
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdHelp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdHelp.Click
		MsgBox("The Gamoto Address setting allows MotoView to communicate with up to 8 Gamotos on the same RS-485 serial line.  This Address should correspond to switches 3,4, and 5 of Dipswitch 1.  It is normally set to 0 (all three switches in the OFF position), in the case of a normal RS-232 serial connection. Note that to use this feature, you must have firmware version 7 or higher (Help-About will display firmware version). See the user manual for more information.", MsgBoxStyle.OKOnly, "Help with Address setting")
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		frmMain.DefInstance.Baud = cboBaud.Text
		frmMain.DefInstance.COMport = cboPort.Text
		frmMain.DefInstance.Node = cboNode.Text
		HEADER = &HAAs + Val(frmMain.DefInstance.Node)
		If chkOpen.CheckState = 1 Then
			frmMain.DefInstance.OpenPortOnStart = True
		Else
			frmMain.DefInstance.OpenPortOnStart = False
		End If
		Me.Close()
	End Sub
	Private Sub frmComm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		cboPort.Items.Add("1")
		cboPort.Items.Add("2")
		cboPort.Items.Add("3")
		cboPort.Items.Add("4")
		cboPort.Text = frmMain.DefInstance.COMport
		
		cboBaud.Items.Add("9600")
		cboBaud.Items.Add("19200")
		cboBaud.Text = frmMain.DefInstance.Baud
		
		cboNode.Items.Add("0")
		cboNode.Items.Add("1")
		cboNode.Items.Add("2")
		cboNode.Items.Add("3")
		cboNode.Items.Add("4")
		cboNode.Items.Add("5")
		cboNode.Items.Add("6")
		cboNode.Items.Add("7")
		
		cboNode.Text = frmMain.DefInstance.Node
		
		If frmMain.DefInstance.OpenPortOnStart Then
			chkOpen.CheckState = System.Windows.Forms.CheckState.Checked
		Else
			chkOpen.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		
	End Sub
End Class