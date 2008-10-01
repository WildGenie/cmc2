<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmGraph))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ZedGraphControl2 = New ZedGraph.ZedGraphControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.ZedGraphControl3 = New ZedGraph.ZedGraphControl
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.ZedGraphControl4 = New ZedGraph.ZedGraphControl
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.ZedGraphControl5 = New ZedGraph.ZedGraphControl
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPageInfo = New System.Windows.Forms.TabPage
        Me.Panel_Statistics = New System.Windows.Forms.Panel
        Me.ListViewStats = New System.Windows.Forms.ListView
        Me.Metric = New System.Windows.Forms.ColumnHeader
        Me.Max = New System.Windows.Forms.ColumnHeader
        Me.Min = New System.Windows.Forms.ColumnHeader
        Me.Avg = New System.Windows.Forms.ColumnHeader
        Me.TabPagePerf = New System.Windows.Forms.TabPage
        Me.Panel_Perf_RAM = New System.Windows.Forms.Panel
        Me.zgc_ram = New ZedGraph.ZedGraphControl
        Me.Panel_Perf_3 = New System.Windows.Forms.Panel
        Me.zgc_Perf_3 = New ZedGraph.ZedGraphControl
        Me.Panel_Perf_CPU = New System.Windows.Forms.Panel
        Me.zgc_cpu = New ZedGraph.ZedGraphControl
        Me.TabPageDsk1 = New System.Windows.Forms.TabPage
        Me.Panel_PhysDisk_2 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk2 = New ZedGraph.ZedGraphControl
        Me.Panel_PhysDisk_3 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk3 = New ZedGraph.ZedGraphControl
        Me.Panel_PhysDisk_1 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk1 = New ZedGraph.ZedGraphControl
        Me.TabPageDsk2 = New System.Windows.Forms.TabPage
        Me.Panel_physdisk_6 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk6 = New ZedGraph.ZedGraphControl
        Me.Panel_physdisk_5 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk5 = New ZedGraph.ZedGraphControl
        Me.Panel_physdisk_4 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk4 = New ZedGraph.ZedGraphControl
        Me.TabPageDsk3 = New System.Windows.Forms.TabPage
        Me.Panel_physdisk_9 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk9 = New ZedGraph.ZedGraphControl
        Me.Panel_physdisk_8 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk8 = New ZedGraph.ZedGraphControl
        Me.Panel_physdisk_7 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk7 = New ZedGraph.ZedGraphControl
        Me.TabPageOther = New System.Windows.Forms.TabPage
        Me.Panel_Oth_3 = New System.Windows.Forms.Panel
        Me.Panel_Oth_2 = New System.Windows.Forms.Panel
        Me.Panel_Oth_1 = New System.Windows.Forms.Panel
        Me.zgc_oth_1 = New ZedGraph.ZedGraphControl
        Me.Panel_TabPageHolder = New System.Windows.Forms.Panel
        Me.MenuStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageInfo.SuspendLayout()
        Me.Panel_Statistics.SuspendLayout()
        Me.TabPagePerf.SuspendLayout()
        Me.Panel_Perf_RAM.SuspendLayout()
        Me.Panel_Perf_3.SuspendLayout()
        Me.Panel_Perf_CPU.SuspendLayout()
        Me.TabPageDsk1.SuspendLayout()
        Me.Panel_PhysDisk_2.SuspendLayout()
        Me.Panel_PhysDisk_3.SuspendLayout()
        Me.Panel_PhysDisk_1.SuspendLayout()
        Me.TabPageDsk2.SuspendLayout()
        Me.Panel_physdisk_6.SuspendLayout()
        Me.Panel_physdisk_5.SuspendLayout()
        Me.Panel_physdisk_4.SuspendLayout()
        Me.TabPageDsk3.SuspendLayout()
        Me.Panel_physdisk_9.SuspendLayout()
        Me.Panel_physdisk_8.SuspendLayout()
        Me.Panel_physdisk_7.SuspendLayout()
        Me.TabPageOther.SuspendLayout()
        Me.Panel_Oth_1.SuspendLayout()
        Me.Panel_TabPageHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "PerfMonitor Files|*.pff|All Files|*.*"
        Me.OpenFileDialog1.Title = "Select file to open"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(514, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(506, 484)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Performance"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ZedGraphControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 250)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 102)
        Me.Panel2.TabIndex = 1
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZedGraphControl1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZedGraphControl1.IsAntiAlias = True
        Me.ZedGraphControl1.Location = New System.Drawing.Point(0, 0)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0
        Me.ZedGraphControl1.ScrollMaxX = 0
        Me.ZedGraphControl1.ScrollMaxY = 0
        Me.ZedGraphControl1.ScrollMaxY2 = 0
        Me.ZedGraphControl1.ScrollMinX = 0
        Me.ZedGraphControl1.ScrollMinY = 0
        Me.ZedGraphControl1.ScrollMinY2 = 0
        Me.ZedGraphControl1.Size = New System.Drawing.Size(500, 102)
        Me.ZedGraphControl1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ZedGraphControl2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(3, 352)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 129)
        Me.Panel3.TabIndex = 2
        '
        'ZedGraphControl2
        '
        Me.ZedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZedGraphControl2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZedGraphControl2.Location = New System.Drawing.Point(0, 0)
        Me.ZedGraphControl2.Name = "ZedGraphControl2"
        Me.ZedGraphControl2.ScrollGrace = 0
        Me.ZedGraphControl2.ScrollMaxX = 0
        Me.ZedGraphControl2.ScrollMaxY = 0
        Me.ZedGraphControl2.ScrollMaxY2 = 0
        Me.ZedGraphControl2.ScrollMinX = 0
        Me.ZedGraphControl2.ScrollMinY = 0
        Me.ZedGraphControl2.ScrollMinY2 = 0
        Me.ZedGraphControl2.Size = New System.Drawing.Size(500, 129)
        Me.ZedGraphControl2.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ListView1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(500, 137)
        Me.Panel4.TabIndex = 3
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(500, 137)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Metric"
        Me.ColumnHeader1.Width = 179
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Max Value"
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Min Value"
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Average"
        Me.ColumnHeader4.Width = 91
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Controls.Add(Me.Panel6)
        Me.TabPage4.Controls.Add(Me.Panel7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(506, 484)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "PhysicalDisk"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ZedGraphControl3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 131)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(506, 207)
        Me.Panel5.TabIndex = 2
        '
        'ZedGraphControl3
        '
        Me.ZedGraphControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZedGraphControl3.Location = New System.Drawing.Point(0, 0)
        Me.ZedGraphControl3.Name = "ZedGraphControl3"
        Me.ZedGraphControl3.ScrollGrace = 0
        Me.ZedGraphControl3.ScrollMaxX = 0
        Me.ZedGraphControl3.ScrollMaxY = 0
        Me.ZedGraphControl3.ScrollMaxY2 = 0
        Me.ZedGraphControl3.ScrollMinX = 0
        Me.ZedGraphControl3.ScrollMinY = 0
        Me.ZedGraphControl3.ScrollMinY2 = 0
        Me.ZedGraphControl3.Size = New System.Drawing.Size(506, 207)
        Me.ZedGraphControl3.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ZedGraphControl4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 338)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(506, 146)
        Me.Panel6.TabIndex = 1
        '
        'ZedGraphControl4
        '
        Me.ZedGraphControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZedGraphControl4.Location = New System.Drawing.Point(0, 0)
        Me.ZedGraphControl4.Name = "ZedGraphControl4"
        Me.ZedGraphControl4.ScrollGrace = 0
        Me.ZedGraphControl4.ScrollMaxX = 0
        Me.ZedGraphControl4.ScrollMaxY = 0
        Me.ZedGraphControl4.ScrollMaxY2 = 0
        Me.ZedGraphControl4.ScrollMinX = 0
        Me.ZedGraphControl4.ScrollMinY = 0
        Me.ZedGraphControl4.ScrollMinY2 = 0
        Me.ZedGraphControl4.Size = New System.Drawing.Size(506, 146)
        Me.ZedGraphControl4.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ZedGraphControl5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(506, 131)
        Me.Panel7.TabIndex = 0
        '
        'ZedGraphControl5
        '
        Me.ZedGraphControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ZedGraphControl5.Location = New System.Drawing.Point(0, 0)
        Me.ZedGraphControl5.Name = "ZedGraphControl5"
        Me.ZedGraphControl5.ScrollGrace = 0
        Me.ZedGraphControl5.ScrollMaxX = 0
        Me.ZedGraphControl5.ScrollMaxY = 0
        Me.ZedGraphControl5.ScrollMaxY2 = 0
        Me.ZedGraphControl5.ScrollMinX = 0
        Me.ZedGraphControl5.ScrollMinY = 0
        Me.ZedGraphControl5.ScrollMinY2 = 0
        Me.ZedGraphControl5.Size = New System.Drawing.Size(506, 131)
        Me.ZedGraphControl5.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageInfo)
        Me.TabControl1.Controls.Add(Me.TabPagePerf)
        Me.TabControl1.Controls.Add(Me.TabPageDsk1)
        Me.TabControl1.Controls.Add(Me.TabPageDsk2)
        Me.TabControl1.Controls.Add(Me.TabPageDsk3)
        Me.TabControl1.Controls.Add(Me.TabPageOther)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(514, 565)
        Me.TabControl1.TabIndex = 0
        '
        'TabPageInfo
        '
        Me.TabPageInfo.Controls.Add(Me.Panel_Statistics)
        Me.TabPageInfo.Location = New System.Drawing.Point(4, 22)
        Me.TabPageInfo.Name = "TabPageInfo"
        Me.TabPageInfo.Size = New System.Drawing.Size(506, 539)
        Me.TabPageInfo.TabIndex = 6
        Me.TabPageInfo.Text = "Information"
        Me.TabPageInfo.UseVisualStyleBackColor = True
        '
        'Panel_Statistics
        '
        Me.Panel_Statistics.Controls.Add(Me.ListViewStats)
        Me.Panel_Statistics.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Statistics.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Statistics.Name = "Panel_Statistics"
        Me.Panel_Statistics.Size = New System.Drawing.Size(506, 323)
        Me.Panel_Statistics.TabIndex = 0
        '
        'ListViewStats
        '
        Me.ListViewStats.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Metric, Me.Max, Me.Min, Me.Avg})
        Me.ListViewStats.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewStats.Font = New System.Drawing.Font("Courier New", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListViewStats.FullRowSelect = True
        Me.ListViewStats.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListViewStats.LabelWrap = False
        Me.ListViewStats.Location = New System.Drawing.Point(0, 0)
        Me.ListViewStats.Name = "ListViewStats"
        Me.ListViewStats.Size = New System.Drawing.Size(506, 323)
        Me.ListViewStats.TabIndex = 1
        Me.ListViewStats.UseCompatibleStateImageBehavior = False
        Me.ListViewStats.View = System.Windows.Forms.View.Details
        '
        'Metric
        '
        Me.Metric.Text = "Metric"
        Me.Metric.Width = 231
        '
        'Max
        '
        Me.Max.Text = "Max Value"
        Me.Max.Width = 94
        '
        'Min
        '
        Me.Min.Text = "Min Value"
        Me.Min.Width = 85
        '
        'Avg
        '
        Me.Avg.Text = "Average"
        Me.Avg.Width = 89
        '
        'TabPagePerf
        '
        Me.TabPagePerf.Controls.Add(Me.Panel_Perf_RAM)
        Me.TabPagePerf.Controls.Add(Me.Panel_Perf_3)
        Me.TabPagePerf.Controls.Add(Me.Panel_Perf_CPU)
        Me.TabPagePerf.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePerf.Name = "TabPagePerf"
        Me.TabPagePerf.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePerf.Size = New System.Drawing.Size(506, 487)
        Me.TabPagePerf.TabIndex = 1
        Me.TabPagePerf.Text = "Performance"
        Me.TabPagePerf.UseVisualStyleBackColor = True
        '
        'Panel_Perf_RAM
        '
        Me.Panel_Perf_RAM.Controls.Add(Me.zgc_ram)
        Me.Panel_Perf_RAM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Perf_RAM.Location = New System.Drawing.Point(3, 147)
        Me.Panel_Perf_RAM.Name = "Panel_Perf_RAM"
        Me.Panel_Perf_RAM.Size = New System.Drawing.Size(500, 167)
        Me.Panel_Perf_RAM.TabIndex = 2
        '
        'zgc_ram
        '
        Me.zgc_ram.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_ram.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zgc_ram.Location = New System.Drawing.Point(0, 0)
        Me.zgc_ram.Name = "zgc_ram"
        Me.zgc_ram.ScrollGrace = 0
        Me.zgc_ram.ScrollMaxX = 0
        Me.zgc_ram.ScrollMaxY = 0
        Me.zgc_ram.ScrollMaxY2 = 0
        Me.zgc_ram.ScrollMinX = 0
        Me.zgc_ram.ScrollMinY = 0
        Me.zgc_ram.ScrollMinY2 = 0
        Me.zgc_ram.Size = New System.Drawing.Size(500, 167)
        Me.zgc_ram.TabIndex = 0
        '
        'Panel_Perf_3
        '
        Me.Panel_Perf_3.Controls.Add(Me.zgc_Perf_3)
        Me.Panel_Perf_3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Perf_3.Location = New System.Drawing.Point(3, 314)
        Me.Panel_Perf_3.Name = "Panel_Perf_3"
        Me.Panel_Perf_3.Size = New System.Drawing.Size(500, 170)
        Me.Panel_Perf_3.TabIndex = 3
        '
        'zgc_Perf_3
        '
        Me.zgc_Perf_3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_Perf_3.Location = New System.Drawing.Point(0, 0)
        Me.zgc_Perf_3.Name = "zgc_Perf_3"
        Me.zgc_Perf_3.ScrollGrace = 0
        Me.zgc_Perf_3.ScrollMaxX = 0
        Me.zgc_Perf_3.ScrollMaxY = 0
        Me.zgc_Perf_3.ScrollMaxY2 = 0
        Me.zgc_Perf_3.ScrollMinX = 0
        Me.zgc_Perf_3.ScrollMinY = 0
        Me.zgc_Perf_3.ScrollMinY2 = 0
        Me.zgc_Perf_3.Size = New System.Drawing.Size(500, 170)
        Me.zgc_Perf_3.TabIndex = 1
        '
        'Panel_Perf_CPU
        '
        Me.Panel_Perf_CPU.Controls.Add(Me.zgc_cpu)
        Me.Panel_Perf_CPU.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Perf_CPU.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Perf_CPU.Name = "Panel_Perf_CPU"
        Me.Panel_Perf_CPU.Size = New System.Drawing.Size(500, 144)
        Me.Panel_Perf_CPU.TabIndex = 1
        '
        'zgc_cpu
        '
        Me.zgc_cpu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_cpu.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.zgc_cpu.IsAntiAlias = True
        Me.zgc_cpu.Location = New System.Drawing.Point(0, 0)
        Me.zgc_cpu.Name = "zgc_cpu"
        Me.zgc_cpu.ScrollGrace = 0
        Me.zgc_cpu.ScrollMaxX = 0
        Me.zgc_cpu.ScrollMaxY = 0
        Me.zgc_cpu.ScrollMaxY2 = 0
        Me.zgc_cpu.ScrollMinX = 0
        Me.zgc_cpu.ScrollMinY = 0
        Me.zgc_cpu.ScrollMinY2 = 0
        Me.zgc_cpu.Size = New System.Drawing.Size(500, 144)
        Me.zgc_cpu.TabIndex = 0
        '
        'TabPageDsk1
        '
        Me.TabPageDsk1.Controls.Add(Me.Panel_PhysDisk_2)
        Me.TabPageDsk1.Controls.Add(Me.Panel_PhysDisk_3)
        Me.TabPageDsk1.Controls.Add(Me.Panel_PhysDisk_1)
        Me.TabPageDsk1.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDsk1.Name = "TabPageDsk1"
        Me.TabPageDsk1.Size = New System.Drawing.Size(506, 487)
        Me.TabPageDsk1.TabIndex = 2
        Me.TabPageDsk1.Text = "PhysicalDisk1"
        Me.TabPageDsk1.UseVisualStyleBackColor = True
        '
        'Panel_PhysDisk_2
        '
        Me.Panel_PhysDisk_2.Controls.Add(Me.zgc_phsdisk2)
        Me.Panel_PhysDisk_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_PhysDisk_2.Location = New System.Drawing.Point(0, 131)
        Me.Panel_PhysDisk_2.Name = "Panel_PhysDisk_2"
        Me.Panel_PhysDisk_2.Size = New System.Drawing.Size(506, 210)
        Me.Panel_PhysDisk_2.TabIndex = 2
        '
        'zgc_phsdisk2
        '
        Me.zgc_phsdisk2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk2.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk2.Name = "zgc_phsdisk2"
        Me.zgc_phsdisk2.ScrollGrace = 0
        Me.zgc_phsdisk2.ScrollMaxX = 0
        Me.zgc_phsdisk2.ScrollMaxY = 0
        Me.zgc_phsdisk2.ScrollMaxY2 = 0
        Me.zgc_phsdisk2.ScrollMinX = 0
        Me.zgc_phsdisk2.ScrollMinY = 0
        Me.zgc_phsdisk2.ScrollMinY2 = 0
        Me.zgc_phsdisk2.Size = New System.Drawing.Size(506, 210)
        Me.zgc_phsdisk2.TabIndex = 0
        '
        'Panel_PhysDisk_3
        '
        Me.Panel_PhysDisk_3.Controls.Add(Me.zgc_phsdisk3)
        Me.Panel_PhysDisk_3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_PhysDisk_3.Location = New System.Drawing.Point(0, 341)
        Me.Panel_PhysDisk_3.Name = "Panel_PhysDisk_3"
        Me.Panel_PhysDisk_3.Size = New System.Drawing.Size(506, 146)
        Me.Panel_PhysDisk_3.TabIndex = 1
        '
        'zgc_phsdisk3
        '
        Me.zgc_phsdisk3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk3.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk3.Name = "zgc_phsdisk3"
        Me.zgc_phsdisk3.ScrollGrace = 0
        Me.zgc_phsdisk3.ScrollMaxX = 0
        Me.zgc_phsdisk3.ScrollMaxY = 0
        Me.zgc_phsdisk3.ScrollMaxY2 = 0
        Me.zgc_phsdisk3.ScrollMinX = 0
        Me.zgc_phsdisk3.ScrollMinY = 0
        Me.zgc_phsdisk3.ScrollMinY2 = 0
        Me.zgc_phsdisk3.Size = New System.Drawing.Size(506, 146)
        Me.zgc_phsdisk3.TabIndex = 0
        '
        'Panel_PhysDisk_1
        '
        Me.Panel_PhysDisk_1.Controls.Add(Me.zgc_phsdisk1)
        Me.Panel_PhysDisk_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_PhysDisk_1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_PhysDisk_1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_PhysDisk_1.Name = "Panel_PhysDisk_1"
        Me.Panel_PhysDisk_1.Size = New System.Drawing.Size(506, 131)
        Me.Panel_PhysDisk_1.TabIndex = 0
        '
        'zgc_phsdisk1
        '
        Me.zgc_phsdisk1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk1.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk1.Name = "zgc_phsdisk1"
        Me.zgc_phsdisk1.ScrollGrace = 0
        Me.zgc_phsdisk1.ScrollMaxX = 0
        Me.zgc_phsdisk1.ScrollMaxY = 0
        Me.zgc_phsdisk1.ScrollMaxY2 = 0
        Me.zgc_phsdisk1.ScrollMinX = 0
        Me.zgc_phsdisk1.ScrollMinY = 0
        Me.zgc_phsdisk1.ScrollMinY2 = 0
        Me.zgc_phsdisk1.Size = New System.Drawing.Size(506, 131)
        Me.zgc_phsdisk1.TabIndex = 0
        '
        'TabPageDsk2
        '
        Me.TabPageDsk2.Controls.Add(Me.Panel_physdisk_6)
        Me.TabPageDsk2.Controls.Add(Me.Panel_physdisk_5)
        Me.TabPageDsk2.Controls.Add(Me.Panel_physdisk_4)
        Me.TabPageDsk2.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDsk2.Name = "TabPageDsk2"
        Me.TabPageDsk2.Size = New System.Drawing.Size(506, 487)
        Me.TabPageDsk2.TabIndex = 3
        Me.TabPageDsk2.Text = "PhysicalDisk2"
        Me.TabPageDsk2.UseVisualStyleBackColor = True
        '
        'Panel_physdisk_6
        '
        Me.Panel_physdisk_6.Controls.Add(Me.zgc_phsdisk6)
        Me.Panel_physdisk_6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_physdisk_6.Location = New System.Drawing.Point(0, 297)
        Me.Panel_physdisk_6.Name = "Panel_physdisk_6"
        Me.Panel_physdisk_6.Size = New System.Drawing.Size(506, 144)
        Me.Panel_physdisk_6.TabIndex = 2
        '
        'zgc_phsdisk6
        '
        Me.zgc_phsdisk6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk6.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk6.Name = "zgc_phsdisk6"
        Me.zgc_phsdisk6.ScrollGrace = 0
        Me.zgc_phsdisk6.ScrollMaxX = 0
        Me.zgc_phsdisk6.ScrollMaxY = 0
        Me.zgc_phsdisk6.ScrollMaxY2 = 0
        Me.zgc_phsdisk6.ScrollMinX = 0
        Me.zgc_phsdisk6.ScrollMinY = 0
        Me.zgc_phsdisk6.ScrollMinY2 = 0
        Me.zgc_phsdisk6.Size = New System.Drawing.Size(506, 144)
        Me.zgc_phsdisk6.TabIndex = 0
        '
        'Panel_physdisk_5
        '
        Me.Panel_physdisk_5.Controls.Add(Me.zgc_phsdisk5)
        Me.Panel_physdisk_5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_physdisk_5.Location = New System.Drawing.Point(0, 161)
        Me.Panel_physdisk_5.Name = "Panel_physdisk_5"
        Me.Panel_physdisk_5.Size = New System.Drawing.Size(506, 136)
        Me.Panel_physdisk_5.TabIndex = 1
        '
        'zgc_phsdisk5
        '
        Me.zgc_phsdisk5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk5.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk5.Name = "zgc_phsdisk5"
        Me.zgc_phsdisk5.ScrollGrace = 0
        Me.zgc_phsdisk5.ScrollMaxX = 0
        Me.zgc_phsdisk5.ScrollMaxY = 0
        Me.zgc_phsdisk5.ScrollMaxY2 = 0
        Me.zgc_phsdisk5.ScrollMinX = 0
        Me.zgc_phsdisk5.ScrollMinY = 0
        Me.zgc_phsdisk5.ScrollMinY2 = 0
        Me.zgc_phsdisk5.Size = New System.Drawing.Size(506, 136)
        Me.zgc_phsdisk5.TabIndex = 0
        '
        'Panel_physdisk_4
        '
        Me.Panel_physdisk_4.Controls.Add(Me.zgc_phsdisk4)
        Me.Panel_physdisk_4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_physdisk_4.Location = New System.Drawing.Point(0, 0)
        Me.Panel_physdisk_4.Name = "Panel_physdisk_4"
        Me.Panel_physdisk_4.Size = New System.Drawing.Size(506, 161)
        Me.Panel_physdisk_4.TabIndex = 0
        '
        'zgc_phsdisk4
        '
        Me.zgc_phsdisk4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk4.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk4.Name = "zgc_phsdisk4"
        Me.zgc_phsdisk4.ScrollGrace = 0
        Me.zgc_phsdisk4.ScrollMaxX = 0
        Me.zgc_phsdisk4.ScrollMaxY = 0
        Me.zgc_phsdisk4.ScrollMaxY2 = 0
        Me.zgc_phsdisk4.ScrollMinX = 0
        Me.zgc_phsdisk4.ScrollMinY = 0
        Me.zgc_phsdisk4.ScrollMinY2 = 0
        Me.zgc_phsdisk4.Size = New System.Drawing.Size(506, 161)
        Me.zgc_phsdisk4.TabIndex = 0
        '
        'TabPageDsk3
        '
        Me.TabPageDsk3.Controls.Add(Me.Panel_physdisk_9)
        Me.TabPageDsk3.Controls.Add(Me.Panel_physdisk_8)
        Me.TabPageDsk3.Controls.Add(Me.Panel_physdisk_7)
        Me.TabPageDsk3.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDsk3.Name = "TabPageDsk3"
        Me.TabPageDsk3.Size = New System.Drawing.Size(506, 487)
        Me.TabPageDsk3.TabIndex = 5
        Me.TabPageDsk3.Text = "PhysicalDisk3"
        Me.TabPageDsk3.UseVisualStyleBackColor = True
        '
        'Panel_physdisk_9
        '
        Me.Panel_physdisk_9.Controls.Add(Me.zgc_phsdisk9)
        Me.Panel_physdisk_9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_physdisk_9.Location = New System.Drawing.Point(0, 317)
        Me.Panel_physdisk_9.Name = "Panel_physdisk_9"
        Me.Panel_physdisk_9.Size = New System.Drawing.Size(506, 167)
        Me.Panel_physdisk_9.TabIndex = 2
        '
        'zgc_phsdisk9
        '
        Me.zgc_phsdisk9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk9.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk9.Name = "zgc_phsdisk9"
        Me.zgc_phsdisk9.ScrollGrace = 0
        Me.zgc_phsdisk9.ScrollMaxX = 0
        Me.zgc_phsdisk9.ScrollMaxY = 0
        Me.zgc_phsdisk9.ScrollMaxY2 = 0
        Me.zgc_phsdisk9.ScrollMinX = 0
        Me.zgc_phsdisk9.ScrollMinY = 0
        Me.zgc_phsdisk9.ScrollMinY2 = 0
        Me.zgc_phsdisk9.Size = New System.Drawing.Size(506, 167)
        Me.zgc_phsdisk9.TabIndex = 0
        '
        'Panel_physdisk_8
        '
        Me.Panel_physdisk_8.Controls.Add(Me.zgc_phsdisk8)
        Me.Panel_physdisk_8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_physdisk_8.Location = New System.Drawing.Point(0, 142)
        Me.Panel_physdisk_8.Name = "Panel_physdisk_8"
        Me.Panel_physdisk_8.Size = New System.Drawing.Size(506, 175)
        Me.Panel_physdisk_8.TabIndex = 1
        '
        'zgc_phsdisk8
        '
        Me.zgc_phsdisk8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk8.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk8.Name = "zgc_phsdisk8"
        Me.zgc_phsdisk8.ScrollGrace = 0
        Me.zgc_phsdisk8.ScrollMaxX = 0
        Me.zgc_phsdisk8.ScrollMaxY = 0
        Me.zgc_phsdisk8.ScrollMaxY2 = 0
        Me.zgc_phsdisk8.ScrollMinX = 0
        Me.zgc_phsdisk8.ScrollMinY = 0
        Me.zgc_phsdisk8.ScrollMinY2 = 0
        Me.zgc_phsdisk8.Size = New System.Drawing.Size(506, 175)
        Me.zgc_phsdisk8.TabIndex = 0
        '
        'Panel_physdisk_7
        '
        Me.Panel_physdisk_7.Controls.Add(Me.zgc_phsdisk7)
        Me.Panel_physdisk_7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_physdisk_7.Location = New System.Drawing.Point(0, 0)
        Me.Panel_physdisk_7.Name = "Panel_physdisk_7"
        Me.Panel_physdisk_7.Size = New System.Drawing.Size(506, 142)
        Me.Panel_physdisk_7.TabIndex = 0
        '
        'zgc_phsdisk7
        '
        Me.zgc_phsdisk7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_phsdisk7.Location = New System.Drawing.Point(0, 0)
        Me.zgc_phsdisk7.Name = "zgc_phsdisk7"
        Me.zgc_phsdisk7.ScrollGrace = 0
        Me.zgc_phsdisk7.ScrollMaxX = 0
        Me.zgc_phsdisk7.ScrollMaxY = 0
        Me.zgc_phsdisk7.ScrollMaxY2 = 0
        Me.zgc_phsdisk7.ScrollMinX = 0
        Me.zgc_phsdisk7.ScrollMinY = 0
        Me.zgc_phsdisk7.ScrollMinY2 = 0
        Me.zgc_phsdisk7.Size = New System.Drawing.Size(506, 142)
        Me.zgc_phsdisk7.TabIndex = 0
        '
        'TabPageOther
        '
        Me.TabPageOther.Controls.Add(Me.Panel_Oth_3)
        Me.TabPageOther.Controls.Add(Me.Panel_Oth_2)
        Me.TabPageOther.Controls.Add(Me.Panel_Oth_1)
        Me.TabPageOther.Location = New System.Drawing.Point(4, 22)
        Me.TabPageOther.Name = "TabPageOther"
        Me.TabPageOther.Size = New System.Drawing.Size(506, 487)
        Me.TabPageOther.TabIndex = 4
        Me.TabPageOther.Text = "Network Interface"
        Me.TabPageOther.UseVisualStyleBackColor = True
        '
        'Panel_Oth_3
        '
        Me.Panel_Oth_3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Oth_3.Location = New System.Drawing.Point(0, 303)
        Me.Panel_Oth_3.Name = "Panel_Oth_3"
        Me.Panel_Oth_3.Size = New System.Drawing.Size(506, 184)
        Me.Panel_Oth_3.TabIndex = 2
        '
        'Panel_Oth_2
        '
        Me.Panel_Oth_2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Oth_2.Location = New System.Drawing.Point(0, 133)
        Me.Panel_Oth_2.Name = "Panel_Oth_2"
        Me.Panel_Oth_2.Size = New System.Drawing.Size(506, 154)
        Me.Panel_Oth_2.TabIndex = 1
        '
        'Panel_Oth_1
        '
        Me.Panel_Oth_1.Controls.Add(Me.zgc_oth_1)
        Me.Panel_Oth_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Oth_1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Oth_1.Name = "Panel_Oth_1"
        Me.Panel_Oth_1.Size = New System.Drawing.Size(506, 133)
        Me.Panel_Oth_1.TabIndex = 0
        '
        'zgc_oth_1
        '
        Me.zgc_oth_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.zgc_oth_1.Location = New System.Drawing.Point(0, 0)
        Me.zgc_oth_1.Name = "zgc_oth_1"
        Me.zgc_oth_1.ScrollGrace = 0
        Me.zgc_oth_1.ScrollMaxX = 0
        Me.zgc_oth_1.ScrollMaxY = 0
        Me.zgc_oth_1.ScrollMaxY2 = 0
        Me.zgc_oth_1.ScrollMinX = 0
        Me.zgc_oth_1.ScrollMinY = 0
        Me.zgc_oth_1.ScrollMinY2 = 0
        Me.zgc_oth_1.Size = New System.Drawing.Size(506, 133)
        Me.zgc_oth_1.TabIndex = 0
        '
        'Panel_TabPageHolder
        '
        Me.Panel_TabPageHolder.Controls.Add(Me.TabControl1)
        Me.Panel_TabPageHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_TabPageHolder.Location = New System.Drawing.Point(0, 24)
        Me.Panel_TabPageHolder.Name = "Panel_TabPageHolder"
        Me.Panel_TabPageHolder.Size = New System.Drawing.Size(514, 565)
        Me.Panel_TabPageHolder.TabIndex = 5
        '
        'FmGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 589)
        Me.Controls.Add(Me.Panel_TabPageHolder)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FmGraph"
        Me.Text = "Performance Graph"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageInfo.ResumeLayout(False)
        Me.Panel_Statistics.ResumeLayout(False)
        Me.TabPagePerf.ResumeLayout(False)
        Me.Panel_Perf_RAM.ResumeLayout(False)
        Me.Panel_Perf_3.ResumeLayout(False)
        Me.Panel_Perf_CPU.ResumeLayout(False)
        Me.TabPageDsk1.ResumeLayout(False)
        Me.Panel_PhysDisk_2.ResumeLayout(False)
        Me.Panel_PhysDisk_3.ResumeLayout(False)
        Me.Panel_PhysDisk_1.ResumeLayout(False)
        Me.TabPageDsk2.ResumeLayout(False)
        Me.Panel_physdisk_6.ResumeLayout(False)
        Me.Panel_physdisk_5.ResumeLayout(False)
        Me.Panel_physdisk_4.ResumeLayout(False)
        Me.TabPageDsk3.ResumeLayout(False)
        Me.Panel_physdisk_9.ResumeLayout(False)
        Me.Panel_physdisk_8.ResumeLayout(False)
        Me.Panel_physdisk_7.ResumeLayout(False)
        Me.TabPageOther.ResumeLayout(False)
        Me.Panel_Oth_1.ResumeLayout(False)
        Me.Panel_TabPageHolder.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ZedGraphControl2 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ZedGraphControl3 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents ZedGraphControl4 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ZedGraphControl5 As ZedGraph.ZedGraphControl
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPagePerf As System.Windows.Forms.TabPage
    Friend WithEvents Panel_Perf_CPU As System.Windows.Forms.Panel
    Friend WithEvents zgc_cpu As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_Perf_RAM As System.Windows.Forms.Panel
    Friend WithEvents zgc_ram As ZedGraph.ZedGraphControl
    Friend WithEvents TabPageOther As System.Windows.Forms.TabPage
    Friend WithEvents Panel_Oth_3 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Oth_2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_Oth_1 As System.Windows.Forms.Panel
    Friend WithEvents zgc_oth_1 As ZedGraph.ZedGraphControl
    Friend WithEvents TabPageDsk1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel_PhysDisk_2 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk2 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_PhysDisk_3 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk3 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_PhysDisk_1 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk1 As ZedGraph.ZedGraphControl
    Friend WithEvents TabPageDsk2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel_physdisk_6 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk6 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_physdisk_5 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk5 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_physdisk_4 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk4 As ZedGraph.ZedGraphControl
    Friend WithEvents TabPageDsk3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel_physdisk_9 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk9 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_physdisk_8 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk8 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_physdisk_7 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk7 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_TabPageHolder As System.Windows.Forms.Panel
    Friend WithEvents TabPageInfo As System.Windows.Forms.TabPage
    Friend WithEvents Panel_Statistics As System.Windows.Forms.Panel
    Friend WithEvents ListViewStats As System.Windows.Forms.ListView
    Friend WithEvents Metric As System.Windows.Forms.ColumnHeader
    Friend WithEvents Max As System.Windows.Forms.ColumnHeader
    Friend WithEvents Min As System.Windows.Forms.ColumnHeader
    Friend WithEvents Avg As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel_Perf_3 As System.Windows.Forms.Panel
    Friend WithEvents zgc_Perf_3 As ZedGraph.ZedGraphControl

End Class
