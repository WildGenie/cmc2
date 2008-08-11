Imports System
Imports System.Net
Imports System.Net.NetworkInformation

Public Class PingClass

    Public Shared Function TryPing(ByVal strComputer As String) As Boolean

        If strComputer = "" Then
            Return False
            Exit Function
        End If

        Dim p As New Ping
        Dim pReply As PingReply
        Dim pStatus As String

        Try

            pReply = p.Send(strComputer)
            'time = "Reply Time (ms): " & pReply.RoundtripTime.ToString
            pStatus = pReply.Status.ToString

            If pStatus = "Success" Then
                Dim replyAddress As String = pReply.Address.ToString
                If replyAddress.Contains(":") Then
                    Form1.Label_IP.Text = GetIP4Address(replyAddress)
                Else
                    Form1.Label_IP.Text = replyAddress
                End If
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


    Public Shared Function GetIP4Address(ByVal strComputer As String) As String
        Dim IP4Address As String = String.Empty

        For Each IPA As Net.IPAddress In Dns.GetHostAddresses(strComputer)
            If IPA.AddressFamily.ToString() = "InterNetwork" Then
                IP4Address = IPA.ToString()
                Exit For
            End If
        Next

        If IP4Address <> String.Empty Then
            Return IP4Address
        End If

        For Each IPA As IPAddress In Dns.GetHostAddresses(Dns.GetHostName())
            If IPA.AddressFamily.ToString() = "InterNetwork" Then
                IP4Address = IPA.ToString()
                Exit For
            End If
        Next

        Return IP4Address
    End Function

End Class
