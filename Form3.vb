Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        ' 计算窗口位置：右下角
        Dim formWidth As Integer = Me.Width
        Dim formHeight As Integer = Me.Height

        Dim newX As Integer = screenWidth - formWidth
        Dim newY As Integer = screenHeight - formHeight

        ' 设置窗口位置
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(newX, newY)
    End Sub

    Private Sub Label3_DoubleClick(sender As Object, e As EventArgs) Handles Label3.DoubleClick
        Me.Close()
    End Sub
End Class