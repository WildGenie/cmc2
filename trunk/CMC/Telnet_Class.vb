Imports System.Net.Sockets
Imports System.Text

Public Class Telnet_Class
    Private oTCPStream As Net.Sockets.NetworkStream
    Private oTCP As New Net.Sockets.TcpClient()
    Private bytWriting As [Byte]()
    Private bytReading As Byte()


    Public Sub Connect(ByVal server As String, ByVal port As String, ByVal username As String, ByVal password As String)
        Try
            Dim str As String
            str = ""
            oTCP.SendTimeout = 1500
            oTCP.Connect(server, port)
            oTCPStream = oTCP.GetStream
            str = str & ReadData() & vbCrLf
            WriteData(username & vbCrLf)
            System.Threading.Thread.Sleep(500)
            str = str & ReadData() & vbCrLf
            WriteData(password & vbCrLf)
            System.Threading.Thread.Sleep(1000)
            str = str & ReadData() & vbCrLf
            WriteData("1" & vbCrLf)
            str = str & ReadData() & vbCrLf
            oTCPStream.Close()
            oTCP.Close()
            MsgBox("connection ok" & vbCrLf & str)
        Catch Err As Exception
            MsgBox(Err.ToString)
        End Try
    End Sub

    Private Function ReadData() As String
        Dim sData As String
        ReDim bytReading(oTCP.ReceiveBufferSize)
        oTCPStream.Read(bytReading, 0, oTCP.ReceiveBufferSize)
        sData = Trim(System.Text.Encoding.ASCII.GetString(bytReading))
        ReadData = sData
    End Function

    Private Sub WriteData(ByVal sData As String)
        bytWriting = System.Text.Encoding.ASCII.GetBytes(sData)
        oTCPStream.Write(bytWriting, 0, bytWriting.Length)
    End Sub
End Class
