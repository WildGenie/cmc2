Imports System.Windows.Forms
Imports System.management

Public Class ProcInfo

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Timer1.Stop()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ProcInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If System.Diagnostics.Debugger.IsAttached Then Me.wmiCheckbox.Visible = True

        ' get the owner of the process
        Me.txtProcOwner.Text = Form1.ProcessOwnerById(Me.txtProcPid.Text)
        If Me.txtProcOwner.Text = "\" Then Me.txtProcOwner.Text = ""

        ' time first run of process stat enumeration
        Dim start, totaltime As Double
        start = Microsoft.VisualBasic.DateAndTime.Timer

        GetProcessStats()

        totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - start, 4)

        ' determine refresh rate according to initial time taken to process
        If totaltime < 0.3 Then
            Timer1.Interval = 1000
        ElseIf totaltime < 0.75 Then
            Timer1.Interval = 2000
        Else
            Timer1.Interval = totaltime * 3000
        End If
        Me.lblTick.Text = "Refresh Rate: " & (Timer1.Interval / 1000).ToString & " s"

        Timer1.Start()
    End Sub

    Private Sub timer1_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If wmiCheckbox.Checked Then
            GetProcessStats()
        Else
            GetProcessStats_Vb()
        End If

    End Sub

    Private Sub GetProcessStats()

        Try
            Dim queryCollection As ManagementObjectCollection
            queryCollection = Form1.wmi.wmiQuery _
               ("SELECT HandleCount, WorkingSetSize, PeakWorkingSetSize,PageFileUsage,PeakPageFileUsage,UserModeTime, KernelModeTime FROM Win32_Process WHERE ProcessID='" & CInt(Me.txtProcPid.Text) & "'")
            Dim m As ManagementObject
            If queryCollection.Count = 0 Then
                Timer1.Stop()
                Timer1.Enabled = False
                Me.txtHandleCount.Text = ""
                Me.txtWorkingSet.Text = ""
                Me.txtPeakWorkingSet.Text = ""
                Me.txtPageFile.Text = ""
                Me.txtCPUTime.Text = ""
                Me.txtPeakPageFile.Text = ""
                Me.lblNoProcess.Text = "Process Not Found"
                Me.lblNoProcess.Visible = True
            Else
                For Each m In queryCollection
                    Me.txtHandleCount.Text = m("HandleCount")
                    Me.txtWorkingSet.Text = CInt(m("WorkingSetSize") / 1024)  ' b?  
                    Me.txtPeakWorkingSet.Text = m("PeakWorkingSetSize") / 1024 ' K
                    Me.txtPageFile.Text = m("PageFileUsage") / 1024 ' K
                    Me.txtPeakPageFile.Text = m("PeakPageFileUsage") / 1024
                    Me.txtCPUTime.Text = CInt((m("UserModeTime") + m("KernelModeTime")) / 10000000) ' 100ns unit - to convert to mins / 600,000,000
                Next
            End If
        Catch ex As Exception
            Timer1.Stop()
            Timer1.Enabled = False
            Me.txtHandleCount.Text = ""
            Me.txtWorkingSet.Text = ""
            Me.txtPeakWorkingSet.Text = ""
            Me.txtPageFile.Text = ""
            Me.txtCPUTime.Text = ""
            Me.txtPeakPageFile.Text = ""
            Me.lblNoProcess.Text = "Error retrieving process information"
            Me.lblNoProcess.Visible = True
        End Try

    End Sub

    Private Sub GetProcessStats_Vb()

        
        Me.txtHandleCount.Text = Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).HandleCount
        Me.txtWorkingSet.Text = CInt(Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).WorkingSet64 / 1024)
        Me.txtPeakWorkingSet.Text = CInt(Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).PeakWorkingSet64 / 1024)
        Me.txtPageFile.Text = CInt(Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).PagedMemorySize64 / 1024)
        Me.txtPeakPageFile.Text = CInt(Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).PeakPagedMemorySize64 / 1024)
        'Me.txtCPUTime.Text = Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).TotalProcessorTime.TotalSeconds 'CInt((m("UserModeTime") + m("KernelModeTime")) / 10000000)
    End Sub

End Class



