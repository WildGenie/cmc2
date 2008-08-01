Imports System.Windows.Forms
Imports System.Xml
' add system.xml reference

Public Class appdeploy

    Private xmlfile As String = My.Application.Info.DirectoryPath & "\App.xml"


    Private Sub appdeploy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_XML_into_Grid()
    End Sub

    ' Read App data for selected item (from datagrid)
    Private Sub appdeploy_load_combo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appdeploy_load_combo.SelectedIndexChanged
        Me.appdeploy_filelist.Items.Clear()
        If AppTable.AppGrid.Rows.Count > 0 Then
            For i As Integer = 0 To AppTable.AppGrid.Rows.Count - 1
                If AppTable.AppGrid(0, i).Value = appdeploy_load_combo.SelectedItem.ToString Then
                    Dim arrfiles() As String = Split(AppTable.AppGrid(1, i).Value, ";")
                    For j As Integer = 0 To arrfiles.Length - 1
                        Me.appdeploy_filelist.Items.Add(arrfiles(j))
                    Next
                    Me.appdeploy_dest.Text = AppTable.AppGrid(2, i).Value
                    Me.appdeploy_cmd.Text = AppTable.AppGrid(3, i).Value
                End If
            Next
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        If Me.Text = "App deploy - Save App" Then
            If Not appdeploy_name.Text = "" Then
                Add_App_To_Grid()
                Save_Grid_to_XML()
                Load_XML_into_Grid()
                Load_App_Combo()
            Else
                MsgBox("You must enter a name.")
            End If
        ElseIf Me.Text = "App deploy - Load App" Then

            ' copy source file list to deploy tab
            Form1.file_folder.Text = ""


            ' copy list contents

            ' count listbox items - 'appdeploy_filelist.Items.count = 1' not working!!!
            Dim count As Integer = 0
            If Me.appdeploy_filelist.Items.Count > 0 Then
                For i As Integer = 0 To Me.appdeploy_filelist.Items.Count - 1
                    If Trim(Me.appdeploy_filelist.Items.Item(i).ToString) <> "" Then
                        count = count + 1
                    End If
                Next
            End If


            ' check for folder, set file/folder checklist, copy items to listbox

            If count = 1 Then
                If Form1.IsFolder(Me.appdeploy_filelist.Items.Item(0)) Then
                    Form1.folder_radio.Checked = True
                    'Form1.Add_File_Folder.Enabled = False
                Else
                    Form1.file_radio.Checked = True
                    Form1.Add_File_Folder.Enabled = True
                End If
                Form1.file_folder.Text = Me.appdeploy_filelist.Items.Item(0)
            Else
                Form1.file_radio.Checked = True
                'Form1.Add_File_Folder.Enabled = False
                For i As Integer = 0 To Me.appdeploy_filelist.Items.Count - 1
                    If Trim(Me.appdeploy_filelist.Items.Item(i).ToString) <> "" Then
                        Form1.file_folder.Text = Form1.file_folder.Text.Insert(0, Me.appdeploy_filelist.Items.Item(i).ToString & ControlChars.NewLine)
                    End If
                Next
            End If



            Form1._to.Text = Replace(Me.appdeploy_dest.Text, "%computername%", pc.Name)
            Form1.installcmd.Text = Me.appdeploy_cmd.Text
            If Trim(Me.appdeploy_cmd.Text) = "" Then
                Form1.installcmd_checkbox.Checked = False
            Else
                Form1.installcmd_checkbox.Checked = True
            End If
            End If
            Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub Load_App_Combo()
        Me.appdeploy_load_combo.Items.Clear()
        load_App_Names()
        Me.appdeploy_load_combo.Text = "Select App..."
        Me.appdeploy_load_combo.Focus()
    End Sub

    ' Read App names into combobox (from datagrid)
    Private Sub load_App_Names()
        If AppTable.AppGrid.Rows.Count > 0 Then
            For i As Integer = 0 To AppTable.AppGrid.Rows.Count - 1
                If Not AppTable.AppGrid(0, i).Value = Nothing Then
                    Me.appdeploy_load_combo.Items.Add(AppTable.AppGrid(0, i).Value)
                End If

            Next
        End If
    End Sub
    ' Open table for editing
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        AppTable.ShowDialog()
        If AppTable.DialogResult = Windows.Forms.DialogResult.OK Then
            Save_Grid_to_XML()
        End If
    End Sub

    Public Sub Save_Grid_to_XML()


        ' Create XML Document to store computer details
        Dim i As Integer
        Dim textWriter As XmlTextWriter = New XmlTextWriter(xmlfile, Nothing)

        textWriter.WriteStartDocument()

        ' Write comments
        textWriter.WriteComment("CMC - App Deploy")
        textWriter.WriteComment("Peter Forman 2007")

        ' Write first element
        textWriter.WriteStartElement("AppList")

        If AppTable.AppGrid.Rows.Count > 0 Then

            For i = 0 To AppTable.AppGrid.RowCount - 1

                Try
                    If AppTable.AppGrid(0, i).Value.ToString <> "" Then
                        textWriter.WriteStartElement("Application")

                        textWriter.WriteStartElement("Name", "")
                        textWriter.WriteString(AppTable.AppGrid(0, i).Value)
                        textWriter.WriteEndElement()

                        textWriter.WriteStartElement("Source", "")
                        textWriter.WriteString(AppTable.AppGrid(1, i).Value)
                        textWriter.WriteEndElement()

                        textWriter.WriteStartElement("Destination", "")
                        textWriter.WriteString(AppTable.AppGrid(2, i).Value)
                        textWriter.WriteEndElement()

                        textWriter.WriteStartElement("Command", "")
                        textWriter.WriteString(AppTable.AppGrid(3, i).Value)
                        textWriter.WriteEndElement()

                        textWriter.WriteEndElement()
                    End If
                Catch ex As Exception
                End Try
            Next
        End If


        textWriter.WriteEndDocument()
        textWriter.Close()


    End Sub

    Public Sub Load_XML_into_Grid()

        If My.Computer.FileSystem.FileExists(xmlfile) Then

            AppTable.AppGrid.Rows.Clear()

            ' open xml doc to load data
            Dim Reader As XmlTextReader = New XmlTextReader(xmlfile)

            Dim _name, _source, _dest, _cmd As String

            While Reader.Read()
                If Reader.NodeType = XmlNodeType.Element Then
                    If Reader.Name = "Application" Then
                        Reader.MoveToAttribute("Name")
                        _name = Reader.ReadElementString
                        Reader.MoveToAttribute("Source")
                        _source = Reader.ReadElementString
                        Reader.MoveToAttribute("Destination")
                        _dest = Reader.ReadElementString
                        Reader.MoveToAttribute("Command")
                        _cmd = Reader.ReadElementString
                        AppTable.AppGrid.Rows.Add(_name, _source, _dest, _cmd)
                    End If
                End If
            End While

            Reader.Close()

        End If

        AppTable.AppGrid.Sort(AppTable.AppGrid.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub Add_App_To_Grid()
        ' Check whether entry exists
        Dim exists As Boolean = False
        If AppTable.AppGrid.Rows.Count > 0 Then
            For i As Integer = 0 To AppTable.AppGrid.Rows.Count - 1
                If LCase(AppTable.AppGrid(0, i).Value) = LCase(appdeploy_name.Text) Then
                    exists = True
                End If
            Next
        End If

        If exists Then
            MsgBox("entry already exists")
            Exit Sub
        End If

        ' add new entry
        If Not appdeploy_name.Text = "" Then

            Dim sourcefiles As String = ""
            If Me.appdeploy_filelist.Items.Count > 0 Then
                For i As Integer = 0 To Me.appdeploy_filelist.Items.Count - 1
                    sourcefiles = sourcefiles & Me.appdeploy_filelist.Items.Item(i).ToString & ";"
                Next
            End If

            AppTable.AppGrid.Rows.Add _
            (appdeploy_name.Text, sourcefiles, appdeploy_dest.Text, appdeploy_cmd.Text)
        End If

    End Sub

End Class

