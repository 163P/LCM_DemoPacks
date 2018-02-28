
Imports System.IO
Imports System.Net

Module Module1

    Dim cmd() As String = Split(Replace(Command, """", ""))

    Sub Main()


        Dim needFilename = IO.Path.GetFileName(cmd(0))
        Dim outFilename = IO.Path.GetFileName(cmd(1))
        Dim SingerName = IO.Directory.GetParent(IO.Path.GetDirectoryName(cmd(0)))



        Console.WriteLine("CLCS V0.2 By Mukaiteh")
        Console.WriteLine("Built For DFZZ_Blossom&moresampler")
        Console.WriteLine("LCM PROJECT")
        Console.WriteLine(GetWav(needFilename))

        Dim p = New Process()
        Dim info = New ProcessStartInfo()
        info.FileName = My.Application.Info.DirectoryPath & "\resampler_CLCS.exe"
        info.Arguments = Command()
        ' info.WindowStyle = ProcessWindowStyle.Hidden
        info.RedirectStandardOutput = True
        info.CreateNoWindow = False
        info.UseShellExecute = False
        p.StartInfo = info
        p.EnableRaisingEvents = True

        p.Start()

        Console.WriteLine("resampler:")

        Console.WriteLine(p.StandardOutput.ReadToEnd())

        'p.WaitForExit()
        'IO.File.Delete(cmd(0))  不再删除下载下来的音源文件
        'Shell(My.Application.Info.DirectoryPath & "\moresampler.exe " & Command())
    End Sub

    Public Function GetWav(Filename As String) As String
        '东方栀子波深：p4nlfxgtd.bkt.clouddn.com/
        'Lime：p4gke73y1.bkt.clouddn.com/
        Dim WebDir As String = "http://p4nlfxgtd.bkt.clouddn.com/" '根目录，如 http://omypsz3w4.bkt.clouddn.com/Source/Wav/

        If IO.File.Exists(cmd(0)) = True Then '如果已经存在该文件
            GetWav = Filename & " Loaded."
        Else
            Try
                Dim Web As New System.Net.WebClient

                Web.DownloadFile(WebDir & Filename, cmd(0))


                '   Dim request As HttpWebRequest = WebRequest.Create(WebDir & Filename)
                '     request.Method = "GET"
                '           Dim sr As BinaryReader = New BinaryReader(myFile)
                '      SaveBinaryFile
                '           Dim fs As New IO.BinaryWriter(request.GetResponse().GetResponseStream)
                '           fs.Write(request.GetResponse().GetResponseStream)
                '
                '      Dim iHandle As IntPtr

                '     Dim lps As SECURITY_ATTRIBUTES

                '      iHandle = CreateFile(cmd(0), GENERIC_WRITE, 0, lps, 1, 256, 0)


                'Dim file As New IO.UnmanagedMemoryStream(,,)
                ' Dim by = Web.DownloadData(WebDir & Filename)
                '     file.Write(by, 0, by.Length)
                ' Dim i As Short
                '   WriteFile(iHandle, by, by.Length, i, 0)
                '        CloseHandle(iHandle)
                'Web.DownloadFile(WebDir & IO.Path.GetFileNameWithoutExtension(cmd(0)) & ".frq", IO.Path.ChangeExtension(cmd(0), ".frq"))
                GetWav = Filename & " Loaded."

            Catch ex As Exception
                GetWav = Filename & " Failed to load.Please check your input and the version of oto.ini."
            End Try
        End If
    End Function
End Module
