Imports System.Runtime.InteropServices

Public Class WinAPI_Window

    <DllImport("user32.dll", EntryPoint:="FindWindow", SetLastError:=True, _
        CharSet:=CharSet.Auto)> _
        Public Shared Function FindWindowByCaption(ByVal zero As IntPtr, _
        ByVal lpWindowName As String) As IntPtr
    End Function

    Declare Function SetForegroundWindow Lib "user32.dll" _
    (ByVal hwnd As IntPtr) As Long

End Class
