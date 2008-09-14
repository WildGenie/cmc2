Public Class FmGroupMembers

    Protected Friend GroupName As String

    Private Sub MembersListView_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MembersListView.MouseDoubleClick
        If ADmgmt.UserList.Count = 1 Then
            If Me.MembersListView.SelectedItems(0).ImageIndex = 0 Then ' a user has been double clicked.
                ADmgmt.UserTabs_Clear()
                ADmgmt.GetUserDetails(ADmgmt.UserList.Item(0))
                ADmgmt.btnSave.Enabled = False
            ElseIf Me.MembersListView.SelectedItems(0).ImageIndex = 1 Then ' a group has been double clicked
                Me.MembersListView.Items.Clear()

                Me.GroupName = ADmgmt.UserList.Item(0)
                Me.Text = Me.GroupName
                Me.MembersListView.Items.Clear()
                ADmgmt.GroupMembers(Me.GroupName, Me.MembersListView)
            End If
        End If
    End Sub

    Private Sub MembersListView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MembersListView.SelectedIndexChanged

        ADmgmt.UserList = New ArrayList
        If Me.MembersListView.SelectedItems.Count = 0 Then Return
        For Each member As ListViewItem In Me.MembersListView.SelectedItems
            ADmgmt.UserList.Add(member.SubItems(0).Text)
        Next
        ADmgmt.UserList.Sort()

        If ADmgmt.UserList.Count = 0 Then
            'Me.MemberRemoveMenu.Enabled = False
            Me.ButtonRemove.Enabled = False
        ElseIf ADmgmt.UserList.Count = 1 Then
            If Me.MembersListView.SelectedItems(0).ImageIndex = 0 Then
                ' "user"
                'Me.MemberRemoveMenu.Text = "Remove user..."
            Else
                ' "group"
                ' Me.MemberRemoveMenu.Text = "Remove sub group..."
            End If
            'Me.MemberRemoveMenu.Enabled = True
            Me.ButtonRemove.Enabled = True
        ElseIf ADmgmt.UserList.Count > 1 Then
            'Me.MemberRemoveMenu.Text = "Remove members..."
            'Me.MemberRemoveMenu.Enabled = True
            Me.ButtonRemove.Enabled = True
        End If

    End Sub



    ' Add user to group
    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        'Me.Hide()
        ADmgmt.AddUserCall()
    End Sub

    ' Remove member from group
    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRemove.Click
        'Me.Hide()
        ADmgmt.RemoveUserCall()
    End Sub

    ' Export
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExport.Click
        Dim filepath As String = "c:\" & Me.GroupName & ".tsv"
        Dim exportFile As New System.IO.StreamWriter(filepath, False)

        If Me.MembersListView.Items.Count > 0 Then
            exportFile.WriteLine("Logon Name, Display Name, Email")
            exportFile.WriteLine("")
            For Each member As ListViewItem In Me.MembersListView.Items
                exportFile.WriteLine(member.SubItems(0).Text & vbTab & member.SubItems(1).Text & vbTab & member.SubItems(2).Text)
            Next
            exportFile.Close()
            Shell("notepad " & filepath)
        End If
    End Sub

    Private Sub Close_Form(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        Me.Hide()
    End Sub




#Region "ListView Sorting"

    ' The listview column currently used for sorting.
    Private m_SortingColumn As ColumnHeader

    ' Sort using the clicked column.
    Private Sub ListView_ColumnSort(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles MembersListView.ColumnClick
        ' Get the new sorting column.
        Dim new_sorting_column As ColumnHeader = MembersListView.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text = _
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        MembersListView.ListViewItemSorter = New _
            ListViewComparer(e.Column, sort_order)

        ' Sort.
        MembersListView.Sort()
    End Sub

#End Region




    Private Sub FmGroupMembers_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' 170,280,...
        If Me.Width > 550 Then
            Me.memberEmail.Width = 280
        Else
            Me.memberEmail.Width = 0
        End If
    End Sub
End Class