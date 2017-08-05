Public Class Class1

    Structure Info
        Dim SingerName As String
        Dim DllVersion As Integer
    End Structure

    Public Web As New System.Net.WebClient

    Public Function GetInfo() As Info
        GetInfo.SingerName = "lcm-project-sample-163"
        GetInfo.DllVersion = My.Application.Info.Version.Build
    End Function

    Public Function GetWav(Filename As String) As String

        Try
            Web.DownloadFile("http://omypsz3w4.bkt.clouddn.com/Source/Wav/" & Filename, My.Application.Info.DirectoryPath & Filename)
            GetWav = Filename & "Loaded."
        Catch ex As Exception
            GetWav = Filename & "Failed to load."
        End Try

    End Function

End Class
