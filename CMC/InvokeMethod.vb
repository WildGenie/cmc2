Imports System
Imports System.Management

' This sample demonstrates invoking a WMI method using an array of arguments.
Class InvokeMethod
    Public Overloads Shared Function Main(ByVal args() As String) As Integer

        ' Get the object on which the method will be invoked
        Dim processClass As New ManagementClass("Win32_Process")

        ' Create an array containing all arguments for the method
        Dim methodArgs() As Object = {"notepad.exe", Nothing, Nothing, 0}

        ' Execute the method
        Dim result As Object = processClass.InvokeMethod("Create", methodArgs)

        ' Display results
        Console.WriteLine("Creation of process returned: {0}", result)
        Console.WriteLine("Process id: {0}", methodArgs(3))
        Return 0
    End Function
End Class

