Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentUser As String = Environment.UserName
        Label7.Text = "授权给：" & currentUser
        TextBox1.SelectionStart = 0
        TextBox1.SelectionLength = 0 ' 确保未选中文本
        PlayNotificationSound()
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    'Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
    '    Dim url As String = "https://github.com/MoonPixelTeam/Mp-PicoFilter"
    '    Try
    '        ' 使用默认浏览器打开网页
    '        Process.Start(url)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub PlayNotificationSound()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.BG, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub
End Class