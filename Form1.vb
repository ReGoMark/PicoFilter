Imports System.Drawing.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.FileIO
Imports OfficeOpenXml

'考虑到.net支持的图片格式只有这五种，像其他图像格式如webp等，后续需要添加第三方库才有可能解决。
'ver 1.2, 2024/9/26, ver 2.0, 2025/6/10

Public Class Form1
    Dim loadedCount As Integer '计数已加载文件数量
    Dim loadedTime As Integer '计量扫描文件耗时
    Dim sumSize As Double '计量扫描总大小
    Dim sumRT, sumLT As Double '计量右侧项目总和，左侧项目总和
    Dim jpgRT, jpgLT As Double '计量右侧和左侧jpg数量，下同
    Dim pngRT, pngLT As Double
    Dim gifRT, gifLT As Double
    Dim bmpRT, bmpLT As Double
    Dim icoRT, icoLT As Double
    Dim mark1 As String = "无效"
    Dim mark2 As String = "存疑"
    Dim mark3 As String = "超时"
    Public consoletime As String
    Dim lbldStr As String '存储标记文件的文本
    Dim formattedString As String '存储格式化后的字符串
    Public toForm5Path As String '传递路径文本到form5
    Public verinfo As String = "PicoFilter 2.0" '存储版本信息
    Private opttext As String = "使用提示" '存储操作按钮默认文本
    Private optcolor As Color = Color.White '存储操作按钮默认颜色
    Private currentColumn As Integer = -1 '存储当前排序的列和顺序
    Private currentOrder As SortOrder = SortOrder.Ascending '存储当前排序的列和顺序
    Private currentItem As ListViewItem = Nothing
    Private isMouseOverTab As Boolean = False
    Private WithEvents optTimer As New Timer() '计量操作按钮显示时间

    Public Sub 加载图片(folderPath As String)
        '计数器重置
        loadedCount = 0
        loadedTime = 0
        sumSize = 0
        ListViewLT.Items.Clear()
        ListViewRT.Items.Clear()
        ProgressBar1.Value = 0
        ProgressBar1.Visible = True

        Dim loadedTimer As New Stopwatch()
        Dim 图片扩展名 As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico"}
        Dim files = Directory.GetFiles(folderPath).Where(Function(f) 图片扩展名.Contains(Path.GetExtension(f).ToLower())).ToList()
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0,
            pngCount As Integer = 0,
            gifCount As Integer = 0,
            bmpCount As Integer = 0,
            icoCount As Integer = 0
        Dim tagCount As Integer = 0

        Dim folderName As String = Path.GetFileName(openText.Text) '截取文件夹名
        Dim sumSizeStr As String = 格式化文件大小(sumSize)  '计量扫描文件的总大小

        ProgressBar1.Maximum = files.Count()

        Dim listViewItems As New List(Of ListViewItem) ' **批量存储 ListViewItem**
        loadedTimer.Start()

        For Each file In files
            Try
                Dim fileName As String = Path.GetFileName(file)
                Dim fileInfo As New FileInfo(file)
                Dim fileSize As Double = fileInfo.Length ' 获取文件大小
                Dim sizeFormatted As String = 格式化文件大小(fileSize) ' 转换大小单位
                Dim format As String = fileInfo.Extension.ToUpper() '快速获取图片分辨率
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

                '创建ListViewItem
                Dim item As New ListViewItem(index.ToString())
                '文件名高亮标记
                If tagButton.Checked = True Then
                    Dim highlightMark As String = "" '未标记项目的处理办法
                    If fileName.Contains(mark3) Then
                        'item.BackColor = Color.MistyRose
                        tagCount += 1
                        highlightMark = "★"
                    End If
                    If fileName.Contains(mark2) Then
                        'item.BackColor = Color.Cornsilk
                        tagCount += 1
                        highlightMark = "★"
                    End If
                    If fileName.Contains(mark1) Then
                        'item.BackColor = Color.LightCyan
                        tagCount += 1
                        highlightMark = "★"
                    End If
                    item.SubItems.Add(highlightMark) '添加标记
                    If tagCount > 0 Then
                        MetroTabPage5.Text = "星标 " & tagCount
                    Else
                        MetroTabPage5.Text = "星标"
                    End If

                Else
                    MetroTabPage5.Text = "星标"
                    item.SubItems.Add(“”) '添加标记
                End If
                item.SubItems.Add(fileName) '添加文件名
                item.SubItems.Add(resolution) '添加分辨率
                item.SubItems.Add(format) '添加格式
                item.SubItems.Add(sizeFormatted) '添加大小
                item.SubItems.Add(fileInfo.LastWriteTime.ToString("yy/MM/dd, HH:mm:ss")) ' **第四列：修改日期**
                listViewItems.Add(item)

                sumSize += fileSize
                index += 1
                ProgressBar1.Value += 1
                loadedCount += 1
                更新标题()
            Catch ex As Exception
                Dim opt = MessageBox.Show(ex.Message & vbCrLf & "加载意外中断，可能是由于内存不足。” & vbCrLf & “点击是继续，点击否终止。", "失败", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If opt = DialogResult.No Then Exit For
            End Try
        Next
        ListViewLT.Items.AddRange(listViewItems.ToArray())  '一次性添加到 ListView，减少 UI 刷新次数

        loadedTimer.Stop()
        loadedTime = loadedTimer.ElapsedMilliseconds '加载时间计时器结算

        Dim result As New List(Of String)
        result.Add($"总计 {files.Count} 项")
        If tagCount > 0 Then result.Add($"星标 {tagCount}")
        If jpgCount > 0 Then result.Add($"JPG {jpgCount}")
        If pngCount > 0 Then result.Add($"PNG {pngCount}")
        If gifCount > 0 Then result.Add($"GIF {gifCount}")
        If bmpCount > 0 Then result.Add($"BMP {bmpCount}")
        If icoCount > 0 Then result.Add($"ICO {icoCount}")
        If Int(sumSize / 1024 / 1024) > 1024 Then
            sumSizeStr = Int(sumSize * 100 / 1024 / 1024 / 1024) / 100 & " GB"
        Else
            If Int(sumSize / 1024 / 1024) > 1 Then
                sumSizeStr = Int(sumSize * 100 / 1024 / 1024) / 100 & " MB"
            Else
                sumSizeStr = Int(sumSize * 100 / 1024) / 100 & " KB"
            End If
        End If

        If tagCount > 0 Then
            optChange("提示：存在星标文件 " & tagCount & “ 项。”, Color.White)
        End If
        sumLblLT.Text = String.Join("  |  ", result)
        Me.Text = verinfo & "  |  " & folderName & "  |  " & sumSizeStr

        ProgressBar1.Visible = False
        更新统计信息()
        PlayNotificationSound3()
        'Form9.RichTextBox1.Text += consoletime & "Read Folder From: " & openText.Text & vbCrLf

        sumLT = files.Count
        jpgLT = jpgCount
        pngLT = pngCount
        bmpLT = bmpCount
        gifLT = gifCount
        icoLT = icoCount
    End Sub

    Private Function 获取图片分辨率(filePath As String) As String
        Try
            Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                Using img As Image = Image.FromStream(fs, False, False)
                    Return $"{img.Width}×{img.Height}"
                End Using
            End Using
        Catch
            Return "0×0"

        End Try
    End Function

    Private Function 格式化文件大小(sizeInBytes As Double) As String
        If sizeInBytes >= 1024 Then
            Return String.Format("{0:N0}", Math.Round(sizeInBytes / 1024, 0)) & " KB"
        Else
            Return String.Format("{0:N0}", sizeInBytes) & " B"
        End If
    End Function

    ' 加载图片从指定文件夹，到右侧
    Private Sub 筛选图片()
        ListViewRT.Items.Clear()

        ' 解析分辨率输入框
        Dim widthFilter As Integer = 0
        Dim heightFilter As Integer = 0
        If Not Integer.TryParse(widText.Text, widthFilter) Then widthFilter = 0
        If Not Integer.TryParse(htText.Text, heightFilter) Then heightFilter = 0

        ' 获取筛选条件
        Dim jpgSelected As Boolean = jpgButton.Checked 'jpg筛选
        Dim pngSelected As Boolean = pngButton.Checked 'png筛选
        Dim gifSelected As Boolean = gifButton.Checked 'gif筛选
        Dim bmpSelected As Boolean = bmpButton.Checked 'bmp筛选
        Dim icoSelected As Boolean = icoButton.Checked 'ico筛选
        Dim reslnSelected As Boolean = reslnButton.Checked '分辨率筛选
        Dim exreslnSelected As Boolean = exButton.Checked '分辨率排除筛选
        Dim volreslnSelected As Boolean = volButton.Checked '分辨率宽高互换筛选
        Dim plsreslnSelected As Boolean = moreButton.Checked '分辨率大于筛选
        Dim mnsreslnSelected As Boolean = mnsButton.Checked '分辨率小于筛选

        Dim jpgCount As Integer = 0,
            pngCount As Integer = 0,
            gifCount As Integer = 0,
            bmpCount As Integer = 0,
            icoCount As Integer = 0
        Dim matchingFileCount As Integer = 0
        Dim tagCount As Integer = 0

        '判断是否启用了格式筛选
        Dim formatFilterEnabled As Boolean = jpgSelected Or pngSelected Or gifSelected Or bmpSelected Or icoSelected
        '遍历左侧数据进行筛选
        For Each item As ListViewItem In ListViewLT.Items
            Dim resolutionParts As String() = item.SubItems(3).Text.Split("×"c)
            Dim width As Integer = Integer.Parse(resolutionParts(0))
            Dim height As Integer = Integer.Parse(resolutionParts(1))
            Dim format As String = item.SubItems(4).Text
            Dim sizeKB As String = item.SubItems(5).Text
            '格式匹配
            Dim formatsMatch As Boolean = False
            If jpgSelected AndAlso (format = ".JPG" OrElse format = ".JPEG") Then formatsMatch = True
            If pngSelected AndAlso format = ".PNG" Then formatsMatch = True
            If bmpSelected AndAlso format = ".BMP" Then formatsMatch = True
            If icoSelected AndAlso format = ".ICO" Then formatsMatch = True
            If gifSelected AndAlso format = ".GIF" Then formatsMatch = True
            '分辨率匹配
            Dim resolutionMatch As Boolean = False
            If reslnSelected Then
                If exreslnSelected Then
                    resolutionMatch = (width <> widthFilter AndAlso height <> heightFilter)
                ElseIf volreslnSelected Then
                    resolutionMatch = (width = heightFilter AndAlso height = widthFilter) OrElse
                        (width = widthFilter AndAlso height = heightFilter)
                ElseIf plsreslnSelected Then
                    resolutionMatch = (width > widthFilter AndAlso height > heightFilter)
                ElseIf mnsreslnSelected Then
                    resolutionMatch = (width < widthFilter AndAlso height < heightFilter)
                Else
                    resolutionMatch = (width = widthFilter AndAlso height = heightFilter)
                End If
            End If
            '是否满足筛选
            Dim isMatch As Boolean = False
            If formatFilterEnabled AndAlso reslnSelected Then
                isMatch = formatsMatch AndAlso resolutionMatch ' 同时启用了格式和分辨率筛选时，必须同时满足两者条件
            ElseIf formatFilterEnabled Then
                isMatch = formatsMatch
            ElseIf reslnSelected Then
                isMatch = resolutionMatch
            Else
                isMatch = False ' 如果两个筛选条件都未启用时的动作
            End If
            '特殊标签筛选
            Dim isSpecialMatch As Boolean = False
            Dim fileName As String = item.SubItems(1).Text

            '最终是否添加
            If isMatch OrElse isSpecialMatch Then
                Dim newItem As New ListViewItem(item.SubItems(0).Text) '保留序号
                newItem.SubItems.Add(item.SubItems(1).Text) '保留标记
                newItem.SubItems.Add(item.SubItems(2).Text) '保留文件名
                newItem.SubItems.Add(item.SubItems(3).Text) '保留分辨率
                newItem.SubItems.Add(item.SubItems(4).Text) '保留格式
                newItem.SubItems.Add(sizeKB) '保留文件大小
                newItem.SubItems.Add(item.SubItems(6).Text) '保留文件大小
                ListViewRT.Items.Add(newItem)
                matchingFileCount += 1 ' 符合条件的文件计数

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
                optChange("提示：文件筛选已完成。", Color.Lavender)
            End If
        Next

        Dim result As New List(Of String)
        result.Add($"结果 {matchingFileCount} 项")
        If jpgCount > 0 Then result.Add($"JPG {jpgCount}")
        If pngCount > 0 Then result.Add($"PNG {pngCount}")
        If gifCount > 0 Then result.Add($"GIF {gifCount}")
        If bmpCount > 0 Then result.Add($"BMP {bmpCount}")
        If icoCount > 0 Then result.Add($"ICO {icoCount}")
        sumLblRT.Text = String.Join("  |  ", result)

        更新统计信息()
        PlayNotificationSound()

        sumRT = matchingFileCount
        jpgRT = jpgCount
        pngRT = pngCount
        bmpRT = bmpCount
        gifRT = gifCount
        icoRT = icoCount
    End Sub

    ' Button1 点击事件：选择文件夹并加载图片
    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                openText.Text = folderBrowserDialog.SelectedPath
                加载图片(folderBrowserDialog.SelectedPath)
                toForm5Path = folderBrowserDialog.SelectedPath
            End If
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toForm5Path
                Form5.toForm1Path = Me.toForm5Path
                Form5.LoadTreeView(Form5.toForm1Path)
            End If
        End Using
    End Sub

    ' 处理键盘事件，绑定 F2 键到 openButton
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'F1-F5切换选项卡
        Select Case e.KeyCode
            Case Keys.F1
                SelectTabPage(5)
            Case Keys.F2
                SelectTabPage(0)
            Case Keys.F3
                SelectTabPage(1)
            Case Keys.F4
                SelectTabPage(2)
            Case Keys.F5
                SelectTabPage(3)
            Case Keys.F6
                SelectTabPage(4)
        End Select
    End Sub

    Private Sub SelectTabPage(index As Integer)
        If index >= 0 AndAlso index < MetroTabControl1.TabPages.Count Then
            MetroTabControl1.SelectedIndex = index
        End If
    End Sub

    ' 筛选按钮点击事件，用于开始筛选
    Private Sub fltButton_Click(sender As Object, e As EventArgs) Handles fltButton.Click
        If moreButton.Checked = True And htText.Text = "" Then htText.Text = "0" '自动补齐高度
        If moreButton.Checked = True And widText.Text = "" Then widText.Text = "0" '自动补齐宽度
        筛选图片()
        更新统计信息()
    End Sub

    ' 启用按钮的拖放功能
    Private Sub openButton_DragEnter(sender As Object, e As DragEventArgs) Handles openButton.DragEnter
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
    Private Sub Button1_DragDrop(sender As Object, e As DragEventArgs) Handles openButton.DragDrop
        Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Directory.Exists(droppedItems(0)) Then
            Dim folderPath As String = droppedItems(0)
            openText.Text = folderPath
            加载图片(folderPath)
            toForm5Path = folderPath
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toForm5Path
                Form5.toForm1Path = Me.toForm5Path
                Form5.LoadTreeView(Form5.toForm1Path)
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim currentUserName As String = Environment.UserName
        Dim fontName As String = "方正黑体_GBK"
        Me.Text = verinfo
        ProgressBar1.Maximum = 0
        loadedCount = 0

        Me.KeyPreview = True ' 确保表单可以捕获键盘事件
        Me.MinimumSize = New Size(1066, 630) ' 设置最小窗口大小
        openButton.AllowDrop = True ' 启用拖放功能
        optButton.Text = opttext        '初始化操作中心
        optButton.BackColor = optcolor
        optTimer.Interval = 5000 '设置定时器间隔为 5 秒
        MetroTabControl1.SelectedTab = MetroTabPage1 '默认选中第一个选项卡
        ' 检测当前日期是否为4月1日
        If DateTime.Now.Month = 4 AndAlso DateTime.Now.Day = 1 Then
            optChange("即使我来时没有爱 / 离别盛载满是情。", Color.MistyRose)
        Else
            If 确认字体安装(fontName) Then
            Else
                optChange("安装「方正黑体GBK」获得最佳视觉体验。", Color.LemonChiffon)
            End If
        End If

        ' 检查分辨率是否小于指定值
        If screenWidth < 1066 OrElse screenHeight < 630 Then
            MessageBox.Show("检测到当前监视器分辨率低于 1066x630，程序布局可能无法正常显示。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            optChange("警告：监视器分辨率过低，程序布局可能出现异常。", Color.MistyRose)
        End If

        If currentUserName = "ReGoMark" Then
            qrButton.Visible = True
        Else
            qrButton.Visible = False
        End If
        ToolTip2.ToolTipIcon = ToolTipIcon.Info
        ToolTip2.ToolTipTitle = "格式说明"
        ToolTip2.SetToolTip(TextBox1, "允许自定义最多三个标记：” & vbCrLf & “{x}{y}{z} - 标记带有x, y, z的项；" & vbCrLf & “{x}{y}{} - 标记带有x, y的文件，不填写请{}留空。")
    End Sub

    Private Function 确认字体安装(fontName As String) As Boolean
        Dim installedFonts As New InstalledFontCollection()
        For Each font As FontFamily In installedFonts.Families
            If font.Name = fontName Then
                Return True
            End If
        Next
        Return False
    End Function

    ''左侧标签点击复制文件地址
    'Private Sub sltLblLT_Click(sender As Object, e As EventArgs) Handles sltLblLT.Click
    '    If ListViewLT.SelectedItems.Count > 0 Then
    '        Dim selectedItem As ListViewItem = ListViewLT.SelectedItems(0)
    '        Dim fileName As String = selectedItem.SubItems(2).Text '获取选中的文件名
    '        Dim folderPath As String = openText.Text '文件夹路径
    '        Dim filePath As String = Path.Combine(folderPath, fileName) '拼接完整的文件路径
    '        Clipboard.SetText(filePath) '复制文件路径到剪贴板
    '        MessageBox.Show("路径已复制：" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    ''右侧标签点击复制文件地址
    'Private Sub sltLblRT_Click(sender As Object, e As EventArgs) Handles sltLblRT.Click
    '    If ListViewRT.SelectedItems.Count > 0 Then
    '        Dim selectedItem As ListViewItem = ListViewRT.SelectedItems(0)
    '        Dim fileName As String = selectedItem.SubItems(2).Text    '获取选中的文件名
    '        Dim folderPath As String = openText.Text ' 文件夹路径
    '        Dim filePath As String = Path.Combine(folderPath, fileName)   '拼接完整的文件路径
    '        Clipboard.SetText(filePath) '复制文件路径到剪贴板
    '        MessageBox.Show("路径已复制：" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    '左侧双击预览
    Private Sub ListViewLT_DoubleClick(sender As Object, e As EventArgs) Handles ListViewLT.DoubleClick
        If ListViewLT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewLT.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(2).Text '获取选中的文件名
            Dim folderPath As String = openText.Text '文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName) '拼接完整的文件路径
            If File.Exists(filePath) Then '检查文件是否存在
                Process.Start(filePath) '使用默认程序打开文件
            Else
                MessageBox.Show("文件不存在: " & filePath， “错误”, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    '右侧双击预览
    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListViewRT.DoubleClick
        If ListViewRT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewRT.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(2).Text '获取选中的文件名
            Dim folderPath As String = openText.Text '文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName) '拼接完整的文件路径
            Try
                Process.Start(filePath) ' 使用默认程序打开文件
            Catch ex As Exception
                MessageBox.Show("无法打开。" & vbCrLf & ex.Message, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    '点击按钮删除文件
    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delbutton.Click
        If ListViewRT.Items.Count = 0 Then
            MessageBox.Show("没有可删除的文件。", "失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Dim result As DialogResult = MessageBox.Show("确定要将筛选结果移动到回收站吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Dim failedFiles As New List(Of String) ' 记录删除失败的文件
            Dim successCount As Integer = 0

            ' 遍历 ListViewRT 中的文件
            For i As Integer = ListViewRT.Items.Count - 1 To 0 Step -1
                Dim item As ListViewItem = ListViewRT.Items(i)
                Dim fileName As String = item.SubItems(2).Text
                Dim sourcePath As String = Path.Combine(openText.Text, fileName) ' 获取完整路径

                Try
                    If File.Exists(sourcePath) Then
                        ' 移动文件到回收站
                        FileSystem.DeleteFile(sourcePath, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                        ListViewRT.Items.RemoveAt(i) ' 从 ListViewRT 中移除对应项
                        successCount += 1
                    End If
                Catch ex As Exception
                    failedFiles.Add(fileName) ' 记录失败的文件
                End Try
            Next

            ' 提示操作结果
            If successCount > 0 Then
                optChange($"警告：文件回收已完成，需要重新加载。", Color.LemonChiffon)
            End If

            If failedFiles.Count > 0 Then
                MessageBox.Show("部分文件删除失败：" & vbCrLf & String.Join(vbCrLf, failedFiles), "删除失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    '复制筛选结果到指定文件夹
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles copyButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Dim targetFolder As String = folderBrowserDialog.SelectedPath
                For Each item As ListViewItem In ListViewRT.Items
                    Dim fileName As String = item.SubItems(2).Text
                    Dim sourcePath As String = Path.Combine(openText.Text, fileName) '源文件路径
                    Try
                        File.Copy(sourcePath, Path.Combine(targetFolder, fileName), True)
                        optChange("提示：文件复制已完成。", Color.White)
                        'Form9.RichTextBox1.Text += consoletime & "Save Copy Result at: " & targetFolder & "\" & fileName & vbCrLf
                    Catch ex As Exception
                        MessageBox.Show("复制失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
        End Using
    End Sub

    '移动筛选结果到指定文件夹
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles moveButton.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Dim targetFolder As String = folderBrowserDialog.SelectedPath
                For Each item As ListViewItem In ListViewRT.Items
                    Dim fileName As String = item.SubItems(2).Text
                    Dim sourcePath As String = Path.Combine(openText.Text, fileName) '源文件路径
                    Try
                        File.Move(sourcePath, Path.Combine(targetFolder, fileName))
                        optChange("警告：文件已移动，需要重新加载。", Color.LemonChiffon)
                        'Form9.RichTextBox1.Text += consoletime & "Move Result at: " & targetFolder & "\" & fileName & vbCrLf
                    Catch ex As Exception
                        MessageBox.Show("移动失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Next
            End If
        End Using
    End Sub

    '筛选结果隔离
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles dvdButton.Click
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmm")
        Dim sourceFolder As String = openText.Text ' 源文件夹路径
        Dim resultFolder As String = Path.Combine(sourceFolder, "隔离结果" & formattedDateTime)
        If ListViewRT.Items.Count > 0 Then
            If Not Directory.Exists(resultFolder) Then
                Directory.CreateDirectory(resultFolder) ' 创建“筛选结果”文件夹（如果不存在）
            End If
            For Each item As ListViewItem In ListViewRT.Items
                Dim fileName As String = item.SubItems(2).Text
                Dim sourcePath As String = Path.Combine(sourceFolder, fileName) ' 源文件路径
                Try
                    File.Move(sourcePath, Path.Combine(resultFolder, fileName))
                    optChange("警告：文件已隔离，需要重新加载。", Color.LemonChiffon)
                Catch ex As Exception
                    MessageBox.Show("隔离失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            Dim opt = MessageBox.Show("隔离成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If opt = DialogResult.Yes Then '判断是否打开文件夹
                Process.Start("explorer.exe", resultFolder) ' 打开“筛选结果”文件夹
            End If
            'Form9.RichTextBox1.Text += consoletime & "Save Isolation Result at: " & resultFolder & vbCrLf
        Else
            MessageBox.Show("筛选结果不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    '快速保存到桌面
    Private Sub Buttonsave_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmm")
        Dim sourceFolder As String = openText.Text ' 源文件夹路径
        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim resultFolder As String = Path.Combine(desktopPath, "快存副本" & formattedDateTime)

        If ListViewRT.Items.Count > 0 Then
            If Not Directory.Exists(resultFolder) Then
                Directory.CreateDirectory(resultFolder) ' 创建"快存副本"文件夹
            End If

            For Each item As ListViewItem In ListViewRT.Items
                Dim fileName As String = item.SubItems(2).Text
                Dim sourcePath As String = Path.Combine(sourceFolder, fileName) ' 源文件路径
                Try
                    File.Copy(sourcePath, Path.Combine(resultFolder, fileName)) ' 使用Copy而不是Move
                    optChange("提示：文件副本已保存到桌面。", Color.LemonChiffon)
                Catch ex As Exception
                    MessageBox.Show("保存失败。" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            Dim opt = MessageBox.Show("保存成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If opt = DialogResult.Yes Then '判断是否打开文件夹
                Process.Start("explorer.exe", resultFolder) ' 打开备份文件夹
            End If
            'Form9.RichTextBox1.Text += consoletime & "Save to Desktop Copy Result at: " & resultFolder & vbCrLf
        Else
            MessageBox.Show("筛选结果不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    '从左侧添加项到右侧
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles addButton.Click
        For Each selectedItem As ListViewItem In ListViewLT.SelectedItems ' 遍历左侧选中项
            ' 检查右侧中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(2).Text
            Dim existsInListView2 As Boolean = ListViewRT.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(2).Text = fileName)
            ' 如果右侧不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) '保留序号
                newItem.SubItems.Add(selectedItem.SubItems(1).Text) '保留文件名
                newItem.SubItems.Add(fileName) '保留文件名
                'newItem.SubItems.Add(selectedItem.SubItems(2).Text) '保留分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) '保留格式
                newItem.SubItems.Add(selectedItem.SubItems(4).Text) '保留大小
                newItem.SubItems.Add(selectedItem.SubItems(5).Text) '标记
                newItem.SubItems.Add(selectedItem.SubItems(6).Text) '标记
                ListViewRT.Items.Add(newItem) '
                newItem.BackColor = Color.Lavender '新项目背景色设置
            End If
        Next
        更新右侧结果标签()
        更新统计信息()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles bksbutton.Click
        If ListViewRT.SelectedItems.Count > 0 Then '确保 ListView2 中有选中的项
            Dim result As DialogResult = MessageBox.Show("确定要移除选定项吗？", "确认移除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                '从 ListView2 中删除选中的项
                Dim index As Integer = ListViewRT.SelectedItems(0).Index
                For Each selectedItem As ListViewItem In ListViewRT.SelectedItems
                    ListViewRT.Items.Remove(selectedItem)
                Next

                optChange("提示：项目已移除。", Color.White)

                If ListViewRT.Items.Count > 0 Then
                    If index < ListViewRT.Items.Count Then
                        ListViewRT.Items(index).Selected = True
                        ListViewRT.Items(index).Focused = True
                    Else
                        ListViewRT.Items(ListViewRT.Items.Count - 1).Selected = True
                        ListViewRT.Items(ListViewRT.Items.Count - 1).Focused = True
                    End If
                End If

                更新右侧结果标签()
                更新统计信息()
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    '窗口总在最前
    Private Sub CheckBox6_CheckStateChanged(sender As Object, e As EventArgs) Handles topButton.CheckStateChanged
        If topButton.Checked = True Then
            TopMost = True
            topButton.ImageIndex = 1

        Else
            TopMost = False
            topButton.ImageIndex = 0
        End If
    End Sub

    ' 左侧标题单击事件
    Private Sub ListViewLT_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListViewLT.ColumnClick
        列表排序法(ListViewLT, e.Column)
    End Sub

    ' 右侧标题单击事件
    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListViewRT.ColumnClick
        列表排序法(ListViewRT, e.Column)
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

            ' 仅为列 1, 2, 3, 5 添加箭头
            If i = 0 Or i = 2 Or i = 3 Or i = 5 Or i = 6 Then
                If i = currentColumn Then
                    If currentOrder = SortOrder.Ascending Then
                        columnHeader.Text &= "▲"
                    Else
                        columnHeader.Text &= "▼"
                    End If
                End If
            End If
            If i = 4 Then
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
                    Case 2 ' 文件名长度（按字符串长度排序）
                        Dim length1 As Integer = System.Text.Encoding.UTF8.GetByteCount(item1.SubItems(col).Text)
                        Dim length2 As Integer = System.Text.Encoding.UTF8.GetByteCount(item2.SubItems(col).Text)
                        returnVal = length1.CompareTo(length2)
                    Case 3 ' 分辨率（按像素总数排序）
                        Dim pixels1 As Integer = 解析分辨率(item1.SubItems(col).Text)
                        Dim pixels2 As Integer = 解析分辨率(item2.SubItems(col).Text)
                        returnVal = pixels1.CompareTo(pixels2)
                    Case 5 ' 文件大小列（按数值大小排序）
                        Dim size1 As Double = 解析文件大小(item1.SubItems(col).Text)
                        Dim size2 As Double = 解析文件大小(item2.SubItems(col).Text)
                        returnVal = size1.CompareTo(size2)
                    Case 6 ' 创建日期（按日期时间排序）
                        Dim date1, date2 As DateTime
                        If DateTime.TryParseExact(item1.SubItems(col).Text, "yy/MM/dd, HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, date1) AndAlso
                   DateTime.TryParseExact(item2.SubItems(col).Text, "yy/MM/dd, HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, date2) Then
                            returnVal = date1.CompareTo(date2)
                        Else
                            returnVal = 0 ' 解析失败，不排序
                        End If
                    Case Else ' 其他列（按字符串排序）
                        returnVal = String.Compare(item1.SubItems(col).Text, item2.SubItems(col).Text)
                End Select
            End If
            If order = SortOrder.Descending Then ' 根据排序顺序调整结果
                returnVal *= -1
            End If
            Return returnVal
        End Function

        ' 解析文件大小
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

        ' 解析分辨率，返回像素总数（宽 × 高）
        Private Function 解析分辨率(resolutionText As String) As Integer
            Dim parts() As String = resolutionText.Split("×"c)
            If parts.Length = 2 Then
                Dim width, height As Integer
                If Integer.TryParse(parts(0).Trim(), width) AndAlso Integer.TryParse(parts(1).Trim(), height) Then
                    Return width * height ' 计算像素总数
                End If
            End If
            Return 0 ' 无法解析时返回 0
        End Function
    End Class

    '分辨率宽度限制输入
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles widText.KeyPress
        '检查输入的字符是否是数字或控制字符（如退格）
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True '如果不是，则取消该输入
        End If
    End Sub

    '分辨率高度限制输入
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles htText.KeyPress
        '检查输入的字符是否是数字或控制字符（如退格）
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True '如果不是，则取消该输入
        End If
    End Sub

    '关于窗口
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles infoButton.Click
        Form2.Show()
    End Sub

    Private Sub 更新右侧结果标签()
        Dim totalFiles As Integer = ListViewRT.Items.Count '总文件数
        ' 各种格式的文件数量
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        Dim bmpCount As Integer = 0
        Dim icoCount As Integer = 0
        ' 遍历 ListViewRT 统计文件格式数量
        For Each item As ListViewItem In ListViewRT.Items
            Dim format As String = item.SubItems(4).Text.ToUpper()
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

        Dim result As New List(Of String)
        result.Add($"结果 {totalFiles} 项")
        If jpgCount > 0 Then result.Add($"JPG {jpgCount}")
        If pngCount > 0 Then result.Add($"PNG {pngCount}")
        If gifCount > 0 Then result.Add($"GIF {gifCount}")
        If bmpCount > 0 Then result.Add($"BMP {bmpCount}")
        If icoCount > 0 Then result.Add($"ICO {icoCount}")
        sumLblRT.Text = String.Join("  |  ", result)

        更新统计信息()
        PlayNotificationSound()
    End Sub

    '导出为xlsx文件
    Private Sub xlsxButton_Click(sender As Object, e As EventArgs) Handles xlsxButton.Click
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmm")
        Dim jpgSelected As Boolean = jpgButton.Checked
        Dim pngSelected As Boolean = pngButton.Checked
        Dim gifSelected As Boolean = gifButton.Checked
        Dim reslnSelected As Boolean = reslnButton.Checked
        Dim bmpSelected As Boolean = bmpButton.Checked
        Dim icoSelected As Boolean = icoButton.Checked
        Dim inreslnSelected As Boolean = exButton.Checked
        Dim volreslnSelected As Boolean = volButton.Checked
        Dim plsreslnSelected As Boolean = moreButton.Checked
        Dim mnsreslnSelected As Boolean = mnsButton.Checked

        Dim sumsizestr = FormatSize(sumSize)
        Dim loadedTimeStr = FormatTime(loadedTime)
        Dim result = GetFilterConditions(jpgSelected, pngSelected, gifSelected, bmpSelected, icoSelected, inreslnSelected, volreslnSelected, reslnSelected, plsreslnSelected, mnsreslnSelected)

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
                        AddHeaderInfo(worksheet, sumLblLT.Text, sumsizestr, loadedTimeStr, sumLblRT.Text, String.Join(" ", result))

                        ' 设置表头（对应 ListView2 的列，从第1行开始）
                        SetListViewHeaders(worksheet, ListViewRT)

                        ' 填充 ListView2 的数据（从第2行开始）
                        FillListViewData(worksheet, ListViewRT)

                        ' 保存 Excel 文件
                        package.Save()
                    End Using

                    Dim opt = MessageBox.Show("表格已导出成功！点击按钮立即打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If opt = DialogResult.Yes Then
                        ' 打开文件
                        Process.Start("explorer.exe", filePath)
                    End If
                Catch ex As Exception
                    MessageBox.Show("表格导出时发生错误: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Dim resolutionStr = $" {widText.Text} × {htText.Text}"
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
        worksheet.Cells("J1").Value = sumlabel0
        worksheet.Cells("J2").Value = " " & sumsizestr
        worksheet.Cells("J3").Value = " " & minstr
        worksheet.Cells("J5").Value = sumlabel1
        worksheet.Cells("J6").Value = " " & formattedString
        worksheet.Cells("J4").Value = lbldStr
        worksheet.Cells("I1").Value = "已扫描"
        worksheet.Cells("I2").Value = "总大小"
        worksheet.Cells("I3").Value = "耗时"
        worksheet.Cells("I5").Value = "筛选结果"
        worksheet.Cells("I6").Value = "筛选条件"
        worksheet.Cells("I4").Value = "星标"
        worksheet.Cells("I1:I6").Style.Font.Bold = True
        worksheet.Cells("I1:I6").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
        worksheet.Cells("I1:I6").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender)
    End Sub

    ' 设置 ListView 的表头到 Excel 工作表
    Private Sub SetListViewHeaders(worksheet As ExcelWorksheet, listView As ListView)
        For i As Integer = 0 To listView.Columns.Count - 1
            worksheet.Cells(1, i + 1).Value = listView.Columns(i).Text
            Dim columnWidth As Double = listView.Columns(i).Width / 7 ' 调整比例使宽度接近视觉一致
            worksheet.Column(i + 1).Width = columnWidth
        Next
        For j As Integer = 1 To listView.Columns.Count - 1
            worksheet.Column(j + 3).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right
        Next
        worksheet.Column(2).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
        worksheet.Column(3).Width = listView.Columns(3).Width / 2.5
        worksheet.Column(10).Width = listView.Columns(4).Width
        worksheet.Cells("A1:G1").Style.Font.Bold = True
        worksheet.Cells("A1:G1").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
        worksheet.Cells("A1:G1").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender)
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
    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles sumLblLT.MouseHover
        ToolTip1.SetToolTip(sumLblLT, sumLblLT.Text)
    End Sub
    '注册tooltip
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles sumLblRT.MouseHover
        ToolTip1.SetToolTip(sumLblRT, sumLblRT.Text)
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
            SplitContainer1.SplitterDistance = SplitContainer1.Width / 2 - 4
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            ListViewLT.Columns(0).Width = ListViewLT.Width / 15
            ListViewLT.Columns(2).Width = ListViewLT.Width / 3
            ListViewLT.Columns(3).Width = ListViewLT.Width / 6
            ListViewLT.Columns(5).Width = ListViewLT.Width / 8

            ListViewRT.Columns(0).Width = ListViewLT.Width / 15
            ListViewRT.Columns(2).Width = ListViewLT.Width / 3
            ListViewRT.Columns(3).Width = ListViewLT.Width / 6
            ListViewRT.Columns(5).Width = ListViewLT.Width / 8
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ListViewLT.Columns(0).Width = 50
            ListViewLT.Columns(2).Width = 150
            ListViewLT.Columns(3).Width = 100
            ListViewLT.Columns(4).Width = 63
            ListViewLT.Columns(5).Width = 90
            ListViewLT.Columns(1).Width = 30
            ListViewLT.Columns(6).Width = 150

            ListViewRT.Columns(0).Width = 50
            ListViewRT.Columns(2).Width = 150
            ListViewRT.Columns(3).Width = 100
            ListViewRT.Columns(4).Width = 63
            ListViewRT.Columns(5).Width = 90
            ListViewRT.Columns(1).Width = 30
            ListViewRT.Columns(6).Width = 150
        End If
    End Sub

    '双重锁定
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If lockButton.Checked = True Then
            ' 检查 ListViewLT 和 ListView2 是否有内容
            If ListViewRT.Items.Count > 0 Then
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
            Form4.Close()
            Form8.Close()
            Form9.Close()
            Form6.Close()
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

    ' 搜索类型枚举
    Enum SearchType
        All
        Index
        FileName
        Format
        eDate
    End Enum

    Private Sub SearchListView(keyword As String, searchType As SearchType)
        Dim lowerKeyword As String = keyword.ToLower()

        For Each item As ListViewItem In ListViewLT.Items
            Dim match As Boolean = False

            Select Case searchType
                Case SearchType.All
                    match = item.Text.ToLower().Contains(lowerKeyword) OrElse
                    item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().
                    Any(Function(subItem) subItem.Text.ToLower().Contains(lowerKeyword))

                Case SearchType.Index
                    ' 假设序号是第0列
                    match = item.Text.ToLower().Contains(lowerKeyword)

                Case SearchType.FileName
                    ' 假设文件名是第2列（索引从0开始）
                    If item.SubItems.Count > 2 Then
                        match = item.SubItems(2).Text.ToLower().Contains(lowerKeyword)
                    End If

                Case SearchType.Format
                    ' 假设格式是第4列，判断是否是合法格式关键字
                    If item.SubItems.Count > 4 Then
                        Dim formatText As String = item.SubItems(4).Text.ToLower()
                        If {".png", ".jpg", ".jpeg", ".ico", ".bmp", ".gif"}.Any(Function(ext) formatText.Contains(ext)) Then
                            match = formatText.Contains(lowerKeyword)
                        End If
                    End If

                Case SearchType.eDate
                    ' 假设日期是第6列（yy/MM/dd, HH:mm:ss 格式）
                    If item.SubItems.Count > 6 Then
                        Dim dateText As String = item.SubItems(6).Text.ToLower()
                        match = dateText.Contains(lowerKeyword)
                    End If
            End Select

            item.Selected = match
            If match Then item.EnsureVisible()
        Next

        PlayNotificationSound3()
        optChange("加载搜索：结果共 " & ListViewLT.SelectedItems.Count & " 项。", Color.White)
    End Sub

    Private Sub SearchListView1(keyword As String, searchType As SearchType)
        Dim lowerKeyword As String = keyword.ToLower()

        For Each item As ListViewItem In ListViewRT.Items
            Dim match As Boolean = False

            Select Case searchType
                Case SearchType.All
                    match = item.Text.ToLower().Contains(lowerKeyword) OrElse
                    item.SubItems.Cast(Of ListViewItem.ListViewSubItem)().
                    Any(Function(subItem) subItem.Text.ToLower().Contains(lowerKeyword))

                Case SearchType.Index
                    ' 假设序号是第0列
                    match = item.Text.ToLower().Contains(lowerKeyword)

                Case SearchType.FileName
                    ' 假设文件名是第2列（索引从0开始）
                    If item.SubItems.Count > 2 Then
                        match = item.SubItems(2).Text.ToLower().Contains(lowerKeyword)
                    End If

                Case SearchType.Format
                    ' 假设格式是第4列，判断是否是合法格式关键字
                    If item.SubItems.Count > 4 Then
                        Dim formatText As String = item.SubItems(4).Text.ToLower()
                        If {".png", ".jpg", ".jpeg", ".ico", ".bmp", ".gif"}.Any(Function(ext) formatText.Contains(ext)) Then
                            match = formatText.Contains(lowerKeyword)
                        End If
                    End If

                Case SearchType.eDate
                    ' 假设日期是第6列（yy/MM/dd, HH:mm:ss 格式）
                    If item.SubItems.Count > 6 Then
                        Dim dateText As String = item.SubItems(6).Text.ToLower()
                        match = dateText.Contains(lowerKeyword)
                    End If
            End Select

            item.Selected = match
            If match Then item.EnsureVisible()
        Next

        PlayNotificationSound3()
        optChange("筛选搜索：结果共 " & ListViewRT.SelectedItems.Count & " 项。", Color.White)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        loadedTime += 1
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles searchButton0.Click
        Dim keyword As String = searchText.Text.Trim()
        Dim type As SearchType

        If rbID.Checked Then
            type = SearchType.Index
        ElseIf rbName.Checked Then
            type = SearchType.FileName
        ElseIf rbFormat.Checked Then
            type = SearchType.Format
        ElseIf rbDate.Checked Then
            type = SearchType.eDate
        Else
            type = SearchType.All
        End If

        SearchListView(keyword, type)
    End Sub
    Private Sub btnSearch1_Click(sender As Object, e As EventArgs) Handles searchButton1.Click
        Dim keyword As String = searchText.Text.Trim()
        Dim type As SearchType

        If rbID.Checked Then
            type = SearchType.Index
        ElseIf rbName.Checked Then
            type = SearchType.FileName
        ElseIf rbFormat.Checked Then
            type = SearchType.Format
        ElseIf rbDate.Checked Then
            type = SearchType.eDate
        Else
            type = SearchType.All
        End If

        SearchListView1(keyword, type)
    End Sub

    Private Sub 更新标题()
        Me.Text = verinfo & "  |  已扫描 " & loadedCount & “ / ” & ProgressBar1.Maximum & “ 项  |  ” & Int(ProgressBar1.Value / ProgressBar1.Maximum * 1000) / 10 & " %"
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
            'optButton.Visible = False
        End If
        If Form5.Visible = True Then
            Form5.TextBox1.Text = Me.toForm5Path
            Form5.toForm1Path = Me.toForm5Path
            Form5.LoadTreeView(Form5.toForm1Path)
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
            My.Computer.Audio.Play(My.Resources.INFO, AudioPlayMode.Background)
        Catch ex As Exception
        End Try
    End Sub

    Public Sub 更新统计信息()
        ' 各种格式的文件数量
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        Dim bmpCount As Integer = 0
        Dim icoCount As Integer = 0
        Dim qstCount As Integer = 0
        Dim tmtCount As Integer = 0
        Dim invldCount As Integer = 0
        ' 遍历 ListViewRT 统计文件格式数量
        For Each item As ListViewItem In ListViewRT.Items
            Dim format As String = item.SubItems(4).Text.ToUpper()
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

        ' 更新格式统计信息
        sumRT = ListViewRT.Items.Count
        jpgRT = jpgCount
        pngRT = pngCount
        bmpRT = bmpCount
        gifRT = gifCount
        icoRT = icoCount

        ' 计算文件大小
        Dim sumsizestr As String
        If Int(sumSize / 1024 / 1024) > 1024 Then
            sumsizestr = Int(sumSize * 100 / 1024 / 1024 / 1024) / 100 & " GB"
        ElseIf Int(sumSize / 1024 / 1024) > 1 Then
            sumsizestr = Int(sumSize * 100 / 1024 / 1024) / 100 & " MB"
        Else
            sumsizestr = Int(sumSize * 100 / 1024) / 100 & " KB"
        End If

        ' 计算加载时间
        Dim loadedTimeStr As String
        If loadedTime < 1000 Then
            loadedTimeStr = loadedTime & " ms"
        Else
            loadedTimeStr = (loadedTime / 1000).ToString("F2") & " s"
        End If

        ' 更新 Form3 中的标签
        Form3.Label9.Text = sumLT
        Form3.Label10.Text = sumsizestr
        Form3.Label23.Text = loadedTimeStr
        Form3.Label11.Text = pngLT
        Form3.Label12.Text = jpgLT
        Form3.Label13.Text = bmpLT
        Form3.Label14.Text = icoLT
        Form3.Label15.Text = gifLT
        Form3.Label16.Text = "↓→ " & sumRT & " = " & (sumLT - sumRT)

        Form3.Label28.Text = pngRT
        Form3.Label27.Text = jpgRT
        Form3.Label26.Text = bmpRT
        Form3.Label25.Text = icoRT
        Form3.Label24.Text = gifRT

        ' 计算格式占比
        Form3.Label17.Text = (Int(pngLT / sumLT * 1000) / 10).ToString("F1") & " %"
        Form3.Label18.Text = (Int(jpgLT / sumLT * 1000) / 10).ToString("F1") & " %"
        Form3.Label19.Text = (Int(bmpLT / sumLT * 1000) / 10).ToString("F1") & " %"
        Form3.Label20.Text = (Int(icoLT / sumLT * 1000) / 10).ToString("F1") & " %"
        Form3.Label21.Text = (Int(gifLT / sumLT * 1000) / 10).ToString("F1") & " %"
        Form3.Label22.Text = " - " & (Int(sumRT / sumLT * 1000) / 10).ToString("F1") & " %"

        ' 计算格式占比（ListViewRT中的文件）
        Form3.Label40.Text = (Int(pngRT / sumRT * 1000) / 10).ToString("F1") & " %"
        Form3.Label39.Text = (Int(jpgRT / sumRT * 1000) / 10).ToString("F1") & " %"
        Form3.Label38.Text = (Int(bmpRT / sumRT * 1000) / 10).ToString("F1") & " %"
        Form3.Label37.Text = (Int(icoRT / sumRT * 1000) / 10).ToString("F1") & " %"
        Form3.Label36.Text = (Int(gifRT / sumRT * 1000) / 10).ToString("F1") & " %"

        ' 计算格式占比的剩余部分
        Dim result As Double = 100 - (Int(pngRT / sumRT * 1000) / 10 + Int(jpgRT / sumRT * 1000) / 10 + Int(bmpRT / sumRT * 1000) / 10 + Int(icoRT / sumRT * 1000) / 10 + Int(gifRT / sumRT * 1000) / 10)
        Form3.Label42.Text = Math.Round(result, 1).ToString("F1") & " %"

        ' 更新格式状态
        Form3.Label3.Text = If(pngLT > 0, "...PNG √", "...PNG")
        Form3.Label4.Text = If(jpgLT > 0, "...JPG √", "...JPG")
        Form3.Label5.Text = If(bmpLT > 0, "...BMP √", "...BMP")
        Form3.Label6.Text = If(icoLT > 0, "...ICO √", "...ICO")
        Form3.Label7.Text = If(gifLT > 0, "...GIF √", "...GIF")

        ' 更新格式状态（ListViewRT中的文件）
        Form3.Label33.Text = If(pngLT - pngRT <> pngLT, "...PNG √", "...PNG")
        Form3.Label32.Text = If(jpgLT - jpgRT <> jpgLT, "...JPG √", "...JPG")
        Form3.Label31.Text = If(bmpLT - bmpRT <> bmpLT, "...BMP √", "...BMP")
        Form3.Label30.Text = If(icoLT - icoRT <> icoLT, "...ICO √", "...ICO")
        Form3.Label29.Text = If(gifLT - gifRT <> gifLT, "...GIF √", "...GIF")

        ' 遍历 ListViewLT 统计特殊文件
        For Each item As ListViewItem In ListViewLT.Items
            Dim fileName As String = item.SubItems(2).Text
            If fileName.Contains(mark3) Then tmtCount += 1
            If fileName.Contains(mark2) Then qstCount += 1
            If fileName.Contains(mark1) Then invldCount += 1
        Next
        ' 更新无效、存疑和超时文件数量

        If tagButton.Checked = True Then
            Form3.Label5.Visible = True
            Form3.Label45.Text = $"{mark1} {invldCount}, {mark2} {qstCount}, {mark3} {tmtCount}"
            lbldStr = $" {mark1} {invldCount} | {mark2} {qstCount} | {mark3} {tmtCount}"
        Else
            Form3.Label5.Visible = False
            Form3.Label45.Text = “请转到「星标」选项卡启用”
            lbldStr = "功能未启用"
        End If

    End Sub

    ' 在 ListView0
    Private Sub ListView0_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewLT.SelectedIndexChanged
        If ListViewLT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewLT.SelectedItems(0)
            Dim selectedCount As Integer = ListViewLT.SelectedItems.Count
            If ListViewLT.SelectedItems.Count > 1 Then
                sltLblLT.Text = $" 复选 {selectedCount} 项"
                Label1.Text = $" 复选 {selectedCount} 项"
                ListViewLT.ContextMenuStrip = ContextMenuStrip2
            Else
                sltLblLT.Text = $" [{selectedItem.SubItems(0).Text}]  {selectedItem.SubItems(2).Text}｛vbCrLf｝{selectedItem.SubItems(3).Text} PX  |  {selectedItem.SubItems(5).Text}  |  {selectedItem.SubItems(6).Text}"
                Label1.Text = $" [{selectedItem.SubItems(0).Text}]  {selectedItem.SubItems(2).Text}  |  {selectedItem.SubItems(3).Text} 像素  |  {selectedItem.SubItems(5).Text}  |  {selectedItem.SubItems(6).Text}"
                ListViewLT.ContextMenuStrip = ContextMenuStrip1
            End If
        Else
            Label1.Text = "就绪"
            ListViewLT.ContextMenuStrip = ContextMenuStrip1
        End If
    End Sub

    ' 当 ListView2 中的项被选中时，在 Label8 显示选中的序号和文件名
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewRT.SelectedIndexChanged
        If ListViewRT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewRT.SelectedItems(0)
            Dim selectedCount As Integer = ListViewRT.SelectedItems.Count
            If ListViewRT.SelectedItems.Count > 1 Then
                sltLblRT.Text = $" 复选 {selectedCount} 项"
                Label1.Text = $" 复选 {selectedCount} 项"
                ListViewRT.ContextMenuStrip = ContextMenuStrip5
            Else
                sltLblRT.Text = $" [{selectedItem.SubItems(0).Text}]  {selectedItem.SubItems(2).Text}｛vbCrLf｝{selectedItem.SubItems(3).Text} PX  |  {selectedItem.SubItems(5).Text}  |  {selectedItem.SubItems(6).Text}"
                Label1.Text = $" [{selectedItem.SubItems(0).Text}]  {selectedItem.SubItems(2).Text}  |  {selectedItem.SubItems(3).Text} 像素  |  {selectedItem.SubItems(5).Text}  |  {selectedItem.SubItems(6).Text}"
                ListViewRT.ContextMenuStrip = ContextMenuStrip3
            End If
        Else
            Label1.Text = "就绪"
            ListViewRT.ContextMenuStrip = ContextMenuStrip3
        End If
    End Sub

    Private Sub 打开文件所在位置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开文件所在位置ToolStripMenuItem.Click
        If ListViewLT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewLT.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(2).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 检查文件是否存在
            If File.Exists(filePath) Then
                ' 使用资源管理器打开文件所在文件夹并选中文件
                Process.Start("explorer.exe", $"/Select,""{filePath}""")
            Else
                MessageBox.Show("文件不存在: " & filePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub 复制地址ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 复制地址ToolStripMenuItem.Click
        If ListViewLT.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListViewLT.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(2).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MessageBox.Show("路径已复制：" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub 添加到右侧ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加到右侧ToolStripMenuItem.Click
        For Each selectedItem As ListViewItem In ListViewLT.SelectedItems ' 遍历左侧选中项
            ' 检查右侧中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(2).Text
            Dim existsInListView2 As Boolean = ListViewRT.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(2).Text = fileName)
            ' 如果右侧不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) '保留序号
                newItem.SubItems.Add(selectedItem.SubItems(1).Text) '保留文件名
                newItem.SubItems.Add(fileName) '保留文件名
                'newItem.SubItems.Add(selectedItem.SubItems(2).Text) '保留分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) '保留格式
                newItem.SubItems.Add(selectedItem.SubItems(4).Text) '保留大小
                newItem.SubItems.Add(selectedItem.SubItems(5).Text) '标记
                newItem.SubItems.Add(selectedItem.SubItems(6).Text) '标记
                ListViewRT.Items.Add(newItem) '
                newItem.BackColor = Color.GhostWhite '新项目背景色设置
            End If
        Next
        ' 更新筛选结果的计数
        更新右侧结果标签()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        For Each selectedItem As ListViewItem In ListViewLT.SelectedItems ' 遍历左侧选中项
            ' 检查右侧中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(2).Text
            Dim existsInListView2 As Boolean = ListViewRT.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(2).Text = fileName)
            ' 如果右侧不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) '保留序号
                newItem.SubItems.Add(selectedItem.SubItems(1).Text) '保留文件名
                newItem.SubItems.Add(fileName) '保留文件名
                'newItem.SubItems.Add(selectedItem.SubItems(2).Text) '保留分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) '保留格式
                newItem.SubItems.Add(selectedItem.SubItems(4).Text) '保留大小
                newItem.SubItems.Add(selectedItem.SubItems(5).Text) '标记
                newItem.SubItems.Add(selectedItem.SubItems(6).Text) '标记
                ListViewRT.Items.Add(newItem) '
                newItem.BackColor = Color.GhostWhite '新项目背景色设置
            End If
        Next
        ' 更新筛选结果的计数
        更新右侧结果标签()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If ListViewRT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewRT.SelectedItems(0)
            Dim format As String = selectedItem.SubItems(4).Text.ToUpper()
            Dim resolution As String() = selectedItem.SubItems(3).Text.Split("×"c)
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
            widText.Text = width
            htText.Text = height
            optChange("提示：单击「开始」进行筛选。", Color.White)

        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        If ListViewRT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewRT.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(2).Text
            Dim folderPath As String = openText.Text
            Dim filePath As String = Path.Combine(folderPath, fileName)

            If File.Exists(filePath) Then
                Process.Start("explorer.exe", $"/select,""{filePath}""")
            Else
                MessageBox.Show("文件不存在: " & filePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If ListViewRT.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListViewRT.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = openText.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MessageBox.Show("路径已复制：" & vbCrLf & filePath, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        ' 确保 ListView2 中有选中的项
        If ListViewRT.SelectedItems.Count > 0 Then
            ' 从 ListView2 中删除选中的项
            Dim index As Integer = ListViewRT.SelectedItems(0).Index
            For Each selectedItem As ListViewItem In ListViewRT.SelectedItems
                ListViewRT.Items.Remove(selectedItem)
            Next
            If ListViewRT.Items.Count > 0 Then
                If index < ListViewRT.Items.Count Then
                    ListViewRT.Items(index).Selected = True
                    ListViewRT.Items(index).Focused = True
                Else
                    ListViewRT.Items(ListViewRT.Items.Count - 1).Selected = True
                    ListViewRT.Items(ListViewRT.Items.Count - 1).Focused = True
                End If
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 更新筛选结果的计数
        更新右侧结果标签()
        更新统计信息()
    End Sub

    Private Sub 删除选中项DToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 移除选中项DToolStripMenuItem.Click
        ' 确保 ListView2 中有选中的项
        If ListViewRT.SelectedItems.Count > 0 Then
            ' 从 ListView2 中删除选中的项
            Dim index As Integer = ListViewRT.SelectedItems(0).Index
            For Each selectedItem As ListViewItem In ListViewRT.SelectedItems
                ListViewRT.Items.Remove(selectedItem)
            Next
            If ListViewRT.Items.Count > 0 Then
                If index < ListViewRT.Items.Count Then
                    ListViewRT.Items(index).Selected = True
                    ListViewRT.Items(index).Focused = True
                Else
                    ListViewRT.Items(ListViewRT.Items.Count - 1).Selected = True
                    ListViewRT.Items(ListViewRT.Items.Count - 1).Focused = True
                End If
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ' 更新筛选结果的计数
        更新右侧结果标签()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        SplitContainer1.SplitterDistance = SplitContainer1.Width / 3 - 4
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        SplitContainer1.SplitterDistance = SplitContainer1.Width / 2 - 4
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        SplitContainer1.SplitterDistance = SplitContainer1.Width / 3 * 2 - 4
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        ListViewLT.Columns(6).TextAlign = HorizontalAlignment.Left
        ListViewLT.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        ListViewRT.Columns(6).TextAlign = HorizontalAlignment.Left
        ListViewRT.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub 列宽恢复默认OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 列宽默认OToolStripMenuItem.Click
        ListViewLT.Columns(6).TextAlign = HorizontalAlignment.Right
        If Me.WindowState = FormWindowState.Normal Then
            ListViewLT.Columns(0).Width = 50
            ListViewLT.Columns(2).Width = 150
            ListViewLT.Columns(3).Width = 100
            ListViewLT.Columns(4).Width = 63
            ListViewLT.Columns(5).Width = 90
            ListViewLT.Columns(1).Width = 30
            ListViewLT.Columns(6).Width = 150
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            ListViewLT.Columns(0).Width = ListViewLT.Width / 15
            ListViewLT.Columns(2).Width = ListViewLT.Width / 3
            ListViewLT.Columns(3).Width = ListViewLT.Width / 6
            ListViewLT.Columns(4).Width = 63
            ListViewLT.Columns(5).Width = ListViewLT.Width / 8
            ListViewLT.Columns(1).Width = 30
            ListViewLT.Columns(6).Width = 150
        End If
    End Sub

    Private Sub 还原列宽OToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 还原列宽OToolStripMenuItem.Click
        ListViewRT.Columns(6).TextAlign = HorizontalAlignment.Right
        If Me.WindowState = FormWindowState.Normal Then
            ListViewRT.Columns(0).Width = 50
            ListViewRT.Columns(2).Width = 150
            ListViewRT.Columns(3).Width = 100
            ListViewRT.Columns(4).Width = 63
            ListViewRT.Columns(5).Width = 90
            ListViewRT.Columns(1).Width = 30
            ListViewRT.Columns(6).Width = 150
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            ListViewRT.Columns(0).Width = ListViewRT.Width / 15
            ListViewRT.Columns(2).Width = ListViewRT.Width / 3
            ListViewRT.Columns(3).Width = ListViewRT.Width / 6
            ListViewRT.Columns(4).Width = 63
            ListViewRT.Columns(5).Width = ListViewRT.Width / 8
            ListViewRT.Columns(1).Width = 30
            ListViewRT.Columns(6).Width = 150
        End If
    End Sub

    Private Sub TextBox2_MouseHover(sender As Object, e As EventArgs) Handles widText.MouseHover
        ToolTip1.SetToolTip(widText, "宽度 " & widText.Text)
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        ListViewRT.Items.Clear()
        更新右侧结果标签()
        更新统计信息()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        Dim folderPath As String = openText.Text
        If Directory.Exists(folderPath) Then
            加载图片(folderPath)
        Else
            MessageBox.Show("路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Form5.Visible = True Then
            Form5.TextBox1.Text = Me.toForm5Path
            Form5.toForm1Path = Me.toForm5Path
            Form5.LoadTreeView(Form5.toForm1Path)
        End If
        'optButton.Visible = False
    End Sub

    Private Sub TextBox3_MouseHover(sender As Object, e As EventArgs) Handles htText.MouseHover
        ToolTip1.SetToolTip(htText, "高度 " & htText.Text)
    End Sub

    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
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
        ' 获取 Form6 实例
        Dim subForm2 As Form6 = TryCast(Application.OpenForms("Form6"), Form6)
        If subForm2 IsNot Nothing Then
            If Form6.absbButton.CheckState = CheckState.Checked Then
                ' 让 Form6 吸附在 Form1 右侧
                subForm2.Location = New Point(Me.Location.X + Me.Width, Me.Location.Y)
            End If
        End If
    End Sub

    Private Sub openText_TextChanged(sender As Object, e As EventArgs) Handles openText.TextChanged
        Me.openText.SelectionStart = Me.openText.Text.Length
        Me.openText.ScrollToCaret()
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Me.CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 以此为筛选条件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 以此为筛选条件ToolStripMenuItem.Click
        If ListViewLT.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListViewLT.SelectedItems(0)
            Dim format As String = selectedItem.SubItems(4).Text.ToUpper()
            Dim resolution As String() = selectedItem.SubItems(3).Text.Split("×"c)
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
            widText.Text = width
            htText.Text = height
            optChange("提示：单击「开始」进行筛选。", Color.White)
        End If
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        ' 如果ListViewLT中有项目，才执行选中操作
        If ListViewLT.Items.Count > 0 Then
            For Each item As ListViewItem In ListViewLT.Items
                item.Selected = True ' 将每一项设置为选中
            Next
        End If
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        ' 如果ListViewLT中有项目，才执行选中操作
        If ListViewRT.Items.Count > 0 Then
            For Each item As ListViewItem In ListViewRT.Items
                item.Selected = True ' 将每一项设置为选中
            Next
        End If
    End Sub

    Private Sub ListView0_DragDrop(sender As Object, e As DragEventArgs) Handles ListViewLT.DragDrop
        Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Directory.Exists(droppedItems(0)) Then
            Dim folderPath As String = droppedItems(0)
            openText.Text = folderPath
            加载图片(folderPath)
            toForm5Path = folderPath
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toForm5Path
                Form5.toForm1Path = Me.toForm5Path
                Form5.LoadTreeView(Form5.toForm1Path)
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles nmButton.Click
        Form6.Show()
    End Sub

    Private Sub ListView0_DragEnter(sender As Object, e As DragEventArgs) Handles ListViewLT.DragEnter
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

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    ' 确保有选中的项
    '    If ListViewRT.SelectedItems.Count = 0 Then Exit Sub

    '    ' 禁用重绘，避免闪烁
    '    ListViewRT.BeginUpdate()

    '    ' 存储选中的项
    '    Dim selectedItems As New List(Of ListViewItem)
    '    For Each item As ListViewItem In ListViewRT.SelectedItems
    '        selectedItems.Add(item)
    '    Next

    '    ' 按索引降序排序，避免调整时影响顺序
    '    selectedItems.Sort(Function(x, y) y.Index.CompareTo(x.Index))

    '    ' 移动项
    '    For Each item As ListViewItem In selectedItems
    '        Dim index As Integer = item.Index
    '        If index < ListViewRT.Items.Count - 1 Then
    '            ListViewRT.Items.RemoveAt(index)
    '            ListViewRT.Items.Insert(index + 1, item)
    '        End If
    '    Next

    '    ' 重新选中移动后的项
    '    For Each item As ListViewItem In selectedItems
    '        item.Selected = True
    '    Next
    '    ListViewRT.EndUpdate()
    'End Sub

    ' 更改按钮文本和背景色的方法
    Public Sub optChange(newText As String, newColor As Color)
        optButton.Visible = True
        optButton.Text = newText
        optButton.BackColor = newColor
        optButton.TextAlign = ContentAlignment.MiddleCenter
        optTimer.Stop() ' 防止重复触发
        optTimer.Start() ' 启动定时器
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Private Sub indexTimer_Tick(sender As Object, e As EventArgs) Handles indexTimer.Tick
        'consoletime = $"[{Now.Year}.{Now.Month}.{Now.Day}-{Now.Hour}:{Now.Minute}:{Now.Second}] "
        Dim checkedCount As Integer = 0 ' 统计选中状态的 CheckBox 数量
        Dim formatCheckedCount As Integer = 0 ' 统计格式 CheckBox 的选中数量

        ' 检查每个 CheckBox 的状态
        If jpgButton.Checked = True Then
            checkedCount += 1
        End If
        If pngButton.Checked = True Then
            checkedCount += 1
        End If
        If bmpButton.Checked = True Then
            checkedCount += 1
        End If
        If icoButton.Checked = True Then
            checkedCount += 1
        End If
        If gifButton.Checked = True Then
            checkedCount += 1
        End If

        ' 分辨率相关 CheckBox 的状态
        If reslnButton.Checked = True Then
            If volButton.Checked = True Then checkedCount += 1
            If exButton.Checked = True Then checkedCount += 1
            If moreButton.Checked = True Then checkedCount += 1
            If mnsButton.Checked = True Then checkedCount += 1
        End If

        ' 更新 MetroTabPage2 的标题
        If checkedCount > 0 Then
            MetroTabPage2.Text = "筛选 " & checkedCount
        Else
            MetroTabPage2.Text = "筛选"
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("功能还在开发中，敬请期待！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = "{屏幕截图}{}{}"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = "{screenshot}{}{}"
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = "{微信图片}{}{}"
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = "{副本}{}{}"
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = "{" & mark1 & "}" & "{" & mark2 & "}" & "{" & mark3 & "}"
    End Sub

    ' Timer 触发后恢复文本和背景色
    Private Sub optTimer_Tick(sender As Object, e As EventArgs) Handles optTimer.Tick
        optButton.Text = opttext
        optButton.BackColor = optcolor
        optButton.TextAlign = ContentAlignment.MiddleRight
        optTimer.Stop() ' 停止计时器
    End Sub

    ' 按下回车键确认地址
    Private Sub openText_KeyDown(sender As Object, e As KeyEventArgs) Handles openText.KeyDown
        Dim folderpath As String = openText.Text
        If e.KeyCode = Keys.Enter Then
            If Directory.Exists(folderpath) Then
                加载图片(folderpath)
            Else
                MessageBox.Show("路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If Form5.Visible = True Then
                Form5.TextBox1.Text = Me.toForm5Path
                Form5.toForm1Path = Me.toForm5Path
                Form5.LoadTreeView(Form5.toForm1Path)
            End If
            optButton.Visible = False
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form8.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Form9.Show()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If ListViewRT.Items.Count > 0 Then
            Dim tagValue = ListViewRT.Items(0).Tag
            MessageBox.Show("Tag 内容：" & If(tagValue IsNot Nothing, tagValue.ToString(), "Tag 是 Nothing"))
        Else
            MessageBox.Show("ListViewRT 是空的")
        End If
    End Sub

    '同步宽高数值
    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        htText.Text = Val（widText.Text）
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Middle Then
            Me.Size = New Size(1066, 582)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim input As String = TextBox1.Text
        Dim pattern As String = "^\{([^{}]*)\}\{([^{}]*)\}\{([^{}]*)\}$" ' 允许 {} 内留空
        Dim match As Match = Regex.Match(input, pattern)

        If match.Success Then
            ' 提取并允许留空
            mark1 = If(match.Groups(1).Value.Trim() = "", "未填写", match.Groups(1).Value.Trim())
            mark2 = If(match.Groups(2).Value.Trim() = "", "未填写", match.Groups(2).Value.Trim())
            mark3 = If(match.Groups(3).Value.Trim() = "", "未填写", match.Groups(3).Value.Trim())
        End If
        If TextBox1.Text = "" Then
            tagButton.Checked = False
        Else
            tagButton.Checked = True
        End If
    End Sub

    ' 添加 MouseEnter 事件处理
    Private Sub MetroTabControl1_MouseEnter(sender As Object, e As EventArgs) Handles MetroTabControl1.MouseEnter
        isMouseOverTab = True
    End Sub

    ' 添加 MouseLeave 事件处理
    Private Sub MetroTabControl1_MouseLeave(sender As Object, e As EventArgs) Handles MetroTabControl1.MouseLeave
        isMouseOverTab = False
    End Sub

    ' 在窗体级别处理鼠标滚轮事件
    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        MyBase.OnMouseWheel(e)

        ' 只有当鼠标在 TabControl 区域内时才处理滚轮事件
        If isMouseOverTab Then
            Dim currentIndex As Integer = MetroTabControl1.SelectedIndex

            ' 根据滚轮方向切换标签页
            If e.Delta < 0 Then ' 滚轮向下，往右切换
                If currentIndex < MetroTabControl1.TabCount - 1 Then
                    MetroTabControl1.SelectedIndex = currentIndex + 1
                End If
            Else ' 滚轮向上，往左切换
                If currentIndex > 0 Then
                    MetroTabControl1.SelectedIndex = currentIndex - 1
                End If
            End If
        End If
    End Sub
End Class