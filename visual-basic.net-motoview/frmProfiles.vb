Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmProfiles
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
	Public WithEvents cmdReset As System.Windows.Forms.Button
	Public WithEvents cmdDecelerate As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdStop As System.Windows.Forms.Button
	Public WithEvents cmdRun As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents txtTotalTime As System.Windows.Forms.TextBox
	Public WithEvents cmdEnter As System.Windows.Forms.Button
	Public WithEvents txtAccelTime As System.Windows.Forms.TextBox
	Public WithEvents txtA As System.Windows.Forms.TextBox
	Public WithEvents txtV As System.Windows.Forms.TextBox
	Public WithEvents txtX As System.Windows.Forms.TextBox
	Public WithEvents cboProfile As System.Windows.Forms.ComboBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProfiles))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ToolTip1.Active = True
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.cmdReset = New System.Windows.Forms.Button
		Me.cmdDecelerate = New System.Windows.Forms.Button
		Me.cmdSave = New System.Windows.Forms.Button
		Me.cmdStop = New System.Windows.Forms.Button
		Me.cmdRun = New System.Windows.Forms.Button
		Me.cmdClose = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtTotalTime = New System.Windows.Forms.TextBox
		Me.cmdEnter = New System.Windows.Forms.Button
		Me.txtAccelTime = New System.Windows.Forms.TextBox
		Me.txtA = New System.Windows.Forms.TextBox
		Me.txtV = New System.Windows.Forms.TextBox
		Me.txtX = New System.Windows.Forms.TextBox
		Me.cboProfile = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Motion Profiles"
		Me.ClientSize = New System.Drawing.Size(366, 267)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmProfiles.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmProfiles"
		Me.Frame2.Text = "Controls"
		Me.Frame2.Size = New System.Drawing.Size(153, 201)
		Me.Frame2.Location = New System.Drawing.Point(200, 16)
		Me.Frame2.TabIndex = 13
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Name = "Frame2"
		Me.cmdReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReset.Text = "Reset to Home"
		Me.cmdReset.Size = New System.Drawing.Size(105, 25)
		Me.cmdReset.Location = New System.Drawing.Point(24, 128)
		Me.cmdReset.TabIndex = 20
		Me.cmdReset.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
		Me.cmdReset.CausesValidation = True
		Me.cmdReset.Enabled = True
		Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdReset.TabStop = True
		Me.cmdReset.Name = "cmdReset"
		Me.cmdDecelerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDecelerate.Text = "Decelerate"
		Me.cmdDecelerate.Size = New System.Drawing.Size(105, 25)
		Me.cmdDecelerate.Location = New System.Drawing.Point(24, 96)
		Me.cmdDecelerate.TabIndex = 17
		Me.cmdDecelerate.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdDecelerate.BackColor = System.Drawing.SystemColors.Control
		Me.cmdDecelerate.CausesValidation = True
		Me.cmdDecelerate.Enabled = True
		Me.cmdDecelerate.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdDecelerate.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDecelerate.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdDecelerate.TabStop = True
		Me.cmdDecelerate.Name = "cmdDecelerate"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.Text = "Save All To Flash"
		Me.cmdSave.Size = New System.Drawing.Size(105, 25)
		Me.cmdSave.Location = New System.Drawing.Point(24, 160)
		Me.cmdSave.TabIndex = 16
		Me.cmdSave.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Enabled = True
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSave.TabStop = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdStop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdStop.Text = "Stop"
		Me.cmdStop.Size = New System.Drawing.Size(73, 25)
		Me.cmdStop.Location = New System.Drawing.Point(40, 56)
		Me.cmdStop.TabIndex = 15
		Me.cmdStop.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdStop.BackColor = System.Drawing.SystemColors.Control
		Me.cmdStop.CausesValidation = True
		Me.cmdStop.Enabled = True
		Me.cmdStop.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdStop.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdStop.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdStop.TabStop = True
		Me.cmdStop.Name = "cmdStop"
		Me.cmdRun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRun.Text = "Run"
		Me.cmdRun.Size = New System.Drawing.Size(73, 25)
		Me.cmdRun.Location = New System.Drawing.Point(40, 24)
		Me.cmdRun.TabIndex = 14
		Me.cmdRun.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdRun.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRun.CausesValidation = True
		Me.cmdRun.Enabled = True
		Me.cmdRun.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRun.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRun.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRun.TabStop = True
		Me.cmdRun.Name = "cmdRun"
		Me.cmdClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClose.Text = "Close"
		Me.cmdClose.Size = New System.Drawing.Size(81, 25)
		Me.cmdClose.Location = New System.Drawing.Point(272, 232)
		Me.cmdClose.TabIndex = 12
		Me.cmdClose.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
		Me.cmdClose.CausesValidation = True
		Me.cmdClose.Enabled = True
		Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClose.TabStop = True
		Me.cmdClose.Name = "cmdClose"
		Me.Frame1.Text = "Motion Profile Data"
		Me.Frame1.Size = New System.Drawing.Size(169, 241)
		Me.Frame1.Location = New System.Drawing.Point(16, 16)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Name = "Frame1"
		Me.txtTotalTime.AutoSize = False
		Me.txtTotalTime.Size = New System.Drawing.Size(57, 19)
		Me.txtTotalTime.Location = New System.Drawing.Point(96, 168)
		Me.txtTotalTime.ReadOnly = True
		Me.txtTotalTime.TabIndex = 18
		Me.txtTotalTime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTotalTime.AcceptsReturn = True
		Me.txtTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtTotalTime.BackColor = System.Drawing.SystemColors.Window
		Me.txtTotalTime.CausesValidation = True
		Me.txtTotalTime.Enabled = True
		Me.txtTotalTime.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtTotalTime.HideSelection = True
		Me.txtTotalTime.Maxlength = 0
		Me.txtTotalTime.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtTotalTime.MultiLine = False
		Me.txtTotalTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtTotalTime.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtTotalTime.TabStop = True
		Me.txtTotalTime.Visible = True
		Me.txtTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtTotalTime.Name = "txtTotalTime"
		Me.cmdEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEnter.Text = "Enter"
		Me.AcceptButton = Me.cmdEnter
		Me.cmdEnter.Size = New System.Drawing.Size(73, 25)
		Me.cmdEnter.Location = New System.Drawing.Point(80, 200)
		Me.cmdEnter.TabIndex = 11
		Me.cmdEnter.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdEnter.BackColor = System.Drawing.SystemColors.Control
		Me.cmdEnter.CausesValidation = True
		Me.cmdEnter.Enabled = True
		Me.cmdEnter.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdEnter.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEnter.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdEnter.TabStop = True
		Me.cmdEnter.Name = "cmdEnter"
		Me.txtAccelTime.AutoSize = False
		Me.txtAccelTime.Size = New System.Drawing.Size(57, 19)
		Me.txtAccelTime.Location = New System.Drawing.Point(96, 144)
		Me.txtAccelTime.ReadOnly = True
		Me.txtAccelTime.TabIndex = 10
		Me.txtAccelTime.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtAccelTime.AcceptsReturn = True
		Me.txtAccelTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtAccelTime.BackColor = System.Drawing.SystemColors.Window
		Me.txtAccelTime.CausesValidation = True
		Me.txtAccelTime.Enabled = True
		Me.txtAccelTime.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtAccelTime.HideSelection = True
		Me.txtAccelTime.Maxlength = 0
		Me.txtAccelTime.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtAccelTime.MultiLine = False
		Me.txtAccelTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtAccelTime.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtAccelTime.TabStop = True
		Me.txtAccelTime.Visible = True
		Me.txtAccelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtAccelTime.Name = "txtAccelTime"
		Me.txtA.AutoSize = False
		Me.txtA.Size = New System.Drawing.Size(57, 19)
		Me.txtA.Location = New System.Drawing.Point(96, 112)
		Me.txtA.TabIndex = 8
		Me.txtA.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtA.AcceptsReturn = True
		Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtA.BackColor = System.Drawing.SystemColors.Window
		Me.txtA.CausesValidation = True
		Me.txtA.Enabled = True
		Me.txtA.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtA.HideSelection = True
		Me.txtA.ReadOnly = False
		Me.txtA.Maxlength = 0
		Me.txtA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtA.MultiLine = False
		Me.txtA.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtA.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtA.TabStop = True
		Me.txtA.Visible = True
		Me.txtA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtA.Name = "txtA"
		Me.txtV.AutoSize = False
		Me.txtV.Size = New System.Drawing.Size(57, 19)
		Me.txtV.Location = New System.Drawing.Point(96, 88)
		Me.txtV.TabIndex = 7
		Me.txtV.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtV.AcceptsReturn = True
		Me.txtV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtV.BackColor = System.Drawing.SystemColors.Window
		Me.txtV.CausesValidation = True
		Me.txtV.Enabled = True
		Me.txtV.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtV.HideSelection = True
		Me.txtV.ReadOnly = False
		Me.txtV.Maxlength = 0
		Me.txtV.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtV.MultiLine = False
		Me.txtV.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtV.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtV.TabStop = True
		Me.txtV.Visible = True
		Me.txtV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtV.Name = "txtV"
		Me.txtX.AutoSize = False
		Me.txtX.Size = New System.Drawing.Size(57, 19)
		Me.txtX.Location = New System.Drawing.Point(96, 64)
		Me.txtX.TabIndex = 6
		Me.txtX.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtX.AcceptsReturn = True
		Me.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtX.BackColor = System.Drawing.SystemColors.Window
		Me.txtX.CausesValidation = True
		Me.txtX.Enabled = True
		Me.txtX.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtX.HideSelection = True
		Me.txtX.ReadOnly = False
		Me.txtX.Maxlength = 0
		Me.txtX.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtX.MultiLine = False
		Me.txtX.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtX.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtX.TabStop = True
		Me.txtX.Visible = True
		Me.txtX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtX.Name = "txtX"
		Me.cboProfile.Size = New System.Drawing.Size(57, 21)
		Me.cboProfile.Location = New System.Drawing.Point(80, 24)
		Me.cboProfile.TabIndex = 2
		Me.cboProfile.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboProfile.BackColor = System.Drawing.SystemColors.Window
		Me.cboProfile.CausesValidation = True
		Me.cboProfile.Enabled = True
		Me.cboProfile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cboProfile.IntegralHeight = True
		Me.cboProfile.Cursor = System.Windows.Forms.Cursors.Default
		Me.cboProfile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cboProfile.Sorted = False
		Me.cboProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cboProfile.TabStop = True
		Me.cboProfile.Visible = True
		Me.cboProfile.Name = "cboProfile"
		Me.Label6.Text = "Total Time (s):"
		Me.Label6.Size = New System.Drawing.Size(81, 17)
		Me.Label6.Location = New System.Drawing.Point(8, 168)
		Me.Label6.TabIndex = 19
		Me.Label6.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label5.Text = "Accel Time (ms):"
		Me.Label5.Size = New System.Drawing.Size(81, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 144)
		Me.Label5.TabIndex = 9
		Me.Label5.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label4.Text = "Acceleration:"
		Me.Label4.Size = New System.Drawing.Size(65, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 112)
		Me.Label4.TabIndex = 5
		Me.Label4.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.Label3.Text = "Velocity:"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(24, 88)
		Me.Label3.TabIndex = 4
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
		Me.Label2.Text = "Distance:"
		Me.Label2.Size = New System.Drawing.Size(49, 17)
		Me.Label2.Location = New System.Drawing.Point(24, 64)
		Me.Label2.TabIndex = 3
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
		Me.Label1.Text = "Profile:"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 26)
		Me.Label1.TabIndex = 1
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
		Me.Controls.Add(Frame2)
		Me.Controls.Add(cmdClose)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(cmdReset)
		Me.Frame2.Controls.Add(cmdDecelerate)
		Me.Frame2.Controls.Add(cmdSave)
		Me.Frame2.Controls.Add(cmdStop)
		Me.Frame2.Controls.Add(cmdRun)
		Me.Frame1.Controls.Add(txtTotalTime)
		Me.Frame1.Controls.Add(cmdEnter)
		Me.Frame1.Controls.Add(txtAccelTime)
		Me.Frame1.Controls.Add(txtA)
		Me.Frame1.Controls.Add(txtV)
		Me.Frame1.Controls.Add(txtX)
		Me.Frame1.Controls.Add(cboProfile)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
	End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmProfiles
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmProfiles
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmProfiles()
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
	Dim qIndex As Short
	Dim i As Short
	Dim Cmd As String
	Dim InData As String
	Dim dS_current As Integer 'Current value of dS, read from device
	'end of declarations
	
	
	'UPGRADE_WARNING: Event cboProfile.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub cboProfile_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cboProfile.SelectedIndexChanged
		GetProfile()
	End Sub
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(VB6.PixelsToTwipsX(Me.Left)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(VB6.PixelsToTwipsY(Me.Top)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(VB6.PixelsToTwipsX(Me.Width)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(VB6.PixelsToTwipsY(Me.Height)))
		Me.Close()
	End Sub
	
	Private Sub cmdDecelerate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDecelerate.Click
		Dim qIndex As Short
		Dim mcMode As Short
		'Now modify the current mode by Setting the Decelerate bit, keeping motor power on
		mcMode = 8 + 2 + 1
		Cmd = Chr(&H2s) & Chr(Mode) & Chr(mcMode)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		
	End Sub
	
	Private Sub cmdEnter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEnter.Click
		i = cboProfile.SelectedIndex
		'Write Distance
		Cmd = Chr(&H4s) & Chr(Profile0 + PROFILE_LEN * i) & DecToHexchars24(Val(txtX.Text))
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		'Write Velocity
		Cmd = Chr(&H3s) & Chr(Profile0 + PROFILE_LEN * i + 3) & DecToHexchars16(Val(txtV.Text))
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		'Write Acceleration
		Cmd = Chr(&H3s) & Chr(Profile0 + PROFILE_LEN * i + 5) & DecToHexchars16(Val(txtA.Text))
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdReset_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReset.Click
		'This command resets the setPosition and mPosition position to 0
		Dim qIndex As Short ' Stores current queue item for calling routine
		
		'Set Mode to zero to turn off motor
		Cmd = Chr(&H2s) & Chr(Mode) & DecToHexchars8(0)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our command to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		
		'Set target position to zero
		Cmd = Chr(&H4s) & Chr(setPosition) & DecToHexchars24(0)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our command to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		
		'Set actual position to zero
		Cmd = Chr(&H4s) & Chr(mPosition) & DecToHexchars24(0)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our command to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		
		'Set Mode to one to turn on motor
		Cmd = Chr(&H2s) & Chr(Mode) & DecToHexchars8(1)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our command to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdRun_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRun.Click
		Dim InData As String
		Dim mcMode As Short
		'Read what the current Mode is set to
		'Cmd = Chr(&H82) & Chr(Mode) & Chr(1)
		'qIndex = frmMain.SendSerial(Cmd)
		'Wait for our response to be completed
		'While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error
		'  DoEvents
		'Wend
		'If Fifo(qIndex).Error Then Exit Sub
		'InData = Fifo(qIndex).Response
		'InData = Right(InData, Len(InData) - 1) 'strip off header (ACK)
		'mcMode = Asc(Mid(InData, 1, 1))
		
		'Set the profile number
		Cmd = Chr(&H2s) & Chr(segnum) & Chr(cboProfile.SelectedIndex)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		
		'Now set the Trajectory ON bit, Motor ON
		mcMode = 3
		Cmd = Chr(&H2s) & Chr(Mode) & Chr(mcMode)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdStop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStop.Click
		Dim InData As String
		Dim mcMode As Short
		Dim mcPosition As Integer
		'Read what the current Mode is set to
		Cmd = Chr(&H82s) & Chr(Mode) & Chr(1)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		mcMode = Asc(Mid(InData, 1, 1))
		'Now modify the current mode by Clearing the Trajectory ON bit
		mcMode = mcMode And (255 - (2 ^ 1))
		Cmd = Chr(&H2s) & Chr(Mode) & Chr(mcMode)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		'Now modify the current mode by Clearing the Trajectory ON bit, keeping motor power on
		mcMode = 1
		Cmd = Chr(&H2s) & Chr(Mode) & Chr(mcMode)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		'Read what the current Position is set to
		Cmd = Chr(&H82s) & Chr(setPosition) & Chr(3)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		mcPosition = Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))) + 65536 * CInt(Asc(Mid(InData, 3, 1)))
		'Now set target position = actual position, so motor will stop, but still be controlling
		Cmd = Chr(&H4s) & Chr(setPosition) & DecToHexchars24(mcPosition)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		Dim qIndex As Short ' Stores current queue item for calling routine
		Dim vbResponse As Object
		cmdEnter_Click(cmdEnter, New System.EventArgs()) 'Make sure the current settings have been sent to the Gamoto
		Cmd = Chr(&H1s) & Chr(StoreFlashCmd)
		'UPGRADE_WARNING: Couldn't resolve default property of object vbResponse. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		vbResponse = MsgBox("This will save profiles AND all key PID parameters to Flash (Kp, Ki, Kd, etc.).  Are you sure?", MsgBoxStyle.OKCancel)
		If vbResponse = MsgBoxResult.OK Then
			qIndex = frmMain.DefInstance.SendSerial(Cmd)
			While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
				System.Windows.Forms.Application.DoEvents()
			End While
		End If
	End Sub
	
	
	Private Sub frmProfiles_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		For i = 0 To 7
			cboProfile.Items.Add(CStr(i))
		Next i
		cboProfile.SelectedIndex = 0
		Me.Left = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(4875))))
		Me.Top = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(3555))))
		Me.Width = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(5610))))
		Me.Height = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(4410))))
	End Sub
	
	Private Sub GetProfile()
		'On Error GoTo GP_Error
		'Read Selected Profile
		i = cboProfile.SelectedIndex
		'Read X from profile (3 bytes)
		Cmd = Chr(&H82s) & Chr(Profile0 + PROFILE_LEN * i) & Chr(3)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtX.Text = CStr(Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))) + 65536 * CInt(Asc(Mid(InData, 3, 1))))
		
		'Read V, A from profile (4 bytes)
		Cmd = Chr(&H82s) & Chr(Profile0 + PROFILE_LEN * i + 3) & Chr(4)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		txtV.Text = CStr(Asc(Mid(InData, 1, 1)) + 256 * CInt(Asc(Mid(InData, 2, 1))))
		txtA.Text = CStr(Asc(Mid(InData, 3, 1)) + 256 * CInt(Asc(Mid(InData, 4, 1))))
		
		'Now read dS from the device, to use later in accel time calcs
		Cmd = Chr(&H82s) & Chr(dS) & Chr(1)
		qIndex = frmMain.DefInstance.SendSerial(Cmd)
		'Wait for our response to be completed
		While (Fifo(qIndex).bytesWaiting > 0) And Not Fifo(qIndex).Error_Renamed
			System.Windows.Forms.Application.DoEvents()
		End While
		If Fifo(qIndex).Error_Renamed Then Exit Sub
		InData = Fifo(qIndex).Response
		InData = VB.Right(InData, Len(InData) - 1) 'strip off header (ACK)
		dS_current = Asc(Mid(InData, 1, 1))
		UpdateTime()
		Exit Sub
GP_Error: 
		MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical)
	End Sub
	
	'UPGRADE_WARNING: Event txtA.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtA_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtA.TextChanged
		UpdateTime()
	End Sub
	
	'UPGRADE_WARNING: Event txtV.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtV_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtV.TextChanged
		UpdateTime()
	End Sub
	
	'UPGRADE_WARNING: Event txtX.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2075"'
	Private Sub txtX_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtX.TextChanged
		UpdateTime()
	End Sub
	Private Sub UpdateTime()
		Dim tA, vMax, acps2, xA, v As Object
		'Exit if any of the parameters are = 0
		If Val(txtX.Text) * Val(txtV.Text) * Val(txtA.Text) * dS_current = 0 Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object acps2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		acps2 = (Val(txtA.Text) / 256) / ((TRAJ_UPDATE_PERIOD / 1000) * dS_current) ^ 2
		'UPGRADE_WARNING: Couldn't resolve default property of object acps2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Min(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object tA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		tA = Min(System.Math.Abs(Val(txtV.Text)) / Val(txtA.Text) * (TRAJ_UPDATE_PERIOD / 1000) * dS_current, (System.Math.Abs(Val(txtX.Text)) / acps2) ^ 0.5)
		'UPGRADE_WARNING: Couldn't resolve default property of object tA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		txtAccelTime.Text = CStr(tA * 1000)
		'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		v = System.Math.Abs((Val(txtV.Text) / 256) / (TRAJ_UPDATE_PERIOD * dS_current) * 1000)
		'UPGRADE_WARNING: Couldn't resolve default property of object tA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object acps2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Min(). Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object vMax. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		vMax = Min(v, acps2 * tA)
		'UPGRADE_WARNING: Couldn't resolve default property of object tA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object acps2. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object xA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		xA = 0.5 * acps2 * tA ^ 2
		'UPGRADE_WARNING: Couldn't resolve default property of object v. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		'UPGRADE_WARNING: Couldn't resolve default property of object vMax. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		If vMax = v Then
			'UPGRADE_WARNING: Couldn't resolve default property of object vMax. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object xA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			'UPGRADE_WARNING: Couldn't resolve default property of object tA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			txtTotalTime.Text = CStr(2 * tA + ((Val(txtX.Text) - 2 * xA) / vMax))
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object tA. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			txtTotalTime.Text = CStr(2 * tA)
		End If
	End Sub
	
	Private Sub txtX_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtX.Enter
		txtX.SelectionStart = 0
		txtX.SelectionLength = Len(txtX.Text)
	End Sub
	Private Sub txtV_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtV.Enter
		txtV.SelectionStart = 0
		txtV.SelectionLength = Len(txtV.Text)
	End Sub
	Private Sub txtA_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtA.Enter
		txtA.SelectionStart = 0
		txtA.SelectionLength = Len(txtA.Text)
	End Sub
End Class