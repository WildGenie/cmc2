Imports System
Imports System.DirectoryServices
Imports system.directoryservices.ActiveDirectory
Imports System.Data


Public Class ADmgmt

    Protected Friend domainList As New DataTable()
    Private _LDAPPath As String
    Private _LDAPHeader As String
    Private _ADUsername As String
    Private _ADPassword As String
    Private de As DirectoryEntry
    Private Loading As Boolean
    Private CurrentGroupName As String
    Dim m_TsUser As TSUSEREXLib.IADsTSUserEx


    Public Enum ADAccountOptions
        UF_TEMP_DUPLICATE_ACCOUNT = 256
        UF_NORMAL_ACCOUNT = 512
        UF_INTERDOMAIN_TRUST_ACCOUNT = 2048
        UF_WORKSTATION_TRUST_ACCOUNT = 4096
        UF_SERVER_TRUST_ACCOUNT = 8192
        UF_DONT_EXPIRE_PASSWD = 65536
        UF_SCRIPT = 1
        UF_ACCOUNTDISABLE = 2
        UF_HOMEDIR_REQUIRED = 8
        UF_LOCKOUT = 16
        UF_PASSWD_NOTREQD = 32
        UF_PASSWD_CANT_CHANGE = 64
        UF_ACCOUNT_LOCKOUT = 16
        UF_ENCRYPTED_TEXT_PASSWORD_ALLOWED = 128
    End Enum


    Private Sub DoWhileLoading()
        Splash.Show()
        Splash.Refresh()
        Do While Me.Loading = True
            System.Threading.Thread.Sleep(1000)
            Splash.Refresh()
        Loop
        Splash.Close()
    End Sub

    Private Sub ADmgmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Panel2.Size = New System.Drawing.Size(410, 0) '410, 320
        Me.Size = New System.Drawing.Size(426, 264) '426, 584

        Me.Loading = True
        Me.Visible = False
        Dim loader As New System.Threading.Thread(AddressOf DoWhileLoading)
        loader.Start()

        Me.SearchTypeCombo.SelectedIndex = 0

        'LoadDomains()
        Create_DomainListDataset()
        customDomainCombo.SelectedIndex = 0

        ' command line args
        If Environment.GetCommandLineArgs().Length > 1 Then
            Dim i As Integer
            Dim domname As String = ""
            For i = 1 To Environment.GetCommandLineArgs().Length - 1
                Select Case LCase(Mid(Environment.GetCommandLineArgs(i).ToString, 1, 2))
                    Case "/?"
                        MsgBox("perfmonitor.exe [/d:domainname] [/u:username]" & vbCrLf & vbCrLf & _
                        "/d:domainname: domain in which to search" & vbCr & _
                        "/u:username: search text" & vbCr & vbCr & _
                        "© Peter Forman 2008", MsgBoxStyle.Information, "AD Manager Usage")
                        Me.Close()
                        Exit Sub

                    Case "/d"
                        domname = Trim(Mid(Environment.GetCommandLineArgs(i), 4, Environment.GetCommandLineArgs(i).Length - 3).ToUpper)
                        For Each row As DataRow In domainList.Rows
                            If row(0).ToString = domname Then
                                DomainSelect.Text = domname
                            End If
                        Next
                    Case "/u"
                        txtSearch.Text = Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3)

                End Select
            Next

            If domname <> "" AndAlso Not String.IsNullOrEmpty(txtSearch.Text) Then
                StartSearch()
            End If
        End If

        Me.Loading = False
        loader.Join()
        Me.Visible = True


    End Sub
    Private Sub Create_DomainListDataset()
        domainList.Columns.Add(New DataColumn("NetBIOSName", GetType(String)))
        domainList.Columns.Add(New DataColumn("DnsName", GetType(String)))
        domainList.Columns.Add(New DataColumn("DomainController", GetType(String)))
        domainList.Columns.Add(New DataColumn("UserName", GetType(String)))
        domainList.Columns.Add(New DataColumn("Password", GetType(String)))
    End Sub

    Public Sub LoadDomains()

        ' add custom domains to DomainList dataset
        Dim di As New CustomDomainInfo
        Dim ca(,) As String = di.GetCustomDomains
        For i As Integer = 0 To ca.Length / 5 - 1
            domainList.Rows.Add(ca(i, 0), ca(i, 1), ca(i, 2), ca(i, 3), ca(i, 4))
        Next

        ' Get local domain
        Dim domainname As String = String.Empty
        Dim domaindnsname As String = String.Empty

        Try
            Dim Info As New ActiveDs.ADSystemInfo()
            domainname = Info.DomainShortName
            domaindnsname = Info.DomainDNSName

            ' check whether local domain already in dataset
            Dim bLocalDomainInList As Boolean = False
            If Not My.Computer.Name.ToUpper = domainname.ToUpper Then
                For Each row As DataRow In domainList.Rows
                    If row(0).ToString.ToUpper = domainname.ToUpper Then
                        bLocalDomainInList = True
                        Exit For
                    End If
                Next
            Else
                bLocalDomainInList = True
            End If

            ' add local domain to dataTable (domainList)
            If Not bLocalDomainInList Then
                domainList.Rows.Add(domainname.ToUpper, domaindnsname, "", "", "")
            End If
        Catch ex As Exception

        End Try

        If domainList.Rows.Count > 1 Then
            Me.DomainSelect.Items.Add(" - Select Domain - ")
        End If

        For Each row As DataRow In domainList.Rows
            If Not String.IsNullOrEmpty(row(0)) Then Me.DomainSelect.Items.Add(row(0))
        Next
        Me.DomainSelect.Sorted = True
        Me.DomainSelect.SelectedIndex = 0

    End Sub
    Private Sub DomainSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainSelect.SelectedIndexChanged

        Me.UserTabs_Clear()
        Me.SearchResultsDGV.Rows.Clear()

        Me.Cursor = Cursors.AppStarting

        If Not Me.DomainSelect.Text = " - Select Domain - " Then

            ' Find matching datarow for selected domain
            For Each row As DataRow In domainList.Rows
                If row(0).ToString.ToUpper = Me.DomainSelect.Text Then
                    Dim strDC As String = String.Empty
                    Dim aDsPath As String = "dc=" & row(1).ToString.Replace(".", ",dc=")
                    If Not String.IsNullOrEmpty(row(2).ToString) Then strDC = row(2).ToString & "/"
                    Me._LDAPPath = "LDAP://" & strDC & aDsPath
                    Me._LDAPHeader = "LDAP://" & strDC
                    Me._ADUsername = row(3)
                    Me._ADPassword = CStr(row(4))
                    If String.IsNullOrEmpty(Me._ADUsername) Then
                        Me._ADUsername = Nothing
                        Me._ADPassword = Nothing
                    End If
                    de = GetDirectoryEntry(Me._LDAPPath, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure)
                End If
            Next

            ' Remove "Select Domain" prompt and enable searching.
            If Me.DomainSelect.Items(0) = " - Select Domain - " Then
                Me.DomainSelect.Items.RemoveAt(0)
                Me.gbSearch.Enabled = True
                Me.adTabControl.Enabled = True
                Me.DomainSelect.BackColor = System.Drawing.SystemColors.Window
            End If

            ' move focus to search box
            Me.txtSearch.BackColor = Color.LightSkyBlue
            Me.txtSearch.Focus()

        End If

        If domainList.Rows.Count = 1 Then
            Me.gbSearch.Enabled = True
            Me.adTabControl.Enabled = True
            Me.DomainSelect.BackColor = System.Drawing.SystemColors.Window
        End If


        Me.DomainSelect.Select(1, 0)
        Me.Cursor = Cursors.Default

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        StartSearch()
    End Sub
    Private Sub StartSearch()
        Me.SearchResultsDGV.Rows.Clear()
        Me.SearchResultsDGV.Visible = True

        If String.IsNullOrEmpty(Me.txtSearch.Text) Then Return

        Me.Cursor = Cursors.AppStarting

        If Me.SearchTypeCombo.Text = "Users" Then
            SearchUser()
        ElseIf Me.SearchTypeCombo.Text = "Groups" Then
            SearchGroup()
        End If

        Me.SearchResultsDGV.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    ''' <summary>
    ''' Return list of users from ANR user query.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SearchUser()

        Using DirSearch As New DirectorySearcher(de)

            With DirSearch
                '.PropertiesToLoad.Add("distinguishedName")
                .PropertiesToLoad.Add("description")
                .PropertiesToLoad.Add("sAMAccountName")
                .Filter = "(&(objectClass=user)(objectCategory=person)(anr=" & Me.txtSearch.Text & "))"
            End With

            Dim RecordCount As Integer = 0
            Try
                RecordCount = DirSearch.FindAll.Count
                If DirSearch.FindAll.Count = 0 Then



                    Me.TopMost = True
                    If Me.Loading Then
                        Splash.Close()
                        Me.Loading = False
                        Me.Visible = True
                    End If
                    MessageBox.Show("User not found", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.TopMost = False




                    Exit Sub
                End If
            Catch ex As System.Runtime.InteropServices.COMException
                'If ex.Message = "The specified domain either does not exist or could not be contacted." Then
                ' "The server is not operational"


                Me.TopMost = True
                If Me.Loading Then
                    Splash.Close()
                    Me.Loading = False
                    Me.Visible = True
                End If
                'MessageBox.Show("User not found", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                MsgBox(ex.Message)
                Me.TopMost = False

                'MsgBox(ex.Message)
                Exit Sub
                'End If
            End Try

            For Each sResultSet As SearchResult In DirSearch.FindAll()
                Dim sAMAccount As String = Me.GetProperty(sResultSet, "sAMAccountName")
                Dim desc As String = Me.GetProperty(sResultSet, "description")
                Me.SearchResultsDGV.Rows.Add(sAMAccount, desc)
                If RecordCount = 1 Then
                    GetUserDetails(sAMAccount)
                    Me.btnSave.Enabled = False
                End If
            Next

        End Using

    End Sub
    ''' <summary>
    ''' Return list of groups from ANR group query.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SearchGroup()

        Using DirSearch As New DirectorySearcher(de)

            With DirSearch
                '.PropertiesToLoad.Add("distinguishedName")
                .PropertiesToLoad.Add("CN")
                .Filter = "(&(objectClass=group)(anr=" & Me.txtSearch.Text & "))"
            End With

            Dim RecordCount As Integer = 0
            Try
                RecordCount = DirSearch.FindAll.Count
                If DirSearch.FindAll.Count = 0 Then
                    MessageBox.Show("Group not found", "Group not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As System.Runtime.InteropServices.COMException
                'If ex.Message = "The specified domain either does not exist or could not be contacted." Then
                MsgBox(ex.Message)
                Exit Sub
                'End If
            End Try

            For Each sResultSet As SearchResult In DirSearch.FindAll()
                Me.SearchResultsDGV.Rows.Add(Me.GetProperty(sResultSet, "CN"))
            Next

        End Using

    End Sub



    Private SelectedResult As String

    Private Sub SearchResultsDGV_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles SearchResultsDGV.CellDoubleClick

        If SearchTypeCombo.Text = "Users" Then UserTabs_Clear()
        FmGroupMembers.MembersListView.Items.Clear()
        Me.Call_GetDetails()

    End Sub
    Private Sub SearchResultsDGV_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchResultsDGV.KeyUp
        'MsgBox(Me.SearchResultsDGV.Rows.Count)
        If Not String.IsNullOrEmpty(Me.SelectedResult) Then
            If e.KeyCode = Keys.Space Then

                UserTabs_Clear()
                FmGroupMembers.MembersListView.Items.Clear()
                Me.Call_GetDetails()

            End If
        End If
    End Sub
    Private Sub Call_GetDetails()
        If Me.SearchTypeCombo.Text = "Users" Then
            GetUserDetails(SelectedResult)
            Me.btnSave.Enabled = False
        ElseIf Me.SearchTypeCombo.Text = "Groups" Then
            If Not String.IsNullOrEmpty(SelectedResult) Then

                CurrentGroupName = SelectedResult
                Me.RefreshMembersListView()

            End If
        End If
    End Sub

    Private Sub SearchResultsDGV_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SearchResultsDGV.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then

                ' ensure only current item selected
                Me.SearchResultsDGV.ClearSelection()
                Me.SearchResultsDGV(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.SelectedResult = Me.SearchResultsDGV(0, hti.RowIndex).Value

                Me.NameMenu.Text = Me.SelectedResult
                userContextMenu.Show(Me.SearchResultsDGV, New Point(e.X, e.Y))
            End If

        Else

            Dim hti As DataGridView.HitTestInfo = sender.HitTest(e.X, e.Y)
            If hti.Type = DataGridViewHitTestType.Cell Then

                Me.SearchResultsDGV.ClearSelection()
                Me.SearchResultsDGV(hti.ColumnIndex, hti.RowIndex).Selected = True

                Me.SelectedResult = Me.SearchResultsDGV(0, hti.RowIndex).Value

            End If
        End If

    End Sub
    Private Sub SearchResultsDGV_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchResultsDGV.SelectionChanged

        If Me.SearchResultsDGV.SelectedRows.Count = 1 Then
            Dim iRow As Integer = Me.SearchResultsDGV.SelectedRows.Item(0).Index
            Me.SelectedResult = Me.SearchResultsDGV(0, iRow).Value
        Else
            Me.SelectedResult = String.Empty
        End If

    End Sub


    Protected Friend Sub UserTabs_Clear()
        Me.txtFirstName.Text = String.Empty
        Me.txtInitials.Text = String.Empty
        Me.txtLastName.Text = String.Empty
        Me.txtDisplayName.Text = String.Empty
        Me.txtDescription.Text = String.Empty
        Me.txtOffice.Text = String.Empty
        Me.txtTelephone.Text = String.Empty
        Me.txtEmail.Text = String.Empty
        Me.txtDomain.Text = String.Empty
        Me.txtSAM.Text = String.Empty
        Me.txtTitle.Text = String.Empty
        Me.txtDepartment.Text = String.Empty
        Me.txtCompany.Text = String.Empty
        Me.txtHomeProfile.Text = String.Empty
        Me.txtHomeFolder.Text = String.Empty
        Me.txtHomeDrive.Text = String.Empty
        Me.btnSave.Enabled = False

        Me.txtTSProfile.Text = String.Empty
        Me.txtTSDrive.Text = String.Empty
        Me.txtTSHomeFolder.Text = String.Empty

        Me.txtExpires.Text = String.Empty
        Me.AccDisabled.Checked = False

        Me.ea1.Text = String.Empty
        Me.ea2.Text = String.Empty
        Me.ea3.Text = String.Empty
        Me.ea4.Text = String.Empty
        Me.ea5.Text = String.Empty
        Me.ea6.Text = String.Empty
        Me.ea7.Text = String.Empty
        Me.ea8.Text = String.Empty
        Me.ea9.Text = String.Empty
        Me.ea10.Text = String.Empty
        Me.ea11.Text = String.Empty
        Me.ea12.Text = String.Empty
        Me.ea13.Text = String.Empty
        Me.ea14.Text = String.Empty
        Me.ea15.Text = String.Empty

        'For Each tb As Control In GroupBox3.Controls
        '    If tb.Name.Substring(1, 2).ToString = "ea" Then
        '        tb.Text = String.Empty
        '    End If
        'Next

        Me.lbMemberOf.Items.Clear()

        CurrentGroupName = String.Empty
        'FmGroupMembers.MembersListView.Items.Clear()
        'Me.btnExportUsers.Enabled = False
    End Sub



    ''' <summary>
    ''' Fill form with selected users attributes.
    ''' </summary>
    ''' <param name="sAccountName"></param>
    ''' <remarks></remarks>
    Protected Friend Sub GetUserDetails(ByVal sAccountName As String)

        Dim Searcher As New System.DirectoryServices.DirectorySearcher(de)
        Dim result As System.DirectoryServices.SearchResult
        Searcher.Filter = "(sAMAccountName= " & sAccountName & ")"

        result = Searcher.FindOne

        ' User Account properties
        Me.txtFirstName.Text = Me.GetProperty(result, "givenName")
        Me.txtInitials.Text = Me.GetProperty(result, "initials")
        Me.txtLastName.Text = Me.GetProperty(result, "sn")
        Me.txtDisplayName.Text = Me.GetProperty(result, "displayName")
        Me.txtDescription.Text = Me.GetProperty(result, "description")
        Me.txtOffice.Text = Me.GetProperty(result, "physicalDeliveryOfficeName")
        Me.txtTelephone.Text = Me.GetProperty(result, "telephoneNumber")
        Me.txtEmail.Text = Me.GetProperty(result, "mail")
        Me.txtDomain.Text = Me.DomainSelect.Text
        Me.txtSAM.Text = Me.GetProperty(result, "sAMAccountName")
        Me.txtTitle.Text = Me.GetProperty(result, "title")
        Me.txtDepartment.Text = Me.GetProperty(result, "department")
        Me.txtCompany.Text = Me.GetProperty(result, "company")

        ' User Profile
        Me.txtHomeProfile.Text = Me.GetProperty(result, "profilePath")
        Me.txtHomeFolder.Text = Me.GetProperty(result, "homeDirectory")
        Me.txtHomeDrive.Text = Me.GetProperty(result, "homeDrive")

        Me.ea1.Text = Me.GetProperty(result, "extensionAttribute1")
        Me.ea2.Text = Me.GetProperty(result, "extensionAttribute2")
        Me.ea3.Text = Me.GetProperty(result, "extensionAttribute3")
        Me.ea4.Text = Me.GetProperty(result, "extensionAttribute4")
        Me.ea5.Text = Me.GetProperty(result, "extensionAttribute5")
        Me.ea6.Text = Me.GetProperty(result, "extensionAttribute6")
        Me.ea7.Text = Me.GetProperty(result, "extensionAttribute7")
        Me.ea8.Text = Me.GetProperty(result, "extensionAttribute8")
        Me.ea9.Text = Me.GetProperty(result, "extensionAttribute9")
        Me.ea10.Text = Me.GetProperty(result, "extensionAttribute10")
        Me.ea11.Text = Me.GetProperty(result, "extensionAttribute11")
        Me.ea12.Text = Me.GetProperty(result, "extensionAttribute12")
        Me.ea13.Text = Me.GetProperty(result, "extensionAttribute13")
        Me.ea14.Text = Me.GetProperty(result, "extensionAttribute14")
        Me.ea15.Text = Me.GetProperty(result, "extensionAttribute15")

        ' Terminal Services profile
        Dim entry1 As DirectoryEntry = New DirectoryEntry(Me._LDAPHeader & Me.GetProperty(result, "distinguishedName"))
        Dim iADsUser1 As ActiveDs.IADsUser = CType(entry1.NativeObject, ActiveDs.IADsUser)
        'Dim m_TsUser As TSUSEREXLib.IADsTSUserEx = CType(iADsUser1, TSUSEREXLib.IADsTSUserEx)
        m_TsUser = CType(iADsUser1, TSUSEREXLib.IADsTSUserEx)
        Me.txtTSProfile.Text = m_TsUser.TerminalServicesProfilePath
        Me.txtTSDrive.Text = m_TsUser.TerminalServicesHomeDrive
        Me.txtTSHomeFolder.Text = m_TsUser.TerminalServicesHomeDirectory
        Me.cbAllowTSLogon.Checked = m_TsUser.AllowLogon

        Dim I_userAccountControl As Integer = CInt(Me.GetProperty(result, "userAccountControl"))

        ' Account Expires ?
        Me.txtExpires.Text = Me.AccExpires(result, "accountExpires")

        ' Is account enabled
        Me.AccDisabled.Checked = Not IsAccountActive(I_userAccountControl)


        ' Group Membership
        lbMemberOf.Items.Add("Domain Users")
        For Each gp As String In GetGroups(sAccountName)
            lbMemberOf.Items.Add(gp)
        Next

    End Sub


    ''' <summary>
    ''' Method that updates user's properties
    ''' </summary>
    ''' <param name="userLogin">sAMAccountName of the user to update</param>
    Public Sub UpdateUserAccountProperties(ByVal userLogin As String)

        Dim Searcher As DirectorySearcher = New DirectorySearcher(de)
        Searcher.Filter = "(&(objectCategory=Person)(objectClass=user)(sAMAccountName=" & userLogin & "))"
        Searcher.SearchScope = SearchScope.Subtree

        Dim searchResults As SearchResult = Searcher.FindOne()

        If Not searchResults Is Nothing Then
            Dim dirEntryResults As New DirectoryEntry(searchResults.Path)

            ' Set the new property values for the specified user
            SetADProperty(dirEntryResults, "givenName", Me.txtFirstName.Text)
            SetADProperty(dirEntryResults, "initials", Me.txtInitials.Text)
            SetADProperty(dirEntryResults, "sn", Me.txtLastName.Text)
            SetADProperty(dirEntryResults, "displayName", Me.txtDisplayName.Text)
            SetADProperty(dirEntryResults, "description", Me.txtDescription.Text)
            SetADProperty(dirEntryResults, "physicalDeliveryOfficeName", Me.txtOffice.Text)
            SetADProperty(dirEntryResults, "telephoneNumber", Me.txtTelephone.Text)
            SetADProperty(dirEntryResults, "mail", Me.txtEmail.Text)
            SetADProperty(dirEntryResults, "title", Me.txtTitle.Text)
            SetADProperty(dirEntryResults, "department", Me.txtDepartment.Text)
            SetADProperty(dirEntryResults, "company", Me.txtCompany.Text)

            ' enable / disable account
            Me.AccountDisable(Me.txtSAM.Text, Me.AccDisabled.Checked)


            ' Commit the changes
            Try
                dirEntryResults.CommitChanges()
            Catch ex As System.DirectoryServices.DirectoryServicesCOMException
                MsgBox("Unable to commit changes - An error has occurred." & vbCr & vbCr & ex.Message)
            End Try

            dirEntryResults.Close()
        End If

    End Sub
    ''' <summary>
    ''' Commit changes to terminal services profile.
    ''' </summary>
    ''' <param name="userLogin"></param>
    ''' <remarks></remarks>
    Private Sub UpdateUserTSProperties(ByVal userLogin As String)

        Dim Searcher As DirectorySearcher = New DirectorySearcher(de)
        Searcher.Filter = "(&(objectCategory=Person)(objectClass=user)(sAMAccountName=" & userLogin & "))"
        Searcher.SearchScope = SearchScope.Subtree

        Dim Result As SearchResult = Searcher.FindOne()

        If Not Result Is Nothing Then

            Dim entry1 As DirectoryEntry = New DirectoryEntry(Me._LDAPHeader & Me.GetProperty(Result, "distinguishedName"))
            Dim iADsUser1 As ActiveDs.IADsUser = CType(entry1.NativeObject, ActiveDs.IADsUser)
            Dim m_TsUser As TSUSEREXLib.IADsTSUserEx = CType(iADsUser1, TSUSEREXLib.IADsTSUserEx)
            m_TsUser.TerminalServicesProfilePath = Me.txtTSProfile.Text
            m_TsUser.TerminalServicesHomeDrive = Me.txtTSDrive.Text
            m_TsUser.TerminalServicesHomeDirectory = Me.txtTSHomeFolder.Text
            If Me.cbAllowTSLogon.Checked Then
                m_TsUser.AllowLogon = 1
            Else
                m_TsUser.AllowLogon = 0
            End If

            entry1.CommitChanges()
            entry1.Close()

        End If

        Searcher.Dispose()

    End Sub
    Private Sub UpdateUserExtensionAttributes(ByVal userLogin As String)
        Dim Searcher As DirectorySearcher = New DirectorySearcher(de)
        Searcher.Filter = "(&(objectCategory=Person)(objectClass=user)(sAMAccountName=" & userLogin & "))"
        Searcher.SearchScope = SearchScope.Subtree

        Dim searchResults As SearchResult = Searcher.FindOne()

        If Not searchResults Is Nothing Then
            Dim dirEntryResults As New DirectoryEntry(searchResults.Path)

            ' Set the new property values for the specified user
            SetADProperty(dirEntryResults, "extensionAttribute1", Me.ea1.Text)
            SetADProperty(dirEntryResults, "extensionAttribute2", Me.ea2.Text)
            SetADProperty(dirEntryResults, "extensionAttribute3", Me.ea3.Text)
            SetADProperty(dirEntryResults, "extensionAttribute4", Me.ea4.Text)
            SetADProperty(dirEntryResults, "extensionAttribute5", Me.ea5.Text)
            SetADProperty(dirEntryResults, "extensionAttribute6", Me.ea6.Text)
            SetADProperty(dirEntryResults, "extensionAttribute7", Me.ea7.Text)
            SetADProperty(dirEntryResults, "extensionAttribute8", Me.ea8.Text)
            SetADProperty(dirEntryResults, "extensionAttribute9", Me.ea9.Text)
            SetADProperty(dirEntryResults, "extensionAttribute10", Me.ea10.Text)
            SetADProperty(dirEntryResults, "extensionAttribute11", Me.ea11.Text)
            SetADProperty(dirEntryResults, "extensionAttribute12", Me.ea12.Text)
            SetADProperty(dirEntryResults, "extensionAttribute13", Me.ea13.Text)
            SetADProperty(dirEntryResults, "extensionAttribute14", Me.ea14.Text)
            SetADProperty(dirEntryResults, "extensionAttribute15", Me.ea15.Text)


            ' Commit the changes
            Try
                dirEntryResults.CommitChanges()
            Catch ex As System.DirectoryServices.DirectoryServicesCOMException
                MsgBox("Unable to commit changes - An error has occurred." & vbCr & vbCr & ex.Message)
            End Try

            dirEntryResults.Close()
        End If
    End Sub

    ''' <summary>
    ''' Return property value from a search result.
    ''' </summary>
    ''' <param name="SR"></param>
    ''' <param name="PropertyName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetProperty(ByVal SR As SearchResult, ByVal PropertyName As String) As String
        Dim retval As String
        If SR.Properties.Contains(PropertyName) Then
            retval = SR.Properties(PropertyName)(0).ToString()
        Else
            retval = String.Empty
        End If
        Return retval
    End Function

    ''' <summary>
    ''' Return formatted value for account expired field.
    ''' Either a date string or Never.
    ''' </summary>
    ''' <param name="SR"></param>
    ''' <param name="PropertyName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function AccExpires(ByVal SR As SearchResult, ByVal PropertyName As String) As String
        '
        ' //msdn2.microsoft.com/en-gb/library/ms675098.aspx
        '  LDAP- "accountExpires" - The date when the account expires.
        ' A value of 0 or 0x7FFFFFFFFFFFFFFF (9223372036854775807)
        '   indicates that the account never expires.
        '
        Dim WrkUInt64 As System.UInt64                ' unsigned 64bit
        Dim WrkUInt32H, WrkUInt32L As System.UInt32   ' unsigned 32bit
        Dim WrkDtTm As DateTime
        Dim Val As String = String.Empty

        If SR.Properties.Contains("accountExpires") Then
            WrkUInt64 = SR.Properties("accountExpires").Item(0)
            WrkUInt32H = CType((WrkUInt64 >> 32), UInteger)
            WrkUInt64 = WrkUInt64 << 32
            WrkUInt64 = WrkUInt64 >> 32
            WrkUInt32L = Convert.ToUInt32(WrkUInt64)
            WrkUInt64 = (WrkUInt32H * &H100000000) + WrkUInt32L
            Try
                WrkDtTm = DateTime.FromFileTime(WrkUInt64)
            Catch ex As Exception       ' not valid = "0x7FFFFFFFFFFFFFFF"
                WrkUInt64 = &H0
            End Try

            If WrkUInt64 = &H0 Then     ' not valid = "0"
                Val = "Never"
            Else
                Val = WrkDtTm
            End If
        Else                            ' property was not returned in the result
            Val = " *Error*"
        End If
        Return Val
    End Function

    ''' <summary>
    ''' Helper method that sets properties for AD users.
    ''' </summary>
    ''' <param name="entry">DirectoryEntry to use</param>
    ''' <param name="pName">Property name to set</param>
    ''' <param name="pValue">Value of property to set</param>
    Public Shared Sub SetADProperty(ByVal entry As DirectoryEntry, ByVal pName As String, ByVal pValue As String)

        If Not String.IsNullOrEmpty(pValue) Then

            'Check to see if the DirectoryEntry contains this property already
            If entry.Properties.Contains(pName) Then
                'Update the properties value
                entry.Properties(pName)(0) = pValue
            Else
                'Add the property and set it's value
                entry.Properties(pName).Add(pValue)
            End If
        Else
            entry.Properties(pName).Clear()
        End If

    End Sub



    Protected Friend Sub GroupMembers(ByVal groupName As String, ByVal mListView As ListView)
        ' To see the members in a group, you actually need to look at
        ' the member attribute of a group object, not its children as
        ' groups aren't container objects in AD (only containers have children). 

        Dim ldapPath As String

        Using DirSearch As New DirectorySearcher(de)

            DirSearch.PropertiesToLoad.Add("distinguishedName")
            DirSearch.Filter = "(&(objectClass=group)(cn=" & groupName & "))"
            Dim result As System.DirectoryServices.SearchResult = DirSearch.FindOne()
            If result Is Nothing Then
                MsgBox("Error finding group: " & vbCr & groupName)
                Return
            End If
            ldapPath = Me.GetProperty(result, "distinguishedName")

        End Using


        Dim myGroup As DirectoryEntry

        'instanciate myGroup to a valid group object in AD using its distinguished name.... 
        myGroup = New DirectoryEntry(Me._LDAPHeader & ldapPath)
        Dim members As PropertyValueCollection
        members = myGroup.Properties("member")
        Dim member As Object
        For Each member In members

            Dim img As Integer
            Dim objectClass As String = GetObjectClass_fromDN(member.ToString).ToLower
            If objectClass = "user" Then
                img = 0
            ElseIf objectClass = "group" Then
                img = 1
            Else
                img = 2
            End If
            Dim lv_row As ListViewItem = New ListViewItem(New String() {GetAttributefromDN("sAMAccountName", member.ToString), _
                                                                        GetAttributefromDN("displayName", member.ToString), _
                                                                        GetAttributefromDN("mail", member.ToString), _
                                                                        GetAttributefromDN("distinguishedName", member.ToString)}, img)
            mListView.Items.Add(lv_row)
        Next

    End Sub

    Private Function GetAttributefromDN(ByVal attributeToReturn As String, ByVal dsPath As String) As String
        Try
            Dim Searcher As New System.DirectoryServices.DirectorySearcher(de)
            Dim result As System.DirectoryServices.SearchResult
            Searcher.Filter = "(distinguishedName= " & dsPath & ")"
            result = Searcher.FindOne
            Return Me.GetProperty(result, attributeToReturn)
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return dsPath.Substring(3, dsPath.IndexOf(",") - 3)
        End Try
    End Function

    ''' <summary>
    ''' Identify whether object is a Group; Person; OrganisationalUnit...
    ''' </summary>
    ''' <param name="dsPath">distinguishedName</param>
    ''' <returns>objectClass(1)</returns>
    ''' <remarks>Need to add code to enumerate each objectClass value.
    '''          Peter Forman 2008</remarks>
    Private Function GetObjectClass_fromDN(ByVal dsPath As String) As String
        'user
        'group
        'contact
        'container
        'organizationalUnit
        'msexchDynamicDistributionList
        Dim Searcher As New System.DirectoryServices.DirectorySearcher(de)
        Dim result As System.DirectoryServices.SearchResultCollection
        Searcher.Filter = "(distinguishedName= " & dsPath & ")" '(objectClass=Group)"
        result = Searcher.FindAll()
        Dim retval As String = String.Empty
        For Each r As SearchResult In result
            If r.Properties.Contains("objectClass") Then
                'r.Properties("objectClass").Count
                'For Each oclass As String In r.Properties("objectClass")
                '    MsgBox(oclass)
                'Next
                'dim lastProperty as integer = r.Properties("objectClass")(1).ToString()
                retval = r.Properties("objectClass")(r.Properties("objectClass").Count - 1).ToString().ToLower
            End If
        Next
        Return retval
    End Function



    Private Sub UNUSED_AddUser_WINNT()
        Try
            Dim AD As DirectoryEntry = _
              New DirectoryEntry("WinNT://" + Environment.MachineName + ",computer")
            Dim NewUser As DirectoryEntry = AD.Children.Add("TestUser1", "user")
            NewUser.Invoke("SetPassword", New Object() {"#12345Abc"})
            NewUser.Invoke("Put", New Object() {"Description", "Test User from .NET"})
            NewUser.CommitChanges()
            Dim grp As DirectoryEntry

            grp = AD.Children.Find("Guests", "group")
            If grp.Name <> "" Then
                grp.Invoke("Add", New Object() {NewUser.Path.ToString()})
            End If
            Console.WriteLine("Account Created Successfully")
            Console.ReadLine()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.ReadLine()
        End Try
    End Sub



    'http://www.codeproject.com/KB/system/active_directory_in_vbnet.aspx


    ''' <summary>
    ''' Method used to create an AD entry.
    ''' Replace the path, username, and password.
    ''' </summary>
    ''' <param name="aDSPath"></param>
    ''' <param name="DomainUser"></param>
    ''' <param name="Password"></param>
    ''' <param name="authenticationType"></param>
    ''' <returns>DirectoryEntry</returns>
    ''' <remarks>DomainUser should be in the form: DOMAIN\Username (or NOTHING)</remarks>
    Private Function GetDirectoryEntry( _
                       ByVal aDSPath As String, _
                       ByVal DomainUser As String, _
                       ByVal Password As String, _
                       Optional ByVal authenticationType As DirectoryServices.AuthenticationTypes = AuthenticationTypes.Secure) _
                                        As DirectoryEntry
        Dim de As New DirectoryEntry()
        de.Path = aDSPath
        de.Username = DomainUser
        de.Password = Password
        Return de
    End Function

    ''' <summary>
    ''' Reset a user's password
    ''' </summary>
    ''' <param name="User">User Logon Name</param>
    ''' <param name="NewPassword">New Password for the user</param>
    Public Function SetUserPassword(ByVal User As String, ByVal NewPassword As String) As Boolean

        Dim oSearcher As New DirectorySearcher(de)
        oSearcher.Filter = "(&(objectClass=user)(sAMAccountName=" & User & "))"
        Dim oResult As SearchResult = oSearcher.FindOne
        Dim oUser As DirectoryEntry = oResult.GetDirectoryEntry

        If Not oUser Is Nothing Then
            Try
                oUser.Invoke("SetPassword", New Object() {NewPassword})
                'usr.Properties("pwdLastSet").Value = -1
                Return True
            Catch Ex As Exception
                MsgBox("Password could not be set for user: " & SelectedResult _
                       & vbCr & vbCr & _
                       Ex.InnerException.Message, MsgBoxStyle.Exclamation, "AD Manager")
                Return False
            End Try
        End If

    End Function
    Private Sub ForceChangePwd(ByVal userLogon As String)
        Dim Searcher As DirectorySearcher = New DirectorySearcher(de)
        Searcher.Filter = "(&(objectCategory=Person)(objectClass=user)(sAMAccountName=" & userLogon & "))"
        Searcher.SearchScope = SearchScope.Subtree

        Dim searchResults As SearchResult = Searcher.FindOne()

        If Not searchResults Is Nothing Then
            Dim dirEntryResults As New DirectoryEntry(searchResults.Path)

            ' Set the new property values for the specified user
            '(-1 sets current datetime, 0 forces password change)
            ' possibly need to add check for password never expires flag
            dirEntryResults.Properties("pwdLastSet").Value = 0

            ' Commit the changes
            Try
                dirEntryResults.CommitChanges()
            Catch ex As System.DirectoryServices.DirectoryServicesCOMException
                MsgBox("Unable to set Pwd expired." & vbCr & vbCr & ex.Message & vbCr & ex.InnerException.Message, MsgBoxStyle.Critical, "AD Manager")
            End Try

            dirEntryResults.Close()
        End If


        'Dim objUser As Object = GetObject("LDAP://" & strUserFQDN)
        '' will not work if 'password never expires' set.
        'objUser.Put("PwdLastSet", 0)
        'objUser.SetInfo()


    End Sub

    ''' <summary>
    ''' Method to add a user to a group
    ''' </summary>
    ''' <param name="entry">DirectoryEntry to use</param>
    ''' <param name="User">User DirectoryEntry to use</param>
    ''' <param name="GroupName">Group Name to add user to</param>
    Public Sub AddUserToGroup(ByVal entry As DirectoryEntry, _
                                     ByVal User As DirectoryEntry, _
                                     ByVal GroupName As String)

        Dim deSearch As DirectorySearcher = New DirectorySearcher(entry)

        deSearch.Filter = "(&(objectClass=group) (cn=" & GroupName & "))"
        Dim results As SearchResultCollection = deSearch.FindAll()

        Dim isGroupMember As Boolean = False
        If results.Count > 0 Then

            Dim group As New DirectoryEntry(results(0).Path) ' adspath
            Dim members As Object = group.Invoke("Members", Nothing)
            For Each member As Object In CType(members, IEnumerable)
                Dim x As DirectoryEntry = New DirectoryEntry(member)
                Dim name As String = x.Name
                If name = User.Name Then
                    isGroupMember = True
                    Exit For
                End If
            Next

            If (Not isGroupMember) Then
                Try
                    group.Invoke("Add", New Object() {User.Path.ToString()})
                Catch ex As Exception
                    MsgBox("Unable to add " & Replace(User.Name, "cn=", "", 1, 1, CompareMethod.Text) & " to " & GroupName & vbCr & vbCr & ex.Message, MsgBoxStyle.Critical, "Group Invoke Error")
                End Try
            End If
            group.Close()

        End If

    End Sub
    Public Sub RemoveUserFromGroup(ByVal entry As DirectoryEntry, _
                                     ByVal User As DirectoryEntry, _
                                     ByVal GroupName As String)

        Dim deSearch As DirectorySearcher = New DirectorySearcher(entry)

        deSearch.Filter = "(&(objectClass=group) (cn=" & GroupName & "))"
        Dim results As SearchResultCollection = deSearch.FindAll()

        Dim isGroupMember As Boolean = False
        If results.Count > 0 Then

            Dim group As New DirectoryEntry(results(0).Path) ' adspath
            Dim members As Object = group.Invoke("Members", Nothing)
            For Each member As Object In CType(members, IEnumerable)
                Dim x As DirectoryEntry = New DirectoryEntry(member)
                Dim name As String = x.Name
                If name = User.Name Then
                    isGroupMember = True
                    Exit For
                End If
            Next

            If isGroupMember Then
                group.Invoke("Remove", New Object() {User.Path.ToString()})
            End If
            group.Close()

        End If

    End Sub

    ''' <summary>
    ''' Function to return all the groups the user is a member od
    ''' </summary>
    ''' <param name="LogonName">Users logon name</param>
    Private Function GetGroups(ByVal LogonName As String) As Collection

        Dim Groups As New Collection
        'Dim dirEntry As New System.DirectoryServices.DirectoryEntry(_path, username, password)
        Dim dirSearcher As New DirectorySearcher(de) '(dirEntry)
        dirSearcher.Filter = "(sAMAccountName= " & LogonName & ")"  'String.Format("(sAMAccountName={0}))", LogonName)
        dirSearcher.PropertiesToLoad.Add("memberOf")

        Dim propCount As Integer
        Try
            Dim dirSearchResults As SearchResult = dirSearcher.FindOne()
            propCount = dirSearchResults.Properties("memberOf").Count
            Dim dn As String
            For i As Integer = 0 To propCount - 1
                dn = dirSearchResults.Properties("memberOf")(i)
                Dim gName As String = GetAttributefromDN("name", dn)
                If Not Groups.Contains(gName) Then
                    Groups.Add(gName)
                End If
            Next
        Catch ex As Exception
            If ex.GetType Is GetType(System.NullReferenceException) Then
                MessageBox.Show("Selected user isn't a member of any groups " & _
                                "at this time.", "No groups listed", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' user does not have a "memberOf" attribute so it errors out.
            Else
                MessageBox.Show(ex.Message.ToString, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Try

        Return Groups

    End Function

    ''' <summary>
    ''' This will perfrom a logical operation on the userAccountControl values
    ''' to see if the user account is enabled or disabled.
    ''' The flag for determining if the
    ''' account is active is a bitwise value (decimal =2)
    ''' </summary>
    ''' <param name="userAccountControl"></param>
    ''' <returns></returns>
    Private Function IsAccountActive(ByVal userAccountControl As Integer) As Boolean

        Dim accountDisabled As Integer = Convert.ToInt32(ADAccountOptions.UF_ACCOUNTDISABLE) '2
        Dim flagExists As Integer = userAccountControl And accountDisabled

        'if a match is found, then the disabled flag exists within the control flags.
        If flagExists > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    ''' <summary>
    ''' Method that enables/disables a user account in the AD 
    ''' and hides user's email from Exchange address lists.
    ''' </summary>
    ''' <param name="userLogin">Login of the user to disable</param>
    Public Sub AccountDisable(ByVal userLogin As String, ByVal DisableAccount As Boolean)

        Dim Searcher As DirectorySearcher = New DirectorySearcher(de)
        Searcher.Filter = "(&(objectCategory=Person)(objectClass=user)(sAMAccountName=" & userLogin & "))"
        Searcher.SearchScope = SearchScope.Subtree

        Dim searchResults As SearchResult = Searcher.FindOne()

        If Not searchResults Is Nothing Then

            Dim dirEntryResults As New DirectoryEntry(searchResults.Path)
            Dim iVal As Integer = CInt(dirEntryResults.Properties("userAccountControl").Value)


            If dirEntryResults.Properties.Contains("userAccountControl") Then
                If DisableAccount Then ' disable account
                    dirEntryResults.Properties("userAccountControl")(0) = iVal Or &H2
                Else                   ' enable account
                    dirEntryResults.Properties("userAccountControl")(0) = iVal And Not &H2
                End If
            Else
                If DisableAccount Then ' disable account
                    dirEntryResults.Properties("userAccountControl").Add(iVal Or &H2)
                Else                   ' enable account
                    dirEntryResults.Properties("userAccountControl").Add(iVal And Not &H2)
                End If
            End If


            ' Commit the changes
            Try
                dirEntryResults.CommitChanges()
            Catch ex As System.DirectoryServices.DirectoryServicesCOMException
                MsgBox("Unable to commit changes - An error has occurred." & vbCr & vbCr & ex.Message)
            End Try

            dirEntryResults.Close()
            dirEntryResults.Dispose()
        End If

    End Sub

    ''' <summary>
    ''' Method that calls and starts a WSHControl.vbs
    ''' </summary>
    ''' <param name="userAlias"></param>
    Public Sub GenerateMailBox(ByVal userAlias As String)
        Dim mailargs As Text.StringBuilder = New Text.StringBuilder()
        mailargs.Append("WSHControl.vbs")
        mailargs.Append(" ")
        mailargs.Append(userAlias)
        Dim sInfo As ProcessStartInfo = New ProcessStartInfo("Wscript.exe", mailargs.ToString())
        sInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(sInfo)
    End Sub

    ''' <summary>
    ''' Method that validates if a string has an email pattern.
    ''' </summary>
    ''' <param name="mail"></param>
    ''' <returns></returns>
    Public Function IsEmail(ByVal mail As String) As Boolean
        Dim mailPattern As Text.RegularExpressions.Regex = New Text.RegularExpressions.Regex("\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
        Return mailPattern.IsMatch(mail)
    End Function

    ''' <summary>
    ''' Method that formats a date in the required format
    ''' needed (AAAAMMDDMMSSSS.0Z) to compare dates in AD.
    ''' </summary>
    ''' <param name="date_Renamed"></param>
    ''' <returns>Date in valid format for AD</returns>
    Public Function ToADDateString(ByVal date_Renamed As DateTime) As String
        Dim year As String = date_Renamed.Year.ToString()
        Dim month As Integer = date_Renamed.Month
        Dim day As Integer = date_Renamed.Day
        Dim sb As Text.StringBuilder = New Text.StringBuilder()
        sb.Append(year)
        If month < 10 Then
            sb.Append("0")
        End If
        sb.Append(month.ToString())
        If day < 10 Then
            sb.Append("0")
        End If
        sb.Append(day.ToString())
        sb.Append("000000.0Z")
        Return sb.ToString()
    End Function


    ' Save Button Handlers
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        UpdateUserAccountProperties(Me.txtSAM.Text)
    End Sub
    Private Sub btnProfileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfileSave.Click
        UpdateUserTSProperties(Me.txtSAM.Text)
    End Sub
    Private Sub btnEaSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEaSave.Click
        UpdateUserExtensionAttributes(Me.txtSAM.Text)
    End Sub

    ' Account Properties changed - enable save button
    Private Sub txtFirstName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtInitials_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInitials.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtLastName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastName.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtDisplayName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisplayName.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtOffice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffice.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtTelephone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelephone.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtTitle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitle.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtDepartment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepartment.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub txtCompany_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompany.TextChanged
        Me.btnSave.Enabled = True
    End Sub
    Private Sub AccDisabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccDisabled.CheckedChanged
        Me.btnSave.Enabled = True
    End Sub

    ' Clear and Exit Button handlers
    Private Sub btnExit_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.UserTabs_Clear()
        Me.txtSearch.Text = ""
        Me.btnSave.Enabled = False
        Me.SearchResultsDGV.Rows.Clear()
        Me.SearchResultsDGV.Visible = False

        ' members context menu
        MemberRefreshMenu.Enabled = False
        MemberExportMenu.Enabled = False
        MemberAddMenu.Enabled = False
        'Me.btnAdd.Enabled = False
    End Sub


    Private Sub btnExportUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ExportToCSV()
    End Sub
    Private Sub ExportToCSV()
        Dim exportFile As New System.IO.StreamWriter("c:\" & CurrentGroupName & ".csv", False)

        If FmGroupMembers.MembersListView.Items.Count > 0 Then
            exportFile.WriteLine("Logon Name, Display Name, Email")
            exportFile.WriteLine("")
            For Each member As ListViewItem In FmGroupMembers.MembersListView.Items
                exportFile.WriteLine(member.SubItems(0).Text & "," & member.SubItems(1).Text)
            Next
            exportFile.Close()
            Shell("notepad c:\" & CurrentGroupName & ".csv")
        End If
    End Sub
    Public Sub ExportToExcel(ByVal dt As DataTable)
        '    Try
        '        Dim oApp As New Excel.Application
        '        Dim oBook As Excel.Workbook = oApp.Workbooks.Add
        '        Dim oSheet As Excel.Worksheet = CType(oBook.Worksheets(1), Excel.Worksheet)

        '        oApp.Visible = False

        '        With oSheet
        '            Dim c As Long = Asc("A")
        '            For Each dc As DataColumn In dt.Columns
        '        .Range(C hr(c) & "1").Value = dc.ColumnName.ToString
        '        .Range(C hr(c) & "1").Font.Bold = True
        '                c += 1
        '            Next

        '            Dim i As Long = 2
        '            For Each dr As DataRow In dt.Rows
        '                c = Asc("A")
        '                For Each dc As DataColumn In dt.Columns
        '           .Range(C hr(c) & i.ToString).Value =  dr.Item(dc.ColumnName)
        '                    c += 1
        '                Next
        '                i += 1
        '            Next

        '            oApp.Visible = True
        '        End With
        '    Catch ex As Exception
        '        MessageBox.Show("Source [" & ex.Source & "] Description  [" & ex.Message & "]")
        '    End Try
    End Sub

    Private Sub customDomainCombo_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles customDomainCombo.DropDown
        customDomainCombo.Items.Clear()
        customDomainCombo.Items.Add(" (Add New...)")
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If Not rk Is Nothing Then
                Dim dominfo() As String = Split(rk, ";")
                customDomainCombo.Items.Add(dominfo(0))
            End If
        Next
    End Sub
    Private Sub customDomainCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customDomainCombo.SelectedIndexChanged
        If customDomainCombo.Text = " (Add New...)" Then
            Dim di As New AddDomainInfo
            di.ShowDialog()

            Me.customDomainCombo.Items.Clear()
            Me.customDomainCombo.Items.AddRange(New Object() {" (edit custom domains)"})
            Me.customDomainCombo.SelectedIndex = 0

        Else
            For i As Integer = 0 To 9
                Dim valuename As String = "Domain" & CStr(i)
                Dim rk As String = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
                If Not rk Is Nothing Then
                    Dim dominfo() As String = Split(rk, ";")
                    If dominfo(0).ToUpper = customDomainCombo.Text.ToUpper Then

                        Dim di As New AddDomainInfo
                        di.OK_Button.Text = "Save"

                        Dim user As String = dominfo(3)
                        If Not String.IsNullOrEmpty(user) Then user = Encryption.DecryptText(user)
                        Dim pass As String = dominfo(4)
                        If Not String.IsNullOrEmpty(pass) Then pass = Encryption.DecryptText(pass)

                        di.txtDomain.Text = dominfo(0)
                        di.txtDNS.Text = dominfo(1)
                        di.txtDC.Text = dominfo(2)
                        di.txtUser.Text = user
                        di.txtPass.Text = pass
                        di.EditMode = True
                        di.ShowDialog()
                        'di.EditMode = False
                    End If
                End If
            Next
        End If
        Me.domainList.Rows.Clear()
        Me.DomainSelect.Items.Clear()
        Me.LoadDomains()
    End Sub

    ''' <summary>
    ''' Code to handle resizing form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ADmgmt_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        ' column width ratio - maintain
        Dim firstcolumnratio As Double = Me.SearchResultsDGV.Columns(0).Width / Me.SearchResultsDGV.Width

        Me.gbSearch.Width = Me.SearchPanel.Width - 20
        Me.gbSearch.Height = Me.SearchPanel.Height - 20
        Me.SearchResultsDGV.Width = Me.SearchPanel.Width - 60
        Me.SearchResultsDGV.Height = Me.SearchPanel.Height - 76

        Me.SearchResultsDGV.Columns(0).Width = Me.SearchResultsDGV.Width * firstcolumnratio '0.4
        Me.SearchResultsDGV.Columns(1).Width = Me.SearchResultsDGV.Width * 1 - firstcolumnratio '0.6
    End Sub

#Region "Tab management"

    ' Select tab according to search type selected
    Private Sub SearchTypeCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTypeCombo.SelectedIndexChanged

        'Me.UserTabs_Clear()
        Me.btnSave.Enabled = False
        'Me.SearchResultsDGV.Rows.Clear()

        '' members context menu
        'MemberRefreshMenu.Enabled = False
        'MemberExportMenu.Enabled = False
        'MemberAddMenu.Enabled = False
        'Me.btnAdd.Enabled = False

        Select Case Me.SearchTypeCombo.Text
            Case "Users"
                Me.PictureBox1.Image = Global.ADmgmt.My.Resources.Resources.user_16x16
                'ShowTabPage(tabAccount)
                'ShowTabPage(tabMemberOf)
                'ShowTabPage(tabProfile)
                'ShowTabPage(tabCustom)
                Me.adTabControl.SelectTab(tabAccount)
                'HideTabPage(tabGroupMembers)
                Me.SearchResultsDGV.Columns(0).Width = 140
            Case "Groups"
                Me.PictureBox1.Image = Global.ADmgmt.My.Resources.Resources.user_group_16x16
                'ShowTabPage(tabGroupMembers)
                'Me.adTabControl.SelectTab(tabGroupMembers)
                'HideTabPage(tabAccount)
                'HideTabPage(tabMemberOf)
                'HideTabPage(tabProfile)
                'HideTabPage(tabCustom)
                'Me.SearchResultsDGV.Columns(0).Width = 360
                '140,350
        End Select
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Me.SearchResultsDGV.Rows.Clear()
        'UserTabs_Clear()
        Me.AcceptButton = Me.btnSearch
    End Sub

    ' Add/Remove Tab Pages
    Private Sub HideTabPage(ByVal tp As TabPage)
        If Me.adTabControl.TabPages.Contains(tp) Then Me.adTabControl.TabPages.Remove(tp)
    End Sub
    Private Sub ShowTabPage(ByVal tp As TabPage)
        ShowTabPage(tp, Me.adTabControl.TabPages.Count)
    End Sub
    Private Sub ShowTabPage(ByVal tp As TabPage, ByVal index As Integer)
        If Me.adTabControl.TabPages.Contains(tp) Then Return
        InsertTabPage(tp, index)
    End Sub
    Private Sub InsertTabPage(ByVal [tabpage] As TabPage, ByVal [index] As Integer)
        If [index] < 0 Or [index] > Me.adTabControl.TabCount Then
            Throw New ArgumentException("Index out of Range.")
        End If
        Me.adTabControl.TabPages.Add([tabpage])
        If [index] < Me.adTabControl.TabCount - 1 Then
            Do While Me.adTabControl.TabPages.IndexOf([tabpage]) <> [index]
                SwapTabPages([tabpage], (Me.adTabControl.TabPages(Me.adTabControl.TabPages.IndexOf([tabpage]) - 1)))
            Loop
        End If
        Me.adTabControl.SelectedTab = [tabpage]
    End Sub
    Private Sub SwapTabPages(ByVal tp1 As TabPage, ByVal tp2 As TabPage)
        If Me.adTabControl.TabPages.Contains(tp1) = False Or Me.adTabControl.TabPages.Contains(tp2) = False Then
            Throw New ArgumentException("TabPages must be in the TabCotrols TabPageCollection.")
        End If
        Dim Index1 As Integer = Me.adTabControl.TabPages.IndexOf(tp1)
        Dim Index2 As Integer = Me.adTabControl.TabPages.IndexOf(tp2)
        Me.adTabControl.TabPages(Index1) = tp2
        Me.adTabControl.TabPages(Index2) = tp1
    End Sub

#End Region



    ''' <summary>
    ''' Reset a users password.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ResetPasswordMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPasswordMenu.Click
        Dim pwd As New Password
        pwd.Text = "Reset Password: " & SelectedResult
        pwd.ShowDialog()
        If pwd.DialogResult = Windows.Forms.DialogResult.OK Then
            If SetUserPassword(SelectedResult, pwd.NewPassword) Then
                MsgBox("Password set for user: " & SelectedResult, MsgBoxStyle.Information, "AD Manager")
            End If
            If pwd.ForcePwdChange Then
                ForceChangePwd(SelectedResult)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Display Users properties (context menu selection)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PropertiesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PropertiesMenu.Click
        UserTabs_Clear()
        FmGroupMembers.MembersListView.Items.Clear()
        Me.Call_GetDetails()
    End Sub

    ''' <summary>
    ''' Add the current user to another group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddUsertoGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUsertoGroup.Click
        Dim s As New TextEntryDialog
        s.Text = "Group Search"
        s.labelMain.Text = "Enter the group name"
        s.ShowDialog()
        s.txtSearch.Focus()

        If s.DialogResult = Windows.Forms.DialogResult.OK Then

            Dim searchstring As String = s.searchstring

            Dim deSearch As DirectorySearcher = New DirectorySearcher(de)
            deSearch.Filter = "(&(objectClass=group)(anr=" & searchstring & "))"
            deSearch.PropertiesToLoad.Add("distinguishedname")
            Dim results As SearchResultCollection = deSearch.FindAll()

            Dim r As New ResultSelector
            r.Text = "Select Group"
            For Each result As SearchResult In results
                r.ListBox1.Items.Add(GetAttributefromDN("CN", Me.GetProperty(result, "distinguishedname")))
            Next
            If r.ListBox1.Items.Count = 1 Then
                r.ListBox1.SelectedIndex = 0
            End If

            r.ShowDialog()
            If r.DialogResult = Windows.Forms.DialogResult.OK Then

                ' get directory entry for user
                Dim UserSearch As DirectorySearcher = New DirectorySearcher(de)
                UserSearch.Filter = "(&(objectClass=user)(objectCategory=person)(samaccountname=" & Me.txtSAM.Text & "))"
                UserSearch.PropertiesToLoad.Add("Path")
                Dim userresult As SearchResultCollection = UserSearch.FindAll()
                Dim user As New DirectoryEntry(userresult(0).Path)

                ' Call sub to add user to group
                Me.AddUserToGroup(de, user, r.SelectedResult)

                ' reload groups
                lbMemberOf.Items.Clear()
                lbMemberOf.Items.Add("Domain Users")
                For Each gp As String In GetGroups(Me.txtSAM.Text)
                    lbMemberOf.Items.Add(gp)
                Next

            End If
        End If
    End Sub

    ''' <summary>
    ''' Remove the current user from selected group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRemoveUserfromGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveUserfromGroup.Click

        Me.btnRemoveUserfromGroup.Enabled = False

        Dim UserSearch As DirectorySearcher = New DirectorySearcher(de)
        UserSearch.Filter = "(&(objectClass=user)(objectCategory=person)(samaccountname=" & Me.txtSAM.Text & "))"
        UserSearch.PropertiesToLoad.Add("Path")
        Dim userresult As SearchResultCollection = UserSearch.FindAll()
        Dim user As New DirectoryEntry(userresult(0).Path)

        ' call removefromgroup sub
        Me.RemoveUserFromGroup(de, user, Me.lbMemberOf.SelectedItem.ToString)

        ' reload groups
        lbMemberOf.Items.Clear()
        lbMemberOf.Items.Add("Domain Users")
        For Each gp As String In GetGroups(Me.txtSAM.Text)
            lbMemberOf.Items.Add(gp)
        Next

    End Sub

    Private Sub lbMemberOf_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbMemberOf.DoubleClick
        If Not Me.lbMemberOf.SelectedItem Is Nothing Then
            FmGroupMembers.Text = CurrentGroupName
            FmGroupMembers.MembersListView.Items.Clear()
            FmGroupMembers.GroupName = CurrentGroupName

            FmGroupMembers.Loading = True
            Dim loader As New System.Threading.Thread(AddressOf FmGroupMembers.DoWhileLoading)
            loader.Start()
            GroupMembers(CurrentGroupName, FmGroupMembers.MembersListView)
            FmGroupMembers.Loading = False

            If FmGroupMembers.Visible = False Then
                FmGroupMembers.Loading = False
                FmGroupMembers.Show()
            End If
        End If
    End Sub
    ''' <summary>
    ''' enable/disable Remove (current user from selected group) button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub lbMemberOf_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbMemberOf.SelectedIndexChanged
        CurrentGroupName = Me.lbMemberOf.SelectedItem
        If Not Me.lbMemberOf.SelectedItem Is Nothing Then
            btnRemoveUserfromGroup.Enabled = True
        Else
            btnRemoveUserfromGroup.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Add a new user to current group
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddUserCall()
    End Sub
    Protected Friend Sub AddUserCall()
        Dim s As New TextEntryDialog
        s.Text = "Group Search"
        s.labelMain.Text = "Search for user:"
        s.ShowDialog()
        s.txtSearch.Focus()

        If s.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim searchstring As String = s.searchstring
            Dim deSearch As DirectorySearcher = New DirectorySearcher(de)
            deSearch.Filter = "(&(anr=" & searchstring & ")(|(objectClass=user)(objectClass=group)))"  '"(&(objectClass=user)(objectCategory=person)(anr=" & searchstring & "))"
            deSearch.PropertiesToLoad.Add("distinguishedname")
            Dim results As SearchResultCollection = deSearch.FindAll()

            Dim r As New ResultSelector
            r.Text = "Select Group"
            For Each result As SearchResult In results
                r.ListBox1.Items.Add(GetAttributefromDN("samaccountname", Me.GetProperty(result, "distinguishedname")))
            Next
            If r.ListBox1.Items.Count = 1 Then
                r.ListBox1.SelectedIndex = 0
            End If

            r.ShowDialog()
            If r.DialogResult = Windows.Forms.DialogResult.OK Then

                If r.SelectedResult.ToLower = CurrentGroupName.ToLower Then
                    ' has selected the group that we are trying to add to
                    MsgBox("Cannot add a group to itself", MsgBoxStyle.Critical, "Numpty Alert")
                    Exit Sub
                End If

                ' Get user as DirectoryEntry
                Dim UserSearch As DirectorySearcher = New DirectorySearcher(de)
                UserSearch.Filter = "(samaccountname=" & r.SelectedResult & ")" '  "(&(objectClass=user)(objectCategory=person)(samaccountname=" & r.SelectedResult & "))"
                UserSearch.PropertiesToLoad.Add("Path")
                Dim userresult As SearchResultCollection = UserSearch.FindAll()
                Dim user As New DirectoryEntry(userresult(0).Path)

                ' Call sub to add user to group
                Me.AddUserToGroup(de, user, CurrentGroupName)

                RefreshMembersListView()

            End If
        End If
    End Sub

    ''' <summary>
    ''' Remove selected users (UserList) from current group.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>removes all users in userlist</remarks>
    Private Sub btnRemoveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RemoveUserCall()
    End Sub
    Protected Friend Sub RemoveUserCall()
        If UserList.Count = 0 Then Return
        For i As Integer = 0 To UserList.Count - 1
            Dim username As String = UserList.Item(i)
            If Not String.IsNullOrEmpty(username) Then
                ' Get user as DirectoryEntry
                Dim UserSearch As DirectorySearcher = New DirectorySearcher(de)
                UserSearch.Filter = "(samaccountname=" & username & ")" ' (&(objectClass=user)(objectCategory=person)())
                UserSearch.PropertiesToLoad.Add("Path")
                Dim userresult As SearchResultCollection = UserSearch.FindAll()
                Dim user As New DirectoryEntry(userresult(0).Path)

                Me.RemoveUserFromGroup(de, user, CurrentGroupName)
            End If
        Next
        RefreshMembersListView()
    End Sub


    Protected Friend UserList As ArrayList

    ''' <summary>
    ''' Add selected users to UserList array
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MembersListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UserList = New ArrayList
        For Each member As ListViewItem In FmGroupMembers.MembersListView.SelectedItems
            UserList.Add(member.SubItems(0).Text)
        Next
        UserList.Sort()

        If UserList.Count = 0 Then
            Me.MemberRemoveMenu.Enabled = False
            'Me.btnRemoveUser.Enabled = False
        ElseIf UserList.Count = 1 Then
            If FmGroupMembers.MembersListView.SelectedItems(0).ImageIndex = 0 Then
                ' "user"
                Me.MemberRemoveMenu.Text = "Remove user..."
            Else
                ' "group"
                Me.MemberRemoveMenu.Text = "Remove sub group..."
            End If
            Me.MemberRemoveMenu.Enabled = True
            'Me.btnRemoveUser.Enabled = True
        ElseIf UserList.Count > 1 Then
            Me.MemberRemoveMenu.Text = "Remove members..."
            Me.MemberRemoveMenu.Enabled = True
            'Me.btnRemoveUser.Enabled = True
        End If
    End Sub


    Private Sub RefreshMembersListView()

        FmGroupMembers.Text = CurrentGroupName
        FmGroupMembers.MembersListView.Items.Clear()
        FmGroupMembers.GroupName = CurrentGroupName
        GroupMembers(CurrentGroupName, FmGroupMembers.MembersListView)
        FmGroupMembers.Show()

    End Sub

    Private Sub txtTSHomeFolder_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTSHomeFolder.MouseDoubleClick
        Try
            System.Diagnostics.Process.Start(txtTSHomeFolder.Text)
        Catch ex As Exception
            Panel2.Text = "unable to open folder"
        End Try
    End Sub
    Private Sub txtTSProfile_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtTSProfile.MouseDoubleClick
        Try
            System.Diagnostics.Process.Start(txtTSProfile.Text)
        Catch ex As Exception
            Panel2.Text = "unable to open folder"
        End Try
    End Sub
    Private Sub txtHomeProfile_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHomeProfile.MouseDoubleClick
        Try
            System.Diagnostics.Process.Start(txtHomeProfile.Text)
        Catch ex As Exception
            Panel2.Text = "unable to open folder"
        End Try
    End Sub
    Private Sub txtHomeFolder_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtHomeFolder.MouseDoubleClick
        Try
            System.Diagnostics.Process.Start(txtHomeFolder.Text)
        Catch ex As Exception
            Panel2.Text = "unable to open folder"
        End Try
    End Sub



    ' group context menu items
    Private Sub AddUserMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberAddMenu.Click
        AddUserCall()
    End Sub
    Private Sub RemoveUserMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberRemoveMenu.Click
        RemoveUserCall()
    End Sub
    Private Sub RefreshMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberRefreshMenu.Click
        RefreshMembersListView()
    End Sub
    Private Sub ExportToolItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemberExportMenu.Click
        ExportToCSV()
    End Sub

    Private UserPanelVisible As Boolean
    Private Sub txtSAM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSAM.TextChanged

        Me.adTabControl.SelectedIndex = 0

        Dim StartHeight As Integer = Me.Height

        If String.IsNullOrEmpty(Me.txtSAM.Text) AndAlso UserPanelVisible = True Then
            Me.UserPanelVisible = False
            Me.MinimumSize = New System.Drawing.Size(426, 260)
            Panel2.Size = New System.Drawing.Size(410, 0) '410, 320
            Me.Size = New System.Drawing.Size(426, StartHeight - 320) '426, 584
        ElseIf Not String.IsNullOrEmpty(Me.txtSAM.Text) AndAlso UserPanelVisible = False Then
            Me.UserPanelVisible = True
            Me.MinimumSize = New System.Drawing.Size(426, 580)
            Panel2.Size = New System.Drawing.Size(410, 320) '410, 320
            Me.Size = New System.Drawing.Size(426, StartHeight + 320) '426, 584
        End If

    End Sub
End Class

