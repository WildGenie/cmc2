Imports System.Windows.Forms
Imports System.Management

Public Class SvcInfo

    Protected Friend FormLoading As Boolean
    Protected Friend CanPause As Boolean
    Protected Friend CanStop As Boolean
    Private InitialStartupMode As String

    ''' <summary>
    ''' Commits service start mode (if changed).
    ''' Closes form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        ' set start mode if changed...
        If Not InitialStartupMode = svcStartupCombo.Text Then
            Form1.Service_ChangeStartMode(Me.txtSvcName.Text, svcStartupCombo.Text)
            Form1.UpdateSelectedService(Form1.sGridRowNumber)
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SvcInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitialStartupMode = svcStartupCombo.Text
        ButtonsEnable()
    End Sub

    Private Sub btnSvcStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSvcStart.Click

        Dim count As Integer
        Me.Cursor = Cursors.AppStarting
        Me.progBar.Visible = True
        Me.progBar.Value = 0

        Form1.StartService(Me.txtSvcName.Text)

        Do While Me.lblSvcStatus.Text <> "Running"
            Me.progBar.Increment(100 / 15)

            Me.lblSvcStatus.Text = Form1.Get_ServiceState(Me.txtSvcName.Text)
            Form1.UpdateSelectedService(Form1.sGridRowNumber)
            System.Threading.Thread.Sleep(1000)
            If count >= 15 Then
                Exit Do
                MsgBox("Unable to start service within time.")
                Me.Close()
            End If
        Loop
        Do While Me.progBar.Value < 100
            Me.progBar.Increment(20)
            System.Threading.Thread.Sleep(100)
        Loop
        If Me.lblSvcStatus.Text = "Running" Then
            Me.btnSvcStop.Enabled = True
        End If
        ButtonsEnable()
        Me.Cursor = Cursors.Default
        Me.progBar.Visible = False

    End Sub

    Private Sub btnSvcStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSvcStop.Click

        Dim count As Integer
        Me.Cursor = Cursors.AppStarting
        Me.progBar.Visible = True
        Me.progBar.Value = 0

        Form1.StopService(Me.txtSvcName.Text)

        Do While Me.lblSvcStatus.Text <> "Stopped"
            Me.progBar.Increment(100 / 15)
            Me.lblSvcStatus.Text = Form1.Get_ServiceState(Me.txtSvcName.Text)
            Form1.UpdateSelectedService(Form1.sGridRowNumber)
            System.Threading.Thread.Sleep(1000)
            If count >= 15 Then
                Exit Do
                MsgBox("Unable to stop service within time.")
                Me.Close()
            End If
        Loop
        Do While Me.progBar.Value < 100
            Me.progBar.Increment(20)
            System.Threading.Thread.Sleep(100)
        Loop
        If Me.lblSvcStatus.Text = "Stopped" Then
            Me.btnSvcStart.Enabled = True
        End If
        ButtonsEnable()
        Me.Cursor = Cursors.Default
        Me.progBar.Visible = False

    End Sub

    Private Sub svcStartupCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svcStartupCombo.SelectedIndexChanged
        If Me.FormLoading = False Then
            Me.Cursor = Cursors.AppStarting
            Form1.Service_ChangeStartMode(txtSvcName.Text, svcStartupCombo.Text)
            Me.ButtonsEnable()
            Me.Cursor = Cursors.Default
        End If
    End Sub


    ''' <summary>
    ''' Enables/Disables control buttons depending 
    ''' upon the service abilities and the service state.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ButtonsEnable()
        Select Case lblSvcStatus.Text
            Case "Running"
                Me.btnSvcStart.Enabled = False
                If CanStop Then Me.btnSvcStop.Enabled = True
                Me.btnSvcPause.Enabled = CanPause
                Me.btnSvcResume.Enabled = False
                Me.picSvcStatus.Image = My.Resources.play
            Case "Start Pending"
                Me.btnSvcStart.Enabled = True
                Me.btnSvcStop.Enabled = False
                Me.btnSvcPause.Enabled = False
                Me.btnSvcResume.Enabled = False
                Me.picSvcStatus.Image = Nothing
            Case "Stopped"
                If svcStartupCombo.Text = "Disabled" Then
                    Me.btnSvcStart.Enabled = False
                Else
                    Me.btnSvcStart.Enabled = True
                End If
                Me.btnSvcStop.Enabled = False
                Me.btnSvcPause.Enabled = False
                Me.btnSvcResume.Enabled = False
                Me.picSvcStatus.Image = My.Resources._stop
            Case "Stop Pending"
                Me.btnSvcStart.Enabled = False
                Me.btnSvcStop.Enabled = True
                Me.btnSvcPause.Enabled = False
                Me.btnSvcResume.Enabled = False
                Me.picSvcStatus.Image = Nothing
            Case "Paused"
                Me.btnSvcStart.Enabled = False
                If CanStop Then Me.btnSvcStop.Enabled = True
                Me.btnSvcPause.Enabled = False
                Me.btnSvcResume.Enabled = True
                Me.picSvcStatus.Image = My.Resources.pause
            Case Else
                Me.btnSvcStart.Enabled = False
                Me.btnSvcStop.Enabled = False
                Me.btnSvcPause.Enabled = False
                Me.btnSvcResume.Enabled = False
                Me.picSvcStatus.Image = Nothing
        End Select
        '"Stopped"
        '"Start Pending"
        '"Stop Pending"
        '"Running"
        '"Continue Pending"
        '"Pause Pending"
        '"Paused"
        '"Unknown"
    End Sub



End Class
