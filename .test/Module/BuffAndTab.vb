Module BuffAndTab

    Public Sub SetDblBuff(ctrl As Control)
        Dim t As Type = ctrl.GetType()
        Dim pi = t.GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If pi IsNot Nothing Then
            pi.SetValue(ctrl, True, Nothing)
        End If
    End Sub

    Public Sub HandleMouseWheel(tab As TabControl, e As MouseEventArgs)
        If tab Is Nothing OrElse tab.TabCount = 0 Then Return

        Dim currentIndex As Integer = tab.SelectedIndex
        If e.Delta < 0 Then
            If currentIndex < tab.TabCount - 1 Then
                tab.SelectedIndex += 1
            End If
        Else
            If currentIndex > 0 Then
                tab.SelectedIndex -= 1
            End If
        End If
    End Sub

End Module