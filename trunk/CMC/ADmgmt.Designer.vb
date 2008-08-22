<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADmgmt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADmgmt))
        Me.DomainSelect = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SearchResults = New System.Windows.Forms.ListBox
        Me.DataSet1 = New System.Data.DataSet
        Me.adTabControl = New System.Windows.Forms.TabControl
        Me.tabAccount = New System.Windows.Forms.TabPage
        Me.AccDisabled = New System.Windows.Forms.CheckBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDepartment = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtSAM = New System.Windows.Forms.TextBox
        Me.txtDomain = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtTelephone = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOffice = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtDisplayName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtInitials = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.tabProfile = New System.Windows.Forms.TabPage
        Me.txtExpires = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtHomeFolder = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtHomeDrive = New System.Windows.Forms.TextBox
        Me.txtHomeProfile = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cbAllowTSLogon = New System.Windows.Forms.CheckBox
        Me.txtTSHomeFolder = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTSDrive = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTSProfile = New System.Windows.Forms.TextBox
        Me.btnProfileSave = New System.Windows.Forms.Button
        Me.tabMemberOf = New System.Windows.Forms.TabPage
        Me.lbMemberOf = New System.Windows.Forms.ListBox
        Me.tabCustom = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnEaSave = New System.Windows.Forms.Button
        Me.ea15 = New System.Windows.Forms.TextBox
        Me.ea14 = New System.Windows.Forms.TextBox
        Me.ea13 = New System.Windows.Forms.TextBox
        Me.ea12 = New System.Windows.Forms.TextBox
        Me.ea11 = New System.Windows.Forms.TextBox
        Me.ea10 = New System.Windows.Forms.TextBox
        Me.ea9 = New System.Windows.Forms.TextBox
        Me.ea8 = New System.Windows.Forms.TextBox
        Me.ea7 = New System.Windows.Forms.TextBox
        Me.ea6 = New System.Windows.Forms.TextBox
        Me.ea5 = New System.Windows.Forms.TextBox
        Me.ea4 = New System.Windows.Forms.TextBox
        Me.ea3 = New System.Windows.Forms.TextBox
        Me.ea2 = New System.Windows.Forms.TextBox
        Me.ea1 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tabGroupMembers = New System.Windows.Forms.TabPage
        Me.cbDN = New System.Windows.Forms.CheckBox
        Me.cbMail = New System.Windows.Forms.CheckBox
        Me.cbDisplay = New System.Windows.Forms.CheckBox
        Me.cbLogon = New System.Windows.Forms.CheckBox
        Me.DGVMembers = New System.Windows.Forms.DataGridView
        Me.colSAM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDisplay = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMail = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnExportUsers = New System.Windows.Forms.Button
        Me.lblGroupName = New System.Windows.Forms.Label
        Me.gbSearch = New System.Windows.Forms.GroupBox
        Me.radioGroups = New System.Windows.Forms.RadioButton
        Me.radioUsers = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.customDomainCombo = New System.Windows.Forms.ComboBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adTabControl.SuspendLayout()
        Me.tabAccount.SuspendLayout()
        Me.tabProfile.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabMemberOf.SuspendLayout()
        Me.tabCustom.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabGroupMembers.SuspendLayout()
        CType(Me.DGVMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSearch.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomainSelect
        '
        Me.DomainSelect.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DomainSelect.FormattingEnabled = True
        Me.DomainSelect.Location = New System.Drawing.Point(94, 6)
        Me.DomainSelect.Name = "DomainSelect"
        Me.DomainSelect.Size = New System.Drawing.Size(158, 21)
        Me.DomainSelect.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(83, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 21)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(311, 13)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 31)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 100000
        Me.Label1.Text = "Select Domain"
        '
        'SearchResults
        '
        Me.SearchResults.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.SearchResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchResults.FormattingEnabled = True
        Me.SearchResults.Location = New System.Drawing.Point(83, 47)
        Me.SearchResults.Name = "SearchResults"
        Me.SearchResults.Size = New System.Drawing.Size(222, 67)
        Me.SearchResults.TabIndex = 4
        Me.SearchResults.Visible = False
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'adTabControl
        '
        Me.adTabControl.Controls.Add(Me.tabAccount)
        Me.adTabControl.Controls.Add(Me.tabProfile)
        Me.adTabControl.Controls.Add(Me.tabMemberOf)
        Me.adTabControl.Controls.Add(Me.tabCustom)
        Me.adTabControl.Controls.Add(Me.tabGroupMembers)
        Me.adTabControl.Enabled = False
        Me.adTabControl.Location = New System.Drawing.Point(11, 162)
        Me.adTabControl.Name = "adTabControl"
        Me.adTabControl.SelectedIndex = 0
        Me.adTabControl.Size = New System.Drawing.Size(389, 313)
        Me.adTabControl.TabIndex = 8
        '
        'tabAccount
        '
        Me.tabAccount.BackColor = System.Drawing.SystemColors.Control
        Me.tabAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabAccount.Controls.Add(Me.AccDisabled)
        Me.tabAccount.Controls.Add(Me.btnSave)
        Me.tabAccount.Controls.Add(Me.Label13)
        Me.tabAccount.Controls.Add(Me.txtDepartment)
        Me.tabAccount.Controls.Add(Me.Label12)
        Me.tabAccount.Controls.Add(Me.txtTitle)
        Me.tabAccount.Controls.Add(Me.Label2)
        Me.tabAccount.Controls.Add(Me.txtCompany)
        Me.tabAccount.Controls.Add(Me.txtSAM)
        Me.tabAccount.Controls.Add(Me.txtDomain)
        Me.tabAccount.Controls.Add(Me.Label11)
        Me.tabAccount.Controls.Add(Me.txtEmail)
        Me.tabAccount.Controls.Add(Me.txtTelephone)
        Me.tabAccount.Controls.Add(Me.Label10)
        Me.tabAccount.Controls.Add(Me.Label9)
        Me.tabAccount.Controls.Add(Me.Label8)
        Me.tabAccount.Controls.Add(Me.Label7)
        Me.tabAccount.Controls.Add(Me.Label6)
        Me.tabAccount.Controls.Add(Me.Label3)
        Me.tabAccount.Controls.Add(Me.txtOffice)
        Me.tabAccount.Controls.Add(Me.txtDescription)
        Me.tabAccount.Controls.Add(Me.txtDisplayName)
        Me.tabAccount.Controls.Add(Me.txtLastName)
        Me.tabAccount.Controls.Add(Me.txtInitials)
        Me.tabAccount.Controls.Add(Me.txtFirstName)
        Me.tabAccount.Location = New System.Drawing.Point(4, 22)
        Me.tabAccount.Name = "tabAccount"
        Me.tabAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAccount.Size = New System.Drawing.Size(381, 287)
        Me.tabAccount.TabIndex = 0
        Me.tabAccount.Text = "Account"
        '
        'AccDisabled
        '
        Me.AccDisabled.AutoSize = True
        Me.AccDisabled.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.AccDisabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AccDisabled.Location = New System.Drawing.Point(93, 264)
        Me.AccDisabled.Name = "AccDisabled"
        Me.AccDisabled.Size = New System.Drawing.Size(117, 17)
        Me.AccDisabled.TabIndex = 26
        Me.AccDisabled.Text = "account is disabled"
        Me.AccDisabled.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Control
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(289, 257)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(93, 205)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(271, 20)
        Me.txtDepartment.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(93, 179)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(271, 20)
        Me.txtTitle.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Company:"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(93, 231)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(271, 20)
        Me.txtCompany.TabIndex = 19
        '
        'txtSAM
        '
        Me.txtSAM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSAM.Location = New System.Drawing.Point(203, 11)
        Me.txtSAM.Name = "txtSAM"
        Me.txtSAM.ReadOnly = True
        Me.txtSAM.Size = New System.Drawing.Size(161, 20)
        Me.txtSAM.TabIndex = 18
        '
        'txtDomain
        '
        Me.txtDomain.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtDomain.Enabled = False
        Me.txtDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomain.Location = New System.Drawing.Point(93, 11)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(104, 20)
        Me.txtDomain.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Logon Name"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(93, 153)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(279, 127)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(85, 20)
        Me.txtTelephone.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Phone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Office:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Display Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name:"
        '
        'txtOffice
        '
        Me.txtOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Location = New System.Drawing.Point(93, 127)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(143, 20)
        Me.txtOffice.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(93, 101)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(271, 20)
        Me.txtDescription.TabIndex = 4
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.Location = New System.Drawing.Point(93, 75)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(271, 20)
        Me.txtDisplayName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(235, 47)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(129, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtInitials
        '
        Me.txtInitials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitials.Location = New System.Drawing.Point(203, 47)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(26, 20)
        Me.txtInitials.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(93, 47)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(104, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'tabProfile
        '
        Me.tabProfile.BackColor = System.Drawing.SystemColors.Control
        Me.tabProfile.Controls.Add(Me.txtExpires)
        Me.tabProfile.Controls.Add(Me.Label31)
        Me.tabProfile.Controls.Add(Me.GroupBox2)
        Me.tabProfile.Controls.Add(Me.GroupBox1)
        Me.tabProfile.Controls.Add(Me.btnProfileSave)
        Me.tabProfile.Location = New System.Drawing.Point(4, 22)
        Me.tabProfile.Name = "tabProfile"
        Me.tabProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProfile.Size = New System.Drawing.Size(381, 287)
        Me.tabProfile.TabIndex = 1
        Me.tabProfile.Text = "Profile"
        '
        'txtExpires
        '
        Me.txtExpires.Location = New System.Drawing.Point(107, 6)
        Me.txtExpires.Name = "txtExpires"
        Me.txtExpires.ReadOnly = True
        Me.txtExpires.Size = New System.Drawing.Size(109, 20)
        Me.txtExpires.TabIndex = 15
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 9)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(87, 13)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "Account Expires:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHomeFolder)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtHomeDrive)
        Me.GroupBox2.Controls.Add(Me.txtHomeProfile)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 71)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Profile"
        '
        'txtHomeFolder
        '
        Me.txtHomeFolder.Location = New System.Drawing.Point(136, 15)
        Me.txtHomeFolder.Name = "txtHomeFolder"
        Me.txtHomeFolder.Size = New System.Drawing.Size(209, 20)
        Me.txtHomeFolder.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Home Directory"
        '
        'txtHomeDrive
        '
        Me.txtHomeDrive.Location = New System.Drawing.Point(91, 15)
        Me.txtHomeDrive.Name = "txtHomeDrive"
        Me.txtHomeDrive.Size = New System.Drawing.Size(29, 20)
        Me.txtHomeDrive.TabIndex = 1
        '
        'txtHomeProfile
        '
        Me.txtHomeProfile.Location = New System.Drawing.Point(91, 40)
        Me.txtHomeProfile.Name = "txtHomeProfile"
        Me.txtHomeProfile.Size = New System.Drawing.Size(254, 20)
        Me.txtHomeProfile.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Profile Path"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAllowTSLogon)
        Me.GroupBox1.Controls.Add(Me.txtTSHomeFolder)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTSDrive)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtTSProfile)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 91)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Terminal Services Profile"
        '
        'cbAllowTSLogon
        '
        Me.cbAllowTSLogon.AutoSize = True
        Me.cbAllowTSLogon.Location = New System.Drawing.Point(91, 67)
        Me.cbAllowTSLogon.Name = "cbAllowTSLogon"
        Me.cbAllowTSLogon.Size = New System.Drawing.Size(163, 17)
        Me.cbAllowTSLogon.TabIndex = 11
        Me.cbAllowTSLogon.Text = "Allow logon to terminal server"
        Me.cbAllowTSLogon.UseVisualStyleBackColor = True
        '
        'txtTSHomeFolder
        '
        Me.txtTSHomeFolder.Location = New System.Drawing.Point(136, 19)
        Me.txtTSHomeFolder.Name = "txtTSHomeFolder"
        Me.txtTSHomeFolder.Size = New System.Drawing.Size(209, 20)
        Me.txtTSHomeFolder.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Home Folder"
        '
        'txtTSDrive
        '
        Me.txtTSDrive.Location = New System.Drawing.Point(91, 20)
        Me.txtTSDrive.Name = "txtTSDrive"
        Me.txtTSDrive.Size = New System.Drawing.Size(29, 20)
        Me.txtTSDrive.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(4, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Profile"
        '
        'txtTSProfile
        '
        Me.txtTSProfile.Location = New System.Drawing.Point(91, 43)
        Me.txtTSProfile.Name = "txtTSProfile"
        Me.txtTSProfile.Size = New System.Drawing.Size(254, 20)
        Me.txtTSProfile.TabIndex = 9
        '
        'btnProfileSave
        '
        Me.btnProfileSave.Location = New System.Drawing.Point(297, 258)
        Me.btnProfileSave.Name = "btnProfileSave"
        Me.btnProfileSave.Size = New System.Drawing.Size(75, 23)
        Me.btnProfileSave.TabIndex = 11
        Me.btnProfileSave.Text = "Save"
        Me.btnProfileSave.UseVisualStyleBackColor = True
        '
        'tabMemberOf
        '
        Me.tabMemberOf.BackColor = System.Drawing.SystemColors.Control
        Me.tabMemberOf.Controls.Add(Me.lbMemberOf)
        Me.tabMemberOf.Location = New System.Drawing.Point(4, 22)
        Me.tabMemberOf.Name = "tabMemberOf"
        Me.tabMemberOf.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMemberOf.Size = New System.Drawing.Size(381, 287)
        Me.tabMemberOf.TabIndex = 2
        Me.tabMemberOf.Text = "Member Of"
        '
        'lbMemberOf
        '
        Me.lbMemberOf.FormattingEnabled = True
        Me.lbMemberOf.Location = New System.Drawing.Point(21, 27)
        Me.lbMemberOf.Name = "lbMemberOf"
        Me.lbMemberOf.Size = New System.Drawing.Size(329, 199)
        Me.lbMemberOf.Sorted = True
        Me.lbMemberOf.TabIndex = 0
        '
        'tabCustom
        '
        Me.tabCustom.BackColor = System.Drawing.SystemColors.Control
        Me.tabCustom.Controls.Add(Me.GroupBox3)
        Me.tabCustom.Location = New System.Drawing.Point(4, 22)
        Me.tabCustom.Name = "tabCustom"
        Me.tabCustom.Size = New System.Drawing.Size(381, 287)
        Me.tabCustom.TabIndex = 3
        Me.tabCustom.Text = "Custom"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnEaSave)
        Me.GroupBox3.Controls.Add(Me.ea15)
        Me.GroupBox3.Controls.Add(Me.ea14)
        Me.GroupBox3.Controls.Add(Me.ea13)
        Me.GroupBox3.Controls.Add(Me.ea12)
        Me.GroupBox3.Controls.Add(Me.ea11)
        Me.GroupBox3.Controls.Add(Me.ea10)
        Me.GroupBox3.Controls.Add(Me.ea9)
        Me.GroupBox3.Controls.Add(Me.ea8)
        Me.GroupBox3.Controls.Add(Me.ea7)
        Me.GroupBox3.Controls.Add(Me.ea6)
        Me.GroupBox3.Controls.Add(Me.ea5)
        Me.GroupBox3.Controls.Add(Me.ea4)
        Me.GroupBox3.Controls.Add(Me.ea3)
        Me.GroupBox3.Controls.Add(Me.ea2)
        Me.GroupBox3.Controls.Add(Me.ea1)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(353, 182)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "extension attributes"
        '
        'btnEaSave
        '
        Me.btnEaSave.Location = New System.Drawing.Point(254, 153)
        Me.btnEaSave.Name = "btnEaSave"
        Me.btnEaSave.Size = New System.Drawing.Size(75, 23)
        Me.btnEaSave.TabIndex = 9017
        Me.btnEaSave.Text = "Save"
        Me.btnEaSave.UseVisualStyleBackColor = True
        '
        'ea15
        '
        Me.ea15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea15.Location = New System.Drawing.Point(208, 132)
        Me.ea15.Name = "ea15"
        Me.ea15.Size = New System.Drawing.Size(118, 17)
        Me.ea15.TabIndex = 9016
        '
        'ea14
        '
        Me.ea14.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea14.Location = New System.Drawing.Point(208, 113)
        Me.ea14.Name = "ea14"
        Me.ea14.Size = New System.Drawing.Size(118, 17)
        Me.ea14.TabIndex = 9015
        '
        'ea13
        '
        Me.ea13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea13.Location = New System.Drawing.Point(208, 94)
        Me.ea13.Name = "ea13"
        Me.ea13.Size = New System.Drawing.Size(118, 17)
        Me.ea13.TabIndex = 9014
        '
        'ea12
        '
        Me.ea12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea12.Location = New System.Drawing.Point(208, 75)
        Me.ea12.Name = "ea12"
        Me.ea12.Size = New System.Drawing.Size(118, 17)
        Me.ea12.TabIndex = 9013
        '
        'ea11
        '
        Me.ea11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea11.Location = New System.Drawing.Point(208, 56)
        Me.ea11.Name = "ea11"
        Me.ea11.Size = New System.Drawing.Size(118, 17)
        Me.ea11.TabIndex = 9012
        '
        'ea10
        '
        Me.ea10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea10.Location = New System.Drawing.Point(208, 37)
        Me.ea10.Name = "ea10"
        Me.ea10.Size = New System.Drawing.Size(118, 17)
        Me.ea10.TabIndex = 9011
        '
        'ea9
        '
        Me.ea9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea9.Location = New System.Drawing.Point(208, 18)
        Me.ea9.Name = "ea9"
        Me.ea9.Size = New System.Drawing.Size(118, 17)
        Me.ea9.TabIndex = 9010
        '
        'ea8
        '
        Me.ea8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea8.Location = New System.Drawing.Point(34, 151)
        Me.ea8.Name = "ea8"
        Me.ea8.Size = New System.Drawing.Size(118, 17)
        Me.ea8.TabIndex = 9009
        '
        'ea7
        '
        Me.ea7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea7.Location = New System.Drawing.Point(34, 132)
        Me.ea7.Name = "ea7"
        Me.ea7.Size = New System.Drawing.Size(118, 17)
        Me.ea7.TabIndex = 9008
        '
        'ea6
        '
        Me.ea6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea6.Location = New System.Drawing.Point(34, 113)
        Me.ea6.Name = "ea6"
        Me.ea6.Size = New System.Drawing.Size(118, 17)
        Me.ea6.TabIndex = 9007
        '
        'ea5
        '
        Me.ea5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea5.Location = New System.Drawing.Point(34, 94)
        Me.ea5.Name = "ea5"
        Me.ea5.Size = New System.Drawing.Size(118, 17)
        Me.ea5.TabIndex = 9006
        '
        'ea4
        '
        Me.ea4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea4.Location = New System.Drawing.Point(34, 75)
        Me.ea4.Name = "ea4"
        Me.ea4.Size = New System.Drawing.Size(118, 17)
        Me.ea4.TabIndex = 9005
        '
        'ea3
        '
        Me.ea3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea3.Location = New System.Drawing.Point(34, 56)
        Me.ea3.Name = "ea3"
        Me.ea3.Size = New System.Drawing.Size(118, 17)
        Me.ea3.TabIndex = 9004
        '
        'ea2
        '
        Me.ea2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea2.Location = New System.Drawing.Point(34, 37)
        Me.ea2.Name = "ea2"
        Me.ea2.Size = New System.Drawing.Size(118, 17)
        Me.ea2.TabIndex = 9003
        '
        'ea1
        '
        Me.ea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ea1.Location = New System.Drawing.Point(34, 18)
        Me.ea1.Name = "ea1"
        Me.ea1.Size = New System.Drawing.Size(118, 17)
        Me.ea1.TabIndex = 9002
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(183, 134)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(19, 13)
        Me.Label30.TabIndex = 9001
        Me.Label30.Text = "15"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(183, 115)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 13)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "14"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(183, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 13)
        Me.Label28.TabIndex = 9000
        Me.Label28.Text = "13"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(183, 77)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(19, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "12"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(183, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 13)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "11"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(183, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "10"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(189, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "9"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 153)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "8"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(15, 134)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "7"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(15, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "6"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(15, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "5"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 77)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "4"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "3"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "1"
        '
        'tabGroupMembers
        '
        Me.tabGroupMembers.BackColor = System.Drawing.SystemColors.Control
        Me.tabGroupMembers.Controls.Add(Me.cbDN)
        Me.tabGroupMembers.Controls.Add(Me.cbMail)
        Me.tabGroupMembers.Controls.Add(Me.cbDisplay)
        Me.tabGroupMembers.Controls.Add(Me.cbLogon)
        Me.tabGroupMembers.Controls.Add(Me.DGVMembers)
        Me.tabGroupMembers.Controls.Add(Me.btnExportUsers)
        Me.tabGroupMembers.Controls.Add(Me.lblGroupName)
        Me.tabGroupMembers.Location = New System.Drawing.Point(4, 22)
        Me.tabGroupMembers.Name = "tabGroupMembers"
        Me.tabGroupMembers.Size = New System.Drawing.Size(381, 287)
        Me.tabGroupMembers.TabIndex = 4
        Me.tabGroupMembers.Text = "Members"
        '
        'cbDN
        '
        Me.cbDN.AutoSize = True
        Me.cbDN.Location = New System.Drawing.Point(101, 271)
        Me.cbDN.Name = "cbDN"
        Me.cbDN.Size = New System.Drawing.Size(67, 17)
        Me.cbDN.TabIndex = 9
        Me.cbDN.Text = "aDsPath"
        Me.cbDN.UseVisualStyleBackColor = True
        '
        'cbMail
        '
        Me.cbMail.AutoSize = True
        Me.cbMail.Location = New System.Drawing.Point(101, 257)
        Me.cbMail.Name = "cbMail"
        Me.cbMail.Size = New System.Drawing.Size(51, 17)
        Me.cbMail.TabIndex = 8
        Me.cbMail.Text = "Email"
        Me.cbMail.UseVisualStyleBackColor = True
        '
        'cbDisplay
        '
        Me.cbDisplay.AutoSize = True
        Me.cbDisplay.Location = New System.Drawing.Point(4, 271)
        Me.cbDisplay.Name = "cbDisplay"
        Me.cbDisplay.Size = New System.Drawing.Size(91, 17)
        Me.cbDisplay.TabIndex = 7
        Me.cbDisplay.Text = "Display Name"
        Me.cbDisplay.UseVisualStyleBackColor = True
        '
        'cbLogon
        '
        Me.cbLogon.AutoSize = True
        Me.cbLogon.Location = New System.Drawing.Point(4, 257)
        Me.cbLogon.Name = "cbLogon"
        Me.cbLogon.Size = New System.Drawing.Size(87, 17)
        Me.cbLogon.TabIndex = 6
        Me.cbLogon.Text = "Logon Name"
        Me.cbLogon.UseVisualStyleBackColor = True
        '
        'DGVMembers
        '
        Me.DGVMembers.AllowUserToAddRows = False
        Me.DGVMembers.AllowUserToDeleteRows = False
        Me.DGVMembers.AllowUserToResizeRows = False
        Me.DGVMembers.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGVMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSAM, Me.colDisplay, Me.colMail, Me.colDN})
        Me.DGVMembers.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGVMembers.Location = New System.Drawing.Point(3, 21)
        Me.DGVMembers.Name = "DGVMembers"
        Me.DGVMembers.ReadOnly = True
        Me.DGVMembers.RowHeadersVisible = False
        Me.DGVMembers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.DGVMembers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        Me.DGVMembers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DGVMembers.RowTemplate.Height = 21
        Me.DGVMembers.Size = New System.Drawing.Size(375, 235)
        Me.DGVMembers.TabIndex = 5
        '
        'colSAM
        '
        Me.colSAM.HeaderText = "Logon name"
        Me.colSAM.Name = "colSAM"
        Me.colSAM.ReadOnly = True
        Me.colSAM.Width = 120
        '
        'colDisplay
        '
        Me.colDisplay.HeaderText = "Display Name"
        Me.colDisplay.Name = "colDisplay"
        Me.colDisplay.ReadOnly = True
        Me.colDisplay.Width = 250
        '
        'colMail
        '
        Me.colMail.HeaderText = "Email Address"
        Me.colMail.Name = "colMail"
        Me.colMail.ReadOnly = True
        Me.colMail.Visible = False
        '
        'colDN
        '
        Me.colDN.HeaderText = "aDsPath"
        Me.colDN.Name = "colDN"
        Me.colDN.ReadOnly = True
        Me.colDN.Visible = False
        '
        'btnExportUsers
        '
        Me.btnExportUsers.Enabled = False
        Me.btnExportUsers.Location = New System.Drawing.Point(304, 260)
        Me.btnExportUsers.Name = "btnExportUsers"
        Me.btnExportUsers.Size = New System.Drawing.Size(75, 23)
        Me.btnExportUsers.TabIndex = 4
        Me.btnExportUsers.Text = "export"
        Me.btnExportUsers.UseVisualStyleBackColor = True
        '
        'lblGroupName
        '
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupName.Location = New System.Drawing.Point(7, 5)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(0, 13)
        Me.lblGroupName.TabIndex = 1
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.radioGroups)
        Me.gbSearch.Controls.Add(Me.radioUsers)
        Me.gbSearch.Controls.Add(Me.SearchResults)
        Me.gbSearch.Controls.Add(Me.txtSearch)
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Enabled = False
        Me.gbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbSearch.Location = New System.Drawing.Point(11, 34)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(389, 122)
        Me.gbSearch.TabIndex = 9
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'radioGroups
        '
        Me.radioGroups.AutoSize = True
        Me.radioGroups.FlatAppearance.BorderSize = 3
        Me.radioGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioGroups.Location = New System.Drawing.Point(19, 35)
        Me.radioGroups.Name = "radioGroups"
        Me.radioGroups.Size = New System.Drawing.Size(58, 17)
        Me.radioGroups.TabIndex = 2
        Me.radioGroups.Text = "Groups"
        Me.radioGroups.UseVisualStyleBackColor = True
        '
        'radioUsers
        '
        Me.radioUsers.AutoSize = True
        Me.radioUsers.Checked = True
        Me.radioUsers.FlatAppearance.BorderSize = 3
        Me.radioUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioUsers.Location = New System.Drawing.Point(19, 19)
        Me.radioUsers.Name = "radioUsers"
        Me.radioUsers.Size = New System.Drawing.Size(51, 17)
        Me.radioUsers.TabIndex = 1
        Me.radioUsers.TabStop = True
        Me.radioUsers.Text = "Users"
        Me.radioUsers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(70, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(58, 20)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(3, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 20)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnClear, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(135, 26)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 484)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(412, 26)
        Me.Panel1.TabIndex = 11
        '
        'customDomainCombo
        '
        Me.customDomainCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customDomainCombo.FormattingEnabled = True
        Me.customDomainCombo.Items.AddRange(New Object() {" (edit custom domains)"})
        Me.customDomainCombo.Location = New System.Drawing.Point(284, 6)
        Me.customDomainCombo.Name = "customDomainCombo"
        Me.customDomainCombo.Size = New System.Drawing.Size(121, 20)
        Me.customDomainCombo.TabIndex = 100001
        '
        'ADmgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 510)
        Me.Controls.Add(Me.customDomainCombo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.adTabControl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DomainSelect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ADmgmt"
        Me.Text = "AD User Manager"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adTabControl.ResumeLayout(False)
        Me.tabAccount.ResumeLayout(False)
        Me.tabAccount.PerformLayout()
        Me.tabProfile.ResumeLayout(False)
        Me.tabProfile.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabMemberOf.ResumeLayout(False)
        Me.tabCustom.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabGroupMembers.ResumeLayout(False)
        Me.tabGroupMembers.PerformLayout()
        CType(Me.DGVMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomainSelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchResults As System.Windows.Forms.ListBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents adTabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabAccount As System.Windows.Forms.TabPage
    Friend WithEvents tabProfile As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOffice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtDisplayName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtInitials As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSAM As System.Windows.Forms.TextBox
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tabMemberOf As System.Windows.Forms.TabPage
    Friend WithEvents tabCustom As System.Windows.Forms.TabPage
    Friend WithEvents gbSearch As System.Windows.Forms.GroupBox
    Friend WithEvents radioGroups As System.Windows.Forms.RadioButton
    Friend WithEvents radioUsers As System.Windows.Forms.RadioButton
    Friend WithEvents tabGroupMembers As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbMemberOf As System.Windows.Forms.ListBox
    Friend WithEvents lblGroupName As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExportUsers As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTSProfile As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTSHomeFolder As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtHomeProfile As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtHomeFolder As System.Windows.Forms.TextBox
    Friend WithEvents txtHomeDrive As System.Windows.Forms.TextBox
    Friend WithEvents txtTSDrive As System.Windows.Forms.TextBox
    Friend WithEvents btnProfileSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAllowTSLogon As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVMembers As System.Windows.Forms.DataGridView
    Friend WithEvents cbLogon As System.Windows.Forms.CheckBox
    Friend WithEvents cbDN As System.Windows.Forms.CheckBox
    Friend WithEvents cbMail As System.Windows.Forms.CheckBox
    Friend WithEvents cbDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents colSAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDisplay As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customDomainCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ea15 As System.Windows.Forms.TextBox
    Friend WithEvents ea14 As System.Windows.Forms.TextBox
    Friend WithEvents ea13 As System.Windows.Forms.TextBox
    Friend WithEvents ea12 As System.Windows.Forms.TextBox
    Friend WithEvents ea11 As System.Windows.Forms.TextBox
    Friend WithEvents ea10 As System.Windows.Forms.TextBox
    Friend WithEvents ea9 As System.Windows.Forms.TextBox
    Friend WithEvents ea8 As System.Windows.Forms.TextBox
    Friend WithEvents ea7 As System.Windows.Forms.TextBox
    Friend WithEvents ea6 As System.Windows.Forms.TextBox
    Friend WithEvents ea5 As System.Windows.Forms.TextBox
    Friend WithEvents ea4 As System.Windows.Forms.TextBox
    Friend WithEvents ea3 As System.Windows.Forms.TextBox
    Friend WithEvents ea2 As System.Windows.Forms.TextBox
    Friend WithEvents ea1 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtExpires As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents AccDisabled As System.Windows.Forms.CheckBox
    Friend WithEvents btnEaSave As System.Windows.Forms.Button
End Class
