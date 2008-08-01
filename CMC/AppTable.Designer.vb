<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppTable
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.AppGrid = New System.Windows.Forms.DataGridView
        Me.App_Name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Source_Type = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Source = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Destination = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Command = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.table_save_button = New System.Windows.Forms.Button
        CType(Me.AppGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppGrid
        '
        Me.AppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.App_Name, Me.Source_Type, Me.Source, Me.Destination, Me.Command})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AppGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.AppGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppGrid.Location = New System.Drawing.Point(0, 0)
        Me.AppGrid.Name = "AppGrid"
        Me.AppGrid.Size = New System.Drawing.Size(707, 469)
        Me.AppGrid.TabIndex = 0
        '
        'App_Name
        '
        'Me.App_Name.HeaderText = "Name1"
        Me.App_Name.Name = "App_Name"
        Me.App_Name.Width = 160
        '
        'Source_Type
        '
        Me.App_Name.HeaderText = "Name"
        Me.App_Name.Name = "Source_Type"
        Me.App_Name.Width = 80
        '
        'Source
        '
        Me.Source.HeaderText = "Destination"
        Me.Source.Name = "Source"
        Me.Source.Width = 200
        '
        'Destination
        '
        Me.Destination.HeaderText = "Command"
        Me.Destination.Name = "Destination"
        Me.Destination.Width = 200
        '
        'Command
        '
        'Me.Command.HeaderText = "2Command"
        Me.Command.Name = "Command"
        Me.Command.Width = 200
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.table_save_button)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 36)
        Me.Panel1.TabIndex = 1
        '
        'table_save_button
        '
        Me.table_save_button.Location = New System.Drawing.Point(3, 3)
        Me.table_save_button.Name = "table_save_button"
        Me.table_save_button.Size = New System.Drawing.Size(75, 32)
        Me.table_save_button.TabIndex = 0
        Me.table_save_button.Text = "save"
        Me.table_save_button.UseVisualStyleBackColor = True
        '
        'AppTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 469)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AppGrid)
        Me.Name = "AppTable"
        Me.Text = "AppTable"
        CType(Me.AppGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AppGrid As System.Windows.Forms.DataGridView
    Friend WithEvents App_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Source_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Source As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Destination As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Command As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents table_save_button As System.Windows.Forms.Button

    Private Sub table_save_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles table_save_button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub
End Class
