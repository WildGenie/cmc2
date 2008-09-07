Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.Security.Permissions

<Assembly: SecurityPermissionAttribute(SecurityAction.RequestMinimum, UnmanagedCode:=True)> 
Public Class Impersonation

    <DllImport("C:\\WINNT\\System32\\advapi32.dll")> _
    Public Shared Function LogonUser(ByVal lpszUsername As String, ByVal lpszDomain As String, ByVal lpszPassword As String, _
    ByVal dwLogonType As Integer, ByVal dwLogonProvider As Integer, ByVal phToken As Integer) As Boolean
    End Function

    <DllImport("C:\\WINNT\\System32\\Kernel32.dll")> _
    Public Shared Function GetLastError() As Integer
    End Function

    Public Shared Sub Main(ByVal args() As String)

        ' The Windows NT user token.
        Dim token1 As Integer

        ' Get the user token for the specified user, machine, and password
        ' using the unmanaged LogonUser method.

        'The parameters for LogonUser are the user name, computer name, password,
        'Logon type (LOGON32_LOGON_NETWORK_CLEARTEXT), Logon provider (LOGON32_PROVIDER_DEFAULT),
        'and user token.
        Dim loggedOn As Boolean = LogonUser("bob", "AARDVARK", "coffee", 3, 0, token1)
        Console.WriteLine("LogonUser called")

        'Call GetLastError to try to determine why logon failed if it did not succeed.
        Dim ret As Integer = GetLastError()

        Console.WriteLine("LogonUser Success? " + loggedOn)
        Console.WriteLine("NT Token Value: " + token1)
        If ret <> 0 Then
            Console.WriteLine("Error code (126 == ""Specified module could not be found""): " + ret)
        End If

        'Starting impersonation here:
        Console.WriteLine("Before impersonation:")
        Dim mWI1 As WindowsIdentity = WindowsIdentity.GetCurrent()
        Console.WriteLine(mWI1.Name)
        Console.WriteLine(mWI1.Token)

        Dim token2 As IntPtr = New IntPtr(token1)

        Console.WriteLine("New identity created:")
        Dim mWI2 As WindowsIdentity = New WindowsIdentity(token2)
        Console.WriteLine(mWI2.Name)
        Console.WriteLine(mWI2.Token)

        'Impersonate the user.
        Dim mWIC As WindowsImpersonationContext = mWI2.Impersonate()

        Console.WriteLine("After impersonation:")
        Dim mWI3 As WindowsIdentity = WindowsIdentity.GetCurrent()
        Console.WriteLine(mWI3.Name)
        Console.WriteLine(mWI3.Token)

        'Revert to previous identity.
        mWIC.Undo()

        Console.WriteLine("After impersonation is reverted:")
        Dim mWI4 As WindowsIdentity = WindowsIdentity.GetCurrent()
        Console.WriteLine(mWI4.Name)
        Console.WriteLine(mWI4.Token)
    End Sub
End Class
