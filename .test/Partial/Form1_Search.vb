Partial Class Form1

    Private currentIndexLT As Integer = -1
    Private currentIndexRT As Integer = -1
    Private searchResultsLT As New List(Of Integer) '全局状态
    Private searchResultsRT As New List(Of Integer)

    Enum SearchType '搜索枚举
        All
        Index
        FileName
        Format
        eDate
    End Enum

    '全选
    Public Sub AllRslt(listView As ListView,
                       ByRef resultList As List(Of Integer),
                       ByRef currentIndex As Integer)
        If resultList.Count = 0 Then
            MessageBox.Show("没有查找结果。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        listView.SelectedItems.Clear()
        For Each idx In resultList
            listView.Items(idx).Selected = True
        Next
        listView.Focus()
        'MessageBox.Show("已选中所有搜索结果。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return
    End Sub

    '下一个
    Public Sub NextRslt(listView As ListView,
                       ByRef resultList As List(Of Integer),
                       ByRef currentIndex As Integer)

        If resultList.Count = 0 Then
            MessageBox.Show("没有查找结果。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Shift 按下 → 一次性选中全部结果
        If Control.ModifierKeys.HasFlag(Keys.Shift) Then
            listView.SelectedItems.Clear()
            For Each idx In resultList
                listView.Items(idx).Selected = True
            Next
            listView.Focus()
            'MessageBox.Show("已选中所有搜索结果。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        '========== 普通 Next ==========
        Dim startIndex As Integer = -1

        ' 如果当前有选中项，就以它为基准
        If listView.SelectedItems.Count > 0 Then
            startIndex = listView.SelectedItems(0).Index
        End If

        ' 在搜索结果里找“比当前选中项靠后的第一个结果”
        Dim nextResultIdx As Integer = -1
        For Each idx In resultList
            If idx > startIndex Then
                nextResultIdx = idx
                Exit For
            End If
        Next

        ' 如果没找到（说明当前选中项已经在最后面），就循环到第一个结果
        If nextResultIdx = -1 Then
            MessageBox.Show("已是最后一项，返回第一项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            nextResultIdx = resultList(0)
        End If

        ' 更新 currentIndex（保持和新逻辑一致）
        currentIndex = resultList.IndexOf(nextResultIdx)

        ' 选中并滚动到目标项
        HighlightItem(listView, nextResultIdx)
    End Sub

    '工具函数
    Private Sub ClearHighlights(listView As ListView)
        For Each it As ListViewItem In listView.Items
            it.BackColor = listView.BackColor   '用控件原色，避免主题下是纯白
        Next
    End Sub

    '高亮显示
    Private Sub HighlightItem(listView As ListView, idx As Integer)
        If idx < 0 OrElse idx >= listView.Items.Count Then Return
        listView.SelectedItems.Clear()
        Dim it = listView.Items(idx)
        it.Selected = True
        it.Focused = True
        it.EnsureVisible()
        listView.Focus()
    End Sub

    '搜索结果
    Private Sub SearchRslt(listView As ListView,
                     keyword As String,
                     searchType As SearchType,
                     ByRef resultList As List(Of Integer),
                     ByRef currentIndex As Integer,
                     uiTag As String)

        Dim lowerKeyword As String = keyword.ToLower()
        resultList.Clear()
        currentIndex = -1

        ClearHighlights(listView)

        For i As Integer = 0 To listView.Items.Count - 1
            Dim item As ListViewItem = listView.Items(i)
            Dim match As Boolean = False

            Select Case searchType
                Case SearchType.All
                    match = item.Text.ToLower().Contains(lowerKeyword) OrElse
                        item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().
                        Any(Function(s) s.Text.ToLower().Contains(lowerKeyword))

                Case SearchType.Index
                    match = item.Text.ToLower().Contains(lowerKeyword)

                Case SearchType.FileName     '假设文件名在第2列
                    If item.SubItems.Count > 2 Then
                        match = item.SubItems(2).Text.ToLower().Contains(lowerKeyword)
                    End If

                Case SearchType.Format       '假设格式在第4列
                    If item.SubItems.Count > 4 Then
                        Dim formatText = item.SubItems(4).Text.ToLower()
                        If {".png", ".jpg", ".jpeg", ".ico", ".bmp", ".gif"}.Any(Function(ext) formatText.Contains(ext)) Then
                            match = formatText.Contains(lowerKeyword)
                        End If
                    End If

                Case SearchType.eDate        '假设日期在第6列
                    If item.SubItems.Count > 6 Then
                        Dim dateText = item.SubItems(6).Text.ToLower()
                        match = dateText.Contains(lowerKeyword)
                    End If
            End Select

            If match Then
                item.BackColor = Color.LemonChiffon
                resultList.Add(i)
            End If
        Next
        '播放ALERT()
        'optChange("「" & uiTag & "」结果 " & resultList.Count & " 项", 5)

        If resultList.Count > 0 Then
            TabMain.TabPages(3).Text = "查找 " & FormatRsltCount(resultList.Count)
            ' 自动滚动到第一个查找结果
            HighlightItem(listView, resultList(0))
        Else
            TabMain.TabPages(3).Text = "查找"
        End If
    End Sub

End Class