Imports ZedGraph

Public Class FmGraph

    Public FileToOpen As String
    Private myData As DataTable
    Private LineThickness As Single = 2
    Private Computer As String
    Private _diskPercentInstance As String
    Private _diskReadInstance As String
    Private _diskWriteInstance As String
    Private _diskReadMBInstance As String
    Private _diskWriteMBInstance As String

    ''' <summary>
    ''' Reads file containing performance data into a datatable
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <remarks></remarks>
    Private Sub Fill_DataTable(ByVal filename As String)
        myData = New DataTable()
        myData.Columns.Add(New DataColumn("Time", GetType(DateTime)))
        myData.Columns.Add(New DataColumn("cpu%", GetType(Double)))
        myData.Columns.Add(New DataColumn("mem%", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk%", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskRead", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWrite", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskReadKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWriteKbSec", GetType(Double)))


        Dim sr As New System.IO.StreamReader(filename)
        Computer = UCase(sr.ReadLine.Split(" ")(0))
        Dim instanceLine() As String = sr.ReadLine.Split(",")
        Me._diskPercentInstance = instanceLine(3).Substring(instanceLine(3).LastIndexOf("\") + 1)
        Me._diskReadInstance = instanceLine(4).Substring(instanceLine(4).LastIndexOf("\") + 1)
        Me._diskWriteInstance = instanceLine(5).Substring(instanceLine(5).LastIndexOf("\") + 1)
        If instanceLine.Length = 8 Then
            Me._diskReadMBInstance = instanceLine(6).Substring(instanceLine(6).LastIndexOf("\") + 1)
            Me._diskWriteMBInstance = instanceLine(7).Substring(instanceLine(7).LastIndexOf("\") + 1)
        End If

        Do While Not sr.EndOfStream
            Dim line() As String = sr.ReadLine.Split(",")
            If line.Length = 6 Then
                Try
                    ' Add data to new myData row
                    myData.Rows.Add(line(0), line(1), line(2), line(3), line(4), line(5))
                Catch ex As System.ArgumentException
                    ' data not in correct format - maybe incomplete line - skip
                End Try
            ElseIf line.Length = 8 Then
                Try
                    ' Add data to new myData row
                    myData.Rows.Add(line(0), line(1), line(2), line(3), line(4), line(5), line(6), line(7))
                Catch ex As System.ArgumentException
                    ' data not in correct format - maybe incomplete line - skip
                End Try
            End If
        Loop
        sr.Close()
    End Sub

    ''' <summary>
    ''' Draw the graph selected curves in the specified graphcontrol
    ''' </summary>
    ''' <param name="zgc"></param>
    ''' <remarks></remarks>
    Private Sub CreateGraph(ByVal zgc As ZedGraphControl)

        ' selected metrics
        Dim _showCPU As Boolean = False
        Dim _showRAM As Boolean = False
        Dim _showDiskTime As Boolean = False
        Dim _showDiskReadQueue As Boolean = False
        Dim _showDiskWriteQueue As Boolean = False
        Dim _ShowDiskReadKB As Boolean = False
        Dim _ShowDiskWriteKB As Boolean = False

        ' line / axis options
        Dim _smoothLines As Boolean = False
        Dim _showY2Axis As Boolean = False
        Dim _ShowYAxis As Boolean = True

        Dim GraphNumber As Integer
        Try
            GraphNumber = CInt(zgc.Name.Substring(zgc.Name.Length - 1))
        Catch ex As Exception
            MsgBox("Graph Control Name must end with an Integer")
        End Try

        'If GraphNumber = 1 Then
        '    For Each mnuitm As ToolStripMenuItem In Me.MenuGraph1.DropDownItems
        '    Next
        'End If

        If GraphNumber = 1 Then
            If Me.menu_graph1_cpu.Checked Then _showCPU = True
            If Me.menu_graph1_ram.Checked Then _showRAM = True
            If Me.menu_graph1_disktime.Checked Then _showDiskTime = True
            If Me.menu_graph1_diskReadQueue.Checked Then _showDiskReadQueue = True
            If Me.menu_graph1_diskWriteQueue.Checked Then _showDiskWriteQueue = True
            If Me.menu_graph1_diskreadMBs.Checked Then _ShowDiskReadKB = True
            If Me.menu_graph1_diskwriteMBs.Checked Then _ShowDiskWriteKB = True

            If Me.menu_graph1_diskReadQueue.Checked OrElse Me.menu_graph1_diskWriteQueue.Checked Then
                _showY2Axis = True
            End If
            If Not Me.menu_graph1_cpu.Checked AndAlso Not Me.menu_graph1_ram.Checked AndAlso Not Me.menu_graph1_disktime.Checked Then
                _ShowYAxis = False
            End If
            If Me.menu_graph1_smoothCurvesMenu.Checked Then _smoothLines = True
        ElseIf GraphNumber = 2 Then
            If Me.menu_graph2_cpu.Checked Then _showCPU = True
            If Me.menu_graph2_ram.Checked Then _showRAM = True
            If Me.menu_graph2_disktime.Checked Then _showDiskTime = True
            If Me.menu_graph2_diskReadQueue.Checked Then _showDiskReadQueue = True
            If Me.menu_graph2_diskWriteQueue.Checked Then _showDiskWriteQueue = True
            If Me.menu_graph2_diskreadMBs.Checked Then _ShowDiskReadKB = True
            If Me.menu_graph2_diskwriteMBs.Checked Then _ShowDiskWriteKB = True

            If Me.menu_graph2_diskReadQueue.Checked OrElse Me.menu_graph2_diskWriteQueue.Checked Then
                _showY2Axis = True
            End If
            If Not Me.menu_graph2_cpu.Checked AndAlso Not Me.menu_graph2_ram.Checked AndAlso Not Me.menu_graph2_disktime.Checked Then
                _ShowYAxis = False
            End If

            If Me.menu_graph2_smoothCurvesMenu.Checked Then _smoothLines = True
        Else

        End If


        Dim myPane As GraphPane = zgc.GraphPane

        ' Set the title
        myPane.Title.Text = Computer
        ' Set the axis type and labels
        myPane.XAxis.Title.Text = "Time"
        myPane.XAxis.Type = AxisType.Date
        myPane.XAxis.Scale.Format = "HH:mm:ss"
        ' Show the x axis grid
        myPane.XAxis.MajorGrid.IsVisible = True

        If _ShowYAxis Then
            myPane.YAxis.Title.Text = "% Percentage"
            '' Manually set the axis range
            myPane.YAxis.Scale.Min = 0
            myPane.YAxis.Scale.Max = 100
            ' Show the y axis grid
            myPane.YAxis.MajorGrid.IsVisible = True
            ' turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = False
            myPane.YAxis.MinorTic.IsOpposite = False
            ' Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Black
            myPane.YAxis.Title.FontSpec.FontColor = Color.Black
        Else
            myPane.YAxis.Title.Text = " "
            myPane.YAxis.MajorGrid.IsVisible = False
            myPane.YAxis.MinorGrid.IsVisible = False
            myPane.YAxis.IsVisible = True
            myPane.YAxis.MajorGrid.IsVisible = False
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Transparent
            myPane.YAxis.Title.FontSpec.FontColor = Color.Transparent
            myPane.YAxis.MajorTic.Color = Color.Transparent
            myPane.YAxis.MinorTic.Color = Color.Transparent

            myPane.Y2Axis.MajorGrid.IsVisible = True
        End If

        If _showY2Axis Then
            ' Enable the Y2 axis display
            myPane.Y2Axis.IsVisible = True
            ' Set The Y2 Title
            myPane.Y2Axis.Title.Text = "Length"
            ' Make the Y2 axis scale blue
            myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue
            myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue
            ' turn off the opposite tics so the Y2 tics don't show up on the Y axis
            myPane.Y2Axis.MajorTic.IsOpposite = False
            myPane.Y2Axis.MinorTic.IsOpposite = False
            ' Align the Y2 axis labels so they are flush to the axis
            myPane.Y2Axis.Scale.Align = AlignP.Inside
        Else
            ' Disable the Y2 axis display
            myPane.Y2Axis.IsVisible = True
            ' Set The Y2 Title
            myPane.Y2Axis.Title.Text = " "
            ' Make the Y2 axis scale White
            myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Transparent
            myPane.Y2Axis.Title.FontSpec.FontColor = Color.Transparent
            ' turn off the opposite tics so the Y2 tics don't show up on the Y axis
            myPane.Y2Axis.MajorTic.Color = Color.Transparent
            myPane.Y2Axis.MinorTic.Color = Color.Transparent
        End If



        Dim cpuList = New PointPairList()
        Dim memList = New PointPairList()
        Dim diskList = New PointPairList()
        Dim rQList = New PointPairList()
        Dim wQList = New PointPairList()
        Dim ReadKbList = New PointPairList()
        Dim WriteKBList = New PointPairList()

        Dim MaxQueue As Double = 0
        For Each row As DataRow In myData.Rows
            Dim x As Double = New XDate(CDate(row(0))).XLDate
            cpuList.add(x, row(1))
            memList.add(x, row(2))
            diskList.add(x, row(3))
            Dim rq As Double = row(4)
            Dim wq As Double = row(5)
            rQList.add(x, rq)
            wQList.add(x, wq)
            If rq > MaxQueue Then MaxQueue = rq
            If wq > MaxQueue Then MaxQueue = wq
            If Not row.IsNull(6) Then ReadKbList.add(x, row(6))
            If Not row.IsNull(7) Then WriteKBList.add(x, row(7))
        Next


        ' Manually Set Y2 Axis according to disk q
        myPane.Y2Axis.Scale.Min = 0
        myPane.Y2Axis.Scale.Max = CInt(MaxQueue) + 1


        Dim Curve As LineItem

        If _ShowDiskReadKB Then

            ' customise y axis
            myPane.YAxis.IsVisible = True
            myPane.YAxis.MajorGrid.IsVisible = True
            myPane.YAxis.Title.Text = "Disk Kb per second"
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Blue
            myPane.YAxis.Title.FontSpec.FontColor = Color.Blue
            _showCPU = False
            _showRAM = False
            _showDiskTime = False

            Curve = myPane.AddCurve("Disk Read: " & Me._diskPercentInstance, ReadKbList, Color.HotPink, SymbolType.None)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
            Curve.IsY2Axis = True
        End If

        If _ShowDiskWriteKB Then
            ' customise y axis
            myPane.YAxis.IsVisible = True
            myPane.YAxis.MajorGrid.IsVisible = True
            myPane.YAxis.Title.Text = "Disk Kb per second"
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Blue
            myPane.YAxis.Title.FontSpec.FontColor = Color.Blue
            _showCPU = False
            _showRAM = False
            _showDiskTime = False

            Curve = myPane.AddCurve("Disk Write: " & Me._diskPercentInstance, WriteKBList, Color.Plum, SymbolType.None)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
            Curve.IsY2Axis = True
        End If

        If _showDiskTime Then
            ' Generate a green curve with circle symbols, and "% Disk Time" in the legend
            Curve = myPane.AddCurve("% Disk Time: " & Me._diskPercentInstance, diskList, Color.Green, SymbolType.None)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
        End If

        If _showDiskReadQueue Then
            Curve = myPane.AddCurve("Read Queue: " & Me._diskReadInstance, rQList, Color.RoyalBlue, SymbolType.None)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
            Curve.Symbol.Fill = New Fill(Color.White)
            ' Associate this curve with the Y2 axis
            Curve.IsY2Axis = True
        End If

        If _showDiskWriteQueue Then
            Curve = myPane.AddCurve("Write Queue: " & Me._diskWriteInstance, wQList, Color.DeepSkyBlue, SymbolType.None)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
            Curve.Symbol.Fill = New Fill(Color.White)

            ' Associate this curve with the Y2 axis
            Curve.IsY2Axis = True
        End If


        If _showCPU Then
            Curve = myPane.AddCurve("% CPU", cpuList, Color.Red, SymbolType.None)
            'cpuCurve.Symbol.Fill = New Fill(Color.Yellow)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
        End If

        If _showRAM Then
            ' Generate a filled blue curve with no symbols, and "% Mem" in the legend - Filled, therefore should be last graph drawn
            Curve = myPane.AddCurve("% Physical Memory", memList, Color.LemonChiffon, SymbolType.None)
            If _smoothLines Then
                Curve.Line.IsSmooth = True
                Curve.Line.SmoothTension = 0.1
            End If
            Curve.Line.Width = Me.LineThickness
            Curve.Line.IsAntiAlias = True
            ' Fill the area under the curve with a white-red gradient at 90 degrees
            Curve.Line.Fill = New Fill(Color.Khaki) '(Color.Thistle)
        End If



        ' Fill the axis background with a color gradient
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(240, 240, 240), 45.0F) '(Color.AliceBlue, Color.White, 90.0F)
        ' Fill the outer pane background with a color gradient
        myPane.Fill = New Fill(Color.White) '(Color.White, Color.Gray, 90.0F)

        ' Calculate the Axis Scale Ranges
        zgc.AxisChange()
    End Sub

    Private Sub FmGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' if arg passed, use as target file
        If Environment.GetCommandLineArgs().Length = 2 Then
            Dim filename As String = Environment.GetCommandLineArgs(1)
            If System.IO.File.Exists(filename) Then
                FileToOpen = filename
            End If
        End If

        If Not FileToOpen Is Nothing Then
            Fill_DataTable(FileToOpen)
            'CreateGraph(zg1)
            CreateGraph(zg1)
            CreateGraph(zg2)
            Me.Text = "Performance Graph: " & FileToOpen
            Me.Width = 800
            Me.Height = 800
            Me.SplitContainer1.Visible = True
        End If

        ToolStripComboBox2.Text = Me.LineThickness.ToString

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
    '# Change the "(Name)" field for the ZedGraphControl to zg1 (it would typically be 'zedGraphControl1').
    '# Double click the Windows Form (not the ZedGraphControl), this will cause the window to switch to CodeView, with a template for Sub Form1_Load
    '# Go to the top of the file (above the "Public Class Form1" declaration) and add Imports ZedGraph 
#End Region

#Region "Menu Items"
    ''' <summary>
    ''' Launches open file dialog to open recorded data files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>jesus, why is typing to difficult?</remarks>
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.OpenFileDialog1.ShowDialog()
        Dim file As String
        file = Me.OpenFileDialog1.FileName
        If Not String.IsNullOrEmpty(file) Then
            Fill_DataTable(file)
            'CreateGraph(zg1)
            CreateGraph(zg1)
            CreateGraph(zg2)
            Me.Text = "Performance Graph: " & file
            Me.Width = 800
            Me.Height = 800
            Me.SplitContainer1.Visible = True
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.OpenFileDialog1.ShowDialog()
        Dim file As String
        file = Me.OpenFileDialog1.FileName
        If Not String.IsNullOrEmpty(file) Then
            If Not myData Is Nothing Then
                zg1.GraphPane.CurveList.Clear()
                zg2.GraphPane.CurveList.Clear()
                zg1.Invalidate()
                zg2.Invalidate()
            End If
            Fill_DataTable(file)
            'CreateGraph(zg1)
            CreateGraph(zg1)
            CreateGraph(zg2)
            Me.Text = "Performance Graph: " & file
            Me.Width = 800
            Me.Height = 800
            Me.SplitContainer1.Visible = True
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub SmoothCurvesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not myData Is Nothing Then
            zg1.GraphPane.CurveList.Clear()
            zg2.GraphPane.CurveList.Clear()
            zg1.Invalidate()
            zg2.Invalidate()
            CreateGraph(zg1)
            CreateGraph(zg2)
        End If
    End Sub


    Private Sub Graph_Options_Changed(ByVal GraphControl As ZedGraphControl)
        If Not myData Is Nothing Then
            GraphControl.GraphPane.CurveList.Clear()
            GraphControl.Invalidate()
            CreateGraph(GraphControl)
        End If
    End Sub

    Private Sub menu_graph1_cpu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_cpu.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub menu_graph1_ram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_ram.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub menu_graph1_disktime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_disktime.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub menu_graph1_diskReadQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_diskReadQueue.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub menu_graph1_diskWriteQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_diskWriteQueue.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub menu_graph1_diskreadMBs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_diskreadMBs.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub menu_graph1_diskwriteMBs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_diskwriteMBs.Click
        Graph_Options_Changed(zg1)
    End Sub
    Private Sub graph1_SmoothCurvesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph1_smoothCurvesMenu.Click
        Graph_Options_Changed(zg1)
    End Sub

    Private Sub menu_graph2_cpu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_cpu.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub menu_graph2_ram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_ram.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub menu_graph2_disktime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_disktime.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub menu_graph2_diskReadQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_diskReadQueue.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub menu_graph2_diskWriteQueue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_diskWriteQueue.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub menu_graph2_diskreadMBs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_diskreadMBs.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub menu_graph2_diskwriteMBs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_diskwriteMBs.Click
        Graph_Options_Changed(zg2)
    End Sub
    Private Sub graph2_SmoothCurvesMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_graph2_smoothCurvesMenu.Click
        Graph_Options_Changed(zg2)
    End Sub

    Private Sub ToolStripComboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox2.SelectedIndexChanged
        Try
            Me.LineThickness = CType(ToolStripComboBox2.Text, Single)
        Catch ex As Exception
            Me.LineThickness = 2
        End Try
        Graph_Options_Changed(zg1)
        Graph_Options_Changed(zg2)
    End Sub

#End Region

#Region "Layout"
    ''' <summary>
    ''' contains code to resize elements
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SplitContainer1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer1.Resize
        SplitContainer1.SplitterDistance = SplitContainer1.Height / 2
        zg1.Width = SplitContainer1.Panel1.Width
        zg1.Height = SplitContainer1.Panel1.Height
        zg2.Width = SplitContainer1.Panel2.Width
        zg2.Height = SplitContainer1.Panel2.Height
    End Sub
    Private Sub SplitContainer1_SplitterMoved(ByVal sender As Object, ByVal e As System.Windows.Forms.SplitterEventArgs) Handles SplitContainer1.SplitterMoved
        zg1.Height = SplitContainer1.Panel1.Height
        zg2.Height = SplitContainer1.Panel2.Height
    End Sub
#End Region


    Private Sub zg1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zg1.Load

    End Sub
End Class
