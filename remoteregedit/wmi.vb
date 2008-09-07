'Option Strict On

Public Class wmi

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

            If Environment.OSVersion.ToString.LastIndexOf("5.1.2600") <> -1 Then
                ' Win XP Host
                .Authentication = System.Management.AuthenticationLevel.Packet
            Else
                ' Win 2K Host
                .Authentication = System.Management.AuthenticationLevel.Connect
            End If
            .Username = Nothing
            .Password = Nothing
        End With
    End Sub

    Public Function WMIConnect(ByVal strComputer As String) As Boolean

        Try
            wmiScope = New Management.ManagementScope("\\" & _
                       strComputer & "\root\cimv2", wmiConnectionOptions)
            wmiScope.Connect()

            RegScope = New Management.ManagementScope("\\" & _
                       strComputer & "\root\default:StdRegProv", wmiConnectionOptions)
            RegScope.Connect()

        Catch ex As System.Management.ManagementException
        End Try

        'Check WMI Connection
        If wmiScope.IsConnected = True Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function wmiQuery(ByVal QueryString As String) As Management.ManagementObjectCollection

        Dim query As Management.ObjectQuery
        query = New Management.ObjectQuery(QueryString)
        Dim searcher As Management.ManagementObjectSearcher
        searcher = New Management.ManagementObjectSearcher(wmiScope, query)
        Dim queryCollection As Management.ManagementObjectCollection
        queryCollection = searcher.Get()
        Return queryCollection

    End Function


    ' StdRegProv
    ' http://msdn2.microsoft.com/en-us/library/aa393664.aspx

    Public Function RegistryGetStringValue(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
  ByVal valueName As String) As String

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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

    Public Function RegistryGetBinaryValue(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
  ByVal valueName As String) As Byte

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("GetBinaryValue")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        inParams("sValueName") = valueName
        outParams = wmiReg.InvokeMethod("GetBinaryValue", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return CByte(outParams.Properties.Item("uValue").Value)
        Else
            Return ""
        End If

    End Function

    Public Function RegistryGetBinaryValue2(ByVal machineName As String, _
ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
ByVal valueName As String) As String

        Dim oReg As Object
        Dim strvalue() As Object = Nothing
        oReg = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & machineName & "\root\default:StdRegProv")
        oReg.GetBinaryValue(registryHive, subKeyName, valueName, strvalue)
        Dim val As String = Join(strvalue)
        Return val
        'For i = lBound(strValue) to uBound(strValue)
        '   wscript.echo  strValue(i)
        'Next

    End Function

    Public Function RegistryEnumKeys(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Array

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)
        Try
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
        Catch ex As Management.ManagementException
            Dim Arr As Array = Nothing
            Return Arr
        End Try

    End Function
    Public Function RegistryEnumValues(ByVal machineName As String, _
  ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String) As Array

        'Const REG_SZ As Integer = 1
        'Const REG_EXPAND_SZ As Integer = 2
        'Const REG_BINARY As Integer = 3
        'Const REG_DWORD As Integer = 4
        'Const REG_MULTI_SZ As Integer = 7

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

        inParams = wmiReg.GetMethodParameters("EnumValues")
        inParams("hDefKey") = CType("&H" & Hex(registryHive), Long)
        inParams("sSubKeyName") = subKeyName
        outParams = wmiReg.InvokeMethod("EnumValues", inParams, Nothing)

        If CInt(outParams.Properties("ReturnValue").Value) = 0 Then
            Return CType(outParams.Properties.Item("sNames").Value, Array) ' & outParams.Properties.Item("Types").Value, Array(,))
        Else
            Dim Arr As Array = Nothing
            Return Arr
        End If


        'Dim arrSubKeys As String()
        'Dim arrTypes As Integer()

        'inParams = wmiReg.GetMethodParameters("EnumValues")
        'inParams.SetPropertyValue("hDefKey", CType("&H" & Hex(registryHive), Long))
        'inParams.SetPropertyValue("sSubKeyName", subKeyName)
        ''objManagementBaseObject.SetPropertyValue("sValueName",strValueName)

        'arrSubKeys = wmiReg.InvokeMethod("EnumValues", inParams, Nothing).Properties.Item("sNames").Value
        'arrTypes = CType(wmiReg.InvokeMethod("EnumValues", inParams, Nothing).Properties.Item("Types").Value, Integer())

    End Function

    Public Sub RegEnumValues(ByVal machineName As String, _
      ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String)

        'On Error Resume Next
        Const HKEY_LOCAL_MACHINE = &H80000002
        'Const REG_SZ = 1
        'Const REG_EXPAND_SZ = 2
        'Const REG_BINARY = 3
        'Const REG_DWORD = 4
        'Const REG_MULTI_SZ = 7
        Dim oreg As Object
        oreg = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & machineName & "\root\default:StdRegProv")
        Dim arrValueNames As String()
        Dim arrValueTypes As Integer()
        If Not (oreg.EnumValues(HKEY_LOCAL_MACHINE, subKeyName, arrValueNames, arrValueTypes) Is DBNull.Value) Then
            For i As Integer = 0 To UBound(arrValueNames)
                'WScript.Echo("Value Name: " & arrValueNames(i))
                'Select Case arrValueTypes(i)
                '    Case REG_SZ
                'WScript.Echo("Data Type: String")
                '    Case REG_EXPAND_SZ
                'WScript.Echo("Data Type: Expanded String")
                '    Case REG_BINARY
                'WScript.Echo("Data Type: Binary")
                '    Case REG_DWORD
                'WScript.Echo("Data Type: DWORD")
                '    Case REG_MULTI_SZ
                'WScript.Echo("Data Type: Multi String")
                'End Select

                Dim lv_row As ListViewItem = New ListViewItem(New String() {arrValueNames(i), arrValueTypes(i), ""})
                RegForm.ListView1.Items.Add(lv_row)
            Next
        End If
    End Sub


    Public Function RegistrySetStringValue(ByVal machineName As String, _
 ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
 ByVal valueName As String, ByVal Value As String) As Boolean

        Dim wmiReg As New Management.ManagementClass
        Dim inParams As Management.ManagementBaseObject
        Dim outParams As Management.ManagementBaseObject
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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
        wmiReg = New Management.ManagementClass(RegScope, New Management.ManagementPath("StdRegProv"), Nothing)

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
        Dim arrValues As Array = RegistryEnumValues(machineName, registryHive.LocalMachine, subKeyName)
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
