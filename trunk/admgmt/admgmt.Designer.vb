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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADmgmt))
        Me.DomainSelect = New System.Windows.Forms.ComboBox
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataSet1 = New System.Data.DataSet
        Me.adTabControl = New System.Windows.Forms.TabControl
        Me.tabAccount = New System.Windows.Forms.TabPage
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtExpires = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
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
        Me.btnRemoveUserfromGroup = New System.Windows.Forms.Button
        Me.btnAddUsertoGroup = New System.Windows.Forms.Button
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
        Me.groupContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MemberAddMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.MemberRemoveMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MemberRefreshMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.MemberExportMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.gbSearch = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SearchTypeCombo = New System.Windows.Forms.ComboBox
        Me.SearchResultsDGV = New System.Windows.Forms.DataGridView
        Me.srName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.srDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.userContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NameMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ResetPasswordMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.PropertiesMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.customDomainCombo = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.SearchPanel = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adTabControl.SuspendLayout()
        Me.tabAccount.SuspendLayout()
        Me.tabProfile.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabMemberOf.SuspendLayout()
        Me.tabCustom.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.groupContextMenu.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchResultsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.userContextMenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SearchPanel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomainSelect
        '
        Me.DomainSelect.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DomainSelect.FormattingEnabled = True
        Me.DomainSelect.Location = New System.Drawing.Point(96, 7)
        Me.DomainSelect.Name = "DomainSelect"
        Me.DomainSelect.Size = New System.Drawing.Size(158, 21)
        Me.DomainSelect.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.Window
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(143, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(165, 21)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(314, 14)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 31)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 100000
        Me.Label1.Text = "Select Domain"
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
        Me.adTabControl.Enabled = False
        Me.adTabControl.Location = New System.Drawing.Point(13, 3)
        Me.adTabControl.Name = "adTabControl"
        Me.adTabControl.SelectedIndex = 0
        Me.adTabControl.Size = New System.Drawing.Size(385, 313)
        Me.adTabControl.TabIndex = 8
        '
        'tabAccount
        '
        Me.tabAccount.BackColor = System.Drawing.Color.Transparent
        Me.tabAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabAccount.Controls.Add(Me.Label33)
        Me.tabAccount.Controls.Add(Me.txtExpires)
        Me.tabAccount.Controls.Add(Me.Label31)
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
        Me.tabAccount.Size = New System.Drawing.Size(377, 287)
        Me.tabAccount.TabIndex = 0
        Me.tabAccount.Text = "Account"
        Me.tabAccount.UseVisualStyleBackColor = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(89, 265)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(46, 13)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "disabled"
        '
        'txtExpires
        '
        Me.txtExpires.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpires.Location = New System.Drawing.Point(135, 245)
        Me.txtExpires.Name = "txtExpires"
        Me.txtExpires.ReadOnly = True
        Me.txtExpires.Size = New System.Drawing.Size(109, 18)
        Me.txtExpires.TabIndex = 28
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(89, 247)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 27
        Me.Label31.Text = "expires"
        '
        'AccDisabled
        '
        Me.AccDisabled.AutoSize = True
        Me.AccDisabled.CheckAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.AccDisabled.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AccDisabled.Location = New System.Drawing.Point(135, 266)
        Me.AccDisabled.Name = "AccDisabled"
        Me.AccDisabled.Size = New System.Drawing.Size(15, 14)
        Me.AccDisabled.TabIndex = 26
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
        Me.Label13.Location = New System.Drawing.Point(12, 194)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(93, 191)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(271, 20)
        Me.txtDepartment.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "title:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(93, 167)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(271, 20)
        Me.txtTitle.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "company:"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(93, 215)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(271, 20)
        Me.txtCompany.TabIndex = 19
        '
        'txtSAM
        '
        Me.txtSAM.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSAM.Location = New System.Drawing.Point(203, 14)
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
        Me.txtDomain.Location = New System.Drawing.Point(93, 14)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(104, 20)
        Me.txtDomain.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "logon name"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(93, 143)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(279, 119)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(85, 20)
        Me.txtTelephone.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(241, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "phone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "office:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "display name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "name:"
        '
        'txtOffice
        '
        Me.txtOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Location = New System.Drawing.Point(93, 119)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(143, 20)
        Me.txtOffice.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(93, 95)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(271, 20)
        Me.txtDescription.TabIndex = 4
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.Location = New System.Drawing.Point(93, 71)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(271, 20)
        Me.txtDisplayName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(235, 45)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(129, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtInitials
        '
        Me.txtInitials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitials.Location = New System.Drawing.Point(203, 45)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(26, 20)
        Me.txtInitials.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(93, 45)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(104, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'tabProfile
        '
        Me.tabProfile.BackColor = System.Drawing.Color.Transparent
        Me.tabProfile.Controls.Add(Me.GroupBox2)
        Me.tabProfile.Controls.Add(Me.GroupBox1)
        Me.tabProfile.Controls.Add(Me.btnProfileSave)
        Me.tabProfile.Location = New System.Drawing.Point(4, 22)
        Me.tabProfile.Name = "tabProfile"
        Me.tabProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProfile.Size = New System.Drawing.Size(377, 287)
        Me.tabProfile.TabIndex = 1
        Me.tabProfile.Text = "Profile"
        Me.tabProfile.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHomeFolder)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtHomeDrive)
        Me.GroupBox2.Controls.Add(Me.txtHomeProfile)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 26)
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
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "home directory"
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
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "profile path"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbAllowTSLogon)
        Me.GroupBox1.Controls.Add(Me.txtTSHomeFolder)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtTSDrive)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtTSProfile)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 134)
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
        Me.cbAllowTSLogon.Size = New System.Drawing.Size(162, 17)
        Me.cbAllowTSLogon.TabIndex = 11
        Me.cbAllowTSLogon.Text = "allow logon to terminal server"
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
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "home folder"
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
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "profile"
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
        Me.tabMemberOf.BackColor = System.Drawing.Color.Transparent
        Me.tabMemberOf.Controls.Add(Me.btnRemoveUserfromGroup)
        Me.tabMemberOf.Controls.Add(Me.btnAddUsertoGroup)
        Me.tabMemberOf.Controls.Add(Me.lbMemberOf)
        Me.tabMemberOf.Location = New System.Drawing.Point(4, 22)
        Me.tabMemberOf.Name = "tabMemberOf"
        Me.tabMemberOf.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMemberOf.Size = New System.Drawing.Size(377, 287)
        Me.tabMemberOf.TabIndex = 2
        Me.tabMemberOf.Text = "Member Of"
        Me.tabMemberOf.UseVisualStyleBackColor = True
        '
        'btnRemoveUserfromGroup
        '
        Me.btnRemoveUserfromGroup.Enabled = False
        Me.btnRemoveUserfromGroup.Location = New System.Drawing.Point(289, 232)
        Me.btnRemoveUserfromGroup.Name = "btnRemoveUserfromGroup"
        Me.btnRemoveUserfromGroup.Size = New System.Drawing.Size(61, 23)
        Me.btnRemoveUserfromGroup.TabIndex = 2
        Me.btnRemoveUserfromGroup.Text = "Remove"
        Me.btnRemoveUserfromGroup.UseVisualStyleBackColor = True
        '
        'btnAddUsertoGroup
        '
        Me.btnAddUsertoGroup.Location = New System.Drawing.Point(221, 232)
        Me.btnAddUsertoGroup.Name = "btnAddUsertoGroup"
        Me.btnAddUsertoGroup.Size = New System.Drawing.Size(66, 23)
        Me.btnAddUsertoGroup.TabIndex = 1
        Me.btnAddUsertoGroup.Text = "Add..."
        Me.btnAddUsertoGroup.UseVisualStyleBackColor = True
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
        Me.tabCustom.BackColor = System.Drawing.Color.Transparent
        Me.tabCustom.Controls.Add(Me.GroupBox3)
        Me.tabCustom.Location = New System.Drawing.Point(4, 22)
        Me.tabCustom.Name = "tabCustom"
        Me.tabCustom.Size = New System.Drawing.Size(377, 287)
        Me.tabCustom.TabIndex = 3
        Me.tabCustom.Text = "Custom"
        Me.tabCustom.UseVisualStyleBackColor = True
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 55)
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
        'groupContextMenu
        '
        Me.groupContextMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MemberAddMenu, Me.MemberRemoveMenu, Me.ToolStripSeparator2, Me.MemberRefreshMenu, Me.ToolStripSeparator3, Me.MemberExportMenu})
        Me.groupContextMenu.Name = "groupContextMenu"
        Me.groupContextMenu.Size = New System.Drawing.Size(138, 104)
        '
        'MemberAddMenu
        '
        Me.MemberAddMenu.Enabled = False
        Me.MemberAddMenu.Name = "MemberAddMenu"
        Me.MemberAddMenu.Size = New System.Drawing.Size(137, 22)
        Me.MemberAddMenu.Text = "Add user..."
        '
        'MemberRemoveMenu
        '
        Me.MemberRemoveMenu.Enabled = False
        Me.MemberRemoveMenu.Name = "MemberRemoveMenu"
        Me.MemberRemoveMenu.Size = New System.Drawing.Size(137, 22)
        Me.MemberRemoveMenu.Text = "Remove user"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(134, 6)
        '
        'MemberRefreshMenu
        '
        Me.MemberRefreshMenu.Enabled = False
        Me.MemberRefreshMenu.Name = "MemberRefreshMenu"
        Me.MemberRefreshMenu.Size = New System.Drawing.Size(137, 22)
        Me.MemberRefreshMenu.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(134, 6)
        '
        'MemberExportMenu
        '
        Me.MemberExportMenu.Enabled = False
        Me.MemberExportMenu.Name = "MemberExportMenu"
        Me.MemberExportMenu.Size = New System.Drawing.Size(137, 22)
        Me.MemberExportMenu.Text = "Export"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "user.png")
        Me.ImageList1.Images.SetKeyName(1, "group.png")
        Me.ImageList1.Images.SetKeyName(2, "people.png")
        Me.ImageList1.Images.SetKeyName(3, "users.png")
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.PictureBox1)
        Me.gbSearch.Controls.Add(Me.SearchTypeCombo)
        Me.gbSearch.Controls.Add(Me.SearchResultsDGV)
        Me.gbSearch.Controls.Add(Me.txtSearch)
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Enabled = False
        Me.gbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbSearch.Location = New System.Drawing.Point(10, 10)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(388, 136)
        Me.gbSearch.TabIndex = 9
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ADmgmt.My.Resources.Resources.user_16x16
        Me.PictureBox1.Location = New System.Drawing.Point(5, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'SearchTypeCombo
        '
        Me.SearchTypeCombo.FormattingEnabled = True
        Me.SearchTypeCombo.Items.AddRange(New Object() {"Users", "Groups"})
        Me.SearchTypeCombo.Location = New System.Drawing.Point(23, 19)
        Me.SearchTypeCombo.Name = "SearchTypeCombo"
        Me.SearchTypeCombo.Size = New System.Drawing.Size(99, 21)
        Me.SearchTypeCombo.TabIndex = 7
        '
        'SearchResultsDGV
        '
        Me.SearchResultsDGV.AllowUserToAddRows = False
        Me.SearchResultsDGV.AllowUserToDeleteRows = False
        Me.SearchResultsDGV.AllowUserToResizeRows = False
        Me.SearchResultsDGV.BackgroundColor = System.Drawing.SystemColors.Window
        Me.SearchResultsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.SearchResultsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchResultsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srName, Me.srDescription})
        Me.SearchResultsDGV.ContextMenuStrip = Me.userContextMenu
        Me.SearchResultsDGV.Location = New System.Drawing.Point(23, 50)
        Me.SearchResultsDGV.Name = "SearchResultsDGV"
        Me.SearchResultsDGV.RowHeadersVisible = False
        Me.SearchResultsDGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.SearchResultsDGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        Me.SearchResultsDGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.SearchResultsDGV.RowTemplate.Height = 15
        Me.SearchResultsDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SearchResultsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SearchResultsDGV.ShowEditingIcon = False
        Me.SearchResultsDGV.Size = New System.Drawing.Size(348, 80)
        Me.SearchResultsDGV.TabIndex = 6
        Me.SearchResultsDGV.Visible = False
        '
        'srName
        '
        Me.srName.HeaderText = "Name"
        Me.srName.Name = "srName"
        Me.srName.ReadOnly = True
        Me.srName.Width = 140
        '
        'srDescription
        '
        Me.srDescription.HeaderText = "Description"
        Me.srDescription.Name = "srDescription"
        Me.srDescription.ReadOnly = True
        Me.srDescription.Width = 210
        '
        'userContextMenu
        '
        Me.userContextMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameMenu, Me.ToolStripSeparator1, Me.ResetPasswordMenu, Me.PropertiesMenu})
        Me.userContextMenu.Name = "userContextMenu"
        Me.userContextMenu.Size = New System.Drawing.Size(152, 76)
        '
        'NameMenu
        '
        Me.NameMenu.ForeColor = System.Drawing.Color.RoyalBlue
        Me.NameMenu.Name = "NameMenu"
        Me.NameMenu.Size = New System.Drawing.Size(151, 22)
        Me.NameMenu.Text = "name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'ResetPasswordMenu
        '
        Me.ResetPasswordMenu.Name = "ResetPasswordMenu"
        Me.ResetPasswordMenu.Size = New System.Drawing.Size(151, 22)
        Me.ResetPasswordMenu.Text = "Reset Password"
        '
        'PropertiesMenu
        '
        Me.PropertiesMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.PropertiesMenu.Name = "PropertiesMenu"
        Me.PropertiesMenu.Size = New System.Drawing.Size(151, 22)
        Me.PropertiesMenu.Text = "Properties"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(290, 0)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 507)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 26)
        Me.Panel1.TabIndex = 11
        '
        'customDomainCombo
        '
        Me.customDomainCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customDomainCombo.FormattingEnabled = True
        Me.customDomainCombo.Items.AddRange(New Object() {" (edit custom domains)"})
        Me.customDomainCombo.Location = New System.Drawing.Point(297, 8)
        Me.customDomainCombo.Name = "customDomainCombo"
        Me.customDomainCombo.Size = New System.Drawing.Size(121, 20)
        Me.customDomainCombo.TabIndex = 100001
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.adTabControl)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 187)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 320)
        Me.Panel2.TabIndex = 100002
        '
        'SearchPanel
        '
        Me.SearchPanel.Controls.Add(Me.gbSearch)
        Me.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchPanel.Location = New System.Drawing.Point(0, 34)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(425, 153)
        Me.SearchPanel.TabIndex = 100003
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.DomainSelect)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.customDomainCombo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(425, 34)
        Me.Panel4.TabIndex = 100004
        '
        'ADmgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 533)
        Me.Controls.Add(Me.SearchPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ADmgmt"
        Me.Text = "AD User Manager"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adTabControl.ResumeLayout(False)
        Me.tabAccount.ResumeLayout(False)
        Me.tabAccount.PerformLayout()
        Me.tabProfile.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabMemberOf.ResumeLayout(False)
        Me.tabCustom.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.groupContextMenu.ResumeLayout(False)
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchResultsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.userContextMenu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SearchPanel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DomainSelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
    Friend WithEvents AccDisabled As System.Windows.Forms.CheckBox
    Friend WithEvents btnEaSave As System.Windows.Forms.Button
    Friend WithEvents SearchResultsDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SearchPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents userContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResetPasswordMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NameMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PropertiesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents srName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents srDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtExpires As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents btnAddUsertoGroup As System.Windows.Forms.Button
    Friend WithEvents btnRemoveUserfromGroup As System.Windows.Forms.Button
    Friend WithEvents SearchTypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents groupContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MemberAddMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MemberRemoveMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MemberRefreshMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MemberExportMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
