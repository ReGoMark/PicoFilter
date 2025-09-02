Imports System.Drawing.Imaging
Imports System.IO

Public Class Form8
    ' 常量定义
    Private ReadOnly SUPPORTED_FORMATS As String() = {".png", ".jpg", ".jpeg", ".bmp", ".ico"}
    Private ReadOnly DEFAULT_FORMAT As String = "PNG"
    Private basePath As String = String.Empty
    Private currentColumn As Integer = -1 '存储当前排序的列和顺序
    Private currentOrder As SortOrder = SortOrder.Ascending '存储当前排序的列和顺序
    Private LastSavePath As String = String.Empty '存储最后保存的路径
    Private backgroundColor As Color = Color.White ' 默认背景色
    Private colorDialog As New ColorDialog()
    Private failedFiles As New List(Of (index As Integer, fileName As String))    ' 创建一个列表来存储失败文件信息

    ' 初始化窗体 在Form8类中添加以下方法和在Form8_Load中调用 启用ListView1的双缓冲以减少闪烁
    Private Sub EnableListViewDoubleBuffering()
        Dim prop = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If prop IsNot Nothing Then
            prop.SetValue(ListView1, True, Nothing)
        End If
    End Sub

    Private Sub BindContextMenuToAllTextBoxes(parent As Control, menu As ContextMenuStrip)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.ContextMenuStrip = menu
            End If
            ' 如果控件里还有子控件，递归处理
            If ctrl.HasChildren Then
                BindContextMenuToAllTextBoxes(ctrl, menu)
            End If
        Next
    End Sub

    ' 获取触发菜单的 TextBox
    Private Function GetTargetTextBox() As TextBox
        Return TryCast(ContextMenuStrip6.SourceControl, TextBox)
    End Function

    ' 撤销
    Private Sub 撤销UToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 撤销ToolStripMenuItem.Click
        Dim tb = GetTargetTextBox()
        If tb IsNot Nothing Then tb.Undo()
    End Sub

    ' 剪切
    Private Sub 剪切PToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 剪切ToolStripMenuItem.Click
        Dim tb = GetTargetTextBox()
        If tb IsNot Nothing Then tb.Cut()
    End Sub

    ' 复制
    Private Sub 复制CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制ToolStripMenuItem.Click
        Dim tb = GetTargetTextBox()
        If tb IsNot Nothing Then tb.Copy()
    End Sub

    ' 粘贴
    Private Sub 粘贴TToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 粘贴ToolStripMenuItem.Click
        Dim tb = GetTargetTextBox()
        If tb IsNot Nothing Then tb.Paste()
    End Sub

    ' 删除
    Private Sub 删除DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除ToolStripMenuItem.Click
        Dim tb = GetTargetTextBox()
        If tb IsNot Nothing AndAlso tb.SelectionLength > 0 Then
            tb.SelectedText = ""
        End If
    End Sub

    ' 全选
    Private Sub 全选AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 全选ToolStripMenuItem.Click
        Dim tb = GetTargetTextBox()
        If tb IsNot Nothing Then tb.SelectAll()
    End Sub

    ' 在Form8_Load方法中调用
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeControls()
        MetroProgressBar1.Value = False
        EnableListViewDoubleBuffering()
        ContextMenuStrip1.Renderer = New ModernMenuRenderer()
        ContextMenuStrip3.Renderer = New ModernMenuRenderer()
        ContextMenuStrip6.Renderer = New ModernMenuRenderer()
        BindContextMenuToAllTextBoxes(Me, ContextMenuStrip6)
    End Sub

    ' 控件初始化
    Private Sub InitializeControls()
        ' 设置默认格式为PNG
        rbPNG.Checked = True

        ' 设置图片质量滑块
        With cobQuality
            .Minimum = 5
            .Maximum = 100
            .Value = 100
            .Increment = 5
        End With

        ' 进度条初始化
        With MetroProgressBar1
            .Minimum = 0
            .Value = 0
        End With

        ' 初始化背景色控件
        With colorButton
            .BackColor = backgroundColor
            '.FlatStyle = FlatStyle.Flat
            '.FlatAppearance.BorderColor = Color.DarkSlateBlue
            .Visible = False  ' 默认隐藏
            '.Enabled = False
        End With

        ' 颜色对话框设置
        colorDialog.FullOpen = True
        colorDialog.Color = backgroundColor
    End Sub

    ' 添加背景色按钮点击事件
    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        If colorDialog.ShowDialog() = DialogResult.OK Then
            backgroundColor = colorDialog.Color
            colorButton.BackColor = backgroundColor
        End If
    End Sub

    ' 根据格式选择显示/隐藏背景色控件
    Private Sub UpdateBackgroundColorControl()
        Dim hasTransparency As Boolean = rbPNG.Checked OrElse rbICO.Checked
        colorButton.Visible = Not hasTransparency
        'colorButton.Enabled = Not hasTransparency
        'colorButton.FlatAppearance.BorderColor = Color.DarkSlateBlue
    End Sub

    ' 5. 添加ICO相关事件处理
    Private Sub rbICO_CheckedChanged(sender As Object, e As EventArgs) Handles rbICO.CheckedChanged
        UpdateBackgroundColorControl()
    End Sub

    ' 拖放文件处理
    Private Sub ListView1_DragEnter(sender As Object, e As DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ListView1_DragDrop(sender As Object, e As DragEventArgs) Handles ListView1.DragDrop
        ListView1.Items.Clear()
        Try
            Dim paths = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())
            For Each path In paths
                If Directory.Exists(path) Then
                    LoadImagesFromDirectory(path)
                    ' 显示文件夹路径
                    TextBox1.Text = path
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()
                End If
            Next
            'UpdateFormTitle("拖拽")
        Catch ex As Exception
            ShowError("拖放处理出现错误。", ex)
        End Try
    End Sub

    ' 加载图片文件
    Private Sub LoadImagesFromDirectory(directoryPath As String)
        Try
            Dim files = Directory.GetFiles(directoryPath, "*.*").
                Where(Function(f) SUPPORTED_FORMATS.Contains(Path.GetExtension(f).ToLower()))

            Dim startIndex = ListView1.Items.Count + 1

            For Each file In files
                AddFileToListView(file, startIndex)
                startIndex += 1
            Next
        Catch ex As Exception
            ShowError("加载目录出现错误。", ex)
        End Try
    End Sub

    ' 添加文件到ListView
    Private Sub AddFileToListView(filePath As String, index As Integer)
        Dim fileName = Path.GetFileName(filePath)
        Dim format = Path.GetExtension(filePath).TrimStart("."c).ToUpper()

        Dim item = New ListViewItem(index.ToString())
        With item
            .SubItems.Add(fileName)
            .SubItems.Add(format)
            .SubItems.Add(format)
            .Tag = filePath
        End With

        ListView1.Items.Add(item)
    End Sub

    ' 从Form1加载数据
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        If (ModifierKeys And Keys.Shift) = Keys.Shift Then
            ' 按住Shift，弹出文件夹选择对话框
            Using fbd As New FolderBrowserDialog()
                If fbd.ShowDialog() = DialogResult.OK Then
                    ListView1.Items.Clear()
                    LoadImagesFromDirectory(fbd.SelectedPath)
                    ' 显示文件夹路径
                    TextBox1.Text = fbd.SelectedPath
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()
                End If
            End Using
            Exit Sub
        End If

        If (ModifierKeys And Keys.Control) = Keys.Control Then
            ' 按住Control，从Form1.ListViewLT拉取数据
            basePath = Form1.openText.Text.Trim()
            ListView1.Items.Clear()
            Dim index = 1
            For Each item As ListViewItem In Form1.ListViewLT.Items
                ProcessForm1Item(item, index)
                index += 1
            Next
            TextBox1.Text = "来自 PicoFilter 加载页"
            TextBox1.SelectionStart = TextBox1.Text.Length
            TextBox1.ScrollToCaret()
            Exit Sub
        End If

        ' 原有从Form1加载数据逻辑(从ListViewRT获取)
        basePath = Form1.openText.Text.Trim()
        ListView1.Items.Clear()
        Dim idx = 1
        For Each item As ListViewItem In Form1.ListViewRT.Items
            ProcessForm1Item(item, idx)
            idx += 1
        Next
        ' 显示“PicoFilter”
        TextBox1.Text = "来自 PicoFilter 筛选页"
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()

        'UpdateFormTitle("拉取")
        'Catch ex As Exception
        '    ShowError("拉取数据为空。", ex)
        'End Try
    End Sub

    '' 验证Form1数据
    'Private Function ValidateForm1Data() As Boolean
    '    If String.IsNullOrEmpty(basePath) OrElse Not Directory.Exists(basePath) Then
    '        MessageBox.Show("拉取的路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return False
    '    End If

    ' If Form1.ListViewRT.Items.Count = 0 Then MessageBox.Show("没有可以拉取的数据。", "提示",
    ' MessageBoxButtons.OK, MessageBoxIcon.Information) Return False End If

    '    Return True
    'End Function

    ' 处理Form1的单个项目
    Private Sub ProcessForm1Item(srcItem As ListViewItem, index As Integer)
        Try
            Dim fileName = srcItem.SubItems(2).Text
            Dim format = Path.GetExtension(fileName).ToUpper().TrimStart("."c)
            Dim fullPath = Path.Combine(basePath, fileName)

            If File.Exists(fullPath) AndAlso SUPPORTED_FORMATS.Contains(Path.GetExtension(fileName).ToLower()) Then
                AddFileToListView(fullPath, index)
            End If
        Catch ex As Exception
            Debug.WriteLine($"处理项目出现错误: {ex.Message}")
        End Try
    End Sub

    ' 格式转换相关方法
    Private Function GetSelectedFormat() As String
        If rbPNG.Checked Then Return "PNG"
        If rbJPG.Checked Then Return "JPG"
        If rbBMP.Checked Then Return "BMP"
        If rbICO.Checked Then Return "ICO"
        Return DEFAULT_FORMAT
    End Function

    ' btnApplySelected：应用选中项格式并标记序号
    Private Sub btnApplySelected_Click(sender As Object, e As EventArgs) Handles btnApplySelected.Click
        Dim format = GetSelectedFormat()
        For Each item As ListViewItem In ListView1.SelectedItems
            If item.SubItems(3).Text <> format Then
                item.SubItems(3).Text = format
                'If Not item.SubItems(0).Text.EndsWith("*") Then
                '    item.SubItems(0).Text &= "*"
                'End If
                item.BackColor = Color.Lavender
            End If
        Next
    End Sub

    ' btnApplyAll：应用全部项格式并标记序号
    Private Sub btnApplyAll_Click(sender As Object, e As EventArgs) Handles btnApplyAll.Click
        If ListView1.Items.Count > 0 Then
            For Each item As ListViewItem In ListView1.Items
                item.Selected = True
            Next
        End If
        'Dim format = GetSelectedFormat()
        'For Each item As ListViewItem In ListView1.Items
        '    If item.SubItems(3).Text <> format Then
        '        item.SubItems(3).Text = format
        '        If Not item.SubItems(0).Text.EndsWith("*") Then
        '            item.SubItems(0).Text &= "*"
        '        End If
        '    End If
        'Next
    End Sub

    ' btnReset：还原格式并去掉序号的*
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each item As ListViewItem In ListView1.SelectedItems
            item.SubItems(3).Text = item.SubItems(2).Text
            'If item.SubItems(0).Text.EndsWith("*") Then
            '    item.SubItems(0).Text = item.SubItems(0).Text.TrimEnd("*"c)
            'End If
            item.BackColor = Color.White
        Next
    End Sub

    ' 保存/转换图片
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If ListView1.Items.Count = 0 Then Exit Sub

        Using fbd As New FolderBrowserDialog()
            fbd.Description = "选择一个位置，新建文件夹以保存转换副本。" ' 设置对话框标题
            If fbd.ShowDialog() = DialogResult.OK Then
                LastSavePath = fbd.SelectedPath
                ProcessImages(fbd.SelectedPath, True)
            End If
        End Using
    End Sub

    ' 修改后的 ProcessImages 方法
    Private Sub ProcessImages(savePath As String, isCopy As Boolean)
        If ListView1.Items.Count = 0 Then Exit Sub

        Dim quality = CInt(cobQuality.Value)
        Dim failedCount = 0

        ' 清空之前的失败记录
        failedFiles.Clear()

        With MetroProgressBar1
            .Visible = True
            .Maximum = ListView1.Items.Count
            .Value = 0
        End With

        For i As Integer = 0 To ListView1.Items.Count - 1
            Try
                Dim item = ListView1.Items(i)
                Dim sourcePath = item.Tag.ToString()
                Dim targetFormat = item.SubItems(3).Text
                Dim targetPath = GetTargetPath(sourcePath, targetFormat, savePath, isCopy)

                ' 执行转换
                ConvertImage(sourcePath, targetPath, targetFormat, quality)

                ' 覆盖模式：如果扩展名不同，删除原始文件，避免产生两个文件
                If Not isCopy Then
                    Dim sourceExt = Path.GetExtension(sourcePath).ToLower()
                    Dim targetExt = Path.GetExtension(targetPath).ToLower()
                    If sourceExt <> targetExt AndAlso File.Exists(sourcePath) Then
                        Try
                            File.Delete(sourcePath)
                        Catch ex As Exception
                            ' 删除失败时忽略，不影响整体流程
                        End Try
                    End If
                End If

                MetroProgressBar1.Value = i + 1
                Application.DoEvents()
            Catch ex As Exception
                failedCount += 1
                ' 记录失败文件信息
                failedFiles.Add((i + 1, ListView1.Items(i).SubItems(1).Text))
            End Try
        Next

        ' 覆盖模式：保存目录设为第一个文件的所在目录
        If Not isCopy AndAlso ListView1.Items.Count > 0 Then
            Dim firstItemPath = ListView1.Items(0).Tag.ToString()
            LastSavePath = Path.GetDirectoryName(firstItemPath)
        End If

        MetroProgressBar1.Visible = False
        ShowProcessResult(failedCount)
    End Sub


    Private Function GetTargetPath(sourcePath As String, format As String, savePath As String, isCopy As Boolean) As String
        If isCopy Then
            Return Path.Combine(savePath,
                              Path.GetFileNameWithoutExtension(sourcePath) & "." & format.ToLower())
        Else
            Return Path.ChangeExtension(sourcePath, format.ToLower())
        End If
    End Function

    ' 6. 修改ConvertImage方法以支持ICO格式
    Private Sub ConvertImage(sourcePath As String, targetPath As String, format As String, quality As Integer)
        Using sourceImg As Image = Image.FromFile(sourcePath)
            Select Case format.ToUpper()
                Case "PNG", "ICO"
                    ' PNG和ICO格式直接保存
                    sourceImg.Save(targetPath, If(format.ToUpper() = "PNG", ImageFormat.Png, ImageFormat.Icon))
                Case "JPG", "BMP"
                    ' 如果目标格式不支持透明度，则创建新图像并填充背景色
                    Using newBitmap As New Bitmap(sourceImg.Width, sourceImg.Height)
                        Using g As Graphics = Graphics.FromImage(newBitmap)
                            ' 填充背景色
                            g.Clear(backgroundColor)
                            ' 绘制原始图像
                            g.DrawImage(sourceImg, 0, 0, sourceImg.Width, sourceImg.Height)
                        End Using

                        ' 保存转换后的图像
                        Dim codec = GetCodec(format)
                        Dim parameters = GetEncoderParameters(format, quality)

                        If codec IsNot Nothing Then
                            newBitmap.Save(targetPath, codec, parameters)
                        Else
                            newBitmap.Save(targetPath)
                        End If
                    End Using
            End Select
        End Using
    End Sub

    Private Function GetCodec(format As String) As ImageCodecInfo
        Return ImageCodecInfo.GetImageEncoders().FirstOrDefault(
            Function(c) c.MimeType = "image/" & format.ToLower().Replace("jpg", "jpeg"))
    End Function

    Private Function GetEncoderParameters(format As String, quality As Integer) As EncoderParameters
        If format.ToUpper() = "JPG" Then
            Dim parameters = New EncoderParameters(1)
            parameters.Param(0) = New EncoderParameter(Encoder.Quality, CLng(quality))
            Return parameters
        End If
        Return Nothing
    End Function

    ' 辅助方法
    Private Sub ShowError(message As String, ex As Exception)
        MessageBox.Show($"{message}: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ' 修改ShowProcessResult方法以显示失败文件列表
    Private Sub ShowProcessResult(failedCount As Integer)
        If failedCount > 0 Then
            ' 创建失败文件列表
            Dim fileList = String.Join(vbCrLf & Environment.NewLine,
            failedFiles.Select(Function(f) $"{f.index}. {f.fileName}"))
            MessageBox.Show($"部分转换完成，其中{failedCount}个文件转换失败：" & vbCrLf & fileList,
                      "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If MessageBox.Show("文件转换完成。点击按钮打开", "提示",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Process.Start("explorer.exe", LastSavePath)
            End If
        Else
            If MessageBox.Show("文件转换完成。点击按钮打开", "提示",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Process.Start("explorer.exe", LastSavePath)
            End If
        End If
    End Sub

    'Private Sub UpdateFormTitle(source As String)
    '    Me.Text = $"转换 | {source}"
    'End Sub

    ' 删除选中项
    Private Sub bksbutton_Click(sender As Object, e As EventArgs) Handles bksbutton.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("请选择要删除的项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ListView1.SelectedItems.Count > 0 Then
            If MessageBox.Show("确定要移除选定项吗？", "确认移除",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                RemoveSelectedItems()
            End If
        End If
    End Sub

    Private Sub RemoveSelectedItems()
        Dim index = ListView1.SelectedItems(0).Index
        For Each item As ListViewItem In ListView1.SelectedItems
            ListView1.Items.Remove(item)
        Next
        UpdateSelectionAfterRemoval(index)
    End Sub

    Private Sub UpdateSelectionAfterRemoval(index As Integer)
        If ListView1.Items.Count > 0 Then
            If index < ListView1.Items.Count Then
                ListView1.Items(index).Selected = True
                ListView1.Items(index).Focused = True
            Else
                ListView1.Items(ListView1.Items.Count - 1).Selected = True
                ListView1.Items(ListView1.Items.Count - 1).Focused = True
            End If
        End If
    End Sub

    Private Sub ListViewPre_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        列表排序法(ListView1, e.Column)
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
            columnHeader.Text = columnHeader.Text.Replace("◇", "").Replace("◆", "")

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
            If i = 2 Or i = 3 Then
                If i = currentColumn Then
                    If currentOrder = SortOrder.Ascending Then
                        columnHeader.Text &= "◇"
                    Else
                        columnHeader.Text &= "◆"
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub rbPNG_CheckedChanged(sender As Object, e As EventArgs) Handles rbPNG.CheckedChanged
        UpdateBackgroundColorControl()
    End Sub

    Private Sub rbJPG_CheckedChanged(sender As Object, e As EventArgs) Handles rbJPG.CheckedChanged
        UpdateBackgroundColorControl()
        If rbJPG.Checked Then
            Label1.Enabled = True
            cobQuality.Enabled = True
        Else
            Label1.Enabled = False
            cobQuality.Enabled = False
        End If
    End Sub

    Private Sub rbBMP_CheckedChanged(sender As Object, e As EventArgs) Handles rbBMP.CheckedChanged
        UpdateBackgroundColorControl()
    End Sub

    Private Sub Form8_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.MinimumSize = New Size(371, 582)
        If Me.WindowState = FormWindowState.Maximized Then
            ListView1.Columns(0).Width = 60
            ListView1.Columns(1).Width = 600
            ListView1.Columns(2).Width = 100
            ListView1.Columns(3).Width = 100
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ListView1.Columns(0).Width = 60
            ListView1.Columns(1).Width = 120
            ListView1.Columns(2).Width = 60
            ListView1.Columns(3).Width = 60
        End If
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
                    Case Else ' 其他列（按字符串排序）
                        returnVal = String.Compare(item1.SubItems(col).Text, item2.SubItems(col).Text)
                End Select
            End If
            If order = SortOrder.Descending Then ' 根据排序顺序调整结果
                returnVal *= -1
            End If
            Return returnVal
        End Function
    End Class

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.Items.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("确认要关闭吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        ElseIf ListView1.Items.Count = 0 Then
            Me.Close()
        End If
    End Sub

    ' 双击预览功能
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim filePath As String = selectedItem.Tag.ToString()
            If File.Exists(filePath) Then
                Try
                    Process.Start(filePath)
                Catch ex As Exception
                    MessageBox.Show("无法打开文件。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("文件不存在: " & filePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub absbButton_CheckStateChanged(sender As Object, e As EventArgs) Handles absbButton.CheckStateChanged
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X + Form1.Width, Form1.Location.Y)
        Else
            'Me.CenterToScreen()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("请选择要删除的项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ListView1.SelectedItems.Count > 0 Then
            If MessageBox.Show("确定要移除选定项吗？", "确认移除",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                RemoveSelectedItems()
            End If
        End If
    End Sub

    Private Sub 移除选中项DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 移除选中项DToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("请选择要删除的项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If ListView1.SelectedItems.Count > 0 Then
            If MessageBox.Show("确定要移除选定项吗？", "确认移除",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                RemoveSelectedItems()
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        If ListView1.Items.Count > 0 Then
            For Each item As ListViewItem In ListView1.Items
                item.Selected = True
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim filePath As String = selectedItem.Tag.ToString()
            If File.Exists(filePath) Then
                Try
                    Process.Start(filePath)
                Catch ex As Exception
                    MessageBox.Show("无法打开文件。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("文件不存在: " & filePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 1 Then
            ListView1.ContextMenuStrip = ContextMenuStrip3
        Else
            ListView1.ContextMenuStrip = ContextMenuStrip1
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
            Color.Lavender, ' 渐变结束色
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
                Return Color.Lavender
            End Get
        End Property

        Public Overrides ReadOnly Property MenuBorder As Color
            Get
                Return Color.Lavender
            End Get
        End Property

    End Class

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ListView1_ColumnWidthChanged(sender As Object, e As ColumnWidthChangedEventArgs) Handles ListView1.ColumnWidthChanged
        Label3.Text = "列宽: " & ListView1.Columns(0).Width.ToString() &
            "列宽: " & ListView1.Columns(1).Width.ToString() &
            "列宽: " & ListView1.Columns(2).Width.ToString()
    End Sub

    Private Sub 还原列宽OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 还原列宽OToolStripMenuItem.Click
        If Me.WindowState = FormWindowState.Normal Then
            ListView1.Columns(0).Width = 60
            ListView1.Columns(1).Width = 120
            ListView1.Columns(2).Width = 60
            ListView1.Columns(3).Width = 60
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            ListView1.Columns(0).Width = 60
            ListView1.Columns(1).Width = 600
            ListView1.Columns(2).Width = 100
            ListView1.Columns(3).Width = 100
        End If
    End Sub

    Private Sub btnLoad_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLoad.MouseDown
        If e.Button = MouseButtons.Right Then
            ' 按住Shift，弹出文件夹选择对话框
            Using fbd As New FolderBrowserDialog()
                If fbd.ShowDialog() = DialogResult.OK Then
                    ListView1.Items.Clear()
                    LoadImagesFromDirectory(fbd.SelectedPath)
                    ' 显示文件夹路径
                    TextBox1.Text = fbd.SelectedPath
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()
                End If
            End Using
        ElseIf e.Button = MouseButtons.Middle Then
            ' 按住Control，从Form1.ListViewLT拉取数据
            basePath = Form1.openText.Text.Trim()
            ListView1.Items.Clear()
            Dim index = 1
            For Each item As ListViewItem In Form1.ListViewLT.Items
                ProcessForm1Item(item, index)
                index += 1
            Next
            TextBox1.Text = "来自 PicoFilter 加载页"
            TextBox1.SelectionStart = TextBox1.Text.Length
            TextBox1.ScrollToCaret()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("没有可转换的文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("此操作将覆盖原始文件，是否继续？", "确认覆盖",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            ' 直接覆盖，不选择新路径
            ProcessImages(String.Empty, False)
        End If
    End Sub

End Class
