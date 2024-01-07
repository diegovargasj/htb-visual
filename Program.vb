Imports System

Module Program
    Sub Main(args As String())
        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString("http://10.10.14.174:8000")
    End Sub
End Module
