Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayNotificationSound()
        'Me.Location = New Point(Form1.Right, Form1.Top)
    End Sub
    Private Sub PlayNotificationSound()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.BG, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub
End Class