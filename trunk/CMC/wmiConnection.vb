Option Strict On

Public Class wmiConnection

    Dim DefaultNamespace As String
    Dim wmiConnectionOptions As Management.ConnectionOptions
    Dim objManagementObjectCollection As Management.ManagementObjectCollection
    Dim wmiSearcher As Management.ManagementObjectSearcher
    Public Shared wmiScope As Management.ManagementScope
    Public Shared RegScope As Management.ManagementScope

    Public Sub SetupWMIConnectionOptions()

        wmiConnectionOptions = New Management.ConnectionOptions

        With wmiConnectionOptions
            .Impersonation = System.Management.ImpersonationLevel.Impersonate
            .Timeout = New TimeSpan(0, 0, 10)

            If Environment.OSVersion.ToString.LastIndexOf("5.0.2195") <> -1 Then
                ' Windows 2000
                .Authentication = System.Management.AuthenticationLevel.Connect
            Else
                ' Windows XP
                .Authentication = System.Management.AuthenticationLevel.Packet
            End If

            If Form1.AltUserCheckBox.Checked Then
                .Username = Form1.sAltUsername
                .Password = Form1.sAltPassword
                .EnablePrivileges = True
            Else
                .Username = Nothing
                .Password = Nothing
            End If

        End With

        'If connecting to local machine can't use alternate credentials
        If LCase(pc.Name) = LCase(My.Computer.Name) Then
            With wmiConnectionOptions
                .Impersonation = System.Management.ImpersonationLevel.Impersonate
                .Username = Nothing
                .Password = Nothing
            End With
        End If

    End Sub

    Public Function WMIConnect(ByVal strComputer As String) As Boolean

        SetupWMIConnectionOptions()

        Try
            wmiScope = New Management.ManagementScope("\\" & _
                       strComputer & "\root\cimv2", wmiConnectionOptions)
            wmiScope.Connect()

            RegScope = New Management.ManagementScope("\\" & _
                       strComputer & "\root\default:StdRegProv", wmiConnectionOptions)
            RegScope.Connect()

        Catch ex As System.Management.ManagementException
            ' Failed to authenticate properly.
            Form1.WriteLog(pc.Name & ": " & "AuthenticationFailure")
            Form1.notification_label.Text = "Authentication Failure"
            Return False
        Catch ex As System.Runtime.InteropServices.COMException
            ' Unable to connect to the RPC service on the remote machine.
            Form1.WriteLog(pc.Name & ": " & "RPCServicesUnavailable")
            Form1.notification_label.Text = "RPC Services Unavailable"
            Return False
        Catch ex As System.UnauthorizedAccessException
            ' User not authorized.
            Form1.WriteLog(pc.Name & ": " & "UnauthorizedAccess")
            Form1.notification_label.Text = "Unauthorized Access"
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
            query = New Management.ObjectQuery(QueryString)
            Dim searcher As Management.ManagementObjectSearcher
            searcher = New Management.ManagementObjectSearcher(wmiScope, query)
            Dim queryCollection As Management.ManagementObjectCollection
            queryCollection = searcher.Get()
            Return queryCollection
        Catch
            MsgBox("Not Connected")
            Form1.ClearBoxes()
            Dim queryCollection As Management.ManagementObjectCollection
            queryCollection = Nothing
            Return queryCollection
        End Try

    End Function

    ' http://msdn2.microsoft.com/en-us/library/aa393664.aspx

    Public Function RegistryGetStringValue(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
  ByVal valueName As String) As String

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        On Error Resume Next
        inParams = wmiReg.GetMethodParameters("GetStringValue")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        inParams("sValueName") = valueName
        outParams = wmiReg.InvokeMethod("GetStringValue", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return CStr(outParams.Properties.Item("sValue").Value)
        Else
            Return ""
        End If

    End Function
    Public Function RegistryGetDWORDValue(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
  ByVal valueName As String) As Integer

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("GetDWORDValue")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        inParams("sValueName") = valueName
        outParams = wmiReg.InvokeMethod("GetDWORDValue", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return CInt(outParams.Properties.Item("uValue").Value)
        Else
            Return -1
        End If

    End Function
    Public Function RegistryEnumKeys(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Array

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("EnumKey")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        outParams = wmiReg.InvokeMethod("EnumKey", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return CType(outParams.Properties.Item("sNames").Value, Array)
        Else
            Dim Arr As Array = Nothing
            Return Arr
        End If

    End Function
    Public Function RegistryEnumValues(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Array

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("EnumValues")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        outParams = wmiReg.InvokeMethod("EnumValues", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return CType(outParams.Properties.Item("sNames").Value, Array) ' & outParams.Properties.Item("Types").Value
            ' REG_SZ (1)
            ' REG_EXPAND_SZ (2)
            ' REG_BINARY (3)
            ' REG_DWORD (4)
            ' REG_MULTI_SZ (7)
        Else
            Dim Arr As Array = Nothing
            Return Arr
        End If

    End Function
    Public Function RegistrySetStringValue(ByVal machineName As String, _
 ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
 ByVal valueName As String, ByVal Value As String) As Boolean

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("SetStringValue")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        inParams("sValueName") = valueName
        inParams("sValue") = Value
        outParams = wmiReg.InvokeMethod("SetStringValue", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function RegistrySetDWORDValue(ByVal machineName As String, _
ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
ByVal valueName As String, ByVal Value As Integer) As Boolean

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("SetDWORDValue")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        inParams("sValueName") = valueName
        inParams("uValue") = Value
        outParams = wmiReg.InvokeMethod("SetDWORDValue", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function RegistryCreateKey(ByVal machineName As String, _
ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Boolean
        ' Creates all keys in subkey path if they do not already exist
        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("CreateKey")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        outParams = wmiReg.InvokeMethod("CreateKey", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function RegistryDeleteKey(ByVal machineName As String, _
ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Boolean
        ' won't delete key containing subkeys
        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("DeleteKey")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        outParams = wmiReg.InvokeMethod("DeleteKey", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Function RegistryDeleteKeyRecursive(ByVal machineName As String, _
ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Boolean

        Dim arrSubKeys As Array = RegistryEnumKeys(machineName, registryHive, subKeyName)
        If arrSubKeys IsNot Nothing Then
            Dim strSubKey As String
            For Each strSubKey In arrSubKeys
                RegistryDeleteKeyRecursive(machineName, registryHive, subKeyName & "\" & strSubKey)
            Next
        End If

        If RegistryDeleteKey(machineName, registryHive, subKeyName) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function RegistryDeleteValue(ByVal machineName As String, _
ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
ByVal valuename As String) As Boolean

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(wmiConnection.RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("DeleteValue")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        inParams("sValueName") = valuename
        outParams = wmiReg.InvokeMethod("DeleteValue", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function RegistryCheckKeyExists(ByVal machineName As String, _
      ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Boolean

        Dim PreviousKey As String
        Dim KeyToFind As String
        If InStr(subKeyName, "\") = 0 Then
            PreviousKey = ""
            KeyToFind = LCase(subKeyName)
        Else
            Dim arrSubkeys() As String = Split(subKeyName, "\")
            KeyToFind = LCase(arrSubkeys(arrSubkeys.Length - 1))
            Array.Resize(arrSubkeys, arrSubkeys.Length - 1)
            PreviousKey = Join(arrSubkeys, "\")
        End If

        Dim exists As Boolean = False
        Dim arrKeys As Array = RegistryEnumKeys(machineName, registryHive, PreviousKey)
        For Each key As String In arrKeys
            If LCase(key) = KeyToFind Then
                exists = True
                Exit For
            End If
        Next

        Return exists

    End Function
    Public Function RegistryCheckValueExists(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, ByVal ValueName As String) As Boolean

        Dim exists As Boolean = False
        Dim arrValues As Array = RegistryEnumValues(pc.Name, registryHive.LocalMachine, subKeyName)
        If arrValues Is Nothing Then
            Return False
            Exit Function
        End If

        For Each value As String In arrValues
            If LCase(value) = LCase(ValueName) Then
                exists = True
                Exit For
            End If
        Next

        Return exists

    End Function
End Class
