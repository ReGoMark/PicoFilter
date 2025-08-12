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
        'Try
        '    Clipboard.SetText("regmvks@outlook.com")
        '    MessageBox.Show("邮箱regmvks@outlook.com已复制到剪切板！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        '    MessageBox.Show("复制邮箱失败，请重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Process.Start("mailto:regmvks@outlook.com")
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
        Dim url As String = "https://www.foundertype.com/index.php/About/powerAllowPro.html"
        Try
            ' 使用默认浏览器打开网页
            Process.Start(url)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTabControl1.SelectedTab = MetroTabControl1.TabPages(0)
        Me.ActiveControl = Nothing ' 取消默认控件焦点
        MetroTabControl1.TabPages.Remove(MetroTabPage1)
        PlayNotificationSound()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class