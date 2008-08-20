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
        Me.lbldomain = New System.Windows.Forms.Label
        Me.adTabControl = New System.Windows.Forms.TabControl
        Me.tabAccount = New System.Windows.Forms.TabPage
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
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtOffice = New System.Windows.Forms.TextBox
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.txtDisplayName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.txtInitials = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.tabProfile = New System.Windows.Forms.TabPage
        Me.tabMemberOf = New System.Windows.Forms.TabPage
        Me.lbMemberOf = New System.Windows.Forms.ListBox
        Me.tabCustom = New System.Windows.Forms.TabPage
        Me.tabGroupMembers = New System.Windows.Forms.TabPage
        Me.listBoxMembers = New System.Windows.Forms.ListBox
        Me.gbSearch = New System.Windows.Forms.GroupBox
        Me.radioGroups = New System.Windows.Forms.RadioButton
        Me.radioUsers = New System.Windows.Forms.RadioButton
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.lblGroupName = New System.Windows.Forms.Label
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adTabControl.SuspendLayout()
        Me.tabAccount.SuspendLayout()
        Me.tabMemberOf.SuspendLayout()
        Me.tabGroupMembers.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomainSelect
        '
        Me.DomainSelect.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DomainSelect.FormattingEnabled = True
        Me.DomainSelect.Location = New System.Drawing.Point(13, 32)
        Me.DomainSelect.Name = "DomainSelect"
        Me.DomainSelect.Size = New System.Drawing.Size(183, 21)
        Me.DomainSelect.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.txtSearch.Location = New System.Drawing.Point(132, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(147, 20)
        Me.txtSearch.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(296, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(58, 20)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search..."
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Domain"
        '
        'SearchResults
        '
        Me.SearchResults.FormattingEnabled = True
        Me.SearchResults.Location = New System.Drawing.Point(68, 49)
        Me.SearchResults.Name = "SearchResults"
        Me.SearchResults.Size = New System.Drawing.Size(286, 69)
        Me.SearchResults.TabIndex = 6
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'lbldomain
        '
        Me.lbldomain.AutoSize = True
        Me.lbldomain.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbldomain.Location = New System.Drawing.Point(120, 13)
        Me.lbldomain.Name = "lbldomain"
        Me.lbldomain.Size = New System.Drawing.Size(10, 13)
        Me.lbldomain.TabIndex = 7
        Me.lbldomain.Text = " "
        '
        'adTabControl
        '
        Me.adTabControl.Controls.Add(Me.tabAccount)
        Me.adTabControl.Controls.Add(Me.tabProfile)
        Me.adTabControl.Controls.Add(Me.tabMemberOf)
        Me.adTabControl.Controls.Add(Me.tabCustom)
        Me.adTabControl.Controls.Add(Me.tabGroupMembers)
        Me.adTabControl.Enabled = False
        Me.adTabControl.Location = New System.Drawing.Point(13, 209)
        Me.adTabControl.Name = "adTabControl"
        Me.adTabControl.SelectedIndex = 0
        Me.adTabControl.Size = New System.Drawing.Size(389, 328)
        Me.adTabControl.TabIndex = 8
        '
        'tabAccount
        '
        Me.tabAccount.BackColor = System.Drawing.Color.Transparent
        Me.tabAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.tabAccount.Controls.Add(Me.Label5)
        Me.tabAccount.Controls.Add(Me.Label4)
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
        Me.tabAccount.Size = New System.Drawing.Size(381, 302)
        Me.tabAccount.TabIndex = 0
        Me.tabAccount.Text = "Account"
        Me.tabAccount.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(289, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 227)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(93, 224)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(271, 20)
        Me.txtDepartment.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(93, 203)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(271, 20)
        Me.txtTitle.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Company:"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.Location = New System.Drawing.Point(93, 245)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(271, 20)
        Me.txtCompany.TabIndex = 19
        '
        'txtSAM
        '
        Me.txtSAM.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtSAM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSAM.Location = New System.Drawing.Point(212, 11)
        Me.txtSAM.Name = "txtSAM"
        Me.txtSAM.ReadOnly = True
        Me.txtSAM.Size = New System.Drawing.Size(152, 20)
        Me.txtSAM.TabIndex = 18
        '
        'txtDomain
        '
        Me.txtDomain.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtDomain.Enabled = False
        Me.txtDomain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDomain.Location = New System.Drawing.Point(93, 11)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(113, 20)
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
        Me.txtEmail.Location = New System.Drawing.Point(93, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(93, 153)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(143, 20)
        Me.txtTelephone.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Telephone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Office:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Display Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(267, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Initials:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name:"
        '
        'txtOffice
        '
        Me.txtOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOffice.Location = New System.Drawing.Point(93, 125)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(271, 20)
        Me.txtOffice.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(93, 104)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(271, 20)
        Me.txtDescription.TabIndex = 4
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplayName.Location = New System.Drawing.Point(93, 83)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(271, 20)
        Me.txtDisplayName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(93, 62)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(271, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtInitials
        '
        Me.txtInitials.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInitials.Location = New System.Drawing.Point(309, 41)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(55, 20)
        Me.txtInitials.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(93, 41)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(143, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'tabProfile
        '
        Me.tabProfile.BackColor = System.Drawing.Color.Transparent
        Me.tabProfile.Location = New System.Drawing.Point(4, 22)
        Me.tabProfile.Name = "tabProfile"
        Me.tabProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProfile.Size = New System.Drawing.Size(381, 302)
        Me.tabProfile.TabIndex = 1
        Me.tabProfile.Text = "Profile"
        Me.tabProfile.UseVisualStyleBackColor = True
        '
        'tabMemberOf
        '
        Me.tabMemberOf.BackColor = System.Drawing.Color.Transparent
        Me.tabMemberOf.Controls.Add(Me.lbMemberOf)
        Me.tabMemberOf.Location = New System.Drawing.Point(4, 22)
        Me.tabMemberOf.Name = "tabMemberOf"
        Me.tabMemberOf.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMemberOf.Size = New System.Drawing.Size(381, 302)
        Me.tabMemberOf.TabIndex = 2
        Me.tabMemberOf.Text = "Member Of"
        Me.tabMemberOf.UseVisualStyleBackColor = True
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
        Me.tabCustom.Location = New System.Drawing.Point(4, 22)
        Me.tabCustom.Name = "tabCustom"
        Me.tabCustom.Size = New System.Drawing.Size(381, 302)
        Me.tabCustom.TabIndex = 3
        Me.tabCustom.Text = "Custom"
        Me.tabCustom.UseVisualStyleBackColor = True
        '
        'tabGroupMembers
        '
        Me.tabGroupMembers.Controls.Add(Me.lblGroupName)
        Me.tabGroupMembers.Controls.Add(Me.listBoxMembers)
        Me.tabGroupMembers.Location = New System.Drawing.Point(4, 22)
        Me.tabGroupMembers.Name = "tabGroupMembers"
        Me.tabGroupMembers.Size = New System.Drawing.Size(381, 302)
        Me.tabGroupMembers.TabIndex = 4
        Me.tabGroupMembers.Text = "Members"
        Me.tabGroupMembers.UseVisualStyleBackColor = True
        '
        'listBoxMembers
        '
        Me.listBoxMembers.FormattingEnabled = True
        Me.listBoxMembers.Location = New System.Drawing.Point(19, 55)
        Me.listBoxMembers.Name = "listBoxMembers"
        Me.listBoxMembers.Size = New System.Drawing.Size(343, 212)
        Me.listBoxMembers.Sorted = True
        Me.listBoxMembers.TabIndex = 0
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
        Me.gbSearch.Location = New System.Drawing.Point(13, 68)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(389, 126)
        Me.gbSearch.TabIndex = 9
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'radioGroups
        '
        Me.radioGroups.AutoSize = True
        Me.radioGroups.FlatAppearance.BorderSize = 3
        Me.radioGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioGroups.Location = New System.Drawing.Point(68, 26)
        Me.radioGroups.Name = "radioGroups"
        Me.radioGroups.Size = New System.Drawing.Size(58, 17)
        Me.radioGroups.TabIndex = 8
        Me.radioGroups.Text = "Groups"
        Me.radioGroups.UseVisualStyleBackColor = True
        '
        'radioUsers
        '
        Me.radioUsers.AutoSize = True
        Me.radioUsers.Checked = True
        Me.radioUsers.FlatAppearance.BorderSize = 3
        Me.radioUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioUsers.Location = New System.Drawing.Point(68, 11)
        Me.radioUsers.Name = "radioUsers"
        Me.radioUsers.Size = New System.Drawing.Size(51, 17)
        Me.radioUsers.TabIndex = 7
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
        Me.TableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(271, 543)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(135, 26)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'lblGroupName
        '
        Me.lblGroupName.AutoSize = True
        Me.lblGroupName.Location = New System.Drawing.Point(19, 36)
        Me.lblGroupName.Name = "lblGroupName"
        Me.lblGroupName.Size = New System.Drawing.Size(0, 13)
        Me.lblGroupName.TabIndex = 1
        '
        'ADmgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 575)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.gbSearch)
        Me.Controls.Add(Me.adTabControl)
        Me.Controls.Add(Me.lbldomain)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DomainSelect)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ADmgmt"
        Me.Text = "ADmgmt"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.adTabControl.ResumeLayout(False)
        Me.tabAccount.ResumeLayout(False)
        Me.tabAccount.PerformLayout()
        Me.tabMemberOf.ResumeLayout(False)
        Me.tabGroupMembers.ResumeLayout(False)
        Me.tabGroupMembers.PerformLayout()
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DomainSelect As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchResults As System.Windows.Forms.ListBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents lbldomain As System.Windows.Forms.Label
    Friend WithEvents adTabControl As System.Windows.Forms.TabControl
    Friend WithEvents tabAccount As System.Windows.Forms.TabPage
    Friend WithEvents tabProfile As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSAM As System.Windows.Forms.TextBox
    Friend WithEvents txtDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tabMemberOf As System.Windows.Forms.TabPage
    Friend WithEvents tabCustom As System.Windows.Forms.TabPage
    Friend WithEvents gbSearch As System.Windows.Forms.GroupBox
    Friend WithEvents radioGroups As System.Windows.Forms.RadioButton
    Friend WithEvents radioUsers As System.Windows.Forms.RadioButton
    Friend WithEvents tabGroupMembers As System.Windows.Forms.TabPage
    Friend WithEvents listBoxMembers As System.Windows.Forms.ListBox
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
End Class
