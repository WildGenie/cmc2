Imports ZedGraph

Public Class FmGraph

    Protected Friend FileToOpen As String
    Private myData As DataTable


    Private Sub Fill_DataTable(ByVal filename As String)
        myData = New DataTable()
        myData.Columns.Add(New DataColumn("Time", GetType(DateTime)))
        myData.Columns.Add(New DataColumn("cpu%", GetType(Double)))
        myData.Columns.Add(New DataColumn("mem%", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk%", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskRead", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWrite", GetType(Double)))


        Dim sr As New System.IO.StreamReader(filename)
        sr.ReadLine()
        sr.ReadLine()
        Do While Not sr.EndOfStream
            Dim line() As String = sr.ReadLine.Split(",")
            If line.Length = 6 Then
                ' Add data to new myData row
                myData.Rows.Add(line(0), line(1), line(2), line(3), line(4), line(5))
            End If
        Loop
        sr.Close()
    End Sub

    Private Sub CreateGraph(ByVal zgc As ZedGraphControl)

        Dim myPane As GraphPane = zgc.GraphPane

        ' Set the title
        myPane.Title.Text = "Performance"
        ' Set the axis type and labels
        myPane.XAxis.Title.Text = "Time"
        myPane.XAxis.Type = AxisType.Date
        myPane.XAxis.Scale.Format = "HH:mm:ss"
        myPane.YAxis.Title.Text = "% Utilisation"
        ' Manually set the axis range
        myPane.YAxis.Scale.Min = 0
        myPane.YAxis.Scale.Max = 100

        ' Show the axis grids
        myPane.XAxis.MajorGrid.IsVisible = True
        myPane.YAxis.MajorGrid.IsVisible = True


        Dim cpuList = New PointPairList()
        Dim memList = New PointPairList()
        Dim diskList = New PointPairList()

        For Each row As DataRow In myData.Rows
            Dim t As String = row(0)
            Dim x As Double = New XDate(CDate(row(0))).XLDate
            ' Dim x As Double = New XDate(CInt(t.Substring(0, 4)), CInt(t.Substring(4, 2)), CInt(t.Substring(6, 2)), CInt(t.Substring(8, 2)), CInt(t.Substring(10, 2)), CInt(t.Substring(12, 2))).XLDate
            cpuList.add(x, row(1))
            memList.add(x, row(2))
            diskList.add(x, row(3))
        Next


        Dim Curve As LineItem

        Curve = myPane.AddCurve("% CPU", cpuList, Color.Red, SymbolType.None)
        'cpuCurve.Symbol.Fill = New Fill(Color.Yellow)
        Curve.Line.IsSmooth = True
        Curve.Line.IsAntiAlias = True


        Curve = myPane.AddCurve("% Disk Time", diskList, Color.Green, SymbolType.None)
        Curve.Line.IsSmooth = True
        Curve.Line.IsAntiAlias = True
        Curve.Line.Style = Drawing2D.DashStyle.Dash
        ' Curve.Symbol.Fill = New Fill(Color.LightSkyBlue)

        ' Generate a filled blue curve with no symbols, and "% Mem" in the legend - Filled, therefore should be last graph drawn
        Curve = myPane.AddCurve("% Physical Memory", memList, Color.LemonChiffon, SymbolType.None)
        Curve.Line.IsSmooth = True
        Curve.Line.IsAntiAlias = True
        ' Fill the area under the curve with a white-red gradient at 90 degrees
        Curve.Line.Fill = New Fill(Color.Khaki) '(Color.Thistle)



        ' Fill the axis background with a color gradient
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(240, 240, 240), 45.0F)
        ' Fill the outer pane background with a color gradient
        myPane.Fill = New Fill(Color.White) '(Color.White, Color.Gray, 90.0F)

        ' Calculate the Axis Scale Ranges
        zgc.AxisChange()

    End Sub
    Private Sub CreateDiskGraph(ByVal zgc As ZedGraphControl)

        Dim myPane As GraphPane = zgc.GraphPane

        ' Set the title
        myPane.Title.Text = "Physical Disk"
        ' Set the axis type and labels
        myPane.XAxis.Title.Text = "Time"
        myPane.XAxis.Type = AxisType.Date
        myPane.XAxis.Scale.Format = "HH:mm:ss"
        myPane.Y2Axis.Title.Text = "Avg Queue Length"
        myPane.YAxis.Title.Text = "% Disk Time"
        ' Manually set the axis range
        myPane.YAxis.Scale.Min = 0
        myPane.YAxis.Scale.Max = 100

        ' Show the x axis grid
        myPane.XAxis.MajorGrid.IsVisible = True
        ' Show the y axis grid
        myPane.YAxis.MajorGrid.IsVisible = True
        ' turn off the opposite tics so the Y tics don't show up on the Y2 axis
        myPane.YAxis.MajorTic.IsOpposite = False
        myPane.YAxis.MinorTic.IsOpposite = False
        ' Align the Y axis labels so they are flush to the axis
        myPane.YAxis.Scale.Align = AlignP.Inside

        ' Enable the Y2 axis display
        myPane.Y2Axis.IsVisible = True
        ' Make the Y2 axis scale blue
        myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue
        myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue
        ' turn off the opposite tics so the Y2 tics don't show up on the Y axis
        myPane.Y2Axis.MajorTic.IsOpposite = False
        myPane.Y2Axis.MinorTic.IsOpposite = False
        ' Align the Y2 axis labels so they are flush to the axis
        myPane.Y2Axis.Scale.Align = AlignP.Inside

        Dim diskList = New PointPairList()
        Dim rQList = New PointPairList()
        Dim wQList = New PointPairList()

        Dim MaxQueue As Double = 0
        For Each row As DataRow In myData.Rows
            Dim x As Double = New XDate(CDate(row(0))).XLDate
            diskList.add(x, row(3))
            Dim rq As Double = row(4)
            Dim wq As Double = row(5)
            rQList.add(x, rq)
            wQList.add(x, wq)
            If rq > MaxQueue Then MaxQueue = rq
            If wq > MaxQueue Then MaxQueue = wq
        Next


        ' Manually Set Y2 Axis according to disk q
        myPane.Y2Axis.Scale.Min = 0
        myPane.Y2Axis.Scale.Max = CInt(MaxQueue) + 1


        Dim Curve As LineItem

        ' Generate a green curve with circle symbols, and "% Disk Time" in the legend
        Curve = myPane.AddCurve("% Disk Time", diskList, Color.Green, SymbolType.None)
        Curve.Line.IsSmooth = True
        Curve.Line.IsAntiAlias = True
        ' diskPercentCurve.Symbol.Fill = New Fill(Color.LightSkyBlue)

        Curve = myPane.AddCurve("Read Queue", rQList, Color.RoyalBlue, SymbolType.Circle)
        Curve.Line.IsSmooth = True
        Curve.Line.IsAntiAlias = True
        Curve.Symbol.Fill = New Fill(Color.White)
        ' Associate this curve with the Y2 axis
        Curve.IsY2Axis = True

        Curve = myPane.AddCurve("Write Queue", wQList, Color.DeepSkyBlue, SymbolType.Square)
        Curve.Line.IsSmooth = True
        Curve.Line.IsAntiAlias = True
        Curve.Symbol.Fill = New Fill(Color.White)
        ' Associate this curve with the Y2 axis
        Curve.IsY2Axis = True



        ' Fill the axis background with a color gradient
        myPane.Chart.Fill = New Fill(Color.White, Color.FromArgb(240, 240, 240), 45.0F) '(Color.AliceBlue, Color.White, 90.0F)
        ' Fill the outer pane background with a color gradient
        myPane.Fill = New Fill(Color.White) '(Color.White, Color.Gray, 90.0F)

        ' Calculate the Axis Scale Ranges
        zgc.AxisChange()
    End Sub

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
            CreateGraph(zg1)
            CreateDiskGraph(zg2)
            Me.Text = "Performance Graph: " & file
            Me.Width = 800
            Me.Height = 800
            Me.SplitContainer1.Visible = True
        End If
    End Sub

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

    Private Sub FmGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not FileToOpen Is Nothing Then
            Fill_DataTable(FileToOpen)
            CreateGraph(zg1)
            CreateDiskGraph(zg2)
            Me.Text = "Performance Graph: " & FileToOpen
            Me.Width = 800
            Me.Height = 800
            Me.SplitContainer1.Visible = True
        Else
            Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            Me.OpenFileDialog1.ShowDialog()
            Dim file As String
            Me.OpenFileDialog1.Title = "Select a pre-recorded file to open"
            file = Me.OpenFileDialog1.FileName
            If Not String.IsNullOrEmpty(file) Then
                Fill_DataTable(file)
                CreateGraph(zg1)
                CreateDiskGraph(zg2)
                Me.Text = "Performance Graph: " & file
                Me.Width = 800
                Me.Height = 800
                Me.SplitContainer1.Visible = True
            End If
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.OpenFileDialog1.ShowDialog()
        Dim file As String
        file = Me.OpenFileDialog1.FileName
        If Not String.IsNullOrEmpty(file) Then
            Fill_DataTable(file)
            CreateGraph(zg1)
            CreateDiskGraph(zg2)
            Me.Text = "Performance Graph: " & file
            Me.Width = 800
            Me.Height = 800
            Me.SplitContainer1.Visible = True
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

#Region "zedgraph helper"
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
End Class
