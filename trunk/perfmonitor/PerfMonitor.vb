Public Class PerfMonitor

    Private cpu, mem, MemPages, NetBytesSec, dskTime, dskReadQ, dskWriteQ, diskReadBytes, diskWriteBytes, dskTime2, dskReadQ2, dskWriteQ2, diskReadBytes2, diskWriteBytes2, dskTime3, dskReadQ3, dskWriteQ3, diskReadBytes3, diskWriteBytes3 As PerformanceCounter
    Private totalMemory As Integer
    Private FirstRun As Boolean
    Private DiskInstance1 As String = "_Total"
    Private DiskInstance2 As String = Nothing
    Private DiskInstance3 As String = Nothing
    Private NetInstance As String = Nothing
    Protected Friend loading As Boolean
    Protected Friend Username As String = Nothing
    Protected Friend Password As String = Nothing
    Private CriticalError As Boolean = False
    Private RecordingFileName

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Start()
    End Sub
    Private Sub Start(Optional ByVal GetMemory As Boolean = True)
        Me.btnStart.Enabled = False
        If Me.computername.Text = "" Then Me.computername.Text = My.Computer.Name

        If GetMemory Then
            'Get System Memory Information
            Me.Cursor = Cursors.AppStarting
            Me.totalMemory = GetPhysicalMemory(Me.computername.Text)
            Me.Cursor = Cursors.Default
            If totalMemory = -1 Then Return
        End If

        FirstRun = True
        PerfMonTimer.Enabled = True
        PerfMonTimer.Interval = TimeValue.Value * 1000
        PerfMonTimer.Start()

        Try
            cpu = New PerformanceCounter("Processor", "% Processor Time", "_Total", Me.computername.Text)
        Catch ex As Exception
            PerfMonTimer.Stop()
            PerfMonTimer.Enabled = False
            MsgBox("An error occurred while requesting" & vbCr & _
                   "performance information from " & Me.computername.Text & _
                   vbCr & vbCr & "The application will be closed.", MsgBoxStyle.Critical, "Perf Mon Error")
            Me.Close()
            End
        End Try

        mem = New PerformanceCounter("Memory", "Available MBytes", "", Me.computername.Text)
        MemPages = New PerformanceCounter("Memory", "Pages Input/sec", "", Me.computername.Text)
        NetBytesSec = New PerformanceCounter("Network Interface", "Bytes Total/sec", "", Me.computername.Text)
        dskTime = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance1, Me.computername.Text)
        dskReadQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance1, Me.computername.Text)
        dskWriteQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance1, Me.computername.Text)
        diskReadBytes = New PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", Me.DiskInstance1, Me.computername.Text)
        diskWriteBytes = New PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", Me.DiskInstance1, Me.computername.Text)

        dskTime2 = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance2, Me.computername.Text)
        dskReadQ2 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance2, Me.computername.Text)
        dskWriteQ2 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance2, Me.computername.Text)
        diskReadBytes2 = New PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", Me.DiskInstance2, Me.computername.Text)
        diskWriteBytes2 = New PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", Me.DiskInstance2, Me.computername.Text)

        dskTime3 = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance3, Me.computername.Text)
        dskReadQ3 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance3, Me.computername.Text)
        dskWriteQ3 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance3, Me.computername.Text)
        diskReadBytes3 = New PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", Me.DiskInstance3, Me.computername.Text)
        diskWriteBytes3 = New PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", Me.DiskInstance3, Me.computername.Text)

        Me.Text = Me.computername.Text.ToUpper
        Me.btnStart.Enabled = False
        Me.btnStop.Enabled = True
        Me.computername.Enabled = False
        Me.btnStop.Focus()

        Me.loading = False

    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        If Me.Recording Then
            Recording = False
            Writer.Close()
        End If
        Me.RecordingButton.Enabled = False
        PerfMonTimer.Stop()
        PerfMonTimer.Enabled = False
        labelCPU.Text = ""
        LabelMem.Text = ""
        LabelDisk.Text = ""
        Me.btnStart.Enabled = True
        Me.btnStop.Enabled = False
        Me.computername.Enabled = True
        Me.Text = "PerfMonitor"
        Me.btnStart.Focus()
    End Sub

    Private Sub PerfMonTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerfMonTimer.Tick

        ' time first run of process stat enumeration
        Dim start, totaltime As Double
        If FirstRun Then
            start = Microsoft.VisualBasic.DateAndTime.Timer
        End If

        ' custom colours
        Dim cpucolor As Color = Color.FromArgb(0, 255, 0)
        Dim memColor As Color = Color.FromArgb(0, 255, 0) 'Color.RoyalBlue
        Dim dskColor As Color = Color.FromArgb(0, 255, 0)

        Dim cpuvalue As Byte
        Try
            cpuvalue = cpu.NextValue
            labelCPU.Text = cpuvalue & "%"
            UpdatePercentGraph(cpuvalue, Pic1, cpucolor)
        Catch ex As Exception
            PerfMonTimer.Stop()
            PerfMonTimer.Enabled = False
            MsgBox("An error occurred while requesting" & vbCr & _
                   "performance information from " & Me.computername.Text & _
                   vbCr & vbCr & "The application will be closed.", MsgBoxStyle.Critical, "Performance Monitor Error")
            Me.Close()
            End
        End Try

        '  ----  % Memory Utilisation  ---------
        Dim memValue As Single = mem.NextValue
        If memValue > 0 Then
            memValue = CInt(100 * (totalMemory - memValue) / totalMemory)
        End If
        LabelMem.Text = memValue & "%"
        UpdatePercentGraph(memValue, Pic2, memColor)

        '  ---  Pages   ------------------
        Dim mempagesValue As Single
        If Me._mempages Then mempagesValue = Me.MemPages.NextValue

        '  ---  NIC   -----
        Dim nicValue As Single = 0
        If Not Me.NetInstance Is Nothing Then
            nicValue = Me.NetBytesSec.NextValue
        End If

        ' ----  % Disk Time  -------------
        Dim dsktimeValue As Integer
        Dim ReadQ As Single
        Dim WriteQ As Single
        Dim DiskReadKbSec As Integer
        Dim DiskWriteKbSec As Integer
        If Not Me.DiskInstance1 Is Nothing Then
            dsktimeValue = CInt(dskTime.NextValue)
            LabelDisk.Text = dsktimeValue & "%"
            If dsktimeValue > 100 Then
                dsktimeValue = 100
            End If
            '  Disk Read & Write
            ReadQ = dskReadQ.NextValue
            WriteQ = dskWriteQ.NextValue
            DiskReadKbSec = CInt(Me.diskReadBytes.NextValue / 1024)
            DiskWriteKbSec = CInt(Me.diskWriteBytes.NextValue / 1024)

            UpdatePercentGraph(dsktimeValue, Pic3, dskColor)
        End If

        Dim dsktimeValue2 As Integer
        Dim ReadQ2 As Single
        Dim WriteQ2 As Single
        Dim DiskReadKbSec2 As Integer
        Dim DiskWriteKbSec2 As Integer
        If Not Me.DiskInstance2 Is Nothing Then
            dsktimeValue2 = CInt(dskTime2.NextValue)
            LabelDisk.Text = dsktimeValue2 & "%"
            If dsktimeValue2 > 100 Then
                dsktimeValue2 = 100
            End If

            '  Disk Read & Write
            ReadQ2 = dskReadQ2.NextValue
            WriteQ2 = dskWriteQ2.NextValue
            DiskReadKbSec2 = CInt(Me.diskReadBytes2.NextValue / 1024)
            DiskWriteKbSec2 = CInt(Me.diskWriteBytes2.NextValue / 1024)
        End If

        Dim dsktimeValue3 As Integer
        Dim ReadQ3 As Single
        Dim WriteQ3 As Single
        Dim DiskReadKbSec3 As Integer
        Dim DiskWriteKbSec3 As Integer
        If Not Me.DiskInstance3 Is Nothing Then
            dsktimeValue3 = CInt(dskTime3.NextValue)
            LabelDisk.Text = dsktimeValue3 & "%"
            If dsktimeValue3 > 100 Then
                dsktimeValue3 = 100
            End If

            '  Disk Read & Write
            ReadQ3 = dskReadQ3.NextValue
            WriteQ3 = dskWriteQ3.NextValue
            DiskReadKbSec3 = CInt(Me.diskReadBytes3.NextValue / 1024)
            DiskWriteKbSec3 = CInt(Me.diskWriteBytes3.NextValue / 1024)
        End If


        If Recording Then

            Dim sLine As String = CInt(cpuvalue) & "," & CInt(memValue) & ","

            If Me._mempages Then
                sLine = sLine & CInt(mempagesValue) & ","
            Else
                sLine = sLine & "0,"
            End If
            If Me._nic Then
                sLine = sLine & CInt(nicValue) & ","
            Else
                sLine = sLine & "0,"
            End If

            If Not Me.DiskInstance1 Is Nothing Then
                If Me._dsk1 Then
                    sLine = sLine & CInt(dsktimeValue) & ","
                Else
                    sLine = sLine & "0,"
                End If
                If Me._dsk2 Then
                    sLine = sLine & ReadQ & "," & WriteQ & ","
                Else
                    sLine = sLine & "0,0,"
                End If
                If Me._dsk3 Then
                    sLine = sLine & DiskReadKbSec & "," & DiskWriteKbSec
                Else
                    sLine = sLine & "0,0"
                End If
            End If
            If Not Me.DiskInstance2 Is Nothing Then
                sLine = sLine & ","
                If Me._dsk1 Then
                    sLine = sLine & CInt(dsktimeValue2) & ","
                Else
                    sLine = sLine & "0,"
                End If
                If Me._dsk2 Then
                    sLine = sLine & ReadQ2 & "," & WriteQ2 & ","
                Else
                    sLine = sLine & "0,0,"
                End If
                If Me._dsk3 Then
                    sLine = sLine & DiskReadKbSec2 & "," & DiskWriteKbSec2
                Else
                    sLine = sLine & "0,0"
                End If
            End If
            If Not Me.DiskInstance3 Is Nothing Then
                sLine = sLine & ","
                If Me._dsk1 Then
                    sLine = sLine & CInt(dsktimeValue3) & ","
                Else
                    sLine = sLine & "0,"
                End If
                If Me._dsk2 Then
                    sLine = sLine & ReadQ2 & "," & WriteQ3 & ","
                Else
                    sLine = sLine & "0,0,"
                End If
                If Me._dsk3 Then
                    sLine = sLine & DiskReadKbSec2 & "," & DiskWriteKbSec3
                Else
                    sLine = sLine & "0,0"
                End If
            End If

            Me.Recording_Write_Line(sLine)

        End If

        If FirstRun Then
            totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - start, 5)
            'Debug.Print(totaltime)
            Me.TimeValue.Value = CInt(totaltime) + 1
            FirstRun = False
            Me.RecordingButton.Enabled = True
        End If


    End Sub
    Private Sub UpdatePercentGraph(ByVal FillPercent As Integer, ByVal PicBox As PictureBox, ByVal BaseColour As Color)

        'Create graphic to draw
        Dim g As Drawing.Graphics
        Dim bmp As New Bitmap(PicBox.Width, PicBox.Height)
        g = Graphics.FromImage(bmp)

        'Create path & brush for gradient
        Dim path As New Drawing2D.GraphicsPath
        Dim brush As New Drawing2D.LinearGradientBrush(New PointF(0, PicBox.Height), New PointF(0, 0), BaseColour, Color.FromArgb(255 / 100 * FillPercent, 255 / 100 * (100 - FillPercent), 0))

        'Add Rectangle with "CPU Data" to graphic
        path.AddRectangle(New Drawing.Rectangle(0, PicBox.Height / 100 * (100 - FillPercent), PicBox.Width, PicBox.Height / 100 * FillPercent))

        'Fill the path
        g.FillPath(brush, path)

        'Set the image to our drawn one
        PicBox.Image = bmp

        'Free resources
        g.Dispose()
    End Sub
    Private Sub Pic3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pic3.DoubleClick

        If String.IsNullOrEmpty(computername.Text) Then
            MsgBox("Enter a computer name to monitor" & vbCr & "before selecting instance.", MsgBoxStyle.Critical, "Select Instance")
            Return
        End If

        If Me.Recording Then
            MsgBox("Selected instance cannot be changed whilst" & vbCr & "data is being recorded." & vbCr & vbCr & _
                   "Stop recording before changing instances.", MsgBoxStyle.Critical, "Select Instance")
            Return
        End If

        Dim si As New SelectInstance

        Dim category As New PerformanceCounterCategory("PhysicalDisk", computername.Text)
        Dim instances() As String = category.GetInstanceNames
        For Each instance As String In instances
            si.InstanceCombo.Items.Add(instance)
        Next
        si.InstanceCombo.Text = Me.DiskInstance1
        si.ShowDialog()

        If si.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.DiskInstance1 = si.InstanceCombo.Text
            dskTime = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance1, Me.computername.Text)
            dskReadQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance1, Me.computername.Text)
            dskWriteQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance1, Me.computername.Text)
        End If
        

    End Sub

    Private Recording As Boolean = False
    Private Writer As System.IO.StreamWriter
    Private _cpu, _mem, _mempages, _nic, _dsk1, _dsk2, _dsk3 As Boolean
    Private Sub RecordingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordingButton.Click
        If Recording = False Then
            Dim rd As New RecordingDialog

            ' fill instances for disk and network
            Dim category As New PerformanceCounterCategory("PhysicalDisk", computername.Text)
            Dim instances() As String = category.GetInstanceNames
            For Each instance As String In instances
                rd.ListBoxDiskInstance.Items.Add(instance)
            Next

            category = New PerformanceCounterCategory("Network Interface", computername.Text)
            instances = category.GetInstanceNames
            For Each instance As String In instances
                rd.comboNICInstance.Items.Add(instance)
            Next
            rd.comboNICInstance.Text = " - select instance -"

            rd.ShowDialog()
            rd.TopMost = True
            If rd.DialogResult = Windows.Forms.DialogResult.OK Then
                TimeValue.Value = rd.NumericUpDown1.Value


                ' Get Selected items for performance counters

                _cpu = rd.cCPU.Checked
                _mem = rd.cMem.Checked
                _mempages = rd.cMemPages.Checked

                If rd.cNic.Checked Then
                    _nic = True
                    Me.NetInstance = rd.comboNICInstance.Text
                    NetBytesSec = New PerformanceCounter("Network Interface", "Bytes Total/sec", Me.NetInstance, Me.computername.Text)
                End If

                Dim i As Integer = 1
                For Each item As String In rd.ListBoxDiskInstance.SelectedItems

                    If i = 1 Then
                        Me.DiskInstance1 = item
                        dskTime = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance1, Me.computername.Text)
                        dskReadQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance1, Me.computername.Text)
                        dskWriteQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance1, Me.computername.Text)
                        diskReadBytes = New PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", Me.DiskInstance1, Me.computername.Text)
                        diskWriteBytes = New PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", Me.DiskInstance1, Me.computername.Text)
                    End If

                    If i = 2 Then
                        Me.DiskInstance2 = item
                        dskTime2 = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance2, Me.computername.Text)
                        dskReadQ2 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance2, Me.computername.Text)
                        dskWriteQ2 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance2, Me.computername.Text)
                        diskReadBytes2 = New PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", Me.DiskInstance2, Me.computername.Text)
                        diskWriteBytes2 = New PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", Me.DiskInstance2, Me.computername.Text)
                    End If

                    If i = 3 Then
                        Me.DiskInstance3 = item
                        dskTime3 = New PerformanceCounter("PhysicalDisk", "% Disk Time", Me.DiskInstance3, Me.computername.Text)
                        dskReadQ3 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", Me.DiskInstance3, Me.computername.Text)
                        dskWriteQ3 = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", Me.DiskInstance3, Me.computername.Text)
                        diskReadBytes3 = New PerformanceCounter("PhysicalDisk", "Disk Read Bytes/sec", Me.DiskInstance3, Me.computername.Text)
                        diskWriteBytes3 = New PerformanceCounter("PhysicalDisk", "Disk Write Bytes/sec", Me.DiskInstance3, Me.computername.Text)
                    End If

                    If i = 4 Then
                        MsgBox("Max 3 instances")
                    End If
                    i += 1
                Next

                _dsk1 = rd.cDsk1.Checked
                _dsk2 = rd.cDsk2.Checked
                _dsk3 = rd.cDsk3.Checked

                Me.Recording = True
                Dim path As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                Dim starttime As String = Replace(DateTime.Now.ToShortDateString, "/", "") & "_" & Replace(DateTime.Now.ToShortTimeString, ":", "") & DateTime.Now.Second
                Me.RecordingFileName = path & "\Perfmon_" & UCase(computername.Text) & "_" & starttime & ".pff"
                Writer = New System.IO.StreamWriter(Me.RecordingFileName, False)
                Writer.WriteLine(computername.Text & " Recording started: " & DateTime.Now)

                'Dim HeaderRow As String = "Time,CPU_%,RAM_%,Memory&Pages_InputPerSec,Network_BytesPerSec_" & Me.NetInstance

                Dim HeaderRow As String = "Time,"
                If _cpu Then
                    HeaderRow = HeaderRow & "CPU_%_1,"
                Else
                    HeaderRow = HeaderRow & "CPU_%_0,"
                End If
                If _mem Then
                    HeaderRow = HeaderRow & "RAM_%_1,"
                Else
                    HeaderRow = HeaderRow & "RAM_%_0,"
                End If
                If _mempages Then
                    HeaderRow = HeaderRow & "Memory&Pages_InputPerSec_1,"
                Else
                    HeaderRow = HeaderRow & "Memory&Pages_InputPerSec_0,"
                End If
                If _nic Then
                    HeaderRow = HeaderRow & "Network_BytesPerSec_" & Me.NetInstance & ","
                Else
                    HeaderRow = HeaderRow & "Network_BytesPerSec_0,"
                End If


                If Not Me.DiskInstance1 Is Nothing Then HeaderRow = HeaderRow & "DiskTime_%_" & Me.DiskInstance1 & _
                                                                                ",Read&Queue_Length_" & Me.DiskInstance1 & _
                                                                                ",Write&Queue_Length_" & Me.DiskInstance1 & _
                                                                                ",Disk&Read_kbs_" & Me.DiskInstance1 & _
                                                                                ",Disk&Write_kbs_" & Me.DiskInstance1

                If Not Me.DiskInstance2 Is Nothing Then HeaderRow = HeaderRow & ",DiskTime_%_" & Me.DiskInstance2 & _
                                                                                ",Read&Queue_Length_" & Me.DiskInstance2 & _
                                                                                ",Write&Queue_Length_" & Me.DiskInstance2 & _
                                                                                ",Disk&Read_kbs_" & Me.DiskInstance2 & _
                                                                                ",Disk&Write_kbs_" & Me.DiskInstance2

                If Not Me.DiskInstance3 Is Nothing Then HeaderRow = HeaderRow & ",DiskTime_%_" & Me.DiskInstance3 & _
                                                                                ",Read&Queue_Length_" & Me.DiskInstance3 & _
                                                                                ",Write&Queue_Length_" & Me.DiskInstance3 & _
                                                                                ",Disk&Read_kbs_" & Me.DiskInstance3 & _
                                                                                ",Disk&Write_kbs_" & Me.DiskInstance3
                Writer.WriteLine(HeaderRow)

                Writer.Flush()

                Me.ToolTip1.SetToolTip(Me.RecordingButton, "stop capturing performance data")
                Me.RecordingButton.Text = "stop recording"
                Me.RecordingStatusLabel.Visible = True
                Me.RecordingStatusLabel.Text = "recording"
            End If
        Else
            Recording = False
            Writer.Close()
            Me.RecordingStatusLabel.Text = String.Empty
            Me.RecordingButton.Text = "start recording"
            Me.ToolTip1.SetToolTip(Me.RecordingButton, "record the performance data to file")

            '    ** using this method, graph display can't be left open 
            '    when closing perfmon form
            '    so replaced with processstartinfo method.
            'Dim g As New PerformanceGraph.FmGraph
            'g.FileToOpen = Me.RecordingFileName
            'g.Show()

            Dim pi As New System.Diagnostics.ProcessStartInfo
            pi.FileName = My.Application.Info.DirectoryPath & "\performancegraph.exe"
            If System.Diagnostics.Debugger.IsAttached Then
                pi.FileName = My.Application.Info.DirectoryPath & "\performancegraph.exe".ToLower.Replace("cmc\bin", "performancegraph\bin\debug")
            End If
            pi.Arguments = Chr(34) & Me.RecordingFileName & Chr(34)
            System.Diagnostics.Process.Start(pi)

        End If
    End Sub
    Private Sub Recording_Write_Line(ByVal Line As String)
        Writer.WriteLine(DateTime.Now & "," & Line)
    End Sub

    ''' <summary>
    ''' WMI query to retrieve total physical memory (MB)
    ''' </summary>
    ''' <param name="MachineName"></param>
    ''' <returns>TotalPhysicalmemory (MB)</returns>
    ''' <remarks></remarks>
    Private Function GetPhysicalMemory(ByVal MachineName As String) As Integer
        Dim totalMemory As Integer = -1
        Dim wmi As New WMI
        If wmi.Connect(MachineName) = True Then
            Dim queryCollection As System.Management.ManagementObjectCollection
            Dim m As System.Management.ManagementObject
            queryCollection = wmi.wmiQuery("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem")
            For Each m In queryCollection
                totalMemory = CInt(m("TotalPhysicalMemory") / (1024 * 1024)) ' MB
            Next
        End If

        Return totalMemory
    End Function

    ''' <summary>
    ''' Handle changing of timer interval.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimeValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeValue.ValueChanged
        If TimeValue.Value = 0 Then TimeValue.Value = 1
        PerfMonTimer.Interval = TimeValue.Value * 1000
        If PerfMonTimer.Enabled Then
            Me.btnStop.Focus()
        Else
            Me.btnStart.Focus()
        End If
    End Sub

    Private Sub computername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computername.TextChanged
        Me.btnStart.Enabled = True
    End Sub

    ''' <summary>
    ''' Change graph size proportionally with form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PerfMonitor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Dim overallWidth As Integer = Panel2.Width
        Dim PicCount As Integer = 3
        Dim borderSize As Integer = 10
        Dim widthAvailablePerPic = (overallWidth - 1 * borderSize) / PicCount
        Dim PicWidth As Integer = widthAvailablePerPic - borderSize
        Dim PicHeight As Integer = Panel2.Height - 56

        Pic1.Width = PicWidth
        Pic2.Width = PicWidth
        Pic3.Width = PicWidth

        Pic1.Location = New System.Drawing.Point(borderSize, 20)
        Pic2.Location = New System.Drawing.Point(widthAvailablePerPic + borderSize, 20)
        Pic3.Location = New System.Drawing.Point((2 * widthAvailablePerPic) + borderSize, 20)

        Me.labelCPU.Location = New System.Drawing.Point(borderSize + (0.5 * PicWidth - 12), 4)
        Me.LabelMem.Location = New System.Drawing.Point(widthAvailablePerPic + borderSize + (0.5 * PicWidth - 12), 4)
        Me.LabelDisk.Location = New System.Drawing.Point((2 * widthAvailablePerPic) + borderSize + (0.5 * PicWidth - 12), 4)
        Me.labelPic1.Location = New System.Drawing.Point(borderSize + (0.5 * PicWidth - 12), PicHeight + 20)
        Me.LabelPic2.Location = New System.Drawing.Point(widthAvailablePerPic + borderSize + (0.5 * PicWidth - 12), PicHeight + 20)
        Me.LabelPic3.Location = New System.Drawing.Point((2 * widthAvailablePerPic) + borderSize + (0.5 * PicWidth - 12), PicHeight + 20)

        Pic1.Height = PicHeight
        Pic2.Height = PicHeight
        Pic3.Height = PicHeight

    End Sub

    ''' <summary>
    ''' Read in command line parameters.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PerfMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' for testing...
        'If System.Diagnostics.Debugger.IsAttached Then drivename.Visible = True


        Me.loading = True

        If Environment.GetCommandLineArgs().Length > 1 Then

            Me.Visible = False
            Dim loader As New System.Threading.Thread(AddressOf DoWhileLoading)
            loader.Start()

            Dim i As Integer
            Dim memory As Integer = 0
            For i = 1 To Environment.GetCommandLineArgs().Length - 1
                Select Case LCase(Mid(Environment.GetCommandLineArgs(i).ToString, 1, 2))
                    Case "/?"
                        MsgBox("perfmonitor.exe \\computer [/u:username] [/p:password] [/t:interval] [/m:memory] [/h]" & vbCrLf & vbCrLf & _
                        "/u:username: user with admin rights on remote computer" & vbCrLf & _
                        "/p:password: password for user on remote computer" & vbCrLf & _
                        "/t:time interval (s)" & vbCrLf & _
                        "/m:physical memory (MB)" & vbCr & _
                        "/h:hide input panel" & vbCr & vbCr & _
                        "© Peter Forman 2008", MsgBoxStyle.Information, "PerfMonitor Usage")
                        Me.Close()
                        Exit Sub
                    Case "\\"
                        Me.computername.Text = Mid(Environment.GetCommandLineArgs(i), 3, Environment.GetCommandLineArgs(i).Length - 2)
                    Case "/u"
                        Username = Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3)
                    Case "/p"
                        Password = Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3)
                    Case "/t"
                        Me.TimeValue.Value = CInt(Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3))
                    Case "/m"
                        If Environment.GetCommandLineArgs(i).Length > 3 Then
                            memory = CInt(Mid(Environment.GetCommandLineArgs(i).ToString, 4, Environment.GetCommandLineArgs(i).Length - 3))
                        End If
                    Case "/h"
                        Panel1.Height = 10
                        Me.Height = Me.Height - 66
                End Select
            Next

            If Not String.IsNullOrEmpty(Me.computername.Text) Then
                MenuStrip2.Visible = False
                'Me.TopMost = True
                If memory > 0 Then
                    Me.totalMemory = memory
                    Start(False)
                Else
                    Start(True)
                End If

            End If

            loader.Join()
            Me.Visible = True

        Else
            Me.loading = False
        End If



    End Sub
    Private Sub DoWhileLoading()
        splashscreen1.Show()
        splashscreen1.Refresh()
        Do While Me.loading = True
            System.Threading.Thread.Sleep(1000)
            splashscreen1.Refresh()
        Loop
        splashscreen1.Close()
    End Sub
    Private Sub PerfMonitor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Recording Then
            If MsgBox("Performance metrics are being captured to file." & vbCr & "Are you sure you want to stop?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "Stop Recording") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                ' close the stream before quitting
                Writer.Close()
                Me.RecordingStatusLabel.Text = String.Empty
                cpu.Dispose()
                mem.Dispose()
                dskTime.Dispose()
                dskReadQ.Dispose()
                dskWriteQ.Dispose()
                e.Cancel = False
            End If
        End If
    End Sub


    ''' <summary>
    ''' Show or hide top panel.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToggleTopPanel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTogglePanel.Click
        If Panel1.Height = 10 Then
            Panel1.Height = 76
            Me.Height = Me.Height + 66
            Me.MenuStrip2.Visible = True
        Else
            Panel1.Height = 10
            Me.Height = Me.Height - 66
            Me.MenuStrip2.Visible = False
        End If
        Me.btnTogglePanel.Location = New System.Drawing.Point(0, Panel1.Height - 10)
    End Sub


    Private Sub AlwaysOnTopToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem1.Click
        Me.TopMost = AlwaysOnTopToolStripMenuItem1.Checked
    End Sub
    Private Sub OpenRecordedDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenRecordedDataToolStripMenuItem.Click
        Dim g As New PerformanceGraph.FmGraph
        g.Show()
    End Sub

End Class
