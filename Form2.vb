Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentUser As String = Environment.UserName
        Label7.Text = "授权给：" & currentUser & "，仅限PAA像素艺术大赛内部，不得用于商业目的。"
    End Sub

    Private Sub Form2_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub
End Class