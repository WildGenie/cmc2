Public Class RegForm

    Public vbreg As New VBRegistry
    Public sComputerName As String
    Public sHive As Microsoft.Win32.RegistryHive
    Public sRegistryKey As String
    Public sNode As TreeNode

    Public Sub New()

        InitializeComponent()

        ' Set default computer as local machine
        sComputerName = Environment.ExpandEnvironmentVariables("%computername%")

        ' if arg passed, use as target computer and test ping
        If Environment.GetCommandLineArgs().Length > 1 Then
            If Environment.GetCommandLineArgs(1) = "/?" Then
                MsgBox("Usage:" & vbCrLf & "RemReg Computer_Name [/u:username] [/p:password]", MsgBoxStyle.Information, "Remote Registry Editor")
            ElseIf Environment.GetCommandLineArgs().Length = 2 Then ' computername arg added
                If Pings(Environment.GetCommandLineArgs(1)) Then
                    sComputerName = Environment.GetCommandLineArgs(1)
                Else
                    MsgBox(Environment.GetCommandLineArgs(1) & " did not respond")
                    Exit Sub
                End If
            End If
        End If

        ComputerNameTextBox.Text = sComputerName

        ' Create nodes
        PopulateTreeView()

        ' Populate status strip
        ToolStripStatusLabel1.Text = UCase(sComputerName)

    End Sub
    Private Sub ComputerNameTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComputerNameTextBox.TextChanged
        TreeView1.Nodes.Clear()
        ListView1.Items.Clear()
    End Sub
    Private Sub ComputerNameTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComputerNameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComputerChanged()
        End If
    End Sub
    Private Sub Go_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Go_Button.Click
        ComputerChanged()
    End Sub
    Private Sub ComputerChanged()
        TreeView1.Nodes.Clear()
        ListView1.Items.Clear()
        ToolStripStatusLabel1.Text = String.Empty
        If Not Trim(ComputerNameTextBox.Text) = String.Empty Then
            ' if arg passed, use as target computer and test ping
            If Pings(ComputerNameTextBox.Text) Then
                sComputerName = Trim(ComputerNameTextBox.Text)
            Else
                MsgBox(ComputerNameTextBox.Text & " did not respond", MsgBoxStyle.Exclamation, "Remote Registry Editor")
                sComputerName = String.Empty
                Exit Sub
            End If

            ' Create nodes
            PopulateTreeView()

            ' Populate status strip
            ToolStripStatusLabel1.Text = UCase(sComputerName)
        End If
    End Sub

    ' Create HKLM & HKU Nodes and populate first level
    Private Sub PopulateTreeView()

        ' Enumerate HKLM Node SubKeys
        Dim HKLM_Node As TreeNode
        HKLM_Node = New TreeNode("HKEY_LOCAL_MACHINE")
        HKLM_Node.Name = "HKLM"
        GetSubKeys(Microsoft.Win32.RegistryHive.LocalMachine, "", HKLM_Node)

        ' Enumerate First level of HKLM_Node Subkey subkeys
        For Each aNode As TreeNode In HKLM_Node.Nodes
            GetSubKeys(Microsoft.Win32.RegistryHive.LocalMachine, aNode.Tag, aNode)
        Next

        ' Enumerate HKU Node SubKeys
        Dim HKU_Node As TreeNode
        HKU_Node = New TreeNode("HKEY_USERS")
        HKU_Node.Name = "HKU"
        GetSubKeys(Microsoft.Win32.RegistryHive.Users, "", HKU_Node)

        TreeView1.Nodes.Add(HKLM_Node)
        TreeView1.Nodes.Add(HKU_Node)

    End Sub
    Private Sub GetSubKeys(ByVal RegHive As Microsoft.Win32.RegistryHive, ByVal KeyPath As String, ByVal nodeToAddTo As TreeNode)

        Dim subkeys As Array = vbreg.EnumKeys(sComputerName, RegHive, KeyPath)
        Dim aNode As TreeNode
        If Not subkeys Is Nothing Then
            For Each sKey As String In subkeys
                aNode = New TreeNode(sKey, 0, 0)
                aNode.Tag = sKey
                nodeToAddTo.Nodes.Add(aNode)
            Next sKey
        End If

    End Sub

    Private Sub UpdateSelection(ByVal sender As Object)

        'Dim node As TreeNode = DirectCast(sender, TreeView).SelectedNode
        sNode = DirectCast(sender, TreeView).SelectedNode
        Dim HiveName As String = String.Empty
        'Dim node As TreeNode = e.node
        If sNode.Parent Is Nothing Then
            HiveName = sNode.Text
            sRegistryKey = ""
        Else
            Dim parent As TreeNode = sNode.Parent
            While Not parent.Parent Is Nothing
                parent = parent.Parent
            End While
            HiveName = parent.Text
            sRegistryKey = Mid(sNode.FullPath, parent.Text.Length + 2, sNode.FullPath.Length)
        End If

        If HiveName = "HKEY_LOCAL_MACHINE" Then
            sHive = Microsoft.Win32.RegistryHive.LocalMachine
        ElseIf HiveName = "HKEY_USERS" Then
            sHive = Microsoft.Win32.RegistryHive.Users
        End If


    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Me.Cursor = Cursors.WaitCursor
        UpdateSelection(sender)
        FillNodeValues()
        ToolStripStatusLabel1.Text = UCase(sComputerName) & "\" & sNode.FullPath
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub TreeView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeView1.KeyDown
        If e.KeyCode = Keys.Right Then
            Me.Cursor = Cursors.WaitCursor
            FillNodeValues()
            If sNode.GetNodeCount(True) = 0 Then FillNodeKeys()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        TreeView1.SelectedNode = e.Node
        'ToolStripStatusLabel1.Text = UCase(sComputerName) & "\" & sNode.FullPath
    End Sub
    Private Sub TreeView1_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Me.Cursor = Cursors.WaitCursor
        If sNode.GetNodeCount(True) = 0 Then FillNodeKeys()
        If sNode.IsExpanded = False Then
            sNode.Expand()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub FillNodeKeys()
        GetSubKeys(sHive, sRegistryKey, sNode)
    End Sub
    Public Sub FillNodeValues()
        ListView1.Items.Clear()
        vbreg.EnumValues(sComputerName, sHive, sRegistryKey)
    End Sub

    ' Change Key Icon according to treeview status
    Private Sub TreeView1_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterExpand
        sNode.SelectedImageIndex = 1
    End Sub
    Private Sub TreeView1_AfterCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterCollapse
        sNode.SelectedImageIndex = 0
    End Sub

    '' Return Hive and Subkey from selected node.
    'Public ReadOnly Property GetSelectedHive() As Microsoft.Win32.RegistryHive
    '    Get
    '        Dim arrPath As Array = Split(TreeView1.SelectedNode.FullPath, "\")
    '        If arrPath(0) = "HKEY_LOCAL_MACHINE" Then
    '            Return Microsoft.Win32.RegistryHive.LocalMachine
    '        ElseIf arrPath(0) = "HKEY_USERS" Then
    '            Return Microsoft.Win32.RegistryHive.Users
    '        Else
    '            Return String.Empty
    '        End If
    '    End Get
    'End Property
    'Public ReadOnly Property GetSelectedSubKey()
    '    Get
    '        Dim arrPath As Array = Split(TreeView1.SelectedNode.FullPath, "\")
    '        Dim subkeypath As String = String.Empty

    '        If arrPath.Length > 1 Then
    '            For i As Integer = 1 To arrPath.Length - 1
    '                subkeypath = subkeypath & arrPath(i) & "\"
    '            Next
    '            subkeypath = Mid(subkeypath, 1, subkeypath.Length - 1)
    '        End If
    '        Return subkeypath
    '    End Get
    'End Property

    ' TreeView Context Menu
    Private Sub MenuExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExpand.Click
        Me.Cursor = Cursors.WaitCursor
        If sNode.GetNodeCount(True) = 0 Then FillNodeKeys()
        sNode.Expand()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub MenuCopyKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCopyKey.Click
        Clipboard.SetText(sNode.Tag.ToString)
    End Sub
    Private Sub CopyKeyPathToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyKeyPathToolStripMenuItem.Click
        Clipboard.SetText(sNode.FullPath)
    End Sub
    Private Sub MenuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDelete.Click
        Me.Cursor = Cursors.WaitCursor
        vbreg.DeleteKey(sComputerName, sHive, sRegistryKey, sNode.Tag)
        sNode.Parent.Nodes.Clear()
        Me.Cursor = Cursors.Default
    End Sub


    ' Add new Key
    Private Sub MenuNewKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNewKey.Click

        If Not TreeView1.SelectedNode Is Nothing Then
            Dim aNode As TreeNode
            aNode = New TreeNode()
            sNode.Nodes.Add(aNode)
            sNode.Expand()
            TreeView1.LabelEdit = True
            If Not aNode.IsEditing Then aNode.BeginEdit()
        End If

    End Sub
    Private Sub TreeView1_AfterLabelEdit_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.NodeLabelEditEventArgs) Handles TreeView1.AfterLabelEdit
        If Not (e.Label Is Nothing) Then
            If e.Label.Length > 0 Then
                If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
                    ' Stop editing without canceling the label change.
                    e.Node.EndEdit(False)
                Else
                    ' Cancel the label edit action, inform the user, and
                    ' place the node in edit mode again. 
                    e.CancelEdit = True
                    MessageBox.Show("Invalid tree node label." & _
                      Microsoft.VisualBasic.ControlChars.Cr & _
                      "The invalid characters are: '@','.', ',', '!'", _
                      "Node Label Edit")
                    e.Node.BeginEdit()
                End If
            Else
                ' Cancel the label edit action, inform the user, and
                ' place the node in edit mode again. 
                e.CancelEdit = True
                MessageBox.Show("Invalid tree node label." & _
                  Microsoft.VisualBasic.ControlChars.Cr & _
                  "The label cannot be blank", "Node Label Edit")
                e.Node.BeginEdit()
            End If
            Me.TreeView1.LabelEdit = False
        End If

        If Not e.Label Is Nothing Then
            vbreg.NewKey(sComputerName, sHive, sRegistryKey, e.Label)
        End If

        sNode.Nodes.Clear()

    End Sub
    Private Sub KeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeyToolStripMenuItem.Click
        If Not sNode Is Nothing Then
            Dim aNode As TreeNode
            aNode = New TreeNode()
            TreeView1.SelectedNode.Nodes.Add(aNode)
            sNode.Expand()
            TreeView1.LabelEdit = True
            If Not aNode.IsEditing Then aNode.BeginEdit()
        End If
    End Sub

    ' Edit Value Data
    Private Sub ListView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick
        EditItem()
    End Sub
    Private Sub LV_ModifyMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_ModifyMenuItem.Click
        EditItem()
    End Sub
    ' 
    Private Sub EditItem()
        Dim Row As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
        Dim item As ListViewItem = Nothing

        For Each item In Row
            Edit.ValueNameTextBox.Text = item.SubItems(0).Text
            Edit.ValueDataTextBox.Text = item.SubItems(2).Text
        Next

        Select Case item.SubItems(1).Text
            Case "Reg_SZ"
                Edit.Text = "Edit String"
                Edit.AcceptButton = Edit.OK_Button
                If LCase(item.SubItems(0).Text) = "(default)" Then Edit.ValueNameTextBox.Text = ""
            Case "Reg_DWORD"
                Edit.Text = "Edit DWORD"
                Edit.AcceptButton = Edit.OK_Button
            Case "Reg_MULTI_SZ"
                Edit.Text = "Edit Multi String"
                Edit.ValueDataTextBox.Multiline = True
                Edit.Height = 250
                Edit.ValueDataTextBox.Height = 88
                Edit.ValueDataTextBox.ScrollBars = ScrollBars.Vertical
                Edit.AcceptButton = Nothing
            Case "Reg_EXPAND_SZ"
                Edit.Text = "Edit Expanded String"
                Edit.AcceptButton = Edit.OK_Button
            Case "Reg_BINARY"
                Edit.Text = "Edit Binary Value"
                Edit.ValueDataTextBox.ReadOnly = True
                Edit.AcceptButton = Edit.OK_Button
        End Select

        Edit.Show()
        Edit.ValueDataTextBox.Focus()
    End Sub

    ' List View Context Menu
    Private Sub ListView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim selection As ListViewItem = ListView1.GetItemAt(e.X, e.Y)

            ' If the user selects an item in the ListView, display
            ' the menu items
            If Not (selection Is Nothing) Then
                'ListViewContextMenu.Items.RemoveByKey("LV_NewMenu")
                ListViewContextMenu.Items("LV_NewMenu").Visible = False
                ListViewContextMenu.Items("LV_ModifyMenuItem").Visible = True
                ListViewContextMenu.Items("LV_Sep").Visible = True
                ListViewContextMenu.Items("CopyValuePathMenuItem").Visible = True
                ListViewContextMenu.Items("LV_DeleteMenuItem").Visible = True
            End If
        End If
    End Sub
    Private Sub ListViewContextMenu_Closed(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripDropDownClosedEventArgs) Handles ListViewContextMenu.Closed
        ListViewContextMenu.Items("LV_NewMenu").Visible = True
        ListViewContextMenu.Items("LV_ModifyMenuItem").Visible = False
        ListViewContextMenu.Items("LV_Sep").Visible = False
        ListViewContextMenu.Items("CopyValuePathMenuItem").Visible = False
        ListViewContextMenu.Items("LV_DeleteMenuItem").Visible = False
    End Sub
    Private Sub LV_DeleteMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_DeleteMenuItem.Click
        Me.Cursor = Cursors.WaitCursor
        Dim Row As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
        Dim item As ListViewItem = Nothing
        Dim sValueName As String = ""
        For Each item In Row
            sValueName = item.SubItems(0).Text
        Next
        vbreg.DeleteValue(sComputerName, sHive, sRegistryKey, sValueName)
        FillNodeValues()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub CopyValuePathMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyValuePathMenuItem.Click

        Dim Row As ListView.SelectedListViewItemCollection = ListView1.SelectedItems
        Dim item As ListViewItem = Nothing
        Dim sValueName As String = ""
        For Each item In Row
            sValueName = item.SubItems(0).Text
        Next

        Clipboard.SetText(sNode.FullPath & "\" & sValueName)
    End Sub

    ' Add new Values and data...
    Private Sub LV_NewString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_NewString.Click
        Edit.Text = "Add new string value"
        Edit.AcceptButton = Edit.OK_Button
        Edit.ValueNameTextBox.ReadOnly = False
        Edit.Show()
    End Sub
    Private Sub LV_NewDWORD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_NewDWORD.Click
        Edit.Text = "Add new DWORD value"
        Edit.AcceptButton = Edit.OK_Button
        Edit.ValueNameTextBox.ReadOnly = False
        Edit.Show()
    End Sub
    Private Sub LV_NewMultiSZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_NewMultiSZ.Click
        With Edit
            .Text = "Add new multi string value"
            .AcceptButton = Nothing
            .ValueNameTextBox.ReadOnly = False
            .Height = 250
            .ValueDataTextBox.Multiline = True
            .ValueDataTextBox.Height = 88
            .ValueDataTextBox.ScrollBars = ScrollBars.Vertical
            .Show()
        End With
    End Sub
    Private Sub LV_NewExpandSZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV_NewExpandSZ.Click
        Edit.Text = "Add new expanded string value"
        Edit.AcceptButton = Edit.OK_Button
        Edit.ValueNameTextBox.ReadOnly = False
        Edit.Show()
    End Sub
    Private Sub MenuNewSZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNewSZ.Click
        Edit.Text = "Add new string value"
        Edit.AcceptButton = Edit.OK_Button
        Edit.ValueNameTextBox.ReadOnly = False
        Edit.Show()
    End Sub
    Private Sub MenuNewDWORD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNewDWORD.Click
        Edit.Text = "Add new DWORD value"
        Edit.AcceptButton = Edit.OK_Button
        Edit.ValueNameTextBox.ReadOnly = False
        Edit.Show()
    End Sub
    Private Sub MenuNewMultiSZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNewMultiSZ.Click
        With Edit
            .Text = "Add new multi string value"
            .AcceptButton = Nothing
            .ValueNameTextBox.ReadOnly = False
            .Height = 250
            .ValueDataTextBox.Multiline = True
            .ValueDataTextBox.Height = 88
            .ValueDataTextBox.ScrollBars = ScrollBars.Vertical
            .Show()
        End With
    End Sub
    Private Sub MenuNewExpandSZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuNewExpandSZ.Click
        Edit.Text = "Add new expanded string value"
        Edit.AcceptButton = Edit.OK_Button
        Edit.ValueNameTextBox.ReadOnly = False
        Edit.Show()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub


    '' Get the tree node under the mouse pointer and
    '' save it in the mySelectedNode variable. 
    'Private Sub treeView1_MouseDown(ByVal sender As Object, _
    'ByVal e As System.Windows.Forms.MouseEventArgs)
    '    mySelectedNode = TreeView1.GetNodeAt(e.X, e.Y)
    'End Sub

    'Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If Not (mySelectedNode Is Nothing) And _
    '      Not (mySelectedNode.Parent Is Nothing) Then
    '        treeView1.SelectedNode = mySelectedNode
    '        treeView1.LabelEdit = True
    '        If Not mySelectedNode.IsEditing Then
    '            mySelectedNode.BeginEdit()
    '        End If
    '    Else
    '        MessageBox.Show("No tree node selected or selected node is a root node." & _
    '          Microsoft.VisualBasic.ControlChars.Cr & _
    '          "Editing of root nodes is not allowed.", "Invalid selection")
    '    End If
    'End Sub


    ' Tool Strip Menu
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        If Edit.Visible = True Then
            MsgBox("Please close edit window first")
            Edit.ShowInTaskbar = True
        Else
            Me.Close()
        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        TreeView1.Nodes.Clear()
        ListView1.Items.Clear()
    End Sub
    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If Not TreeView1.Font.SizeInPoints > 13 Then
            Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", Me.TreeView1.Font.SizeInPoints + 1)
            Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", Me.ListView1.Font.SizeInPoints + 1)
        End If
    End Sub
    Private Sub FontToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem1.Click
        If Not TreeView1.Font.SizeInPoints < 4 Then
            Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", Me.TreeView1.Font.SizeInPoints - 1)
            Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", Me.ListView1.Font.SizeInPoints - 1)
        End If
    End Sub
    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        MsgBox("FFS...")
    End Sub

    Private Function Pings(ByVal strComputer As String) As Boolean

        If strComputer = "" Then
            Return False
            Exit Function
        End If

        Dim p As System.Net.NetworkInformation.Ping
        Dim pReply As System.Net.NetworkInformation.PingReply
        Dim pStatus As String

        Try
            p = New System.Net.NetworkInformation.Ping
            pReply = p.Send(strComputer)
            pStatus = pReply.Status.ToString
        Catch pEx As System.Net.NetworkInformation.PingException
            Return False
            Exit Function
        End Try

        If pStatus = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Function Read_CMD(ByVal command As String) As String
        ' reg query "\\server\HKLM\Software\Microsoft\Windows NT\CurrentVersion" /v LicenseInfo
        ' line 5:
        '     LicenseInfo	REG_BINARY	9E84AE29DB44CD6DD3AC....
        Dim output As String
        Dim pi As New System.Diagnostics.ProcessStartInfo(command)
        pi.RedirectStandardOutput = True
        pi.CreateNoWindow = True
        pi.UseShellExecute = False
        Dim p As Process = Process.Start(pi)
        output = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        Return output
    End Function

    Private Sub ExportRegKey()

        ' Prompt for filename to Save as
        Dim myregfile As String
        SaveRegFileDialog.Title = "Export registry File"
        SaveRegFileDialog.ShowDialog()
        If SaveRegFileDialog.FileName <> "" Then
            myregfile = SaveRegFileDialog.FileName
        Else
            Exit Sub
        End If

        Dim Hive As String = String.Empty
        Dim nHive As String = String.Empty
        Select Case sHive
            Case Microsoft.Win32.RegistryHive.LocalMachine
                Hive = "\HKLM\"
                nHive = "HKEY_LOCAL_MACHINE"
            Case Microsoft.Win32.RegistryHive.Users
                Hive = "\HKU\"
                nHive = "HKEY_USERS"
        End Select

        ' Reg Copy \\computer\HKEY\KeyPath HKEY\TempKeyPath
        Shell("reg copy \\" & sComputerName & Hive & sRegistryKey & _
           " HKLM\Software\kTmp /s /f", 0, True)

        ' Reg Export HKEY\TempKeyPath filename.reg
        Dim sTempFileName As String = "C:\kTmp.log" 'System.IO.Path.GetTempFileName
        Shell("reg export HKLM\Software\kTmp " & sTempFileName, 0, True)

        ' Delete TempKeyPath
        Shell("reg delete HKLM\Software\kTmp /f", 0, True)

        ' Edit Reg File for correct path
        Dim oRead As IO.StreamReader = New IO.StreamReader(sTempFileName)
        Dim oWrite As IO.StreamWriter = New IO.StreamWriter(myregfile)
        Dim LineLen As Integer = 0
        Dim sline As String

        Do While Not oRead.EndOfStream
            sline = oRead.ReadLine()
            If InStr(UCase(sline), "[HKEY_LOCAL_MACHINE\SOFTWARE\KTMP", CompareMethod.Text) Then
                LineLen = sline.Length
                sline = "[" & nHive & "\" & sRegistryKey & Mid(sline, 34, LineLen)
            End If
            oWrite.WriteLine(sline)
        Loop
        oRead.Close()
        System.IO.File.Delete(sTempFileName)
        oWrite.Close()

    End Sub
    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        ExportRegKey()
    End Sub
    Private Sub ExportMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportMenuItem.Click
        ExportRegKey()
    End Sub

End Class
