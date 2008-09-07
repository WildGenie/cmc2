Imports System.Management
Imports System.DirectoryServices
Imports Microsoft.win32
Imports System.Runtime.InteropServices

Module LoggedOn
    Dim objManagementClass As ManagementClass
    Dim objManagementScope As ManagementScope
    Dim objManagementBaseObject As ManagementBaseObject

    Sub Main()

        Dim WMIScope As Management.ManagementScope
        Dim WMIConnectionOptions As New Management.ConnectionOptions
        Dim strRootDomain As String
        Dim objRootLDAP As DirectoryEntry
        Dim query As ManagementObjectSearcher
        Dim queryCollection As ManagementObjectCollection
        Dim oq As New System.Management.ObjectQuery
        Dim mo As New ManagementObject
        Dim UserDomain As String
        Dim UserID As String
        Dim StrLoggedUserSID() As Byte

        Dim Strcomputer As String = My.Application.CommandLineArgs.Item(0)

        With WMIConnectionOptions
            .Impersonation = System.Management.ImpersonationLevel.Impersonate
            .Authentication = System.Management.AuthenticationLevel.Packet
        End With

        WMIScope = New Management.ManagementScope("\\" & _
        Strcomputer & "\root\cimv2", WMIConnectionOptions)

        objRootLDAP = New DirectoryEntry("LDAP://RootDSE")
        strRootDomain = objRootLDAP.Properties.Item("rootDomainNamingContext").Value.ToString

        oq = New System.Management.ObjectQuery("SELECT * from Win32_process Where Name='explorer.exe' and SessionID=0")
        query = New ManagementObjectSearcher(WMIScope, oq)
        queryCollection = query.Get()

        If queryCollection.Count = 0 Then
            Console.WriteLine("No user logged on")
            Exit Sub
        Else

            Dim strKeyPath As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\WinLogon"
            objManagementScope = New ManagementScope
            objManagementScope.Path.Server = Strcomputer
            objManagementScope.Path.NamespacePath = "root\default"
            objManagementScope.Options.EnablePrivileges = True
            objManagementScope.Options.Impersonation = ImpersonationLevel.Impersonate
            objManagementScope.Connect()

            objManagementClass = New ManagementClass("stdRegProv")
            objManagementClass.Scope = objManagementScope
            objManagementBaseObject = objManagementClass.GetMethodParameters("EnumValues")
            objManagementBaseObject.SetPropertyValue("hDefKey", CType("&H" & Hex(RegistryHive.LocalMachine), Long))
            objManagementBaseObject.SetPropertyValue("sSubKeyName", strKeyPath)

            UserDomain = CStr(GetRegValues("DefaultDomainName", strKeyPath, "HKLM"))
            UserID = CStr(GetRegValues("DefaultUserName", strKeyPath, "HKLM"))

            If UCase(UserDomain) = UCase(Strcomputer) Then
                Console.WriteLine("Logged on user = " & UserDomain & "\" & UserID & " (local user)")
                Exit Sub
            End If


            Dim LdapBind As String
            LdapBind = ("LDAP://" & "DC=" & UserDomain & "," & strRootDomain)

            Dim deEntry3 As New DirectoryEntry(LdapBind)
            Dim DSearch As New DirectorySearcher(deEntry3)

            With DSearch
                .SearchScope = SearchScope.Subtree
                .Filter = "(&(objectclass=user)(sAMAccountName=" & UserID & "))"
                .PropertiesToLoad.Add("name")
                .PropertiesToLoad.Add("sAMAccountName")
                .PropertiesToLoad.Add("distinguishedName")
            End With


            Dim sResultSet As SearchResult

            For Each sResultSet In DSearch.FindAll()

                If UCase(GetProperty(sResultSet, "sAMAccountName")) = UCase(UserID) Then

                    Console.WriteLine("Logged on user = " & GetProperty(sResultSet, "name") & " (as " & _
                    UserDomain & "\" & UserID & ")")

                    Dim deEntry4 As New DirectoryEntry("LDAP://" & GetProperty(sResultSet, "distinguishedName").ToString)
                    StrLoggedUserSID = CType(deEntry4.Properties("objectSid").Value, Byte())
                    Console.WriteLine("User's SID = " & ConvertSid(StrLoggedUserSID))
                End If
            Next

        End If
    End Sub

    Public Function GetProperty(ByVal srSearchResult As SearchResult, ByVal strPropertyName As String) As String
        If srSearchResult.Properties.Contains(strPropertyName) Then
            Return srSearchResult.Properties(strPropertyName)(0).ToString()
        Else
            Return String.Empty
        End If
    End Function
    Private Function GetRegValues(ByVal regkeyValue As String, ByVal regkey As String, ByVal Hive As String)

        Select Case Hive
            Case "HKLM"
                Hive = CStr(RegistryHive.LocalMachine)
            Case "HKU"
                Hive = CStr(RegistryHive.Users)
            Case "HKCU"
                Hive = CStr(RegistryHive.CurrentUser)
            Case "HKCR"
                Hive = CStr(RegistryHive.ClassesRoot)
        End Select

        objManagementBaseObject = objManagementClass.GetMethodParameters("GetStringValue")
        objManagementBaseObject.SetPropertyValue("hDefKey", CType("&H" & Hex(Hive), Long))
        objManagementBaseObject.SetPropertyValue("sSubKeyName", regkey)
        objManagementBaseObject.SetPropertyValue("sValueName", regkeyValue)
        objManagementBaseObject = objManagementClass.InvokeMethod("GetStringValue", objManagementBaseObject, Nothing)
        GetRegValues = objManagementBaseObject("sValue")

    End Function

    Public Function ConvertSid(ByVal sid As Byte()) As String

        Dim sidString As String
        Dim sidPtr As IntPtr
        Dim sidStringPtr As IntPtr
        Dim res As Integer

        sidPtr = Marshal.AllocHGlobal(sid.Length)
        Marshal.Copy(sid, 0, sidPtr, sid.Length)
        res = ConvertSidToStringSid(sidPtr, sidStringPtr)
        If res = 0 Then
            Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())
        End If
        sidString = Marshal.PtrToStringAuto(sidStringPtr)
        Marshal.FreeHGlobal(sidPtr)
        Marshal.FreeHGlobal(sidStringPtr)

        Return sidString

    End Function

    <DllImport("advapi32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Private Function ConvertSidToStringSid(ByVal pSID As IntPtr, ByRef pSidString As IntPtr) As Integer
    End Function


End Module
