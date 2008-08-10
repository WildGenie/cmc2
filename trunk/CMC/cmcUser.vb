Public Class cmcUser

    Dim m_username As String

    Private ADSystemInfo As Object = CreateObject("ADSystemInfo")

    ''' <summary>
    ''' Get the windows logon name of the current cmc user.
    ''' </summary>
    ''' <value></value>
    ''' <returns>username</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property username() As String
        Get
            Try
                If m_username <> Nothing Then
                    Return m_username
                Else
                    Return System.Security.Principal.WindowsIdentity.GetCurrent.Name
                End If
            Catch ex As Exception
                Return "error getting name"
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Get the Netbios domain name of the current application user.
    ''' (returns 'no domain found' if not domain member.)
    ''' </summary>
    ''' <returns>domain name</returns>
    Public ReadOnly Property userdomain() As String
        Get
            Try
                Return ADSystemInfo.DomainShortName
            Catch ex As Exception
                Return "no domain found"
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Returns the name of the server used to authenticate the current application users session.
    ''' </summary>
    Public ReadOnly Property LogonServer() As String
        Get
            Try
                Return Environment.ExpandEnvironmentVariables("%LogonServer%").Replace("\\", "")
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Returns the current cmc users dns domain name.
    ''' </summary>
    ''' <value></value>
    ''' <returns>If the user is not on a domain return empty string</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property dnsdomain() As String
        Get
            Try
                Return ADSystemInfo.DomainDNSName
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Gets the distinguishedName of the cmc application user.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property UserDN() As String
        Get
            Try
                Return ADSystemInfo.UserName
            Catch ex As Exception
                Return "not active directory member"
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Gets the distinguishedName of the host computer running the cmc application.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ComputerFQDN() As String
        Get
            Try
                Return ADSystemInfo.ComputerName
            Catch ex As Exception
                Return "not active directory member"
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Gets boolean value indicating whether cmc user is a domain account.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property User_ADMember() As Boolean
        Get
            Try
                Dim name As String = ADSystemInfo.UserName()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Gets boolean value indicating whether cmc host computer is a domain computer.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Computer_ADMember() As Boolean
        Get
            Try
                Dim name As String = ADSystemInfo.ComputerName()
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Get
    End Property

    ''' <summary>
    ''' Gets the name of any available domain controller for the current domain.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DomainController() As String
        Get
            Return ADSystemInfo.GetAnyDCName
        End Get
    End Property


End Class
