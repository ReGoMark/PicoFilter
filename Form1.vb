Imports System.IO
Imports OfficeOpenXml
Imports System.Drawing.Text
Imports MS.Internal

'考虑到.net支持的图片格式比较常规，像比较冷门的格式完全不支持，如webp等，后续需要添加第三方库才有可能解决。
'ver 1.2,2024/9/26

Public Class Form1
    Dim NUM As Integer
    Dim min As Integer
    Dim sumsize As Double '计量扫描总大小
    Dim output0, output1 As Double '右侧总和，左侧总和
    Dim jpg0, jpg1 As Double '计量右侧jpg数量，左侧jpg数量。下同
    Dim png0, png1 As Double
    Dim gif0, gif1 As Double
    Dim bmp0, bmp1 As Double
    Dim ico0, ico1 As Double
    Public toform5path As String
    Dim invldstr As String
    Dim tmtstr As String
    Dim qststr As String
    Dim labelstr As String
    Dim formattedString As String
    Public verinfo As String = "PicoFilter 1.6"

    ' 加载图片从指定文件夹到listview1
    Public Sub 加载图片(folderPath As String)
        NUM = 0
        min = 0
        sumsize = 0
        ListView0.Items.Clear()
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True
        Dim stopwatch As New Stopwatch()
        Dim 图片扩展名 As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico"}
        Dim files = Directory.GetFiles(folderPath).Where(Function(f) 图片扩展名.Contains(Path.GetExtension(f).ToLower())).ToList()
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0, pngCount As Integer = 0, gifCount As Integer = 0
        Dim bmpCount As Integer = 0, icoCount As Integer = 0
        Dim tagCount As Integer = 0

        ProgressBar1.Maximum = files.Count()

        Dim listViewItems As New List(Of ListViewItem) ' **批量存储 ListViewItem**
        stopwatch.Start()

        For Each file In files
            Try
                Dim fileName As String = Path.GetFileName(file)
                Dim fileInfo As New FileInfo(file)
                Dim fileSize As Double = fileInfo.Length ' **获取文件大小**
                Dim sizeFormatted As String = 格式化文件大小(fileSize) ' **转换大小单位**
                Dim format As String = fileInfo.Extension.ToUpper()              ' **优化：快速获取图片分辨率**
                Dim resolution As String = 获取图片分辨率(file)

                ' **计数不同格式**
                Select Case format
                    Case ".JPG", ".JPEG"
                        jpgCount += 1
                    Case ".PNG"
                        pngCount += 1
                    Case ".GIF"
                        gifCount += 1
                    Case ".ICO"
                        icoCount += 1
                    Case ".BMP"
                        bmpCount += 1
                End Select

                ' **创建 ListViewItem**
                Dim item As New ListViewItem(index.ToString())
                item.SubItems.Add(fileName)
                item.SubItems.Add(resolution)
                item.SubItems.Add(format)
                item.SubItems.Add(sizeFormatted) ' **使用自动转换的大小单位**

                ' **根据文件名高亮**
                Dim highlightMark As String = "" ' 额外列，默认留白
                If fileName.Contains("超时") Then
                    item.BackColor = Color.MistyRose
                    tagCount += 1
                    highlightMark = "*"
                End If
                If fileName.Contains("存疑") Then
                    item.BackColor = Color.Cornsilk
                    tagCount += 1
                    highlightMark = "*"
                End If
                If fileName.Contains("无效") Then
                    item.BackColor = Color.LightCyan
                    tagCount += 1
                    highlightMark = "*"
                End If
                item.SubItems.Add(highlightMark)
                listViewItems.Add(item)
                sumsize += fileSize
                index += 1
                ProgressBar1.Value += 1
                NUM += 1
                更新标题()

            Catch ex As Exception
                Dim opt = MessageBox.Show(ex.Message & vbCrLf & "点击是继续，点击否终止。", "失败", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If opt = DialogResult.No Then Exit For
            End Try
        Next

        ' **一次性添加到 ListView，减少 UI 刷新次数**
        ListView0.Items.AddRange(listViewItems.ToArray())

        stopwatch.Stop()
        min = stopwatch.ElapsedMilliseconds

        Dim foldername As String = Path.GetFileName(openText.Text)

        ' **计算总大小**
        Dim sumsizestr As String = 格式化文件大小(sumsize)

        ' **更新 Label6**
        Dim result As New List(Of String)
        result.Add($" 总计 {files.Count} 项")
        If tagCount > 0 Then result.Add($"标记 {tagCount}")
        If jpgCount > 0 Then result.Add($"JPG {jpgCount}")
        If pngCount > 0 Then result.Add($"PNG {pngCount}")
        If gifCount > 0 Then result.Add($"GIF {gifCount}")
        If bmpCount > 0 Then result.Add($"BMP {bmpCount}")
        If icoCount > 0 Then result.Add($"ICO {icoCount}")

        sumLabel0.Text = String.Join("  |  ", result)

        If Int(sumsize / 1024 / 1024) > 1024 Then
            sumsizestr = Int(sumsize * 100 / 1024 / 1024 / 1024) / 100 & " GB"
        Else
            If Int(sumsize / 1024 / 1024) > 1 Then
                sumsizestr = Int(sumsize * 100 / 1024 / 1024) / 100 & " MB"
            Else
                sumsizestr = Int(sumsize * 100 / 1024) / 100 & " KB"
            End If
        End If
        Me.Text = verinfo & "  |  " & foldername & "  |  " & sumsizestr
        更新统计信息()
        PlayNotificationSound()

        output1 = files.Count
        jpg1 = jpgCount
        png1 = pngCount
        bmp1 = bmpCount
        gif1 = gifCount
        ico1 = icoCount
        ProgressBar1.Visible = False
    End Sub

    Private Function 获取图片分辨率(filePath As String) As String
        Try
            Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                Using img As Image = Image.FromStream(fs, False, False)
                    Return $"{img.Width}×{img.Height}"
                End Using
            End Using
        Catch
            Return "未知"
        End Try
    End Function

    Private Function 格式化文件大小(sizeInBytes As Double) As String
        If sizeInBytes >= 1024 Then
            Return String.Format("{0:N0}", Math.Round(sizeInBytes / 1024, 0)) & " KB"
        Else
            Return String.Format("{0:N0}", sizeInBytes) & " B"
        End If
    End Function

    ' 加载图片从指定文件夹，到 ListView1
    Private Sub 筛选图片()
        ListView1.Items.Clear()

        ' 解析分辨率输入框
        Dim widthFilter As Integer = 0
        Dim heightFilter As Integer = 0
        If Not Integer.TryParse(wideButton.Text, widthFilter) Then widthFilter = 0
        If Not Integer.TryParse(htButton.Text, heightFilter) Then heightFilter = 0

        ' 获取筛选条件
        Dim jpgSelected As Boolean = jpgButton.Checked
        Dim pngSelected As Boolean = pngButton.Checked
        Dim gifSelected As Boolean = gifButton.Checked
        Dim bmpSelected As Boolean = bmpButton.Checked
        Dim icoSelected As Boolean = icoButton.Checked
        Dim resolutionSelected As Boolean = reslnButton.Checked
        Dim excludeResolution As Boolean = exButton.Checked   ' 分辨率反选筛选
        Dim volResolution As Boolean = volButton.Checked        ' 宽高互换
        Dim plsResolution As Boolean = moreButton.Checked       ' 大于
        Dim mnsResolution As Boolean = mnsButton.Checked        ' 小于
        Dim qstSelected As Boolean = qstCheck.Checked
        Dim tmtSelected As Boolean = tmtCheck.Checked
        Dim invldSelected As Boolean = invldCheck.Checked
        Dim matchingFileCount As Integer = 0
        Dim jpgCount As Integer = 0, pngCount As Integer = 0, gifCount As Integer = 0
        Dim bmpCount As Integer = 0, icoCount As Integer = 0
        Dim tagCount As Integer = 0

        ' 判断是否启用了格式筛选（任意一种格式被选中）
        Dim formatFilterEnabled As Boolean = jpgSelected Or pngSelected Or gifSelected Or bmpSelected Or icoSelected
        ' 分辨率筛选直接用 resolutionSelected 即可

        ' 遍历 ListView0 进行筛选
        For Each item As ListViewItem In ListView0.Items
            Dim resolutionParts As String() = item.SubItems(2).Text.Split("×"c)
            Dim width As Integer = Integer.Parse(resolutionParts(0))
            Dim height As Integer = Integer.Parse(resolutionParts(1))
            Dim format As String = item.SubItems(3).Text
            Dim sizeInKB As String = item.SubItems(4).Text ' 获取大小列的值

            ' **格式匹配**
            Dim formatsMatch As Boolean = False
            If jpgSelected AndAlso (format = ".JPG" OrElse format = ".JPEG") Then formatsMatch = True
            If pngSelected AndAlso format = ".PNG" Then formatsMatch = True
            If bmpSelected AndAlso format = ".BMP" Then formatsMatch = True
            If icoSelected AndAlso format = ".ICO" Then formatsMatch = True
            If gifSelected AndAlso format = ".GIF" Then formatsMatch = True

            ' **分辨率匹配**
            Dim resolutionMatch As Boolean = False
            If resolutionSelected Then
                If excludeResolution Then
                    resolutionMatch = (width <> widthFilter AndAlso height <> heightFilter)
                ElseIf volResolution Then
                    resolutionMatch = (width = heightFilter AndAlso height = widthFilter) OrElse (width = widthFilter AndAlso height = heightFilter)
                ElseIf plsResolution Then
                    resolutionMatch = (width > widthFilter AndAlso height > heightFilter)
                ElseIf mnsResolution Then
                    resolutionMatch = (width < widthFilter AndAlso height < heightFilter)
                Else
                    resolutionMatch = (width = widthFilter AndAlso height = heightFilter)
                End If
            End If

            ' **是否满足筛选**
            Dim isMatch As Boolean = False
            If formatFilterEnabled AndAlso resolutionSelected Then
                ' 同时启用了格式和分辨率筛选时，必须同时满足两者条件
                isMatch = formatsMatch AndAlso resolutionMatch
            ElseIf formatFilterEnabled Then
                isMatch = formatsMatch
            ElseIf resolutionSelected Then
                isMatch = resolutionMatch
            Else
                isMatch = False ' 如果两个筛选条件都未启用，则默认匹配所有
            End If

            ' **特殊标签筛选**
            Dim isSpecialMatch As Boolean = False
            Dim fileName As String = item.SubItems(1).Text
            If tmtSelected AndAlso fileName.Contains("超时") Then isSpecialMatch = True
            If qstSelected AndAlso fileName.Contains("存疑") Then isSpecialMatch = True
            If invldSelected AndAlso fileName.Contains("无效") Then isSpecialMatch = True

            ' **最终是否添加**
            If isMatch OrElse isSpecialMatch Then
                Dim newItem As New ListViewItem(item.SubItems(0).Text) ' 保留原始序号
                newItem.SubItems.Add(item.SubItems(1).Text) ' 文件名
                newItem.SubItems.Add(item.SubItems(2).Text) ' 分辨率
                newItem.SubItems.Add(item.SubItems(3).Text) ' 格式
                newItem.SubItems.Add(sizeInKB) ' 文件大小
                newItem.SubItems.Add(item.SubItems(5).Text) ' 格式
                ListView1.Items.Add(newItem)
                matchingFileCount += 1 ' 符合条件的文件计数自增

                ' 根据特殊条件设置背景颜色
                If tmtSelected AndAlso fileName.Contains("超时") Then
                    newItem.BackColor = Color.MistyRose
                    tagCount += 1
                End If
                If qstSelected AndAlso fileName.Contains("存疑") Then
                    newItem.BackColor = Color.Cornsilk
                    tagCount += 1
                End If
                If invldSelected AndAlso fileName.Contains("无效") Then
                    newItem.BackColor = Color.LightCyan
                    tagCount += 1
                End If

                ' 更新各格式计数
                Select Case format
                    Case ".JPG", ".JPEG"
                        jpgCount += 1
                    Case ".PNG"
                        pngCount += 1
                    Case ".GIF"
                        gifCount += 1
                    Case ".ICO"
                        icoCount += 1
                    Case ".BMP"
                        bmpCount += 1
                End Select
            End If
        Next
        '更新label2
        Dim result As New List(Of String)
        result.Add($" 结果 {matchingFileCount} 项")
        'If tagCount > 0 Then result.Add($"标记 {tagCount}")
        If jpgCount > 0 Then result.Add($"JPG {jpgCount}")
        If pngCount > 0 Then result.Add($"PNG {pngCount}")
        If gifCount > 0 Then result.Add($"GIF {gifCount}")
        If bmpCount > 0 Then result.Add($"BMP {bmpCount}")
        If icoCount > 0 Then result.Add($"ICO {icoCount}")

        sumLabel1.Text = String.Join("  |  ", result)
        PlayNotificationSound()
        output0 = matchingFileCount
        jpg0 = jpgCount
        png0 = pngCount
        bmp0 = bmpCount
        gif0 = gifCount
        ico0 = icoCount
    End Sub

    ' Button1 点击事件：选择文件夹并加载图片
    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                openText.Text = folderBrowserDialog.SelectedPath
                加载图片(folderBrowserDialog.SelectedPath)
                toform5path = folderBrowserDialog.SelectedPath
            End If
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toform5path
                Form5.toform1path = Me.toform5path
                Form5.LoadTreeView(Form5.toform1path)
            End If
        End Using
    End Sub

    ' 筛选按钮点击事件，用于开始筛选
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles fltButton.Click
        If moreButton.Checked = True And htButton.Text = "" Then htButton.Text = "0"
        If moreButton.Checked = True And wideButton.Text = "" Then wideButton.Text = "0"
        筛选图片()
        更新统计信息()
    End Sub

    ' 启用按钮的拖放功能
    Private Sub Button1_DragEnter(sender As Object, e As DragEventArgs) Handles openButton.DragEnter
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

    ' 拖入识别
    Private Sub Button1_DragDrop(sender As Object, e As DragEventArgs) Handles openButton.DragDrop
        Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Directory.Exists(droppedItems(0)) Then
            Dim folderPath As String = droppedItems(0)
            openText.Text = folderPath
            加载图片(folderPath)
            toform5path = folderPath
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toform5path
                Form5.toform1path = Me.toform5path
                Form5.LoadTreeView(Form5.toform1path)
            End If
        End If
    End Sub

    ' 启用按钮的拖放功能
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openButton.AllowDrop = True ' 启用拖放功能
        ComboBox1.SelectedIndex = 0
        ProgressBar1.Maximum = 0
        NUM = 0
        Me.Text = verinfo
        Me.KeyPreview = True ' 确保表单可以捕获键盘事件
    End Sub

    'Private Function 检测字体是否安装(fontName As String) As Boolean
    '    Dim fonts As New InstalledFontCollection()
    '    For Each font As FontFamily In fonts.Families
    '        If font.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase) Then
    '            Return True ' 找到字体，返回 True
    '        End If
    '    Next
    '    Return False ' 未找到字体，返回 False
    'End Function

    ' 在 Label5 上单击复制 ListView1 选中的文件路径
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles sltLabel0.Click
        If ListView0.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MessageBox.Show("路径已复制。" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 在 Label8 上单击时复制 ListView2 选中的文件路径
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles sltLabel1.Click
        If ListView1.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MessageBox.Show("路径已复制。" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' 双击 ListView1 中的项以打开文件
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView0.DoubleClick
        If ListView0.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 检查文件是否存在
            If File.Exists(filePath) Then
                ' 使用默认程序打开文件
                Process.Start(filePath)
            Else
                MessageBox.Show("文件不存在: " & filePath， “错误”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    ' 双击 ListView2 选中项打开文件
    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 使用默认程序打开文件
            Try
                Process.Start(filePath)
            Catch ex As Exception
                MessageBox.Show("无法打开。" & vbCrLf & ex.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    '点击按钮删除文件
    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delbutton.Click
        If ListView1.Items.Count = 0 Then
            MessageBox.Show("没有可删除的文件。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("确定要删除选定文件吗？操作不可逆！", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            For Each item As ListViewItem In ListView1.Items
                Dim fileName As String = item.SubItems(1).Text
                Dim sourcePath As String = Path.Combine(openText.Text, fileName) ' 获取完整路径

                Try
                    If File.Exists(sourcePath) Then
                        File.Delete(sourcePath) ' 删除文件
                    End If
                Catch ex As Exception
                    MessageBox.Show("删除失败。" & vbCrLf & ex.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next

            ' 删除成功后，从 ListView1 中移除项
            ListView1.Items.Clear()
        End If
    End Sub

    ' Button3 点击事件：复制筛选结果到指定文件夹
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles copyButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Dim targetFolder As String = folderBrowserDialog.SelectedPath

                For Each item As ListViewItem In ListView1.Items
                    Dim fileName As String = item.SubItems(1).Text
                    Dim sourcePath As String = Path.Combine(openText.Text, fileName) ' 源文件路径

                    Try
                        File.Copy(sourcePath, Path.Combine(targetFolder, fileName), True)
                    Catch ex As Exception
                        MessageBox.Show("复制失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
        End Using
    End Sub

    ' Button4 点击事件：移动筛选结果到指定文件夹
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles moveButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Dim targetFolder As String = folderBrowserDialog.SelectedPath

                For Each item As ListViewItem In ListView1.Items
                    Dim fileName As String = item.SubItems(1).Text
                    Dim sourcePath As String = Path.Combine(openText.Text, fileName) ' 源文件路径

                    Try
                        File.Move(sourcePath, Path.Combine(targetFolder, fileName))
                    Catch ex As Exception
                        MessageBox.Show("移动失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
        End Using

    End Sub

    ' Button5 点击事件：将筛选结果移动到扫描文件夹下的“筛选结果”文件夹内
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles dvdButton.Click
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmm")
        Dim sourceFolder As String = openText.Text ' 源文件夹路径
        Dim resultFolder As String = Path.Combine(sourceFolder, "隔离结果" & formattedDateTime)

        ' 创建“筛选结果”文件夹（如果不存在）
        If Not Directory.Exists(resultFolder) Then
            Directory.CreateDirectory(resultFolder)
        End If

        For Each item As ListViewItem In ListView1.Items
            Dim fileName As String = item.SubItems(1).Text
            Dim sourcePath As String = Path.Combine(sourceFolder, fileName) ' 源文件路径

            Try
                File.Move(sourcePath, Path.Combine(resultFolder, fileName))
            Catch ex As Exception
                MessageBox.Show("移动失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next

        ' 显示成功消息并打开筛选结果文件夹
        Dim opt = MessageBox.Show("隔离成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If opt = DialogResult.Yes Then
            ' 打开文件
            Process.Start("explorer.exe", resultFolder) ' 打开“筛选结果”文件夹
        End If
    End Sub


    ' Button7 点击事件：将 ListView1 中选中的文件添加到 ListView2 中
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles addButton.Click
        ' 遍历 ListView1 中的选中项
        For Each selectedItem As ListViewItem In ListView0.SelectedItems
            ' 检查 ListView2 中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(1).Text
            Dim existsInListView2 As Boolean = ListView1.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(1).Text = fileName)

            ' 如果 ListView2 中不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) ' 保留原始序号
                newItem.SubItems.Add(fileName) ' 文件名
                newItem.SubItems.Add(selectedItem.SubItems(2).Text) ' 分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) ' 格式
                newItem.SubItems.Add(selectedItem.SubItems(4).Text)
                ListView1.Items.Add(newItem) ' 添加到 ListView2
                ' 将新项目的字体颜色设置
                newItem.ForeColor = Color.Black
                newItem.BackColor = Color.GhostWhite
            End If
        Next
        ' 更新筛选结果的计数
        UpdateLabel2()
        更新统计信息()
    End Sub

    ' Button8 点击事件：删除 ListView2 中选中的项
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles bksbutton.Click
        ' 确保 ListView2 中有选中的项
        If ListView1.SelectedItems.Count > 0 Then
            ' 从 ListView2 中删除选中的项
            Dim index As Integer = ListView1.SelectedItems(0).Index
            For Each selectedItem As ListViewItem In ListView1.SelectedItems
                ListView1.Items.Remove(selectedItem)
            Next
            If ListView1.Items.Count > 0 Then
                If index < ListView1.Items.Count Then
                    ListView1.Items(index).Selected = True
                    ListView1.Items(index).Focused = True
                Else
                    ListView1.Items(ListView1.Items.Count - 1).Selected = True
                    ListView1.Items(ListView1.Items.Count - 1).Focused = True
                End If
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 更新筛选结果的计数
        UpdateLabel2()
        更新统计信息()
    End Sub
    '总在最前
    Private Sub CheckBox6_CheckStateChanged(sender As Object, e As EventArgs) Handles topButton.CheckStateChanged
        If topButton.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    ' 用于存储当前排序的列和顺序
    Private currentColumn As Integer = -1
    Private currentOrder As SortOrder = SortOrder.Ascending

    ' ListView1 的列标题单击事件
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView0.ColumnClick
        SortListView(ListView0, e.Column)
    End Sub

    ' ListView2 的列标题单击事件
    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        SortListView(ListView1, e.Column)
    End Sub

    '排序
    Private Sub SortListView(listView As ListView, column As Integer)
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

        ' 使用自定义比较器进行排序
        listView.ListViewItemSorter = New ListViewItemComparer(currentColumn, currentOrder)
        listView.Sort()
    End Sub

    ' 创建 ListViewItemComparer 类
    Public Class ListViewItemComparer
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
                    Case 0 ' **序号列（按整数排序）**
                        Dim num1 As Integer = Integer.Parse(item1.SubItems(col).Text)
                        Dim num2 As Integer = Integer.Parse(item2.SubItems(col).Text)
                        returnVal = num1.CompareTo(num2)

                    Case 4 ' **文件大小列（按数值大小排序）**
                        Dim size1 As Double = 解析文件大小(item1.SubItems(col).Text)
                        Dim size2 As Double = 解析文件大小(item2.SubItems(col).Text)
                        returnVal = size1.CompareTo(size2)

                    Case Else ' **其他列（按字符串排序）**
                        returnVal = String.Compare(item1.SubItems(col).Text, item2.SubItems(col).Text)
                End Select
            End If

            ' **根据排序顺序调整结果**
            If order = SortOrder.Descending Then
                returnVal *= -1
            End If

            Return returnVal
        End Function

        ' **解析文件大小**
        Private Function 解析文件大小(sizeText As String) As Double
            Dim sizeValue As Double = 0

            If sizeText.EndsWith(" KB") Then
                Double.TryParse(sizeText.Replace(" KB", "").Trim(), sizeValue)
                sizeValue *= 1024 ' 转换为字节
            ElseIf sizeText.EndsWith(" MB") Then
                Double.TryParse(sizeText.Replace(" MB", "").Trim(), sizeValue)
                sizeValue *= 1024 * 1024 ' 转换为字节
            ElseIf sizeText.EndsWith(" GB") Then
                Double.TryParse(sizeText.Replace(" GB", "").Trim(), sizeValue)
                sizeValue *= 1024 * 1024 * 1024 ' 转换为字节
            End If

            Return sizeValue
        End Function
    End Class



    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles wideButton.KeyPress
        ' 检查输入的字符是否是数字或控制字符（如退格）
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' 如果不是，则取消该输入
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles htButton.KeyPress
        ' 检查输入的字符是否是数字或控制字符（如退格）
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' 如果不是，则取消该输入
        End If
    End Sub
    '关于
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles infoButton.Click
        Form2.Show()
    End Sub

    Private Sub UpdateLabel2()
        ' 总文件数
        Dim totalFiles As Integer = ListView1.Items.Count
        ' 各种格式的文件数量
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        '### 1.2 new ###
        Dim bmpCount As Integer = 0
        Dim icoCount As Integer = 0

        ' 遍历 ListView2 统计文件格式数量
        For Each item As ListViewItem In ListView1.Items
            Dim format As String = item.SubItems(3).Text.ToUpper()

            Select Case format
                Case ".JPG", ".JPEG"
                    jpgCount += 1
                Case ".PNG"
                    pngCount += 1
                Case ".GIF"
                    gifCount += 1
                Case ".ICO"
                    icoCount += 1
                Case ".BMP"
                    bmpCount += 1

            End Select
        Next
        '更新label2
        Dim result As New List(Of String)
        result.Add($" [RSLT {totalFiles}]")
        If jpgCount > 0 Then result.Add($"JPG {jpgCount}")
        If pngCount > 0 Then result.Add($"PNG {pngCount}")
        If gifCount > 0 Then result.Add($"GIF {gifCount}")
        If bmpCount > 0 Then result.Add($"BMP {bmpCount}")
        If icoCount > 0 Then result.Add($"ICO {icoCount}")
        sumLabel1.Text = String.Join("  |  ", result)
    End Sub

    ' Label5 的 MouseHover 事件
    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles sltLabel0.MouseHover
        ' 检查 ListView1 是否有选中项
        If ListView0.SelectedItems.Count > 0 Then
            ' 获取 ListView1 选中项的文件名
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text
            ' 设置 ToolTip1 的文本
            ToolTip1.SetToolTip(sltLabel0, selectedItem.SubItems(1).Text & vbCrLf & "单击复制路径。")
        Else
            ' 如果没有选中项，显示默认提示
            ToolTip1.SetToolTip(sltLabel0, "单击复制路径。")
        End If
    End Sub

    ' Label8 的 MouseHover 事件
    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles sltLabel1.MouseHover
        ' 检查 ListView2 是否有选中项
        If ListView1.SelectedItems.Count > 0 Then
            ' 获取 ListView2 选中项的文件名
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text
            ' 设置 ToolTip1 的文本
            ToolTip1.SetToolTip(sltLabel1, fileName & vbCrLf & "单击复制路径。")
        Else
            ' 如果没有选中项，显示默认提示
            ToolTip1.SetToolTip(sltLabel1, "单击复制路径。")
        End If
    End Sub

    ' xlsxButton 的点击事件，用于将 ListView2 导出为 .xlsx 文件
    Private Sub xlsxButton_Click(sender As Object, e As EventArgs) Handles xlsxButton.Click
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmm")
        Dim jpgSelected As Boolean = jpgButton.Checked
        Dim pngSelected As Boolean = pngButton.Checked
        Dim gifSelected As Boolean = gifButton.Checked
        Dim resolutionSelected As Boolean = reslnButton.Checked
        Dim bmpSelected As Boolean = bmpButton.Checked
        Dim icoSelected As Boolean = icoButton.Checked
        Dim inreslnSelected As Boolean = exButton.Checked
        Dim volreslnSelected As Boolean = volButton.Checked
        Dim plsreslnSelected As Boolean = moreButton.Checked
        Dim mnsreslnSelected As Boolean = mnsButton.Checked

        Dim sumsizestr = FormatSize(sumsize)
        Dim minstr = FormatTime(min)
        Dim result = GetFilterConditions(jpgSelected, pngSelected, gifSelected, bmpSelected, icoSelected, inreslnSelected, volreslnSelected, resolutionSelected, plsreslnSelected, mnsreslnSelected)

        ' 选择保存路径
        Using saveFileDialog As New SaveFileDialog
            saveFileDialog.FileName = "筛选结果" & formattedDateTime & ".xlsx"
            saveFileDialog.Filter = "Excel 文件 (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "导出为 Excel 文件"

            ' 确认用户选择了保存路径
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim filePath As String = saveFileDialog.FileName
                    Dim fileInfo As New FileInfo(filePath)

                    ' 使用 EPPlus 创建 Excel 文件
                    Using package As New ExcelPackage(fileInfo)
                        ' 创建一个新的工作表
                        Dim worksheet = package.Workbook.Worksheets.Add("筛选结果" & formattedDateTime)

                        ' 添加 Label6 和 Label2 的内容在顶部
                        AddHeaderInfo(worksheet, sumLabel0.Text, sumsizestr, minstr, sumLabel1.Text, String.Join(" ", result))

                        ' 设置表头（对应 ListView2 的列，从第1行开始）
                        SetListViewHeaders(worksheet, ListView1)

                        ' 填充 ListView2 的数据（从第2行开始）
                        FillListViewData(worksheet, ListView1)

                        ' 保存 Excel 文件
                        package.Save()
                    End Using

                    Dim opt = MessageBox.Show("文件已导出成功！点击按钮立即打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If opt = DialogResult.Yes Then
                        ' 打开文件
                        Process.Start("explorer.exe", filePath)
                    End If
                Catch ex As Exception
                    MessageBox.Show("导出文件时发生错误: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    ' 格式化文件大小
    Private Function FormatSize(size As Long) As String
        If Int(size / 1024 / 1024 / 1024) > 0 Then
            Return Int(size * 100 / 1024 / 1024 / 1024) / 100 & " GB"
        ElseIf Int(size / 1024 / 1024) > 0 Then
            Return Int(size * 100 / 1024 / 1024) / 100 & " MB"
        Else
            Return Int(size * 100 / 1024) / 100 & " KB"
        End If
    End Function

    ' 格式化时间
    Private Function FormatTime(time As Long) As String
        If time < 1000 Then
            Return time & " ms"
        Else
            Return time / 1000 & " s"
        End If
    End Function

    ' 获取筛选条件字符串列表
    Private Function GetFilterConditions(jpgSelected As Boolean, pngSelected As Boolean, gifSelected As Boolean, bmpSelected As Boolean, icoSelected As Boolean, inreslnSelected As Boolean, volreslnSelected As Boolean, resolutionSelected As Boolean, plsreslnSelected As Boolean, mnsreslnSelected As Boolean) As List(Of String)
        Dim result As New List(Of String)
        Dim resolutionStr = $" {wideButton.Text} × {htButton.Text}"
        If inreslnSelected And resolutionSelected And Not volreslnSelected Then
            result.Add($"排除分辨率 {resolutionStr}")
        ElseIf resolutionSelected And Not inreslnSelected And Not volreslnSelected And Not plsreslnSelected And Not mnsreslnSelected Then
            result.Add($"分辨率 {resolutionStr}")
        ElseIf volreslnSelected And resolutionSelected And inreslnSelected Then
            result.Add($"旋转&排除分辨率 {resolutionStr}")
        ElseIf volreslnSelected And resolutionSelected And Not inreslnSelected Then
            result.Add($"旋转分辨率 {resolutionStr}")
        ElseIf plsreslnSelected And resolutionSelected And Not volreslnSelected And Not inreslnSelected And Not mnsreslnSelected Then
            result.Add($"大于分辨率 {resolutionStr}")
        ElseIf mnsreslnSelected And resolutionSelected And Not volreslnSelected And Not inreslnSelected And Not plsreslnSelected Then
            result.Add($"小于分辨率 {resolutionStr}")
        End If
        If jpgSelected Then result.Add("JPG")
        If pngSelected Then result.Add("PNG")
        If gifSelected Then result.Add("GIF")
        If bmpSelected Then result.Add("BMP")
        If icoSelected Then result.Add("ICO")
        formattedString = String.Join("  |  ", result)
        Return result
    End Function

    ' 添加表头信息到 Excel 工作表
    Private Sub AddHeaderInfo(worksheet As ExcelWorksheet, sumlabel0 As String, sumsizestr As String, minstr As String, sumlabel1 As String, filterConditions As String)
        worksheet.Cells("H1").Value = sumlabel0
        worksheet.Cells("H2").Value = " " & sumsizestr
        worksheet.Cells("H3").Value = " " & minstr
        worksheet.Cells("H4").Value = sumlabel1
        worksheet.Cells("H5").Value = " " & formattedString
        worksheet.Cells("H6").Value = labelstr
        worksheet.Cells("G1").Value = "已扫描"
        worksheet.Cells("G2").Value = "总大小"
        worksheet.Cells("G3").Value = "耗时"
        worksheet.Cells("G4").Value = "结果"
        worksheet.Cells("G5").Value = "条件"
        worksheet.Cells("G6").Value = "标记"
        worksheet.Cells("G1:G6").Style.Font.Bold = True
        worksheet.Cells("G1:G6").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
        worksheet.Cells("G1:G6").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender)
    End Sub

    ' 设置 ListView 的表头到 Excel 工作表
    Private Sub SetListViewHeaders(worksheet As ExcelWorksheet, listView As ListView)
        For i As Integer = 0 To listView.Columns.Count - 1
            worksheet.Cells(1, i + 1).Value = listView.Columns(i).Text
            Dim columnWidth As Double = listView.Columns(i).Width / 7 ' 调整比例使宽度接近视觉一致
            worksheet.Column(i + 1).Width = columnWidth
            worksheet.Column(i + 3).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right
        Next
        worksheet.Column(2).Width = listView.Columns(2).Width / 2
        worksheet.Column(8).Width = listView.Columns(2).Width / 2
        worksheet.Cells("A1:E1").Style.Font.Bold = True
        worksheet.Cells("A1:E1").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
        worksheet.Cells("A1:E1").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender)
    End Sub

    ' 填充 ListView 的数据到 Excel 工作表，并匹配背景颜色
    Private Sub FillListViewData(worksheet As ExcelWorksheet, listView As ListView)
        For i As Integer = 0 To listView.Items.Count - 1
            For j As Integer = 0 To listView.Items(i).SubItems.Count - 1
                Dim cell = worksheet.Cells(i + 2, j + 1)
                cell.Value = listView.Items(i).SubItems(j).Text

                ' 获取 ListView 项目的背景颜色
                Dim lvItemColor As Color = listView.Items(i).BackColor
                If lvItemColor = Color.Empty Then lvItemColor = listView.BackColor ' 默认使用 ListView 背景色

                ' 设置 Excel 单元格背景颜色
                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
                cell.Style.Fill.BackgroundColor.SetColor(lvItemColor)
            Next
        Next
    End Sub

    '条件全选
    Private Sub CheckBox10_CheckStateChanged(sender As Object, e As EventArgs) Handles mentionButton.CheckStateChanged
        If mentionButton.Checked = True Then
            jpgButton.Checked = True
            pngButton.Checked = True
            gifButton.Checked = True
            bmpButton.Checked = True
            icoButton.Checked = True
        Else
            jpgButton.Checked = False
            pngButton.Checked = False
            gifButton.Checked = False
            bmpButton.Checked = False
            icoButton.Checked = False
        End If
    End Sub
    '注册tooltip
    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles sumLabel0.MouseHover
        ToolTip1.SetToolTip(sumLabel0, sumLabel0.Text)
    End Sub
    '注册tooltip
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles sumLabel1.MouseHover
        ToolTip1.SetToolTip(sumLabel1, sumLabel1.Text)
    End Sub
    '双击填充分辨率
    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        htButton.Text = Val（wideButton.Text）
    End Sub
    '中键打开
    Private Sub TextBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles openText.MouseUp
        ' 判断是否为鼠标中键点击
        If e.Button = MouseButtons.Middle Then
            ' 调试输出，确认事件触发
            'MsgBox("鼠标中键点击触发")

            ' 获取文件夹路径
            Dim folderPath As String = openText.Text

            ' 检查路径是否为空并且文件夹是否存在
            If Not String.IsNullOrEmpty(folderPath) AndAlso Directory.Exists(folderPath) Then
                ' 打开文件夹
                Process.Start("explorer.exe", folderPath)
            Else
                ' 如果路径无效或文件夹不存在，提示错误信息
                MessageBox.Show("路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    '平分窗口
    Private Sub SplitContainer1_MouseUp(sender As Object, e As MouseEventArgs) Handles SplitContainer1.MouseUp
        If e.Button = MouseButtons.Middle Then
            If Me.WindowState = FormWindowState.Normal Then
                SplitContainer1.SplitterDistance = 509
            ElseIf Me.WindowState = FormWindowState.Maximized Then
                SplitContainer1.SplitterDistance = SplitContainer1.Width / 2
            End If

        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            ListView0.Columns(1).Width = ListView0.Width / 1.75
            ListView1.Columns(1).Width = ListView1.Width / 1.75
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ListView0.Columns(1).Width = 135
            ListView1.Columns(1).Width = 135
        End If
    End Sub

    '双重锁定
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If lockButton.Checked = True Then
            ' 检查 ListView1 和 ListView2 是否有内容
            If ListView1.Items.Count > 0 Then
                ' 弹出消息框
                Dim result As DialogResult = MessageBox.Show("确定要关闭吗？", "关闭", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If result = DialogResult.Cancel Then
                    ' 用户选择了取消，阻止关闭
                    e.Cancel = True
                End If
            End If
            ' 如果没有内容或用户选择了确定，窗口将继续关闭
            Form5.Close()
            Form2.Close()
            Form3.Close()
        End If

        'SaveConfig()
    End Sub

    '双重锁定判定
    Private Sub CheckBox12_CheckStateChanged(sender As Object, e As EventArgs) Handles lockButton.CheckStateChanged
        If lockButton.Checked = True Then
            lockButton.ImageIndex = 0
        Else
            lockButton.ImageIndex = 1
        End If
    End Sub

    '简单搜索
    Private Sub SearchListView(keyword As String)
        ' 遍历ListView中的每一行
        For Each item As ListViewItem In ListView0.Items
            If item.Text.ToLower().Contains(keyword.ToLower()) OrElse
           item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().
           Any(Function(subItem) subItem.Text.ToLower().Contains(keyword.ToLower())) Then
                ' 如果匹配到，设置该行为选中状态
                item.Selected = True
                item.EnsureVisible() ' 确保该行可见
            Else
                item.Selected = False
            End If
        Next
        PlayNotificationSound3()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        min += 1
    End Sub

    ' 在按钮单击或文本框文本更改事件中调用
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles searchButton0.Click
        Dim keyword As String = searchText.Text.Trim()
        If Not String.IsNullOrEmpty(keyword) Then
            SearchListView(keyword)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles searchButton1.Click
        Dim keyword As String = searchText.Text.Trim()
        If Not String.IsNullOrEmpty(keyword) Then
            SearchListView2(keyword)
        End If
    End Sub

    'Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
    '    If CheckBox6.Checked = True Then PlayNotificationSound2()
    'End Sub

    '搜索结果选定
    Private Sub SearchListView2(keyword As String)
        ' 遍历ListView中的每一行
        For Each item As ListViewItem In ListView1.Items
            If item.Text.ToLower().Contains(keyword.ToLower()) OrElse
           item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().
           Any(Function(subItem) subItem.Text.ToLower().Contains(keyword.ToLower())) Then
                ' 如果匹配到，设置该行为选中状态
                item.Selected = True
                item.EnsureVisible() ' 确保该行可见
            Else
                item.Selected = False
            End If
        Next
        PlayNotificationSound3()
    End Sub

    Private Sub 更新标题()
        Me.Text = verinfo & "  已扫描 " & NUM & “ / ” & ProgressBar1.Maximum & “ 项 , ” & Int(ProgressBar1.Value / ProgressBar1.Maximum * 1000) / 10 & " %"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles stsButton.Click
        更新统计信息()
        If Form3.Visible = True Then
            Form3.Close()
        Else
            Form3.Show()
        End If
    End Sub
    Private Sub PlayNotificationSound()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.RESOLVED, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles setting.Click
        Form4.Show()
    End Sub

    Private Sub rfhbutton_Click(sender As Object, e As EventArgs) Handles rfhButton.Click
        Dim folderPath As String = openText.Text
        If Directory.Exists(folderPath) Then
            加载图片(folderPath)
        Else
            MessageBox.Show("路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Form5.Visible = True Then
            Form5.TextBox1.Text = Me.toform5path
            Form5.toform1path = Me.toform5path
            Form5.LoadTreeView(Form5.toform1path)
        End If
    End Sub

    Private Sub PlayNotificationSound2()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.ALERT, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub treebutton_Click_1(sender As Object, e As EventArgs) Handles treeButton.Click
        If Form5.Visible = False Then
            Form5.Show()
        Else
            Form5.Close()
        End If
    End Sub

    Private Sub PlayNotificationSound3()
        Try
            ' 从资源播放音效
            My.Computer.Audio.Play(My.Resources.ALERT, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub pnlTimer_Tick(sender As Object, e As EventArgs) Handles pnlTimer.Tick
        ' 设置 Panel3 不可见
        Panel3.Visible = False
        plsButton.CheckState = CheckState.Unchecked
        ' 停止 Timer
        pnlTimer.Stop()
    End Sub

    Private Sub 更新统计信息()
        ' 各种格式的文件数量
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        Dim bmpCount As Integer = 0
        Dim icoCount As Integer = 0
        Dim qstCount As Integer = 0
        Dim tmtCount As Integer = 0
        Dim invldCount As Integer = 0

        ' 遍历 ListView2 统计文件格式数量
        For Each item As ListViewItem In ListView1.Items
            Dim format As String = item.SubItems(3).Text.ToUpper()
            Select Case format
                Case ".JPG", ".JPEG"
                    jpgCount += 1
                Case ".PNG"
                    pngCount += 1
                Case ".GIF"
                    gifCount += 1
                Case ".ICO"
                    icoCount += 1
                Case ".BMP"
                    bmpCount += 1
            End Select
        Next
        output0 = ListView1.Items.Count
        jpg0 = jpgCount
        png0 = pngCount
        bmp0 = bmpCount
        gif0 = gifCount
        ico0 = icoCount

        Dim sumsizestr As String
        If Int(sumsize / 1024 / 1024) > 1024 Then
            sumsizestr = Int(sumsize * 100 / 1024 / 1024 / 1024) / 100 & " GB"
        Else
            If Int(sumsize / 1024 / 1024) > 1 Then
                sumsizestr = Int(sumsize * 100 / 1024 / 1024) / 100 & " MB"
            Else
                sumsizestr = Int(sumsize * 100 / 1024) / 100 & " KB"
            End If
        End If
        Dim minstr As String
        If min < 1000 Then
            minstr = min & " ms"
        Else
            minstr = min / 1000 & " s"
        End If
        Form3.Label9.Text = output1
        Form3.Label10.Text = sumsizestr
        Form3.Label23.Text = minstr
        Form3.Label11.Text = png1
        Form3.Label12.Text = jpg1
        Form3.Label13.Text = bmp1
        Form3.Label14.Text = ico1
        Form3.Label15.Text = gif1
        Form3.Label16.Text = "→ " & output0 & " = " & output1 - output0

        Form3.Label28.Text = png0
        Form3.Label27.Text = jpg0
        Form3.Label26.Text = bmp0
        Form3.Label25.Text = ico0
        Form3.Label24.Text = gif0

        Form3.Label17.Text = Int(png1 / output1 * 1000) / 10 & " %"
        Form3.Label18.Text = Int(jpg1 / output1 * 1000) / 10 & " %"
        Form3.Label19.Text = Int(bmp1 / output1 * 1000) / 10 & " %"
        Form3.Label20.Text = Int(ico1 / output1 * 1000) / 10 & " %"
        Form3.Label21.Text = Int(gif1 / output1 * 1000) / 10 & " %"
        Form3.Label22.Text = “- ” & (Int(output0 / output1 * 1000) / 10) & " %"

        Form3.Label40.Text = Int(png0 / output0 * 1000) / 10 & " %"
        Form3.Label39.Text = Int(jpg0 / output0 * 1000) / 10 & " %"
        Form3.Label38.Text = Int(bmp0 / output0 * 1000) / 10 & " %"
        Form3.Label37.Text = Int(ico0 / output0 * 1000) / 10 & " %"
        Form3.Label36.Text = Int(gif0 / output0 * 1000) / 10 & " %"
        Dim result As Double = 100 - (Int(png0 / output0 * 1000) / 10 + Int(jpg0 / output0 * 1000) / 10 + Int(bmp0 / output0 * 1000) / 10 + Int(ico0 / output0 * 1000) / 10 + Int(gif0 / output0 * 1000) / 10)
        Form3.Label42.Text = Math.Round(result, 1) & “ %”

        If png1 > 0 Then
            Form3.Label3.Text = "...PNG √"
        Else
            Form3.Label3.Text = "...PNG"
        End If
        If jpg1 > 0 Then
            Form3.Label4.Text = "...JPG √"
        Else
            Form3.Label4.Text = "...JPG"
        End If
        If bmp1 > 0 Then
            Form3.Label5.Text = "...BMP √"
        Else
            Form3.Label5.Text = "...BMP"
        End If
        If ico1 > 0 Then
            Form3.Label6.Text = "...ICO √"
        Else
            Form3.Label6.Text = "...ICO"
        End If
        If gif1 > 0 Then
            Form3.Label7.Text = "...GIF √"
        Else
            Form3.Label7.Text = "...GIF"
        End If

        If png1 - png0 <> png1 Then
            Form3.Label33.Text = "...PNG √"
        Else
            Form3.Label33.Text = "...PNG"
        End If
        If jpg1 - jpg0 <> jpg1 Then
            Form3.Label32.Text = "...JPG √"
        Else
            Form3.Label32.Text = "...JPG"
        End If
        If bmp1 - bmp0 <> bmp1 Then
            Form3.Label31.Text = "...BMP √"
        Else
            Form3.Label31.Text = "...BMP"
        End If
        If ico1 - ico0 <> ico1 Then
            Form3.Label30.Text = "...ICO √"
        Else
            Form3.Label30.Text = "...ICO"
        End If
        If gif1 - gif0 <> gif1 Then
            Form3.Label29.Text = "...GIF √"
        Else
            Form3.Label29.Text = "...GIF"
        End If

        For Each item As ListViewItem In ListView0.Items
            ' 获取文件名（假设文件名在第二列，即索引 1）
            Dim fileName As String = item.SubItems(1).Text
            ' 判断文件名是否包含 "超时"
            If fileName.Contains("超时") Then
                tmtCount += 1
            End If
            If fileName.Contains("存疑") Then
                qstCount += 1
            End If
            If fileName.Contains("无效") Then
                invldCount += 1
            End If
        Next
        Form3.Label45.Text = " 无效 " & invldCount & “  存疑 ” & qstCount & “  超时 ” & tmtCount
        labelstr = " 无效 " & invldCount & “  |  存疑 ” & qstCount & “  |  超时 ” & tmtCount
    End Sub

    Private Sub 以此为筛选条件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 以此为筛选条件ToolStripMenuItem.Click
        If ListView0.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim format As String = selectedItem.SubItems(3).Text.ToUpper()
            Dim resolution As String() = selectedItem.SubItems(2).Text.Split("×"c)
            Dim width As String = resolution(0)
            Dim height As String = resolution(1)

            ' 自动勾选对应的 CheckBox
            jpgButton.Checked = (format = ".JPG" Or format = ".JPEG")
            pngButton.Checked = (format = ".PNG")
            gifButton.Checked = (format = ".GIF")
            bmpButton.Checked = (format = ".BMP")
            icoButton.Checked = (format = ".ICO")
            reslnButton.Checked = True

            ' 填充分辨率到对应的文本框
            wideButton.Text = width
            htButton.Text = height
        End If
    End Sub

    ' 在 ListView0 的 SelectedIndexChanged 事件中禁用 ContextMenuStrip1
    Private Sub ListView0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView0.SelectedIndexChanged
        If ListView0.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim selectedCount As Integer = ListView0.SelectedItems.Count
            If ListView0.SelectedItems.Count > 1 Then
                sltLabel0.Text = $" 复选 {selectedCount} 项"
                ListView0.ContextMenuStrip = ContextMenuStrip2
            Else
                sltLabel0.Text = $" [{selectedItem.SubItems(0).Text}]  |  {selectedItem.SubItems(1).Text}  |  {selectedItem.SubItems(2).Text}  |  {selectedItem.SubItems(4).Text}"
                ListView0.ContextMenuStrip = ContextMenuStrip1
            End If
        Else
            sltLabel0.Text = " 就绪"
            ListView0.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    ' 当 ListView2 中的项被选中时，在 Label8 显示选中的序号和文件名
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim selectedCount As Integer = ListView1.SelectedItems.Count
            If ListView1.SelectedItems.Count > 1 Then
                sltLabel1.Text = $" 复选 {selectedCount} 项"
                ListView1.ContextMenuStrip = ContextMenuStrip5
            Else
                sltLabel1.Text = $" [{selectedItem.SubItems(0).Text}]  |  {selectedItem.SubItems(1).Text}  |  {selectedItem.SubItems(2).Text}  |  {selectedItem.SubItems(4).Text}"
                ListView1.ContextMenuStrip = ContextMenuStrip3
            End If
        Else
            sltLabel1.Text = " 等待"
            ListView1.ContextMenuStrip = ContextMenuStrip3
        End If
    End Sub

    Private Sub 打开文件所在位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开文件所在位置ToolStripMenuItem.Click
        If ListView0.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 检查文件是否存在
            If File.Exists(filePath) Then
                ' 使用资源管理器打开文件所在文件夹并选中文件
                Process.Start("explorer.exe", $"/select,""{filePath}""")
            Else
                MessageBox.Show("文件不存在: " & filePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub 复制地址ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制地址ToolStripMenuItem.Click
        If ListView0.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListView0.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MessageBox.Show("路径已复制。" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub 添加到右侧ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加到右侧ToolStripMenuItem.Click
        ' 遍历 ListView1 中的选中项
        For Each selectedItem As ListViewItem In ListView0.SelectedItems
            ' 检查 ListView2 中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(1).Text
            Dim existsInListView2 As Boolean = ListView1.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(1).Text = fileName)

            ' 如果 ListView2 中不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) ' 保留原始序号
                newItem.SubItems.Add(fileName) ' 文件名
                newItem.SubItems.Add(selectedItem.SubItems(2).Text) ' 分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) ' 格式
                newItem.SubItems.Add(selectedItem.SubItems(4).Text)
                ListView1.Items.Add(newItem) ' 添加到 ListView2
                ' 将新项目的字体颜色设置
                newItem.ForeColor = Color.Black
                newItem.BackColor = Color.GhostWhite
            End If
        Next
        ' 更新筛选结果的计数
        UpdateLabel2()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        ' 遍历 ListView1 中的选中项
        For Each selectedItem As ListViewItem In ListView0.SelectedItems
            ' 检查 ListView2 中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(1).Text
            Dim existsInListView2 As Boolean = ListView1.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(1).Text = fileName)

            ' 如果 ListView2 中不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) ' 保留原始序号
                newItem.SubItems.Add(fileName) ' 文件名
                newItem.SubItems.Add(selectedItem.SubItems(2).Text) ' 分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) ' 格式
                newItem.SubItems.Add(selectedItem.SubItems(4).Text)
                ListView1.Items.Add(newItem) ' 添加到 ListView2
                ' 将新项目的字体颜色设置
                newItem.ForeColor = Color.Black
                newItem.BackColor = Color.GhostWhite
            End If
        Next
        ' 更新筛选结果的计数
        UpdateLabel2()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim format As String = selectedItem.SubItems(3).Text.ToUpper()
            Dim resolution As String() = selectedItem.SubItems(2).Text.Split("×"c)
            Dim width As String = resolution(0)
            Dim height As String = resolution(1)

            ' 自动勾选对应的 CheckBox
            jpgButton.Checked = (format = ".JPG" Or format = ".JPEG")
            pngButton.Checked = (format = ".PNG")
            gifButton.Checked = (format = ".GIF")
            bmpButton.Checked = (format = ".BMP")
            icoButton.Checked = (format = ".ICO")
            reslnButton.Checked = True

            ' 填充分辨率到对应的文本框
            wideButton.Text = width
            htButton.Text = height
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 检查文件是否存在
            If File.Exists(filePath) Then
                ' 使用资源管理器打开文件所在文件夹并选中文件
                Process.Start("explorer.exe", $"/select,""{filePath}""")
            Else
                MessageBox.Show("文件不存在: " & filePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If ListView1.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MessageBox.Show("路径已复制。" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        ' 确保 ListView2 中有选中的项
        If ListView1.SelectedItems.Count > 0 Then
            ' 从 ListView2 中删除选中的项
            Dim index As Integer = ListView1.SelectedItems(0).Index
            For Each selectedItem As ListViewItem In ListView1.SelectedItems
                ListView1.Items.Remove(selectedItem)
            Next
            If ListView1.Items.Count > 0 Then
                If index < ListView1.Items.Count Then
                    ListView1.Items(index).Selected = True
                    ListView1.Items(index).Focused = True
                Else
                    ListView1.Items(ListView1.Items.Count - 1).Selected = True
                    ListView1.Items(ListView1.Items.Count - 1).Focused = True
                End If
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 更新筛选结果的计数
        UpdateLabel2()
        更新统计信息()
    End Sub

    Private Sub 删除选中项DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除选中项DToolStripMenuItem.Click
        ' 确保 ListView2 中有选中的项
        If ListView1.SelectedItems.Count > 0 Then
            ' 从 ListView2 中删除选中的项
            Dim index As Integer = ListView1.SelectedItems(0).Index
            For Each selectedItem As ListViewItem In ListView1.SelectedItems
                ListView1.Items.Remove(selectedItem)
            Next
            If ListView1.Items.Count > 0 Then
                If index < ListView1.Items.Count Then
                    ListView1.Items(index).Selected = True
                    ListView1.Items(index).Focused = True
                Else
                    ListView1.Items(ListView1.Items.Count - 1).Selected = True
                    ListView1.Items(ListView1.Items.Count - 1).Focused = True
                End If
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 更新筛选结果的计数
        UpdateLabel2()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        SplitContainer1.SplitterDistance = SplitContainer1.Width / 3
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        SplitContainer1.SplitterDistance = SplitContainer1.Width / 2
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        SplitContainer1.SplitterDistance = SplitContainer1.Width / 3 * 2
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        ListView0.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub 列宽恢复默认OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 列宽恢复默认OToolStripMenuItem.Click
        ListView0.Columns(0).Width = 50
        ListView0.Columns(1).Width = 170
        ListView0.Columns(2).Width = 110
        ListView0.Columns(3).Width = 60
        ListView0.Columns(4).Width = 90
    End Sub

    Private Sub 还原列宽OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 还原列宽OToolStripMenuItem.Click
        ListView1.Columns(0).Width = 50
        ListView1.Columns(1).Width = 170
        ListView1.Columns(2).Width = 110
        ListView1.Columns(3).Width = 60
        ListView1.Columns(4).Width = 90
    End Sub

    Private Sub CheckBox14_CheckStateChanged(sender As Object, e As EventArgs) Handles plsButton.CheckStateChanged
        If plsButton.Checked = True Then
            Panel3.Visible = True
            '启动 Timer， 3 秒后触发 Tick 事件
            pnlTimer.Interval = 4000 ' 设置间隔为 3000 毫秒（3 秒）
            pnlTimer.Start()
        ElseIf plsButton.Checked = False Then
            Panel3.Visible = False
        End If
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles wideButton.MouseHover
        ToolTip1.SetToolTip(wideButton, "宽度 " & wideButton.Text)
    End Sub

    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles htButton.MouseHover
        ToolTip1.SetToolTip(htButton, "高度 " & htButton.Text)
    End Sub

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        ' 获取 Form3 实例
        Dim subForm As Form3 = TryCast(Application.OpenForms("Form3"), Form3)
        If subForm IsNot Nothing Then
            If Form3.absbButton.CheckState = CheckState.Checked Then
                ' 让 Form3 吸附在 Form1 右侧
                subForm.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
            End If
        End If
        ' 获取 Form5 实例
        Dim subForm1 As Form5 = TryCast(Application.OpenForms("Form5"), Form5)
        If subForm1 IsNot Nothing Then
            If Form5.absbButton.CheckState = CheckState.Checked Then
                ' 让 Form5 吸附在 Form1 右侧
                subForm1.Location = New Point(Me.Location.X - Form5.Width, Me.Location.Y)
            End If
        End If
    End Sub

    Private Sub openText_TextChanged(sender As Object, e As EventArgs) Handles openText.TextChanged
        Me.openText.SelectionStart = Me.openText.Text.Length
        Me.openText.ScrollToCaret()
        'If Form5.Visible = True Then
        '    Form5.toform1path = toform5path
        '    Form5.LoadTreeView(toform5path)
        'End If
    End Sub
    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.CenterToScreen()
    End Sub

    Private Sub ListView0_DragDrop(sender As Object, e As DragEventArgs) Handles ListView0.DragDrop
        Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Directory.Exists(droppedItems(0)) Then
            Dim folderPath As String = droppedItems(0)
            openText.Text = folderPath
            加载图片(folderPath)
            toform5path = folderPath
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toform5path
                Form5.toform1path = Me.toform5path
                Form5.LoadTreeView(Form5.toform1path)
            End If
        End If
    End Sub

    Private Sub ListView0_DragEnter(sender As Object, e As DragEventArgs) Handles ListView0.DragEnter
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
End Class