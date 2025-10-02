Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class Form1
    Public OpenPath As String
    Public FolderNameString As String
    Private MarkString As String 'lblstr
    Public VersionString As String = "PicoFilter 3.0"
    Private Mark1, Mark2, Mark3 As String

    Private LoadCount As Integer
    Private LoadTime As Integer
    Private LoadSize As Double

    Private SumLoad, SumFilt As Integer
    Private BMPLoad, BMPFilt As Integer
    Private GIFLoad, GIFFilt As Integer
    Private ICOLoad, ICOFilt As Integer
    Private JPGLoad, JPGFilt As Integer
    Private PNGLoad, PNGFilt As Integer
    Private TIFLoad, TIFFilt As Integer
    Private WBPLoad, WBPFilt As Integer
    Private MarkLoad, MarkTemp As Integer

    Private IsMouseOverTab As Boolean = False

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        If ListViewFilt.SelectedItems.Count > 0 Then
            Dim Dlg As DialogResult =
                MessageBox.Show("确定要移除选定项吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If Dlg = DialogResult.Yes Then
                Dim Index As Integer = ListViewFilt.SelectedItems(0).Index
                For Each SelectedItem As ListViewItem In ListViewFilt.SelectedItems
                    ListViewFilt.Items.Remove(SelectedItem)
                Next
                'optChange("选定项已移除", 0)
                If ListViewFilt.Items.Count > 0 Then
                    If Index < ListViewFilt.Items.Count Then
                        ListViewFilt.Items(Index).Selected = True
                        ListViewFilt.Items(Index).Focused = True
                    Else
                        ListViewFilt.Items(ListViewFilt.Items.Count - 1).Selected = True
                        ListViewFilt.Items(ListViewFilt.Items.Count - 1).Focused = True
                    End If
                End If
                UpdateLblFilt()
            End If
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnRpt_Click(sender As Object, e As EventArgs) Handles BtnRpt.Click
        If ListViewLoad.Items.Count > 0 Then
            ' 清除原有选择
            For Each Item As ListViewItem In ListViewLoad.Items
                Item.Selected = False
            Next

            '用文件大小和修改时间分组
            Dim GroupDict As New Dictionary(Of String, List(Of ListViewItem))()
            For Each Item As ListViewItem In ListViewLoad.Items
                Dim FileName As String = Item.SubItems(2).Text
                Dim FilePath As String = Path.Combine(TbxOpen.Text.Trim(), FileName)
                If File.Exists(FilePath) Then
                    Dim FileInfo As New FileInfo(FilePath)
                    Dim Key As String = FileInfo.Length.ToString() & "|" & FileInfo.LastWriteTimeUtc.Ticks.ToString()
                    If GroupDict.ContainsKey(Key) Then
                        GroupDict(Key).Add(Item)
                    Else
                        GroupDict(Key) = New List(Of ListViewItem) From {Item}
                    End If
                End If
            Next

            ' 进度条初始化
            ProgressBarLoad.Value = 0
            ProgressBarLoad.Maximum = GroupDict.Values.Count
            ProgressBarLoad.Visible = True

            ' 第二步：仅对同组(大于1)的文件再比哈希
            Dim hashDict As New Dictionary(Of String, List(Of ListViewItem))()
            Dim duplicateCount As Integer = 0
            Dim groupIndex As Integer = 0

            For Each group In GroupDict.Values
                If group.Count > 1 Then
                    Dim tempHashDict As New Dictionary(Of String, List(Of ListViewItem))()
                    For Each item In group
                        Dim fileName As String = item.SubItems(2).Text
                        Dim filePath As String = Path.Combine(TbxOpen.Text.Trim(), fileName)
                        Dim hash As String = GetFileHash(filePath)
                        If tempHashDict.ContainsKey(hash) Then
                            tempHashDict(hash).Add(item)
                        Else
                            tempHashDict(hash) = New List(Of ListViewItem) From {item}
                        End If
                    Next
                    ' 合并到总哈希字典
                    For Each pair In tempHashDict
                        If pair.Value.Count > 1 Then
                            If hashDict.ContainsKey(pair.Key) Then
                                hashDict(pair.Key).AddRange(pair.Value)
                            Else
                                hashDict(pair.Key) = New List(Of ListViewItem)(pair.Value)
                            End If
                        End If
                    Next
                End If
                groupIndex += 1
                ProgressBarLoad.Value = groupIndex
                Application.DoEvents()
            Next

            ' 选中所有重复项
            For Each pair In hashDict
                For Each dupItem In pair.Value
                    dupItem.Selected = True
                Next
                duplicateCount += pair.Value.Count
            Next
            ProgressBarLoad.Visible = False
            'If duplicateCount > 0 Then
            '    optChange("「重复」结果 " & duplicateCount & " 项", 7)
            'Else
            '    MessageBox.Show("未检测到重复文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'End If
        Else
            MessageBox.Show("加载页内容为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If ListViewLoad.SelectedItems.Count > 0 Then
            Dim TotalToAdd As Integer = ListViewLoad.SelectedItems.Count
            If TotalToAdd > 20 Then
                ProgressBarLoad.Value = 0
                ProgressBarLoad.Maximum = TotalToAdd
                ProgressBarLoad.Visible = True
            End If
            Dim AddedCount As Integer = 0
            For Each SelectedItem As ListViewItem In ListViewLoad.SelectedItems ' 遍历左侧选中项
                ' 检查右侧中是否已经存在该文件
                Dim FileName As String = SelectedItem.SubItems(2).Text
                Dim ExistsInListView As Boolean = ListViewFilt.Items.Cast(Of ListViewItem)().Any(Function(item) item.SubItems(2).Text = FileName)
                ' 如果右侧不存在该文件，则添加
                If Not ExistsInListView Then
                    Dim newItem As New ListViewItem(SelectedItem.SubItems(0).Text) '保留序号
                    newItem.SubItems.Add(SelectedItem.SubItems(1).Text) '保留文件名
                    newItem.SubItems.Add(FileName) '保留文件名
                    'newItem.SubItems.Add(selectedItem.SubItems(2).Text) '保留分辨率
                    newItem.SubItems.Add(SelectedItem.SubItems(3).Text) '保留格式
                    newItem.SubItems.Add(SelectedItem.SubItems(4).Text) '保留大小
                    newItem.SubItems.Add(SelectedItem.SubItems(5).Text) '标记
                    newItem.SubItems.Add(SelectedItem.SubItems(6).Text) '标记
                    ListViewFilt.Items.Add(newItem) '
                    newItem.BackColor = Color.Lavender '新项目背景色设置
                End If
                AddedCount += 1
                If TotalToAdd > 20 Then
                    ProgressBarLoad.Value = AddedCount
                    Application.DoEvents()
                End If
            Next
            If TotalToAdd > 20 Then
                ProgressBarLoad.Visible = False
            End If
            UpdateLblFilt()
        Else
            MessageBox.Show("选择一个项。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnReslnFill_Click(sender As Object, e As EventArgs) Handles BtnReslnFill.Click
        If TbxWd.Text <> "" Then
            'If TbxHt.Text > TbxWd.Text Then
            TbxHt.Text = TbxWd.Text
            'ElseIf TbxHt.Text > TbxWd.Text Then
            '    TbxWd.Text = TbxHt.Text
            'End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub CbxResln_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxResln.SelectedIndexChanged
        If CbxResln.SelectedIndex = -1 Then
            Exit Sub ' 确保有选中
        Else
            Dim sel As String = CbxResln.SelectedItem.ToString() ' 获取当前选中内容
            Dim parts() As String = sel.Split("×"c) ' 格式是 "宽×高"，我们分割一下

            If parts.Length = 2 Then
                TbxWd.Text = parts(0).Trim()
                TbxHt.Text = parts(1).Trim()
            End If
        End If
    End Sub

    Private Sub BtnIsolate_Click(sender As Object, e As EventArgs) Handles BtnIsolate.Click
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmmss")
        Dim sourceFolder As String = TbxOpen.Text.Trim() ' 源文件夹路径
        Dim resultFolder As String = Path.Combine(sourceFolder, "隔离结果_" & formattedDateTime)
        If ListViewFilt.Items.Count > 0 Then
            If Not Directory.Exists(resultFolder) Then
                Directory.CreateDirectory(resultFolder) ' 创建“筛选结果”文件夹（如果不存在）
            End If
            For Each item As ListViewItem In ListViewFilt.Items
                Dim fileName As String = item.SubItems(2).Text
                Dim sourcePath As String = Path.Combine(sourceFolder, fileName) ' 源文件路径
                Try
                    File.Move(sourcePath, Path.Combine(resultFolder, fileName))
                    'optChange("「警告」隔离完成，点击「重新整理」刷新", 1,, Color.FromArgb(145, 29, 52))
                Catch ex As Exception
                    MessageBox.Show("隔离失败，请重新整理后再试。" & vbCrLf & ex.Message, "未完成", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            Dim opt = MessageBox.Show("文件隔离成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If opt = DialogResult.Yes Then '判断是否打开文件夹
                Process.Start("explorer.exe", resultFolder) ' 打开“筛选结果”文件夹
            End If
            'Form9.RichTextBox1.Text += consoletime & "Save Isolation Result at: " & resultFolder & vbCrLf
        Else
            MessageBox.Show("筛选结果不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnDesk_Click(sender As Object, e As EventArgs) Handles BtnDesk.Click
        Dim now As DateTime = DateTime.Now
        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmmss")
        Dim sourceFolder As String = TbxOpen.Text.Trim() ' 源文件夹路径
        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim resultFolder As String = Path.Combine(desktopPath, "快存结果_" & formattedDateTime)

        If ListViewFilt.Items.Count > 0 Then
            If Not Directory.Exists(resultFolder) Then
                Directory.CreateDirectory(resultFolder) ' 创建"快存副本"文件夹
            End If

            For Each item As ListViewItem In ListViewFilt.Items
                Dim fileName As String = item.SubItems(2).Text
                Dim sourcePath As String = Path.Combine(sourceFolder, fileName) ' 源文件路径
                Try
                    File.Copy(sourcePath, Path.Combine(resultFolder, fileName)) ' 使用Copy而不是Move
                Catch ex As Exception
                    MessageBox.Show("保存失败，请检查文件。" & vbCrLf & ex.Message, "未完成", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Next
            Dim opt = MessageBox.Show("桌面快存成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If opt = DialogResult.Yes Then '判断是否打开文件夹
                Process.Start("explorer.exe", resultFolder) ' 打开备份文件夹
            End If
            'Form9.RichTextBox1.Text += consoletime & "Save to Desktop Copy Result at: " & resultFolder & vbCrLf
        Else
            MessageBox.Show("筛选结果不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnRecycle_Click(sender As Object, e As EventArgs) Handles BtnRecycle.Click
        If ListViewFilt.Items.Count = 0 Then
            MessageBox.Show("没有可删除的文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim result As DialogResult = MessageBox.Show("确定要将筛选结果移动到回收站吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim failedFiles As New List(Of String) ' 记录删除失败的文件
                Dim successCount As Integer = 0

                ' 遍历 ListViewFilt 中的文件
                For i As Integer = ListViewFilt.Items.Count - 1 To 0 Step -1
                    Dim item As ListViewItem = ListViewFilt.Items(i)
                    Dim fileName As String = item.SubItems(2).Text
                    Dim sourcePath As String = Path.Combine(TbxOpen.Text.Trim(), fileName) ' 获取完整路径

                    Try
                        If File.Exists(sourcePath) Then
                            ' 移动文件到回收站
                            FileSystem.DeleteFile(sourcePath, FileIO.UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin)
                            ListViewFilt.Items.RemoveAt(i) ' 从 ListViewFilt 中移除对应项
                            successCount += 1
                        End If
                    Catch ex As Exception
                        failedFiles.Add(fileName) ' 记录失败的文件
                    End Try
                Next

                ' 提示操作结果
                If successCount > 0 Then
                    'optChange($"「警告」回收完成，点击「重新整理」刷新", 1,, Color.FromArgb(145, 29, 52))
                End If

                If failedFiles.Count > 0 Then
                    MessageBox.Show("部分文件删除失败：" & vbCrLf & String.Join(vbCrLf, failedFiles), "未完成", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        If ListViewFilt.Items.Count > 0 Then
            Using folderBrowserDialog As New FolderBrowserDialog
                folderBrowserDialog.Description = "选择一个位置，新建文件夹以保存筛选副本。" ' 设置对话框标题
                ' 设置初始目录为当前打开的文件夹路径
                Dim currentFolder As String = TbxOpen.Text.Trim()
                If Directory.Exists(currentFolder) Then
                    folderBrowserDialog.SelectedPath = currentFolder
                End If
                If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                    Dim targetFolder As String = folderBrowserDialog.SelectedPath
                    For Each item As ListViewItem In ListViewFilt.Items
                        Dim fileName As String = item.SubItems(2).Text
                        Dim sourcePath As String = Path.Combine(TbxOpen.Text.Trim(), fileName) '源文件路径
                        Try
                            File.Copy(sourcePath, Path.Combine(targetFolder, fileName), True)
                        Catch ex As Exception
                            MessageBox.Show("复制失败，请检查文件。" & vbCrLf & ex.Message, "未完成", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Next
                    Dim opt = MessageBox.Show("文件复制成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If opt = DialogResult.Yes Then
                        Process.Start("explorer.exe", targetFolder)
                    End If
                End If
            End Using
        Else
            MessageBox.Show("没有可复制的文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnMove_Click(sender As Object, e As EventArgs) Handles BtnMove.Click
        If ListViewFilt.Items.Count > 0 Then
            Using folderBrowserDialog As New FolderBrowserDialog
                folderBrowserDialog.Description = "选择一个位置，新建文件夹以存放移动结果。" ' 设置对话框标题
                ' 设置初始目录为当前打开的文件夹路径
                Dim currentFolder As String = TbxOpen.Text.Trim()
                If Directory.Exists(currentFolder) Then
                    folderBrowserDialog.SelectedPath = currentFolder
                End If
                If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                    Dim targetFolder As String = folderBrowserDialog.SelectedPath
                    For Each item As ListViewItem In ListViewFilt.Items
                        Dim fileName As String = item.SubItems(2).Text
                        Dim sourcePath As String = Path.Combine(TbxOpen.Text.Trim(), fileName) '源文件路径
                        Try
                            File.Move(sourcePath, Path.Combine(targetFolder, fileName))
                            'optChange("「警告」移动完成，点击「重新整理」刷新", 1,, Color.FromArgb(145, 29, 52))
                            'Form9.RichTextBox1.Text += consoletime & "Move Result at: " & targetFolder & "\" & fileName & vbCrLf
                        Catch ex As Exception
                            MessageBox.Show("移动失败，请重新整理后再试。" & vbCrLf & ex.Message, "未完成", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Next
                    Dim opt = MessageBox.Show("文件移动成功。点击按钮打开文件夹", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If opt = DialogResult.Yes Then '判断是否打开文件夹
                        Process.Start("explorer.exe", targetFolder) ' 打开“筛选结果”文件夹
                    End If
                End If
            End Using
        Else
            MessageBox.Show("没有可移动的文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub BtnXlsx_Click(sender As Object, e As EventArgs) Handles BtnXlsx.Click
        If ListViewFilt.Items.Count = 0 Then
            MessageBox.Show("没有可导出的数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            SaveAsXlsx()
        End If
    End Sub

    Private Sub BtnZip_Click(sender As Object, e As EventArgs) Handles BtnZip.Click
        If ListViewFilt.Items.Count = 0 Then
            MessageBox.Show("没有可压缩的数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            SaveAsZip()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If String.IsNullOrWhiteSpace(TbxSearch.Text) Then
            MessageBox.Show("请输入查找内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim keyword As String = TbxSearch.Text.Trim()
        Dim type As SearchType
        If RbtnIndex.Checked Then
            type = SearchType.Index
        ElseIf RbtnName.Checked Then
            type = SearchType.FileName
        ElseIf RbtnFormat.Checked Then
            type = SearchType.Format
        ElseIf RbtnDate.Checked Then
            type = SearchType.eDate
        Else
            type = SearchType.All
        End If

        '决定在哪个列表搜索：rbLlist(加载) / rbRlist(筛选)
        If RbtnFilt.Checked Then
            SearchRslt(ListViewFilt, keyword, type, searchResultsRT, currentIndexRT, "筛选页")
        Else
            '默认左侧
            SearchRslt(ListViewLoad, keyword, type, searchResultsLT, currentIndexLT, "加载页")
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If RbtnFilt.Checked Then
            NextRslt(ListViewFilt, searchResultsRT, currentIndexRT)
        Else
            NextRslt(ListViewLoad, searchResultsLT, currentIndexLT)
        End If
    End Sub

    Private Sub BtnSearchAll_Click(sender As Object, e As EventArgs) Handles BtnSearchAll.Click
        If RbtnFilt.Checked Then
            AllRslt(ListViewFilt, searchResultsRT, currentIndexRT)
        Else
            AllRslt(ListViewLoad, searchResultsLT, currentIndexLT)
        End If
    End Sub

    Private Sub BtnSearchCls_Click(sender As Object, e As EventArgs) Handles BtnSearchCls.Click
        ' 清空搜索框 & Tab 名称
        TbxSearch.Text = ""
        'MetroTabPage4.Text = "查找"

        ' 清除左侧列表高亮
        For Each it As ListViewItem In ListViewLoad.Items
            If it.BackColor = Color.LemonChiffon Then
                it.BackColor = Color.Empty   '还原为默认背景色
            End If
        Next

        ' 清除右侧列表高亮
        For Each it As ListViewItem In ListViewFilt.Items
            If it.BackColor = Color.LemonChiffon Then
                it.BackColor = Color.Empty
            End If
        Next
    End Sub

    Private Sub BtnTabColor_CheckedChanged(sender As Object, e As EventArgs) Handles BtnTabColor.CheckedChanged
        Select Case BtnTabColor.CheckState
            Case CheckState.Checked
                TabMain.TabSelectedColor = Color.FromArgb(240, 238, 255)
                TabMain.TabUnSelectedColor = Color.FromArgb(240, 238, 255)
                TabMain.TabBackColor = Color.FromArgb(240, 238, 255)
                TabMain.TabSelectedForeColor = Color.DarkSlateBlue
                TabMain.TabUnSelectedForeColor = Color.DarkSlateBlue
                TabMain.TabSelectedHighColor = Color.DarkSlateBlue
                Panel2.BackColor = Color.FromArgb(240, 238, 255)
            Case CheckState.Unchecked
                TabMain.TabSelectedColor = Color.White
                TabMain.TabUnSelectedColor = Color.White
                TabMain.TabBackColor = Color.White
                TabMain.TabSelectedForeColor = Color.FromArgb(43, 43, 43)
                TabMain.TabUnSelectedForeColor = Color.FromArgb(43, 43, 43)
                TabMain.TabSelectedHighColor = Color.FromArgb(43, 43, 43)
                Panel2.BackColor = Color.White
        End Select
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult =
            MessageBox.Show("即将关闭程序，请确认数据已保存。", "关闭确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub BtnAna_Click(sender As Object, e As EventArgs) Handles BtnAna.Click
        If FormAnalysis.Visible = False Then
            FormAnalysis.Show()
            UpdateAnalysis()
            DrawChart()
        Else
            FormAnalysis.Close()
        End If
    End Sub

    Private Sub BtnTree_Click(sender As Object, e As EventArgs) Handles BtnTree.Click
        If FormTreeview.Visible = False Then
            FormTreeview.Show()
        Else
            FormTreeview.Close()
        End If
    End Sub

    Private Sub BtnRfh_Click(sender As Object, e As EventArgs) Handles BtnRfh.Click
        Dim FolderPath As String = TbxOpen.Text.Trim()
        If Directory.Exists(FolderPath) Then
            LoadImages(TbxOpen.Text.Trim())
            OpenPath = TbxOpen.Text.Trim()
        Else
            MessageBox.Show("路径无效或不存在。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'optButton.Visible = False
        End If
        'If Form5.Visible = True Then
        '    Form5.TextBox1.Text = Me.toForm5Path
        '    Form5.toForm1Path = Me.toForm5Path
        '    Form5.LoadTreeView(Form5.toForm1Path)
        'End If
    End Sub

    Private Sub BtnFilt_Click(sender As Object, e As EventArgs) Handles BtnFilt.Click
        FiltImages()
    End Sub

    Private Sub BtnLocate_Click(sender As Object, e As EventArgs) Handles BtnLocate.Click
        Dim folderPath As String = OpenPath
        If String.IsNullOrEmpty(folderPath) OrElse Not Directory.Exists(folderPath) Then
            MessageBox.Show("文件夹路径无效: " & folderPath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If ListViewLoad.SelectedItems.Count > 0 Then
            ' 取第一个选中的文件
            Dim SelectedItem As ListViewItem = ListViewLoad.SelectedItems(0)
            Dim FileName As String = SelectedItem.SubItems(2).Text
            Dim FilePath As String = Path.Combine(folderPath, FileName)

            If File.Exists(FilePath) Then
                ' 打开资源管理器并选中文件
                Process.Start("explorer.exe", $"/select,""{FilePath}""")
            Else
                MessageBox.Show("文件不存在: " & FilePath, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' 如果没有选中项，则只打开文件夹
            Process.Start("explorer.exe", $"""{folderPath}""")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabMain.FillColor = Color.White
        SetDblBuff(Me)
        SetDblBuff(TabMain)
        SetDblBuff(ListViewLoad)
        SetDblBuff(ListViewFilt)
        Mark1 = "未填写"
        Mark2 = "未填写"
        Mark3 = "未填写"
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        MinimumSize = New Size(1030, 630)
    End Sub

    Private Sub BtnFormatAll_CheckedChanged(sender As Object, e As EventArgs) Handles BtnFormatAll.CheckedChanged
        Select Case BtnFormatAll.Checked
            Case True
                BtnBMP.Checked = True
                BtnGIF.Checked = True
                BtnICO.Checked = True
                BtnJPG.Checked = True
                BtnPNG.Checked = True
                BtnTIF.Checked = True
                BtnWBP.Checked = True
            Case False
                BtnBMP.Checked = False
                BtnGIF.Checked = False
                BtnICO.Checked = False
                BtnJPG.Checked = False
                BtnPNG.Checked = False
                BtnTIF.Checked = False
                BtnWBP.Checked = False
        End Select
    End Sub

    Private Sub BtnResln_CheckedChanged(sender As Object, e As EventArgs) Handles BtnResln.CheckedChanged
        Select Case BtnResln.Checked
            Case True
                BtnEx.Enabled = True
                BtnVol.Enabled = True
                BtnHigher.Enabled = True
                BtnLower.Enabled = True
            Case False
                BtnEx.Enabled = False
                BtnVol.Enabled = False
                BtnHigher.Enabled = False
                BtnLower.Enabled = False
        End Select
    End Sub

    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        'Dim Dlg As New VistaFolderBrowserDialog()
        'Dlg.Description = "选择一个包含图像的文件夹..."
        'Dlg.UseDescriptionForTitle = True
        'If Dlg.ShowDialog(Me) = DialogResult.OK Then
        '    OpenPath = Dlg.SelectedPath
        '    TbxOpen.Text = OpenPath
        '    LoadImages(Dlg.SelectedPath)
        'End If
        Using folderBrowserDialog As New FolderBrowserDialog
            folderBrowserDialog.Description = "选择一个包含图像的文件夹..." ' 设置对话框标题
            If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
                OpenPath = folderBrowserDialog.SelectedPath
                TbxOpen.Text = OpenPath
                LoadImages(OpenPath)
            End If

        End Using
    End Sub

    Private Sub TabMain_MouseEnter(sender As Object, e As EventArgs) Handles TabMain.MouseEnter
        IsMouseOverTab = True
    End Sub

    Private Sub TabMain_MouseLeave(sender As Object, e As EventArgs) Handles TabMain.MouseLeave
        IsMouseOverTab = False
    End Sub

    Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
        MyBase.OnMouseWheel(e)

        If IsMouseOverTab Then
            HandleMouseWheel(TabMain, e)
        End If
    End Sub

End Class