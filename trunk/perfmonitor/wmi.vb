Option Strict On

Public Class WMI

    Dim DefaultNamespace As String
    Dim wmiConnectionOptions As Management.ConnectionOptions
    Dim objManagementObjectCollection As Management.ManagementObjectCollection
    Dim wmiSearcher As Management.ManagementObjectSearcher
    Public Shared wmiScope As Management.ManagementScope
    Public Shared RegScope As Management.ManagementScope

    Public Sub SetupConnectionOptions()

        wmiConnectionOptions = New Management.ConnectionOptions

        With wmiConnectionOptions
            .Impersonation = System.Management.ImpersonationLevel.Impersonate
            .Timeout = New TimeSpan(0, 0, 10)
            .Username = Nothing
            .Password = Nothing
            'MsgBox(My.Computer.Info.OSVersion)
            If Environment.OSVersion.ToString.LastIndexOf("5.0") <> -1 Then
                ' Windows 2000
                .Authentication = System.Management.AuthenticationLevel.Connect
            Else
                ' Windows XP or later
                .Authentication = System.Management.AuthenticationLevel.Packet
            End If

            If Not String.IsNullOrEmpty(PerfMonitor.Username) Then
                .Username = PerfMonitor.Username
                .Password = PerfMonitor.Password
                .EnablePrivileges = True
            Else
                .Username = Nothing
                .Password = Nothing
            End If

        End With

    End Sub

    Public Function Connect(ByVal strComputer As String) As Boolean

        SetupConnectionOptions()

        Try
            wmiScope = New Management.ManagementScope("\\" & _
                       strComputer & "\root\cimv2", wmiConnectionOptions)
            wmiScope.Connect()

            RegScope = New Management.ManagementScope("\\" & _
                       strComputer & "\root\default:StdRegProv", wmiConnectionOptions)
            RegScope.Connect()

        Catch ex As System.Management.ManagementException
            ' Failed to authenticate properly.
            MsgBox(strComputer & ": " & "AuthenticationFailure")
            Return False
        Catch ex As System.Runtime.InteropServices.COMException
            ' Unable to connect to the RPC service on the remote machine.
            MsgBox(strComputer & ": " & "RPCServicesUnavailable")
            Return False
        Catch ex As System.UnauthorizedAccessException
            ' User not authorized.
            MsgBox(strComputer & ": " & "UnauthorizedAccess")
            Return False
        End Try

        'Check WMI Connection
        If wmiScope.IsConnected = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function wmiQuery(ByVal QueryString As String) As Management.ManagementObjectCollection

        If wmiScope.IsConnected = False Then
            wmiScope.Connect()
        End If

        Try
            Dim query As Management.ObjectQuery
            Query = New Management.ObjectQuery(QueryString)
            Dim searcher As Management.ManagementObjectSearcher
            searcher = New Management.ManagementObjectSearcher(wmiScope, Query)
            Dim queryCollection As Management.ManagementObjectCollection
            queryCollection = searcher.Get()
            Return queryCollection
        Catch
            Dim queryCollection As Management.ManagementObjectCollection
            queryCollection = Nothing
            Return queryCollection
        End Try

    End Function
End Class
