Imports System.Windows.Forms

Public Class ChangeSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub labelcolour1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelcolour1.Click
        Me.ColorDialog1.ShowDialog()
        labelcolour1.Text = "Colour: " & ColorDialog1.Color.Name
        labelcolour1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub labelcolour2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles labelcolour2.Click
        Me.ColorDialog1.ShowDialog()
        labelcolour2.Text = "Colour: " & ColorDialog1.Color.Name
        labelcolour2.ForeColor = ColorDialog1.Color
    End Sub
End Class
