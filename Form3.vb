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
            My.Computer.Audio.Play(My.Resources.INFO, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub absbButton_CheckStateChanged(sender As Object, e As EventArgs) Handles absbButton.CheckStateChanged
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X + Form1.Width, Form1.Location.Y)
        Else
            'Me.CenterToScreen()
        End If
    End Sub
    Private Sub CheckBox6_CheckStateChanged(sender As Object, e As EventArgs) Handles topButton.CheckStateChanged
        If topButton.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.CenterToScreen()
    End Sub
End Class