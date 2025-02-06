﻿Imports System.IO
Public Class Form5
    Public toform1path As String
    Public oripath As String
    ' 在 Form5 加载时，显示目录结构
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' 加载当前路径的目录结构
        toform1path = Form1.toform5path
        LoadTreeView(Form1.toform5path)
        TextBox1.Text = Form1.toform5path
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
        Else
            Me.CenterToScreen()
        End If

    End Sub

    ' 加载 TreeView1，仅显示文件夹
    Public Sub LoadTreeView(rootPath As String)
        ' 清空现有节点，确保不会重复加载
        TreeView1.Nodes.Clear()

        ' 只加载根节点
        If IO.Directory.Exists(rootPath) Then
            Dim rootNode As TreeNode = TreeView1.Nodes.Add(IO.Path.GetFileName(rootPath))
            rootNode.Tag = rootPath
            ' 加载该路径下的文件夹结构
            LoadDirectories(rootPath, rootNode)
            ' 只展开当前根节点
            rootNode.Expand()
        End If
        TextBox1.SelectionStart = Form1.openText.Text.Length
        TextBox1.ScrollToCaret()

    End Sub

    ' 递归加载子文件夹，避免显示文件
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
                    ' 递归加载子目录
                    LoadDirectories(dir, node)
                End If
            Next
        Catch ex As Exception
            ' 处理权限错误（如果访问某些文件夹没有权限）
        End Try
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        ' 仅更新 Form1 中的 toform5path 为选中的节点路径
        toform1path = e.Node.Tag.ToString()
        ' 同步更新 TextBox1 中文本框内容
        TextBox1.Text = toform1path
        ' 设置 SelectionStart 到文本末尾，确保滚动到末尾
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.openText.Text = toform1path
        Form1.加载图片(Form1.openText.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.SelectionStart = Form1.openText.Text.Length
        TextBox1.ScrollToCaret()
    End Sub

    Private Sub absbButton_CheckStateChanged(sender As Object, e As EventArgs) Handles absbButton.CheckStateChanged
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
        Else
            Me.CenterToScreen()
        End If
    End Sub
    Private Sub CheckBox6_CheckStateChanged(sender As Object, e As EventArgs) Handles topButton.CheckStateChanged
        If topButton.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub
    Private Sub btnGoUp_Click(sender As Object, e As EventArgs) Handles btnGoUp.Click
        ' 检查 toform1path 是否为空
        If String.IsNullOrEmpty(toform1path) Then
            MessageBox.Show("当前没有可返回的上一级目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 获取上一级目录
        Dim parentDirectory As String = IO.Directory.GetParent(toform1path)?.FullName

        ' 检查上一级目录是否存在
        If String.IsNullOrEmpty(parentDirectory) Then
            MessageBox.Show("已经到达最上层目录，无法继续返回！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 更新 toform1path
        toform1path = parentDirectory
        ' 更新 TextBox1 显示新的目录
        TextBox1.Text = toform1path
        ' 重新加载 TreeView
        LoadTreeView(toform1path)
    End Sub


    ' 变量用于跟踪TreeView的展开/折叠状态
    Private isExpanded As Boolean = False

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If isExpanded Then
            ' 如果已经展开，则折叠所有节点
            TreeView1.CollapseAll()
            Button5.Text = "全部展开"
        Else
            ' 如果是折叠状态，则展开所有节点
            TreeView1.ExpandAll()
            Button5.Text = "全部折叠"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
