Imports System
Imports System.DirectoryServices
Imports system.directoryservices.ActiveDirectory
Imports System.Data
' for authentication class
Imports System.Text
Imports System.Collections



Public Class ADmgmt

    Private domainList As New DataTable()
    Private _LDAPPath As String
    Private _LDAPHeader As String
    Private _ADUsername As String
    Private _ADPassword As String
    Private de As DirectoryEntry

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
    Public Enum LoginResult
        LOGIN_OK = 0
        LOGIN_USER_DOESNT_EXIST
        LOGIN_USER_ACCOUNT_INACTIVE
    End Enum


    Private Sub ADmgmt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDomains()
    End Sub
    Public Sub LoadDomains()

        domainList.Columns.Add(New DataColumn("NetBIOSName", GetType(String)))
        domainList.Columns.Add(New DataColumn("DnsName", GetType(String)))
        domainList.Columns.Add(New DataColumn("DomainController", GetType(String)))
        domainList.Columns.Add(New DataColumn("UserName", GetType(String)))
        domainList.Columns.Add(New DataColumn("Password", GetType(String)))


        ' add custom domains to DomainList dataset
        Dim di As New CustomDomainInfo
        Dim ca(,) As String = di.GetCustomDomains
        For i As Integer = 0 To ca.Length / 5 - 1
            domainList.Rows.Add(ca(i, 0), ca(i, 1), ca(i, 2), ca(i, 3), ca(i, 4))
        Next

        ' Get local domain
        Dim domainname As String = String.Empty
        Dim domaindnsname As String = String.Empty

        Dim usr As New cmcUser
        domainname = usr.userdomain
        domaindnsname = usr.dnsdomain
        If domainname = "no domain found" Then domainname = String.Empty

        'Dim objSearcher As New Management.ManagementObjectSearcher("SELECT Name,DnsForestName FROM Win32_NTDomain")
        'Dim objDomain As Management.ManagementObject
        'For Each objDomain In objSearcher.Get()
        '    domainname = objDomain("Name").ToString().ToUpper.Replace("DOMAIN: ", "")
        '    domaindnsname = CStr(objDomain("DnsForestName"))
        'Next objDomain

        'MsgBox(domainname & vbCr & domaindnsname)

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


        '' Set domainList datatable as source for domain selection combo
        'Me.DomainSelect.DataSource = domainList
        'Me.DomainSelect.DisplayMember = "NetBIOSName"
        ''Me.DomainSelect.ValueMember = "DnsName"

        Me.DomainSelect.Items.Add(" - Select Domain - ")
        For Each row As DataRow In domainList.Rows
            Me.DomainSelect.Items.Add(row(0))
        Next
        Me.DomainSelect.SelectedIndex = 0

    End Sub

    Private Sub DomainSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomainSelect.SelectedIndexChanged

        Me.UserTabs_Clear()
        Me.SearchResults.Items.Clear()

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
                    'lbldomain.Text = Me._LDAPPath
                    de = GetDirectoryEntry(Me._LDAPPath, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure)
                End If
            Next

            ' Remove "Select Domain" prompt and enable searching.
            If Me.DomainSelect.Items(0) = " - Select Domain - " Then
                Me.DomainSelect.Items.RemoveAt(0)
                Me.gbSearch.Enabled = True
                Me.adTabControl.Enabled = True
            End If

        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.Cursor = Cursors.AppStarting
        If String.IsNullOrEmpty(Me.txtSearch.Text) Then Return
        Me.SearchResults.Items.Clear()

        If Me.radioUsers.Checked Then
            SearchUser()
        ElseIf Me.radioGroups.Checked Then
            SearchGroup()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SearchResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchResults.SelectedIndexChanged

        UserTabs_Clear()
        Me.listBoxMembers.Items.Clear()

        If Me.radioUsers.Checked Then
            GetUserDetails(Me.SearchResults.SelectedItem.ToString)
        ElseIf Me.radioGroups.Checked Then
            If Not Me.SearchResults.SelectedItem Is Nothing Then
                Me.lblGroupName.Text = Me.SearchResults.SelectedItem.ToString

                ' return selected user attribute for each group member
                If String.IsNullOrEmpty(Me.comboGroupUserProperty.Text) Then
                    GroupMembers(Me.SearchResults.SelectedItem.ToString, "samaccountname")
                Else
                    GroupMembers(Me.SearchResults.SelectedItem.ToString, Me.comboGroupUserProperty.Text)
                End If

                ' enable export button
                If Me.listBoxMembers.Items.Count > 1 Then
                    Me.btnExportUsers.Enabled = True
                Else
                    Me.btnExportUsers.Enabled = False
                End If

            End If

        End If

    End Sub

    Private Sub UserTabs_Clear()
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

        Me.lbMemberOf.Items.Clear()

        Me.lblGroupName.Text = String.Empty
        Me.listBoxMembers.Items.Clear()
        Me.btnExportUsers.Enabled = False
    End Sub

    ''' <summary>
    ''' Return list of users from ANR user query.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SearchUser()

        Using DirSearch As New DirectorySearcher(de) 'GetDirectoryEntry(Me._LDAPPath, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure))

            With DirSearch
                '.PropertiesToLoad.Add("distinguishedName")
                '.PropertiesToLoad.Add("displayName")
                .PropertiesToLoad.Add("sAMAccountName")
                .Filter = "(&(objectClass=user)(objectCategory=person)(anr=" & Me.txtSearch.Text & "))"
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
                Me.SearchResults.Items.Add(Me.GetProperty(sResultSet, "sAMAccountName"))
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
                Me.SearchResults.Items.Add(Me.GetProperty(sResultSet, "CN"))
            Next

        End Using

    End Sub

    ''' <summary>
    ''' Fill form with selected users attributes.
    ''' </summary>
    ''' <param name="sAccountName"></param>
    ''' <remarks></remarks>
    Private Sub GetUserDetails(ByVal sAccountName As String)

        'Dim entry As New DirectoryServices.DirectoryEntry(Me._LDAPPath)
        Dim Searcher As New System.DirectoryServices.DirectorySearcher(de) 'entry)
        Dim result As System.DirectoryServices.SearchResult
        Searcher.Filter = "(sAMAccountName= " & sAccountName & ")"

        result = Searcher.FindOne

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

        Me.txtHomeProfile.Text = Me.GetProperty(result, "profilePath")
        Me.txtHomeFolder.Text = Me.GetProperty(result, "homeDirectory")
        Me.txtHomeDrive.Text = Me.GetProperty(result, "homeDrive")

        'http://msdn.microsoft.com/en-us/library/aa380823.aspx

        For Each gp As String In GetGroups(sAccountName)
            lbMemberOf.Items.Add(gp)
        Next

    End Sub

    Private Function GetAttributefromDN(ByVal attributeToReturn As String, ByVal dsPath As String) As String
        Try
            Dim Searcher As New System.DirectoryServices.DirectorySearcher(de) 'entry)
            Dim result As System.DirectoryServices.SearchResult
            Searcher.Filter = "(distinguishedName= " & dsPath & ")"
            result = Searcher.FindOne
            Return Me.GetProperty(result, attributeToReturn)
        Catch ex As Exception
            Return dsPath.Substring(3, dsPath.IndexOf(",") - 3)
        End Try
    End Function

    Private Sub GroupMembers(ByVal groupName As String, ByVal attribute As String)
        ' To see the members in a group, you actually need to look at
        ' the member attribute of a group object, not its children as
        ' groups aren't container objects in AD (only containers have children). 

        Dim ldapPath As String

        Using DirSearch As New DirectorySearcher(de)

            DirSearch.PropertiesToLoad.Add("distinguishedName")
            DirSearch.Filter = "(&(objectClass=group)(CN=" & groupName & "))"
            Dim result As System.DirectoryServices.SearchResult = DirSearch.FindOne()
            ldapPath = Me.GetProperty(result, "distinguishedName")

        End Using

        Dim myGroup As DirectoryEntry
        'instanciate myGroup to a valid group object in AD using its distinguished name.... 
        myGroup = New DirectoryEntry(Me._LDAPHeader & ldapPath)
        Dim members As PropertyValueCollection
        members = myGroup.Properties("member")
        Dim member As Object
        For Each member In members
            'Me.listBoxMembers.Items.Add(member.ToString)
            Dim val As String = GetAttributefromDN(attribute, member.ToString)
            If Not String.IsNullOrEmpty(val) Then Me.listBoxMembers.Items.Add(val)
        Next

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

            ' Commit the changes
            dirEntryResults.CommitChanges()
            dirEntryResults.Close()
        End If

    End Sub

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

    ''' <summary>
    ''' Method to set a user's password
    ''' </summary>
    ''' <param name="entry">DirectoryEntry to use</param>
    ''' <param name="sPassword">Password for the new user</param>
    Private Shared Sub SetPassword(ByVal Entry As DirectoryEntry, ByVal sPassword As String)
        Dim oPassword As Object() = New Object() {sPassword}
        Dim ret As Object = Entry.Invoke("SetPassword", oPassword)
        Entry.CommitChanges()
    End Sub

    ''' <summary>
    ''' Method to enable a user account in the AD.
    ''' </summary>
    ''' <param name="entry"></param>
    Private Sub Enable_Account(ByVal entry As DirectoryEntry)
        'UF_DONT_EXPIRE_PASSWD 0x10000
        Dim exp As Integer = CInt(de.Properties("userAccountControl").Value)
        entry.Properties("userAccountControl").Value = exp Or &H1
        entry.CommitChanges()
        'UF_ACCOUNTDISABLE 0x0002
        Dim val As Integer = CInt(de.Properties("userAccountControl").Value)
        entry.Properties("userAccountControl").Value = val And Not &H2
        entry.CommitChanges()
    End Sub

    ''' <summary>
    ''' Method to add a user to a group
    ''' </summary>
    ''' <param name="entry">DirectoryEntry to use</param>
    ''' <param name="deUser">User DirectoryEntry to use</param>
    ''' <param name="GroupName">Group Name to add user to</param>
    Public Shared Sub AddUserToGroup(ByVal entry As DirectoryEntry, _
                                     ByVal deUser As DirectoryEntry, _
                                     ByVal GroupName As String)

        Dim deSearch As DirectorySearcher = New DirectorySearcher()
        deSearch.SearchRoot = entry
        deSearch.Filter = "(&(objectClass=group) (cn=" & GroupName & "))"
        Dim results As SearchResultCollection = deSearch.FindAll()
        Dim isGroupMember As Boolean = False
        If results.Count > 0 Then

            Dim group As New DirectoryEntry(results(0).Path)
            Dim members As Object = group.Invoke("Members", Nothing)
            For Each member As Object In CType(members, IEnumerable)
                Dim x As DirectoryEntry = New DirectoryEntry(member)
                Dim name As String = x.Name
                If name = deUser.Name Then
                    isGroupMember = True
                    Exit For
                End If
            Next

            If (Not isGroupMember) Then
                group.Invoke("Add", New Object() {deUser.Path.ToString()})
            End If
            group.Close()

        End If

    End Sub

    ''' <summary>
    ''' Method that disables a user account in the AD 
    ''' and hides user's email from Exchange address lists.
    ''' </summary>
    ''' <param name="sLogin">Login of the user to disable</param>
    Public Sub DisableAccount(ByVal sLogin As String)

        ' Search the Active Directory for the desired user
        Dim dirSearcher As DirectorySearcher = New DirectorySearcher(de)
        dirSearcher.Filter = "(&(objectCategory=Person)(objectClass=user)(SAMAccountName=" & sLogin & "))"
        dirSearcher.SearchScope = SearchScope.Subtree
        Dim results As SearchResult = dirSearcher.FindOne()

        ' Check returned results
        If Not results Is Nothing Then  ' User was returned
            Dim dirEntryResults As DirectoryEntry = GetDirectoryEntry(results.Path, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure)
            Dim iVal As Integer = CInt(dirEntryResults.Properties("userAccountControl").Value)
            ' Disable the users account
            dirEntryResults.Properties("userAccountControl").Value = iVal Or &H2
            ' Hide users email from all Exchange Mailing Lists
            dirEntryResults.Properties("msExchHideFromAddressLists").Value = "TRUE"
            dirEntryResults.CommitChanges()
            dirEntryResults.Close()
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
            Dim equalsIndex As String
            Dim commaIndex As String
            For i As Integer = 0 To propCount - 1
                dn = dirSearchResults.Properties("memberOf")(i)
                equalsIndex = dn.IndexOf("=", 1)
                commaIndex = dn.IndexOf(",", 1)
                If equalsIndex = -1 Then
                    Return Nothing
                End If
                If Not Groups.Contains(dn.Substring((equalsIndex + 1), _
                                      (commaIndex - equalsIndex) - 1)) Then
                    Groups.Add(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
                End If
            Next
        Catch ex As Exception
            If ex.GetType Is GetType(System.NullReferenceException) Then
                MessageBox.Show("Selected user isn't a member of any groups " & _
                                "at this time.", "No groups listed", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                'they are still a good user just does not
                'have a "memberOf" attribute so it errors out.
                'code to do something else here if you want
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
    Public Shared Function IsAccountActive(ByVal userAccountControl As Integer) As Boolean
        Dim accountDisabled As Integer = Convert.ToInt32(ADAccountOptions.UF_ACCOUNTDISABLE)
        Dim flagExists As Integer = userAccountControl And accountDisabled
        'if a match is found, then the disabled 
        'flag exists within the control flags
        If flagExists > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' This will perform the removal of a user from the specified group
    ''' </summary>
    ''' <param name="UserName">Username of the user to remove</param>
    ''' <param name="GroupName">Groupname to remove them from</param>
    ''' <remarks></remarks>
    Public Shared Sub RemoveUserFromGroup(ByVal UserName As String, ByVal GroupName As String)

        'Dim Domain As New String("")

        ''get reference to group
        'Domain = "/CN=" + GroupName & ",CN=Users," & GetLDAPDomain()
        'Dim oGroup As DirectoryEntry = GetDirectoryObject(Domain)

        ''get reference to user
        'Domain = "/CN=" + UserName + ",CN=Users," + GetLDAPDomain()
        'Dim oUser As DirectoryEntry = GetDirectoryObject(Domain)

        ''Add the user to the group via the invoke method
        'oGroup.Invoke("Remove", New Object() {oUser.Path.ToString()})

        'oGroup.Close()
        'oUser.Close()
    End Sub

    ''' <summary>
    ''' Method to enable a user account.
    ''' </summary>
    ''' <param name="entry"></param>
    Private Shared Sub EnableAccount(ByVal entry As DirectoryEntry)
        'UF_DONT_EXPIRE_PASSWD 0x10000
        Dim exp As Integer = CInt(entry.Properties("userAccountControl").Value)
        entry.Properties("userAccountControl").Value = exp Or &H1
        entry.CommitChanges()
        'UF_ACCOUNTDISABLE 0x0002
        Dim val As Integer = CInt(entry.Properties("userAccountControl").Value)
        entry.Properties("userAccountControl").Value = val And Not &H2
        entry.CommitChanges()
    End Sub

    ''' <summary>
    ''' Method that calls and starts a WSHControl.vbs
    ''' </summary>
    ''' <param name="userAlias"></param>
    Public Sub GenerateMailBox(ByVal userAlias As String)
        Dim mailargs As StringBuilder = New StringBuilder()
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
        Dim mailPattern As RegularExpressions.Regex = New RegularExpressions.Regex("\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")
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
        Dim sb As StringBuilder = New StringBuilder()
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


    'Private Function GetDirectoryObject(ByVal domainReference As String, ByVal UserName As String, ByVal Password As String) As DirectoryEntry
    '    Dim oDE As DirectoryEntry
    '    oDE = New DirectoryEntry(ADFullPath + domainReference, UserName, Password, AuthenticationTypes.Secure)
    '    Return oDE
    'End Function

    'Private Shared Function GetLDAPDomain() As String

    'Dim LDAPDomain As New Text.StringBuilder()
    'Dim LDAPDC As String() = ADServer.Split("."c)
    'For i As Integer = 0 To LDAPDC.GetUpperBound(0)

    '    LDAPDomain.Append("DC=" + LDAPDC(i))
    '    If i < LDAPDC.GetUpperBound(0) Then
    '        LDAPDomain.Append(",")
    '    End If
    'Next

    'Return LDAPDomain.ToString()
    'End Function


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        UpdateUserAccountProperties(Me.txtSAM.Text)
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

    Private Sub btnExit_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.UserTabs_Clear()
        Me.txtSearch.Text = ""
        Me.btnSave.Enabled = False
        Me.SearchResults.Items.Clear()
    End Sub

    ' select tab according to search type selected
    Private Sub radioGroups_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioGroups.CheckedChanged
        Me.SearchResults.Items.Clear()
        If Me.radioGroups.Checked Then
            ShowTabPage(tabGroupMembers)
            Me.adTabControl.SelectTab(tabGroupMembers)
            HideTabPage(tabAccount)
            HideTabPage(tabMemberOf)
            HideTabPage(tabProfile)
            HideTabPage(tabCustom)
        End If
    End Sub
    Private Sub radioUsers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioUsers.CheckedChanged
        If Me.radioUsers.Checked Then
            ShowTabPage(tabAccount)
            ShowTabPage(tabMemberOf)
            ShowTabPage(tabProfile)
            ShowTabPage(tabCustom)
            Me.adTabControl.SelectTab(tabAccount)
            HideTabPage(tabGroupMembers)
        End If
    End Sub
    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Me.SearchResults.Items.Clear()
        UserTabs_Clear()
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

End Class



Public Class LdapAuthentication

    Dim _path As String
    Dim _filterAttribute As String

    Public Sub New(ByVal path As String)
        _path = path
    End Sub

    Public Function IsAuthenticated(ByVal domain As String, ByVal username As String, ByVal pwd As String) As Boolean

        Dim domainAndUsername As String = domain & "\" & username
        Dim entry As DirectoryEntry = New DirectoryEntry(_path, domainAndUsername, pwd)

        Try
            'Bind to the native AdsObject to force authentication.			
            Dim obj As Object = entry.NativeObject
            Dim search As DirectorySearcher = New DirectorySearcher(entry)

            search.Filter = "(SAMAccountName=" & username & ")"
            search.PropertiesToLoad.Add("cn")
            Dim result As SearchResult = search.FindOne()

            If (result Is Nothing) Then
                Return False
            End If

            'Update the new path to the user in the directory.
            _path = result.Path
            _filterAttribute = CType(result.Properties("cn")(0), String)

        Catch ex As Exception
            Throw New Exception("Error authenticating user. " & ex.Message)
        End Try

        Return True
    End Function

    Public Function GetGroups() As String
        Dim search As DirectorySearcher = New DirectorySearcher(_path)
        search.Filter = "(cn=" & _filterAttribute & ")"
        search.PropertiesToLoad.Add("memberOf")
        Dim groupNames As StringBuilder = New StringBuilder()

        Try
            Dim result As SearchResult = search.FindOne()
            Dim propertyCount As Integer = result.Properties("memberOf").Count

            Dim dn As String
            Dim equalsIndex, commaIndex As Integer

            Dim propertyCounter As Integer

            For propertyCounter = 0 To propertyCount - 1
                dn = CType(result.Properties("memberOf")(propertyCounter), String)

                equalsIndex = dn.IndexOf("=", 1)
                commaIndex = dn.IndexOf(",", 1)
                If (equalsIndex = -1) Then
                    Return Nothing
                End If

                groupNames.Append(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
                groupNames.Append("|")
            Next

        Catch ex As Exception
            Throw New Exception("Error obtaining group names. " & ex.Message)
        End Try

        Return groupNames.ToString()
    End Function
End Class
