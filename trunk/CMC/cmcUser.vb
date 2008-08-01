Public Class cmcUser

    Dim m_username As String

    Private ADSystemInfo As Object = CreateObject("ADSystemInfo")

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

    Public ReadOnly Property userdomain() As String
        Get
            Try
                Return ADSystemInfo.DomainShortName
            Catch ex As Exception
                Return "no domain found"
            End Try
        End Get
    End Property

    Public ReadOnly Property dnsdomain() As String
        Get
            Try
                Return ADSystemInfo.DomainDNSName
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    Public ReadOnly Property UserFQDN() As String
        Get
            Try
                Return ADSystemInfo.UserName
            Catch ex As Exception
                Return "not active directory member"
            End Try
        End Get
    End Property

    Public ReadOnly Property ComputerFQDN() As String
        Get
            Try
                Return ADSystemInfo.ComputerName
            Catch ex As Exception
                Return "not active directory member"
            End Try
        End Get
    End Property

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

    Public ReadOnly Property DomainController() As String
        Get
            Return ADSystemInfo.GetAnyDCName
        End Get
    End Property


End Class
