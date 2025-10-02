'Imports System.IO

'Public Class FormRename

'    Private currentColumn As Integer = -1 '存储当前排序的列和顺序
'    Private currentOrder As SortOrder = SortOrder.Ascending '存储当前排序的列和顺序
'    Private originalNames As New Dictionary(Of Integer, String)()

'    ' 在类级别添加一个列表来存储重命名失败的文件信息
'    Private renameFailedFiles As New List(Of (index As Integer, fileName As String, newName As String))

'    Dim PathString As String

'    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
'        If (ModifierKeys And Keys.Shift) = Keys.Shift Then
'            ' Shift+点击，浏览文件夹
'            Using fbd As New FolderBrowserDialog()
'                If fbd.ShowDialog() = DialogResult.OK Then
'                    'PathString = ""
'                    拖入重命名(fbd.SelectedPath)
'                    ' 显示路径到TextBox2
'                    TbxOpen.Text = fbd.SelectedPath
'                End If
'            End Using
'            Exit Sub
'        End If

'        If (ModifierKeys And Keys.Control) = Keys.Control Then
'            ' Ctrl+点击，从ListViewLT拉取数据
'            ListViewLoad.Items.Clear()
'            originalNames.Clear()
'            For i As Integer = 0 To Form1.ListViewLoad.Items.Count - 1
'                Dim item As ListViewItem = Form1.ListViewLoad.Items(i)
'                Dim newItem As New ListViewItem((i + 1).ToString())
'                newItem.SubItems.Add(item.SubItems(2).Text) ' 只添加文件名
'                newItem.SubItems.Add(item.SubItems(2).Text) ' 新增：原始文件名
'                newItem.Tag = item.Tag
'                ListViewLoad.Items.Add(newItem)
'                originalNames(i) = item.SubItems(2).Text
'            Next
'            PathString = Form1.OpenPath
'            TbxOpen.Text = "来自 PicoFilter 加载页"
'            Console.WriteLine("listviewload 中的项目数量：" & ListViewLoad.Items.Count)
'            Exit Sub
'        End If

'        PathString = ""
'        转到重命名()
'        ' 拉取时显示PicoFilter
'        TbxOpen.Text = "来自 PicoFilter 筛选页"
'        TbxOpen.SelectionStart = TbxOpen.Text.Length
'        TbxOpen.ScrollToCaret()
'    End Sub

'    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
'        If ListViewLoad.SelectedItems.Count > 0 Then '确保 ListView2 中有选中的项
'            Dim result As DialogResult = MessageBox.Show("确定要移除选定项吗？", "确认移除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

'            If result = DialogResult.Yes Then
'                '从 ListView2 中删除选中的项
'                Dim index As Integer = ListViewLoad.SelectedItems(0).Index
'                For Each selectedItem As ListViewItem In ListViewLoad.SelectedItems
'                    ListViewLoad.Items.Remove(selectedItem)
'                Next

'                If ListViewLoad.Items.Count > 0 Then
'                    If index < ListViewLoad.Items.Count Then
'                        ListViewLoad.Items(index).Selected = True
'                        ListViewLoad.Items(index).Focused = True
'                    Else
'                        ListViewLoad.Items(ListViewLoad.Items.Count - 1).Selected = True
'                        ListViewLoad.Items(ListViewLoad.Items.Count - 1).Focused = True
'                    End If
'                End If

'                ' 重新排序动态序号
'                UpdateDynamicIndex()
'            End If
'        Else
'            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
'        End If
'    End Sub

'    Private Sub btnApplyAll_Click(sender As Object, e As EventArgs) Handles btnApplyAll.Click
'        ' 如果列表内存在项目，点击后全部选中
'        If ListViewLoad.Items.Count > 0 Then
'            For Each item As ListViewItem In ListViewLoad.Items
'                item.Selected = True
'            Next
'        End If

'        ' 以下为原有批量应用格式的代码（如需恢复可取消注释）
'    End Sub

'    Private Sub btnApplySelected_Click(sender As Object, e As EventArgs) Handles btnApplySelected.Click
'        Dim FormatString As String = CbxFormat.Text
'        Dim folderName As String = If(Not String.IsNullOrEmpty(PathString),
'                               Path.GetFileName(PathString.TrimEnd(Path.DirectorySeparatorChar)),
'                               "")
'        If String.IsNullOrWhiteSpace(FormatString) Then Return
'        If ListViewLoad.SelectedItems.Count = 0 Then
'            MessageBox.Show("请选择至少一个项目进行修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Return
'        End If
'        Dim startIndex As Integer = If(Integer.TryParse(TextBoxStart.Text, Nothing), CInt(TextBoxStart.Text), 1)
'        Dim stepSize As Integer = CInt(NumericUpDown1.Value) ' 获取步长值
'        Dim currentMonth As String = DateTime.Now.Month.ToString
'        Dim paddedMonth As String = DateTime.Now.Month.ToString.PadLeft(2, "0"c)
'        Dim currentDate As String = DateTime.Now.ToString("yyyyMMdd")
'        Dim paddedDate As String = DateTime.Now.ToString("yyyyMMdd").PadLeft(8, "0"c)
'        Dim currentYear As String = DateTime.Now.Year.ToString
'        Dim currentSeason As String = ""
'        Select Case currentMonth
'            Case "3", "4", "5" : currentSeason = "春"
'            Case "6", "7", "8" : currentSeason = "夏"
'            Case "9", "10", "11" : currentSeason = "秋"
'            Case "12", "1", "2" : currentSeason = "冬"
'        End Select
'        ' 修改maxIndexLength的计算，考虑步长的影响
'        Dim maxIndex As Integer = startIndex + (ListViewLoad.SelectedItems.Count - 1) * stepSize
'        Dim maxIndexLength As Integer = maxIndex.ToString().Length

'        For Each item As ListViewItem In ListViewLoad.SelectedItems
'            Dim i As Integer = item.Index
'            Dim originalName As String
'            If originalNames.ContainsKey(i) Then
'                originalName = originalNames(i)
'            Else
'                originalName = item.SubItems(1).Text
'                originalNames(i) = originalName
'            End If
'            Dim originalName0 As String = IO.Path.GetFileNameWithoutExtension(originalName)
'            Dim fileExtension As String = IO.Path.GetExtension(originalName)
'            ' 修改indexValue的计算，使用步长
'            Dim indexValue As Integer = startIndex + (i * stepSize)
'            Dim indexStr As String = indexValue.ToString()
'            Dim paddedIndex As String = indexStr.PadLeft(maxIndexLength, "0"c)
'            Dim newName As String = FormatString.Replace("{prefix}", "") _
'                               .Replace("{0name}", originalName) _
'                               .Replace("{name}", originalName0) _
'                               .Replace("{suffix}", "") _
'                               .Replace("{index}", indexStr) _
'                               .Replace("{0index}", paddedIndex) _
'                               .Replace("{season}", currentSeason) _
'                               .Replace("{year}", currentYear) _
'                               .Replace("{date}", currentDate) _
'                               .Replace("{0date}", paddedDate) _
'                               .Replace("{month}", currentMonth) _
'                               .Replace("{0month}", paddedMonth) _
'                               .Replace("{folder}", folderName)
'            newName &= fileExtension
'            item.SubItems(1).Text = newName

'            ' 检查是否有改动，添加*到序号
'            If newName <> originalName Then
'                item.BackColor = Color.Lavender
'            End If
'        Next
'    End Sub

'    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
'        ' 仅还原选中项
'        For Each item As ListViewItem In ListViewLoad.SelectedItems
'            ' 使用第三列保存的原始文件名进行还原（避免依赖索引）
'            Dim originalName As String = ""
'            If item.SubItems.Count >= 3 Then
'                originalName = item.SubItems(2).Text
'            End If

'            If Not String.IsNullOrEmpty(originalName) Then
'                item.SubItems(1).Text = originalName
'            End If
'            ' 去掉变更标记背景色
'            item.BackColor = Color.White
'        Next
'        ' 不再 Clear originalNames（避免破坏其它逻辑）
'    End Sub

'    Private Sub mnsButton_Click(sender As Object, e As EventArgs) Handles mnsButton.Click
'        If ListViewLoad.SelectedItems.Count = 0 Then Exit Sub

'        ' 取消排序器，保证移动的是当前显示顺序
'        ListViewLoad.ListViewItemSorter = Nothing

'        ListViewLoad.BeginUpdate()
'        ' 选中项按索引降序排列，避免顺序错乱
'        Dim selectedItems = ListViewLoad.SelectedItems.Cast(Of ListViewItem).OrderByDescending(Function(x) x.Index).ToList()
'        For Each item In selectedItems
'            Dim idx = item.Index
'            If idx < ListViewLoad.Items.Count - 1 Then
'                ListViewLoad.Items.RemoveAt(idx)
'                ListViewLoad.Items.Insert(idx + 1, item)
'            End If
'        Next
'        ' 恢复选中
'        For Each item In selectedItems
'            item.Selected = True
'        Next
'        ListViewLoad.EndUpdate()
'        UpdateDynamicIndex()
'    End Sub

'    Private Sub moreButton_Click(sender As Object, e As EventArgs) Handles moreButton.Click
'        If ListViewLoad.SelectedItems.Count = 0 Then Exit Sub

'        ' 取消排序器，保证移动的是当前显示顺序
'        ListViewLoad.ListViewItemSorter = Nothing

'        ListViewLoad.BeginUpdate()
'        ' 选中项按索引升序排列，避免顺序错乱
'        Dim selectedItems = ListViewLoad.SelectedItems.Cast(Of ListViewItem).OrderBy(Function(x) x.Index).ToList()
'        For Each item In selectedItems
'            Dim idx = item.Index
'            If idx > 0 Then
'                ListViewLoad.Items.RemoveAt(idx)
'                ListViewLoad.Items.Insert(idx - 1, item)
'            End If
'        Next
'        ' 恢复选中
'        For Each item In selectedItems
'            item.Selected = True
'        Next
'        ListViewLoad.EndUpdate()
'        UpdateDynamicIndex()
'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        If ListViewLoad.Items.Count = 0 Then
'            MessageBox.Show("没有可重命名的文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
'            Exit Sub
'        End If

'        If String.IsNullOrEmpty(PathString) OrElse Not IO.Directory.Exists(PathString) Then
'            MessageBox.Show("源文件夹无效。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Exit Sub
'        End If

'        Dim confirm = MessageBox.Show("即将覆盖原文件，是否继续？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
'        If confirm <> DialogResult.Yes Then Exit Sub

'        Dim failedFiles As New List(Of String)
'        Dim processedCount As Integer = 0

'        With MetroProgressBar1
'            .Minimum = 0
'            .Maximum = ListViewLoad.Items.Count
'            .Value = 0
'            .Visible = True
'        End With

'        For Each item As ListViewItem In ListViewLoad.Items
'            Try
'                ' 使用第三列原始文件名来获取 oldName（避免排序后索引不一致）
'                Dim oldName As String = If(item.SubItems.Count >= 3, item.SubItems(2).Text, item.SubItems(1).Text)
'                Dim newName As String = item.SubItems(1).Text
'                If oldName = newName Then
'                    ' 跳过未更名项
'                    processedCount += 1
'                    MetroProgressBar1.Value = processedCount
'                    Continue For
'                End If

'                Dim oldPath As String = IO.Path.Combine(PathString, oldName)
'                Dim newPath As String = IO.Path.Combine(PathString, newName)

'                If IO.File.Exists(oldPath) Then
'                    ' 若目标文件已存在，先删除
'                    If IO.File.Exists(newPath) Then IO.File.Delete(newPath)
'                    IO.File.Move(oldPath, newPath)
'                End If
'            Catch ex As Exception
'                Dim failedName As String = If(item.SubItems.Count >= 3, item.SubItems(2).Text, item.SubItems(1).Text)
'                failedFiles.Add(failedName)
'            Finally
'                processedCount += 1
'                MetroProgressBar1.Value = processedCount
'                Application.DoEvents()
'            End Try
'        Next

'        MetroProgressBar1.Visible = False

'        If failedFiles.Count > 0 Then
'            Dim failedFilesList As String = String.Join(vbCrLf, failedFiles)
'            MessageBox.Show($"部分文件重命名失败：{vbCrLf}{failedFilesList}", "未完成", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'        Else
'            If MessageBox.Show("文件重命名完成，点击按钮打开文件夹", "完成", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
'                Try
'                    Process.Start("explorer.exe", PathString)
'                Catch ex As Exception
'                    MessageBox.Show("无法打开文件夹。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                End Try
'            End If
'        End If
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        If ListViewLoad.Items.Count > 0 Then
'            Using folderDialog As New FolderBrowserDialog()
'                folderDialog.Description = "选择一个位置，新建文件夹以保存重命名副本。" ' 设置对话框标题
'                If folderDialog.ShowDialog() = DialogResult.OK Then
'                    Dim targetPath As String = folderDialog.SelectedPath
'                    Dim sourcePath As String = PathString

'                    ' 设置进度条
'                    With MetroProgressBar1
'                        .Minimum = 0
'                        .Maximum = ListViewLoad.Items.Count
'                        .Value = 0
'                        .Visible = True
'                    End With

'                    Dim failedFiles As New List(Of String) ' 存储失败文件的信息
'                    Dim processedCount As Integer = 0

'                    For Each item As ListViewItem In ListViewLoad.Items
'                        Try
'                            ' 使用第三列原始文件名来确定原路径（避免索引映射问题）
'                            Dim origName As String = If(item.SubItems.Count >= 3, item.SubItems(2).Text, item.SubItems(1).Text)
'                            Dim originalFilePath As String = IO.Path.Combine(sourcePath, origName)
'                            Dim newFilePath As String = IO.Path.Combine(targetPath, item.SubItems(1).Text)

'                            If IO.File.Exists(originalFilePath) Then
'                                IO.File.Copy(originalFilePath, newFilePath, True) ' 复制文件
'                            End If
'                        Catch ex As Exception
'                            ' 记录失败文件的信息，尽量从第三列读取原名
'                            Dim failedName As String = If(item.SubItems.Count >= 3, item.SubItems(2).Text, item.SubItems(1).Text)
'                            failedFiles.Add(failedName)
'                        Finally
'                            processedCount += 1
'                            MetroProgressBar1.Value = processedCount
'                            Application.DoEvents() ' 允许UI更新
'                        End Try
'                    Next

'                    MetroProgressBar1.Visible = False

'                    If failedFiles.Count > 0 Then
'                        ' 构建错误信息字符串
'                        Dim failedFilesList As String = ""
'                        For Each failedFile In failedFiles
'                            failedFilesList &= failedFile & vbCrLf
'                        Next

'                        MessageBox.Show($"部分重命名完成，其中{failedFiles.Count}个文件重命名失败。{vbCrLf}{failedFilesList}",
'                                  "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
'                        ' 修改这里：添加询问是否打开目标文件夹
'                        If MessageBox.Show("重命名已完成。点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
'                            Try
'                                Process.Start("explorer.exe", targetPath)
'                            Catch ex As Exception
'                                MessageBox.Show("无法打开目标文件夹。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                            End Try
'                        End If
'                    Else
'                        ' 修改这里：添加询问是否打开目标文件夹
'                        If MessageBox.Show("重命名已完成。点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
'                            Try
'                                Process.Start("explorer.exe", targetPath)
'                            Catch ex As Exception
'                                MessageBox.Show("无法打开目标文件夹。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                            End Try
'                        End If
'                    End If
'                End If
'            End Using
'        End If
'    End Sub

'End Class