Imports System.Windows.Forms

Public Class VNCDialog

    Protected Friend IsWMIConnected As Boolean
    Protected Friend IsLoggedOn As Boolean

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub VNCDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.vncCombo.SelectedIndex = 0
    End Sub

    Private Sub vncCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vncCombo.SelectedIndexChanged

        If Me.vncCombo.SelectedIndex >= 1 AndAlso Me.IsWMIConnected = False Then
            MsgBox("You need to make a connection to the computer" & vbCr & "before you can install VNC.", MsgBoxStyle.Critical, "CMC - VNC Connection")
            Me.vncCombo.SelectedIndex = 0
            Exit Sub
        End If

        If Me.vncCombo.SelectedIndex = 1 AndAlso Me.IsLoggedOn = False Then
            If MsgBox("No one is logged on to the remote computer." & vbCr & vbCr & "Are you sure you want to prompt for a connection?.", 36, "CMC - VNC Connection") = vbNo Then
                Me.vncCombo.SelectedIndex = 2
            End If
        End If

        If Me.vncCombo.SelectedIndex = 2 AndAlso Me.IsLoggedOn = True Then
            If MsgBox("You should have permission from the person logged on to the remote computer" & vbCr & "before making a connection." & vbCr & vbCr & "Do you want to prompt the user to accept the connection?", 36, "CMC - VNC Connection") = vbYes Then
                Me.vncCombo.SelectedIndex = 1
            End If
        End If

    End Sub
End Class
