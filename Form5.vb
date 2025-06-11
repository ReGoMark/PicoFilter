Imports System.IO
Public Class Form5
    Public toForm1Path As String
    Public oripath As String

    ' 在 Form5 加载时，显示目录结构
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 加载当前路径的目录结构
        toForm1Path = Form1.toForm5Path
        LoadTreeView(Form1.toForm5Path)
        TextBox1.Text = Form1.toForm5Path
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
        Else
            Me.CenterToScreen()
        End If
        TreeView1.AllowDrop = True
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
        TextBox1.SelectionStart = Form1.openText.Text.Length
        TextBox1.ScrollToCaret()
    End Sub

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
            If CheckBox1.Checked Then
                Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp"}
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

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim selectedPath As String = TryCast(e.Node.Tag, String)

        If selectedPath Is Nothing Then
            TextBox1.Text = ""
            Button2.Enabled = False
            sltLabel0.Text = " 当前"
            Label1.ImageIndex = -1 ' 清除图标
            Exit Sub
        End If

        If IO.File.Exists(selectedPath) Then
            ' 是文件
            Dim parentPath As String = IO.Path.GetDirectoryName(selectedPath)
            TextBox1.Text = parentPath
            Button2.Enabled = True
            Button2.Tag = parentPath

            ' 判断是否是图片
            Dim ext As String = IO.Path.GetExtension(selectedPath).ToLower()
            Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".gif", ".bmp", ".ico", ".tiff", ".webp"}
            If imageExtensions.Contains(ext) Then
                Label1.ImageIndex = 2 ' 图片
            Else
                Label1.ImageIndex = -1 ' 非图片文件
            End If

        ElseIf IO.Directory.Exists(selectedPath) Then
            ' 是文件夹
            TextBox1.Text = selectedPath
            Button2.Enabled = True
            Button2.Tag = selectedPath
            Label1.ImageIndex = 1 ' 文件夹

        Else
            ' 路径无效
            TextBox1.Text = ""
            Button2.Enabled = False
            Label1.ImageIndex = -1
        End If

        ' 设置光标位置和滚动
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()

        ' 设置标签文本
        If TreeView1.SelectedNode IsNot Nothing Then
            sltLabel0.Text = " " & TreeView1.SelectedNode.Text
        Else
            sltLabel0.Text = " 当前"
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim folderPath As String = TryCast(Button2.Tag, String)

        If Not String.IsNullOrEmpty(folderPath) AndAlso IO.Directory.Exists(folderPath) Then
            Form1.openText.Text = folderPath
            Form1.加载图片(folderPath)
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectionStart = Form1.openText.Text.Length
        TextBox1.ScrollToCaret()
    End Sub

    Private Sub absbButton_CheckStateChanged(sender As Object, e As EventArgs) Handles absbButton.CheckStateChanged
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
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

    Private Sub btnGoUp_Click(sender As Object, e As EventArgs) Handles btnGoUp.Click
        ' 检查 toForm1Path 是否为空
        If String.IsNullOrEmpty(toForm1Path) Then
            MessageBox.Show("当前没有可返回的上一级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 获取上一级目录
        Dim parentDirectory As String = IO.Directory.GetParent(toForm1Path)?.FullName

        ' 检查上一级目录是否存在
        If String.IsNullOrEmpty(parentDirectory) Then
            MessageBox.Show("已经到达最上层目录，无法继续返回！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 更新 toForm1Path
        toForm1Path = parentDirectory
        ' 更新 TextBox1 显示新的目录
        TextBox1.Text = toForm1Path
        ' 重新加载 TreeView
        LoadTreeView(toForm1Path)
    End Sub

    ' 变量用于跟踪TreeView的展开/折叠状态
    Private isExpanded As Boolean = False

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If isExpanded Then
            ' 如果已经展开，则折叠所有节点
            TreeView1.CollapseAll()
            Button5.Text = "展开"
        Else
            ' 如果是折叠状态，则展开所有节点
            TreeView1.ExpandAll()
            Button5.Text = "折叠"
        End If

        ' 切换展开状态
        isExpanded = Not isExpanded
    End Sub

    Private Sub TreeView1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeExpand
        ' 节点展开时，设置图标为 ImageList1 的索引 0（已展开）
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0
    End Sub

    Private Sub TreeView1_BeforeCollapse(sender As Object, e As TreeViewCancelEventArgs) Handles TreeView1.BeforeCollapse
        ' 节点折叠时，设置图标为 ImageList1 的索引 1（未展开）
        e.Node.ImageIndex = 1
        e.Node.SelectedImageIndex = 1
    End Sub

    'Private Sub sltLabel0_MouseHover(sender As Object, e As EventArgs) Handles sltLabel0.MouseHover
    '    If TreeView1.SelectedNode IsNot Nothing Then
    '        ToolTip1.SetToolTip(sltLabel0, TreeView1.SelectedNode.Text)
    '    End If
    'End Sub

    Private Sub TextBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseUp
        ' 判断是否为鼠标中键点击
        If e.Button = MouseButtons.Middle Then
            ' 获取文件夹路径
            Dim folderPath As String = TextBox1.Text

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

    Private Sub Form5_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.CenterToScreen()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ' 状态变化立即刷新当前目录树
        LoadTreeView(toForm1Path)
    End Sub

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

    Private Sub TreeView1_DragDrop(sender As Object, e As DragEventArgs) Handles TreeView1.DragDrop
        Dim droppedItems() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If Directory.Exists(droppedItems(0)) Then
            Dim folderPath As String = droppedItems(0)
            Form1.openText.Text = folderPath
            Form1.加载图片(folderPath)
            Form1.toForm5Path = folderPath
            If Me.Visible = True Then
                Me.TextBox1.Text = Form1.toForm5Path
                Me.toForm1Path = Form1.toForm5Path
                Me.LoadTreeView(Me.toForm1Path)
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sourceFolder As String = TextBox1.Text.Trim()

        ' 验证源文件夹是否存在
        If Not IO.Directory.Exists(sourceFolder) Then
            MessageBox.Show("源文件夹不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' 选择目标文件夹
        Using fbd As New FolderBrowserDialog
            fbd.Description = "请选择目标文件夹"
            If fbd.ShowDialog() = DialogResult.OK Then
                Dim destinationFolder As String = fbd.SelectedPath

                ' 获取所有图像文件（包括子文件夹）
                Dim imageExtensions As String() = {".jpg", ".jpeg", ".png", ".bmp", ".gif", ".ico", ".tiff", ".webp", ".cur", ".ani"}
                Dim filesToCopy = IO.Directory.GetFiles(sourceFolder, "*.*", IO.SearchOption.AllDirectories).
                                  Where(Function(f) imageExtensions.Contains(IO.Path.GetExtension(f).ToLower())).ToList()

                Dim totalFiles As Integer = filesToCopy.Count
                Dim copiedCount As Integer = 0

                ' 设置 ProgressBar1
                ProgressBar1.Minimum = 0
                ProgressBar1.Visible = True
                ProgressBar1.Maximum = totalFiles
                ProgressBar1.Value = 0

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
                    Me.Text = $"导视 | 已完成 {percent.ToString("0.0")}%"
                    Application.DoEvents() ' 刷新UI
                    ' 更新进度条
                    ProgressBar1.Value = copiedCount
                    Application.DoEvents() ' 让UI及时刷新
                Next

                MessageBox.Show($"文件提取完成，共 {copiedCount} 项。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ProgressBar1.Visible = False
                Me.Text = "导视"
            End If
        End Using
    End Sub

End Class
