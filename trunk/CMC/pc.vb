Public Class pc

    Public Shared Name As String
    Public Hostname As String
    Public IPAddress As String
    Public OperatingSystem As String
    Public ServicePack As String
    Public OSVersion As String
    Protected Friend SystemDirectory As String
    Protected Friend TSEnabled As Boolean
    Protected Friend PhysicalMemory As Integer
    Dim m_LastBootTime As String
    Public IEVersion As String
    Public IEProxy As String
    Public CurrentUser As String
    Public CurrentUserDomain As String
    Dim m_SID As String
    Public LastLogon As String
    Protected Friend ScreenSaverActive As Boolean
    Public MacAddress As String
    Public NetworkAdaptorID As String
    Private _DomainRoleCode As Integer
    Private _DomainMember As Boolean
    Private _DomainName As String
    Private _64b As Boolean
    Private _arrayListShares As ArrayList


    ''' <summary>
    ''' Gets the Time when the computer was last booted.
    ''' </summary>
    ''' <value></value>
    ''' <returns>Last Boot Time as a string</returns>
    ''' <remarks></remarks>
    Public Property LastBootTime() As String
        Get
            If m_LastBootTime = "" Then
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
                    Case 4
                        Return True
                    Case 5
                        Return True
                    Case Else
                        Return False
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
            If Not String.IsNullOrEmpty(_DomainName) Then
                Return _DomainName
            Else
                Return String.Empty
            End If
        End Get
        Set(ByVal value As String)
            _DomainName = value
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
                    If _DomainRoleCode >= 2 Then
                        Return "Windows 2000 Server"
                    Else
                        Return "Windows 2000"
                    End If
                Case "5.1"
                    Return "Windows XP"
                Case "5.2"
                    Return "Windows 2003 Server"
                Case "6.0"
                    Return "Windows Vista"
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

    ''' <summary>
    ''' Determines whether OS is 32bit or 64bit from osversion string
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property x64() As Boolean
        Get
            If InStr(OperatingSystem, "x64") Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            _64b = value
        End Set
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

    Protected Friend Property ShareList() As ArrayList
        Get
            Return _arrayListShares
        End Get
        Set(ByVal value As ArrayList)
            _arrayListShares = value
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
        Me.PhysicalMemory = Nothing
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
        _arrayListShares = Nothing
        TSEnabled = Nothing
        ScreenSaverActive = Nothing
    End Sub
End Class
