Imports System.IO
Imports System.IO.Compression
Imports OfficeOpenXml

Partial Class Form1
    '    Dim FormatString As String
    '    ' 添加表头信息到 Excel 工作表
    '    Private Sub AddHeaderInfo(worksheet As ExcelWorksheet, sumlabel0 As String, sumsizestr As String, minstr As String, sumlabel1 As String, filterConditions As String)
    '        worksheet.Cells("J1").Value = sumlabel0
    '        worksheet.Cells("J2").Value = " " & sumsizestr
    '        worksheet.Cells("J3").Value = " " & minstr
    '        worksheet.Cells("J5").Value = sumlabel1
    '        worksheet.Cells("J6").Value = " " & FormatString
    '        worksheet.Cells("J4").Value = lbldStr
    '        worksheet.Cells("I1").Value = "已扫描"
    '        worksheet.Cells("I2").Value = "总大小"
    '        worksheet.Cells("I3").Value = "耗时"
    '        worksheet.Cells("I5").Value = "筛选结果"
    '        worksheet.Cells("I6").Value = "筛选条件"
    '        worksheet.Cells("I4").Value = "星标"
    '        worksheet.Cells("I1:I6").Style.Font.Bold = True
    '        worksheet.Cells("I1:I6").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
    '        worksheet.Cells("I1:I6").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender)
    '    End Sub

    '    ' 填充 ListView 的数据到 Excel 工作表，并匹配背景颜色
    '    Private Sub FillListViewData(worksheet As ExcelWorksheet, listView As ListView)
    '        For i As Integer = 0 To listView.Items.Count - 1
    '            For j As Integer = 0 To listView.Items(i).SubItems.Count - 1
    '                Dim cell = worksheet.Cells(i + 2, j + 1)
    '                cell.Value = listView.Items(i).SubItems(j).Text

    '                ' 获取 ListView 项目的背景颜色
    '                Dim lvItemColor As Color = listView.Items(i).BackColor
    '                If lvItemColor = Color.Empty Then lvItemColor = listView.BackColor ' 默认使用 ListView 背景色

    '                ' 设置 Excel 单元格背景颜色
    '                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
    '                cell.Style.Fill.BackgroundColor.SetColor(lvItemColor)
    '            Next
    '        Next
    '    End Sub

    '    ' 获取筛选条件字符串列表
    '    Private Function GetFilterConditions(jpgSelected As Boolean, pngSelected As Boolean, gifSelected As Boolean, bmpSelected As Boolean, icoSelected As Boolean, inreslnSelected As Boolean, volreslnSelected As Boolean, resolutionSelected As Boolean, plsreslnSelected As Boolean, mnsreslnSelected As Boolean) As List(Of String)
    '        Dim FiltString As New List(Of String)
    '        Dim resolutionStr = $" {TbxWd.Text} × {TbxHt.Text}"
    '        If inreslnSelected And resolutionSelected And Not volreslnSelected Then
    '            FiltString.Add($"排除分辨率 {resolutionStr}")
    '        ElseIf resolutionSelected And Not inreslnSelected And Not volreslnSelected And Not plsreslnSelected And Not mnsreslnSelected Then
    '            FiltString.Add($"分辨率 {resolutionStr}")
    '        ElseIf volreslnSelected And resolutionSelected And inreslnSelected Then
    '            FiltString.Add($"旋转&排除分辨率 {resolutionStr}")
    '        ElseIf volreslnSelected And resolutionSelected And Not inreslnSelected Then
    '            FiltString.Add($"旋转分辨率 {resolutionStr}")
    '        ElseIf plsreslnSelected And resolutionSelected And Not volreslnSelected And Not inreslnSelected And Not mnsreslnSelected Then
    '            FiltString.Add($"大于分辨率 {resolutionStr}")
    '        ElseIf mnsreslnSelected And resolutionSelected And Not volreslnSelected And Not inreslnSelected And Not plsreslnSelected Then
    '            FiltString.Add($"小于分辨率 {resolutionStr}")
    '        End If
    '        If jpgSelected Then FiltString.Add("JPG")
    '        If pngSelected Then FiltString.Add("PNG")
    '        If gifSelected Then FiltString.Add("GIF")
    '        If bmpSelected Then FiltString.Add("BMP")
    '        If icoSelected Then FiltString.Add("ICO")
    '        FormatString = String.Join("  |  ", FiltString)
    '        Return FiltString
    '    End Function

    Private Sub SaveAsXlsx()
        '        Dim now As DateTime = DateTime.Now
        '        Dim formattedDateTime As String = now.ToString("yyyyMMddHHmm")
        '        Dim jpgSelected As Boolean = BtnJPG.Checked
        '        Dim pngSelected As Boolean = BtnPNG.Checked
        '        Dim gifSelected As Boolean = BtnGIF.Checked
        '        Dim reslnSelected As Boolean = BtnResln.Checked
        '        Dim bmpSelected As Boolean = BtnBMP.Checked
        '        Dim icoSelected As Boolean = BtnICO.Checked
        '        Dim inreslnSelected As Boolean = BtnEx.Checked
        '        Dim volreslnSelected As Boolean = BtnVol.Checked
        '        Dim plsreslnSelected As Boolean = BtnHigher.Checked
        '        Dim mnsreslnSelected As Boolean = BtnLower.Checked

        '        Dim sumsizestr = FormatFileSize(LoadSize)
        '        Dim loadedTimeStr = FormatLoadTime(LoadTime)
        '        Dim result =
        '            GetFilterConditions(jpgSelected, pngSelected, gifSelected, bmpSelected, icoSelected, inreslnSelected, volreslnSelected, reslnSelected, plsreslnSelected, mnsreslnSelected)

        '        Using saveFileDialog As New SaveFileDialog
        '            saveFileDialog.FileName = "表格_" & formattedDateTime & ".xlsx"
        '            saveFileDialog.Filter = "Excel 文件 (*.xlsx)|*.xlsx"
        '            saveFileDialog.Title = "导出为 Excel 文件"
        '            Dim currentFolder As String = TbxOpen.Text.Trim()
        '            If Directory.Exists(currentFolder) Then
        '                saveFileDialog.InitialDirectory = currentFolder
        '            End If

        '            If saveFileDialog.ShowDialog() = DialogResult.OK Then
        '                Try
        '                    Dim filePath As String = saveFileDialog.FileName
        '                    Dim fileInfo As New FileInfo(filePath)

        '                    ' 进度条初始化
        '                    ProgressBarFilt.Value = 0
        '                    ProgressBarFilt.Maximum = ListViewFilt.Items.Count
        '                    ProgressBarFilt.Visible = True
        '                    'optChange("表格正在导出，请稍候", 4, -1)

        '                    Using package As New ExcelPackage(fileInfo)
        '                        Dim worksheet = package.Workbook.Worksheets.Add("筛选结果" & formattedDateTime)
        '                        AddHeaderInfo(worksheet, LblLoad.Text, sumsizestr, loadedTimeStr, LblFilt.Text, String.Join(" ", result))
        '                        SetListViewHeaders(worksheet, ListViewFilt)

        '                        ' 填充数据并更新进度条
        '                        For i As Integer = 0 To ListViewFilt.Items.Count - 1
        '                            For j As Integer = 0 To ListViewFilt.Items(i).SubItems.Count - 1
        '                                Dim cell = worksheet.Cells(i + 2, j + 1)
        '                                cell.Value = ListViewFilt.Items(i).SubItems(j).Text
        '                                Dim lvItemColor As Color = ListViewFilt.Items(i).BackColor
        '                                If lvItemColor = Color.Empty Then lvItemColor = ListViewFilt.BackColor
        '                                cell.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
        '                                cell.Style.Fill.BackgroundColor.SetColor(lvItemColor)
        '                            Next
        '                            ProgressBarFilt.Value = i + 1
        '                            Application.DoEvents()
        '                        Next

        '                        package.Save()
        '                    End Using

        '                    ProgressBarFilt.Visible = False
        '                    'optChange(opttext, 0)
        '                    Dim opt = MessageBox.Show("表格已导出成功！点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        '                    If opt = DialogResult.Yes Then
        '                        Process.Start("explorer.exe", filePath)
        '                    End If
        '                Catch ex As Exception
        '                    ProgressBarFilt.Visible = False
        '                    MessageBox.Show("表格导出时发生错误: " & ex.Message, "未完成", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                End Try
        '            End If
        '        End Using
    End Sub

    '    ' 设置 ListView 的表头到 Excel 工作表
    '    Private Sub SetListViewHeaders(worksheet As ExcelWorksheet, listView As ListView)
    '        For i As Integer = 0 To listView.Columns.Count - 1
    '            worksheet.Cells(1, i + 1).Value = listView.Columns(i).Text
    '            Dim columnWidth As Double = listView.Columns(i).Width / 7 ' 调整比例使宽度接近视觉一致
    '            worksheet.Column(i + 1).Width = columnWidth
    '        Next
    '        For j As Integer = 1 To listView.Columns.Count - 1
    '            worksheet.Column(j + 3).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right
    '        Next
    '        worksheet.Column(2).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center
    '        worksheet.Column(3).Width = listView.Columns(3).Width / 2.5
    '        worksheet.Column(10).Width = listView.Columns(4).Width
    '        worksheet.Cells("A1:G1").Style.Font.Bold = True
    '        worksheet.Cells("A1:G1").Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid
    '        worksheet.Cells("A1:G1").Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.Lavender)
    'End Sub
    Private Sub SaveAsZip()
        Using sfd As New SaveFileDialog()
            sfd.Title = "导出为 Zip 文件"
            sfd.Filter = "ZIP 压缩包 (*.zip)|*.zip"
            sfd.FileName = "压缩结果_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".zip"

            If sfd.ShowDialog() = DialogResult.OK Then
                Dim zipPath As String = sfd.FileName
                Dim totalFiles As Integer = ListViewFilt.Items.Count
                Dim currentFile As Integer = 0

                Try
                    If File.Exists(zipPath) Then File.Delete(zipPath)

                    ' 显示进度条
                    ProgressBarFilt.Value = 0
                    ProgressBarFilt.Maximum = totalFiles
                    ProgressBarFilt.Visible = True

                    ' 创建一个4MB的缓冲区
                    Const BufferSize As Integer = 4 * 1024 * 1024

                    Using zipStream As FileStream = New FileStream(zipPath, FileMode.Create)
                        Using archive As New ZipArchive(zipStream, ZipArchiveMode.Create)
                            ' 并行处理大文件
                            Dim largeFiles = From item In ListViewFilt.Items.Cast(Of ListViewItem)()
                                             Let fileSize = New FileInfo(Path.Combine(TbxOpen.Text.Trim(), item.SubItems(2).Text)).Length
                                             Where fileSize > BufferSize
                                             Select item

                            ' 处理大文件
                            For Each item In largeFiles
                                Dim fileName As String = item.SubItems(2).Text
                                Dim sourcePath As String = Path.Combine(TbxOpen.Text.Trim(), fileName)

                                If File.Exists(sourcePath) Then
                                    Dim entry = archive.CreateEntry(fileName, Compression.CompressionLevel.Fastest)
                                    Using entryStream = entry.Open()
                                        Using fileStream = File.OpenRead(sourcePath)
                                            Dim buffer(BufferSize - 1) As Byte
                                            Dim bytesRead As Integer

                                            While (bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0
                                                entryStream.Write(buffer, 0, bytesRead)
                                            End While
                                        End Using
                                    End Using
                                End If

                                currentFile += 1
                                ProgressBarFilt.Value = currentFile
                                'Me.Text = $"{verinfo}  |  正在压缩... {currentFile}/{totalFiles} ({CInt(currentFile / totalFiles * 100)}%)"
                                Application.DoEvents()
                            Next

                            ' 处理小文件
                            For Each item As ListViewItem In ListViewFilt.Items
                                Dim fileName As String = item.SubItems(2).Text
                                Dim sourcePath As String = Path.Combine(TbxOpen.Text.Trim(), fileName)

                                If File.Exists(sourcePath) AndAlso Not largeFiles.Contains(item) Then
                                    Dim entry = archive.CreateEntry(fileName, Compression.CompressionLevel.Optimal)
                                    Using entryStream = entry.Open(), fileStream = File.OpenRead(sourcePath)
                                        fileStream.CopyTo(entryStream, BufferSize)
                                    End Using
                                End If

                                currentFile += 1
                                ProgressBarFilt.Value = currentFile
                                'Me.Text = $"{verinfo}  |  正在压缩... {currentFile}/{totalFiles} ({CInt(currentFile / totalFiles * 100)}%)"
                                Application.DoEvents()
                            Next
                        End Using
                    End Using

                    ' 恢复界面
                    ProgressBarFilt.Visible = False
                    'optChange(opttext, 0)
                    'Me.Text = verinfo

                    If MessageBox.Show("压缩包保存成功。点击按钮打开", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Process.Start(zipPath)
                    End If
                Catch ex As Exception
                    ProgressBarFilt.Visible = False
                    'Me.Text = verinfo
                    MessageBox.Show("压缩失败：" & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

End Class