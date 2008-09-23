
Imports System
Imports Microsoft.Win32

Public Class FileAssoc

' http://vbcity.com/forums/topic.asp?tid=72502

Public Sub SetFileType(ByVal extension As String, ByVal FileType As String)
        Dim rk As RegistryKey = Registry.ClassesRoot
        Dim ext As RegistryKey = rk.CreateSubKey(extension)
        ext.SetValue("", FileType)
End Sub

Public Sub SetFileDescription(ByVal FileType As String, ByVal Description As String)
        Dim rk As RegistryKey = Registry.ClassesRoot
        Dim ext As RegistryKey = rk.CreateSubKey(FileType)
        ext.SetValue("", Description)
End Sub

Public Sub AddAction(ByVal FileType As String, ByVal Verb As String, ByVal ActionDescription As String)
        Dim rk As RegistryKey = Registry.ClassesRoot
        Dim ext As RegistryKey = rk.OpenSubKey(FileType,True).CreateSubKey("Shell").CreateSubKey(Verb)
        ext.SetValue("", ActionDescription)
End Sub

Public Sub SetExtensionCommandLine(ByVal Command As String, ByVal FileType As String, ByVal CommandLine As String, Optional ByVal Name As String = "")
        Dim rk As RegistryKey = Registry.ClassesRoot
        Dim ext As RegistryKey = rk.OpenSubKey(FileType).OpenSubKey("Shell").OpenSubKey(Command, True).CreateSubKey("Command")
        ext.SetValue(Name, CommandLine)
End Sub

Public Sub SetDefaultAction(ByVal FileType As String, ByVal Verb As String)
        Dim rk As RegistryKey = Registry.ClassesRoot
        Dim ext As RegistryKey = rk.OpenSubKey(FileType).OpenSubKey("Shell")
        ext.SetValue("", Verb)
End Sub

Public Sub SetDefaultIcon(ByVal FileType As String, ByVal Icon As String)
        Dim rk As RegistryKey = Registry.ClassesRoot
        Dim ext As RegistryKey = rk.OpenSubKey(FileType)
        ext.SetValue("DefaultIcon", Icon)
End Sub

End Class


'Windows Registry Editor Version 5.00

'[HKEY_CLASSES_ROOT\.pff]
'@="Perfmonitor.Datafile"

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile]
'@="PerfMonitor Data File"
'"EditFlags"=dword:00000000
'"BrowserFlags"=dword:00000008

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\DefaultIcon]
'@="C:\\Program Files\\CMC\\files\\perf.ico,0"

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\shell]
'@="open"

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\shell\open]

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\shell\open\command]
'@="\"c:\\program files\\cmc\\performancegraph.exe\" \"%1\""

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\shell\open\ddeexec]

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\shell\open\ddeexec\Application]
'@="performancegraph"

'[HKEY_CLASSES_ROOT\Perfmonitor.Datafile\shell\open\ddeexec\Topic]
'@="System"

