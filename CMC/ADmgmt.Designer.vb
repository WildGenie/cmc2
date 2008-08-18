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
        Me.tabGroups = New System.Windows.Forms.TabPage
        Me.tabCustom = New System.Windows.Forms.TabPage
        Me.gbSearch = New System.Windows.Forms.GroupBox
        Me.radioComputers = New System.Windows.Forms.RadioButton
        Me.radioGroups = New System.Windows.Forms.RadioButton
        Me.radioUsers = New System.Windows.Forms.RadioButton
        Me.tabGroupMembers = New System.Windows.Forms.TabPage
        Me.listBoxMembers = New System.Windows.Forms.ListBox
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.adTabControl.SuspendLayout()
        Me.tabAccount.SuspendLayout()
        Me.gbSearch.SuspendLayout()
        Me.tabGroupMembers.SuspendLayout()
        Me.SuspendLayout()
        '
        'DomainSelect
        '
        Me.DomainSelect.FormattingEnabled = True
        Me.DomainSelect.Location = New System.Drawing.Point(32, 32)
        Me.DomainSelect.Name = "DomainSelect"
        Me.DomainSelect.Size = New System.Drawing.Size(183, 21)
        Me.DomainSelect.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(143, 19)
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
        Me.Label1.Location = New System.Drawing.Point(29, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Domain"
        '
        'SearchResults
        '
        Me.SearchResults.FormattingEnabled = True
        Me.SearchResults.Location = New System.Drawing.Point(143, 45)
        Me.SearchResults.Name = "SearchResults"
        Me.SearchResults.Size = New System.Drawing.Size(211, 69)
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
        Me.lbldomain.Location = New System.Drawing.Point(139, 13)
        Me.lbldomain.Name = "lbldomain"
        Me.lbldomain.Size = New System.Drawing.Size(39, 13)
        Me.lbldomain.TabIndex = 7
        Me.lbldomain.Text = "Label3"
        '
        'adTabControl
        '
        Me.adTabControl.Controls.Add(Me.tabAccount)
        Me.adTabControl.Controls.Add(Me.tabProfile)
        Me.adTabControl.Controls.Add(Me.tabGroups)
        Me.adTabControl.Controls.Add(Me.tabCustom)
        Me.adTabControl.Controls.Add(Me.tabGroupMembers)
        Me.adTabControl.Enabled = False
        Me.adTabControl.Location = New System.Drawing.Point(32, 209)
        Me.adTabControl.Name = "adTabControl"
        Me.adTabControl.SelectedIndex = 0
        Me.adTabControl.Size = New System.Drawing.Size(389, 351)
        Me.adTabControl.TabIndex = 8
        '
        'tabAccount
        '
        Me.tabAccount.BackColor = System.Drawing.Color.Transparent
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
        Me.tabAccount.Size = New System.Drawing.Size(381, 325)
        Me.tabAccount.TabIndex = 0
        Me.tabAccount.Text = "Account"
        Me.tabAccount.UseVisualStyleBackColor = True
        '
        'txtSAM
        '
        Me.txtSAM.Location = New System.Drawing.Point(170, 53)
        Me.txtSAM.Name = "txtSAM"
        Me.txtSAM.Size = New System.Drawing.Size(194, 20)
        Me.txtSAM.TabIndex = 18
        '
        'txtDomain
        '
        Me.txtDomain.Enabled = False
        Me.txtDomain.Location = New System.Drawing.Point(15, 53)
        Me.txtDomain.Name = "txtDomain"
        Me.txtDomain.Size = New System.Drawing.Size(149, 20)
        Me.txtDomain.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(191, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "User Logon Name (pre-Windows 2000)"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(93, 267)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(271, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtTelephone
        '
        Me.txtTelephone.Location = New System.Drawing.Point(93, 241)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(132, 20)
        Me.txtTelephone.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Telephone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Office:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Display Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Last Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Initials:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name:"
        '
        'txtOffice
        '
        Me.txtOffice.Location = New System.Drawing.Point(93, 198)
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(271, 20)
        Me.txtOffice.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(93, 171)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(271, 20)
        Me.txtDescription.TabIndex = 4
        '
        'txtDisplayName
        '
        Me.txtDisplayName.Location = New System.Drawing.Point(93, 144)
        Me.txtDisplayName.Name = "txtDisplayName"
        Me.txtDisplayName.Size = New System.Drawing.Size(271, 20)
        Me.txtDisplayName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(93, 117)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(271, 20)
        Me.txtLastName.TabIndex = 2
        '
        'txtInitials
        '
        Me.txtInitials.Location = New System.Drawing.Point(309, 90)
        Me.txtInitials.Name = "txtInitials"
        Me.txtInitials.Size = New System.Drawing.Size(55, 20)
        Me.txtInitials.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(93, 90)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(132, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'tabProfile
        '
        Me.tabProfile.BackColor = System.Drawing.Color.Transparent
        Me.tabProfile.Location = New System.Drawing.Point(4, 22)
        Me.tabProfile.Name = "tabProfile"
        Me.tabProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProfile.Size = New System.Drawing.Size(381, 325)
        Me.tabProfile.TabIndex = 1
        Me.tabProfile.Text = "Profile"
        Me.tabProfile.UseVisualStyleBackColor = True
        '
        'tabGroups
        '
        Me.tabGroups.Location = New System.Drawing.Point(4, 22)
        Me.tabGroups.Name = "tabGroups"
        Me.tabGroups.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGroups.Size = New System.Drawing.Size(381, 325)
        Me.tabGroups.TabIndex = 2
        Me.tabGroups.Text = "Groups"
        Me.tabGroups.UseVisualStyleBackColor = True
        '
        'tabCustom
        '
        Me.tabCustom.Location = New System.Drawing.Point(4, 22)
        Me.tabCustom.Name = "tabCustom"
        Me.tabCustom.Size = New System.Drawing.Size(381, 325)
        Me.tabCustom.TabIndex = 3
        Me.tabCustom.Text = "Custom"
        Me.tabCustom.UseVisualStyleBackColor = True
        '
        'gbSearch
        '
        Me.gbSearch.Controls.Add(Me.radioComputers)
        Me.gbSearch.Controls.Add(Me.radioGroups)
        Me.gbSearch.Controls.Add(Me.radioUsers)
        Me.gbSearch.Controls.Add(Me.SearchResults)
        Me.gbSearch.Controls.Add(Me.txtSearch)
        Me.gbSearch.Controls.Add(Me.btnSearch)
        Me.gbSearch.Enabled = False
        Me.gbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbSearch.Location = New System.Drawing.Point(32, 68)
        Me.gbSearch.Name = "gbSearch"
        Me.gbSearch.Size = New System.Drawing.Size(389, 126)
        Me.gbSearch.TabIndex = 9
        Me.gbSearch.TabStop = False
        Me.gbSearch.Text = "Search"
        '
        'radioComputers
        '
        Me.radioComputers.AutoSize = True
        Me.radioComputers.FlatAppearance.BorderSize = 3
        Me.radioComputers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioComputers.Location = New System.Drawing.Point(52, 68)
        Me.radioComputers.Name = "radioComputers"
        Me.radioComputers.Size = New System.Drawing.Size(74, 17)
        Me.radioComputers.TabIndex = 9
        Me.radioComputers.Text = "Computers"
        Me.radioComputers.UseVisualStyleBackColor = True
        '
        'radioGroups
        '
        Me.radioGroups.AutoSize = True
        Me.radioGroups.FlatAppearance.BorderSize = 3
        Me.radioGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.radioGroups.Location = New System.Drawing.Point(52, 45)
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
        Me.radioUsers.Location = New System.Drawing.Point(52, 21)
        Me.radioUsers.Name = "radioUsers"
        Me.radioUsers.Size = New System.Drawing.Size(51, 17)
        Me.radioUsers.TabIndex = 7
        Me.radioUsers.TabStop = True
        Me.radioUsers.Text = "Users"
        Me.radioUsers.UseVisualStyleBackColor = True
        '
        'tabGroupMembers
        '
        Me.tabGroupMembers.Controls.Add(Me.listBoxMembers)
        Me.tabGroupMembers.Location = New System.Drawing.Point(4, 22)
        Me.tabGroupMembers.Name = "tabGroupMembers"
        Me.tabGroupMembers.Size = New System.Drawing.Size(381, 325)
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
        Me.listBoxMembers.TabIndex = 0
        '
        'ADmgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 573)
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
        Me.gbSearch.ResumeLayout(False)
        Me.gbSearch.PerformLayout()
        Me.tabGroupMembers.ResumeLayout(False)
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
    Friend WithEvents tabGroups As System.Windows.Forms.TabPage
    Friend WithEvents tabCustom As System.Windows.Forms.TabPage
    Friend WithEvents gbSearch As System.Windows.Forms.GroupBox
    Friend WithEvents radioComputers As System.Windows.Forms.RadioButton
    Friend WithEvents radioGroups As System.Windows.Forms.RadioButton
    Friend WithEvents radioUsers As System.Windows.Forms.RadioButton
    Friend WithEvents tabGroupMembers As System.Windows.Forms.TabPage
    Friend WithEvents listBoxMembers As System.Windows.Forms.ListBox
End Class
