Imports ZedGraph

''' <summary>
''' Read in files containing cmc-performanceMonitor data
''' and display statistics and graphs.
''' </summary>
''' <remarks></remarks>
Public Class FmGraph

    Public FileToOpen As String
    Private myData As DataTable

    ' instance names + data present indicators
    Private _disk1Instance As String
    Private _disk2Instance As String
    Private _disk3Instance As String
    Private _NICInstance1 As String

    ' data present indicators
    Private _cpuActive As Boolean
    Private _memActive As Boolean
    Private _MemPagesInputActive As Boolean


    ''' <summary>
    ''' Create datatable and read performance data from file into datatable
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <remarks></remarks>
    Private Sub Fill_DataTable(ByVal filename As String)

        ' Clear existing values
        Me._MemPagesInputActive = False
        Me._cpuActive = False
        Me._memActive = False
        _disk1Instance = Nothing
        _disk2Instance = Nothing
        _disk3Instance = Nothing
        _NICInstance1 = Nothing

        ' Get computername & date from 1st line of file
        Dim sr As New System.IO.StreamReader(filename)
        Dim ArrInfo() As String = sr.ReadLine.Split(" ")
        Me.Text = UCase(ArrInfo(0)) & " - Performance Graph - " & ArrInfo(3)

        ' Get metric/instance information from 2nd line
        Dim instanceLine() As String = sr.ReadLine.Split(",")


        myData = New DataTable()
        myData.Columns.Add(New DataColumn("time", GetType(DateTime)))
        myData.Columns.Add(New DataColumn("cpu%", GetType(Double)))
        myData.Columns.Add(New DataColumn("mem%", GetType(Double)))
        myData.Columns.Add(New DataColumn("memInputPages", GetType(Double)))
        myData.Columns.Add(New DataColumn("spare1", GetType(Double)))
        myData.Columns.Add(New DataColumn("spare2", GetType(Double)))
        myData.Columns.Add(New DataColumn("spare3", GetType(Double)))
        myData.Columns.Add(New DataColumn("NicBytes", GetType(Double)))
        myData.Columns.Add(New DataColumn("spare4", GetType(Double)))
        myData.Columns.Add(New DataColumn("spare5", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk%", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskRead", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWrite", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskReadKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWriteKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk2%", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk2Read", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk2Write", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk2ReadKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk2WriteKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk3%", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk3Read", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk3Write", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk3ReadKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk3WriteKbSec", GetType(Double)))


        Dim ColCPU As Integer
        Dim ColMem As Integer
        Dim ColInputPages As Integer
        Dim ColNic1 As Integer
        Dim ColDskPercent1 As Integer
        Dim ColDskPercent2 As Integer
        Dim ColDskPercent3 As Integer
        For i As Integer = 0 To instanceLine.Length - 1
            Dim tmpString As String = Trim(instanceLine(i))
            If tmpString = "CPU_%_1" OrElse tmpString = "% Processor Time\_Total" Then
                _cpuActive = True
                ColCPU = i
            ElseIf tmpString = "CPU_%_0" Then
                _cpuActive = False
            ElseIf tmpString = "RAM_%_1" OrElse tmpString = "% Mem Used" Then
                Me._memActive = True
                ColMem = i
            ElseIf tmpString = "RAM_%_0" Then
                Me._memActive = False
            ElseIf tmpString = "Memory&Pages_InputPerSec_1" Then
                Me._MemPagesInputActive = True
                ColInputPages = i
            ElseIf tmpString = "Memory&Pages_InputPerSec_0" Then
                Me._MemPagesInputActive = False
            ElseIf tmpString = "Network_BytesPerSec_0" Then
                Me._NICInstance1 = False
            ElseIf tmpString.Contains("Network_BytesPerSec_") Then
                Me._NICInstance1 = True
                ColNic1 = i
            ElseIf tmpString.Contains("DiskTime_%_") OrElse tmpString.Contains("% Disk Time\") Then
                If String.IsNullOrEmpty(Me._disk1Instance) Then
                    Me._disk1Instance = tmpString.Substring(11)
                    ColDskPercent1 = i
                ElseIf String.IsNullOrEmpty(Me._disk2Instance) Then
                    Me._disk2Instance = tmpString.Substring(11)
                    ColDskPercent2 = i
                ElseIf String.IsNullOrEmpty(Me._disk3Instance) Then
                    Me._disk3Instance = tmpString.Substring(11)
                    ColDskPercent3 = i
                End If
            End If
        Next

        If String.IsNullOrEmpty(Me._disk1Instance) Then Me._disk1Instance = Nothing
        If String.IsNullOrEmpty(Me._disk2Instance) Then Me._disk2Instance = Nothing
        If String.IsNullOrEmpty(Me._disk3Instance) Then Me._disk3Instance = Nothing


        Do While Not sr.EndOfStream

            Dim line() As String = sr.ReadLine.Split(",")
            Dim dtNewRow As DataRow = myData.NewRow()
            ' For i As Integer = 0 To line.Length - 1
            dtNewRow.Item("time") = line(0)
            dtNewRow.Item("cpu%") = line(ColCPU)
            dtNewRow.Item("mem%") = line(ColMem)
            If Me._MemPagesInputActive Then dtNewRow.Item("memInputPages") = line(ColInputPages)
            If Me._NICInstance1 Then dtNewRow.Item("NicBytes") = line(ColNic1)

            If Not Me._disk1Instance Is Nothing Then
                dtNewRow.Item("disk%") = line(ColDskPercent1)
                dtNewRow.Item("diskRead") = line(ColDskPercent1 + 1)
                dtNewRow.Item("diskWrite") = line(ColDskPercent1 + 2)
                Try
                    dtNewRow.Item("diskReadKbSec") = line(ColDskPercent1 + 3)
                    dtNewRow.Item("diskWriteKbSec") = line(ColDskPercent1 + 4)
                Catch ex As Exception
                End Try
            End If
            If Not Me._disk2Instance Is Nothing Then
                dtNewRow.Item("disk2%") = line(ColDskPercent2)
                dtNewRow.Item("disk2Read") = line(ColDskPercent2 + 1)
                dtNewRow.Item("disk2Write") = line(ColDskPercent2 + 2)
                Try
                    dtNewRow.Item("disk2ReadKbSec") = line(ColDskPercent2 + 3)
                    dtNewRow.Item("disk2WriteKbSec") = line(ColDskPercent2 + 4)
                Catch ex As Exception
                End Try
            End If
            If Not Me._disk3Instance Is Nothing Then
                dtNewRow.Item("disk3%") = line(ColDskPercent3)
                dtNewRow.Item("disk3Read") = line(ColDskPercent3 + 1)
                dtNewRow.Item("disk3Write") = line(ColDskPercent3 + 2)
                dtNewRow.Item("disk3ReadKbSec") = line(ColDskPercent3 + 3)
                dtNewRow.Item("disk3WriteKbSec") = line(ColDskPercent3 + 4)
            End If
            ' Next
            Try
                myData.Rows.Add(dtNewRow)
            Catch ex As Exception
            End Try

        Loop
        sr.Close()


    End Sub
    Private Sub Old_Fill_DataTable(ByVal filename As String)
        myData = New DataTable()
        myData.Columns.Add(New DataColumn("time", GetType(DateTime)))
        myData.Columns.Add(New DataColumn("cpu%", GetType(Double)))
        myData.Columns.Add(New DataColumn("mem%", GetType(Double)))
        myData.Columns.Add(New DataColumn("disk%", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskRead", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWrite", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskReadKbSec", GetType(Double)))
        myData.Columns.Add(New DataColumn("diskWriteKbSec", GetType(Double)))

        Dim sr As New System.IO.StreamReader(filename)
        Dim instanceLine() As String = sr.ReadLine.Split(",")
        Me._disk1Instance = instanceLine(3).Substring(instanceLine(3).LastIndexOf("\") + 1)

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

    Private Sub CreateGraph(ByVal ZGC As ZedGraphControl, _
                                  ByVal GraphTitle As String, _
                                  ByVal YAxis1Title As String, _
                                  ByVal YAxis2Title As String, _
                                  ByVal CPUGraph As Boolean, _
                                  ByVal RAMGraph As Boolean, _
                                  ByVal PageGraph As Boolean, _
                                  ByVal NetGraph As Boolean, _
                                  ByVal DiskNumber As Integer, _
                                  ByVal DiskPercentGraph As Boolean, _
                                  ByVal DiskReadQueueGraph As Boolean, _
                                  ByVal DiskWriteQueueGraph As Boolean, _
                                  ByVal DiskReadRateGraph As Boolean, _
                                  ByVal DiskWriteRateGraph As Boolean)


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
        Dim diskList2 = New PointPairList()
        Dim rQList2 = New PointPairList()
        Dim wQList2 = New PointPairList()
        Dim ReadKbList2 = New PointPairList()
        Dim WriteKBList2 = New PointPairList()
        Dim diskList3 = New PointPairList()
        Dim rQList3 = New PointPairList()
        Dim wQList3 = New PointPairList()
        Dim ReadKbList3 = New PointPairList()
        Dim WriteKBList3 = New PointPairList()


        For Each row As DataRow In myData.Rows
            Dim x As Double = New XDate(CDate(row(0))).XLDate
            If Not row.IsNull("cpu%") Then cpuList.add(x, row("cpu%"))
            If Not row.IsNull("mem%") Then memList.add(x, row("mem%"))
            If Not row.IsNull("memInputPages") Then memPagesList.add(x, row("memInputPages"))
            If Not row.IsNull("NicBytes") Then NICList.add(x, row("NicBytes"))
            If Not Me._disk1Instance = Nothing Then
                If Not row.IsNull("disk%") Then diskList.add(x, row("disk%"))
                If Not row.IsNull("diskRead") Then rQList.add(x, row("diskRead"))
                If Not row.IsNull("diskWrite") Then wQList.add(x, row("diskWrite"))
                If Not row.IsNull("diskReadKbSec") Then ReadKbList.add(x, row("diskReadKbSec"))
                If Not row.IsNull("diskWriteKbSec") Then WriteKBList.add(x, row("diskWriteKbSec"))
            End If
            If Not Me._disk2Instance = Nothing Then
                If Not row.IsNull("disk2%") Then diskList2.add(x, row("disk2%"))
                If Not row.IsNull("disk2Read") Then rQList2.add(x, row("disk2Read"))
                If Not row.IsNull("disk2Write") Then wQList2.add(x, row("disk2Write"))
                If Not row.IsNull("disk2ReadKbSec") Then ReadKbList2.add(x, row("disk2ReadKbSec"))
                If Not row.IsNull("disk2WriteKbSec") Then WriteKBList2.add(x, row("disk2WriteKbSec"))
            End If
            If Not Me._disk3Instance = Nothing Then
                If Not row.IsNull("disk3%") Then diskList3.add(x, row("disk3%"))
                If Not row.IsNull("disk3Read") Then rQList3.add(x, row("disk3Read"))
                If Not row.IsNull("disk3Write") Then wQList3.add(x, row("disk3Write"))
                If Not row.IsNull("disk3ReadKbSec") Then ReadKbList3.add(x, row("disk3ReadKbSec"))
                If Not row.IsNull("disk3WriteKbSec") Then WriteKBList3.add(x, row("disk3WriteKbSec"))
            End If
        Next


        Dim Curve As LineItem

        Dim PPList As PointPairList = Nothing

        If DiskReadRateGraph Then
            If DiskNumber = 1 Then PPList = ReadKbList
            If DiskNumber = 2 Then PPList = ReadKbList2
            If DiskNumber = 3 Then PPList = ReadKbList3
            Curve = myPane.AddCurve("Disk Read", PPList, Me.PhysDiskIOReadCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskIOReadCurve.LineTension
            Curve.Line.Width = Me.PhysDiskIOReadCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskIOReadCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskIOReadCurve.LineColor)
        End If

        If DiskWriteRateGraph Then
            If DiskNumber = 1 Then PPList = WriteKBList
            If DiskNumber = 2 Then PPList = WriteKBList2
            If DiskNumber = 3 Then PPList = WriteKBList3
            Curve = myPane.AddCurve("Disk Write", PPList, Me.PhysDiskIOWriteCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskIOWriteCurve.LineTension
            Curve.Line.Width = Me.PhysDiskIOWriteCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskIOWriteCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskIOWriteCurve.LineColor)
        End If

        If DiskReadQueueGraph Then
            If DiskNumber = 1 Then PPList = rQList
            If DiskNumber = 2 Then PPList = rQList2
            If DiskNumber = 3 Then PPList = rQList3
            Curve = myPane.AddCurve("Read Queue", PPList, Me.PhysDiskQueueReadCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskQueueReadCurve.LineTension
            Curve.Line.Width = Me.PhysDiskQueueReadCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskQueueReadCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskQueueReadCurve.LineColor)

            Curve.IsY2Axis = True
        End If

        If DiskWriteQueueGraph Then
            If DiskNumber = 1 Then PPList = wQList
            If DiskNumber = 2 Then PPList = wQList2
            If DiskNumber = 3 Then PPList = wQList3
            Curve = myPane.AddCurve("Write Queue", PPList, Me.PhysDiskQueueWriteCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskQueueWriteCurve.LineTension
            Curve.Line.Width = Me.PhysDiskQueueWriteCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskQueueWriteCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskQueueWriteCurve.LineColor)

            Curve.IsY2Axis = True
        End If

        If DiskPercentGraph Then
            If DiskNumber = 1 Then PPList = diskList
            If DiskNumber = 2 Then PPList = diskList2
            If DiskNumber = 3 Then PPList = diskList3
            Curve = myPane.AddCurve("% Disk Time", PPList, Me.PhysDiskPercentCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.PhysDiskPercentCurve.LineTension
            Curve.Line.Width = Me.PhysDiskPercentCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.PhysDiskPercentCurve.Filled Then Curve.Line.Fill = New Fill(Me.PhysDiskPercentCurve.LineColor)

            myPane.YAxis.Scale.Min = 0
            myPane.YAxis.Scale.Max = 105
        End If

        If NetGraph Then
            Curve = myPane.AddCurve("Bytes/sec", NICList, Me.NicCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.NicCurve.LineTension
            Curve.Line.Width = Me.NicCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.NicCurve.Filled Then Curve.Line.Fill = New Fill(Me.NicCurve.LineColor)
        End If

        If PageGraph Then
            Curve = myPane.AddCurve("Memory Pages/sec", memPagesList, Me.MemPagesCurve.LineColor, SymbolType.None)
            Curve.Line.IsSmooth = True
            Curve.Line.SmoothTension = Me.MemPagesCurve.LineTension
            Curve.Line.Width = Me.MemPagesCurve.LineThickness
            Curve.Line.IsAntiAlias = True
            If Me.MemPagesCurve.Filled Then Curve.Line.Fill = New Fill(Me.MemPagesCurve.LineColor)
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

    ''' <summary>
    ''' Use the DataTable.Compute method to populate listviewbox
    ''' with Max, Min, Avg values for the collected data.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetStats()

        Me.ListViewStats.Items.Clear()

        Dim item As ListViewItem

        Try
            item = New ListViewItem("Processor - % Time")
            item.SubItems.Add(CInt(myData.Compute("MAX([cpu%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([cpu%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([cpu%])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        Try
            item = New ListViewItem("Memory  - % Used")
            item.SubItems.Add(CInt(myData.Compute("MAX([mem%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("MIN([mem%])", String.Empty)))
            item.SubItems.Add(CInt(myData.Compute("AVG([mem%])", String.Empty)))
            Me.ListViewStats.Items.Add(item)
        Catch ex As Exception
        End Try

        If Not Me._MemPagesInputActive = False Then
            Try
                item = New ListViewItem("Memory - Pages input/sec")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([memInputPages])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([memInputPages])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([memInputPages])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try
        End If

        If Not Me._NICInstance1 Is Nothing Then
            Try
                item = New ListViewItem("Network - Bytes/sec (" & Me._NICInstance1 & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([NicBytes])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([NicBytes])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([NicBytes])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try
        End If

        If Not Me._disk1Instance Is Nothing Then
            Try
                item = New ListViewItem("% Disk Time        (" & Me._disk1Instance & ")")
                item.SubItems.Add(CInt(myData.Compute("MAX([disk%])", String.Empty)))
                item.SubItems.Add(CInt(myData.Compute("MIN([disk%])", String.Empty)))
                item.SubItems.Add(CInt(myData.Compute("AVG([disk%])", String.Empty)))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk Read Queue    (" & Me._disk1Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([diskRead])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([diskRead])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([diskRead])", String.Empty), Single), 4))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk Write Queue   (" & Me._disk1Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([diskWrite])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([diskWrite])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([diskWrite])", String.Empty), Single), 4))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk IO Read kb/s  (" & Me._disk1Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([diskReadKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([diskReadKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([diskReadKbSec])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk IO Write kb/s (" & Me._disk1Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([diskWriteKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([diskWriteKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([diskWriteKbSec])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try
        End If

        If Not Me._disk2Instance Is Nothing Then
            Try
                item = New ListViewItem("% Disk Time        (" & Me._disk2Instance & ")")
                item.SubItems.Add(CInt(myData.Compute("MAX([disk2%])", String.Empty)))
                item.SubItems.Add(CInt(myData.Compute("MIN([disk2%])", String.Empty)))
                item.SubItems.Add(CInt(myData.Compute("AVG([disk2%])", String.Empty)))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk Read Queue    (" & Me._disk2Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk2Read])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk2Read])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk2Read])", String.Empty), Single), 4))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk Write Queue   (" & Me._disk2Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk2Write])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk2Write])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk2Write])", String.Empty), Single), 4))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk IO Read kb/s  (" & Me._disk2Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk2ReadKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk2ReadKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk2ReadKbSec])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk IO Write kb/s (" & Me._disk2Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk2WriteKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk2WriteKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk2WriteKbSec])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try
        End If

        If Not Me._disk3Instance Is Nothing Then
            Try
                item = New ListViewItem("% Disk Time        (" & Me._disk3Instance & ")")
                item.SubItems.Add(CInt(myData.Compute("MAX([disk3%])", String.Empty)))
                item.SubItems.Add(CInt(myData.Compute("MIN([disk3%])", String.Empty)))
                item.SubItems.Add(CInt(myData.Compute("AVG([disk3%])", String.Empty)))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk Read Queue    (" & Me._disk3Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk3Read])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk3Read])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk3Read])", String.Empty), Single), 4))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk Write Queue   (" & Me._disk3Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk3Write])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk3Write])", String.Empty), Single), 4))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk3Write])", String.Empty), Single), 4))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk IO Read kb/s  (" & Me._disk3Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk3ReadKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk3ReadKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk3ReadKbSec])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try

            Try
                item = New ListViewItem("Disk IO Write kb/s (" & Me._disk3Instance & ")")
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MAX([disk3WriteKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("MIN([disk3WriteKbSec])", String.Empty), Single), 0))
                item.SubItems.Add(FormatNumber(CType(myData.Compute("AVG([disk3WriteKbSec])", String.Empty), Single), 0))
                Me.ListViewStats.Items.Add(item)
            Catch ex As Exception
            End Try
        End If

    End Sub

    ''' <summary>
    ''' Clear existing graphs.
    ''' Reload data if required.
    ''' Call CreateGraph routine for active metrics.
    ''' </summary>
    ''' <param name="filename"></param>
    ''' <param name="UseCurrentData"></param>
    ''' <remarks></remarks>
    Private Sub PlotFileData(ByVal filename As String, ByVal UseCurrentData As Boolean)

        If Me.Height < 600 Then Me.Height = 625

        ' Clear Existing Graphs
        If Not myData Is Nothing Then
            zgc_cpu.GraphPane.CurveList.Clear()
            zgc_ram.GraphPane.CurveList.Clear()
            zgc_phsdisk1.GraphPane.CurveList.Clear()
            zgc_phsdisk2.GraphPane.CurveList.Clear()
            zgc_phsdisk3.GraphPane.CurveList.Clear()
            zgc_phsdisk4.GraphPane.CurveList.Clear()
            zgc_phsdisk5.GraphPane.CurveList.Clear()
            zgc_phsdisk6.GraphPane.CurveList.Clear()
            zgc_oth_1.GraphPane.CurveList.Clear()
            zgc_Perf_3.GraphPane.CurveList.Clear()
            zgc_cpu.Invalidate()
            zgc_ram.Invalidate()
            zgc_oth_1.Invalidate()
            zgc_Perf_3.Invalidate()
            zgc_phsdisk1.Invalidate()
            zgc_phsdisk2.Invalidate()
            zgc_phsdisk3.Invalidate()
            zgc_phsdisk4.Invalidate()
            zgc_phsdisk5.Invalidate()
            zgc_phsdisk6.Invalidate()
        End If


        If UseCurrentData = False Then
            ' Read New File data and plot graphs
            If Not filename Is Nothing Then
                Fill_DataTable(filename)
                TabShowHide()
            Else
                MsgBox("Load New File", MsgBoxStyle.Critical, "No Data")
                Return
            End If
        End If

        If Me._cpuActive Then CreateGraph(zgc_cpu, "CPU Utilisation", " % Percent", "", True, False, False, False, 1, False, False, False, False, False)
        If Me._memActive Then CreateGraph(zgc_ram, "Physical Memory Utilsation", "% Percent", "", False, True, False, False, 1, False, False, False, False, False)

        If Not Me._MemPagesInputActive = False Then
            CreateGraph(Me.zgc_Perf_3, "Memory Paging", "Pages input/sec", "", False, False, True, False, 0, False, False, False, False, False)
        End If

        If Not Me._disk1Instance Is Nothing Then
            CreateGraph(zgc_phsdisk1, "% Disk Time [" & Me._disk1Instance & "]", "Percent", "", False, False, False, False, 1, True, False, False, False, False)
            CreateGraph(zgc_phsdisk2, "Disk Queue Length [" & Me._disk1Instance & "]", "Avg Queue Length", "", False, False, False, False, 1, False, True, True, False, False)
            CreateGraph(zgc_phsdisk3, "Disk IO [" & Me._disk1Instance & "]", "Kb/Second", "", False, False, False, False, 1, False, False, False, True, True)
        End If
        If Not Me._disk2Instance Is Nothing Then
            CreateGraph(zgc_phsdisk4, "% Disk Time [" & Me._disk2Instance & "]", "Percent", "", False, False, False, False, 2, True, False, False, False, False)
            CreateGraph(zgc_phsdisk5, "Disk Queue Length [" & Me._disk2Instance & "]", "Avg Queue Length", "", False, False, False, False, 2, False, True, True, False, False)
            CreateGraph(zgc_phsdisk6, "Disk IO [" & Me._disk2Instance & "]", "Kb/Second", "", False, False, False, False, 2, False, False, False, True, True)
        End If
        If Not Me._disk3Instance Is Nothing Then
            CreateGraph(zgc_phsdisk7, "% Disk Time [" & Me._disk3Instance & "]", "Percent", "", False, False, False, False, 3, True, False, False, False, False)
            CreateGraph(zgc_phsdisk8, "Disk Queue Length [" & Me._disk3Instance & "]", "Avg Queue Length", "", False, False, False, False, 3, False, True, True, False, False)
            CreateGraph(zgc_phsdisk9, "Disk IO [" & Me._disk3Instance & "]", "Kb/Second", "", False, False, False, False, 3, False, False, False, True, True)
        End If

        If Not Me._NICInstance1 Is Nothing Then
            CreateGraph(zgc_oth_1, "Network [" & Me._NICInstance1 & "]", "Bytes/sec", "", False, False, False, True, 0, False, False, False, False, False)
        End If

    End Sub



#Region "Form Management"
    Private Sub FmGraph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DimCurves()

        ' if arg passed, use as target file
        If Environment.GetCommandLineArgs().Length = 2 Then
            Dim filename As String = Environment.GetCommandLineArgs(1)
            If System.IO.File.Exists(filename) Then
                FileToOpen = filename
            End If
        End If


        If Not FileToOpen Is Nothing Then
            Me.Height = 625
            'GraphPanelsVisible(True)

            Me.PlotFileData(FileToOpen, False)
            Me.GetStats()

        Else
            TabShowHide()
            'GraphPanelsVisible(False)
            Me.Height = 200
        End If


    End Sub
    Private Sub FmGraph_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Dim OneThirdHeight As Integer = (Me.TabControl1.Height - 26) / 3
        Me.Panel_Statistics.Height = 2 * OneThirdHeight
        Me.Panel_Perf_CPU.Height = OneThirdHeight
        Me.Panel_Perf_RAM.Height = OneThirdHeight
        Me.Panel_Perf_3.Height = OneThirdHeight
        Me.Panel_Oth_1.Height = OneThirdHeight
        Me.Panel_Oth_2.Height = OneThirdHeight
        Me.Panel_Oth_3.Height = OneThirdHeight
        Me.Panel_PhysDisk_1.Height = OneThirdHeight
        Me.Panel_PhysDisk_2.Height = OneThirdHeight
        Me.Panel_PhysDisk_3.Height = OneThirdHeight
        Me.Panel_physdisk_4.Height = OneThirdHeight
        Me.Panel_physdisk_5.Height = OneThirdHeight
        Me.Panel_physdisk_6.Height = OneThirdHeight
        Me.Panel_physdisk_7.Height = OneThirdHeight
        Me.Panel_physdisk_8.Height = OneThirdHeight
        Me.Panel_physdisk_9.Height = OneThirdHeight
    End Sub

    ''' <summary>
    ''' Launches open file dialog to open recorded data files
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>why is typing to difficult-  is it the beer?</remarks>
    Private Sub OpenToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Me.OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.OpenFileDialog1.ShowDialog()
        Dim file As String
        file = Me.OpenFileDialog1.FileName
        If Not String.IsNullOrEmpty(file) Then
            TabShowHide()
            Me.PlotFileData(file, False)
            Me.GetStats()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
#End Region

#Region "Curve Settings"
    ' instantiate curve settings
    Private CPUCurve As CurveSettings
    Private RAMCurve As CurveSettings
    Private MemPagesCurve As CurveSettings
    Private NicCurve As CurveSettings
    Private PhysDiskPercentCurve As CurveSettings
    Private PhysDiskQueueReadCurve As CurveSettings
    Private PhysDiskQueueWriteCurve As CurveSettings
    Private PhysDiskIOReadCurve As CurveSettings
    Private PhysDiskIOWriteCurve As CurveSettings

    Private Sub DimCurves()
        Me.CPUCurve = New CurveSettings
        Me.CPUCurve.Add("CPU", True)
        Me.RAMCurve = New CurveSettings
        Me.RAMCurve.Add("RAM", True)
        Me.MemPagesCurve = New CurveSettings
        Me.MemPagesCurve.Add("Pages", True)
        Me.NicCurve = New CurveSettings
        Me.NicCurve.Add("NIC", True)
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
    End Sub
#End Region

#Region "Context Menu"
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
    Private Sub PagesContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_Perf_3.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "PagesPropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub NicContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_oth_1.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "NicPropsMenu"
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
    Private Sub disk2PercentContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk4.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydisk1PropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub disk2queueContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk5.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydiskqueuePropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub disk2ioContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk6.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydiskIOPropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub disk3PercentContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk7.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydisk1PropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub disk3queueContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk8.ContextMenuBuilder
        Dim item As ToolStripMenuItem = New ToolStripMenuItem
        item.Name = "phydiskqueuePropsMenu"
        item.Text = "Properties"
        AddHandler item.Click, AddressOf Me.ShowSettings
        menuStrip.Items.Add(item)
    End Sub
    Private Sub disk3ioContextMenuBuilder(ByVal control As ZedGraphControl, ByVal menuStrip As ContextMenuStrip, ByVal mousePt As Point, ByVal objState As ZedGraphControl.ContextMenuObjectState) Handles zgc_phsdisk9.ContextMenuBuilder
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
                cs.GroupBoxLine1.Text = "Processor"
            Case "ramPropsMenu"
                myCurve = Me.RAMCurve
                cs.GroupBoxLine1.Text = "Memory"
            Case "PagesPropsMenu"
                myCurve = Me.MemPagesCurve
                cs.GroupBoxLine1.Text = "Memory Pages"
            Case "NicPropsMenu"
                myCurve = Me.NicCurve
                cs.GroupBoxLine1.Text = "Network Interface"
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
#End Region

#Region "Tab Control"
    Private Sub TabShowHide()

        Me.TabControl1.Visible = False

        HideTabPage(Me.TabPagePerf)
        HideTabPage(Me.TabPageDsk1)
        HideTabPage(Me.TabPageDsk2)
        HideTabPage(Me.TabPageDsk3)
        HideTabPage(Me.TabPageOther)

        If Me._cpuActive OrElse Me._memActive OrElse Me._MemPagesInputActive Then
            ShowTabPage(Me.TabPagePerf)
        Else
            HideTabPage(Me.TabPagePerf)
        End If

        If _disk1Instance Is Nothing Then
            HideTabPage(Me.TabPageDsk1)
        Else
            ShowTabPage(Me.TabPageDsk1)
        End If

        If _disk2Instance Is Nothing Then
            HideTabPage(Me.TabPageDsk2)
        Else
            ShowTabPage(Me.TabPageDsk2)
        End If

        If _disk3Instance Is Nothing Then
            HideTabPage(Me.TabPageDsk3)
        Else
            ShowTabPage(Me.TabPageDsk3)
        End If

        If _NICInstance1 Is Nothing Then
            HideTabPage(Me.TabPageOther)
        Else
            ShowTabPage(Me.TabPageOther)
        End If


        Me.TabControl1.SelectTab(Me.TabPageInfo)

        Me.TabControl1.Visible = True

    End Sub
    ' Add/Remove Tab Pages
    Private Sub HideTabPage(ByVal tp As TabPage)
        If Me.TabControl1.TabPages.Contains(tp) Then Me.TabControl1.TabPages.Remove(tp)
    End Sub
    Private Sub ShowTabPage(ByVal tp As TabPage)
        ShowTabPage(tp, Me.TabControl1.TabPages.Count)
    End Sub
    Private Sub ShowTabPage(ByVal tp As TabPage, ByVal index As Integer)
        If Me.TabControl1.TabPages.Contains(tp) Then Return
        InsertTabPage(tp, index)
    End Sub
    Private Sub InsertTabPage(ByVal [tabpage] As TabPage, ByVal [index] As Integer)
        If [index] < 0 Or [index] > Me.TabControl1.TabCount Then
            Throw New ArgumentException("Index out of Range.")
        End If
        Me.TabControl1.TabPages.Add([tabpage])
        If [index] < Me.TabControl1.TabCount - 1 Then
            Do While Me.TabControl1.TabPages.IndexOf([tabpage]) <> [index]
                SwapTabPages([tabpage], (Me.TabControl1.TabPages(Me.TabControl1.TabPages.IndexOf([tabpage]) - 1)))
            Loop
        End If
        Me.TabControl1.SelectedTab = [tabpage]
    End Sub
    Private Sub SwapTabPages(ByVal tp1 As TabPage, ByVal tp2 As TabPage)
        If Me.TabControl1.TabPages.Contains(tp1) = False Or Me.TabControl1.TabPages.Contains(tp2) = False Then
            Throw New ArgumentException("TabPages must be in the TabCotrols TabPageCollection.")
        End If
        Dim Index1 As Integer = Me.TabControl1.TabPages.IndexOf(tp1)
        Dim Index2 As Integer = Me.TabControl1.TabPages.IndexOf(tp2)
        Me.TabControl1.TabPages(Index1) = tp2
        Me.TabControl1.TabPages(Index2) = tp1
    End Sub
#End Region



End Class
