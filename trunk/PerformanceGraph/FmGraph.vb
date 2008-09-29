Imports ZedGraph

Public Class FmGraph

    Public FileToOpen As String
    Private myData As DataTable
    Private Computer As String

    Private CPUCurve As CurveSettings
    Private RAMCurve As CurveSettings
    Private PhysDiskPercentCurve As CurveSettings
    Private PhysDiskQueueReadCurve As CurveSettings
    Private PhysDiskQueueWriteCurve As CurveSettings
    Private PhysDiskIOReadCurve As CurveSettings
    Private PhysDiskIOWriteCurve As CurveSettings

    Private _disk1Instance As String
    Private _disk2Instance As String
    Private _disk3Instance As String

    ''' <summary>
    ''' Create datatable and read performance data from file into datatable
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <remarks></remarks>
    Private Sub Fill_DataTable(ByVal filename As String)
        myData = New DataTable()
        myData.Columns.Add(New DataColumn("time", GetType(DateTime)))
        myData.Columns.Add(New DataColumn("cpu%", GetType(Double)))
        myData.Columns.Add(New DataColumn("mem%", GetType(Double)))
        myData.Columns.Add(New DataColumn("memPages", GetType(Double)))
        myData.Columns.Add(New DataColumn("NicBytes", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk%", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskRead", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWrite", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskReadKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWriteKbSec", GetType(Double)))

        Dim sr As New System.IO.StreamReader(filename)
        Computer = UCase(sr.ReadLine.Split(" ")(0))
        Dim instanceLine() As String = sr.ReadLine.Split(",")

        ' 1 Time
        ' 2 CPU_%
        ' 3 RAM_%
        ' 4 Memory&Pages_InputPerSec
        ' 5 Network_BytesPerSec_Broadcom NetXtreme Gigabit Ethernet - Packet Scheduler Miniport

        ' 6 DiskTime_%_0 C:
        ' 7 Read&Queue_Length_0 C:
        ' 8 Write&Queue_Length_0 C:
        ' 9 Disk&Read_kbs0 C:
        '10 Disk&Write_kbs_0 C:


        If instanceLine.Length > 5 Then
            Me._disk2Instance = instanceLine(6).Substring(instanceLine(6).LastIndexOf("_") + 1)
        End If

        If instanceLine.Length > 10 Then
            Me._disk2Instance = instanceLine(11).Substring(instanceLine(11).LastIndexOf("_") + 1)
        End If

        If instanceLine.Length > 15 Then
            Me._disk2Instance = instanceLine(16).Substring(instanceLine(16).LastIndexOf("_") + 1)
        End If

        Do While Not sr.EndOfStream
            Dim line() As String = sr.ReadLine.Split(",")
            Dim dtNewRow As DataRow = myData.NewRow()
            For i As Integer = 0 To line.Length - 1
                dtNewRow.Item(i) = line(i)
            Next
            Try
                myData.Rows.Add(dtNewRow)
            Catch ex As Exception
            End Try
        Loop
        sr.Close()
    End Sub

    Private Sub CreateSingleGraph(ByVal ZGC As ZedGraphControl, _
                                  ByVal GraphTitle As String, _
                                  ByVal YAxis1Title As String, _
                                  ByVal YAxis2Title As String, _
                                  ByVal CPUGraph As Boolean, _
                                  ByVal RAMGraph As Boolean, _
                                  ByVal DiskPercentGraph As Boolean, _
                                  ByVal DiskReadQueueGraph As Boolean, _
                                  ByVal DiskWriteQueueGraph As Boolean, _
                                  ByVal DiskReadRateGraph As Boolean, _
                                  ByVal DiskWriteRateGraph As Boolean, _
                                  ByVal LineTension As Single, _
                                  ByVal LineWidth As Integer)


        Dim myPane As GraphPane = ZGC.GraphPane


        ' Disable Font Scaling
        myPane.IsFontsScaled = False


        myPane.Title.FontSpec.Size = 12
        myPane.Title.FontSpec.IsBold = False

        myPane.XAxis.Title.FontSpec.Size = 12
        myPane.YAxis.Title.FontSpec.Size = 12
        myPane.Y2Axis.Title.FontSpec.Size = 12
        myPane.XAxis.Title.FontSpec.IsBold = False
        myPane.YAxis.Title.FontSpec.IsBold = False
        myPane.Y2Axis.Title.FontSpec.IsBold = False

        myPane.XAxis.Scale.FontSpec.Size = 10
        myPane.YAxis.Scale.FontSpec.Size = 10
        myPane.Y2Axis.Scale.FontSpec.Size = 10

        myPane.YAxis.MinorTic.Size = 0

        ' Set the Graph Title
        myPane.Title.Text = GraphTitle

        ' X Axis
        myPane.XAxis.Title.Text = "Time"
        myPane.XAxis.Type = AxisType.Date
        myPane.XAxis.Scale.Format = "HH:mm:ss"
        myPane.XAxis.MajorGrid.IsVisible = True

        ' Y Axis
        myPane.YAxis.Title.Text = YAxis1Title
        myPane.YAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorTic.IsOpposite = False
        myPane.YAxis.MinorTic.IsOpposite = False
        myPane.YAxis.Scale.Align = AlignP.Inside
        myPane.YAxis.Scale.FontSpec.FontColor = Color.Black
        myPane.YAxis.Title.FontSpec.FontColor = Color.Black


        ' Y2 Axis
        myPane.Y2Axis.MajorTic.IsOpposite = False
        myPane.Y2Axis.MinorTic.IsOpposite = False
        myPane.Y2Axis.Scale.Align = AlignP.Inside
        myPane.Y2Axis.Title.Text = YAxis2Title
        If Not String.IsNullOrEmpty(YAxis2Title) Then
            myPane.Y2Axis.IsVisible = True
            myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue
            myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue
            myPane.Y2Axis.MajorTic.Color = Color.Blue
        Else
            myPane.Y2Axis.IsVisible = False
            myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Transparent
            myPane.Y2Axis.Title.FontSpec.FontColor = Color.Transparent
            myPane.Y2Axis.MajorTic.Color = Color.Transparent
        End If


        Dim cpuList = New PointPairList()
        Dim memList = New PointPairList()
        Dim memPagesList = New PointPairList()
        Dim NICList = New PointPairList()
        Dim diskList = New PointPairList()
        Dim rQList = New PointPairList()
        Dim wQList = New PointPairList()
        Dim ReadKbList = New PointPairList()
        Dim WriteKBList = New PointPairList()

        'Dim MaxQueue As Double = 0
        For Each row As DataRow In myData.Rows
            Dim x As Double = New XDate(CDate(row(0))).XLDate
            If Not row.IsNull(1) Then cpuList.add(x, row(1))
            If Not row.IsNull(2) Then memList.add(x, row(2))
            If Not row.IsNull(3) Then memPagesList.add(x, row(3))
            If Not row.IsNull(4) Then NICList.add(x, row(4))
            If Not row.IsNull(5) Then diskList.add(x, row(5))
            If Not row.IsNull(6) Then rQList.add(x, row(6))
            If Not row.IsNull(7) Then wQList.add(x, row(7))
            If Not row.IsNull(8) Then ReadKbList.add(x, row(8))
            If Not row.IsNull(9) Then WriteKBList.add(x, row(9))
        Next


        Dim Curve As LineItem

        If DiskReadRateGraph Then
            Curve = myPane.AddCurve("Disk Read: " & Me._disk1Instance, ReadKbList, Me.PhysDiskIOReadCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskIOReadCurve.LineTension
            Curve.Line.Width = Me.PhysDiskIOReadCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskIOReadCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskIOReadCurve.LineColor)
        End If

        If DiskWriteRateGraph Then
            Curve = myPane.AddCurve("Disk Write: " & Me._disk1Instance, WriteKBList, Me.PhysDiskIOWriteCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskIOWriteCurve.LineTension
            Curve.Line.Width = Me.PhysDiskIOWriteCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskIOWriteCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskIOWriteCurve.LineColor)
        End If

        If DiskReadQueueGraph Then
            Curve = myPane.AddCurve("Read Queue: " & Me._disk1Instance, rQList, Me.PhysDiskQueueReadCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskQueueReadCurve.LineTension
            Curve.Line.Width = Me.PhysDiskQueueReadCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskQueueReadCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskQueueReadCurve.LineColor)

            Curve.IsY2Axis = True
        End If

        If DiskWriteQueueGraph Then
            Curve = myPane.AddCurve("Write Queue: " & Me._disk1Instance, wQList, Me.PhysDiskQueueWriteCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskQueueWriteCurve.LineTension
            Curve.Line.Width = Me.PhysDiskQueueWriteCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskQueueWriteCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskQueueWriteCurve.LineColor)

            Curve.IsY2Axis = True
        End If

        If DiskPercentGraph Then
            Curve = myPane.AddCurve("% Disk Time: " & Me._disk1Instance, diskList, Me.PhysDiskPercentCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskPercentCurve.LineTension
            Curve.Line.Width = Me.PhysDiskPercentCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskPercentCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskPercentCurve.LineColor)

            myPane.YAxis.Scale.Min = 0
            myPane.YAxis.Scale.Max = 105
        End If

        If CPUGraph Then
            Curve = myPane.AddCurve("% CPU", cpuList, Me.CPUCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.CPUCurve.LineTension
            Curve.Line.Width = Me.CPUCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.CPUCurve.Filled Then Curve.Line.Fill = New Fill(Me.CPUCurve.LineColor)

            myPane.YAxis.Scale.Min = 0
            myPane.YAxis.Scale.Max = 105
        End If

        If RAMGraph Then
            Curve = myPane.AddCurve("% Physical Memory", memList, Me.RAMCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.RAMCurve.LineTension
            Curve.Line.Width = Me.RAMCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.RAMCurve.Filled Then Curve.Line.Fill = New Fill(Me.RAMCurve.LineColor)

            ' Always show zero % as base
            myPane.YAxis.Scale.Min = 0
            myPane.YAxis.Scale.Max = 105
            ' Set scale max % according to data
            'myPane.YAxis.Scale.MaxAuto = True
        End If


        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(240, 240, 240), 45.0F) '(Color.AliceBlue, Color.White, 90.0F)
        myPane.Fill = New Fill(Color.WhiteSmoke) '(Color.White, Color.Gray, 90.0F)

        ZGC.AxisChange()
    End Sub
    Private Sub GetStats()

        Me.ListViewStats.Items.Clear()
        Dim item As ListViewItem

        Try
            item = New ListViewItem("CPU %")
            item.SubItems.Add(CInt(myData.Compute("MAX([cpu%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([cpu%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([cpu%])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("RAM % Used")
            item.SubItems.Add(CInt(myData.Compute("MAX([mem%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([mem%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([mem%])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("Disk % Time")
            item.SubItems.Add(CInt(myData.Compute("MAX([disk%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([disk%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([disk%])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("Disk Read Queue")
            item.SubItems.Add(CInt(myData.Compute("MAX([diskRead])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([diskRead])", String.Empty)))
            item.SubItems.Add(CType(myData.Compute("AVG([diskRead])", String.Empty), Single))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("Disk Write Queue")
            item.SubItems.Add(CInt(myData.Compute("MAX([diskWrite])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([diskWrite])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([diskWrite])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("Disk IO Read kb/s")
            item.SubItems.Add(CInt(myData.Compute("MAX([diskReadKbSec])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([diskReadKbSec])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([diskReadKbSec])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("Disk IO Write kb/s")
            item.SubItems.Add(CInt(myData.Compute("MAX([diskWriteKbSec])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([diskWriteKbSec])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([diskWriteKbSec])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try


    End Sub

    Private Sub PlotFileData(ByVal filename As String, ByVal UseCurrentData As Boolean)

        GraphPanelsVisible(True)
        If Me.Height < 500 Then Me.Height = 600

        ' Clear Existing Graphs
        If Not myData Is Nothing Then
            zgc_cpu.GraphPane.CurveList.Clear()
            zgc_ram.GraphPane.CurveList.Clear()
            zgc_phsdisk1.GraphPane.CurveList.Clear()
            zgc_phsdisk2.GraphPane.CurveList.Clear()
            zgc_phsdisk3.GraphPane.CurveList.Clear()
            zgc_cpu.Invalidate()
            zgc_ram.Invalidate()
            zgc_phsdisk1.Invalidate()
            zgc_phsdisk2.Invalidate()
            zgc_phsdisk3.Invalidate()
        End If


        If UseCurrentData = False Then
            ' Read New File data and plot graphs
            If Not filename Is Nothing Then
                Fill_DataTable(filename)
            Else
                MsgBox("Load New File", MsgBoxStyle.Critical, "No Data")
                Return
            End If
        End If
        CreateSingleGraph(zgc_cpu, "CPU Utilisation", " % Percent", "", True, False, False, False, False, False, False, 0.2, 1)
        CreateSingleGraph(zgc_ram, "Physical Memory Utilsation", "% Percent", "", False, True, False, False, False, False, False, 0.2, 1)
        CreateSingleGraph(zgc_phsdisk1, "Disk Utilisation", " % Percent", "", False, False, True, False, False, False, False, 0.2, 1)
        CreateSingleGraph(zgc_phsdisk2, "Disk Queue Length", "Avg Queue Length", "", False, False, False, True, True, False, False, 0.2, 1)
        CreateSingleGraph(zgc_phsdisk3, "Disk IO", "Kb/Second", "", False, False, False, False, False, True, True, 0.2, 1)
        Me.Text = "Performance Graph: " & FileToOpen

    End Sub



#Region "zedgraph help"
    '#  In the Solution Explorer, right-click on the ZedGraphSample project and select "Add Reference..."
    '# Pick the browse tab, and navigate to the zedGraph.dll (downloadable from here), and click OK
    '# From View menu, select Toolbox, scroll down to the bottom of the toolbox window to see the "General" bar
    '# If ZedGraphControl is not already available as an option, rightclick on the "General" bar, and select "Choose Items..."
    '# Under ".Net Framework Components" tab, click browse
    '# Navigate to the zedgraph.dll file, and click Open, Click OK
    '# In the toolbox, left-click on the ZedGraphControl, go to your Form and click inside it to place a ZedGraphControl item.
    '# With the ZedGraphControl selected in the form, under the View menu select "Properties Window"
    '# Change the "(Name)" field for the ZedGraphControl to zgc_cpu (it would typically be 'zedGraphControl1').
    '# Double click the Windows Form (not the ZedGraphControl), this will cause the window to switch to CodeView, with a template for Sub Form1_Load
    '# Go to the top of the file (above the "Public Class Form1" declaration) and add Imports ZedGraph 
#End Region

    Private Sub FmGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CPUCurve = New CurveSettings
        Me.CPUCurve.Add("CPU", True)
        Me.RAMCurve = New CurveSettings
        Me.RAMCurve.Add("RAM", True)
        Me.PhysDiskPercentCurve = New CurveSettings
        Me.PhysDiskPercentCurve.Add("DiskPercent", True)
        Me.PhysDiskQueueReadCurve = New CurveSettings
        Me.PhysDiskQueueReadCurve.Add("DiskQueueRead", True)
        Me.PhysDiskQueueWriteCurve = New CurveSettings
        Me.PhysDiskQueueWriteCurve.Add("DiskQueueWrite", True)
        Me.PhysDiskIOReadCurve = New CurveSettings
        Me.PhysDiskIOReadCurve.Add("DiskIORead", True)
        Me.PhysDiskIOWriteCurve = New CurveSettings
        Me.PhysDiskIOWriteCurve.Add("DiskIOWrite", True)

        ' if arg passed, use as target file
        If Environment.GetCommandLineArgs().Length = 2 Then
            Dim filename As String = Environment.GetCommandLineArgs(1)
            If System.IO.File.Exists(filename) Then
                FileToOpen = filename
            End If
        End If


        If Not FileToOpen Is Nothing Then
            Me.Height = 600
            GraphPanelsVisible(True)
            Me.PlotFileData(FileToOpen, False)
            Me.GetStats()
        Else
            GraphPanelsVisible(False)
            Me.Height = 200
        End If


    End Sub

    ''' <summary>
    ''' Launches open file dialog to open recorded data files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>jesus, why is typing to difficult?</remarks>
    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.OpenFileDialog1.ShowDialog()
        Dim file As String
        file = Me.OpenFileDialog1.FileName
        Me.PlotFileData(file, False)
        Me.GetStats()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FmGraph_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Panel_Info.Height = (Me.TabControl1.Height - 26) / 3
        Me.Panel_Perf_CPU.Height = (Me.TabControl1.Height - 26) / 3
        Me.Panel_Perf_RAM.Height = (Me.TabControl1.Height - 26) / 3
        Me.Panel_PhysDisk_1.Height = (Me.TabControl1.Height - 26) / 3
        Me.Panel_PhysDisk_2.Height = (Me.TabControl1.Height - 26) / 3
        Me.Panel_PhysDisk_3.Height = (Me.TabControl1.Height - 26) / 3
    End Sub

    Private Sub GraphPanelsVisible(ByVal Visible As Boolean)
        Me.Panel_Info.Height = (Me.TabControl1.Height - 26) / 3
        Me.Panel_Perf_CPU.Visible = Visible
        Me.Panel_Perf_RAM.Visible = Visible
        Me.Panel_PhysDisk_1.Visible = Visible
        Me.Panel_PhysDisk_2.Visible = Visible
        Me.Panel_PhysDisk_3.Visible = Visible
    End Sub



    Private Sub cpuContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_cpu.ContextMenuBuilder
        ' create a new menu item
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        ' This is the user-defined name so you can find this menu item later if necessary
        item.Name = "cpuPropsMenu"
        ' This is the text that will show up in the menu
        item.Text = "Properties"

        ' Add a handler that will respond when that menu item is selected
        AddHandler item.Click, AddressOf Me.ShowSettings

        ' Add the menu item to the menu
        menuStrip.Items.Add(item)
    End Sub
    Private Sub ramContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_ram.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "ramPropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub diskPercentContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk1.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydisk1PropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub diskqueueContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk2.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydiskqueuePropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub diskioContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk3.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydiskIOPropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub

    Protected Sub ShowSettings(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim cs As New ChangeSettings
        Dim myCurve As CurveSettings = Nothing
        Dim myCurve2 As CurveSettings = Nothing
        Dim NumberOfLines As Integer = 1

        ' not used - redraw individual graphs
        Dim myGraph As ZedGraphControl = Nothing

        Select Case sender.name
            Case "cpuPropsMenu"
                myCurve = Me.CPUCurve
                cs.GroupBoxLine1.Text = "CPU"
            Case "ramPropsMenu"
                myCurve = Me.RAMCurve
                cs.GroupBoxLine1.Text = "RAM"
            Case "phydisk1PropsMenu"
                myCurve = Me.PhysDiskPercentCurve
                cs.GroupBoxLine1.Text = "Disk %"
            Case "phydiskqueuePropsMenu"
                myCurve = Me.PhysDiskQueueReadCurve
                myCurve2 = Me.PhysDiskQueueWriteCurve
                cs.GroupBoxLine1.Text = "Disk Read Queue"
                cs.GroupBoxLine2.Text = "Disk Write Queue"
                NumberOfLines = 2
            Case "phydiskIOPropsMenu"
                myCurve = Me.PhysDiskIOReadCurve
                myCurve2 = Me.PhysDiskIOWriteCurve
                cs.GroupBoxLine1.Text = "Disk Read IO"
                cs.GroupBoxLine2.Text = "Disk Write IO"
                NumberOfLines = 2
            Case Else
                MsgBox("invalid graph selection")
                Exit Sub
        End Select


        ' load current curve settings into dialog
        If myCurve.Filled Then
            cs.comboLineStyle.SelectedIndex = 1
        Else
            cs.comboLineStyle.SelectedIndex = 0
        End If
        cs.comboLineThickness.Text = myCurve.LineThickness
        cs.TrackBarLineTension.Value = myCurve.LineTension * 10
        cs.labelcolour1.Text = "colour: " & myCurve.LineColor.Name
        cs.labelcolour1.ForeColor = myCurve.LineColor

        If NumberOfLines = 2 Then
            If myCurve2.Filled Then
                cs.comboLineStyle2.SelectedIndex = 1
            Else
                cs.comboLineStyle2.SelectedIndex = 0
            End If
            cs.comboLineThickness2.Text = myCurve2.LineThickness
            cs.TrackBarLineTension2.Value = myCurve2.LineTension * 10
            cs.labelcolour2.Text = "colour: " & myCurve2.LineColor.Name
            cs.labelcolour2.ForeColor = myCurve2.LineColor

            cs.Width = 460
            cs.GroupBoxLine2.Visible = True
        Else
            cs.Width = 230
            cs.GroupBoxLine2.Visible = True
        End If

        ' display the dialog
        cs.ShowDialog()

        If cs.DialogResult = Windows.Forms.DialogResult.OK Then
            If cs.comboLineStyle.SelectedIndex = 1 Then
                myCurve.Filled = True
            Else
                myCurve.Filled = False
            End If
            myCurve.LineThickness = cs.comboLineThickness.Text
            If cs.TrackBarLineTension.Value = 0 Then
                myCurve.LineTension = 0
            Else
                myCurve.LineTension = cs.TrackBarLineTension.Value / 10
            End If

            myCurve.LineColor = cs.labelcolour1.ForeColor

            If NumberOfLines = 2 Then
                If cs.comboLineStyle2.SelectedIndex = 1 Then
                    myCurve2.Filled = True
                Else
                    myCurve2.Filled = False
                End If
                myCurve2.LineThickness = cs.comboLineThickness2.Text
                If cs.TrackBarLineTension2.Value = 0 Then
                    myCurve2.LineTension = 0
                Else
                    myCurve2.LineTension = cs.TrackBarLineTension2.Value / 10
                End If
                myCurve2.LineColor = cs.labelcolour2.ForeColor
            End If

            ' redraw the graph
            PlotFileData(Nothing, True)
        End If
    End Sub

End Class
