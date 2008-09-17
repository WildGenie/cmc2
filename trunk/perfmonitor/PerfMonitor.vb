Public Class PerfMonitor

    Private cpu, mem, dskTime, dskReadQ, dskWriteQ As PerformanceCounter
    Private totalMemory As Integer
    Private FirstRun As Boolean
    Protected Friend loading As Boolean
    Protected Friend Username As String = Nothing
    Protected Friend Password As String = Nothing
    Private CriticalError As Boolean = False

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
        dskTime = New PerformanceCounter("PhysicalDisk", "% Disk Time", "_Total", Me.computername.Text)
        dskReadQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Read Queue Length", "_Total", Me.computername.Text)
        dskWriteQ = New PerformanceCounter("PhysicalDisk", "Avg. Disk Write Queue Length", "_Total", Me.computername.Text)


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
                               vbCr & vbCr & "The application will be closed.", MsgBoxStyle.Critical, "Perf Mon Error")
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

        ' ----  % Disk Time  -------------
        Dim dsktimeValue As Integer = CInt(dskTime.NextValue)
        LabelDisk.Text = dsktimeValue & "%"
        If dsktimeValue > 100 Then
            dsktimeValue = 100
        End If

        '  ----  Avg Disk Read & Write Queues
        Dim ReadQ As Single = dskReadQ.NextValue
        'LblReadQ.Text = FormatNumber(ReadQ, 2)
        Dim WriteQ As Single = dskWriteQ.NextValue
        'LblWriteQ.Text = FormatNumber(WriteQ, 2)



        UpdatePercentGraph(dsktimeValue, Pic3, dskColor)



        If Recording Then
            Me.Recording_Write_Line(CInt(cpuvalue) & "," & CInt(memValue) & "," & CInt(dsktimeValue) & "," & ReadQ & "," & WriteQ)
        End If

        If FirstRun Then
            totaltime = Microsoft.VisualBasic.Left(Microsoft.VisualBasic.DateAndTime.Timer - start, 5)
            'Debug.Print(totaltime)
            Me.TimeValue.Value = CInt(totaltime) + 1
            FirstRun = False
            Me.RecordStartButton.Enabled = True
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

    ''' <summary>
    ''' Handle changing of timer interval.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TimeValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeValue.ValueChanged
        If TimeValue.Value = 0 Then TimeValue.Value = 1
        If TimeValue.Value > 60 Then TimeValue.Value = 60
        PerfMonTimer.Interval = TimeValue.Value * 1000
        If PerfMonTimer.Enabled Then
            Me.btnStop.Focus()
        Else
            Me.btnStart.Focus()
        End If
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
    ''' Show or hide top panel.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ToggleTopPanel(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTogglePanel.Click
        If Panel1.Height = 10 Then
            Panel1.Height = 76
            Me.Height = Me.Height + 66
        Else
            Panel1.Height = 10
            Me.Height = Me.Height - 66
        End If
        Me.btnTogglePanel.Location = New System.Drawing.Point(0, Panel1.Height - 10)
    End Sub

    ''' <summary>
    ''' Read in command line parameters.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub PerfMonitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
                If memory > 0 Then
                    Me.totalMemory = memory
                    Start(False)
                Else
                    Start(True)
                End If
                'Me.TopMost = True
            End If

            loader.Join()
            Me.Visible = True

        Else
            Me.loading = False
        End If



    End Sub

    Private Sub AlwaysOnTopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlwaysOnTopToolStripMenuItem.Click
        If Me.TopMost = True Then
            Me.TopMost = False
        Else
            Me.TopMost = True
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

    Private Recording As Boolean = False
    Private Writer As System.IO.StreamWriter
    Private Sub RecordStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordStartButton.Click

        Dim rd As New RecordingDialog
        rd.ShowDialog()
        rd.TopMost = True
        If rd.DialogResult = Windows.Forms.DialogResult.OK Then
            TimeValue.Value = rd.NumericUpDown1.Value
            Recording = True
            Writer = New System.IO.StreamWriter("c:\record.csv", False)
            Writer.WriteLine(computername.Text & " Recording started: " & DateTime.Now)
            Writer.WriteLine("Time,Processor\% Processor Time\_Total,PhysicalMemory\% Used,PhysicalDisk\% Disk Time\_Total,PhysicalDisk\Avg Read Queue\_Total,PhysicalDisk\Avg Write Queue\_Total")
            Me.RecordStartButton.Enabled = False
            Me.RecordPauseButton.Enabled = True
            Me.RecordStopButton.Enabled = True
            Me.RecordingStatusLabel.Visible = True
            Me.RecordingStatusLabel.Text = "recording"
        End If
    End Sub
    Private Sub RecordStopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordStopButton.Click
        Recording = False
        Writer.Close()
        Me.RecordStopButton.Enabled = False
        Me.RecordPauseButton.Enabled = False
        Me.RecordStartButton.Enabled = True
        Me.RecordingStatusLabel.Text = "stopped"
    End Sub
    Private Sub RecordPauseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecordPauseButton.Click
        If Me.RecordPauseButton.ImageIndex = 2 Then ' we want to pause
            Me.Recording = False
            Me.RecordPauseButton.ImageIndex = 3
            Me.RecordingStatusLabel.Text = "paused"
        Else
            Me.Recording = True
            Me.RecordPauseButton.ImageIndex = 2
            Me.RecordingStatusLabel.Text = "recording"
        End If
    End Sub
    Private Sub Recording_Write_Line(ByVal Line As String)
        Writer.WriteLine(DateTime.Now.ToLongTimeString & "," & Line)
    End Sub



End Class
