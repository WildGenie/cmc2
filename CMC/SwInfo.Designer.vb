<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SwInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SwInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.swOS = New System.Windows.Forms.TextBox
        Me.swHostname = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gbUninst = New System.Windows.Forms.GroupBox
        Me.btnUninstall = New System.Windows.Forms.Button
        Me.swuninst = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.swURL = New System.Windows.Forms.LinkLabel
        Me.swpath = New System.Windows.Forms.TextBox
        Me.swdate = New System.Windows.Forms.TextBox
        Me.swver = New System.Windows.Forms.TextBox
        Me.swpub = New System.Windows.Forms.TextBox
        Me.swname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.gbUninst.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.swOS)
        Me.GroupBox1.Controls.Add(Me.swHostname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 95)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Host Computer"
        '
        'swOS
        '
        Me.swOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swOS.Location = New System.Drawing.Point(122, 54)
        Me.swOS.Name = "swOS"
        Me.swOS.ReadOnly = True
        Me.swOS.Size = New System.Drawing.Size(182, 20)
        Me.swOS.TabIndex = 3
        '
        'swHostname
        '
        Me.swHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swHostname.Location = New System.Drawing.Point(122, 19)
        Me.swHostname.Name = "swHostname"
        Me.swHostname.ReadOnly = True
        Me.swHostname.Size = New System.Drawing.Size(182, 20)
        Me.swHostname.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(18, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Operating System"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(18, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Host Name"
        '
        'gbUninst
        '
        Me.gbUninst.Controls.Add(Me.btnUninstall)
        Me.gbUninst.Controls.Add(Me.swuninst)
        Me.gbUninst.Controls.Add(Me.Label14)
        Me.gbUninst.ForeColor = System.Drawing.Color.RoyalBlue
        Me.gbUninst.Location = New System.Drawing.Point(16, 360)
        Me.gbUninst.Name = "gbUninst"
        Me.gbUninst.Size = New System.Drawing.Size(322, 82)
        Me.gbUninst.TabIndex = 3
        Me.gbUninst.TabStop = False
        Me.gbUninst.Text = "Uninstall"
        '
        'btnUninstall
        '
        Me.btnUninstall.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUninstall.Location = New System.Drawing.Point(24, 39)
        Me.btnUninstall.Name = "btnUninstall"
        Me.btnUninstall.Size = New System.Drawing.Size(87, 23)
        Me.btnUninstall.TabIndex = 4
        Me.btnUninstall.Text = "Uninstall"
        Me.btnUninstall.UseVisualStyleBackColor = True
        '
        'swuninst
        '
        Me.swuninst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swuninst.Location = New System.Drawing.Point(122, 18)
        Me.swuninst.Multiline = True
        Me.swuninst.Name = "swuninst"
        Me.swuninst.ReadOnly = True
        Me.swuninst.Size = New System.Drawing.Size(182, 44)
        Me.swuninst.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(21, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Uninstall Command"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.swURL)
        Me.GroupBox2.Controls.Add(Me.swpath)
        Me.GroupBox2.Controls.Add(Me.swdate)
        Me.GroupBox2.Controls.Add(Me.swver)
        Me.GroupBox2.Controls.Add(Me.swpub)
        Me.GroupBox2.Controls.Add(Me.swname)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(16, 133)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(322, 212)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Software Properties"
        '
        'swURL
        '
        Me.swURL.AutoSize = True
        Me.swURL.Location = New System.Drawing.Point(122, 183)
        Me.swURL.Name = "swURL"
        Me.swURL.Size = New System.Drawing.Size(31, 13)
        Me.swURL.TabIndex = 11
        Me.swURL.TabStop = True
        Me.swURL.Text = "none"
        '
        'swpath
        '
        Me.swpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swpath.Location = New System.Drawing.Point(122, 153)
        Me.swpath.Name = "swpath"
        Me.swpath.ReadOnly = True
        Me.swpath.Size = New System.Drawing.Size(182, 20)
        Me.swpath.TabIndex = 10
        '
        'swdate
        '
        Me.swdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swdate.Location = New System.Drawing.Point(122, 121)
        Me.swdate.Name = "swdate"
        Me.swdate.ReadOnly = True
        Me.swdate.Size = New System.Drawing.Size(182, 20)
        Me.swdate.TabIndex = 9
        '
        'swver
        '
        Me.swver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swver.Location = New System.Drawing.Point(122, 89)
        Me.swver.Name = "swver"
        Me.swver.ReadOnly = True
        Me.swver.Size = New System.Drawing.Size(182, 20)
        Me.swver.TabIndex = 8
        '
        'swpub
        '
        Me.swpub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swpub.Location = New System.Drawing.Point(122, 57)
        Me.swpub.Name = "swpub"
        Me.swpub.ReadOnly = True
        Me.swpub.Size = New System.Drawing.Size(182, 20)
        Me.swpub.TabIndex = 7
        '
        'swname
        '
        Me.swname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.swname.Location = New System.Drawing.Point(122, 25)
        Me.swname.Name = "swname"
        Me.swname.ReadOnly = True
        Me.swname.Size = New System.Drawing.Size(182, 20)
        Me.swname.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(18, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Web Page"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(18, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Installed Location"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(18, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Software Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(18, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Date Installed"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(18, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Software Version"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(18, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Software Publisher"
        '
        'SwInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 456)
        Me.Controls.Add(Me.gbUninst)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SwInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Properties"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbUninst.ResumeLayout(False)
        Me.gbUninst.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents swHostname As System.Windows.Forms.TextBox
    Friend WithEvents gbUninst As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents swOS As System.Windows.Forms.TextBox
    Friend WithEvents swuninst As System.Windows.Forms.TextBox
    Friend WithEvents swURL As System.Windows.Forms.LinkLabel
    Friend WithEvents swpath As System.Windows.Forms.TextBox
    Friend WithEvents swdate As System.Windows.Forms.TextBox
    Friend WithEvents swver As System.Windows.Forms.TextBox
    Friend WithEvents swpub As System.Windows.Forms.TextBox
    Friend WithEvents swname As System.Windows.Forms.TextBox
    Friend WithEvents btnUninstall As System.Windows.Forms.Button
End Class
