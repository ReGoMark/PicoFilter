Imports System.IO
Imports OfficeOpenXml ' 引入 EPPlus 库(for .xlsx output)
Imports OfficeOpenXml.Table
'考虑到.net支持的图片格式比较常规，像比较冷门的格式完全不支持，如webp等，后续需要添加第三方库才有可能解决。
'ver 1.2,2024/9/26

Public Class Form1

    ' 加载图片从指定文件夹，到listview1
    Private Sub 加载图片(folderPath As String)
        ListView1.Items.Clear()
        '修改此处同时在26，57修改
        Dim 图片扩展名 As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico"}
        Dim files = Directory.GetFiles(folderPath).Where(Function(f) 图片扩展名.Contains(Path.GetExtension(f).ToLower()))
        ' 计数
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        '### 1.2 new ###
        Dim bmpCount As Integer = 0
        'Dim curCount As Integer = 0
        'Dim aniCount As Integer = 0
        Dim icoCount As Integer = 0

        'progressbar for scanning files
        ProgressBar1.Maximum = files.Count()
        ProgressBar1.Value = 0

        'items filling to listview1
        For Each file In files
            Try
                Using img As Image = Image.FromFile(file)
                    Dim fileName As String = Path.GetFileName(file)
                    Dim resolution As String = $"{img.Width}×{img.Height}"
                    Dim format As String = Path.GetExtension(file).ToUpper()
                    '显示文件大小
                    Dim fileSize As Double = New FileInfo(file).Length ' 文件大小（字节）
                    Dim sizeInKB As Double = Int(fileSize / 1024) ' 转换为KB

                    ' 计数不同格式
                    Select Case format
                        Case ".JPG", ".JPEG"
                            jpgCount += 1
                        Case ".PNG"
                            pngCount += 1
                        Case ".GIF"
                            gifCount += 1

                        'Case ".ANI"
                        '    aniCount += 1
                        Case ".ICO"
                            icoCount += 1
                        'Case ".CUR"
                        '    curCount += 1
                        Case ".BMP"
                            bmpCount += 1
                    End Select

                    Dim item As New ListViewItem(index.ToString()) ' 添加序号
                    item.SubItems.Add(fileName) ' 添加文件名
                    item.SubItems.Add(resolution) ' 添加分辨率
                    item.SubItems.Add(format) ' 添加格式
                    'item.SubItems.Add(sizeInKB & " KB") ' 添加文件大小

                    ' 添加到 listview1
                    ListView1.Items.Add(item)
                    index += 1 ' 序号自增

                    ' 更新进度条
                    ProgressBar1.Value += 1
                End Using

            Catch ex As Exception
                ' 忽略无法读取的文件(文件本身有问题而不是格式不支持)
                MsgBox("加载失败。无法读取: " & ex.Message, MsgBoxStyle.OkOnly)
            End Try

        Next

        ' 显示文件总数和各格式数量
        Label6.Text = $"[总数 {files.Count()}],[JPG] {jpgCount},[PNG] {pngCount},[GIF] {gifCount},[BMP] {bmpCount},[ICO] {icoCount}" '[CUR]{curCount},[ANI] {aniCount}"
    End Sub

    ' 加载图片从指定文件夹，到listview2
    Private Sub 筛选图片()
        ListView2.Items.Clear()
        ' 分辨率
        Dim widthFilter As Integer
        Dim heightFilter As Integer
        If Integer.TryParse(TextBox2.Text, widthFilter) AndAlso Integer.TryParse(TextBox3.Text, heightFilter) Then
        Else
            widthFilter = 0 ' 如果未设置分辨率，则设置为0
            heightFilter = 0
        End If

        Dim jpgSelected As Boolean = CheckBox1.Checked
        Dim pngSelected As Boolean = CheckBox2.Checked
        Dim gifSelected As Boolean = CheckBox3.Checked
        Dim resolutionSelected As Boolean = CheckBox4.Checked

        '分辨率不达标筛选
        Dim excludeResolution As Boolean = CheckBox11.Checked ' 获取CheckBox11的状态

        Dim bmpSelected As Boolean = CheckBox5.Checked
        'Dim aniSelected As Boolean = CheckBox9.Checked
        Dim icoSelected As Boolean = CheckBox7.Checked
        'Dim curSelected As Boolean = CheckBox8.Checked
        'Dim webpSelected As Boolean = CheckBox11.Checked

        ' 符合筛选条件的计数
        Dim matchingFileCount As Integer = 0
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0

        Dim bmpCount As Integer = 0
        'Dim curCount As Integer = 0
        'Dim aniCount As Integer = 0
        Dim icoCount As Integer = 0
        'Dim webpCount As Integer = 0

        ' 遍历 ListView1 中的每一项，进行筛选
        For Each item As ListViewItem In ListView1.Items
            Dim resolution As String() = item.SubItems(2).Text.Split("×"c)
            Dim width As Integer = Integer.Parse(resolution(0))
            Dim height As Integer = Integer.Parse(resolution(1))
            Dim format As String = item.SubItems(3).Text

            '处理是否勾选了分辨率作为筛选条件
            Dim matchesResolution As Boolean = Not resolutionSelected OrElse (width = widthFilter AndAlso height = heightFilter)
            ' 处理文件格式筛选
            Dim matchesFormat As Boolean = (jpgSelected AndAlso format = ".JPG") OrElse
                (jpgSelected AndAlso format = ".JPEG") OrElse
                (pngSelected AndAlso format = ".PNG") OrElse
                (bmpSelected AndAlso format = ".BMP") OrElse
                (icoSelected AndAlso format = ".ICO") OrElse
                (gifSelected AndAlso format = ".GIF")
            'OrElse(webpSelected AndAlso format = ".WEBP") 'OrElse (curSelected AndAlso format = ".CUR") OrElse (aniSelected AndAlso format = ".ANI") 

            If excludeResolution And resolutionSelected Then
                If width <> widthFilter OrElse height <> heightFilter Then
                    ' 分辨率不符合要求，将文件添加到ListView2
                    Dim newItem As New ListViewItem(item.SubItems(0).Text) ' 保留原始序号
                    newItem.SubItems.Add(item.SubItems(1).Text) ' 文件名
                    newItem.SubItems.Add(item.SubItems(2).Text) ' 分辨率
                    newItem.SubItems.Add(item.SubItems(3).Text) ' 格式
                    ListView2.Items.Add(newItem)
                    matchingFileCount += 1 ' 符合条件的文件计数自增

                    ' 更新格式计数
                    Select Case format
                        Case ".JPG", ".JPEG"
                            jpgCount += 1
                        Case ".PNG"
                            pngCount += 1
                        Case ".GIF"
                            gifCount += 1
                        Case ".BMP"
                            bmpCount += 1
                        Case ".ICO"
                            icoCount += 1
                    End Select

                    Continue For ' 跳过本次循环，继续下一个文件
                End If
            End If

            If resolutionSelected And Not excludeResolution Then
                ' 如果勾选了分辨率则直接添加
                If width = widthFilter AndAlso height = heightFilter Then
                    Dim newItem As New ListViewItem(item.SubItems(0).Text) ' 保留原始序号
                    newItem.SubItems.Add(item.SubItems(1).Text) ' 文件名
                    newItem.SubItems.Add(item.SubItems(2).Text) ' 分辨率
                    newItem.SubItems.Add(item.SubItems(3).Text) ' 格式
                    ListView2.Items.Add(newItem)
                    matchingFileCount += 1 ' 符合条件的文件计数自增

                    ' 更新各格式计数
                    Select Case format
                        Case ".JPG", ".JPEG"
                            jpgCount += 1
                        Case ".PNG"
                            pngCount += 1
                        Case ".GIF"
                            gifCount += 1
                        '### 1.2 new ###
                        'Case ".ANI"
                        '    aniCount += 1
                        Case ".ICO"
                            icoCount += 1
                        'Case ".CUR"
                        '    curCount += 1
                        Case ".BMP"
                            bmpCount += 1
                            'Case ".WEBP"
                            '    webpCount += 1

                    End Select

                    Continue For ' 继续下一个文件
                End If
            End If

            ' 处理文件格式筛选
            If matchesResolution AndAlso matchesFormat Then
                Dim newItem As New ListViewItem(item.SubItems(0).Text) ' 保留原始序号
                newItem.SubItems.Add(item.SubItems(1).Text) ' 文件名
                newItem.SubItems.Add(item.SubItems(2).Text) ' 分辨率
                newItem.SubItems.Add(item.SubItems(3).Text) ' 格式
                ListView2.Items.Add(newItem)
                matchingFileCount += 1 ' 符合条件的文件计数自增

                ' 更新各格式计数
                Select Case format
                    Case ".JPG", ".JPEG"
                        jpgCount += 1
                    Case ".PNG"
                        pngCount += 1
                    Case ".GIF"
                        gifCount += 1
                        '### 1.2 new ###
                    'Case ".ANI"
                    '    aniCount += 1
                    Case ".ICO"
                        icoCount += 1
                    'Case ".CUR"
                    '    curCount += 1
                    Case ".BMP"
                        bmpCount += 1
                        'Case ".WEBP"
                        '    webpCount += 1
                End Select
            End If
        Next

        ' 在 Label2 显示
        Label2.Text = $"[结果 {matchingFileCount}],[JPG] {jpgCount},[PNG] {pngCount},[GIF] {gifCount},[BMP] {bmpCount},[ICO] {icoCount}" '[CUR] {curCount},[ANI] {aniCount},
    End Sub

    ' 当 ListView1 中的项被选中时，在 Label5 显示选中的序号和文件名
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim selectedCount As Integer = ListView1.SelectedItems.Count
            Label5.Text = $"[已选 {selectedCount}][{selectedItem.SubItems(0).Text}] {selectedItem.SubItems(1).Text}"
        Else
            Label5.Text = "等待选中"
        End If
    End Sub

    ' 当 ListView2 中的项被选中时，在 Label8 显示选中的序号和文件名
    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim selectedCount As Integer = ListView1.SelectedItems.Count
            Label8.Text = $"[已选 {selectedCount}][{selectedItem.SubItems(0).Text}] {selectedItem.SubItems(1).Text}"
        Else
            Label8.Text = ""
        End If
    End Sub

    ' Button1 点击事件：选择文件夹并加载图片
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = folderBrowserDialog.SelectedPath
                加载图片(folderBrowserDialog.SelectedPath)
                'Label1.BackColor = Color.FromArgb(0, 120, 215)
                'Label1.Text = "提示:" & "已加载"
            End If
        End Using
    End Sub

    ' 筛选按钮点击事件，用于开始筛选
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        筛选图片()
    End Sub

    ' 启用按钮的拖放功能
    Private Sub Button1_DragEnter(sender As Object, e As DragEventArgs) Handles Button1.DragEnter
        ' 判断拖入的是否是文件夹
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            If Directory.Exists(droppedItems(0)) Then
                e.Effect = DragDropEffects.Copy
                'Label1.BackColor = Color.FromArgb(0, 120, 215)
                'Label1.Text = "提示:" & "已加载"
            Else
                e.Effect = DragDropEffects.None
            End If
        End If
    End Sub

    ' 拖入识别
    Private Sub Button1_DragDrop(sender As Object, e As DragEventArgs) Handles Button1.DragDrop
        Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Directory.Exists(droppedItems(0)) Then
            Dim folderPath As String = droppedItems(0)
            TextBox1.Text = folderPath
            加载图片(folderPath)
        End If
    End Sub

    '按下回车键刷新
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F5 Then
            Dim folderPath As String = TextBox1.Text
            If Directory.Exists(folderPath) Then
                加载图片(folderPath)
            Else
                MsgBox("加载失败。无效路径", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    ' 启用按钮的拖放功能
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.AllowDrop = True ' 启用拖放功能
    End Sub


    ' 在 Label5 上单击复制 ListView1 选中的文件路径
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If ListView1.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = TextBox1.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MsgBox("文件路径已复制: " & filePath, MessageBoxIcon.Information)
        End If
    End Sub

    ' 在 Label8 上单击时复制 ListView2 选中的文件路径
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If ListView2.SelectedItems.Count > 0 Then
            ' 获取选中的文件名
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = TextBox1.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 复制文件路径到剪贴板
            Clipboard.SetText(filePath)
            MsgBox("文件路径已复制: " & filePath, MessageBoxIcon.Information)
        End If
    End Sub

    ' 双击 ListView1 中的项以打开文件
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text

            ' 拼接完整的文件路径
            Dim folderPath As String = TextBox1.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 检查文件是否存在
            If File.Exists(filePath) Then
                ' 使用默认程序打开文件
                Process.Start(filePath)
            Else
                MessageBox.Show("文件不存在: " & filePath)
            End If
        End If
    End Sub

    ' 双击 ListView2 选中项打开文件
    Private Sub ListView2_DoubleClick(sender As Object, e As EventArgs) Handles ListView2.DoubleClick
        If ListView2.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text
            Dim folderPath As String = TextBox1.Text ' 文件夹路径
            Dim filePath As String = Path.Combine(folderPath, fileName)

            ' 使用默认程序打开文件
            Try
                Process.Start(filePath)
            Catch ex As Exception
                MsgBox("无法打开: " & ex.Message)
            End Try
        End If
    End Sub

    ' Button3 点击事件：复制筛选结果到指定文件夹
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Dim targetFolder As String = folderBrowserDialog.SelectedPath

                For Each item As ListViewItem In ListView2.Items
                    Dim fileName As String = item.SubItems(1).Text
                    Dim sourcePath As String = Path.Combine(TextBox1.Text, fileName) ' 源文件路径

                    Try
                        File.Copy(sourcePath, Path.Combine(targetFolder, fileName), True)
                    Catch ex As Exception
                        MsgBox("复制失败: " & ex.Message)

                    End Try
                Next
            End If
        End Using
    End Sub

    ' Button4 点击事件：移动筛选结果到指定文件夹
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Using folderBrowserDialog As New FolderBrowserDialog
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                Dim targetFolder As String = folderBrowserDialog.SelectedPath

                For Each item As ListViewItem In ListView2.Items
                    Dim fileName As String = item.SubItems(1).Text
                    Dim sourcePath As String = Path.Combine(TextBox1.Text, fileName) ' 源文件路径

                    Try
                        File.Move(sourcePath, Path.Combine(targetFolder, fileName))
                    Catch ex As Exception
                        MsgBox("移动失败: " & ex.Message)

                    End Try
                Next
            End If
        End Using
    End Sub

    ' Button5 点击事件：将筛选结果移动到扫描文件夹下的“筛选结果”文件夹内
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sourceFolder As String = TextBox1.Text ' 源文件夹路径
        Dim resultFolder As String = Path.Combine(sourceFolder, "筛选结果" & Now.Month & “-” & Now.Day & "-" & Now.Hour & "-" & Now.Minute)

        ' 创建“筛选结果”文件夹（如果不存在）
        If Not Directory.Exists(resultFolder) Then
            Directory.CreateDirectory(resultFolder)
        End If

        For Each item As ListViewItem In ListView2.Items
            Dim fileName As String = item.SubItems(1).Text
            Dim sourcePath As String = Path.Combine(sourceFolder, fileName) ' 源文件路径

            Try
                File.Move(sourcePath, Path.Combine(resultFolder, fileName))
            Catch ex As Exception
                MsgBox("移动失败: " & ex.Message)

            End Try
        Next
        MsgBox("文件已移动到 筛选结果 文件夹!", MsgBoxStyle.OkOnly, MessageBoxIcon.Information)

    End Sub

    ' Button7 点击事件：将 ListView1 中选中的文件添加到 ListView2 中
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' 遍历 ListView1 中的选中项
        For Each selectedItem As ListViewItem In ListView1.SelectedItems
            ' 检查 ListView2 中是否已经存在该文件
            Dim fileName As String = selectedItem.SubItems(1).Text
            Dim existsInListView2 As Boolean = ListView2.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(1).Text = fileName)

            ' 如果 ListView2 中不存在该文件，则添加
            If Not existsInListView2 Then
                Dim newItem As New ListViewItem(selectedItem.SubItems(0).Text) ' 保留原始序号
                newItem.SubItems.Add(fileName) ' 文件名
                newItem.SubItems.Add(selectedItem.SubItems(2).Text) ' 分辨率
                newItem.SubItems.Add(selectedItem.SubItems(3).Text) ' 格式

                ListView2.Items.Add(newItem) ' 添加到 ListView2
                ' 将新项目的字体颜色设置为红色
                newItem.ForeColor = Color.FromArgb(0, 120, 215)
            End If
        Next
        ' 更新筛选结果的计数
        UpdateLabel2()
    End Sub

    ' Button8 点击事件：删除 ListView2 中选中的项
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ' 确保 ListView2 中有选中的项
        If ListView2.SelectedItems.Count > 0 Then
            ' 从 ListView2 中删除选中的项
            For Each selectedItem As ListViewItem In ListView2.SelectedItems
                ListView2.Items.Remove(selectedItem)
            Next
            'Label1.Text = "提示：" & ("已删除选中的项")
            'Label1.BackColor = Color.FromArgb(0, 120, 215)
        Else
            MsgBox("请选择一个项", MsgBoxStyle.OkOnly)
        End If
        UpdateLabel2()
    End Sub
    '总在最前
    Private Sub CheckBox6_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckStateChanged
        If CheckBox6.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub

    ' 用于存储当前排序的列和顺序
    Private currentColumn As Integer = -1
    Private currentOrder As SortOrder = SortOrder.Ascending

    ' ListView1 的列标题单击事件
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        SortListView(ListView1, e.Column)
    End Sub

    ' ListView2 的列标题单击事件
    Private Sub ListView2_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView2.ColumnClick
        SortListView(ListView2, e.Column)
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

                ' 根据列索引进行比较
                If col = 0 Then ' 序号列
                    Dim num1 As Integer = Integer.Parse(item1.SubItems(col).Text)
                    Dim num2 As Integer = Integer.Parse(item2.SubItems(col).Text)
                    returnVal = num1.CompareTo(num2)
                Else
                    returnVal = String.Compare(item1.SubItems(col).Text, item2.SubItems(col).Text)
                End If
            End If

            ' 根据排序顺序返回相应的结果
            If order = SortOrder.Descending Then
                returnVal *= -1
            End If
            Return returnVal
        End Function
    End Class

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        ' 检查输入的字符是否是数字或控制字符（如退格）
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' 如果不是，则取消该输入
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        ' 检查输入的字符是否是数字或控制字符（如退格）
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' 如果不是，则取消该输入
        End If
    End Sub
    '关于
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form2.Show()
    End Sub

    Private Sub UpdateLabel2()
        ' 总文件数
        Dim totalFiles As Integer = ListView2.Items.Count

        ' 各种格式的文件数量
        Dim index As Integer = 1
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        '### 1.2 new ###
        Dim bmpCount As Integer = 0
        'Dim curCount As Integer = 0
        'Dim aniCount As Integer = 0
        Dim icoCount As Integer = 0

        ' 遍历 ListView2 统计文件格式数量
        For Each item As ListViewItem In ListView2.Items
            Dim format As String = item.SubItems(3).Text.ToUpper()

            Select Case format
                Case ".JPG", ".JPEG"
                    jpgCount += 1
                Case ".PNG"
                    pngCount += 1
                Case ".GIF"
                    gifCount += 1

                        'Case ".ANI"
                        '    aniCount += 1
                Case ".ICO"
                    icoCount += 1
                        'Case ".CUR"
                        '    curCount += 1
                Case ".BMP"
                    bmpCount += 1

            End Select
        Next

        ' 更新 Label2 的文本
        Label2.Text = $"[结果 {totalFiles}],[JPG] {jpgCount},[PNG] {pngCount},[GIF] {gifCount},[BMP] {bmpCount},[ICO] {icoCount}" '[CUR] {curCount},[ANI] {aniCount},
    End Sub

    ' Label5 的 MouseHover 事件
    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles Label5.MouseHover
        ' 检查 ListView1 是否有选中项
        If ListView1.SelectedItems.Count > 0 Then
            ' 获取 ListView1 选中项的文件名
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text ' 假设第2列是文件名

            ' 设置 ToolTip1 的文本
            ToolTip1.SetToolTip(Label5, fileName & vbCrLf & "单击复制路径。复选状态下只能复制头文件路径。")
        Else
            ' 如果没有选中项，显示默认提示
            ToolTip1.SetToolTip(Label5, "单击复制路径。复选状态下只能复制头文件路径。")
        End If
    End Sub

    ' Label8 的 MouseHover 事件
    Private Sub Label8_MouseHover(sender As Object, e As EventArgs) Handles Label8.MouseHover
        ' 检查 ListView2 是否有选中项
        If ListView2.SelectedItems.Count > 0 Then
            ' 获取 ListView2 选中项的文件名
            Dim selectedItem As ListViewItem = ListView2.SelectedItems(0)
            Dim fileName As String = selectedItem.SubItems(1).Text ' 假设第2列是文件名

            ' 设置 ToolTip1 的文本
            ToolTip1.SetToolTip(Label8, fileName & vbCrLf & "单击复制路径。复选状态下只能复制头文件路径。")
        Else
            ' 如果没有选中项，显示默认提示
            ToolTip1.SetToolTip(Label8, "单击复制路径。复选状态下只能复制头文件路径。")
        End If
    End Sub

    ' Button9 的点击事件，用于将 ListView2 导出为 .xlsx 文件
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' 设置许可证上下文为非商业用途
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        ' 选择保存路径
        Using saveFileDialog As New SaveFileDialog
            saveFileDialog.FileName = "筛选结果" & Now.Month & “-” & Now.Day & "-" & Now.Hour & "-" & Now.Minute & ".xlsx"
            saveFileDialog.Filter = "Excel 文件 (*.xlsx)|*.xlsx"
            saveFileDialog.Title = "导出为 Excel 文件"

            ' 确认用户选择了保存路径
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                ' 确保文件路径有效
                Try
                    Dim filePath As String = saveFileDialog.FileName
                    Dim fileInfo As New FileInfo(filePath)

                    ' 使用 EPPlus 创建 Excel 文件
                    Using package As New ExcelPackage(fileInfo)
                        ' 创建一个新的工作表
                        Dim worksheet = package.Workbook.Worksheets.Add("ListView2数据")

                        ' 设置表头（对应 ListView2 的列）
                        For i As Integer = 0 To ListView2.Columns.Count - 1
                            worksheet.Cells(1, i + 1).Value = ListView2.Columns(i).Text
                        Next

                        ' 填充 ListView2 的数据
                        For i As Integer = 0 To ListView2.Items.Count - 1
                            For j As Integer = 0 To ListView2.Items(i).SubItems.Count - 1
                                worksheet.Cells(i + 2, j + 1).Value = ListView2.Items(i).SubItems(j).Text
                            Next
                        Next

                        ' 保存 Excel 文件
                        package.Save()
                    End Using

                    MessageBox.Show("导出为xlsx成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    ' 捕获并显示异常
                    MessageBox.Show("导出文件时发生错误: " & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True ' 启用键盘事件捕获
    End Sub

    ' 窗体的 KeyDown 事件
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Add Then ' 检测 "+" 按键
            Button7.PerformClick() ' 触发 Button7 的点击事件
        End If
        If e.KeyCode = Keys.Delete Then ' 检测 "Delete" 按键
            Button8.PerformClick() ' 触发 Button8 的点击事件
        End If
        If e.KeyCode = Keys.F3 Then
            Button1.PerformClick()
        End If

    End Sub

    Private Sub CheckBox10_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckStateChanged
        If CheckBox10.Checked = True Then
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox3.Checked = True
            CheckBox5.Checked = True
            CheckBox7.Checked = True
        Else
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
            CheckBox5.Checked = False
            CheckBox7.Checked = False
        End If
    End Sub

    Private Sub Label6_MouseHover(sender As Object, e As EventArgs) Handles Label6.MouseHover
        ToolTip1.SetToolTip(Label6, Label6.Text)
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        ToolTip1.SetToolTip(Label2, Label2.Text)
    End Sub

    Private Sub Label4_DoubleClick(sender As Object, e As EventArgs) Handles Label4.DoubleClick
        TextBox3.Text = Val（TextBox2.Text）
    End Sub

    Private Sub TextBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseUp
        ' 判断是否为鼠标中键点击
        If e.Button = MouseButtons.Middle Then
            ' 调试输出，确认事件触发
            'MsgBox("鼠标中键点击触发")

            ' 获取文件夹路径
            Dim folderPath As String = TextBox1.Text

            ' 检查路径是否为空并且文件夹是否存在
            If Not String.IsNullOrEmpty(folderPath) AndAlso Directory.Exists(folderPath) Then
                ' 打开文件夹
                Process.Start("explorer.exe", folderPath)
            Else
                ' 如果路径无效或文件夹不存在，提示错误信息
                MsgBox("文件夹路径无效或未选择。", MsgBoxStyle.OkOnly,)
            End If
        End If
    End Sub
    Private Sub SplitContainer1_MouseUp(sender As Object, e As MouseEventArgs) Handles SplitContainer1.MouseUp
        If e.Button = MouseButtons.Middle Then
            If Me.WindowState = FormWindowState.Normal Then
                SplitContainer1.SplitterDistance = 446
            ElseIf Me.WindowState = FormWindowState.Maximized Then
                SplitContainer1.SplitterDistance = SplitContainer1.Width / 2
            End If

        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            ListView1.Columns(1).Width = ListView1.Width / 2
            ListView2.Columns(1).Width = ListView2.Width / 2
        ElseIf Me.WindowState = FormWindowState.Normal Then
            ListView1.Columns(1).Width = 150
            ListView2.Columns(1).Width = 150
        End If
    End Sub
End Class