Imports System.IO
Imports System.Text.RegularExpressions

Public Class Form7
    ' 静态缓存：仅加载一次
    Private Shared englishDict As HashSet(Of String) = Nothing
    Private Shared chineseDict As HashSet(Of String) = Nothing
    'Private isSelecting As Boolean = False
    'Private selectStart As Point
    'Private selectionRect As Rectangle

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 默认使用基础分组
        FlowLayoutPanel1.AutoScroll = True
        MetroTabControl1.SelectedTab = MetroTabControl1.TabPages(0)

        'panelSelectionOverlay.BackColor = Color.Transparent
        'panelSelectionOverlay.Dock = DockStyle.Fill
        'panelSelectionOverlay.BringToFront()
        'panelSelectionOverlay.Cursor = Cursors.Cross
    End Sub

    'Private Sub panelSelectionOverlay_MouseDown(sender As Object, e As MouseEventArgs) Handles panelSelectionOverlay.MouseDown
    '    isSelecting = True
    '    selectStart = e.Location
    '    selectionRect = New Rectangle(e.Location, Size.Empty)
    '    panelSelectionOverlay.Invalidate()
    'End Sub

    'Private Sub panelSelectionOverlay_MouseMove(sender As Object, e As MouseEventArgs) Handles panelSelectionOverlay.MouseMove
    '    If isSelecting Then
    '        Dim x = Math.Min(selectStart.X, e.X)
    '        Dim y = Math.Min(selectStart.Y, e.Y)
    '        Dim width = Math.Abs(e.X - selectStart.X)
    '        Dim height = Math.Abs(e.Y - selectStart.Y)
    '        selectionRect = New Rectangle(x, y, width, height)
    '        panelSelectionOverlay.Invalidate()
    '    End If
    'End Sub

    'Private Sub panelSelectionOverlay_MouseUp(sender As Object, e As MouseEventArgs) Handles panelSelectionOverlay.MouseUp
    '    isSelecting = False
    '    panelSelectionOverlay.Invalidate()

    '    ' 检查被选中的 CheckBox
    '    For Each ctrl As Control In FlowLayoutPanel1.Controls
    '        If TypeOf ctrl Is CheckBox Then
    '            Dim cb = DirectCast(ctrl, CheckBox)
    '            ' 获取控件相对于 selectionOverlay 的位置
    '            Dim ctrlBounds = cb.Bounds
    '            Dim ctrlLocation = FlowLayoutPanel1.PointToScreen(cb.Location)
    '            ctrlLocation = panelSelectionOverlay.PointToClient(ctrlLocation)
    '            ctrlBounds.Location = ctrlLocation

    '            If selectionRect.IntersectsWith(ctrlBounds) Then
    '                cb.Checked = Not My.Computer.Keyboard.CtrlKeyDown ' Ctrl 取消勾选
    '            End If
    '        End If
    '    Next
    'End Sub

    'Private Sub panelSelectionOverlay_Paint(sender As Object, e As PaintEventArgs) Handles panelSelectionOverlay.Paint
    '    If isSelecting Then
    '        Using pen As New Pen(Color.Blue, 1)
    '            pen.DashStyle = Drawing2D.DashStyle.Dot
    '            e.Graphics.DrawRectangle(pen, selectionRect)
    '        End Using
    '    End If
    'End Sub

    ''' <summary>
    ''' 外部调用接口：传入文件名，进行分词并生成标签
    ''' </summary>
    Public Sub LoadFromFileName(fileName As String)
        FlowLayoutPanel1.Controls.Clear()

        Dim nameOnly As String = Path.GetFileNameWithoutExtension(fileName)
        Dim parts As List(Of String)

        ' 默认使用基础分组（推荐）
        parts = BasicSplit(nameOnly)

        ' 若启用词典分组，请取消下方注释并注释上方
        ' EnsureDictionariesLoaded()
        ' parts = DictSplit(nameOnly)

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
                .Cursor = Cursors.Hand,
                .Font = New Font("微软雅黑", 15, GraphicsUnit.Pixel),
                .ForeColor = Color.DarkSlateBlue
            }
            cb.FlatAppearance.BorderSize = 1
            cb.FlatAppearance.BorderColor = Color.DarkSlateBlue
            cb.FlatAppearance.MouseDownBackColor = Color.LemonChiffon
            cb.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            cb.FlatAppearance.CheckedBackColor = Color.Lavender

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
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FlowLayoutPanel1.Controls.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("确认要关闭吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        ElseIf FlowLayoutPanel1.Controls.Count = 0 Then
            Me.Close()
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
            MessageBox.Show("请先选择。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim combinedText = String.Join("", selectedWords)
        Form1.searchText.Text = combinedText
        Form1.optChange("转到「查找」选项卡以继续。", Color.Lavender, 0)
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
        Form1.TextBox1.Text = "{" & combinedText & "}{}{}"
        Form1.optChange("转到「星标」选项卡以继续。", Color.Lavender, 0)
    End Sub

    Private Sub FlowLayoutPanel1_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Click

    End Sub
End Class
