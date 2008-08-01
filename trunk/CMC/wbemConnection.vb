Public Class wbemConnection

    Dim objLocator As Object 'SWbemLocator
    Dim objWMIServices As Object 'SWbemServices
    Dim objWMIregistry As Object 'SWbemObject
    Dim m_Connected As Boolean = False


    ' Make WMI Connection

    Public Function Connect(ByVal strComputer As String, Optional ByVal Username As String = "", Optional ByVal Password As String = "") As Boolean
        Try
            objLocator = CreateObject("WbemScripting.SWbemLocator")
            objWMIServices = objLocator.ConnectServer(strComputer, "Root\DEFAULT", Username, Password, , , 128)
            objWMIregistry = objWMIServices.Get("StdRegProv")
            m_Connected = True
            Return True
        Catch ex As Exception
            m_Connected = False
            Return False
        End Try
    End Function

    Public ReadOnly Property IsConnected() As Boolean
        Get
            Return m_Connected
        End Get
    End Property

    ' Registry Functions

    Public Function RegReadString(ByVal HIVE As Integer, ByVal strKeyPath As String, ByVal strValueName As String) As String
        Dim strValue As String = ""
        Try
            objWMIregistry.GetStringValue(HIVE, strKeyPath, strValueName, strValue)
        Catch ex As Exception
            strValue = "error"
        End Try
        Return strValue
    End Function

    Public Function RegReadDWORD(ByVal HIVE As Integer, ByVal strKeyPath As String, ByVal strValueName As String) As Integer
        Dim strValue As Integer = Nothing
        Try
            objWMIregistry.GetDWordValue(HIVE, strKeyPath, strValueName, strValue)
        Catch
            Return -1
        End Try
        Return strValue
    End Function

    Public Function RegWriteString(ByVal HIVE As Integer, ByVal strKeyPath As String, ByVal strValueName As String, ByVal strValue As String) As Boolean

        Dim aKeys As Array = Split(strKeyPath, "\")
        Dim lastkey As String = aKeys(aKeys.Length - 1)
        Dim shortstrKeyPath As String = ""
        Dim i As Integer
        For i = 0 To aKeys.Length - 2
            shortstrKeyPath = shortstrKeyPath & aKeys(i) & "\"
        Next
        shortstrKeyPath = Mid(shortstrKeyPath, 1, shortstrKeyPath.Length - 1)
        If RegCheckKeyExists(HIVE, shortstrKeyPath, aKeys(aKeys.Length - 1)) Then
            Try
                objWMIregistry.SetStringValue(HIVE, strKeyPath, strValueName, strValue)
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function RegWriteDWORD(ByVal HIVE As Integer, ByVal strKeyPath As String, ByVal strValueName As String, ByVal Value As Integer) As Boolean
        Dim aKeys As Array = Split(strKeyPath, "\")
        Dim lastkey As String = aKeys(aKeys.Length - 1)
        Dim shortstrKeyPath As String = ""
        Dim i As Integer
        For i = 0 To aKeys.Length - 2
            shortstrKeyPath = shortstrKeyPath & aKeys(i) & "\"
        Next
        shortstrKeyPath = Mid(shortstrKeyPath, 1, shortstrKeyPath.Length - 1)
        If RegCheckKeyExists(HIVE, shortstrKeyPath, aKeys(aKeys.Length - 1)) Then
            Try
                objWMIregistry.SetDWordValue(HIVE, strKeyPath, strValueName, Value)
                Return True
            Catch ex As Exception
                Return False
            End Try
        Else
            Return False
        End If
    End Function

    Public Function RegDeleteValue(ByVal HIVE As Integer, ByVal strKeyPath As String, ByVal strValueName As String) As Boolean
        Try
            objWMIregistry.DeleteValue(HIVE, strKeyPath, strValueName)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RegDeleteKey(ByVal HIVE As Integer, ByVal strKeyPath As String) As Boolean
        Try
            objWMIregistry.DeleteKey(HIVE, strKeyPath)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function RegCheckKeyExists(ByVal HIVE As Integer, ByVal strKeyPath As String, ByVal strKey As String) As Boolean
        Dim arrSubKeys As Array = Nothing
        Dim subkey As String
        Dim keyExists As Boolean = False
        Try
            objWMIregistry.EnumKey(HIVE, strKeyPath, arrSubKeys)
            For Each subkey In arrSubKeys
                If LCase(subkey) = LCase(strKey) Then keyExists = True
            Next
        Catch ex As Exception
        End Try
        Return keyExists
    End Function

    Public Function RegGetSubKeys(ByVal HIVE As Integer, ByVal strKeyPath As String) As Array
        Dim arrSubKeys As Array = Nothing
        Dim i As Integer = 0

        Try
            objWMIregistry.EnumKey(HIVE, strKeyPath, arrSubKeys)
            'If arrSubKeys.Length = 0 Then
            '    Dim lines() As String = {"0"}
            '    Return lines
            '    Exit Function
            'End If
            Return arrSubKeys
        catch ex as System.InvalidCastException 
            Dim lines() As String = {"0"}
            Return lines
            Exit Function
        Catch ex As Exception
            Dim lines() As String = {"-1"}
            Return lines
        End Try
    End Function
    ' Create new key
    Public Function RegCreateKey(ByVal HIVE As Integer, ByVal strKeyPath As String) As Boolean
        Try
            objWMIregistry.CreateKey(HIVE, strKeyPath)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    ' WMI functions

    Public Sub DeletePrinter(ByVal printername As String)
        Try
            Dim colInstalledPrinters As Object = objWMIServices.ExecQuery("Select * from Win32_Printer Where Name = '" & printername & "'")
            Dim objPrinter As Object
            For Each objPrinter In colInstalledPrinters
                objPrinter.Delete_()
            Next
        Catch ex As Exception
            MsgBox("error deleting printer: " & ex.Message)
        End Try
    End Sub


End Class
