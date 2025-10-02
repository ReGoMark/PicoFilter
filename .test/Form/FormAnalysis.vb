Public Class FormAnalysis
    Private IsMouseOverTab As Boolean = False

    Private Sub FormAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormAna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UiComboBox1.SelectedIndex = 0
        TabAnalysis.SelectedIndex = 0
        SetDblBuff(TabAnalysis)
        SetDblBuff(UiDoughnutChart1)
    End Sub

    Private Sub UiComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiComboBox1.SelectedIndexChanged
        Form1.DrawChart()
    End Sub

    Private Sub UiTabControl1_MouseEnter(sender As Object, e As EventArgs) Handles TabAnalysis.MouseEnter
        IsMouseOverTab = True
    End Sub

    Private Sub UiTabControl1_MouseLeave(sender As Object, e As EventArgs) Handles TabAnalysis.MouseLeave
        IsMouseOverTab = False
    End Sub

    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        MyBase.OnMouseWheel(e)

        ' 只有当鼠标在 TabControl 区域内时才处理滚轮事件
        If IsMouseOverTab Then
            Dim currentIndex As Integer = TabAnalysis.SelectedIndex

            ' 根据滚轮方向切换标签页
            If e.Delta < 0 Then ' 滚轮向下，往右切换
                If currentIndex < TabAnalysis.TabCount - 1 Then
                    TabAnalysis.SelectedIndex = currentIndex + 1
                End If
            Else ' 滚轮向上，往左切换
                If currentIndex > 0 Then
                    TabAnalysis.SelectedIndex = currentIndex - 1
                End If
            End If
        End If
    End Sub

End Class