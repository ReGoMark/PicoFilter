Imports System.IO
Imports System.Drawing.Imaging

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

    ' 初始化窗体
    ' 在Form8类中添加以下方法和在Form8_Load中调用
    ' 启用ListView1的双缓冲以减少闪烁
    Private Sub EnableListViewDoubleBuffering()
        Dim prop = GetType(Control).GetProperty("DoubleBuffered", Reflection.BindingFlags.Instance Or Reflection.BindingFlags.NonPublic)
        If prop IsNot Nothing Then
            prop.SetValue(ListView1, True, Nothing)
        End If
    End Sub

    ' 在Form8_Load方法中调用
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeControls()
        MetroProgressBar1.Value = False
        EnableListViewDoubleBuffering()
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
            .FlatStyle = FlatStyle.Flat
            .Visible = False  ' 默认隐藏
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
        Dim hasTransparency As Boolean = rbPNG.Checked
        colorButton.Visible = Not hasTransparency
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

    '    If Form1.ListViewRT.Items.Count = 0 Then
    '        MessageBox.Show("没有可以拉取的数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        Return False
    '    End If

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
        Return DEFAULT_FORMAT
    End Function

    Private Sub btnApplySelected_Click(sender As Object, e As EventArgs) Handles btnApplySelected.Click
        ApplyFormat(ListView1.SelectedItems)
    End Sub

    Private Sub btnApplyAll_Click(sender As Object, e As EventArgs) Handles btnApplyAll.Click
        ApplyFormat(ListView1.Items)
    End Sub

    Private Sub ApplyFormat(items As IEnumerable)
        Dim format = GetSelectedFormat()
        For Each item As ListViewItem In items
            item.SubItems(3).Text = format
        Next
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        For Each item As ListViewItem In ListView1.Items
            item.SubItems(3).Text = item.SubItems(2).Text
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

    'Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
    '    ProcessImages(String.Empty, False)
    'End Sub

    Private Sub ProcessImages(savePath As String, isCopy As Boolean)
        If ListView1.Items.Count = 0 Then Exit Sub

        Dim quality = CInt(cobQuality.Value)
        'Dim logPath = Path.Combine(Application.StartupPath, "convert_errors.log")
        Dim failedCount = 0

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

                ConvertImage(sourcePath, targetPath, targetFormat, quality)
                MetroProgressBar1.Value = i + 1
                Application.DoEvents()
            Catch ex As Exception
                failedCount += 1
                'LogError(logPath, ListView1.Items(i).Tag.ToString(), ex)
            End Try
        Next
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

    Private Sub ConvertImage(sourcePath As String, targetPath As String, format As String, quality As Integer)
        Using sourceImg As Image = Image.FromFile(sourcePath)
            ' 如果目标格式不支持透明度，则创建新图像并填充背景色
            If format.ToUpper() <> "PNG" Then
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
            Else
                ' PNG格式直接保存
                sourceImg.Save(targetPath, ImageFormat.Png)
            End If
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

    'Private Sub LogError(logPath As String, filePath As String, ex As Exception)
    '    File.AppendAllText(logPath,
    '        $"[{DateTime.Now}] 文件: {filePath}{Environment.NewLine}错误: {ex.Message}{Environment.NewLine}{Environment.NewLine}")
    'End Sub

    Private Sub ShowProcessResult(failedCount As Integer)
        If failedCount > 0 Then
            MessageBox.Show($"部分转换完成，其中{failedCount}个文件转换失败。",
                          "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

        If MessageBox.Show("确定要移除选定项吗？", "确认移除",
                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            RemoveSelectedItems()
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
            Label2.Enabled = True
        Else
            Label1.Enabled = False
            cobQuality.Enabled = False
            Label2.Enabled = False
        End If
    End Sub

    Private Sub rbBMP_CheckedChanged(sender As Object, e As EventArgs) Handles rbBMP.CheckedChanged
        UpdateBackgroundColorControl()
    End Sub

    Private Sub Form8_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Me.MinimumSize = New Size(371, 582)
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
End Class
