Imports System.Windows.Forms

Public Class RecordingDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ListBoxDiskInstance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxDiskInstance.SelectedIndexChanged
        If Not Me.ListBoxDiskInstance.SelectedItems Is Nothing Then
            Me.cDsk1.Enabled = True
            Me.cDsk2.Enabled = True
            Me.cDsk3.Enabled = True
        End If
    End Sub

    Private Sub comboNICInstance_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboNICInstance.SelectedIndexChanged
        If Me.comboNICInstance.Text = " - select instance -" Then
            cNic.Enabled = False
        Else
            cNic.Enabled = True
        End If
    End Sub
End Class
