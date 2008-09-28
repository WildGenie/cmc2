<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeSettings
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
        Me.comboLineThickness = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TrackBarLineTension = New System.Windows.Forms.TrackBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.comboLineStyle = New System.Windows.Forms.ComboBox
        Me.GroupBoxLine1 = New System.Windows.Forms.GroupBox
        Me.labelcolour1 = New System.Windows.Forms.Label
        Me.GroupBoxLine2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.comboLineStyle2 = New System.Windows.Forms.ComboBox
        Me.comboLineThickness2 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TrackBarLineTension2 = New System.Windows.Forms.TrackBar
        Me.Label6 = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.labelcolour2 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.TrackBarLineTension, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxLine1.SuspendLayout()
        Me.GroupBoxLine2.SuspendLayout()
        CType(Me.TrackBarLineTension2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(296, 181)
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
        'comboLineThickness
        '
        Me.comboLineThickness.FormattingEnabled = True
        Me.comboLineThickness.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.comboLineThickness.Location = New System.Drawing.Point(99, 58)
        Me.comboLineThickness.Name = "comboLineThickness"
        Me.comboLineThickness.Size = New System.Drawing.Size(78, 21)
        Me.comboLineThickness.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Line Thickness"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Line Smoothing"
        '
        'TrackBarLineTension
        '
        Me.TrackBarLineTension.LargeChange = 1
        Me.TrackBarLineTension.Location = New System.Drawing.Point(92, 87)
        Me.TrackBarLineTension.Name = "TrackBarLineTension"
        Me.TrackBarLineTension.Size = New System.Drawing.Size(94, 45)
        Me.TrackBarLineTension.TabIndex = 6
        Me.TrackBarLineTension.Value = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Line Style"
        '
        'comboLineStyle
        '
        Me.comboLineStyle.FormattingEnabled = True
        Me.comboLineStyle.Items.AddRange(New Object() {"Line", "Filled"})
        Me.comboLineStyle.Location = New System.Drawing.Point(99, 31)
        Me.comboLineStyle.Name = "comboLineStyle"
        Me.comboLineStyle.Size = New System.Drawing.Size(78, 21)
        Me.comboLineStyle.TabIndex = 8
        '
        'GroupBoxLine1
        '
        Me.GroupBoxLine1.Controls.Add(Me.labelcolour1)
        Me.GroupBoxLine1.Controls.Add(Me.Label2)
        Me.GroupBoxLine1.Controls.Add(Me.comboLineStyle)
        Me.GroupBoxLine1.Controls.Add(Me.comboLineThickness)
        Me.GroupBoxLine1.Controls.Add(Me.Label1)
        Me.GroupBoxLine1.Controls.Add(Me.TrackBarLineTension)
        Me.GroupBoxLine1.Controls.Add(Me.Label3)
        Me.GroupBoxLine1.Location = New System.Drawing.Point(12, 17)
        Me.GroupBoxLine1.Name = "GroupBoxLine1"
        Me.GroupBoxLine1.Size = New System.Drawing.Size(200, 149)
        Me.GroupBoxLine1.TabIndex = 9
        Me.GroupBoxLine1.TabStop = False
        Me.GroupBoxLine1.Text = "Line 1"
        '
        'labelcolour1
        '
        Me.labelcolour1.AutoSize = True
        Me.labelcolour1.Location = New System.Drawing.Point(57, 127)
        Me.labelcolour1.Name = "labelcolour1"
        Me.labelcolour1.Size = New System.Drawing.Size(67, 13)
        Me.labelcolour1.TabIndex = 9
        Me.labelcolour1.Text = "select colour"
        '
        'GroupBoxLine2
        '
        Me.GroupBoxLine2.Controls.Add(Me.labelcolour2)
        Me.GroupBoxLine2.Controls.Add(Me.Label4)
        Me.GroupBoxLine2.Controls.Add(Me.comboLineStyle2)
        Me.GroupBoxLine2.Controls.Add(Me.comboLineThickness2)
        Me.GroupBoxLine2.Controls.Add(Me.Label5)
        Me.GroupBoxLine2.Controls.Add(Me.TrackBarLineTension2)
        Me.GroupBoxLine2.Controls.Add(Me.Label6)
        Me.GroupBoxLine2.Location = New System.Drawing.Point(240, 17)
        Me.GroupBoxLine2.Name = "GroupBoxLine2"
        Me.GroupBoxLine2.Size = New System.Drawing.Size(200, 149)
        Me.GroupBoxLine2.TabIndex = 10
        Me.GroupBoxLine2.TabStop = False
        Me.GroupBoxLine2.Text = "Line 2"
        Me.GroupBoxLine2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Line Style"
        '
        'comboLineStyle2
        '
        Me.comboLineStyle2.FormattingEnabled = True
        Me.comboLineStyle2.Items.AddRange(New Object() {"Line", "Filled"})
        Me.comboLineStyle2.Location = New System.Drawing.Point(99, 31)
        Me.comboLineStyle2.Name = "comboLineStyle2"
        Me.comboLineStyle2.Size = New System.Drawing.Size(78, 21)
        Me.comboLineStyle2.TabIndex = 8
        '
        'comboLineThickness2
        '
        Me.comboLineThickness2.FormattingEnabled = True
        Me.comboLineThickness2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.comboLineThickness2.Location = New System.Drawing.Point(99, 58)
        Me.comboLineThickness2.Name = "comboLineThickness2"
        Me.comboLineThickness2.Size = New System.Drawing.Size(78, 21)
        Me.comboLineThickness2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Line Thickness"
        '
        'TrackBarLineTension2
        '
        Me.TrackBarLineTension2.LargeChange = 1
        Me.TrackBarLineTension2.Location = New System.Drawing.Point(92, 87)
        Me.TrackBarLineTension2.Name = "TrackBarLineTension2"
        Me.TrackBarLineTension2.Size = New System.Drawing.Size(94, 45)
        Me.TrackBarLineTension2.TabIndex = 6
        Me.TrackBarLineTension2.Value = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Line Smoothing"
        '
        'labelcolour2
        '
        Me.labelcolour2.AutoSize = True
        Me.labelcolour2.Location = New System.Drawing.Point(59, 127)
        Me.labelcolour2.Name = "labelcolour2"
        Me.labelcolour2.Size = New System.Drawing.Size(67, 13)
        Me.labelcolour2.TabIndex = 11
        Me.labelcolour2.Text = "select colour"
        '
        'ChangeSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(454, 222)
        Me.Controls.Add(Me.GroupBoxLine2)
        Me.Controls.Add(Me.GroupBoxLine1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Graph Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.TrackBarLineTension, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxLine1.ResumeLayout(False)
        Me.GroupBoxLine1.PerformLayout()
        Me.GroupBoxLine2.ResumeLayout(False)
        Me.GroupBoxLine2.PerformLayout()
        CType(Me.TrackBarLineTension2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents comboLineThickness As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBarLineTension As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboLineStyle As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxLine1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxLine2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboLineStyle2 As System.Windows.Forms.ComboBox
    Friend WithEvents comboLineThickness2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TrackBarLineTension2 As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents labelcolour1 As System.Windows.Forms.Label
    Friend WithEvents labelcolour2 As System.Windows.Forms.Label

End Class
