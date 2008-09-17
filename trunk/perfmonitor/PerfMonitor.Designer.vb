<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PerfMonitor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PerfMonitor))
        Me.PerfMonTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Pic1 = New System.Windows.Forms.PictureBox
        Me.labelCPU = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.btnStop = New System.Windows.Forms.Button
        Me.computername = New System.Windows.Forms.TextBox
        Me.Pic2 = New System.Windows.Forms.PictureBox
        Me.LabelMem = New System.Windows.Forms.Label
        Me.TimeValue = New System.Windows.Forms.NumericUpDown
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnTogglePanel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AlwaysOnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.RecordingStatusLabel = New System.Windows.Forms.Label
        Me.RecordingButton = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.LabelDisk = New System.Windows.Forms.Label
        Me.Pic3 = New System.Windows.Forms.PictureBox
        Me.LabelPic3 = New System.Windows.Forms.Label
        Me.labelPic1 = New System.Windows.Forms.Label
        Me.LabelPic2 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PerfMonTimer
        '
        Me.PerfMonTimer.Interval = 1000
        '
        'Pic1
        '
        Me.Pic1.BackColor = System.Drawing.Color.LightGray
        Me.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic1.Location = New System.Drawing.Point(15, 25)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(30, 150)
        Me.Pic1.TabIndex = 1
        Me.Pic1.TabStop = False
        '
        'labelCPU
        '
        Me.labelCPU.AutoSize = True
        Me.labelCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCPU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelCPU.Location = New System.Drawing.Point(13, 9)
        Me.labelCPU.Name = "labelCPU"
        Me.labelCPU.Size = New System.Drawing.Size(0, 13)
        Me.labelCPU.TabIndex = 2
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(58, 38)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(38, 20)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(96, 38)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(38, 20)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'computername
        '
        Me.computername.Location = New System.Drawing.Point(12, 13)
        Me.computername.Name = "computername"
        Me.computername.Size = New System.Drawing.Size(122, 20)
        Me.computername.TabIndex = 5
        '
        'Pic2
        '
        Me.Pic2.BackColor = System.Drawing.Color.LightGray
        Me.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic2.Location = New System.Drawing.Point(57, 25)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(34, 150)
        Me.Pic2.TabIndex = 6
        Me.Pic2.TabStop = False
        '
        'LabelMem
        '
        Me.LabelMem.AutoSize = True
        Me.LabelMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelMem.Location = New System.Drawing.Point(55, 9)
        Me.LabelMem.Name = "LabelMem"
        Me.LabelMem.Size = New System.Drawing.Size(0, 13)
        Me.LabelMem.TabIndex = 7
        '
        'TimeValue
        '
        Me.TimeValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeValue.Location = New System.Drawing.Point(12, 38)
        Me.TimeValue.Name = "TimeValue"
        Me.TimeValue.Size = New System.Drawing.Size(33, 19)
        Me.TimeValue.TabIndex = 8
        Me.TimeValue.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnTogglePanel)
        Me.Panel1.Controls.Add(Me.computername)
        Me.Panel1.Controls.Add(Me.TimeValue)
        Me.Panel1.Controls.Add(Me.btnStart)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(156, 74)
        Me.Panel1.TabIndex = 9
        '
        'btnTogglePanel
        '
        Me.btnTogglePanel.Location = New System.Drawing.Point(1, 63)
        Me.btnTogglePanel.Name = "btnTogglePanel"
        Me.btnTogglePanel.Size = New System.Drawing.Size(12, 10)
        Me.btnTogglePanel.TabIndex = 9
        Me.btnTogglePanel.Text = "-"
        Me.btnTogglePanel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "s"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlwaysOnTopToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(148, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'AlwaysOnTopToolStripMenuItem
        '
        Me.AlwaysOnTopToolStripMenuItem.Name = "AlwaysOnTopToolStripMenuItem"
        Me.AlwaysOnTopToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.AlwaysOnTopToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.AlwaysOnTopToolStripMenuItem.Text = "always on top"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.LabelDisk)
        Me.Panel2.Controls.Add(Me.Pic3)
        Me.Panel2.Controls.Add(Me.labelCPU)
        Me.Panel2.Controls.Add(Me.Pic1)
        Me.Panel2.Controls.Add(Me.LabelMem)
        Me.Panel2.Controls.Add(Me.Pic2)
        Me.Panel2.Controls.Add(Me.LabelPic3)
        Me.Panel2.Controls.Add(Me.labelPic1)
        Me.Panel2.Controls.Add(Me.LabelPic2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 221)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RecordingStatusLabel)
        Me.Panel3.Controls.Add(Me.RecordingButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 201)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(156, 20)
        Me.Panel3.TabIndex = 15
        '
        'RecordingStatusLabel
        '
        Me.RecordingStatusLabel.AutoSize = True
        Me.RecordingStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordingStatusLabel.ForeColor = System.Drawing.Color.DodgerBlue
        Me.RecordingStatusLabel.Location = New System.Drawing.Point(25, 3)
        Me.RecordingStatusLabel.Name = "RecordingStatusLabel"
        Me.RecordingStatusLabel.Size = New System.Drawing.Size(50, 13)
        Me.RecordingStatusLabel.TabIndex = 11
        Me.RecordingStatusLabel.Text = "recording"
        Me.RecordingStatusLabel.Visible = False
        '
        'RecordingButton
        '
        Me.RecordingButton.Enabled = False
        Me.RecordingButton.ImageIndex = 4
        Me.RecordingButton.ImageList = Me.ImageList1
        Me.RecordingButton.Location = New System.Drawing.Point(1, 0)
        Me.RecordingButton.Name = "RecordingButton"
        Me.RecordingButton.Size = New System.Drawing.Size(20, 20)
        Me.RecordingButton.TabIndex = 12
        Me.RecordingButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.RecordingButton, "start recording")
        Me.RecordingButton.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "record.png")
        Me.ImageList1.Images.SetKeyName(1, "stop.png")
        Me.ImageList1.Images.SetKeyName(2, "pause.png")
        Me.ImageList1.Images.SetKeyName(3, "play.png")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "StopRed.png")
        '
        'LabelDisk
        '
        Me.LabelDisk.AutoSize = True
        Me.LabelDisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisk.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelDisk.Location = New System.Drawing.Point(99, 9)
        Me.LabelDisk.Name = "LabelDisk"
        Me.LabelDisk.Size = New System.Drawing.Size(0, 13)
        Me.LabelDisk.TabIndex = 11
        '
        'Pic3
        '
        Me.Pic3.BackColor = System.Drawing.Color.LightGray
        Me.Pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pic3.Location = New System.Drawing.Point(102, 25)
        Me.Pic3.Name = "Pic3"
        Me.Pic3.Size = New System.Drawing.Size(32, 150)
        Me.Pic3.TabIndex = 10
        Me.Pic3.TabStop = False
        '
        'LabelPic3
        '
        Me.LabelPic3.AutoSize = True
        Me.LabelPic3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPic3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelPic3.Location = New System.Drawing.Point(104, 176)
        Me.LabelPic3.Name = "LabelPic3"
        Me.LabelPic3.Size = New System.Drawing.Size(25, 13)
        Me.LabelPic3.TabIndex = 14
        Me.LabelPic3.Text = "disk"
        '
        'labelPic1
        '
        Me.labelPic1.AutoSize = True
        Me.labelPic1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelPic1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelPic1.Location = New System.Drawing.Point(18, 176)
        Me.labelPic1.Name = "labelPic1"
        Me.labelPic1.Size = New System.Drawing.Size(24, 13)
        Me.labelPic1.TabIndex = 12
        Me.labelPic1.Text = "cpu"
        '
        'LabelPic2
        '
        Me.LabelPic2.AutoSize = True
        Me.LabelPic2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPic2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelPic2.Location = New System.Drawing.Point(60, 176)
        Me.LabelPic2.Name = "LabelPic2"
        Me.LabelPic2.Size = New System.Drawing.Size(29, 13)
        Me.LabelPic2.TabIndex = 13
        Me.LabelPic2.Text = "mem"
        '
        'PerfMonitor
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnStop
        Me.ClientSize = New System.Drawing.Size(156, 295)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(164, 110)
        Me.Name = "PerfMonitor"
        Me.Text = "PerfMonitor"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Pic3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PerfMonTimer As System.Windows.Forms.Timer
    Friend WithEvents Pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents labelCPU As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents computername As System.Windows.Forms.TextBox
    Friend WithEvents Pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelMem As System.Windows.Forms.Label
    Friend WithEvents TimeValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnTogglePanel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AlwaysOnTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RecordingStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelDisk As System.Windows.Forms.Label
    Friend WithEvents LabelPic3 As System.Windows.Forms.Label
    Friend WithEvents labelPic1 As System.Windows.Forms.Label
    Friend WithEvents LabelPic2 As System.Windows.Forms.Label
    Friend WithEvents RecordingButton As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel

End Class
