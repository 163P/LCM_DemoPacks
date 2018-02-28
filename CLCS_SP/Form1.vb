Imports System.IO
Imports System.Text
Imports IniLib
Imports System.IO.Compression
Imports ICSharpCode.SharpZipLib.Zip
Public Class Form1
    Dim Web As New System.Net.WebClient
    Dim InfoFile As IniFile
    Dim Num As Short
    Dim sr As StreamReader
    Dim InfoFileURL As String
    Dim fastzip As New FastZip




    Private Async Sub ini_Load()
        Try
            Web.DownloadFile(InfoFileURL, My.Application.Info.DirectoryPath & "\CLCS_SP\CLCS_SP_Info.ini")
            InfoFile = Await IniLib.ReadParser.ReadFileAsync(My.Application.Info.DirectoryPath & "\CLCS_SP\CLCS_SP_Info.ini")
            Num = InfoFile("Info")("SingerNum")

            For i As Short = 0 To Num Step 1
                Web.DownloadFile(InfoFile(i.ToString("000"))("Img"), My.Application.Info.DirectoryPath & "\CLCS_SP\" & i & ".jpg") '下载音源头像
                Web.DownloadFile(InfoFile(i.ToString("000"))("Detail"), My.Application.Info.DirectoryPath & "\CLCS_SP\" & i & ".txt") '下载音源描述文件
                ImageList1.Images.Add(Image.FromFile(My.Application.Info.DirectoryPath & "\CLCS_SP\" & i & ".jpg"))
                ImageList2.Images.Add(Image.FromFile(My.Application.Info.DirectoryPath & "\CLCS_SP\" & i & ".jpg")) '添加入ImageList
                ListView1.Items.Add(InfoFile(i.ToString("000"))("Name"), i) '显示歌姬列表                       
            Next
            Label3.Text = "未选择音源"
        Catch ex As Exception
            Label3.Text = "Info加载失败。请检查服务器地址。"
            TextBox2.Enabled = True
            Button2.Enabled = True
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'PictureBox1.Image = ImageList1.Images.Item(ListView1.SelectedItems.Item(0).Index) '加载大图
        'NameLabel.Text = InfoFile(ListView1.SelectedItems.Item(0).Index.ToString("000"))("Name") '加载歌手名
        'Label1.Text = InfoFile(ListView1.SelectedItems.Item(0).Index.ToString("000"))("Pulisher") '加载出品方

        'sr = New StreamReader(My.Application.Info.DirectoryPath & "\CLCS_SP\" & ListView1.SelectedItems.Item(0).Index & ".txt", Encoding.GetEncoding("gb2312"))
        'TextBox1.Text = sr.ReadToEnd '加载简介
        'sr.Close()
        'sr.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = "正在部署"
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\voice\" & InfoFile(ListView1.SelectedItems.Item(0).Index.ToString("000"))("DirName")) = True Then
            If MessageBox.Show(Me, "音源已经存在。要覆盖安装吗？", "音源已存在", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Kill(My.Application.Info.DirectoryPath & "\voice\" & InfoFile(ListView1.SelectedItems.Item(0).Index.ToString("000"))("DirName") & "\*.*")
                Web.DownloadFile(InfoFile(ListView1.SelectedItems.Item(0).Index.ToString("000"))("zipLink"), My.Application.Info.DirectoryPath & "\CLCS_SP\" & ListView1.SelectedItems.Item(0).Index & ".zip")
                fastzip.ExtractZip(My.Application.Info.DirectoryPath & "\CLCS_SP\" & ListView1.SelectedItems.Item(0).Index & ".zip", My.Application.Info.DirectoryPath & "\voice\", "")
                Label3.Text = "部署完毕"
                Exit Sub
            Else
                Label3.Text = "部署完毕"
                Exit Sub
            End If
        End If

        Web.DownloadFile(InfoFile(ListView1.SelectedItems.Item(0).Index.ToString("000"))("zipLink"), My.Application.Info.DirectoryPath & "\CLCS_SP\" & ListView1.SelectedItems.Item(0).Index & ".zip")

        fastzip.ExtractZip(My.Application.Info.DirectoryPath & "\CLCS_SP\" & ListView1.SelectedItems.Item(0).Index & ".zip", My.Application.Info.DirectoryPath & "\voice\", "")
        Label3.Text = "部署完毕"
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        Button1.Enabled = True
        PictureBox1.Image = ImageList2.Images.Item(e.ItemIndex) '加载大图
        NameLabel.Text = InfoFile(e.ItemIndex.ToString("000"))("Name") '加载歌手名
        Label1.Text = InfoFile(e.ItemIndex.ToString("000"))("Pulisher") '加载出品方

        sr = New StreamReader(My.Application.Info.DirectoryPath & "\CLCS_SP\" & e.ItemIndex & ".txt", Encoding.GetEncoding("gb2312"))
        TextBox1.Text = sr.ReadToEnd '加载简介
        sr.Close()
        sr.Dispose()
        Label3.Text = "部署就绪"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InfoFileURL = TextBox2.Text & "?" & New Random().Next(1, 1000)
        TextBox2.Enabled = False
        Button2.Enabled = False

        ini_Load()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.Directory.Exists(My.Application.Info.DirectoryPath & "\CLCS_SP\") = False Then
            IO.Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\CLCS_SP\")
        Else
            Kill(My.Application.Info.DirectoryPath & "\CLCS_SP\*.*")
        End If
    End Sub
End Class
