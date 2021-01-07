Option Strict Off
Option Explicit On
Friend Class frmAnalog
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
	Public WithEvents cmdClose As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents _txtAnalog_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnalog_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnalog_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnalog_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtAnalog_0 As System.Windows.Forms.TextBox
	Public WithEvents _sldAnalog_0 As AxMSComctlLib.AxSlider
	Public WithEvents _sldAnalog_1 As AxMSComctlLib.AxSlider
	Public WithEvents _sldAnalog_2 As AxMSComctlLib.AxSlider
	Public WithEvents _sldAnalog_3 As AxMSComctlLib.AxSlider
	Public WithEvents _sldAnalog_4 As AxMSComctlLib.AxSlider
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents _Label1_4 As System.Windows.Forms.Label
	Public WithEvents _Label1_3 As System.Windows.Forms.Label
	Public WithEvents _Label1_2 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents sldAnalog As AxSliderArray.AxSliderArray
	Public WithEvents txtAnalog As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAnalog))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClose = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._txtAnalog_4 = New System.Windows.Forms.TextBox
        Me._txtAnalog_3 = New System.Windows.Forms.TextBox
        Me._txtAnalog_2 = New System.Windows.Forms.TextBox
        Me._txtAnalog_1 = New System.Windows.Forms.TextBox
        Me._txtAnalog_0 = New System.Windows.Forms.TextBox
        Me._sldAnalog_0 = New AxMSComctlLib.AxSlider
        Me._sldAnalog_1 = New AxMSComctlLib.AxSlider
        Me._sldAnalog_2 = New AxMSComctlLib.AxSlider
        Me._sldAnalog_3 = New AxMSComctlLib.AxSlider
        Me._sldAnalog_4 = New AxMSComctlLib.AxSlider
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me._Label1_4 = New System.Windows.Forms.Label
        Me._Label1_3 = New System.Windows.Forms.Label
        Me._Label1_2 = New System.Windows.Forms.Label
        Me._Label1_1 = New System.Windows.Forms.Label
        Me._Label1_0 = New System.Windows.Forms.Label
        Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.sldAnalog = New AxSliderArray.AxSliderArray(Me.components)
        Me.txtAnalog = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        CType(Me._sldAnalog_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._sldAnalog_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._sldAnalog_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._sldAnalog_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._sldAnalog_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sldAnalog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnalog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClose.Location = New System.Drawing.Point(240, 248)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClose.Size = New System.Drawing.Size(73, 25)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "Close"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        '_txtAnalog_4
        '
        Me._txtAnalog_4.AcceptsReturn = True
        Me._txtAnalog_4.AutoSize = False
        Me._txtAnalog_4.BackColor = System.Drawing.SystemColors.Window
        Me._txtAnalog_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtAnalog_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtAnalog_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnalog.SetIndex(Me._txtAnalog_4, CType(4, Short))
        Me._txtAnalog_4.Location = New System.Drawing.Point(256, 200)
        Me._txtAnalog_4.MaxLength = 0
        Me._txtAnalog_4.Name = "_txtAnalog_4"
        Me._txtAnalog_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtAnalog_4.Size = New System.Drawing.Size(49, 19)
        Me._txtAnalog_4.TabIndex = 13
        Me._txtAnalog_4.Text = "Text1"
        Me._txtAnalog_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtAnalog_3
        '
        Me._txtAnalog_3.AcceptsReturn = True
        Me._txtAnalog_3.AutoSize = False
        Me._txtAnalog_3.BackColor = System.Drawing.SystemColors.Window
        Me._txtAnalog_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtAnalog_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtAnalog_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnalog.SetIndex(Me._txtAnalog_3, CType(3, Short))
        Me._txtAnalog_3.Location = New System.Drawing.Point(192, 200)
        Me._txtAnalog_3.MaxLength = 0
        Me._txtAnalog_3.Name = "_txtAnalog_3"
        Me._txtAnalog_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtAnalog_3.Size = New System.Drawing.Size(49, 19)
        Me._txtAnalog_3.TabIndex = 10
        Me._txtAnalog_3.Text = "Text1"
        Me._txtAnalog_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtAnalog_2
        '
        Me._txtAnalog_2.AcceptsReturn = True
        Me._txtAnalog_2.AutoSize = False
        Me._txtAnalog_2.BackColor = System.Drawing.SystemColors.Window
        Me._txtAnalog_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtAnalog_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtAnalog_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnalog.SetIndex(Me._txtAnalog_2, CType(2, Short))
        Me._txtAnalog_2.Location = New System.Drawing.Point(136, 200)
        Me._txtAnalog_2.MaxLength = 0
        Me._txtAnalog_2.Name = "_txtAnalog_2"
        Me._txtAnalog_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtAnalog_2.Size = New System.Drawing.Size(49, 19)
        Me._txtAnalog_2.TabIndex = 7
        Me._txtAnalog_2.Text = "Text1"
        Me._txtAnalog_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtAnalog_1
        '
        Me._txtAnalog_1.AcceptsReturn = True
        Me._txtAnalog_1.AutoSize = False
        Me._txtAnalog_1.BackColor = System.Drawing.SystemColors.Window
        Me._txtAnalog_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtAnalog_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtAnalog_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnalog.SetIndex(Me._txtAnalog_1, CType(1, Short))
        Me._txtAnalog_1.Location = New System.Drawing.Point(80, 200)
        Me._txtAnalog_1.MaxLength = 0
        Me._txtAnalog_1.Name = "_txtAnalog_1"
        Me._txtAnalog_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtAnalog_1.Size = New System.Drawing.Size(49, 19)
        Me._txtAnalog_1.TabIndex = 4
        Me._txtAnalog_1.Text = "Text1"
        Me._txtAnalog_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_txtAnalog_0
        '
        Me._txtAnalog_0.AcceptsReturn = True
        Me._txtAnalog_0.AutoSize = False
        Me._txtAnalog_0.BackColor = System.Drawing.SystemColors.Window
        Me._txtAnalog_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._txtAnalog_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._txtAnalog_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAnalog.SetIndex(Me._txtAnalog_0, CType(0, Short))
        Me._txtAnalog_0.Location = New System.Drawing.Point(24, 200)
        Me._txtAnalog_0.MaxLength = 0
        Me._txtAnalog_0.Name = "_txtAnalog_0"
        Me._txtAnalog_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._txtAnalog_0.Size = New System.Drawing.Size(49, 19)
        Me._txtAnalog_0.TabIndex = 1
        Me._txtAnalog_0.Text = "Text1"
        Me._txtAnalog_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_sldAnalog_0
        '
        Me.sldAnalog.SetIndex(Me._sldAnalog_0, CType(0, Short))
        Me._sldAnalog_0.Location = New System.Drawing.Point(40, 24)
        Me._sldAnalog_0.Name = "_sldAnalog_0"
        Me._sldAnalog_0.OcxState = CType(resources.GetObject("_sldAnalog_0.OcxState"), System.Windows.Forms.AxHost.State)
        Me._sldAnalog_0.Size = New System.Drawing.Size(17, 169)
        Me._sldAnalog_0.TabIndex = 0
        '
        '_sldAnalog_1
        '
        Me.sldAnalog.SetIndex(Me._sldAnalog_1, CType(1, Short))
        Me._sldAnalog_1.Location = New System.Drawing.Point(96, 24)
        Me._sldAnalog_1.Name = "_sldAnalog_1"
        Me._sldAnalog_1.OcxState = CType(resources.GetObject("_sldAnalog_1.OcxState"), System.Windows.Forms.AxHost.State)
        Me._sldAnalog_1.Size = New System.Drawing.Size(17, 169)
        Me._sldAnalog_1.TabIndex = 3
        '
        '_sldAnalog_2
        '
        Me.sldAnalog.SetIndex(Me._sldAnalog_2, CType(2, Short))
        Me._sldAnalog_2.Location = New System.Drawing.Point(152, 24)
        Me._sldAnalog_2.Name = "_sldAnalog_2"
        Me._sldAnalog_2.OcxState = CType(resources.GetObject("_sldAnalog_2.OcxState"), System.Windows.Forms.AxHost.State)
        Me._sldAnalog_2.Size = New System.Drawing.Size(17, 169)
        Me._sldAnalog_2.TabIndex = 6
        '
        '_sldAnalog_3
        '
        Me.sldAnalog.SetIndex(Me._sldAnalog_3, CType(3, Short))
        Me._sldAnalog_3.Location = New System.Drawing.Point(208, 24)
        Me._sldAnalog_3.Name = "_sldAnalog_3"
        Me._sldAnalog_3.OcxState = CType(resources.GetObject("_sldAnalog_3.OcxState"), System.Windows.Forms.AxHost.State)
        Me._sldAnalog_3.Size = New System.Drawing.Size(17, 169)
        Me._sldAnalog_3.TabIndex = 9
        '
        '_sldAnalog_4
        '
        Me.sldAnalog.SetIndex(Me._sldAnalog_4, CType(4, Short))
        Me._sldAnalog_4.Location = New System.Drawing.Point(272, 24)
        Me._sldAnalog_4.Name = "_sldAnalog_4"
        Me._sldAnalog_4.OcxState = CType(resources.GetObject("_sldAnalog_4.OcxState"), System.Windows.Forms.AxHost.State)
        Me._sldAnalog_4.Size = New System.Drawing.Size(17, 169)
        Me._sldAnalog_4.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(24, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Current"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(24, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Motor"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(256, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "1024"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(192, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "1024"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(136, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "1024"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(80, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "1024"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "1024"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_4
        '
        Me._Label1_4.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_4, CType(4, Short))
        Me._Label1_4.Location = New System.Drawing.Point(264, 224)
        Me._Label1_4.Name = "_Label1_4"
        Me._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_4.Size = New System.Drawing.Size(25, 17)
        Me._Label1_4.TabIndex = 14
        Me._Label1_4.Text = "A4"
        Me._Label1_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_3
        '
        Me._Label1_3.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_3, CType(3, Short))
        Me._Label1_3.Location = New System.Drawing.Point(200, 224)
        Me._Label1_3.Name = "_Label1_3"
        Me._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_3.Size = New System.Drawing.Size(25, 17)
        Me._Label1_3.TabIndex = 11
        Me._Label1_3.Text = "A3"
        Me._Label1_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_2
        '
        Me._Label1_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_2, CType(2, Short))
        Me._Label1_2.Location = New System.Drawing.Point(144, 224)
        Me._Label1_2.Name = "_Label1_2"
        Me._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_2.Size = New System.Drawing.Size(25, 17)
        Me._Label1_2.TabIndex = 8
        Me._Label1_2.Text = "A2"
        Me._Label1_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_1
        '
        Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_1, CType(1, Short))
        Me._Label1_1.Location = New System.Drawing.Point(88, 224)
        Me._Label1_1.Name = "_Label1_1"
        Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_1.Size = New System.Drawing.Size(25, 17)
        Me._Label1_1.TabIndex = 5
        Me._Label1_1.Text = "A1"
        Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label1_0
        '
        Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label1_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.SetIndex(Me._Label1_0, CType(0, Short))
        Me._Label1_0.Location = New System.Drawing.Point(32, 224)
        Me._Label1_0.Name = "_Label1_0"
        Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label1_0.Size = New System.Drawing.Size(25, 17)
        Me._Label1_0.TabIndex = 2
        Me._Label1_0.Text = "A0"
        Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAnalog
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(340, 284)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me._txtAnalog_4)
        Me.Controls.Add(Me._txtAnalog_3)
        Me.Controls.Add(Me._txtAnalog_2)
        Me.Controls.Add(Me._txtAnalog_1)
        Me.Controls.Add(Me._txtAnalog_0)
        Me.Controls.Add(Me._sldAnalog_0)
        Me.Controls.Add(Me._sldAnalog_1)
        Me.Controls.Add(Me._sldAnalog_2)
        Me.Controls.Add(Me._sldAnalog_3)
        Me.Controls.Add(Me._sldAnalog_4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me._Label1_4)
        Me.Controls.Add(Me._Label1_3)
        Me.Controls.Add(Me._Label1_2)
        Me.Controls.Add(Me._Label1_1)
        Me.Controls.Add(Me._Label1_0)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmAnalog"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Analog Readings"
        CType(Me._sldAnalog_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._sldAnalog_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._sldAnalog_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._sldAnalog_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._sldAnalog_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sldAnalog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnalog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmAnalog
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmAnalog
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmAnalog()
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
	
	Dim qIndex As Short
	Dim Cmd As String
	Dim InData As String
	Dim i As Short
	
	Private Sub cmdClose_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClose.Click
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(VB6.PixelsToTwipsX(Me.Left)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(VB6.PixelsToTwipsY(Me.Top)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(VB6.PixelsToTwipsX(Me.Width)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(VB6.PixelsToTwipsY(Me.Height)))
		Timer1.Enabled = False
		Me.Close()
	End Sub
	
	Private Sub frmAnalog_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Timer1.Interval = 100
		If frmMain.DefInstance.MSComm1.PortOpen Then
			Timer1.Enabled = True
		End If
		Me.Left = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(5070))))
		Me.Top = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(3435))))
		Me.Width = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(5220))))
		Me.Height = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(4665))))
		Me.Show()
		cmdClose.Focus()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim j As Short
		Dim InData2 As String
		InData = ""
		InData2 = ""
		'Read 12 bytes, starting at Analog0, in 3 blocks of 4
		For j = 0 To 2
			Cmd = Chr(&H82s) & Chr(Analog0 + j * 4) & Chr(4)
			qIndex = frmMain.DefInstance.SendSerial(Cmd)
			'Wait for our response to be completed
			While Fifo(qIndex).bytesWaiting > 0
				System.Windows.Forms.Application.DoEvents()
			End While
			InData2 = Fifo(qIndex).Response
			InData2 = Mid(InData2, 2, Len(InData2) - 2) 'strip off header (ACK) & CS
			InData = InData & InData2
		Next j
		For i = 0 To 4
			txtAnalog(i).Text = CStr(Asc(Mid(InData, 2 * i + 1, 1)) + 256 * CInt(Asc(Mid(InData, 2 * i + 2, 1))))
			sldAnalog(i).Value = sldAnalog(i).Max - Val(txtAnalog(i).Text)
		Next i
	End Sub
End Class