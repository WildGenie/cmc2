<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmDomains
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DomainDatagrid = New System.Windows.Forms.DataGridView
        Me.domNTName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.domDNSName = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.domDC = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.domUsername = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.domPassword = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnDomCancel = New System.Windows.Forms.Button
        Me.dtnDomSave = New System.Windows.Forms.Button
        CType(Me.DomainDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DomainDatagrid
        '
        Me.DomainDatagrid.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DomainDatagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DomainDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DomainDatagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.domNTName, Me.domDNSName, Me.domDC, Me.domUsername, Me.domPassword})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DomainDatagrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.DomainDatagrid.Location = New System.Drawing.Point(27, 50)
        Me.DomainDatagrid.Name = "DomainDatagrid"
        Me.DomainDatagrid.RowHeadersVisible = False
        Me.DomainDatagrid.RowHeadersWidth = 26
        Me.DomainDatagrid.Size = New System.Drawing.Size(671, 150)
        Me.DomainDatagrid.TabIndex = 0
        '
        'domNTName
        '
        Me.domNTName.HeaderText = "NT Domain"
        Me.domNTName.Name = "domNTName"
        '
        'domDNSName
        '
        Me.domDNSName.HeaderText = "DNS Domain"
        Me.domDNSName.Name = "domDNSName"
        Me.domDNSName.Width = 200
        '
        'domDC
        '
        Me.domDC.HeaderText = "Domain Controller"
        Me.domDC.Name = "domDC"
        '
        'domUsername
        '
        Me.domUsername.HeaderText = "Username"
        Me.domUsername.Name = "domUsername"
        '
        'domPassword
        '
        Me.domPassword.HeaderText = "Password"
        Me.domPassword.Name = "domPassword"
        '
        'btnDomCancel
        '
        Me.btnDomCancel.Location = New System.Drawing.Point(542, 209)
        Me.btnDomCancel.Name = "btnDomCancel"
        Me.btnDomCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnDomCancel.TabIndex = 1
        Me.btnDomCancel.Text = "Cancel"
        Me.btnDomCancel.UseVisualStyleBackColor = True
        '
        'dtnDomSave
        '
        Me.dtnDomSave.Location = New System.Drawing.Point(623, 209)
        Me.dtnDomSave.Name = "dtnDomSave"
        Me.dtnDomSave.Size = New System.Drawing.Size(75, 30)
        Me.dtnDomSave.TabIndex = 2
        Me.dtnDomSave.Text = "Save"
        Me.dtnDomSave.UseVisualStyleBackColor = True
        '
        'FmDomains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 245)
        Me.Controls.Add(Me.dtnDomSave)
        Me.Controls.Add(Me.btnDomCancel)
        Me.Controls.Add(Me.DomainDatagrid)
        Me.Name = "FmDomains"
        Me.Text = "Domains"
        CType(Me.DomainDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DomainDatagrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnDomCancel As System.Windows.Forms.Button
    Friend WithEvents dtnDomSave As System.Windows.Forms.Button
    Friend WithEvents domNTName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domDNSName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domDC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domUsername As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents domPassword As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
