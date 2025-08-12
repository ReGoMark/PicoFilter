Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayNotificationSound()
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
            topButton.ImageIndex = 1

        Else
            TopMost = False
            topButton.ImageIndex = 0
        End If
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.CenterToScreen()
    End Sub

    Private Sub Label16_MouseHover(sender As Object, e As EventArgs) Handles Label16.MouseHover
        ToolTip1.SetToolTip(Label16, Label16.Text)
    End Sub

    Private Sub Label45_MouseHover(sender As Object, e As EventArgs) Handles Label45.MouseHover
        ToolTip1.SetToolTip(Label45, Label45.Text)
    End Sub
End Class