<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmGroupMembers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FmGroupMembers))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ButtonAdd = New System.Windows.Forms.Button
        Me.ButtonRemove = New System.Windows.Forms.Button
        Me.ButtonExport = New System.Windows.Forms.Button
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MembersListView = New System.Windows.Forms.ListView
        Me.memberCN = New System.Windows.Forms.ColumnHeader
        Me.memberDisplay = New System.Windows.Forms.ColumnHeader
        Me.memberEmail = New System.Windows.Forms.ColumnHeader
        Me.memberDN = New System.Windows.Forms.ColumnHeader
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(455, 38)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(154, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(301, 38)
        Me.Panel3.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonAdd, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonRemove, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonExport, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonClose, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(295, 32)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(67, 23)
        Me.ButtonAdd.TabIndex = 0
        Me.ButtonAdd.Text = "Add..."
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.Location = New System.Drawing.Point(76, 3)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(67, 23)
        Me.ButtonRemove.TabIndex = 1
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = True
        '
        'ButtonExport
        '
        Me.ButtonExport.Location = New System.Drawing.Point(149, 3)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(67, 23)
        Me.ButtonExport.TabIndex = 2
        Me.ButtonExport.Text = "Export..."
        Me.ButtonExport.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(222, 3)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(70, 23)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MembersListView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(455, 284)
        Me.Panel2.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "user.png")
        Me.ImageList1.Images.SetKeyName(1, "group.png")
        Me.ImageList1.Images.SetKeyName(2, "people.png")
        Me.ImageList1.Images.SetKeyName(3, "users.png")
        Me.ImageList1.Images.SetKeyName(4, "computer.png")
        Me.ImageList1.Images.SetKeyName(5, "contact.png")
        '
        'MembersListView
        '
        Me.MembersListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.memberCN, Me.memberDisplay, Me.memberEmail, Me.memberDN})
        Me.MembersListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MembersListView.FullRowSelect = True
        Me.MembersListView.Location = New System.Drawing.Point(0, 0)
        Me.MembersListView.Name = "MembersListView"
        Me.MembersListView.Size = New System.Drawing.Size(455, 284)
        Me.MembersListView.SmallImageList = Me.ImageList1
        Me.MembersListView.TabIndex = 0
        Me.MembersListView.UseCompatibleStateImageBehavior = False
        Me.MembersListView.View = System.Windows.Forms.View.Details
        '
        'memberCN
        '
        Me.memberCN.Text = "Name"
        Me.memberCN.Width = 170
        '
        'memberDisplay
        '
        Me.memberDisplay.Text = "Display Name"
        Me.memberDisplay.Width = 280
        '
        'memberEmail
        '
        Me.memberEmail.Text = "Email"
        Me.memberEmail.Width = 0
        '
        'memberDN
        '
        Me.memberDN.Text = "Distinguished Name"
        Me.memberDN.Width = 0
        '
        'FmGroupMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 322)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FmGroupMembers"
        Me.ShowInTaskbar = False
        Me.Text = "FmGroupMembers"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MembersListView As System.Windows.Forms.ListView
    Friend WithEvents memberCN As System.Windows.Forms.ColumnHeader
    Friend WithEvents memberDisplay As System.Windows.Forms.ColumnHeader
    Friend WithEvents memberEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents memberDN As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ButtonAdd As System.Windows.Forms.Button
    Friend WithEvents ButtonRemove As System.Windows.Forms.Button
    Friend WithEvents ButtonExport As System.Windows.Forms.Button
    Friend WithEvents ButtonClose As System.Windows.Forms.Button

End Class
