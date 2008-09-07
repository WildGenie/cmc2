Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class Edit

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        EditAction()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub EditAction()

        Dim Reg As Microsoft.Win32.RegistryKey
        Dim RegHive As Microsoft.Win32.RegistryHive = RegForm.sHive
        Dim sKeyPath As String = RegForm.sRegistryKey
        Dim sComputer As String = RegForm.sComputerName
        Reg = RegistryKey.OpenRemoteBaseKey(RegHive, sComputer).OpenSubKey(sKeyPath, True)

        ' http://msdn2.microsoft.com/en-us/library/microsoft.win32.registryvaluekind(VS.80).aspx
        ' Reg.SetValue("DWordValue", 42, RegistryValueKind.DWord)
        ' Reg.SetValue("MultipleStringValue", New String() {"One", "Two", "Three"}, RegistryValueKind.MultiString)
        ' Reg.SetValue("BinaryValue", New Byte() {10, 43, 44, 45, 14, 255}, RegistryValueKind.Binary)
        ' Reg.SetValue("StringValue", "The path is %PATH%", RegistryValueKind.String)

        Select Case Me.Text
            Case "Edit String"
                Dim ValName As String = ValueNameTextBox.Text
                If LCase(ValName) = "(default)" Then ValName = ""
                Reg.SetValue(ValueNameTextBox.Text, ValueDataTextBox.Text, RegistryValueKind.String)
            Case "Edit DWORD"
                Dim sVal As Int32 = CType(ValueDataTextBox.Text, Int32)
                Reg.SetValue(ValueNameTextBox.Text, sVal, RegistryValueKind.DWord)
            Case "Edit Multi String"
                Dim aVal() As String = Split(ValueDataTextBox.Text, vbNewLine)
                Reg.SetValue(ValueNameTextBox.Text, aVal, RegistryValueKind.MultiString)
            Case "Edit Expanded String"
                Reg.SetValue(ValueNameTextBox.Text, ValueDataTextBox.Text, RegistryValueKind.ExpandString)

            Case "Add new string value"
                Dim ValName As String = ValueNameTextBox.Text
                If LCase(ValName) = "(default)" Then ValName = ""
                Reg.SetValue(ValueNameTextBox.Text, ValueDataTextBox.Text, RegistryValueKind.String)
            Case "Add new DWORD value"
                Dim sVal As Int32 = CType(ValueDataTextBox.Text, Int32)
                Reg.SetValue(ValueNameTextBox.Text, sVal, RegistryValueKind.DWord)
            Case "Add new multi string value"
                Dim aVal() As String = Split(ValueDataTextBox.Text, vbNewLine)
                Reg.SetValue(ValueNameTextBox.Text, aVal, RegistryValueKind.MultiString)
            Case "Add new expanded string value"
                Reg.SetValue(ValueNameTextBox.Text, ValueDataTextBox.Text, RegistryValueKind.ExpandString)
        End Select

        RegForm.FillNodeValues()

    End Sub

End Class
