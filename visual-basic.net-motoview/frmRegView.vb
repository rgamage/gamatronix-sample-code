Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmRegView
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
	Public WithEvents cmdStop As System.Windows.Forms.Button
	Public WithEvents cmdStart As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents MSChart1 As AxMSChart20Lib.AxMSChart
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents _cboRegName_9 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_9 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_8 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_8 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_7 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_7 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_6 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_6 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_5 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_5 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_4 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_4 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_3 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_3 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_2 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_2 As System.Windows.Forms.TextBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents _cboRegName_1 As System.Windows.Forms.ComboBox
	Public WithEvents _txtRegValue_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtRegValue_0 As System.Windows.Forms.TextBox
	Public WithEvents _cboRegName_0 As System.Windows.Forms.ComboBox
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cboRegName As Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray
	Public WithEvents txtRegValue As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRegView))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdStop = New System.Windows.Forms.Button
		Me.cmdStart = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.MSChart1 = New AxMSChart20Lib.AxMSChart
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me._cboRegName_9 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_9 = New System.Windows.Forms.TextBox
		Me._cboRegName_8 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_8 = New System.Windows.Forms.TextBox
		Me._cboRegName_7 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_7 = New System.Windows.Forms.TextBox
		Me._cboRegName_6 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_6 = New System.Windows.Forms.TextBox
		Me._cboRegName_5 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_5 = New System.Windows.Forms.TextBox
		Me._cboRegName_4 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_4 = New System.Windows.Forms.TextBox
		Me._cboRegName_3 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_3 = New System.Windows.Forms.TextBox
		Me._cboRegName_2 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_2 = New System.Windows.Forms.TextBox
		Me.cmdClose = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._cboRegName_1 = New System.Windows.Forms.ComboBox
		Me._txtRegValue_1 = New System.Windows.Forms.TextBox
		Me._txtRegValue_0 = New System.Windows.Forms.TextBox
		Me._cboRegName_0 = New System.Windows.Forms.ComboBox
		Me.cboRegName = New Microsoft.VisualBasic.Compatibility.VB6.ComboBoxArray(components)
		Me.txtRegValue = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		CType(Me.MSChart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cboRegName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtRegValue, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Register View"
		Me.ClientSize = New System.Drawing.Size(258, 361)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmRegView.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmRegView"
		Me.Frame2.Text = "Graph of Values"
		Me.Frame2.Size = New System.Drawing.Size(345, 337)
		Me.Frame2.Location = New System.Drawing.Point(264, 16)
		Me.Frame2.TabIndex = 22
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.cmdStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdStop.Text = "Stop"
		Me.cmdStop.Size = New System.Drawing.Size(81, 25)
		Me.cmdStop.Location = New System.Drawing.Point(136, 304)
		Me.cmdStop.TabIndex = 26
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
		Me.cmdStart.Text = "Start"
		Me.cmdStart.Size = New System.Drawing.Size(81, 25)
		Me.cmdStart.Location = New System.Drawing.Point(24, 304)
		Me.cmdStart.TabIndex = 25
		Me.cmdStart.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStart.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStart.CausesValidation = True
		Me.cmdStart.Enabled = True
		Me.cmdStart.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStart.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStart.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStart.TabStop = True
		Me.cmdStart.Name = "cmdStart"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Clear"
		Me.Command1.Size = New System.Drawing.Size(81, 25)
		Me.Command1.Location = New System.Drawing.Point(248, 304)
		Me.Command1.TabIndex = 24
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		MSChart1.OcxState = CType(resources.GetObject("MSChart1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MSChart1.Size = New System.Drawing.Size(321, 289)
		Me.MSChart1.Location = New System.Drawing.Point(8, 16)
		Me.MSChart1.TabIndex = 23
		Me.MSChart1.Name = "MSChart1"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me._cboRegName_9.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_9.Location = New System.Drawing.Point(32, 264)
		Me._cboRegName_9.TabIndex = 21
		Me._cboRegName_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_9.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_9.CausesValidation = True
		Me._cboRegName_9.Enabled = True
		Me._cboRegName_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_9.IntegralHeight = True
		Me._cboRegName_9.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_9.Sorted = False
		Me._cboRegName_9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_9.TabStop = True
		Me._cboRegName_9.Visible = True
		Me._cboRegName_9.Name = "_cboRegName_9"
		Me._txtRegValue_9.AutoSize = False
		Me._txtRegValue_9.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_9.Location = New System.Drawing.Point(144, 264)
		Me._txtRegValue_9.TabIndex = 20
		Me._txtRegValue_9.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_9.AcceptsReturn = True
		Me._txtRegValue_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_9.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_9.CausesValidation = True
		Me._txtRegValue_9.Enabled = True
		Me._txtRegValue_9.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_9.HideSelection = True
		Me._txtRegValue_9.ReadOnly = False
		Me._txtRegValue_9.Maxlength = 0
		Me._txtRegValue_9.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_9.MultiLine = False
		Me._txtRegValue_9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_9.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_9.TabStop = True
		Me._txtRegValue_9.Visible = True
		Me._txtRegValue_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_9.Name = "_txtRegValue_9"
		Me._cboRegName_8.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_8.Location = New System.Drawing.Point(32, 240)
		Me._cboRegName_8.TabIndex = 19
		Me._cboRegName_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_8.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_8.CausesValidation = True
		Me._cboRegName_8.Enabled = True
		Me._cboRegName_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_8.IntegralHeight = True
		Me._cboRegName_8.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_8.Sorted = False
		Me._cboRegName_8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_8.TabStop = True
		Me._cboRegName_8.Visible = True
		Me._cboRegName_8.Name = "_cboRegName_8"
		Me._txtRegValue_8.AutoSize = False
		Me._txtRegValue_8.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_8.Location = New System.Drawing.Point(144, 240)
		Me._txtRegValue_8.TabIndex = 18
		Me._txtRegValue_8.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_8.AcceptsReturn = True
		Me._txtRegValue_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_8.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_8.CausesValidation = True
		Me._txtRegValue_8.Enabled = True
		Me._txtRegValue_8.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_8.HideSelection = True
		Me._txtRegValue_8.ReadOnly = False
		Me._txtRegValue_8.Maxlength = 0
		Me._txtRegValue_8.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_8.MultiLine = False
		Me._txtRegValue_8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_8.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_8.TabStop = True
		Me._txtRegValue_8.Visible = True
		Me._txtRegValue_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_8.Name = "_txtRegValue_8"
		Me._cboRegName_7.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_7.Location = New System.Drawing.Point(32, 216)
		Me._cboRegName_7.TabIndex = 17
		Me._cboRegName_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_7.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_7.CausesValidation = True
		Me._cboRegName_7.Enabled = True
		Me._cboRegName_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_7.IntegralHeight = True
		Me._cboRegName_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_7.Sorted = False
		Me._cboRegName_7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_7.TabStop = True
		Me._cboRegName_7.Visible = True
		Me._cboRegName_7.Name = "_cboRegName_7"
		Me._txtRegValue_7.AutoSize = False
		Me._txtRegValue_7.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_7.Location = New System.Drawing.Point(144, 216)
		Me._txtRegValue_7.TabIndex = 16
		Me._txtRegValue_7.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_7.AcceptsReturn = True
		Me._txtRegValue_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_7.CausesValidation = True
		Me._txtRegValue_7.Enabled = True
		Me._txtRegValue_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_7.HideSelection = True
		Me._txtRegValue_7.ReadOnly = False
		Me._txtRegValue_7.Maxlength = 0
		Me._txtRegValue_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_7.MultiLine = False
		Me._txtRegValue_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_7.TabStop = True
		Me._txtRegValue_7.Visible = True
		Me._txtRegValue_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_7.Name = "_txtRegValue_7"
		Me._cboRegName_6.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_6.Location = New System.Drawing.Point(32, 192)
		Me._cboRegName_6.TabIndex = 15
		Me._cboRegName_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_6.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_6.CausesValidation = True
		Me._cboRegName_6.Enabled = True
		Me._cboRegName_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_6.IntegralHeight = True
		Me._cboRegName_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_6.Sorted = False
		Me._cboRegName_6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_6.TabStop = True
		Me._cboRegName_6.Visible = True
		Me._cboRegName_6.Name = "_cboRegName_6"
		Me._txtRegValue_6.AutoSize = False
		Me._txtRegValue_6.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_6.Location = New System.Drawing.Point(144, 192)
		Me._txtRegValue_6.TabIndex = 14
		Me._txtRegValue_6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_6.AcceptsReturn = True
		Me._txtRegValue_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_6.CausesValidation = True
		Me._txtRegValue_6.Enabled = True
		Me._txtRegValue_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_6.HideSelection = True
		Me._txtRegValue_6.ReadOnly = False
		Me._txtRegValue_6.Maxlength = 0
		Me._txtRegValue_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_6.MultiLine = False
		Me._txtRegValue_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_6.TabStop = True
		Me._txtRegValue_6.Visible = True
		Me._txtRegValue_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_6.Name = "_txtRegValue_6"
		Me._cboRegName_5.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_5.Location = New System.Drawing.Point(32, 168)
		Me._cboRegName_5.TabIndex = 13
		Me._cboRegName_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_5.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_5.CausesValidation = True
		Me._cboRegName_5.Enabled = True
		Me._cboRegName_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_5.IntegralHeight = True
		Me._cboRegName_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_5.Sorted = False
		Me._cboRegName_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_5.TabStop = True
		Me._cboRegName_5.Visible = True
		Me._cboRegName_5.Name = "_cboRegName_5"
		Me._txtRegValue_5.AutoSize = False
		Me._txtRegValue_5.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_5.Location = New System.Drawing.Point(144, 168)
		Me._txtRegValue_5.TabIndex = 12
		Me._txtRegValue_5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_5.AcceptsReturn = True
		Me._txtRegValue_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_5.CausesValidation = True
		Me._txtRegValue_5.Enabled = True
		Me._txtRegValue_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_5.HideSelection = True
		Me._txtRegValue_5.ReadOnly = False
		Me._txtRegValue_5.Maxlength = 0
		Me._txtRegValue_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_5.MultiLine = False
		Me._txtRegValue_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_5.TabStop = True
		Me._txtRegValue_5.Visible = True
		Me._txtRegValue_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_5.Name = "_txtRegValue_5"
		Me._cboRegName_4.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_4.Location = New System.Drawing.Point(32, 144)
		Me._cboRegName_4.TabIndex = 11
		Me._cboRegName_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_4.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_4.CausesValidation = True
		Me._cboRegName_4.Enabled = True
		Me._cboRegName_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_4.IntegralHeight = True
		Me._cboRegName_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_4.Sorted = False
		Me._cboRegName_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_4.TabStop = True
		Me._cboRegName_4.Visible = True
		Me._cboRegName_4.Name = "_cboRegName_4"
		Me._txtRegValue_4.AutoSize = False
		Me._txtRegValue_4.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_4.Location = New System.Drawing.Point(144, 144)
		Me._txtRegValue_4.TabIndex = 10
		Me._txtRegValue_4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_4.AcceptsReturn = True
		Me._txtRegValue_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_4.CausesValidation = True
		Me._txtRegValue_4.Enabled = True
		Me._txtRegValue_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_4.HideSelection = True
		Me._txtRegValue_4.ReadOnly = False
		Me._txtRegValue_4.Maxlength = 0
		Me._txtRegValue_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_4.MultiLine = False
		Me._txtRegValue_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_4.TabStop = True
		Me._txtRegValue_4.Visible = True
		Me._txtRegValue_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_4.Name = "_txtRegValue_4"
		Me._cboRegName_3.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_3.Location = New System.Drawing.Point(32, 120)
		Me._cboRegName_3.TabIndex = 9
		Me._cboRegName_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_3.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_3.CausesValidation = True
		Me._cboRegName_3.Enabled = True
		Me._cboRegName_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_3.IntegralHeight = True
		Me._cboRegName_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_3.Sorted = False
		Me._cboRegName_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_3.TabStop = True
		Me._cboRegName_3.Visible = True
		Me._cboRegName_3.Name = "_cboRegName_3"
		Me._txtRegValue_3.AutoSize = False
		Me._txtRegValue_3.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_3.Location = New System.Drawing.Point(144, 120)
		Me._txtRegValue_3.TabIndex = 8
		Me._txtRegValue_3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_3.AcceptsReturn = True
		Me._txtRegValue_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_3.CausesValidation = True
		Me._txtRegValue_3.Enabled = True
		Me._txtRegValue_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_3.HideSelection = True
		Me._txtRegValue_3.ReadOnly = False
		Me._txtRegValue_3.Maxlength = 0
		Me._txtRegValue_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_3.MultiLine = False
		Me._txtRegValue_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_3.TabStop = True
		Me._txtRegValue_3.Visible = True
		Me._txtRegValue_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_3.Name = "_txtRegValue_3"
		Me._cboRegName_2.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_2.Location = New System.Drawing.Point(32, 96)
		Me._cboRegName_2.TabIndex = 7
		Me._cboRegName_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_2.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_2.CausesValidation = True
		Me._cboRegName_2.Enabled = True
		Me._cboRegName_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_2.IntegralHeight = True
		Me._cboRegName_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_2.Sorted = False
		Me._cboRegName_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_2.TabStop = True
		Me._cboRegName_2.Visible = True
		Me._cboRegName_2.Name = "_cboRegName_2"
		Me._txtRegValue_2.AutoSize = False
		Me._txtRegValue_2.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_2.Location = New System.Drawing.Point(144, 96)
		Me._txtRegValue_2.TabIndex = 6
		Me._txtRegValue_2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_2.AcceptsReturn = True
		Me._txtRegValue_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_2.CausesValidation = True
		Me._txtRegValue_2.Enabled = True
		Me._txtRegValue_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_2.HideSelection = True
		Me._txtRegValue_2.ReadOnly = False
		Me._txtRegValue_2.Maxlength = 0
		Me._txtRegValue_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_2.MultiLine = False
		Me._txtRegValue_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_2.TabStop = True
		Me._txtRegValue_2.Visible = True
		Me._txtRegValue_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_2.Name = "_txtRegValue_2"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.Location = New System.Drawing.Point(160, 328)
		Me.cmdClose.TabIndex = 3
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.Frame1.Text = "Register Values"
		Me.Frame1.Size = New System.Drawing.Size(233, 297)
		Me.Frame1.Location = New System.Drawing.Point(16, 16)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me._cboRegName_1.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_1.Location = New System.Drawing.Point(16, 56)
		Me._cboRegName_1.TabIndex = 5
		Me._cboRegName_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_1.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_1.CausesValidation = True
		Me._cboRegName_1.Enabled = True
		Me._cboRegName_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_1.IntegralHeight = True
		Me._cboRegName_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_1.Sorted = False
		Me._cboRegName_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_1.TabStop = True
		Me._cboRegName_1.Visible = True
		Me._cboRegName_1.Name = "_cboRegName_1"
		Me._txtRegValue_1.AutoSize = False
		Me._txtRegValue_1.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_1.Location = New System.Drawing.Point(128, 56)
		Me._txtRegValue_1.TabIndex = 4
		Me._txtRegValue_1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_1.AcceptsReturn = True
		Me._txtRegValue_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_1.CausesValidation = True
		Me._txtRegValue_1.Enabled = True
		Me._txtRegValue_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_1.HideSelection = True
		Me._txtRegValue_1.ReadOnly = False
		Me._txtRegValue_1.Maxlength = 0
		Me._txtRegValue_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_1.MultiLine = False
		Me._txtRegValue_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_1.TabStop = True
		Me._txtRegValue_1.Visible = True
		Me._txtRegValue_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_1.Name = "_txtRegValue_1"
		Me._txtRegValue_0.AutoSize = False
		Me._txtRegValue_0.Size = New System.Drawing.Size(73, 19)
		Me._txtRegValue_0.Location = New System.Drawing.Point(128, 32)
		Me._txtRegValue_0.TabIndex = 2
		Me._txtRegValue_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtRegValue_0.AcceptsReturn = True
		Me._txtRegValue_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtRegValue_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtRegValue_0.CausesValidation = True
		Me._txtRegValue_0.Enabled = True
		Me._txtRegValue_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtRegValue_0.HideSelection = True
		Me._txtRegValue_0.ReadOnly = False
		Me._txtRegValue_0.Maxlength = 0
		Me._txtRegValue_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtRegValue_0.MultiLine = False
		Me._txtRegValue_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtRegValue_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtRegValue_0.TabStop = True
		Me._txtRegValue_0.Visible = True
		Me._txtRegValue_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtRegValue_0.Name = "_txtRegValue_0"
		Me._cboRegName_0.Size = New System.Drawing.Size(97, 21)
		Me._cboRegName_0.Location = New System.Drawing.Point(16, 32)
		Me._cboRegName_0.TabIndex = 1
		Me._cboRegName_0.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cboRegName_0.BackColor = System.Drawing.SystemColors.Window
		Me._cboRegName_0.CausesValidation = True
		Me._cboRegName_0.Enabled = True
		Me._cboRegName_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._cboRegName_0.IntegralHeight = True
		Me._cboRegName_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cboRegName_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cboRegName_0.Sorted = False
		Me._cboRegName_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me._cboRegName_0.TabStop = True
		Me._cboRegName_0.Visible = True
		Me._cboRegName_0.Name = "_cboRegName_0"
		Me.Controls.Add(Frame2)
		Me.Controls.Add(_cboRegName_9)
		Me.Controls.Add(_txtRegValue_9)
		Me.Controls.Add(_cboRegName_8)
		Me.Controls.Add(_txtRegValue_8)
		Me.Controls.Add(_cboRegName_7)
		Me.Controls.Add(_txtRegValue_7)
		Me.Controls.Add(_cboRegName_6)
		Me.Controls.Add(_txtRegValue_6)
		Me.Controls.Add(_cboRegName_5)
		Me.Controls.Add(_txtRegValue_5)
		Me.Controls.Add(_cboRegName_4)
		Me.Controls.Add(_txtRegValue_4)
		Me.Controls.Add(_cboRegName_3)
		Me.Controls.Add(_txtRegValue_3)
		Me.Controls.Add(_cboRegName_2)
		Me.Controls.Add(_txtRegValue_2)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(cmdStop)
		Me.Frame2.Controls.Add(cmdStart)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame2.Controls.Add(MSChart1)
		Me.Frame1.Controls.Add(_cboRegName_1)
		Me.Frame1.Controls.Add(_txtRegValue_1)
		Me.Frame1.Controls.Add(_txtRegValue_0)
		Me.Frame1.Controls.Add(_cboRegName_0)
		Me.cboRegName.SetIndex(_cboRegName_9, CType(9, Short))
		Me.cboRegName.SetIndex(_cboRegName_8, CType(8, Short))
		Me.cboRegName.SetIndex(_cboRegName_7, CType(7, Short))
		Me.cboRegName.SetIndex(_cboRegName_6, CType(6, Short))
		Me.cboRegName.SetIndex(_cboRegName_5, CType(5, Short))
		Me.cboRegName.SetIndex(_cboRegName_4, CType(4, Short))
		Me.cboRegName.SetIndex(_cboRegName_3, CType(3, Short))
		Me.cboRegName.SetIndex(_cboRegName_2, CType(2, Short))
		Me.cboRegName.SetIndex(_cboRegName_1, CType(1, Short))
		Me.cboRegName.SetIndex(_cboRegName_0, CType(0, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_9, CType(9, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_8, CType(8, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_7, CType(7, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_6, CType(6, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_5, CType(5, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_4, CType(4, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_3, CType(3, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_2, CType(2, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_1, CType(1, Short))
		Me.txtRegValue.SetIndex(_txtRegValue_0, CType(0, Short))
		CType(Me.txtRegValue, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cboRegName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.MSChart1, System.ComponentModel.ISupportInitialize).EndInit()
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmRegView
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmRegView
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmRegView()
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
	Dim mcRegs(30) As mcRegList
	Dim PlotOn As Boolean
	
	
	Private Sub FillRegList()
		mcRegs(0).RegName = "Kp"
		mcRegs(0).RegAddress = Kp
		mcRegs(0).RegLen = 2
		mcRegs(1).RegName = "Ki"
		mcRegs(1).RegAddress = Ki
		mcRegs(1).RegLen = 2
		mcRegs(2).RegName = "Kd"
		mcRegs(2).RegAddress = Kd
		mcRegs(2).RegLen = 2
		mcRegs(3).RegName = "iLimit"
		mcRegs(3).RegAddress = iL
		mcRegs(3).RegLen = 2
		mcRegs(4).RegName = "dS"
		mcRegs(4).RegAddress = dS
		mcRegs(4).RegLen = 1
		mcRegs(5).RegName = "Mode"
		mcRegs(5).RegAddress = Mode
		mcRegs(5).RegLen = 1
		mcRegs(6).RegName = "pwrLimit"
		mcRegs(6).RegAddress = pwrLimit
		mcRegs(6).RegLen = 1
		mcRegs(7).RegName = "setPosition"
		mcRegs(7).RegAddress = setPosition
		mcRegs(7).RegLen = 3
		mcRegs(8).RegName = "mPosition"
		mcRegs(8).RegAddress = mPosition
		mcRegs(8).RegLen = 3
		mcRegs(9).RegName = "setVelocity"
		mcRegs(9).RegAddress = setVelocity
		mcRegs(9).RegLen = 2
		mcRegs(10).RegName = "mVelocity"
		mcRegs(10).RegAddress = mVelocity
		mcRegs(10).RegLen = 2
		mcRegs(11).RegName = "segnum"
		mcRegs(11).RegAddress = segnum
		mcRegs(11).RegLen = 1
		mcRegs(12).RegName = "mPower"
		mcRegs(12).RegAddress = mPower
		mcRegs(12).RegLen = 1
		mcRegs(13).RegName = "u0"
		mcRegs(13).RegAddress = 97
		mcRegs(13).RegLen = 3
		mcRegs(14).RegName = "Analog0"
		mcRegs(14).RegAddress = Analog0
		mcRegs(14).RegLen = 2
		mcRegs(15).RegName = "Analog1"
		mcRegs(15).RegAddress = Analog1
		mcRegs(15).RegLen = 2
		mcRegs(16).RegName = "Analog2"
		mcRegs(16).RegAddress = Analog2
		mcRegs(16).RegLen = 2
		mcRegs(17).RegName = "Analog3"
		mcRegs(17).RegAddress = Analog3
		mcRegs(17).RegLen = 2
		mcRegs(18).RegName = "Analog4"
		mcRegs(18).RegAddress = Analog4
		mcRegs(18).RegLen = 2
		mcRegs(19).RegName = "fPosition"
		mcRegs(19).RegAddress = 87
		mcRegs(19).RegLen = 3
		mcRegs(20).RegName = "FlatCount"
		mcRegs(20).RegAddress = 90
		mcRegs(20).RegLen = 3
		mcRegs(21).RegName = "Vlim"
		mcRegs(21).RegAddress = 105
		mcRegs(21).RegLen = 2
		mcRegs(22).RegName = "Accel"
		mcRegs(22).RegAddress = 107
		mcRegs(22).RegLen = 3
		mcRegs(23).RegName = "Phase1dist"
		mcRegs(23).RegAddress = 110
		mcRegs(23).RegLen = 2
		mcRegs(24).RegName = "integral"
		mcRegs(24).RegAddress = 67
		mcRegs(24).RegLen = 2
		mcRegs(25).RegName = "dummy1"
		mcRegs(25).RegAddress = dummy1
		mcRegs(26).RegLen = 1
		mcRegs(26).RegName = "UpCount"
		mcRegs(26).RegAddress = UpCount
		mcRegs(27).RegLen = 1
		mcRegs(27).RegName = "DnCount"
		mcRegs(27).RegAddress = DnCount
		mcRegs(28).RegLen = 1
		mcRegs(28).RegName = "dBug1"
		mcRegs(28).RegAddress = dBug1
		mcRegs(29).RegLen = 1
		mcRegs(29).RegName = "dBug2"
		mcRegs(29).RegAddress = dBug2
		mcRegs(30).RegLen = 3
		mcRegs(30).RegName = "Ypid"
		mcRegs(30).RegAddress = Ypid
	End Sub
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		Dim i As Short
		'Save watch list settings
		For i = 0 To 9
			WatchList(i) = cboRegName(i).SelectedIndex
		Next i
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(VB6.PixelsToTwipsX(Me.Left)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(VB6.PixelsToTwipsY(Me.Top)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(VB6.PixelsToTwipsX(Me.Width)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(VB6.PixelsToTwipsY(Me.Height)))
		Timer1.Enabled = False
		Me.Close()
	End Sub
	
	Private Sub cmdStart_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStart.Click
		PlotOn = True
		
	End Sub
	
	Private Sub cmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStop.Click
		PlotOn = False
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		MSChart1.RowCount = 0
		MSChart1.ColumnCount = 0
		
	End Sub
	
	Private Sub frmRegView_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Short
		Dim j As Short
		Dim cBox As System.Windows.Forms.ComboBox
		PlotOn = False
		Timer1.Interval = 100
		FillRegList()
		For i = 0 To 9
			For j = 0 To UBound(mcRegs)
				cboRegName(i).Items.Add(mcRegs(j).RegName)
			Next j
		Next 
		For i = 0 To 9
			SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "WatchList" & i, CStr(WatchList(i)))
			cboRegName(i).SelectedIndex = WatchList(i)
		Next i
		If frmMain.DefInstance.MSComm1.PortOpen = True Then
			Timer1.Enabled = True
		End If
		MSChart1.ColumnCount = 0
		MSChart1.RowCount = 0
		Me.Left = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(5685))))
		Me.Top = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(2850))))
		Me.Width = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(3990))))
		Me.Height = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(5820))))
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim i As Short
		Dim lIndex As Short
		Dim Cmd As String
		Dim qIndex As Short
		Dim InData As String
		Dim regData As Integer
		Dim L As Short
		
		
		If PlotOn Then
			MSChart1.RowCount = MSChart1.RowCount + 1
			MSChart1.Row = MSChart1.RowCount
		End If
		'TEST CODE ADDED FOR DEBUGGING THE ALEDGED MISSING CHECKSUM BUG FROM ERIC J
		'Const PI = 3.1415927
		'Dim angle As Single
		'Dim sinPos as singe
		'angle = angle + 1 Mod 360
		'sinPos = Sin(angle * PI / 180) * 500
		'Debug.Print sinPos
		'  Cmd = Chr(&H4) & Chr(setPosition) & DecToHexchars24(Val(sinPos))
		'  qIndex = frmMain.SendSerial(Cmd)
		'  While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
		'     DoEvents
		'  Wend
		'  If Fifo(qIndex).Error Then MsgBox "ERROR!", vbCritical
		'END TEST CODE
		For i = 0 To 9
			lIndex = cboRegName(i).SelectedIndex
			regData = 0
			If lIndex >= 0 Then
				Cmd = Chr(&H82s) & Chr(mcRegs(lIndex).RegAddress) & Chr(mcRegs(lIndex).RegLen)
				qIndex = frmMain.DefInstance.SendSerial(Cmd)
				'Wait for our response to be completed
				While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
					System.Windows.Forms.Application.DoEvents()
				End While
				If Fifo(qIndex).Error_Renamed Then
					Timer1.Enabled = False
					Exit Sub
				End If
				InData = Fifo(qIndex).Response
				InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
				L = mcRegs(lIndex).RegLen
				Select Case L
					Case 1
						regData = Asc(Mid(InData, 1, 1))
					Case 2
						regData = Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1)))
					Case 3
						regData = Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))) + 65536 * CInt(Asc(Mid(InData, 3, 1)))
				End Select
				If regData >= (2 ^ (8 * L) / 2) Then
					regData = regData - 2 ^ (8 * L)
				End If
				txtRegValue(i).Text = CStr(regData)
			End If
			If i < 4 Then
				If PlotOn Then
					'Update chart
					MSChart1.ColumnCount = MSChart1.ColumnCount + 1
					MSChart1.Column = MSChart1.ColumnCount
					MSChart1.Data = CStr(regData)
				End If
			End If
		Next i
	End Sub
End Class