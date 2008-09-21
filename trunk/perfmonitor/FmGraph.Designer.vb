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
        Me.zg1 = New ZedGraph.ZedGraphControl
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.zg2 = New ZedGraph.ZedGraphControl
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.zg1.Size = New System.Drawing.Size(615, 266)
        Me.zg1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "PerfMonitor Files|*.csv|All Files|*.*"
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
        Me.zg2.Size = New System.Drawing.Size(615, 206)
        Me.zg2.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(282, 132)
        Me.SplitContainer1.SplitterDistance = 66
        Me.SplitContainer1.TabIndex = 3
        Me.SplitContainer1.Visible = False
        '
        'FmGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 132)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "FmGraph"
        Me.Text = "Performance Graph"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents zg1 As ZedGraph.ZedGraphControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents zg2 As ZedGraph.ZedGraphControl
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
