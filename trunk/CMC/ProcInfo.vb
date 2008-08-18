Imports System.Windows.Forms
Imports System.management

Public Class ProcInfo

    Private KBDivider As Integer
    Private PWS_vb As Integer
    Private PWS_wmi As Integer

    Private Sub ProcInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If System.Diagnostics.Debugger.IsAttached Then Me.wmiCheckbox.Visible = True

        ' get the owner of the process
        Me.txtProcOwner.Text = Form1.ProcessOwnerById(Me.txtProcPid.Text)
        If Me.txtProcOwner.Text = "\" Then Me.txtProcOwner.Text = ""

        ' time first run of process stat enumeration
        Dim start, totaltime As Double
        start = Microsoft.VisualBasic.DateAndTime.Timer


        ' Retrieve initial values
        KBDivider = 1
        GetProcessStats()


        ' determine refresh rate according to initial time taken to process
        totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - start, 4)
        If totaltime < 0.4 Then
            Timer1.Interval = 2000
        ElseIf totaltime < 1 Then
            Timer1.Interval = 4000
        Else
            Timer1.Interval = totaltime * 4000
        End If
        Me.lblTick.Text = "Refresh Rate: " & (Timer1.Interval / 1000).ToString & " s"


        ' wmi provider appears to change unit for some items from bytes to kb (or something)
        ' so need to add custom divisor for some items.
        ' determine correct value for wmi PeakWorkingSet and pagefile (use vb value as target value
        PWS_vb = CInt(GetPeakWorkingSetKB(pc.Name, Me.txtProcPid.Text))
        PWS_wmi = CInt(Me.txtPeakWorkingSet.Text)
        If PWS_vb = 0 Then
            KBDivider = 1
        Else
            Dim ratio As Long = PWS_vb / PWS_wmi
            If ratio > 0 And ratio < 0.01 Then
                KBDivider = 1024
            ElseIf ratio > 0.8 And ratio < 1.2 Then
                KBDivider = 1
            ElseIf ratio > 800 And ratio < 1200 Then
                KBDivider = 1 / 1024
            End If
        End If

        ' start the clock ticking
        Timer1.Start()

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Timer1.Stop()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
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
                    Me.txtPeakWorkingSet.Text = CInt(m("PeakWorkingSetSize") / KBDivider) ' K
                    Me.txtPageFile.Text = CInt(m("PageFileUsage") / KBDivider) ' K
                    Me.txtPeakPageFile.Text = CInt(m("PeakPageFileUsage") / KBDivider)
                    Me.txtCPUTime.Text = CInt((m("UserModeTime") + m("KernelModeTime")) / 10000000) ' 100ns unit - to convert to mins /600,000,000
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
        ' Me.txtCPUTime.Text = Process.GetProcessById(CInt(Me.txtProcPid.Text), pc.Name).TotalProcessorTime.Seconds
    End Sub

    Private Function GetPeakWorkingSetKB(ByVal Computer As String, ByVal PID As Integer) As Long
        Try
            Return Process.GetProcessById(PID, Computer).PeakWorkingSet64 / 1024
        Catch ex As Exception
            Return 0
        End Try
    End Function


End Class



