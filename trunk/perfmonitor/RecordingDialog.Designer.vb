<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordingDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.cCPU = New System.Windows.Forms.CheckBox
        Me.cMem = New System.Windows.Forms.CheckBox
        Me.cDsk1 = New System.Windows.Forms.CheckBox
        Me.cDsk2 = New System.Windows.Forms.CheckBox
        Me.cMemPages = New System.Windows.Forms.CheckBox
        Me.cNic = New System.Windows.Forms.CheckBox
        Me.ListBoxDiskInstance = New System.Windows.Forms.ListBox
        Me.cDsk3 = New System.Windows.Forms.CheckBox
        Me.comboNICInstance = New System.Windows.Forms.ComboBox
        Me.gbNet = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gbProcessor = New System.Windows.Forms.GroupBox
        Me.gbMem = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbNet.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbProcessor.SuspendLayout()
        Me.gbMem.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(236, 298)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(164, 14)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 20)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Recording Interval (seconds)"
        '
        'cCPU
        '
        Me.cCPU.AutoSize = True
        Me.cCPU.Checked = True
        Me.cCPU.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cCPU.Location = New System.Drawing.Point(11, 25)
        Me.cCPU.Name = "cCPU"
        Me.cCPU.Size = New System.Drawing.Size(110, 17)
        Me.cCPU.TabIndex = 5
        Me.cCPU.Text = "% Processor Time"
        Me.cCPU.UseVisualStyleBackColor = True
        '
        'cMem
        '
        Me.cMem.AutoSize = True
        Me.cMem.Checked = True
        Me.cMem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cMem.Location = New System.Drawing.Point(11, 19)
        Me.cMem.Name = "cMem"
        Me.cMem.Size = New System.Drawing.Size(122, 17)
        Me.cMem.TabIndex = 6
        Me.cMem.Text = "% Memory Utilisation"
        Me.cMem.UseVisualStyleBackColor = True
        '
        'cDsk1
        '
        Me.cDsk1.AutoSize = True
        Me.cDsk1.Checked = True
        Me.cDsk1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDsk1.Enabled = False
        Me.cDsk1.Location = New System.Drawing.Point(10, 93)
        Me.cDsk1.Name = "cDsk1"
        Me.cDsk1.Size = New System.Drawing.Size(84, 17)
        Me.cDsk1.TabIndex = 7
        Me.cDsk1.Text = "% Disk Time"
        Me.cDsk1.UseVisualStyleBackColor = True
        '
        'cDsk2
        '
        Me.cDsk2.AutoSize = True
        Me.cDsk2.Checked = True
        Me.cDsk2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDsk2.Enabled = False
        Me.cDsk2.Location = New System.Drawing.Point(10, 109)
        Me.cDsk2.Name = "cDsk2"
        Me.cDsk2.Size = New System.Drawing.Size(116, 17)
        Me.cDsk2.TabIndex = 8
        Me.cDsk2.Text = "Avg Queue Length"
        Me.cDsk2.UseVisualStyleBackColor = True
        '
        'cMemPages
        '
        Me.cMemPages.AutoSize = True
        Me.cMemPages.Location = New System.Drawing.Point(11, 37)
        Me.cMemPages.Name = "cMemPages"
        Me.cMemPages.Size = New System.Drawing.Size(107, 17)
        Me.cMemPages.TabIndex = 10
        Me.cMemPages.Text = "Pages Input/Sec"
        Me.cMemPages.UseVisualStyleBackColor = True
        '
        'cNic
        '
        Me.cNic.AutoSize = True
        Me.cNic.Enabled = False
        Me.cNic.Location = New System.Drawing.Point(14, 60)
        Me.cNic.Name = "cNic"
        Me.cNic.Size = New System.Drawing.Size(101, 17)
        Me.cNic.TabIndex = 11
        Me.cNic.Text = "Bytes Total/sec"
        Me.cNic.UseVisualStyleBackColor = True
        '
        'ListBoxDiskInstance
        '
        Me.ListBoxDiskInstance.FormattingEnabled = True
        Me.ListBoxDiskInstance.Location = New System.Drawing.Point(10, 19)
        Me.ListBoxDiskInstance.Name = "ListBoxDiskInstance"
        Me.ListBoxDiskInstance.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxDiskInstance.Size = New System.Drawing.Size(146, 56)
        Me.ListBoxDiskInstance.TabIndex = 12
        '
        'cDsk3
        '
        Me.cDsk3.AutoSize = True
        Me.cDsk3.Checked = True
        Me.cDsk3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDsk3.Enabled = False
        Me.cDsk3.Location = New System.Drawing.Point(10, 125)
        Me.cDsk3.Name = "cDsk3"
        Me.cDsk3.Size = New System.Drawing.Size(74, 17)
        Me.cDsk3.TabIndex = 9
        Me.cDsk3.Text = "IO kb/sec"
        Me.cDsk3.UseVisualStyleBackColor = True
        '
        'comboNICInstance
        '
        Me.comboNICInstance.DropDownWidth = 200
        Me.comboNICInstance.FormattingEnabled = True
        Me.comboNICInstance.Location = New System.Drawing.Point(13, 29)
        Me.comboNICInstance.Name = "comboNICInstance"
        Me.comboNICInstance.Size = New System.Drawing.Size(141, 21)
        Me.comboNICInstance.TabIndex = 13
        '
        'gbNet
        '
        Me.gbNet.Controls.Add(Me.comboNICInstance)
        Me.gbNet.Controls.Add(Me.Label2)
        Me.gbNet.Controls.Add(Me.cNic)
        Me.gbNet.Location = New System.Drawing.Point(16, 242)
        Me.gbNet.Name = "gbNet"
        Me.gbNet.Size = New System.Drawing.Size(167, 85)
        Me.gbNet.TabIndex = 14
        Me.gbNet.TabStop = False
        Me.gbNet.Text = "Network Interface"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "select instance"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListBoxDiskInstance)
        Me.GroupBox1.Controls.Add(Me.cDsk1)
        Me.GroupBox1.Controls.Add(Me.cDsk2)
        Me.GroupBox1.Controls.Add(Me.cDsk3)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 159)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PhysicalDisk"
        '
        'gbProcessor
        '
        Me.gbProcessor.Controls.Add(Me.cCPU)
        Me.gbProcessor.Location = New System.Drawing.Point(16, 66)
        Me.gbProcessor.Name = "gbProcessor"
        Me.gbProcessor.Size = New System.Drawing.Size(167, 60)
        Me.gbProcessor.TabIndex = 16
        Me.gbProcessor.TabStop = False
        Me.gbProcessor.Text = "Processor"
        '
        'gbMem
        '
        Me.gbMem.Controls.Add(Me.cMem)
        Me.gbMem.Controls.Add(Me.cMemPages)
        Me.gbMem.Location = New System.Drawing.Point(16, 145)
        Me.gbMem.Name = "gbMem"
        Me.gbMem.Size = New System.Drawing.Size(167, 80)
        Me.gbMem.TabIndex = 17
        Me.gbMem.TabStop = False
        Me.gbMem.Text = "Memory"
        '
        'RecordingDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(394, 339)
        Me.Controls.Add(Me.gbMem)
        Me.Controls.Add(Me.gbProcessor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbNet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecordingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Performance Data Recording"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbNet.ResumeLayout(False)
        Me.gbNet.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbProcessor.ResumeLayout(False)
        Me.gbProcessor.PerformLayout()
        Me.gbMem.ResumeLayout(False)
        Me.gbMem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cCPU As System.Windows.Forms.CheckBox
    Friend WithEvents cMem As System.Windows.Forms.CheckBox
    Friend WithEvents cDsk1 As System.Windows.Forms.CheckBox
    Friend WithEvents cDsk2 As System.Windows.Forms.CheckBox
    Friend WithEvents cMemPages As System.Windows.Forms.CheckBox
    Friend WithEvents cNic As System.Windows.Forms.CheckBox
    Friend WithEvents ListBoxDiskInstance As System.Windows.Forms.ListBox
    Friend WithEvents cDsk3 As System.Windows.Forms.CheckBox
    Friend WithEvents comboNICInstance As System.Windows.Forms.ComboBox
    Friend WithEvents gbNet As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbProcessor As System.Windows.Forms.GroupBox
    Friend WithEvents gbMem As System.Windows.Forms.GroupBox

End Class
