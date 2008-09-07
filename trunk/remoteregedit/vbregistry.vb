
Imports Microsoft.Win32

Public Class VBRegistry

    Public Function EnumKeys(ByVal sComputer As String, ByVal reghive As Microsoft.Win32.RegistryHive, ByVal sKeyPath As String) As Array

        Dim arr As Array = Nothing

        Try
            arr = RegistryKey.OpenRemoteBaseKey(reghive, sComputer).OpenSubKey(sKeyPath).GetSubKeyNames()
            Array.Sort(arr)
        Catch ex As Exception
        End Try

        Return arr

    End Function

    Public Sub EnumValues(ByVal sComputer As String, _
                          ByVal reghive As Microsoft.Win32.RegistryHive, _
                          ByVal KeyPath As String)

        Dim aValues As Array = Nothing
        Try
            aValues = RegistryKey.OpenRemoteBaseKey(reghive, sComputer).OpenSubKey(KeyPath).GetValueNames
        Catch ex As Exception 'System.Security.SecurityException
            'MsgBox("permission denied to this key")
            Exit Sub
        End Try
        Dim sType As String
        Dim sData As String
        Dim img As Integer
        For Each sName As String In aValues
            sData = ""
            Dim sValueType As Microsoft.Win32.RegistryValueKind = RegistryKey.OpenRemoteBaseKey(reghive, sComputer).OpenSubKey(KeyPath).GetValueKind(sName)

            Select Case sValueType
                Case 1
                    sType = "Reg_SZ"
                    img = 3
                Case 2
                    sType = "Reg_EXPAND_SZ"
                    img = 3
                Case 3
                    sType = "Reg_BINARY"
                    img = 2
                Case 4
                    sType = "Reg_DWORD"
                    img = 2
                Case 7
                    sType = "Reg_MULTI_SZ"
                    img = 3
                Case Else
                    sType = "unknown"
            End Select

            Try
                If sType = "Reg_BINARY" Then
                    sData = RegistryGetBinaryValue(sComputer, reghive, KeyPath, sName)
                ElseIf sType = "Reg_MULTI_SZ" Then
                    Dim arrData() As String
                    arrData = RegistryKey.OpenRemoteBaseKey(reghive, sComputer).OpenSubKey(KeyPath).GetValue(sName)
                    sData = Join(arrData, vbNewLine)
                Else
                    sData = RegistryKey.OpenRemoteBaseKey(reghive, sComputer).OpenSubKey(KeyPath).GetValue(sName)
                End If
            Catch
                MsgBox(Err.Description)
                sData = "<error>"
            End Try

            If Trim(sName) = "" Then sName = "(Default)"
            Dim lv_row As ListViewItem = New ListViewItem(New String() {sName, sType, sData}, img)
            RegForm.ListView1.Items.Add(lv_row)
        Next
    End Sub

    'Public Function RegistryGetBinaryValue2(ByVal sComputer As String, _
    '        ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
    '        ByVal valueName As String) As String
    '    Try
    '        Dim oReg As Object
    '        Dim strvalue() As Object = Nothing
    '        oReg = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" _
    '            & sComputer & "\root\default:StdRegProv")
    '        oReg.GetBinaryValue(registryHive, subKeyName, valueName, strvalue)
    '        Dim val As String = Join(strvalue)
    '        Return val
    '    Catch ex As Exception
    '        Return String.Empty
    '    End Try
    'End Function
    Public Function RegistryGetBinaryValue(ByVal machineName As String, _
                ByVal registryHive As Microsoft.Win32.RegistryHive, ByVal subKeyName As String, _
                ByVal valueName As String) As String 'Byte()

        Dim HKLM As RegistryKey = Registry.LocalMachine
        Dim RegBinary As Object
        RegBinary = RegistryKey.OpenRemoteBaseKey(registryHive, machineName).OpenSubKey(subKeyName).GetValue(valueName)
        Dim myByteArray() As Byte = CType(RegBinary, Byte())
        Return BinToHex(myByteArray)
    End Function

    Public Sub NewKey(ByVal sComputer As String, _
                      ByVal regHive As Microsoft.Win32.RegistryHive, _
                      ByVal sKeyPath As String, _
                      ByVal sKeyName As String)
        Try
            RegistryKey.OpenRemoteBaseKey(regHive, sComputer).OpenSubKey(sKeyPath, True).CreateSubKey(sKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree)
        Catch ex As Exception
            MsgBox("error creating key")
        End Try
    End Sub
    Public Sub DeleteKey(ByVal sComputer As String, _
                          ByVal regHive As Microsoft.Win32.RegistryHive, _
                          ByVal sKeyPath As String, _
                          ByVal sKeyName As String)

        Dim arrPath As Array = Split(sKeyPath, "\")
        Dim parentkeypath As String = ""
        If arrPath.Length > 1 Then
            For i As Integer = 0 To arrPath.Length - 2
                parentkeypath = parentkeypath & arrPath(i) & "\"
            Next
            parentkeypath = Mid(parentkeypath, 1, parentkeypath.Length - 1)
        End If
        Try
            RegistryKey.OpenRemoteBaseKey(regHive, sComputer).OpenSubKey(parentkeypath, True).DeleteSubKeyTree(sKeyName)
        Catch ex As Exception
            MsgBox("error deleting key")
        End Try
    End Sub
    Public Sub NewStringValue(ByVal sComputer As String, _
                          ByVal regHive As Microsoft.Win32.RegistryHive, _
                          ByVal sKeyPath As String, _
                          ByVal sValueName As String, _
                          ByVal sValueData As String)
        Try
            RegistryKey.OpenRemoteBaseKey(regHive, sComputer).OpenSubKey(sKeyPath, True).SetValue(sValueName, sValueData)
        Catch ex As Exception
            MsgBox("error creating value")
        End Try
    End Sub
    Public Sub DeleteValue(ByVal sComputer As String, _
                          ByVal regHive As Microsoft.Win32.RegistryHive, _
                          ByVal sKeyPath As String, _
                          ByVal sValueName As String)
        Try
            RegistryKey.OpenRemoteBaseKey(regHive, sComputer).OpenSubKey(sKeyPath, True).DeleteValue(sValueName, False)
        Catch ex As Exception
            MsgBox("error deleting value")
        End Try
    End Sub

    Private Function BinToHex(ByVal data As Byte()) As String
        If Not data Is Nothing Then
            Dim sb As New System.Text.StringBuilder
            For i As Integer = 0 To data.Length - 1
                sb.Append(data(i).ToString("x2"))
                sb.Append(" ", 1)
            Next
            Return (sb.ToString())
        Else
            Return (Nothing)
        End If
    End Function
    Private Function HexToBin(ByVal s As String) As Byte()
        s = Replace(s, " ", "")
        Dim arraySize As Integer = CInt(s.Length / 2)
        Dim bytes(arraySize - 1) As Byte
        Dim counter As Integer
        For i As Integer = 0 To s.Length - 1 Step 2
            Dim hexValue As String = s.Substring(i, 2)
            ' Tell convert to interpret the string as a 16 bit hex value  
            Dim intValue As Integer = Convert.ToInt32(hexValue, 16)
            ' Convert the integer to a byte and store it in the array  
            bytes(counter) = Convert.ToByte(intValue)
            counter += 1
        Next
        Return (bytes)
    End Function

    Private Sub RegPerm()
        Dim regPerm1 As Security.Permissions.RegistryPermission
        Dim pRegKey As RegistryKey = Registry.Users
        regPerm1 = New Security.Permissions.RegistryPermission(Security.Permissions.RegistryPermissionAccess.AllAccess, "HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion")
        regPerm1.SetPathList(Security.Permissions.RegistryPermissionAccess.AllAccess, "HKEY_USERS\.DEFAULT\Software\Microsoft\Windows\CurrentVersion")
        'Dim key1 As RegistryKey = Registry.Users.OpenSubKey(".DEFAULT\\Software\\Microsoft\\Windows\\CurrentVersion", True)
        'Dim newkey1 As RegistryKey = key1.CreateSubKey("{A587DE14-48CB-37A3-BB7D-F5913EA15DDC}\\Parameters\\Sys")
        'newkey1.SetValue("IDInfo", "2")
    End Sub
    
End Class



