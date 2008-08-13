<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcInfo))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNoProcess = New System.Windows.Forms.Label
        Me.txtProcOwner = New System.Windows.Forms.TextBox
        Me.txtProcPath = New System.Windows.Forms.TextBox
        Me.txtProcPid = New System.Windows.Forms.TextBox
        Me.txtProcName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.gbProcResources = New System.Windows.Forms.GroupBox
        Me.txtPeakWorkingSet = New System.Windows.Forms.TextBox
        Me.txtWorkingSet = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCPUTime = New System.Windows.Forms.TextBox
        Me.txtPageFile = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtHandleCount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblTick = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbProcResources.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(206, 409)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Close"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNoProcess)
        Me.GroupBox1.Controls.Add(Me.txtProcOwner)
        Me.GroupBox1.Controls.Add(Me.txtProcPath)
        Me.GroupBox1.Controls.Add(Me.txtProcPid)
        Me.GroupBox1.Controls.Add(Me.txtProcName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 213)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Process Information"
        '
        'lblNoProcess
        '
        Me.lblNoProcess.AutoSize = True
        Me.lblNoProcess.ForeColor = System.Drawing.Color.Red
        Me.lblNoProcess.Location = New System.Drawing.Point(100, 16)
        Me.lblNoProcess.Name = "lblNoProcess"
        Me.lblNoProcess.Size = New System.Drawing.Size(45, 13)
        Me.lblNoProcess.TabIndex = 9
        Me.lblNoProcess.Text = "Label14"
        Me.lblNoProcess.Visible = False
        '
        'txtProcOwner
        '
        Me.txtProcOwner.Location = New System.Drawing.Point(31, 173)
        Me.txtProcOwner.Name = "txtProcOwner"
        Me.txtProcOwner.ReadOnly = True
        Me.txtProcOwner.Size = New System.Drawing.Size(289, 20)
        Me.txtProcOwner.TabIndex = 8
        '
        'txtProcPath
        '
        Me.txtProcPath.Location = New System.Drawing.Point(31, 121)
        Me.txtProcPath.Name = "txtProcPath"
        Me.txtProcPath.ReadOnly = True
        Me.txtProcPath.Size = New System.Drawing.Size(289, 20)
        Me.txtProcPath.TabIndex = 7
        '
        'txtProcPid
        '
        Me.txtProcPid.Location = New System.Drawing.Point(144, 73)
        Me.txtProcPid.Name = "txtProcPid"
        Me.txtProcPid.ReadOnly = True
        Me.txtProcPid.Size = New System.Drawing.Size(176, 20)
        Me.txtProcPid.TabIndex = 6
        '
        'txtProcName
        '
        Me.txtProcName.Location = New System.Drawing.Point(144, 41)
        Me.txtProcName.Name = "txtProcName"
        Me.txtProcName.ReadOnly = True
        Me.txtProcName.Size = New System.Drawing.Size(176, 20)
        Me.txtProcName.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Process Owner"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Path"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Process ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Process Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Handle Count:"
        Me.ToolTip1.SetToolTip(Me.Label7, "Total number of open handles owned by the process.")
        '
        'gbProcResources
        '
        Me.gbProcResources.Controls.Add(Me.PictureBox1)
        Me.gbProcResources.Controls.Add(Me.txtPeakWorkingSet)
        Me.gbProcResources.Controls.Add(Me.txtWorkingSet)
        Me.gbProcResources.Controls.Add(Me.Label13)
        Me.gbProcResources.Controls.Add(Me.Label12)
        Me.gbProcResources.Controls.Add(Me.txtCPUTime)
        Me.gbProcResources.Controls.Add(Me.txtPageFile)
        Me.gbProcResources.Controls.Add(Me.Label11)
        Me.gbProcResources.Controls.Add(Me.Label2)
        Me.gbProcResources.Controls.Add(Me.Label4)
        Me.gbProcResources.Controls.Add(Me.Label5)
        Me.gbProcResources.Controls.Add(Me.txtHandleCount)
        Me.gbProcResources.Controls.Add(Me.Label3)
        Me.gbProcResources.Controls.Add(Me.Label1)
        Me.gbProcResources.Controls.Add(Me.Label7)
        Me.gbProcResources.Location = New System.Drawing.Point(12, 231)
        Me.gbProcResources.Name = "gbProcResources"
        Me.gbProcResources.Size = New System.Drawing.Size(337, 170)
        Me.gbProcResources.TabIndex = 4
        Me.gbProcResources.TabStop = False
        Me.gbProcResources.Text = "Performance"
        '
        'txtPeakWorkingSet
        '
        Me.txtPeakWorkingSet.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPeakWorkingSet.Location = New System.Drawing.Point(196, 78)
        Me.txtPeakWorkingSet.Name = "txtPeakWorkingSet"
        Me.txtPeakWorkingSet.ReadOnly = True
        Me.txtPeakWorkingSet.Size = New System.Drawing.Size(100, 20)
        Me.txtPeakWorkingSet.TabIndex = 8
        '
        'txtWorkingSet
        '
        Me.txtWorkingSet.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtWorkingSet.Location = New System.Drawing.Point(196, 55)
        Me.txtWorkingSet.Name = "txtWorkingSet"
        Me.txtWorkingSet.ReadOnly = True
        Me.txtWorkingSet.Size = New System.Drawing.Size(100, 20)
        Me.txtWorkingSet.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(295, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "k"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(295, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "k"
        '
        'txtCPUTime
        '
        Me.txtCPUTime.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtCPUTime.Location = New System.Drawing.Point(196, 143)
        Me.txtCPUTime.Name = "txtCPUTime"
        Me.txtCPUTime.ReadOnly = True
        Me.txtCPUTime.Size = New System.Drawing.Size(100, 20)
        Me.txtCPUTime.TabIndex = 11
        '
        'txtPageFile
        '
        Me.txtPageFile.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtPageFile.Location = New System.Drawing.Point(196, 120)
        Me.txtPageFile.Name = "txtPageFile"
        Me.txtPageFile.ReadOnly = True
        Me.txtPageFile.Size = New System.Drawing.Size(100, 20)
        Me.txtPageFile.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(295, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "k"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(295, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "CPU Time:"
        Me.ToolTip1.SetToolTip(Me.Label4, "Amount of time this process has used the cpu since it started.")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Current WorkingSet:"
        Me.ToolTip1.SetToolTip(Me.Label5, "Amount of physical memory the process is using.")
        '
        'txtHandleCount
        '
        Me.txtHandleCount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtHandleCount.Location = New System.Drawing.Point(196, 15)
        Me.txtHandleCount.Name = "txtHandleCount"
        Me.txtHandleCount.ReadOnly = True
        Me.txtHandleCount.Size = New System.Drawing.Size(100, 20)
        Me.txtHandleCount.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PageFile Usage:"
        Me.ToolTip1.SetToolTip(Me.Label3, "Amount of page file space currently used by the process.")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Peak WorkingSet:"
        Me.ToolTip1.SetToolTip(Me.Label1, "Maximum size of the working set used by the process since it was created.")
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'lblTick
        '
        Me.lblTick.AutoSize = True
        Me.lblTick.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTick.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblTick.Location = New System.Drawing.Point(12, 404)
        Me.lblTick.Name = "lblTick"
        Me.lblTick.Size = New System.Drawing.Size(45, 13)
        Me.lblTick.TabIndex = 5
        Me.lblTick.Text = "Label12"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CMC.My.Resources.Resources.stats_info
        Me.PictureBox1.Location = New System.Drawing.Point(7, 127)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'ProcInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(364, 450)
        Me.Controls.Add(Me.lblTick)
        Me.Controls.Add(Me.gbProcResources)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProcInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Properties"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbProcResources.ResumeLayout(False)
        Me.gbProcResources.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProcOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtProcPath As System.Windows.Forms.TextBox
    Friend WithEvents txtProcPid As System.Windows.Forms.TextBox
    Friend WithEvents txtProcName As System.Windows.Forms.TextBox
    Friend WithEvents gbProcResources As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPageFile As System.Windows.Forms.TextBox
    Friend WithEvents txtPeakWorkingSet As System.Windows.Forms.TextBox
    Friend WithEvents txtHandleCount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCPUTime As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkingSet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTick As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblNoProcess As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
