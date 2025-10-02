Module ListViewSort
    Private CurrentColumn As Integer = -1 '存储当前排序的列和顺序
    Private CurrentOrder As SortOrder = SortOrder.Ascending '存储当前排序的列和顺序

    Private Sub ListViewSort(ListView As ListView, Column As Integer)
        If Column = CurrentColumn Then
            If CurrentOrder = SortOrder.Ascending Then
                CurrentOrder = SortOrder.Descending
            Else
                CurrentOrder = SortOrder.Ascending
            End If
        Else
            CurrentColumn = Column
            CurrentOrder = SortOrder.Ascending
        End If
        updatecolumntext(ListView)
        ListView.ListViewItemSorter = New ListViewComparer(CurrentColumn, CurrentOrder)
        ListView.Sort()
    End Sub

    Private Sub updatecolumntext(listview As ListView)
        For i As Integer = 0 To listview.Columns.Count - 1
            Dim ColumnHeader As ColumnHeader = listview.Columns(i)
            ColumnHeader.Text = ColumnHeader.Text.Replace("▲", "").Replace("▼", "")
            ColumnHeader.Text = ColumnHeader.Text.Replace("◇", "").Replace("◆", "")

            Select Case i
                Case 0, 2, 3, 5, 6
                    If i = CurrentColumn Then
                        If CurrentOrder = SortOrder.Ascending Then
                            ColumnHeader.Text &= "▲"
                        Else
                            ColumnHeader.Text &= "▼"
                        End If
                    End If

                Case 4
                    If i = CurrentColumn Then
                        If CurrentOrder = SortOrder.Ascending Then
                            ColumnHeader.Text &= "◇"
                        Else
                            ColumnHeader.Text &= "◆"
                        End If
                    End If
            End Select

        Next
    End Sub

    Private Class ListViewComparer
        Implements IComparer
        Private Col As Integer
        Private Order As SortOrder

        Public Sub New(column As Integer, order As SortOrder)
            Me.Col = column
            Me.Order = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim ReturnVal As Integer = 0
            If TypeOf x Is ListViewItem AndAlso TypeOf y Is ListViewItem Then
                Dim item1 As ListViewItem = CType(x, ListViewItem)
                Dim item2 As ListViewItem = CType(y, ListViewItem)
                Select Case Col
                    Case 0 ' 序号列（按整数排序）
                        Dim num1 As Integer = Integer.Parse(item1.SubItems(Col).Text)
                        Dim num2 As Integer = Integer.Parse(item2.SubItems(Col).Text)
                        ReturnVal = num1.CompareTo(num2)

                    Case 2 ' 文件名列（自然排序）
                        ReturnVal = NatureSort(item1.SubItems(Col).Text, item2.SubItems(Col).Text)

                    Case 3 ' 分辨率（按像素总数排序）
                        Dim pixels1 As Integer = ReslnResolve(item1.SubItems(Col).Text)
                        Dim pixels2 As Integer = ReslnResolve(item2.SubItems(Col).Text)
                        ReturnVal = pixels1.CompareTo(pixels2)

                    Case 5 ' 文件大小列（按数值大小排序）
                        Dim size1 As Double = FileSizeResolve(item1.SubItems(Col).Text)
                        Dim size2 As Double = FileSizeResolve(item2.SubItems(Col).Text)
                        ReturnVal = size1.CompareTo(size2)

                    Case 6 ' 创建日期（按日期时间排序）
                        Dim date1, date2 As DateTime
                        If DateTime.TryParseExact(item1.SubItems(Col).Text, "yyyy/MM/dd, HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, date1) AndAlso
                   DateTime.TryParseExact(item2.SubItems(Col).Text, "yyyy/MM/dd, HH:mm:ss", Nothing, Globalization.DateTimeStyles.None, date2) Then
                            ReturnVal = date1.CompareTo(date2)
                        Else
                            ReturnVal = 0 ' 解析失败，不排序
                        End If

                    Case Else ' 其他列（按字符串排序）
                        ReturnVal = String.Compare(item1.SubItems(Col).Text, item2.SubItems(Col).Text)
                End Select
            End If
            If Order = SortOrder.Descending Then ' 根据排序顺序调整结果
                ReturnVal *= -1
            End If
            Return ReturnVal
        End Function

        Private Function NatureSort(strA As String, strB As String) As Integer
            Dim regex As New System.Text.RegularExpressions.Regex("(\d+)|(\D+)")
            Dim matchesA = regex.Matches(strA)
            Dim matchesB = regex.Matches(strB)

            Dim i As Integer = 0
            While i < matchesA.Count AndAlso i < matchesB.Count
                Dim partA As String = matchesA(i).Value
                Dim partB As String = matchesB(i).Value

                Dim numA, numB As Integer
                If Integer.TryParse(partA, numA) AndAlso Integer.TryParse(partB, numB) Then
                    ' 数字部分 → 按数值比较
                    If numA <> numB Then
                        Return numA.CompareTo(numB)
                    End If
                Else
                    ' 非数字部分 → 按字符串比较
                    Dim cmp As Integer = String.Compare(partA, partB, StringComparison.CurrentCultureIgnoreCase)
                    If cmp <> 0 Then
                        Return cmp
                    End If
                End If
                i += 1
            End While

            ' 如果前面都一样 → 长度短的在前
            Return matchesA.Count.CompareTo(matchesB.Count)
        End Function

        ' 解析文件大小
        Private Function FileSizeResolve(sizeText As String) As Double
            Dim sizeValue As Double = 0
            If sizeText.EndsWith(" KB") Then
                Double.TryParse(sizeText.Replace(" KB", "").Trim(), sizeValue)
                sizeValue *= 1024 ' 转换为字节
            ElseIf sizeText.EndsWith(" MB") Then
                Double.TryParse(sizeText.Replace(" MB", "").Trim(), sizeValue)
                sizeValue *= 1024 * 1024 ' 转换为字节
            ElseIf sizeText.EndsWith(" GB") Then
                Double.TryParse(sizeText.Replace(" GB", "").Trim(), sizeValue)
                sizeValue *= 1024 * 1024 * 1024 ' 转换为字节
            End If
            Return sizeValue
        End Function

        ' 解析分辨率，返回像素总数（宽 × 高）
        Private Function ReslnResolve(resolutionText As String) As Integer
            Dim parts() As String = resolutionText.Split("×"c)
            If parts.Length = 2 Then
                Dim width, height As Integer
                If Integer.TryParse(parts(0).Trim(), width) AndAlso Integer.TryParse(parts(1).Trim(), height) Then
                    Return width * height ' 计算像素总数
                End If
            End If
            Return 0 ' 无法解析时返回 0
        End Function

    End Class

End Module