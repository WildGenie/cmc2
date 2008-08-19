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
    Private _ADUsername As String
    Private _ADPassword As String

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
            ' MsgBox("adding " & domainname.ToUpper)
            domainList.Rows.Add(domainname.ToUpper, domaindnsname, "", "", "")
            'Else
            'MsgBox("not adding " & domainname.ToUpper)
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

        If Not Me.DomainSelect.Text = " - Select Domain - " Then

            ' Find matching datarow for selected domain
            For Each row As DataRow In domainList.Rows
                If row(0).ToString.ToUpper = Me.DomainSelect.Text Then
                    Dim strDC As String = String.Empty
                    Dim aDsPath As String = "dc=" & row(1).ToString.Replace(".", ",dc=")
                    If Not String.IsNullOrEmpty(row(2).ToString) Then strDC = row(2).ToString & "/"
                    Me._LDAPPath = "LDAP://" & strDC & aDsPath
                    Me._ADUsername = row(3)
                    Me._ADPassword = CStr(row(4))
                    If String.IsNullOrEmpty(Me._ADUsername) Then
                        Me._ADUsername = Nothing
                        Me._ADPassword = Nothing
                    End If
                    lbldomain.Text = Me._LDAPPath
                End If
            Next

            ' Remove "Select Domain" prompt and enable searching.
            If Me.DomainSelect.Items(0) = " - Select Domain - " Then
                Me.DomainSelect.Items.RemoveAt(0)
                Me.gbSearch.Enabled = True
                Me.adTabControl.Enabled = True
            End If

        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Me.SearchResults.Items.Clear()

        If Me.radioUsers.Checked Then
            SearchUser()
        ElseIf Me.radioGroups.Checked Then
            SearchGroup()
        End If

    End Sub

    Private Sub SearchResults_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchResults.SelectedIndexChanged

        UserTabs_Clear()

        GetUserDetails(Me.SearchResults.SelectedItem.ToString)

        'Dim ad As New AD
        'Using DirSearch As New DirectorySearcher(ad.GetDirectoryEntry(Me._LDAPPath, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure))
        '    With DirSearch
        '        .PropertiesToLoad.Add("distinguishedName")
        '        .PropertiesToLoad.Add("displayName")
        '        .PropertiesToLoad.Add("sAMAccountName")
        '        .Filter = "(&(objectClass=user)(objectCategory=person)(anr=" & Me.txtSearch.Text & "))"
        '    End With
        '    Dim RecordCount As Integer = 0
        '    For Each sResultSet As SearchResult In DirSearch.FindAll()
        '        Me.SearchResults.Items.Add(Me.GetProperty(sResultSet, "sAMAccountName"))
        '    Next
        'End Using
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
    End Sub

    ''' <summary>
    ''' Return list of users from ANR user query.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SearchUser()

        Dim ad As New AD
        Using DirSearch As New DirectorySearcher(ad.GetDirectoryEntry(Me._LDAPPath, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure))

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
        Dim ad As New AD
        Using DirSearch As New DirectorySearcher(ad.GetDirectoryEntry(Me._LDAPPath, Me._ADUsername, Me._ADPassword, AuthenticationTypes.Secure))

            With DirSearch
                '.PropertiesToLoad.Add("distinguishedName")
                '.PropertiesToLoad.Add("displayName")
                .PropertiesToLoad.Add("CN")

                .Filter = "(&(objectClass=group)(anr=" & Me.txtSearch.Text & "))"
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

        Dim entry As New DirectoryServices.DirectoryEntry(Me._LDAPPath)
        Dim Searcher As New System.DirectoryServices.DirectorySearcher(entry)
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
    ''' Method used to create an entry to the AD.
    ''' </summary>
    ''' <returns> A DirectoryEntry </returns>
    ''' <remarks></remarks>
    Public Shared Function GetDirectoryEntry() As DirectoryEntry
        Dim dirEntry As DirectoryEntry = New DirectoryEntry()
        dirEntry.Path = "LDAP://192.168.1.1/CN=Users;DC=Yourdomain"
        dirEntry.Username = "yourdomain\sampleuser"
        dirEntry.Password = "samplepassword"
        Return dirEntry
    End Function

    ''' <summary>
    ''' Helper method that sets properties for AD users.
    ''' </summary>
    ''' <param name="de">DirectoryEntry to use</param>
    ''' <param name="pName">Property name to set</param>
    ''' <param name="pValue">Value of property to set</param>
    Public Shared Sub SetADProperty(ByVal de As DirectoryEntry, ByVal pName As String, ByVal pValue As String)
        'First make sure the property value isnt "nothing"
        If Not pValue Is Nothing Then
            'Check to see if the DirectoryEntry contains this property already
            If de.Properties.Contains(pName) Then 'The DE contains this property
                'Update the properties value
                de.Properties(pName)(0) = pValue
            Else    'Property doesnt exist
                'Add the property and set it's value
                de.Properties(pName).Add(pValue)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Method to set a user's password
    ''' </summary>
    ''' <param name="dEntry">DirectoryEntry to use</param>
    ''' <param name="sPassword">Password for the new user</param>
    Private Shared Sub SetPassword(ByVal dEntry As DirectoryEntry, ByVal sPassword As String)
        Dim oPassword As Object() = New Object() {sPassword}
        Dim ret As Object = dEntry.Invoke("SetPassword", oPassword)
        dEntry.CommitChanges()
    End Sub

    ''' <summary>
    ''' Method to enable a user account in the AD.
    ''' </summary>
    ''' <param name="de"></param>
    Private Shared Sub EnableAccount(ByVal de As DirectoryEntry)
        'UF_DONT_EXPIRE_PASSWD 0x10000
        Dim exp As Integer = CInt(de.Properties("userAccountControl").Value)
        de.Properties("userAccountControl").Value = exp Or &H1
        de.CommitChanges()
        'UF_ACCOUNTDISABLE 0x0002
        Dim val As Integer = CInt(de.Properties("userAccountControl").Value)
        de.Properties("userAccountControl").Value = val And Not &H2
        de.CommitChanges()
    End Sub

    ''' <summary>
    ''' Method to add a user to a group
    ''' </summary>
    ''' <param name="de">DirectoryEntry to use</param>
    ''' <param name="deUser">User DirectoryEntry to use</param>
    ''' <param name="GroupName">Group Name to add user to</param>
    Public Shared Sub AddUserToGroup(ByVal de As DirectoryEntry, _
    ByVal deUser As DirectoryEntry, ByVal GroupName As String)
        Dim deSearch As DirectorySearcher = New DirectorySearcher()
        deSearch.SearchRoot = de
        deSearch.Filter = "(&(objectClass=group) (cn=" & GroupName & "))"
        Dim results As SearchResultCollection = deSearch.FindAll()
        Dim isGroupMember As Boolean = False
        If results.Count > 0 Then
            Dim group As New DirectoryEntry(results(0).Path)
            Dim members As Object = group.Invoke("Members", Nothing)
            For Each member As Object In CType(members, IEnumerable)
                Dim x As DirectoryEntry = New DirectoryEntry(member)
                Dim name As String = x.Name
                If name <> deUser.Name Then
                    isGroupMember = False
                Else
                    isGroupMember = True
                    Exit For
                End If
            Next member
            If (Not isGroupMember) Then
                group.Invoke("Add", New Object() {deUser.Path.ToString()})
            End If
            group.Close()
        End If
        Return
    End Sub

    ''' <summary>
    ''' Method that disables a user account in the AD 
    ''' and hides user's email from Exchange address lists.
    ''' </summary>
    ''' <param name="sLogin">Login of the user to disable</param>
    Public Sub DisableAccount(ByVal sLogin As String)
        ''   1. Search the Active Directory for the desired user
        'Dim dirEntry As DirectoryEntry = GetDirectoryEntry()
        'Dim dirSearcher As DirectorySearcher = New DirectorySearcher(dirEntry)
        'dirSearcher.Filter = "(&(objectCategory=Person)(objectClass=user)(SAMAccountName=" & sLogin & "))"
        'dirSearcher.SearchScope = SearchScope.Subtree
        'Dim results As SearchResult = dirSearcher.FindOne()
        ''   2. Check returned results
        'If Not results Is Nothing Then
        '    '   2a. User was returned
        '    Dim dirEntryResults As DirectoryEntry = GetDirectoryEntry(results.Path)
        '    Dim iVal As Integer = _
        '        CInt(dirEntryResults.Properties("userAccountControl").Value)
        '    '   3. Disable the users account
        '    dirEntryResults.Properties("userAccountControl").Value = iVal Or &H2
        '    '   4. Hide users email from all Exchange Mailing Lists
        '    dirEntryResults.Properties("msExchHideFromAddressLists").Value = "TRUE"
        '    dirEntryResults.CommitChanges()
        '    dirEntryResults.Close()
        'End If
        'dirEntry.Close()
    End Sub

    ''' <summary>
    ''' Method that updates user's properties
    ''' </summary>
    ''' <param name="userLogin">Login of the user to update</param>
    ''' <param name="userDepartment">New department of the specified user</param>
    ''' <param name="userTitle">New title of the specified user</param>
    ''' <param name="userPhoneExt">New phone extension of the specified user</param>
    Public Sub UpdateUserADAccount(ByVal userLogin As String, ByVal userDepartment As String, ByVal userTitle As String, ByVal userPhoneExt As String)
        'Dim dirEntry As DirectoryEntry = GetDirectoryEntry()
        'Dim dirSearcher As DirectorySearcher = New DirectorySearcher(dirEntry)
        '   1. Search the Active Directory for the speied user
        'dirSearcher.Filter = "(&(objectCategory=Person)(objectClass=user)(sAMAccountName=" & userLogin & "))"
        'dirSearcher.SearchScope = SearchScope.Subtree
        'Dim searchResults As SearchResult = dirSearcher.FindOne()
        'If Not searchResults Is Nothing Then
        '    Dim dirEntryResults As New DirectoryEntry(searchResults.Path)
        '    The properties listed here may be different then the 
        '    properties in your Active Directory so they may need to be 
        '    changed according to your network
        '       2. Set the new property values for the specified user
        '    SetProperty(dirEntryResults, "department", userDepartment)
        '    SetProperty(dirEntryResults, "title", userTitle)
        '    SetProperty(dirEntryResults, "phone", userPhoneExt)
        '       3. Commit the changes
        '    dirEntryResults.CommitChanges()
        '       4. Close & Cleanup
        '    dirEntryResults.Close()
        'End If

        '   Close & Cleanup
        'dirEntry.Close()
    End Sub

    ''' <summary>
    ''' Function to return all the groups the user is a member od
    ''' </summary>
    ''' <param name="_path">Path to bind to the AD</param>
    ''' <param name="username">Username of the user</param>
    ''' <param name="password">password of the user</param>
    Private Function GetGroups(ByVal _path As String, ByVal username As String, _
                     ByVal password As String) As Collection
        Dim Groups As New Collection
        Dim dirEntry As New _
            System.DirectoryServices.DirectoryEntry(_path, username, password)
        Dim dirSearcher As New DirectorySearcher(dirEntry)
        dirSearcher.Filter = String.Format("(sAMAccountName={0}))", username)
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

    'Private Shared Function GetDirectoryObject(byval domainReference as string,ByVal UserName As String, ByVal Password As String) As DirectoryEntry
    'Dim oDE As DirectoryEntry

    'oDE = New DirectoryEntry(ADFullPath + DomainReference, UserName, Password, AuthenticationTypes.Secure)

    'Return oDE
    'End Function


    'Private Shared Function GetLDAPDomain() As String

    '    Dim LDAPDomain As New Text.StringBuilder()
    '    Dim LDAPDC As String() = ADServer.Split("."c)
    '    For i As Integer = 0 To LDAPDC.GetUpperBound(0)

    '        LDAPDomain.Append("DC=" + LDAPDC(i))
    '        If i < LDAPDC.GetUpperBound(0) Then
    '            LDAPDomain.Append(",")
    '        End If
    '    Next

    '    Return LDAPDomain.ToString()
    'End Function


    Private Sub radioUsers_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioUsers.CheckedChanged
        'Me.adTabControl.T()
    End Sub


    Private Sub btnExit_Clicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.UserTabs_Clear()
        Me.txtSearch.Text = ""
        Me.SearchResults.Items.Clear()
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
