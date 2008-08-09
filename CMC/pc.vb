Public Class pc

    Public Shared Name As String
    Public Hostname As String
    Public IPAddress As String
    Public OperatingSystem As String
    Public ServicePack As String
    Public OSVersion As String
    Public SystemDirectory As String
    Protected Friend TSEnabled As Boolean
    Dim m_LastBootTime As String
    Public IEVersion As String
    Public IEProxy As String
    Public CurrentUser As String
    Public CurrentUserDomain As String
    Dim m_SID As String
    Public LastLogon As String
    Public MacAddress As String
    Public NetworkAdaptorID As String
    Private _DomainRoleCode As Integer
    Private _DomainMember As Boolean
    Private _DomainName As String

    ''' <summary>
    ''' Gets the Time when the computer was last booted.
    ''' </summary>
    ''' <value></value>
    ''' <returns>Last Boot Time as a string</returns>
    ''' <remarks></remarks>
    Public Property LastBootTime() As String
        Get
            If m_lastboottime = "" Then
                Return ""
            Else
                Return Mid(m_LastBootTime, 7, 2) & "/" & Mid(m_LastBootTime, 5, 2) & "/" & _
                Mid(m_LastBootTime, 1, 4) & " " & _
                Mid(m_LastBootTime, 9, 2) & ":" & Mid(m_LastBootTime, 11, 2)
            End If
        End Get
        Set(ByVal value As String)
            m_LastBootTime = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the domain role of the Server or Workstation.
    ''' </summary>
    ''' <returns>domain role as a string</returns>
    ''' <remarks></remarks>
    Public Property DomainRole() As String
        Get
            Select Case _DomainRoleCode
                Case 0
                    Return "Standalone Workstation"
                Case 1
                    Return "Member Workstation"
                Case 2
                    Return "Standalone Server"
                Case 3
                    Return "Member Server"
                Case Else
                    Return "Domain Controller"
            End Select
        End Get
        Set(ByVal value As String)
            _DomainRoleCode = CInt(value)
        End Set
    End Property

    ''' <summary>
    ''' Gets a boolean value indicating whether the computer is a member of a domain
    ''' </summary>
    ''' <value></value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    Public Property DomainMember() As Boolean
        Get
            If _DomainMember <> Nothing Then
                Return _DomainMember
            ElseIf Not String.IsNullOrEmpty(_DomainRoleCode) Then
                Select Case _DomainRoleCode
                    Case 0
                        Return False
                    Case 1
                        Return True
                    Case 2
                        Return False
                    Case 3
                        Return True
                    Case Else
                        Return True
                End Select
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As Boolean)
            _DomainMember = value
        End Set
    End Property

    ''' <summary>Identifies the dns name of the domain of which the computer is a member.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property DomainName() As String
        Get
            If Not String.IsNullOrEmpty(_Domainname) Then
                Return _Domainname
            Else
                Return String.Empty
            End If
        End Get
        Set(ByVal value As String)
            _Domainname = value
        End Set
    End Property

    ''' <summary>
    ''' Gets the 'Friendly Name' of the OS (eg: 'Windows 2000')
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OS() As String
        Get
            Select Case Mid(OSVersion, 1, 3)
                Case "4.0"
                    Return "NT"
                Case "5.0"
                    Return "Windows 2000"
                Case "5.1"
                    Return "Windows XP"
                Case "5.2"
                    Return "Windows 2003"
                Case Else
                    Return "Unknown"
            End Select
        End Get

    End Property

    ''' <summary>
    ''' Gets a numeric value for the OS version (eg: 5.0 or 5.2)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OSVersionNumeric() As Double
        Get
            On Error Resume Next
            Return Double.Parse(Mid(OSVersion, 1, 3))
        End Get
    End Property

    Public Property CurrentUserSID() As String
        Get
            If m_SID = Nothing Then
                Return ""
            Else
                Return m_SID
            End If
        End Get
        Set(ByVal value As String)
            m_SID = value
        End Set
    End Property

    Public Sub Clear()
        Name = Nothing
        Hostname = Nothing
        IPAddress = Nothing
        OperatingSystem = Nothing
        ServicePack = Nothing
        OSVersion = Nothing
        SystemDirectory = Nothing
        m_LastBootTime = Nothing
        LastBootTime = Nothing
        IEVersion = Nothing
        IEProxy = Nothing
        MacAddress = Nothing
        NetworkAdaptorID = Nothing
        CurrentUser = Nothing
        CurrentUserDomain = Nothing
        CurrentUserSID = Nothing
        LastLogon = Nothing
        _DomainRoleCode = Nothing
        _DomainMember = Nothing
        _DomainName = Nothing
        TSEnabled = Nothing
    End Sub
End Class
