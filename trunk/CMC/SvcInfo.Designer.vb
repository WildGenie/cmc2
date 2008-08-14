<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SvcInfo
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
        Me.gbGeneral = New System.Windows.Forms.GroupBox
        Me.txtSvcPath = New System.Windows.Forms.TextBox
        Me.txtSvcCaption = New System.Windows.Forms.TextBox
        Me.txtSvcName = New System.Windows.Forms.TextBox
        Me.lblSvcAccount = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.svcStartupCombo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.gbSvcStatus = New System.Windows.Forms.GroupBox
        Me.btnSvcResume = New System.Windows.Forms.Button
        Me.btnSvcPause = New System.Windows.Forms.Button
        Me.btnSvcStop = New System.Windows.Forms.Button
        Me.btnSvcStart = New System.Windows.Forms.Button
        Me.lblSvcStatus = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.picSvcStatus = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.gbGeneral.SuspendLayout()
        Me.gbSvcStatus.SuspendLayout()
        CType(Me.picSvcStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(234, 433)
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
        'gbGeneral
        '
        Me.gbGeneral.Controls.Add(Me.txtSvcPath)
        Me.gbGeneral.Controls.Add(Me.txtSvcCaption)
        Me.gbGeneral.Controls.Add(Me.txtSvcName)
        Me.gbGeneral.Controls.Add(Me.lblSvcAccount)
        Me.gbGeneral.Controls.Add(Me.Label7)
        Me.gbGeneral.Controls.Add(Me.PictureBox1)
        Me.gbGeneral.Controls.Add(Me.txtDescription)
        Me.gbGeneral.Controls.Add(Me.svcStartupCombo)
        Me.gbGeneral.Controls.Add(Me.Label5)
        Me.gbGeneral.Controls.Add(Me.Label4)
        Me.gbGeneral.Controls.Add(Me.Label3)
        Me.gbGeneral.Controls.Add(Me.Label2)
        Me.gbGeneral.Controls.Add(Me.Label1)
        Me.gbGeneral.Location = New System.Drawing.Point(12, 12)
        Me.gbGeneral.Name = "gbGeneral"
        Me.gbGeneral.Size = New System.Drawing.Size(368, 279)
        Me.gbGeneral.TabIndex = 1
        Me.gbGeneral.TabStop = False
        Me.gbGeneral.Text = "General"
        '
        'txtSvcPath
        '
        Me.txtSvcPath.Location = New System.Drawing.Point(16, 185)
        Me.txtSvcPath.Name = "txtSvcPath"
        Me.txtSvcPath.ReadOnly = True
        Me.txtSvcPath.Size = New System.Drawing.Size(342, 20)
        Me.txtSvcPath.TabIndex = 14
        '
        'txtSvcCaption
        '
        Me.txtSvcCaption.Location = New System.Drawing.Point(98, 59)
        Me.txtSvcCaption.Name = "txtSvcCaption"
        Me.txtSvcCaption.ReadOnly = True
        Me.txtSvcCaption.Size = New System.Drawing.Size(260, 20)
        Me.txtSvcCaption.TabIndex = 13
        '
        'txtSvcName
        '
        Me.txtSvcName.Location = New System.Drawing.Point(98, 28)
        Me.txtSvcName.Name = "txtSvcName"
        Me.txtSvcName.ReadOnly = True
        Me.txtSvcName.Size = New System.Drawing.Size(225, 20)
        Me.txtSvcName.TabIndex = 12
        '
        'lblSvcAccount
        '
        Me.lblSvcAccount.AutoSize = True
        Me.lblSvcAccount.Location = New System.Drawing.Point(95, 218)
        Me.lblSvcAccount.Name = "lblSvcAccount"
        Me.lblSvcAccount.Size = New System.Drawing.Size(10, 13)
        Me.lblSvcAccount.TabIndex = 11
        Me.lblSvcAccount.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(13, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Account"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(98, 91)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(260, 72)
        Me.txtDescription.TabIndex = 9
        '
        'svcStartupCombo
        '
        Me.svcStartupCombo.FormattingEnabled = True
        Me.svcStartupCombo.Items.AddRange(New Object() {"Automatic", "Manual", "Disabled"})
        Me.svcStartupCombo.Location = New System.Drawing.Point(98, 247)
        Me.svcStartupCombo.Name = "svcStartupCombo"
        Me.svcStartupCombo.Size = New System.Drawing.Size(203, 21)
        Me.svcStartupCombo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(13, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Startup Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(13, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Path to executable:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(13, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Display Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Name:"
        '
        'gbSvcStatus
        '
        Me.gbSvcStatus.Controls.Add(Me.picSvcStatus)
        Me.gbSvcStatus.Controls.Add(Me.btnSvcResume)
        Me.gbSvcStatus.Controls.Add(Me.btnSvcPause)
        Me.gbSvcStatus.Controls.Add(Me.btnSvcStop)
        Me.gbSvcStatus.Controls.Add(Me.btnSvcStart)
        Me.gbSvcStatus.Controls.Add(Me.lblSvcStatus)
        Me.gbSvcStatus.Controls.Add(Me.Label6)
        Me.gbSvcStatus.Location = New System.Drawing.Point(12, 307)
        Me.gbSvcStatus.Name = "gbSvcStatus"
        Me.gbSvcStatus.Size = New System.Drawing.Size(368, 114)
        Me.gbSvcStatus.TabIndex = 2
        Me.gbSvcStatus.TabStop = False
        Me.gbSvcStatus.Text = "Status"
        '
        'btnSvcResume
        '
        Me.btnSvcResume.Location = New System.Drawing.Point(262, 64)
        Me.btnSvcResume.Name = "btnSvcResume"
        Me.btnSvcResume.Size = New System.Drawing.Size(75, 23)
        Me.btnSvcResume.TabIndex = 5
        Me.btnSvcResume.Text = "Resume"
        Me.btnSvcResume.UseVisualStyleBackColor = True
        '
        'btnSvcPause
        '
        Me.btnSvcPause.Location = New System.Drawing.Point(181, 64)
        Me.btnSvcPause.Name = "btnSvcPause"
        Me.btnSvcPause.Size = New System.Drawing.Size(75, 23)
        Me.btnSvcPause.TabIndex = 4
        Me.btnSvcPause.Text = "Pause"
        Me.btnSvcPause.UseVisualStyleBackColor = True
        '
        'btnSvcStop
        '
        Me.btnSvcStop.Location = New System.Drawing.Point(100, 64)
        Me.btnSvcStop.Name = "btnSvcStop"
        Me.btnSvcStop.Size = New System.Drawing.Size(75, 23)
        Me.btnSvcStop.TabIndex = 3
        Me.btnSvcStop.Text = "Stop"
        Me.btnSvcStop.UseVisualStyleBackColor = True
        '
        'btnSvcStart
        '
        Me.btnSvcStart.Location = New System.Drawing.Point(19, 64)
        Me.btnSvcStart.Name = "btnSvcStart"
        Me.btnSvcStart.Size = New System.Drawing.Size(75, 23)
        Me.btnSvcStart.TabIndex = 2
        Me.btnSvcStart.Text = "Start"
        Me.btnSvcStart.UseVisualStyleBackColor = True
        '
        'lblSvcStatus
        '
        Me.lblSvcStatus.AutoSize = True
        Me.lblSvcStatus.Location = New System.Drawing.Point(99, 28)
        Me.lblSvcStatus.Name = "lblSvcStatus"
        Me.lblSvcStatus.Size = New System.Drawing.Size(10, 13)
        Me.lblSvcStatus.TabIndex = 1
        Me.lblSvcStatus.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(16, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Service Status:"
        '
        'picSvcStatus
        '
        Me.picSvcStatus.Image = Global.CMC.My.Resources.Resources._stop
        Me.picSvcStatus.Location = New System.Drawing.Point(311, 11)
        Me.picSvcStatus.Name = "picSvcStatus"
        Me.picSvcStatus.Size = New System.Drawing.Size(32, 32)
        Me.picSvcStatus.TabIndex = 6
        Me.picSvcStatus.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CMC.My.Resources.Resources.gear
        Me.PictureBox1.Location = New System.Drawing.Point(331, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SvcInfo
        '
        Me.AcceptButton = Me.Cancel_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(392, 474)
        Me.Controls.Add(Me.gbSvcStatus)
        Me.Controls.Add(Me.gbGeneral)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SvcInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Properties"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.gbGeneral.ResumeLayout(False)
        Me.gbGeneral.PerformLayout()
        Me.gbSvcStatus.ResumeLayout(False)
        Me.gbSvcStatus.PerformLayout()
        CType(Me.picSvcStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents gbGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents gbSvcStatus As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents svcStartupCombo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnSvcResume As System.Windows.Forms.Button
    Friend WithEvents btnSvcPause As System.Windows.Forms.Button
    Friend WithEvents btnSvcStop As System.Windows.Forms.Button
    Friend WithEvents btnSvcStart As System.Windows.Forms.Button
    Friend WithEvents lblSvcStatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblSvcAccount As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSvcPath As System.Windows.Forms.TextBox
    Friend WithEvents txtSvcCaption As System.Windows.Forms.TextBox
    Friend WithEvents txtSvcName As System.Windows.Forms.TextBox
    Friend WithEvents picSvcStatus As System.Windows.Forms.PictureBox

End Class
