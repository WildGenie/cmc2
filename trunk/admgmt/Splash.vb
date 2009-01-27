Imports System.Windows.Forms

Public Class Splash

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    'Private Sub Splash_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    '    Me.Opacity = 1
    '    For i As Double = 1 To 100
    '        Me.Opacity = 1
    '        Me.Refresh()
    '        System.Threading.Thread.Sleep(10)
    '    Next
    'End Sub
End Class
