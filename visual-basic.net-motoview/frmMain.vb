Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMain
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			m_vb6FormDefInstance = Me
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
	Public WithEvents Timeout1 As System.Windows.Forms.Timer
	Public WithEvents MSComm1 As AxMSCommLib.AxMSComm
	Public WithEvents mnuExit As System.Windows.Forms.MenuItem
	Public WithEvents mnuFile As System.Windows.Forms.MenuItem
	Public WithEvents mnuPID As System.Windows.Forms.MenuItem
	Public WithEvents mnuAnalog As System.Windows.Forms.MenuItem
	Public WithEvents mnuMotion As System.Windows.Forms.MenuItem
	Public WithEvents mnuLogging As System.Windows.Forms.MenuItem
	Public WithEvents mnuTools As System.Windows.Forms.MenuItem
	Public WithEvents mnuSettings As System.Windows.Forms.MenuItem
	Public WithEvents mnuConnect As System.Windows.Forms.MenuItem
	Public WithEvents mnuDisconnect As System.Windows.Forms.MenuItem
	Public WithEvents mnuCommunication As System.Windows.Forms.MenuItem
	Public WithEvents mnuAbout As System.Windows.Forms.MenuItem
	Public WithEvents mnuHelp As System.Windows.Forms.MenuItem
	Public MainMenu1 As System.Windows.Forms.MainMenu
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timeout1 = New System.Windows.Forms.Timer(Me.components)
        Me.MSComm1 = New AxMSCommLib.AxMSComm()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuExit = New System.Windows.Forms.MenuItem()
        Me.mnuTools = New System.Windows.Forms.MenuItem()
        Me.mnuPID = New System.Windows.Forms.MenuItem()
        Me.mnuAnalog = New System.Windows.Forms.MenuItem()
        Me.mnuMotion = New System.Windows.Forms.MenuItem()
        Me.mnuLogging = New System.Windows.Forms.MenuItem()
        Me.mnuCommunication = New System.Windows.Forms.MenuItem()
        Me.mnuSettings = New System.Windows.Forms.MenuItem()
        Me.mnuConnect = New System.Windows.Forms.MenuItem()
        Me.mnuDisconnect = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timeout1
        '
        Me.Timeout1.Interval = 1
        '
        'MSComm1
        '
        Me.MSComm1.Enabled = True
        Me.MSComm1.Location = New System.Drawing.Point(24, 16)
        Me.MSComm1.Name = "MSComm1"
        Me.MSComm1.OcxState = CType(resources.GetObject("MSComm1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSComm1.Size = New System.Drawing.Size(38, 38)
        Me.MSComm1.TabIndex = 1
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuTools, Me.mnuCommunication, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuExit})
        Me.mnuFile.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 0
        Me.mnuExit.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuExit.Text = "E&xit"
        '
        'mnuTools
        '
        Me.mnuTools.Index = 1
        Me.mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPID, Me.mnuAnalog, Me.mnuMotion, Me.mnuLogging})
        Me.mnuTools.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuTools.Text = "&Tools"
        '
        'mnuPID
        '
        Me.mnuPID.Index = 0
        Me.mnuPID.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuPID.Text = "&PID Settings"
        '
        'mnuAnalog
        '
        Me.mnuAnalog.Index = 1
        Me.mnuAnalog.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuAnalog.Text = "Analog Values"
        '
        'mnuMotion
        '
        Me.mnuMotion.Index = 2
        Me.mnuMotion.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuMotion.Text = "Motion Profiles"
        '
        'mnuLogging
        '
        Me.mnuLogging.Index = 3
        Me.mnuLogging.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuLogging.Text = "Register View"
        '
        'mnuCommunication
        '
        Me.mnuCommunication.Index = 2
        Me.mnuCommunication.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSettings, Me.mnuConnect, Me.mnuDisconnect})
        Me.mnuCommunication.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuCommunication.Text = "Communication"
        '
        'mnuSettings
        '
        Me.mnuSettings.Index = 0
        Me.mnuSettings.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuSettings.Text = "Settings"
        '
        'mnuConnect
        '
        Me.mnuConnect.Index = 1
        Me.mnuConnect.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuConnect.Text = "Connect"
        '
        'mnuDisconnect
        '
        Me.mnuDisconnect.Index = 2
        Me.mnuDisconnect.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuDisconnect.Text = "Disconnect"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 3
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout})
        Me.mnuHelp.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 0
        Me.mnuAbout.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuAbout.Text = "About"
        '
        'frmMain
        '
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(278, 0)
        Me.Controls.Add(Me.MSComm1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Location = New System.Drawing.Point(11, 30)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gamatronix"
        CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmMain
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmMain
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New frmMain()
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
	'Compiled under MS Visual Basic 6.0, SP6
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
	'Version Tracking
	'2/4/04 Compiled & posted version 1.0.1
	'2/4/04 Added Firmware version display in the Help - About box
	'1.0.1 - 2/4/04 Initial Release
	'1.0.2 - 3/12/04 Added new logo, fixed var declaration error in module2
	'1.0.3 - 3/12/04 Fixed Motion profile numbering - now starts at zero, as in manual
	'1.0.4 - 3/31/04
	'Changed profiles to 24-bit distance profiles.  Now this MotoView will only work
	'with Firmware v. 4 and up.
	'Packaged as v. 1.0.4
	'1.0.4 Posted on the Web
	'5/14/04: Made change to program ending tasks.  Moved them from Exit_Click to Unload,
	'to cover the case where the user clicks on the X in the upper right of the window.
	'Fixed bug in Analog display window
	'Released 1.0.5, posted to the web
	'Fixed Bad Help About dialog formatting in WinXP.
	'6/21/04 Fixed Profile calculations - major corrections to the formulas
	'Released 1.0.6, posted to the web
	'9/26/04 Changed all reads to max 4 bytes at a time, to comply with new firmware (v7)
	'that protects the data integrity during a write or read
	'9/26/04 Added Node (Address) setting in Comm dialog, defaults to "0"
	'and changed the way the Header is defined.  Header = $AA + Node address
	'10/11/04 Built version 1.0.7, posted to web
	Public COMport As String
	Public Baud As String
	Public Node As String
	Public OpenPortOnStart As Boolean
	Dim COMsettings As String
	Public qLow As Short
	Public qHi As Short
	Dim i As Short
	
	Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		OpenPortOnStart = CBool(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "OpenPortOnStart", "False"))
		Baud = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "Baud", "19200")
		COMport = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "COMport", "1")
		Node = GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "Node", "0")
		HEADER = &HAAs + Val(Node)
		For i = 0 To 9
			WatchList(i) = CShort(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "WatchList" & i, CStr(-1)))
		Next i
		
		If OpenPortOnStart Then
			mnuConnect_Click(mnuConnect, New System.EventArgs())
		Else
			mnuDisconnect.Enabled = False
			mnuConnect.Enabled = True
		End If
		MSComm1.RThreshold = 1
		Timeout1.Enabled = False
		'UPGRADE_WARNING: Timer property Timeout1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2020"'
		Timeout1.Interval = TIMEOUT
		qLow = 0 'qHi is index of next item in the FIFO to be processed.  Processing takes place from
		'the "bottom" of the queue and works up (first added is first processed)
		'As soon as this item is processed, qLow gets incremented
		qHi = 0 'qHi is index of next available slot in the Queue. It normally points to
		'and empty slot.  A new item gets added here, then qHi is incremented.
		
		Me.Left = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(5000))))
		Me.Top = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(3000))))
		Me.Width = VB6.TwipsToPixelsX(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(3495))))
		Me.Height = VB6.TwipsToPixelsY(CSng(GetSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(675))))
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmMain.Unload has a new behavior. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup2065"'
	Private Sub frmMain_Closed(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Closed
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "OpenPortOnStart", CStr(OpenPortOnStart))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "Baud", Baud)
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "COMport", COMport)
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "Node", Node)
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "left", CStr(VB6.PixelsToTwipsX(Me.Left)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "top", CStr(VB6.PixelsToTwipsY(Me.Top)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "width", CStr(VB6.PixelsToTwipsX(Me.Width)))
		SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, Me.Name, "height", CStr(VB6.PixelsToTwipsY(Me.Height)))
		For i = 0 To 9
			SaveSetting(System.Reflection.Assembly.GetExecutingAssembly.GetName.Name, "Startup", "WatchList" & i, CStr(WatchList(i)))
		Next i
	End Sub
	
	Public Sub mnuAbout_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Popup
		mnuAbout_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Click
		frmAbout.DefInstance.Show()
	End Sub
	
	Public Sub mnuAnalog_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAnalog.Popup
		mnuAnalog_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuAnalog_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAnalog.Click
		frmAnalog.DefInstance.Show()
	End Sub
	
	Public Sub mnuExit_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExit.Popup
		mnuExit_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExit.Click
		Me.Close()
		End
	End Sub
	Public Function SendSerial(ByRef strCmd As String) As Short
		'This routine takes a Gamoto command string as its input
		'It then adds the required header and checksum, does some
		'basic syntax checking of the command, and throws an error
		'if the command is invalid.
		'It then adds this serial request to the FIFO queue, and returns
		'a Queue item number to the calling routine.  The calling routine
		'then monitors this element of the queue to know when the request
		'has been completed.
		Dim rtnBytes As Short
		Dim qLen As Short
		
		'Figure out how many bytes to expect in return
		If Asc(Mid(strCmd, 1, 1)) > 127 Then
			'It's a read command, so find out how many bytes are being read
			rtnBytes = Asc(Mid(strCmd, 3, 1)) + 2
		Else
			'It's a write command, so always expect only two bytes back (ACK + Checksum)
			rtnBytes = 2
		End If
		
		'Add header and checksum
		strCmd = Chr(HEADER) & strCmd
		strCmd = AddCS(strCmd)
		
		'Return queue item number to calling routine
		SendSerial = qHi
		
		'Populate element in Queue with command string
		Fifo(qHi).Cmd = strCmd
		
		'Populate element in Queue with expected number of return bytes
		Fifo(qHi).bytesWaiting = rtnBytes
		
		'Clear way for new response
		Fifo(qHi).Response = ""
		Fifo(qHi).Error_Renamed = False
		
		'Increment index to circular FIFO queue
		qHi = (qHi + 1) Mod UBound(Fifo)
		
		qLen = qHi - qLow
		If qLen < 0 Then 'Deal with wrap (this is a circular queue)
			qLen = qLen + 20
		End If
		
		'Debug
		'Debug.Print qLen
		
		'Check if this is the only item in the Queue
		If qLen = 1 Then
			MSComm1.RThreshold = rtnBytes
			MSComm1.Output = strCmd ' Go ahead and send it
			Timeout1.Enabled = True ' Start timeout timer
		End If
		'Otherwise, we must wait.  Data will be sent by MSComm routine when slot opens up
	End Function
	
	
	Public Sub mnuConnect_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuConnect.Popup
		mnuConnect_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuConnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuConnect.Click
		On Error GoTo ComError
		COMsettings = Baud & ",N,8,1"
		MSComm1.Settings = COMsettings
		MSComm1.CommPort = CShort(COMport)
		MSComm1.PortOpen = True
		mnuDisconnect.Enabled = True
		mnuConnect.Enabled = False
		Exit Sub
		
ComError: 
		MsgBox(Err.Description & ": Check values and try again", MsgBoxStyle.Critical)
	End Sub
	
	Public Sub mnuDisconnect_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDisconnect.Popup
		mnuDisconnect_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuDisconnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDisconnect.Click
		On Error Resume Next
		MSComm1.PortOpen = False
		mnuDisconnect.Enabled = False
		mnuConnect.Enabled = True
	End Sub
	
	
	
	Public Sub mnuLogging_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLogging.Popup
		mnuLogging_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuLogging_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLogging.Click
		frmRegView.DefInstance.Show()
	End Sub
	
	Public Sub mnuMotion_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMotion.Popup
		mnuMotion_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuMotion_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuMotion.Click
		frmProfiles.DefInstance.Show()
	End Sub
	
	Public Sub mnuPID_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPID.Popup
		mnuPID_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuPID_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPID.Click
		frmPID.DefInstance.Show()
	End Sub
	
	Public Sub mnuSettings_Popup(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSettings.Popup
		mnuSettings_Click(eventSender, eventArgs)
	End Sub
	Public Sub mnuSettings_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuSettings.Click
		VB6.ShowForm(frmComm.DefInstance, VB6.FormShowConstants.Modal, Me)
	End Sub
	
	Private Sub MSComm1_OnComm(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSComm1.OnComm
		Dim newData As String
		Dim qLen As Short
		Dim CS As Short
		Dim InData As String
		If MSComm1.CommEvent = MSCommLib.OnCommConstants.comEvReceive Then
			'UPGRADE_WARNING: Couldn't resolve default property of object MSComm1.Input. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
			newData = MSComm1.Input
			Fifo(qLow).Response = Fifo(qLow).Response & newData
			'Deduct number of outstanding bytes by number just received
			Fifo(qLow).bytesWaiting = Fifo(qLow).bytesWaiting - Len(newData)
			'If we got everything we expected, then increment the queue
			If Fifo(qLow).bytesWaiting = 0 Then
				Timeout1.Enabled = False 'Don't time out - we got our response
				InData = Fifo(qLow).Response
				'Check response header (ACK)
				If Asc(Mid(InData, 1, 1)) <> ACK Then
					MsgBox("Error - Bad ACK in response header", MsgBoxStyle.Critical)
				End If
				'Check length
				If Len(InData) < 2 Then
					MsgBox("Error - Bad length of response", MsgBoxStyle.Critical)
					Exit Sub
				End If
				'Check checksum
				CS = 0
				For i = 1 To Len(InData) - 1
					CS = (CS + Asc(Mid(InData, i, 1))) Mod 256
				Next i
				If CS <> Asc(VB.Right(InData, 1)) Then
					MsgBox("Error - Bad Checksum in response", MsgBoxStyle.Critical)
					Exit Sub
				End If
				qLow = (qLow + 1) Mod UBound(Fifo)
				'Check if there is another message waiting in the queue
				qLen = qHi - qLow
				If qLen < 0 Then 'Deal with wrap (this is a circular queue)
					qLen = qLen + 20
				End If
				If qLen > 0 Then
					MSComm1.RThreshold = Fifo(qLow).bytesWaiting
					MSComm1.Output = Fifo(qLow).Cmd
					Timeout1.Enabled = True 'Start comm timeout timer
				End If
			Else
				If Fifo(qLow).bytesWaiting < 0 Then
					MsgBox("Error - Unexpected data received", MsgBoxStyle.Critical)
					'UPGRADE_WARNING: Couldn't resolve default property of object frmMain.MSComm1.Input. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
					InData = frmMain.DefInstance.MSComm1.Input 'Read the rest of whatever garbage is in buffer
				End If
			End If
		End If
		
	End Sub
	
	Private Sub MSComm2_OnComm()
		
	End Sub
	
	Private Sub Timeout1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timeout1.Tick
		Dim InData As String
		MsgBox("Error - Response Timeout.  " & Fifo(qLow).bytesWaiting & " bytes outstanding.  Check connections", MsgBoxStyle.Critical)
		'UPGRADE_WARNING: Couldn't resolve default property of object MSComm1.Input. Click for more: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1037"'
		InData = MSComm1.Input 'Read to clear out whatever may be left in the buffer
		Timeout1.Enabled = False
		Fifo(qLow).Error_Renamed = True
		qLow = (qLow + 1) Mod UBound(Fifo) 'Remove this item from the FIFO queue
	End Sub
End Class