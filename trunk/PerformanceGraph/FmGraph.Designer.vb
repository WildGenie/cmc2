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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel_Perf_CPU = New System.Windows.Forms.Panel
        Me.zgc_cpu = New ZedGraph.ZedGraphControl
        Me.Panel_Perf_RAM = New System.Windows.Forms.Panel
        Me.zgc_ram = New ZedGraph.ZedGraphControl
        Me.Panel_Info = New System.Windows.Forms.Panel
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel_PhysDisk_2 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk2 = New ZedGraph.ZedGraphControl
        Me.Panel_PhysDisk_3 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk3 = New ZedGraph.ZedGraphControl
        Me.Panel_PhysDisk_1 = New System.Windows.Forms.Panel
        Me.zgc_phsdisk1 = New ZedGraph.ZedGraphControl
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel_Perf_CPU.SuspendLayout()
        Me.Panel_Perf_RAM.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel_PhysDisk_2.SuspendLayout()
        Me.Panel_PhysDisk_3.SuspendLayout()
        Me.Panel_PhysDisk_1.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 446)
        Me.Panel1.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(514, 446)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel_Perf_CPU)
        Me.TabPage2.Controls.Add(Me.Panel_Perf_RAM)
        Me.TabPage2.Controls.Add(Me.Panel_Info)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(506, 420)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Performance"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel_Perf_CPU
        '
        Me.Panel_Perf_CPU.Controls.Add(Me.zgc_cpu)
        Me.Panel_Perf_CPU.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Perf_CPU.Location = New System.Drawing.Point(3, 186)
        Me.Panel_Perf_CPU.Name = "Panel_Perf_CPU"
        Me.Panel_Perf_CPU.Size = New System.Drawing.Size(500, 102)
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
        Me.zgc_cpu.Size = New System.Drawing.Size(500, 102)
        Me.zgc_cpu.TabIndex = 0
        '
        'Panel_Perf_RAM
        '
        Me.Panel_Perf_RAM.Controls.Add(Me.zgc_ram)
        Me.Panel_Perf_RAM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Perf_RAM.Location = New System.Drawing.Point(3, 288)
        Me.Panel_Perf_RAM.Name = "Panel_Perf_RAM"
        Me.Panel_Perf_RAM.Size = New System.Drawing.Size(500, 129)
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
        Me.zgc_ram.Size = New System.Drawing.Size(500, 129)
        Me.zgc_ram.TabIndex = 0
        '
        'Panel_Info
        '
        Me.Panel_Info.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Info.Location = New System.Drawing.Point(3, 3)
        Me.Panel_Info.Name = "Panel_Info"
        Me.Panel_Info.Size = New System.Drawing.Size(500, 137)
        Me.Panel_Info.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel_PhysDisk_2)
        Me.TabPage3.Controls.Add(Me.Panel_PhysDisk_3)
        Me.TabPage3.Controls.Add(Me.Panel_PhysDisk_1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(506, 420)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PhysicalDisk"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel_PhysDisk_2
        '
        Me.Panel_PhysDisk_2.Controls.Add(Me.zgc_phsdisk2)
        Me.Panel_PhysDisk_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_PhysDisk_2.Location = New System.Drawing.Point(0, 131)
        Me.Panel_PhysDisk_2.Name = "Panel_PhysDisk_2"
        Me.Panel_PhysDisk_2.Size = New System.Drawing.Size(506, 143)
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
        Me.zgc_phsdisk2.Size = New System.Drawing.Size(506, 143)
        Me.zgc_phsdisk2.TabIndex = 0
        '
        'Panel_PhysDisk_3
        '
        Me.Panel_PhysDisk_3.Controls.Add(Me.zgc_phsdisk3)
        Me.Panel_PhysDisk_3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_PhysDisk_3.Location = New System.Drawing.Point(0, 274)
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
        'FmGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 470)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FmGraph"
        Me.Text = "Performance Graph"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.Panel_Perf_CPU.ResumeLayout(False)
        Me.Panel_Perf_RAM.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel_PhysDisk_2.ResumeLayout(False)
        Me.Panel_PhysDisk_3.ResumeLayout(False)
        Me.Panel_PhysDisk_1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents zgc_cpu As ZedGraph.ZedGraphControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel_Perf_RAM As System.Windows.Forms.Panel
    Friend WithEvents Panel_Perf_CPU As System.Windows.Forms.Panel
    Friend WithEvents zgc_ram As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_PhysDisk_2 As System.Windows.Forms.Panel
    Friend WithEvents Panel_PhysDisk_3 As System.Windows.Forms.Panel
    Friend WithEvents Panel_PhysDisk_1 As System.Windows.Forms.Panel
    Friend WithEvents zgc_phsdisk1 As ZedGraph.ZedGraphControl
    Friend WithEvents zgc_phsdisk2 As ZedGraph.ZedGraphControl
    Friend WithEvents zgc_phsdisk3 As ZedGraph.ZedGraphControl
    Friend WithEvents Panel_Info As System.Windows.Forms.Panel

End Class
