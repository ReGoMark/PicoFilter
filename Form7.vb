Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form7
    ' 静态缓存：仅加载一次
    Private Shared englishDict As HashSet(Of String) = Nothing
    Private Shared chineseDict As HashSet(Of String) = Nothing
    'Private isSelecting As Boolean = False
    'Private selectStart As Point
    'Private selectionRect As Rectangle

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

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 默认使用基础分组
        FlowLayoutPanel1.AutoScroll = True
        MetroTabControl1.SelectedTab = MetroTabControl1.TabPages(0)

        'panelSelectionOverlay.BackColor = Color.Transparent
        'panelSelectionOverlay.Dock = DockStyle.Fill
        'panelSelectionOverlay.BringToFront()
        'panelSelectionOverlay.Cursor = Cursors.Cross
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
        Else
            Me.CenterToScreen()
        End If
        ''BindContextMenuToAllTextBoxes(Me, ContextMenuStrip6)
    End Sub

    Private Sub absbButton_CheckStateChanged(sender As Object, e As EventArgs) Handles absbButton.CheckStateChanged
        If absbButton.Checked = True Then
            Me.Location = New Point(Form1.Location.X - Me.Width, Form1.Location.Y)
        Else
            'Me.CenterToScreen()
        End If
    End Sub

    ''' <summary>
    ''' 外部调用接口：传入文件名，进行分词并生成标签
    ''' </summary>
    Public Sub LoadFromFileName(fileName As String)
        FlowLayoutPanel1.Controls.Clear()

        Dim nameOnly As String = Path.GetFileNameWithoutExtension(fileName)
        Dim parts As List(Of String)

        ' 默认使用基础分组（推荐）
        parts = BasicSplit(nameOnly)

        ' 若启用词典分组，请取消下方注释并注释上方 EnsureDictionariesLoaded() parts = DictSplit(nameOnly)

        ' 生成 CheckBox 控件
        For Each word In parts
            Dim cb As New CheckBox With {
                .Text = word,
                .Appearance = Appearance.Button,
                .AutoSize = True,
                .Padding = New Padding(0),
                .Margin = New Padding(4),
                .BackColor = Color.White,
                .FlatStyle = FlatStyle.Flat,
                .Cursor = Cursors.Default,
                .Font = New Font("Microsoft YaHei", 15, GraphicsUnit.Pixel),
                .ForeColor = Color.FromArgb(43, 43, 43)
            }
            cb.FlatAppearance.BorderSize = 1
            cb.FlatAppearance.BorderColor = Color.White 'FromArgb(43, 43, 43)
            cb.FlatAppearance.MouseDownBackColor = Color.LemonChiffon
            cb.FlatAppearance.MouseOverBackColor = Color.Silver
            cb.FlatAppearance.CheckedBackColor = Color.Gainsboro

            FlowLayoutPanel1.Controls.Add(cb)
        Next
    End Sub

    ''' <summary>
    ''' 基础分割法：符号+驼峰+数字+中文字符识别
    ''' </summary>
    Private Function BasicSplit(input As String) As List(Of String)
        input = input.Replace("_", " ").Replace("-", " ")
        Dim rawParts = Regex.Split(input, "\s+")
        Dim result As New List(Of String)

        For Each part In rawParts
            If String.IsNullOrEmpty(part) Then Continue For
            Dim tokens = Regex.Matches(part, "([A-Z]?[a-z]+|[A-Z]+(?![a-z])|\d+|[\u4e00-\u9fa5]+)")
            For Each m As Match In tokens
                result.Add(m.Value)
            Next
        Next

        Return result
    End Function

    ''' <summary>
    ''' 最大匹配法（中英文词典分组）—— 保留
    ''' </summary>
    Private Function DictSplit(input As String) As List(Of String)
        Dim result As New List(Of String)
        Dim i As Integer = 0

        While i < input.Length
            Dim found As Boolean = False
            For j = input.Length To i + 1 Step -1
                Dim subStr = input.Substring(i, j - i)
                If englishDict.Contains(subStr.ToLower()) OrElse chineseDict.Contains(subStr) Then
                    result.Add(subStr)
                    i = j
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                result.Add(input(i).ToString())
                i += 1
            End If
        End While

        Return result
    End Function

    '''' <summary>
    '''' 加载词典，只加载一次（已注释，可启用）
    '''' </summary>
    'Private Sub EnsureDictionariesLoaded()
    '    If englishDict Is Nothing Then
    '        englishDict = New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
    '        If File.Exists("Dictionaries\english-words.txt") Then
    '            For Each line In File.ReadLines("Dictionaries\english-words.txt")
    '                Dim word = line.Trim()
    '                If word <> "" Then englishDict.Add(word)
    '            Next
    '        End If
    '    End If

    '    If chineseDict Is Nothing Then
    '        chineseDict = New HashSet(Of String)
    '        If File.Exists("Dictionaries\cedict_ts.u8") Then
    '            For Each line In File.ReadLines("Dictionaries\cedict_ts.u8")
    '                If line.StartsWith("#") Then Continue For
    '                Dim parts = line.Split(" "c)
    '                If parts.Length > 0 Then chineseDict.Add(parts(0))
    '            Next
    '        End If
    '    End If
    'End Sub

    ''' <summary>
    ''' 复制所有选中的词
    ''' </summary>

    Private Sub ButtonCopySelected_Click(sender As Object, e As EventArgs) Handles ButtonCopySelected.Click
        If MetroTabControl1.SelectedIndex = 0 Then
            Dim selectedWords As New List(Of String)
            For Each ctrl As Control In FlowLayoutPanel1.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                    If cb.Checked Then
                        selectedWords.Add(cb.Text)
                    End If
                End If
            Next
            If selectedWords.Count = 0 Then
                MessageBox.Show("请先选择要复制的词", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim combinedText = String.Join("", selectedWords)
            Clipboard.SetText(combinedText)
            MessageBox.Show("取词已复制:" & vbCrLf & combinedText, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf MetroTabControl1.SelectedIndex = 1 Then
            Clipboard.SetText(TextBox1.Text)
            MessageBox.Show("文本已复制。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MessageBox.Show("该功能仅支持「词典拆分」选项卡，请右键复制所选文本。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub topButton_CheckStateChanged(sender As Object, e As EventArgs) Handles topButton.CheckStateChanged
        If topButton.Checked = True Then
            TopMost = True
            topButton.ImageIndex = 1

        Else
            TopMost = False
            topButton.ImageIndex = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedWords As New List(Of String)
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    selectedWords.Add(cb.Text)
                End If
            End If
        Next
        If selectedWords.Count = 0 Then
            MessageBox.Show("请先取词。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim combinedText = String.Join("", selectedWords)
        Form1.searchText.Text = combinedText
        Form1.optChange("转到「查找」选项卡以继续", Color.White, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedWords As New List(Of String)
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                If cb.Checked Then
                    selectedWords.Add(cb.Text)
                End If
            End If
        Next
        If selectedWords.Count = 0 Then
            MessageBox.Show("请先选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim combinedText = String.Join("", selectedWords)
        Form1.starText.Text = "{" & combinedText & "}{}{}"
        Form1.optChange("转到「星标」选项卡以继续", Color.White, 0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MetroTabControl1.SelectedIndex = 0 Then
            Button4.Visible = True
            ButtonCopySelected.Visible = True
            Dim totalCount As Integer = 0
            Dim checkedCount As Integer = 0

            ' 统计当前选中数量
            For Each ctrl As Control In FlowLayoutPanel1.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb = DirectCast(ctrl, CheckBox)
                    totalCount += 1
                    If cb.Checked Then checkedCount += 1
                End If
            Next

            ' 决定是“全选”还是“取消全选”
            Dim selectAll As Boolean = checkedCount < totalCount

            For Each ctrl As Control In FlowLayoutPanel1.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb = DirectCast(ctrl, CheckBox)
                    cb.Checked = selectAll
                End If
            Next
            '' 可选：更新按钮文字
            'Button4.Text = If(selectAll, "取消选中", "全选选中")
        ElseIf MetroTabControl1.SelectedIndex = 1 Then
            TextBox1.SelectAll()   '选中全部文本
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MetroTabControl1.SelectedIndex = 0 Then
            Dim sfd As New SaveFileDialog()
            Dim selectedWords As New List(Of String)
            For Each ctrl As Control In FlowLayoutPanel1.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim cb As CheckBox = DirectCast(ctrl, CheckBox)
                    If cb.Checked Then
                        selectedWords.Add(cb.Text)
                    End If
                End If
            Next
            If selectedWords.Count = 0 Then
                MessageBox.Show("请先选择要复制的词", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Dim combinedText = String.Join("", selectedWords)
            sfd.Title = "保存文本文件"
            sfd.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"
            sfd.FileName = "取词文本.txt" '默认文件名
            sfd.DefaultExt = "txt"

            If sfd.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(sfd.FileName, combinedText, System.Text.Encoding.UTF8)
                If MessageBox.Show("文本保存成功，点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Process.Start(sfd.FileName)
                End If
            End If
        ElseIf MetroTabControl1.SelectedIndex = 1 Then
            Dim sfd As New SaveFileDialog()
            sfd.Title = "保存文本文件"
            sfd.Filter = "文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*"
            sfd.FileName = "文件名文本.txt" '默认文件名
            sfd.DefaultExt = "txt"
            If sfd.ShowDialog() = DialogResult.OK Then
                System.IO.File.WriteAllText(sfd.FileName, TextBox1.Text, System.Text.Encoding.UTF8)
                If MessageBox.Show("文本保存成功，点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Process.Start(sfd.FileName)
                End If
            End If
        End If
    End Sub
End Class
