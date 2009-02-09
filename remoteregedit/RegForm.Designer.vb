<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.TreeViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuExpand = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNew = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNewKey = New System.Windows.Forms.ToolStripMenuItem
        Me.SepToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.MenuNewSZ = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNewDWORD = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNewMultiSZ = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuNewExpandSZ = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuDelete = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.MenuCopyKey = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyKeyPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.NameColumn = New System.Windows.Forms.ColumnHeader
        Me.TypeColumn = New System.Windows.Forms.ColumnHeader
        Me.DataColumn = New System.Windows.Forms.ColumnHeader
        Me.ListViewContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LV_ModifyMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LV_Sep = New System.Windows.Forms.ToolStripSeparator
        Me.LV_DeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyValuePathMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LV_NewMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.KeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator
        Me.LV_NewString = New System.Windows.Forms.ToolStripMenuItem
        Me.LV_NewDWORD = New System.Windows.Forms.ToolStripMenuItem
        Me.LV_NewMultiSZ = New System.Windows.Forms.ToolStripMenuItem
        Me.LV_NewExpandSZ = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.strip1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.dbglabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.ExportMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComputerNameTextBox = New System.Windows.Forms.TextBox
        Me.Go_Button = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SaveRegFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TreeViewContextMenu.SuspendLayout()
        Me.ListViewContextMenu.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(764, 495)
        Me.SplitContainer1.SplitterDistance = 251
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.ContextMenuStrip = Me.TreeViewContextMenu
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ImageKey = "closedfolder.png"
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.Indent = 19
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageKey = "openfolder.ICO"
        Me.TreeView1.Size = New System.Drawing.Size(251, 495)
        Me.TreeView1.TabIndex = 0
        '
        'TreeViewContextMenu
        '
        Me.TreeViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuExpand, Me.MenuNew, Me.ToolStripSeparator6, Me.MenuDelete, Me.ToolStripSeparator3, Me.MenuCopyKey, Me.CopyKeyPathToolStripMenuItem, Me.ToolStripSeparator1, Me.ExportToolStripMenuItem})
        Me.TreeViewContextMenu.Name = "TreeViewContextMenu"
        Me.TreeViewContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TreeViewContextMenu.ShowImageMargin = False
        Me.TreeViewContextMenu.Size = New System.Drawing.Size(132, 154)
        '
        'MenuExpand
        '
        Me.MenuExpand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MenuExpand.Name = "MenuExpand"
        Me.MenuExpand.Size = New System.Drawing.Size(131, 22)
        Me.MenuExpand.Text = "Expand"
        '
        'MenuNew
        '
        Me.MenuNew.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuNewKey, Me.SepToolStripMenuItem, Me.MenuNewSZ, Me.MenuNewDWORD, Me.MenuNewMultiSZ, Me.MenuNewExpandSZ})
        Me.MenuNew.Name = "MenuNew"
        Me.MenuNew.Size = New System.Drawing.Size(131, 22)
        Me.MenuNew.Text = "New"
        '
        'MenuNewKey
        '
        Me.MenuNewKey.Name = "MenuNewKey"
        Me.MenuNewKey.Size = New System.Drawing.Size(200, 22)
        Me.MenuNewKey.Text = "Key"
        '
        'SepToolStripMenuItem
        '
        Me.SepToolStripMenuItem.Name = "SepToolStripMenuItem"
        Me.SepToolStripMenuItem.Size = New System.Drawing.Size(197, 6)
        '
        'MenuNewSZ
        '
        Me.MenuNewSZ.Name = "MenuNewSZ"
        Me.MenuNewSZ.Size = New System.Drawing.Size(200, 22)
        Me.MenuNewSZ.Text = "String Value"
        '
        'MenuNewDWORD
        '
        Me.MenuNewDWORD.Name = "MenuNewDWORD"
        Me.MenuNewDWORD.Size = New System.Drawing.Size(200, 22)
        Me.MenuNewDWORD.Text = "Dword Value"
        '
        'MenuNewMultiSZ
        '
        Me.MenuNewMultiSZ.Name = "MenuNewMultiSZ"
        Me.MenuNewMultiSZ.Size = New System.Drawing.Size(200, 22)
        Me.MenuNewMultiSZ.Text = "Multi String Value"
        '
        'MenuNewExpandSZ
        '
        Me.MenuNewExpandSZ.Name = "MenuNewExpandSZ"
        Me.MenuNewExpandSZ.Size = New System.Drawing.Size(200, 22)
        Me.MenuNewExpandSZ.Text = "Expandable String Value"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(128, 6)
        '
        'MenuDelete
        '
        Me.MenuDelete.Name = "MenuDelete"
        Me.MenuDelete.Size = New System.Drawing.Size(131, 22)
        Me.MenuDelete.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(128, 6)
        '
        'MenuCopyKey
        '
        Me.MenuCopyKey.Name = "MenuCopyKey"
        Me.MenuCopyKey.Size = New System.Drawing.Size(131, 22)
        Me.MenuCopyKey.Text = "Copy key name"
        '
        'CopyKeyPathToolStripMenuItem
        '
        Me.CopyKeyPathToolStripMenuItem.Name = "CopyKeyPathToolStripMenuItem"
        Me.CopyKeyPathToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CopyKeyPathToolStripMenuItem.Text = "Copy key path"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "closedfolder.png")
        Me.ImageList1.Images.SetKeyName(1, "openfolder.ICO")
        Me.ImageList1.Images.SetKeyName(2, "binary.png")
        Me.ImageList1.Images.SetKeyName(3, "sz.png")
        Me.ImageList1.Images.SetKeyName(4, "folder_closed.ico")
        Me.ImageList1.Images.SetKeyName(5, "folder_open.ico")
        Me.ImageList1.Images.SetKeyName(6, "0018.ico")
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn, Me.DataColumn})
        Me.ListView1.ContextMenuStrip = Me.ListViewContextMenu
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(509, 495)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 130
        '
        'TypeColumn
        '
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 95
        '
        'DataColumn
        '
        Me.DataColumn.Text = "Data"
        Me.DataColumn.Width = 280
        '
        'ListViewContextMenu
        '
        Me.ListViewContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LV_ModifyMenuItem, Me.LV_Sep, Me.LV_DeleteMenuItem, Me.CopyValuePathMenuItem, Me.LV_NewMenu})
        Me.ListViewContextMenu.Name = "ListViewContextMenu"
        Me.ListViewContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ListViewContextMenu.ShowImageMargin = False
        Me.ListViewContextMenu.Size = New System.Drawing.Size(136, 98)
        '
        'LV_ModifyMenuItem
        '
        Me.LV_ModifyMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LV_ModifyMenuItem.Name = "LV_ModifyMenuItem"
        Me.LV_ModifyMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LV_ModifyMenuItem.Text = "Modify"
        Me.LV_ModifyMenuItem.Visible = False
        '
        'LV_Sep
        '
        Me.LV_Sep.Name = "LV_Sep"
        Me.LV_Sep.Size = New System.Drawing.Size(132, 6)
        Me.LV_Sep.Visible = False
        '
        'LV_DeleteMenuItem
        '
        Me.LV_DeleteMenuItem.Name = "LV_DeleteMenuItem"
        Me.LV_DeleteMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LV_DeleteMenuItem.Text = "Delete"
        Me.LV_DeleteMenuItem.Visible = False
        '
        'CopyValuePathMenuItem
        '
        Me.CopyValuePathMenuItem.Name = "CopyValuePathMenuItem"
        Me.CopyValuePathMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CopyValuePathMenuItem.Text = "Copy value path"
        '
        'LV_NewMenu
        '
        Me.LV_NewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeyToolStripMenuItem, Me.EToolStripMenuItem, Me.LV_NewString, Me.LV_NewDWORD, Me.LV_NewMultiSZ, Me.LV_NewExpandSZ})
        Me.LV_NewMenu.Name = "LV_NewMenu"
        Me.LV_NewMenu.Size = New System.Drawing.Size(135, 22)
        Me.LV_NewMenu.Text = "New"
        '
        'KeyToolStripMenuItem
        '
        Me.KeyToolStripMenuItem.Name = "KeyToolStripMenuItem"
        Me.KeyToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.KeyToolStripMenuItem.Text = "Key"
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(187, 6)
        '
        'LV_NewString
        '
        Me.LV_NewString.Name = "LV_NewString"
        Me.LV_NewString.Size = New System.Drawing.Size(190, 22)
        Me.LV_NewString.Text = "String Value"
        '
        'LV_NewDWORD
        '
        Me.LV_NewDWORD.Name = "LV_NewDWORD"
        Me.LV_NewDWORD.Size = New System.Drawing.Size(190, 22)
        Me.LV_NewDWORD.Text = "DWORD Value"
        '
        'LV_NewMultiSZ
        '
        Me.LV_NewMultiSZ.Name = "LV_NewMultiSZ"
        Me.LV_NewMultiSZ.Size = New System.Drawing.Size(190, 22)
        Me.LV_NewMultiSZ.Text = "Multi String Value"
        '
        'LV_NewExpandSZ
        '
        Me.LV_NewExpandSZ.Name = "LV_NewExpandSZ"
        Me.LV_NewExpandSZ.Size = New System.Drawing.Size(190, 22)
        Me.LV_NewExpandSZ.Text = "Expanded String value"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.strip1, Me.ToolStripStatusLabel1, Me.dbglabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 519)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'strip1
        '
        Me.strip1.Name = "strip1"
        Me.strip1.Size = New System.Drawing.Size(0, 17)
        Me.strip1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(72, 17)
        Me.ToolStripStatusLabel1.Text = "My Computer"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dbglabel
        '
        Me.dbglabel.Name = "dbglabel"
        Me.dbglabel.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(764, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.ExportMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = Global.RemoteRegedit.My.Resources.Resources.png_16_reg_t
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Clear"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'ExportMenuItem
        '
        Me.ExportMenuItem.Image = CType(resources.GetObject("ExportMenuItem.Image"), System.Drawing.Image)
        Me.ExportMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportMenuItem.Name = "ExportMenuItem"
        Me.ExportMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportMenuItem.Text = "Export"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.RemoteRegedit.My.Resources.Resources.door_out
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.FontToolStripMenuItem1})
        Me.CustomizeToolStripMenuItem.Image = Global.RemoteRegedit.My.Resources.Resources.application_form_edit
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Customize"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Image = Global.RemoteRegedit.My.Resources.Resources.font_add
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FontToolStripMenuItem.Text = "Font +"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Image = Global.RemoteRegedit.My.Resources.Resources.font_delete
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(171, 22)
        Me.FontToolStripMenuItem1.Text = "Font -"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Image = Global.RemoteRegedit.My.Resources.Resources.bullet_wrench
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.RemoteRegedit.My.Resources.Resources.information
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ComputerNameTextBox
        '
        Me.ComputerNameTextBox.BackColor = System.Drawing.Color.Beige
        Me.ComputerNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ComputerNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerNameTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ComputerNameTextBox.Location = New System.Drawing.Point(255, 1)
        Me.ComputerNameTextBox.MaxLength = 25
        Me.ComputerNameTextBox.Name = "ComputerNameTextBox"
        Me.ComputerNameTextBox.Size = New System.Drawing.Size(110, 20)
        Me.ComputerNameTextBox.TabIndex = 3
        '
        'Go_Button
        '
        Me.Go_Button.Image = Global.RemoteRegedit.My.Resources.Resources.bullet_go
        Me.Go_Button.Location = New System.Drawing.Point(365, 1)
        Me.Go_Button.Name = "Go_Button"
        Me.Go_Button.Size = New System.Drawing.Size(20, 20)
        Me.Go_Button.TabIndex = 5
        Me.Go_Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.RemoteRegedit.My.Resources.Resources._0018
        Me.Button1.Location = New System.Drawing.Point(215, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 21)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = False
        '
        'SaveRegFileDialog
        '
        Me.SaveRegFileDialog.DefaultExt = "REG"
        Me.SaveRegFileDialog.Filter = "Registration files (*.reg)|*.reg*.txt"
        Me.SaveRegFileDialog.InitialDirectory = "Desktop"
        '
        'RegForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 541)
        Me.Controls.Add(Me.Go_Button)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComputerNameTextBox)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RegForm"
        Me.Text = "Remote Registry Editor"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TreeViewContextMenu.ResumeLayout(False)
        Me.ListViewContextMenu.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents NameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents TypeColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DataColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents strip1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TreeViewContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuExpand As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNewKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SepToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuNewSZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNewDWORD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNewMultiSZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuNewExpandSZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuCopyKey As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListViewContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents LV_NewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LV_NewString As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LV_NewDWORD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LV_NewMultiSZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LV_NewExpandSZ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LV_ModifyMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LV_DeleteMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LV_Sep As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyKeyPathToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComputerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyValuePathMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dbglabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Go_Button As System.Windows.Forms.Button
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveRegFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator

End Class
