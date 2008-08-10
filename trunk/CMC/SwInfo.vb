Public Class SwInfo

    Private Sub btnUninstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUninstall.Click
        Form1.UninstallSoftware(Me.swHostname.Text, Me.swuninst.Text)
    End Sub

    Private Sub swURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles swURL.LinkClicked
        On Error Resume Next
        If Not String.IsNullOrEmpty(Me.swURL.Text) Then
            System.Diagnostics.Process.Start(Me.swURL.Text)
        End If
    End Sub
End Class