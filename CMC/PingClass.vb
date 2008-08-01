Imports System.Net.NetworkInformation

Public Class PingClass

    Public Shared Function TryPing(ByVal strComputer As String) As Boolean

        If strComputer = "" Then
            Return False
            Exit Function
        End If

        Dim p As Ping
        Dim pReply As PingReply
        Dim pStatus As String

        Try
            p = New Ping
            pReply = p.Send(strComputer)
            'lblTime.Text = "Reply Time (ms): " & pReply.RoundtripTime.ToString
            'lblAddress.Text = "Address: " & pReply.Address.AddressFamily.ToString
            pStatus = pReply.Status.ToString
            If pStatus = "Success" Then
                Form1.Label_IP.Text = pReply.Address.ToString
            Else
                Form1.Label_IP.Text = ""
            End If


        Catch pEx As PingException
            Return False
            Exit Function
            'Debug.Write(pEx.InnerException.Message)
        End Try

        If pStatus = "Success" Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function GetIPfromName(ByVal strComputer As String) As String
        If String.IsNullOrEmpty(strComputer) Then
            Return False
            Exit Function
        End If

        Dim p As Ping
        Dim pReply As PingReply
        Dim pStatus As String
        Dim ip As String = ""

        Try
            p = New Ping
            pReply = p.Send(strComputer)
            pStatus = pReply.Status.ToString
            If pStatus = "Success" Then
                ip = pReply.Address.ToString
            End If
        Catch ex As Exception
        End Try
        Return ip
    End Function

End Class
