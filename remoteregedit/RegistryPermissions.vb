' This sample demonstrates the IsSubsetOf, Union, Intersect, Copy, ToXml, FromXml
' GetPathList, AddPathList, and SetPathList methods
' of the RegistryPermission class.

Imports System
Imports System.Security
Imports System.Security.Permissions
Imports System.Collections

Public Class RegistryPermission
    Private readPerm1 As New RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0")
    Private readPerm2 As New RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION")
    Private readPerm3 As New RegistryPermission(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\FloatingPointProcessor\0")
    Private createPerm1 As New RegistryPermission(RegistryPermissionAccess.Create, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0")
    Private readPerm4 As IPermission

    ' IsSubsetOf determines whether the current permission is a subset of the specified permission.
    Private Function IsSubsetOfDemo() As Boolean

        Dim returnValue As Boolean = True

        If readPerm1.IsSubsetOf(readPerm2) Then

            Console.WriteLine(readPerm1.GetPathList(RegistryPermissionAccess.Read) + vbLf + " is a subset of " + readPerm2.GetPathList(RegistryPermissionAccess.Read) + vbLf)
        Else
            Console.WriteLine(readPerm1.GetPathList(RegistryPermissionAccess.Read) + vbLf + " is not a subset of " + readPerm2.GetPathList(RegistryPermissionAccess.Read) + vbLf)
        End If
        If createPerm1.IsSubsetOf(readPerm1) Then

            Console.WriteLine("RegistryPermissionAccess.Create" + vbLf + " is a subset of " + "RegistryPermissionAccess.Read" + vbLf)
        Else
            Console.WriteLine("RegistryPermissionAccess.Create" + vbLf + " is not a subset of " + "RegistryPermissionAccess.Read" + vbLf)
        End If

        Return returnValue

    End Function 'IsSubsetOfDemo

    ' Union creates a new permission that is the union of the current permission and
    ' the specified permission.
    Private Function UnionDemo() As Boolean

        Dim returnValue As Boolean = True
        readPerm3 = CType(readPerm1.Union(readPerm2), RegistryPermission)

        If readPerm3 Is Nothing Then
            Console.WriteLine("The union of " + vbLf + readPerm1.GetPathList(RegistryPermissionAccess.Read) + " " + vbLf + "and " + readPerm2.GetPathList(RegistryPermissionAccess.Read) + " is null.")
        Else
            Console.WriteLine("The union of " + vbLf + readPerm1.GetPathList(RegistryPermissionAccess.Read) + " " + vbLf + "and " + readPerm2.GetPathList(RegistryPermissionAccess.Read) + " = " + vbLf + vbTab + CType(readPerm3, RegistryPermission).GetPathList(RegistryPermissionAccess.Read).ToString())
        End If

        Return returnValue

    End Function 'UnionDemo

    ' Intersect creates and returns a new permission that is the intersection of the
    ' current permission and the permission specified.
    Private Function IntersectDemo() As Boolean

        Dim returnValue As Boolean = True

        readPerm3 = CType(readPerm1.Intersect(readPerm2), RegistryPermission)
        If Not (readPerm3 Is Nothing) AndAlso Not (readPerm3.GetPathList(RegistryPermissionAccess.Read) Is Nothing) Then

            Console.WriteLine("The intersection of " + vbLf + readPerm1.GetPathList(RegistryPermissionAccess.Read) + " " + vbLf + "and " + readPerm2.GetPathList(RegistryPermissionAccess.Read) + " = " + vbLf + vbTab + CType(readPerm3, RegistryPermission).GetPathList(RegistryPermissionAccess.Read).ToString())
        Else
            Console.WriteLine("The intersection of " + vbLf + readPerm2.GetPathList(RegistryPermissionAccess.Read) + " " + vbLf + "and " + readPerm2.GetPathList(RegistryPermissionAccess.Read) + " is null. ")
        End If

        Return returnValue

    End Function 'IntersectDemo

    'Copy creates and returns an identical copy of the current permission.
    Private Function CopyDemo() As Boolean

        Dim returnValue As Boolean = True
        readPerm4 = CType(readPerm1.Copy(), RegistryPermission)
        If Not (readPerm4 Is Nothing) Then
            Console.WriteLine("Result of copy = " + readPerm4.ToXml().ToString() + vbLf)
        Else
            Console.WriteLine("Result of copy is null. " + vbLf)
        End If
        Return returnValue

    End Function 'CopyDemo

    ' ToXml creates an XML encoding of the permission and its current state; FromXml
    ' reconstructs a permission with the specified state from the XML encoding.
    Private Function ToFromXmlDemo() As Boolean

        Dim returnValue As Boolean = True
        readPerm2 = New RegistryPermission(PermissionState.None)
        readPerm2.FromXml(readPerm1.ToXml())
        Console.WriteLine("Result of ToFromXml = " + readPerm2.ToString() + vbLf)

        Return returnValue

    End Function 'ToFromXmlDemo

    ' AddPathList adds access for the specified registry variables to the existing state of the permission.
    ' SetPathList sets new access for the specified registry variable names to the existing state of the permission.
    ' GetPathList gets paths for all registry variables with the specified RegistryPermissionAccess.
    Private Function SetGetPathListDemo() As Boolean
        Try
            Console.WriteLine("********************************************************" + vbLf)

            Dim readPerm1 As RegistryPermission
            Console.WriteLine("Creating RegistryPermission with AllAccess rights for 'HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0'")
            readPerm1 = New RegistryPermission(RegistryPermissionAccess.AllAccess, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0")
            Console.WriteLine("Adding 'HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION' to the write access list, " + "and " + vbLf + " 'HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\FloatingPointProcessor\0' " + "to the read access list.")
            readPerm1.AddPathList(RegistryPermissionAccess.Write, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION")
            readPerm1.AddPathList(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\FloatingPointProcessor\0")
            Console.WriteLine("Read access list before SetPathList = " + readPerm1.GetPathList(RegistryPermissionAccess.Read))
            Console.WriteLine("Setting read access rights to " + vbLf + "'HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0'")
            readPerm1.SetPathList(RegistryPermissionAccess.Read, "HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0")
            Console.WriteLine("Read access list after SetPathList = " + vbLf + readPerm1.GetPathList(RegistryPermissionAccess.Read))
            Console.WriteLine("Write access = " + vbLf + readPerm1.GetPathList(RegistryPermissionAccess.Write))
            Console.WriteLine("Write access Registry variables = " + vbLf + readPerm1.GetPathList(RegistryPermissionAccess.AllAccess))
        Catch e As ArgumentException
            ' RegistryPermissionAccess.AllAccess can not be used as a parameter for GetPathList.
            Console.WriteLine("An ArgumentException occured as a result of using AllAccess. " + _
            "AllAccess cannot be used as a parameter in GetPathList because it represents more than one " + _
            "type of registry variable access : " + vbLf + e.Message)
        End Try

        Return True

    End Function 'SetGetPathListDemo

    ' Invoke all demos.
    Public Function RunDemo() As Boolean

        Dim ret As Boolean = True
        Dim retTmp As Boolean
        ' Call IsSubset demo.
        If IsSubsetOfDemo() Then
            Console.Out.WriteLine("IsSubset demo completed successfully.")
        Else
            Console.Out.WriteLine("IsSubset demo failed.")
        End If
        ret = retTmp AndAlso ret

        ' Call the Union demo.
        retTmp = UnionDemo()
        If retTmp Then
            Console.Out.WriteLine("Union demo completed successfully.")
        Else
            Console.Out.WriteLine("Union demo failed.")
        End If
        ret = retTmp AndAlso ret

        ' Call the intersect demo.
        retTmp = UnionDemo()
        If retTmp Then
            Console.Out.WriteLine("Intersect demo completed successfully.")
        Else
            Console.Out.WriteLine("Intersect demo failed.")
        End If
        ret = retTmp AndAlso ret


        ' Call the Copy demo.
        retTmp = CopyDemo()
        If retTmp Then
            Console.Out.WriteLine("Copy demo completed successfully.")
        Else
            Console.Out.WriteLine("Copy demo failed.")
        End If
        ret = retTmp AndAlso ret

        ' Call the ToFromXml demo.
        retTmp = ToFromXmlDemo()
        If retTmp Then
            Console.Out.WriteLine("ToFromXml demo completed successfully.")
        Else
            Console.Out.WriteLine("ToFromXml demo failed.")
        End If
        ret = retTmp AndAlso ret

        ' Call the GetPathList demo.
        retTmp = SetGetPathListDemo()
        If retTmp Then
            Console.Out.WriteLine("SetGetPathList demo completed successfully.")
        Else
            Console.Out.WriteLine("SetGetPathList demo failed.")
        End If
        ret = retTmp AndAlso ret

        Return ret

    End Function 'RunDemo

    ' Test harness.
    Public Shared Sub Main(ByVal args() As String)
        Try
            Dim democase As New RegistryPermissionDemo()
            Dim ret As Boolean = democase.RunDemo()
            If ret Then
                Console.Out.WriteLine("The RegisterPermission demo completed successfully.")
                Console.Out.WriteLine("Press the Enter key to exit.")
                Dim consoleInput As String = Console.ReadLine()
                System.Environment.ExitCode = 100
            Else
                Console.Out.WriteLine("The RegisterPermission demo failed")
                Console.Out.WriteLine("Press the Enter key to exit.")
                Dim consoleInput As String = Console.ReadLine()
                System.Environment.ExitCode = 101
            End If
        Catch e As Exception
            Console.Out.WriteLine("The RegisterPermission demo failed")
            Console.WriteLine(e.ToString())
            Console.Out.WriteLine("Press the Enter key to exit.")
            Dim consoleInput As String = Console.ReadLine()
            System.Environment.ExitCode = 101
        End Try

    End Sub 'Main
End Class 'RegistryPermissionDemo


