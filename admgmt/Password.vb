Imports System.Windows.Forms


Public Class Password

    Protected Friend NewPassword As String
    Protected Friend ForcePwdChange As Boolean

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.txtPass1.Text <> Me.txtPass2.Text Then
            MsgBox("The New and Confirm passwords must match. Please re-type them.", MsgBoxStyle.Critical, "AD User Manager")
            Return
        End If

        NewPassword = Me.txtPass1.Text
        Me.ForcePwdChange = ForceChange.Checked
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
