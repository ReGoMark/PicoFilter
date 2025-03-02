Imports System.IO
Imports System.Text.RegularExpressions
Public Class Form6
    Private currentColumn As Integer = -1 '存储当前排序的列和顺序
    Private currentOrder As SortOrder = SortOrder.Ascending '存储当前排序的列和顺序
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListViewPre.Width = 328
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub bksbutton_Click(sender As Object, e As EventArgs) Handles bksbutton.Click
        If ListViewPre.SelectedItems.Count > 0 Then '确保 ListView2 中有选中的项
            '从 ListView2 中删除选中的项
            Dim index As Integer = ListViewPre.SelectedItems(0).Index
            For Each selectedItem As ListViewItem In ListViewPre.SelectedItems
                ListViewPre.Items.Remove(selectedItem)

            Next
            If ListViewPre.Items.Count > 0 Then
                If index < ListViewPre.Items.Count Then
                    ListViewPre.Items(index).Selected = True
                    ListViewPre.Items(index).Focused = True
                Else
                    ListViewPre.Items(ListViewPre.Items.Count - 1).Selected = True
                    ListViewPre.Items(ListViewPre.Items.Count - 1).Focused = True
                End If
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 重新排序动态序号
        UpdateDynamicIndex()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        转到重命名()
    End Sub

    Public Sub 转到重命名()
        ListViewPre.Items.Clear()  ' 确保清空旧数据
        For i As Integer = 0 To Form1.ListViewRT.Items.Count - 1
            Dim item As ListViewItem = Form1.ListViewRT.Items(i)
            Dim newItem As New ListViewItem((i + 1).ToString()) ' 第一栏显示动态序号
            newItem.SubItems.Add(item.SubItems(0).Text) ' 第二栏保留原始序号
            newItem.SubItems.Add(item.SubItems(2).Text) ' 第三栏是文件名
            newItem.SubItems.Add(item.SubItems(2).Text) ' 第三栏是文件名
            newItem.Tag = item.Tag ' 确保文件路径信息不会丢失
            ListViewPre.Items.Add(newItem)
        Next
        Console.WriteLine("ListViewPre 中的项目数量：" & ListViewPre.Items.Count)
    End Sub

    Private originalNames As New Dictionary(Of Integer, String)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 添加工具提示，展示所有可用格式
        Dim toolTip As New ToolTip()
        toolTip.ToolTipIcon = ToolTipIcon.Info
        toolTip.ToolTipTitle = "可用格式"
        toolTip.SetToolTip(ComboBox1, "{name} - 原始文件名" & vbCrLf & "{index} - 序号" & vbCrLf & "{0index} - 补齐0的序号" & vbCrLf & "{date} - 日期(yyyyMMdd)" & vbCrLf & "{0date} - 补齐0的日期(yyyyMMdd)")
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        Dim formatString As String = ComboBox1.Text
        If String.IsNullOrWhiteSpace(formatString) Then Return

        Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd")
        Dim paddedDate As String = DateTime.Now.ToString("yyyyMMdd").PadLeft(8, "0"c) ' 自动补齐0位
        Dim maxIndexLength As Integer = ListViewPre.Items.Count.ToString().Length ' 计算最大序号长度
        For i As Integer = 0 To ListViewPre.Items.Count - 1
            Dim originalName As String = ListViewPre.Items(i).SubItems(2).Text
            If Not originalNames.ContainsKey(i) Then
                originalNames(i) = originalName ' 仅在第一次重命名时保存原始名称
            Else
                originalName = originalNames(i) ' 确保使用最初的文件名
            End If

            Dim indexStr As String = (i + 1).ToString()
            Dim paddedIndex As String = indexStr.PadLeft(maxIndexLength, "0"c) ' 序号补齐0
            Dim fileNameWithoutExt As String = IO.Path.GetFileNameWithoutExtension(originalName)
            Dim fileExtension As String = IO.Path.GetExtension(originalName)

            ' 解析表达式
            Dim newName As String = formatString.Replace("{prefix}", "") _
                                            .Replace("{name}", originalName) _
                                            .Replace("{suffix}", "") _
                                            .Replace("{index}", indexStr) _
                                            .Replace("{0index}", paddedIndex) _
                                            .Replace("{date}", currentDate) _
                                            .Replace("{0date}", paddedDate) ' 添加自动补齐0的日期

            newName &= fileExtension ' 保留原始文件扩展名
            ListViewPre.Items(i).SubItems(2).Text = newName
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To ListViewPre.Items.Count - 1
            If originalNames.ContainsKey(i) Then
                ListViewPre.Items(i).SubItems(2).Text = originalNames(i) ' 还原原始文件名
            End If
        Next
        originalNames.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = “{0index}”
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Text = "{0index}_{0date}"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListViewPre.Items.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("确认要关闭吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using folderDialog As New FolderBrowserDialog()
            If folderDialog.ShowDialog() = DialogResult.OK Then
                Dim targetPath As String = folderDialog.SelectedPath
                Dim sourcePath As String = Form1.openText.Text

                For Each item As ListViewItem In ListViewPre.Items
                    Dim originalFilePath As String = IO.Path.Combine(sourcePath, originalNames(item.Index))
                    Dim newFilePath As String = IO.Path.Combine(targetPath, item.SubItems(2).Text)

                    If IO.File.Exists(originalFilePath) Then
                        IO.File.Copy(originalFilePath, newFilePath, True) ' 复制文件
                    End If

                Next
                MessageBox.Show("重命名副本已保存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub ListViewPre_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListViewPre.ColumnClick
        列表排序法(ListViewPre, e.Column)
    End Sub
    ' 排序方法
    Private Sub 列表排序法(listView As ListView, column As Integer)
        ' 检查是否点击同一列
        If column = currentColumn Then
            If currentOrder = SortOrder.Ascending Then
                currentOrder = SortOrder.Descending
            Else
                currentOrder = SortOrder.Ascending
            End If
        Else
            currentColumn = column
            currentOrder = SortOrder.Ascending
        End If

        ' 更新排序指示箭头
        更新列标题(listView)

        ' 使用自定义比较器进行排序
        listView.ListViewItemSorter = New 列表比较器(currentColumn, currentOrder)
        listView.Sort()
    End Sub

    ' 更新列标题显示排序箭头
    Private Sub 更新列标题(listView As ListView)
        For i As Integer = 0 To listView.Columns.Count - 1
            Dim columnHeader As ColumnHeader = listView.Columns(i)

            ' 清除所有列标题的箭头
            columnHeader.Text = columnHeader.Text.Replace("▲", "").Replace("▼", "")

            ' 仅为列 1, 2, 添加箭头
            If i = 0 Or i = 1 Then
                If i = currentColumn Then
                    If currentOrder = SortOrder.Ascending Then
                        columnHeader.Text &= "▲"
                    Else
                        columnHeader.Text &= "▼"
                    End If
                End If
            End If
        Next
    End Sub

    Public Class 列表比较器
        Implements IComparer
        Private col As Integer
        Private order As SortOrder

        Public Sub New(column As Integer, order As SortOrder)
            Me.col = column
            Me.order = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim returnVal As Integer = 0
            If TypeOf x Is ListViewItem AndAlso TypeOf y Is ListViewItem Then
                Dim item1 As ListViewItem = CType(x, ListViewItem)
                Dim item2 As ListViewItem = CType(y, ListViewItem)
                Select Case col
                    Case 0 ' 序号列（按整数排序）
                        Dim num1 As Integer = Integer.Parse(item1.SubItems(col).Text)
                        Dim num2 As Integer = Integer.Parse(item2.SubItems(col).Text)
                        returnVal = num1.CompareTo(num2)
                    Case 1 ' 序号列（按整数排序）
                        Dim num1 As Integer = Integer.Parse(item1.SubItems(col).Text)
                        Dim num2 As Integer = Integer.Parse(item2.SubItems(col).Text)
                        returnVal = num1.CompareTo(num2)
                End Select
            End If
            If order = SortOrder.Descending Then ' 根据排序顺序调整结果
                returnVal *= -1
            End If
            Return returnVal
        End Function
    End Class

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sourcePath As String = Form1.openText.Text

        If MessageBox.Show("确定要覆盖原文件名吗？操作不可逆！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            For Each item As ListViewItem In ListViewPre.Items
                Dim originalFilePath As String = IO.Path.Combine(sourcePath, originalNames(item.Index))
                Dim newFilePath As String = IO.Path.Combine(sourcePath, item.SubItems(2).Text)

                If IO.File.Exists(originalFilePath) AndAlso originalFilePath <> newFilePath Then
                    IO.File.Move(originalFilePath, newFilePath) ' 直接重命名文件
                End If
            Next
            MessageBox.Show("覆盖文件名已完成。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.optChange("警告：文件名已修改，需要重新加载。", Color.LemonChiffon)
        End If
    End Sub

    Private Sub moreButton_Click(sender As Object, e As EventArgs) Handles moreButton.Click
        ' 确保有选中的项
        If ListViewPre.SelectedItems.Count = 0 Then Exit Sub

        ' 禁用重绘，避免闪烁
        ListViewPre.BeginUpdate()

        ' 存储选中的项
        Dim selectedItems As New List(Of ListViewItem)
        For Each item As ListViewItem In ListViewPre.SelectedItems
            selectedItems.Add(item)
        Next

        ' 按索引升序排序，避免调整时影响顺序
        selectedItems.Sort(Function(x, y) x.Index.CompareTo(y.Index))

        ' 移动项
        For Each item As ListViewItem In selectedItems
            Dim index As Integer = item.Index
            If index > 0 Then
                ListViewPre.Items.RemoveAt(index)
                ListViewPre.Items.Insert(index - 1, item)
            End If
        Next

        ' 重新选中移动后的项
        For Each item As ListViewItem In selectedItems
            item.Selected = True
        Next

        ' 结束更新
        ListViewPre.EndUpdate()
        ' 重新排序动态序号
        UpdateDynamicIndex()
    End Sub

    Private Sub mnsButton_Click(sender As Object, e As EventArgs) Handles mnsButton.Click
        ' 确保有选中的项
        If ListViewPre.SelectedItems.Count = 0 Then Exit Sub

        ' 禁用重绘，避免闪烁
        ListViewPre.BeginUpdate()

        ' 存储选中的项
        Dim selectedItems As New List(Of ListViewItem)
        For Each item As ListViewItem In ListViewPre.SelectedItems
            selectedItems.Add(item)
        Next

        ' 按索引降序排序，避免调整时影响顺序
        selectedItems.Sort(Function(x, y) y.Index.CompareTo(x.Index))

        ' 移动项
        For Each item As ListViewItem In selectedItems
            Dim index As Integer = item.Index
            If index < ListViewPre.Items.Count - 1 Then
                ListViewPre.Items.RemoveAt(index)
                ListViewPre.Items.Insert(index + 1, item)
            End If
        Next

        ' 重新选中移动后的项
        For Each item As ListViewItem In selectedItems
            item.Selected = True
        Next

        ' 结束更新
        ListViewPre.EndUpdate()
        ' 重新排序动态序号
        UpdateDynamicIndex()
    End Sub
    Private Sub UpdateDynamicIndex()
        For i As Integer = 0 To ListViewPre.Items.Count - 1
            ListViewPre.Items(i).SubItems(0).Text = (i + 1).ToString() ' 更新动态序号
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "(无)" Then
            ApplyButton.Visible = False
        Else
            ApplyButton.Visible = True
        End If
    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If ComboBox1.Text = "(无)" Then
            ApplyButton.Visible = False
        Else
            ApplyButton.Visible = True
        End If
    End Sub

    Private Sub Form6_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            ListViewPre.Columns(0).Width = ListViewPre.Width / 15
            ListViewPre.Columns(1).Width = ListViewPre.Width / 15
            ListViewPre.Columns(2).Width = ListViewPre.Width / 3
            ListViewPre.Columns(3).Width = ListViewPre.Width / 3
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ListViewPre.Columns(0).Width = 50
            ListViewPre.Columns(1).Width = 50
            ListViewPre.Columns(2).Width = 200
            ListViewPre.Columns(3).Width = 200
        End If
    End Sub

    Private Sub ListViewPre_DoubleClick(sender As Object, e As EventArgs) Handles ListViewPre.DoubleClick
        If ListViewPre.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewPre.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(3).Text '获取选中的文件名
            Dim folderPath As String = Form1.openText.Text '文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName) '拼接完整的文件路径
            Try
                Process.Start(filePath) ' 使用默认程序打开文件
            Catch ex As Exception
                MessageBox.Show("无法打开。" & vbCrLf & ex.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class