Imports System.IO

Public Class FormTreeview

    ' 变量用于跟踪TreeView的展开/折叠状态
    Private isExpanded As Boolean = False

    ' 递归加载子文件夹，显示图像文件
    Public Sub LoadDirectories(path As String, parentNode As TreeNode)
        Try
            ' 获取目录下的所有文件夹
            Dim directories As String() = IO.Directory.GetDirectories(path)
            For Each dir As String In directories
                ' 检查此节点是否已经存在，不存在才添加
                If Not parentNode.Nodes.Cast(Of TreeNode)().Any(Function(n) n.Tag.ToString() = dir) Then
                    ' 创建一个新的节点显示该文件夹
                    Dim node As TreeNode = parentNode.Nodes.Add(IO.Path.GetFileName(dir))
                    node.Tag = dir ' 存储该目录的完整路径
                    node.ImageIndex = 1
                    node.SelectedImageIndex = 1
                    ' 递归加载子目录
                    LoadDirectories(dir, node)
                End If
            Next

            ' ===== 新增：如果勾选了 CheckBox1，则加载图像文件 =====
            If BtnDetail.Checked Then
                Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico"}
                Dim files As String() = IO.Directory.GetFiles(path)
                For Each file As String In files
                    If imageExtensions.Contains(IO.Path.GetExtension(file).ToLower()) Then
                        ' 添加图像文件节点
                        Dim fileNode As TreeNode = parentNode.Nodes.Add(IO.Path.GetFileName(file))
                        fileNode.Tag = file ' 存储完整路径
                        fileNode.ImageIndex = 2 ' 图像文件图标（假设 ImageList1.Images(2) 是图像文件图标）
                        fileNode.SelectedImageIndex = 2
                    End If
                Next
            End If
        Catch ex As Exception
            ' 处理权限错误（如果访问某些文件夹没有权限）
        End Try
    End Sub

    ' 加载 TreeView1，显示文件夹和图像文件
    Public Sub LoadTreeView(rootPath As String)
        ' 清空现有节点，确保不会重复加载
        TreeView1.Nodes.Clear()

        ' 只加载根节点
        If IO.Directory.Exists(rootPath) Then
            Dim rootNode As TreeNode = TreeView1.Nodes.Add(IO.Path.GetFileName(rootPath))
            rootNode.Tag = rootPath
            ' 加载该路径下的文件夹和图像文件结构
            LoadDirectories(rootPath, rootNode)
            ' 只展开当前根节点
            rootNode.Expand()
        End If
        TbxOpen.SelectionStart = Form1.TbxOpen.Text.Length
        TbxOpen.ScrollToCaret()
    End Sub

    Private Sub BtnDetail_CheckedChanged(sender As Object, e As EventArgs) Handles BtnDetail.CheckedChanged
        ' 状态变化立即刷新当前目录树
        LoadTreeView(Form1.OpenPath)
    End Sub

    Private Sub BtnExtr_Click(sender As Object, e As EventArgs) Handles BtnExtr.Click
        Dim sourceFolder As String = Form1.OpenPath

        ' 验证源文件夹是否存在
        If Not IO.Directory.Exists(sourceFolder) Then
            MessageBox.Show("源文件夹不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 选择目标文件夹
        Using fbd As New FolderBrowserDialog
            fbd.Description = "选择一个位置，新建文件夹以保存提取结果。" ' 设置对话框标题
            If fbd.ShowDialog() = DialogResult.OK Then
                Dim destinationFolder As String = fbd.SelectedPath

                ' 获取所有图像文件（包括子文件夹）
                Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".bmp", ".gif", ".ico"}
                Dim filesToCopy = IO.Directory.GetFiles(sourceFolder, "*.*", IO.SearchOption.AllDirectories).
                                  Where(Function(f) imageExtensions.Contains(IO.Path.GetExtension(f).ToLower())).ToList()

                Dim totalFiles As Integer = filesToCopy.Count
                Dim copiedCount As Integer = 0

                ' 设置 ProgressBar1
                ProgressBarOut.Minimum = 0
                ProgressBarOut.Visible = True
                ProgressBarOut.Maximum = totalFiles
                ProgressBarOut.Value = 0

                Dim sw As New Stopwatch()
                sw.Start()

                ' 复制文件
                For Each filePath In filesToCopy
                    Try
                        Dim fileName As String = IO.Path.GetFileName(filePath)
                        Dim destPath As String = IO.Path.Combine(destinationFolder, fileName)

                        ' 如果目标文件已存在，添加编号避免覆盖
                        Dim counter As Integer = 1
                        While IO.File.Exists(destPath)
                            Dim fileNameWithoutExt = IO.Path.GetFileNameWithoutExtension(filePath)
                            Dim ext = IO.Path.GetExtension(filePath)
                            destPath = IO.Path.Combine(destinationFolder, $"{fileNameWithoutExt}_{counter}{ext}")
                            counter += 1
                        End While

                        IO.File.Copy(filePath, destPath)
                        copiedCount += 1
                    Catch ex As Exception
                        MessageBox.Show($"文件提取失败：{filePath}" & vbCrLf & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    ' 更新窗口标题
                    Dim percent As Double = (copiedCount / totalFiles) * 100
                    'Me.Text = $"导视 | 已完成 {percent.ToString("0.0")}%"
                    Application.DoEvents() ' 刷新UI
                    ' 更新进度条
                    ProgressBarOut.Value = copiedCount
                    Application.DoEvents() ' 让UI及时刷新
                Next

                ProgressBarOut.Visible = False
                'Me.Text = "导视"
                Dim result = MessageBox.Show($"提取到 {copiedCount} 项。点击按钮打开", "成功", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If result = DialogResult.Yes Then
                    Try
                        Process.Start("explorer.exe", destinationFolder)
                    Catch ex As Exception
                        MessageBox.Show("无法打开文件夹：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End Using
    End Sub

    Private Sub BtnJump_Click(sender As Object, e As EventArgs) Handles BtnJump.Click
        Dim folderPath As String = TryCast(BtnJump.Tag, String)

        If Not String.IsNullOrEmpty(folderPath) AndAlso IO.Directory.Exists(folderPath) Then
            Form1.TbxOpen.Text = folderPath
            Form1.OpenPath = folderPath
            Form1.LoadImages(folderPath)

            If CheckBox2.Checked Then
                ' 勾选：清除其他节点，只保留选中节点
                LoadTreeView(folderPath)
            Else
                ' 不勾选：只定位到选中节点，不清除其他节点 先找到选中节点
                Dim nodes As TreeNode() = TreeView1.Nodes.Find(IO.Path.GetFileName(folderPath), True)
                If nodes.Length > 0 Then
                    TreeView1.SelectedNode = nodes(0)
                    TreeView1.SelectedNode.Expand()
                    TreeView1.SelectedNode.EnsureVisible()
                End If
            End If
        End If
    End Sub

    Private Sub BtnNode_Click(sender As Object, e As EventArgs) Handles BtnNode.Click
        If isExpanded Then
            ' 如果已经展开，则折叠所有节点
            TreeView1.CollapseAll()
            BtnNode.Text = "展开全部节点"
        Else
            ' 如果是折叠状态，则展开所有节点
            TreeView1.ExpandAll()
            BtnNode.Text = "折叠全部节点"
        End If
        ' 切换展开状态
        isExpanded = Not isExpanded
    End Sub

    Private Sub BtnUp_Click(sender As Object, e As EventArgs) Handles BtnUp.Click
        ' 检查 toForm1Path 是否为空
        If String.IsNullOrEmpty(Form1.OpenPath) Then
            MessageBox.Show("当前没有可返回的上一级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 获取上一级目录
        Dim parentDirectory As String = IO.Directory.GetParent(Form1.OpenPath)?.FullName

        ' 检查上一级目录是否存在
        If String.IsNullOrEmpty(parentDirectory) Then
            MessageBox.Show("已经到达最上层目录，无法继续返回！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 更新 toForm1Path
        Form1.OpenPath = parentDirectory
        ' 更新 TextBox1 显示新的目录
        TbxOpen.Text = Form1.OpenPath
        ' 重新加载 TreeView
        LoadTreeView(Form1.OpenPath)
    End Sub

    Private Sub Form5_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.CenterToScreen()
    End Sub

    Private Sub FormTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.AllowDrop = True
        If Form1.OpenPath <> Nothing Then
            TbxOpen.Text = Form1.OpenPath
            LoadTreeView(Form1.OpenPath)
        End If
    End Sub

    Private Sub FormTree_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        MinimumSize = New Size(380, 590)
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim selectedPath As String = TryCast(e.Node.Tag, String)

        If selectedPath Is Nothing Then
            TbxOpen.Text = ""
            BtnJump.Enabled = False
            'sltLabel0.Text = " 当前"
            'Label1.ImageIndex = -1 ' 清除图标
            'Label2.Text = "" ' 清空Label2
            Exit Sub
        End If

        If IO.File.Exists(selectedPath) Then
            ' 是文件
            Dim parentPath As String = IO.Path.GetDirectoryName(selectedPath)
            TbxOpen.Text = parentPath
            BtnJump.Enabled = True
            BtnJump.Tag = parentPath

            '' 判断是否是图片
            'Dim ext As String = IO.Path.GetExtension(selectedPath).ToLower()
            'Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico"}
            'If imageExtensions.Contains(ext) Then
            '    Label1.ImageIndex = 2 ' 图片
            '    ' 显示分辨率
            '    Try
            '        Using img As Image = Image.FromFile(selectedPath)
            '            Label2.Text = $"{img.Width}×{img.Height} 像素"
            '        End Using
            '    Catch
            '        Label2.Text = "无法读取分辨率"
            '    End Try
            'Else
            '    Label1.ImageIndex = -1 ' 非图片文件
            '    ' 显示其所在文件夹的统计
            '    If IO.Directory.Exists(parentPath) Then
            '        Dim dirCount As Integer = IO.Directory.GetDirectories(parentPath).Length
            '        Dim fileCount As Integer = IO.Directory.GetFiles(parentPath).Length
            '        Label2.Text = $"文件 {fileCount} 项  |  文件夹 {dirCount} 项"
            '    Else
            '        Label2.Text = ""
            '    End If
            'End If

        ElseIf IO.Directory.Exists(selectedPath) Then
            ' 是文件夹
            TbxOpen.Text = selectedPath
            BtnJump.Enabled = True
            BtnJump.Tag = selectedPath
            'Label1.ImageIndex = 1 ' 文件夹

            '' 统计当前文件夹下的文件夹和文件数
            'Dim dirCount As Integer = IO.Directory.GetDirectories(selectedPath).Length
            'Dim fileCount As Integer = IO.Directory.GetFiles(selectedPath).Length
            'Label2.Text = $"文件 {fileCount} 项  |  文件夹 {dirCount} 项"
        Else
            ' 路径无效
            TbxOpen.Text = ""
            'Button2.Enabled = False
            'Label1.ImageIndex = -1
            'Label2.Text = ""
        End If

        ' 设置光标位置和滚动
        TbxOpen.SelectionStart = Form1.OpenPath.Length
        TbxOpen.ScrollToCaret()

        '' 设置标签文本
        'If TreeView1.SelectedNode IsNot Nothing Then
        '    sltLabel0.Text = TreeView1.SelectedNode.Text
        'Else
        '    sltLabel0.Text = "当前"
        'End If
    End Sub

    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    '    TextBox1.SelectionStart = Form1.openText.Text.Length
    '    TextBox1.ScrollToCaret()
    'End Sub

    'Private Sub absbButton_CheckStateChanged(sender As Object, e As EventArgs) Handles absbButton.CheckStateChanged
    '    If absbButton.Checked = True Then
    '        Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
    '    Else
    '        'Me.CenterToScreen()
    '    End If
    'End Sub

    Private Sub TreeView1_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeCollapse
        ' 节点折叠时，设置图标为 ImageList1 的索引 1（未展开）
        e.Node.ImageIndex = 1
        e.Node.SelectedImageIndex = 1
    End Sub

    'Private Sub CheckBox6_CheckStateChanged(sender As Object, e As EventArgs) Handles topButton.CheckStateChanged
    '    If topButton.Checked = True Then
    '        TopMost = True
    '        topButton.ImageIndex = 1
    '    Else
    '        TopMost = False
    '        topButton.ImageIndex = 0
    '    End If
    'End Sub
    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        ' 节点展开时，设置图标为 ImageList1 的索引 0（已展开）
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0
    End Sub

    '        ' 检查路径是否为空并且文件夹是否存在
    '        If Not String.IsNullOrEmpty(folderPath) AndAlso Directory.Exists(folderPath) Then
    '            ' 打开文件夹
    '            Process.Start("explorer.exe", folderPath)
    '        Else
    '            ' 如果路径无效或文件夹不存在，提示错误信息
    '            MessageBox.Show("路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    End If
    'End Sub
    Private Sub TreeView1_DragEnter(sender As Object, e As DragEventArgs) Handles TreeView1.DragEnter
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

    Private Sub TreeView1_KeyDown(sender As Object, e As KeyEventArgs) Handles TreeView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' 模拟 Button2_Click 的逻辑，但不调用 PerformClick（避免 Button2 抢焦点）
            Dim folderPath As String = TryCast(BtnJump.Tag, String)

            If Not String.IsNullOrEmpty(folderPath) AndAlso IO.Directory.Exists(folderPath) Then

                Form1.OpenPath = folderPath
                Form1.TbxOpen.Text = folderPath
                Form1.LoadImages(folderPath)

                If CheckBox2.Checked Then
                    ' 勾选时：清除其他节点
                    LoadTreeView(folderPath)
                Else
                    ' 未勾选时：只展开定位到选中节点
                    Dim nodes As TreeNode() = TreeView1.Nodes.Find(IO.Path.GetFileName(folderPath), True)
                    If nodes.Length > 0 Then
                        TreeView1.SelectedNode = nodes(0)
                        TreeView1.SelectedNode.Expand()
                        TreeView1.SelectedNode.EnsureVisible()
                    End If
                End If
            End If

            ' 阻止系统“叮”声
            e.Handled = True
        End If
        If e.KeyCode = Keys.Back Then
            BtnUp.PerformClick()
        End If
    End Sub

    'Private Sub TextBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseUp
    '    ' 判断是否为鼠标中键点击
    '    If e.Button = MouseButtons.Middle Then
    '        ' 获取文件夹路径
    '        Dim folderPath As String = TextBox1.Text
    'Private Sub TreeView1_DragDrop(sender As Object, e As DragEventArgs) Handles TreeView1.DragDrop
    '    Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
    '    If Directory.Exists(droppedItems(0)) Then
    '        Dim folderPath As String = droppedItems(0)
    '        Form1.openText.Text = folderPath
    '        Form1.加载图片(folderPath)
    '        Form1.toForm5Path = folderPath
    '        If Me.Visible = True Then
    '            Me.TextBox1.Text = Form1.toForm5Path
    '            Me.toForm1Path = Form1.toForm5Path
    '            Me.LoadTreeView(Me.toForm1Path)
    '        End If
    '    End If
    'End Sub
End Class