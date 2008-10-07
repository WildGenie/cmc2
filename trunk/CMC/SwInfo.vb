Public Class SwInfo

    Private Sub btnUninstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUninstall.Click
        Form1.UninstallSoftware(Me.swHostname.Text, Me.swuninstsilent.Text)
    End Sub

    Private Sub swURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles swURL.LinkClicked
        On Error Resume Next
        If Not String.IsNullOrEmpty(Me.swURL.Text) Then
            System.Diagnostics.Process.Start(Me.swURL.Text)
        End If
    End Sub

    Private Sub SwInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' PictureBox1.Image = Drawing.Icon.ExtractAssociatedIcon("file.exe").ToBitmap()

        'Dim x As Integer = 1
        ''img is an imagelist
        'For Each ico As Image In img.Images
        '    x = x + 1
        '    pb1.Image = ico
        '    Application.DoEvents()
        '    ico.Save(apath & "icons\" & IO.Path.GetFileName(fil) & x & ".ico", System.Drawing.Imaging.ImageFormat.Icon)
        'Next
    End Sub
End Class