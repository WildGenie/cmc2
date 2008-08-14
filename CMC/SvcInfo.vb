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
        Form1.StartService(Me.txtSvcName.Text)
        Dim count As Integer
        Me.Cursor = Cursors.AppStarting
        Do While Me.lblSvcStatus.Text <> "Running"
            Me.lblSvcStatus.Text = Form1.Get_ServiceState(Me.txtSvcName.Text)
            Form1.UpdateSelectedService(Form1.sGridRowNumber)
            System.Threading.Thread.Sleep(1000)
            If count >= 15 Then Exit Do
        Loop
        ButtonsEnable()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSvcStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSvcStop.Click
        Form1.StopService(Me.txtSvcName.Text)
        Dim count As Integer
        Me.Cursor = Cursors.AppStarting
        Do While Me.lblSvcStatus.Text <> "Stopped"
            Me.lblSvcStatus.Text = Form1.Get_ServiceState(Me.txtSvcName.Text)
            Form1.UpdateSelectedService(Form1.sGridRowNumber)
            System.Threading.Thread.Sleep(1000)
            If count >= 15 Then Exit Do
        Loop
        ButtonsEnable()
        Me.Cursor = Cursors.Default
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
                Me.btnSvcStart.Enabled = True
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
