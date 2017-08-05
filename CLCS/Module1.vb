Module Module1
    Public Web As New System.Net.WebClient
    Dim cmd() As String = Split(Replace(Command, """", ""))
    Sub Main()


        Dim needFilename = IO.Path.GetFileName(cmd(0))
        Dim outFilename = IO.Path.GetFileName(cmd(1))
        Dim SingerName = IO.Directory.GetParent(IO.Path.GetDirectoryName(cmd(0)))

        Console.WriteLine(GetWav(needFilename))
        Console.WriteLine("LCM PROJECT")
        Console.WriteLine("CLCS V0.1")
        Dim p = New Process()
        Dim info = New ProcessStartInfo()
        info.FileName = My.Application.Info.DirectoryPath & "\moresampler.exe"
        info.Arguments = Command()
        'info.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo = info
        p.Start()
        p.WaitForExit()
        IO.File.Delete(cmd(0))
        'Shell(My.Application.Info.DirectoryPath & "\moresampler.exe " & Command())
    End Sub

    Public Function GetWav(Filename As String) As String

        Try
            Web.DownloadFile("http://omypsz3w4.bkt.clouddn.com/Source/Wav/" & Filename, cmd(0))
            GetWav = Filename & " Loaded."
        Catch ex As Exception
            GetWav = Filename & " Failed to load."
        End Try

    End Function
End Module
