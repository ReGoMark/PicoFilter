Imports System.IO
Imports Sunny.UI

Partial Class Form1

    Public Sub DrawChart()
        Dim options As New UIDoughnutOption()
        '设置Title
        options.Title = New UITitle()
        options.Title.Text = ""
        options.ToolTip.Visible = True

        ' 设置Legend
        options.Legend = New UILegend()
        options.Legend.Orient = UIOrient.Vertical
        options.Legend.Top = UITopAlignment.Bottom
        options.Legend.Left = UILeftAlignment.Left
        If BMPLoad > 0 Then
            options.Legend.AddData("BMP", Color.FromArgb(91, 143, 243))
        End If
        If GIFLoad > 0 Then
            options.Legend.AddData("GIF", Color.FromArgb(79, 155, 144))
        End If
        If ICOLoad > 0 Then
            options.Legend.AddData("ICO", Color.FromArgb(92, 111, 143))
        End If
        If JPGLoad > 0 Then
            options.Legend.AddData("JPEG", Color.FromArgb(245, 189, 25))
        End If
        If PNGLoad > 0 Then
            options.Legend.AddData("PNG", Color.FromArgb(231, 104, 68))
        End If
        If TIFLoad > 0 Then
            options.Legend.AddData("TIFF", Color.FromArgb(253, 149, 193))
        End If
        If WBPLoad > 0 Then
            options.Legend.AddData("WEBP", Color.FromArgb(146, 111, 200))
        End If

        ' 设置Series
        Dim series As New UIDoughnutSeries()
        If FormAnalysis.UiComboBox1.SelectedIndex = 0 Then
            series.Name = "加载 " & SumLoad & " 项"
        ElseIf FormAnalysis.UiComboBox1.SelectedIndex = 1 Then
            series.Name = "筛选 " & SumFilt & " 项"
        End If

        series.Center = New UICenter(50, 45)
        series.Radius.Inner = 40
        series.Radius.Outer = 70
        series.Label.Show = True
        series.Label.Position = UIPieSeriesLabelPosition.Center

        '增加数据
        If FormAnalysis.UiComboBox1.SelectedIndex = 0 Then
            series.AddData("BMP", BMPLoad, Color.FromArgb(91, 143, 243))
            series.AddData("GIF", GIFLoad, Color.FromArgb(79, 155, 144))
            series.AddData("ICO", ICOLoad, Color.FromArgb(92, 111, 143))
            series.AddData("JPEG", JPGLoad, Color.FromArgb(245, 189, 25))
            series.AddData("PNG", PNGLoad, Color.FromArgb(231, 104, 68))
            series.AddData("TIFF", TIFLoad, Color.FromArgb(253, 149, 193))
            series.AddData("WEBP", WBPLoad, Color.FromArgb(146, 111, 200))
        ElseIf FormAnalysis.UiComboBox1.SelectedIndex = 1 Then
            series.AddData("BMP", BMPFilt, Color.FromArgb(91, 143, 243))
            series.AddData("GIF", GIFFilt, Color.FromArgb(79, 155, 144))
            series.AddData("ICO", ICOFilt, Color.FromArgb(92, 111, 143))
            series.AddData("JPEG", JPGFilt, Color.FromArgb(245, 189, 25))
            series.AddData("PNG", PNGFilt, Color.FromArgb(231, 104, 68))
            series.AddData("TIFF", TIFFilt, Color.FromArgb(253, 149, 193))
            series.AddData("WEBP", WBPFilt, Color.FromArgb(146, 111, 200))
        End If
        ' 增加Series
        options.Series.Clear()
        options.Series.Add(series)

        ' 显示数据小数位数
        options.DecimalPlaces = 0
        FormAnalysis.UiDoughnutChart1.SetOption(options)
    End Sub

    Public Sub UpdateAnalysis()
        ' 各种格式的文件数量
        Dim jpgCount As Integer = 0
        Dim pngCount As Integer = 0
        Dim gifCount As Integer = 0
        Dim bmpCount As Integer = 0
        Dim icoCount As Integer = 0
        Dim tifCount As Integer = 0
        Dim webpCount As Integer = 0
        Dim mark2count As Integer = 0
        Dim mark3count As Integer = 0
        Dim mark1count As Integer = 0
        ' 遍历 listviewfilt 统计文件格式数量
        For Each item As ListViewItem In ListViewFilt.Items
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
                Case ".TIF", ".TIFF"
                    tifCount += 1
                Case ".WEBP"
                    webpCount += 1
            End Select
        Next

        ' 更新格式统计信息
        SumFilt = ListViewFilt.Items.Count
        JPGFilt = jpgCount
        PNGFilt = pngCount
        BMPFilt = bmpCount
        GIFFilt = gifCount
        ICOFilt = icoCount
        TIFFilt = tifCount
        WBPFilt = webpCount

        ' 计算文件大小
        Dim sumsizestr = FormatFileSize(LoadSize)

        ' 计算加载时间
        Dim loadedTimeStr = FormatLoadTime(LoadTime)

        ' 更新 formanalysis 中的标签
        FormAnalysis.AnaLoadCount.Text = SumLoad
        FormAnalysis.AnaLoadSizeAndTime.Text = sumsizestr & "," & loadedTimeStr
        'formanalysis.AnaLoadTime.Text = loadedTimeStr
        If FolderNameString = "" Then
            FormAnalysis.Label46.Text = "等待加载数据"
        Else
            FormAnalysis.Label46.Text = FolderNameString
        End If

        FormAnalysis.AnaLoadpngCount.Text = PNGLoad
        FormAnalysis.AnaLoadjpgCount.Text = JPGLoad
        FormAnalysis.AnaLoadbmpCount.Text = BMPLoad
        FormAnalysis.AnaLoadicoCount.Text = ICOLoad
        FormAnalysis.AnaLoadgifCount.Text = GIFLoad

        FormAnalysis.AnaLoadtifCount.Text = TIFLoad
        FormAnalysis.AnaLoadwebpCount.Text = WBPLoad

        FormAnalysis.AnaFiltCount.Text = "↓ " & SumFilt & " = " & (SumLoad - SumFilt)

        FormAnalysis.AnaFiltpngCount.Text = PNGFilt
        FormAnalysis.AnaFiltjpgCount.Text = JPGFilt
        FormAnalysis.AnaFiltbmpCount.Text = BMPFilt
        FormAnalysis.AnaFilticoCount.Text = ICOFilt
        FormAnalysis.AnaFiltgifCount.Text = GIFFilt

        FormAnalysis.AnaFilttifCount.Text = TIFFilt
        FormAnalysis.AnaFiltwebpCount.Text = WBPFilt

        ' 计算格式占比(load)
        FormAnalysis.AnaLoadpngPercn.Text = If(SumLoad > 0, (PNGLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaLoadjpgPercn.Text = If(SumLoad > 0, (JPGLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaLoadbmpPercn.Text = If(SumLoad > 0, (BMPLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaLoadicoPercn.Text = If(SumLoad > 0, (ICOLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaLoadgifPercn.Text = If(SumLoad > 0, (GIFLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaLoadtifPercn.Text = If(SumLoad > 0, (TIFLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaLoadwebpPercn.Text = If(SumLoad > 0, (WBPLoad / SumLoad * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFiltPercn.Text = If(SumLoad > 0, "↓ " & (SumFilt / SumLoad * 100).ToString("F1") & " %", "↓ 0.0 %")
        ' 计算格式占比(filt)
        FormAnalysis.AnaFiltpngPercn.Text = If(SumFilt > 0, (PNGFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFiltjpgPercn.Text = If(SumFilt > 0, (JPGFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFiltbmpPercn.Text = If(SumFilt > 0, (BMPFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFilticoPercn.Text = If(SumFilt > 0, (ICOFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFiltgifPercn.Text = If(SumFilt > 0, (GIFFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFilttifPercn.Text = If(SumFilt > 0, (TIFFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")
        FormAnalysis.AnaFiltwebpPercn.Text = If(SumFilt > 0, (WBPFilt / SumFilt * 100).ToString("F1") & " %", "0.0 %")

        ' 计算格式占比的剩余部分
        Dim result As Double = 0.0
        If SumFilt > 0 Then
            result = 100 - (PNGFilt / SumFilt * 100 + JPGFilt / SumFilt * 100 + BMPFilt / SumFilt * 100 + ICOFilt / SumFilt * 100 + GIFFilt / SumFilt * 100 + TIFFilt / SumFilt * 100 + WBPFilt / SumFilt * 100)
        End If
        'formanalysis.Label42.Text = Math.Round(result, 1).ToString("F1") & " %"

        ' 更新格式状态
        FormAnalysis.Label3.Text = If(PNGLoad > 0, "...PNG ●", "...PNG")
        FormAnalysis.Label4.Text = If(JPGLoad > 0, "...JPG ●", "...JPG")
        FormAnalysis.Label5.Text = If(BMPLoad > 0, "...BMP ●", "...BMP")
        FormAnalysis.Label6.Text = If(ICOLoad > 0, "...ICO ●", "...ICO")
        FormAnalysis.Label7.Text = If(GIFLoad > 0, "...GIF ●", "...GIF")

        FormAnalysis.Label47.Text = If(TIFLoad > 0, "...TIF ●", "...TIF")
        FormAnalysis.Label48.Text = If(WBPLoad > 0, "...WBP ●", "...WBP")

        ' 更新格式状态（listviewfilt中的文件）
        FormAnalysis.Label33.Text = If(PNGLoad - PNGFilt <> PNGLoad, "...PNG ●", "...PNG")
        FormAnalysis.Label32.Text = If(JPGLoad - JPGFilt <> JPGLoad, "...JPG ●", "...JPG")
        FormAnalysis.Label31.Text = If(BMPLoad - BMPFilt <> BMPLoad, "...BMP ●", "...BMP")
        FormAnalysis.Label30.Text = If(ICOLoad - ICOFilt <> ICOLoad, "...ICO ●", "...ICO")
        FormAnalysis.Label29.Text = If(GIFLoad - GIFFilt <> GIFLoad, "...GIF ●", "...GIF")

        FormAnalysis.Label34.Text = If(TIFLoad - TIFFilt <> TIFLoad, "...TIF ●", "...TIF")
        FormAnalysis.Label53.Text = If(WBPLoad - WBPFilt <> WBPLoad, "...WBP ●", "...WBP")

        ' 遍历 ListViewLT 统计特殊文件
        For Each item As ListViewItem In ListViewLoad.Items
            Dim fileName As String = item.SubItems(2).Text
            If fileName.Contains(Mark3) Then mark3count += 1
            If fileName.Contains(Mark2) Then mark2count += 1
            If fileName.Contains(Mark1) Then mark1count += 1
        Next
        ' 更新无效、存疑和超时文件数量

        If BtnMark.Checked = True Then
            FormAnalysis.Label45.Text = “{” & Mark1 & “}” & mark1count & “, ” & “{” & Mark2 & “}” & mark2count & “, ” & “{” & Mark3 & “}” & mark3count
            MarkString = “{” & Mark1 & “}” & mark1count & “ | ” & “{” & Mark2 & “}” & mark2count & “ | ” & “{” & Mark3 & “}” & mark3count
        Else
            FormAnalysis.Label45.Text = “转到「星标」选项卡启用”
            MarkString = "功能未启用"
        End If

        ' 显示当前文件夹的创建日期和最后修改日期（带星期时间日期）
        Try
            Dim folderPath As String = TbxOpen.Text.Trim()
            If Directory.Exists(folderPath) Then
                Dim dirInfo As New DirectoryInfo(folderPath)
                Dim createTime As DateTime = dirInfo.CreationTime
                Dim modifyTime As DateTime = dirInfo.LastWriteTime
                FormAnalysis.AnaCreateTime.Text = createTime.ToString("yyyy/MM/dd,HH:mm:ss")
                FormAnalysis.AnaModifyTime.Text = modifyTime.ToString("yyyy/MM/dd,HH:mm:ss")
            Else
                FormAnalysis.AnaCreateTime.Text = "yyyy/MM/dd,HH:mm:ss"
                FormAnalysis.AnaModifyTime.Text = "yyyy/MM/dd,HH:mm:ss"
            End If
        Catch ex As Exception
            ' formanalysis.Label50.Text = "error" formanalysis.Label52.Text = "读取失败"
        End Try

    End Sub

End Class