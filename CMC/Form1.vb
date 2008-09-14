Imports System
Imports System.management
Imports System.Threading
Imports System.Net
Imports System.IO
Imports Microsoft.Win32
Imports System.DirectoryServices
Imports System.ComponentModel



Public Class Form1

    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

#Region " form layout code"

    ' Declares variables.
    Friend WithEvents PingButton As System.Windows.Forms.Button
    Friend WithEvents altPassword_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents mmcToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents evntToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents usrsToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents regToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents zenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents rdpToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents vncToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents vncinstall As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Prefs_Menu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AppendToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolbarEnabled As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MicrosoftMMCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventViewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalUsersAndGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SharedFoldersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteDesktopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VNCToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZenworksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteAssistanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstallAndConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectOnlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteDesktopConnectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RDPConsoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableRDPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADUserInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents svccontextmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents svcname As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents svcstop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents svcstart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents svcrestart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents startmode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AutomaticMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisabledMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RefreshMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultiThreadMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TelnetMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NetSendMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents options As System.Windows.Forms.TabPage
    Friend WithEvents PrefCancel As System.Windows.Forms.Button
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents defHW As System.Windows.Forms.CheckBox
    Friend WithEvents defNW As System.Windows.Forms.CheckBox
    Friend WithEvents defPR As System.Windows.Forms.CheckBox
    Friend WithEvents defSV As System.Windows.Forms.CheckBox
    Friend WithEvents about As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents version As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents message As System.Windows.Forms.TabPage
    Friend WithEvents netsendCancel As System.Windows.Forms.Button
    Friend WithEvents NetSendTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents aduser As System.Windows.Forms.TabPage
    Friend WithEvents PasswordGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents forcepasswordchange As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents resetpassword As System.Windows.Forms.Button
    Friend WithEvents password1 As System.Windows.Forms.TextBox
    Friend WithEvents password2 As System.Windows.Forms.TextBox
    Friend WithEvents FQDN As System.Windows.Forms.TextBox
    Friend WithEvents samaccountname As System.Windows.Forms.TextBox
    Friend WithEvents mail As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents adGroupsListBox As System.Windows.Forms.ListBox
    Friend WithEvents profileGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TerminalServicesHomeDrive As System.Windows.Forms.TextBox
    Friend WithEvents TerminalServicesHomeDirectory As System.Windows.Forms.TextBox
    Friend WithEvents profilepath As System.Windows.Forms.TextBox
    Friend WithEvents homedirectory As System.Windows.Forms.TextBox
    Friend WithEvents homedrive As System.Windows.Forms.TextBox
    Friend WithEvents TerminalServicesProfilePath As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents userupdate_button As System.Windows.Forms.Button
    Friend WithEvents telephonenumber As System.Windows.Forms.TextBox
    Private WithEvents tools As System.Windows.Forms.TabPage
    Friend WithEvents joinGroupbox As System.Windows.Forms.GroupBox
    Friend WithEvents joinbutton As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents joindompass As System.Windows.Forms.TextBox
    Friend WithEvents joindomuser As System.Windows.Forms.TextBox
    Friend WithEvents joindomainuserlabel As System.Windows.Forms.Label
    Friend WithEvents domaintojoin As System.Windows.Forms.TextBox
    Friend WithEvents nbtstat As System.Windows.Forms.Button
    Friend WithEvents tracert As System.Windows.Forms.Button
    Friend WithEvents Ping As System.Windows.Forms.Button
    Friend WithEvents RenameGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RenameIt As System.Windows.Forms.Button
    Friend WithEvents domaccountlabel As System.Windows.Forms.Label
    Friend WithEvents netdompass As System.Windows.Forms.TextBox
    Friend WithEvents netdomname As System.Windows.Forms.TextBox
    Friend WithEvents newname As System.Windows.Forms.TextBox
    Friend WithEvents oldname As System.Windows.Forms.TextBox
    Friend WithEvents domainroleLabel As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RenameArea As System.Windows.Forms.Button
    Friend WithEvents pingcontinuous As System.Windows.Forms.CheckBox
    Friend WithEvents software As System.Windows.Forms.TabPage
    Friend WithEvents software_button As System.Windows.Forms.Button
    Friend WithEvents ShowUpdates As System.Windows.Forms.CheckBox
    Private WithEvents processes As System.Windows.Forms.TabPage
    Friend WithEvents ProcessRefresh As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RunNewProcess As System.Windows.Forms.Button
    Friend WithEvents interactive As System.Windows.Forms.CheckBox
    Friend WithEvents newprocess As System.Windows.Forms.TextBox
    Private WithEvents services As System.Windows.Forms.TabPage
    Friend WithEvents svc_datagrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents refreshsvc As System.Windows.Forms.Button
    Friend WithEvents network As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dnssearchbutton As System.Windows.Forms.Button
    Friend WithEvents primdnssetbutton As System.Windows.Forms.Button
    Friend WithEvents staticdnsbutton As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sfx1 As System.Windows.Forms.TextBox
    Friend WithEvents dnsservers As System.Windows.Forms.TextBox
    Friend WithEvents suffix As System.Windows.Forms.TextBox
    Friend WithEvents networkupdate As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents staticbutton As System.Windows.Forms.Button
    Friend WithEvents dhcpbutton As System.Windows.Forms.Button
    Friend WithEvents gateway As System.Windows.Forms.TextBox
    Friend WithEvents subnet As System.Windows.Forms.TextBox
    Friend WithEvents ipaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents domain As System.Windows.Forms.TextBox
    Friend WithEvents domainlabel As System.Windows.Forms.Label
    Friend WithEvents macaddress As System.Windows.Forms.TextBox
    Friend WithEvents hostname As System.Windows.Forms.TextBox
    Private WithEvents os As System.Windows.Forms.TabPage
    Friend WithEvents adbutton As System.Windows.Forms.Button
    Friend WithEvents ie As System.Windows.Forms.TextBox
    Friend WithEvents ielabel As System.Windows.Forms.Label
    Friend WithEvents HWButton As System.Windows.Forms.Button
    Friend WithEvents Hardware As System.Windows.Forms.GroupBox
    Friend WithEvents hdCombo As System.Windows.Forms.ComboBox
    Friend WithEvents cpuBox As System.Windows.Forms.TextBox
    Friend WithEvents RAMBox As System.Windows.Forms.TextBox
    Friend WithEvents makemodel As System.Windows.Forms.TextBox
    Friend WithEvents SNoBox As System.Windows.Forms.TextBox
    Friend WithEvents chassis As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox_Shares As System.Windows.Forms.ListBox
    Friend WithEvents Button_openshare As System.Windows.Forms.Button
    Friend WithEvents Label_User As System.Windows.Forms.TextBox
    Friend WithEvents Label_Boot As System.Windows.Forms.TextBox
    Friend WithEvents Label_Ver As System.Windows.Forms.TextBox
    Friend WithEvents Label_SP As System.Windows.Forms.TextBox
    Friend WithEvents Label_OS As System.Windows.Forms.TextBox
    Friend WithEvents Label_Name As System.Windows.Forms.TextBox
    Friend WithEvents LabelIP As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelUser As System.Windows.Forms.Label
    Friend WithEvents LabelSP As System.Windows.Forms.Label
    Friend WithEvents LabelV As System.Windows.Forms.Label
    Friend WithEvents LabelBoot As System.Windows.Forms.Label
    Friend WithEvents LabelOS As System.Windows.Forms.Label
    Private WithEvents Tabholder1 As System.Windows.Forms.TabControl
    Friend WithEvents aboutOK As System.Windows.Forms.Button
    Friend WithEvents msgboxTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents msgSend As System.Windows.Forms.Button
    Friend WithEvents msgboxradio As System.Windows.Forms.RadioButton
    Friend WithEvents netsendradio As System.Windows.Forms.RadioButton
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ShutDownMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents processgrid As System.Windows.Forms.DataGridView
    Friend WithEvents previewbutton As System.Windows.Forms.Button
    Friend WithEvents test As System.Windows.Forms.TabPage
    Friend WithEvents netdomreboot As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents startup As System.Windows.Forms.TabPage
    Friend WithEvents startupbutton As System.Windows.Forms.Button
    Friend WithEvents startupDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents stup_user As System.Windows.Forms.TextBox
    Friend WithEvents stup_location As System.Windows.Forms.TextBox
    Friend WithEvents stup_command As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents StartUpProgramsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents startupName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startupCommand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startupLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startupUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents startupDeleteButton As System.Windows.Forms.Button
    Friend WithEvents startupModifyButton As System.Windows.Forms.Button
    Friend WithEvents startupApplyButton As System.Windows.Forms.Button
    Friend WithEvents printers As System.Windows.Forms.TabPage
    Friend WithEvents printerRefresh As System.Windows.Forms.Button
    Friend WithEvents printerGrid As System.Windows.Forms.DataGridView
    Friend WithEvents mappings As System.Windows.Forms.ListBox
    Friend WithEvents MappedDrivesButton As System.Windows.Forms.Button
    Friend WithEvents mappeddrivesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents addthisprinter As System.Windows.Forms.TextBox
    Friend WithEvents printermenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ptrproperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ptsvrproperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents addptr As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ptrrefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletePrinterMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintersMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pLocation As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewPrintersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintServerPropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents MappedDrivesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents addshare As System.Windows.Forms.Button
    Friend WithEvents delete_Share As System.Windows.Forms.Button
    Friend WithEvents critical As System.Windows.Forms.RadioButton
    Friend WithEvents question As System.Windows.Forms.RadioButton
    Friend WithEvents exclamation As System.Windows.Forms.RadioButton
    Friend WithEvents information As System.Windows.Forms.RadioButton
    Friend WithEvents nomodal As System.Windows.Forms.RadioButton
    Friend WithEvents modallabel As System.Windows.Forms.Label
    Friend WithEvents computername As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperatingSystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetworkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MappedDrivesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents SettingAltPass As System.Windows.Forms.TextBox
    Friend WithEvents SettingAltUser As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents addmappeddrive_letter As System.Windows.Forms.TextBox
    Friend WithEvents addmappeddrive_path As System.Windows.Forms.TextBox
    Friend WithEvents addmappeddrive_button As System.Windows.Forms.Button
    Friend WithEvents deletemappeddrive As System.Windows.Forms.Button
    Friend WithEvents GoogleLookupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPrinterButton As System.Windows.Forms.Button
    Friend WithEvents addptr4all As System.Windows.Forms.CheckBox
    Friend WithEvents DeleteNetworkPrinterMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForThisUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForAllUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_IP As System.Windows.Forms.TextBox
    Friend WithEvents sfxlist As System.Windows.Forms.ListBox
    Friend WithEvents sfx_add_button As System.Windows.Forms.Button
    Friend WithEvents sfx_delete As System.Windows.Forms.Button
    Friend WithEvents psexecpath As System.Windows.Forms.TextBox
    Friend WithEvents downloadpsexec As System.Windows.Forms.Button
    Friend WithEvents psexecbrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents command As System.Windows.Forms.TextBox
    Friend WithEvents copy As System.Windows.Forms.CheckBox
    Friend WithEvents returnval As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents interactively As System.Windows.Forms.CheckBox
    Friend WithEvents proxyset As System.Windows.Forms.Button
    Friend WithEvents DisableRDPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceLogoffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForceRebootToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PowerDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForcePowerDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents adpanel As System.Windows.Forms.Panel
    Friend WithEvents AdaptorID As System.Windows.Forms.TextBox
    Friend WithEvents ScheduleTime As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ScheduleButton As System.Windows.Forms.Button
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RemRegMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindRegMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents sw_use_wmi_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents get_processes_by_wmi_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents InstallAndConnectNoUserPromptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents deploy As System.Windows.Forms.TabPage
    Friend WithEvents installcmd As System.Windows.Forms.TextBox
    Friend WithEvents installcmd_checkbox As System.Windows.Forms.CheckBox
    Friend WithEvents load_appdeploy As System.Windows.Forms.Button
    Friend WithEvents save_appdeploy As System.Windows.Forms.Button
    Friend WithEvents GetFolder2 As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents _to As System.Windows.Forms.TextBox
    Friend WithEvents AppGo_Button As System.Windows.Forms.Button
    Friend WithEvents DeployToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Add_File_Folder As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents edit As System.Windows.Forms.LinkLabel
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents deploy_clear_link As System.Windows.Forms.LinkLabel
    Friend WithEvents sgrid As System.Windows.Forms.DataGridView
    Friend WithEvents SetPrinterAsDefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents close_on_finish As System.Windows.Forms.CheckBox
    Friend WithEvents run_visible As System.Windows.Forms.CheckBox
    Friend WithEvents folder_radio As System.Windows.Forms.RadioButton
    Friend WithEvents file_radio As System.Windows.Forms.RadioButton
    Friend WithEvents file_folder As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cpu_info_lbl As System.Windows.Forms.LinkLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_Monitor As System.Windows.Forms.Button
    Friend WithEvents video_label As System.Windows.Forms.LinkLabel
    Friend WithEvents audio_label As System.Windows.Forms.LinkLabel
    Friend WithEvents msg_radio As System.Windows.Forms.RadioButton
    Friend WithEvents stdInbtn As System.Windows.Forms.Button
    Friend WithEvents testbox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmdtorun As System.Windows.Forms.TextBox
    Friend WithEvents MSinfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_AddGroup As System.Windows.Forms.Button
    Friend WithEvents setSiteOrg As System.Windows.Forms.Button
    Friend WithEvents org As System.Windows.Forms.ComboBox
    Friend WithEvents sitename As System.Windows.Forms.TextBox
    Friend WithEvents domainlogon As System.Windows.Forms.CheckBox
    Friend WithEvents groupToAdd As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GPUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BothComputerAndUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlyComputerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlyUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpo As System.Windows.Forms.TabPage
    Friend WithEvents GPODataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btn_startupscripts As System.Windows.Forms.Button
    Friend WithEvents gprefresh As System.Windows.Forms.Button
    Friend WithEvents gpoContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents script_openContainer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gpoDebugMode As System.Windows.Forms.Label
    Friend WithEvents btn_GetSiteOrg As System.Windows.Forms.Button
    Friend WithEvents gpoDebugCombo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_gpo_policies As System.Windows.Forms.Button
    Friend WithEvents col0 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupPolicyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents btn_dsa As System.Windows.Forms.Button
    Friend WithEvents gpupdateChoice As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lbl_rsop As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_debug As System.Windows.Forms.LinkLabel
    Friend WithEvents lbl_localgpo As System.Windows.Forms.LinkLabel
    Friend WithEvents mnuProcKill As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProcGoogle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mnuCopyPath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents procMenuHeader As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DomainCombo As System.Windows.Forms.ComboBox
    Friend WithEvents swname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents swver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents swpub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents swdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents swloc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents swunins As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sw_url As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents swContextmenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuSwName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSwProps As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSwUninst As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSvcProperties As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcceptPause As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AcceptStop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PathName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblDhcp As System.Windows.Forms.Label
    Friend WithEvents PropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents admanagement As System.Windows.Forms.Button
    Friend WithEvents pr_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pr_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents executablepath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PerfMonMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exec As System.Windows.Forms.Button


    Public Sub New()
        ' This call is required for Windows Form Designer support.
        InitializeComponent()
    End Sub
    ' This method is required for Designer support.
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents ButtonExit As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GO_Button As System.Windows.Forms.Button
    Friend WithEvents AltUserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents altusername_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents notification_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Panel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.ButtonClear = New System.Windows.Forms.Button
        Me.ButtonExit = New System.Windows.Forms.Button
        Me.svccontextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.svcname = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.svcstop = New System.Windows.Forms.ToolStripMenuItem
        Me.svcstart = New System.Windows.Forms.ToolStripMenuItem
        Me.svcrestart = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.startmode = New System.Windows.Forms.ToolStripMenuItem
        Me.AutomaticMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ManualMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.DisabledMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSvcProperties = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator
        Me.GoogleLookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.Label11 = New System.Windows.Forms.Label
        Me.GO_Button = New System.Windows.Forms.Button
        Me.AltUserCheckBox = New System.Windows.Forms.CheckBox
        Me.altusername_TextBox = New System.Windows.Forms.TextBox
        Me.notification_label = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.StatusBarPanel
        Me.Panel2 = New System.Windows.Forms.StatusBarPanel
        Me.Panel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.PingButton = New System.Windows.Forms.Button
        Me.altPassword_TextBox = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.mmcToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.evntToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.usrsToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.regToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.cmdToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.zenToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.rdpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.vncToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.vncinstall = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AppendToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MicrosoftMMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComputerManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EventViewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LocalUsersAndGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SharedFoldersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoteControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoteDesktopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoteDesktopConnectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDPConsoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnableRDPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisableRDPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VNCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectOnlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstallAndConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstallAndConnectNoUserPromptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ZenworksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoteAssistanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TelnetMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.MSinfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintersMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewPrintersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintServerPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MappedDrivesMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.StartUpProgramsMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GPUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BothComputerAndUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnlyComputerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnlyUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.ShutDownMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TurnOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForceLogoffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForceRebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PowerDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForcePowerDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NetSendMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.WindRegMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemRegMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator
        Me.ADUserInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PerfMonMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.GoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OperatingSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NetworkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServicesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MappedDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeployToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupPolicyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StartupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Prefs_Menu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MultiThreadMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolbarEnabled = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.ViewLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator
        Me.ClearHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.options = New System.Windows.Forms.TabPage
        Me.DomainCombo = New System.Windows.Forms.ComboBox
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.psexecbrowse = New System.Windows.Forms.Button
        Me.downloadpsexec = New System.Windows.Forms.Button
        Me.psexecpath = New System.Windows.Forms.TextBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.SettingAltPass = New System.Windows.Forms.TextBox
        Me.SettingAltUser = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.PrefCancel = New System.Windows.Forms.Button
        Me.Save_Button = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.defHW = New System.Windows.Forms.CheckBox
        Me.defNW = New System.Windows.Forms.CheckBox
        Me.defPR = New System.Windows.Forms.CheckBox
        Me.defSV = New System.Windows.Forms.CheckBox
        Me.about = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.aboutOK = New System.Windows.Forms.Button
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.version = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.message = New System.Windows.Forms.TabPage
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.modallabel = New System.Windows.Forms.Label
        Me.critical = New System.Windows.Forms.RadioButton
        Me.question = New System.Windows.Forms.RadioButton
        Me.exclamation = New System.Windows.Forms.RadioButton
        Me.information = New System.Windows.Forms.RadioButton
        Me.nomodal = New System.Windows.Forms.RadioButton
        Me.previewbutton = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.msgSend = New System.Windows.Forms.Button
        Me.msgboxTitle = New System.Windows.Forms.TextBox
        Me.NetSendTextBox = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.msg_radio = New System.Windows.Forms.RadioButton
        Me.msgboxradio = New System.Windows.Forms.RadioButton
        Me.netsendradio = New System.Windows.Forms.RadioButton
        Me.Label35 = New System.Windows.Forms.Label
        Me.netsendCancel = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.aduser = New System.Windows.Forms.TabPage
        Me.adpanel = New System.Windows.Forms.Panel
        Me.profileGroupBox = New System.Windows.Forms.GroupBox
        Me.profilepath = New System.Windows.Forms.TextBox
        Me.homedirectory = New System.Windows.Forms.TextBox
        Me.homedrive = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.tsGroupBox = New System.Windows.Forms.GroupBox
        Me.TerminalServicesHomeDirectory = New System.Windows.Forms.TextBox
        Me.TerminalServicesHomeDrive = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TerminalServicesProfilePath = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btn_dsa = New System.Windows.Forms.Button
        Me.telephonenumber = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtOffice = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.mail = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.FQDN = New System.Windows.Forms.TextBox
        Me.samaccountname = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.adGroupsListBox = New System.Windows.Forms.ListBox
        Me.userupdate_button = New System.Windows.Forms.Button
        Me.PasswordGroupBox = New System.Windows.Forms.GroupBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.forcepasswordchange = New System.Windows.Forms.CheckBox
        Me.resetpassword = New System.Windows.Forms.Button
        Me.password1 = New System.Windows.Forms.TextBox
        Me.password2 = New System.Windows.Forms.TextBox
        Me.tools = New System.Windows.Forms.TabPage
        Me.joinGroupbox = New System.Windows.Forms.GroupBox
        Me.domainlogon = New System.Windows.Forms.CheckBox
        Me.netdomreboot = New System.Windows.Forms.CheckBox
        Me.joinbutton = New System.Windows.Forms.Button
        Me.Label21 = New System.Windows.Forms.Label
        Me.joindompass = New System.Windows.Forms.TextBox
        Me.joindomuser = New System.Windows.Forms.TextBox
        Me.joindomainuserlabel = New System.Windows.Forms.Label
        Me.domaintojoin = New System.Windows.Forms.TextBox
        Me.nbtstat = New System.Windows.Forms.Button
        Me.tracert = New System.Windows.Forms.Button
        Me.Ping = New System.Windows.Forms.Button
        Me.RenameGroupBox = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.RenameIt = New System.Windows.Forms.Button
        Me.domaccountlabel = New System.Windows.Forms.Label
        Me.netdompass = New System.Windows.Forms.TextBox
        Me.netdomname = New System.Windows.Forms.TextBox
        Me.newname = New System.Windows.Forms.TextBox
        Me.oldname = New System.Windows.Forms.TextBox
        Me.domainroleLabel = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.RenameArea = New System.Windows.Forms.Button
        Me.pingcontinuous = New System.Windows.Forms.CheckBox
        Me.software = New System.Windows.Forms.TabPage
        Me.sgrid = New System.Windows.Forms.DataGridView
        Me.swname = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.swver = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.swpub = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.swdate = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.swloc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.swunins = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sw_url = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sw_use_wmi_checkbox = New System.Windows.Forms.CheckBox
        Me.software_button = New System.Windows.Forms.Button
        Me.ShowUpdates = New System.Windows.Forms.CheckBox
        Me.processes = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.get_processes_by_wmi_checkbox = New System.Windows.Forms.CheckBox
        Me.processgrid = New System.Windows.Forms.DataGridView
        Me.pr_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pr_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.executablepath = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProcessRefresh = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ScheduleButton = New System.Windows.Forms.Button
        Me.ScheduleTime = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.RunNewProcess = New System.Windows.Forms.Button
        Me.interactive = New System.Windows.Forms.CheckBox
        Me.newprocess = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.services = New System.Windows.Forms.TabPage
        Me.svc_datagrid = New System.Windows.Forms.DataGridView
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AcceptPause = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AcceptStop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PathName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label30 = New System.Windows.Forms.Label
        Me.refreshsvc = New System.Windows.Forms.Button
        Me.network = New System.Windows.Forms.TabPage
        Me.AdaptorID = New System.Windows.Forms.TextBox
        Me.networkupdate = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.sfx_delete = New System.Windows.Forms.Button
        Me.sfx_add_button = New System.Windows.Forms.Button
        Me.sfxlist = New System.Windows.Forms.ListBox
        Me.dnssearchbutton = New System.Windows.Forms.Button
        Me.primdnssetbutton = New System.Windows.Forms.Button
        Me.staticdnsbutton = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.sfx1 = New System.Windows.Forms.TextBox
        Me.dnsservers = New System.Windows.Forms.TextBox
        Me.suffix = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lblDhcp = New System.Windows.Forms.Label
        Me.dhcpbutton = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.staticbutton = New System.Windows.Forms.Button
        Me.gateway = New System.Windows.Forms.TextBox
        Me.subnet = New System.Windows.Forms.TextBox
        Me.ipaddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.domain = New System.Windows.Forms.TextBox
        Me.domainlabel = New System.Windows.Forms.Label
        Me.macaddress = New System.Windows.Forms.TextBox
        Me.hostname = New System.Windows.Forms.TextBox
        Me.os = New System.Windows.Forms.TabPage
        Me.admanagement = New System.Windows.Forms.Button
        Me.cpu_info_lbl = New System.Windows.Forms.LinkLabel
        Me.ie = New System.Windows.Forms.TextBox
        Me.proxyset = New System.Windows.Forms.Button
        Me.Label_IP = New System.Windows.Forms.TextBox
        Me.adbutton = New System.Windows.Forms.Button
        Me.ielabel = New System.Windows.Forms.Label
        Me.HWButton = New System.Windows.Forms.Button
        Me.Hardware = New System.Windows.Forms.GroupBox
        Me.audio_label = New System.Windows.Forms.LinkLabel
        Me.video_label = New System.Windows.Forms.LinkLabel
        Me.hdCombo = New System.Windows.Forms.ComboBox
        Me.cpuBox = New System.Windows.Forms.TextBox
        Me.RAMBox = New System.Windows.Forms.TextBox
        Me.makemodel = New System.Windows.Forms.TextBox
        Me.SNoBox = New System.Windows.Forms.TextBox
        Me.chassis = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.delete_Share = New System.Windows.Forms.Button
        Me.addshare = New System.Windows.Forms.Button
        Me.ListBox_Shares = New System.Windows.Forms.ListBox
        Me.Button_openshare = New System.Windows.Forms.Button
        Me.Label_User = New System.Windows.Forms.TextBox
        Me.Label_Boot = New System.Windows.Forms.TextBox
        Me.Label_Ver = New System.Windows.Forms.TextBox
        Me.Label_SP = New System.Windows.Forms.TextBox
        Me.Label_OS = New System.Windows.Forms.TextBox
        Me.Label_Name = New System.Windows.Forms.TextBox
        Me.LabelIP = New System.Windows.Forms.Label
        Me.LabelName = New System.Windows.Forms.Label
        Me.LabelUser = New System.Windows.Forms.Label
        Me.LabelSP = New System.Windows.Forms.Label
        Me.LabelV = New System.Windows.Forms.Label
        Me.LabelBoot = New System.Windows.Forms.Label
        Me.LabelOS = New System.Windows.Forms.Label
        Me.Tabholder1 = New System.Windows.Forms.TabControl
        Me.printers = New System.Windows.Forms.TabPage
        Me.addptr4all = New System.Windows.Forms.CheckBox
        Me.AddPrinterButton = New System.Windows.Forms.Button
        Me.addthisprinter = New System.Windows.Forms.TextBox
        Me.printerGrid = New System.Windows.Forms.DataGridView
        Me.pName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.mappeddrivesGroupBox = New System.Windows.Forms.GroupBox
        Me.deletemappeddrive = New System.Windows.Forms.Button
        Me.addmappeddrive_button = New System.Windows.Forms.Button
        Me.addmappeddrive_letter = New System.Windows.Forms.TextBox
        Me.addmappeddrive_path = New System.Windows.Forms.TextBox
        Me.mappings = New System.Windows.Forms.ListBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.MappedDrivesButton = New System.Windows.Forms.Button
        Me.printerRefresh = New System.Windows.Forms.Button
        Me.gpo = New System.Windows.Forms.TabPage
        Me.lbl_localgpo = New System.Windows.Forms.LinkLabel
        Me.gpoDebugCombo = New System.Windows.Forms.ComboBox
        Me.lbl_debug = New System.Windows.Forms.LinkLabel
        Me.lbl_rsop = New System.Windows.Forms.LinkLabel
        Me.Label55 = New System.Windows.Forms.Label
        Me.gpoDebugMode = New System.Windows.Forms.Label
        Me.gpupdateChoice = New System.Windows.Forms.ComboBox
        Me.btn_gpo_policies = New System.Windows.Forms.Button
        Me.gprefresh = New System.Windows.Forms.Button
        Me.GPODataGrid = New System.Windows.Forms.DataGridView
        Me.col0 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Col3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_startupscripts = New System.Windows.Forms.Button
        Me.deploy = New System.Windows.Forms.TabPage
        Me.file_folder = New System.Windows.Forms.TextBox
        Me.folder_radio = New System.Windows.Forms.RadioButton
        Me.file_radio = New System.Windows.Forms.RadioButton
        Me.installcmd = New System.Windows.Forms.TextBox
        Me.close_on_finish = New System.Windows.Forms.CheckBox
        Me.run_visible = New System.Windows.Forms.CheckBox
        Me.deploy_clear_link = New System.Windows.Forms.LinkLabel
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.edit = New System.Windows.Forms.LinkLabel
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Add_File_Folder = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.installcmd_checkbox = New System.Windows.Forms.CheckBox
        Me.load_appdeploy = New System.Windows.Forms.Button
        Me.save_appdeploy = New System.Windows.Forms.Button
        Me.GetFolder2 = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me._to = New System.Windows.Forms.TextBox
        Me.AppGo_Button = New System.Windows.Forms.Button
        Me.startup = New System.Windows.Forms.TabPage
        Me.startupApplyButton = New System.Windows.Forms.Button
        Me.startupModifyButton = New System.Windows.Forms.Button
        Me.startupDeleteButton = New System.Windows.Forms.Button
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.stup_command = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.stup_user = New System.Windows.Forms.TextBox
        Me.stup_location = New System.Windows.Forms.TextBox
        Me.startupbutton = New System.Windows.Forms.Button
        Me.startupDataGrid = New System.Windows.Forms.DataGridView
        Me.startupName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.startupCommand = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.startupLocation = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.startupUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.test = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.btn_GetSiteOrg = New System.Windows.Forms.Button
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.setSiteOrg = New System.Windows.Forms.Button
        Me.sitename = New System.Windows.Forms.TextBox
        Me.org = New System.Windows.Forms.ComboBox
        Me.groupToAdd = New System.Windows.Forms.TextBox
        Me.btn_AddGroup = New System.Windows.Forms.Button
        Me.cmdtorun = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.testbox = New System.Windows.Forms.TextBox
        Me.stdInbtn = New System.Windows.Forms.Button
        Me.btn_Monitor = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.interactively = New System.Windows.Forms.CheckBox
        Me.returnval = New System.Windows.Forms.Label
        Me.command = New System.Windows.Forms.TextBox
        Me.copy = New System.Windows.Forms.CheckBox
        Me.exec = New System.Windows.Forms.Button
        Me.printermenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ptrproperties = New System.Windows.Forms.ToolStripMenuItem
        Me.ptsvrproperties = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.SetPrinterAsDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator
        Me.addptr = New System.Windows.Forms.ToolStripMenuItem
        Me.DeletePrinterMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteNetworkPrinterMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ForThisUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForAllUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator
        Me.ptrrefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator
        Me.computername = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gpoContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.script_openContainer = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuProcGoogle = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.procMenuHeader = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator
        Me.PropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuProcKill = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCopyPath = New System.Windows.Forms.ToolStripMenuItem
        Me.swContextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuSwName = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuSwProps = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSwUninst = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContainer1.SuspendLayout()
        Me.svccontextmenu.SuspendLayout()
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.options.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.about.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.message.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.aduser.SuspendLayout()
        Me.adpanel.SuspendLayout()
        Me.profileGroupBox.SuspendLayout()
        Me.tsGroupBox.SuspendLayout()
        Me.PasswordGroupBox.SuspendLayout()
        Me.tools.SuspendLayout()
        Me.joinGroupbox.SuspendLayout()
        Me.RenameGroupBox.SuspendLayout()
        Me.software.SuspendLayout()
        CType(Me.sgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.processes.SuspendLayout()
        CType(Me.processgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.services.SuspendLayout()
        CType(Me.svc_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.network.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.os.SuspendLayout()
        Me.Hardware.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Tabholder1.SuspendLayout()
        Me.printers.SuspendLayout()
        CType(Me.printerGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mappeddrivesGroupBox.SuspendLayout()
        Me.gpo.SuspendLayout()
        CType(Me.GPODataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.deploy.SuspendLayout()
        Me.startup.SuspendLayout()
        CType(Me.startupDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.test.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.printermenu.SuspendLayout()
        Me.gpoContextMenu.SuspendLayout()
        Me.ProcContextMenu.SuspendLayout()
        Me.swContextmenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(25, 27)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(247, 427)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(25, 27)
        Me.ToolStripContainer1.TabIndex = 53
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ButtonClear.ForeColor = System.Drawing.SystemColors.Window
        Me.ButtonClear.Location = New System.Drawing.Point(307, 347)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(38, 28)
        Me.ButtonClear.TabIndex = 43
        Me.ButtonClear.Text = "clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ButtonExit.ForeColor = System.Drawing.Color.White
        Me.ButtonExit.Location = New System.Drawing.Point(347, 347)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(35, 28)
        Me.ButtonExit.TabIndex = 38
        Me.ButtonExit.Text = "exit"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'svccontextmenu
        '
        Me.svccontextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.svcname, Me.ToolStripSeparator5, Me.svcstop, Me.svcstart, Me.svcrestart, Me.ToolStripSeparator6, Me.startmode, Me.ToolStripSeparator7, Me.mnuSvcProperties, Me.ToolStripSeparator25, Me.GoogleLookupToolStripMenuItem, Me.DeleteServiceToolStripMenuItem, Me.ToolStripSeparator8, Me.RefreshMenu})
        Me.svccontextmenu.Name = "svccontextmenu"
        Me.svccontextmenu.Size = New System.Drawing.Size(152, 232)
        '
        'svcname
        '
        Me.svcname.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.svcname.ForeColor = System.Drawing.Color.SteelBlue
        Me.svcname.Name = "svcname"
        Me.svcname.Size = New System.Drawing.Size(151, 22)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(148, 6)
        '
        'svcstop
        '
        Me.svcstop.Name = "svcstop"
        Me.svcstop.Size = New System.Drawing.Size(151, 22)
        Me.svcstop.Text = "stop..."
        '
        'svcstart
        '
        Me.svcstart.Name = "svcstart"
        Me.svcstart.Size = New System.Drawing.Size(151, 22)
        Me.svcstart.Text = "start..."
        '
        'svcrestart
        '
        Me.svcrestart.Name = "svcrestart"
        Me.svcrestart.Size = New System.Drawing.Size(151, 22)
        Me.svcrestart.Text = "restart..."
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(148, 6)
        '
        'startmode
        '
        Me.startmode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutomaticMenu, Me.ManualMenu, Me.DisabledMenu})
        Me.startmode.Name = "startmode"
        Me.startmode.Size = New System.Drawing.Size(151, 22)
        Me.startmode.Text = "start mode..."
        '
        'AutomaticMenu
        '
        Me.AutomaticMenu.Name = "AutomaticMenu"
        Me.AutomaticMenu.Size = New System.Drawing.Size(128, 22)
        Me.AutomaticMenu.Text = "automatic"
        '
        'ManualMenu
        '
        Me.ManualMenu.Name = "ManualMenu"
        Me.ManualMenu.Size = New System.Drawing.Size(128, 22)
        Me.ManualMenu.Text = "manual"
        '
        'DisabledMenu
        '
        Me.DisabledMenu.Name = "DisabledMenu"
        Me.DisabledMenu.Size = New System.Drawing.Size(128, 22)
        Me.DisabledMenu.Text = "disabled"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(148, 6)
        '
        'mnuSvcProperties
        '
        Me.mnuSvcProperties.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.mnuSvcProperties.Name = "mnuSvcProperties"
        Me.mnuSvcProperties.Size = New System.Drawing.Size(151, 22)
        Me.mnuSvcProperties.Text = "Properties"
        Me.mnuSvcProperties.ToolTipText = "Show extended properties"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(148, 6)
        '
        'GoogleLookupToolStripMenuItem
        '
        Me.GoogleLookupToolStripMenuItem.Name = "GoogleLookupToolStripMenuItem"
        Me.GoogleLookupToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.GoogleLookupToolStripMenuItem.Text = "google lookup"
        '
        'DeleteServiceToolStripMenuItem
        '
        Me.DeleteServiceToolStripMenuItem.Name = "DeleteServiceToolStripMenuItem"
        Me.DeleteServiceToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DeleteServiceToolStripMenuItem.Text = "delete service"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(148, 6)
        '
        'RefreshMenu
        '
        Me.RefreshMenu.Name = "RefreshMenu"
        Me.RefreshMenu.Size = New System.Drawing.Size(151, 22)
        Me.RefreshMenu.Text = "refresh"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(5, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Computer Name"
        '
        'GO_Button
        '
        Me.GO_Button.Location = New System.Drawing.Point(142, 37)
        Me.GO_Button.Name = "GO_Button"
        Me.GO_Button.Size = New System.Drawing.Size(32, 24)
        Me.GO_Button.TabIndex = 2
        Me.GO_Button.TabStop = False
        Me.GO_Button.Text = "Go"
        '
        'AltUserCheckBox
        '
        Me.AltUserCheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomRight
        Me.AltUserCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.AltUserCheckBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.AltUserCheckBox.Location = New System.Drawing.Point(268, 24)
        Me.AltUserCheckBox.Name = "AltUserCheckBox"
        Me.AltUserCheckBox.Size = New System.Drawing.Size(98, 15)
        Me.AltUserCheckBox.TabIndex = 4
        Me.AltUserCheckBox.Text = "use alt credentials"
        Me.ToolTip1.SetToolTip(Me.AltUserCheckBox, "enter alternate admistrative credentials")
        '
        'altusername_TextBox
        '
        Me.altusername_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.altusername_TextBox.Enabled = False
        Me.altusername_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.altusername_TextBox.Location = New System.Drawing.Point(264, 41)
        Me.altusername_TextBox.Name = "altusername_TextBox"
        Me.altusername_TextBox.Size = New System.Drawing.Size(102, 18)
        Me.altusername_TextBox.TabIndex = 5
        Me.altusername_TextBox.Text = "username"
        '
        'notification_label
        '
        Me.notification_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.notification_label.ForeColor = System.Drawing.Color.Red
        Me.notification_label.Location = New System.Drawing.Point(21, 65)
        Me.notification_label.Name = "notification_label"
        Me.notification_label.Size = New System.Drawing.Size(237, 16)
        Me.notification_label.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Panel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.Raised
        Me.Panel1.Icon = CType(resources.GetObject("Panel1.Icon"), System.Drawing.Icon)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Text = "Status"
        Me.Panel1.ToolTipText = "Computer Management Console.   Peter Forman  2006"
        Me.Panel1.Width = 64
        '
        'Panel2
        '
        Me.Panel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.Panel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Text = "ready"
        Me.Panel2.ToolTipText = "current process/state"
        Me.Panel2.Width = 236
        '
        'Panel3
        '
        Me.Panel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.Panel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Text = "© peter forman"
        Me.Panel3.Width = 82
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.StatusBar1.Location = New System.Drawing.Point(0, 378)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.Panel1, Me.Panel2, Me.Panel3})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(382, 19)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 40
        '
        'PingButton
        '
        Me.PingButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.PingButton.Location = New System.Drawing.Point(178, 41)
        Me.PingButton.Name = "PingButton"
        Me.PingButton.Size = New System.Drawing.Size(29, 18)
        Me.PingButton.TabIndex = 3
        Me.PingButton.TabStop = False
        Me.PingButton.Text = "ping"
        Me.PingButton.UseVisualStyleBackColor = True
        '
        'altPassword_TextBox
        '
        Me.altPassword_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.altPassword_TextBox.Enabled = False
        Me.altPassword_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.altPassword_TextBox.Location = New System.Drawing.Point(264, 60)
        Me.altPassword_TextBox.Name = "altPassword_TextBox"
        Me.altPassword_TextBox.Size = New System.Drawing.Size(102, 19)
        Me.altPassword_TextBox.TabIndex = 6
        Me.altPassword_TextBox.Text = "password"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowItemReorder = True
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.CanOverflow = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Enabled = False
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mmcToolStripButton, Me.evntToolStripButton, Me.usrsToolStripButton, Me.ToolStripSeparator1, Me.regToolStripButton, Me.cmdToolStripButton, Me.ToolStripSeparator2, Me.zenToolStripButton, Me.rdpToolStripButton, Me.vncToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 344)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(382, 34)
        Me.ToolStrip1.TabIndex = 0
        '
        'mmcToolStripButton
        '
        Me.mmcToolStripButton.AutoSize = False
        Me.mmcToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.mmcToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mmcToolStripButton.Image = CType(resources.GetObject("mmcToolStripButton.Image"), System.Drawing.Image)
        Me.mmcToolStripButton.ImageTransparentColor = System.Drawing.Color.Maroon
        Me.mmcToolStripButton.Name = "mmcToolStripButton"
        Me.mmcToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.mmcToolStripButton.Text = "MMC"
        Me.mmcToolStripButton.ToolTipText = "remote management console"
        '
        'evntToolStripButton
        '
        Me.evntToolStripButton.AutoSize = False
        Me.evntToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.evntToolStripButton.Image = CType(resources.GetObject("evntToolStripButton.Image"), System.Drawing.Image)
        Me.evntToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.evntToolStripButton.Name = "evntToolStripButton"
        Me.evntToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.evntToolStripButton.Text = "evntToolStripButton"
        Me.evntToolStripButton.ToolTipText = "remote event viewer"
        '
        'usrsToolStripButton
        '
        Me.usrsToolStripButton.AutoSize = False
        Me.usrsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.usrsToolStripButton.Image = CType(resources.GetObject("usrsToolStripButton.Image"), System.Drawing.Image)
        Me.usrsToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.usrsToolStripButton.Name = "usrsToolStripButton"
        Me.usrsToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.usrsToolStripButton.Text = "usrsToolStripButton"
        Me.usrsToolStripButton.ToolTipText = "remote users and groups console"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'regToolStripButton
        '
        Me.regToolStripButton.AutoSize = False
        Me.regToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.regToolStripButton.Image = CType(resources.GetObject("regToolStripButton.Image"), System.Drawing.Image)
        Me.regToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.regToolStripButton.Name = "regToolStripButton"
        Me.regToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.regToolStripButton.Text = "remote registry editor"
        '
        'cmdToolStripButton
        '
        Me.cmdToolStripButton.AutoSize = False
        Me.cmdToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdToolStripButton.Image = CType(resources.GetObject("cmdToolStripButton.Image"), System.Drawing.Image)
        Me.cmdToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdToolStripButton.Name = "cmdToolStripButton"
        Me.cmdToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.cmdToolStripButton.Text = "remote cmd window"
        Me.cmdToolStripButton.ToolTipText = "remote cmd"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'zenToolStripButton
        '
        Me.zenToolStripButton.AutoSize = False
        Me.zenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.zenToolStripButton.Enabled = False
        Me.zenToolStripButton.Image = CType(resources.GetObject("zenToolStripButton.Image"), System.Drawing.Image)
        Me.zenToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.zenToolStripButton.Name = "zenToolStripButton"
        Me.zenToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.zenToolStripButton.Text = "remote control using zenworks"
        '
        'rdpToolStripButton
        '
        Me.rdpToolStripButton.AutoSize = False
        Me.rdpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.rdpToolStripButton.Image = CType(resources.GetObject("rdpToolStripButton.Image"), System.Drawing.Image)
        Me.rdpToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.rdpToolStripButton.Name = "rdpToolStripButton"
        Me.rdpToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.rdpToolStripButton.Text = "remote desktop"
        '
        'vncToolStripButton
        '
        Me.vncToolStripButton.AutoSize = False
        Me.vncToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.vncToolStripButton.Image = CType(resources.GetObject("vncToolStripButton.Image"), System.Drawing.Image)
        Me.vncToolStripButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.vncToolStripButton.Name = "vncToolStripButton"
        Me.vncToolStripButton.Size = New System.Drawing.Size(34, 34)
        Me.vncToolStripButton.Text = "vnc remote control"
        '
        'vncinstall
        '
        Me.vncinstall.AutoSize = True
        Me.vncinstall.BackColor = System.Drawing.Color.Transparent
        Me.vncinstall.Enabled = False
        Me.vncinstall.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.vncinstall.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.vncinstall.Location = New System.Drawing.Point(285, 347)
        Me.vncinstall.Margin = New System.Windows.Forms.Padding(1)
        Me.vncinstall.Name = "vncinstall"
        Me.vncinstall.Size = New System.Drawing.Size(15, 14)
        Me.vncinstall.TabIndex = 51
        Me.vncinstall.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.vncinstall.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Label19.ForeColor = System.Drawing.Color.DimGray
        Me.Label19.Location = New System.Drawing.Point(283, 361)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(25, 9)
        Me.Label19.TabIndex = 54
        Me.Label19.Text = "Install"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.GoToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(382, 24)
        Me.MenuStrip1.TabIndex = 57
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ToolStripSeparator3, Me.SaveToolStripMenuItem, Me.AppendToolStripMenuItem, Me.toolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.application_add
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.application_form
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(168, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SaveToolStripMenuItem.Text = "Save to file..."
        '
        'AppendToolStripMenuItem
        '
        Me.AppendToolStripMenuItem.Enabled = False
        Me.AppendToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.page_save
        Me.AppendToolStripMenuItem.Name = "AppendToolStripMenuItem"
        Me.AppendToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AppendToolStripMenuItem.Text = "Append to file..."
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(168, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.door_out
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MicrosoftMMCToolStripMenuItem, Me.RemoteControlToolStripMenuItem, Me.TelnetMenu, Me.MSinfoToolStripMenuItem, Me.ToolStripSeparator18, Me.PrintersMenuItem, Me.MappedDrivesMenu, Me.StartUpProgramsMenuItem, Me.GPUpdateToolStripMenuItem, Me.ToolStripSeparator13, Me.ShutDownMenu, Me.NetSendMenu, Me.ToolStripSeparator14, Me.WindRegMenuItem, Me.RemRegMenuItem, Me.ToolStripSeparator21, Me.ADUserInfoToolStripMenuItem, Me.PerfMonMenu})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'MicrosoftMMCToolStripMenuItem
        '
        Me.MicrosoftMMCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputerManagementToolStripMenuItem, Me.EventViewerToolStripMenuItem, Me.LocalUsersAndGroupsToolStripMenuItem, Me.ServicesToolStripMenuItem, Me.SharedFoldersToolStripMenuItem})
        Me.MicrosoftMMCToolStripMenuItem.Enabled = False
        Me.MicrosoftMMCToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.wrench_orange
        Me.MicrosoftMMCToolStripMenuItem.Name = "MicrosoftMMCToolStripMenuItem"
        Me.MicrosoftMMCToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MicrosoftMMCToolStripMenuItem.Text = "Microsoft MMC"
        '
        'ComputerManagementToolStripMenuItem
        '
        Me.ComputerManagementToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.wrench
        Me.ComputerManagementToolStripMenuItem.Name = "ComputerManagementToolStripMenuItem"
        Me.ComputerManagementToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ComputerManagementToolStripMenuItem.Text = "Computer Management"
        '
        'EventViewerToolStripMenuItem
        '
        Me.EventViewerToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.page_error
        Me.EventViewerToolStripMenuItem.Name = "EventViewerToolStripMenuItem"
        Me.EventViewerToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.EventViewerToolStripMenuItem.Text = "Event Viewer"
        '
        'LocalUsersAndGroupsToolStripMenuItem
        '
        Me.LocalUsersAndGroupsToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.group
        Me.LocalUsersAndGroupsToolStripMenuItem.Name = "LocalUsersAndGroupsToolStripMenuItem"
        Me.LocalUsersAndGroupsToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LocalUsersAndGroupsToolStripMenuItem.Text = "Local Users and Groups"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.table
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'SharedFoldersToolStripMenuItem
        '
        Me.SharedFoldersToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.folder_user
        Me.SharedFoldersToolStripMenuItem.Name = "SharedFoldersToolStripMenuItem"
        Me.SharedFoldersToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SharedFoldersToolStripMenuItem.Text = "Shared Folders"
        '
        'RemoteControlToolStripMenuItem
        '
        Me.RemoteControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoteDesktopToolStripMenuItem, Me.VNCToolStripMenuItem, Me.ZenworksToolStripMenuItem, Me.RemoteAssistanceToolStripMenuItem})
        Me.RemoteControlToolStripMenuItem.Enabled = False
        Me.RemoteControlToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.monitor_lightning
        Me.RemoteControlToolStripMenuItem.Name = "RemoteControlToolStripMenuItem"
        Me.RemoteControlToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoteControlToolStripMenuItem.Text = "Remote Control"
        '
        'RemoteDesktopToolStripMenuItem
        '
        Me.RemoteDesktopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoteDesktopConnectionToolStripMenuItem, Me.RDPConsoleToolStripMenuItem, Me.EnableRDPToolStripMenuItem, Me.DisableRDPToolStripMenuItem})
        Me.RemoteDesktopToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.monitor
        Me.RemoteDesktopToolStripMenuItem.Name = "RemoteDesktopToolStripMenuItem"
        Me.RemoteDesktopToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RemoteDesktopToolStripMenuItem.Text = "Remote Desktop"
        '
        'RemoteDesktopConnectionToolStripMenuItem
        '
        Me.RemoteDesktopConnectionToolStripMenuItem.Name = "RemoteDesktopConnectionToolStripMenuItem"
        Me.RemoteDesktopConnectionToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RemoteDesktopConnectionToolStripMenuItem.Text = "RDP Connection"
        '
        'RDPConsoleToolStripMenuItem
        '
        Me.RDPConsoleToolStripMenuItem.Name = "RDPConsoleToolStripMenuItem"
        Me.RDPConsoleToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RDPConsoleToolStripMenuItem.Text = "RDP (Console)"
        '
        'EnableRDPToolStripMenuItem
        '
        Me.EnableRDPToolStripMenuItem.Enabled = False
        Me.EnableRDPToolStripMenuItem.Name = "EnableRDPToolStripMenuItem"
        Me.EnableRDPToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.EnableRDPToolStripMenuItem.Text = "Enable RDP"
        '
        'DisableRDPToolStripMenuItem
        '
        Me.DisableRDPToolStripMenuItem.Enabled = False
        Me.DisableRDPToolStripMenuItem.Name = "DisableRDPToolStripMenuItem"
        Me.DisableRDPToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.DisableRDPToolStripMenuItem.Text = "Disable RDP"
        '
        'VNCToolStripMenuItem
        '
        Me.VNCToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectOnlyToolStripMenuItem, Me.InstallAndConnectToolStripMenuItem, Me.InstallAndConnectNoUserPromptToolStripMenuItem})
        Me.VNCToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.monitor_go
        Me.VNCToolStripMenuItem.Name = "VNCToolStripMenuItem"
        Me.VNCToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VNCToolStripMenuItem.Text = "VNC"
        '
        'ConnectOnlyToolStripMenuItem
        '
        Me.ConnectOnlyToolStripMenuItem.Name = "ConnectOnlyToolStripMenuItem"
        Me.ConnectOnlyToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.ConnectOnlyToolStripMenuItem.Text = "Connect Only"
        '
        'InstallAndConnectToolStripMenuItem
        '
        Me.InstallAndConnectToolStripMenuItem.Name = "InstallAndConnectToolStripMenuItem"
        Me.InstallAndConnectToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.InstallAndConnectToolStripMenuItem.Text = "Install and Connect"
        '
        'InstallAndConnectNoUserPromptToolStripMenuItem
        '
        Me.InstallAndConnectNoUserPromptToolStripMenuItem.Name = "InstallAndConnectNoUserPromptToolStripMenuItem"
        Me.InstallAndConnectNoUserPromptToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.InstallAndConnectNoUserPromptToolStripMenuItem.Text = "Install and Connect - No User Prompt"
        '
        'ZenworksToolStripMenuItem
        '
        Me.ZenworksToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.picture_key
        Me.ZenworksToolStripMenuItem.Name = "ZenworksToolStripMenuItem"
        Me.ZenworksToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ZenworksToolStripMenuItem.Text = "Zenworks"
        '
        'RemoteAssistanceToolStripMenuItem
        '
        Me.RemoteAssistanceToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.keyboard
        Me.RemoteAssistanceToolStripMenuItem.Name = "RemoteAssistanceToolStripMenuItem"
        Me.RemoteAssistanceToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RemoteAssistanceToolStripMenuItem.Text = "Remote Assistance"
        '
        'TelnetMenu
        '
        Me.TelnetMenu.Enabled = False
        Me.TelnetMenu.Image = Global.CMC.My.Resources.Resources.application_osx_terminal
        Me.TelnetMenu.Name = "TelnetMenu"
        Me.TelnetMenu.Size = New System.Drawing.Size(180, 22)
        Me.TelnetMenu.Text = "Telnet"
        '
        'MSinfoToolStripMenuItem
        '
        Me.MSinfoToolStripMenuItem.Enabled = False
        Me.MSinfoToolStripMenuItem.Image = Global.CMC.My.Resources.Resources._0029
        Me.MSinfoToolStripMenuItem.Name = "MSinfoToolStripMenuItem"
        Me.MSinfoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MSinfoToolStripMenuItem.Text = "MSinfo"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(177, 6)
        '
        'PrintersMenuItem
        '
        Me.PrintersMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPrintersToolStripMenuItem, Me.PrintServerPropertiesToolStripMenuItem})
        Me.PrintersMenuItem.Enabled = False
        Me.PrintersMenuItem.Image = Global.CMC.My.Resources.Resources.printer
        Me.PrintersMenuItem.Name = "PrintersMenuItem"
        Me.PrintersMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintersMenuItem.Text = "Printers"
        '
        'ViewPrintersToolStripMenuItem
        '
        Me.ViewPrintersToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.printer
        Me.ViewPrintersToolStripMenuItem.Name = "ViewPrintersToolStripMenuItem"
        Me.ViewPrintersToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ViewPrintersToolStripMenuItem.Text = "View Printers"
        '
        'PrintServerPropertiesToolStripMenuItem
        '
        Me.PrintServerPropertiesToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.server
        Me.PrintServerPropertiesToolStripMenuItem.Name = "PrintServerPropertiesToolStripMenuItem"
        Me.PrintServerPropertiesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.PrintServerPropertiesToolStripMenuItem.Text = "Print Server Properties"
        '
        'MappedDrivesMenu
        '
        Me.MappedDrivesMenu.Enabled = False
        Me.MappedDrivesMenu.Image = Global.CMC.My.Resources.Resources.drive_network
        Me.MappedDrivesMenu.Name = "MappedDrivesMenu"
        Me.MappedDrivesMenu.Size = New System.Drawing.Size(180, 22)
        Me.MappedDrivesMenu.Text = "Mapped Drives"
        '
        'StartUpProgramsMenuItem
        '
        Me.StartUpProgramsMenuItem.Enabled = False
        Me.StartUpProgramsMenuItem.Image = Global.CMC.My.Resources.Resources.application_cascade
        Me.StartUpProgramsMenuItem.Name = "StartUpProgramsMenuItem"
        Me.StartUpProgramsMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StartUpProgramsMenuItem.Text = "StartUp Programs"
        '
        'GPUpdateToolStripMenuItem
        '
        Me.GPUpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BothComputerAndUserToolStripMenuItem, Me.OnlyComputerToolStripMenuItem, Me.OnlyUserToolStripMenuItem})
        Me.GPUpdateToolStripMenuItem.Enabled = False
        Me.GPUpdateToolStripMenuItem.Name = "GPUpdateToolStripMenuItem"
        Me.GPUpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GPUpdateToolStripMenuItem.Text = "GPUpdate"
        '
        'BothComputerAndUserToolStripMenuItem
        '
        Me.BothComputerAndUserToolStripMenuItem.Enabled = False
        Me.BothComputerAndUserToolStripMenuItem.Name = "BothComputerAndUserToolStripMenuItem"
        Me.BothComputerAndUserToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BothComputerAndUserToolStripMenuItem.Text = "Both: Computer and User"
        '
        'OnlyComputerToolStripMenuItem
        '
        Me.OnlyComputerToolStripMenuItem.Name = "OnlyComputerToolStripMenuItem"
        Me.OnlyComputerToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.OnlyComputerToolStripMenuItem.Text = "Only: Computer"
        '
        'OnlyUserToolStripMenuItem
        '
        Me.OnlyUserToolStripMenuItem.Enabled = False
        Me.OnlyUserToolStripMenuItem.Name = "OnlyUserToolStripMenuItem"
        Me.OnlyUserToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.OnlyUserToolStripMenuItem.Text = "Only: User"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(177, 6)
        '
        'ShutDownMenu
        '
        Me.ShutDownMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOffToolStripMenuItem, Me.TurnOffToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ForceLogoffToolStripMenuItem, Me.ForceRebootToolStripMenuItem, Me.PowerDownToolStripMenuItem, Me.ForcePowerDownToolStripMenuItem})
        Me.ShutDownMenu.Enabled = False
        Me.ShutDownMenu.Image = Global.CMC.My.Resources.Resources.exclamation
        Me.ShutDownMenu.Name = "ShutDownMenu"
        Me.ShutDownMenu.Size = New System.Drawing.Size(180, 22)
        Me.ShutDownMenu.Text = "Shut Down"
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LogOffToolStripMenuItem.Text = "Log Off"
        '
        'TurnOffToolStripMenuItem
        '
        Me.TurnOffToolStripMenuItem.Name = "TurnOffToolStripMenuItem"
        Me.TurnOffToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TurnOffToolStripMenuItem.Text = "Shutdown"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RestartToolStripMenuItem.Text = "Reboot"
        '
        'ForceLogoffToolStripMenuItem
        '
        Me.ForceLogoffToolStripMenuItem.Name = "ForceLogoffToolStripMenuItem"
        Me.ForceLogoffToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ForceLogoffToolStripMenuItem.Text = "Force Logoff"
        '
        'ForceRebootToolStripMenuItem
        '
        Me.ForceRebootToolStripMenuItem.Name = "ForceRebootToolStripMenuItem"
        Me.ForceRebootToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ForceRebootToolStripMenuItem.Text = "Force Reboot"
        '
        'PowerDownToolStripMenuItem
        '
        Me.PowerDownToolStripMenuItem.Name = "PowerDownToolStripMenuItem"
        Me.PowerDownToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PowerDownToolStripMenuItem.Text = "Power Down"
        '
        'ForcePowerDownToolStripMenuItem
        '
        Me.ForcePowerDownToolStripMenuItem.Name = "ForcePowerDownToolStripMenuItem"
        Me.ForcePowerDownToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ForcePowerDownToolStripMenuItem.Text = "Force Power Down"
        '
        'NetSendMenu
        '
        Me.NetSendMenu.Enabled = False
        Me.NetSendMenu.Image = Global.CMC.My.Resources.Resources.comment
        Me.NetSendMenu.Name = "NetSendMenu"
        Me.NetSendMenu.Size = New System.Drawing.Size(180, 22)
        Me.NetSendMenu.Text = "Send Message"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(177, 6)
        '
        'WindRegMenuItem
        '
        Me.WindRegMenuItem.Enabled = False
        Me.WindRegMenuItem.Image = Global.CMC.My.Resources.Resources.regedit
        Me.WindRegMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.WindRegMenuItem.Name = "WindRegMenuItem"
        Me.WindRegMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WindRegMenuItem.Text = "windows registry editor"
        '
        'RemRegMenuItem
        '
        Me.RemRegMenuItem.Enabled = False
        Me.RemRegMenuItem.Image = Global.CMC.My.Resources.Resources.regedit
        Me.RemRegMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.RemRegMenuItem.Name = "RemRegMenuItem"
        Me.RemRegMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemRegMenuItem.Text = "remote registry editor"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(177, 6)
        '
        'ADUserInfoToolStripMenuItem
        '
        Me.ADUserInfoToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.user_16x16
        Me.ADUserInfoToolStripMenuItem.Name = "ADUserInfoToolStripMenuItem"
        Me.ADUserInfoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ADUserInfoToolStripMenuItem.Text = "ad user manager"
        '
        'PerfMonMenu
        '
        Me.PerfMonMenu.Image = Global.CMC.My.Resources.Resources.stats_info
        Me.PerfMonMenu.Name = "PerfMonMenu"
        Me.PerfMonMenu.Size = New System.Drawing.Size(180, 22)
        Me.PerfMonMenu.Text = "performance monitor"
        '
        'GoToolStripMenuItem
        '
        Me.GoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatingSystemToolStripMenuItem, Me.NetworkToolStripMenuItem, Me.ServicesToolStripMenuItem1, Me.ProcessesToolStripMenuItem, Me.PrintersToolStripMenuItem, Me.MappedDrivesToolStripMenuItem, Me.SoftwareToolStripMenuItem, Me.DeployToolStripMenuItem, Me.ADUserToolStripMenuItem, Me.GroupPolicyToolStripMenuItem, Me.MessageToolStripMenuItem, Me.StartupToolStripMenuItem, Me.ToolsToolStripMenuItem1, Me.TestToolStripMenuItem})
        Me.GoToolStripMenuItem.Name = "GoToolStripMenuItem"
        Me.GoToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.GoToolStripMenuItem.Text = "Navigate"
        '
        'OperatingSystemToolStripMenuItem
        '
        Me.OperatingSystemToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.computer
        Me.OperatingSystemToolStripMenuItem.Name = "OperatingSystemToolStripMenuItem"
        Me.OperatingSystemToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OperatingSystemToolStripMenuItem.Text = "Operating System"
        '
        'NetworkToolStripMenuItem
        '
        Me.NetworkToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.computer_link
        Me.NetworkToolStripMenuItem.Name = "NetworkToolStripMenuItem"
        Me.NetworkToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.NetworkToolStripMenuItem.Text = "Network"
        '
        'ServicesToolStripMenuItem1
        '
        Me.ServicesToolStripMenuItem1.Image = Global.CMC.My.Resources.Resources.table
        Me.ServicesToolStripMenuItem1.Name = "ServicesToolStripMenuItem1"
        Me.ServicesToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ServicesToolStripMenuItem1.Text = "Services"
        '
        'ProcessesToolStripMenuItem
        '
        Me.ProcessesToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.table_gear
        Me.ProcessesToolStripMenuItem.Name = "ProcessesToolStripMenuItem"
        Me.ProcessesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProcessesToolStripMenuItem.Text = "Processes"
        '
        'PrintersToolStripMenuItem
        '
        Me.PrintersToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.printer
        Me.PrintersToolStripMenuItem.Name = "PrintersToolStripMenuItem"
        Me.PrintersToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PrintersToolStripMenuItem.Text = "Printers"
        '
        'MappedDrivesToolStripMenuItem
        '
        Me.MappedDrivesToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.drive_network
        Me.MappedDrivesToolStripMenuItem.Name = "MappedDrivesToolStripMenuItem"
        Me.MappedDrivesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MappedDrivesToolStripMenuItem.Text = "Mapped Drives"
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.package_green
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SoftwareToolStripMenuItem.Text = "Software"
        '
        'DeployToolStripMenuItem
        '
        Me.DeployToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.application_get
        Me.DeployToolStripMenuItem.Name = "DeployToolStripMenuItem"
        Me.DeployToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.DeployToolStripMenuItem.Text = "Deploy"
        '
        'ADUserToolStripMenuItem
        '
        Me.ADUserToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.group_key
        Me.ADUserToolStripMenuItem.Name = "ADUserToolStripMenuItem"
        Me.ADUserToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ADUserToolStripMenuItem.Text = "AD User"
        '
        'GroupPolicyToolStripMenuItem
        '
        Me.GroupPolicyToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.page
        Me.GroupPolicyToolStripMenuItem.Name = "GroupPolicyToolStripMenuItem"
        Me.GroupPolicyToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GroupPolicyToolStripMenuItem.Text = "Group Policy"
        '
        'MessageToolStripMenuItem
        '
        Me.MessageToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.comment
        Me.MessageToolStripMenuItem.Name = "MessageToolStripMenuItem"
        Me.MessageToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MessageToolStripMenuItem.Text = "Message"
        '
        'StartupToolStripMenuItem
        '
        Me.StartupToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.application_cascade
        Me.StartupToolStripMenuItem.Name = "StartupToolStripMenuItem"
        Me.StartupToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.StartupToolStripMenuItem.Text = "Startup"
        '
        'ToolsToolStripMenuItem1
        '
        Me.ToolsToolStripMenuItem1.Image = Global.CMC.My.Resources.Resources.wrench_orange
        Me.ToolsToolStripMenuItem1.Name = "ToolsToolStripMenuItem1"
        Me.ToolsToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.ToolsToolStripMenuItem1.Text = "Tools"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.TestToolStripMenuItem.Text = "Test"
        Me.TestToolStripMenuItem.Visible = False
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Prefs_Menu, Me.ToolStripSeparator9, Me.AlwaysOnTopToolStripMenuItem, Me.MultiThreadMenuItem, Me.ToolbarEnabled, Me.ToolStripSeparator10, Me.ViewLogToolStripMenuItem, Me.ClearLogToolStripMenuItem, Me.ToolStripSeparator15, Me.ClearHistoryToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'Prefs_Menu
        '
        Me.Prefs_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Prefs_Menu.Image = Global.CMC.My.Resources.Resources.wrench
        Me.Prefs_Menu.Name = "Prefs_Menu"
        Me.Prefs_Menu.Size = New System.Drawing.Size(193, 22)
        Me.Prefs_Menu.Text = "Preferences"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(190, 6)
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.CheckOnClick = True
        Me.AlwaysOnTopToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.AlwaysOnTopToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.application_get
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.AlwaysOnTopToolStripMenuItem.Text = "Always on top"
        Me.AlwaysOnTopToolStripMenuItem.ToolTipText = "remain visible when window focus lost"
        '
        'MultiThreadMenuItem
        '
        Me.MultiThreadMenuItem.Image = Global.CMC.My.Resources.Resources.arrow_join
        Me.MultiThreadMenuItem.Name = "MultiThreadMenuItem"
        Me.MultiThreadMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.MultiThreadMenuItem.Text = "No Multithread"
        '
        'ToolbarEnabled
        '
        Me.ToolbarEnabled.CheckOnClick = True
        Me.ToolbarEnabled.Image = Global.CMC.My.Resources.Resources.application_view_tile
        Me.ToolbarEnabled.Name = "ToolbarEnabled"
        Me.ToolbarEnabled.Size = New System.Drawing.Size(193, 22)
        Me.ToolbarEnabled.Text = "Toolbar always enabled"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(190, 6)
        '
        'ViewLogToolStripMenuItem
        '
        Me.ViewLogToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.page
        Me.ViewLogToolStripMenuItem.Name = "ViewLogToolStripMenuItem"
        Me.ViewLogToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ViewLogToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ViewLogToolStripMenuItem.Text = "View Log"
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.page_delete
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ClearLogToolStripMenuItem.Text = "Clear Log"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(190, 6)
        '
        'ClearHistoryToolStripMenuItem
        '
        Me.ClearHistoryToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.page_lightning
        Me.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        Me.ClearHistoryToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ClearHistoryToolStripMenuItem.Text = "Clear History"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.CMC.My.Resources.Resources.information
        Me.AboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "tsv"
        Me.SaveFileDialog1.Filter = "tab separated files (*.tsv)|*.tsv|All files (*.*)|*.*"""
        Me.SaveFileDialog1.InitialDirectory = "C:\"
        Me.SaveFileDialog1.Title = "CMC  -  save to file"
        '
        'options
        '
        Me.options.Controls.Add(Me.DomainCombo)
        Me.options.Controls.Add(Me.GroupBox13)
        Me.options.Controls.Add(Me.GroupBox12)
        Me.options.Controls.Add(Me.PrefCancel)
        Me.options.Controls.Add(Me.Save_Button)
        Me.options.Controls.Add(Me.GroupBox7)
        Me.options.Location = New System.Drawing.Point(4, 22)
        Me.options.Name = "options"
        Me.options.Padding = New System.Windows.Forms.Padding(3)
        Me.options.Size = New System.Drawing.Size(370, 238)
        Me.options.TabIndex = 11
        Me.options.Text = "Options"
        Me.options.UseVisualStyleBackColor = True
        '
        'DomainCombo
        '
        Me.DomainCombo.FormattingEnabled = True
        Me.DomainCombo.Items.AddRange(New Object() {" (edit custom domains)"})
        Me.DomainCombo.Location = New System.Drawing.Point(224, 97)
        Me.DomainCombo.Name = "DomainCombo"
        Me.DomainCombo.Size = New System.Drawing.Size(134, 21)
        Me.DomainCombo.TabIndex = 34
        Me.DomainCombo.Text = "(edit custom domains)"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.psexecbrowse)
        Me.GroupBox13.Controls.Add(Me.downloadpsexec)
        Me.GroupBox13.Controls.Add(Me.psexecpath)
        Me.GroupBox13.Location = New System.Drawing.Point(7, 193)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(212, 39)
        Me.GroupBox13.TabIndex = 31
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "psexec location"
        '
        'psexecbrowse
        '
        Me.psexecbrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psexecbrowse.Location = New System.Drawing.Point(4, 14)
        Me.psexecbrowse.Name = "psexecbrowse"
        Me.psexecbrowse.Size = New System.Drawing.Size(20, 18)
        Me.psexecbrowse.TabIndex = 11
        Me.psexecbrowse.Text = "..."
        Me.psexecbrowse.UseVisualStyleBackColor = True
        '
        'downloadpsexec
        '
        Me.downloadpsexec.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadpsexec.Location = New System.Drawing.Point(151, 13)
        Me.downloadpsexec.Name = "downloadpsexec"
        Me.downloadpsexec.Size = New System.Drawing.Size(53, 20)
        Me.downloadpsexec.TabIndex = 12
        Me.downloadpsexec.Text = "download"
        Me.downloadpsexec.UseVisualStyleBackColor = True
        '
        'psexecpath
        '
        Me.psexecpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.psexecpath.Location = New System.Drawing.Point(27, 15)
        Me.psexecpath.Name = "psexecpath"
        Me.psexecpath.Size = New System.Drawing.Size(118, 17)
        Me.psexecpath.TabIndex = 10
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.SettingAltPass)
        Me.GroupBox12.Controls.Add(Me.SettingAltUser)
        Me.GroupBox12.Controls.Add(Me.Label52)
        Me.GroupBox12.Location = New System.Drawing.Point(216, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(148, 76)
        Me.GroupBox12.TabIndex = 26
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "alt user"
        '
        'SettingAltPass
        '
        Me.SettingAltPass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SettingAltPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.SettingAltPass.Location = New System.Drawing.Point(35, 49)
        Me.SettingAltPass.Name = "SettingAltPass"
        Me.SettingAltPass.Size = New System.Drawing.Size(95, 19)
        Me.SettingAltPass.TabIndex = 9
        Me.SettingAltPass.UseSystemPasswordChar = True
        '
        'SettingAltUser
        '
        Me.SettingAltUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SettingAltUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.SettingAltUser.Location = New System.Drawing.Point(35, 29)
        Me.SettingAltUser.Name = "SettingAltUser"
        Me.SettingAltUser.Size = New System.Drawing.Size(95, 18)
        Me.SettingAltUser.TabIndex = 8
        Me.SettingAltUser.Text = "administrator"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label52.Location = New System.Drawing.Point(4, 15)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(127, 12)
        Me.Label52.TabIndex = 9
        Me.Label52.Text = "set default alt user credentials"
        '
        'PrefCancel
        '
        Me.PrefCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PrefCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrefCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.PrefCancel.Location = New System.Drawing.Point(298, 209)
        Me.PrefCancel.Name = "PrefCancel"
        Me.PrefCancel.Size = New System.Drawing.Size(67, 23)
        Me.PrefCancel.TabIndex = 31
        Me.PrefCancel.Text = "Cancel"
        '
        'Save_Button
        '
        Me.Save_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Save_Button.Location = New System.Drawing.Point(225, 209)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(67, 23)
        Me.Save_Button.TabIndex = 30
        Me.Save_Button.Text = "Save"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.defHW)
        Me.GroupBox7.Controls.Add(Me.defNW)
        Me.GroupBox7.Controls.Add(Me.defPR)
        Me.GroupBox7.Controls.Add(Me.defSV)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(192, 76)
        Me.GroupBox7.TabIndex = 20
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "default tab selections"
        '
        'defHW
        '
        Me.defHW.AutoSize = True
        Me.defHW.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defHW.ForeColor = System.Drawing.Color.RoyalBlue
        Me.defHW.Location = New System.Drawing.Point(28, 24)
        Me.defHW.Name = "defHW"
        Me.defHW.Size = New System.Drawing.Size(70, 17)
        Me.defHW.TabIndex = 1
        Me.defHW.Text = "hardware"
        Me.defHW.UseVisualStyleBackColor = True
        '
        'defNW
        '
        Me.defNW.AutoSize = True
        Me.defNW.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defNW.ForeColor = System.Drawing.Color.RoyalBlue
        Me.defNW.Location = New System.Drawing.Point(28, 42)
        Me.defNW.Name = "defNW"
        Me.defNW.Size = New System.Drawing.Size(63, 17)
        Me.defNW.TabIndex = 3
        Me.defNW.Text = "network"
        Me.defNW.UseVisualStyleBackColor = True
        '
        'defPR
        '
        Me.defPR.AutoSize = True
        Me.defPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defPR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.defPR.Location = New System.Drawing.Point(115, 42)
        Me.defPR.Name = "defPR"
        Me.defPR.Size = New System.Drawing.Size(73, 17)
        Me.defPR.TabIndex = 4
        Me.defPR.Text = "processes"
        Me.defPR.UseVisualStyleBackColor = True
        '
        'defSV
        '
        Me.defSV.AutoSize = True
        Me.defSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defSV.ForeColor = System.Drawing.Color.RoyalBlue
        Me.defSV.Location = New System.Drawing.Point(115, 24)
        Me.defSV.Name = "defSV"
        Me.defSV.Size = New System.Drawing.Size(64, 17)
        Me.defSV.TabIndex = 2
        Me.defSV.Text = "services"
        Me.defSV.UseVisualStyleBackColor = True
        '
        'about
        '
        Me.about.Controls.Add(Me.GroupBox4)
        Me.about.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.Location = New System.Drawing.Point(4, 22)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(370, 238)
        Me.about.TabIndex = 6
        Me.about.Text = "About"
        Me.about.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.aboutOK)
        Me.GroupBox4.Controls.Add(Me.LinkLabel2)
        Me.GroupBox4.Controls.Add(Me.version)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.LinkLabel1)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(14, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 219)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CMC"
        '
        'aboutOK
        '
        Me.aboutOK.Location = New System.Drawing.Point(297, 188)
        Me.aboutOK.Name = "aboutOK"
        Me.aboutOK.Size = New System.Drawing.Size(37, 25)
        Me.aboutOK.TabIndex = 8
        Me.aboutOK.Text = "OK"
        Me.aboutOK.UseVisualStyleBackColor = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LinkLabel2.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(131, 170)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(108, 13)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "www.peterforman.net"
        Me.LinkLabel2.Visible = False
        '
        'version
        '
        Me.version.AutoSize = True
        Me.version.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.version.Location = New System.Drawing.Point(29, 35)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(36, 12)
        Me.version.TabIndex = 6
        Me.version.Text = "version"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label5.Location = New System.Drawing.Point(89, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "web site:"
        Me.Label5.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(143, 183)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(59, 25)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "send email"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label16.Location = New System.Drawing.Point(27, 77)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(296, 20)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "For personal use only. Use at your own risk."
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label15.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label15.Location = New System.Drawing.Point(27, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(292, 34)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Requires client computer running Windows XP Professional and  Microsoft  .NET  fr" & _
            "amework version 2.0  or  higher."
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label14.Location = New System.Drawing.Point(248, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 14)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Peter Forman"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label13.Location = New System.Drawing.Point(16, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Computer Management Console"
        '
        'message
        '
        Me.message.Controls.Add(Me.GroupBox8)
        Me.message.Controls.Add(Me.msg_radio)
        Me.message.Controls.Add(Me.msgboxradio)
        Me.message.Controls.Add(Me.netsendradio)
        Me.message.Controls.Add(Me.Label35)
        Me.message.Controls.Add(Me.netsendCancel)
        Me.message.Controls.Add(Me.PictureBox1)
        Me.message.Location = New System.Drawing.Point(4, 22)
        Me.message.Name = "message"
        Me.message.Padding = New System.Windows.Forms.Padding(3)
        Me.message.Size = New System.Drawing.Size(370, 238)
        Me.message.TabIndex = 10
        Me.message.Text = "Message"
        Me.message.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.modallabel)
        Me.GroupBox8.Controls.Add(Me.critical)
        Me.GroupBox8.Controls.Add(Me.question)
        Me.GroupBox8.Controls.Add(Me.exclamation)
        Me.GroupBox8.Controls.Add(Me.information)
        Me.GroupBox8.Controls.Add(Me.nomodal)
        Me.GroupBox8.Controls.Add(Me.previewbutton)
        Me.GroupBox8.Controls.Add(Me.Label37)
        Me.GroupBox8.Controls.Add(Me.msgSend)
        Me.GroupBox8.Controls.Add(Me.msgboxTitle)
        Me.GroupBox8.Controls.Add(Me.NetSendTextBox)
        Me.GroupBox8.Controls.Add(Me.Label31)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(10, 33)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(349, 164)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Message"
        '
        'modallabel
        '
        Me.modallabel.AutoSize = True
        Me.modallabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modallabel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.modallabel.Location = New System.Drawing.Point(261, 12)
        Me.modallabel.Name = "modallabel"
        Me.modallabel.Size = New System.Drawing.Size(82, 12)
        Me.modallabel.TabIndex = 24
        Me.modallabel.Text = "select modal style:"
        '
        'critical
        '
        Me.critical.AutoSize = True
        Me.critical.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.critical.ForeColor = System.Drawing.Color.RoyalBlue
        Me.critical.Location = New System.Drawing.Point(268, 83)
        Me.critical.Name = "critical"
        Me.critical.Size = New System.Drawing.Size(50, 16)
        Me.critical.TabIndex = 21
        Me.critical.Text = "critical"
        Me.critical.UseVisualStyleBackColor = True
        '
        'question
        '
        Me.question.AutoSize = True
        Me.question.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.question.ForeColor = System.Drawing.Color.RoyalBlue
        Me.question.Location = New System.Drawing.Point(268, 69)
        Me.question.Name = "question"
        Me.question.Size = New System.Drawing.Size(58, 16)
        Me.question.TabIndex = 20
        Me.question.Text = "question"
        Me.question.UseVisualStyleBackColor = True
        '
        'exclamation
        '
        Me.exclamation.AutoSize = True
        Me.exclamation.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exclamation.ForeColor = System.Drawing.Color.RoyalBlue
        Me.exclamation.Location = New System.Drawing.Point(268, 55)
        Me.exclamation.Name = "exclamation"
        Me.exclamation.Size = New System.Drawing.Size(73, 16)
        Me.exclamation.TabIndex = 19
        Me.exclamation.Text = "exclamation"
        Me.exclamation.UseVisualStyleBackColor = True
        '
        'information
        '
        Me.information.AutoSize = True
        Me.information.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.information.ForeColor = System.Drawing.Color.RoyalBlue
        Me.information.Location = New System.Drawing.Point(268, 41)
        Me.information.Name = "information"
        Me.information.Size = New System.Drawing.Size(69, 16)
        Me.information.TabIndex = 22
        Me.information.Text = "information"
        Me.information.UseVisualStyleBackColor = True
        '
        'nomodal
        '
        Me.nomodal.AutoSize = True
        Me.nomodal.Checked = True
        Me.nomodal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomodal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.nomodal.Location = New System.Drawing.Point(268, 27)
        Me.nomodal.Name = "nomodal"
        Me.nomodal.Size = New System.Drawing.Size(43, 16)
        Me.nomodal.TabIndex = 23
        Me.nomodal.TabStop = True
        Me.nomodal.Text = "none"
        Me.nomodal.UseVisualStyleBackColor = True
        '
        'previewbutton
        '
        Me.previewbutton.Location = New System.Drawing.Point(285, 99)
        Me.previewbutton.Name = "previewbutton"
        Me.previewbutton.Size = New System.Drawing.Size(59, 23)
        Me.previewbutton.TabIndex = 18
        Me.previewbutton.Text = "preview"
        Me.ToolTip1.SetToolTip(Me.previewbutton, "preview message before sending")
        Me.previewbutton.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label37.Location = New System.Drawing.Point(10, 19)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(62, 13)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "msgbox title"
        '
        'msgSend
        '
        Me.msgSend.Enabled = False
        Me.msgSend.Location = New System.Drawing.Point(285, 126)
        Me.msgSend.Name = "msgSend"
        Me.msgSend.Size = New System.Drawing.Size(59, 34)
        Me.msgSend.TabIndex = 16
        Me.msgSend.Text = "send message"
        Me.msgSend.UseVisualStyleBackColor = True
        '
        'msgboxTitle
        '
        Me.msgboxTitle.Enabled = False
        Me.msgboxTitle.Location = New System.Drawing.Point(10, 35)
        Me.msgboxTitle.MaxLength = 60
        Me.msgboxTitle.Name = "msgboxTitle"
        Me.msgboxTitle.Size = New System.Drawing.Size(245, 20)
        Me.msgboxTitle.TabIndex = 10
        '
        'NetSendTextBox
        '
        Me.NetSendTextBox.Location = New System.Drawing.Point(11, 76)
        Me.NetSendTextBox.MaxLength = 255
        Me.NetSendTextBox.Multiline = True
        Me.NetSendTextBox.Name = "NetSendTextBox"
        Me.NetSendTextBox.Size = New System.Drawing.Size(244, 74)
        Me.NetSendTextBox.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label31.Location = New System.Drawing.Point(7, 61)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(137, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "enter text message to send:"
        '
        'msg_radio
        '
        Me.msg_radio.AutoSize = True
        Me.msg_radio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.msg_radio.Location = New System.Drawing.Point(198, 13)
        Me.msg_radio.Name = "msg_radio"
        Me.msg_radio.Size = New System.Drawing.Size(67, 17)
        Me.msg_radio.TabIndex = 19
        Me.msg_radio.Text = "Msg cmd"
        Me.ToolTip1.SetToolTip(Me.msg_radio, "60s msgbox popup")
        Me.msg_radio.UseVisualStyleBackColor = True
        '
        'msgboxradio
        '
        Me.msgboxradio.AutoSize = True
        Me.msgboxradio.Checked = True
        Me.msgboxradio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.msgboxradio.Location = New System.Drawing.Point(54, 13)
        Me.msgboxradio.Name = "msgboxradio"
        Me.msgboxradio.Size = New System.Drawing.Size(63, 17)
        Me.msgboxradio.TabIndex = 15
        Me.msgboxradio.TabStop = True
        Me.msgboxradio.Text = "MsgBox"
        Me.ToolTip1.SetToolTip(Me.msgboxradio, "use vbscript msgbox with optional modal")
        Me.msgboxradio.UseVisualStyleBackColor = True
        '
        'netsendradio
        '
        Me.netsendradio.AutoSize = True
        Me.netsendradio.ForeColor = System.Drawing.Color.RoyalBlue
        Me.netsendradio.Location = New System.Drawing.Point(123, 13)
        Me.netsendradio.Name = "netsendradio"
        Me.netsendradio.Size = New System.Drawing.Size(69, 17)
        Me.netsendradio.TabIndex = 14
        Me.netsendradio.Text = "Net Send"
        Me.ToolTip1.SetToolTip(Me.netsendradio, "enables messenger service to send message")
        Me.netsendradio.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label35.Location = New System.Drawing.Point(42, 205)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(172, 13)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "send a message to the remote user"
        '
        'netsendCancel
        '
        Me.netsendCancel.Location = New System.Drawing.Point(316, 205)
        Me.netsendCancel.Name = "netsendCancel"
        Me.netsendCancel.Size = New System.Drawing.Size(48, 27)
        Me.netsendCancel.TabIndex = 7
        Me.netsendCancel.Text = "cancel"
        Me.netsendCancel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CMC.My.Resources.Resources.comment
        Me.PictureBox1.Location = New System.Drawing.Point(220, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'aduser
        '
        Me.aduser.Controls.Add(Me.adpanel)
        Me.aduser.Location = New System.Drawing.Point(4, 22)
        Me.aduser.Name = "aduser"
        Me.aduser.Padding = New System.Windows.Forms.Padding(3)
        Me.aduser.Size = New System.Drawing.Size(370, 238)
        Me.aduser.TabIndex = 9
        Me.aduser.Text = "AD User"
        Me.aduser.UseVisualStyleBackColor = True
        '
        'adpanel
        '
        Me.adpanel.Controls.Add(Me.profileGroupBox)
        Me.adpanel.Controls.Add(Me.tsGroupBox)
        Me.adpanel.Controls.Add(Me.btn_dsa)
        Me.adpanel.Controls.Add(Me.telephonenumber)
        Me.adpanel.Controls.Add(Me.txtCompany)
        Me.adpanel.Controls.Add(Me.Label54)
        Me.adpanel.Controls.Add(Me.txtOffice)
        Me.adpanel.Controls.Add(Me.Label53)
        Me.adpanel.Controls.Add(Me.mail)
        Me.adpanel.Controls.Add(Me.Label26)
        Me.adpanel.Controls.Add(Me.FQDN)
        Me.adpanel.Controls.Add(Me.samaccountname)
        Me.adpanel.Controls.Add(Me.Label27)
        Me.adpanel.Controls.Add(Me.Label25)
        Me.adpanel.Controls.Add(Me.adGroupsListBox)
        Me.adpanel.Controls.Add(Me.userupdate_button)
        Me.adpanel.Controls.Add(Me.PasswordGroupBox)
        Me.adpanel.Location = New System.Drawing.Point(2, 2)
        Me.adpanel.Name = "adpanel"
        Me.adpanel.Size = New System.Drawing.Size(367, 235)
        Me.adpanel.TabIndex = 31
        '
        'profileGroupBox
        '
        Me.profileGroupBox.Controls.Add(Me.profilepath)
        Me.profileGroupBox.Controls.Add(Me.homedirectory)
        Me.profileGroupBox.Controls.Add(Me.homedrive)
        Me.profileGroupBox.Controls.Add(Me.Label23)
        Me.profileGroupBox.Controls.Add(Me.Label24)
        Me.profileGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.profileGroupBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.profileGroupBox.Location = New System.Drawing.Point(183, 81)
        Me.profileGroupBox.Name = "profileGroupBox"
        Me.profileGroupBox.Size = New System.Drawing.Size(179, 76)
        Me.profileGroupBox.TabIndex = 21
        Me.profileGroupBox.TabStop = False
        Me.profileGroupBox.Text = "profile"
        '
        'profilepath
        '
        Me.profilepath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.profilepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.profilepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.profilepath.Location = New System.Drawing.Point(4, 54)
        Me.profilepath.Name = "profilepath"
        Me.profilepath.ReadOnly = True
        Me.profilepath.Size = New System.Drawing.Size(170, 18)
        Me.profilepath.TabIndex = 3
        '
        'homedirectory
        '
        Me.homedirectory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.homedirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.homedirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homedirectory.Location = New System.Drawing.Point(29, 25)
        Me.homedirectory.Name = "homedirectory"
        Me.homedirectory.ReadOnly = True
        Me.homedirectory.Size = New System.Drawing.Size(145, 18)
        Me.homedirectory.TabIndex = 2
        '
        'homedrive
        '
        Me.homedrive.BackColor = System.Drawing.Color.WhiteSmoke
        Me.homedrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.homedrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homedrive.Location = New System.Drawing.Point(4, 25)
        Me.homedrive.Name = "homedrive"
        Me.homedrive.ReadOnly = True
        Me.homedrive.Size = New System.Drawing.Size(22, 18)
        Me.homedrive.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(1, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 13)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "profile path"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(1, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "home directory"
        '
        'tsGroupBox
        '
        Me.tsGroupBox.Controls.Add(Me.TerminalServicesHomeDirectory)
        Me.tsGroupBox.Controls.Add(Me.TerminalServicesHomeDrive)
        Me.tsGroupBox.Controls.Add(Me.Label20)
        Me.tsGroupBox.Controls.Add(Me.TerminalServicesProfilePath)
        Me.tsGroupBox.Controls.Add(Me.Label22)
        Me.tsGroupBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.tsGroupBox.Location = New System.Drawing.Point(183, 156)
        Me.tsGroupBox.Name = "tsGroupBox"
        Me.tsGroupBox.Size = New System.Drawing.Size(179, 76)
        Me.tsGroupBox.TabIndex = 39
        Me.tsGroupBox.TabStop = False
        Me.tsGroupBox.Text = "terminal services profile"
        '
        'TerminalServicesHomeDirectory
        '
        Me.TerminalServicesHomeDirectory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TerminalServicesHomeDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TerminalServicesHomeDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminalServicesHomeDirectory.Location = New System.Drawing.Point(29, 24)
        Me.TerminalServicesHomeDirectory.Name = "TerminalServicesHomeDirectory"
        Me.TerminalServicesHomeDirectory.ReadOnly = True
        Me.TerminalServicesHomeDirectory.Size = New System.Drawing.Size(146, 18)
        Me.TerminalServicesHomeDirectory.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TerminalServicesHomeDirectory, "double click to open")
        '
        'TerminalServicesHomeDrive
        '
        Me.TerminalServicesHomeDrive.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TerminalServicesHomeDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TerminalServicesHomeDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminalServicesHomeDrive.Location = New System.Drawing.Point(5, 24)
        Me.TerminalServicesHomeDrive.Name = "TerminalServicesHomeDrive"
        Me.TerminalServicesHomeDrive.ReadOnly = True
        Me.TerminalServicesHomeDrive.Size = New System.Drawing.Size(21, 18)
        Me.TerminalServicesHomeDrive.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(2, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "profile folder"
        '
        'TerminalServicesProfilePath
        '
        Me.TerminalServicesProfilePath.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TerminalServicesProfilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TerminalServicesProfilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminalServicesProfilePath.Location = New System.Drawing.Point(5, 54)
        Me.TerminalServicesProfilePath.Name = "TerminalServicesProfilePath"
        Me.TerminalServicesProfilePath.ReadOnly = True
        Me.TerminalServicesProfilePath.Size = New System.Drawing.Size(170, 18)
        Me.TerminalServicesProfilePath.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TerminalServicesProfilePath, "double click to open")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(2, 12)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "user folder"
        '
        'btn_dsa
        '
        Me.btn_dsa.Enabled = False
        Me.btn_dsa.FlatAppearance.BorderSize = 0
        Me.btn_dsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dsa.Image = Global.CMC.My.Resources.Resources.book_open
        Me.btn_dsa.Location = New System.Drawing.Point(171, 28)
        Me.btn_dsa.Name = "btn_dsa"
        Me.btn_dsa.Size = New System.Drawing.Size(20, 20)
        Me.btn_dsa.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.btn_dsa, "AD Users & Computers")
        Me.btn_dsa.UseVisualStyleBackColor = True
        '
        'telephonenumber
        '
        Me.telephonenumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.telephonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.telephonenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telephonenumber.Location = New System.Drawing.Point(98, 116)
        Me.telephonenumber.Name = "telephonenumber"
        Me.telephonenumber.ReadOnly = True
        Me.telephonenumber.Size = New System.Drawing.Size(75, 18)
        Me.telephonenumber.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.telephonenumber, "Telephone")
        '
        'txtCompany
        '
        Me.txtCompany.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(5, 87)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.ReadOnly = True
        Me.txtCompany.Size = New System.Drawing.Size(168, 18)
        Me.txtCompany.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.txtCompany, "Company")
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(95, 104)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(54, 13)
        Me.Label54.TabIndex = 36
        Me.Label54.Text = "telephone"
        '
        'txtOffice
        '
        Me.txtOffice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Location = New System.Drawing.Point(5, 116)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.ReadOnly = True
        Me.txtOffice.Size = New System.Drawing.Size(90, 18)
        Me.txtOffice.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.txtOffice, "Office")
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(3, 104)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(32, 13)
        Me.Label53.TabIndex = 35
        Me.Label53.Text = "office"
        '
        'mail
        '
        Me.mail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mail.Location = New System.Drawing.Point(5, 60)
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        Me.mail.Size = New System.Drawing.Size(168, 18)
        Me.mail.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.mail, "email address")
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "company"
        '
        'FQDN
        '
        Me.FQDN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FQDN.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FQDN.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FQDN.Location = New System.Drawing.Point(2, 4)
        Me.FQDN.Name = "FQDN"
        Me.FQDN.ReadOnly = True
        Me.FQDN.Size = New System.Drawing.Size(363, 10)
        Me.FQDN.TabIndex = 28
        Me.FQDN.Visible = False
        '
        'samaccountname
        '
        Me.samaccountname.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.samaccountname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.samaccountname.Location = New System.Drawing.Point(5, 27)
        Me.samaccountname.Name = "samaccountname"
        Me.samaccountname.Size = New System.Drawing.Size(127, 18)
        Me.samaccountname.TabIndex = 18
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(4, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(31, 13)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "email"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(5, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(73, 13)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "account name"
        '
        'adGroupsListBox
        '
        Me.adGroupsListBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.adGroupsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adGroupsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adGroupsListBox.FormattingEnabled = True
        Me.adGroupsListBox.ItemHeight = 12
        Me.adGroupsListBox.Location = New System.Drawing.Point(4, 141)
        Me.adGroupsListBox.Name = "adGroupsListBox"
        Me.adGroupsListBox.Size = New System.Drawing.Size(169, 86)
        Me.adGroupsListBox.Sorted = True
        Me.adGroupsListBox.TabIndex = 24
        '
        'userupdate_button
        '
        Me.userupdate_button.Enabled = False
        Me.userupdate_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userupdate_button.Location = New System.Drawing.Point(138, 23)
        Me.userupdate_button.Name = "userupdate_button"
        Me.userupdate_button.Size = New System.Drawing.Size(30, 26)
        Me.userupdate_button.TabIndex = 23
        Me.userupdate_button.Text = "go"
        Me.userupdate_button.UseVisualStyleBackColor = True
        '
        'PasswordGroupBox
        '
        Me.PasswordGroupBox.Controls.Add(Me.Label29)
        Me.PasswordGroupBox.Controls.Add(Me.forcepasswordchange)
        Me.PasswordGroupBox.Controls.Add(Me.resetpassword)
        Me.PasswordGroupBox.Controls.Add(Me.password1)
        Me.PasswordGroupBox.Controls.Add(Me.password2)
        Me.PasswordGroupBox.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PasswordGroupBox.Location = New System.Drawing.Point(199, 13)
        Me.PasswordGroupBox.Name = "PasswordGroupBox"
        Me.PasswordGroupBox.Size = New System.Drawing.Size(163, 64)
        Me.PasswordGroupBox.TabIndex = 29
        Me.PasswordGroupBox.TabStop = False
        Me.PasswordGroupBox.Text = "password"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(106, 47)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 12)
        Me.Label29.TabIndex = 21
        Me.Label29.Text = "next logon"
        '
        'forcepasswordchange
        '
        Me.forcepasswordchange.AutoSize = True
        Me.forcepasswordchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forcepasswordchange.ForeColor = System.Drawing.SystemColors.ControlText
        Me.forcepasswordchange.Location = New System.Drawing.Point(90, 34)
        Me.forcepasswordchange.Name = "forcepasswordchange"
        Me.forcepasswordchange.Size = New System.Drawing.Size(64, 16)
        Me.forcepasswordchange.TabIndex = 20
        Me.forcepasswordchange.Text = "change at"
        Me.ToolTip1.SetToolTip(Me.forcepasswordchange, "force user to change password at next logon")
        Me.forcepasswordchange.UseVisualStyleBackColor = True
        '
        'resetpassword
        '
        Me.resetpassword.Enabled = False
        Me.resetpassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.resetpassword.Location = New System.Drawing.Point(90, 12)
        Me.resetpassword.Name = "resetpassword"
        Me.resetpassword.Size = New System.Drawing.Size(64, 23)
        Me.resetpassword.TabIndex = 19
        Me.resetpassword.Text = "reset"
        Me.ToolTip1.SetToolTip(Me.resetpassword, "reset users password")
        Me.resetpassword.UseVisualStyleBackColor = True
        '
        'password1
        '
        Me.password1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password1.Location = New System.Drawing.Point(6, 16)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(78, 19)
        Me.password1.TabIndex = 17
        Me.password1.UseSystemPasswordChar = True
        '
        'password2
        '
        Me.password2.Enabled = False
        Me.password2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password2.Location = New System.Drawing.Point(6, 36)
        Me.password2.Name = "password2"
        Me.password2.Size = New System.Drawing.Size(78, 19)
        Me.password2.TabIndex = 18
        Me.password2.UseSystemPasswordChar = True
        '
        'tools
        '
        Me.tools.BackColor = System.Drawing.Color.Transparent
        Me.tools.Controls.Add(Me.joinGroupbox)
        Me.tools.Controls.Add(Me.nbtstat)
        Me.tools.Controls.Add(Me.tracert)
        Me.tools.Controls.Add(Me.Ping)
        Me.tools.Controls.Add(Me.RenameGroupBox)
        Me.tools.Controls.Add(Me.RenameArea)
        Me.tools.Controls.Add(Me.pingcontinuous)
        Me.tools.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tools.Location = New System.Drawing.Point(4, 22)
        Me.tools.Name = "tools"
        Me.tools.Size = New System.Drawing.Size(370, 238)
        Me.tools.TabIndex = 5
        Me.tools.Text = "Tools"
        Me.tools.UseVisualStyleBackColor = True
        '
        'joinGroupbox
        '
        Me.joinGroupbox.Controls.Add(Me.domainlogon)
        Me.joinGroupbox.Controls.Add(Me.netdomreboot)
        Me.joinGroupbox.Controls.Add(Me.joinbutton)
        Me.joinGroupbox.Controls.Add(Me.Label21)
        Me.joinGroupbox.Controls.Add(Me.joindompass)
        Me.joinGroupbox.Controls.Add(Me.joindomuser)
        Me.joinGroupbox.Controls.Add(Me.joindomainuserlabel)
        Me.joinGroupbox.Controls.Add(Me.domaintojoin)
        Me.joinGroupbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.joinGroupbox.Location = New System.Drawing.Point(8, 15)
        Me.joinGroupbox.Name = "joinGroupbox"
        Me.joinGroupbox.Size = New System.Drawing.Size(172, 121)
        Me.joinGroupbox.TabIndex = 9
        Me.joinGroupbox.TabStop = False
        Me.joinGroupbox.Text = "join domain"
        '
        'domainlogon
        '
        Me.domainlogon.AutoSize = True
        Me.domainlogon.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.domainlogon.ForeColor = System.Drawing.Color.RoyalBlue
        Me.domainlogon.Location = New System.Drawing.Point(7, 68)
        Me.domainlogon.Name = "domainlogon"
        Me.domainlogon.Size = New System.Drawing.Size(159, 16)
        Me.domainlogon.TabIndex = 7
        Me.domainlogon.Text = "set domain as default login option"
        Me.domainlogon.UseVisualStyleBackColor = True
        '
        'netdomreboot
        '
        Me.netdomreboot.AutoSize = True
        Me.netdomreboot.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.netdomreboot.ForeColor = System.Drawing.Color.RoyalBlue
        Me.netdomreboot.Location = New System.Drawing.Point(7, 90)
        Me.netdomreboot.Name = "netdomreboot"
        Me.netdomreboot.Size = New System.Drawing.Size(97, 16)
        Me.netdomreboot.TabIndex = 6
        Me.netdomreboot.Text = "reboot when done"
        Me.netdomreboot.UseVisualStyleBackColor = True
        '
        'joinbutton
        '
        Me.joinbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.joinbutton.Location = New System.Drawing.Point(124, 88)
        Me.joinbutton.Name = "joinbutton"
        Me.joinbutton.Size = New System.Drawing.Size(42, 29)
        Me.joinbutton.TabIndex = 5
        Me.joinbutton.Text = "join"
        Me.joinbutton.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label21.Location = New System.Drawing.Point(117, 32)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 12)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "password"
        '
        'joindompass
        '
        Me.joindompass.Location = New System.Drawing.Point(120, 44)
        Me.joindompass.Name = "joindompass"
        Me.joindompass.Size = New System.Drawing.Size(45, 18)
        Me.joindompass.TabIndex = 3
        Me.joindompass.UseSystemPasswordChar = True
        '
        'joindomuser
        '
        Me.joindomuser.Location = New System.Drawing.Point(7, 44)
        Me.joindomuser.Name = "joindomuser"
        Me.joindomuser.Size = New System.Drawing.Size(111, 18)
        Me.joindomuser.TabIndex = 2
        '
        'joindomainuserlabel
        '
        Me.joindomainuserlabel.AutoSize = True
        Me.joindomainuserlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.joindomainuserlabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.joindomainuserlabel.Location = New System.Drawing.Point(5, 32)
        Me.joindomainuserlabel.Name = "joindomainuserlabel"
        Me.joindomainuserlabel.Size = New System.Drawing.Size(90, 12)
        Me.joindomainuserlabel.TabIndex = 1
        Me.joindomainuserlabel.Text = "domain user account"
        '
        'domaintojoin
        '
        Me.domaintojoin.Location = New System.Drawing.Point(6, 14)
        Me.domaintojoin.Name = "domaintojoin"
        Me.domaintojoin.Size = New System.Drawing.Size(160, 18)
        Me.domaintojoin.TabIndex = 0
        '
        'nbtstat
        '
        Me.nbtstat.BackColor = System.Drawing.SystemColors.ControlText
        Me.nbtstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.nbtstat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.nbtstat.Location = New System.Drawing.Point(3, 194)
        Me.nbtstat.Name = "nbtstat"
        Me.nbtstat.Size = New System.Drawing.Size(54, 32)
        Me.nbtstat.TabIndex = 8
        Me.nbtstat.Text = "NBTstat"
        Me.nbtstat.UseVisualStyleBackColor = False
        '
        'tracert
        '
        Me.tracert.BackColor = System.Drawing.SystemColors.ControlText
        Me.tracert.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.tracert.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tracert.Location = New System.Drawing.Point(58, 194)
        Me.tracert.Name = "tracert"
        Me.tracert.Size = New System.Drawing.Size(52, 32)
        Me.tracert.TabIndex = 6
        Me.tracert.Text = "Tracert"
        Me.tracert.UseVisualStyleBackColor = False
        '
        'Ping
        '
        Me.Ping.BackColor = System.Drawing.SystemColors.ControlText
        Me.Ping.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Ping.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Ping.Location = New System.Drawing.Point(111, 194)
        Me.Ping.Name = "Ping"
        Me.Ping.Size = New System.Drawing.Size(50, 32)
        Me.Ping.TabIndex = 5
        Me.Ping.Text = "Ping"
        Me.Ping.UseVisualStyleBackColor = False
        '
        'RenameGroupBox
        '
        Me.RenameGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.RenameGroupBox.Controls.Add(Me.Label12)
        Me.RenameGroupBox.Controls.Add(Me.RenameIt)
        Me.RenameGroupBox.Controls.Add(Me.domaccountlabel)
        Me.RenameGroupBox.Controls.Add(Me.netdompass)
        Me.RenameGroupBox.Controls.Add(Me.netdomname)
        Me.RenameGroupBox.Controls.Add(Me.newname)
        Me.RenameGroupBox.Controls.Add(Me.oldname)
        Me.RenameGroupBox.Controls.Add(Me.domainroleLabel)
        Me.RenameGroupBox.Controls.Add(Me.Label10)
        Me.RenameGroupBox.Controls.Add(Me.Label9)
        Me.RenameGroupBox.Enabled = False
        Me.RenameGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.RenameGroupBox.Location = New System.Drawing.Point(188, 26)
        Me.RenameGroupBox.Name = "RenameGroupBox"
        Me.RenameGroupBox.Size = New System.Drawing.Size(174, 200)
        Me.RenameGroupBox.TabIndex = 2
        Me.RenameGroupBox.TabStop = False
        Me.RenameGroupBox.Text = "rename computer"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(3, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 43)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Changing  the  computer  name  without restarting  may have an adverse impact on " & _
            "performance and network access."
        '
        'RenameIt
        '
        Me.RenameIt.Location = New System.Drawing.Point(62, 168)
        Me.RenameIt.Name = "RenameIt"
        Me.RenameIt.Size = New System.Drawing.Size(52, 28)
        Me.RenameIt.TabIndex = 8
        Me.RenameIt.Text = "rename"
        '
        'domaccountlabel
        '
        Me.domaccountlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.domaccountlabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.domaccountlabel.Location = New System.Drawing.Point(1, 92)
        Me.domaccountlabel.Name = "domaccountlabel"
        Me.domaccountlabel.Size = New System.Drawing.Size(69, 12)
        Me.domaccountlabel.TabIndex = 7
        Me.domaccountlabel.Text = "domain user"
        '
        'netdompass
        '
        Me.netdompass.Enabled = False
        Me.netdompass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.netdompass.Location = New System.Drawing.Point(100, 105)
        Me.netdompass.Name = "netdompass"
        Me.netdompass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.netdompass.Size = New System.Drawing.Size(69, 18)
        Me.netdompass.TabIndex = 6
        '
        'netdomname
        '
        Me.netdomname.Enabled = False
        Me.netdomname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.netdomname.Location = New System.Drawing.Point(3, 105)
        Me.netdomname.Name = "netdomname"
        Me.netdomname.Size = New System.Drawing.Size(92, 18)
        Me.netdomname.TabIndex = 5
        '
        'newname
        '
        Me.newname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.newname.Location = New System.Drawing.Point(91, 64)
        Me.newname.Name = "newname"
        Me.newname.Size = New System.Drawing.Size(78, 20)
        Me.newname.TabIndex = 2
        '
        'oldname
        '
        Me.oldname.BackColor = System.Drawing.SystemColors.Window
        Me.oldname.Enabled = False
        Me.oldname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.oldname.Location = New System.Drawing.Point(3, 64)
        Me.oldname.Name = "oldname"
        Me.oldname.ReadOnly = True
        Me.oldname.Size = New System.Drawing.Size(82, 20)
        Me.oldname.TabIndex = 1
        '
        'domainroleLabel
        '
        Me.domainroleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.domainroleLabel.Location = New System.Drawing.Point(2, 16)
        Me.domainroleLabel.Name = "domainroleLabel"
        Me.domainroleLabel.Size = New System.Drawing.Size(170, 32)
        Me.domainroleLabel.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(90, 51)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "new name"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(2, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "old name"
        '
        'RenameArea
        '
        Me.RenameArea.Enabled = False
        Me.RenameArea.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RenameArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.RenameArea.Location = New System.Drawing.Point(243, 4)
        Me.RenameArea.Name = "RenameArea"
        Me.RenameArea.Size = New System.Drawing.Size(68, 22)
        Me.RenameArea.TabIndex = 1
        Me.RenameArea.Text = "rename..."
        '
        'pingcontinuous
        '
        Me.pingcontinuous.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.pingcontinuous.Location = New System.Drawing.Point(161, 202)
        Me.pingcontinuous.Name = "pingcontinuous"
        Me.pingcontinuous.Size = New System.Drawing.Size(32, 16)
        Me.pingcontinuous.TabIndex = 7
        Me.pingcontinuous.Text = "-t"
        Me.pingcontinuous.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.ToolTip1.SetToolTip(Me.pingcontinuous, "select for continuous ping")
        '
        'software
        '
        Me.software.BackColor = System.Drawing.Color.Transparent
        Me.software.Controls.Add(Me.sgrid)
        Me.software.Controls.Add(Me.sw_use_wmi_checkbox)
        Me.software.Controls.Add(Me.software_button)
        Me.software.Controls.Add(Me.ShowUpdates)
        Me.software.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.software.Location = New System.Drawing.Point(4, 22)
        Me.software.Name = "software"
        Me.software.Size = New System.Drawing.Size(370, 238)
        Me.software.TabIndex = 7
        Me.software.Text = "Software"
        Me.software.UseVisualStyleBackColor = True
        '
        'sgrid
        '
        Me.sgrid.AllowUserToAddRows = False
        Me.sgrid.AllowUserToDeleteRows = False
        Me.sgrid.AllowUserToResizeColumns = False
        Me.sgrid.AllowUserToResizeRows = False
        Me.sgrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.sgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.sgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.sgrid.ColumnHeadersVisible = False
        Me.sgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.swname, Me.swver, Me.swpub, Me.swdate, Me.swloc, Me.swunins, Me.sw_url})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MidnightBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sgrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.sgrid.GridColor = System.Drawing.Color.White
        Me.sgrid.Location = New System.Drawing.Point(2, 23)
        Me.sgrid.Name = "sgrid"
        Me.sgrid.ReadOnly = True
        Me.sgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.sgrid.RowHeadersVisible = False
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sgrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.sgrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.sgrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.sgrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.sgrid.RowTemplate.Height = 18
        Me.sgrid.RowTemplate.ReadOnly = True
        Me.sgrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.sgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.sgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.sgrid.Size = New System.Drawing.Size(365, 212)
        Me.sgrid.TabIndex = 59
        '
        'swname
        '
        Me.swname.HeaderText = "swname"
        Me.swname.Name = "swname"
        Me.swname.ReadOnly = True
        Me.swname.ToolTipText = "Double click for info"
        Me.swname.Width = 400
        '
        'swver
        '
        Me.swver.HeaderText = "swver"
        Me.swver.Name = "swver"
        Me.swver.ReadOnly = True
        Me.swver.Visible = False
        '
        'swpub
        '
        Me.swpub.HeaderText = "swpub"
        Me.swpub.Name = "swpub"
        Me.swpub.ReadOnly = True
        Me.swpub.Visible = False
        '
        'swdate
        '
        Me.swdate.HeaderText = "swdate"
        Me.swdate.Name = "swdate"
        Me.swdate.ReadOnly = True
        Me.swdate.Visible = False
        '
        'swloc
        '
        Me.swloc.HeaderText = "swloc"
        Me.swloc.Name = "swloc"
        Me.swloc.ReadOnly = True
        Me.swloc.Visible = False
        '
        'swunins
        '
        Me.swunins.HeaderText = "swunins"
        Me.swunins.Name = "swunins"
        Me.swunins.ReadOnly = True
        Me.swunins.Visible = False
        '
        'sw_url
        '
        Me.sw_url.HeaderText = "sw_url"
        Me.sw_url.Name = "sw_url"
        Me.sw_url.ReadOnly = True
        Me.sw_url.Visible = False
        '
        'sw_use_wmi_checkbox
        '
        Me.sw_use_wmi_checkbox.AutoSize = True
        Me.sw_use_wmi_checkbox.ForeColor = System.Drawing.Color.SteelBlue
        Me.sw_use_wmi_checkbox.Location = New System.Drawing.Point(123, 4)
        Me.sw_use_wmi_checkbox.Name = "sw_use_wmi_checkbox"
        Me.sw_use_wmi_checkbox.Size = New System.Drawing.Size(64, 17)
        Me.sw_use_wmi_checkbox.TabIndex = 58
        Me.sw_use_wmi_checkbox.Text = "use wmi"
        Me.sw_use_wmi_checkbox.UseVisualStyleBackColor = True
        Me.sw_use_wmi_checkbox.Visible = False
        '
        'software_button
        '
        Me.software_button.Enabled = False
        Me.software_button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.software_button.Location = New System.Drawing.Point(317, 1)
        Me.software_button.Name = "software_button"
        Me.software_button.Size = New System.Drawing.Size(48, 20)
        Me.software_button.TabIndex = 50
        Me.software_button.Text = "refresh"
        '
        'ShowUpdates
        '
        Me.ShowUpdates.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!)
        Me.ShowUpdates.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ShowUpdates.Location = New System.Drawing.Point(2, 5)
        Me.ShowUpdates.Name = "ShowUpdates"
        Me.ShowUpdates.Size = New System.Drawing.Size(130, 16)
        Me.ShowUpdates.TabIndex = 51
        Me.ShowUpdates.Text = "Show Updates/Hotfixes"
        '
        'processes
        '
        Me.processes.BackColor = System.Drawing.Color.Transparent
        Me.processes.Controls.Add(Me.Label7)
        Me.processes.Controls.Add(Me.get_processes_by_wmi_checkbox)
        Me.processes.Controls.Add(Me.processgrid)
        Me.processes.Controls.Add(Me.ProcessRefresh)
        Me.processes.Controls.Add(Me.GroupBox1)
        Me.processes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.processes.Location = New System.Drawing.Point(4, 22)
        Me.processes.Name = "processes"
        Me.processes.Size = New System.Drawing.Size(370, 238)
        Me.processes.TabIndex = 1
        Me.processes.Text = "Processes"
        Me.processes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(1, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "right click for menu"
        '
        'get_processes_by_wmi_checkbox
        '
        Me.get_processes_by_wmi_checkbox.AutoSize = True
        Me.get_processes_by_wmi_checkbox.ForeColor = System.Drawing.Color.Gray
        Me.get_processes_by_wmi_checkbox.Location = New System.Drawing.Point(206, 3)
        Me.get_processes_by_wmi_checkbox.Name = "get_processes_by_wmi_checkbox"
        Me.get_processes_by_wmi_checkbox.Size = New System.Drawing.Size(44, 17)
        Me.get_processes_by_wmi_checkbox.TabIndex = 14
        Me.get_processes_by_wmi_checkbox.Text = "wmi"
        Me.get_processes_by_wmi_checkbox.UseVisualStyleBackColor = True
        Me.get_processes_by_wmi_checkbox.Visible = False
        '
        'processgrid
        '
        Me.processgrid.AllowUserToAddRows = False
        Me.processgrid.AllowUserToDeleteRows = False
        Me.processgrid.AllowUserToResizeRows = False
        Me.processgrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.processgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.processgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.processgrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pr_name, Me.pr_id, Me.mem, Me.executablepath})
        Me.processgrid.GridColor = System.Drawing.SystemColors.Window
        Me.processgrid.Location = New System.Drawing.Point(0, 21)
        Me.processgrid.MultiSelect = False
        Me.processgrid.Name = "processgrid"
        Me.processgrid.ReadOnly = True
        Me.processgrid.RowHeadersVisible = False
        Me.processgrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.processgrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.processgrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.processgrid.RowTemplate.Height = 18
        Me.processgrid.RowTemplate.ReadOnly = True
        Me.processgrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.processgrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.processgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.processgrid.ShowCellToolTips = False
        Me.processgrid.ShowEditingIcon = False
        Me.processgrid.Size = New System.Drawing.Size(368, 155)
        Me.processgrid.TabIndex = 13
        Me.processgrid.TabStop = False
        Me.ToolTip1.SetToolTip(Me.processgrid, "Double click for properties")
        '
        'pr_name
        '
        Me.pr_name.Frozen = True
        Me.pr_name.HeaderText = "Name"
        Me.pr_name.Name = "pr_name"
        Me.pr_name.ReadOnly = True
        Me.pr_name.Width = 160
        '
        'pr_id
        '
        Me.pr_id.Frozen = True
        Me.pr_id.HeaderText = "PID"
        Me.pr_id.Name = "pr_id"
        Me.pr_id.ReadOnly = True
        Me.pr_id.Width = 60
        '
        'mem
        '
        Me.mem.Frozen = True
        Me.mem.HeaderText = "Memory Usage (kb)"
        Me.mem.Name = "mem"
        Me.mem.ReadOnly = True
        Me.mem.Width = 144
        '
        'executablepath
        '
        Me.executablepath.HeaderText = "Path"
        Me.executablepath.Name = "executablepath"
        Me.executablepath.ReadOnly = True
        Me.executablepath.Visible = False
        '
        'ProcessRefresh
        '
        Me.ProcessRefresh.Enabled = False
        Me.ProcessRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ProcessRefresh.Location = New System.Drawing.Point(321, 0)
        Me.ProcessRefresh.Name = "ProcessRefresh"
        Me.ProcessRefresh.Size = New System.Drawing.Size(48, 20)
        Me.ProcessRefresh.TabIndex = 9
        Me.ProcessRefresh.Text = "refresh"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ScheduleButton)
        Me.GroupBox1.Controls.Add(Me.ScheduleTime)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.RunNewProcess)
        Me.GroupBox1.Controls.Add(Me.interactive)
        Me.GroupBox1.Controls.Add(Me.newprocess)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(5, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 54)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Create New Process"
        '
        'ScheduleButton
        '
        Me.ScheduleButton.Enabled = False
        Me.ScheduleButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ScheduleButton.Location = New System.Drawing.Point(298, 9)
        Me.ScheduleButton.Name = "ScheduleButton"
        Me.ScheduleButton.Size = New System.Drawing.Size(57, 20)
        Me.ScheduleButton.TabIndex = 91
        Me.ScheduleButton.Text = "schedule"
        Me.ToolTip1.SetToolTip(Me.ScheduleButton, "create a scheduled task to run the command at the specified time")
        Me.ScheduleButton.UseVisualStyleBackColor = True
        '
        'ScheduleTime
        '
        Me.ScheduleTime.Location = New System.Drawing.Point(320, 31)
        Me.ScheduleTime.Name = "ScheduleTime"
        Me.ScheduleTime.Size = New System.Drawing.Size(35, 19)
        Me.ScheduleTime.TabIndex = 90
        Me.ScheduleTime.Text = "00:00"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label40.Location = New System.Drawing.Point(297, 31)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(26, 13)
        Me.Label40.TabIndex = 89
        Me.Label40.Text = "time"
        '
        'RunNewProcess
        '
        Me.RunNewProcess.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RunNewProcess.Location = New System.Drawing.Point(222, 9)
        Me.RunNewProcess.Name = "RunNewProcess"
        Me.RunNewProcess.Size = New System.Drawing.Size(53, 40)
        Me.RunNewProcess.TabIndex = 4
        Me.RunNewProcess.Text = "run now"
        '
        'interactive
        '
        Me.interactive.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.interactive.ForeColor = System.Drawing.SystemColors.ControlText
        Me.interactive.Location = New System.Drawing.Point(6, 35)
        Me.interactive.Name = "interactive"
        Me.interactive.Size = New System.Drawing.Size(85, 16)
        Me.interactive.TabIndex = 2
        Me.interactive.TabStop = False
        Me.interactive.Text = "interactive"
        Me.ToolTip1.SetToolTip(Me.interactive, "run new process visible")
        '
        'newprocess
        '
        Me.newprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.newprocess.Location = New System.Drawing.Point(6, 16)
        Me.newprocess.Name = "newprocess"
        Me.newprocess.Size = New System.Drawing.Size(205, 18)
        Me.newprocess.TabIndex = 1
        Me.newprocess.TabStop = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label41.Location = New System.Drawing.Point(277, 23)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(16, 13)
        Me.Label41.TabIndex = 92
        Me.Label41.Text = "or"
        '
        'services
        '
        Me.services.BackColor = System.Drawing.Color.Transparent
        Me.services.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.services.Controls.Add(Me.svc_datagrid)
        Me.services.Controls.Add(Me.Label30)
        Me.services.Controls.Add(Me.refreshsvc)
        Me.services.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.services.Location = New System.Drawing.Point(4, 22)
        Me.services.Name = "services"
        Me.services.Size = New System.Drawing.Size(370, 238)
        Me.services.TabIndex = 2
        Me.services.Text = "Services"
        Me.services.UseVisualStyleBackColor = True
        '
        'svc_datagrid
        '
        Me.svc_datagrid.AllowUserToAddRows = False
        Me.svc_datagrid.AllowUserToDeleteRows = False
        Me.svc_datagrid.AllowUserToResizeRows = False
        Me.svc_datagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.svc_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.svc_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.svc_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column1, Me.Column2, Me.Column3, Me.Column4, Me.description, Me.AcceptPause, Me.AcceptStop, Me.PathName, Me.Account})
        Me.svc_datagrid.GridColor = System.Drawing.SystemColors.Window
        Me.svc_datagrid.Location = New System.Drawing.Point(0, 21)
        Me.svc_datagrid.MultiSelect = False
        Me.svc_datagrid.Name = "svc_datagrid"
        Me.svc_datagrid.ReadOnly = True
        Me.svc_datagrid.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.svc_datagrid.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.svc_datagrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.svc_datagrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.svc_datagrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.svc_datagrid.RowTemplate.Height = 18
        Me.svc_datagrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.svc_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.svc_datagrid.ShowCellToolTips = False
        Me.svc_datagrid.ShowEditingIcon = False
        Me.svc_datagrid.Size = New System.Drawing.Size(366, 214)
        Me.svc_datagrid.TabIndex = 17
        Me.svc_datagrid.TabStop = False
        Me.ToolTip1.SetToolTip(Me.svc_datagrid, "Double click for properties")
        '
        'column1
        '
        Me.column1.Frozen = True
        Me.column1.HeaderText = "Display Name"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Width = 240
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "State"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Startup"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 60
        '
        'Column4
        '
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.ReadOnly = True
        Me.description.Visible = False
        '
        'AcceptPause
        '
        Me.AcceptPause.HeaderText = "AcceptPause"
        Me.AcceptPause.Name = "AcceptPause"
        Me.AcceptPause.ReadOnly = True
        Me.AcceptPause.Visible = False
        '
        'AcceptStop
        '
        Me.AcceptStop.HeaderText = "AcceptStop"
        Me.AcceptStop.Name = "AcceptStop"
        Me.AcceptStop.ReadOnly = True
        Me.AcceptStop.Visible = False
        '
        'PathName
        '
        Me.PathName.HeaderText = "PathName"
        Me.PathName.Name = "PathName"
        Me.PathName.ReadOnly = True
        Me.PathName.Visible = False
        '
        'Account
        '
        Me.Account.HeaderText = "Account"
        Me.Account.Name = "Account"
        Me.Account.ReadOnly = True
        Me.Account.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label30.Location = New System.Drawing.Point(1, 4)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(127, 13)
        Me.Label30.TabIndex = 18
        Me.Label30.Text = "right click for control menu"
        '
        'refreshsvc
        '
        Me.refreshsvc.Enabled = False
        Me.refreshsvc.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshsvc.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.refreshsvc.Location = New System.Drawing.Point(320, 0)
        Me.refreshsvc.Name = "refreshsvc"
        Me.refreshsvc.Size = New System.Drawing.Size(47, 20)
        Me.refreshsvc.TabIndex = 13
        Me.refreshsvc.Text = "refresh"
        '
        'network
        '
        Me.network.BackColor = System.Drawing.SystemColors.Control
        Me.network.Controls.Add(Me.AdaptorID)
        Me.network.Controls.Add(Me.networkupdate)
        Me.network.Controls.Add(Me.GroupBox6)
        Me.network.Controls.Add(Me.GroupBox5)
        Me.network.Controls.Add(Me.Label2)
        Me.network.Controls.Add(Me.Label1)
        Me.network.Controls.Add(Me.domain)
        Me.network.Controls.Add(Me.domainlabel)
        Me.network.Controls.Add(Me.macaddress)
        Me.network.Controls.Add(Me.hostname)
        Me.network.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.network.Location = New System.Drawing.Point(4, 22)
        Me.network.Name = "network"
        Me.network.Size = New System.Drawing.Size(370, 238)
        Me.network.TabIndex = 8
        Me.network.Text = "Network"
        '
        'AdaptorID
        '
        Me.AdaptorID.BackColor = System.Drawing.SystemColors.Control
        Me.AdaptorID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AdaptorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdaptorID.ForeColor = System.Drawing.Color.DodgerBlue
        Me.AdaptorID.Location = New System.Drawing.Point(6, 3)
        Me.AdaptorID.Multiline = True
        Me.AdaptorID.Name = "AdaptorID"
        Me.AdaptorID.Size = New System.Drawing.Size(306, 25)
        Me.AdaptorID.TabIndex = 33
        '
        'networkupdate
        '
        Me.networkupdate.Enabled = False
        Me.networkupdate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.networkupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.networkupdate.Location = New System.Drawing.Point(318, 3)
        Me.networkupdate.Name = "networkupdate"
        Me.networkupdate.Size = New System.Drawing.Size(48, 20)
        Me.networkupdate.TabIndex = 31
        Me.networkupdate.Text = "refresh"
        Me.networkupdate.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.sfx_delete)
        Me.GroupBox6.Controls.Add(Me.sfx_add_button)
        Me.GroupBox6.Controls.Add(Me.sfxlist)
        Me.GroupBox6.Controls.Add(Me.dnssearchbutton)
        Me.GroupBox6.Controls.Add(Me.primdnssetbutton)
        Me.GroupBox6.Controls.Add(Me.staticdnsbutton)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.sfx1)
        Me.GroupBox6.Controls.Add(Me.dnsservers)
        Me.GroupBox6.Controls.Add(Me.suffix)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GroupBox6.Location = New System.Drawing.Point(173, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(194, 203)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "dns settings"
        '
        'sfx_delete
        '
        Me.sfx_delete.Enabled = False
        Me.sfx_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.sfx_delete.Location = New System.Drawing.Point(158, 152)
        Me.sfx_delete.Name = "sfx_delete"
        Me.sfx_delete.Size = New System.Drawing.Size(29, 20)
        Me.sfx_delete.TabIndex = 30
        Me.sfx_delete.Text = "del"
        Me.sfx_delete.UseVisualStyleBackColor = True
        '
        'sfx_add_button
        '
        Me.sfx_add_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.sfx_add_button.Location = New System.Drawing.Point(158, 173)
        Me.sfx_add_button.Name = "sfx_add_button"
        Me.sfx_add_button.Size = New System.Drawing.Size(29, 20)
        Me.sfx_add_button.TabIndex = 29
        Me.sfx_add_button.Text = "add"
        Me.sfx_add_button.UseVisualStyleBackColor = True
        '
        'sfxlist
        '
        Me.sfxlist.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.sfxlist.FormattingEnabled = True
        Me.sfxlist.ItemHeight = 12
        Me.sfxlist.Location = New System.Drawing.Point(7, 120)
        Me.sfxlist.Name = "sfxlist"
        Me.sfxlist.Size = New System.Drawing.Size(144, 52)
        Me.sfxlist.TabIndex = 28
        '
        'dnssearchbutton
        '
        Me.dnssearchbutton.Enabled = False
        Me.dnssearchbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dnssearchbutton.Location = New System.Drawing.Point(153, 119)
        Me.dnssearchbutton.Name = "dnssearchbutton"
        Me.dnssearchbutton.Size = New System.Drawing.Size(35, 20)
        Me.dnssearchbutton.TabIndex = 27
        Me.dnssearchbutton.TabStop = False
        Me.dnssearchbutton.Text = "save"
        Me.dnssearchbutton.UseVisualStyleBackColor = True
        '
        'primdnssetbutton
        '
        Me.primdnssetbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.primdnssetbutton.Location = New System.Drawing.Point(153, 77)
        Me.primdnssetbutton.Name = "primdnssetbutton"
        Me.primdnssetbutton.Size = New System.Drawing.Size(34, 20)
        Me.primdnssetbutton.TabIndex = 26
        Me.primdnssetbutton.TabStop = False
        Me.primdnssetbutton.Text = "set"
        Me.primdnssetbutton.UseVisualStyleBackColor = True
        '
        'staticdnsbutton
        '
        Me.staticdnsbutton.Enabled = False
        Me.staticdnsbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.staticdnsbutton.Location = New System.Drawing.Point(153, 45)
        Me.staticdnsbutton.Name = "staticdnsbutton"
        Me.staticdnsbutton.Size = New System.Drawing.Size(34, 20)
        Me.staticdnsbutton.TabIndex = 24
        Me.staticdnsbutton.TabStop = False
        Me.staticdnsbutton.Text = "set"
        Me.staticdnsbutton.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label18.Location = New System.Drawing.Point(5, 106)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 12)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "dns suffix search order"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label17.Location = New System.Drawing.Point(5, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 12)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "primary dns suffix"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label8.Location = New System.Drawing.Point(5, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 12)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "dns server addresses (comma separated)"
        '
        'sfx1
        '
        Me.sfx1.BackColor = System.Drawing.SystemColors.Window
        Me.sfx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.sfx1.Location = New System.Drawing.Point(7, 174)
        Me.sfx1.Name = "sfx1"
        Me.sfx1.Size = New System.Drawing.Size(144, 18)
        Me.sfx1.TabIndex = 12
        Me.sfx1.TabStop = False
        '
        'dnsservers
        '
        Me.dnsservers.BackColor = System.Drawing.SystemColors.Window
        Me.dnsservers.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dnsservers.Location = New System.Drawing.Point(7, 26)
        Me.dnsservers.Name = "dnsservers"
        Me.dnsservers.Size = New System.Drawing.Size(180, 18)
        Me.dnsservers.TabIndex = 8
        Me.dnsservers.TabStop = False
        '
        'suffix
        '
        Me.suffix.BackColor = System.Drawing.SystemColors.Window
        Me.suffix.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.suffix.Location = New System.Drawing.Point(7, 78)
        Me.suffix.Name = "suffix"
        Me.suffix.Size = New System.Drawing.Size(144, 18)
        Me.suffix.TabIndex = 6
        Me.suffix.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblDhcp)
        Me.GroupBox5.Controls.Add(Me.dhcpbutton)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.staticbutton)
        Me.GroupBox5.Controls.Add(Me.gateway)
        Me.GroupBox5.Controls.Add(Me.subnet)
        Me.GroupBox5.Controls.Add(Me.ipaddress)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 93)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(159, 138)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "ip config"
        '
        'lblDhcp
        '
        Me.lblDhcp.AutoSize = True
        Me.lblDhcp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.lblDhcp.Location = New System.Drawing.Point(5, 98)
        Me.lblDhcp.Name = "lblDhcp"
        Me.lblDhcp.Size = New System.Drawing.Size(25, 12)
        Me.lblDhcp.TabIndex = 21
        Me.lblDhcp.Text = "dhcp"
        '
        'dhcpbutton
        '
        Me.dhcpbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.dhcpbutton.Location = New System.Drawing.Point(14, 112)
        Me.dhcpbutton.Name = "dhcpbutton"
        Me.dhcpbutton.Size = New System.Drawing.Size(63, 21)
        Me.dhcpbutton.TabIndex = 14
        Me.dhcpbutton.TabStop = False
        Me.dhcpbutton.Text = "enable dhcp"
        Me.ToolTip1.SetToolTip(Me.dhcpbutton, "change to configuration by dhcp")
        Me.dhcpbutton.UseVisualStyleBackColor = True
        Me.dhcpbutton.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label6.Location = New System.Drawing.Point(5, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "gateway"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label4.Location = New System.Drawing.Point(5, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "subnet mask"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label3.Location = New System.Drawing.Point(5, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 12)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "ip address"
        '
        'staticbutton
        '
        Me.staticbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.staticbutton.Location = New System.Drawing.Point(82, 112)
        Me.staticbutton.Name = "staticbutton"
        Me.staticbutton.Size = New System.Drawing.Size(62, 21)
        Me.staticbutton.TabIndex = 15
        Me.staticbutton.TabStop = False
        Me.staticbutton.Text = "make static"
        Me.ToolTip1.SetToolTip(Me.staticbutton, "change to static ip configuration")
        Me.staticbutton.UseVisualStyleBackColor = True
        Me.staticbutton.Visible = False
        '
        'gateway
        '
        Me.gateway.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gateway.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.gateway.Location = New System.Drawing.Point(63, 65)
        Me.gateway.Name = "gateway"
        Me.gateway.Size = New System.Drawing.Size(87, 18)
        Me.gateway.TabIndex = 3
        Me.gateway.TabStop = False
        '
        'subnet
        '
        Me.subnet.BackColor = System.Drawing.Color.WhiteSmoke
        Me.subnet.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.subnet.Location = New System.Drawing.Point(63, 42)
        Me.subnet.Name = "subnet"
        Me.subnet.Size = New System.Drawing.Size(87, 18)
        Me.subnet.TabIndex = 2
        Me.subnet.TabStop = False
        '
        'ipaddress
        '
        Me.ipaddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ipaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.ipaddress.Location = New System.Drawing.Point(63, 19)
        Me.ipaddress.Name = "ipaddress"
        Me.ipaddress.Size = New System.Drawing.Size(87, 18)
        Me.ipaddress.TabIndex = 1
        Me.ipaddress.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "mac"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "hostname"
        '
        'domain
        '
        Me.domain.BackColor = System.Drawing.SystemColors.Window
        Me.domain.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.domain.Location = New System.Drawing.Point(62, 50)
        Me.domain.Name = "domain"
        Me.domain.ReadOnly = True
        Me.domain.Size = New System.Drawing.Size(100, 18)
        Me.domain.TabIndex = 4
        Me.domain.TabStop = False
        '
        'domainlabel
        '
        Me.domainlabel.AutoSize = True
        Me.domainlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.domainlabel.Location = New System.Drawing.Point(6, 53)
        Me.domainlabel.Name = "domainlabel"
        Me.domainlabel.Size = New System.Drawing.Size(56, 13)
        Me.domainlabel.TabIndex = 11
        Me.domainlabel.Text = "workgroup"
        '
        'macaddress
        '
        Me.macaddress.BackColor = System.Drawing.SystemColors.Window
        Me.macaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.macaddress.Location = New System.Drawing.Point(62, 70)
        Me.macaddress.Name = "macaddress"
        Me.macaddress.ReadOnly = True
        Me.macaddress.Size = New System.Drawing.Size(100, 18)
        Me.macaddress.TabIndex = 5
        Me.macaddress.TabStop = False
        '
        'hostname
        '
        Me.hostname.BackColor = System.Drawing.SystemColors.Window
        Me.hostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.hostname.Location = New System.Drawing.Point(62, 30)
        Me.hostname.Name = "hostname"
        Me.hostname.ReadOnly = True
        Me.hostname.Size = New System.Drawing.Size(100, 18)
        Me.hostname.TabIndex = 0
        Me.hostname.TabStop = False
        '
        'os
        '
        Me.os.BackColor = System.Drawing.Color.Transparent
        Me.os.Controls.Add(Me.admanagement)
        Me.os.Controls.Add(Me.cpu_info_lbl)
        Me.os.Controls.Add(Me.ie)
        Me.os.Controls.Add(Me.proxyset)
        Me.os.Controls.Add(Me.Label_IP)
        Me.os.Controls.Add(Me.adbutton)
        Me.os.Controls.Add(Me.ielabel)
        Me.os.Controls.Add(Me.HWButton)
        Me.os.Controls.Add(Me.Hardware)
        Me.os.Controls.Add(Me.GroupBox3)
        Me.os.Controls.Add(Me.Label_User)
        Me.os.Controls.Add(Me.Label_Boot)
        Me.os.Controls.Add(Me.Label_Ver)
        Me.os.Controls.Add(Me.Label_SP)
        Me.os.Controls.Add(Me.Label_OS)
        Me.os.Controls.Add(Me.Label_Name)
        Me.os.Controls.Add(Me.LabelIP)
        Me.os.Controls.Add(Me.LabelName)
        Me.os.Controls.Add(Me.LabelUser)
        Me.os.Controls.Add(Me.LabelSP)
        Me.os.Controls.Add(Me.LabelV)
        Me.os.Controls.Add(Me.LabelBoot)
        Me.os.Controls.Add(Me.LabelOS)
        Me.os.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.os.Location = New System.Drawing.Point(4, 22)
        Me.os.Name = "os"
        Me.os.Size = New System.Drawing.Size(370, 238)
        Me.os.TabIndex = 0
        Me.os.Text = "OS"
        Me.os.UseVisualStyleBackColor = True
        '
        'admanagement
        '
        Me.admanagement.FlatAppearance.BorderSize = 0
        Me.admanagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.admanagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admanagement.Location = New System.Drawing.Point(292, 96)
        Me.admanagement.Name = "admanagement"
        Me.admanagement.Size = New System.Drawing.Size(48, 20)
        Me.admanagement.TabIndex = 70
        Me.admanagement.Text = "ad mgr"
        Me.admanagement.UseVisualStyleBackColor = True
        '
        'cpu_info_lbl
        '
        Me.cpu_info_lbl.ActiveLinkColor = System.Drawing.Color.MediumPurple
        Me.cpu_info_lbl.AutoSize = True
        Me.cpu_info_lbl.BackColor = System.Drawing.SystemColors.Window
        Me.cpu_info_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpu_info_lbl.LinkColor = System.Drawing.Color.DodgerBlue
        Me.cpu_info_lbl.Location = New System.Drawing.Point(342, 190)
        Me.cpu_info_lbl.Name = "cpu_info_lbl"
        Me.cpu_info_lbl.Size = New System.Drawing.Size(17, 9)
        Me.cpu_info_lbl.TabIndex = 69
        Me.cpu_info_lbl.TabStop = True
        Me.cpu_info_lbl.Text = "info"
        Me.ToolTip1.SetToolTip(Me.cpu_info_lbl, "get detailed cpu information")
        Me.cpu_info_lbl.Visible = False
        '
        'ie
        '
        Me.ie.BackColor = System.Drawing.SystemColors.Window
        Me.ie.Location = New System.Drawing.Point(92, 71)
        Me.ie.Name = "ie"
        Me.ie.Size = New System.Drawing.Size(112, 19)
        Me.ie.TabIndex = 62
        Me.ie.TabStop = False
        '
        'proxyset
        '
        Me.proxyset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.proxyset.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proxyset.Location = New System.Drawing.Point(63, 71)
        Me.proxyset.Name = "proxyset"
        Me.proxyset.Size = New System.Drawing.Size(26, 19)
        Me.proxyset.TabIndex = 68
        Me.proxyset.Text = "set"
        Me.proxyset.UseVisualStyleBackColor = True
        Me.proxyset.Visible = False
        '
        'Label_IP
        '
        Me.Label_IP.BackColor = System.Drawing.SystemColors.Window
        Me.Label_IP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_IP.Location = New System.Drawing.Point(268, 4)
        Me.Label_IP.Name = "Label_IP"
        Me.Label_IP.ReadOnly = True
        Me.Label_IP.Size = New System.Drawing.Size(96, 19)
        Me.Label_IP.TabIndex = 66
        Me.Label_IP.TabStop = False
        '
        'adbutton
        '
        Me.adbutton.Enabled = False
        Me.adbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adbutton.Image = Global.CMC.My.Resources.Resources.user_info_16x16
        Me.adbutton.Location = New System.Drawing.Point(269, 95)
        Me.adbutton.Name = "adbutton"
        Me.adbutton.Size = New System.Drawing.Size(22, 22)
        Me.adbutton.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.adbutton, "AD User Profile")
        Me.adbutton.UseVisualStyleBackColor = True
        '
        'ielabel
        '
        Me.ielabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.ielabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ielabel.Location = New System.Drawing.Point(3, 73)
        Me.ielabel.Name = "ielabel"
        Me.ielabel.Size = New System.Drawing.Size(55, 16)
        Me.ielabel.TabIndex = 63
        Me.ielabel.Text = "ie version"
        Me.ToolTip1.SetToolTip(Me.ielabel, "click to toggle version/proxy")
        '
        'HWButton
        '
        Me.HWButton.Enabled = False
        Me.HWButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.HWButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.HWButton.Location = New System.Drawing.Point(304, 122)
        Me.HWButton.Name = "HWButton"
        Me.HWButton.Size = New System.Drawing.Size(48, 20)
        Me.HWButton.TabIndex = 14
        Me.HWButton.Text = "refresh"
        Me.ToolTip1.SetToolTip(Me.HWButton, "load hardware information")
        '
        'Hardware
        '
        Me.Hardware.Controls.Add(Me.audio_label)
        Me.Hardware.Controls.Add(Me.video_label)
        Me.Hardware.Controls.Add(Me.hdCombo)
        Me.Hardware.Controls.Add(Me.cpuBox)
        Me.Hardware.Controls.Add(Me.RAMBox)
        Me.Hardware.Controls.Add(Me.makemodel)
        Me.Hardware.Controls.Add(Me.SNoBox)
        Me.Hardware.Controls.Add(Me.chassis)
        Me.Hardware.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Hardware.Location = New System.Drawing.Point(146, 121)
        Me.Hardware.Name = "Hardware"
        Me.Hardware.Size = New System.Drawing.Size(218, 112)
        Me.Hardware.TabIndex = 61
        Me.Hardware.TabStop = False
        Me.Hardware.Text = "Hardware"
        '
        'audio_label
        '
        Me.audio_label.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.audio_label.AutoSize = True
        Me.audio_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.audio_label.LinkColor = System.Drawing.Color.DimGray
        Me.audio_label.Location = New System.Drawing.Point(108, 7)
        Me.audio_label.Name = "audio_label"
        Me.audio_label.Size = New System.Drawing.Size(23, 9)
        Me.audio_label.TabIndex = 65
        Me.audio_label.TabStop = True
        Me.audio_label.Text = "audio"
        Me.ToolTip1.SetToolTip(Me.audio_label, "sound device information")
        Me.audio_label.Visible = False
        '
        'video_label
        '
        Me.video_label.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.video_label.AutoSize = True
        Me.video_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.video_label.LinkColor = System.Drawing.Color.DimGray
        Me.video_label.Location = New System.Drawing.Point(81, 7)
        Me.video_label.Name = "video_label"
        Me.video_label.Size = New System.Drawing.Size(23, 9)
        Me.video_label.TabIndex = 64
        Me.video_label.TabStop = True
        Me.video_label.Text = "video"
        Me.ToolTip1.SetToolTip(Me.video_label, "video controller information")
        Me.video_label.Visible = False
        '
        'hdCombo
        '
        Me.hdCombo.FormattingEnabled = True
        Me.hdCombo.Location = New System.Drawing.Point(4, 86)
        Me.hdCombo.Name = "hdCombo"
        Me.hdCombo.Size = New System.Drawing.Size(211, 21)
        Me.hdCombo.TabIndex = 62
        Me.hdCombo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.hdCombo, "Hard Drives")
        '
        'cpuBox
        '
        Me.cpuBox.BackColor = System.Drawing.SystemColors.Window
        Me.cpuBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.cpuBox.Location = New System.Drawing.Point(53, 66)
        Me.cpuBox.Name = "cpuBox"
        Me.cpuBox.ReadOnly = True
        Me.cpuBox.Size = New System.Drawing.Size(161, 18)
        Me.cpuBox.TabIndex = 54
        Me.cpuBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.cpuBox, "CPU")
        '
        'RAMBox
        '
        Me.RAMBox.BackColor = System.Drawing.SystemColors.Window
        Me.RAMBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.RAMBox.Location = New System.Drawing.Point(4, 66)
        Me.RAMBox.Name = "RAMBox"
        Me.RAMBox.ReadOnly = True
        Me.RAMBox.Size = New System.Drawing.Size(46, 18)
        Me.RAMBox.TabIndex = 53
        Me.RAMBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RAMBox, "Physical Memory")
        '
        'makemodel
        '
        Me.makemodel.BackColor = System.Drawing.SystemColors.Window
        Me.makemodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.makemodel.Location = New System.Drawing.Point(4, 26)
        Me.makemodel.Name = "makemodel"
        Me.makemodel.ReadOnly = True
        Me.makemodel.Size = New System.Drawing.Size(210, 18)
        Me.makemodel.TabIndex = 52
        Me.makemodel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.makemodel, "Make & Model")
        '
        'SNoBox
        '
        Me.SNoBox.BackColor = System.Drawing.SystemColors.Window
        Me.SNoBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.SNoBox.Location = New System.Drawing.Point(116, 46)
        Me.SNoBox.Name = "SNoBox"
        Me.SNoBox.ReadOnly = True
        Me.SNoBox.Size = New System.Drawing.Size(98, 18)
        Me.SNoBox.TabIndex = 55
        Me.SNoBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SNoBox, "Serial Number")
        '
        'chassis
        '
        Me.chassis.BackColor = System.Drawing.SystemColors.Window
        Me.chassis.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.chassis.Location = New System.Drawing.Point(4, 46)
        Me.chassis.Name = "chassis"
        Me.chassis.ReadOnly = True
        Me.chassis.Size = New System.Drawing.Size(108, 18)
        Me.chassis.TabIndex = 56
        Me.chassis.TabStop = False
        Me.ToolTip1.SetToolTip(Me.chassis, "Form Factor")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.delete_Share)
        Me.GroupBox3.Controls.Add(Me.addshare)
        Me.GroupBox3.Controls.Add(Me.ListBox_Shares)
        Me.GroupBox3.Controls.Add(Me.Button_openshare)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(134, 112)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Shares"
        '
        'delete_Share
        '
        Me.delete_Share.Enabled = False
        Me.delete_Share.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.delete_Share.FlatAppearance.BorderSize = 0
        Me.delete_Share.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.delete_Share.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_Share.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_Share.Image = Global.CMC.My.Resources.Resources.folder_delete
        Me.delete_Share.Location = New System.Drawing.Point(60, 12)
        Me.delete_Share.Name = "delete_Share"
        Me.delete_Share.Size = New System.Drawing.Size(18, 18)
        Me.delete_Share.TabIndex = 3
        Me.delete_Share.TabStop = False
        Me.ToolTip1.SetToolTip(Me.delete_Share, "delete selected share")
        Me.delete_Share.UseVisualStyleBackColor = True
        '
        'addshare
        '
        Me.addshare.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.addshare.FlatAppearance.BorderSize = 0
        Me.addshare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.addshare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addshare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addshare.Image = Global.CMC.My.Resources.Resources.folder_add
        Me.addshare.Location = New System.Drawing.Point(35, 12)
        Me.addshare.Name = "addshare"
        Me.addshare.Size = New System.Drawing.Size(18, 18)
        Me.addshare.TabIndex = 2
        Me.addshare.TabStop = False
        Me.ToolTip1.SetToolTip(Me.addshare, "add a new share")
        Me.addshare.UseVisualStyleBackColor = True
        '
        'ListBox_Shares
        '
        Me.ListBox_Shares.BackColor = System.Drawing.SystemColors.Window
        Me.ListBox_Shares.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.ListBox_Shares.Location = New System.Drawing.Point(4, 38)
        Me.ListBox_Shares.Name = "ListBox_Shares"
        Me.ListBox_Shares.Size = New System.Drawing.Size(124, 69)
        Me.ListBox_Shares.Sorted = True
        Me.ListBox_Shares.TabIndex = 0
        Me.ListBox_Shares.TabStop = False
        '
        'Button_openshare
        '
        Me.Button_openshare.Enabled = False
        Me.Button_openshare.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.Button_openshare.Image = CType(resources.GetObject("Button_openshare.Image"), System.Drawing.Image)
        Me.Button_openshare.Location = New System.Drawing.Point(100, 8)
        Me.Button_openshare.Name = "Button_openshare"
        Me.Button_openshare.Size = New System.Drawing.Size(28, 28)
        Me.Button_openshare.TabIndex = 1
        Me.Button_openshare.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Button_openshare, "open selected share")
        '
        'Label_User
        '
        Me.Label_User.BackColor = System.Drawing.SystemColors.Window
        Me.Label_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_User.Location = New System.Drawing.Point(92, 96)
        Me.Label_User.Name = "Label_User"
        Me.Label_User.ReadOnly = True
        Me.Label_User.Size = New System.Drawing.Size(175, 19)
        Me.Label_User.TabIndex = 13
        Me.Label_User.TabStop = False
        '
        'Label_Boot
        '
        Me.Label_Boot.BackColor = System.Drawing.SystemColors.Window
        Me.Label_Boot.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_Boot.Location = New System.Drawing.Point(268, 71)
        Me.Label_Boot.Name = "Label_Boot"
        Me.Label_Boot.ReadOnly = True
        Me.Label_Boot.Size = New System.Drawing.Size(96, 19)
        Me.Label_Boot.TabIndex = 49
        Me.Label_Boot.TabStop = False
        '
        'Label_Ver
        '
        Me.Label_Ver.BackColor = System.Drawing.SystemColors.Window
        Me.Label_Ver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_Ver.Location = New System.Drawing.Point(268, 49)
        Me.Label_Ver.Name = "Label_Ver"
        Me.Label_Ver.ReadOnly = True
        Me.Label_Ver.Size = New System.Drawing.Size(96, 19)
        Me.Label_Ver.TabIndex = 47
        Me.Label_Ver.TabStop = False
        '
        'Label_SP
        '
        Me.Label_SP.BackColor = System.Drawing.SystemColors.Window
        Me.Label_SP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_SP.Location = New System.Drawing.Point(92, 49)
        Me.Label_SP.Name = "Label_SP"
        Me.Label_SP.ReadOnly = True
        Me.Label_SP.Size = New System.Drawing.Size(112, 19)
        Me.Label_SP.TabIndex = 11
        Me.Label_SP.TabStop = False
        '
        'Label_OS
        '
        Me.Label_OS.BackColor = System.Drawing.SystemColors.Window
        Me.Label_OS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_OS.Location = New System.Drawing.Point(92, 27)
        Me.Label_OS.Name = "Label_OS"
        Me.Label_OS.ReadOnly = True
        Me.Label_OS.Size = New System.Drawing.Size(272, 19)
        Me.Label_OS.TabIndex = 10
        Me.Label_OS.TabStop = False
        '
        'Label_Name
        '
        Me.Label_Name.BackColor = System.Drawing.SystemColors.Window
        Me.Label_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.Label_Name.Location = New System.Drawing.Point(92, 5)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.ReadOnly = True
        Me.Label_Name.Size = New System.Drawing.Size(112, 19)
        Me.Label_Name.TabIndex = 8
        Me.Label_Name.TabStop = False
        '
        'LabelIP
        '
        Me.LabelIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelIP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelIP.Location = New System.Drawing.Point(211, 8)
        Me.LabelIP.Name = "LabelIP"
        Me.LabelIP.Size = New System.Drawing.Size(64, 16)
        Me.LabelIP.TabIndex = 41
        Me.LabelIP.Text = "ip address"
        '
        'LabelName
        '
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelName.Location = New System.Drawing.Point(2, 7)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(84, 16)
        Me.LabelName.TabIndex = 39
        Me.LabelName.Text = "hostname"
        '
        'LabelUser
        '
        Me.LabelUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelUser.Location = New System.Drawing.Point(28, 98)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(72, 16)
        Me.LabelUser.TabIndex = 36
        Me.LabelUser.Text = "current user"
        '
        'LabelSP
        '
        Me.LabelSP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelSP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelSP.Location = New System.Drawing.Point(2, 51)
        Me.LabelSP.Name = "LabelSP"
        Me.LabelSP.Size = New System.Drawing.Size(87, 16)
        Me.LabelSP.TabIndex = 33
        Me.LabelSP.Text = "service pack"
        '
        'LabelV
        '
        Me.LabelV.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelV.Location = New System.Drawing.Point(211, 52)
        Me.LabelV.Name = "LabelV"
        Me.LabelV.Size = New System.Drawing.Size(48, 16)
        Me.LabelV.TabIndex = 32
        Me.LabelV.Text = "version"
        '
        'LabelBoot
        '
        Me.LabelBoot.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelBoot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelBoot.Location = New System.Drawing.Point(211, 73)
        Me.LabelBoot.Name = "LabelBoot"
        Me.LabelBoot.Size = New System.Drawing.Size(56, 16)
        Me.LabelBoot.TabIndex = 31
        Me.LabelBoot.Text = "last boot"
        '
        'LabelOS
        '
        Me.LabelOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LabelOS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelOS.Location = New System.Drawing.Point(1, 28)
        Me.LabelOS.Name = "LabelOS"
        Me.LabelOS.Size = New System.Drawing.Size(97, 16)
        Me.LabelOS.TabIndex = 30
        Me.LabelOS.Text = "operating system"
        '
        'Tabholder1
        '
        Me.Tabholder1.Controls.Add(Me.os)
        Me.Tabholder1.Controls.Add(Me.network)
        Me.Tabholder1.Controls.Add(Me.services)
        Me.Tabholder1.Controls.Add(Me.processes)
        Me.Tabholder1.Controls.Add(Me.printers)
        Me.Tabholder1.Controls.Add(Me.software)
        Me.Tabholder1.Controls.Add(Me.aduser)
        Me.Tabholder1.Controls.Add(Me.gpo)
        Me.Tabholder1.Controls.Add(Me.deploy)
        Me.Tabholder1.Controls.Add(Me.message)
        Me.Tabholder1.Controls.Add(Me.startup)
        Me.Tabholder1.Controls.Add(Me.tools)
        Me.Tabholder1.Controls.Add(Me.options)
        Me.Tabholder1.Controls.Add(Me.about)
        Me.Tabholder1.Controls.Add(Me.test)
        Me.Tabholder1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tabholder1.ItemSize = New System.Drawing.Size(58, 18)
        Me.Tabholder1.Location = New System.Drawing.Point(4, 83)
        Me.Tabholder1.Name = "Tabholder1"
        Me.Tabholder1.SelectedIndex = 0
        Me.Tabholder1.Size = New System.Drawing.Size(378, 264)
        Me.Tabholder1.TabIndex = 7
        '
        'printers
        '
        Me.printers.Controls.Add(Me.addptr4all)
        Me.printers.Controls.Add(Me.AddPrinterButton)
        Me.printers.Controls.Add(Me.addthisprinter)
        Me.printers.Controls.Add(Me.printerGrid)
        Me.printers.Controls.Add(Me.mappeddrivesGroupBox)
        Me.printers.Controls.Add(Me.printerRefresh)
        Me.printers.Location = New System.Drawing.Point(4, 22)
        Me.printers.Name = "printers"
        Me.printers.Padding = New System.Windows.Forms.Padding(3)
        Me.printers.Size = New System.Drawing.Size(370, 238)
        Me.printers.TabIndex = 14
        Me.printers.Text = "Printers"
        Me.printers.UseVisualStyleBackColor = True
        '
        'addptr4all
        '
        Me.addptr4all.AutoSize = True
        Me.addptr4all.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addptr4all.ForeColor = System.Drawing.Color.RoyalBlue
        Me.addptr4all.Location = New System.Drawing.Point(204, 90)
        Me.addptr4all.Name = "addptr4all"
        Me.addptr4all.Size = New System.Drawing.Size(88, 16)
        Me.addptr4all.TabIndex = 11
        Me.addptr4all.Text = "add for all users"
        Me.addptr4all.UseVisualStyleBackColor = True
        '
        'AddPrinterButton
        '
        Me.AddPrinterButton.Location = New System.Drawing.Point(147, 87)
        Me.AddPrinterButton.Name = "AddPrinterButton"
        Me.AddPrinterButton.Size = New System.Drawing.Size(35, 20)
        Me.AddPrinterButton.TabIndex = 10
        Me.AddPrinterButton.Text = "add"
        Me.AddPrinterButton.UseVisualStyleBackColor = True
        '
        'addthisprinter
        '
        Me.addthisprinter.BackColor = System.Drawing.SystemColors.Control
        Me.addthisprinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.addthisprinter.Location = New System.Drawing.Point(20, 87)
        Me.addthisprinter.Name = "addthisprinter"
        Me.addthisprinter.Size = New System.Drawing.Size(124, 20)
        Me.addthisprinter.TabIndex = 7
        Me.addthisprinter.Text = "\\server\printer"
        '
        'printerGrid
        '
        Me.printerGrid.AllowUserToAddRows = False
        Me.printerGrid.AllowUserToDeleteRows = False
        Me.printerGrid.AllowUserToResizeColumns = False
        Me.printerGrid.AllowUserToResizeRows = False
        Me.printerGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.printerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.printerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.printerGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pName, Me.pLocation})
        Me.printerGrid.Location = New System.Drawing.Point(18, 6)
        Me.printerGrid.MultiSelect = False
        Me.printerGrid.Name = "printerGrid"
        Me.printerGrid.RowHeadersVisible = False
        Me.printerGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printerGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.printerGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.printerGrid.RowTemplate.Height = 14
        Me.printerGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.printerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.printerGrid.Size = New System.Drawing.Size(274, 77)
        Me.printerGrid.TabIndex = 2
        Me.printerGrid.TabStop = False
        '
        'pName
        '
        Me.pName.HeaderText = "Printer Name   (right click for menu)"
        Me.pName.Name = "pName"
        Me.pName.ReadOnly = True
        Me.pName.Width = 200
        '
        'pLocation
        '
        Me.pLocation.HeaderText = "Location"
        Me.pLocation.Name = "pLocation"
        Me.pLocation.ReadOnly = True
        Me.pLocation.Width = 70
        '
        'mappeddrivesGroupBox
        '
        Me.mappeddrivesGroupBox.Controls.Add(Me.deletemappeddrive)
        Me.mappeddrivesGroupBox.Controls.Add(Me.addmappeddrive_button)
        Me.mappeddrivesGroupBox.Controls.Add(Me.addmappeddrive_letter)
        Me.mappeddrivesGroupBox.Controls.Add(Me.addmappeddrive_path)
        Me.mappeddrivesGroupBox.Controls.Add(Me.mappings)
        Me.mappeddrivesGroupBox.Controls.Add(Me.Label50)
        Me.mappeddrivesGroupBox.Controls.Add(Me.MappedDrivesButton)
        Me.mappeddrivesGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mappeddrivesGroupBox.Location = New System.Drawing.Point(11, 113)
        Me.mappeddrivesGroupBox.Name = "mappeddrivesGroupBox"
        Me.mappeddrivesGroupBox.Size = New System.Drawing.Size(349, 119)
        Me.mappeddrivesGroupBox.TabIndex = 5
        Me.mappeddrivesGroupBox.TabStop = False
        Me.mappeddrivesGroupBox.Text = "persistent mapped drives"
        '
        'deletemappeddrive
        '
        Me.deletemappeddrive.Enabled = False
        Me.deletemappeddrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletemappeddrive.Location = New System.Drawing.Point(293, 79)
        Me.deletemappeddrive.Name = "deletemappeddrive"
        Me.deletemappeddrive.Size = New System.Drawing.Size(48, 19)
        Me.deletemappeddrive.TabIndex = 8
        Me.deletemappeddrive.Text = "delete"
        Me.deletemappeddrive.UseVisualStyleBackColor = True
        '
        'addmappeddrive_button
        '
        Me.addmappeddrive_button.Enabled = False
        Me.addmappeddrive_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addmappeddrive_button.Location = New System.Drawing.Point(249, 79)
        Me.addmappeddrive_button.Name = "addmappeddrive_button"
        Me.addmappeddrive_button.Size = New System.Drawing.Size(37, 19)
        Me.addmappeddrive_button.TabIndex = 7
        Me.addmappeddrive_button.Text = "add"
        Me.addmappeddrive_button.UseVisualStyleBackColor = True
        '
        'addmappeddrive_letter
        '
        Me.addmappeddrive_letter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addmappeddrive_letter.Location = New System.Drawing.Point(7, 79)
        Me.addmappeddrive_letter.MaxLength = 1
        Me.addmappeddrive_letter.Name = "addmappeddrive_letter"
        Me.addmappeddrive_letter.Size = New System.Drawing.Size(26, 20)
        Me.addmappeddrive_letter.TabIndex = 5
        '
        'addmappeddrive_path
        '
        Me.addmappeddrive_path.BackColor = System.Drawing.Color.WhiteSmoke
        Me.addmappeddrive_path.Location = New System.Drawing.Point(39, 79)
        Me.addmappeddrive_path.Name = "addmappeddrive_path"
        Me.addmappeddrive_path.Size = New System.Drawing.Size(204, 20)
        Me.addmappeddrive_path.TabIndex = 6
        '
        'mappings
        '
        Me.mappings.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mappings.FormattingEnabled = True
        Me.mappings.Location = New System.Drawing.Point(7, 20)
        Me.mappings.Name = "mappings"
        Me.mappings.Size = New System.Drawing.Size(279, 56)
        Me.mappings.TabIndex = 3
        Me.mappings.TabStop = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label50.Location = New System.Drawing.Point(38, 101)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(205, 12)
        Me.Label50.TabIndex = 4
        Me.Label50.Text = "drives will not be updated for user until next logon"
        '
        'MappedDrivesButton
        '
        Me.MappedDrivesButton.Enabled = False
        Me.MappedDrivesButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.MappedDrivesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MappedDrivesButton.Location = New System.Drawing.Point(292, 21)
        Me.MappedDrivesButton.Name = "MappedDrivesButton"
        Me.MappedDrivesButton.Size = New System.Drawing.Size(49, 23)
        Me.MappedDrivesButton.TabIndex = 1
        Me.MappedDrivesButton.Text = "refresh"
        Me.ToolTip1.SetToolTip(Me.MappedDrivesButton, "list currently logged on uer's mapped drives")
        Me.MappedDrivesButton.UseVisualStyleBackColor = True
        '
        'printerRefresh
        '
        Me.printerRefresh.Enabled = False
        Me.printerRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printerRefresh.Location = New System.Drawing.Point(311, 6)
        Me.printerRefresh.Name = "printerRefresh"
        Me.printerRefresh.Size = New System.Drawing.Size(49, 23)
        Me.printerRefresh.TabIndex = 0
        Me.printerRefresh.Text = "refresh"
        Me.printerRefresh.UseVisualStyleBackColor = True
        '
        'gpo
        '
        Me.gpo.Controls.Add(Me.lbl_localgpo)
        Me.gpo.Controls.Add(Me.gpoDebugCombo)
        Me.gpo.Controls.Add(Me.lbl_debug)
        Me.gpo.Controls.Add(Me.lbl_rsop)
        Me.gpo.Controls.Add(Me.Label55)
        Me.gpo.Controls.Add(Me.gpoDebugMode)
        Me.gpo.Controls.Add(Me.gpupdateChoice)
        Me.gpo.Controls.Add(Me.btn_gpo_policies)
        Me.gpo.Controls.Add(Me.gprefresh)
        Me.gpo.Controls.Add(Me.GPODataGrid)
        Me.gpo.Controls.Add(Me.btn_startupscripts)
        Me.gpo.Location = New System.Drawing.Point(4, 22)
        Me.gpo.Name = "gpo"
        Me.gpo.Padding = New System.Windows.Forms.Padding(3)
        Me.gpo.Size = New System.Drawing.Size(370, 238)
        Me.gpo.TabIndex = 16
        Me.gpo.Text = "Group Policy"
        Me.gpo.UseVisualStyleBackColor = True
        '
        'lbl_localgpo
        '
        Me.lbl_localgpo.AutoSize = True
        Me.lbl_localgpo.Enabled = False
        Me.lbl_localgpo.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_localgpo.Location = New System.Drawing.Point(6, 29)
        Me.lbl_localgpo.Name = "lbl_localgpo"
        Me.lbl_localgpo.Size = New System.Drawing.Size(87, 13)
        Me.lbl_localgpo.TabIndex = 107
        Me.lbl_localgpo.TabStop = True
        Me.lbl_localgpo.Text = "local group policy"
        '
        'gpoDebugCombo
        '
        Me.gpoDebugCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpoDebugCombo.FormattingEnabled = True
        Me.gpoDebugCombo.Items.AddRange(New Object() {"None", "Normal", "Verbose", "Logfile", "Debugger", "Normal|Logfile", "Verbose|Logfile", "Debug|Verbose|Logfile"})
        Me.gpoDebugCombo.Location = New System.Drawing.Point(243, 30)
        Me.gpoDebugCombo.Name = "gpoDebugCombo"
        Me.gpoDebugCombo.Size = New System.Drawing.Size(121, 20)
        Me.gpoDebugCombo.TabIndex = 3
        '
        'lbl_debug
        '
        Me.lbl_debug.AutoSize = True
        Me.lbl_debug.Enabled = False
        Me.lbl_debug.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_debug.LinkColor = System.Drawing.Color.Gray
        Me.lbl_debug.Location = New System.Drawing.Point(240, 49)
        Me.lbl_debug.Name = "lbl_debug"
        Me.lbl_debug.Size = New System.Drawing.Size(67, 12)
        Me.lbl_debug.TabIndex = 106
        Me.lbl_debug.TabStop = True
        Me.lbl_debug.Text = "view debug file"
        '
        'lbl_rsop
        '
        Me.lbl_rsop.AutoSize = True
        Me.lbl_rsop.Enabled = False
        Me.lbl_rsop.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_rsop.Location = New System.Drawing.Point(6, 12)
        Me.lbl_rsop.Name = "lbl_rsop"
        Me.lbl_rsop.Size = New System.Drawing.Size(89, 13)
        Me.lbl_rsop.TabIndex = 105
        Me.lbl_rsop.TabStop = True
        Me.lbl_rsop.Text = "create rsop report"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(176, 29)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(42, 13)
        Me.Label55.TabIndex = 104
        Me.Label55.Text = "set gpo"
        '
        'gpoDebugMode
        '
        Me.gpoDebugMode.AutoSize = True
        Me.gpoDebugMode.Location = New System.Drawing.Point(176, 37)
        Me.gpoDebugMode.Name = "gpoDebugMode"
        Me.gpoDebugMode.Size = New System.Drawing.Size(69, 13)
        Me.gpoDebugMode.TabIndex = 100
        Me.gpoDebugMode.Text = "debug mode:"
        '
        'gpupdateChoice
        '
        Me.gpupdateChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpupdateChoice.FormattingEnabled = True
        Me.gpupdateChoice.Items.AddRange(New Object() {"Machine Only", "User Only", "Machine and User"})
        Me.gpupdateChoice.Location = New System.Drawing.Point(243, 4)
        Me.gpupdateChoice.Name = "gpupdateChoice"
        Me.gpupdateChoice.Size = New System.Drawing.Size(121, 20)
        Me.gpupdateChoice.TabIndex = 2
        '
        'btn_gpo_policies
        '
        Me.btn_gpo_policies.Enabled = False
        Me.btn_gpo_policies.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gpo_policies.Location = New System.Drawing.Point(6, 59)
        Me.btn_gpo_policies.Name = "btn_gpo_policies"
        Me.btn_gpo_policies.Size = New System.Drawing.Size(94, 22)
        Me.btn_gpo_policies.TabIndex = 5
        Me.btn_gpo_policies.Text = "applied policies"
        Me.btn_gpo_policies.UseVisualStyleBackColor = True
        '
        'gprefresh
        '
        Me.gprefresh.Enabled = False
        Me.gprefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gprefresh.Location = New System.Drawing.Point(179, 3)
        Me.gprefresh.Name = "gprefresh"
        Me.gprefresh.Size = New System.Drawing.Size(60, 22)
        Me.gprefresh.TabIndex = 1
        Me.gprefresh.Text = "gpupdate"
        Me.gprefresh.UseVisualStyleBackColor = True
        '
        'GPODataGrid
        '
        Me.GPODataGrid.AllowUserToAddRows = False
        Me.GPODataGrid.AllowUserToDeleteRows = False
        Me.GPODataGrid.AllowUserToResizeRows = False
        Me.GPODataGrid.BackgroundColor = System.Drawing.Color.White
        Me.GPODataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GPODataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GPODataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GPODataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col0, Me.col1, Me.col2, Me.Col3})
        Me.GPODataGrid.Location = New System.Drawing.Point(7, 82)
        Me.GPODataGrid.MultiSelect = False
        Me.GPODataGrid.Name = "GPODataGrid"
        Me.GPODataGrid.ReadOnly = True
        Me.GPODataGrid.RowHeadersVisible = False
        Me.GPODataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.GPODataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GPODataGrid.RowTemplate.Height = 19
        Me.GPODataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GPODataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GPODataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GPODataGrid.Size = New System.Drawing.Size(357, 151)
        Me.GPODataGrid.TabIndex = 2
        Me.GPODataGrid.TabStop = False
        Me.ToolTip1.SetToolTip(Me.GPODataGrid, "Right click for menu")
        '
        'col0
        '
        Me.col0.HeaderText = ""
        Me.col0.Name = "col0"
        Me.col0.ReadOnly = True
        Me.col0.Width = 400
        '
        'col1
        '
        Me.col1.HeaderText = ""
        Me.col1.Name = "col1"
        Me.col1.ReadOnly = True
        '
        'col2
        '
        Me.col2.HeaderText = ""
        Me.col2.Name = "col2"
        Me.col2.ReadOnly = True
        '
        'Col3
        '
        Me.Col3.HeaderText = ""
        Me.Col3.Name = "Col3"
        Me.Col3.ReadOnly = True
        Me.Col3.Visible = False
        '
        'btn_startupscripts
        '
        Me.btn_startupscripts.Enabled = False
        Me.btn_startupscripts.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_startupscripts.Location = New System.Drawing.Point(106, 59)
        Me.btn_startupscripts.Name = "btn_startupscripts"
        Me.btn_startupscripts.Size = New System.Drawing.Size(91, 22)
        Me.btn_startupscripts.TabIndex = 6
        Me.btn_startupscripts.Text = "applied scripts"
        Me.btn_startupscripts.UseVisualStyleBackColor = True
        '
        'deploy
        '
        Me.deploy.Controls.Add(Me.file_folder)
        Me.deploy.Controls.Add(Me.folder_radio)
        Me.deploy.Controls.Add(Me.file_radio)
        Me.deploy.Controls.Add(Me.installcmd)
        Me.deploy.Controls.Add(Me.close_on_finish)
        Me.deploy.Controls.Add(Me.run_visible)
        Me.deploy.Controls.Add(Me.deploy_clear_link)
        Me.deploy.Controls.Add(Me.ProgressBar1)
        Me.deploy.Controls.Add(Me.edit)
        Me.deploy.Controls.Add(Me.Label51)
        Me.deploy.Controls.Add(Me.Label49)
        Me.deploy.Controls.Add(Me.Add_File_Folder)
        Me.deploy.Controls.Add(Me.Label44)
        Me.deploy.Controls.Add(Me.installcmd_checkbox)
        Me.deploy.Controls.Add(Me.load_appdeploy)
        Me.deploy.Controls.Add(Me.save_appdeploy)
        Me.deploy.Controls.Add(Me.GetFolder2)
        Me.deploy.Controls.Add(Me.Label43)
        Me.deploy.Controls.Add(Me._to)
        Me.deploy.Controls.Add(Me.AppGo_Button)
        Me.deploy.Location = New System.Drawing.Point(4, 22)
        Me.deploy.Name = "deploy"
        Me.deploy.Size = New System.Drawing.Size(370, 238)
        Me.deploy.TabIndex = 15
        Me.deploy.Text = "Deploy"
        Me.deploy.UseVisualStyleBackColor = True
        '
        'file_folder
        '
        Me.file_folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file_folder.Location = New System.Drawing.Point(54, 27)
        Me.file_folder.Multiline = True
        Me.file_folder.Name = "file_folder"
        Me.file_folder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.file_folder.Size = New System.Drawing.Size(261, 46)
        Me.file_folder.TabIndex = 108
        Me.file_folder.WordWrap = False
        '
        'folder_radio
        '
        Me.folder_radio.AutoSize = True
        Me.folder_radio.Location = New System.Drawing.Point(4, 26)
        Me.folder_radio.Name = "folder_radio"
        Me.folder_radio.Size = New System.Drawing.Size(51, 17)
        Me.folder_radio.TabIndex = 131
        Me.folder_radio.Text = "folder"
        Me.folder_radio.UseVisualStyleBackColor = True
        '
        'file_radio
        '
        Me.file_radio.AutoSize = True
        Me.file_radio.Checked = True
        Me.file_radio.Location = New System.Drawing.Point(4, 41)
        Me.file_radio.Name = "file_radio"
        Me.file_radio.Size = New System.Drawing.Size(49, 17)
        Me.file_radio.TabIndex = 130
        Me.file_radio.TabStop = True
        Me.file_radio.Text = "file(s)"
        Me.file_radio.UseVisualStyleBackColor = True
        '
        'installcmd
        '
        Me.installcmd.Enabled = False
        Me.installcmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.installcmd.Location = New System.Drawing.Point(21, 147)
        Me.installcmd.Multiline = True
        Me.installcmd.Name = "installcmd"
        Me.installcmd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.installcmd.Size = New System.Drawing.Size(262, 23)
        Me.installcmd.TabIndex = 115
        '
        'close_on_finish
        '
        Me.close_on_finish.AutoSize = True
        Me.close_on_finish.Enabled = False
        Me.close_on_finish.Location = New System.Drawing.Point(289, 158)
        Me.close_on_finish.Name = "close_on_finish"
        Me.close_on_finish.Size = New System.Drawing.Size(74, 17)
        Me.close_on_finish.TabIndex = 117
        Me.close_on_finish.Text = "auto close"
        Me.ToolTip1.SetToolTip(Me.close_on_finish, "close cmd window once command completed")
        Me.close_on_finish.UseVisualStyleBackColor = True
        '
        'run_visible
        '
        Me.run_visible.AutoSize = True
        Me.run_visible.Checked = True
        Me.run_visible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.run_visible.Enabled = False
        Me.run_visible.Location = New System.Drawing.Point(289, 144)
        Me.run_visible.Name = "run_visible"
        Me.run_visible.Size = New System.Drawing.Size(84, 17)
        Me.run_visible.TabIndex = 116
        Me.run_visible.Text = "cmd window"
        Me.ToolTip1.SetToolTip(Me.run_visible, "monitor install progress")
        Me.run_visible.UseVisualStyleBackColor = True
        '
        'deploy_clear_link
        '
        Me.deploy_clear_link.AutoSize = True
        Me.deploy_clear_link.LinkColor = System.Drawing.Color.RoyalBlue
        Me.deploy_clear_link.Location = New System.Drawing.Point(17, 197)
        Me.deploy_clear_link.Name = "deploy_clear_link"
        Me.deploy_clear_link.Size = New System.Drawing.Size(29, 13)
        Me.deploy_clear_link.TabIndex = 122
        Me.deploy_clear_link.TabStop = True
        Me.deploy_clear_link.Text = "clear"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Gold
        Me.ProgressBar1.Location = New System.Drawing.Point(54, 108)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(261, 16)
        Me.ProgressBar1.TabIndex = 59
        Me.ProgressBar1.Visible = False
        '
        'edit
        '
        Me.edit.AutoSize = True
        Me.edit.LinkColor = System.Drawing.Color.RoyalBlue
        Me.edit.Location = New System.Drawing.Point(17, 215)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(56, 13)
        Me.edit.TabIndex = 123
        Me.edit.TabStop = True
        Me.edit.Text = "edit saved"
        Me.ToolTip1.SetToolTip(Me.edit, "view/edit saved deployment details")
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label51.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label51.Location = New System.Drawing.Point(19, 180)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(208, 12)
        Me.Label51.TabIndex = 122
        Me.Label51.Text = "call a script or batch file (c:\newfolder\install.cmd)"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!)
        Me.Label49.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label49.Location = New System.Drawing.Point(19, 170)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(233, 12)
        Me.Label49.TabIndex = 121
        Me.Label49.Text = "The command can invoke a file directly (c:\setup.exe) or"
        '
        'Add_File_Folder
        '
        Me.Add_File_Folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_File_Folder.Location = New System.Drawing.Point(321, 27)
        Me.Add_File_Folder.Name = "Add_File_Folder"
        Me.Add_File_Folder.Size = New System.Drawing.Size(46, 19)
        Me.Add_File_Folder.TabIndex = 109
        Me.Add_File_Folder.Text = "browse"
        Me.ToolTip1.SetToolTip(Me.Add_File_Folder, "select files/folder required")
        Me.Add_File_Folder.UseVisualStyleBackColor = True
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(52, 14)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(38, 13)
        Me.Label44.TabIndex = 116
        Me.Label44.Text = "source"
        '
        'installcmd_checkbox
        '
        Me.installcmd_checkbox.AutoSize = True
        Me.installcmd_checkbox.Location = New System.Drawing.Point(21, 130)
        Me.installcmd_checkbox.Name = "installcmd_checkbox"
        Me.installcmd_checkbox.Size = New System.Drawing.Size(197, 17)
        Me.installcmd_checkbox.TabIndex = 114
        Me.installcmd_checkbox.Text = "run command when copy complete..."
        Me.installcmd_checkbox.UseVisualStyleBackColor = True
        '
        'load_appdeploy
        '
        Me.load_appdeploy.Location = New System.Drawing.Point(135, 211)
        Me.load_appdeploy.Name = "load_appdeploy"
        Me.load_appdeploy.Size = New System.Drawing.Size(49, 23)
        Me.load_appdeploy.TabIndex = 118
        Me.load_appdeploy.Text = "Load..."
        Me.ToolTip1.SetToolTip(Me.load_appdeploy, "load previously saved software deployment details")
        Me.load_appdeploy.UseVisualStyleBackColor = True
        '
        'save_appdeploy
        '
        Me.save_appdeploy.Location = New System.Drawing.Point(190, 211)
        Me.save_appdeploy.Name = "save_appdeploy"
        Me.save_appdeploy.Size = New System.Drawing.Size(49, 23)
        Me.save_appdeploy.TabIndex = 119
        Me.save_appdeploy.Text = "Save..."
        Me.ToolTip1.SetToolTip(Me.save_appdeploy, "save current software deployment details")
        Me.save_appdeploy.UseVisualStyleBackColor = True
        '
        'GetFolder2
        '
        Me.GetFolder2.Location = New System.Drawing.Point(321, 86)
        Me.GetFolder2.Name = "GetFolder2"
        Me.GetFolder2.Size = New System.Drawing.Size(46, 19)
        Me.GetFolder2.TabIndex = 113
        Me.GetFolder2.Text = "..."
        Me.ToolTip1.SetToolTip(Me.GetFolder2, "select folder on target computer")
        Me.GetFolder2.UseVisualStyleBackColor = True
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(52, 73)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(58, 13)
        Me.Label43.TabIndex = 110
        Me.Label43.Text = "destination"
        '
        '_to
        '
        Me._to.Location = New System.Drawing.Point(54, 86)
        Me._to.Name = "_to"
        Me._to.Size = New System.Drawing.Size(261, 19)
        Me._to.TabIndex = 110
        '
        'AppGo_Button
        '
        Me.AppGo_Button.Location = New System.Drawing.Point(310, 191)
        Me.AppGo_Button.Name = "AppGo_Button"
        Me.AppGo_Button.Size = New System.Drawing.Size(46, 38)
        Me.AppGo_Button.TabIndex = 120
        Me.AppGo_Button.Text = "Go"
        Me.ToolTip1.SetToolTip(Me.AppGo_Button, "copy files and run command")
        Me.AppGo_Button.UseVisualStyleBackColor = True
        '
        'startup
        '
        Me.startup.Controls.Add(Me.startupApplyButton)
        Me.startup.Controls.Add(Me.startupModifyButton)
        Me.startup.Controls.Add(Me.startupDeleteButton)
        Me.startup.Controls.Add(Me.Label48)
        Me.startup.Controls.Add(Me.Label47)
        Me.startup.Controls.Add(Me.stup_command)
        Me.startup.Controls.Add(Me.Label46)
        Me.startup.Controls.Add(Me.Label45)
        Me.startup.Controls.Add(Me.stup_user)
        Me.startup.Controls.Add(Me.stup_location)
        Me.startup.Controls.Add(Me.startupbutton)
        Me.startup.Controls.Add(Me.startupDataGrid)
        Me.startup.Location = New System.Drawing.Point(4, 22)
        Me.startup.Name = "startup"
        Me.startup.Padding = New System.Windows.Forms.Padding(3)
        Me.startup.Size = New System.Drawing.Size(370, 238)
        Me.startup.TabIndex = 13
        Me.startup.Text = "StartUp"
        Me.startup.UseVisualStyleBackColor = True
        '
        'startupApplyButton
        '
        Me.startupApplyButton.Enabled = False
        Me.startupApplyButton.Location = New System.Drawing.Point(318, 180)
        Me.startupApplyButton.Name = "startupApplyButton"
        Me.startupApplyButton.Size = New System.Drawing.Size(46, 23)
        Me.startupApplyButton.TabIndex = 78
        Me.startupApplyButton.Text = "apply"
        Me.startupApplyButton.UseVisualStyleBackColor = True
        '
        'startupModifyButton
        '
        Me.startupModifyButton.Enabled = False
        Me.startupModifyButton.Location = New System.Drawing.Point(239, 107)
        Me.startupModifyButton.Name = "startupModifyButton"
        Me.startupModifyButton.Size = New System.Drawing.Size(46, 23)
        Me.startupModifyButton.TabIndex = 77
        Me.startupModifyButton.Text = "modify"
        Me.startupModifyButton.UseVisualStyleBackColor = True
        '
        'startupDeleteButton
        '
        Me.startupDeleteButton.Enabled = False
        Me.startupDeleteButton.Location = New System.Drawing.Point(299, 107)
        Me.startupDeleteButton.Name = "startupDeleteButton"
        Me.startupDeleteButton.Size = New System.Drawing.Size(46, 23)
        Me.startupDeleteButton.TabIndex = 76
        Me.startupDeleteButton.Text = "delete"
        Me.startupDeleteButton.UseVisualStyleBackColor = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Location = New System.Drawing.Point(3, 200)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(67, 13)
        Me.Label48.TabIndex = 75
        Me.Label48.Text = "user account"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label47.Location = New System.Drawing.Point(3, 132)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(93, 13)
        Me.Label47.TabIndex = 74
        Me.Label47.Text = "instruction location"
        '
        'stup_command
        '
        Me.stup_command.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stup_command.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stup_command.Location = New System.Drawing.Point(5, 182)
        Me.stup_command.Name = "stup_command"
        Me.stup_command.ReadOnly = True
        Me.stup_command.Size = New System.Drawing.Size(307, 18)
        Me.stup_command.TabIndex = 69
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label46.Location = New System.Drawing.Point(4, 167)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(52, 13)
        Me.Label46.TabIndex = 73
        Me.Label46.Text = "command"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label45.Location = New System.Drawing.Point(216, 6)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(145, 13)
        Me.Label45.TabIndex = 72
        Me.Label45.Text = "Commands that run at startup"
        '
        'stup_user
        '
        Me.stup_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stup_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stup_user.Location = New System.Drawing.Point(5, 215)
        Me.stup_user.Name = "stup_user"
        Me.stup_user.ReadOnly = True
        Me.stup_user.Size = New System.Drawing.Size(205, 17)
        Me.stup_user.TabIndex = 71
        '
        'stup_location
        '
        Me.stup_location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stup_location.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stup_location.Location = New System.Drawing.Point(5, 146)
        Me.stup_location.Name = "stup_location"
        Me.stup_location.ReadOnly = True
        Me.stup_location.Size = New System.Drawing.Size(356, 18)
        Me.stup_location.TabIndex = 70
        '
        'startupbutton
        '
        Me.startupbutton.Enabled = False
        Me.startupbutton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.startupbutton.Location = New System.Drawing.Point(313, 22)
        Me.startupbutton.Name = "startupbutton"
        Me.startupbutton.Size = New System.Drawing.Size(48, 20)
        Me.startupbutton.TabIndex = 67
        Me.startupbutton.Text = "refresh"
        Me.startupbutton.UseVisualStyleBackColor = True
        '
        'startupDataGrid
        '
        Me.startupDataGrid.AllowUserToAddRows = False
        Me.startupDataGrid.AllowUserToDeleteRows = False
        Me.startupDataGrid.AllowUserToResizeColumns = False
        Me.startupDataGrid.AllowUserToResizeRows = False
        Me.startupDataGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.startupDataGrid.ColumnHeadersHeight = 14
        Me.startupDataGrid.ColumnHeadersVisible = False
        Me.startupDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.startupName, Me.startupCommand, Me.startupLocation, Me.startupUser})
        Me.startupDataGrid.GridColor = System.Drawing.SystemColors.Window
        Me.startupDataGrid.Location = New System.Drawing.Point(6, 7)
        Me.startupDataGrid.MultiSelect = False
        Me.startupDataGrid.Name = "startupDataGrid"
        Me.startupDataGrid.ReadOnly = True
        Me.startupDataGrid.RowHeadersVisible = False
        Me.startupDataGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.startupDataGrid.RowTemplate.Height = 14
        Me.startupDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.startupDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.startupDataGrid.Size = New System.Drawing.Size(204, 123)
        Me.startupDataGrid.TabIndex = 66
        '
        'startupName
        '
        Me.startupName.HeaderText = "Name"
        Me.startupName.Name = "startupName"
        Me.startupName.ReadOnly = True
        Me.startupName.ToolTipText = "Start Up Programs"
        Me.startupName.Width = 200
        '
        'startupCommand
        '
        Me.startupCommand.HeaderText = "Command"
        Me.startupCommand.Name = "startupCommand"
        Me.startupCommand.ReadOnly = True
        Me.startupCommand.Visible = False
        '
        'startupLocation
        '
        Me.startupLocation.HeaderText = "Location"
        Me.startupLocation.Name = "startupLocation"
        Me.startupLocation.ReadOnly = True
        Me.startupLocation.Visible = False
        '
        'startupUser
        '
        Me.startupUser.HeaderText = "User"
        Me.startupUser.Name = "startupUser"
        Me.startupUser.ReadOnly = True
        Me.startupUser.Visible = False
        '
        'test
        '
        Me.test.Controls.Add(Me.GroupBox10)
        Me.test.Controls.Add(Me.groupToAdd)
        Me.test.Controls.Add(Me.btn_AddGroup)
        Me.test.Controls.Add(Me.cmdtorun)
        Me.test.Controls.Add(Me.Button4)
        Me.test.Controls.Add(Me.testbox)
        Me.test.Controls.Add(Me.stdInbtn)
        Me.test.Controls.Add(Me.btn_Monitor)
        Me.test.Controls.Add(Me.Button2)
        Me.test.Controls.Add(Me.Button3)
        Me.test.Controls.Add(Me.GroupBox9)
        Me.test.Location = New System.Drawing.Point(4, 22)
        Me.test.Name = "test"
        Me.test.Padding = New System.Windows.Forms.Padding(3)
        Me.test.Size = New System.Drawing.Size(370, 238)
        Me.test.TabIndex = 12
        Me.test.Text = "test"
        Me.test.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.btn_GetSiteOrg)
        Me.GroupBox10.Controls.Add(Me.Label42)
        Me.GroupBox10.Controls.Add(Me.Label39)
        Me.GroupBox10.Controls.Add(Me.setSiteOrg)
        Me.GroupBox10.Controls.Add(Me.sitename)
        Me.GroupBox10.Controls.Add(Me.org)
        Me.GroupBox10.Location = New System.Drawing.Point(185, 35)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(177, 72)
        Me.GroupBox10.TabIndex = 105
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "registry settings"
        '
        'btn_GetSiteOrg
        '
        Me.btn_GetSiteOrg.Location = New System.Drawing.Point(138, 24)
        Me.btn_GetSiteOrg.Name = "btn_GetSiteOrg"
        Me.btn_GetSiteOrg.Size = New System.Drawing.Size(35, 19)
        Me.btn_GetSiteOrg.TabIndex = 106
        Me.btn_GetSiteOrg.Text = "Get"
        Me.btn_GetSiteOrg.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(6, 43)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(18, 12)
        Me.Label42.TabIndex = 105
        Me.Label42.Text = "org"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(6, 25)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(20, 12)
        Me.Label39.TabIndex = 104
        Me.Label39.Text = "site"
        '
        'setSiteOrg
        '
        Me.setSiteOrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setSiteOrg.Location = New System.Drawing.Point(138, 43)
        Me.setSiteOrg.Name = "setSiteOrg"
        Me.setSiteOrg.Size = New System.Drawing.Size(35, 19)
        Me.setSiteOrg.TabIndex = 103
        Me.setSiteOrg.Text = "Set"
        Me.setSiteOrg.UseVisualStyleBackColor = True
        '
        'sitename
        '
        Me.sitename.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sitename.Location = New System.Drawing.Point(32, 22)
        Me.sitename.Name = "sitename"
        Me.sitename.Size = New System.Drawing.Size(98, 17)
        Me.sitename.TabIndex = 101
        '
        'org
        '
        Me.org.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.org.FormattingEnabled = True
        Me.org.Items.AddRange(New Object() {"5N6", "5N7", "YDD08", "RXM", "Q33"})
        Me.org.Location = New System.Drawing.Point(32, 43)
        Me.org.Name = "org"
        Me.org.Size = New System.Drawing.Size(98, 20)
        Me.org.TabIndex = 102
        '
        'groupToAdd
        '
        Me.groupToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupToAdd.Location = New System.Drawing.Point(9, 90)
        Me.groupToAdd.Name = "groupToAdd"
        Me.groupToAdd.Size = New System.Drawing.Size(121, 17)
        Me.groupToAdd.TabIndex = 104
        '
        'btn_AddGroup
        '
        Me.btn_AddGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddGroup.Location = New System.Drawing.Point(8, 108)
        Me.btn_AddGroup.Name = "btn_AddGroup"
        Me.btn_AddGroup.Size = New System.Drawing.Size(75, 24)
        Me.btn_AddGroup.TabIndex = 100
        Me.btn_AddGroup.Text = "add to admins"
        Me.btn_AddGroup.UseVisualStyleBackColor = True
        '
        'cmdtorun
        '
        Me.cmdtorun.Location = New System.Drawing.Point(4, 172)
        Me.cmdtorun.Name = "cmdtorun"
        Me.cmdtorun.Size = New System.Drawing.Size(195, 19)
        Me.cmdtorun.TabIndex = 99
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(205, 168)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(53, 23)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'testbox
        '
        Me.testbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.testbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testbox.ForeColor = System.Drawing.Color.White
        Me.testbox.Location = New System.Drawing.Point(4, 194)
        Me.testbox.MaxLength = 260
        Me.testbox.Multiline = True
        Me.testbox.Name = "testbox"
        Me.testbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.testbox.Size = New System.Drawing.Size(254, 38)
        Me.testbox.TabIndex = 97
        '
        'stdInbtn
        '
        Me.stdInbtn.Location = New System.Drawing.Point(261, 168)
        Me.stdInbtn.Name = "stdInbtn"
        Me.stdInbtn.Size = New System.Drawing.Size(53, 23)
        Me.stdInbtn.TabIndex = 96
        Me.stdInbtn.Text = "stdIn/Out"
        Me.stdInbtn.UseVisualStyleBackColor = True
        '
        'btn_Monitor
        '
        Me.btn_Monitor.Location = New System.Drawing.Point(316, 7)
        Me.btn_Monitor.Name = "btn_Monitor"
        Me.btn_Monitor.Size = New System.Drawing.Size(51, 20)
        Me.btn_Monitor.TabIndex = 95
        Me.btn_Monitor.Text = "Monitor EDID"
        Me.btn_Monitor.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(253, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 20)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "eventlog"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(182, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 20)
        Me.Button3.TabIndex = 93
        Me.Button3.Text = "screenshot..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.interactively)
        Me.GroupBox9.Controls.Add(Me.returnval)
        Me.GroupBox9.Controls.Add(Me.command)
        Me.GroupBox9.Controls.Add(Me.copy)
        Me.GroupBox9.Controls.Add(Me.exec)
        Me.GroupBox9.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(166, 77)
        Me.GroupBox9.TabIndex = 79
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Remote Process"
        '
        'interactively
        '
        Me.interactively.AutoSize = True
        Me.interactively.Location = New System.Drawing.Point(95, 28)
        Me.interactively.Name = "interactively"
        Me.interactively.Size = New System.Drawing.Size(74, 17)
        Me.interactively.TabIndex = 79
        Me.interactively.Text = "interactive"
        Me.interactively.UseVisualStyleBackColor = True
        '
        'returnval
        '
        Me.returnval.AutoSize = True
        Me.returnval.Location = New System.Drawing.Point(10, 59)
        Me.returnval.Name = "returnval"
        Me.returnval.Size = New System.Drawing.Size(63, 13)
        Me.returnval.TabIndex = 78
        Me.returnval.Text = "return value"
        '
        'command
        '
        Me.command.Location = New System.Drawing.Point(6, 40)
        Me.command.Name = "command"
        Me.command.Size = New System.Drawing.Size(86, 19)
        Me.command.TabIndex = 76
        '
        'copy
        '
        Me.copy.AutoSize = True
        Me.copy.Location = New System.Drawing.Point(95, 44)
        Me.copy.Name = "copy"
        Me.copy.Size = New System.Drawing.Size(48, 17)
        Me.copy.TabIndex = 77
        Me.copy.Text = "copy"
        Me.copy.UseVisualStyleBackColor = True
        '
        'exec
        '
        Me.exec.Location = New System.Drawing.Point(6, 18)
        Me.exec.Name = "exec"
        Me.exec.Size = New System.Drawing.Size(70, 20)
        Me.exec.TabIndex = 65
        Me.exec.Text = "remoteexec"
        Me.exec.UseVisualStyleBackColor = True
        '
        'printermenu
        '
        Me.printermenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ptrproperties, Me.ptsvrproperties, Me.ToolStripSeparator12, Me.SetPrinterAsDefaultToolStripMenuItem, Me.ToolStripSeparator20, Me.addptr, Me.DeletePrinterMenu, Me.DeleteNetworkPrinterMenu, Me.ToolStripSeparator16, Me.ptrrefresh, Me.ToolStripSeparator19})
        Me.printermenu.Name = "printermenu"
        Me.printermenu.Size = New System.Drawing.Size(191, 182)
        '
        'ptrproperties
        '
        Me.ptrproperties.Enabled = False
        Me.ptrproperties.Name = "ptrproperties"
        Me.ptrproperties.Size = New System.Drawing.Size(190, 22)
        Me.ptrproperties.Text = "printer properties..."
        '
        'ptsvrproperties
        '
        Me.ptsvrproperties.Enabled = False
        Me.ptsvrproperties.Name = "ptsvrproperties"
        Me.ptsvrproperties.Size = New System.Drawing.Size(190, 22)
        Me.ptsvrproperties.Text = "print server properties"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(187, 6)
        '
        'SetPrinterAsDefaultToolStripMenuItem
        '
        Me.SetPrinterAsDefaultToolStripMenuItem.Name = "SetPrinterAsDefaultToolStripMenuItem"
        Me.SetPrinterAsDefaultToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SetPrinterAsDefaultToolStripMenuItem.Text = "set printer as default"
        Me.SetPrinterAsDefaultToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(187, 6)
        '
        'addptr
        '
        Me.addptr.Enabled = False
        Me.addptr.Name = "addptr"
        Me.addptr.Size = New System.Drawing.Size(190, 22)
        Me.addptr.Text = "add local printer"
        '
        'DeletePrinterMenu
        '
        Me.DeletePrinterMenu.Enabled = False
        Me.DeletePrinterMenu.Name = "DeletePrinterMenu"
        Me.DeletePrinterMenu.Size = New System.Drawing.Size(190, 22)
        Me.DeletePrinterMenu.Text = "delete local printer"
        '
        'DeleteNetworkPrinterMenu
        '
        Me.DeleteNetworkPrinterMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForThisUserToolStripMenuItem, Me.ForAllUsersToolStripMenuItem})
        Me.DeleteNetworkPrinterMenu.Enabled = False
        Me.DeleteNetworkPrinterMenu.Name = "DeleteNetworkPrinterMenu"
        Me.DeleteNetworkPrinterMenu.Size = New System.Drawing.Size(190, 22)
        Me.DeleteNetworkPrinterMenu.Text = "delete network printer"
        '
        'ForThisUserToolStripMenuItem
        '
        Me.ForThisUserToolStripMenuItem.Name = "ForThisUserToolStripMenuItem"
        Me.ForThisUserToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ForThisUserToolStripMenuItem.Text = "for this user"
        '
        'ForAllUsersToolStripMenuItem
        '
        Me.ForAllUsersToolStripMenuItem.Name = "ForAllUsersToolStripMenuItem"
        Me.ForAllUsersToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ForAllUsersToolStripMenuItem.Text = "for all users"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(187, 6)
        '
        'ptrrefresh
        '
        Me.ptrrefresh.Enabled = False
        Me.ptrrefresh.Name = "ptrrefresh"
        Me.ptrrefresh.Size = New System.Drawing.Size(190, 22)
        Me.ptrrefresh.Text = "refresh"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(187, 6)
        '
        'computername
        '
        Me.computername.BackColor = System.Drawing.Color.LightSkyBlue
        Me.computername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.computername.ForeColor = System.Drawing.Color.Black
        Me.computername.Location = New System.Drawing.Point(8, 37)
        Me.computername.MaxDropDownItems = 12
        Me.computername.Name = "computername"
        Me.computername.Size = New System.Drawing.Size(130, 24)
        Me.computername.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(4, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(14, 15)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        '
        'gpoContextMenu
        '
        Me.gpoContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.script_openContainer, Me.EditToolStripMenuItem})
        Me.gpoContextMenu.Name = "gpoContextMenu"
        Me.gpoContextMenu.Size = New System.Drawing.Size(198, 48)
        '
        'script_openContainer
        '
        Me.script_openContainer.Name = "script_openContainer"
        Me.script_openContainer.Size = New System.Drawing.Size(197, 22)
        Me.script_openContainer.Text = "Open containing folder"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'mnuProcGoogle
        '
        Me.mnuProcGoogle.Name = "mnuProcGoogle"
        Me.mnuProcGoogle.Size = New System.Drawing.Size(133, 22)
        Me.mnuProcGoogle.Text = "google..."
        '
        'ProcContextMenu
        '
        Me.ProcContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.procMenuHeader, Me.ToolStripSeparator24, Me.PropertiesToolStripMenuItem, Me.ToolStripSeparator26, Me.mnuProcKill, Me.mnuProcGoogle, Me.mnuCopyPath})
        Me.ProcContextMenu.Name = "ProcContextMenu"
        Me.ProcContextMenu.Size = New System.Drawing.Size(134, 126)
        '
        'procMenuHeader
        '
        Me.procMenuHeader.ForeColor = System.Drawing.Color.SteelBlue
        Me.procMenuHeader.Name = "procMenuHeader"
        Me.procMenuHeader.Size = New System.Drawing.Size(133, 22)
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(130, 6)
        '
        'PropertiesToolStripMenuItem
        '
        Me.PropertiesToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem"
        Me.PropertiesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PropertiesToolStripMenuItem.Text = "Properties"
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(130, 6)
        '
        'mnuProcKill
        '
        Me.mnuProcKill.Image = Global.CMC.My.Resources.Resources.cancel
        Me.mnuProcKill.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuProcKill.Name = "mnuProcKill"
        Me.mnuProcKill.Size = New System.Drawing.Size(133, 22)
        Me.mnuProcKill.Text = "kill process"
        '
        'mnuCopyPath
        '
        Me.mnuCopyPath.Name = "mnuCopyPath"
        Me.mnuCopyPath.Size = New System.Drawing.Size(133, 22)
        Me.mnuCopyPath.Text = "copy path"
        '
        'swContextmenu
        '
        Me.swContextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSwName, Me.ToolStripSeparator23, Me.mnuSwProps, Me.mnuSwUninst})
        Me.swContextmenu.Name = "swContextmenu"
        Me.swContextmenu.Size = New System.Drawing.Size(128, 76)
        '
        'mnuSwName
        '
        Me.mnuSwName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.mnuSwName.Name = "mnuSwName"
        Me.mnuSwName.Size = New System.Drawing.Size(127, 22)
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(124, 6)
        '
        'mnuSwProps
        '
        Me.mnuSwProps.Name = "mnuSwProps"
        Me.mnuSwProps.Size = New System.Drawing.Size(127, 22)
        Me.mnuSwProps.Text = "Properties"
        '
        'mnuSwUninst
        '
        Me.mnuSwUninst.Name = "mnuSwUninst"
        Me.mnuSwUninst.Size = New System.Drawing.Size(127, 22)
        Me.mnuSwUninst.Text = "Uninstall"
        '
        'Form1
        '
        Me.AcceptButton = Me.GO_Button
        Me.AccessibleName = "computer management console"
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(382, 397)
        Me.Controls.Add(Me.computername)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.GO_Button)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.vncinstall)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.PingButton)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.altPassword_TextBox)
        Me.Controls.Add(Me.altusername_TextBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Tabholder1)
        Me.Controls.Add(Me.notification_label)
        Me.Controls.Add(Me.AltUserCheckBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Computer Management Console"
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.svccontextmenu.ResumeLayout(False)
        CType(Me.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Panel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.options.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.about.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.message.ResumeLayout(False)
        Me.message.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.aduser.ResumeLayout(False)
        Me.adpanel.ResumeLayout(False)
        Me.adpanel.PerformLayout()
        Me.profileGroupBox.ResumeLayout(False)
        Me.profileGroupBox.PerformLayout()
        Me.tsGroupBox.ResumeLayout(False)
        Me.tsGroupBox.PerformLayout()
        Me.PasswordGroupBox.ResumeLayout(False)
        Me.PasswordGroupBox.PerformLayout()
        Me.tools.ResumeLayout(False)
        Me.joinGroupbox.ResumeLayout(False)
        Me.joinGroupbox.PerformLayout()
        Me.RenameGroupBox.ResumeLayout(False)
        Me.RenameGroupBox.PerformLayout()
        Me.software.ResumeLayout(False)
        Me.software.PerformLayout()
        CType(Me.sgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.processes.ResumeLayout(False)
        Me.processes.PerformLayout()
        CType(Me.processgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.services.ResumeLayout(False)
        Me.services.PerformLayout()
        CType(Me.svc_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.network.ResumeLayout(False)
        Me.network.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.os.ResumeLayout(False)
        Me.os.PerformLayout()
        Me.Hardware.ResumeLayout(False)
        Me.Hardware.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Tabholder1.ResumeLayout(False)
        Me.printers.ResumeLayout(False)
        Me.printers.PerformLayout()
        CType(Me.printerGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mappeddrivesGroupBox.ResumeLayout(False)
        Me.mappeddrivesGroupBox.PerformLayout()
        Me.gpo.ResumeLayout(False)
        Me.gpo.PerformLayout()
        CType(Me.GPODataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.deploy.ResumeLayout(False)
        Me.deploy.PerformLayout()
        Me.startup.ResumeLayout(False)
        Me.startup.PerformLayout()
        CType(Me.startupDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.test.ResumeLayout(False)
        Me.test.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.printermenu.ResumeLayout(False)
        Me.gpoContextMenu.ResumeLayout(False)
        Me.ProcContextMenu.ResumeLayout(False)
        Me.swContextmenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load Form"

    'Private worker As BackgroundWorker
    Protected Friend PC As pc
    Protected Friend cmcUser As New cmcUser
    Protected Friend wmi As wmiConnection
    Protected Friend ConnectionExists As Boolean = False
    Private PingOK As Boolean

    Public TraceLog As System.IO.TextWriter
    Protected Friend LogFilePath As String
    Private psexecfile As String
    Private FormCleared As Boolean
    Private VNC_INSTALL_RUNNING As Boolean = False
    Private iTabIndex As Integer

    ' Load Application and get settings
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Version
        Me.version.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)

        ' allow cross thread calls
        Control.CheckForIllegalCrossThreadCalls = False

        ' load settings
        LoadSettings()

        ' Load History
        LoadHistory()

        '' Log File
        'LogFilePath = sLogFilePath.Text

        If System.IO.File.Exists(LogFilePath) Then
            TraceLog = System.IO.File.AppendText(LogFilePath)
            TraceLog.Close()
        Else
            TraceLog = System.IO.File.CreateText(LogFilePath)
            TraceLog.Close()
        End If


        ' Check whether ZENworks tool should be enabled
        If My.Computer.FileSystem.FileExists("c://novell//consoleone//1.2//bin//desktop4.exe") Then
            zenToolStripButton.Enabled = True
        End If


        ' Get CMC user details
        netdomname.Text = cmcUser.username
        joindomuser.Text = cmcUser.username
        If Not cmcUser.userdomain = "no domain found" Then groupToAdd.Text = cmcUser.userdomain & "\Domain Admins"


        ' Specify form settings for testing..
        If InStr(LCase(cmcUser.username), "forman") Then
            TestToolStripMenuItem.Visible = True
            SetPrinterAsDefaultToolStripMenuItem.Visible = True
        Else
            TestToolStripMenuItem.Visible = False
            Tabholder1.TabPages.RemoveAt(14)
            sw_use_wmi_checkbox.Visible = False
        End If


        ' Get computername as startup argument
        '        cmc.exe \\computer </u:username> </p:password> </r>

        If Environment.GetCommandLineArgs().Length > 1 Then
            Dim i As Integer
            For i = 1 To Environment.GetCommandLineArgs().Length - 1
                Select Case LCase(Mid(Environment.GetCommandLineArgs(i).ToString, 1, 2))
                    Case "/?"
                        MsgBox("cmc.exe \\computer [/u:username] [/p:password] [/r]" & vbCrLf & vbCrLf & _
                        "/u:username: user with admin rights on remote computer" & vbCrLf & _
                        "/p:password: password for user on remote computer" & vbCrLf & _
                        "/r - retrieve information", MsgBoxStyle.Information, "CMC: Usage")
                        Exit Select
                        Exit Sub
                    Case "\\"
                        computername.Text = Mid(Environment.GetCommandLineArgs(i), 3, Environment.GetCommandLineArgs(i).Length - 2)
                    Case "/u"
                        AltUserCheckBox.Checked = True
                        altusername_TextBox.Text = Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3)
                    Case "/p"
                        altPassword_TextBox.Text = Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3)
                End Select
            Next
        End If


        Me.AcceptButton = GO_Button
        FormCleared = True


        'worker = New BackgroundWorker()
        ''        worker.WorkerReportsProgress = True
        'AddHandler worker.DoWork, New DoWorkEventHandler(AddressOf Main)
        ''AddHandler worker.RunWorkerCompleted, New RunWorkerCompletedEventHandler(AddressOf OnWorkCompleted)
        ''AddHandler worker.ProgressChanged, New ProgressChangedEventHandler(AddressOf OnProgressChanged)

    End Sub
    Public Sub LoadSettings()

        ' Tab Checkboxes
        If My.Settings.hw = True Then
            defHW.Checked = True
        Else
            defHW.Checked = False
        End If
        If My.Settings.nw = True Then
            defNW.Checked = True
        Else
            defNW.Checked = False
        End If
        If My.Settings.sv = True Then
            defSV.Checked = True
        Else
            defSV.Checked = False
        End If
        If My.Settings.pr = True Then
            defPR.Checked = True
        Else
            defPR.Checked = False
        End If



        ' psexec.exe location

        Dim defaultpath As String = My.Application.Info.DirectoryPath.ToLower & "\files\psexec.exe"
        If System.Diagnostics.Debugger.IsAttached Then
            defaultpath = defaultpath.Replace("cmc\bin\files", "cmc\resources\files")
        End If

        psexecpath.Text = My.Settings.psexecpath
        If psexecpath.Text = "" Then
            If System.IO.File.Exists(defaultpath) Then
                My.Settings.psexecpath = defaultpath
                psexecpath.Text = defaultpath
                psexecfile = Chr(34) & defaultpath & Chr(34)
            ElseIf System.IO.File.Exists(Environment.ExpandEnvironmentVariables("%systemroot%") & "\system32\psexec.exe") Then
                My.Settings.psexecpath = Environment.ExpandEnvironmentVariables("%systemroot%") & "\system32\psexec.exe"
                psexecpath.Text = Environment.ExpandEnvironmentVariables("%systemroot%") & "\system32\psexec.exe"
                psexecfile = Chr(34) & psexecpath.Text & Chr(34)
            Else
                psexecfile = ""
            End If
        Else
            If System.IO.File.Exists(psexecpath.Text) Then
                psexecfile = Chr(34) & psexecpath.Text & Chr(34)
            Else
                psexecfile = ""
                psexecpath.Text = ""
            End If
        End If


        ' Ensure default alt username and password exist.

        Dim rKey As RegistryKey = Registry.CurrentUser.OpenSubKey("software\Forman")
        If rKey Is Nothing Then
            ' App regkey does not exist, so create key.
            Registry.CurrentUser.OpenSubKey("Software", True).CreateSubKey("Forman")
            ' create default history size now as this is the only time it will be set
            Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("HistorySize", 40, RegistryValueKind.DWord)
        End If


        ' check individual values exist

        Dim rUser As String = String.Empty
        Dim rPass As String = String.Empty
        Dim rLog As String = String.Empty

        ' Alt Username
        rUser = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("Alt1")
        If rUser Is Nothing Then
            ' value does not exist
            Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("Alt1", EncryptText.EncryptText("Administrator"), RegistryValueKind.String)
        End If
        SettingAltUser.Text = EncryptText.DecryptText(Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("Alt1"))


        ' Alt Password
        rPass = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("Alt2")
        If rPass Is Nothing Then
            ' value does not exist
            Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("Alt2", "to/0Po8O6rOkIx0Rp/F98A==", RegistryValueKind.String)
        End If
        SettingAltPass.Text = EncryptText.DecryptText(Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("Alt2"))


        ' LogFile Path
        rLog = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("LogFile")
        If rLog Is Nothing Then
            ' value does not exist
            Dim Path As String = Environment.ExpandEnvironmentVariables("%appdata%") & "\CMC\cmc_log.txt"
            If Not Directory.Exists(Environment.ExpandEnvironmentVariables("%appdata%") & "\CMC") Then
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables("%appdata%") & "\CMC")
            End If
            Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("LogFile", Path, RegistryValueKind.String)
        End If
        Me.LogFilePath = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("LogFile")


    End Sub

#End Region

    ' Computername Changed Code
    Private Sub computername_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles computername.TextChanged
        If Not FormCleared Then ClearBoxes()
        Me.AcceptButton = Me.GO_Button
    End Sub

    ' Alternative Credentials
    Protected Friend sAltUsername As String
    Protected Friend sAltPassword As String
    Protected Friend sAltDomain As String
    Protected Friend sAltDomainUser As String
    Private Sub AltUserCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltUserCheckBox.CheckedChanged
        If AltUserCheckBox.Checked Then
            altPassword_TextBox.UseSystemPasswordChar = True
            altusername_TextBox.Enabled = True
            altPassword_TextBox.Enabled = True
            altPassword_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular)
            altusername_TextBox.BackColor = Color.LightSkyBlue 'Color.PaleGoldenrod
            altPassword_TextBox.BackColor = Color.LightSkyBlue 'Color.PaleGoldenrod
            altusername_TextBox.Text = SettingAltUser.Text
            altPassword_TextBox.Text = SettingAltPass.Text
            If GO_Button.Text <> "" Then GO_Button.Enabled = True
        Else
            altusername_TextBox.Text = "username"
            altPassword_TextBox.Text = "password"
            altPassword_TextBox.UseSystemPasswordChar = False
            altusername_TextBox.Enabled = False
            altPassword_TextBox.Enabled = False
            altPassword_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular)
            altusername_TextBox.BackColor = Color.WhiteSmoke
            altPassword_TextBox.BackColor = Color.WhiteSmoke
        End If

    End Sub
    Private Sub altusername_TextBox_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles altusername_TextBox.MouseHover
        Me.ToolTip1.Show("Enter Alternate Credentials. eg:" & vbCrLf & "<username>" & vbCrLf & "<domain>\<username> or" & vbCrLf & "<username>@<domain>", Me.altusername_TextBox)
    End Sub
    Private Sub altusername_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altusername_TextBox.TextChanged
        notification_label.Text = ""
        CheckAltUserCredentials()
    End Sub
    Private Sub altPassword_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles altPassword_TextBox.TextChanged

        GO_Button.Enabled = True
        notification_label.Text = ""
        CheckAltUserCredentials()

    End Sub
    Private Sub CheckAltUserCredentials()

        If AltUserCheckBox.Checked = True Then

            If InStr(altusername_TextBox.Text, "\") Then
                Dim domuser() As String = Split(altusername_TextBox.Text, "\")
                Me.sAltDomainUser = domuser(1)
                Me.sAltDomain = domuser(0)
                Me.sAltUsername = Trim(altusername_TextBox.Text)
                Me.sAltPassword = Trim(altPassword_TextBox.Text)
            ElseIf InStr(altusername_TextBox.Text, "@") Then
                Dim domuser() As String = Split(altusername_TextBox.Text, "@")
                Me.sAltDomainUser = domuser(0)
                Me.sAltDomain = domuser(1)
                Me.sAltUsername = Trim(altusername_TextBox.Text)
                Me.sAltPassword = Trim(altPassword_TextBox.Text)
            Else
                Me.sAltUsername = PC.Name & "\" & Trim(altusername_TextBox.Text)
                Me.sAltPassword = Trim(altPassword_TextBox.Text)
                Me.sAltDomain = PC.Name
                Me.sAltDomainUser = Trim(altusername_TextBox.Text)
            End If

        Else
            Me.sAltUsername = ""
            Me.sAltPassword = ""
            Me.sAltDomain = ""
            Me.sAltDomainUser = ""
        End If

    End Sub

    ' ping check
    Private Sub PingButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PingButton.Click

        FormCleared = False
        GO_Button.Enabled = False

        If PingClass.TryPing(Trim(computername.Text)) Then
            PC = New pc
            PC.Name = Trim(computername.Text)
            Panel2.Text = "ping successful"
            MicrosoftMMCToolStripMenuItem.Enabled = True
            RemoteControlToolStripMenuItem.Enabled = True
            rdpToolStripButton.Enabled = True
            ToolStrip1.Enabled = True
            vncinstall.Enabled = True
            TelnetMenu.Enabled = True
            MSinfoToolStripMenuItem.Enabled = True
            WindRegMenuItem.Enabled = True
        Else
            Panel2.Text = "connection failed. check the computer is online."
        End If

        GO_Button.Enabled = True

    End Sub

    ' GO BUTTON....

    Private Sub GO_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GO_Button.Click
        Me.Cursor = Cursors.WaitCursor
        computername.Text = Trim(computername.Text.ToLower)
        Me.computername.Refresh()

        PC = New pc
        PC.Name = computername.Text

        ' clear the form
        If FormCleared = False Then ClearBoxes()
        GO_Button.Enabled = False

        Panel2.Text = "connecting..."

        If Not PingClass.TryPing(PC.Name) Then
            Panel2.Text = "connection failed. check the computer is online."
        Else
            PC.IPAddress = Label_IP.Text

            CheckAltUserCredentials()

            Main()

            Me.AddToHistory(PC.Name)
            Me.SaveHistory()
            ' re-select new entry & refresh
            computername.Text = PC.Name
            computername.Refresh()

            SaveToolStripMenuItem.Enabled = True
            AppendToolStripMenuItem.Enabled = True
            FormCleared = False
        End If

        GO_Button.Enabled = True
        'GO_Button.Focus()
        Me.Refresh()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Main() '(ByVal sender As Object, ByVal e As DoWorkEventArgs)


        ' start timing
        Dim start, totaltime As Double
        start = Microsoft.VisualBasic.DateAndTime.Timer


        ' Make WMI Connection
        Panel2.Text = "connecting to wmi....."
        wmi = New wmiConnection

        If wmi.WMIConnect(PC.Name) = False Then
            Dim tmpstring As String = notification_label.Text
            ClearBoxes()
            notification_label.Text = tmpstring
            tmpstring = Nothing
            Panel2.Text = "wmi connect failed"
            Exit Sub
        End If

        ConnectionExists = True
        Panel2.Text = "wmi connection made, requesting data..."


        '=================================================================

        Dim bMultiThread As Boolean
        If MultiThreadMenuItem.Checked Then
            bMultiThread = False
        Else
            bMultiThread = True
        End If

        ' Retrieve WMI information

        Dim OSThread As New System.Threading.Thread(AddressOf OS_and_User)
        Dim ieThread As New System.Threading.Thread(AddressOf getIE)

        If bMultiThread Then
            OSThread.Start()
        Else
            OS_and_User()
        End If

        ' Get Shares
        refreshShares()

        '==============    Get IE version    =============================

        If bMultiThread Then
            ieThread.Start()
        Else
            getIE()
        End If

        '==============    Hardware , Network, Services, Processes   ===================================

        If My.Settings.hw Then gethardware()
        If My.Settings.nw Then WMINetwork()
        If My.Settings.sv Then GetSVClist()
        If My.Settings.pr Then GetProcesses()

        '=================================================================
        ' map IPC$ share

        If AltUserCheckBox.Checked Then _
                Shell("net use \\" & PC.Name & "\ipc$ /USER:" & Me.sAltUsername & " " & Me.sAltPassword, 0, False)


        '=================================================================
        EnableButtons()

        '=================================================================

        ' Rejoin threads
        If bMultiThread Then
            Try
                OSThread.Join()
            Catch ex As Exception
            End Try
            Try
                ieThread.Join()
            Catch ex As Exception
            End Try
        End If

        '===============  Finished  ======================================
        totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - start, 4)

        'Me.AddToHistory(PC.Name)
        'Me.SaveHistory()
        '' re-select new entry & refresh
        'computername.Text = PC.Name
        'computername.Refresh()
        'GO_Button.Focus()

        WriteLog(PC.Name & " - connection time: " & totaltime.ToString)
        'GO_Button.Enabled = True
        'SaveToolStripMenuItem.Enabled = True
        'AppendToolStripMenuItem.Enabled = True
        'FormCleared = False
        Panel2.Text = "ready"
        Panel3.Text = totaltime & "s"


    End Sub

#Region "OS"

    ''' <summary>
    ''' Calls GetOS and GetUser.
    ''' Call GetProxy using impersonation if required.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OS_and_User()
        GetOS()
        GetUser()

        If PC.CurrentUser <> "" Then
            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    GetProxy()
                    impersonator.undoImpersonation()
                End If
            Else
                GetProxy()
            End If
        End If

    End Sub

    ''' <summary>
    ''' Retrieve operating system and domain information.
    '''   Win32_OperatingSystem
    '''   Win32_ComputerSystem
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetOS()

        On Error Resume Next
        Dim lastboot As String = Nothing
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery _
        ("SELECT Caption, Lastbootuptime, version, csdversion, csname, SystemDirectory FROM Win32_OperatingSystem")

        For Each m In queryCollection
            PC.Hostname = UCase(m("csname"))
            PC.LastBootTime = m("LastBootUpTime")
            PC.OSVersion = m("Version")
            PC.ServicePack = m("CSDVersion")
            PC.OperatingSystem = m("Caption")
            PC.SystemDirectory = LCase(m("SystemDirectory"))
        Next

        Label_OS.Text = Replace(PC.OperatingSystem, "(R)", "")
        Label_Ver.Text = PC.OSVersion
        Label_SP.Text = PC.ServicePack
        Label_Name.Text = PC.Hostname
        Label_Boot.Text = PC.LastBootTime


        If TSEnabled(PC.Name) Then
            DisableRDPToolStripMenuItem.Enabled = True
            'rdpToolStripButton.Enabled = True
            PC.TSEnabled = True
        Else
            EnableRDPToolStripMenuItem.Enabled = True
            'rdpToolStripButton.Enabled = False
            PC.TSEnabled = False
        End If


        If Not IsValidIPAddress(PC.Name) AndAlso Not (LCase(PC.Name) = LCase(PC.Hostname)) Then
            Label_Name.BackColor = Color.Orange
        End If

        Dim _role As Integer
        queryCollection = wmi.wmiQuery("SELECT Domain,DomainRole,TotalPhysicalMemory FROM Win32_ComputerSystem")
        For Each m In queryCollection
            _role = m("DomainRole")
            PC.DomainRole = _role
            PC.DomainName = m("Domain")
            If _role = 0 OrElse _role = 2 Then
                domainlabel.Text = "workgroup:"
                GPUpdateToolStripMenuItem.Enabled = False
            Else
                domainlabel.Text = "domain:"
                GPUpdateToolStripMenuItem.Enabled = True
            End If
            PC.PhysicalMemory = CInt(m("TotalPhysicalMemory") / 1024 / 1024)
        Next

        ' write hostname to logfile if IP address used
        If InStr(PC.Name, ".") <> 0 Then
            WriteLog(PC.Name & " - Hostname: " & PC.Hostname)
        End If

    End Sub
    Private Sub GetUser()

        Dim path As String = "Software\Microsoft\Windows NT\CurrentVersion\Winlogon"

        If IsProcessRunning("explorer.exe") Then
            If PC.OSVersionNumeric > 5 Then
                Label_User.Text = ProcessOwner("explorer.exe")
                ' check for error
                If Label_User.Text = "\" Then
                    PC.CurrentUser = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, path, "DefaultUserName")
                    PC.CurrentUserDomain = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, path, "DefaultDomainName")
                    Label_User.Text = PC.CurrentUserDomain & "\" & PC.CurrentUser
                End If
            Else
                PC.CurrentUser = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, path, "DefaultUserName")
                PC.CurrentUserDomain = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, path, "DefaultDomainName")
                Label_User.Text = PC.CurrentUserDomain & "\" & PC.CurrentUser
            End If
            ' enable gpupdate user-side menu
            BothComputerAndUserToolStripMenuItem.Enabled = True
            OnlyUserToolStripMenuItem.Enabled = True

            WriteLog(PC.Name & " - logged on user: " & Label_User.Text)
            mappeddrivesGroupBox.Text = "persistent mapped drives  [" & LCase(PC.CurrentUser) & "]"
            mappeddrivesGroupBox.Enabled = True
            PC.LastLogon = ""
        Else
            Label_User.Text = "no one is logged on"
            ' disable gpupdate buttons for user accounts
            BothComputerAndUserToolStripMenuItem.Enabled = False
            OnlyUserToolStripMenuItem.Enabled = False

            PC.CurrentUser = ""
            PC.CurrentUserDomain = ""
            WriteLog(PC.Name & " - no one logged on")
            mappeddrivesGroupBox.Text = "persistent mapped drives"
            mappeddrivesGroupBox.Enabled = False
            ielabel.ForeColor = System.Drawing.SystemColors.ControlText

            ' Read last user logon from registry
            Dim lDomain As String = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, path, "DefaultDomainName")
            Dim lUser As String = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, path, "DefaultUserName")

            ' if still no last logon values returned then try using api vb call rather than wmi
            If String.IsNullOrEmpty(lDomain) Then
                If AltUserCheckBox.Checked Then
                    Dim impersonator As New Impersonation
                    If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                        lUser = GetLastLogon()
                        impersonator.undoImpersonation()
                    End If
                Else
                    lUser = GetLastLogon()
                End If
            End If


            If lUser.Contains("\") Then
                PC.LastLogon = lUser
            Else
                If String.IsNullOrEmpty(lDomain) = False AndAlso String.IsNullOrEmpty(lUser) = False Then
                    PC.LastLogon = lDomain & "\" & lUser
                End If
            End If

        End If

        ' check for running screensaver
        Dim scr_running As Boolean = False
        Try
            Dim m As ManagementObject
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("SELECT Name FROM Win32_Process")
            For Each m In queryCollection
                Dim procName As String = m("Name").ToString.ToLower
                If procName.Substring(procName.Length - 4) = ".scr" Then
                    scr_running = True
                    Exit For
                End If
            Next
        Catch ex As Exception
        End Try

        If scr_running Then
            Label_User.BackColor = Color.LightGray
        Else
            Label_User.BackColor = Color.LightYellow
        End If

        ' enable adbutton if domain matches
        'If LCase(PC.CurrentUserDomain) = LCase(cmcUser.userdomain) And cmcUser.dnsdomain <> "" Then
        If Label_User.Text = "no one is logged on" Then
            adbutton.Enabled = False
        Else
            If Not String.IsNullOrEmpty(PC.CurrentUserDomain) Then
                If PC.CurrentUserDomain.ToLower <> PC.Name.ToLower Then
                    adbutton.Enabled = True
                    samaccountname.Text = PC.CurrentUserDomain & "\" & PC.CurrentUser
                End If
            End If
        End If

    End Sub

    ''' <summary>
    ''' Use VB registry call to retrieve last logon information
    ''' </summary>
    ''' <returns>domain\user</returns>
    ''' <remarks></remarks>
    Private Function GetLastLogon() As String
        Dim strkeyPath As String = "Software\Microsoft\Windows NT\CurrentVersion\Winlogon"
        Try
            Dim user As String = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC.Name).OpenSubKey(strkeyPath).GetValue("DefaultUserName")
            Dim domain As String = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC.Name).OpenSubKey(strkeyPath).GetValue("DefaultDomainName")
            If String.IsNullOrEmpty(user) AndAlso (String.IsNullOrEmpty(domain) = False) Then
                user = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC.Name).OpenSubKey(strkeyPath).GetValue("AltDefaultUserName")
            End If
            Return domain & "\" & user
        Catch ex As Exception
            Return String.Empty
        End Try
        
    End Function

    ''' <summary>
    ''' Read IE Version from the registry.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub getIE()
        Try
            PC.IEVersion = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\Microsoft\Internet Explorer", "Version")
            If ielabel.Text.ToLower = "ie version" Then ie.Text = PC.IEVersion
        Catch ex As Exception
            WriteLog(PC.Name & " - error retrieving ie information: " & ex.Message)
        End Try
    End Sub
    ' ie proxy - does not check whether use proxy option checked - xp + only
    'Private Sub IEProxy()
    '    Try
    '        Dim proxyport As String = ""
    '        Dim proxyserver As String = ""
    '        Dim m As ManagementObject
    '        Dim queryCollection As ManagementObjectCollection
    '        queryCollection = wmi.wmiQuery("SELECT ProxyServer, ProxyPortNumber FROM Win32_Proxy")
    '        For Each m In queryCollection
    '            proxyport = m("ProxyPortNumber").ToString
    '            proxyserver = m("ProxyServer").ToString
    '        Next
    '        If proxyport <> "" Or proxyserver <> "" Then
    '            Me.proxy = proxyserver & ":" & proxyport
    '        Else
    '            Me.proxy = ""
    '        End If
    '    Catch ex As Exception
    '        WriteLog(pc.name & " - error getting proxy. " & ex.Message)
    '        Me.proxy = ""
    '    End Try
    'End Sub

    Private Sub ielabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ielabel.Click

        If String.IsNullOrEmpty(PC.Name) Then Exit Sub

        On Error Resume Next
        'If PC.IEProxy = "" Then Exit Sub
        If ielabel.Text = "ie version" Then
            ielabel.Text = "proxy"
            ie.Text = PC.IEProxy
            proxyset.Visible = True
        ElseIf ielabel.Text.ToLower = "proxy" Then
            ielabel.Text = "ie version"
            ie.Text = PC.IEVersion
            proxyset.Visible = False
        End If
    End Sub
    Private Sub ie_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ie.MouseEnter
        If PC.Name = Nothing OrElse PC.IEProxy = "" Then Exit Sub
        If ielabel.Text.ToLower = "ie version" Then ie.Text = PC.IEProxy
    End Sub
    Private Sub ie_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ie.MouseLeave
        If PC.Name = Nothing OrElse PC.IEProxy = "" Then Exit Sub
        If ielabel.Text = "ie version" Then
            ie.Text = PC.IEVersion
        End If
    End Sub

    Private Sub GetProxy()

        If PC.CurrentUserSID = "" Then
            'WriteLog(PC.Name & " - NO SID - Calling GetSID")
            PC.CurrentUserSID = GetSID(PC.CurrentUser)
            ielabel.Text = "ie version"
            proxyset.Visible = False
            Exit Sub
        End If

        Dim strkeyPath As String = _
            PC.CurrentUserSID & "\SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings"

        Try

            If RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name).OpenSubKey(strkeyPath).GetValue("ProxyEnable") = 1 Then
                PC.IEProxy = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name).OpenSubKey(strkeyPath).GetValue("ProxyServer")
                ielabel.ForeColor = Color.DodgerBlue
            Else
                PC.IEProxy = ""
                ielabel.ForeColor = System.Drawing.SystemColors.ControlText
            End If

        Catch ex As Exception
            PC.IEProxy = ""
            ielabel.ForeColor = System.Drawing.SystemColors.ControlText
            Exit Sub
        End Try

        If ielabel.Text = "Proxy" Then
            ie.Text = PC.IEProxy
            proxyset.Visible = True
        Else
            proxyset.Visible = False
        End If

    End Sub
    Private Sub SetProxy(ByVal proxyserver As String)

        If PC.CurrentUserSID = "" Then Exit Sub

        Dim UseProxy As Integer
        If Trim(proxyserver) = "" Then
            UseProxy = 0
        Else
            UseProxy = 1
        End If


        Dim strkeyPath As String = _
            PC.CurrentUserSID & "\SOFTWARE\Microsoft\Windows\CurrentVersion\Internet Settings"

        RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
        OpenSubKey(strkeyPath, True).SetValue("ProxyEnable", UseProxy, RegistryValueKind.DWord)
        If UseProxy = 1 Then RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
        OpenSubKey(strkeyPath, True).SetValue("ProxyServer", proxyserver, RegistryValueKind.String)

        PC.IEProxy = ie.Text

    End Sub
    Private Sub proxyset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proxyset.Click
        If ie.Text.Length <> 0 AndAlso InStr(ie.Text, ":") = 0 Then
            MsgBox("proxy server should be in the form:" & vbCrLf & "<server>:<port>")
        Else
            Try
                If AltUserCheckBox.Checked Then
                    Dim impersonator As New Impersonation
                    If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                        SetProxy(ie.Text)
                        impersonator.undoImpersonation()
                    End If
                Else
                    SetProxy(ie.Text)
                End If

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub ListBox_Shares_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox_Shares.MouseHover
        Me.ToolTip1.Show("double click to open selected share", Me.ListBox_Shares)
    End Sub
    Private Sub ListBox_Shares_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox_Shares.SelectedIndexChanged
        Dim arrShare As Array = Split(ListBox_Shares.SelectedItem, "\")
        Dim SelShare As String = LCase(arrShare(3))
        If SelShare.Length = 2 Or SelShare = "admin$" Then
            delete_Share.Enabled = False
        Else
            delete_Share.Enabled = True
        End If
    End Sub
    Private Sub Button_openshare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_openshare.Click
        openfolder(ListBox_Shares.SelectedItem)
        WriteLog(PC.Name & " - " & ListBox_Shares.SelectedItem & " accessed")
    End Sub
    Private Sub ListBox_Shares_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListBox_Shares.MouseDoubleClick
        openfolder(ListBox_Shares.SelectedItem)
        WriteLog(PC.Name & " - " & ListBox_Shares.SelectedItem & " accessed")
    End Sub
    Private Sub addshare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addshare.Click
        Shell("SHRPUBW.EXE /s " & PC.Name, AppWinStyle.NormalFocus, True)
        'ShareDir(pc.name, "C:\Script", "Scripts", "Pete's Scripts")
        refreshShares()
    End Sub
    ' wmi method to add share - not in use
    Private Sub ShareDir(ByVal Server As String, ByVal path As String, _
        ByVal sharename As String, ByVal description As String)

        Dim wmiShare As ManagementClass
        Dim inParams As ManagementBaseObject
        Dim outParams As ManagementBaseObject
        Try
            wmiShare = New ManagementClass(wmiConnection.wmiScope, New ManagementPath("Win32_Share"), Nothing)
            inParams = wmiShare.GetMethodParameters("Create")
            inParams("Path") = path
            inParams("Name") = sharename
            inParams("Type") = 0
            inParams("MaximumAllowed") = Nothing
            inParams("Description") = description
            outParams = wmiShare.InvokeMethod("Create", inParams, Nothing)
        Catch e As Exception
            MsgBox(e.Message)
        End Try

    End Sub
    Private Sub delete_Share_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_Share.Click
        If MsgBox("Are you sure you want to delete" & vbCrLf & _
                "the selected share?", 36, "DELETE " & UCase(ListBox_Shares.SelectedItem) & " ?") = MsgBoxResult.Yes Then
            Dim arrShare As Array = Split(ListBox_Shares.SelectedItem, "\")
            Dim SelShare As String = LCase(arrShare(3))
            DeleteShare(SelShare)
            refreshShares()
        End If
    End Sub

    Private Sub DeleteShare(ByVal sShare As String)

        Try
            Dim queryCollection As ManagementObjectCollection
            Dim share As ManagementObject
            queryCollection = wmi.wmiQuery("SELECT name FROM Win32_Share where name='" & sShare & "'")

            For Each share In queryCollection
                share.Delete()
            Next

            WriteLog(PC.Name & " - Share deleted: " & sShare)
        Catch err As ManagementException
            WriteLog(PC.Name & " - An error occurred deleting share: " & sShare & " - " & err.Message)
        End Try

    End Sub
    Private Sub refreshShares()

        ListBox_Shares.Items.Clear()

        Try
            Dim sharecount As Integer = 0
            Dim m As ManagementObject
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("SELECT name FROM Win32_Share")

            For Each m In queryCollection
                If InStr(m("name").ToString, "IPC") = 0 Then
                    sharecount = sharecount + 1
                    If sharecount >= 50 Then
                        Panel2.Text = "share limit reached"
                        Exit For
                    End If
                    ListBox_Shares.Items.Add("\\" & PC.Name & "\" & m("Name").ToString)
                End If
            Next
        Catch ex As Exception
        End Try

        If ListBox_Shares.Items.Count > 0 Then Button_openshare.Enabled = True

    End Sub

    Private Sub ListBox_Shares_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox_Shares.MouseEnter
        ListBox_Shares.Focus()
    End Sub
    Private Sub ListBox_Shares_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox_Shares.MouseLeave
        GO_Button.Focus()
    End Sub

    ' Username stuff
    Private currentUser As String
    Private Sub Label_User_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_User.MouseEnter
        If Label_User.Text = "" Then Exit Sub
        Me.currentUser = Label_User.Text
        On Error Resume Next
        If PC.LastLogon <> "" Then
            Label_User.Text = "Last User: " & PC.LastLogon
        Else
            If Label_User.BackColor = Color.LightGray Then
                Label_User.Text = "screen saver running"
            End If
        End If
    End Sub
    Private Sub Label_User_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label_User.MouseLeave
        If Label_User.Text = "" Then Exit Sub
        On Error Resume Next
        If PC.LastLogon = "" Then
            If Label_User.BackColor = Color.LightGray Then
                'Label_User.Text = PC.CurrentUserDomain & "\" & PC.CurrentUser
            End If
            'Else
            '    Label_User.Text = "no one is logged on"
        End If
        Label_User.Text = Me.currentUser
        Me.currentUser = String.Empty
    End Sub
    Private Sub Label_User_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label_User.DoubleClick
        If FormCleared = True Then Exit Sub
        If Label_User.Text = "no one is logged on" Then Exit Sub
        If PC.CurrentUserSID = "" Then Exit Sub
        If InStr(Label_User.Text, "\") <> 0 Then
            Label_User.Text = PC.CurrentUserSID
        Else
            Label_User.Text = PC.CurrentUserDomain & "\" & PC.CurrentUser
        End If
    End Sub

    Private Sub ClearOS()
        Label_Name.Text = ""
        Label_User.Text = ""
        Label_Name.BackColor = System.Drawing.SystemColors.Window
        Label_User.BackColor = System.Drawing.SystemColors.Window
        Label_OS.Text = ""
        Label_SP.Text = ""
        Label_Ver.Text = ""
        Label_Boot.Text = ""
        ie.Text = ""
        ielabel.ForeColor = System.Drawing.SystemColors.ControlText
        proxyset.Visible = False
        ListBox_Shares.Items.Clear()
        Label_IP.Text = ""
        delete_Share.Enabled = False
    End Sub

#End Region

#Region "HARDWARE"

    Private Sub HWButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HWButton.Click

        Panel2.Text = "getting hardware information..."
        clearHW()
        Me.Cursor = Cursors.WaitCursor

        ' gather information
        gethardware()

        audio_label.Visible = True
        video_label.Visible = True
        Me.Cursor = Cursors.Default
        Panel2.Text = "ready"

    End Sub
    Public Sub gethardware()

        ' Query system for WMI information
        Dim queryCollection As ManagementObjectCollection
        Dim m As ManagementObject
        Dim propvalue As Object
        Dim strchassis As String

        'domainrole,partofdomain
        queryCollection = wmi.wmiQuery("SELECT Manufacturer,Model,TotalPhysicalMemory FROM Win32_ComputerSystem")
        Panel2.Text = "getting make and model..."
        Try
            For Each m In queryCollection
                If InStr(m("Manufacturer"), "Dell") <> 0 Then
                    makemodel.Text = "Dell " & Trim(m("Model"))
                Else
                    makemodel.Text = Trim(m("Manufacturer")) & " " & Trim(m("Model"))
                End If
                RAMBox.Text = Trim(Int(m("TotalPhysicalMemory") / (1024 * 1024))) & "MB"
            Next
        Catch ex As Exception
        End Try

        Try
            Panel2.Text = "getting cpu information..."
            queryCollection = wmi.wmiQuery("SELECT Name FROM Win32_Processor")
            For Each m In queryCollection
                cpuBox.Text = Replace(Replace(Replace(Trim(m("Name").ToString), "    ", ""), "(R)", ""), "(TM)", "")
            Next
        Catch
        End Try

        Panel2.Text = "getting drive information..."
        Try
            queryCollection = wmi.wmiQuery("SELECT name,size,freespace FROM Win32_LogicalDisk where DriveType = 3")
            For Each m In queryCollection
                hdCombo.Items.Add(m("Name").ToString & "   " & Int(m("Size") / 1073741824) & " GB total, " & Int(m("FreeSpace") / 1048576) & "MB Free")
                'Me.sDrivesInUse = Me.sDrivesInUse & m("Name").ToString
            Next
            hdCombo.SelectedIndex = 0
            If hdCombo.Items.Count > 1 Then
                hdCombo.BackColor = Color.PaleGoldenrod
            End If


            Panel2.Text = "getting enclosure type..."
            queryCollection = wmi.wmiQuery("SELECT SerialNumber,ChassisTypes FROM Win32_SystemEnclosure")
            For Each m In queryCollection
                SNoBox.Text = m("SerialNumber").ToString
                For Each propvalue In m("ChassisTypes")
                    strchassis = propvalue
                    Select Case strchassis
                        Case 1
                            chassis.Text = "Other"
                        Case 2
                            chassis.Text = "Unknown"
                        Case 3
                            chassis.Text = "Desktop"
                        Case 4
                            chassis.Text = "Low Profile Desktop"
                        Case 5
                            chassis.Text = "Pizza Box"
                        Case 6
                            chassis.Text = "Mini Tower"
                        Case 7
                            chassis.Text = "Tower"
                        Case 8
                            chassis.Text = "Portable"
                        Case 9
                            chassis.Text = "Laptop"
                        Case 10
                            chassis.Text = "Notebook"
                        Case 11
                            chassis.Text = "Handheld"
                        Case 12
                            chassis.Text = "Docking Station"
                        Case 13
                            chassis.Text = "All-in-One"
                        Case 14
                            chassis.Text = "Sub-Notebook"
                        Case 15
                            chassis.Text = "Space Saving"
                        Case 16
                            chassis.Text = "Lunch Box"
                        Case 17
                            chassis.Text = "Main System Chassis"
                        Case 18
                            chassis.Text = "Expansion Chassis"
                        Case 19
                            chassis.Text = "Sub-Chassis"
                        Case 20
                            chassis.Text = "Bus Expansion Chassis"
                        Case 21
                            chassis.Text = "Peripheral Chassis"
                        Case 22
                            chassis.Text = "Storage Chassis"
                        Case 23
                            chassis.Text = "Rack Mount Chassis"
                        Case 24
                            chassis.Text = "Sealed-Case PC"
                        Case Else
                            chassis.Text = "Unknown"
                    End Select
                Next
            Next
        Catch
        End Try
    End Sub

    ' cpu additional info
    Private Sub cpuBox_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cpuBox.MouseEnter
        If Not String.IsNullOrEmpty(cpuBox.Text) Then cpu_info_lbl.Visible = True
    End Sub
    Private Sub cpu_info_lbl_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cpu_info_lbl.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim output As String = String.Empty
            Dim m As ManagementObject
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("SELECT * FROM Win32_Processor")

            For Each m In queryCollection
                output = output & "Name: " & m("Name") & vbCrLf & _
                "Manufacturer: " & m("Manufacturer") & vbCrLf & _
                "Description: " & m("Description") & vbCrLf & _
                "CurrentClockSpeed: " & m("CurrentClockSpeed") & vbCrLf & _
                "CurrentVoltage: " & m("CurrentVoltage") & vbCrLf & _
                "DeviceID: " & m("DeviceID") & vbCrLf & _
                "Family: " & m("Family") & vbCrLf & _
                "L2CacheSize: " & m("L2CacheSize") & vbCrLf & _
                "MaxClockSpeed: " & m("MaxClockSpeed") & vbCrLf & _
                "ProcessorId: " & m("ProcessorId") & vbCrLf & _
                "Revision: " & m("Revision") & vbCrLf & _
                "SocketDesignation: " & m("SocketDesignation") & vbCrLf & _
                "Version: " & m("Version") & vbCrLf & vbCrLf
                'If m("NumberOfCores") > 1 Then
                '    output = m("NumberOfCores") & " Cores" & vbCr & vbCr & output
                '    Exit For
                'End If
                'MsgBox(m("NumberOfCores"))
            Next
            MsgBox(output, MsgBoxStyle.Information, "Processor Information")
        Catch

        Finally
            cpu_info_lbl.Visible = False
            Me.Cursor = Cursors.Default
        End Try



    End Sub
    ' video controller info
    Private Sub video_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles video_label.LinkClicked
        If Not FormCleared Then
            Me.Cursor = Cursors.WaitCursor
            video_info()
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub video_info()

        Try
            Dim output As String = String.Empty
            Dim m As ManagementObject
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("SELECT * FROM Win32_VideoController")

            Dim name As String = String.Empty
            Dim driver As String = String.Empty
            Dim driverversion As String = String.Empty
            Dim status As String = String.Empty
            Dim hRes As String = String.Empty
            Dim vRes As String = String.Empty
            Dim Bits As String = String.Empty
            Dim rRate As String = String.Empty

            For Each m In queryCollection
                name = m("Name") & vbCrLf
                If m("CurrentHorizontalResolution") <> Nothing Then
                    hRes = "H Res: " & m("CurrentHorizontalResolution").ToString & vbCrLf
                End If
                If m("CurrentVerticalResolution") <> Nothing Then
                    vRes = "V Res: " & m("CurrentVerticalResolution").ToString & vbCrLf
                End If
                If m("CurrentBitsPerPixel") <> Nothing Then
                    Bits = "Bits: " & m("CurrentBitsPerPixel").ToString & vbCrLf
                End If
                If m("CurrentRefreshRate") <> Nothing Then
                    rRate = "Refresh Rate: " & m("CurrentRefreshRate").ToString & vbCrLf
                End If
                driver = "Driver: " & m("InstalledDisplayDrivers") & vbCrLf
                driverversion = "Driver Version: " & m("DriverVersion") & vbCrLf
                status = "Status: " & m("Status") & vbCrLf
            Next
            output = name & hRes & vRes & Bits & rRate & driver & driverversion & status
            MsgBox(output, MsgBoxStyle.Information, PC.Name.ToUpper & " - Video Controller Information")
        Catch
        End Try

    End Sub
    ' sound
    Private Sub audio_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles audio_label.LinkClicked
        Me.Cursor = Cursors.WaitCursor
        sound_device()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub sound_device()
        On Error Resume Next
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("Select Name, Manufacturer from win32_SoundDevice")
        Dim output As String = ""
        Dim name As String = ""
        Dim maker As String = ""
        For Each m In queryCollection
            name = m("Name") & vbCrLf
            maker = m("Manufacturer") & vbCrLf
        Next
        If String.IsNullOrEmpty(name) AndAlso String.IsNullOrEmpty(maker) Then
            MsgBox("No information available.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, PC.Name.ToUpper & " - Sound Device")
        Else
            MsgBox("Name: " & name & vbCrLf & "Manufacturer: " & maker & vbCrLf, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, PC.Name.ToUpper & " - Sound Device")
        End If

    End Sub
    'faulty hardware
    Private Sub HWFault()
        Dim count As Integer = 0
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("select * from win32_pnpentity where ConfigManagerErrorCode <> 0")
        For Each m In queryCollection

        Next
        'objWMIService = GetObject("winmgmts:\\" & PC.Name & "\root\cimv2")
        'colItems = objWMIService.ExecQuery("select * from win32_pnpentity where ConfigManagerErrorCode <>0", , 48)

        'For Each objItem In colItems
        '    WScript.Echo("ConfigManagerErrorCode: " & objItem.ConfigManagerErrorCode)
        '    WScript.Echo("DeviceID: " & objItem.DeviceID)
        '    WScript.Echo("Manufacturer: " & objItem.Manufacturer)
        '    Name = m("Name")
        '    WScript.Echo("PNPDeviceID: " & objItem.PNPDeviceID)
        '    WScript.Echo("Service: " & objItem.Service)
        '    WScript.Echo("Status: " & objItem.Status)
        '    WScript.Echo("-------------------")
        'Next
    End Sub

    Private Sub clearHW()
        makemodel.Text = ""
        chassis.Text = ""
        SNoBox.Text = ""
        RAMBox.Text = ""
        cpuBox.Text = ""
        hdCombo.SelectedIndex = -1
        hdCombo.Items.Clear()
        hdCombo.BackColor = System.Drawing.SystemColors.Window
        cpu_info_lbl.Visible = False
        audio_label.Visible = False
        video_label.Visible = False
    End Sub

#End Region

#Region "NETWORK"
    Public Sub WMINetwork()
        IdentifyNetworkAdaptor()
        GetNetwork()
    End Sub
    Private Sub IdentifyNetworkAdaptor()

        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("Select IPAddress,MACAddress From Win32_NetworkAdapterConfiguration Where IPEnabled = True")
        Dim arrIP As Array
        Dim MAC As String = ""

        For Each m In queryCollection
            arrIP = m("IPAddress")
            For Each IP As String In arrIP
                If IP = PC.IPAddress Then
                    ipaddress.Text = IP
                    MAC = m("MacAddress")
                End If
            Next
        Next


        If String.IsNullOrEmpty(MAC) Then
            PC.MacAddress = ""
            Exit Sub
        Else
            PC.MacAddress = MAC
            macaddress.Text = MAC
        End If

        Try
            queryCollection = wmi.wmiQuery _
                ("Select Name,MACAddress,NetConnectionID,NetConnectionStatus From Win32_NetworkAdapter Where MACAddress = '" & _
                    PC.MacAddress & "' AND NetConnectionStatus = '2'")
            For Each m In queryCollection
                If m("NetConnectionID") IsNot Nothing Then
                    PC.NetworkAdaptorID = m("NetConnectionID")
                    AdaptorID.Text = PC.NetworkAdaptorID & vbCrLf & m("Name")
                Else
                    AdaptorID.Text = m("Name")
                End If
            Next
        Catch ex As System.Management.ManagementException
        End Try

    End Sub
    Private Sub GetNetwork()

        hostname.Text = PC.Hostname
        domain.Text = PC.DomainName

        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery _
        ("SELECT IPSubnet,DefaultIPGateway,DHCPEnabled,DHCPServer,DNSServerSearchOrder,DNSDomainSuffixSearchOrder " & _
            "FROM Win32_NetworkAdapterConfiguration Where MACAddress = '" & PC.MacAddress & "' AND IPEnabled = True")
        For Each m In queryCollection
            Try
                For Each SM As String In m("IPSubnet")
                    subnet.Text = SM
                Next
            Catch
            End Try

            Try
                For Each GW As String In m("DefaultIPGateway")
                    gateway.Text = GW
                Next
            Catch
            End Try

            Try

                If m("DHCPEnabled") = True Then
                    lblDhcp.Text = "DHCP Server : " & m("DHCPServer")
                    dhcpbutton.Visible = False
                    staticbutton.Visible = True
                Else
                    lblDhcp.Text = "Static Configuration"
                    dhcpbutton.Visible = True
                    staticbutton.Visible = False
                End If
            Catch
                lblDhcp.Text = ""
                dhcpbutton.Visible = False
                staticbutton.Visible = False
            End Try


            ' ----  dns servers   ------------------------------

            Try
                For Each dnsserver As String In m("DNSServerSearchOrder")
                    If dnsservers.Text = "" Then
                        dnsservers.Text = dnsserver
                    Else
                        dnsservers.Text = dnsservers.Text & "," & dnsserver
                    End If
                Next
            Catch
            End Try


            ' ----  dns suffix search order   ------------------------------

            sfxlist.Items.Clear()

            Try
                For Each suffix As String In m("DNSDomainSuffixSearchOrder")
                    sfxlist.Items.Add(suffix)
                Next
            Catch ex As System.NullReferenceException
                ' no entries
            End Try


            ' ----  dns suffix    ------------------------------------------

            suffix.Text = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, _
                "SYSTEM\CurrentControlSet\Services\Tcpip\Parameters", "Domain")

        Next
        staticdnsbutton.Enabled = True

    End Sub

    Private Sub networkupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles networkupdate.Click

        Me.Cursor = Cursors.WaitCursor
        ClearNetwork()
        IdentifyNetworkAdaptor()
        GetNetwork()
        Me.Cursor = Cursors.Default
        Panel2.Text = "ready"

    End Sub
    Private Sub staticdnsbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staticdnsbutton.Click

        Me.Cursor = Cursors.WaitCursor
        staticdnsbutton.Enabled = False
        Try
            If Trim(dnsservers.Text) = "" Then
                Dim strKeyPath As String = "SYSTEM\CurrentControlSet\Services\Tcpip\Parameters"
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, strKeyPath, "NameServer", "")
                staticdnsbutton.Enabled = True
                Me.Cursor = Cursors.Default
            Else
                Dim Servers As String = Replace(dnsservers.Text, " ", "")
                Dim arrServers As Array = Split(Servers, ",")
                Dim i As Integer
                For i = 0 To arrServers.Length - 1
                    If IsValidIPAddress(arrServers(i)) = False Then
                        MsgBox("Invalid IP entered")
                        Me.Cursor = Cursors.Default
                        staticdnsbutton.Enabled = True
                        Exit Sub
                    End If
                Next
                SetDNS(Servers)
            End If
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try


        Me.Cursor = Cursors.Default
        staticdnsbutton.Enabled = True

    End Sub
    Private Sub SetDNS(ByVal Servers As String)
        Try
            Dim arrDNSservers As System.Object = Split(Servers, ",")
            Dim m As ManagementObject
            Dim inParams As ManagementBaseObject
            Dim outparams As ManagementBaseObject
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("Select * from Win32_NetworkAdapterConfiguration Where MACAddress = '" & PC.MacAddress & "' AND IPEnabled = True")
            For Each m In queryCollection
                inParams = m.GetMethodParameters("SetDNSServerSearchOrder")
                inParams("DNSServerSearchOrder") = arrDNSservers
                outparams = m.InvokeMethod("SetDNSServerSearchOrder", inParams, Nothing)
                If outparams.Properties("ReturnValue").Value <> 0 Then
                    MsgBox("Error setting DNS Servers")
                End If
            Next
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub dhcpbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dhcpbutton.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim ipThread As New System.Threading.Thread(AddressOf SetDHCP)
            ipThread.Start()
            System.Threading.Thread.Sleep(5000)
            If ipThread.IsAlive Then
                ipThread.Abort()
            End If
            System.Threading.Thread.Sleep(1000)
            wmi.WMIConnect(PC.Name)
            ClearNetwork()
            WMINetwork()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub SetDHCP() ' NOT IN USE
        Try
            Dim m As ManagementObject
            Dim inParams As ManagementBaseObject
            Dim outparams As ManagementBaseObject
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("Select * from Win32_NetworkAdapterConfiguration Where MACAddress = '" & PC.MacAddress & "' AND IPEnabled = True")
            For Each m In queryCollection
                inParams = m.GetMethodParameters("EnableDHCP")
                outparams = m.InvokeMethod("EnableDHCP", Nothing, Nothing)
                If outparams.Properties("ReturnValue").Value <> 0 Then
                    MsgBox("Error setting DHCP configuration")
                End If
            Next
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
        ' return codes: http://msdn2.microsoft.com/en-us/library/aa390378.aspx
    End Sub
    Private Sub primdnssetbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles primdnssetbutton.Click

        Me.Cursor = Cursors.WaitCursor

        primdnssetbutton.Enabled = False
        Try
            wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, _
                "System\CurrentControlSet\services\Tcpip\Parameters", "Domain", suffix.Text)
            Panel2.Text = "primary dns suffix set"
        Catch
            Panel2.Text = "unable to set primary dns suffix"
        End Try

        primdnssetbutton.Enabled = True
        Me.Cursor = Cursors.Default

    End Sub
    Private Sub suffix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suffix.TextChanged
        primdnssetbutton.Enabled = True
    End Sub
    Private Sub suffix_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles suffix.DoubleClick
        suffix.Text = cmcUser.dnsdomain
    End Sub
    Private Sub staticbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles staticbutton.Click

        Me.Cursor = Cursors.WaitCursor

        CreateStaticScript()
        System.Threading.Thread.Sleep(3000)

        wmi.WMIConnect(PC.Name)
        ClearNetwork()
        WMINetwork()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub MakeStaticIP()

        Dim m As ManagementObject
        Dim inParams As ManagementBaseObject
        'Dim GWParams As ManagementBaseObject
        Dim outparams As ManagementBaseObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery _
            ("Select * from Win32_NetworkAdapterConfiguration Where MACAddress = '" & PC.MacAddress & "' AND IPEnabled = True")
        Try
            For Each m In queryCollection
                For Each IP As String In m("IPAddress")
                    If IP = Label_IP.Text Then
                        inParams = m.GetMethodParameters("EnableStatic")
                        inParams("IPAddress") = New String() {ipaddress.Text}
                        inParams("SubnetMask") = New String() {subnet.Text}
                        'GWParams("DefaultIPGateway") = New String() {gateway.Text}
                        outparams = m.InvokeMethod("EnableStatic", inParams, Nothing)
                        If outparams.Properties("ReturnValue").Value <> 0 Then
                            MsgBox("Error setting DHCP configuration")
                        End If
                    End If
                Next
            Next
        Catch ex As Exception
            ' error at: "outparams = m.InvokeMethod("EnableStatic", inParams, Nothing)"
            ' on remote machine due to lost connection
        End Try

        ' return codes: http://msdn.microsoft.com/library/default.asp?url=/library/en-us/wmisdk/wmi/enablestatic_method_in_class_win32_networkadapterconfiguration.asp

    End Sub
    Private Sub CreateStaticScript()

        'write text to file
        Dim VBS_tempfile As String = My.Application.Info.DirectoryPath & "\static.vbs"
        Dim script As New System.IO.StreamWriter(VBS_tempfile, False)
        script.WriteLine("on error resume next")
        script.WriteLine("strComputer = " & Chr(34) & "." & Chr(34))
        script.WriteLine("Set objWMIService = GetObject(" & Chr(34) & "winmgmts:\\" & Chr(34) & " & strcomputer & " & Chr(34) & "\root\cimv2" & Chr(34) & ")")
        script.WriteLine("Set colNetAdapters = objWMIService.ExecQuery(" & Chr(34) & "Select * from Win32_NetworkAdapterConfiguration where IPEnabled=TRUE" & Chr(34) & ")")
        script.WriteLine("strIPAddress = Array(" & Chr(34) & ipaddress.Text & Chr(34) & ")")
        script.WriteLine("strSubnetMask = Array(" & Chr(34) & subnet.Text & Chr(34) & ")")
        script.WriteLine("strGateway = Array(" & Chr(34) & gateway.Text & Chr(34) & ")")
        script.WriteLine("strGatewayMetric = Array(1)")
        script.WriteLine("For Each objNetAdapter In colNetAdapters")
        script.WriteLine("errEnable = objNetAdapter.EnableStatic(strIPAddress, strSubnetMask)")
        script.WriteLine("errGateways = objNetAdapter.SetGateways(strGateway, strGatewaymetric)")
        script.WriteLine("Next")
        script.WriteLine("Set objFSO = CreateObject(" & Chr(34) & "Scripting.FileSystemObject" & Chr(34) & ")")
        script.WriteLine("objFSO.DeleteFile(" & Chr(34) & "C:\static.vbs" & Chr(34) & ")")
        script.Close()

        Try
            Shell("cmd /c copy " & Chr(34) & VBS_tempfile & Chr(34) & _
            " \\" & PC.Name & "\c$\static.vbs /Y", 0, True)
        Catch ex As Exception
            Panel2.Text = "msgbox failed"
            WriteLog(PC.Name & " - message - file copy failed: " & ex.Message)
            Exit Sub
        End Try

        ' Run script on remote pc
        If RemoteExec(PC.Name, "wscript.exe c:\static.vbs") = 0 Then
            MsgBox("An error occurred setting IP address")
        End If


    End Sub

    ' DNS Suffix Search order
    Private Sub dnssearchbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dnssearchbutton.Click

        Me.Cursor = Cursors.WaitCursor
        dnssearchbutton.Enabled = False

        Dim strSFX As String = ""
        Dim i As Integer
        If sfxlist.Items.Count = 0 Then
            strSFX = ""
        Else
            For i = 0 To sfxlist.Items.Count - 1
                strSFX = strSFX & "," & sfxlist.Items(i)
            Next
            strSFX = Mid(strSFX, 2, strSFX.Length - 1)
        End If


        ' Write strSFX value to Reg
        Try
            wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, _
                "System\CurrentControlSet\services\Tcpip\Parameters", "SearchList", strSFX)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub sfx_add_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sfx_add_button.Click
        sfxlist.Items.Add(Trim(sfx1.Text))
        sfx1.Text = ""
        dnssearchbutton.Enabled = True
    End Sub
    Private Sub sfx_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sfx_delete.Click
        sfxlist.Items.Remove(sfxlist.SelectedItem)
        dnssearchbutton.Enabled = True
    End Sub
    Private Sub sfxlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sfxlist.SelectedIndexChanged
        If Trim(sfxlist.SelectedItem) <> "" Then
            sfx_delete.Enabled = True
        Else
            sfx_delete.Enabled = False
        End If
    End Sub
    Private Sub sfx1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sfx1.TextChanged
        If sfx1.Text.Length > 2 Then
            sfx_add_button.Enabled = True
        Else
            sfx_add_button.Enabled = False
        End If
    End Sub
    Private Sub macaddress_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles macaddress.MouseDoubleClick
        If ConnectionExists Then
            If InStr(macaddress.Text, ":") Then
                macaddress.Text = Replace(PC.MacAddress, ":", "")
            Else
                macaddress.Text = PC.MacAddress
            End If
        End If
    End Sub
    Private Sub ClearNetwork()
        AdaptorID.Text = ""
        hostname.Text = ""
        ipaddress.Text = ""
        subnet.Text = ""
        gateway.Text = ""
        domain.Text = ""
        lblDhcp.Text = ""
        macaddress.Text = ""
        suffix.Text = ""
        dnsservers.Text = ""
        sfx1.Text = ""
        sfxlist.Items.Clear()
        sfx_add_button.Enabled = False
        sfx_delete.Enabled = False
        dhcpbutton.Visible = False
        staticbutton.Visible = False
        staticdnsbutton.Enabled = False
        primdnssetbutton.Enabled = False
        dnssearchbutton.Enabled = False
        dnssearchbutton.Enabled = False
    End Sub

#End Region

#Region "SERVICES"

    ' Currently selected service
    Protected Friend sGridRowNumber As Integer
    Dim sGridCaption As String
    Dim sGridState As String
    Dim sGridStartMode As String
    Dim sGridName As String
    Dim sGridDescription As String
    Dim sGridCanPause As String
    Dim sGridCanStop As String
    Dim sGridPath As String
    Dim sGridAccount As String

    Private Sub refreshsvc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshsvc.Click
        svc_datagrid.Rows.Clear()
        svc_datagrid.Cursor = Cursors.AppStarting
        Panel2.Text = "getting services..."
        GetSVClist()
        svc_datagrid.Cursor = Cursors.Default
        Panel2.Text = "ready"
    End Sub
    Public Sub GetSVClist()

        Try
            Dim queryCollection As ManagementObjectCollection
            Dim svc As ManagementObject
            queryCollection = wmi.wmiQuery _
                  ("SELECT Caption, Name, State, StartMode, Description, AcceptPause, AcceptStop, PathName, StartName FROM Win32_Service")
            For Each svc In queryCollection

                svc_datagrid.Rows.Add(svc("caption").ToString(), _
                                      svc("state").ToString(), _
                                      svc("StartMode").ToString(), _
                                      svc("name").ToString(), _
                                      CStr(svc("Description")), _
                                      svc("acceptpause").ToString, _
                                      svc("acceptstop").ToString, _
                                      svc("pathName").ToString, _
                                      svc("startName").ToString)
            Next

            svc_datagrid.Sort(column1, ComponentModel.ListSortDirection.Ascending)
            svc_datagrid.ClearSelection()
            svc_datagrid.Focus()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try

    End Sub
    Public Sub UpdateSelectedService(ByVal Row As Integer)

        Try
            Dim queryCollection As ManagementObjectCollection
            Dim svc As ManagementObject
            queryCollection = wmi.wmiQuery _
                  ("SELECT State, Startmode FROM Win32_Service WHERE Name ='" & Me.sGridName & "'")

            For Each svc In queryCollection
                svc_datagrid(1, Row).Value = svc("state").ToString()
                svc_datagrid(2, Row).Value = svc("StartMode").ToString()
            Next

            svc_datagrid.Sort(column1, ComponentModel.ListSortDirection.Ascending)
            svc_datagrid.ClearSelection()
            svc_datagrid.Focus()
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try


    End Sub
    Public Function Get_ServiceStartMode(ByVal ServiceName As String) As String

        Dim startMode As String = String.Empty
        Try
            Dim queryCollection As ManagementObjectCollection
            Dim svc As ManagementObject
            queryCollection = wmi.wmiQuery _
                  ("SELECT State, Startmode FROM Win32_Service WHERE Name ='" & ServiceName & "'")

            For Each svc In queryCollection
                startMode = svc("StartMode").ToString()
            Next

            svc_datagrid.Sort(column1, ComponentModel.ListSortDirection.Ascending)
            svc_datagrid.ClearSelection()
            svc_datagrid.Focus()
        Catch ex As Exception
        End Try

        Return startMode

    End Function
    Public Function Get_ServiceState(ByVal ServiceName As String) As String

        Dim serviceState As String = String.Empty
        Try
            Dim queryCollection As ManagementObjectCollection
            Dim svc As ManagementObject
            queryCollection = wmi.wmiQuery _
                  ("SELECT State, Startmode FROM Win32_Service WHERE Name ='" & ServiceName & "'")

            For Each svc In queryCollection
                serviceState = svc("State").ToString()
            Next

            svc_datagrid.Sort(column1, ComponentModel.ListSortDirection.Ascending)
            svc_datagrid.ClearSelection()
            svc_datagrid.Focus()
        Catch ex As Exception
        End Try

        Return serviceState

    End Function

    ' Service Controls
    Private Overloads Sub StopService()
        StopService(Me.sGridName)
    End Sub
    Public Overloads Sub StopService(ByVal servicename As String)
        Try
            Dim queryCollection As ManagementObjectCollection
            Dim m As ManagementObject
            Dim outparams As ManagementBaseObject
            queryCollection = wmi.wmiQuery("SELECT * FROM Win32_Service Where Name ='" & servicename & "'")
            For Each m In queryCollection
                outparams = m.InvokeMethod("StopService", Nothing, Nothing)
                System.Threading.Thread.Sleep(500)
                If outparams.Properties("ReturnValue").Value <> 0 Then
                    MsgBox("error stopping service: " & servicename & vbCrLf & "error:" & outparams.Properties("ReturnValue").Value)
                    'Debug.Print("error stopping service: " & servicename & vbCrLf & "error:" & outparams.Properties("ReturnValue").Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub
    Public Overloads Sub StartService()
        StartService(Me.sGridName)
    End Sub
    Public Overloads Sub StartService(ByVal servicename As String)
        Try
            Dim queryCollection As ManagementObjectCollection
            Dim m As ManagementObject
            Dim outparams As ManagementBaseObject
            queryCollection = wmi.wmiQuery("SELECT name FROM Win32_Service Where Name ='" & servicename & "'")
            For Each m In queryCollection
                outparams = m.InvokeMethod("StartService", Nothing, Nothing)
                System.Threading.Thread.Sleep(500)
                If outparams.Properties("ReturnValue").Value <> 0 Then
                    MsgBox("error starting service: " & servicename & vbCrLf & "error:" & outparams.Properties("ReturnValue").Value)
                    'Debug.Print("error starting service: " & servicename & vbCrLf & "error:" & outparams.Properties("ReturnValue").Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub
    Protected Friend Sub Service_ChangeStartMode(ByVal servicename As String, ByVal NewStartMode As String)
        If NewStartMode <> "Automatic" AndAlso NewStartMode <> "Manual" AndAlso NewStartMode <> "Disabled" Then
            MsgBox("Invalid service start mode passed")
            Exit Sub
        End If
        Try
            Dim inParams As ManagementBaseObject
            Dim outParams As ManagementBaseObject
            Dim result As Integer
            Dim queryCollection As ManagementObjectCollection
            Dim m As ManagementObject
            queryCollection = wmi.wmiQuery("SELECT name FROM Win32_Service Where Name ='" & servicename & "'")
            For Each m In queryCollection
                inParams = m.GetMethodParameters("ChangeStartMode")
                inParams("StartMode") = NewStartMode
                outParams = m.InvokeMethod("ChangeStartMode", inParams, Nothing)
                If outParams.Properties("ReturnValue").Value <> 0 Then
                    result = Convert.ToInt32(outParams("returnValue"))
                    If result <> 0 Then
                        Throw New Exception("ChangeStartMode method error code " & result)
                    End If
                    'MsgBox("error changing start mode: " & servicename & vbCrLf & "error:" & outParams.Properties("ReturnValue").Value)
                End If
            Next
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Service Control methods - not wmi
    Private Sub ServiceControlStopService(ByVal SComputer As String, ByVal servicename As String)
        Try
            Dim StopService As New ServiceProcess.ServiceController(servicename, SComputer)
            StopService.Stop()
            StopService.WaitForStatus(ServiceProcess.ServiceControllerStatus.Stopped)
        Catch ex As Exception
            MsgBox(Err.Description & vbCrLf & "error code: " & Err.Number)
        End Try
    End Sub
    Private Sub ServiceControlStartService(ByVal SComputer As String, ByVal servicename As String)
        Try
            Dim StartService As New ServiceProcess.ServiceController(servicename, SComputer)
            StartService.Start()
            StartService.WaitForStatus(ServiceProcess.ServiceControllerStatus.Running)
        Catch ex As Exception
            MsgBox(Err.Description & vbCrLf & "error code: " & Err.Number)
        End Try
    End Sub

    Private Overloads Sub restartservice(ByVal servicename As String)
        Dim reStartService As New ServiceProcess.ServiceController

        reStartService.MachineName = PC.Name
        reStartService.ServiceName = servicename

        Try
            reStartService.Stop()
            reStartService.WaitForStatus(ServiceProcess.ServiceControllerStatus.Stopped)
            reStartService.Start()
            reStartService.WaitForStatus(ServiceProcess.ServiceControllerStatus.Running)
        Catch ex As Exception
            MsgBox(Err.Description & vbCrLf & "error code: " & Err.Number)
        End Try
    End Sub
    Private Overloads Sub RestartService()
        restartservice(Me.sGridName)
    End Sub
    Private Sub RemoveService()
        svc_datagrid.Refresh()
        Panel2.Text = "removing " & Me.sGridName & " service..."
        Me.Cursor = Cursors.WaitCursor

        Try
            Dim strRemoveService As String = "SC \\" & PC.Name & " delete " & Me.sGridName
            Shell(strRemoveService, 0, True, 10)
        Catch ex As Exception
            MsgBox(Err.Description & vbCrLf & "error code: " & Err.Number)
        End Try

        Panel2.Text = "ready"
        Me.Cursor = Cursors.Default

    End Sub
    Private Overloads Sub ChangeServiceStartmode(ByVal strStartMode As String)
        ChangeServiceStartmode(Me.sGridName, strStartMode)
    End Sub
    Private Overloads Sub ChangeServiceStartmode(ByVal ServiceName As String, ByVal strStartMode As String)
        svc_datagrid.Refresh()
        Try
            Dim strChangeService As String = "SC \\" & PC.Name & " config " & ServiceName & " start= " & strStartMode
            Shell(strChangeService, 0, True)
        Catch ex As Exception
            MsgBox(Err.Description & vbCrLf & "error code: " & Err.Number)
        End Try

        WriteLog(PC.Name & " - change startmode to " & strStartMode & "for service: " & ServiceName)

    End Sub

    ' Context menu setup
    Private Sub svc_datagrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles svc_datagrid.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then
                svc_datagrid.ClearSelection()
                svc_datagrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.sGridRowNumber = hti.RowIndex
                Me.sGridCaption = svc_datagrid(0, hti.RowIndex).Value
                Me.sGridState = svc_datagrid(1, hti.RowIndex).Value
                Me.sGridStartMode = svc_datagrid(2, hti.RowIndex).Value
                Me.sGridName = svc_datagrid(3, hti.RowIndex).Value
                Me.sGridDescription = svc_datagrid(4, hti.RowIndex).Value
                Me.sGridCanPause = svc_datagrid(5, hti.RowIndex).Value
                Me.sGridCanStop = svc_datagrid(6, hti.RowIndex).Value
                Me.sGridPath = svc_datagrid(7, hti.RowIndex).Value
                Me.sGridAccount = svc_datagrid(8, hti.RowIndex).Value

                svcname.Text = Me.sGridCaption

                ' Prepare Context Menu

                If Me.sGridStartMode = "Disabled" Then
                    svcstart.Enabled = False
                    svcstop.Enabled = False
                    svcrestart.Enabled = False
                Else
                    Select Case Me.sGridState
                        Case "Running"
                            svcstart.Enabled = False
                            svcstop.Enabled = True
                            svcrestart.Enabled = True
                        Case "Stopped"
                            svcstart.Enabled = True
                            svcstop.Enabled = False
                            svcrestart.Enabled = False
                        Case Else
                            svcstart.Enabled = True
                            svcstop.Enabled = True
                            svcrestart.Enabled = True
                    End Select
                End If

                If Me.sGridStartMode = "Disabled" Then
                    DisabledMenu.Checked = True
                    AutomaticMenu.Checked = False
                    ManualMenu.Checked = False
                ElseIf Me.sGridStartMode = "Auto" Then
                    DisabledMenu.Checked = False
                    AutomaticMenu.Checked = True
                    ManualMenu.Checked = False
                ElseIf Me.sGridStartMode = "Manual" Then
                    DisabledMenu.Checked = False
                    AutomaticMenu.Checked = False
                    ManualMenu.Checked = True
                Else
                    DisabledMenu.Checked = False
                    AutomaticMenu.Checked = False
                    ManualMenu.Checked = False
                End If

                Me.svccontextmenu.Show(Me.svc_datagrid, New Point(e.X, e.Y))
            End If

        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then
                svc_datagrid.ClearSelection()
                svc_datagrid(hti.ColumnIndex, hti.RowIndex).Selected = True
                'svc_datagrid.Rows(hti.RowIndex).Selected = True

                Me.sGridRowNumber = hti.RowIndex
                Me.sGridCaption = svc_datagrid(0, hti.RowIndex).Value
                Me.sGridState = svc_datagrid(1, hti.RowIndex).Value
                Me.sGridStartMode = svc_datagrid(2, hti.RowIndex).Value
                Me.sGridName = svc_datagrid(3, hti.RowIndex).Value
                Me.sGridDescription = svc_datagrid(4, hti.RowIndex).Value
                Me.sGridCanPause = svc_datagrid(5, hti.RowIndex).Value
                Me.sGridCanStop = svc_datagrid(6, hti.RowIndex).Value
                Me.sGridPath = svc_datagrid(7, hti.RowIndex).Value
                Me.sGridAccount = svc_datagrid(8, hti.RowIndex).Value

            End If
        End If


    End Sub
    Private Sub svc_datagrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles svc_datagrid.KeyDown

        If e.KeyCode = Keys.Enter Then

            ' get current selected row.
            Dim iRow As DataGridViewRow = svc_datagrid.CurrentRow
            svc_datagrid.ClearSelection()
            svc_datagrid(2, iRow.Index).Selected = True

            Me.sGridRowNumber = Me.svc_datagrid.SelectedRows(0).Index
            Me.sGridCaption = svc_datagrid(0, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridState = svc_datagrid(1, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridStartMode = svc_datagrid(2, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridName = svc_datagrid(3, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridDescription = svc_datagrid(4, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridCanPause = svc_datagrid(5, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridCanStop = svc_datagrid(6, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridPath = svc_datagrid(7, Me.svc_datagrid.SelectedRows(0).Index).Value
            Me.sGridAccount = svc_datagrid(8, Me.svc_datagrid.SelectedRows(0).Index).Value

            ' load service proprties form as dialog - wait for exit.
            LoadServicePropertiesForm()

            ' by default enter key causes selection to move 
            ' to the next row down.
            ' this is a crap effort to retain existing selection.
            svc_datagrid.ClearSelection()
            Try
                svc_datagrid(2, iRow.Index - 1).Selected = True
            Catch ex As Exception
            End Try

        End If
    End Sub
    Private Sub svc_datagrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles svc_datagrid.CellDoubleClick
        LoadServicePropertiesForm()
    End Sub
    Private Sub LoadServicePropertiesForm()

        Dim si As New SvcInfo
        si.FormLoading = True

        si.txtSvcCaption.Text = Me.sGridCaption
        si.txtSvcName.Text = Me.sGridName
        si.txtSvcPath.Text = Me.sGridPath
        si.lblSvcStatus.Text = Me.sGridState
        si.lblSvcAccount.Text = Me.sGridAccount
        si.txtDescription.Text = Me.sGridDescription
        si.CanPause = CBool(Me.sGridCanPause)
        si.CanStop = CBool(Me.sGridCanStop)

        si.Text = Me.sGridCaption & " Properties"

        Select Case Me.sGridStartMode
            Case "Auto"
                si.svcStartupCombo.SelectedIndex = 0
            Case "Manual"
                si.svcStartupCombo.SelectedIndex = 1
            Case "Disabled"
                si.svcStartupCombo.SelectedIndex = 2
        End Select

        si.FormLoading = False
        si.ShowDialog()

    End Sub

    ' Context menu selections
    Private Sub svcstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svcstop.Click
        Me.Refresh()
        Me.Cursor = Cursors.WaitCursor
        Panel2.Text = "stopping " & Me.sGridName & ".  please wait..."

        Dim svcthread As New System.Threading.Thread(AddressOf StopService)
        svcthread.Start()
        Dim count As Integer = 0
        Do While svcthread.IsAlive And count < 10
            System.Threading.Thread.Sleep(1000)
            count = count + 1
        Loop
        svcthread.Join()

        GetServiceState(Me.sGridName)
        WriteLog(PC.Name & " - stop service: " & Me.sGridName)
        Panel2.Text = "ready"
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub svcstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svcstart.Click
        Me.Refresh()
        Me.Cursor = Cursors.WaitCursor
        Panel2.Text = "starting " & Me.sGridName & ".  please wait..."

        Dim svcthread As New System.Threading.Thread(AddressOf StartService)
        svcthread.Start()
        Dim count As Integer = 0
        Do While svcthread.IsAlive And count < 10
            System.Threading.Thread.Sleep(1000)
            count = count + 1
        Loop
        svcthread.Join()

        GetServiceState(Me.sGridName)
        WriteLog(PC.Name & " - start service: " & Me.sGridName)
        Panel2.Text = "ready "
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub svcrestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svcrestart.Click
        Me.Refresh()
        Me.Cursor = Cursors.WaitCursor
        Panel2.Text = "restarting " & Me.sGridName & ".  please wait..."
        'RestartService()

        Dim svcthread As New System.Threading.Thread(AddressOf restartservice)
        svcthread.Start()
        Dim count As Integer = 0
        Do While svcthread.IsAlive And count < 10
            System.Threading.Thread.Sleep(1000)
            count = count + 1
        Loop
        svcthread.Join()

        GetServiceState(Me.sGridName)
        WriteLog(PC.Name & " - restart service: " & Me.sGridName)
        Panel2.Text = "ready "
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub mnuSvcProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSvcProperties.Click
        Dim si As New SvcInfo

        si.FormLoading = True

        si.txtSvcCaption.Text = Me.sGridCaption
        si.txtSvcName.Text = Me.sGridName
        si.txtSvcPath.Text = Me.sGridPath
        si.lblSvcStatus.Text = Me.sGridState
        si.txtDescription.Text = Me.sGridDescription

        Select Case Me.sGridStartMode
            Case "Auto"
                si.svcStartupCombo.SelectedIndex = 0
            Case "Manual"
                si.svcStartupCombo.SelectedIndex = 1
            Case "Disabled"
                si.svcStartupCombo.SelectedIndex = 2
        End Select

        Select Case Me.sGridState
            Case "Running"
                si.btnSvcStart.Enabled = False
                si.btnSvcStop.Enabled = True
                si.btnSvcPause.Enabled = CBool(Me.sGridCanPause)
                si.btnSvcResume.Enabled = False
            Case "Stopped"
                si.btnSvcStart.Enabled = True
                si.btnSvcStop.Enabled = False
                si.btnSvcPause.Enabled = False
                si.btnSvcResume.Enabled = False
            Case "Paused"
                si.btnSvcStart.Enabled = False
                si.btnSvcStop.Enabled = False
                si.btnSvcPause.Enabled = False
                si.btnSvcResume.Enabled = True
        End Select

        si.FormLoading = False

        si.ShowDialog()
    End Sub
    Private Sub DeleteServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteServiceToolStripMenuItem.Click
        If MsgBox("Are you sure you want to delete" & vbCrLf & _
                        "the selected service?", 36, "DELETE  " _
                        & UCase(Me.sGridName) & " ?") = MsgBoxResult.Yes Then

            RemoveService()
            Me.svc_datagrid.Rows.Clear()
            GetSVClist()

            WriteLog(PC.Name & " - delete service: " & Me.sGridName)
        End If
    End Sub
    Private Sub GetServiceState(ByVal sService As String)

        Dim svc As New ServiceProcess.ServiceController
        svc.MachineName = PC.Name
        svc.ServiceName = sService

        Try
            svc_datagrid.Item(1, Me.sGridRowNumber).Value = svc.Status
        Catch ex As Exception
        End Try


    End Sub
    Private Sub RefreshMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshMenu.Click
        GetSVClist()
    End Sub

    Private Sub AutomaticMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutomaticMenu.Click

        If AutomaticMenu.Checked = True Then Exit Sub
        Try
            Me.Cursor = Cursors.WaitCursor
            'ChangeServiceStartmode("auto")
            Service_ChangeStartMode(Me.sGridName, "Automatic")
            svc_datagrid.Item(2, Me.sGridRowNumber).Value = "Auto"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Startmode change failed:" & vbCrLf & Err.Number & vbCrLf & Err.Description)
        End Try


        'GetSVClist()


    End Sub
    Private Sub ManualMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualMenu.Click

        If ManualMenu.Checked = True Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            ChangeServiceStartmode("demand")
            svc_datagrid.Item(2, Me.sGridRowNumber).Value = "Manual"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Startmode change failed:" & vbCrLf & Err.Number & vbCrLf & Err.Description)
        End Try

    End Sub
    Private Sub DisabledMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisabledMenu.Click

        If DisabledMenu.Checked = True Then Exit Sub

        Try
            Me.Cursor = Cursors.WaitCursor
            ChangeServiceStartmode("disabled")
            svc_datagrid.Item(2, Me.sGridRowNumber).Value = "Disabled"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Startmode change failed:" & vbCrLf & Err.Number & vbCrLf & Err.Description)
        End Try

    End Sub

    Private Sub GoogleLookupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoogleLookupToolStripMenuItem.Click
        If Me.sGridName <> "" Then
            System.Diagnostics.Process.Start("http://www.google.com/search?q=" & Me.sGridName & " service")
        End If
    End Sub

#End Region

#Region "PROCESSES"

    Protected Friend pGrid_Name As String
    Protected Friend pGrid_ID As String
    Protected Friend pGrid_Path As String

    Private Sub ProcessRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessRefresh.Click
        Me.Panel2.Text = "enumerating running processes..."
        Me.processgrid.Cursor = Cursors.AppStarting
        Me.processgrid.Rows.Clear()
        Me.GetProcesses_WMI()
        Me.processgrid.Sort(pr_name, ComponentModel.ListSortDirection.Ascending)
        Me.processgrid.ClearSelection()
        Me.processgrid.Focus()
        Me.Panel2.Text = "ready"
        Me.processgrid.Cursor = Cursors.Default
    End Sub
    Private Sub GetProcesses()



        'If get_processes_by_wmi_checkbox.Checked Then
        Me.processgrid.Rows.Clear()
        GetProcesses_WMI()
        'Else
        '    If AltUserCheckBox.Checked Then
        '        Dim impersonator As New Impersonation
        '        If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
        '            GetProcesses_API()
        '            impersonator.undoImpersonation()
        '        Else
        '            GetProcesses_WMI()
        '        End If
        '    Else
        '        GetProcesses_API()
        '    End If
        'End If

        processgrid.Sort(pr_name, ComponentModel.ListSortDirection.Ascending)
        processgrid.ClearSelection()
        processgrid.Focus()


    End Sub
    Private Sub GetProcesses_WMI()

        Try
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("SELECT Name, ProcessID, WorkingSetSize, ExecutablePath FROM Win32_Process")

            Dim m As ManagementObject
            For Each m In queryCollection
                processgrid.Rows.Add(m("Name").ToString, CInt(m("ProcessID")), CInt(m("WorkingSetSize") / 1024), CStr(m("ExecutablePath")))
                'FormatNumber(m("WorkingSetSize") / 1024, 0, TriState.True)
            Next
        Catch ex As Exception
            Panel2.Text = "error getting processes"
            WriteLog(PC.Name & " - wmi process enumeration error: " & Err.Description)
        End Try

    End Sub
    Private Sub GetProcesses_API()

        Try
            Dim ps As System.Diagnostics.Process
            For Each ps In System.Diagnostics.Process.GetProcesses(PC.Name)
                processgrid.Rows.Add(ps.ProcessName, ps.Id, "", ps.WorkingSet64 / 1024)
            Next ps
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Function ProcessOwnerById(ByVal ProcessID As Integer) As String
        On Error Resume Next
        Dim domain As String = ""
        Dim user As String = ""

        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery _
            ("SELECT * FROM Win32_Process WHERE ProcessID = '" & ProcessID & "'")

        For Each m In queryCollection
            Dim s(1) As String
            m.InvokeMethod("GetOwner", CType(s, Object()))
            user = s(0)
            domain = s(1)
        Next

        Return domain & "\" & user

    End Function
    Private Function WMI_Kill() As Boolean

        Try
            Dim queryCollection As ManagementObjectCollection
            Dim m As ManagementObject
            queryCollection = wmi.wmiQuery("SELECT * FROM Win32_Process WHERE Handle = '" & pGrid_ID & "'")

            If queryCollection.Count = 1 Then
                For Each m In queryCollection
                    m.InvokeMethod("Terminate", Nothing)
                    WriteLog(PC.Name & " - process killed " & m("Name").ToString)
                Next
                Return True
            Else
                Panel2.Text = "kill failed"
                Return False
            End If

        Catch ex As Exception
            Panel2.Text = "process kill failed"
            WriteLog(PC.Name & " - Process Kill failed: " & ex.Message)
            Return False
        End Try

    End Function

    ' activate menus/controls
    Private Sub processgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles processgrid.DoubleClick
        ShowProcessInfoDialog()
    End Sub
    Private Sub processgrid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles processgrid.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' get current selected row.
            Dim iRow As DataGridViewRow = processgrid.CurrentRow
            processgrid.ClearSelection()
            processgrid(2, iRow.Index).Selected = True

            Me.pGrid_Name = processgrid(0, Me.processgrid.SelectedRows(0).Index).Value
            Me.pGrid_ID = processgrid(1, Me.processgrid.SelectedRows(0).Index).Value
            Me.pGrid_Path = processgrid(3, Me.processgrid.SelectedRows(0).Index).Value

            ' load process proprties form as dialog - wait for exit.
            ShowProcessInfoDialog()

            ' by default enter key causes selection to move 
            ' to the next row down.
            ' this is a crap effort to retain existing selection.
            processgrid.ClearSelection()
            Try
                processgrid(2, iRow.Index - 1).Selected = True
            Catch ex As Exception
            End Try

        End If
    End Sub
    Private Sub processgrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
               Handles processgrid.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then

                ' ensure only current item selected
                processgrid.ClearSelection()
                processgrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.pGrid_Name = processgrid(0, hti.RowIndex).Value
                Me.pGrid_ID = processgrid(1, hti.RowIndex).Value
                Me.pGrid_Path = processgrid(3, hti.RowIndex).Value

                procMenuHeader.Text = Me.pGrid_Name
                mnuProcKill.Text = "kill process  [" & Me.pGrid_ID & "]"
                mnuProcGoogle.Text = "google lookup"

                If Me.pGrid_Name.ToLower = "system" OrElse Me.pGrid_Name.ToLower = "csrss.exe" _
                         OrElse Me.pGrid_Name.ToLower = "system idle process" Then
                    mnuProcKill.Enabled = False
                    mnuProcGoogle.Enabled = False
                Else
                    mnuProcKill.Enabled = True
                    mnuProcGoogle.Enabled = True
                End If

                If String.IsNullOrEmpty(Me.pGrid_Path) Then
                    mnuCopyPath.Enabled = False
                Else
                    mnuCopyPath.Enabled = True
                End If

                ProcContextMenu.Show(processgrid, New Point(e.X, e.Y))
            End If
        Else

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then

                ' ensure only current item selected
                processgrid.ClearSelection()
                processgrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.pGrid_Name = processgrid(0, hti.RowIndex).Value
                Me.pGrid_ID = processgrid(1, hti.RowIndex).Value
                Me.pGrid_Path = processgrid(3, hti.RowIndex).Value
            End If
        End If

    End Sub
    Private Sub ShowProcessInfoDialog()
        Dim pi As New ProcInfo
        pi.AcceptButton = pi.CancelButton
        pi.Text = Me.pGrid_Name & " Properties"
        pi.txtProcName.Text = Me.pGrid_Name
        pi.txtProcPath.Text = Me.pGrid_Path
        pi.txtProcPid.Text = Me.pGrid_ID
        pi.ShowDialog()
    End Sub

    ' context menu items
    Private Sub mnuProcKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcKill.Click
        Me.Cursor = Cursors.WaitCursor
        If WMI_Kill() Then
            For i As Integer = 0 To processgrid.RowCount - 1
                If InStr(LCase(processgrid(1, i).Value), Me.pGrid_ID) Then
                    processgrid.Rows(i).Visible = False
                End If
            Next
            'processname.Text = ""
            'processpath.Text = ""
            'processid.Text = ""
        End If

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub mnuProcGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProcGoogle.Click
        On Error Resume Next
        If Me.pGrid_Name <> "" Then
            System.Diagnostics.Process.Start("http://www.google.com/search?q=" & Me.pGrid_Name)
        End If
    End Sub
    Private Sub mnuCopyPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyPath.Click
        ' copy path to clipboard
        My.Computer.Clipboard.SetText(Me.pGrid_Path)
    End Sub
    Private Sub mnuProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesToolStripMenuItem.Click
        Dim pi As New ProcInfo
        pi.Text = Me.pGrid_Name & " Properties"
        pi.txtProcName.Text = Me.pGrid_Name
        pi.txtProcPath.Text = Me.pGrid_Path
        pi.txtProcPid.Text = Me.pGrid_ID
        pi.ShowDialog()
    End Sub

    ' Create New process
    Private Sub RunNewProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunNewProcess.Click
        Me.Cursor = Cursors.WaitCursor

        If interactive.Checked Then
            If psexecpath.Text <> "" Then
                cmcPSEXEC("-d -i " & newprocess.Text, 0, True, "C")
                WriteLog(PC.Name & " - psexec started remote process: " & newprocess.Text)
                System.Threading.Thread.Sleep(800)
                GetProcesses()
            Else
                Try
                    Dim pid As Integer = ScheduleJob(PC.Name, newprocess.Text, True)
                    If pid = 0 Then
                        WriteLog(PC.Name & " - start remote process failed: " & newprocess.Text)
                        Panel2.Text = "start process failed"
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    Else
                        Panel2.Text = "process scheduled with id: " & pid
                    End If
                Catch ex As Exception
                    MsgBox("An error occurred: " & ex.Message)
                End Try
            End If
        Else
            Try
                'remoteExec.Execute(newprocess.Text, pc.name, -1)
                Dim startprocess As Integer = RemoteExec(PC.Name, newprocess.Text)
                If startprocess <> 0 Then
                    System.Threading.Thread.Sleep(900)
                    GetProcesses()
                    WriteLog(PC.Name & " - started remote process: " & newprocess.Text)
                    Panel2.Text = "process started with id: " & startprocess
                Else
                    Panel2.Text = "process execute failed"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ScheduleButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleButton.Click
        If Trim(newprocess.Text) = "" Then Exit Sub

        ' Get timezone difference for daylight saving
        Dim sHour, sMinute As Integer
        sHour = CInt(ScheduleTime.Text.Substring(0, 2))
        sMinute = CInt(ScheduleTime.Text.Substring(3, 2))

        Dim HourOffset As Integer = System.TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now).Hours
        sHour = sHour - HourOffset

        Dim rtn As Integer = ScheduleJob(PC.Name, Trim(newprocess.Text), interactive.Checked, sHour & ":" & sMinute)

        If rtn = 0 Then
            MsgBox("error creating scheduled task", MsgBoxStyle.Critical)
        Else
            MsgBox("Scheduled task created successfully." & vbCrLf & "JobID: " & CStr(rtn), MsgBoxStyle.Information, "Task Scheduled")
        End If
    End Sub
    Private Sub ScheduleTime_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScheduleTime.TextChanged
        If ScheduleTime.Text.Length = 5 Then
            Dim times() As String = Split(ScheduleTime.Text, ":")
            Dim hr As Integer = CInt(times(0))
            Dim mn As Integer = CInt(times(1))
            If hr >= 0 AndAlso hr < 24 AndAlso mn >= 0 AndAlso mn < 60 Then
                ScheduleButton.Enabled = True
            Else
                ScheduleButton.Enabled = False
            End If
        Else
            ScheduleButton.Enabled = False
        End If
    End Sub
#End Region

#Region "SOFTWARE"

    Private Sub software_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles software_button.Click

        sgrid.Rows.Clear()
        Panel2.Text = "getting installed software..."
        Me.Cursor = Cursors.AppStarting

        Dim swThread As New System.Threading.Thread(AddressOf Enum_Software)
        swThread.Start()
        'Enum_Software()

        Tabholder1.SelectedTab.Refresh()
        Me.Cursor = Cursors.Default
        Panel2.Text = "ready."

    End Sub
    Private Sub Enum_Software()

        If sw_use_wmi_checkbox.Checked Then
            Software_WMI()
        Else
            If AltUserCheckBox.Checked Then

                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    Software_API()
                    impersonator.undoImpersonation()
                Else
                    Software_WMI()
                End If
            Else
                Software_API()
            End If

        End If

        If ShowUpdates.Checked = False Then Show_Updates()
        Me.sgrid.Refresh()


    End Sub

    Public Sub Software_WMI()

        Dim swstart, totaltime As Double
        swstart = Microsoft.VisualBasic.DateAndTime.Timer

        Dim strkeypath, strvaluename, strsubpath As String
        Dim strvalue As String = Nothing
        Dim objsubkey, objDictSoft As Object
        Dim Displayname As String = Nothing
        Dim DisplayVersion As String = Nothing
        Dim Publisher As String = Nothing
        Dim Installdate As String = Nothing
        Dim installlocation As String = Nothing
        Dim uninstallstring As String = Nothing
        Dim urlinfoabout As String = Nothing
        Dim arrSubkeys As Array = Nothing
        Dim strsoftstream As String


        On Error Resume Next

        strkeypath = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"
        arrSubkeys = wmi.RegistryEnumKeys(PC.Name, RegistryHive.LocalMachine, strkeypath)
        For Each objsubkey In arrSubkeys
            strsubpath = strkeypath & "\" & objsubkey

            strvalue = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "DisplayName")
            DisplayVersion = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "DisplayVersion")
            Publisher = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "Publisher")
            Installdate = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "InstallDate")
            installlocation = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "InstallLocation")
            uninstallstring = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "QuietUninstallString")
            urlinfoabout = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, strsubpath, "URLInfoAbout")

            If Not String.IsNullOrEmpty(strvalue) Then
                sgrid.Rows.Add(strvalue, DisplayVersion, Publisher, Installdate, installlocation, uninstallstring, urlinfoabout)
            End If
        Next

        sgrid.Sort(swname, ComponentModel.ListSortDirection.Ascending)

        totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - swstart, 4)
        Panel2.Text = totaltime
    End Sub
    Private Sub Software_API()

        Dim swstart, totaltime As Double
        swstart = Microsoft.VisualBasic.DateAndTime.Timer

        Dim strkeypath, strsubpath As String
        Dim strvalue As String = Nothing
        Dim objsubkey As Object
        Dim Displayname As String = Nothing
        Dim DisplayVersion As String = Nothing
        Dim Publisher As String = Nothing
        Dim Installdate As String = Nothing
        Dim installlocation As String = Nothing
        Dim uninstallstring As String = Nothing
        Dim urlinfoabout As String = Nothing
        Dim arrSubkeys As Array = Nothing
        Dim strsoftstream As String

        On Error Resume Next

        strkeypath = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"

        Dim oReg As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC.Name)
        arrSubkeys = oReg.OpenSubKey(strkeypath).GetSubKeyNames

        For Each objsubkey In arrSubkeys
            strvalue = ""
            strsubpath = strkeypath & "\" & objsubkey
            strvalue = oReg.OpenSubKey(strsubpath).GetValue("DisplayName")
            DisplayVersion = oReg.OpenSubKey(strsubpath).GetValue("DisplayVersion")
            Publisher = oReg.OpenSubKey(strsubpath).GetValue("Publisher")
            Installdate = oReg.OpenSubKey(strsubpath).GetValue("InstallDate")
            installlocation = oReg.OpenSubKey(strsubpath).GetValue("InstallLocation")
            uninstallstring = oReg.OpenSubKey(strsubpath).GetValue("QuietUninstallString")
            urlinfoabout = oReg.OpenSubKey(strsubpath).GetValue("URLInfoAbout")

            If Not String.IsNullOrEmpty(strvalue) Then
                sgrid.Rows.Add(strvalue, DisplayVersion, Publisher, Installdate, installlocation, uninstallstring, urlinfoabout)
            End If
        Next

        sgrid.Sort(swname, ComponentModel.ListSortDirection.Ascending)

        totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - swstart, 4)
        Panel2.Text = totaltime
    End Sub

    Protected Friend swGrid_Name As String
    Protected Friend swGrid_version As String
    Protected Friend swGrid_Date As String
    Protected Friend swGrid_Pub As String
    Protected Friend swGrid_Location As String
    Protected Friend swGrid_Uninst As String
    Protected Friend swGrid_URL As String

    Private Sub sgrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sgrid.DoubleClick
        OpenSoftwarePropertiesDialog()
    End Sub
    ''' <summary>
    ''' Open the SwInfo Form (Dialog) and populate with selected software info.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub OpenSoftwarePropertiesDialog()
        Dim sw As New SwInfo

        ' manually position form (@ center parent) as not working.
        Dim X, Y As Integer
        X = Me.Location.X
        Y = Me.Location.Y
        sw.Location = New Drawing.Point(X + 20, Y - 10)
        sw.StartPosition = FormStartPosition.Manual



        sw.Text = swGrid_Name & " Properties"
        sw.swHostname.Text = PC.Name
        sw.swOS.Text = PC.OperatingSystem.Replace("(R)", "")
        sw.swname.Text = swGrid_Name
        sw.swdate.Text = swGrid_Date
        sw.swpath.Text = swGrid_Location
        sw.swpub.Text = Me.swGrid_Pub
        sw.swuninst.Text = Me.swGrid_Uninst
        If String.IsNullOrEmpty(Me.swGrid_URL) Then
            sw.swURL.Text = ""
        Else
            sw.swURL.Text = Me.swGrid_URL
        End If
        sw.swver.Text = Me.swGrid_version
        sw.swuninst.Text = Me.swGrid_Uninst

        If String.IsNullOrEmpty(Me.swGrid_Uninst) Then
            sw.btnUninstall.Enabled = False
        Else
            sw.btnUninstall.Enabled = True
        End If

        sw.Show()
    End Sub
    Private Sub mnuSwProps_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSwProps.Click
        OpenSoftwarePropertiesDialog()
    End Sub
    Private Sub mnuSwUninst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSwUninst.Click
        UninstallSoftware(PC.Name, swGrid_Uninst)
    End Sub
    ''' <summary>
    ''' Launch remote process to silently uninstall software.
    ''' </summary>
    ''' <param name="Computer"></param>
    ''' <param name="UninstallString"></param>
    ''' <remarks></remarks>
    Public Sub UninstallSoftware(ByVal Computer As String, ByVal UninstallString As String)
        'MsgBox("This feature is not yet implemented." & vbCr & _
        '       "Please be patient (or ask nicely if" & vbCrLf & _
        '       "you are particularly desparate).", MsgBoxStyle.Information, "Your patience is appreciated")

        'Exit Sub
        If Not String.IsNullOrEmpty(UninstallString) Then
            If UninstallString.ToLower.StartsWith("msiexec") Then
                UninstallString = "msiexec /x " & UninstallString.Substring(UninstallString.IndexOf("{")) & " /qn"
            End If
        End If

        RemoteExec(Computer, UninstallString, False)

    End Sub
    Private Sub sgrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sgrid.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then
                ' ensure only current item selected
                sgrid.ClearSelection()
                sgrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.swGrid_Name = sgrid(0, hti.RowIndex).Value
                Me.swGrid_version = sgrid(1, hti.RowIndex).Value
                Me.swGrid_Pub = sgrid(2, hti.RowIndex).Value
                Me.swGrid_Date = sgrid(3, hti.RowIndex).Value
                Me.swGrid_Location = sgrid(4, hti.RowIndex).Value
                Me.swGrid_Uninst = sgrid(5, hti.RowIndex).Value
                Me.swGrid_URL = sgrid(6, hti.RowIndex).Value

                Me.mnuSwName.Text = Me.swGrid_Name
                If String.IsNullOrEmpty(Me.swGrid_Uninst) Then
                    mnuSwUninst.Enabled = False
                Else
                    mnuSwUninst.Enabled = True
                End If

                swContextmenu.Show(sgrid, New Point(e.X, e.Y))
            End If
        Else

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then

                sgrid.ClearSelection()
                sgrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.swGrid_Name = sgrid(0, hti.RowIndex).Value
                Me.swGrid_version = sgrid(1, hti.RowIndex).Value
                Me.swGrid_Pub = sgrid(2, hti.RowIndex).Value
                Me.swGrid_Date = sgrid(3, hti.RowIndex).Value
                Me.swGrid_Location = sgrid(4, hti.RowIndex).Value
                Me.swGrid_Uninst = sgrid(5, hti.RowIndex).Value
                Me.swGrid_URL = sgrid(6, hti.RowIndex).Value

            End If
        End If
    End Sub

    Private Sub ShowUpdates_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowUpdates.CheckedChanged
        Show_Updates()
    End Sub
    Private Sub Show_Updates()
        For i As Integer = 0 To sgrid.RowCount - 1
            If (InStr(LCase(sgrid(0, i).Value), "update") AndAlso InStr(LCase(sgrid(0, i).Value), "windows")) OrElse (InStr(LCase(sgrid(0, i).Value), "hotfix") AndAlso InStr(LCase(sgrid(0, i).Value), "windows")) Then
                sgrid.Rows(i).Visible = ShowUpdates.Checked
            End If
        Next
    End Sub

#End Region

#Region "PRINTERS"

    ' print server
    Private sServer As String
    Private sPrinter As String

    Private Sub printerRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printerRefresh.Click
        RefreshPrinters()
    End Sub
    Private Sub RefreshPrinters()

        Me.Cursor = Cursors.WaitCursor
        printerGrid.Rows.Clear()

        printerGrid.RowTemplate.DefaultCellStyle.BackColor = Color.GreenYellow 'Color.LightBlue
        LocalPrinters(PC.Name)

        printerGrid.RowTemplate.DefaultCellStyle.BackColor = Color.PaleGoldenrod  'Color.CornflowerBlue

        If PC.CurrentUserSID = "error" Or PC.CurrentUserSID = "" Then
            Panel2.Text = "unable to get network printers"
        Else
            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    GetNetworkPrinters()
                    impersonator.undoImpersonation()
                End If
            Else
                GetNetworkPrinters()
            End If
        End If

        printerGrid.ClearSelection()
        printerGrid.Focus()
        Me.Cursor = Cursors.Default
        addthisprinter.Enabled = True
        AddPrinterButton.Enabled = True
        addthisprinter.BackColor = Color.White
    End Sub
    Private Sub LocalPrinters(ByVal strComputer As String)

        Dim sPrinterType As String
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("Select Attributes, Name from Win32_Printer")
        Dim m As ManagementObject

        Try
            For Each m In queryCollection
                If m("Attributes") And 64 Then
                    sPrinterType = "Local"
                Else
                    sPrinterType = "Network"
                End If
                printerGrid.Rows.Add(m("Name"), sPrinterType)
            Next
        Catch ex As Exception
            Panel2.Text = "error enumerating local printers"
            WriteLog(PC.Name & " - error enumerating local printers. " & ex.Message)
        End Try

    End Sub
    Private Sub GetNetworkPrinters()

        ' Declare Variables
        Dim subkey As String
        Dim arrPtrKeys As Array

        ' enumerate Keys in HKU\< SID >\Printers\Connections
        Dim regpath2enumerate As String = PC.CurrentUserSID & "\Printers\Connections"

        Try
            arrPtrKeys = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                            OpenSubKey(regpath2enumerate).GetSubKeyNames
        Catch ex As Exception
            WriteLog(PC.Name & " - Error returning Network Printer SubKeys for sid: " & PC.CurrentUserSID & ". Error: " & ex.Message)
            Panel2.Text = "error enumerating network printers - see log"
            Exit Sub
        End Try

        ' Get printers from name of subkeys
        For Each subkey In arrPtrKeys
            Dim PrinterArray() As String = Split(subkey, ",")
            printerGrid.Rows.Add(PrinterArray(3), PrinterArray(2))
        Next
    End Sub

    Private Sub printerGrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles printerGrid.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then

                ptrproperties.Enabled = True
                ptsvrproperties.Enabled = True
                SetPrinterAsDefaultToolStripMenuItem.Enabled = True

                printerGrid.ClearSelection()
                printerGrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.sPrinter = printerGrid(0, hti.RowIndex).Value
                Me.sServer = printerGrid(1, hti.RowIndex).Value
                If Me.sServer = "Local" Or Me.sServer = "Network" Then
                    DeletePrinterMenu.Enabled = True
                    DeleteNetworkPrinterMenu.Enabled = False
                Else
                    DeletePrinterMenu.Enabled = False
                    DeleteNetworkPrinterMenu.Enabled = True
                End If

                printermenu.Show(printerGrid, New Point(e.X, e.Y))
            Else
                ptrproperties.Enabled = False
                ptsvrproperties.Enabled = False
                SetPrinterAsDefaultToolStripMenuItem.Enabled = False
                printermenu.Show(printerGrid, New Point(e.X, e.Y))
            End If
        End If

    End Sub
    ' Printer Context Menu
    Private Sub ptrproperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptrproperties.Click
        If Me.sServer = "Local" Or sServer = "Network" Then sServer = PC.Name
        GetPrinterProperties(sServer, sPrinter)
    End Sub
    Private Sub GetPrinterProperties(ByVal strcomputer As String, ByVal strprinter As String)
        Shell("cmd /c rundll32 printui.dll, PrintUIEntry /p /n" & Chr(34) & "\\" & strcomputer & "\" & strprinter & Chr(34), 0, False)
    End Sub
    Private Sub ptsvrproperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptsvrproperties.Click
        If Me.sServer = "Local" Or sServer = "Network" Then sServer = PC.Name
        Shell("cmd /c rundll32 printui.dll, PrintUIEntry /s /t1 /n\\" & Me.sServer, AppWinStyle.Hide, False)
    End Sub
    Private Sub addptr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addptr.Click
        Shell("cmd /c rundll32 printui.dll, PrintUIEntry /il /c\\" & PC.Name, 0, False)
        WriteLog(PC.Name & " - Add printer wizard launched")
    End Sub
    Private Sub addnwkptr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        addthisprinter.Enabled = True
        AddPrinterButton.Enabled = True
        addthisprinter.BackColor = Color.White
    End Sub
    Private Sub ptrrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ptrrefresh.Click
        RefreshPrinters()
    End Sub

    ' add network printer
    Private Sub AddPrinterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPrinterButton.Click
        If Mid(addthisprinter.Text, 1, 2) <> "\\" Or _
        InStr(Mid(addthisprinter.Text, 3, addthisprinter.Text.Length - 3), "\") = 0 Then
            MsgBox("check syntax. (\\servername\printer)")
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        If addptr4all.Checked Then
            AddPrinterForAllUsers()
        Else
            ' add reg entries for network printer
            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    AddPrinterForCurrent()
                    impersonator.undoImpersonation()
                End If
            Else
                AddPrinterForCurrent()
            End If
        End If

        restartservice("Spooler")

        RefreshPrinters()

        addthisprinter.BackColor = System.Drawing.SystemColors.Control
        addthisprinter.Enabled = False
        AddPrinterButton.Enabled = False
        Me.Cursor = Cursors.Default
        WriteLog(PC.Name & " - Install network printer: " & addthisprinter.Text)
    End Sub
    Private Sub AddPrinterForAllUsers()

        Try
            Shell("rundll32 printui.dll,PrintUIEntry /ga /c\\" & PC.Name & " /n" & addthisprinter.Text, 0, True, 10)
            WriteLog(PC.Name & " - added network printer: " & addthisprinter.Text)
        Catch ex As Exception
            MsgBox("unable to add printer")
            WriteLog(PC.Name & " - add printer for all users failed: " & ex.Message)
            Exit Sub
        End Try


    End Sub
    Private Sub AddPrinterForCurrent()

        Dim regkey As Microsoft.Win32.RegistryKey
        Dim basekey As Microsoft.Win32.RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name)

        ' check key exists "HKU\SID\Printers"
        regkey = basekey.OpenSubKey(PC.CurrentUserSID & "\Printers")
        If regkey Is Nothing Then basekey.OpenSubKey(PC.CurrentUserSID, True).CreateSubKey("Printers")

        ' check key exists "HKU\SID\Printers\connections"
        regkey = basekey.OpenSubKey(PC.CurrentUserSID & "\Printers\Connections")
        If regkey Is Nothing Then basekey.OpenSubKey(PC.CurrentUserSID & "\Printers", True).CreateSubKey("Connections")

        ' get servername and printername
        Dim printer As String = Replace(addthisprinter.Text, "\", ",", , 3)
        Dim pArray As Array = Split(printer, ",")

        ' create new subkey ",,server,printer"
        basekey.OpenSubKey(PC.CurrentUserSID & "\Printers\Connections", True).CreateSubKey(printer)
        basekey.OpenSubKey(PC.CurrentUserSID & "\Printers\Connections\" & printer, True).SetValue("Provider", "win32spl.dll", RegistryValueKind.String)
        basekey.OpenSubKey(PC.CurrentUserSID & "\Printers\Connections\" & printer, True).SetValue("Server", pArray(2), RegistryValueKind.String)

    End Sub

    ' Delete printer
    Private Sub DeletePrinterMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeletePrinterMenu.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Refresh()
        If DeleteLocalPrinterFromRegistry(Me.sPrinter) = True Then
            restartservice("Spooler")
            RefreshPrinters()
            WriteLog(PC.Name & " - deleted local printer (reg): " & Me.sPrinter)
        ElseIf DeleteLocalPrinter_WMI(Me.sPrinter) Then
            restartservice("Spooler")
            RefreshPrinters()
            WriteLog(PC.Name & " - deleted local printer (wmi): " & Me.sPrinter)
        Else
            MsgBox("Delete Printer Failed")
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Function DeleteLocalPrinterFromRegistry(ByVal printername As String) As Boolean
        Dim subkey As String = "System\CurrentControlSet\Control\Print\Printers"
        Dim arrSubkeys As Array = wmi.RegistryEnumKeys(PC.Name, RegistryHive.LocalMachine, subkey)
        Dim printerkey As String = ""

        If arrSubkeys Is Nothing Then
            Return False
            Exit Function
        End If

        For Each strPrintername As String In arrSubkeys
            If LCase(strPrintername) = LCase(printername) Then
                printerkey = subkey & "\" & strPrintername
                Exit For
            End If
        Next

        If printerkey = "" Then
            MsgBox("printer not found")
            Return False
            Exit Function
        End If

        If wmi.RegistryDeleteKeyRecursive(PC.Name, RegistryHive.LocalMachine, printerkey) Then
            Return True
        Else
            Return False
        End If

    End Function

    ' Set Default Printer
    Private Sub SetPrinterAsDefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetPrinterAsDefaultToolStripMenuItem.Click
        Me.Cursor = Cursors.WaitCursor

        If AltUserCheckBox.Checked Then
            Dim impersonator As New Impersonation
            If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                SetDefaultPrinter(sPrinter)
                impersonator.undoImpersonation()
            End If
        Else
            SetDefaultPrinter(sPrinter)
        End If
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub SetDefaultPrinter(ByVal printername As String)


        If Me.sServer = "Local" OrElse Me.sServer = "Network" Then
            ' locally installed
        Else
            printername = "\\" & Me.sServer & "\" & Me.sPrinter
        End If

        ' get name of selected printer <printername>
        ' read port info from:
        '   hku\<sid>\software\microsoft\windows nt\currentversion\devices\<printername> - <portvalue>
        ' set value of 
        '   hku\<sid>\software\microsoft\windows nt\currentversion\windows
        '           (value)=device (data)=<printername> & "," & <portvalue>


        ' Declare Variables
        Dim portVal As String = String.Empty
        Dim arrPtrKeys As Array
        Dim matched As Boolean = False

        ' enumerate Keys in HKU\< SID >\Printers\Connections
        Dim GetPtrRegPath As String = PC.CurrentUserSID & "\Software\Microsoft\Windows NT\CurrentVersion\Devices"

        Try
            arrPtrKeys = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                            OpenSubKey(GetPtrRegPath).GetValueNames
            For Each pkey As String In arrPtrKeys
                If pkey.ToLower = printername.ToLower Then
                    portVal = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                                OpenSubKey(GetPtrRegPath).GetValue(pkey)
                    matched = True
                End If
            Next

            If Not matched Then
                MsgBox("could not match printer", MsgBoxStyle.Critical, "Default Printer - Error")
                Exit Sub
            End If


            Dim SetPtrRegPath As String = PC.CurrentUserSID & "\Software\Microsoft\Windows NT\CurrentVersion\Windows"

            If Not String.IsNullOrEmpty(portVal) Then
                RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                     OpenSubKey(SetPtrRegPath, True).SetValue("Device", printername & "," & portVal)
            End If
            Panel2.Text = "default printer set: " & printername

        Catch ex As Exception
            WriteLog(PC.Name & " - Error setting default printer. SID=" & PC.CurrentUserSID & ". Printer=" & printername & ". Error: " & ex.Message)
            Panel2.Text = "error setting default printer - see log"
        End Try

    End Sub

    ' Delete Network Printer - Current User
    Private Sub ForThisUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForThisUserToolStripMenuItem.Click

        ' enumerate subkeys of "HKU\SID\Printers\Connections"
        Dim arrPrinters As Array = wmi.RegistryEnumKeys(PC.Name, RegistryHive.Users, _
                                    PC.CurrentUserSID & "\Printers\Connections")
        Dim ptrkey As String
        For Each ptrkey In arrPrinters
            If LCase(ptrkey) = ",," & LCase(Me.sServer) & "," & LCase(Me.sPrinter) Then
                wmi.RegistryDeleteKey(PC.Name, RegistryHive.Users, PC.CurrentUserSID & "\Printers\Connections\" & ptrkey)
            End If
        Next

        RefreshPrinters()

    End Sub
    ' Delete Network Printer - All Users
    Private Sub ForAllUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForAllUsersToolStripMenuItem.Click

        Me.Refresh()
        Me.Cursor = Cursors.WaitCursor

        Try
            Shell("rundll32 printui.dll,PrintUIEntry /gd /c\\" & PC.Name & " /n\\" & Me.sServer & "\" & Me.sPrinter, 0, True, 10)
            WriteLog(PC.Name & " - added network printer: " & addthisprinter.Text)
        Catch ex As Exception
            MsgBox("unable to delete printer")
            WriteLog(PC.Name & " - delete printer for all users failed: " & ex.Message)
            Exit Sub
            Me.Cursor = Cursors.Default
        End Try

        Me.sGridName = "Spooler"
        restartservice()

        Me.Cursor = Cursors.Default

        RefreshPrinters()


    End Sub

    Private Sub printerGrid_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles printerGrid.MouseLeave
        printerGrid.ClearSelection()
    End Sub

    ' Test
    Private Sub addnwkptr()
        Dim addPrn As New System.Management.ManagementClass("Win32_Printer")
        Dim objShareName() As Object = {"\\prnsrvr\RICOH_PS"}
        addPrn.InvokeMethod("AddPrinterConnection", objShareName)
    End Sub
    Private Sub AddTCPIP_Printer()
        'String portNumber = "9100";
        'String printerIP = "99.99.1.1";
        'String portName = "IP_" + printerIP;
        'Try
        '{
        'ConnectionOptions options = new ConnectionOptions();
        'options.EnablePrivileges = true;
        'ManagementScope mscope = new ManagementScope(@"\root\CIMV2"
        'options);
        'mscope.Connect();

        'ManagementPath(mpPort = ne)
        'ManagementPath("Win32_TCPIPPrinterPort");
        'ManagementClass mcPort = new ManagementClass(mscope, mpPort
        'new ObjectGetOptions());
        'ManagementObject moPort = mcPort.CreateInstance();
        'moPort.Properties["Name"].Value = portName;
        'moPort.Properties["HostAddress"].Value = printerIP;
        'moPort.Properties["PortNumber"].Value = portNumber;
        'moPort.Properties["Protocol"].Value = 1;
        'moPort.Put();

        'ManagementPath(mpPrinter = ne)
        'System.Management.ManagementPath("Win32_Printer");
        'ManagementClass mcPrinter = new ManagementClass(mscope
        'mpPrinter, new ObjectGetOptions());
        'ManagementObject moPrinter = mcPrinter.CreateInstance();

        'moPrinter.Properties["Name"].Value = "99.99";
        'moPrinter.Properties["DeviceID"].Value = "99.99";
        'moPrinter.Properties["DriverName"].Value = "Generic / Tex
        'Only(";")
        'moPrinter.Properties["PortName"].Value = portName;
        'moPrinter.Properties["Network"].Value = true;
        'moPrinter.Properties["Shared"].Value = false;
        'moPrinter.Put();
        '}
        'Catch(Exception ex)
        '{
        'Console.Writeline(ex.toString());
        '}
    End Sub
    Private Function DeleteLocalPrinter_WMI(ByVal PrinterName As String) As Boolean

        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("Select * from Win32_Printer")
        Dim m As ManagementObject

        Try
            For Each m In queryCollection
                If LCase(m("Name")) = LCase(PrinterName) Then
                    'm.InvokeMethod("Delete_", Nothing)
                    m.Delete()
                End If
            Next
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "Mapped Drives"

    Private sDrivesInUse As String

    Private Sub MappedDrivesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MappedDrivesButton.Click
        Me.Cursor = Cursors.WaitCursor
        mappings.Items.Clear()
        If PC.CurrentUserSID = "" Then PC.CurrentUserSID = GetSID(PC.CurrentUser)
        If PC.CurrentUserSID = "error" Then
            Panel2.Text = "error identifying user SID"
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        If AltUserCheckBox.Checked Then
            Dim impersonator As New Impersonation
            If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                GetMappedDrives(PC.CurrentUserSID)
                impersonator.undoImpersonation()
            Else
                MsgBox("user credentials not accepted")
            End If
        Else
            GetMappedDrives(PC.CurrentUserSID)
        End If

        mappings.Focus()
        deletemappeddrive.Enabled = False
        Me.Cursor = Cursors.Default
    End Sub

    ' Connects to HKU to read mapped drives for SID
    Private Sub GetMappedDrives(ByVal SIDsubkey As String)

        Dim arrRegKeys As Array = Nothing
        Dim arrkeynames As Array = Nothing
        Dim subkey As String
        Dim drivepath As String = ""
        Dim regpath As String
        Dim sidssubkey As String

        ' Check if HKU\[SID]\NETWORK subkey exists
        Dim checkKeys As Microsoft.Win32.RegistryKey = RegistryKey.OpenRemoteBaseKey _
        (RegistryHive.Users, PC.Name).OpenSubKey(PC.CurrentUserSID & "\Network")


        If checkKeys Is Nothing Then
            mappings.Items.Add("no mapped drives")
            addmappeddrive_button.Enabled = True
            Exit Sub
        End If


        ' enumerate SubKeys in: HKEY_LOCAL_USERS\[SID]\Network
        regpath = SIDsubkey & "\Network"

        Try
            ' Service Pack 4 check
            If PC.OS = "Windows 2000" AndAlso PC.ServicePack = "Service Pack 4" Then
                Dim arrsidsubkeys As Array = RegistryKey.OpenRemoteBaseKey _
                (RegistryHive.Users, PC.Name).OpenSubKey(PC.CurrentUserSID & "\Network").GetSubKeyNames

                If arrsidsubkeys.Length = 0 Then
                    mappings.Items.Add("no mapped drives")
                    addmappeddrive_button.Enabled = True
                    Exit Sub
                End If
                For Each sidssubkey In arrsidsubkeys
                    drivepath = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, _
                    PC.Name).OpenSubKey(PC.CurrentUserSID & "\Network\" & sidssubkey).GetValue("RemotePath")
                    mappings.Items.Add(sidssubkey & ": " & drivepath)
                    Me.sDrivesInUse = Me.sDrivesInUse & SIDsubkey & ":"
                Next
            Else ' Not service pack 4
                arrkeynames = wmi.RegistryEnumKeys(PC.Name, RegistryHive.Users, regpath)
                If arrkeynames Is Nothing Then
                    mappings.Items.Add("no mapped drives")
                Else
                    Dim drives As String = ""
                    For Each subkey In arrkeynames
                        drivepath = wmi.RegistryGetStringValue(PC.Name, RegistryHive.Users, regpath & "\" & subkey, "RemotePath")
                        mappings.Items.Add(subkey & ": " & drivepath)
                        Me.sDrivesInUse = Me.sDrivesInUse & subkey & ":"
                    Next
                End If
            End If

            ' enable add mapped drive button
            addmappeddrive_button.Enabled = True
        Catch ex As System.NullReferenceException
        End Try

    End Sub

    Private Sub mappings_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mappings.MouseDoubleClick
        Try
            If mappings.SelectedItem.ToString = "no mapped drives" Then Exit Sub
            Dim sFolder As String = Mid(mappings.SelectedItem, 4, mappings.SelectedItem.ToString.Length - 3)
            'openfolder(sFolder)
            Dim dShell As Double
            dShell = Shell("Explorer /n," & sFolder, vbNormalFocus, False)
            WriteLog(PC.Name & " - Accessed network drive: " & sFolder)
        Catch ex As System.NullReferenceException
            MsgBox("nothing selected")
        End Try
    End Sub
    Private Sub addmappeddrive_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addmappeddrive_button.Click

        Dim sDriveLetter As String = Mid(UCase(addmappeddrive_letter.Text), 1, 1)
        Dim sDrivePath As String = addmappeddrive_path.Text

        ' Check drive letter
        If String.IsNullOrEmpty(sDriveLetter) Then
            MsgBox("drive letter is empty")
            Exit Sub
        ElseIf InStr(DrivesInUse, sDriveLetter) <> 0 Then
            MsgBox("Drive " & sDriveLetter & ": is already in use." & vbCrLf & "Please use another letter")
            Exit Sub
        End If

        ' Check drivepath
        If Mid(sDrivePath, 1, 2) <> "\\" Then
            MsgBox("mapped drive path should be in the form '\\servername\sharename'")
            Exit Sub
        ElseIf InStr(Mid(sDrivePath, 4, sDrivePath.Length - 4), "\") = 0 Then
            MsgBox("mapped drive path should be in the form '\\servername\sharename'")
            Exit Sub
        End If


        ' Call drive mapping Function

        If Not AltUserCheckBox.Checked Then
            Try
                Add_Mapped_Drive_API(sDriveLetter, sDrivePath)
            Catch ex As Exception
                Add_Mapped_Drive_WMI(sDriveLetter, sDrivePath)
            End Try
        Else
            Try
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    Add_Mapped_Drive_API(sDriveLetter, sDrivePath)
                    impersonator.undoImpersonation()
                End If
            Catch ex As Exception
                Add_Mapped_Drive_WMI(sDriveLetter, sDrivePath)
            End Try
        End If



        ' Refresh listbox

        mappings.Items.Clear()
        GetMappedDrives(PC.CurrentUserSID)

    End Sub
    Private Function DrivesInUse() As String
        Dim DrivesUsed As String = "A:B:"
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("SELECT DeviceID FROM Win32_LogicalDisk")
        For Each m In queryCollection
            DrivesUsed = DrivesUsed & m("DeviceID")
        Next
        Me.sDrivesInUse = Me.sDrivesInUse & DrivesUsed
        Return Me.sDrivesInUse
    End Function
    Private Sub Add_Mapped_Drive_API(ByVal letter As String, ByVal UNC_Path As String)

        Dim strKeyPath As String
        Dim arrSubKeys As Array = Nothing
        Dim subkey As String
        Dim bNetworkKey As Boolean = False

        ' Add mapping reg entries
        Try
            ' check if HKU\*SID*\NETWORK exists
            bNetworkKey = False
            arrSubKeys = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(PC.CurrentUserSID, True).GetSubKeyNames
            For Each subkey In arrSubKeys
                If LCase(subkey) = "network" Then bNetworkKey = True
            Next

            ' create NETWORK subkey 
            If bNetworkKey = False Then

                RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                    OpenSubKey(PC.CurrentUserSID, True).CreateSubKey("Network")
                RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                    OpenSubKey(PC.CurrentUserSID & "\Network", True).CreateSubKey(letter)

            Else

                strKeyPath = PC.CurrentUserSID & "\Network"
                ' check if drive already in use
                bNetworkKey = False
                arrSubKeys = RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                    OpenSubKey(strKeyPath, True).GetSubKeyNames
                Try
                    For Each subkey In arrSubKeys
                        If UCase(subkey) = letter Then bNetworkKey = True
                    Next
                Catch ex As Exception
                End Try

                If bNetworkKey = False Then
                    ' create subkey
                    RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                        OpenSubKey(PC.CurrentUserSID & "\Network", True).CreateSubKey(letter)
                Else
                    MsgBox("Drive " & letter & ": is already in use." & vbCrLf & "Please use another letter")
                    Exit Sub
                End If

            End If

            strKeyPath = PC.CurrentUserSID & "\Network\" & letter

            ' write subkey values
            RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(strKeyPath, True).SetValue("ConnectionType", 1, RegistryValueKind.DWord)
            RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(strKeyPath, True).SetValue("DeferFlags", 4, RegistryValueKind.DWord)
            RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(strKeyPath, True).SetValue("ProviderName", "Microsoft Windows Network", RegistryValueKind.String)
            RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(strKeyPath, True).SetValue("ProviderType", 131072, RegistryValueKind.DWord)
            RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(strKeyPath, True).SetValue("RemotePath", UNC_Path, RegistryValueKind.String)
            RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
            OpenSubKey(strKeyPath, True).SetValue("UserName", 0, RegistryValueKind.DWord)

        Catch ex As Exception
            MsgBox("add mapped drive failed. " & vbCrLf & ex.Message)
        End Try

    End Sub
    Private Sub Add_Mapped_Drive_WMI(ByVal letter As String, ByVal UNC_Path As String)

        Dim strKeyPath As String
        Dim arrSubKeys As Array = Nothing
        Dim subkey As String
        Dim bNetworkKey As Boolean = False

        ' add mapping reg entries
        Try
            ' check if HKU\*SID*\NETWORK exists
            strKeyPath = PC.CurrentUserSID
            arrSubKeys = wmi.RegistryEnumKeys(PC.Name, RegistryHive.Users, strKeyPath)
            For Each subkey In arrSubKeys
                If LCase(subkey) = "network" Then bNetworkKey = True
            Next
            ' create NETWORK subkey 
            If bNetworkKey = False Then
                strKeyPath = PC.CurrentUserSID & "\Network"
                wmi.RegistryCreateKey(PC.Name, RegistryHive.Users, strKeyPath)
            End If


            strKeyPath = PC.CurrentUserSID & "\Network"

            ' check if drive already in use
            bNetworkKey = False
            arrSubKeys = wmi.RegistryEnumKeys(PC.Name, RegistryHive.Users, strKeyPath)
            Try
                For Each subkey In arrSubKeys
                    If UCase(subkey) = letter Then bNetworkKey = True
                Next
            Catch ex As System.NullReferenceException
                'MsgBox("null")
            End Try

            strKeyPath = PC.CurrentUserSID & "\Network\" & letter

            If bNetworkKey = False Then
                ' create subkey
                wmi.RegistryCreateKey(PC.Name, RegistryHive.Users, strKeyPath)
            Else
                MsgBox("Drive " & letter & ": is already in use." & vbCrLf & "Please use another letter")
                Exit Sub
            End If


            ' write subkey values
            wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.Users, strKeyPath, "ConnectionType", 1)
            wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.Users, strKeyPath, "DeferFlags", "4")
            wmi.RegistrySetStringValue(PC.Name, RegistryHive.Users, strKeyPath, "ProviderName", "Microsoft Windows Network")
            wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.Users, strKeyPath, "ProviderType", "131072")
            wmi.RegistrySetStringValue(PC.Name, RegistryHive.Users, strKeyPath, "RemotePath", UNC_Path)
            wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.Users, strKeyPath, "UserName", "0")

        Catch ex As Exception
            MsgBox("add mapped drive failed. " & vbCrLf & ex.Message)
        End Try

    End Sub
    Private Sub deletemappeddrive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deletemappeddrive.Click

        Dim sDriveToDelete As String = Mid(UCase(Trim(mappings.SelectedItem.ToString)), 1, 1)
        Try
            Dim strKeyPath As String = PC.CurrentUserSID & "\Network\" & sDriveToDelete

            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                            OpenSubKey(PC.CurrentUserSID & "\Network", True).DeleteSubKey(sDriveToDelete)
                    impersonator.undoImpersonation()
                Else
                    wmi.RegistryDeleteKey(PC.Name, RegistryHive.Users, strKeyPath)
                End If
            Else
                RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, PC.Name). _
                     OpenSubKey(PC.CurrentUserSID & "\Network", True).DeleteSubKey(sDriveToDelete)
            End If

            ' refresh listbox
            WriteLog(PC.Name & " - Mapped drive deleted: " & mappings.SelectedItem.ToString)
            mappings.Items.Clear()
            GetMappedDrives(PC.CurrentUserSID)

        Catch
        End Try
    End Sub

    Private Sub addmappeddrive_letter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addmappeddrive_letter.TextChanged
        addmappeddrive_letter.Text = UCase(addmappeddrive_letter.Text)
        addmappeddrive_letter.Select(2, 1)
    End Sub
    Private Sub mappings_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mappings.SelectedIndexChanged
        Dim sSelection As String = Trim(LCase(mappings.SelectedItem.ToString))
        If sSelection <> "" And InStr(sSelection, "no mapped drives") = 0 And PC.CurrentUserSID <> "" Then
            deletemappeddrive.Enabled = True
        End If
    End Sub

    Private Sub ClearPrinters()
        printerGrid.Rows.Clear()
        mappings.Items.Clear()
        mappeddrivesGroupBox.Text = "persistent mapped drives"
        addthisprinter.Text = "\\server\printer"
        AddPrinterButton.Enabled = False
        addptr.Enabled = False
        ptrrefresh.Enabled = False
        addthisprinter.BackColor = System.Drawing.SystemColors.Control
        addthisprinter.Enabled = False
        Me.sServer = ""
        Me.sPrinter = ""
        MappedDrivesMenu.Enabled = False
        addmappeddrive_letter.Text = ""
        addmappeddrive_path.Text = ""
        addmappeddrive_button.Enabled = False
        deletemappeddrive.Enabled = False
        SetPrinterAsDefaultToolStripMenuItem.Enabled = False
    End Sub


#End Region

#Region "TOOLS TAB"

    Sub RenameButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameArea.Click

        Panel2.Text = "getting information for rename function..."
        RenameGroupBox.Enabled = True

        Dim strdomain, strmember As String

        oldname.Text = Label_Name.Text
        netdomname.Text = My.User.Name


        strdomain = PC.DomainName
        Select Case PC.DomainRole
            Case "Standalone Workstation"
                strmember = "Workgroup"
                domainroleLabel.Text = PC.DomainRole & ": " & Label_Name.Text & vbCrLf & strmember & ": " & strdomain
            Case "Member Workstation"
                strmember = "Domain"
                domainroleLabel.Text = PC.DomainRole & ": " & Label_Name.Text & vbCrLf & strmember & ": " & strdomain
                netdomname.Enabled = True
                netdompass.Enabled = True
            Case "Standalone Server"
                strmember = "Workgroup"
                domainroleLabel.Text = PC.DomainRole & ": " & Label_Name.Text & vbCrLf & strmember & ": " & strdomain
            Case "Member Server"
                strmember = "Domain"
                domainroleLabel.Text = PC.DomainRole & ": " & Label_Name.Text & vbCrLf & strmember & ": " & strdomain
                netdomname.Enabled = True
                netdompass.Enabled = True
            Case "Domain Controller"
                strmember = "PDC/BDC of Domain"
                domainroleLabel.Text = PC.DomainRole & vbCrLf & strmember & ": " & strdomain
                RenameIt.Enabled = False
        End Select

        Panel2.Text = "ready"
    End Sub
    Private Sub RenameIt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RenameIt.Click

        If newname.Text = "" Or newname.Text = oldname.Text Then
            Panel2.Text = "cannot continue with rename - check details"
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim strmember As String = ""
        Dim strkeypath, strvaluename As String

        strmember = "pdc"
        If InStr(PC.DomainRole, "Member") Then strmember = "Domain"
        If InStr(PC.DomainRole, "Standalone") Then strmember = "Workgroup"

        Select Case strmember
            Case "Domain"
                Panel2.Text = "renaming domain computer and computer Account..."
                Shell(Chr(34) & My.Application.Info.DirectoryPath & "\files\netdom.exe" & Chr(34) & " renamecomputer " & oldname.Text & " /NewName:" & newname.Text & " /UserD:" & netdomname.Text & " /PasswordD:" & netdompass.Text, AppWinStyle.Hide, True)
                Panel2.Text = "ready"
            Case "Workgroup"
                On Error Resume Next
                Panel2.Text = "renaming standalone computer..."

                strkeypath = "System\CurrentControlSet\Control\ComputerName\ComputerName"
                strvaluename = "ComputerName"
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, strkeypath, strvaluename, newname.Text)

                strkeypath = "System\CurrentControlSet\Control\ComputerName\ActiveComputerName"
                strvaluename = "ComputerName"
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, strkeypath, strvaluename, newname.Text)

                strkeypath = "System\CurrentControlSet\Services\Tcpip\Parameters"
                strvaluename = "HostName"
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, strkeypath, strvaluename, newname.Text)

                strvaluename = "NV HostName"
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, strkeypath, strvaluename, newname.Text)

                Panel2.Text = "ready"
            Case Else
                Panel2.Text = "cannot rename a domain controller"
        End Select

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub joinbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles joinbutton.Click

        notification_label.Text = ""
        joinbutton.Enabled = False

        Dim localusername, localuserpass As String

        If domaintojoin.Text = "" Or joindomuser.Text = "" Or joindompass.Text = "" Then
            notification_label.Text = "ensure all details entered"
            Exit Sub
        End If

        If InStr(domaintojoin.Text, ".") = 0 Then
            notification_label.Text = "requires dns domain name"
            Exit Sub
        End If

        If AltUserCheckBox.Checked = False Then
            localusername = My.User.Name
            localuserpass = joindompass.Text
        Else
            localusername = altusername_TextBox.Text
            localuserpass = altPassword_TextBox.Text
        End If

        Try
            'Shell(Chr(34) & My.Application.Info.DirectoryPath & _
            '  "\files\netdom" & Chr(34) & " join " & PC.Name & " /Domain:" & _
            '  domaintojoin.Text & " /UserD:" & joindomuser.Text & " /PasswordD:" & _
            '  joindompass.Text & " /UserO:" & localusername & " /PasswordO:" & _
            '  localuserpass, 0, True)

            Dim netdompath As String = My.Application.Info.DirectoryPath.ToLower & "\files\netdom"
            If System.Diagnostics.Debugger.IsAttached Then
                netdompath = netdompath.Replace("cmc\cmc\bin\files\netdom.exe", "cmc\cmc\resources\files\netdom.exe")
            End If

            If File.Exists(netdompath) Then
                Dim p As New Process
                Dim psi As ProcessStartInfo = New ProcessStartInfo
                psi.FileName = netdompath
                If ConnectionExists Then
                    psi.Arguments = "join " & PC.Name & " /Domain:" & domaintojoin.Text & _
                                    " /UserD:" & joindomuser.Text & " /PasswordD:" & joindompass.Text & _
                                    " /UserO:" & localusername & " /PasswordO:" & localuserpass
                End If
                p.StartInfo = psi
                p.Start()
            End If


            ' set logon screen options
            If domainlogon.Checked Then
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\Microsoft\Windows NT\CurrentVersion\WinLogon", "DefaultDomainName", UCase(cmcUser.userdomain))
                wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.LocalMachine, "Software\Microsoft\Windows NT\CurrentVersion\WinLogon", "ShowLogonOptions", 1)
            Else
                wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\Microsoft\Windows NT\CurrentVersion\WinLogon", "DefaultDomainName", UCase(PC.Hostname))
                wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.LocalMachine, "Software\Microsoft\Windows NT\CurrentVersion\WinLogon", "ShowLogonOptions", 0)
            End If

            ' set dns suffix
            wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, _
                "System\CurrentControlSet\services\Tcpip\Parameters", "Domain", domaintojoin.Text)

            ' reboot option
            If netdomreboot.Checked Then
                RebootPC(Win32ShutdownFlag.ForceReboot)
            End If

        Catch
            Panel2.Text = "unable to complete request"
        End Try

        joinbutton.Enabled = True
    End Sub
    Private Sub domaintojoin_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles domaintojoin.DoubleClick
        domaintojoin.Text = cmcUser.dnsdomain
    End Sub

    Public Sub runcommand(ByVal commandtorun As String, Optional ByVal WindowStyle As AppWinStyle = AppWinStyle.NormalFocus)
        Try
            Shell("CMD /K " & commandtorun & " " & PC.Name, WindowStyle, False)
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Ping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ping.Click
        If pingcontinuous.Checked Then
            runcommand("ping -t ")
        Else
            runcommand("ping")
        End If
    End Sub
    Private Sub tracert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tracert.Click
        runcommand("tracert")
    End Sub
    Private Sub nbtstat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nbtstat.Click
        runcommand("nbtstat -a")
    End Sub


#End Region

#Region "AD User"

    Private Sub samaccountname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samaccountname.TextChanged
        If samaccountname.Text.Length > 4 Then
            userupdate_button.Enabled = True
        Else
            userupdate_button.Enabled = False
        End If
        If samaccountname.Text.Contains("\") Then
            btn_dsa.Enabled = True
        Else
            btn_dsa.Enabled = False
        End If
    End Sub
    ' front screen button
    Private Sub adbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adbutton.Click

        Panel2.Text = "Searching for account..."
        ClearADUser()
        samaccountname.Text = Label_User.Text
        Tabholder1.SelectTab(aduser)
        Tabholder1.Refresh()

        Me.Cursor = Cursors.WaitCursor

        Tabholder1.SelectTab(aduser)
        ADUserProfile2(Label_User.Text)

        Me.Cursor = Cursors.Default
        Panel2.Text = "ready"



        'Me.Cursor = Cursors.WaitCursor
        'Dim Path As String = My.Application.Info.DirectoryPath.ToLower & "\files\admgmt.exe"
        'If System.Diagnostics.Debugger.IsAttached Then
        '    Path = Path.Replace("cmc\bin\files\admgmt.exe", "admgmt\obj\Debug\admgmt.exe")
        'End If

        'If File.Exists(Path) Then
        '    Dim p As New Process
        '    Dim psi As ProcessStartInfo = New ProcessStartInfo
        '    psi.FileName = Path
        '    If ConnectionExists Then
        '        psi.Arguments = "/d:" & PC.CurrentUserDomain & " /u:" & Chr(34) & PC.CurrentUser & Chr(34)
        '    End If
        '    p.StartInfo = psi
        '    p.Start()
        'End If
        'Me.Cursor = Cursors.Default

        'Me.GO_Button.Focus()

    End Sub
    ' Go button
    Private Sub userupdate_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userupdate_button.Click
        Me.Cursor = Cursors.WaitCursor
        Panel2.Text = "Searching for account..."
        Dim tempADuser As String = Trim(samaccountname.Text)
        ClearADUser()
        samaccountname.Text = tempADuser
        ADUserProfile2(tempADuser)
        Panel2.Text = "ready"
        Me.Cursor = Cursors.Default
    End Sub

    ''' <summary>
    ''' Determine the default naming context for the domain.
    ''' </summary>
    ''' <returns>aDSPath / empty string</returns>
    ''' <remarks></remarks>
    Private Function GetLocalRootLDAP() As String

        Dim strLDAPPath As String = String.Empty
        Dim rootDSE As DirectoryEntry = _
            New DirectoryEntry("LDAP://RootDSE", Nothing, Nothing, AuthenticationTypes.Secure)

        Dim bindTest As Object
        Dim domainPath As String = String.Empty
        Try
            bindTest = rootDSE.NativeObject
            domainPath = rootDSE.Properties("defaultNamingContext")(0)
            strLDAPPath = "LDAP://" & domainPath
        Catch ex As System.Runtime.InteropServices.COMException
            strLDAPPath = ""
        End Try
        Return strLDAPPath

    End Function
    Private Sub ADUserProfile2(ByVal strUser As String)

        Dim LDAPPath As String = String.Empty
        Dim username As String = Nothing ' or DOMAIN\username
        Dim password As String = Nothing

        ' Identify the target users Netbios domain and username
        Dim sUsername As String
        Dim sUserNTDomain As String

        If strUser.Contains("\") Then
            sUsername = strUser.Substring(strUser.LastIndexOf("\") + 1)
            sUserNTDomain = strUser.Substring(0, strUser.LastIndexOf("\"))
        Else ' assume on my domain...
            sUsername = strUser
            If cmcUser.User_ADMember Then
                sUserNTDomain = cmcUser.userdomain
            Else
                MsgBox("Unable to determine the target users domain." & vbCr & vbCr & _
                       "Please enter the username in the form" & vbCr & _
                       "  <domain>\<username>", _
                       MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Unknown Domain")
                Exit Sub
            End If
        End If


        ' Get aDSPath for domain
        Dim cd As New CustomDomainInfo

        '     if user on my domain
        If sUserNTDomain.ToLower = cmcUser.userdomain.ToLower Then
            ' check for custom entry
            If cd.Found(sUserNTDomain) Then
                LDAPPath = cd.DSPath
                If Not String.IsNullOrEmpty(cd.Username) Then
                    username = cd.NTDomainName & "\" & cd.Username
                    password = cd.Password
                End If
            Else
                Dim ldap As String = GetLocalRootLDAP()
                If Not String.IsNullOrEmpty(ldap) Then
                    LDAPPath = ldap
                Else
                    ' could not determine local aDSPath - request custom info...
                    If MsgBox("Unable to communicate with domain [" & sUserNTDomain & "]" & vbCr & vbCr & _
                                      "Do you want to enter connection information?", MsgBoxStyle.YesNo, "CMC - Unknown Domain") = vbYes Then
                        Dim di As New AddDomainInfo
                        di.ShowDialog()
                        If di.DialogResult = Windows.Forms.DialogResult.OK Then
                            cd = New CustomDomainInfo
                            If cd.Found(sUserNTDomain) Then
                                LDAPPath = cd.DSPath
                                If Not String.IsNullOrEmpty(cd.Username) Then
                                    username = cd.NTDomainName & "\" & cd.Username
                                    password = cd.Password
                                End If
                            End If
                        Else
                            Exit Sub
                        End If
                    Else
                        Exit Sub
                    End If
                End If
            End If
        Else ' not on my domain...
            If cd.Found(sUserNTDomain) Then
                LDAPPath = cd.DSPath
                If Not String.IsNullOrEmpty(cd.Username) Then
                    username = cd.NTDomainName & "\" & cd.Username
                    password = cd.Password
                End If
            Else
                cd = Nothing
                If MsgBox("Unable to communicate with domain [" & sUserNTDomain & "]" & vbCr & vbCr & _
                  "Do you want to enter connection information?", MsgBoxStyle.YesNo, "CMC - Unknown Domain") = vbYes Then
                    Dim di As New AddDomainInfo
                    di.ShowDialog()
                    If di.DialogResult = Windows.Forms.DialogResult.OK Then
                        cd = New CustomDomainInfo
                        If cd.Found(sUserNTDomain) Then
                            LDAPPath = cd.DSPath
                            If Not String.IsNullOrEmpty(cd.Username) Then
                                username = cd.NTDomainName & "\" & cd.Username
                                password = cd.Password
                            End If
                        End If
                    Else
                        Exit Sub
                    End If
                End If
            End If
        End If

        Panel2.Text = "searching " & LDAPPath & "..."
        GetUserProperties(sUsername, LDAPPath, username, password)
        Panel2.Text = "ready"

    End Sub

    ''' <summary>
    ''' Retrieves AD user account properties from selected domain and
    ''' populates AD User tab with results.
    ''' </summary>
    ''' <param name="sAMAccountName"></param>
    ''' <param name="LDAPPath"></param>
    ''' <param name="adusername"></param>
    ''' <param name="adpassword"></param>
    ''' <remarks></remarks>
    Private Sub GetUserProperties(ByVal sAMAccountName As String, ByVal LDAPPath As String, ByVal adusername As String, ByVal adpassword As String)

        Dim de As New DirectoryEntry(LDAPPath, adusername, adpassword, AuthenticationTypes.Secure)
        Using DirSearch As New DirectorySearcher(de)

            With DirSearch
                .PropertiesToLoad.Add("distinguishedName")
                .PropertiesToLoad.Add("mail")
                .PropertiesToLoad.Add("telephoneNumber")
                .PropertiesToLoad.Add("physicalDeliveryOfficeName")
                .PropertiesToLoad.Add("company")
                .PropertiesToLoad.Add("profilePath")
                .PropertiesToLoad.Add("homeDirectory")
                .PropertiesToLoad.Add("homeDrive")
                .PropertiesToLoad.Add("terminalServicesProfilePath")
                .PropertiesToLoad.Add("terminalServicesHomeDirectory")
                .PropertiesToLoad.Add("terminalServicesHomeDrive")
                .PropertiesToLoad.Add("memberOf")

                .Filter = "(&(objectClass=user)(objectCategory=person)(sAMAccountName=" & sAMAccountName & "))"
            End With

            Dim RecordCount As Integer = 0
            Try
                RecordCount = DirSearch.FindAll.Count
                If DirSearch.FindAll.Count = 0 Then
                    MessageBox.Show("User not found", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As System.Runtime.InteropServices.COMException
                'If ex.Message = "The specified domain either does not exist or could not be contacted." Then
                MsgBox(ex.Message)
                Exit Sub
                'End If
            End Try

            For Each sResultSet As SearchResult In DirSearch.FindAll()
                FQDN.Text = Me.GetProperty(sResultSet, "DistinguishedName")
                mail.Text = Me.GetProperty(sResultSet, "mail")
                telephonenumber.Text = Me.GetProperty(sResultSet, "telephoneNumber")
                txtOffice.Text = Me.GetProperty(sResultSet, "physicalDeliveryOfficeName")
                txtCompany.Text = Me.GetProperty(sResultSet, "company")
                profilepath.Text = Me.GetProperty(sResultSet, "profilePath")
                homedirectory.Text = Me.GetProperty(sResultSet, "homeDirectory")
                homedrive.Text = Me.GetProperty(sResultSet, "homeDrive")

                Dim GroupCount As Integer = sResultSet.Properties("memberOf").Count
                For i As Integer = 0 To GroupCount - 1
                    Dim dn As String = CType(sResultSet.Properties("memberOf")(i), String)
                    Dim dnStripped As String = dn.Substring(3, dn.IndexOf(",") - 3)
                    adGroupsListBox.Items.Add(dnStripped)
                Next
            Next

        End Using

        Me.Refresh()
        Panel2.Text = "enumerating terminal services settings"
        ' ts properties cannot be enumerated above...
        Try
            Dim objUser As Object = GetObject("LDAP://" & FQDN.Text)
            TerminalServicesProfilePath.Text = objUser.TerminalServicesProfilePath
            TerminalServicesHomeDirectory.Text = objUser.TerminalServicesHomeDirectory
            TerminalServicesHomeDrive.Text = objUser.TerminalServicesHomeDrive
            tsGroupBox.Enabled = True
        Catch ex As Exception
            'MsgBox("Unable to enumerate terminal" & vbCr & "services information for " & strUser & vbCr & vbCr & ex.Message)
            tsGroupBox.Enabled = False
        End Try
    End Sub
    Public Function GetProperty(ByVal srSearchResult As SearchResult, ByVal strPropertyName As String) As String
        Dim retval As String
        'Returns a property from a search result.
        If srSearchResult.Properties.Contains(strPropertyName) Then
            retval = srSearchResult.Properties(strPropertyName)(0).ToString()
        Else
            retval = String.Empty
        End If
        Return retval
    End Function

    Private Sub btn_EnumGroups_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If FQDN.Text.ToLower.Contains("cn=") Then
            adGroupsListBox.Items.Clear()

            Dim objUser As Object = GetObject("LDAP://" & FQDN.Text)

            Dim strgroup As String
            Dim objgroup As Object

            Try
                For Each strgroup In objUser.memberOf
                    objgroup = GetObject("LDAP://" & strgroup)
                    adGroupsListBox.Items.Add(objgroup.CN)
                Next
            Catch ex As System.Exception
                If ex.Message.Contains("ActiveX") Then
                    ' may be only one group
                    Try
                        objgroup = GetObject("LDAP://" & objUser.memberOf.ToString)
                        adGroupsListBox.Items.Add(objgroup.CN)
                    Catch ex2 As Exception
                        MsgBox("Error enumerating group membership." & vbCr & ex2.Message)
                    End Try

                End If
            End Try

        End If
    End Sub
    Private Sub FQDN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FQDN.TextChanged
        If FQDN.Text.ToLower.Contains("cn=") Then
            tsGroupBox.Enabled = True
        Else
            tsGroupBox.Enabled = False
        End If
    End Sub

    Private Sub aduserprofile(ByVal strNTName As String)

        If InStr(strNTName, "\") = 0 Then
            Dim objWSNet As Object = CreateObject("WScript.Network")
            Dim sNetBIOSDomain As String = objWSNet.UserDomain
            strNTName = sNetBIOSDomain & "\" & strNTName
        End If

        Const ADS_NAME_INITTYPE_GC As Integer = 3
        Const ADS_NAME_TYPE_NT4 As Integer = 3
        Const ADS_NAME_TYPE_1779 As Integer = 1

        Dim objTrans As Object = CreateObject("NameTranslate")

        On Error Resume Next
        objTrans.Init(ADS_NAME_INITTYPE_GC, "")
        objTrans.Set(ADS_NAME_TYPE_NT4, strNTName)
        Dim strUserFQDN As String = objTrans.Get(ADS_NAME_TYPE_1779)

        '====  BIND TO USER   ======================================

        Dim objUser As Object = GetObject("LDAP://" & strUserFQDN)

        '====  Fully Qualified Domain Name  ========================

        FQDN.Text = strUserFQDN

        '====  PROFILE   ===========================================

        objUser.GetInfo()

        samaccountname.Text = objUser.Get("sAMAccountName")
        'givenname.Text = objUser.Get("givenName")
        'sn.Text = objUser.Get("sn")
        '.Add("UserPrincipleName", objUser.Get("userPrincipalName"))
        mail.Text = objUser.Get("mail")
        telephonenumber.Text = objUser.Get("telephoneNumber")
        TerminalServicesProfilePath.Text = objUser.TerminalServicesProfilePath
        TerminalServicesHomeDirectory.Text = objUser.TerminalServicesHomeDirectory
        TerminalServicesHomeDrive.Text = objUser.TerminalServicesHomeDrive
        'adusergrid.Rows.Add("Script Path", objUser.Get("scriptPath"))
        profilepath.Text = objUser.Get("profilePath")
        homedirectory.Text = objUser.Get("homeDirectory")
        homedrive.Text = objUser.Get("homeDrive")


        ''====  GROUP MEMBERSHIP   ==================================

        Dim strgroup As String
        Dim objgroup As Object
        For Each strgroup In objUser.memberOf
            objgroup = GetObject("LDAP://" & strgroup)
            adGroupsListBox.Items.Add(objgroup.CN)
        Next

        Cursor = Cursors.Default
        Err.Number = 0


    End Sub
    Private Sub ClearADUser()

        FQDN.Text = ""

        samaccountname.Text = ""
        mail.Text = ""
        telephonenumber.Text = ""
        TerminalServicesProfilePath.Text = ""
        TerminalServicesHomeDirectory.Text = ""
        TerminalServicesHomeDrive.Text = ""
        profilepath.Text = ""
        homedirectory.Text = ""
        homedrive.Text = ""
        txtOffice.Text = ""
        txtCompany.Text = ""
        tsGroupBox.Enabled = True

        adGroupsListBox.Items.Clear()

    End Sub

    Private Sub homedirectory_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles homedirectory.MouseDoubleClick
        openfolder(homedirectory.Text)
    End Sub
    Private Sub profilepath_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles profilepath.MouseDoubleClick
        openfolder(profilepath.Text)
    End Sub
    Private Sub TerminalServicesHomeDirectory_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TerminalServicesHomeDirectory.MouseDoubleClick
        openfolder(TerminalServicesHomeDirectory.Text)
    End Sub
    Private Sub TerminalServicesProfilePath_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TerminalServicesProfilePath.MouseDoubleClick
        openfolder(TerminalServicesProfilePath.Text)
    End Sub

    Private strpass As String ' ad user password
    Private Sub password1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password1.TextChanged
        If userupdate_button.Enabled = False Then Exit Sub
        If Len(Trim(password1.Text)) >= 5 Then
            password2.Enabled = True
        End If
    End Sub
    Private Sub password2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password2.TextChanged
        If password2.Text = password1.Text Then
            resetpassword.Enabled = True
            strpass = password2.Text
        Else
            resetpassword.Enabled = False
            strpass = Nothing
        End If
    End Sub
    Private Sub resetpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetpassword.Click

        If strpass = Nothing Then
            MsgBox("Error")
            Exit Sub
        End If

        Dim strUserFQDN As String = FQDN.Text

        Dim objUser As Object = GetObject("LDAP://" & strUserFQDN)

        objUser.SetPassword(strpass)

        If forcepasswordchange.Checked Then ' will not work if 'password never expires' set.
            objUser.Put("PwdLastSet", 0)
            objUser.SetInfo() ' ok_btn equiv
        End If

    End Sub

    ' users and computers shortcut (dsc.msc /domain='domainname')
    Private Sub btn_dsa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_dsa.Click
        If samaccountname.Text.Contains("\") Then
            Dim strNTdomain As String = samaccountname.Text.Substring(0, samaccountname.Text.LastIndexOf("\"))
            Dim dsaPath As String = "c:\windows\system32\dsa.msc"
            If File.Exists(dsaPath) Then
                Dim p As New Process
                Dim psi As ProcessStartInfo = New ProcessStartInfo
                psi.FileName = dsaPath
                psi.Arguments = "/domain=" & strNTdomain
                p.StartInfo = psi
                p.Start()
            End If
        End If
    End Sub

#End Region

#Region "Group Policy"

    Protected Friend GPOGridType As String
    Private Shared gpos As ArrayList = New ArrayList
    Protected Friend gpoName As String
    Protected Friend gpoDSPath As String
    Protected Friend scriptPath As String
    Protected Friend script As String

    Private Sub btn_gpo_policies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gpo_policies.Click

        'if pc.name
        Me.GPODataGrid.Cursor = Cursors.AppStarting
        Panel2.Text = "Enumerating applied group policies..."

        GPOGridType = "policy"

        GPODataGrid.Columns(0).HeaderText = "policy (right click for options)"
        GPODataGrid.Columns(0).Width = 290
        GPODataGrid.Columns(1).HeaderText = "type"
        GPODataGrid.Columns(1).Width = 70
        GPODataGrid.Columns(1).Visible = True
        GPODataGrid.Columns(2).HeaderText = "dsPath"
        GPODataGrid.Columns(2).Width = 50
        GPODataGrid.Columns(2).Visible = False
        GPODataGrid.Columns(3).Visible = False

        GPODataGrid.Rows.Clear()

        ' impersonate here
        If AltUserCheckBox.Checked Then
            Dim impersonator As New Impersonation
            If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                EnumGPOPolicies("Machine")
                If Not PC.CurrentUserSID Is Nothing Then
                    gpos.Clear()
                    EnumGPOPolicies("User")
                End If
                impersonator.undoImpersonation()
            End If
        Else
            EnumGPOPolicies("Machine")
            If Not PC.CurrentUserSID Is Nothing Then
                gpos.Clear()
                EnumGPOPolicies("User")
            End If
        End If

        Me.GPODataGrid.Cursor = Cursors.Default
        Panel2.Text = "ready"
    End Sub
    Private Sub btn_startupscripts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_startupscripts.Click

        Panel2.Text = "Enumerating scripts applied from GPOs..."
        Me.GPODataGrid.Cursor = Cursors.WaitCursor

        GPOGridType = "script"
        GPODataGrid.Rows.Clear()

        If PC.OSVersionNumeric > 5 Then

            GPODataGrid.Columns(0).HeaderText = "script (right click for menu)"
            GPODataGrid.Columns(0).Width = 160
            GPODataGrid.Columns(1).HeaderText = "parent policy"
            GPODataGrid.Columns(1).Width = 140
            GPODataGrid.Columns(1).Visible = True
            GPODataGrid.Columns(2).HeaderText = "type"
            GPODataGrid.Columns(2).Width = 70
            GPODataGrid.Columns(2).Visible = True
            GPODataGrid.Columns(3).HeaderText = "path"
            GPODataGrid.Columns(3).Width = 100
            GPODataGrid.Columns(3).Visible = False


            ' impersonate here

            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    EnumGPOScripts("startup")
                    EnumGPOScripts("shutdown")
                    If Not PC.CurrentUserSID Is Nothing AndAlso PC.CurrentUserSID <> "" Then
                        EnumGPOScripts("Logon")
                        EnumGPOScripts("Logoff")
                    End If
                    impersonator.undoImpersonation()
                End If
            Else
                EnumGPOScripts("startup")
                EnumGPOScripts("shutdown")
                If Not PC.CurrentUserSID Is Nothing AndAlso PC.CurrentUserSID <> "" Then
                    EnumGPOScripts("Logon")
                    EnumGPOScripts("Logoff")
                End If
            End If


        Else
            GPODataGrid.Columns(0).HeaderText = "script (right click for menu)"
            GPODataGrid.Columns(0).Width = 290
            GPODataGrid.Columns(1).HeaderText = "parent policy"
            GPODataGrid.Columns(1).Width = 150
            GPODataGrid.Columns(1).Visible = False
            GPODataGrid.Columns(2).HeaderText = "type"
            GPODataGrid.Columns(2).Width = 80
            GPODataGrid.Columns(2).Visible = True
            GPODataGrid.Columns(3).HeaderText = "path"
            GPODataGrid.Columns(3).Width = 100
            GPODataGrid.Columns(3).Visible = False


            ' impersonate here
            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    EnumGPOScripts_2K("startup")
                    EnumGPOScripts_2K("shutdown")
                    If Not PC.CurrentUserSID Is Nothing AndAlso PC.CurrentUserSID <> "" Then
                        EnumGPOScripts_2K("Logon")
                        EnumGPOScripts_2K("Logoff")
                    End If
                    impersonator.undoImpersonation()
                End If
            Else
                EnumGPOScripts_2K("startup")
                EnumGPOScripts_2K("shutdown")
                If Not PC.CurrentUserSID Is Nothing AndAlso PC.CurrentUserSID <> "" Then
                    EnumGPOScripts_2K("Logon")
                    EnumGPOScripts_2K("Logoff")
                End If
            End If
        End If

        Me.GPODataGrid.Cursor = Cursors.Default
        Panel2.Text = "ready"
    End Sub

    Private Sub EnumGPOPolicies(ByVal sBaseKey As String)
        'Each time GPOs are processed, a record of all of the GPOs applied to the user or computer is written to the registry.
        'GPOs applied to the local computer are stored in the following registry path:
        'HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\Group Policy\History
        'GPOs applied to the currently logged on user are stored in the following registry path:
        'HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Group Policy\History

        Dim basekey As String
        Dim hive As RegistryHive
        Select Case LCase(sBaseKey)
            Case "machine"
                basekey = "Software\Microsoft\Windows\CurrentVersion\Group Policy\History"
                hive = RegistryHive.LocalMachine
            Case "user"
                basekey = PC.CurrentUserSID & "\Software\Microsoft\Windows\CurrentVersion\Group Policy\History"
                hive = RegistryHive.Users
            Case Else
                Exit Sub
        End Select

        Dim BaseReg As RegistryKey
        Try
            BaseReg = RegistryKey.OpenRemoteBaseKey(hive, PC.Name).OpenSubKey(basekey)
            Dim iLen As Integer = BaseReg.GetSubKeyNames.Length - 1
            Dim arrGPO(iLen) As String
            For Each SidSubKey As String In BaseReg.GetSubKeyNames
                For Each gposubkey As String In BaseReg.OpenSubKey(SidSubKey).GetSubKeyNames
                    Dim gpoDSPath As String = LCase(BaseReg.OpenSubKey(SidSubKey).OpenSubKey(gposubkey, False).GetValue("DSPath"))
                    Dim gpoName As String = BaseReg.OpenSubKey(SidSubKey).OpenSubKey(gposubkey, False).GetValue("DisplayName")
                    If Not gpos.Contains(LCase(gpoName)) Then
                        gpoDSPath = Replace(Replace(Replace(gpoDSPath, "cn=machine,", ""), "cn=user,", ""), "ldap:", "LDAP:")
                        gpos.Add(LCase(gpoName))
                        GPODataGrid.Rows.Add(gpoName, LCase(sBaseKey), gpoDSPath)
                    End If
                Next
            Next
        Catch ex As NullReferenceException
            ' key not found
        End Try
    End Sub

    Private Sub EnumGPOScripts(ByVal sBaseKey As String)

        Dim basekey As String
        Dim hive As RegistryHive
        Select Case LCase(sBaseKey)
            Case "startup"
                basekey = "Software\Policies\Microsoft\Windows\System\Scripts\Startup"
                hive = RegistryHive.LocalMachine
            Case "shutdown"
                basekey = "Software\Policies\Microsoft\Windows\System\Scripts\Shutdown"
                hive = RegistryHive.LocalMachine
            Case "logon"
                basekey = PC.CurrentUserSID & "\Software\Policies\Microsoft\Windows\System\Scripts\Logon"
                hive = RegistryHive.Users
            Case "logoff"
                basekey = PC.CurrentUserSID & "\Software\Policies\Microsoft\Windows\System\Scripts\Logoff"
                hive = RegistryHive.Users
            Case Else
                Exit Sub
        End Select

        Dim BaseReg As RegistryKey
        Try
            BaseReg = RegistryKey.OpenRemoteBaseKey(hive, PC.Name).OpenSubKey(basekey)
            Dim iLen As Integer = BaseReg.GetSubKeyNames.Length - 1
            Dim arrGPO(iLen) As String
            For Each subStartupKey As String In BaseReg.GetSubKeyNames
                Dim gponame As String = BaseReg.OpenSubKey(subStartupKey, False).GetValue("DisplayName")
                Dim gpoPath As String = BaseReg.OpenSubKey(subStartupKey, False).GetValue("FileSysPath")
                Dim scriptlist As String = ""
                For Each scriptsubkey As String In BaseReg.OpenSubKey(subStartupKey).GetSubKeyNames
                    Dim scriptFullPath As String = BaseReg.OpenSubKey(subStartupKey).OpenSubKey(scriptsubkey, False).GetValue("Script")
                    Dim scriptName As String = scriptFullPath.Substring(scriptFullPath.LastIndexOf("\") + 1)
                    Dim scriptFolder As String = gpoPath & "\Scripts\" & sBaseKey
                    If InStr(scriptFullPath, "\") > 0 Then
                        scriptFullPath = scriptFullPath.Substring(0, scriptFullPath.LastIndexOf("\"))
                    Else
                        scriptFullPath = scriptFolder
                    End If
                    GPODataGrid.Rows.Add(scriptName, gponame, LCase(sBaseKey), scriptFullPath)
                Next
            Next
        Catch ex As NullReferenceException
            ' key not found
        End Try

    End Sub
    Private Sub EnumGPOScripts_2K(ByVal sBaseKey As String)

        Dim basekey As String
        Dim hive As RegistryHive
        Select Case LCase(sBaseKey)
            Case "startup"
                basekey = "Software\Policies\Microsoft\Windows\System\Scripts"
                hive = RegistryHive.LocalMachine
            Case "shutdown"
                basekey = "Software\Policies\Microsoft\Windows\System\Scripts"
                hive = RegistryHive.LocalMachine
            Case "logon"
                basekey = PC.CurrentUserSID & "\Software\Policies\Microsoft\Windows\System\Scripts"
                hive = RegistryHive.Users
            Case "logoff"
                basekey = PC.CurrentUserSID & "\Software\Policies\Microsoft\Windows\System\Scripts"
                hive = RegistryHive.Users
            Case Else
                Exit Sub
        End Select

        Dim BaseReg As RegistryKey
        BaseReg = RegistryKey.OpenRemoteBaseKey(hive, PC.Name).OpenSubKey(basekey)

        Try
            Dim startupscripts As String = BaseReg.GetValue(sBaseKey)

            Dim flagcheck As Boolean = False ' use to identify whether ini in correct section

            Dim arrStartupscripts() As String = Split(startupscripts, ";")
            For i As Integer = 0 To UBound(arrStartupscripts)
                Dim sIniFile As String = arrStartupscripts(i) & "\scripts.ini"
                If System.IO.File.Exists(sIniFile) Then
                    Dim sr As StreamReader = System.IO.File.OpenText(sIniFile)
                    Do While sr.EndOfStream = False
                        Dim tmp As String = sr.ReadLine()

                        If tmp.ToLower.Contains("[") Then
                            If tmp.ToLower = "[" & sBaseKey.ToLower & "]" Then
                                flagcheck = True
                            Else
                                flagcheck = False
                            End If
                        End If

                        If flagcheck Then
                            If Mid(tmp, 2, 8) = "CmdLine=" AndAlso tmp.Length > 10 Then
                                Dim scriptName As String
                                Dim scriptFullPath As String
                                scriptName = Mid(tmp, 10, tmp.Length - 9)
                                If InStr(scriptName, "\") Then
                                    scriptFullPath = scriptName.Substring(0, scriptName.LastIndexOf("\"))
                                    scriptName = Mid(scriptName, scriptName.LastIndexOf("\") + 2)
                                Else
                                    scriptFullPath = arrStartupscripts(i) & "\" & sBaseKey
                                End If

                                GPODataGrid.Rows.Add(scriptName, "", LCase(sBaseKey), scriptFullPath)
                            End If
                        End If
                    Loop
                End If
            Next
        Catch ex As System.NullReferenceException
            GPODataGrid.Rows.Add("cannot enumerate")
        End Try

    End Sub


    ' GPO Datagrid context menu
    Private Sub GPODataGrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GPODataGrid.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then
                GPODataGrid.ClearSelection()
                GPODataGrid(hti.ColumnIndex, hti.RowIndex).Selected = True

                If GPOGridType = "policy" Then
                    script_openContainer.Visible = False
                    Me.gpoName = GPODataGrid(0, hti.RowIndex).Value
                    Me.gpoDSPath = GPODataGrid(2, hti.RowIndex).Value
                ElseIf GPOGridType = "script" Then
                    script_openContainer.Visible = True
                    Me.script = GPODataGrid(0, hti.RowIndex).Value
                    Me.scriptPath = GPODataGrid(3, hti.RowIndex).Value
                End If

                gpoContextMenu.Show(GPODataGrid, New Point(e.X, e.Y))
            End If
        End If
    End Sub
    Private Sub script_openContainer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles script_openContainer.Click
        openfolder(scriptPath)
    End Sub
    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

        If GPOGridType = "policy" Then

            ' gpedit.msc /gpobject:"LDAP://CN={GUID of the GPO},CN=Policies,CN=System,DC=xDerwentSharedServices,DC=NHS,DC=UK"
            ' gpedit.msc /gpobject: & DSPATH   ....see below.....
            ' *** strip out CN=Machine, from beginning of DSPATH
            ' *** 'LDAP' MUST be in UPPER CASE

            'MsgBox("gpedit.msc " & "/gpobject:" & chr(34) & gpoDSPath & chr(34))
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = "gpedit.msc"
            psi.Arguments = "/gpobject:" & Chr(34) & gpoDSPath & Chr(34)
            p.StartInfo = psi
            p.Start()

        ElseIf GPOGridType = "script" Then

            Dim scripteditor As String = Registry.ClassesRoot.OpenSubKey("VBSFile\Shell\Edit\Command").GetValue("")
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = Trim(Replace(scripteditor, "%1", ""))
            psi.Arguments = Me.scriptPath & "\" & Me.script
            p.StartInfo = psi
            p.Start()

        End If

    End Sub

    Private Sub lbl_rsop_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_rsop.LinkClicked

        Dim bValid As Boolean = True
        If Not PC.DomainMember Then
            bValid = False
        ElseIf PC.DomainName.ToLower <> cmcUser.dnsdomain.ToLower Then
            bValid = False
        End If

        If Not bValid Then
            MsgBox("Resultant set of policy reports can only" & vbCr & _
                "generated for computers on the same domain as this computer.", _
                MsgBoxStyle.Information, "RSOP")
        Else
            GpoRsop()
        End If


    End Sub
    Private Sub GpoRsop()
        On Error Resume Next

        Dim GPMC As Object = CreateObject("GPMgmt.GPM")
        If Err.Number = 0 Then
            Dim path As String = Environment.ExpandEnvironmentVariables("%appdata%") & "\cmc\rsop" & PC.Name & ".html"
            Dim Constants As Object = GPMC.GetConstants()
            Dim RSOP As Object = GPMC.GetRSOP(Constants.RSOPModeLogging, "server", 1)
            RSOP.LoggingComputer = PC.Name
            RSOP.LoggingUser = PC.CurrentUser
            RSOP.CreateQueryResults()
            RSOP.GenerateReportToFile(Constants.ReportHTML, path)
            Dim p As New ProcessStartInfo

            Dim count As Integer = 0
            Do While File.Exists(path) = False
                Shell("cmd /c ping -n 1 127.0.0.1", AppWinStyle.Hide, True)
                count = count + 1
                If count >= 5 Then Exit Do
            Loop

            p.FileName = "iexplore.exe"
            p.Arguments = path
            Process.Start(p)
        Else
            If MsgBox("To create an RSOP report, you need the Microsoft Group" & vbCr & _
                      "Policy Management snap-in to be installed." & vbCr & vbCr & _
                      "Do you want to open the download page now?", _
                      vbYesNo + MsgBoxStyle.Exclamation, "Download Required Component") = vbYes Then
                Dim psi As New ProcessStartInfo()
                With psi
                    .FileName = "iexplore"
                    .Arguments = "-new http://www.microsoft.com/downloads/details.aspx?FamilyId=0A6D4C24-8CBD-4B35-9272-DD3CBFC81887&displaylang=en"
                    '.Arguments = "-new http://download.microsoft.com/download/a/d/b/adb5177d-01a7-4f04-bfcc-cb7cea8b5bb7/gpmc.msi"
                End With
                Process.Start(psi)
            End If
        End If
    End Sub


    Private Sub gprefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gprefresh.Click

        'http://technet.microsoft.com/en-us/library/bb490983.aspx
        'gpupdate [/target:{computer|user}] [/force] [/wait:value] [/logoff] [/boot]

        Dim updateCmd As String = String.Empty
        Dim updateCmdM As String = String.Empty
        Dim updateCmdU As String = String.Empty

        Select Case gpupdateChoice.Text
            Case "Machine Only"
                updateCmd = "GPUpdate /target:computer /force"
                updateCmdM = "SECEDIT /REFRESHPOLICY MACHINE_POLICY /ENFORCE"
            Case "User Only"
                updateCmd = "GPUpdate /target:user /force"
                updateCmdU = "SECEDIT /REFRESHPOLICY USER_POLICY /ENFORCE"
            Case "Machine and User"
                updateCmd = "GPUpdate /force"
                updateCmdM = "SECEDIT /REFRESHPOLICY MACHINE_POLICY /ENFORCE"
        End Select

        If PC.DomainMember Then
            If PC.OSVersionNumeric = 5.0 Then
                Dim pid1 As Integer = 1
                Dim pid2 As Integer = 1
                If Not String.IsNullOrEmpty(updateCmdM) Then pid1 = RemoteExec(PC.Name, updateCmdM, False)
                If Not String.IsNullOrEmpty(updateCmdU) Then pid2 = RemoteExec(PC.Name, updateCmdU, False)
                If pid1 > 0 And pid2 > 0 Then
                    'MsgBox("gpupdate started")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "group policy on " & PC.Name)
                End If
            Else
                If RemoteExec(PC.Name, updateCmd, False) > 0 Then
                    'MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "group policy on " & PC.Name)
                End If
            End If
        End If
    End Sub

    Private Property GPODebugSetting() As String
        'NONE 0x00000000 [0]
        'NORMAL 0x00000001 [1]
        'VERBOSE 0x00000002 [2]
        'LOGFILE 0x00010000
        'DEBUGGER 0x00020000
        'The default value is NORMAL|LOGFILE (0x00010001). [65537]

        'You can combine these values. For example, you can combine VERBOSE 0x00000002 and LOGFILE 0x00010000 to get 0x00010002. 
        'Therefore, if UserEnvDebugLevel is given a value of 0x00010002, LOGFILE and VERBOSE are both turned on. 
        'Combining these values is the same as using an OR statement.
        '0x00010000 OR 0x00000002 = 0x00010002
        'Note If you set UserEnvDebugLevel to 0x00030002, the most verbose details are logged in the Userenv.log file.

        'The log file is written to the %Systemroot%\Debug\UserMode\Userenv.log file
        Get
            If Not ConnectionExists Then
                Return ""
            End If
            Dim sDebug As String = "None"

            Dim i As Integer = RegistryKey.OpenRemoteBaseKey _
                        (RegistryHive.LocalMachine, PC.Name). _
                        OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon"). _
                        GetValue("UserEnvDebugLevel", 0)

            Select Case i
                Case 0
                    sDebug = "None"
                Case 1
                    sDebug = "Normal"
                Case 2
                    sDebug = "Verbose"
                Case 65536
                    sDebug = "Logfile"
                Case 131072
                    sDebug = "Debugger"
                Case 65537
                    sDebug = "Normal|Logfile" ' [default setting]
                Case 65538
                    sDebug = "Verbose|Logfile"
                Case 196610
                    sDebug = "Debug|Verbose|Logfile"
            End Select
            Return sDebug
        End Get
        Set(ByVal value As String)

            Dim sDebug As Integer
            Select Case value
                Case "None"
                    sDebug = 0
                Case "Normal"
                    sDebug = 1
                Case "Verbose"
                    sDebug = 2
                Case "Logfile"
                    sDebug = 65536
                Case "Debugger"
                    sDebug = 131072
                Case "Normal|Logfile"
                    sDebug = 65537 ' [default setting]
                Case "Verbose|Logfile"
                    sDebug = 65538
                Case "Debug|Verbose|Logfile"
                    sDebug = 196610
            End Select

            RegistryKey.OpenRemoteBaseKey _
                                    (RegistryHive.LocalMachine, PC.Name). _
                                    OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True). _
                                    SetValue("UserEnvDebugLevel", sDebug, RegistryValueKind.DWord)
        End Set
    End Property

    ' Get gpo debug setting when GPO tab activated.
    Private Sub gpo_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles gpo.Paint
        If ConnectionExists AndAlso gpoDebugCombo.Text = "" Then
            gpoDebugCombo.Text = String.Empty
            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    gpoDebugCombo.SelectedText = GPODebugSetting
                    impersonator.undoImpersonation()
                End If
            Else
                gpoDebugCombo.SelectedText = GPODebugSetting
            End If

        End If
    End Sub
    Private Sub gpoDebugCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gpoDebugCombo.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim NewDebug As String = gpoDebugCombo.SelectedItem

            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    GPODebugSetting = NewDebug
                    impersonator.undoImpersonation()
                End If
            Else
                GPODebugSetting = NewDebug
            End If



            gpoDebugCombo.Text = GPODebugSetting
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    ' Open existing gpo debug file
    Private Sub lbl_debug_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_debug.LinkClicked
        Dim logfilepath As String = "\\" & PC.Name & "\" & Replace(PC.SystemDirectory, ":", "$") & "\Debug\UserMode\Userenv.log"
        If System.IO.File.Exists(logfilepath) Then
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = "Notepad.exe"
            psi.Arguments = logfilepath
            p.StartInfo = psi
            p.Start()
        Else
            MsgBox("Debug file not found")
        End If
    End Sub

    Private Sub lbl_localgpo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lbl_localgpo.LinkClicked
        ' gpedit.msc /gpcomputer:"myComputer"
        Dim p As New Process
        Dim psi As ProcessStartInfo = New ProcessStartInfo
        psi.FileName = "gpedit.msc"
        psi.Arguments = "/gpcomputer:" & Chr(34) & PC.Name & Chr(34)
        p.StartInfo = psi
        p.Start()
    End Sub

    Sub ClearGPOTab()
        GPODataGrid.Rows.Clear()
        gpoDebugCombo.Text = ""
        gprefresh.Enabled = False
        btn_startupscripts.Enabled = False
        btn_gpo_policies.Enabled = False
        lbl_localgpo.Enabled = False
        lbl_rsop.Enabled = False
        lbl_debug.Enabled = False
    End Sub

    Sub GPO_EnableItems()
        '       If PC.DomainMember Then
        gprefresh.Enabled = True
        lbl_rsop.Enabled = True
        '       End If
        btn_startupscripts.Enabled = True
        btn_gpo_policies.Enabled = True
        lbl_localgpo.Enabled = True
        lbl_debug.Enabled = True
    End Sub


#End Region

#Region "Message"

    ' message text box
    Private Sub NetSendTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetSendTextBox.TextChanged
        If Trim(NetSendTextBox.Text) <> "" Then
            msgSend.Enabled = True
            If msg_radio.Checked Then
                NetSendTextBox.MaxLength = 256
            Else
                NetSendTextBox.MaxLength = 800
            End If
        Else
            msgSend.Enabled = False
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NetSendTextBox.KeyPress
        If e.KeyChar = ChrW(13) Then
            If msg_radio.Checked Then
                e.Handled = True
                MsgBox("carriage returns can not be used with the MSG cmd selection.", MsgBoxStyle.Exclamation, "MSG CMD")
            End If
        End If
    End Sub

    Private Sub msgSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgSend.Click

        If msgboxradio.Checked Then
            PopUpMessage(False)
        ElseIf netsendradio.Checked Then
            Dim NetSendThread As New System.Threading.Thread(AddressOf NetSend)
            NetSendThread.Start()
        ElseIf msg_radio.Checked Then
            sendMsg(NetSendTextBox.Text)
        End If

    End Sub
    Private Sub previewbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previewbutton.Click
        PopUpMessage(True)
    End Sub
    Private Sub netsendCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles netsendCancel.Click
        Tabholder1.SelectedIndex = iTabIndex
        Me.AcceptButton = GO_Button
        NetSendTextBox.Text = ""
    End Sub
    Private Sub msgboxradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgboxradio.CheckedChanged
        If msgboxradio.Checked Then
            msgboxTitle.Enabled = True
            previewbutton.Enabled = True
            msgboxTitle.Text = "Message From " & My.User.Name
            question.Enabled = True
            critical.Enabled = True
            exclamation.Enabled = True
            information.Enabled = True
            nomodal.Enabled = True
            nomodal.Checked = True
        End If
    End Sub
    Private Sub netsendradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles netsendradio.CheckedChanged
        If netsendradio.Checked Then
            msgboxTitle.Enabled = False
            previewbutton.Enabled = False
            msgboxTitle.Text = "Message From " & My.User.Name
            question.Enabled = False
            critical.Enabled = False
            exclamation.Enabled = False
            information.Enabled = False
            nomodal.Enabled = False
        End If
    End Sub
    Private Sub msg_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msg_radio.CheckedChanged
        If msg_radio.Checked Then
            NetSendTextBox.Text = Replace(NetSendTextBox.Text, vbCrLf, " ")
            msgboxTitle.Enabled = False
            previewbutton.Enabled = False
            msgboxTitle.Text = "Message From " & My.User.Name & " " & DateTime.Now
            question.Enabled = False
            critical.Enabled = False
            exclamation.Enabled = False
            information.Enabled = False
            nomodal.Enabled = False
        End If
    End Sub

    Private Sub NetSend()

        Try
            If AltUserCheckBox.Checked Then
                Dim impersonator As New Impersonation
                If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                    ChangeServiceStartmode("demand")
                    System.Threading.Thread.Sleep(1000)
                    ServiceControlStartService(PC.Name, "Messenger")
                    System.Threading.Thread.Sleep(1000)
                    Shell("Net Send /Domain:" & PC.Name & " " & NetSendTextBox.Text, 0, True)
                    System.Threading.Thread.Sleep(1000)
                    ServiceControlStopService(PC.Name, "Messenger")
                    System.Threading.Thread.Sleep(1000)
                    Service_ChangeStartMode("Messenger", "Disabled")
                    impersonator.undoImpersonation()
                End If
            Else
                ChangeServiceStartmode("demand")
                System.Threading.Thread.Sleep(1000)
                ServiceControlStartService(PC.Name, "Messenger")
                System.Threading.Thread.Sleep(1000)
                Shell("Net Send /Domain:" & PC.Name & " " & NetSendTextBox.Text, 0, True)
                System.Threading.Thread.Sleep(1000)
                ServiceControlStopService(PC.Name, "Messenger")
                System.Threading.Thread.Sleep(1000)
                Service_ChangeStartMode("Messenger", "Disabled")
            End If

            WriteLog(PC.Name & " - Net Send: " & NetSendTextBox.Text)
            MsgBox("Net Send Completed")

        Catch ex As Exception
            MsgBox("Net Send Operation failed" & vbCrLf & Err.Number)
        Finally
            NetSendTextBox.Text = ""
        End Try

    End Sub

    Private Sub PopUpMessage(ByVal preview As Boolean)

        Dim VBS_tempfile As String = My.Application.Info.DirectoryPath & "\msg.vbs"
        Dim strComputer As String = PC.Name
        Dim sTitle As String

        ' get text
        Dim sMessage As String
        ' replace invalid characters
        sMessage = Replace(NetSendTextBox.Text, Chr(34), "'")
        ' format line breaks
        sMessage = Replace(sMessage, vbCrLf, Chr(34) & " & vbcrlf & " & Chr(34))

        ' get title
        If msgboxradio.Checked And Trim(msgboxTitle.Text) <> "" Then
            sTitle = msgboxTitle.Text
        Else
            sTitle = "Message from " & My.User.Name
        End If

        Dim cmcModal As Integer = 0
        If information.Checked Then cmcModal = 64
        If exclamation.Checked Then cmcModal = 48
        If question.Checked Then cmcModal = 32
        If critical.Checked Then cmcModal = 16


        'write text to file
        Dim PopUpFile As New System.IO.StreamWriter(VBS_tempfile, False)
        PopUpFile.WriteLine("on error resume next")
        PopUpFile.WriteLine("msgbox " & Chr(34) & sMessage & Chr(34) & "," & cmcModal & "," & Chr(34) & sTitle & Chr(34))
        PopUpFile.WriteLine("Set objFSO = CreateObject(" & Chr(34) & "Scripting.FileSystemObject" & Chr(34) & ")")
        PopUpFile.WriteLine("objFSO.DeleteFile(" & Chr(34) & "C:\msg.vbs" & Chr(34) & ")")
        PopUpFile.Close()

        If preview = False Then

            ' Copy file to pc.name
            Try
                Shell("cmd /c copy " & Chr(34) & VBS_tempfile & Chr(34) & _
                " \\" & PC.Name & "\c$\msg.vbs /Y", 0, True)
            Catch ex As Exception
                Panel2.Text = "msgbox failed"
                WriteLog(PC.Name & " - message - file copy failed: " & ex.Message)
                Exit Sub
            End Try

            ' Run script on remote pc (using psexec or scheduled task)
            If psexecpath.Text <> "" Then
                Try
                    Shell("cmd /c " & psexecfile & " \\" & strComputer & " -d -i wscript.exe c:\msg.vbs", 0, True, 8)
                    WriteLog(strComputer & " - MSGBOX: " & sTitle & "  -  " & sMessage)
                Catch ex As Exception
                    Panel2.Text = "msgbox failed to complete"
                    WriteLog(strComputer & " - MSGBOX - script exec failed: " & ex.Message)
                    Exit Sub
                End Try
            Else
                ScheduleJob(PC.Name, "wscript.exe c:\msg.vbs", True)
            End If


        Else
            Shell("wscript.exe " & Chr(34) & VBS_tempfile & Chr(34), 0, False)
        End If


    End Sub

    Private Sub sendMsg(ByVal strMessage As String)

        strMessage = Replace(strMessage, vbCrLf, " ")

        If strMessage.Length > 255 Then
            MsgBox("too many characters - max 255", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        'If PC.OS <> "NT" AndAlso PC.OS <> "Windows 2000" Then
        'Shell("cmd /c msg * /server:" & PC.Name & " /v " & strMessage, 0, True)
        'Else
        'MsgBox("Can't use msg command on older version of windows")
        'End If

        Dim myProcess As Process = New Process()
        Dim s As String
        Dim exittime As String
        Dim exitcode As Integer
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        '' add an Exited event handler
        'myProcess.EnableRaisingEvents = True
        'AddHandler myProcess.Exited, AddressOf Me.ProcessExited

        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True

        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write("msg * /server:" & PC.Name & " /v " & strMessage & System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        exittime = CStr(myProcess.ExitTime)
        exitcode = myProcess.ExitCode

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()

        If Not exitcode = 0 Then
            MsgBox(s)
        Else
            If InStr(s, "Async message sent to ") Then
                MsgBox("Msg sent OK")
            Else
                MsgBox(s)
            End If
        End If

    End Sub


#End Region

#Region "StartUp"

    Private stup_name As String
    Private Sub startupbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startupbutton.Click
        Me.Cursor = Cursors.WaitCursor
        startupDataGrid.Rows.Clear()
        stup_command.Text = ""
        stup_location.Text = ""
        stup_user.Text = ""

        ' get startups
        StartUpCommands()

        startupDataGrid.ClearSelection()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub StartUpCommands()

        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("Select Name, Command, Location, User from Win32_StartupCommand WHERE Caption<>'desktop'")
        Dim m As ManagementObject
        Try
            For Each m In queryCollection
                startupDataGrid.Rows.Add(m("Name").ToString, m("Command").ToString, m("Location").ToString, m("User").ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub startupDataGrid_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles startupDataGrid.MouseDown

        stup_command.Text = ""
        stup_location.Text = ""
        stup_user.Text = ""
        stup_command.ReadOnly = True
        startupDeleteButton.Enabled = False
        startupModifyButton.Enabled = False
        'startupApplyButton.Enabled = False


        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)

            If hti.Type = DataGridViewHitTestType.Cell Then
                startupDataGrid.ClearSelection()
                startupDataGrid(hti.ColumnIndex, hti.RowIndex).Selected = True
                stup_name = startupDataGrid(0, hti.RowIndex).Value
                stup_command.Text = startupDataGrid(1, hti.RowIndex).Value
                stup_location.Text = startupDataGrid(2, hti.RowIndex).Value
                stup_user.Text = startupDataGrid(3, hti.RowIndex).Value
            End If
            ' provide modify options (delete reg entry)

            If Mid(stup_location.Text, 1, 4) = "HKU\" Or Mid(stup_location.Text, 1, 5) = "HKLM\" Then
                startupDeleteButton.Enabled = True
                startupModifyButton.Enabled = True
            Else
                startupDeleteButton.Enabled = False
                startupModifyButton.Enabled = False
            End If

            If stup_location.Text.ToLower = "common startup" Then
                startupDeleteButton.Enabled = True
            End If

            startupApplyButton.Enabled = False
        End If
    End Sub
    Private Sub startupModifyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startupModifyButton.Click
        stup_command.ReadOnly = False
        startupDeleteButton.Enabled = False
    End Sub
    Private Sub stup_command_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stup_command.TextChanged
        startupApplyButton.Enabled = True
    End Sub
    Private Sub startupApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startupApplyButton.Click

        stup_command.ReadOnly = True
        startupModifyButton.Enabled = False
        startupApplyButton.Enabled = False

        Me.Cursor = Cursors.WaitCursor

        Dim sRoot As RegistryHive
        Dim sInt As Integer
        Dim sLngth As Integer = stup_location.Text.Length + 1

        Dim sKeyPath As String

        Select Case Mid(stup_location.Text, 1, 3)
            Case "HKU"
                sRoot = RegistryHive.Users
                sInt = 5
                sKeyPath = Mid(stup_location.Text, sInt, sLngth - sInt)
            Case "HKL"
                sRoot = RegistryHive.LocalMachine
                sInt = 6
                sKeyPath = Mid(stup_location.Text, sInt, sLngth - sInt)
            Case Else
                MsgBox("option not available")
                Exit Sub
        End Select

        wmi.RegistrySetStringValue(PC.Name, sRoot, sKeyPath, Me.stup_name, stup_command.Text)
        WriteLog(PC.Name & " - StartUp command entry modified: " & sRoot & "\" & sKeyPath & " KEY: " & Me.stup_name & " VALUE: " & stup_command.Text)

        StartUpCommands()

        Me.Cursor = Cursors.Default

    End Sub
    Private Sub startupDeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startupDeleteButton.Click

        If stup_location.Text.ToLower = "common startup" Then
            Delete_CommonStartupFolderItem()
            Exit Sub
        End If

        Dim sRoot As RegistryHive
        Dim sInt As Integer
        Dim sLngth As Integer = stup_location.Text.Length + 1

        Dim sKeyPath As String

        Select Case Mid(stup_location.Text, 1, 3)
            Case "HKU"
                sRoot = RegistryHive.Users
                sInt = 5
                sKeyPath = Mid(stup_location.Text, sInt, sLngth - sInt)
            Case "HKL"
                sRoot = RegistryHive.LocalMachine
                sInt = 6
                sKeyPath = Mid(stup_location.Text, sInt, sLngth - sInt)
            Case Else
                MsgBox("option not available")
                Exit Sub
        End Select

        If wmi.RegistryDeleteValue(PC.Name, sRoot, sKeyPath, Me.stup_name) = True Then
            ' refresh startupDataGrid
            startupDataGrid.Rows.Clear()
            StartUpCommands()
        Else
            MsgBox("operation failed")
        End If



    End Sub
    Private Sub Delete_CommonStartupFolderItem()
        If stup_location.Text.ToLower = "common startup" Then
            Dim regkey As String = "software\microsoft\windows\currentversion\explorer\shell folders"
            Dim folder As String = "\\" & PC.Name & "\" & Replace(wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, regkey, "Common Startup"), ":", "$")
            For Each shortcut As String In System.IO.Directory.GetFiles(folder)
                Dim shortcutname As String = LCase(Replace(shortcut, folder & "\", ""))
                Dim itemname As String = startupDataGrid.SelectedCells(0).Value
                Dim selectedname As String = LCase(itemname) & ".lnk"
                If shortcutname = selectedname Then
                    Try
                        ' delete shortcut file
                        System.IO.File.Delete(shortcut)
                        ' remove item from datagrid list
                        For i As Integer = 0 To startupDataGrid.RowCount - 1
                            If InStr(startupDataGrid(0, i).Value, itemname) Then
                                startupDataGrid.Rows(i).Visible = False
                            End If
                        Next
                    Catch ex As Exception
                    End Try
                End If
            Next
        End If
    End Sub

    Private Sub ClearStartUp()
        stup_command.Text = ""
        stup_location.Text = ""
        stup_user.Text = ""
        startupDataGrid.Rows.Clear()
        startupModifyButton.Enabled = False
        startupDeleteButton.Enabled = False
        startupApplyButton.Enabled = False
    End Sub

#End Region

#Region "Deploy"


    ' Browse for Folder dialog
    Private Function GetFolder(Optional ByVal defaultlocation As String = "C:\") As String

        Dim FolderBrowserDialog1 As New FolderBrowserDialog
        ' Change the .SelectedPath property to the default location
        With FolderBrowserDialog1
            ' Desktop is the root folder in the dialog.
            .RootFolder = Environment.SpecialFolder.Desktop
            ' Select the C:\Windows directory on entry.
            .SelectedPath = defaultlocation
            ' Prompt the user with a custom message.
            .Description = "Select directory"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                My.Settings.softwaresource = .SelectedPath
                My.Settings.Save()
                Return .SelectedPath
            Else
                Return String.Empty
            End If
        End With
    End Function
    ' Add Files or folder
    Private Sub Add_File_Folder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_File_Folder.Click
        If folder_radio.Checked Then

            Dim returnedfolder As String
            If file_folder.Text = "" Then
                returnedfolder = GetFolder(My.Settings.softwaresource)
            Else
                returnedfolder = GetFolder(file_folder.Text)
            End If

            If Not returnedfolder = String.Empty Then
                file_folder.Text = returnedfolder
            End If

            '' If a folder is added, disable Add button. (only one folder allowed)
            'If FileListBox.Items.Count > 0 OrElse String.IsNullOrEmpty(Trim(file_folder.Text)) Then
            '    Add_File_Folder.Enabled = False
            'Else
            '    Add_File_Folder.Enabled = True
            'End If
        Else
            Add_Files(My.Settings.softwaresource)
        End If
    End Sub
    Private Sub Add_Files(ByVal dir As String)
        Dim FileBrowser As New OpenFileDialog
        With FileBrowser
            .Multiselect = True
            .Filter = "All files (*.*)|*.*|installer files|*.exe;*.msi;*.bat;*.cmd;*.vbs;*.iss,*.mst;*.ini,*.reg,*.inf"
            .CheckFileExists = True
            .CheckPathExists = True
            .InitialDirectory = dir
            .Title = "Select source files"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim lastfilepath As String = String.Empty
                For Each fName As String In .FileNames
                    file_folder.Text = file_folder.Text.Insert(0, fName & ControlChars.NewLine)
                    lastfilepath = fName
                Next
                My.Settings.softwaresource = Path_from_filename(lastfilepath)
                My.Settings.Save()
            End If
        End With
    End Sub
    ' Launch browse dialog for destination folder
    Private Sub GetFolder2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetFolder2.Click
        If _to.Text = "" AndAlso Not String.IsNullOrEmpty(PC.Name) Then
            _to.Text = "\\" & PC.Name & "\c$"
        Else
            _to.Text = GetFolder(_to.Text)
        End If
    End Sub
    ' Save application deployment settings
    Private Sub save_appdeploy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_appdeploy.Click
        With (appdeploy)
            .appdeploy_load_combo.Visible = False
            .Show()
            .Text = "App deploy - Save App"
            .OK_Button.Text = "Save"
            .appdeploy_filelist.Items.AddRange(file_folder.Lines)
            .appdeploy_dest.Text = Replace(_to.Text, PC.Name, "%computername%")
            .appdeploy_cmd.Text = installcmd.Text
        End With
    End Sub
    ' Load pre-saved application settings
    Private Sub load_appdeploy_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles load_appdeploy.Click
        With appdeploy
            .Show()
            .Text = "App deploy - Load App"
            .OK_Button.Text = "Load"
            .appdeploy_filelist.Items.Clear()
            .appdeploy_dest.Text = ""
            .appdeploy_cmd.Text = ""
            .Load_App_Combo()
        End With
    End Sub
    ' checkbox to determine whether command to run following folder copy
    Private Sub installcmd_checkbox_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles installcmd_checkbox.CheckedChanged
        installcmd.Enabled = installcmd_checkbox.Checked
        run_visible.Enabled = installcmd_checkbox.Checked
        close_on_finish.Enabled = run_visible.Checked And installcmd_checkbox.Checked
    End Sub
    ' file / folder select
    Private Sub folder_radio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles folder_radio.CheckedChanged
        If Not String.IsNullOrEmpty(Trim(file_folder.Text)) Then
            file_folder.Text = ""
        End If
        If folder_radio.Checked Then
            file_folder.Multiline = False
        Else
            file_folder.Multiline = True
        End If
        Add_File_Folder.Enabled = True
    End Sub
    ' Open datagridview allowing edit of xml contents
    Private Sub edit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles edit.LinkClicked
        appdeploy.Load_XML_into_Grid()
        AppTable.ShowDialog()
        If AppTable.DialogResult = Windows.Forms.DialogResult.OK Then
            appdeploy.Save_Grid_to_XML()
        End If
    End Sub
    ' clear deploy tab
    Private Sub deploy_clear_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles deploy_clear_link.LinkClicked
        file_folder.Text = ""
        _to.Text = ""
        ProgressBar1.Visible = False
        installcmd.Text = ""
        installcmd_checkbox.Checked = False
    End Sub
    ' Copy files and Launch command script
    Private Sub AppGo_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppGo_Button.Click
        'Dim copythread As New System.Threading.Thread(AddressOf Copy_Files_Run_Cmd)
        'copythread.Start()
        Copy_Files_Run_Cmd()
    End Sub
    Private Sub Copy_Files_Run_Cmd()

        AppGo_Button.Enabled = False


        If file_radio.Checked Then
            ' Check Files Exist
            For Each line As String In file_folder.Lines
                If Not String.IsNullOrEmpty(line) Then
                    If Not System.IO.File.Exists(line) Then
                        MsgBox("Cannot find source file" & vbCrLf & "(" & line & ")", MsgBoxStyle.Exclamation)
                        AppGo_Button.Enabled = True
                        Exit Sub
                    End If
                End If
            Next
            Copy_Files()
        Else
            ' Check source folder exists
            If Not System.IO.Directory.Exists(file_folder.Text) Then
                MsgBox("Cannot find source folder" & vbCrLf & "(" & file_folder.Text & ")", MsgBoxStyle.Exclamation)
                AppGo_Button.Enabled = True
                Exit Sub
            End If
            ' Check Destination root folder exists
            If Not System.IO.Directory.Exists(_to.Text) Then
                MsgBox("Cannot find destiantion folder" & vbCrLf & "(" & _to.Text & ")", MsgBoxStyle.Exclamation)
                AppGo_Button.Enabled = True
                Exit Sub
            End If
            Copy_Folder()
        End If



        ' Run command once copying files complete

        If Not installcmd_checkbox.Checked Then
            Panel2.Text = "file copy complete."
        Else

            Panel2.Text = "file copy complete, starting command..."

            Dim cmdtxt As String = Replace(LCase(Trim(installcmd.Text)), "wscript", "cscript")
            If cmdtxt <> "" Then
                If My.Settings.psexecpath <> "" Then

                    ' set up psexec part of command string
                    Dim pscmd As String = psexecfile & " \\" & PC.Name & " "
                    If AltUserCheckBox.Checked Then pscmd = pscmd & " -u " & Me.sAltDomain & "\" & Me.sAltDomainUser & " -p " & sAltPassword & " "

                    ' run command
                    Dim comspec As String = "cmd /k "
                    Dim vis As Integer = 0
                    If run_visible.Checked Then vis = 1
                    If close_on_finish.Checked Then comspec = "cmd /c "

                    Shell(comspec & pscmd & cmdtxt, vis)

                Else
                    RemoteExec(PC.Name, cmdtxt)
                End If
            End If
        End If

        Panel2.Text = "command complete."
        AppGo_Button.Enabled = True

    End Sub
    Private Sub Copy_Files()

        Dim DestDir As String = _to.Text
        If Not DestDir.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) Then _
                 DestDir &= System.IO.Path.DirectorySeparatorChar

        ' Create directory if it doesn't exist
        If Not System.IO.Directory.Exists(DestDir) Then
            Try
                System.IO.Directory.CreateDirectory(DestDir)
            Catch ex As Exception
                MsgBox("error creating " & DestDir & vbCrLf & ex.Message)
            End Try
        End If


        ' Copy files to destination directory

        ProgressBar1.Visible = True
        'If FileListBox.Items.Count > 0 Then
        If file_folder.Lines.Length > 0 Then
            'For i As Integer = 0 To FileListBox.Items.Count - 1
            For i As Integer = 0 To file_folder.Lines.Length - 1
                Dim filepath As String()
                Dim fullfilename As String
                'fullfilename = FileListBox.Items.Item(i).ToString
                fullfilename = file_folder.Lines(i)

                filepath = Split(fullfilename, "\")
                Dim filename As String = filepath(filepath.GetUpperBound(0))
                Try
                    ' Basic Copy file
                    ' System.IO.File.Copy(fullfilename, DestDir & filename, True)


                    ' Copy file with progress bar
                    '' first, set attributes to normal (hidden or readonly will cause copy to fail)
                    'Dim fi As New System.IO.FileInfo(DestDir & filename)
                    'If fi.Exists Then fi.Attributes = IO.FileAttributes.Normal

                    Dim cpr As New CopyProgressRoutine(AddressOf CopyProgress)
                    CopyFileEx(fullfilename, DestDir & filename, cpr, 0, 0, 0)
                    ' last integer: 0 = overwrite, 1 = do not overwrite

                Catch ex As Exception
                    MsgBox("file copy failed")
                End Try
            Next
        End If

        ProgressBar1.Visible = False
    End Sub
    Private Sub Copy_Folder()

        ' Get name of the source folder (to create if none entered)
        Dim sourcefoldername As String = GetFolderName_From_Path(file_folder.Text)

        ' Get destination folder name
        Dim fldrpath As String = _to.Text
        ' Add trailing separator to the supplied path if they don't exist.
        If Not fldrpath.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) Then
            fldrpath &= System.IO.Path.DirectorySeparatorChar
        End If
        Dim destinationfoldername As String = GetFolderName_From_Path(_to.Text)

        ' Append foldername to destination if required
        If Not destinationfoldername.ToLower = sourcefoldername.ToLower Then
            fldrpath &= sourcefoldername
        End If


        'RecursiveCopyFiles(FileListBox.Items.Item(0), fldrpath, True, True)
        ProgressBar1.Visible = True

        CopyFolder(file_folder.Text, fldrpath)

        ProgressBar1.Visible = False
    End Sub
    Private Sub run_visible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles run_visible.CheckedChanged
        If run_visible.Checked = False Then
            close_on_finish.Checked = True
            close_on_finish.Enabled = False
        Else
            close_on_finish.Enabled = True
        End If
    End Sub


    ' File Copy Progress Bar code
    Private Sub MyFileCopyWithProgress(ByVal source As String, ByVal destination As String)
        Dim cpr As New CopyProgressRoutine(AddressOf CopyProgress)
        CopyFileEx(source, destination, cpr, 0, 0, 0)
    End Sub


    ' Copy Progress Bar code http://khsw.blogspot.com/2006/03/copy-complete-directory-with-progress.html
    Private Function CopyProgress(ByVal totalFileSize As Int64, ByVal totalBytesTransferred As Int64, ByVal streamSize As Int64, ByVal streamBytesTransferred As Int64, ByVal dwStreamNumber As Int32, ByVal dwCallbackReason As Int32, ByVal hSourceFile As Int32, ByVal hDestinationFile As Int32, ByVal lpData As Int32) As Int32
        ProgressBar1.Value = Convert.ToInt32(totalBytesTransferred / totalFileSize * 100)
    End Function
    Private Sub CopyFolder(ByVal rootfolder As String, ByVal destfolder As String)
        GetTotalFileSize(New System.IO.DirectoryInfo(rootfolder))
        _copyProgressRoutine = New CopyProgressRoutine(AddressOf CopyProgress)
        CopyFiles(New System.IO.DirectoryInfo(rootfolder), rootfolder, destfolder)
    End Sub
    Private Sub CopyFiles(ByVal folder As System.IO.DirectoryInfo, ByVal rootfolder As String, ByVal destinationFolder As String)
        If Not System.IO.Directory.Exists(destinationFolder) Then
            System.IO.Directory.CreateDirectory(destinationFolder)
        End If
        For Each fi As System.IO.FileInfo In folder.GetFiles
            CopyFileEx(fi.FullName, destinationFolder & "\" & fi.Name, _copyProgressRoutine, 0, 0, 0)
            _totalBytesCopied += fi.Length
        Next
        For Each di As System.IO.DirectoryInfo In folder.GetDirectories
            CopyFiles(di, rootfolder, di.FullName.Replace(rootfolder, destinationFolder))
        Next
    End Sub
    Private Function CopyFolderProgress(ByVal totalFileSize As Int64, ByVal totalBytesTransferred As Int64, ByVal streamSize As Int64, ByVal streamBytesTransferred As Int64, ByVal dwStreamNumber As Int32, ByVal dwCallbackReason As Int32, ByVal hSourceFile As Int32, ByVal hDestinationFile As Int32, ByVal lpData As Int32) As Int32
        ProgressBar1.Value = Convert.ToInt32((_totalBytesCopied + totalBytesTransferred) / _totalFileSize * 100)
        Application.DoEvents()
    End Function
    Private Sub GetTotalFileSize(ByVal folder As System.IO.DirectoryInfo)
        For Each fi As System.IO.FileInfo In folder.GetFiles
            _totalFileSize += fi.Length
        Next
        For Each di As System.IO.DirectoryInfo In folder.GetDirectories
            GetTotalFileSize(di)
        Next
    End Sub

    Private _totalFileSize As Long = 0
    Private _totalBytesCopied As Long = 0
    Private _copyProgressRoutine As CopyProgressRoutine

    ' API Functions for file/folder copy progress bar
    Private Delegate Function CopyProgressRoutine(ByVal totalFileSize As Int64, ByVal totalBytesTransferred As Int64, ByVal streamSize As Int64, ByVal streamBytesTransferred As Int64, ByVal dwStreamNumber As Int32, ByVal dwCallbackReason As Int32, ByVal hSourceFile As Int32, ByVal hDestinationFile As Int32, ByVal lpData As Int32) As Int32
    Private Declare Auto Function CopyFileEx Lib "kernel32.dll" (ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal lpProgressRoutine As CopyProgressRoutine, ByVal lpData As Int32, ByVal lpBool As Int32, ByVal dwCopyFlags As Int32) As Int32

#End Region

#Region "Options"

    Private Sub Save_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save_Button.Click
        If defHW.Checked Then
            My.Settings.hw = True
        Else
            My.Settings.hw = False
        End If
        If defNW.Checked Then
            My.Settings.nw = True
        Else
            My.Settings.nw = False
        End If
        If defSV.Checked Then
            My.Settings.sv = True
        Else
            My.Settings.sv = False
        End If
        If defPR.Checked Then
            My.Settings.pr = True
        Else
            My.Settings.pr = False
        End If


        ' Alt User Credentials
        Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("Alt1", EncryptText.EncryptText(SettingAltUser.Text), RegistryValueKind.String)
        Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("Alt2", EncryptText.EncryptText(SettingAltPass.Text), RegistryValueKind.String)

        ' psexec
        If System.IO.File.Exists(psexecpath.Text) And InStr(LCase(psexecpath.Text), "psexec.exe") Then
            My.Settings.psexecpath = psexecpath.Text
        Else
            My.Settings.psexecpath = ""
            psexecpath.Text = ""
        End If

        ' Save & Reload settings
        My.Settings.Save()
        My.Settings.Reload()
        LoadSettings()

        ' Go to first tab
        'Tabholder1.SelectTab(os)

    End Sub
    Private Sub downloadpsexec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downloadpsexec.Click

        Dim downloadaddress As String = "http://live.sysinternals.com/tools/psexec.exe"
        Dim downloadedfile As String = My.Application.Info.DirectoryPath & "\files\psexec.exe"

        Try
            My.Computer.Network.DownloadFile(downloadaddress, downloadedfile, "", "", True, 100, False)

        Catch ex As WebException
            System.Diagnostics.Process.Start(downloadaddress)
        End Try

        'If UnZipFile(My.Application.Info.DirectoryPath & "\files\pstools.zip") = "Fail" Then downloaderror()
    End Sub
    Private Sub psexecbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles psexecbrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.InitialDirectory = My.Application.Info.DirectoryPath & "\files"
        openFile.Filter = "psexec.exe|*.exe"
        openFile.Title = "CMC - psexec location"
        'openFile.ShowDialog()

        If openFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If InStr(LCase(openFile.FileName), "psexec.exe") Then
                psexecpath.Text = openFile.FileName
                My.Settings.psexecpath = psexecpath.Text
            Else
                MsgBox("psexec not found")
                psexecpath.Text = ""
            End If
        End If

    End Sub
    Private Sub downloaderror()
        MsgBox("Unable to download/install the file. You should download PSexec.exe manually and place" & vbCrLf & _
                    "in the folder: '" & My.Application.Info.DirectoryPath & "\files'")
    End Sub

    Private Sub PrefCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrefCancel.Click
        ' reset pref text boxes to previous (unchanged) values.
        LoadSettings()
        ' reset view to front tab
        Tabholder1.SelectTab(iTabIndex)
    End Sub
    Private Sub aboutOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutOK.Click
        Tabholder1.SelectTab(os)
    End Sub

    Private Sub DomainCombo_Opened(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainCombo.DropDown
        DomainCombo.Items.Clear()
        DomainCombo.Items.Add(" (Add New...)")
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If Not rk Is Nothing Then
                Dim dominfo() As String = Split(rk, ";")
                DomainCombo.Items.Add(dominfo(0))
            End If
        Next
    End Sub
    Private Sub DomainCombo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DomainCombo.SelectedIndexChanged
        If DomainCombo.Text = " (Add New...)" Then
            Dim di As New AddDomainInfo
            di.ShowDialog()

            Me.DomainCombo.Items.Clear()
            Me.DomainCombo.Items.AddRange(New Object() {" (edit custom domains)"})
            Me.DomainCombo.SelectedIndex = 0

        Else
            For i As Integer = 0 To 9
                Dim valuename As String = "Domain" & CStr(i)
                Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
                If Not rk Is Nothing Then
                    Dim dominfo() As String = Split(rk, ";")
                    If dominfo(0).ToUpper = DomainCombo.Text.ToUpper Then

                        Dim di As New AddDomainInfo
                        di.OK_Button.Text = "Save"

                        Dim user As String = dominfo(3)
                        If Not String.IsNullOrEmpty(user) Then user = EncryptText.DecryptText(user)
                        Dim pass As String = dominfo(4)
                        If Not String.IsNullOrEmpty(pass) Then pass = EncryptText.DecryptText(pass)

                        di.txtDomain.Text = dominfo(0)
                        di.txtDNS.Text = dominfo(1)
                        di.txtDC.Text = dominfo(2)
                        di.txtUser.Text = user
                        di.txtPass.Text = pass
                        di.ShowDialog()

                    End If
                End If
            Next
        End If
    End Sub

#End Region


#Region "TOOLSTRIP"

    Private Sub mmcToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mmcToolStripButton.Click
        MMC_Snap_in("compmgmt")
    End Sub
    Private Sub evntToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles evntToolStripButton.Click
        MMC_Snap_in("eventvwr")
    End Sub
    Private Sub usrsToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usrsToolStripButton.Click
        MMC_Snap_in("lusrmgr")
    End Sub
    Private Sub regToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regToolStripButton.Click

        Panel2.Text = "opening remote registry..."
        Me.TopMost = False

        WinRegEdit()

        Panel2.Text = "ready"

    End Sub
    Private Sub cmdToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdToolStripButton.Click

        If psexecfile <> "" Then
            cmcPSEXEC("cmd", 1, False, "C")
        Else
            Telnet()
            'RunTelnet(PC.Name)
        End If

    End Sub
    Private Sub zenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zenToolStripButton.Click
        zenworks()
    End Sub
    Private Sub rdpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdpToolStripButton.Click
        If ConnectionExists = True Then
            If PC.TSEnabled Then
                LaunchRDP(PC.Name, False)
            Else
                If MsgBox("Remote Desktop is not enabled on " & PC.Name & vbNewLine & vbNewLine & _
                                "would you like to enable it?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, _
                                "Enable Remote Desktop?") = MsgBoxResult.Yes Then
                    EnableTS(True)
                    System.Threading.Thread.Sleep(500)
                    If TSEnabled(PC.Name) Then
                        If MsgBox("RDP has been enabled on " & PC.Name & "." & vbCr & _
                                    "It will not be accessible until" & vbCr & PC.Name & " has restarted." & vbCr & _
                                    vbCr & "Would you like to try anyway?", MsgBoxStyle.YesNo, "TS Enabled") = MsgBoxResult.Yes Then
                            LaunchRDP(PC.Name, False)
                        Else
                            MsgBox("Could not enable Remote Desktop")
                        End If
                    End If
                End If
            End If
        Else
            Try
                LaunchRDP(PC.Name, False)
            Catch ex As Exception
                If Trim(computername.Text) <> "" Then
                    LaunchRDP(Trim(computername.Text), False)
                End If
            End Try
        End If
    End Sub
    Private Sub vncToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vncToolStripButton.Click

        If vncinstall.Checked = True Then
            'RunVNC(pc.name, True)
            Try
                Dim vncThread As New System.Threading.Thread(AddressOf RunVNC_install)
                vncThread.Start()
            Catch ex As Exception
            End Try
        Else
            RunVNC(PC.Name, False)
        End If

    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        'WriteLog("")
        If VNC_INSTALL_RUNNING = True Then
            VNC_Warning()
            vnc_warning_count = vnc_warning_count + 1
            If vnc_warning_count < 2 Then Exit Sub
        End If

        ClearBoxes()
        If AltUserCheckBox.Checked And InStr(altusername_TextBox.Text, "\") <> 0 Then
            Dim altcompname As String = Mid(altusername_TextBox.Text, 1, InStr(altusername_TextBox.Text, "\") - 1)
            If Trim(UCase(altcompname)) = UCase(PC.Name) Then
                altusername_TextBox.Text = Mid(altusername_TextBox.Text, InStr(altusername_TextBox.Text, "\") + 1)
            End If
        End If
        computername.Text = ""

    End Sub
    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        If VNC_INSTALL_RUNNING = True Then
            VNC_Warning()
            vnc_warning_count = vnc_warning_count + 1
            If vnc_warning_count < 2 Then Exit Sub
        End If
        CMC_CLOSE()
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CMC_CLOSE()
    End Sub
    Private Sub ExitToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        CMC_CLOSE()
    End Sub

    Private Sub ButtonExit_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.MouseEnter
        ButtonExit.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub
    Private Sub ButtonExit_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonExit.MouseLeave
        ButtonExit.BackColor = System.Drawing.SystemColors.InactiveCaption
    End Sub
    Private Sub ButtonClear_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.MouseEnter
        ButtonClear.BackColor = System.Drawing.SystemColors.ActiveCaption
    End Sub
    Private Sub ButtonClear_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonClear.MouseLeave
        ButtonClear.BackColor = System.Drawing.SystemColors.InactiveCaption
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tabholder1.SelectedIndex = 0
    End Sub


#End Region

#Region "MENU ITEMS"

    ' File
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        System.Diagnostics.Process.Start(My.Application.Info.DirectoryPath & "\cmc.exe")
    End Sub
    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        If VNC_INSTALL_RUNNING = True Then
            VNC_Warning()
            Exit Sub
        End If

        ClearBoxes()
        If AltUserCheckBox.Checked And InStr(altusername_TextBox.Text, "\") <> 0 Then
            Dim altcompname As String = Mid(altusername_TextBox.Text, 1, InStr(altusername_TextBox.Text, "\") - 1)
            If Trim(UCase(altcompname)) = UCase(PC.Name) Then
                altusername_TextBox.Text = Mid(altusername_TextBox.Text, InStr(altusername_TextBox.Text, "\") + 1)
            End If
        End If
        computername.Text = ""
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        Me.SaveFileDialog1.FileName = PC.Name.ToString()
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.ToString = "" Then
            Exit Sub
        End If

        Dim filename As String = SaveFileDialog1.FileName.ToString()
        OutputToFile(filename, False)

        Me.Refresh()

    End Sub
    Private Sub AppendToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppendToolStripMenuItem.Click

        SaveFileDialog1.OverwritePrompt = False
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName.ToString = "" Then
            Exit Sub
        End If

        Dim filename As String = SaveFileDialog1.FileName.ToString()
        OutputToFile(filename, True)

        Me.Refresh()

    End Sub
    Private Sub OutputToFile(ByVal filename As String, ByVal bAppend As Boolean)

        Dim exportFile As New System.IO.StreamWriter(filename, bAppend)
        exportFile.WriteLine("==========================================================")
        exportFile.WriteLine("Computer:" & vbTab & computername.Text)
        exportFile.WriteLine(Now)
        exportFile.WriteLine("==========================================================")

        If Label_Name.Text <> "" And Label_OS.Text <> "" Then
            exportFile.WriteLine()
            exportFile.WriteLine("---------   Operating System   ------------")
            exportFile.WriteLine()
            exportFile.WriteLine("Resolved name" & vbTab & Label_Name.Text)
            exportFile.WriteLine("Resolved IP Address" & vbTab & Label_IP.Text)
            exportFile.WriteLine("Operating System" & vbTab & Label_OS.Text)
            exportFile.WriteLine("Service Pack" & vbTab & Label_SP.Text)
            exportFile.WriteLine("Version" & vbTab & Label_Ver.Text)
            exportFile.WriteLine("IE Version" & vbTab & ie.Text)
            exportFile.WriteLine("Last Boot Time" & vbTab & Label_Boot.Text)
            exportFile.WriteLine("Logged on user" & vbTab & Label_User.Text)
        End If

        If makemodel.Text <> "" And chassis.Text <> "" Then
            exportFile.WriteLine()
            exportFile.WriteLine("--------------   Hardware   ---------------")
            exportFile.WriteLine()
            exportFile.WriteLine("Make/Model" & vbTab & makemodel.Text)
            exportFile.WriteLine("Form Factor" & vbTab & chassis.Text)
            exportFile.WriteLine("Serial Number" & vbTab & SNoBox.Text)
            exportFile.WriteLine("RAM" & vbTab & RAMBox.Text)
            exportFile.WriteLine("CPU" & vbTab & cpuBox.Text)
            exportFile.WriteLine("Fixed Disks:")
            Dim i As Integer
            For i = 0 To (hdCombo.Items.Count() - 1)
                exportFile.WriteLine(hdCombo.Items(i))
            Next
        End If

        If hostname.Text <> "" And ipaddress.Text <> "" Then
            exportFile.WriteLine()
            exportFile.WriteLine("--------------    Network   ----------------")
            exportFile.WriteLine()
            exportFile.WriteLine("DNS Hostname" & vbTab & hostname.Text)
            exportFile.WriteLine(domainlabel.Text & vbTab & domain.Text)
            exportFile.WriteLine("MAC Address" & vbTab & macaddress.Text)
            exportFile.WriteLine("IP Address" & vbTab & ipaddress.Text)
            exportFile.WriteLine("Subnet Mask" & vbTab & subnet.Text)
            exportFile.WriteLine("Default Gateway" & vbTab & gateway.Text)
            exportFile.WriteLine("DNS Servers" & vbTab & dnsservers.Text)
            exportFile.WriteLine("Primary DNS Suffix" & vbTab & suffix.Text)
            exportFile.WriteLine("DNS suffix search order" & vbTab & sfx1.Text)
        End If

        If svc_datagrid.Rows.Count <> 0 Then
            exportFile.WriteLine()
            exportFile.WriteLine("--------------    Services   ----------------")
            exportFile.WriteLine()
            Dim i As Integer
            Dim cella As DataGridViewCell
            Dim cellb As DataGridViewCell
            Dim cellc As DataGridViewCell
            For i = 0 To svc_datagrid.RowCount
                Try
                    cella = svc_datagrid(0, i)
                    cellb = svc_datagrid(1, i)
                    cellc = svc_datagrid(2, i)
                    exportFile.WriteLine(cella.Value & vbTab & cellb.Value & vbTab & cellc.Value)
                Catch ex As Exception
                End Try
            Next
        End If

        If processgrid.Rows.Count <> 0 Then
            exportFile.WriteLine()
            exportFile.WriteLine("-------------- Processes ----------------")
            exportFile.WriteLine()
            Dim i As Integer = 0
            Dim pcella As DataGridViewCell
            Dim pcellb As DataGridViewCell
            For i = 0 To processgrid.RowCount
                Try
                    pcella = processgrid(0, i)
                    pcellb = processgrid(1, i)
                    exportFile.WriteLine(pcella.Value & vbTab & pcellb.Value)
                Catch ex As Exception
                End Try
            Next
        End If

        'If Software_ListBox.Items.Count <> 0 Then
        '    exportFile.WriteLine()
        '    exportFile.WriteLine("-------------- Software ----------------")
        '    exportFile.WriteLine()
        '    Dim i As Integer = 0
        '    For i = 0 To (Software_ListBox.Items.Count - 1)
        '        exportFile.WriteLine(Software_ListBox.Items.Item(i))
        '    Next
        'End If

        exportFile.WriteLine("")
        exportFile.Close()

    End Sub

    ' Options
    Private Sub Prefs_Menu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Prefs_Menu.Click
        iTabIndex = Tabholder1.SelectedIndex
        Tabholder1.SelectTab(options)
    End Sub
    Private Sub AlwaysOnTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click

        If AlwaysOnTopToolStripMenuItem.Checked Then
            'WriteLog("cmc - always on top invoked")
            Me.TopMost = True
            SaveSetting("CMC", "defaults", "top", "1")
        Else
            'WriteLog("cmc - always on top revoked")
            Me.TopMost = False
            SaveSetting("CMC", "defaults", "top", "0")
        End If
    End Sub
    Private Sub ToolbarEnabled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolbarEnabled.Click
        If ToolbarEnabled.Checked = True Then
            ToolStrip1.Enabled = True
        End If
    End Sub
    Private Sub MultiThreadMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MultiThreadMenuItem.Click
        If MultiThreadMenuItem.Checked = True Then
            MultiThreadMenuItem.Checked = False
        Else
            MultiThreadMenuItem.Checked = True
        End If
    End Sub
    Private Sub ClearHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearHistoryToolStripMenuItem.Click
        computername.Items.Clear()
        computername.AutoCompleteCustomSource.Clear()
    End Sub

    ' Tools
    Private Sub RemoteAssistanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteAssistanceToolStripMenuItem.Click
        StartRemoteAssistance(PC.Name)
    End Sub
    Private Sub RemoteDesktopConnectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteDesktopConnectionToolStripMenuItem.Click
        LaunchRDP(computername.Text, False)
    End Sub
    Private Sub RDPConsoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDPConsoleToolStripMenuItem.Click
        LaunchRDP(computername.Text, True)
    End Sub
    Private Sub EnableRDPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableRDPToolStripMenuItem.Click
        If TSEnabled(PC.Name) Then
            MsgBox("RDP is already enabled.")
        Else
            EnableTS(True)
            If TSEnabled(PC.Name) Then
                WriteLog(PC.Name & " - RDP Enabled")
            Else
                MsgBox("Could not enable Remote Desktop")
            End If
        End If
    End Sub
    Private Sub DisableRDPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableRDPToolStripMenuItem.Click
        If TSEnabled(PC.Name) = False Then
            MsgBox("RDP is already disabled.")
        Else
            EnableTS(False)
            If TSEnabled(PC.Name) = False Then
                WriteLog(PC.Name & " - RDP Disabled")
            Else
                MsgBox("Could not Disable Remote Desktop")
            End If
        End If
    End Sub
    Private Sub ConnectOnlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectOnlyToolStripMenuItem.Click
        RunVNC(PC.Name, False)
    End Sub
    Private Sub InstallAndConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallAndConnectToolStripMenuItem.Click
        'RunVNC(pc.name, True)
        Try
            Dim vncThread As New System.Threading.Thread(AddressOf RunVNC_install)
            vncThread.Start()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub InstallAndConnectNoUserPromptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstallAndConnectNoUserPromptToolStripMenuItem.Click
        Try
            Dim vncThread As New System.Threading.Thread(AddressOf RunVNC_install_noQuery)
            vncThread.Start()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ComputerManagementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputerManagementToolStripMenuItem.Click
        MMC_Snap_in("compmgmt")
    End Sub
    Private Sub EventViewerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EventViewerToolStripMenuItem.Click
        MMC_Snap_in("eventvwr")
    End Sub
    Private Sub LocalUsersAndGroupsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalUsersAndGroupsToolStripMenuItem.Click
        MMC_Snap_in("lusrmgr")
    End Sub
    Private Sub ServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesToolStripMenuItem.Click
        MMC_Snap_in("services")
    End Sub
    Private Sub SharedFoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SharedFoldersToolStripMenuItem.Click
        MMC_Snap_in("fsmgmt")
    End Sub
    Private Sub RSOPReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GpoRsop()
    End Sub
    Private Sub MSinfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSinfoToolStripMenuItem.Click
        Dim s As String = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Shared Tools\MSINFO").GetValue("Path", "")
        If File.Exists(s) Then
            Dim p As New Process
            p.StartInfo.FileName = s
            p.StartInfo.Arguments = "/computer " & PC.Name
            p.Start()
        End If
    End Sub

    ' power options
    Private Sub TurnOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnOffToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.Shutdown)
    End Sub
    Private Sub RestartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.Reboot)
    End Sub
    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.Logoff)
    End Sub
    Private Sub ForceLogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceLogoffToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.ForceLogOff)
    End Sub
    Private Sub ForceRebootToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceRebootToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.ForceReboot)
    End Sub
    Private Sub PowerDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerDownToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.PowerDown)
    End Sub
    Private Sub ForcePowerDownToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForcePowerDownToolStripMenuItem.Click
        RebootPC(Win32ShutdownFlag.ForcePowerDown)
    End Sub

    Private Sub ViewPrintersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPrintersToolStripMenuItem.Click
        Tabholder1.SelectTab(printers)
        Me.Refresh()
        RefreshPrinters()
    End Sub
    Private Sub PrintServerPropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintServerPropertiesToolStripMenuItem.Click
        Shell("cmd /c rundll32 printui.dll, PrintUIEntry /s /t1 /n\\" & PC.Name, AppWinStyle.Hide, False)
    End Sub
    Private Sub MappedDrivesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MappedDrivesMenu.Click
        Tabholder1.SelectTab(printers)
        Me.Refresh()
        mappings.Items.Clear()
        GetMappedDrives(PC.CurrentUser)
    End Sub
    Private Sub StartUpProgramsMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartUpProgramsMenuItem.Click
        Tabholder1.SelectTab(startup)
        Me.Refresh()
        StartUpCommands()
    End Sub
    Private Sub TelnetMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TelnetMenu.Click
        RunTelnet(PC.Name)
    End Sub
    Private Sub NetSendMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetSendMenu.Click
        iTabIndex = Tabholder1.SelectedIndex
        Tabholder1.SelectTab(message)
        Me.AcceptButton = Nothing
    End Sub
    Private Sub WindRegMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindRegMenuItem.Click
        WinRegEdit()
    End Sub
    ' external tools
    Private Sub RemRegMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemRegMenuItem.Click

        Dim path As String = My.Application.Info.DirectoryPath.ToLower & "\files\remreg.exe"
        If System.Diagnostics.Debugger.IsAttached Then
            path = path.Replace("cmc\bin\files\remreg.exe", "remoteregedit\obj\debug\remreg.exe")
        End If

        If File.Exists(path) Then
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = path
            If ConnectionExists Then
                psi.Arguments = PC.Name
            End If
            p.StartInfo = psi
            p.Start()
        Else
            MsgBox("File not found")
        End If
    End Sub
    Private Sub ADUserInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADUserInfoToolStripMenuItem.Click
        'Tabholder1.SelectTab(aduser)

        Dim Path As String = My.Application.Info.DirectoryPath.ToLower & "\files\admgmt.exe"
        If System.Diagnostics.Debugger.IsAttached Then
            Path = Path.Replace("cmc\bin\files\admgmt.exe", "admgmt\obj\Debug\admgmt.exe")
        End If

        If File.Exists(Path) Then
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = Path
            If ConnectionExists Then
                psi.Arguments = "/d:" & PC.CurrentUserDomain & " /u:" & Chr(34) & PC.CurrentUser & Chr(34)
            End If
            p.StartInfo = psi
            p.Start()
        End If
    End Sub
    Private Sub PerfMonMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfMonMenu.Click

        Dim Path As String = My.Application.Info.DirectoryPath.ToLower & "\files\perfmonitor.exe"
        If System.Diagnostics.Debugger.IsAttached Then
            Path = Path.Replace("\cmc\bin\files\perfmonitor.exe", "\perfmonitor\obj\Debug\perfmonitor.exe")
        End If

        If File.Exists(Path) Then
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = Path
            If ConnectionExists Then
                psi.Arguments = "\\" & PC.Name & " /m:" & PC.PhysicalMemory & " /h /t:1"
            End If
            p.StartInfo = psi
            p.Start()
        End If

    End Sub
    Private Sub admanagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admanagement.Click

        Me.Cursor = Cursors.WaitCursor
        Dim Path As String = My.Application.Info.DirectoryPath.ToLower & "\files\admgmt.exe"
        If System.Diagnostics.Debugger.IsAttached Then
            Path = Path.Replace("cmc\bin\files\admgmt.exe", "admgmt\obj\Debug\admgmt.exe")
        End If

        If File.Exists(Path) Then
            Dim p As New Process
            Dim psi As ProcessStartInfo = New ProcessStartInfo
            psi.FileName = Path
            If ConnectionExists Then
                psi.Arguments = "/d:" & PC.CurrentUserDomain & " /u:" & Chr(34) & PC.CurrentUser & Chr(34)
            End If
            p.StartInfo = psi
            p.Start()
        End If
        Me.Cursor = Cursors.Default

        Me.GO_Button.Select()
        Me.GO_Button.Focus()
        Me.AcceptButton = Me.GO_Button
    End Sub

    ' gpupdate
    Private Sub BothComputerAndUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BothComputerAndUserToolStripMenuItem.Click
        If PC.DomainMember Then
            If PC.OSVersionNumeric = 5.0 Then
                Dim pid1, pid2 As Integer
                pid1 = RemoteExec(PC.Name, "SECEDIT /REFRESHPOLICY MACHINE_POLICY /ENFORCE", False)
                pid2 = RemoteExec(PC.Name, "SECEDIT /REFRESHPOLICY USER_POLICY /ENFORCE", False)
                If pid1 > 0 And pid2 > 0 Then
                    MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "group policy on " & PC.Name)
                End If
            Else
                If RemoteExec(PC.Name, "GPUpdate", False) > 0 Then
                    MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "group policy on " & PC.Name)
                End If
            End If
        End If
    End Sub
    Private Sub OnlyComputerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlyComputerToolStripMenuItem.Click
        If PC.DomainMember Then
            If PC.OSVersionNumeric = 5.0 Then
                Dim pid1 As Integer
                pid1 = RemoteExec(PC.Name, "SECEDIT /REFRESHPOLICY MACHINE_POLICY /ENFORCE", False)
                If pid1 > 0 Then
                    MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "machine policy on " & PC.Name)
                End If
            Else
                If RemoteExec(PC.Name, "GPUPDATE /target:Computer", False) > 0 Then
                    MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "machine policy on " & PC.Name)
                End If
            End If
        End If
    End Sub
    Private Sub OnlyUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlyUserToolStripMenuItem.Click
        If PC.DomainMember Then
            If PC.OSVersionNumeric = 5.0 Then
                Dim pid1 As Integer
                pid1 = RemoteExec(PC.Name, "SECEDIT /REFRESHPOLICY USER_POLICY /ENFORCE", False)
                If pid1 > 0 Then
                    MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "user policy on " & PC.Name)
                End If
            Else
                If RemoteExec(PC.Name, "GPUPDATE /target:User", False) > 0 Then
                    MsgBox("gpupdate started ok")
                Else
                    MsgBox("there was an error refreshing" & vbCr & "user policy on " & PC.Name)
                End If
            End If
        End If
    End Sub

    ' Go
    Private Sub OperatingSystemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OperatingSystemToolStripMenuItem.Click
        Tabholder1.SelectTab(os)
    End Sub
    Private Sub NetworkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetworkToolStripMenuItem.Click
        Tabholder1.SelectTab(network)
    End Sub
    Private Sub ServicesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesToolStripMenuItem1.Click
        Tabholder1.SelectTab(services)
    End Sub
    Private Sub ProcessesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessesToolStripMenuItem.Click
        Tabholder1.SelectTab(processes)
    End Sub
    Private Sub SoftwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoftwareToolStripMenuItem.Click
        Tabholder1.SelectTab(software)
    End Sub
    Private Sub PrintersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintersToolStripMenuItem.Click
        Tabholder1.SelectTab(printers)
    End Sub
    Private Sub MappedDrivesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MappedDrivesToolStripMenuItem.Click
        Tabholder1.SelectTab(printers)
    End Sub
    Private Sub MessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessageToolStripMenuItem.Click
        Tabholder1.SelectTab(message)
    End Sub
    Private Sub StartupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartupToolStripMenuItem.Click
        Tabholder1.SelectTab(startup)
    End Sub
    Private Sub ADUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADUserToolStripMenuItem.Click
        Tabholder1.SelectTab(aduser)
    End Sub
    Private Sub GroupPolicyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupPolicyToolStripMenuItem.Click
        Tabholder1.SelectTab(gpo)
    End Sub
    Private Sub ToolsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem1.Click
        Tabholder1.SelectTab(tools)
    End Sub
    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        Tabholder1.SelectTab(test)
    End Sub
    Private Sub DeployToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeployToolStripMenuItem.Click
        Tabholder1.SelectTab(deploy)
    End Sub

    ' About
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Tabholder1.SelectTab(about)
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'WriteLog("support email link selected")
        System.Diagnostics.Process.Start("mailto:support@computermanagementconsole.co.uk")
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        'WriteLog("http link selected")
        System.Diagnostics.Process.Start("http://www.peterforman.net/")
    End Sub

#End Region


#Region "Shared Functions and Routines"

    ' Check whether string is an IP Address
    Private Function IsValidIPAddress(ByVal IPAddress As String) As Boolean

        Dim Count As Integer
        IsValidIPAddress = False
        Dim IPArray() As String = Split(IPAddress, ".", -1, CompareMethod.Text)
        If UBound(IPArray) <> 3 Then Exit Function

        For Count = 0 To UBound(IPArray)
            If Not IsNumeric(IPArray(Count)) Then Exit Function
            If (IPArray(Count)) > 255 Then Exit Function
        Next
        Return True

    End Function
    Private Function IsPingable(ByVal computer As String) As Boolean
        ' Check computer is online (pingable)

        Try
            If My.Computer.Network.Ping(PC.Name, 500) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

    End Function

    ' is process running (eg explorer.exe)
    Private Function IsProcessRunning(ByVal ProcessName As String) As Boolean
        On Error Resume Next
        Dim running As Boolean = False
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("SELECT Caption FROM Win32_Process WHERE Caption = '" & ProcessName & "'")
        For Each m In queryCollection
            running = True
            Exit For
        Next
        Return running

    End Function
    Private Function ProcessOwner(ByVal ProcessName As String) As String
        On Error Resume Next
        Dim account As String = ""
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery _
            ("SELECT * FROM Win32_Process WHERE Caption = '" & ProcessName & "'")

        For Each m In queryCollection
            Dim s(1) As String
            m.InvokeMethod("GetOwner", CType(s, Object()))
            PC.CurrentUser = s(0)
            PC.CurrentUserDomain = s(1)
            Dim sid(0) As String
            m.InvokeMethod("GetOwnerSID", CType(sid, Object()))
            PC.CurrentUserSID = sid(0)
        Next

        Return PC.CurrentUserDomain & "\" & PC.CurrentUser

    End Function
    ' Gets SID for given accountname - SIDS: http://support.microsoft.com/kb/163846
    Public Function GetSID(ByVal Username As String) As String

        Dim objWbem As Object
        Dim objWMIService As Object
        Dim objSID As Object
        Dim SIDsubkey As String
        Dim arrSubKeys As Array
        Dim SID As String = ""

        Try
            objWbem = GetObject("winmgmts:")
            objWMIService = GetObject _
            ("winmgmts:" & "{impersonationLevel=impersonate}!\\" & PC.Name & "\root\cimv2")
        Catch ex As Exception
            Return "error"
            Exit Function
        End Try

        ' ------------  Service Pack 4 check ------------------

        'If PC.OS = "Windows 2000" AndAlso PC.ServicePack = "Service Pack 4" Then
        If InStr(Label_SP.Text, "4") Then
            Dim QueryKey As RegistryKey
            Try
                QueryKey = RegistryKey.OpenRemoteBaseKey _
                (RegistryHive.Users, PC.Name)
            Catch ex As Exception
                Return "error"
                Exit Function
            End Try

            ' Enumerate <SID> Sub Keys
            arrSubKeys = QueryKey.GetSubKeyNames
        Else
            'arrSubKeys = wbem.RegGetSubKeys(HKU, "")
            arrSubKeys = wmi.RegistryEnumKeys(PC.Name, RegistryHive.Users, "")
        End If

        ' ------------  Service Pack 4 check  end --------------

        For Each SIDsubkey In arrSubKeys
            If UCase(SIDsubkey) = ".DEFAULT" Or UCase(SIDsubkey) = "S-1-5-18" Or _
            UCase(SIDsubkey) = "S-1-5-19" Or UCase(SIDsubkey) = "S-1-5-20" Or _
            InStr(UCase(SIDsubkey), "_CLASSES") <> 0 Then
                ' ignore
            Else

                ' Get Account associated with SID (SIDSubKey)
                Try
                    objSID = objWMIService.Get("Win32_SID.SID='" & SIDsubkey & "'")
                    ' If SID.account matches the username enumerate the network(subtree)
                    If UCase(objSID.accountname) = UCase(Username) Then
                        SID = SIDsubkey
                        Return SID
                        Exit Function
                    End If

                Catch ex As System.Runtime.InteropServices.COMException
                    SID = "error"
                End Try

            End If
        Next

        Return SID

    End Function

    ' Microsoft MMC
    Private Sub MMC_Snap_in(ByVal SnapIn As String)
        Try
            Shell("cmd /c " & SnapIn & ".msc /computer=" & PC.Name, AppWinStyle.Hide, False)
        Catch ex As Exception
        End Try
    End Sub

    ' Remote Control
    Private Sub LaunchRDP(ByVal strcomputer As String, ByVal console As Boolean)

        Try
            WriteLog(PC.Name & " - rdp connection initiated")

            Dim rdp As New System.Diagnostics.Process
            rdp.StartInfo.FileName = "mstsc.exe"

            Dim StrArg As String = "/v " & strcomputer & " "
            If console = True Then StrArg = StrArg & "/console"

            rdp.StartInfo.Arguments = StrArg

            rdp.Start()

            CMCeventLog("Remote Desktop Connection made to " & PC.Name)
        Catch ex As Exception
            WriteLog(PC.Name & " - rdp connection failed: " & ex.Message)
            Panel2.Text = "unable to run command"
        End Try

    End Sub
    Private Function TSEnabled(ByVal strcomputer As String) As Boolean

        If ConnectionExists = False Then Exit Function

        Dim enabled As Boolean = False

        If PC.OSVersionNumeric = 5.0 Then
            If wmi.RegistryGetDWORDValue(strcomputer, RegistryHive.LocalMachine, "SYSTEM\CurrentControlSet\Control\Terminal Server", "TSEnabled") = 1 Then
                enabled = True
            End If
        ElseIf PC.OSVersionNumeric > 5 Then
            Dim queryCollection As ManagementObjectCollection
            queryCollection = wmi.wmiQuery("Select AllowTSConnections from Win32_TerminalServiceSetting")
            Dim m As ManagementObject
            For Each m In queryCollection
                If m("AllowTSConnections") = 1 Then
                    enabled = True
                    Exit For
                End If
            Next
        End If

        Return enabled

    End Function
    Private Sub EnableTS(ByVal enable As Boolean)

        Dim value As Integer = 1
        If enable = False Then
            value = 0
        End If

        If PC.OSVersionNumeric = 5.0 Then
            wmi.RegistrySetDWORDValue(PC.Name, RegistryHive.LocalMachine, "SYSTEM\CurrentControlSet\Control\Terminal Server", "TSEnabled", value)
        ElseIf PC.OSVersionNumeric > 5 Then
            Dim m As ManagementObject
            Dim inParams As ManagementBaseObject
            Dim outParams As ManagementBaseObject
            Dim queryCollection As ManagementObjectCollection

            queryCollection = wmi.wmiQuery("Select * from Win32_TerminalServiceSetting")
            For Each m In queryCollection
                inParams = m.GetMethodParameters("SetAllowTSConnections")
                inParams("AllowTSConnections") = value
                outParams = m.InvokeMethod("SetAllowTSConnections", inParams, Nothing)
                If outParams.Properties("ReturnValue").Value <> 0 Then
                    MsgBox("Error setting TS Connection property")
                End If
            Next
        End If
    End Sub
    Private Sub CreateRDPFile()

        Dim filePath As String = My.Application.Info.DirectoryPath & "\conn.rdp"
        Dim RDPFile As New System.IO.StreamWriter(filePath, False)

        RDPFile.WriteLine("screen mode id:i:2")
        RDPFile.WriteLine("redirectprinters:i:0")
        RDPFile.WriteLine("authentication level:i:0")
        RDPFile.WriteLine("prompt for credentials:i:0")
        RDPFile.WriteLine("negotiate security layer:i:1")
        RDPFile.WriteLine("disable wallpaper:i:1")
        RDPFile.WriteLine("disable themes:i:1")
        RDPFile.WriteLine("bitmapcachepersistenable:i:1")
        RDPFile.WriteLine("audiomode:i:2")
        RDPFile.WriteLine("full address:s:" & PC.Name)
        RDPFile.WriteLine("username:s:" & cmcUser.username)
        RDPFile.WriteLine("domain: s:" & PC.DomainName)
        RDPFile.WriteLine("connect to console:i:" & "1")

        RDPFile.Close()


    End Sub
    Private Sub StartRemoteAssistance(ByVal strcomputer As String)

        Dim RemAssistProc As Process
        RemAssistProc = New Process

        With RemAssistProc.StartInfo
            .CreateNoWindow = True
            .FileName = "cmd.exe"
            .Arguments = "/c start hcp://CN=Microsoft%20Corporation,L=Redmond,S=Washington,C=US/Remote%20Assistance/Escalation/unsolicited/unsolicitedrcui.htm"
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Hidden
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
        End With
        RemAssistProc.Start()
        RemAssistProc = Nothing

    End Sub
    Private Sub zenworks()

        Dim consoleonedir As String = "C:\novell\consoleone\1.2\bin\"

        'option to connect via ip or name
        Dim zencmdstring As String
        Dim ZENaction As String = "Remote Control"

        If Label_IP.Text <> "" Then
            ' Use IP Address
            zencmdstring = "cmd /c " & consoleonedir & "zen\RcLaunch\rcconsole.exe -c" & """" & (ZENaction) & """" & " -a" & """" & PC.Name & """" & " -t" & """" & "0" & """" & " -s" & """" & "2" & """" & " -n" & """" & "DSS-TREE" & """"
        ElseIf IsValidIPAddress(PC.Name) Then
            ' Use IP Address
            zencmdstring = "cmd /c " & consoleonedir & "zen\RcLaunch\rcconsole.exe -c" & """" & (ZENaction) & """" & " -a" & """" & Label_IP.Text & """" & " -t" & """" & "0" & """" & " -s" & """" & "2" & """" & " -n" & """" & "DSS-TREE" & """"
        Else
            ' Use Computer Name
            zencmdstring = "cmd /c c:\novell\consoleone\1.2\bin\desktop4.exe -w" & Chr(34) & "CN=" & PC.Name & ".OU=Workstations.O=DSS" & Chr(34) & " -n" & Chr(34) & "DSS-TREE" & Chr(34) & " -c" & Chr(34) & "RemoteControl" & Chr(34)
        End If

        WriteLog(PC.Name & " - zenworks connection initiated")
        CMCeventLog("ZENWorks Remote Control Session made to " & PC.Name)

        Shell(zencmdstring, AppWinStyle.Hide, False)

    End Sub
    ' VNC
    Private Sub RunVNC(ByVal strcomputer As String, ByVal vncinstall As Boolean, Optional ByVal vnc_queryconnect As Boolean = True)

        Dim vncuser, vncpass As String
        Dim vncDeleteThread As New System.Threading.Thread(AddressOf VNC_Delete_Files)

        If vnc_queryconnect Then
            If PC.CurrentUser = "" Then vnc_queryconnect = False
        End If

        Dim path As String = My.Application.Info.DirectoryPath.ToLower & "\files\"
        If System.Diagnostics.Debugger.IsAttached Then
            path = path.Replace("\bin\files", "\resources\files")
        End If


        If vncinstall = False Then
            Shell(Chr(34) & path & "vncviewer.exe" & Chr(34) & " " & strcomputer, 0, False)
        Else

            Me.Cursor = Cursors.WaitCursor

            ' remove existing reg entries and winvnc service#
            Panel2.Text = "cleaning up previous instances..."
            VNC_Cleanup(strcomputer)

            WriteLog(strcomputer & " - vnc - installing service")

            If AltUserCheckBox.Checked Then
                vncuser = " -u " & Me.sAltUsername
                vncpass = " -p " & Me.sAltPassword
                If PC.DomainRole = "Domain Controller" Then vncuser = " -u " & Me.sAltDomain & "\" & Me.sAltDomainUser
            Else
                vncuser = ""
                vncpass = ""
            End If

            If IO.File.Exists(path & "winvnc\winvnc.cmd") = False OrElse IO.File.Exists(path & "winvnc\winvnc.reg") = False Then
                Panel2.Text = "preparing vnc files..."
                VNC_Create_Files(vnc_queryconnect)
                If File.Exists(path & "winvnc\winvnc.cmd") = False Then
                    MsgBox("Required files missing" & vbCr & path & "winvnc.cmd", MsgBoxStyle.Exclamation, "Error")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
            End If

            ' copy vnc server files to remote pc
            Panel2.Text = "copying files..."

            If shell_xcopy(path & "winvnc", "\\" & PC.Name & "\c$\winvnc") = False Then
                MsgBox("VNC failed at: filecopy", MsgBoxStyle.Critical, PC.Name & " - VNC Install Error")
                ' reset Cursor
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            ' If Not File.Exists(PC.Name & "\c$\winvnc\winvnc4.exe") Then
            '     do check...
            ' End If



           


            '' Run install cmd on remote computer
            'If psexecpath.Text <> "" Then
            '    Shell("cmd /c " & psexecfile & " \\" & strcomputer & vncuser & vncpass & " C:\winvnc\winvnc.cmd", 0, True)
            'Else
            If RemoteExec(strcomputer, "c:\winvnc\winvnc.cmd", True) <> 0 Then
                VNC_INSTALL_RUNNING = True
                vnc_warning_count = 0
                Me.ControlBox = False

                Panel2.Text = "starting vnc service..."
            Else
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            'End If

            Dim count As Integer = 0
            Dim svc_ok As Boolean = True
            Do While IsProcessRunning("winvnc4.exe") = False
                System.Threading.Thread.Sleep(1000)
                count += 1
                If count = 15 Then
                    svc_ok = False
                    Exit Do
                End If
            Loop

            If svc_ok = False Then
                If IsProcessRunning("winvnc4.exe") = False Then
                    Panel2.Text = "Error starting VNC service."
                    ' Delete remote VNC files
                    Shell("cmd /c rmDir \\" & strcomputer & "\c$\winvnc /S /Q", 0, True)
                    Panel2.Text = "vnc service removed"
                    WriteLog(strcomputer & " - vnc - uninstalled")

                    ' remove WinVNC Reg Entry
                    wmi.RegistryDeleteKeyRecursive(PC.Name, RegistryHive.LocalMachine, "Software\RealVNC")

                    ' delete local files
                    vncDeleteThread.Start()

                    Me.Cursor = Cursors.Default
                    VNC_INSTALL_RUNNING = False
                    Me.ControlBox = True
                    Exit Sub
                End If
            End If

            System.Threading.Thread.Sleep(2000)

            If vnc_queryconnect Then
                Panel2.Text = "VNC INSTALLED - Waiting for user to accept connection..."
            Else
                Panel2.Text = "VNC INSTALLED"
            End If

            CMCeventLog("VNC Installed on " & strcomputer & ". QueryConnect:" & vnc_queryconnect.ToString)
            Me.Cursor = Cursors.Default

            ' Run vnc viewer app
            Shell(Chr(34) & path & "vncviewer.exe" & Chr(34) & " " & strcomputer, 0, True)




            Me.Cursor = Cursors.WaitCursor
            Panel2.Text = "vnc service is being removed..."

            ' Wait for 1 Second after vnc viewer closed
            System.Threading.Thread.Sleep(800)



            ' Stop WINVNC service
            Shell("sc \\" & strcomputer & " stop winvnc4", 0, True)
            Panel2.Text = "vnc service stopped..."

            System.Threading.Thread.Sleep(2500)

            ' Remove WINVNC service
            Shell("sc \\" & strcomputer & " delete winvnc4", 0, True)




            ' Delete remote VNC files
            Shell("cmd /c rmDir \\" & strcomputer & "\c$\winvnc /S /Q", 0, True)
            Panel2.Text = "vnc service removed"
            WriteLog(strcomputer & " - vnc - uninstalled")

            ' remove WinVNC Reg Entry
            wmi.RegistryDeleteKeyRecursive(PC.Name, RegistryHive.LocalMachine, "Software\RealVNC")

            ' delete local files
            vncDeleteThread.Start()

            ' reset Cursor
            Me.Cursor = Cursors.Default
            VNC_INSTALL_RUNNING = False
            Me.ControlBox = True
            'computername.Enabled = True
        End If

    End Sub
    Private Sub RunVNC_install()
        ' holder for running vnc install in new thread
        RunVNC(PC.Name, True)
    End Sub
    Private Sub RunVNC_install_noQuery()
        ' holder for running vnc install in new thread
        RunVNC(PC.Name, True, False)
    End Sub
    Private vnc_warning_count As Integer
    Private Sub VNC_Warning()
        MsgBox("VNC has been installed on " & UCase(PC.Name) & "." & vbCrLf & vbCrLf & _
                "Please close the VNC session before" & vbCrLf & _
                "closing or disconnecting this cmc session" _
                , MsgBoxStyle.Exclamation, "CMC - VNC INSTALLATION")
    End Sub
    Private Sub VNC_Cleanup(ByVal strcomputer As String)
        On Error Resume Next
        wmi.RegistryDeleteKeyRecursive(strcomputer, RegistryHive.LocalMachine, "Software\RealVNC")
        wmi.RegistryDeleteKeyRecursive(strcomputer, RegistryHive.LocalMachine, "Software\UltraVNC")
        wmi.RegistryDeleteKeyRecursive(strcomputer, RegistryHive.LocalMachine, "Software\ORL")

        Dim running As Boolean = False
        Dim m As ManagementObject
        Dim outparams As ManagementBaseObject
        Dim queryCollection As ManagementObjectCollection
        queryCollection = wmi.wmiQuery("SELECT Name FROM Win32_Service WHERE Name ='winvnc'")
        For Each m In queryCollection
            If m("Name").ToString <> "winvnc4" Then
                outparams = m.InvokeMethod("StopService", Nothing, Nothing)
                Shell("sc \\" & strcomputer & " delete " & m("Name"), 0, True)
            End If
        Next
    End Sub
    Private Sub VNC_Create_Files(Optional ByVal vnc_queryconnect As Boolean = True)

        Dim queryconnect As String
        Dim queryconnectInt As String = "1"
        If vnc_queryconnect Then
            queryconnect = Chr(34) & "QueryConnect" & Chr(34) & "=dword:00000001"
        Else
            queryconnect = Chr(34) & "QueryConnect" & Chr(34) & "=dword:00000000"
            queryconnectInt = "0"
        End If


        Dim VNC_CMD_FILENAME As String = My.Application.Info.DirectoryPath.ToLower & "\files\winvnc\winvnc.cmd"
        If System.Diagnostics.Debugger.IsAttached Then
            VNC_CMD_FILENAME = VNC_CMD_FILENAME.Replace("cmc\bin", "cmc\resources")
        End If

        ' vista client error  here - permissions to local winvnc folder
        Dim writer As System.IO.StreamWriter
        Try
            writer = New System.IO.StreamWriter(VNC_CMD_FILENAME, False)
            writer.WriteLine("regedit /s c:\winvnc\winvnc.reg")
            writer.WriteLine("c:\winvnc\winvnc4.exe -register")
            writer.WriteLine("ping -n 2 127.0.0.1")
            writer.WriteLine("c:\winvnc\winvnc4.exe -start -QueryConnect=" & queryconnectInt & " -QueryOnlyIfLoggedOn")
            'winvnc4.exe -service -QueryConnect=1 -QueryConnectTimeout=30 -SecurityTypes=none -QueryOnlyIfLoggedOn
            writer.Close()
        Catch ex As Exception
            MsgBox("Check that you have at least modify permission" & vbCr & My.Application.Info.DirectoryPath.ToLower & "\files\winvnc", MsgBoxStyle.Critical, "NTFS permission Error")
            Exit Sub
        End Try


       

        Dim VNC_REG_FILENAME As String = My.Application.Info.DirectoryPath.ToLower & "\files\winvnc\winvnc.reg"
        If System.Diagnostics.Debugger.IsAttached Then
            VNC_REG_FILENAME = VNC_REG_FILENAME.Replace("cmc\bin", "cmc\resources")
        End If

        Dim regwriter As New System.IO.StreamWriter(VNC_REG_FILENAME, False)
        regwriter.WriteLine("REGEDIT4")
        regwriter.WriteLine("")
        regwriter.WriteLine("[HKEY_LOCAL_MACHINE\SOFTWARE\RealVNC\WinVNC4]")
        regwriter.WriteLine(Chr(34) & "SecurityTypes" & Chr(34) & "=" & Chr(34) & "None" & Chr(34))
        regwriter.WriteLine(queryconnect)
        regwriter.WriteLine(Chr(34) & "QueryOnlyIfLoggedOn" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "DisconnectAction" & Chr(34) & "=" & Chr(34) & "None" & Chr(34))
        regwriter.WriteLine(Chr(34) & "RemoveWallpaper" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "RemovePattern" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "DisableEffects" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "UpdateMethod" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "PollConsoleWindows" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "UseCaptureBlt" & Chr(34) & "=dword:00000001")
        regwriter.WriteLine(Chr(34) & "UseHooks" & Chr(34) & "=dword:00000001")
        regwriter.Close()

    End Sub
    Private Sub VNC_Delete_Files()
        ' delete local files
        Dim path As String = My.Application.Info.DirectoryPath.ToLower & "\files\winvnc\"
        If System.Diagnostics.Debugger.IsAttached Then
            path = path.Replace("cmc\bin\files", "cmc\resources\files")
        End If
        System.IO.File.Delete(path & "winvnc.cmd")
        System.IO.File.Delete(path & "winvnc.reg")
    End Sub

    Private Function shell_xcopy(ByVal SourceFolder As String, ByVal DestinationFolder As String) As Boolean
        Dim myProcess As Process = New Process()
        Dim s As String
        Dim exitcode As Integer
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True
        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write("xcopy """ & SourceFolder & """ " & """" & DestinationFolder & """" & " /E /C /I /Y" & System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        exitcode = myProcess.ExitCode

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()

        If exitcode = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Remote Command
    Private Sub Telnet()
        If ConnectionExists Then
            Dim telnetThread As New System.Threading.Thread(AddressOf RunTelnet)
            telnetThread.Start()
        Else
            Dim p As New Process
            Dim pi As ProcessStartInfo = New ProcessStartInfo
            pi.FileName = "telnet"
            pi.Arguments = computername.Text
            p.StartInfo = pi
            p.Start()
        End If
    End Sub
    Private Overloads Sub RunTelnet()
        RunTelnet(PC.Name)
    End Sub
    Private Overloads Sub RunTelnet(ByVal strComputer As String)

        If My.Computer.Info.OSVersion.Chars(1) = "6" Then
            MsgBox("Telnet command is not available on Vista OS", MsgBoxStyle.Critical, "Telnet Error")
            Return
        End If

        ChangeServiceStartmode("TlntSvr", "demand")
        System.Threading.Thread.Sleep(1000)
        StartService("TlntSvr")

        Dim p As New Process
        Dim pi As ProcessStartInfo = New ProcessStartInfo
        pi.FileName = "telnet"
        pi.Arguments = strComputer
        p.StartInfo = pi
        p.Start()

        Do While p.HasExited = False
            Thread.Sleep(2000)
        Loop

        ServiceControlStopService(strComputer, "TlntSvr")
        ChangeServiceStartmode("TlntSvr", "disabled")

    End Sub
    Private Sub cmcPSEXEC(ByVal psCommand As String, ByVal visible As Integer, ByVal waituntilfinished As Boolean, Optional ByVal Cmd_C_K As String = "K")

        Dim cmduser, cmdpass As String

        If AltUserCheckBox.Checked Then
            cmduser = " -u " & Me.sAltDomain & "\" & Me.sAltDomainUser
            cmdpass = " -p " & Me.sAltPassword
            ' second rate effort to prevent failure of alt credentials if domain controleer
            If PC.DomainRole = "Domain Controller" Then cmduser = " -u " & Me.sAltDomainUser
        Else
            cmduser = ""
            cmdpass = ""
        End If
        Try
            Shell("cmd /" & Cmd_C_K & " " & psexecfile & " \\" & PC.Name & cmduser & cmdpass & " " & psCommand, visible, waituntilfinished)
        Catch
            Panel2.Text = "unable to run this command"
        End Try

    End Sub
    Private Sub WinRegEdit()

        Panel2.Text = "opening remote registry..."

        Try

            Shell("regsvr32 /s " & """" & My.Application.Info.DirectoryPath & "\files\regx3.dll" & "", AppWinStyle.Hide, True)
            Dim oAutoIt As Object = CreateObject("AutoItX3.Control")

            Dim intresult As Integer = oAutoIt.WinExists("Registry Editor", "")
            If intresult = "0" Then
                System.Diagnostics.Process.Start("regedit.exe")
            Else
                oAutoIt.WinActivate("Registry Editor", "")
            End If
            oAutoIt.WinWaitActive("Registry Editor")
            oAutoIt.Send("{HOME}")
            oAutoIt.Send("{LEFT 2}")
            oAutoIt.Send("!f")
            oAutoIt.Send("c")
            oAutoIt.WinWaitActive("Select Computer")
            oAutoIt.Send(PC.Name)
            oAutoIt.Send("{ENTER}")

        Catch ex As Exception

            Dim RegeditProc As Process
            RegeditProc = New Process
            With RegeditProc.StartInfo
                .CreateNoWindow = True
                .FileName = "regedit.exe"
                .UseShellExecute = False
                .WindowStyle = ProcessWindowStyle.Normal
                .RedirectStandardOutput = True
                .RedirectStandardInput = True
            End With
            RegeditProc.Start()
            RegeditProc.WaitForInputIdle()

            Dim hWnd As Long = WinAPI_Window.FindWindowByCaption(0, "Registry Editor")
            Dim hWnd2 As Long = WinAPI_Window.FindWindowByCaption(0, "Select Computer")

            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("{HOME}")
            RegeditProc.WaitForInputIdle()
            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("{Left}")
            RegeditProc.WaitForInputIdle()
            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("{TAB}")
            RegeditProc.WaitForInputIdle()

            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("{HOME}")
            RegeditProc.WaitForInputIdle()
            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("{Left}")
            RegeditProc.WaitForInputIdle()

            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("%F")
            RegeditProc.WaitForInputIdle()
            WinAPI_Window.SetForegroundWindow(hWnd)
            System.Windows.Forms.SendKeys.Send("C")
            RegeditProc.WaitForInputIdle()

            WinAPI_Window.SetForegroundWindow(hWnd2)
            System.Windows.Forms.SendKeys.Send(PC.Name)
            RegeditProc.WaitForInputIdle()
            WinAPI_Window.SetForegroundWindow(hWnd2)
            System.Windows.Forms.SendKeys.Send("{ENTER}")
            RegeditProc.WaitForInputIdle()
        End Try

        Panel2.Text = "ready"
    End Sub

    ' Scheduled Jobs
    Public Function ScheduleJob(ByVal strComputer As String, _
                                ByVal strCommand As String, _
                                Optional ByVal Interactive As Boolean = True, _
                                Optional ByVal Time As String = "now") As Integer

        Dim wmiScheduledJob As ManagementClass
        Dim inParams As ManagementBaseObject
        Dim outParams As ManagementBaseObject
        Try
            wmiScheduledJob = New ManagementClass(wmiConnection.wmiScope, New ManagementPath("Win32_ScheduledJob"), Nothing)
            inParams = wmiScheduledJob.GetMethodParameters("Create")
            inParams("Command") = strCommand
            inParams("DaysOfMonth") = Nothing               ' Optional, only used if RunRepeatedly=true
            inParams("DaysOfWeek") = Nothing                ' Optional, 1=monday... only used if RunRepeatedly=true
            inParams("InteractWithDesktop") = Interactive   ' Optional, default:False
            inParams("RunRepeatedly") = False               ' Optional, default:False
            If Time = "now" Then
                inParams("StartTime") = ScheduleLocalTime(strComputer)
            Else
                Time = Replace(Time, ":", "")
                inParams("StartTime") = "********" & Time & "00.000000-000"
            End If
            outParams = wmiScheduledJob.InvokeMethod("Create", inParams, Nothing)
            ' jobID = outParams.Properties("JobId").Value
            ' ReturnValue = outParams.Properties("ReturnValue").Value

            Return outParams.Properties("JobId").Value
        Catch e As Exception
            WriteLog(PC.Name & " - error creating task. " & e.Message)
            Return 0
        End Try


    End Function
    Private Function RemoteExec(ByVal strComputer As String, _
                                ByVal strCommand As String, _
                                Optional ByVal wait_for_exit As Boolean = False) As Integer

        Dim procStart As ManagementClass
        Dim procClass As ManagementClass
        Dim ps As ManagementObject

        Try
            procStart = New ManagementClass(wmiConnection.wmiScope, New ManagementPath("Win32_ProcessStartup"), Nothing)
            ps = procStart.CreateInstance
            ps("ShowWindow") = 0
            procClass = New ManagementClass(wmiConnection.wmiScope, New ManagementPath("Win32_Process"), Nothing)

            Dim p() As Object = New Object() {strCommand, Nothing, ps, Nothing}
            procClass.InvokeMethod("Create", p)
            Dim pid As Integer = Convert.ToInt32(p(3))
            Return pid
        Catch
            Return 0
        End Try


    End Function


    Private Shared pids As ArrayList = New ArrayList

    ' timeoutSeconds = -1: Ignore
    ' timeoutSeconds = 0:  Wait until process finished
    ' timeoutSeconds = +(i): kill process if not complete after (i) seconds
    Private Sub Execute(ByVal cmd As String, ByVal machine As String, ByVal timeoutSeconds As Integer, Optional ByVal Show_Window As Integer = 1)
        Dim procStart As ManagementClass = New ManagementClass(wmiConnection.wmiScope, New ManagementPath("Win32_ProcessStartup"), Nothing)
        Dim ps As ManagementObject = procStart.CreateInstance
        ps("ShowWindow") = Show_Window ' (0/1)
        Dim procClass As ManagementClass = New ManagementClass(wmiConnection.wmiScope, New ManagementPath("Win32_Process"), Nothing)
        Dim watcher As ManagementEventWatcher = New ManagementEventWatcher("select * from __instancedeletionevent WITHIN 0.1 where Targetinstance ISA 'Win32_Process'")
        AddHandler watcher.EventArrived, AddressOf ProcessEnd
        pids.Clear()
        watcher.Start()
        Try
            Dim p() As Object = New Object() {cmd, Nothing, ps, Nothing}
            procClass.InvokeMethod("Create", p)
            Dim pid As Integer = Convert.ToInt32(p(3))


            ' We'll wait until the process created no longer exists on the(remote) machine
            If timeoutSeconds > 0 Then
                Dim endTime As DateTime = DateTime.Now.AddSeconds(timeoutSeconds)
                While ((DateTime.Compare(DateTime.Now, endTime) < 0) _
                AndAlso Not pids.Contains(pid))
                    System.Threading.Thread.Sleep(1000)
                End While
                If Not pids.Contains(pid) Then
                    'Kill the process
                    Dim m As ManagementObject
                    Dim queryCollection As ManagementObjectCollection
                    queryCollection = wmi.wmiQuery("Select * from Win32_Process Where ProcessID = " + Convert.ToString(pid))
                    Dim observer As ManagementOperationObserver = New ManagementOperationObserver()
                    For Each m In queryCollection
                        m.InvokeMethod(observer, "Terminate", Nothing)
                    Next
                    Throw New ApplicationException("Process timed out - killed(pid = " + pid.ToString & ")")
                End If
            ElseIf timeoutSeconds = 0 Then
                ' Wait until the command finish on the remote server

                Dim counter As Integer = 1
                While Not pids.Contains(pid) OrElse counter > 20
                    System.Threading.Thread.Sleep(1000)
                    counter = counter + 1
                End While

            Else
                ' The command has been started. Wait 500 milliseconds and 
                ' leave the command running without control
                System.Threading.Thread.Sleep(500)
            End If
        Finally
            watcher.Stop()
        End Try

    End Sub
    ' The event handler for the Process_End WMI event
    Private Shared Sub ProcessEnd(ByVal sender As Object, ByVal e As EventArrivedEventArgs)
        Dim pid As Object = CType(e.NewEvent.Properties("TargetInstance").Value, ManagementBaseObject).Properties("Handle").Value
        pids.Add(Convert.ToInt32(pid))
    End Sub


    Public Function ScheduleLocalTime(ByVal strComputer As String) As String


        Dim sHour, sMinute, sSecond As Integer
        Dim m As ManagementObject
        Dim queryCollection As ManagementObjectCollection


        If InStr(PC.OperatingSystem, "XP") <> 0 OrElse InStr(PC.OperatingSystem, "2003") <> 0 Then

            queryCollection = wmi.wmiQuery("Select hour, minute, second from Win32_LocalTime")
            For Each m In queryCollection
                sHour = m("Hour")
                sMinute = m("Minute")
                sSecond = m("Second")
            Next

        Else
            Dim dtmLocalTime As String = Nothing
            queryCollection = wmi.wmiQuery("Select LocalDateTime from Win32_OperatingSystem")
            For Each m In queryCollection
                dtmLocalTime = m("LocalDateTime").ToString
            Next
            sHour = Int32.Parse(Mid(dtmLocalTime, 9, 2))
            sMinute = Int32.Parse(Mid(dtmLocalTime, 11, 2))
            sSecond = Int32.Parse(Mid(dtmLocalTime, 13, 2))
        End If

        ' Get timezone difference for daylight saving
        Dim HourOffset As Integer = System.TimeZone.CurrentTimeZone.GetUtcOffset(Date.Now).Hours
        sHour = sHour - HourOffset


        If sSecond > 55 Then
            sMinute = sMinute + 2
        Else
            sMinute = sMinute + 1
        End If

        If sMinute > 59 Then
            sMinute = sMinute - 60
            sHour = sHour + 1
        End If

        ' set time to 5 seconds before scheduled time
        If sSecond < 45 Then
            Try
                RemoteExec(strComputer, "cmd /c time " & sHour & ":" & sMinute - 1 & ":" & "56")
            Catch ex As Exception

            End Try
        End If

        Return "********" & sHour.ToString.PadLeft(2, "0"c) & sMinute.ToString.PadLeft(2, "0"c) & "00.000000-000"


    End Function

    ' Power Off / Log Off / Restart
    Private Enum Win32ShutdownFlag
        [Logoff] = 0
        [Shutdown] = 1
        [Reboot] = 2
        [ForceLogOff] = 4
        [ForceReboot] = 6
        [PowerDown] = 8
        [ForcePowerDown] = 12
    End Enum
    Private Sub RebootPC(ByVal flag As Win32ShutdownFlag)
        Try
            Dim queryCollection As ManagementObjectCollection
            Dim m As ManagementObject
            queryCollection = wmi.wmiQuery("SELECT * FROM win32_operatingsystem")
            Dim myParams() As Object = {flag, 0}
            For Each m In queryCollection
                m.InvokeMethod("Win32Shutdown", myParams)
            Next

            WriteLog(PC.Name & " - PowerOption: " & flag)
            If flag <> 0 Then ClearBoxes()

        Catch ex As Exception
            MsgBox("unable to perform action")
        End Try
    End Sub

    ' File & Folder
    Private Sub openfolder(ByVal sFolder As String)
        Try
            System.Diagnostics.Process.Start(sFolder)
        Catch ex As Exception
            Panel2.Text = "unable to open folder"
        End Try
    End Sub
    Public Sub CopyFiletoRemote(ByVal strCommand As String, Optional ByVal OverWriteExisting As Boolean = True)

        Dim filename As String
        If My.Computer.FileSystem.FileExists(strCommand) Then
            If InStr(strCommand, "\") Then
                Dim arrFile As Array = Split(strCommand, "\")
                filename = arrFile(arrFile.Length - 1)
            Else
                filename = strCommand
            End If

            Dim sPath As String = "\\" & PC.Name & "\" & Replace(PC.SystemDirectory, ":", "$")
            System.IO.File.Copy(strCommand, sPath & "\" & filename, OverWriteExisting)
        End If

    End Sub
    Private Function UnZipFile(ByVal inputfile As String) As String
        Dim outputfolderpath As String = My.Application.Info.DirectoryPath & "\files"
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\files\xzip.dll") Then
            Try
                Shell("regsvr32 /s " & Chr(34) & My.Application.Info.DirectoryPath & "\files\xzip.dll" & Chr(34), 0, True)
                Dim objZip As Object = CreateObject("XStandard.Zip")
                objZip.UnPack(inputfile, outputfolderpath)
                objZip = Nothing
                Return "Success"
            Catch ex As Exception
                WriteLog("cmc - unzip file failed: " & ex.Message)
                Return "Fail"
            End Try
        Else
            WriteLog("cmc - file not found - xzip.dll")
            Return "Fail"
        End If
    End Function
    ' Recursively copy all files and subdirectories
    Private Sub RecursiveCopyFiles(ByVal sourceDir As String, _
                                    ByVal destDir As String, _
                                    ByVal fRecursive As Boolean, _
                                    ByVal overWrite As Boolean)

        Dim i As Integer
        Dim posSep As Integer
        Dim sDir As String
        Dim aDirs() As String
        Dim sFile As String
        Dim aFiles() As String

        ' Add trailing separators to the supplied paths if they don't exist.
        If Not sourceDir.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) Then
            sourceDir &= System.IO.Path.DirectorySeparatorChar
        End If

        If Not destDir.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) Then
            destDir &= System.IO.Path.DirectorySeparatorChar
        End If

        ' Recursive switch to continue drilling down into dir structure.
        If fRecursive Then

            ' Get a list of directories from the current parent.
            aDirs = System.IO.Directory.GetDirectories(sourceDir)
            ' Check for 0 subfolders - else fails to create 'destDir + sDir'
            If aDirs.Length = 0 Then
                System.IO.Directory.CreateDirectory(destDir)
            Else

                For i = 0 To aDirs.GetUpperBound(0)

                    ' Get the position of the last separator in the current path.
                    posSep = aDirs(i).LastIndexOf("\")

                    ' Get the path of the source directory.
                    sDir = aDirs(i).Substring((posSep + 1), aDirs(i).Length - (posSep + 1))

                    ' Create the new directory in the destination directory.
                    System.IO.Directory.CreateDirectory(destDir + sDir)

                    ' Since we are in recursive mode, copy the children also
                    RecursiveCopyFiles(aDirs(i), (destDir + sDir), fRecursive, overWrite)
                Next

            End If

        End If

        ' Get the files from the current parent.
        aFiles = System.IO.Directory.GetFiles(sourceDir)

        ' Copy all files.
        For i = 0 To aFiles.GetUpperBound(0)

            ' Get the position of the trailing separator.
            posSep = aFiles(i).LastIndexOf("\")

            ' Get the full path of the source file.
            sFile = aFiles(i).Substring((posSep + 1), aFiles(i).Length - (posSep + 1))
            Try


                ' Copy the file.
                System.IO.File.Copy(aFiles(i), destDir + sFile, False)
                'addToConsoleWindow("Copied " & sFile & " to " & destDir)
            Catch ex As Exception
                If overWrite = False Then
                    'errorBoxShow(ex.Message)
                    'addToConsoleWindow("Skipping..." & ex.Message)
                Else
                    System.IO.File.Copy(aFiles(i), destDir + sFile, True)
                    'addToConsoleWindow("Overwriting old " & sFile & " in " & destDir)
                End If

            End Try
        Next i

    End Sub
    Public Function IsFolder(ByVal path As String) As Boolean

        ' Add trailing backslash
        If Not path.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) Then _
                         path &= System.IO.Path.DirectorySeparatorChar

        ' Check whether is valid directory
        If System.IO.Directory.Exists(path) Then
            Return True
        Else
            Return False
        End If

    End Function
    Private Function GetFolderName_From_Path(ByVal folderpath As String) As String
        Dim foldername As String

        ' Add trailing separator to the supplied path if they don't exist.
        If Not folderpath.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) Then
            folderpath &= System.IO.Path.DirectorySeparatorChar
        End If

        Dim folders() As String = Split(StrReverse(folderpath), "\")
        If folders.Length > 1 Then
            foldername = StrReverse(folders(1))
            Return foldername
        Else
            Return String.Empty
        End If
    End Function
    Private Function Path_from_filename(ByVal filepath As String) As String
        If Not InStr(filepath, System.IO.Path.DirectorySeparatorChar) = 0 Then
            Dim ArrFldr() As String = Split(filepath, System.IO.Path.DirectorySeparatorChar)
            Dim path As String = String.Empty
            For i As Integer = 0 To ArrFldr.Length - 2
                path &= ArrFldr(i) & "\"
            Next
            Return path
        Else
            Return filepath
        End If
    End Function

    ' CMC operations
    Private Sub Tabholder1_Selecting(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlCancelEventArgs) Handles Tabholder1.Selecting
        Select Case LCase(Tabholder1.SelectedTab.Name)
            Case "os"
                Me.AcceptButton = GO_Button
            Case "network"
                Me.AcceptButton = networkupdate
            Case "services"
                Me.AcceptButton = refreshsvc
            Case "processes"
                Me.AcceptButton = ProcessRefresh
            Case "printers"
                Me.AcceptButton = Nothing
            Case "software"
                Me.AcceptButton = software_button
            Case "deploy"
                Me.AcceptButton = Nothing
            Case "message"
                Me.AcceptButton = Nothing
            Case "startup"
                Me.AcceptButton = startupbutton
            Case "aduser"
                Me.AcceptButton = userupdate_button
            Case "tools"
                Me.AcceptButton = Nothing
            Case "options"
                Me.AcceptButton = Save_Button
                Me.DomainCombo.SelectedIndex = 0
            Case "about"
                Me.AcceptButton = aboutOK
            Case "test"
                Me.AcceptButton = Nothing
            Case "gpo"
                Me.AcceptButton = Nothing
                If gpoDebugCombo.Text = String.Empty Then
                    gpupdateChoice.SelectedIndex = 2
                    gpoDebugCombo.SelectedText = GPODebugSetting
                End If

            Case Else
                Me.AcceptButton = GO_Button
        End Select
    End Sub
    Public Sub ClearBoxes()

        If FormCleared = False Then

            ' Disable Menu Items
            MicrosoftMMCToolStripMenuItem.Enabled = False
            RemoteControlToolStripMenuItem.Enabled = False
            If ToolbarEnabled.Checked Then
                ToolStrip1.Enabled = True
            Else
                ToolStrip1.Enabled = False
            End If
            WindRegMenuItem.Enabled = False
            RemRegMenuItem.Enabled = False
            TelnetMenu.Enabled = False
            MSinfoToolStripMenuItem.Enabled = False
            GPUpdateToolStripMenuItem.Enabled = False
            BothComputerAndUserToolStripMenuItem.Enabled = False
            OnlyUserToolStripMenuItem.Enabled = False
            NetSendMenu.Enabled = False
            PrintersMenuItem.Enabled = False
            StartUpProgramsMenuItem.Enabled = False

            ' disable buttons
            adbutton.Enabled = False
            vncinstall.Enabled = False
            GO_Button.Enabled = True
            Button_openshare.Enabled = False
            HWButton.Enabled = False
            software_button.Enabled = False
            ProcessRefresh.Enabled = False
            refreshsvc.Enabled = False
            startupbutton.Enabled = False
            networkupdate.Enabled = False
            MappedDrivesButton.Enabled = False
            printerRefresh.Enabled = False

            ' network tab
            ClearNetwork()

            ' OS Tab
            ClearOS()

            ' hw
            clearHW()

            ' Service Tab
            svc_datagrid.Rows.Clear()

            ' Process Tab
            newprocess.Text = ""
            processgrid.Rows.Clear()
            Me.pGrid_ID = ""
            Me.pGrid_Name = ""
            Me.pGrid_Path = ""

            ' Software tab
            sgrid.Rows.Clear()

            ' Printers
            ClearPrinters()

            ' gpo tab
            ClearGPOTab()

            ' Deploy Tab
            _to.Text = ""

            ' Tools Tab
            RenameGroupBox.Enabled = False
            domainroleLabel.Text = ""
            oldname.Text = ""
            newname.Text = ""
            joindompass.Text = ""
            EnableRDPToolStripMenuItem.Enabled = False
            SaveToolStripMenuItem.Enabled = False
            AppendToolStripMenuItem.Enabled = False
            ShutDownMenu.Enabled = False

            ' Message Tab
            NetSendTextBox.Text = ""
            msgboxTitle.Text = "Message From " & My.User.Name

            ' StartUp tab
            ClearStartUp()

            ' test tab
            sitename.Text = ""
            org.Text = ""



            If AltUserCheckBox.Checked Then _
                Shell("net use \\" & PC.Name & "\ipc$ /delete /y", 0, False)

            System.GC.Collect()

            FormCleared = True

            Try
                PC.Clear()
            Catch ex As Exception
            End Try

        End If

        GO_Button.Enabled = True
        Me.sDrivesInUse = ""
        Me.AcceptButton = GO_Button
        Tabholder1.SelectedIndex = 0
        notification_label.Text = ""
        Panel2.Text = "ready"
        Panel3.Text = "© peter forman"
        ConnectionExists = False
        ClearADUser()


    End Sub
    Private Sub EnableButtons()
        ToolStrip1.Enabled = True
        SaveToolStripMenuItem.Enabled = True
        AppendToolStripMenuItem.Enabled = True
        RenameArea.Enabled = True
        vncinstall.Enabled = True
        HWButton.Enabled = True
        software_button.Enabled = True
        ProcessRefresh.Enabled = True
        refreshsvc.Enabled = True
        startupbutton.Enabled = True
        networkupdate.Enabled = True
        MicrosoftMMCToolStripMenuItem.Enabled = True
        RemoteControlToolStripMenuItem.Enabled = True
        TelnetMenu.Enabled = True
        WindRegMenuItem.Enabled = True
        RemRegMenuItem.Enabled = True
        NetSendMenu.Enabled = True
        ShutDownMenu.Enabled = True
        PrintersMenuItem.Enabled = True
        StartUpProgramsMenuItem.Enabled = True
        MappedDrivesButton.Enabled = True
        printerRefresh.Enabled = True
        addptr.Enabled = True
        ptrrefresh.Enabled = True
        MappedDrivesMenu.Enabled = True
        MSinfoToolStripMenuItem.Enabled = True
        audio_label.Visible = True
        video_label.Visible = True
        GPO_EnableItems()
    End Sub
    Private Sub CMC_CLOSE()

        ' Save History Items
        'SaveHistory()

        ' Release mapped ipc share
        Shell("net use \\" & PC.Name & "\ipc$ /delete /y", 0, False)
        '    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", "NoRecentDocsNetHood", "0", Microsoft.Win32.RegistryValueKind.DWord)
        System.GC.Collect()
        End

    End Sub


#End Region

#Region "Logging/History"
    ' Log
    Public Sub WriteLog(ByVal Message As String)
        Try
            TraceLog = System.IO.File.AppendText(Me.LogFilePath)
            TraceLog.WriteLine(Format(Now, "dd MMM yyyy HH:mm:ss") & " - " & Message)
            TraceLog.Flush()
            TraceLog.Close()
        Catch ex As Exception
            'MsgBox("Log File Error")
        End Try
    End Sub
    Private Sub ViewLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewLogToolStripMenuItem.Click
        Dim viewlogProc As Process
        viewlogProc = New Process

        With viewlogProc.StartInfo
            .CreateNoWindow = True
            .FileName = "notepad.exe"
            .Arguments = Me.LogFilePath
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Hidden
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
        End With
        viewlogProc.Start()
        viewlogProc = Nothing

    End Sub
    Private Sub ClearLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogToolStripMenuItem.Click
        TraceLog.Close()
        File.Delete(LogFilePath)
        TraceLog = System.IO.File.CreateText(LogFilePath)
        TraceLog.Close()
    End Sub

    ' Event Log
    Private Sub CMCeventLog(ByVal sEvent As String)

        Dim sSource As String = "CMC"
        Dim sLog As String = "Application"
        Dim sMachine As String = "."

        Dim ELog As New EventLog("Application", ".", "CMC")
        ELog.WriteEntry(sEvent)
        'ELog.WriteEntry(sEvent, EventLogEntryType.Warning, 234, CType(3, Short))

    End Sub

    ' History
    Private Sub LoadHistory()

        computername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        computername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        computername.MaxDropDownItems = 9

        Dim hist As String() = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("HistoryItems")
        If Not hist Is Nothing Then
            For Each item As String In hist
                If Not String.IsNullOrEmpty(item) Then
                    computername.Items.Add(item)
                    computername.AutoCompleteCustomSource.Add(item)
                End If
            Next
        End If
    End Sub
    Private Sub SaveHistory()

        Dim limit As Integer = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue("HistorySize", 40)

        Dim i As Integer = 0
        Dim historyList As New ArrayList
        For Each comp As String In computername.Items
            historyList.Add(comp)
            i += 1
            If i = limit Then Exit For
        Next

        Dim string_array() As String
        string_array = DirectCast(historyList.ToArray(GetType(String)), String())

        Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue("HistoryItems", string_array, RegistryValueKind.MultiString)

    End Sub
    Private Sub AddToHistory(ByVal strComputer As String)

        ' see if entry already exists in list
        Try
            Dim index As Integer = computername.FindStringExact(LCase(strComputer))
            If index <> ListBox.NoMatches Then
                computername.Items.RemoveAt(index)
            End If
        Catch ex As Exception
        End Try

        ' add name to top of drop down list
        computername.Items.Insert(0, LCase(strComputer))
        ' add name to autocomplete source
        computername.AutoCompleteCustomSource.Add(LCase(strComputer))
        ' reload autocomplete source
        computername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource

    End Sub

#End Region

#Region "TEST"

    ' exec
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exec.Click
        If copy.Checked Then CopyFiletoRemote(command.Text, True)
        If interactively.Checked Then
            returnval.Text = ScheduleJob(PC.Name, command.Text)
        Else
            'returnval.Text = RemoteExec(PC.Name, command.Text)
            Execute(command.Text, PC.Name, 0, 0)
            MsgBox("exe done")
        End If
    End Sub

    ' screenshot (lsgrab)
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GetScreenShot(PC.Name)
    End Sub
    Private Sub GetScreenShot(ByVal sComputer As String)

        'Set the screenshot grabber path
        Dim strLsGrab As String = Chr(34) & My.Application.Info.DirectoryPath & "\Files\lsgrab.exe" & Chr(34)

        'Finally, run the screen grabber command
        Dim strCommand As String = strLsGrab & " /c:" & sComputer & " /p:" & Chr(34) & My.Application.Info.DirectoryPath & "\" & Chr(34)

        Shell(strCommand, AppWinStyle.Hide, True)

        Dim strFile As String = My.Application.Info.DirectoryPath & "\" & sComputer & ".jpg"

        If File.Exists(strFile) Then
            If FileLen(strFile) > 20000 Then
                System.Diagnostics.Process.Start(strFile)
            Else
                MsgBox("screen locked")
            End If
        Else
            MsgBox("screenshot not created")
        End If

    End Sub

    ' stdin - stdout
    Private Sub stdInbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stdInbtn.Click
        read_console(testbox.Text)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        command_window(cmdtorun.Text)
    End Sub
    Private Sub command_window(ByVal Command_txt As String)

        Dim myProcess As Process = New Process()
        Dim s As String

        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()

        Dim stdIn As StreamWriter = myProcess.StandardInput
        stdIn.AutoFlush = True
        Dim stdOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError

        stdIn.Write(Command_txt & System.Environment.NewLine)
        stdIn.Write("exit" & System.Environment.NewLine)

        Do While Not stdOut.EndOfStream
            s = stdOut.ReadLine
            If Not String.IsNullOrEmpty(s) Then ' AndAlso InStr(s, ">exit") = 0 Then
                testbox.AppendText(Trim(s) & System.Environment.NewLine)
                testbox.ScrollToCaret()
                testbox.Refresh()
            End If
        Loop

        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        Dim exittime As String = CStr(myProcess.ExitTime)
        Dim exitcode As Integer = myProcess.ExitCode

        stdIn.Close()
        stdOut.Close()
        sErr.Close()
        myProcess.Close()

    End Sub
    Private Sub read_console(ByVal Command As String)

        Dim myProcess As Process = New Process()
        Dim s As String
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.CreateNoWindow = True
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.StartInfo.RedirectStandardError = True
        myProcess.Start()
        Dim sIn As StreamWriter = myProcess.StandardInput
        sIn.AutoFlush = True

        Dim sOut As StreamReader = myProcess.StandardOutput
        Dim sErr As StreamReader = myProcess.StandardError
        sIn.Write(Command & System.Environment.NewLine)
        sIn.Write("exit" & System.Environment.NewLine)
        s = sOut.ReadToEnd()
        If Not myProcess.HasExited Then
            myProcess.Kill()
        End If

        MessageBox.Show("command window closed at: " & myProcess.ExitTime & "." & _
            System.Environment.NewLine & "Exit Code: " & myProcess.ExitCode)

        sIn.Close()
        sOut.Close()
        sErr.Close()
        myProcess.Close()

        MessageBox.Show(s)
    End Sub

    'Event Log
    Public Sub ListEventLog()

        Dim objLogs() As EventLog
        objLogs = EventLog.GetEventLogs(PC.Name)

        For Each objLog As EventLog In objLogs
            'MsgBox(objLog.LogDisplayName) 'List: 'Application' , 'Security' , 'System' etc
            For Each objEntry As EventLogEntry In objLog.Entries
                'If DateDiff(DateInterval.Minute, objEntry.TimeGenerated, DateTime.Now) > 10 Then Exit For
                If objEntry.Source = "MsiInstaller" AndAlso DateDiff(DateInterval.Day, objEntry.TimeGenerated, DateTime.Now) > 1 Then
                    MsgBox("Source: " & objEntry.Source & " Time: " & objEntry.TimeGenerated.ToString & " Message: " & objEntry.Message)
                End If
            Next
        Next

    End Sub
    Public Function LastLogEntry(Optional ByVal LogName As String = "Application") As String
        'gets message for last entry in specified log

        Dim objLogs() As EventLog

        'Dim objEntry As EventLogEntry
        Dim objLog As EventLog = Nothing
        objLogs = EventLog.GetEventLogs()

        For Each objLog In objLogs
            If objLog.LogDisplayName = LogName Then Exit For
        Next

        If Not objLog Is Nothing Then
            Return objLog.Entries(objLog.Entries.Count - 1).Message
        Else
            Return String.Empty
        End If

    End Function
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListEventLog()
    End Sub


    Private Sub btn_AddDomAdmins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddGroup.Click

        AddtoLocalGroup("Administrators", groupToAdd.Text)

    End Sub
    Private Sub AddtoLocalGroup(ByVal sLocalGroup As String, ByVal sDomainGroup As String)

        Const ADS_SECURE_AUTHENTICATION As Integer = &H1
        Const ADS_USE_ENCRYPTION As Integer = &H2

        sDomainGroup = Replace(sDomainGroup, "\", "/")

        Me.Cursor = Cursors.WaitCursor

        ' Bind to the local Administrators group with alternate credentials.
        Dim objNS As Object = GetObject("WinNT:")
        Dim objLocalAdmins As Object = objNS.OpenDSObject("WinNT://" & PC.Name _
            & "/" & sLocalGroup & ",group", Me.sAltUsername, Me.sAltPassword, _
            ADS_SECURE_AUTHENTICATION Or ADS_USE_ENCRYPTION)

        ' Bind to domain group.
        'Dim objDomainGroup As Object = GetObject("WinNT://District/Domain Admins,group")
        Dim objDomainGroup As Object = GetObject("WinNT://" & sDomainGroup & ",group")

        ' Check if already a member.
        Try
            ' Add the domain group to the local group.
            objLocalAdmins.Add(objDomainGroup.AdsPath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btn_GetSiteOrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GetSiteOrg.Click
        sitename.Text = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\DHIS", "Site")
        org.Text = wmi.RegistryGetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\DHIS", "Org")
    End Sub
    Private Sub setSiteOrg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setSiteOrg.Click
        Me.Cursor = Cursors.WaitCursor
        wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\DHIS", "Site", sitename.Text)
        wmi.RegistrySetStringValue(PC.Name, RegistryHive.LocalMachine, "Software\DHIS", "Org", org.Text)
        Me.Cursor = Cursors.Default
    End Sub



    Friend Sub ProcessExited(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim myProcess As Process = DirectCast(sender, Process)
        MessageBox.Show("The process exited, raising " & _
           "the Exited event at: " & myProcess.ExitTime & _
           "." & System.Environment.NewLine & _
           "Exit Code: " & myProcess.ExitCode)
        myProcess.Close()
    End Sub

    ' Monitor



    'HKLM "SYSTEM\CurrentControlSet\Enum\DISPLAY"

    'enum subkeys - 1 per monitor + def monitor
    'Get All Monitors: if subkey value HardwareID contains "monitor\..." then a monitor.
    'Get Active Monitors: if subkey has a subkey named CONTROL then it is current monitor.
    'For each active monitor:
    '    ' Get EDID From Active Monitors
    '	arrtmpResult = RegGetBinaryValue(strMonitorRegKey & "\Device Parameters","EDID")
    '	for each bytevalue in arrtmpResult
    '		strtmpResult=strtmpResult & chr(bytevalue)
    '	next
    'Next


    'DISPLAY
    '---Default_Monitor
    '       -- 5&31b5448&0&11337799&01&00
    '			-- Device Parameters
    '			-- LogConf
    '			HardwareID	REG_MULTI_SZ	Monitor\Default_Monitor
    '---DELA026
    '       -- 5&31b5448&0&11335587&01&00
    '			-- Control
    '			-- Device Parameters
    '			-- LogConf
    '			HardwareID	REG_MULTI_SZ	Monitor\DELA026
    '---NEC6604
    '       -- 5&31b5448&0&11335587&01&00
    '			-- Device Parameters
    '			-- LogConf
    '			HardwareID	REG_MULTI_SZ	Monitor\NEC6604
    Private Sub btn_Monitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Monitor.Click
        Get_EDID_Data()
    End Sub
    Private Sub Get_EDID_Data()

        If PC.OS = "Windows XP" Then

            Dim DisplayBaseKey As String = "SYSTEM\CurrentControlSet\Enum\DISPLAY"
            Dim DisplayReg As RegistryKey = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC.Name).OpenSubKey(DisplayBaseKey)

            Dim intDisplayCount As Integer = 0
            Dim ActiveDisplayKeys() As String = Nothing
            Dim arrMonitorKeys() As String = DisplayReg.GetSubKeyNames ' Def Monitor, DELA026, NEC6604

            Dim bControl As Boolean

            For Each MonitorKey As String In arrMonitorKeys
                Dim HexSubKey() As String = DisplayReg.OpenSubKey(MonitorKey).GetSubKeyNames
                For Each HexKey As String In HexSubKey
                    For Each val As String In DisplayReg.OpenSubKey(MonitorKey & "\" & HexKey).GetValueNames
                        If val = "HardwareID" Then

                            bControl = False

                            ' check for Control Sub Key - indicates Active Monitor
                            For Each checkreg As String In DisplayReg.OpenSubKey(MonitorKey & "\" & HexKey).GetSubKeyNames
                                If checkreg = "Control" Then
                                    bControl = True
                                End If
                            Next

                            If bControl Then
                                ' for each loop to read value of HardwareID due to Multi_SZ value
                                For Each multiVal As String In DisplayReg.OpenSubKey(MonitorKey & "\" & HexKey).GetValue("HardwareID")
                                    ' If monitor then store key in array and increment count
                                    If multiVal.ToLower.StartsWith("monitor\") Then
                                        'If Microsoft.VisualBasic.Left(multiVal, 8).ToLower = "monitor\" Then
                                        ReDim Preserve ActiveDisplayKeys(intDisplayCount)
                                        ActiveDisplayKeys.SetValue(MonitorKey & "\" & HexKey, intDisplayCount)
                                        intDisplayCount = intDisplayCount + 1
                                    End If
                                Next
                            End If


                        End If
                    Next
                Next
            Next


            For i As Integer = 0 To intDisplayCount - 1
                Dim Key As String = "SYSTEM\CurrentControlSet\Enum\DISPLAY\" & ActiveDisplayKeys(i) & "\Device Parameters" ') ' REG_BINARY VALUE: EDID
                'Displays(intdisplaycount - 1, 1) = reg2.GetRegistryValue("EDID", "")
                'Dim BinVal() = RegistryKey.OpenRemoteBaseKey(RegistryHive.LocalMachine, PC.Name).OpenSubKey(Key).GetValue("EDID")
                Dim strRAWEDID As String = RegistryGetBinaryValue(PC.Name, RegistryHive.LocalMachine, Key, "EDID")
                MsgBox(strRAWEDID)
                'MsgBox(GetModelFromEDID(strRAWEDID))






                '            '*********************************************************************
                '            'first get the model and serial numbers from the vesa descriptor
                '            'blocks in the edid. the model number is required to be present
                '            'according to the spec. (v1.2 and beyond)but serial number is not
                '            'required. There are 4 descriptor blocks in edid at offset locations
                '            '&H36 &H48 &H5a and &H6c each block is 18 bytes long
                '            '*********************************************************************

                '            location(0) = Mid(Displays(i, 1), &H36 + 1, 18)
                '            location(1) = Mid(Displays(i, 1), &H48 + 1, 18)
                '            location(2) = Mid(Displays(i, 1), &H5A + 1, 18)
                '            location(3) = Mid(Displays(i, 1), &H6C + 1, 18)


                '            'you can tell If the location contains a serial number If it starts with &H00 00 00 ff
                '            strSerFind = Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&HFF)

                '            'or a model description If it starts with &H00 00 00 fc
                '            strMdlFind = Chr(&H0) & Chr(&H0) & Chr(&H0) & Chr(&HFC)

                '            intSerFoundAt = -1
                '            intMdlFoundAt = -1

                '            For findit = 0 To 3
                '                If InStr(location(findit), strSerFind) > 0 Then
                '                    intSerFoundAt = findit
                '                End If
                '                If InStr(location(findit), strMdlFind) > 0 Then
                '                    intMdlFoundAt = findit
                '                End If
                '            Next

                '            'If a location containing a serial number block was found then store it
                '            If intSerFoundAt <> -1 Then
                '                tmp = Right(location(intSerFoundAt), 14)
                '                If InStr(tmp, Chr(&HA)) > 0 Then
                '                    tmpser = Trim(Left(tmp, InStr(tmp, Chr(&HA)) - 1))
                '                Else
                '                    tmpser = Trim(tmp)
                '                End If

                '                'although it is not part of the edid spec it seems as though the
                '                'serial number will frequently be preceeded by &H00, this
                '                'compensates For that
                '                If Left(tmpser, 1) = Chr(0) Then
                '                    tmpser = Right(tmpser, Len(tmpser) - 1)
                '                Else
                '                    tmpser = "Serial Number Not Found in EDID data"
                '                End If

                '                'If a location containing a model number block was found then store it
                '                If intMdlFoundAt <> -1 Then
                '                    tmp = Right(location(intMdlFoundAt), 14)
                '                    If InStr(tmp, Chr(&HA)) > 0 Then
                '                        tmpmdl = Trim(Left(tmp, InStr(tmp, Chr(&HA)) - 1))
                '                    Else
                '                        tmpmdl = Trim(tmp)
                '                    End If

                '                    'although it is not part of the edid spec it seems as though the
                '                    'serial number will frequently be preceeded by &H00, this
                '                    'compensates For that
                '                    If Left(tmpmdl, 1) = Chr(0) Then
                '                        tmpmdl = Right(tmpmdl, Len(tmpmdl) - 1)
                '                    Else
                '                        tmpmdl = "Model Descriptor Not Found in EDID data"
                '                    End If

                '                    '**************************************************************
                '                    'Next get the mfg date
                '                    '**************************************************************
                '                    'the week of manufacture is stored at EDID offset &H10
                '                    tmpmfgweek = Asc(Mid(Displays(i, 1), &H10 + 1, 1))

                '                    'the year of manufacture is stored at EDID offset &H11
                '                    'and is the current year -1990
                '                    tmpmfgyear = (Asc(Mid(Displays(i, 1), &H11 + 1, 1))) + 1990

                '                    'store it in month/year format
                '                    tmpmdt = Month(DateAdd("ww", tmpmfgweek, DateValue("1/1/" & tmpmfgyear))) & "/" & tmpmfgyear

                '                    '**************************************************************
                '                    'Next get the edid version
                '                    '**************************************************************
                '                    'the version is at EDID offset &H12
                '                    tmpEDIDMajorVer = Asc(Mid(Displays(i, 1), &H12 + 1, 1))

                '                    'the revision level is at EDID offset &H13
                '                    tmpEDIDRev = Asc(Mid(Displays(i, 1), &H13 + 1, 1))

                '                    'store it in month/year format
                '                    If tmpEDIDMajorVer < 255 - 48 And tmpEDIDRev < 255 - 48 Then
                '                        tmpver = Chr(48 + tmpEDIDMajorVer) & "." & Chr(48 + tmpEDIDRev)
                '                    Else
                '                        tmpver = "Not available"
                '                    End If

                '                    '**************************************************************
                '                    'Next get the mfg id
                '                    '**************************************************************
                '                    'the mfg id is 2 bytes starting at EDID offset &H08
                '                    'the id is three characters long. using 5 bits to represent
                '                    'each character. the bits are used so that 1=A 2=B etc..
                '                    '
                '                    'get the data
                '                    tmpEDIDMfg = Mid(Displays(i, 1), &H8 + 1, 2)

                '                    Char1 = 0 : Char2 = 0 : Char3 = 0

                '                    Byte1 = Asc(Left(tmpEDIDMfg, 1)) 'get the first half of the string
                '                    Byte2 = Asc(Right(tmpEDIDMfg, 1)) 'get the first half of the string

                '                    'now shift the bits
                '                    'shift the 64 bit to the 16 bit
                '                    If (Byte1 And 64) > 0 Then Char1 = Char1 + 16

                '                    'shift the 32 bit to the 8 bit
                '                    If (Byte1 And 32) > 0 Then Char1 = Char1 + 8

                '                    'etc....
                '                    If (Byte1 And 16) > 0 Then Char1 = Char1 + 4
                '                    If (Byte1 And 8) > 0 Then Char1 = Char1 + 2
                '                    If (Byte1 And 4) > 0 Then Char1 = Char1 + 1

                '                    'the 2nd character uses the 2 bit and the 1 bit of the 1st byte
                '                    If (Byte1 And 2) > 0 Then Char2 = Char2 + 16
                '                    If (Byte1 And 1) > 0 Then Char2 = Char2 + 8

                '                    'and the 128,64 and 32 bits of the 2nd byte
                '                    If (Byte2 And 128) > 0 Then Char2 = Char2 + 4
                '                    If (Byte2 And 64) > 0 Then Char2 = Char2 + 2
                '                    If (Byte2 And 32) > 0 Then Char2 = Char2 + 1

                '                    'the bits For the 3rd character don't need shifting
                '                    'we can use them as they are
                '                    Char3 = Char3 + (Byte2 And 16)
                '                    Char3 = Char3 + (Byte2 And 8)
                '                    Char3 = Char3 + (Byte2 And 4)
                '                    Char3 = Char3 + (Byte2 And 2)
                '                    Char3 = Char3 + (Byte2 And 1)

                '                    tmpmfg = Chr(Char1 + 64) & Chr(Char2 + 64) & Chr(Char3 + 64)

                '                    '**************************************************************
                '                    'Next get the device id
                '                    '**************************************************************
                '                    'the device id is 2bytes starting at EDID offset &H0a
                '                    'the bytes are in reverse order.
                '                    'this code is not text. it is just a 2 byte code assigned
                '                    'by the manufacturer. they should be unique to a model
                '                    tmpEDIDDev1 = Hex(Asc(Mid(Displays(i, 1), &HA + 1, 1)))
                '                    tmpEDIDDev2 = Hex(Asc(Mid(Displays(i, 1), &HB + 1, 1)))

                '                    If Len(tmpEDIDDev1) = 1 Then tmpEDIDDev1 = "0" & tmpEDIDDev1
                '                    If Len(tmpEDIDDev2) = 1 Then tmpEDIDDev2 = "0" & tmpEDIDDev2

                '                    tmpdev = tmpEDIDDev2 & tmpEDIDDev1

                '                    '**************************************************************
                '                    'finally store all the values into the array
                '                    '**************************************************************
                '                    arrMonitorInfo(i, 0) = tmpmfg
                '                    arrMonitorInfo(i, 1) = tmpdev
                '                    arrMonitorInfo(i, 2) = tmpmdt
                '                    arrMonitorInfo(i, 3) = tmpser
                '                    arrMonitorInfo(i, 4) = tmpmdl
                '                    arrMonitorInfo(i, 5) = tmpver
                '                End If
                '            End If
                '        End If


                '        Text1 = arrMonitorInfo(i, 0)
                '        Text2 = arrMonitorInfo(i, 1)
                '        Text3 = arrMonitorInfo(i, 2)
                '        Text4 = arrMonitorInfo(i, 3)
                '        Text5 = arrMonitorInfo(i, 4)
                '        Text6 = arrMonitorInfo(i, 5)








            Next

        End If
    End Sub
    Public Function RegistryGetBinaryValue(ByVal machineName As String, _
                    ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
                    ByVal valueName As String) As String 'Byte()

        Dim HKLM As RegistryKey = Registry.LocalMachine
        Dim RegBinary As Object
        RegBinary = RegistryKey.OpenRemoteBaseKey(registryHive, machineName).OpenSubKey(subKeyName).GetValue(valueName)
        Dim myByteArray() As Byte = CType(RegBinary, Byte())
        Return BinToHex(myByteArray)
    End Function
    Private Function BinToHex(ByVal data As Byte()) As String
        If Not data Is Nothing Then
            Dim sb As New System.Text.StringBuilder
            For i As Integer = 0 To data.Length - 1
                sb.Append(data(i).ToString("x2"))
                sb.Append(" ", 1)
            Next
            Return (sb.ToString())
        Else
            Return (Nothing)
        End If
    End Function

    'This function parses a string containing EDID data
    'and returns the information contained in one of the
    '4 custom "descriptor blocks" providing the data in the
    'block is tagged wit a certain prefix
    'if no descriptor is tagged with the specified prefix then
    'function returns "Not Present in EDID"
    'otherwise it returns the data found in the descriptor
    'trimmed of its prefix tag and also trimmed of
    'leading NULLs (chr(0)) and trailing linefeeds (chr(10))
    'Function GetDescriptorBlockFromEDID(ByVal strEDID As String, ByVal strTag As String) As String
    '    If strEDID = "{ERROR}" Then
    '        GetDescriptorBlockFromEDID = "Bad EDID"
    '        Exit Function
    '    End If

    '    '*********************************************************************
    '    'There are 4 descriptor blocks in edid at offset locations
    '    '&H36 &H48 &H5a and &H6c each block is 18 bytes long
    '    'the model and serial numbers are stored in the vesa descriptor
    '    'blocks in the edid.
    '    '*********************************************************************
    '    Dim arrDescriptorBlock(3)
    '    arrDescriptorBlock(0) = Mid(strEDID, &H36 + 1, 18)
    '    arrDescriptorBlock(1) = Mid(strEDID, &H48 + 1, 18)
    '    arrDescriptorBlock(2) = Mid(strEDID, &H5A + 1, 18)
    '    arrDescriptorBlock(3) = Mid(strEDID, &H6C + 1, 18)

    '    Dim strFoundBlock As String
    '    If InStr(arrDescriptorBlock(0), strTag) > 0 Then
    '        strFoundBlock = arrDescriptorBlock(0)
    '    ElseIf InStr(arrDescriptorBlock(1), strTag) > 0 Then
    '        strFoundBlock = arrDescriptorBlock(1)
    '    ElseIf InStr(arrDescriptorBlock(2), strTag) > 0 Then
    '        strFoundBlock = arrDescriptorBlock(2)
    '    ElseIf InStr(arrDescriptorBlock(3), strTag) > 0 Then
    '        strFoundBlock = arrDescriptorBlock(3)
    '    Else
    '        GetDescriptorBlockFromEDID = "Not Present in EDID"
    '        Exit Function
    '    End If

    '    Dim strResult As String = Microsoft.VisualBasic.Right(strFoundBlock, 14)
    '    'the data in the descriptor block will either fill the 
    '    'block completely or be terminated with a linefeed (&h0a)
    '    If InStr(strResult, Chr(&HA)) > 0 Then
    '        strResult = Trim(Microsoft.VisualBasic.Left(strResult, InStr(strResult, Chr(&HA)) - 1))
    '    Else
    '        strResult = Trim(strResult)
    '    End If

    '    'although it is not part of the edid spec (as far as i can tell) it seems as though the
    '    'information in the descriptor will frequently be preceeded by &H00, this
    '    'compensates for that
    '    If Microsoft.VisualBasic.Left(strResult, 1) = Chr(0) Then strResult = Microsoft.VisualBasic.Right(strResult, Len(strResult) - 1)

    '    GetDescriptorBlockFromEDID = strResult
    'End Function

#End Region

    ' If System.Diagnostics.Debugger.IsAttached then (is running in ide)

    Private Sub Impersonation_Template()

        If AltUserCheckBox.Checked Then
            Dim impersonator As New Impersonation
            If impersonator.impersonateValidUser(Me.sAltDomainUser, Me.sAltDomain, Me.sAltPassword) Then
                ' Run Routine Here WITH impersonation
                impersonator.undoImpersonation()
            End If
        Else
            ' Run Routine Here WITHOUT impersonation
        End If
    End Sub

End Class




