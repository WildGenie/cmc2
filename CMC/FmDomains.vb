Imports Microsoft.Win32


Public Class FmDomains

    Private Sub FmDomains_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If rk Is Nothing Then
                'Exit Sub
            Else
                Dim dominfo() As String = Split(rk, ";")

                Dim user As String = dominfo(3)
                If Not String.IsNullOrEmpty(user) Then user = EncryptText.DecryptText(user)
                Dim pass As String = dominfo(4)
                If Not String.IsNullOrEmpty(pass) Then pass = EncryptText.DecryptText(pass)

                DomainDatagrid.Rows.Add(dominfo(0), dominfo(1), dominfo(2), user, pass)

            End If
        Next
    End Sub

    Private Sub dtnDomSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtnDomSave.Click

        ' delete existing domain entries (for reordering)
        For i As Integer = 0 To 9
            Dim valuename As String = "Domain" & CStr(i)
            Dim rk As String = Registry.CurrentUser.OpenSubKey("Software\Forman").GetValue(valuename, Nothing)
            If Not rk Is Nothing Then
                Registry.CurrentUser.OpenSubKey("Software\Forman", True).DeleteValue(valuename)
            End If
        Next

        ' write datagrid to custom domain registry strings
        For Each row As DataGridViewRow In DomainDatagrid.Rows
            If Not String.IsNullOrEmpty(DomainDatagrid(1, row.Index).Value) Then
                Dim keyname As String = "Domain" & CStr(row.Index)

                Dim NT As String = DomainDatagrid(0, row.Index).Value
                Dim dns As String = DomainDatagrid(1, row.Index).Value
                Dim dc As String = DomainDatagrid(2, row.Index).Value
                Dim user As String = DomainDatagrid(3, row.Index).Value
                If Not String.IsNullOrEmpty(user) Then user = EncryptText.EncryptText(user)
                Dim pass As String = DomainDatagrid(4, row.Index).Value
                If Not String.IsNullOrEmpty(pass) Then pass = EncryptText.EncryptText(pass)

                Dim stringtoadd As String = NT & ";" & dns & ";" & dc & ";" & user & ";" & pass
                Registry.CurrentUser.OpenSubKey("Software\Forman", True).SetValue(keyname, stringtoadd, RegistryValueKind.String)
            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btnDomCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDomCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class