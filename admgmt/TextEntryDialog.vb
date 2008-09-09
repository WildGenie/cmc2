Imports System.Windows.Forms

Public Class TextEntryDialog

    Protected Friend searchstring As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.searchstring = Me.txtSearch.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TextEntryDialog_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtSearch.Focus()
    End Sub

    Private Sub TextEntryDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Focus()
    End Sub
End Class
