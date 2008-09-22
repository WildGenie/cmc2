Imports System.Windows.Forms
Imports Microsoft.Win32


Public Class AddDomainInfo

    ''' <summary>
    ''' Validates and adds custom domain information.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Peter Forman 09/08/2008</remarks>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If ValidateInformation() Then
            lblNotValidated.Visible = False
            lblDomain.ForeColor = Color.Black
            lblDNS.ForeColor = Color.Black

            Dim domain As String = Me.txtDomain.Text
            Dim dns As String = Me.txtDNS.Text
            Dim dc As String = Me.txtDC.Text

            Dim user As String = Me.txtUser.Text
            Dim pass As String = Me.txtPass.Text

            Dim cdi As New CustomDomainInfo
            cdi.SaveCustomDomainInfo(domain, dns, dc, user, pass)

            If cdi.Found(domain) Then
                cdi = Nothing
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                MsgBox("Error saving custom domain information.")
                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

        Else
            lblNotValidated.Visible = True
            lblDomain.ForeColor = Color.Red
            lblDNS.ForeColor = Color.Red

            Exit Sub
        End If

    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Protected Friend dnsPart As String = ""
    Protected Friend dcPart As String = ""
    Protected Friend EditMode As Boolean

    ''' <summary>
    ''' Read Domain Controller value and add to aDSPath
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtDC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDC.TextChanged
        If String.IsNullOrEmpty(txtDC.Text) Then
            dcPart = ""
        Else
            dcPart = UCase(txtDC.Text) & "/"
        End If
        txtDSPreview.Text = "LDAP://" & Me.dcPart & Me.dnsPart
    End Sub

    ''' <summary>
    ''' Read DNS Domain name and convert to aDSPath
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtDNS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDNS.TextChanged
        If Not txtDNS.Text.ToLower.Contains("dc=") Then
            dnsPart = "dc=" & Replace(txtDNS.Text.ToLower, ".", ",dc=")
        Else
            dnsPart = txtDNS.Text.ToLower
        End If
        txtDSPreview.Text = "LDAP://" & Me.dcPart & Me.dnsPart
    End Sub

    ''' <summary>
    ''' Checks that mandatory domain fields are completed.
    ''' </summary>
    ''' <returns>true/false</returns>
    ''' <remarks>username and password not validated.</remarks>
    Function ValidateInformation() As Boolean
        If String.IsNullOrEmpty(Me.txtDomain.Text) Then
            Return False
        ElseIf String.IsNullOrEmpty(Me.txtDNS.Text) Then
            Return False
            'ElseIf String.IsNullOrEmpty(Me.txtDC.Text) Then
            '    Return False
        Else
            Return True
        End If
    End Function

    Private Sub AddDomainInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If EditMode = True Then
            OK_Button.Text = "Save"
            btnDelete.Visible = True
        Else
            OK_Button.Text = "Add"
            btnDelete.Visible = False
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim di As New CustomDomainInfo
        Dim valuename As String = di.RegKeyName(Me.txtDomain.Text)
        If Not String.IsNullOrEmpty(valuename) Then
            Registry.CurrentUser.OpenSubKey("software\Forman", True).DeleteValue(valuename)
        Else
            MsgBox("Domain not found in registry.", MsgBoxStyle.Critical, "Error Deleting Entry")
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class


''' <summary>
''' Stores and retrieves custom domain strings.
''' Strings contain: NT Domain Name, DNS Domain Name, Preferred domain controller,
'''                  Optional Username and Password.
''' </summary>
''' <remarks>Peter Forman 09/08/2008</remarks>
Public Class CustomDomainInfo

#Region "Internal Properties"
    Private _found As Boolean = False
    Private _regkeyname As String
    Private _regStringValue As String
    Private _ntDomain As String
    Private _dnsDomain As String
    Private _dc As String
    Private _username As String
    Private _password As String
#End Region

    ''' <summary>
    ''' Returns boolean value indicating whether the requested domain name
    ''' has a custom registry entry.
    ''' </summary>
    ''' <param name="NT_Domain"></param>
    ''' <value></value>
    ''' <returns>True/False</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Found(ByVal NT_Domain As String) As Boolean
        Get
            _found = FindCustomDomainInfo(NT_Domain)
            Return _found
        End Get
    End Property

    ''' <summary>
    ''' Returns the registry key name containing the information
    ''' for the selected domain.
    ''' </summary>
    ''' <param name="NT_Domain"></param>
    ''' <value></value>
    ''' <returns>Registry Key Name</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property RegKeyName(ByVal NT_Domain As String) As String
        Get
            If FindCustomDomainInfo(NT_Domain) Then
                Return _regkeyname
            Else
                Return String.Empty
            End If
        End Get
    End Property

    ''' <summary>
    ''' The NT (Short) domain name
    ''' </summary>
    ''' <returns>Short domain name in upper case</returns>
    ''' <remarks></remarks>
    Public Property NTDomainName() As String
        Get
            If _found Then
                Return _ntDomain
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            _ntDomain = value
        End Set
    End Property

    ''' <summary>
    ''' The dns name of the domain.
    ''' </summary>
    ''' <returns>Lower case dns domain name</returns>
    ''' <remarks></remarks>
    Public Property DNSDomainName() As String
        Get
            If _found Then
                Return _dnsDomain
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            _dnsDomain = value
        End Set
    End Property

    ''' <summary>
    ''' The preferred domain controller used for querying AD.
    ''' </summary>
    ''' <value></value>
    ''' <returns>Upper case domain controller name</returns>
    ''' <remarks></remarks>
    Public Property DomainController() As String
        Get
            If _found Then
                Return _dc
            Else
                Return ""
            End If
        End Get
        Set(ByVal value As String)
            _dc = value
        End Set
    End Property

    ''' <summary>
    ''' Optional username to use when querying AD. Returns Nothing if empty
    ''' </summary>
    ''' <value></value>
    ''' <returns>Decrypted username as string, or Nothing if empty</returns>
    ''' <remarks></remarks>
    Public Property Username() As String
        Get
            If _found Then
                If String.IsNullOrEmpty(_username) Then
                    Return Nothing
                Else
                    Return Encryption.DecryptText(_username)
                End If
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As String)
            If String.IsNullOrEmpty(value) Then
                _username = Nothing
            Else
                _username = Encryption.EncryptText(value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Optional password to use when querying AD. Returns Nothing if empty
    ''' </summary>
    ''' <value></value>
    ''' <returns>Decrypted password as string, or Nothing if empty</returns>
    ''' <remarks></remarks>
    Public Property Password() As String
        Get
            If _found Then
                If String.IsNullOrEmpty(_password) Then
                    Return Nothing
                Else
                    Return Encryption.DecryptText(_password)
                End If
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As String)
            If String.IsNullOrEmpty(value) Then
                _password = Nothing
            Else
                _password = Encryption.EncryptText(value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Returns DSPath (LDAP://{DC}/my.domain.com) for the selected domain.
    ''' </summary>
    ''' <value></value>
    ''' <returns>aDSPath as string</returns>
    ''' <remarks>Includes DC in string if available</remarks>
    Public ReadOnly Property DSPath() As String
        Get
            If _found Then

                Dim dc As String = _dc
                If Not String.IsNullOrEmpty(dc) Then dc = dc & "/"

                Dim dns As String = _dnsDomain
                If Not _dnsDomain.ToLower.Contains("dc=") Then
                    dns = "dc=" & Replace(_dnsDomain, ".", ",dc=")
                End If

                Return "LDAP://" & dc & dns
            Else
                Return ""
            End If
        End Get
    End Property


    ''' <summary>
    ''' Checks for custom domain entry in registry, returns true if found
    ''' </summary>
    ''' <param name="Domain"></param>
    ''' <returns>Populates internal properties</returns>
    ''' <remarks></remarks>
    Private Function FindCustomDomainInfo(ByVal Domain As String) As Boolean

        Dim bFound As Boolean = False
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If rk Is Nothing Then
                'Exit For
            Else
                Dim dominfo() As String = Split(rk, ";")

                If dominfo(0).ToLower = Domain.ToLower Then

                    ' domain found in registry
                    _regkeyname = valuename
                    _regStringValue = rk
                    _ntDomain = UCase(Domain)
                    _dnsDomain = LCase(dominfo(1))
                    _dc = UCase(dominfo(2))
                    _username = dominfo(3)
                    _password = dominfo(4)

                    bFound = True
                    Exit For
                End If
            End If
        Next

        Return bFound

    End Function

    Public Function GetCustomDomains() As Array

        ' count custom domains
        Dim domaincount As Integer = 0
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If Not rk Is Nothing Then
                domaincount = domaincount + 1
            End If
        Next

        ' add custom domains to array
        Dim domains(domaincount - 1, 4) As String
        domaincount = 0
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If Not rk Is Nothing Then
                Dim dominfo() As String = Split(rk, ";")
                domains(domaincount, 0) = UCase(dominfo(0))
                domains(domaincount, 1) = dominfo(1)
                domains(domaincount, 2) = dominfo(2)
                domains(domaincount, 3) = dominfo(3)
                domains(domaincount, 4) = dominfo(4)
                domaincount = domaincount + 1
            End If
        Next

        Return domains
    End Function

    ''' <summary>
    ''' Saves custom domain information to the registry in first available space.
    ''' </summary>
    ''' <param name="Domain"></param>
    ''' <remarks></remarks>
    Protected Friend Sub SaveCustomDomainInfo(ByVal Domain As String, ByVal dnsDomain As String, ByVal DomainController As String, ByVal User As String, ByVal Passwd As String)

        If Not String.IsNullOrEmpty(User) Then User = Encryption.EncryptText(User)
        If Not String.IsNullOrEmpty(Passwd) Then Passwd = Encryption.EncryptText(Passwd)

        Dim rKey As RegistryKey = Registry.CurrentUser.OpenSubKey("software\Forman")
        If rKey Is Nothing Then
            ' App regkey does not exist, so create key.
            Registry.CurrentUser.OpenSubKey("Software", True).CreateSubKey("Forman")
        End If

        Dim RegistryKeyName As String = String.Empty
        If FindCustomDomainInfo(Domain) Then
            RegistryKeyName = _regkeyname
        Else
            For i As Integer = 0 To 9
                Dim valuename As String = "Domain" & CStr(i)
                Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
                If rk Is Nothing Then
                    RegistryKeyName = valuename
                    Exit For
                End If
            Next
        End If
        Dim DomString As String = Domain & ";" & dnsDomain & ";" & DomainController & ";" & User & ";" & Passwd
        Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue(RegistryKeyName, DomString, RegistryValueKind.String)
    End Sub

End Class
