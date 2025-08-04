Imports System.IO
Public Class Form6
    Private currentColumn As Integer = -1 '存储当前排序的列和顺序
    Private currentOrder As SortOrder = SortOrder.Ascending '存储当前排序的列和顺序
    Private originalNames As New Dictionary(Of Integer, String)()
    Dim Publicpath As String

    ' 在Form6类中添加以下方法和调用，实现ListViewPre的双缓冲
    ' 1. 添加扩展ListView的双缓冲支持
    Private Sub EnableDoubleBuffering(listView As ListView)
        Dim prop As Reflection.PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If prop IsNot Nothing Then
            prop.SetValue(listView, True, Nothing)
        End If
    End Sub

    ' 2. 在Form6_Load中调用
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        ListViewPre.AllowDrop = True
        Publicpath = ""
        ' 开启ListViewPre双缓冲
        EnableDoubleBuffering(ListViewPre)
        ' 添加工具提示，展示所有可用格式
        Dim toolTip As New ToolTip()
        toolTip.ToolTipIcon = ToolTipIcon.Info
        toolTip.ToolTipTitle = "可用格式"
        toolTip.SetToolTip(ComboBox1, "{name} - 原文件名(xxxx)" & vbCrLf & "{index} - 序号(!)" & vbCrLf & "{0index} - 补齐0的序号(0!)" & vbCrLf & "{year} - 年(yyyy)" & vbCrLf & "{month} - 月(M)" & vbCrLf & "{0month} - 补齐0的月(0M)" & vbCrLf & "{date} - 日期(yyyyMd)" & vbCrLf & "{0date} - 补齐0的日期(yyyy0M0d)" & vbCrLf & "{season} - 季(春/夏/秋/冬)")
        ContextMenuStrip1.Renderer = New ModernMenuRenderer()
        ContextMenuStrip3.Renderer = New ModernMenuRenderer()
    End Sub

    Private Sub bksbutton_Click(sender As Object, e As EventArgs) Handles bksbutton.Click
        If ListViewPre.SelectedItems.Count > 0 Then '确保 ListView2 中有选中的项
            Dim result As DialogResult = MessageBox.Show("确定要移除选定项吗？", "确认移除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
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

                ' 重新排序动态序号
                UpdateDynamicIndex()
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        If (ModifierKeys And Keys.Shift) = Keys.Shift Then
            ' Shift+点击，浏览文件夹
            Using fbd As New FolderBrowserDialog()
                If fbd.ShowDialog() = DialogResult.OK Then
                    Publicpath = ""
                    拖入重命名(fbd.SelectedPath)
                    ' 显示路径到TextBox2
                    TextBox2.Text = fbd.SelectedPath
                    TextBox2.SelectionStart = TextBox2.Text.Length
                    TextBox2.ScrollToCaret()
                End If
            End Using
            Exit Sub
        End If

        If (ModifierKeys And Keys.Control) = Keys.Control Then
            ' Ctrl+点击，从ListViewLT拉取数据
            ListViewPre.Items.Clear()
            originalNames.Clear()
            For i As Integer = 0 To Form1.ListViewLT.Items.Count - 1
                Dim item As ListViewItem = Form1.ListViewLT.Items(i)
                Dim newItem As New ListViewItem((i + 1).ToString())
                newItem.SubItems.Add(item.SubItems(2).Text) ' 只添加文件名
                newItem.Tag = item.Tag
                ListViewPre.Items.Add(newItem)
                originalNames(i) = item.SubItems(2).Text
            Next
            Publicpath = Form1.openText.Text
            TextBox2.Text = "来自 PicoFilter 加载页"
            TextBox2.SelectionStart = TextBox2.Text.Length
            TextBox2.ScrollToCaret()
            Console.WriteLine("ListViewPre 中的项目数量：" & ListViewPre.Items.Count)
            Exit Sub
        End If

        Publicpath = ""
        转到重命名()
        ' 拉取时显示PicoFilter
        TextBox2.Text = "来自 PicoFilter 筛选页"
        TextBox2.SelectionStart = TextBox2.Text.Length
        TextBox2.ScrollToCaret()
    End Sub

    Public Sub 转到重命名()
        ListViewPre.Items.Clear()
        originalNames.Clear()
        For i As Integer = 0 To Form1.ListViewRT.Items.Count - 1
            Dim item As ListViewItem = Form1.ListViewRT.Items(i)
            Dim newItem As New ListViewItem((i + 1).ToString())
            newItem.SubItems.Add(item.SubItems(2).Text) ' 只添加文件名
            newItem.Tag = item.Tag
            ListViewPre.Items.Add(newItem)
            originalNames(i) = item.SubItems(2).Text ' 存储原始文件名
        Next
        Publicpath = Form1.openText.Text
        TextBox2.Text = "PicoFilter"
        TextBox2.SelectionStart = TextBox2.Text.Length
        TextBox2.ScrollToCaret()
        Console.WriteLine("ListViewPre 中的项目数量：" & ListViewPre.Items.Count)
    End Sub

    ' ApplyButton_Click：批量应用格式
    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        ' 如果列表内存在项目，点击后全部选中
        If ListViewPre.Items.Count > 0 Then
            For Each item As ListViewItem In ListViewPre.Items
                item.Selected = True
            Next
        End If

        ' 以下为原有批量应用格式的代码（如需恢复可取消注释）
        'Dim formatString As String = ComboBox1.Text
        'If String.IsNullOrWhiteSpace(formatString) Then Return

        'Dim startIndex As Integer = If(Integer.TryParse(TextBoxStart.Text, Nothing), CInt(TextBoxStart.Text), 1)
        'Dim currentMonth As String = DateTime.Now.Month.ToString
        'Dim paddedMonth As String = DateTime.Now.Month.ToString.PadLeft(2, "0"c)
        'Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd")
        'Dim currentYear As String = DateTime.Now.Year.ToString
        'Dim currentSeason As String = ""
        'Select Case currentMonth
        '    Case 3 To 5 : currentSeason = "春"
        '    Case 6 To 8 : currentSeason = "夏"
        '    Case 9 To 11 : currentSeason = "秋"
        '    Case 12, 1, 2 : currentSeason = "冬"
        'End Select
        'Dim paddedDate As String = DateTime.Now.ToString("yyyyMMdd").PadLeft(8, "0"c)
        'Dim maxIndexLength As Integer = (startIndex + ListViewPre.Items.Count - 1).ToString().Length

        'For i As Integer = 0 To ListViewPre.Items.Count - 1
        '    Dim originalName As String
        '    If originalNames.ContainsKey(i) Then
        '        originalName = originalNames(i)
        '    Else
        '        originalName = ListViewPre.Items(i).SubItems(1).Text
        '        originalNames(i) = originalName
        '    End If
        '    Dim originalName0 As String = Path.GetFileNameWithoutExtension(originalName)
        '    Dim indexValue As Integer = startIndex + i
        '    Dim indexStr As String = indexValue.ToString()
        '    Dim paddedIndex As String = indexStr.PadLeft(maxIndexLength, "0"c)
        '    Dim fileExtension As String = IO.Path.GetExtension(originalName)
        '    Dim newName As String = formatString.Replace("{prefix}", "") _
        '                              .Replace("{0name}", originalName) _
        '                              .Replace("{name}", originalName0) _
        '                              .Replace("{suffix}", "") _
        '                              .Replace("{index}", indexStr) _
        '                              .Replace("{0index}", paddedIndex) _
        '                              .Replace("{season}", currentSeason) _
        '                              .Replace("{year}", currentYear) _
        '                              .Replace("{date}", currentDate) _
        '                              .Replace("{0date}", paddedDate) _
        '                              .Replace("{month}", currentMonth) _
        '                              .Replace("{0month}", paddedMonth)
        '    newName &= fileExtension
        '    ListViewPre.Items(i).SubItems(1).Text = newName

        '    ' 检查是否有改动，添加*到序号
        '    If newName <> originalName Then
        '        If Not ListViewPre.Items(i).SubItems(0).Text.EndsWith("*") Then
        '            ListViewPre.Items(i).SubItems(0).Text &= "*"
        '        End If
        '    End If
        'Next
    End Sub

    ' Button7_Click：对选中项应用格式
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim formatString As String = ComboBox1.Text
        If String.IsNullOrWhiteSpace(formatString) Then Return
        If ListViewPre.SelectedItems.Count = 0 Then
            MessageBox.Show("请选择至少一个项目进行修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim startIndex As Integer = If(Integer.TryParse(TextBoxStart.Text, Nothing), CInt(TextBoxStart.Text), 1)
        Dim currentMonth As String = DateTime.Now.Month.ToString
        Dim paddedMonth As String = DateTime.Now.Month.ToString.PadLeft(2, "0"c)
        Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd")
        Dim paddedDate As String = DateTime.Now.ToString("yyyyMMdd").PadLeft(8, "0"c)
        Dim currentYear As String = DateTime.Now.Year.ToString
        Dim currentSeason As String = ""
        Select Case currentMonth
            Case "3", "4", "5" : currentSeason = "春"
            Case "6", "7", "8" : currentSeason = "夏"
            Case "9", "10", "11" : currentSeason = "秋"
            Case "12", "1", "2" : currentSeason = "冬"
        End Select
        Dim maxIndexLength As Integer = (startIndex + ListViewPre.Items.Count - 1).ToString().Length

        For Each item As ListViewItem In ListViewPre.SelectedItems
            Dim i As Integer = item.Index
            Dim originalName As String
            If originalNames.ContainsKey(i) Then
                originalName = originalNames(i)
            Else
                originalName = item.SubItems(1).Text
                originalNames(i) = originalName
            End If
            Dim originalName0 As String = IO.Path.GetFileNameWithoutExtension(originalName)
            Dim fileExtension As String = IO.Path.GetExtension(originalName)
            Dim indexValue As Integer = startIndex + i
            Dim indexStr As String = indexValue.ToString()
            Dim paddedIndex As String = indexStr.PadLeft(maxIndexLength, "0"c)
            Dim newName As String = formatString.Replace("{prefix}", "") _
                               .Replace("{0name}", originalName) _
                               .Replace("{name}", originalName0) _
                               .Replace("{suffix}", "") _
                               .Replace("{index}", indexStr) _
                               .Replace("{0index}", paddedIndex) _
                               .Replace("{season}", currentSeason) _
                               .Replace("{year}", currentYear) _
                               .Replace("{date}", currentDate) _
                               .Replace("{0date}", paddedDate) _
                               .Replace("{month}", currentMonth) _
                               .Replace("{0month}", paddedMonth)
            newName &= fileExtension
            item.SubItems(1).Text = newName

            ' 检查是否有改动，添加*到序号
            If newName <> originalName Then
                item.BackColor = Color.Lavender
            End If
        Next
    End Sub

    ' Button4_Click：还原并去掉所有*
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' 仅还原选中项
        For Each item As ListViewItem In ListViewPre.SelectedItems
            Dim i As Integer = item.Index
            If originalNames.ContainsKey(i) Then
                item.SubItems(1).Text = originalNames(i)
            End If
            ' 去掉序号后的*
            item.BackColor = Color.White
        Next
        originalNames.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ComboBox1.Text = “{0index}”
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Text = "{name}_{0date}"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListViewPre.Items.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("确认要关闭吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        ElseIf ListViewPre.Items.Count = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListViewPre.Items.Count > 0 Then
            Using folderDialog As New FolderBrowserDialog()
                folderDialog.Description = "选择一个位置，新建文件夹以保存重命名副本。" ' 设置对话框标题
                If folderDialog.ShowDialog() = DialogResult.OK Then
                    Dim targetPath As String = folderDialog.SelectedPath
                    Dim sourcePath As String = Publicpath

                    ' 设置进度条
                    With MetroProgressBar1
                        .Minimum = 0
                        .Maximum = ListViewPre.Items.Count
                        .Value = 0
                        .Visible = True
                    End With

                    Dim failedCount As Integer = 0
                    Dim processedCount As Integer = 0

                    For Each item As ListViewItem In ListViewPre.Items
                        Try
                            Dim originalFilePath As String = IO.Path.Combine(sourcePath, originalNames(item.Index))
                            Dim newFilePath As String = IO.Path.Combine(targetPath, item.SubItems(1).Text)

                            If IO.File.Exists(originalFilePath) Then
                                IO.File.Copy(originalFilePath, newFilePath, True) ' 复制文件
                            End If
                        Catch ex As Exception
                            failedCount += 1
                        Finally
                            processedCount += 1
                            MetroProgressBar1.Value = processedCount
                            Application.DoEvents() ' 允许UI更新
                        End Try
                    Next

                    MetroProgressBar1.Visible = False

                    If failedCount > 0 Then
                        MessageBox.Show($"部分重命名完成，其中{failedCount}个文件重命名失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        ' 修改这里：添加询问是否打开目标文件夹
                        If MessageBox.Show("重命名副本已保存。点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            Try
                                Process.Start("explorer.exe", targetPath)
                            Catch ex As Exception
                                MessageBox.Show("无法打开目标文件夹。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Try
                        End If
                    End If
                End If
            End Using
        End If
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
                    Case 1 ' 其他列（按字符串排序）
                        returnVal = String.Compare(item1.SubItems(col).Text, item2.SubItems(col).Text)
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
            topButton.ImageIndex = 1

        Else
            TopMost = False
            topButton.ImageIndex = 0
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

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        'If ComboBox1.Text = "(无)" Or ComboBox1.Text = "" Then
        '    ApplyButton.Visible = False
        '    Button7.Visible = False
        'Else
        '    ApplyButton.Visible = True
        '    Button7.Visible = True
        'End If
    End Sub

    Private Sub ListViewPre_DoubleClick(sender As Object, e As EventArgs) Handles ListViewPre.DoubleClick
        If ListViewPre.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewPre.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text '获取选中的文件名
            Dim folderPath As String = Publicpath '文件夹路径
            TextBox1.Text = Publicpath
            Dim filePath As String = Path.Combine(folderPath, fileName) '拼接完整的文件路径
            Console.WriteLine("打开文件：" & filePath)
            Try
                Process.Start(filePath) ' 使用默认程序打开文件
            Catch ex As Exception
                MessageBox.Show("无法打开。" & vbCrLf & ex.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' 当文件拖入窗口时触发，判断是否是文件夹
    Private Sub ListViewPre_DragEnter(sender As Object, e As DragEventArgs) Handles ListViewPre.DragEnter
        ' 判断拖入的是否是文件夹
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If Directory.Exists(droppedItems(0)) Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    ' 当文件夹被拖入并放开鼠标时触发
    Private Sub ListViewPre_DragDrop(sender As Object, e As DragEventArgs) Handles ListViewPre.DragDrop
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())

        ' 确保拖入的不是单个文件，而是文件夹
        If files.Length > 0 AndAlso Directory.Exists(files(0)) Then
            Dim folderPath As String = files(0) ' 获取文件夹路径
            Publicpath = ""
            拖入重命名(folderPath)
        End If
    End Sub

    ' 读取文件夹内的所有图片文件并填充 ListViewPre
    Private Sub 拖入重命名(folderPath As String)
        ListViewPre.Items.Clear() ' 清空旧数据
        originalNames.Clear()
        ' 定义允许的图片文件扩展名
        Dim allowedExtensions As String() = {".jpg", ".png", ".gif", ".bmp", ".ico"}
        ' 获取文件夹内所有文件
        Dim filePaths As String() = Directory.GetFiles(folderPath)
        For Each filePath As String In filePaths
            ' 获取文件扩展名
            Dim extension As String = Path.GetExtension(filePath).ToLower()
            ' 检查文件扩展名是否在允许的列表中
            If allowedExtensions.Contains(extension) Then
                Dim fileName As String = Path.GetFileName(filePath)
                Dim newItem As New ListViewItem((ListViewPre.Items.Count + 1).ToString()) ' 第一栏显示动态序号
                newItem.SubItems.Add(fileName) ' 第二栏是文件名
                newItem.Tag = filePath ' 保存完整文件路径，方便后续重命名
                ListViewPre.Items.Add(newItem)
                originalNames(ListViewPre.Items.Count - 1) = fileName ' 存储原始文件名
            End If
        Next
        Publicpath = folderPath
        ' 显示路径到TextBox2
        TextBox2.Text = folderPath
        TextBox2.SelectionStart = TextBox2.Text.Length
        TextBox2.ScrollToCaret()
        Console.WriteLine("ListViewPre 中的项目数量：" & ListViewPre.Items.Count)
    End Sub

    Private Sub Form6_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.MinimumSize = New Size(371, 582)
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        If ListViewPre.SelectedItems.Count = 1 Then
            Dim selectedItem As ListViewItem = ListViewPre.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text '获取选中的文件名
            Dim folderPath As String = Publicpath '文件夹路径
            TextBox1.Text = Publicpath
            Dim filePath As String = Path.Combine(folderPath, fileName) '拼接完整的文件路径
            Console.WriteLine("打开文件：" & filePath)
            Try
                Process.Start(filePath) ' 使用默认程序打开文件
            Catch ex As Exception
                MessageBox.Show("无法打开。" & vbCrLf & ex.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub 移除选中项DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 移除选中项DToolStripMenuItem.Click
        If ListViewPre.SelectedItems.Count > 0 Then '确保 ListView2 中有选中的项
            Dim result As DialogResult = MessageBox.Show("确定要移除选定项吗？", "确认移除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
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

                ' 重新排序动态序号
                UpdateDynamicIndex()
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        ' 如果列表内存在项目，点击后全部选中
        If ListViewPre.Items.Count > 0 Then
            For Each item As ListViewItem In ListViewPre.Items
                item.Selected = True
            Next
        End If
    End Sub
    ' 在 ListView0
    Private Sub ListView0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewPre.SelectedIndexChanged
        If ListViewPre.SelectedItems.Count = 1 Then
            ListViewPre.ContextMenuStrip = ContextMenuStrip3
        Else
            ListViewPre.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If ListViewPre.SelectedItems.Count > 0 Then '确保 ListView2 中有选中的项
            Dim result As DialogResult = MessageBox.Show("确定要移除选定项吗？", "确认移除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
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

                ' 重新排序动态序号
                UpdateDynamicIndex()
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    ' 自定义现代风格渲染器
    Public Class ModernMenuRenderer
        Inherits ToolStripProfessionalRenderer

        Public Sub New()
            MyBase.New(New ModernColorTable())
        End Sub

        ' 新增：自定义左侧图标区域渐变色
        Protected Overrides Sub OnRenderImageMargin(e As ToolStripRenderEventArgs)
            Dim marginRect As Rectangle = e.AffectedBounds
            ' 你可以自定义渐变色，这里以蓝紫渐变为例
            Using brush As New Drawing2D.LinearGradientBrush(
                marginRect,
                Color.Lavender, ' 渐变起始色
                Color.White, ' 渐变结束色
                Drawing2D.LinearGradientMode.Horizontal)
                e.Graphics.FillRectangle(brush, marginRect)
            End Using
        End Sub

        Protected Overrides Sub OnRenderSeparator(e As ToolStripSeparatorRenderEventArgs)
            Dim g = e.Graphics
            Dim bounds = e.Item.ContentRectangle
            Dim y = bounds.Top + bounds.Height \ 2
            Using pen As New Pen(Color.Lavender, 1)
                g.DrawLine(pen, bounds.Left + 25, y, bounds.Right - 4, y)
            End Using
        End Sub

    End Class

    ' 自定义颜色表
    Public Class ModernColorTable
        Inherits ProfessionalColorTable

        Public Overrides ReadOnly Property MenuItemSelected As Color
            Get
                Return Color.Lavender
            End Get
        End Property

        Public Overrides ReadOnly Property MenuItemBorder As Color
            Get
                Return Color.FromArgb(180, 180, 220)
            End Get
        End Property

        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return Color.FromArgb(180, 180, 220)
            End Get
        End Property
    End Class
End Class