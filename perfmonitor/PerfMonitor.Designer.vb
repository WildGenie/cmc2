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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.Pic1.Size = New System.Drawing.Size(49, 150)
        Me.Pic1.TabIndex = 1
        Me.Pic1.TabStop = False
        '
        'labelCPU
        '
        Me.labelCPU.AutoSize = True
        Me.labelCPU.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCPU.ForeColor = System.Drawing.Color.RoyalBlue
        Me.labelCPU.Location = New System.Drawing.Point(13, 9)
        Me.labelCPU.Name = "labelCPU"
        Me.labelCPU.Size = New System.Drawing.Size(28, 13)
        Me.labelCPU.TabIndex = 2
        Me.labelCPU.Text = "CPU"
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
        Me.Pic2.Location = New System.Drawing.Point(88, 25)
        Me.Pic2.Name = "Pic2"
        Me.Pic2.Size = New System.Drawing.Size(45, 150)
        Me.Pic2.TabIndex = 6
        Me.Pic2.TabStop = False
        '
        'LabelMem
        '
        Me.LabelMem.AutoSize = True
        Me.LabelMem.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelMem.Location = New System.Drawing.Point(86, 9)
        Me.LabelMem.Name = "LabelMem"
        Me.LabelMem.Size = New System.Drawing.Size(30, 13)
        Me.LabelMem.TabIndex = 7
        Me.LabelMem.Text = "RAM"
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
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 74)
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.labelCPU)
        Me.Panel2.Controls.Add(Me.Pic1)
        Me.Panel2.Controls.Add(Me.LabelMem)
        Me.Panel2.Controls.Add(Me.Pic2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(148, 190)
        Me.Panel2.TabIndex = 10
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
        'PerfMonitor
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnStop
        Me.ClientSize = New System.Drawing.Size(148, 264)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(164, 110)
        Me.Name = "PerfMonitor"
        Me.Text = "PerfMonitor"
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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

End Class
