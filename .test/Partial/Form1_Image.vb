Imports System.IO

Partial Class Form1

    Public Sub LoadImages(folderPath As String)
        ListViewLoad.Items.Clear()
        ListViewFilt.Items.Clear()
        ProgressBarLoad.Visible = True

        LoadCount = 0
        LoadTime = 0
        LoadSize = 0
        ProgressBarLoad.Value = 0

        Dim ItemIndex As Integer = 1
        Dim BMPCount As Integer = 0,
            GIFCount As Integer = 0,
            ICOCount As Integer = 0,
            JPGCount As Integer = 0,
            PNGCount As Integer = 0,
            TIFCount As Integer = 0,
            WBPCount As Integer = 0

        Dim ImageFormat As String() =
           {".jpg", ".jpeg", ".jpe", ".jfif", ".png", ".gif", ".bmp", ".ico", ".tiff", ".tif", ".webp"}
        Dim FolderName As String = Path.GetFileName(folderPath.Trim())

        Dim CreateTime As DateTime = (New DirectoryInfo(folderPath)).CreationTime

        Dim Files =
            Directory.GetFiles(folderPath).Where(Function(f) ImageFormat.Contains(Path.GetExtension(f).ToLower())).ToList()
        Dim LoadTimer As New Stopwatch()
        Dim ListViewItems As New List(Of ListViewItem)

        Dim SubFolder As Boolean = Directory.GetDirectories(folderPath).Length > 0

        ProgressBarLoad.Maximum = Files.Count
        LoadTimer.Start()

        For Each File In Files
            Try
                Dim ItemInfo As New FileInfo(File)
                Dim Item As New ListViewItem(ItemIndex.ToString())
                Dim ItemSize As Double = ItemInfo.Length 'get item size

                Dim ItemName As String = Path.GetFileName(File) 'get item name
                Dim ItemFormat As String = ItemInfo.Extension.ToUpper() 'get item format to upper
                Dim ItemResln As String = GetResln(File) 'get item resolution
                Dim ItemSizeFormat As String = FormatFileSize(ItemSize) 'formatted item size

                Select Case ItemFormat
                    Case ".JPG", ".JPEG", ".JPE", ".JFIF"
                        JPGCount += 1
                    Case ".PNG"
                        PNGCount += 1
                    Case ".GIF"
                        GIFCount += 1
                    Case ".ICO"
                        ICOCount += 1
                    Case ".BMP"
                        BMPCount += 1
                    Case ".TIF", ".TIFF"
                        TIFCount += 1
                    Case ".WEBP"
                        WBPCount += 1
                End Select

                If BtnMark.Checked = True Then
                    Dim highlightMark As String = "★"

                    Select Case True
                        Case ItemName.Contains(Mark3)
                            'item.BackColor = Color.MistyRose
                            MarkLoad += 1
                            'highlightMark = "★"

                        Case ItemName.Contains(Mark2)
                            'item.BackColor = Color.Cornsilk
                            MarkLoad += 1
                            'highlightMark = "★"

                        Case ItemName.Contains(Mark1)
                            'item.BackColor = Color.LightCyan
                            MarkLoad += 1
                            'highlightMark = "★"
                    End Select
                    Item.SubItems.Add(highlightMark) 'add mark
                Else
                    Item.SubItems.Add("") 'add empty mark
                End If

                Item.SubItems.Add(ItemName)
                Item.SubItems.Add(ItemResln)
                Item.SubItems.Add(ItemFormat)
                Item.SubItems.Add(ItemSizeFormat)
                Item.SubItems.Add(ItemInfo.LastWriteTime.ToString("yyyy/MM/dd,HH:mm:ss"))
                ListViewItems.Add(Item)

                LoadCount += 1 'count add
                ItemIndex += 1 'index add
                LoadSize += ItemSize 'size total
                ProgressBarLoad.Value += 1
            Catch ex As Exception
                Dim opt = MessageBox.Show(ex.Message & vbCrLf & "加载意外中断, 原因未知. ” & vbCrLf & "点击是继续, 点击否终止. ", "加载未完成", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If opt = DialogResult.No Then Exit For
            End Try
        Next
        ListViewLoad.Items.AddRange(ListViewItems.ToArray()) 'add items to listviewload

        LoadTimer.Stop()
        ProgressBarLoad.Visible = False
        LoadTime = LoadTimer.ElapsedMilliseconds 'get load time in ms

        Dim LblLoadString As New List(Of String)
        LblLoadString.Add($"加载 {Files.Count} 项")
        If MarkLoad > 0 Then LblLoadString.Add($"星标 {MarkLoad}")
        If BMPCount > 0 Then LblLoadString.Add($"BMP {BMPCount}")
        If GIFCount > 0 Then LblLoadString.Add($"GIF {GIFCount}")
        If ICOCount > 0 Then LblLoadString.Add($"ICO {ICOCount}")
        If JPGCount > 0 Then LblLoadString.Add($"JPG {JPGCount}")
        If PNGCount > 0 Then LblLoadString.Add($"PNG {PNGCount}")
        If TIFCount > 0 Then LblLoadString.Add($"TIF {TIFCount}")
        If WBPCount > 0 Then LblLoadString.Add($"WBP {WBPCount}")

        LblLoad.Text = String.Join("  |  ", LblLoadString)
        Text = VersionString & "  |  " & FolderName & "  |  " & FormatFileSize(LoadSize) & "  |  " & CreateTime.ToString("yyyy/MM/dd, HH:mm:ss")

        FolderNameString = FolderName
        SumLoad = Files.Count
        JPGLoad = JPGCount
        PNGLoad = PNGCount
        BMPLoad = BMPCount
        GIFLoad = GIFCount
        ICOLoad = ICOCount
        TIFLoad = TIFCount
        WBPLoad = WBPCount

        UpdateAnalysis()
        If FormAnalysis.Visible = True Then
            DrawChart()
        End If
        If FormTreeview.Visible = True Then
            FormTreeview.LoadTreeView(OpenPath)
        End If
    End Sub

    Private Sub FiltImages()
        ListViewFilt.Items.Clear()

        Dim TbxReslnWd As String = TbxWd.Text.Trim()
        Dim TbxReslnHt As String = TbxHt.Text.Trim()
        Dim ReslnWd As Integer = 0
        Dim ReslnHt As Integer = 0

        ' 校验宽高输入是否为数字
        If Not Integer.TryParse(TbxReslnWd, ReslnWd) OrElse Not Integer.TryParse(TbxReslnHt, ReslnHt) Then
            MessageBox.Show("宽度和高度必须为数字。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim BMPSelected As Boolean = BtnBMP.Checked
        Dim GIFSelected As Boolean = BtnGIF.Checked
        Dim ICOSelected As Boolean = BtnICO.Checked
        Dim JPGSelected As Boolean = BtnJPG.Checked
        Dim PNGSelected As Boolean = BtnPNG.Checked
        Dim TIFSelected As Boolean = BtnTIF.Checked
        Dim WBPSelected As Boolean = BtnWBP.Checked

        Dim ReslnSelected As Boolean = BtnResln.Checked
        Dim ExSelected As Boolean = BtnEx.Checked
        Dim VolSelected As Boolean = BtnVol.Checked
        Dim HigherSelected As Boolean = BtnHigher.Checked
        Dim LowerSelected As Boolean = BtnLower.Checked
        Dim FormatSelected As Boolean =
            BMPSelected Or GIFSelected Or ICOSelected Or JPGSelected Or PNGSelected Or TIFSelected Or WBPSelected

        Dim BMPCount As Integer = 0,
            GIFCount As Integer = 0,
            ICOCount As Integer = 0,
            JPGCount As Integer = 0,
            PNGCount As Integer = 0,
            TIFCount As Integer = 0,
            WBPCount As Integer = 0
        Dim MarkCount As Integer = 0
        Dim MatchCount As Integer = 0

        For Each Item As ListViewItem In ListViewLoad.Items
            Dim ItemFormat As String = Item.SubItems(4).Text
            Dim ItemSize As String = Item.SubItems(5).Text
            Dim ReslnString As String() = Item.SubItems(3).Text.Split("×"c)
            Dim Width As Integer = Integer.Parse(ReslnString(0))
            Dim Height As Integer = Integer.Parse(ReslnString(1))

            Dim FormatMatch As Boolean = False
            Dim ReslnMatch As Boolean = False
            Dim IsMatch As Boolean = False
            Dim IsSpecialMatch As Boolean = False

            If BMPSelected AndAlso ItemFormat = ".BMP" Then FormatMatch = True
            If GIFSelected AndAlso ItemFormat = ".GIF" Then FormatMatch = True
            If ICOSelected AndAlso ItemFormat = ".ICO" Then FormatMatch = True
            If JPGSelected AndAlso
            (ItemFormat = ".JPG" OrElse ItemFormat = ".JPEG" OrElse ItemFormat = ".JPE" OrElse ItemFormat = ".JFIF") Then FormatMatch = True
            If PNGSelected AndAlso ItemFormat = ".PNG" Then FormatMatch = True
            If TIFSelected AndAlso (ItemFormat = ".TIF" OrElse ItemFormat = ".TIFF") Then FormatMatch = True
            If WBPSelected AndAlso ItemFormat = ".WEBP" Then FormatMatch = True

            If ReslnSelected Then
                If ExSelected Then
                    ReslnMatch = (Width <> ReslnWd OrElse Height <> ReslnHt)
                ElseIf VolSelected AndAlso ReslnSelected Then
                    ' 只筛选旋转后的图片
                    ReslnMatch = (Width = ReslnHt AndAlso Height = ReslnWd)
                ElseIf VolSelected Then
                    ReslnMatch = (Width = ReslnHt AndAlso Height = ReslnWd) OrElse
                    (Width = ReslnWd AndAlso Height = ReslnHt)
                ElseIf HigherSelected Then
                    ReslnMatch = (Width > ReslnWd AndAlso Height > ReslnHt)
                ElseIf LowerSelected Then
                    ReslnMatch = (Width < ReslnWd AndAlso Height < ReslnHt)
                Else
                    ReslnMatch = (Width = ReslnWd AndAlso Height = ReslnHt)
                End If
            End If

            If FormatSelected AndAlso ReslnSelected Then
                IsMatch = FormatMatch AndAlso ReslnMatch
            ElseIf FormatSelected Then
                IsMatch = FormatMatch
            ElseIf ReslnSelected Then
                IsMatch = ReslnMatch
            Else
                IsMatch = False
            End If

            If IsMatch OrElse IsSpecialMatch Then
                Dim newItem As New ListViewItem(Item.SubItems(0).Text)
                newItem.SubItems.Add(Item.SubItems(1).Text)
                newItem.SubItems.Add(Item.SubItems(2).Text)
                newItem.SubItems.Add(Item.SubItems(3).Text)
                newItem.SubItems.Add(Item.SubItems(4).Text)
                newItem.SubItems.Add(ItemSize)
                newItem.SubItems.Add(Item.SubItems(6).Text)
                ListViewFilt.Items.Add(newItem)
                MatchCount += 1

                Select Case ItemFormat
                    Case ".JPG", ".JPEG"
                        JPGCount += 1
                    Case ".PNG"
                        PNGCount += 1
                    Case ".GIF"
                        GIFCount += 1
                    Case ".ICO"
                        ICOCount += 1
                    Case ".BMP"
                        BMPCount += 1
                    Case ".TIF", ".TIFF"
                        TIFCount += 1
                    Case ".WEBP"
                        WBPCount += 1
                End Select
            End If
        Next

        Dim LblFiltString As New List(Of String)
        LblFiltString.Add($"筛选 {MatchCount} 项")
        If BMPCount > 0 Then LblFiltString.Add($"BMP {BMPCount}")
        If GIFCount > 0 Then LblFiltString.Add($"GIF {GIFCount}")
        If ICOCount > 0 Then LblFiltString.Add($"ICO {ICOCount}")
        If JPGCount > 0 Then LblFiltString.Add($"JPG {JPGCount}")
        If PNGCount > 0 Then LblFiltString.Add($"PNG {PNGCount}")
        If TIFCount > 0 Then LblFiltString.Add($"TIF {TIFCount}")
        If WBPCount > 0 Then LblFiltString.Add($"WBP {WBPCount}")
        LblFilt.Text = String.Join("  |  ", LblFiltString)

        SumFilt = MatchCount
        JPGFilt = JPGCount
        PNGFilt = PNGCount
        BMPFilt = BMPCount
        GIFFilt = GIFCount
        ICOFilt = ICOCount
        TIFFilt = TIFCount
        WBPFilt = WBPCount

        UpdateAnalysis()
    End Sub

    Private Sub UpdateLblFilt()
        Dim MatchCount As Integer = ListViewFilt.Items.Count
        Dim ItemIndex As Integer = 1
        Dim BMPCount As Integer = 0,
            GIFCount As Integer = 0,
            ICOCount As Integer = 0,
            JPGCount As Integer = 0,
            PNGCount As Integer = 0,
            TIFCount As Integer = 0,
            WBPCount As Integer = 0

        For Each Item As ListViewItem In ListViewFilt.Items
            Dim ItemFormat As String = Item.SubItems(4).Text.ToUpper()
            Select Case ItemFormat
                Case ".JPG", ".JPEG"
                    JPGCount += 1
                Case ".PNG"
                    PNGCount += 1
                Case ".GIF"
                    GIFCount += 1
                Case ".ICO"
                    ICOCount += 1
                Case ".BMP"
                    BMPCount += 1
                Case ".TIF", ".TIFF"
                    TIFCount += 1
                Case ".WEBP"
                    WBPCount += 1
            End Select
        Next

        Dim LblFiltString As New List(Of String)
        LblFiltString.Add($"筛选 {SumFilt} 项")
        If BMPCount > 0 Then LblFiltString.Add($"BMP {BMPCount}")
        If GIFCount > 0 Then LblFiltString.Add($"GIF {GIFCount}")
        If ICOCount > 0 Then LblFiltString.Add($"ICO {ICOCount}")
        If JPGCount > 0 Then LblFiltString.Add($"JPG {JPGCount}")
        If PNGCount > 0 Then LblFiltString.Add($"PNG {PNGCount}")
        If TIFCount > 0 Then LblFiltString.Add($"TIF {TIFCount}")
        If WBPCount > 0 Then LblFiltString.Add($"WBP {WBPCount}")
        LblFilt.Text = String.Join("  |  ", LblFiltString)

        SumFilt = MatchCount
        JPGFilt = JPGCount
        PNGFilt = PNGCount
        BMPFilt = BMPCount
        GIFFilt = GIFCount
        ICOFilt = ICOCount
        TIFFilt = TIFCount
        WBPFilt = WBPCount

        UpdateAnalysis()
    End Sub

End Class