Public Class Form2

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim url As String = "https://github.com/ReGoMark/PicoFilter"
        Try
            ' 使用默认浏览器打开网页
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub PlayNotificationSound()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.INFO, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Process1.StartInfo.UseShellExecute = True
        Process1.StartInfo.FileName = Application.StartupPath & "\tutorial.mp4"

        '' 显示文件路径以便调试
        'MessageBox.Show("尝试打开文件: " & Process1.StartInfo.FileName)

        Try
            Process1.Start()
        Catch ex As Exception
            MessageBox.Show("无法打开视频教程，请检查文件是否存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Try
            Clipboard.SetText("regmvks@outlook.com")
            MessageBox.Show("邮箱regmvks@outlook.com已复制到剪切板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("复制邮箱失败，请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)
        Dim url As String = "https://baike.baidu.com/item/%E6%84%BF%E4%BD%A0%E5%86%B3%E5%AE%9A/7483097"
        Try
            ' 使用默认浏览器打开网页
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        Dim url As String = "https://www.foundertype.com/index.php/About/powerAllowPro.html#:~:text=%E6%9C%AC%E3%80%8A%E6%96%B9%E6%AD%A3%E5%AD%97%E5%BA%93%E7%9F%A5%E8%AF%86%E4%BA%A7%E6%9D%83%E7%94%A8%E6%88%B7%E8%AE%B8%E5%8F%AF%E5%8D%8F%E8%AE%AE%E3%80%8B%EF%BC%88%E4%BB%A5%E4%B8%8B%E7%AE%80%E7%A7%B0%E2%80%9C%E5%8D%8F%E8%AE%AE%E2%80%9D%EF%BC%89%E6%98%AF%E6%82%A8%E4%B8%8E%E5%8C%97%E4%BA%AC%E5%8C%97%E5%A4%A7%E6%96%B9%E6%AD%A3%E7%94%B5%E5%AD%90%E6%9C%89%E9%99%90%E5%85%AC%E5%8F%B8%EF%BC%88%E4%BB%A5%E4%B8%8B%E7%AE%80%E7%A7%B0%E2%80%9C%E6%96%B9%E6%AD%A3%E7%94%B5%E5%AD%90%E5%85%AC%E5%8F%B8%E2%80%9D%EF%BC%89%E4%B9%8B%E9%97%B4%E6%9C%89%E5%85%B3%E5%AE%89%E8%A3%85%E3%80%81%E4%BD%BF%E7%94%A8%E6%9C%AC%E5%8D%8F%E8%AE%AE%E9%99%84%E9%9A%8F%E7%9A%84%E2%80%9C%E6%96%B9%E6%AD%A3%E5%AD%97%E5%BA%93%E2%80%9D%EF%BC%88%E4%BB%A5%E4%B8%8B%E7%AE%80%E7%A7%B0%E2%80%9C%E5%AD%97%E5%BA%93%E8%BD%AF%E4%BB%B6%E2%80%9D%EF%BC%89%E7%9A%84%E6%B3%95%E5%BE%8B%E5%8D%8F%E8%AE%AE%E3%80%82,%E6%82%A8%E5%9C%A8%E4%BD%BF%E7%94%A8%E6%9C%AC%E2%80%9C%E5%AD%97%E5%BA%93%E8%BD%AF%E4%BB%B6%E2%80%9D%E7%9A%84%E6%89%80%E6%9C%89%E6%88%96%E4%BB%BB%E4%BD%95%E9%83%A8%E5%88%86%E5%89%8D%EF%BC%8C%E5%BA%94%E6%8E%A5%E5%8F%97%E6%9C%AC%E5%8D%8F%E8%AE%AE%E4%B8%AD%E8%A7%84%E5%AE%9A%E7%9A%84%E6%89%80%E6%9C%89%E6%9D%A1%E6%AC%BE%E5%92%8C%E6%9D%A1%E4%BB%B6%EF%BC%8C%E7%89%B9%E5%88%AB%E6%98%AF%E5%85%B6%E4%B8%AD%E5%AF%B9%E4%B8%8B%E5%88%97%E5%86%85%E5%AE%B9%E7%9A%84%E8%A7%84%E5%AE%9A%EF%BC%9A%EF%BC%88a%EF%BC%89%E4%BD%BF%E7%94%A8%EF%BC%88%E7%AC%AC3%E3%80%814%20%E9%83%A8%E5%88%86%EF%BC%89%EF%BC%9B%EF%BC%88b%EF%BC%89%E7%9F%A5%E8%AF%86%E4%BA%A7%E6%9D%83%EF%BC%88%E7%AC%AC5%E9%83%A8%E5%88%86%EF%BC%89%EF%BC%9B%EF%BC%88c%EF%BC%89%E4%BF%9D%E8%AF%81%EF%BC%88%E7%AC%AC6%E9%83%A8%E5%88%86%EF%BC%89%E5%8F%8A%E8%B4%A3%E4%BB%BB%EF%BC%88%E7%AC%AC7%E9%83%A8%E5%88%86%EF%BC%89%E3%80%82"
        Try
            ' 使用默认浏览器打开网页
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedTab = MetroTabControl1.TabPages(0)
    End Sub
End Class