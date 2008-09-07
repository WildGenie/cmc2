Imports System
Imports system.DirectoryServices
Imports system.directoryservices.ActiveDirectory

Public Class AD

    ''' <summary>
    ''' Method used to create an entry to the AD.
    ''' Replace the path, username, and password.
    ''' </summary>
    ''' <param name="aDSPath"></param>
    ''' <param name="DomainUser"></param>
    ''' <param name="Password"></param>
    ''' <param name="authenticationType"></param>
    ''' <returns>DirectoryEntry</returns>
    ''' <remarks>DomainUser should be in the form: DOMAIN\Username (or NOTHING)</remarks>
    Public Function GetDirectoryEntry( _
                       ByVal aDSPath As String, _
                       ByVal DomainUser As String, _
                       ByVal Password As String, _
                       Optional ByVal authenticationType As DirectoryServices.AuthenticationTypes = AuthenticationTypes.Secure) _
                                        As DirectoryEntry
        Dim de As New DirectoryEntry()
        de.Path = aDSPath
        de.Username = DomainUser
        de.Password = Password
        Return de
    End Function

    ''' <summary>
    ''' Converts Netbios domain name to dns domain name.
    ''' </summary>
    ''' <param name="friendlyDomainName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FriendlyDomainToLdapDomain(ByVal friendlyDomainName As String) As String

        Dim ldapPath As String
        Try
            Dim objContext As New DirectoryContext(DirectoryContextType.Domain, friendlyDomainName)
            Dim objDomain As Domain = Domain.GetDomain(objContext)
            ldapPath = objDomain.Name
        Catch ex As Exception
            ldapPath = String.Empty
        End Try

        Return ldapPath

    End Function

    ''' <summary>
    ''' Returns an ArrayList containg all domains within the current forest.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EnumerateDomains() As ArrayList

        Dim allDomains As New ArrayList()
        Dim currentForest As Forest = Forest.GetCurrentForest()
        Dim myDomains As DomainCollection = currentForest.Domains

        For Each objDomain As Domain In myDomains
            allDomains.Add(objDomain.Name)
        Next
        Return allDomains

    End Function

    ''' <summary>
    ''' Returns an ArrayList containing all domain controllers within the current domain.
    ''' </summary>
    ''' <returns>ArrayList</returns>
    ''' <remarks></remarks>
    Public Function EnumerateDomainControllers() As ArrayList

        Dim DCs As New ArrayList()
        Dim currentDomain As Domain = Domain.GetCurrentDomain
        For Each dc As DomainController In currentDomain.DomainControllers
            DCs.Add(dc.Name)
        Next
        Return DCs

    End Function

    Public Function MemberOf(ByVal UserDN As String, ByVal recursive As Boolean) As ArrayList

        Dim groupMemberships As New ArrayList
        Return AttributeValuesMultiString("memberOf", UserDN, groupMemberships, recursive)

    End Function
    Public Function AttributeValuesMultiString( _
                      ByVal attributeName As String, _
                      ByVal objectDn As String, _
                      ByVal valuesCollection As ArrayList, _
                      ByVal recursive As Boolean) _
                                                   As ArrayList

        Dim ent As New DirectoryEntry(objectDn)
        Dim ValueCollection As PropertyValueCollection = ent.Properties(attributeName)
        Dim en As IEnumerator = ValueCollection.GetEnumerator()

        While en.MoveNext
            If Not en.Current Is Nothing Then
                If Not valuesCollection.Contains(en.Current.ToString()) Then
                    valuesCollection.Add(en.Current.ToString())
                    If (recursive) Then
                        AttributeValuesMultiString(attributeName, "LDAP://" & en.Current.ToString(), valuesCollection, True)
                    End If
                End If
            End If
        End While

        ent.Close()
        ent.Dispose()

        Return valuesCollection

    End Function

End Class
