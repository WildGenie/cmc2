Imports System.Windows.Forms

Public Class ProcInfo

    Dim pstat As New System.Threading.Thread(AddressOf Me.Caller_GetProcessStats)
    Dim Timer1 As New Timer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        pstat.Join()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        pstat.Join()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ProcInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProcOwner.Text = Form1.ProcessOwnerById(Me.txtProcPid.Text)

        pstat.Start()
    End Sub

    Private Sub Caller_GetProcessStats()

        '    Dim timersetting As Integer = 5000
        '    Timer1.Interval = timersetting
        '    Timer1.Start()

    End Sub


    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick


    '    Me.txtProcPid.Text = Now.ToLongTimeString.ToString()


    'End Sub

    'Private Sub GetProcessStats()
    '    If bScanning = False Then
    '        'RunPingTest()
    '    Else
    '        MsgBox("scan already in progress", MsgBoxStyle.SystemModal + MsgBoxStyle.OkOnly, "online alert")
    '    End If
    'End Sub
End Class



