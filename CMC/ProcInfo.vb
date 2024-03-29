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

        If Not Me.lblNoProcess.Text = "Process Not Found" Then

            ' determine refresh rate according to initial time taken to process
            totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - start, 4)
            If totaltime < 0.4 Then
                Timer1.Interval = 2000
            ElseIf totaltime < 1 Then
                Timer1.Interval = 4000
            ElseIf totaltime < 2 Then
                Timer1.Interval = 5000
            ElseIf totaltime < 4 Then
                Timer1.Interval = 10000
            ElseIf totaltime < 8 Then
                Timer1.Interval = 15000
            Else
                Timer1.Interval = CInt(totaltime) * 4000
            End If
            Me.lblTick.Text = "Refresh Rate: " & (Timer1.Interval / 1000).ToString & " s"


            ' wmi provider appears to change unit for some items/os's 
            ' from bytes to kb (or something)
            ' so need to add custom divisor for some items.
            ' WorkingSet always seems to be accurate, so use that as 
            ' a basis for checking...
            ' determine correct value for PeakWorkingSet and pagefile
            If CInt(Me.txtPeakWorkingSet.Text) / CInt(Me.txtWorkingSet.Text) > 1000 Then
                KBDivider = 1024
                Me.txtPeakWorkingSet.Text = CInt(Me.txtPeakWorkingSet.Text / KBDivider)
                Me.txtPageFile.Text = CInt(Me.txtPageFile.Text / KBDivider)
                Me.txtPeakPageFile.Text = CInt(Me.txtPeakPageFile.Text / KBDivider)
            End If

            ' start the clock ticking
            Timer1.Start()

        End If


        Try
            PictureBox2.Image = Drawing.Icon.ExtractAssociatedIcon(txtProcPath.Text).ToBitmap
        Catch ex As Exception
        End Try


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
                    Me.txtWorkingSet.Text = FormatNumber(CInt(m("WorkingSetSize") / 1024), 0, TriState.True)
                    Me.txtPeakWorkingSet.Text = FormatNumber(CInt(m("PeakWorkingSetSize") / KBDivider), 0, TriState.True)
                    Me.txtPageFile.Text = FormatNumber(CInt(m("PageFileUsage") / KBDivider), 0, TriState.True)
                    Me.txtPeakPageFile.Text = FormatNumber(CInt(m("PeakPageFileUsage") / KBDivider), 0, TriState.True)
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

    Private Sub Button_Kill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Kill.Click

        Me.Button_Kill.Enabled = False
        Me.gbProcResources.Enabled = False

        If Form1.WMI_Kill_Process(CInt(Me.txtProcPid.Text)) Then

            Dim processalive As Boolean = True
            Dim count As Integer = 0

            Do While processalive
                processalive = Form1.IsProcessRunning(CInt(Me.txtProcPid.Text))
                System.Threading.Thread.Sleep(1000)
                count += 1
                If count > 10 Then
                    Exit Do
                End If
            Loop

            If Not processalive Then

                Timer1.Stop()
                Me.lblNoProcess.Text = "Process Terminated Successfully"
                Me.lblNoProcess.Visible = True

                ' remove row from listview_processes.
                For Each row As ListViewItem In Form1.ListView_Processes.Items
                    If row.SubItems(1).Text = Me.txtProcPid.Text Then
                        row.Remove()
                        Exit For
                    End If
                Next

                Form1.pGrid_Name = Nothing
                Form1.pGrid_ID = Nothing
                Form1.pGrid_Path = Nothing
            Else
                ''  Panel2.Text = "process not yet terminated"
                MsgBox("Process was successfully sent a kill command" & vbCr & "but is still running", MsgBoxStyle.Information, "CMC - Kill Process")
            End If
        Else
            MsgBox("Process kill command failed" & vbCr & "see log for details", MsgBoxStyle.Exclamation, "CMC - Kill Process")
        End If

    End Sub

    'Private Sub ProcInfo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    '    For i As Integer = 0 To 100 Step 10
    '        Me.Opacity = i / 100
    '        System.Threading.Thread.Sleep(10)
    '        Me.Refresh()
    '    Next
    'End Sub
End Class



