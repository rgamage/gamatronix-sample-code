Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmPID
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
	Public WithEvents mdClose As System.Windows.Forms.Button
	Public WithEvents cmdReadRegisters As System.Windows.Forms.Button
	Public WithEvents cmdFactoryReset As System.Windows.Forms.Button
	Public WithEvents cmdSaveToFlash As System.Windows.Forms.Button
	Public WithEvents _cmdEnter_7 As System.Windows.Forms.Button
	Public WithEvents txtMode As System.Windows.Forms.TextBox
	Public WithEvents _Check1_7 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_6 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_5 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_4 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_3 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_2 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_1 As System.Windows.Forms.CheckBox
	Public WithEvents _Check1_0 As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents MSComm1 As AxMSCommLib.AxMSComm
	Public WithEvents cmdStop As System.Windows.Forms.Button
	Public WithEvents cmdStart As System.Windows.Forms.Button
	Public WithEvents txtSetpoint As System.Windows.Forms.TextBox
	Public WithEvents Slider1 As AxMSComctlLib.AxSlider
	Public WithEvents lblMax As System.Windows.Forms.Label
	Public WithEvents lblMin As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents StatusBar1 As AxMSComctlLib.AxStatusBar
	Public WithEvents _cmdEnter_8 As System.Windows.Forms.Button
	Public WithEvents txtpwrLimit As System.Windows.Forms.TextBox
	Public WithEvents txtVel As System.Windows.Forms.TextBox
	Public WithEvents _cmdEnter_6 As System.Windows.Forms.Button
	Public WithEvents txtmP As System.Windows.Forms.TextBox
	Public WithEvents _cmdEnter_5 As System.Windows.Forms.Button
	Public WithEvents _cmdEnter_4 As System.Windows.Forms.Button
	Public WithEvents _cmdEnter_3 As System.Windows.Forms.Button
	Public WithEvents _cmdEnter_2 As System.Windows.Forms.Button
	Public WithEvents _cmdEnter_1 As System.Windows.Forms.Button
	Public WithEvents _cmdEnter_0 As System.Windows.Forms.Button
	Public WithEvents txtdS As System.Windows.Forms.TextBox
	Public WithEvents txtiL As System.Windows.Forms.TextBox
	Public WithEvents txtD As System.Windows.Forms.TextBox
	Public WithEvents txtI As System.Windows.Forms.TextBox
	Public WithEvents txtP As System.Windows.Forms.TextBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Check1 As Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray
	Public WithEvents cmdEnter As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPID))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.mdClose = New System.Windows.Forms.Button
		Me.cmdReadRegisters = New System.Windows.Forms.Button
		Me.cmdFactoryReset = New System.Windows.Forms.Button
		Me.cmdSaveToFlash = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me._cmdEnter_7 = New System.Windows.Forms.Button
		Me.txtMode = New System.Windows.Forms.TextBox
		Me._Check1_7 = New System.Windows.Forms.CheckBox
		Me._Check1_6 = New System.Windows.Forms.CheckBox
		Me._Check1_5 = New System.Windows.Forms.CheckBox
		Me._Check1_4 = New System.Windows.Forms.CheckBox
		Me._Check1_3 = New System.Windows.Forms.CheckBox
		Me._Check1_2 = New System.Windows.Forms.CheckBox
		Me._Check1_1 = New System.Windows.Forms.CheckBox
		Me._Check1_0 = New System.Windows.Forms.CheckBox
		Me.MSComm1 = New AxMSCommLib.AxMSComm
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.cmdStop = New System.Windows.Forms.Button
		Me.cmdStart = New System.Windows.Forms.Button
		Me.txtSetpoint = New System.Windows.Forms.TextBox
		Me.Slider1 = New AxMSComctlLib.AxSlider
		Me.lblMax = New System.Windows.Forms.Label
		Me.lblMin = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.StatusBar1 = New AxMSComctlLib.AxStatusBar
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._cmdEnter_8 = New System.Windows.Forms.Button
		Me.txtpwrLimit = New System.Windows.Forms.TextBox
		Me.txtVel = New System.Windows.Forms.TextBox
		Me._cmdEnter_6 = New System.Windows.Forms.Button
		Me.txtmP = New System.Windows.Forms.TextBox
		Me._cmdEnter_5 = New System.Windows.Forms.Button
		Me._cmdEnter_4 = New System.Windows.Forms.Button
		Me._cmdEnter_3 = New System.Windows.Forms.Button
		Me._cmdEnter_2 = New System.Windows.Forms.Button
		Me._cmdEnter_1 = New System.Windows.Forms.Button
		Me._cmdEnter_0 = New System.Windows.Forms.Button
		Me.txtdS = New System.Windows.Forms.TextBox
		Me.txtiL = New System.Windows.Forms.TextBox
		Me.txtD = New System.Windows.Forms.TextBox
		Me.txtI = New System.Windows.Forms.TextBox
		Me.txtP = New System.Windows.Forms.TextBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Label6 = New System.Windows.Forms.Label
		Me.Check1 = New Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(components)
		Me.cmdEnter = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Slider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Check1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdEnter, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "MotoView"
		Me.ClientSize = New System.Drawing.Size(427, 508)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmPID.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmPID"
		Me.mdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.mdClose.Text = "Close"
		Me.mdClose.Size = New System.Drawing.Size(81, 25)
		Me.mdClose.Location = New System.Drawing.Point(328, 456)
		Me.mdClose.TabIndex = 48
		Me.mdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.mdClose.BackColor = System.Drawing.SystemColors.Control
		Me.mdClose.CausesValidation = True
		Me.mdClose.Enabled = True
		Me.mdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.mdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.mdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.mdClose.TabStop = True
		Me.mdClose.Name = "mdClose"
		Me.cmdReadRegisters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReadRegisters.Text = "Read Registers"
		Me.cmdReadRegisters.Size = New System.Drawing.Size(153, 33)
		Me.cmdReadRegisters.Location = New System.Drawing.Point(256, 312)
		Me.cmdReadRegisters.TabIndex = 46
		Me.cmdReadRegisters.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReadRegisters.BackColor = System.Drawing.SystemColors.Control
		Me.cmdReadRegisters.CausesValidation = True
		Me.cmdReadRegisters.Enabled = True
		Me.cmdReadRegisters.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdReadRegisters.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReadRegisters.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdReadRegisters.TabStop = True
		Me.cmdReadRegisters.Name = "cmdReadRegisters"
		Me.cmdFactoryReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFactoryReset.Text = "Reset to Factory Default"
		Me.cmdFactoryReset.Size = New System.Drawing.Size(153, 33)
		Me.cmdFactoryReset.Location = New System.Drawing.Point(256, 392)
		Me.cmdFactoryReset.TabIndex = 45
		Me.cmdFactoryReset.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdFactoryReset.BackColor = System.Drawing.SystemColors.Control
		Me.cmdFactoryReset.CausesValidation = True
		Me.cmdFactoryReset.Enabled = True
		Me.cmdFactoryReset.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdFactoryReset.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFactoryReset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdFactoryReset.TabStop = True
		Me.cmdFactoryReset.Name = "cmdFactoryReset"
		Me.cmdSaveToFlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSaveToFlash.Text = "Save Settings in Flash"
		Me.cmdSaveToFlash.Size = New System.Drawing.Size(153, 33)
		Me.cmdSaveToFlash.Location = New System.Drawing.Point(256, 352)
		Me.cmdSaveToFlash.TabIndex = 44
		Me.cmdSaveToFlash.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSaveToFlash.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSaveToFlash.CausesValidation = True
		Me.cmdSaveToFlash.Enabled = True
		Me.cmdSaveToFlash.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSaveToFlash.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSaveToFlash.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSaveToFlash.TabStop = True
		Me.cmdSaveToFlash.Name = "cmdSaveToFlash"
		Me.Frame2.Text = "Mode Control"
		Me.Frame2.Size = New System.Drawing.Size(153, 249)
		Me.Frame2.Location = New System.Drawing.Point(256, 48)
		Me.Frame2.TabIndex = 35
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me._cmdEnter_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_7.Text = "Enter"
		Me._cmdEnter_7.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_7.Location = New System.Drawing.Point(80, 216)
		Me._cmdEnter_7.TabIndex = 23
		Me._cmdEnter_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_7.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_7.CausesValidation = True
		Me._cmdEnter_7.Enabled = True
		Me._cmdEnter_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_7.TabStop = True
		Me._cmdEnter_7.Name = "_cmdEnter_7"
		Me.txtMode.AutoSize = False
		Me.txtMode.Size = New System.Drawing.Size(41, 19)
		Me.txtMode.Location = New System.Drawing.Point(16, 216)
		Me.txtMode.TabIndex = 12
		Me.txtMode.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtMode.AcceptsReturn = True
		Me.txtMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMode.BackColor = System.Drawing.SystemColors.Window
		Me.txtMode.CausesValidation = True
		Me.txtMode.Enabled = True
		Me.txtMode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMode.HideSelection = True
		Me.txtMode.ReadOnly = False
		Me.txtMode.Maxlength = 0
		Me.txtMode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMode.MultiLine = False
		Me.txtMode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMode.TabStop = True
		Me.txtMode.Visible = True
		Me.txtMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMode.Name = "txtMode"
		Me._Check1_7.Text = "LAP PWM Mode"
		Me._Check1_7.Size = New System.Drawing.Size(121, 17)
		Me._Check1_7.Location = New System.Drawing.Point(16, 192)
		Me._Check1_7.TabIndex = 43
		Me._Check1_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_7.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_7.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_7.CausesValidation = True
		Me._Check1_7.Enabled = True
		Me._Check1_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_7.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_7.TabStop = True
		Me._Check1_7.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_7.Visible = True
		Me._Check1_7.Name = "_Check1_7"
		Me._Check1_6.Text = "Overtemp Condition"
		Me._Check1_6.Size = New System.Drawing.Size(129, 17)
		Me._Check1_6.Location = New System.Drawing.Point(16, 168)
		Me._Check1_6.TabIndex = 42
		Me._Check1_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_6.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_6.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_6.CausesValidation = True
		Me._Check1_6.Enabled = True
		Me._Check1_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_6.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_6.TabStop = True
		Me._Check1_6.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_6.Visible = True
		Me._Check1_6.Name = "_Check1_6"
		Me._Check1_5.Text = "Brake On"
		Me._Check1_5.Size = New System.Drawing.Size(105, 17)
		Me._Check1_5.Location = New System.Drawing.Point(16, 144)
		Me._Check1_5.TabIndex = 41
		Me._Check1_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_5.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_5.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_5.CausesValidation = True
		Me._Check1_5.Enabled = True
		Me._Check1_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_5.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_5.TabStop = True
		Me._Check1_5.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_5.Visible = True
		Me._Check1_5.Name = "_Check1_5"
		Me._Check1_4.Text = "Power Mode"
		Me._Check1_4.Size = New System.Drawing.Size(105, 17)
		Me._Check1_4.Location = New System.Drawing.Point(16, 120)
		Me._Check1_4.TabIndex = 40
		Me._Check1_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_4.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_4.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_4.CausesValidation = True
		Me._Check1_4.Enabled = True
		Me._Check1_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_4.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_4.TabStop = True
		Me._Check1_4.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_4.Visible = True
		Me._Check1_4.Name = "_Check1_4"
		Me._Check1_3.Text = "Stop Gracefully"
		Me._Check1_3.Size = New System.Drawing.Size(105, 17)
		Me._Check1_3.Location = New System.Drawing.Point(16, 96)
		Me._Check1_3.TabIndex = 39
		Me._Check1_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_3.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_3.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_3.CausesValidation = True
		Me._Check1_3.Enabled = True
		Me._Check1_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_3.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_3.TabStop = True
		Me._Check1_3.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_3.Visible = True
		Me._Check1_3.Name = "_Check1_3"
		Me._Check1_2.Text = "Velocity Mode"
		Me._Check1_2.Size = New System.Drawing.Size(105, 17)
		Me._Check1_2.Location = New System.Drawing.Point(16, 72)
		Me._Check1_2.TabIndex = 38
		Me._Check1_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_2.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_2.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_2.CausesValidation = True
		Me._Check1_2.Enabled = True
		Me._Check1_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_2.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_2.TabStop = True
		Me._Check1_2.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_2.Visible = True
		Me._Check1_2.Name = "_Check1_2"
		Me._Check1_1.Text = "Trajectory Mode"
		Me._Check1_1.Size = New System.Drawing.Size(105, 17)
		Me._Check1_1.Location = New System.Drawing.Point(16, 48)
		Me._Check1_1.TabIndex = 37
		Me._Check1_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_1.CausesValidation = True
		Me._Check1_1.Enabled = True
		Me._Check1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_1.TabStop = True
		Me._Check1_1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_1.Visible = True
		Me._Check1_1.Name = "_Check1_1"
		Me._Check1_0.Text = "Motor Power Enable"
		Me._Check1_0.Size = New System.Drawing.Size(129, 17)
		Me._Check1_0.Location = New System.Drawing.Point(16, 24)
		Me._Check1_0.TabIndex = 36
		Me._Check1_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Check1_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._Check1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Check1_0.CausesValidation = True
		Me._Check1_0.Enabled = True
		Me._Check1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Check1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Check1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Check1_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._Check1_0.TabStop = True
		Me._Check1_0.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me._Check1_0.Visible = True
		Me._Check1_0.Name = "_Check1_0"
		MSComm1.OcxState = CType(resources.GetObject("MSComm1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MSComm1.Location = New System.Drawing.Point(0, 8)
		Me.MSComm1.Name = "MSComm1"
		Me.Frame4.Text = "Interactive Position Control"
		Me.Frame4.Size = New System.Drawing.Size(225, 137)
		Me.Frame4.Location = New System.Drawing.Point(16, 344)
		Me.Frame4.TabIndex = 26
		Me.Frame4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame4.BackColor = System.Drawing.SystemColors.Control
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame4.Visible = True
		Me.Frame4.Name = "Frame4"
		Me.cmdStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdStop.Text = "STOP"
		Me.cmdStop.Size = New System.Drawing.Size(65, 25)
		Me.cmdStop.Location = New System.Drawing.Point(144, 104)
		Me.cmdStop.TabIndex = 49
		Me.cmdStop.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStop.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStop.CausesValidation = True
		Me.cmdStop.Enabled = True
		Me.cmdStop.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStop.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStop.TabStop = True
		Me.cmdStop.Name = "cmdStop"
		Me.cmdStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdStart.Text = "START"
		Me.cmdStart.Size = New System.Drawing.Size(65, 25)
		Me.cmdStart.Location = New System.Drawing.Point(16, 104)
		Me.cmdStart.TabIndex = 32
		Me.cmdStart.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStart.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStart.CausesValidation = True
		Me.cmdStart.Enabled = True
		Me.cmdStart.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStart.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStart.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStart.TabStop = True
		Me.cmdStart.Name = "cmdStart"
		Me.txtSetpoint.AutoSize = False
		Me.txtSetpoint.Size = New System.Drawing.Size(65, 19)
		Me.txtSetpoint.Location = New System.Drawing.Point(88, 72)
		Me.txtSetpoint.TabIndex = 28
		Me.txtSetpoint.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSetpoint.AcceptsReturn = True
		Me.txtSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtSetpoint.BackColor = System.Drawing.SystemColors.Window
		Me.txtSetpoint.CausesValidation = True
		Me.txtSetpoint.Enabled = True
		Me.txtSetpoint.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtSetpoint.HideSelection = True
		Me.txtSetpoint.ReadOnly = False
		Me.txtSetpoint.Maxlength = 0
		Me.txtSetpoint.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtSetpoint.MultiLine = False
		Me.txtSetpoint.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtSetpoint.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtSetpoint.TabStop = True
		Me.txtSetpoint.Visible = True
		Me.txtSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtSetpoint.Name = "txtSetpoint"
		Slider1.OcxState = CType(resources.GetObject("Slider1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Slider1.Size = New System.Drawing.Size(193, 17)
		Me.Slider1.Location = New System.Drawing.Point(16, 24)
		Me.Slider1.TabIndex = 27
		Me.Slider1.Name = "Slider1"
		Me.lblMax.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.lblMax.Text = "100"
		Me.lblMax.Size = New System.Drawing.Size(41, 17)
		Me.lblMax.Location = New System.Drawing.Point(168, 48)
		Me.lblMax.TabIndex = 31
		Me.lblMax.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMax.BackColor = System.Drawing.SystemColors.Control
		Me.lblMax.Enabled = True
		Me.lblMax.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMax.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMax.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMax.UseMnemonic = True
		Me.lblMax.Visible = True
		Me.lblMax.AutoSize = False
		Me.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMax.Name = "lblMax"
		Me.lblMin.Text = "-100"
		Me.lblMin.Size = New System.Drawing.Size(41, 17)
		Me.lblMin.Location = New System.Drawing.Point(8, 48)
		Me.lblMin.TabIndex = 30
		Me.lblMin.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMin.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblMin.BackColor = System.Drawing.SystemColors.Control
		Me.lblMin.Enabled = True
		Me.lblMin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblMin.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblMin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblMin.UseMnemonic = True
		Me.lblMin.Visible = True
		Me.lblMin.AutoSize = False
		Me.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblMin.Name = "lblMin"
		Me.Label7.Text = "Setpoint:"
		Me.Label7.Size = New System.Drawing.Size(49, 17)
		Me.Label7.Location = New System.Drawing.Point(32, 72)
		Me.Label7.TabIndex = 29
		Me.Label7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		StatusBar1.OcxState = CType(resources.GetObject("StatusBar1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.StatusBar1.Size = New System.Drawing.Size(427, 17)
		Me.StatusBar1.Location = New System.Drawing.Point(0, 491)
		Me.StatusBar1.TabIndex = 25
		Me.StatusBar1.Name = "StatusBar1"
		Me.Frame1.Text = "Registers"
		Me.Frame1.Size = New System.Drawing.Size(225, 289)
		Me.Frame1.Location = New System.Drawing.Point(16, 48)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me._cmdEnter_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_8.Text = "Enter"
		Me._cmdEnter_8.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_8.Location = New System.Drawing.Point(144, 256)
		Me._cmdEnter_8.TabIndex = 22
		Me._cmdEnter_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_8.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_8.CausesValidation = True
		Me._cmdEnter_8.Enabled = True
		Me._cmdEnter_8.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_8.TabStop = True
		Me._cmdEnter_8.Name = "_cmdEnter_8"
		Me.txtpwrLimit.AutoSize = False
		Me.txtpwrLimit.Size = New System.Drawing.Size(65, 19)
		Me.txtpwrLimit.Location = New System.Drawing.Point(64, 256)
		Me.txtpwrLimit.TabIndex = 11
		Me.txtpwrLimit.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtpwrLimit.AcceptsReturn = True
		Me.txtpwrLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtpwrLimit.BackColor = System.Drawing.SystemColors.Window
		Me.txtpwrLimit.CausesValidation = True
		Me.txtpwrLimit.Enabled = True
		Me.txtpwrLimit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtpwrLimit.HideSelection = True
		Me.txtpwrLimit.ReadOnly = False
		Me.txtpwrLimit.Maxlength = 0
		Me.txtpwrLimit.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtpwrLimit.MultiLine = False
		Me.txtpwrLimit.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtpwrLimit.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtpwrLimit.TabStop = True
		Me.txtpwrLimit.Visible = True
		Me.txtpwrLimit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtpwrLimit.Name = "txtpwrLimit"
		Me.txtVel.AutoSize = False
		Me.txtVel.Size = New System.Drawing.Size(65, 19)
		Me.txtVel.Location = New System.Drawing.Point(64, 224)
		Me.txtVel.TabIndex = 10
		Me.txtVel.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtVel.AcceptsReturn = True
		Me.txtVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtVel.BackColor = System.Drawing.SystemColors.Window
		Me.txtVel.CausesValidation = True
		Me.txtVel.Enabled = True
		Me.txtVel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtVel.HideSelection = True
		Me.txtVel.ReadOnly = False
		Me.txtVel.Maxlength = 0
		Me.txtVel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtVel.MultiLine = False
		Me.txtVel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtVel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtVel.TabStop = True
		Me.txtVel.Visible = True
		Me.txtVel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtVel.Name = "txtVel"
		Me._cmdEnter_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_6.Text = "Enter"
		Me._cmdEnter_6.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_6.Location = New System.Drawing.Point(144, 224)
		Me._cmdEnter_6.TabIndex = 21
		Me._cmdEnter_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_6.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_6.CausesValidation = True
		Me._cmdEnter_6.Enabled = True
		Me._cmdEnter_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_6.TabStop = True
		Me._cmdEnter_6.Name = "_cmdEnter_6"
		Me.txtmP.AutoSize = False
		Me.txtmP.Size = New System.Drawing.Size(65, 19)
		Me.txtmP.Location = New System.Drawing.Point(64, 192)
		Me.txtmP.TabIndex = 9
		Me.txtmP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtmP.AcceptsReturn = True
		Me.txtmP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtmP.BackColor = System.Drawing.SystemColors.Window
		Me.txtmP.CausesValidation = True
		Me.txtmP.Enabled = True
		Me.txtmP.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtmP.HideSelection = True
		Me.txtmP.ReadOnly = False
		Me.txtmP.Maxlength = 0
		Me.txtmP.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtmP.MultiLine = False
		Me.txtmP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtmP.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtmP.TabStop = True
		Me.txtmP.Visible = True
		Me.txtmP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtmP.Name = "txtmP"
		Me._cmdEnter_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_5.Text = "Enter"
		Me._cmdEnter_5.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_5.Location = New System.Drawing.Point(144, 192)
		Me._cmdEnter_5.TabIndex = 20
		Me._cmdEnter_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_5.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_5.CausesValidation = True
		Me._cmdEnter_5.Enabled = True
		Me._cmdEnter_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_5.TabStop = True
		Me._cmdEnter_5.Name = "_cmdEnter_5"
		Me._cmdEnter_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_4.Text = "Enter"
		Me._cmdEnter_4.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_4.Location = New System.Drawing.Point(144, 160)
		Me._cmdEnter_4.TabIndex = 19
		Me._cmdEnter_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_4.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_4.CausesValidation = True
		Me._cmdEnter_4.Enabled = True
		Me._cmdEnter_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_4.TabStop = True
		Me._cmdEnter_4.Name = "_cmdEnter_4"
		Me._cmdEnter_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_3.Text = "Enter"
		Me._cmdEnter_3.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_3.Location = New System.Drawing.Point(144, 128)
		Me._cmdEnter_3.TabIndex = 18
		Me._cmdEnter_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_3.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_3.CausesValidation = True
		Me._cmdEnter_3.Enabled = True
		Me._cmdEnter_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_3.TabStop = True
		Me._cmdEnter_3.Name = "_cmdEnter_3"
		Me._cmdEnter_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_2.Text = "Enter"
		Me._cmdEnter_2.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_2.Location = New System.Drawing.Point(144, 96)
		Me._cmdEnter_2.TabIndex = 17
		Me._cmdEnter_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_2.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_2.CausesValidation = True
		Me._cmdEnter_2.Enabled = True
		Me._cmdEnter_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_2.TabStop = True
		Me._cmdEnter_2.Name = "_cmdEnter_2"
		Me._cmdEnter_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_1.Text = "Enter"
		Me._cmdEnter_1.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_1.Location = New System.Drawing.Point(144, 64)
		Me._cmdEnter_1.TabIndex = 16
		Me._cmdEnter_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_1.CausesValidation = True
		Me._cmdEnter_1.Enabled = True
		Me._cmdEnter_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_1.TabStop = True
		Me._cmdEnter_1.Name = "_cmdEnter_1"
		Me._cmdEnter_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdEnter_0.Text = "Enter"
		Me._cmdEnter_0.Size = New System.Drawing.Size(49, 17)
		Me._cmdEnter_0.Location = New System.Drawing.Point(144, 32)
		Me._cmdEnter_0.TabIndex = 15
		Me._cmdEnter_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdEnter_0.BackColor = System.Drawing.SystemColors.Control
		Me._cmdEnter_0.CausesValidation = True
		Me._cmdEnter_0.Enabled = True
		Me._cmdEnter_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdEnter_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdEnter_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdEnter_0.TabStop = True
		Me._cmdEnter_0.Name = "_cmdEnter_0"
		Me.txtdS.AutoSize = False
		Me.txtdS.Size = New System.Drawing.Size(65, 19)
		Me.txtdS.Location = New System.Drawing.Point(64, 160)
		Me.txtdS.TabIndex = 8
		Me.txtdS.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtdS.AcceptsReturn = True
		Me.txtdS.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtdS.BackColor = System.Drawing.SystemColors.Window
		Me.txtdS.CausesValidation = True
		Me.txtdS.Enabled = True
		Me.txtdS.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtdS.HideSelection = True
		Me.txtdS.ReadOnly = False
		Me.txtdS.Maxlength = 0
		Me.txtdS.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtdS.MultiLine = False
		Me.txtdS.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtdS.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtdS.TabStop = True
		Me.txtdS.Visible = True
		Me.txtdS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtdS.Name = "txtdS"
		Me.txtiL.AutoSize = False
		Me.txtiL.Size = New System.Drawing.Size(65, 19)
		Me.txtiL.Location = New System.Drawing.Point(64, 128)
		Me.txtiL.TabIndex = 7
		Me.txtiL.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtiL.AcceptsReturn = True
		Me.txtiL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtiL.BackColor = System.Drawing.SystemColors.Window
		Me.txtiL.CausesValidation = True
		Me.txtiL.Enabled = True
		Me.txtiL.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtiL.HideSelection = True
		Me.txtiL.ReadOnly = False
		Me.txtiL.Maxlength = 0
		Me.txtiL.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtiL.MultiLine = False
		Me.txtiL.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtiL.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtiL.TabStop = True
		Me.txtiL.Visible = True
		Me.txtiL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtiL.Name = "txtiL"
		Me.txtD.AutoSize = False
		Me.txtD.Size = New System.Drawing.Size(65, 19)
		Me.txtD.Location = New System.Drawing.Point(64, 96)
		Me.txtD.TabIndex = 6
		Me.txtD.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtD.AcceptsReturn = True
		Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtD.BackColor = System.Drawing.SystemColors.Window
		Me.txtD.CausesValidation = True
		Me.txtD.Enabled = True
		Me.txtD.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtD.HideSelection = True
		Me.txtD.ReadOnly = False
		Me.txtD.Maxlength = 0
		Me.txtD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtD.MultiLine = False
		Me.txtD.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtD.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtD.TabStop = True
		Me.txtD.Visible = True
		Me.txtD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtD.Name = "txtD"
		Me.txtI.AutoSize = False
		Me.txtI.Size = New System.Drawing.Size(65, 19)
		Me.txtI.Location = New System.Drawing.Point(64, 64)
		Me.txtI.TabIndex = 5
		Me.txtI.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtI.AcceptsReturn = True
		Me.txtI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtI.BackColor = System.Drawing.SystemColors.Window
		Me.txtI.CausesValidation = True
		Me.txtI.Enabled = True
		Me.txtI.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtI.HideSelection = True
		Me.txtI.ReadOnly = False
		Me.txtI.Maxlength = 0
		Me.txtI.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtI.MultiLine = False
		Me.txtI.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtI.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtI.TabStop = True
		Me.txtI.Visible = True
		Me.txtI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtI.Name = "txtI"
		Me.txtP.AutoSize = False
		Me.txtP.Size = New System.Drawing.Size(65, 19)
		Me.txtP.Location = New System.Drawing.Point(64, 32)
		Me.txtP.TabIndex = 4
		Me.txtP.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtP.AcceptsReturn = True
		Me.txtP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtP.BackColor = System.Drawing.SystemColors.Window
		Me.txtP.CausesValidation = True
		Me.txtP.Enabled = True
		Me.txtP.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtP.HideSelection = True
		Me.txtP.ReadOnly = False
		Me.txtP.Maxlength = 0
		Me.txtP.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtP.MultiLine = False
		Me.txtP.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtP.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtP.TabStop = True
		Me.txtP.Visible = True
		Me.txtP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtP.Name = "txtP"
		Me.Label11.Text = "pwrLim"
		Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Size = New System.Drawing.Size(57, 17)
		Me.Label11.Location = New System.Drawing.Point(8, 256)
		Me.Label11.TabIndex = 47
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label10.Text = "Veloc:"
		Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Size = New System.Drawing.Size(57, 17)
		Me.Label10.Location = New System.Drawing.Point(8, 224)
		Me.Label10.TabIndex = 34
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label9.Text = "mPwr:"
		Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Size = New System.Drawing.Size(41, 17)
		Me.Label9.Location = New System.Drawing.Point(8, 192)
		Me.Label9.TabIndex = 33
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label5.Text = "dS:"
		Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Size = New System.Drawing.Size(25, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 160)
		Me.Label5.TabIndex = 14
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "iL:"
		Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Size = New System.Drawing.Size(25, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 128)
		Me.Label4.TabIndex = 13
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Kd:"
		Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(25, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 96)
		Me.Label3.TabIndex = 3
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
		Me.Label2.Text = "Ki:"
		Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(17, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 64)
		Me.Label2.TabIndex = 2
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
		Me.Label1.Text = "Kp:"
		Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(25, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 32)
		Me.Label1.TabIndex = 1
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
		Me.Timer1.Interval = 100
		Me.Timer1.Enabled = True
		Me.Label6.Text = "GAMATRONIX Motor Control Panel"
		Me.Label6.Font = New System.Drawing.Font("Arial", 13.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Size = New System.Drawing.Size(321, 25)
		Me.Label6.Location = New System.Drawing.Point(56, 8)
		Me.Label6.TabIndex = 24
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Controls.Add(mdClose)
		Me.Controls.Add(cmdReadRegisters)
		Me.Controls.Add(cmdFactoryReset)
		Me.Controls.Add(cmdSaveToFlash)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(MSComm1)
		Me.Controls.Add(Frame4)
		Me.Controls.Add(StatusBar1)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Label6)
		Me.Frame2.Controls.Add(_cmdEnter_7)
		Me.Frame2.Controls.Add(txtMode)
		Me.Frame2.Controls.Add(_Check1_7)
		Me.Frame2.Controls.Add(_Check1_6)
		Me.Frame2.Controls.Add(_Check1_5)
		Me.Frame2.Controls.Add(_Check1_4)
		Me.Frame2.Controls.Add(_Check1_3)
		Me.Frame2.Controls.Add(_Check1_2)
		Me.Frame2.Controls.Add(_Check1_1)
		Me.Frame2.Controls.Add(_Check1_0)
		Me.Frame4.Controls.Add(cmdStop)
		Me.Frame4.Controls.Add(cmdStart)
		Me.Frame4.Controls.Add(txtSetpoint)
		Me.Frame4.Controls.Add(Slider1)
		Me.Frame4.Controls.Add(lblMax)
		Me.Frame4.Controls.Add(lblMin)
		Me.Frame4.Controls.Add(Label7)
		Me.Frame1.Controls.Add(_cmdEnter_8)
		Me.Frame1.Controls.Add(txtpwrLimit)
		Me.Frame1.Controls.Add(txtVel)
		Me.Frame1.Controls.Add(_cmdEnter_6)
		Me.Frame1.Controls.Add(txtmP)
		Me.Frame1.Controls.Add(_cmdEnter_5)
		Me.Frame1.Controls.Add(_cmdEnter_4)
		Me.Frame1.Controls.Add(_cmdEnter_3)
		Me.Frame1.Controls.Add(_cmdEnter_2)
		Me.Frame1.Controls.Add(_cmdEnter_1)
		Me.Frame1.Controls.Add(_cmdEnter_0)
		Me.Frame1.Controls.Add(txtdS)
		Me.Frame1.Controls.Add(txtiL)
		Me.Frame1.Controls.Add(txtD)
		Me.Frame1.Controls.Add(txtI)
		Me.Frame1.Controls.Add(txtP)
		Me.Frame1.Controls.Add(Label11)
		Me.Frame1.Controls.Add(Label10)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.Check1.SetIndex(_Check1_7, CType(7, Short))
		Me.Check1.SetIndex(_Check1_6, CType(6, Short))
		Me.Check1.SetIndex(_Check1_5, CType(5, Short))
		Me.Check1.SetIndex(_Check1_4, CType(4, Short))
		Me.Check1.SetIndex(_Check1_3, CType(3, Short))
		Me.Check1.SetIndex(_Check1_2, CType(2, Short))
		Me.Check1.SetIndex(_Check1_1, CType(1, Short))
		Me.Check1.SetIndex(_Check1_0, CType(0, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_7, CType(7, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_8, CType(8, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_6, CType(6, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_5, CType(5, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_4, CType(4, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_3, CType(3, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_2, CType(2, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_1, CType(1, Short))
		Me.cmdEnter.SetIndex(_cmdEnter_0, CType(0, Short))
		CType(Me.cmdEnter, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Check1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Slider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmPID
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmPID
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmPID()
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
	
	Dim i As Integer ' general index
	Dim numAxes As Integer ' number of axes added to form
	Dim bStream As Boolean ' Enable streaming of position data to controller
	Dim SliderX As Single ' X position of mouse over slider control
	Dim checksum As Byte ' byte checksum
	Dim InData As String ' temp storage of response string
	Dim Cmd As String ' Command string
	
	'UPGRADE_WARNING: Event Check1.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged
		Dim Index As Short = Check1.GetIndex(eventSender)
		Dim i As Short
		Dim newMode As Short
		For i = 0 To 7
			If Check1(i).CheckState = 1 Then newMode = newMode + 2 ^ i
		Next i
		txtMode.Text = CStr(newMode)
	End Sub
	
	Private Sub cmdEnter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEnter.Click
		Dim Index As Short = cmdEnter.GetIndex(eventSender)
		Dim qIndex As Short ' Stores current queue item for calling routine
		Select Case Index
			Case 0 'P
				Cmd = Chr(&H3s) & Chr(Kp) & DecToHexchars16(Val(txtP.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 1 'I
				Cmd = Chr(&H3s) & Chr(Ki) & DecToHexchars16(Val(txtI.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 2 'D
				Cmd = Chr(&H3s) & Chr(Kd) & DecToHexchars16(Val(txtD.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 3 'iL
				Cmd = Chr(&H3s) & Chr(iL) & DecToHexchars16(Val(txtiL.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 4 'dS
				Cmd = Chr(&H2s) & Chr(dS) & DecToHexchars8(Val(txtdS.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 5 'mPower
				Cmd = Chr(&H2s) & Chr(mPower) & DecToHexchars8(Val(txtmP.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 6 'Velocity
				Cmd = Chr(&H3s) & Chr(setVelocity) & DecToHexchars16(Val(txtVel.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 7 'Mode from checkboxes
				Cmd = Chr(&H2s) & Chr(Mode) & DecToHexchars8(Val(txtMode.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
			Case 8 'pwrLimit
				Cmd = Chr(&H2s) & Chr(pwrLimit) & DecToHexchars8(Val(txtpwrLimit.Text))
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
		End Select
		'Wait for our command to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdFactoryReset_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFactoryReset.Click
		Dim qIndex As Short ' Stores current queue item for calling routine
		Cmd = Chr(&H1s) & Chr(FactoryResetCmd)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdSaveToFlash_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSaveToFlash.Click
		Dim qIndex As Short ' Stores current queue item for calling routine
		Cmd = Chr(&H1s) & Chr(StoreFlashCmd)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStart.Click
		bStream = True
		cmdStart.Enabled = False
		cmdStop.Enabled = True
		Slider1.Enabled = True
		txtSetpoint.Enabled = True
		cmdStop.Focus()
	End Sub
	
	Private Sub cmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStop.Click
		bStream = False
		cmdStart.Enabled = True
		cmdStop.Enabled = False
		Slider1.Enabled = False
		txtSetpoint.Enabled = False
		cmdStart.Focus()
	End Sub
	
	Private Sub cmdTest_Click()
		'Internal Verification test: Try writing to 4 consecutive bytes, then reading back
		
		Dim qIndex As Short ' Stores current queue item for calling routine
		
		Cmd = Chr(&H5s) & Chr(setPosition - 1) & Chr(1) & Chr(2) & Chr(3) & Chr(4)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		
		'Wait for our command to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		
		'Read 4 bytes, starting at Kp
		Cmd = Chr(&H82s) & Chr(setPosition - 1) & Chr(4)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtP.Text = CStr(Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))))
		System.Diagnostics.Debug.WriteLine(Asc(Mid(InData, 1, 1)))
		System.Diagnostics.Debug.WriteLine(Asc(Mid(InData, 2, 1)))
		System.Diagnostics.Debug.WriteLine(Asc(Mid(InData, 3, 1)))
		System.Diagnostics.Debug.WriteLine(Asc(Mid(InData, 4, 1)))
	End Sub
	
	Private Sub cmdTest2_Click()
		'TEST CODE ADDED FOR DEBUGGING THE ALEDGED MISSING CHECKSUM BUG FROM ERIC J
		Dim angle As Single
		Dim sinPos As Integer
		Const PI As Double = 3.1415927
		Dim qIndex As Short
		Dim Cmd As String
		While 1 'Do forever
			angle = angle + 1 Mod 360
			sinPos = System.Math.Sin(angle * PI / 180) * 500
			Cmd = Chr(&H4s) & Chr(setPosition) & DecToHexchars24(Val(CStr(sinPos)))
			qIndex = frmMain.DefInstance.SendSerial(Cmd)
			While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
				System.Windows.Forms.Application.DoEvents()
			End While
			If Fifo(qIndex).Error_Renamed Then MsgBox("ERROR!", MsgBoxStyle.Critical)
			'Read 3 bytes, starting at mPosition
			Cmd = Chr(&H82s) & Chr(mPosition) & Chr(3)
			qIndex = frmMain.DefInstance.SendSerial(Cmd)
			'Wait for our response to be completed
			While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
				System.Windows.Forms.Application.DoEvents()
			End While
			If Fifo(qIndex).Error_Renamed Then Exit Sub
		End While
		'END TEST CODE
	End Sub
	
	Private Sub frmPID_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		On Error GoTo err1
		' Start with timer disabled
		Timer1.Enabled = False
		Slider1.Value = CShort((Slider1.Max - Slider1.Min) / 2)
		SliderX = VB6.PixelsToTwipsX(Slider1.Width) / 2
		lblMax.Cursor = System.Windows.Forms.Cursors.Help
		lblMin.Cursor = System.Windows.Forms.Cursors.Help
		If frmMain.DefInstance.MSComm1.PortOpen Then
			StatusBar1.Panels(2)._ObjectDefault = "Connected"
			GetParms()
		Else
			StatusBar1.Panels(2)._ObjectDefault = "NOT CONNECTED"
		End If
		' Start the timer
		Timer1.Enabled = True
		
		Me.Left = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(4410))))
		Me.Top = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(1740))))
		Me.Width = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(6525))))
		Me.Height = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(8025))))
		
		Me.Show() 'Have to show form before doing a setFocus command
		cmdStop_Click(cmdStop, New System.EventArgs()) 'Stop streaming position data, setfocus, disable some controls
		
		Exit Sub
err1: 
		MsgBox(Err.Number & ": " & Err.Description)
	End Sub
	
	Private Sub cmdReadRegisters_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReadRegisters.Click
		GetParms()
	End Sub
	Private Sub GetParms()
		Dim qIndex As Short ' Stores current queue item for calling routine
		Dim i As Short 'loop index var
		Dim strBin As String 'binary string
		'Read 4 bytes, starting at Kp
		Cmd = Chr(&H82s) & Chr(Kp) & Chr(4)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtP.Text = CStr(Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))))
		txtI.Text = CStr(Asc(Mid(InData, 3, 1)) + 256 * CInt(Asc(Mid(InData, 4, 1))))
		
		'Read 4 bytes, starting at Kd
		Cmd = Chr(&H82s) & Chr(Kd) & Chr(4)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtD.Text = CStr(Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))))
		txtiL.Text = CStr(Asc(Mid(InData, 3, 1)) + 256 * CInt(Asc(Mid(InData, 4, 1))))
		
		'Read 3 bytes, starting at dS
		Cmd = Chr(&H82s) & Chr(dS) & Chr(3)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtdS.Text = CStr(Asc(Mid(InData, 1, 1)))
		txtMode.Text = CStr(Asc(Mid(InData, 2, 1)))
		txtpwrLimit.Text = CStr(Asc(Mid(InData, 3, 1)))
		'Read 2 bytes, starting at setVelocity
		Cmd = Chr(&H82s) & Chr(setVelocity) & Chr(2)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtVel.Text = CStr(Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))))
		'Read 1 byte, starting at mPower
		Cmd = Chr(&H82s) & Chr(mPower) & Chr(1)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtmP.Text = CStr(Asc(Mid(InData, 1, 1)))
		'Fill in check boxes for mode status
		strBin = DecToBin(Val(txtMode.Text))
		For i = 0 To 7
			If Mid(strBin, 8 - i, 1) = "1" Then
				Check1(i).CheckState = System.Windows.Forms.CheckState.Checked
			Else
				Check1(i).CheckState = System.Windows.Forms.CheckState.Unchecked
			End If
		Next i
	End Sub
	
	
	Private Sub lblMax_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblMax.Click
		Dim InVar As String
		InVar = InputBox("Enter New Max:", "Set Value", lblMax.Text)
		If InVar <> "" Then lblMax.Text = InVar
		
	End Sub
	
	Private Sub lblMin_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblMin.Click
		Dim InVar As String
		InVar = InputBox("Enter New Min:", "Set Value", lblMin.Text)
		If InVar <> "" Then lblMin.Text = InVar
	End Sub
	
	Private Sub mdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mdClose.Click
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(VB6.PixelsToTwipsX(Me.Left)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(VB6.PixelsToTwipsY(Me.Top)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(VB6.PixelsToTwipsX(Me.Width)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(VB6.PixelsToTwipsY(Me.Height)))
		Timer1.Enabled = False
		Me.Close()
	End Sub
	Private Sub Slider1_MouseMoveEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSComctlLib.ISliderEvents_MouseMoveEvent) Handles Slider1.MouseMoveEvent
		Slider1.Value = eventArgs.x / VB6.PixelsToTwipsX(Slider1.Width) * Slider1.Max
		SliderX = eventArgs.x
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim qIndex As Short ' Stores current queue item for calling routine
		If frmMain.DefInstance.MSComm1.PortOpen Then
			StatusBar1.Panels(2)._ObjectDefault = "Connected"
		Else
			StatusBar1.Panels(2)._ObjectDefault = "NOT CONNECTED"
		End If
		txtSetpoint.Text = CStr(CShort((CDbl(lblMax.Text) - CDbl(lblMin.Text)) * SliderX / VB6.PixelsToTwipsX(Slider1.Width)) + CDbl(lblMin.Text))
		If bStream Then
			Cmd = Chr(&H4s) & Chr(setPosition) & DecToHexchars24(Val(txtSetpoint.Text))
			qIndex = frmMain.DefInstance.SendSerial(Cmd)
			While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
				System.Windows.Forms.Application.DoEvents()
			End While
			If Fifo(qIndex).Error_Renamed Then MsgBox("ERROR!", MsgBoxStyle.Critical)
			If Fifo(qIndex).Error_Renamed Then cmdStop_Click(cmdStop, New System.EventArgs()) 'Stop streaming in the case of an error
		End If
	End Sub
	
	Private Sub txtP_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtP.Enter
		VB6.SetDefault(cmdEnter(0), True)
		txtP.SelectionStart = 0
		txtP.SelectionLength = Len(txtP.Text)
	End Sub
	Private Sub txtI_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtI.Enter
		VB6.SetDefault(cmdEnter(1), True)
		txtI.SelectionStart = 0
		txtI.SelectionLength = Len(txtI.Text)
	End Sub
	Private Sub txtD_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtD.Enter
		VB6.SetDefault(cmdEnter(2), True)
		txtD.SelectionStart = 0
		txtD.SelectionLength = Len(txtD.Text)
	End Sub
	Private Sub txtiL_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtiL.Enter
		VB6.SetDefault(cmdEnter(3), True)
		txtiL.SelectionStart = 0
		txtiL.SelectionLength = Len(txtiL.Text)
	End Sub
	Private Sub txtdS_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtdS.Enter
		VB6.SetDefault(cmdEnter(4), True)
		txtdS.SelectionStart = 0
		txtdS.SelectionLength = Len(txtdS.Text)
	End Sub
	Private Sub txtmP_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtmP.Enter
		VB6.SetDefault(cmdEnter(5), True)
		txtmP.SelectionStart = 0
		txtmP.SelectionLength = Len(txtmP.Text)
	End Sub
	Private Sub txtVel_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtVel.Enter
		VB6.SetDefault(cmdEnter(6), True)
		txtVel.SelectionStart = 0
		txtVel.SelectionLength = Len(txtVel.Text)
	End Sub
	Private Sub txtMode_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMode.Enter
		VB6.SetDefault(cmdEnter(7), True)
		txtMode.SelectionStart = 0
		txtMode.SelectionLength = Len(txtMode.Text)
	End Sub
	Private Sub txtpwrLimit_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtpwrLimit.Enter
		VB6.SetDefault(cmdEnter(8), True)
		txtpwrLimit.SelectionStart = 0
		txtpwrLimit.SelectionLength = Len(txtpwrLimit.Text)
	End Sub
End Class