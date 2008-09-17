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
        Me.Label2 = New System.Windows.Forms.Label
        Me.cCPU = New System.Windows.Forms.CheckBox
        Me.cMem = New System.Windows.Forms.CheckBox
        Me.cDsk1 = New System.Windows.Forms.CheckBox
        Me.cDsk2 = New System.Windows.Forms.CheckBox
        Me.cDsk3 = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(65, 170)
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
        Me.NumericUpDown1.Value = New Decimal(New Integer() {5, 0, 0, 0})
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(23, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "select data to record"
        '
        'cCPU
        '
        Me.cCPU.AutoSize = True
        Me.cCPU.Checked = True
        Me.cCPU.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cCPU.Enabled = False
        Me.cCPU.Location = New System.Drawing.Point(26, 69)
        Me.cCPU.Name = "cCPU"
        Me.cCPU.Size = New System.Drawing.Size(141, 17)
        Me.cCPU.TabIndex = 5
        Me.cCPU.Text = "CPU - % Processor Time"
        Me.cCPU.UseVisualStyleBackColor = True
        '
        'cMem
        '
        Me.cMem.AutoSize = True
        Me.cMem.Checked = True
        Me.cMem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cMem.Enabled = False
        Me.cMem.Location = New System.Drawing.Point(26, 83)
        Me.cMem.Name = "cMem"
        Me.cMem.Size = New System.Drawing.Size(154, 17)
        Me.cMem.TabIndex = 6
        Me.cMem.Text = "Mem - % Memory Utilisation"
        Me.cMem.UseVisualStyleBackColor = True
        '
        'cDsk1
        '
        Me.cDsk1.AutoSize = True
        Me.cDsk1.Checked = True
        Me.cDsk1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDsk1.Enabled = False
        Me.cDsk1.Location = New System.Drawing.Point(26, 97)
        Me.cDsk1.Name = "cDsk1"
        Me.cDsk1.Size = New System.Drawing.Size(114, 17)
        Me.cDsk1.TabIndex = 7
        Me.cDsk1.Text = "Disk - % Disk Time"
        Me.cDsk1.UseVisualStyleBackColor = True
        '
        'cDsk2
        '
        Me.cDsk2.AutoSize = True
        Me.cDsk2.Checked = True
        Me.cDsk2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDsk2.Enabled = False
        Me.cDsk2.Location = New System.Drawing.Point(26, 111)
        Me.cDsk2.Name = "cDsk2"
        Me.cDsk2.Size = New System.Drawing.Size(175, 17)
        Me.cDsk2.TabIndex = 8
        Me.cDsk2.Text = "Disk - Avg Read Queue Length"
        Me.cDsk2.UseVisualStyleBackColor = True
        '
        'cDsk3
        '
        Me.cDsk3.AutoSize = True
        Me.cDsk3.Checked = True
        Me.cDsk3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cDsk3.Enabled = False
        Me.cDsk3.Location = New System.Drawing.Point(26, 125)
        Me.cDsk3.Name = "cDsk3"
        Me.cDsk3.Size = New System.Drawing.Size(174, 17)
        Me.cDsk3.TabIndex = 9
        Me.cDsk3.Text = "Disk - Avg Write Queue Length"
        Me.cDsk3.UseVisualStyleBackColor = True
        '
        'RecordingDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(223, 211)
        Me.Controls.Add(Me.cDsk3)
        Me.Controls.Add(Me.cDsk2)
        Me.Controls.Add(Me.cDsk1)
        Me.Controls.Add(Me.cMem)
        Me.Controls.Add(Me.cCPU)
        Me.Controls.Add(Me.Label2)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cCPU As System.Windows.Forms.CheckBox
    Friend WithEvents cMem As System.Windows.Forms.CheckBox
    Friend WithEvents cDsk1 As System.Windows.Forms.CheckBox
    Friend WithEvents cDsk2 As System.Windows.Forms.CheckBox
    Friend WithEvents cDsk3 As System.Windows.Forms.CheckBox

End Class
