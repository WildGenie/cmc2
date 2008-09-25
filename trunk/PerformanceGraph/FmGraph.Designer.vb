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
        Me.zg1 = New ZedGraph.ZedGraphControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.zg2 = New ZedGraph.ZedGraphControl
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuGraph1 = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_cpu = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_ram = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_disktime = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_diskReadQueue = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_diskWriteQueue = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_diskreadMBs = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph1_diskwriteMBs = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.menu_graph1_smoothCurvesMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuGraph2 = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_cpu = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_ram = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_disktime = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_diskReadQueue = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_diskWriteQueue = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_diskreadMBs = New System.Windows.Forms.ToolStripMenuItem
        Me.menu_graph2_diskwriteMBs = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.menu_graph2_smoothCurvesMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.LineThicknessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'zg1
        '
        Me.zg1.Location = New System.Drawing.Point(0, 0)
        Me.zg1.Name = "zg1"
        Me.zg1.ScrollGrace = 0
        Me.zg1.ScrollMaxX = 0
        Me.zg1.ScrollMaxY = 0
        Me.zg1.ScrollMaxY2 = 0
        Me.zg1.ScrollMinX = 0
        Me.zg1.ScrollMinY = 0
        Me.zg1.ScrollMinY2 = 0
        Me.zg1.Size = New System.Drawing.Size(260, 53)
        Me.zg1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "PerfMonitor Files|*.pff|All Files|*.*"
        Me.OpenFileDialog1.Title = "Select file to open"
        '
        'zg2
        '
        Me.zg2.Location = New System.Drawing.Point(0, 0)
        Me.zg2.Name = "zg2"
        Me.zg2.ScrollGrace = 0
        Me.zg2.ScrollMaxX = 0
        Me.zg2.ScrollMaxY = 0
        Me.zg2.ScrollMaxY2 = 0
        Me.zg2.ScrollMinX = 0
        Me.zg2.ScrollMinY = 0
        Me.zg2.ScrollMinY2 = 0
        Me.zg2.Size = New System.Drawing.Size(260, 52)
        Me.zg2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.zg1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.zg2)
        Me.SplitContainer1.Size = New System.Drawing.Size(269, 123)
        Me.SplitContainer1.SplitterDistance = 58
        Me.SplitContainer1.TabIndex = 3
        Me.SplitContainer1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(269, 24)
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
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuGraph1, Me.MenuGraph2, Me.ToolStripSeparator3, Me.LineThicknessToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'MenuGraph1
        '
        Me.MenuGraph1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_graph1_cpu, Me.menu_graph1_ram, Me.menu_graph1_disktime, Me.menu_graph1_diskReadQueue, Me.menu_graph1_diskWriteQueue, Me.menu_graph1_diskreadMBs, Me.menu_graph1_diskwriteMBs, Me.ToolStripSeparator1, Me.menu_graph1_smoothCurvesMenu})
        Me.MenuGraph1.Name = "MenuGraph1"
        Me.MenuGraph1.Size = New System.Drawing.Size(152, 22)
        Me.MenuGraph1.Text = "graph1"
        '
        'menu_graph1_cpu
        '
        Me.menu_graph1_cpu.Checked = True
        Me.menu_graph1_cpu.CheckOnClick = True
        Me.menu_graph1_cpu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_graph1_cpu.Name = "menu_graph1_cpu"
        Me.menu_graph1_cpu.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_cpu.Text = "% cpu utilisation"
        '
        'menu_graph1_ram
        '
        Me.menu_graph1_ram.Checked = True
        Me.menu_graph1_ram.CheckOnClick = True
        Me.menu_graph1_ram.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_graph1_ram.Name = "menu_graph1_ram"
        Me.menu_graph1_ram.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_ram.Text = "% mem uilisation"
        '
        'menu_graph1_disktime
        '
        Me.menu_graph1_disktime.CheckOnClick = True
        Me.menu_graph1_disktime.Name = "menu_graph1_disktime"
        Me.menu_graph1_disktime.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_disktime.Text = "% disk time"
        '
        'menu_graph1_diskReadQueue
        '
        Me.menu_graph1_diskReadQueue.CheckOnClick = True
        Me.menu_graph1_diskReadQueue.Name = "menu_graph1_diskReadQueue"
        Me.menu_graph1_diskReadQueue.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_diskReadQueue.Text = "disk read queue"
        '
        'menu_graph1_diskWriteQueue
        '
        Me.menu_graph1_diskWriteQueue.CheckOnClick = True
        Me.menu_graph1_diskWriteQueue.Name = "menu_graph1_diskWriteQueue"
        Me.menu_graph1_diskWriteQueue.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_diskWriteQueue.Text = "disk write queue"
        '
        'menu_graph1_diskreadMBs
        '
        Me.menu_graph1_diskreadMBs.CheckOnClick = True
        Me.menu_graph1_diskreadMBs.Name = "menu_graph1_diskreadMBs"
        Me.menu_graph1_diskreadMBs.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_diskreadMBs.Text = "disk read MB/s"
        '
        'menu_graph1_diskwriteMBs
        '
        Me.menu_graph1_diskwriteMBs.CheckOnClick = True
        Me.menu_graph1_diskwriteMBs.Name = "menu_graph1_diskwriteMBs"
        Me.menu_graph1_diskwriteMBs.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_diskwriteMBs.Text = "disk write MB/s"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(162, 6)
        '
        'menu_graph1_smoothCurvesMenu
        '
        Me.menu_graph1_smoothCurvesMenu.CheckOnClick = True
        Me.menu_graph1_smoothCurvesMenu.Name = "menu_graph1_smoothCurvesMenu"
        Me.menu_graph1_smoothCurvesMenu.Size = New System.Drawing.Size(165, 22)
        Me.menu_graph1_smoothCurvesMenu.Text = "smooth curves"
        '
        'MenuGraph2
        '
        Me.MenuGraph2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_graph2_cpu, Me.menu_graph2_ram, Me.menu_graph2_disktime, Me.menu_graph2_diskReadQueue, Me.menu_graph2_diskWriteQueue, Me.menu_graph2_diskreadMBs, Me.menu_graph2_diskwriteMBs, Me.ToolStripSeparator2, Me.menu_graph2_smoothCurvesMenu})
        Me.MenuGraph2.Name = "MenuGraph2"
        Me.MenuGraph2.Size = New System.Drawing.Size(152, 22)
        Me.MenuGraph2.Text = "graph2"
        '
        'menu_graph2_cpu
        '
        Me.menu_graph2_cpu.CheckOnClick = True
        Me.menu_graph2_cpu.Name = "menu_graph2_cpu"
        Me.menu_graph2_cpu.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_cpu.Text = "% cpu"
        '
        'menu_graph2_ram
        '
        Me.menu_graph2_ram.CheckOnClick = True
        Me.menu_graph2_ram.Name = "menu_graph2_ram"
        Me.menu_graph2_ram.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_ram.Text = "% ram"
        '
        'menu_graph2_disktime
        '
        Me.menu_graph2_disktime.Checked = True
        Me.menu_graph2_disktime.CheckOnClick = True
        Me.menu_graph2_disktime.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_graph2_disktime.Name = "menu_graph2_disktime"
        Me.menu_graph2_disktime.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_disktime.Text = "% disk time"
        '
        'menu_graph2_diskReadQueue
        '
        Me.menu_graph2_diskReadQueue.Checked = True
        Me.menu_graph2_diskReadQueue.CheckOnClick = True
        Me.menu_graph2_diskReadQueue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_graph2_diskReadQueue.Name = "menu_graph2_diskReadQueue"
        Me.menu_graph2_diskReadQueue.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_diskReadQueue.Text = "disk read queue"
        '
        'menu_graph2_diskWriteQueue
        '
        Me.menu_graph2_diskWriteQueue.Checked = True
        Me.menu_graph2_diskWriteQueue.CheckOnClick = True
        Me.menu_graph2_diskWriteQueue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menu_graph2_diskWriteQueue.Name = "menu_graph2_diskWriteQueue"
        Me.menu_graph2_diskWriteQueue.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_diskWriteQueue.Text = "disk write queue"
        '
        'menu_graph2_diskreadMBs
        '
        Me.menu_graph2_diskreadMBs.CheckOnClick = True
        Me.menu_graph2_diskreadMBs.Name = "menu_graph2_diskreadMBs"
        Me.menu_graph2_diskreadMBs.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_diskreadMBs.Text = "disk reads MB/s"
        '
        'menu_graph2_diskwriteMBs
        '
        Me.menu_graph2_diskwriteMBs.CheckOnClick = True
        Me.menu_graph2_diskwriteMBs.Name = "menu_graph2_diskwriteMBs"
        Me.menu_graph2_diskwriteMBs.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_diskwriteMBs.Text = "disk writes MB/s"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'menu_graph2_smoothCurvesMenu
        '
        Me.menu_graph2_smoothCurvesMenu.CheckOnClick = True
        Me.menu_graph2_smoothCurvesMenu.Name = "menu_graph2_smoothCurvesMenu"
        Me.menu_graph2_smoothCurvesMenu.Size = New System.Drawing.Size(163, 22)
        Me.menu_graph2_smoothCurvesMenu.Text = "smooth curves"
        '
        'LineThicknessToolStripMenuItem
        '
        Me.LineThicknessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox2})
        Me.LineThicknessToolStripMenuItem.Name = "LineThicknessToolStripMenuItem"
        Me.LineThicknessToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LineThicknessToolStripMenuItem.Text = "line thickness"
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4"})
        Me.ToolStripComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(75, 21)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(149, 6)
        '
        'FmGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 147)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FmGraph"
        Me.Text = "Performance Graph"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents zg1 As ZedGraph.ZedGraphControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents zg2 As ZedGraph.ZedGraphControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGraph1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph1_cpu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph1_ram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph1_disktime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuGraph2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_cpu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_ram As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_disktime As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_diskReadQueue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_diskWriteQueue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph1_diskReadQueue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph1_diskWriteQueue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menu_graph1_smoothCurvesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menu_graph2_smoothCurvesMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineThicknessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents menu_graph1_diskreadMBs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph1_diskwriteMBs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_diskreadMBs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menu_graph2_diskwriteMBs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
