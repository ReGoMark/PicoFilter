Imports System.IO
Imports System.Security.Cryptography
Imports SkiaSharp

Module FormatString

    Public Function FormatFileSize(bytes As Long) As String
        If bytes < 1024 Then
            Return bytes & " B"
        ElseIf bytes < 1024 * 1024 Then
            Return (bytes / 1024).ToString("F2") & " KB"
        ElseIf bytes < 1024 * 1024 * 1024 Then
            Return (bytes / 1024 / 1024).ToString("F2") & " MB"
        Else
            Return (bytes / 1024 / 1024 / 1024).ToString("F2") & " GB"
        End If
    End Function

    Public Function GetResln(filePath As String) As String
        Try
            Dim ext As String = Path.GetExtension(filePath).ToLower()

            ' WebP 用 SkiaSharp 解析
            If ext = ".webp" Then
                Using input As FileStream = File.OpenRead(filePath)
                    Using codec As SKCodec = SKCodec.Create(input)
                        If codec IsNot Nothing Then
                            Dim info As SKImageInfo = codec.Info
                            Return $"{info.Width}×{info.Height}"
                        Else
                            Return "0×0"
                        End If
                    End Using
                End Using
            Else
                ' 其他常规格式走 System.Drawing
                Using fs As New FileStream(filePath, FileMode.Open, FileAccess.Read)
                    Using img As Image = Image.FromStream(fs, False, False)
                        Return $"{img.Width}×{img.Height}"
                    End Using
                End Using
            End If
        Catch
            Return "0×0"
        End Try
    End Function

    Public Function GetFileHash(filePath As String) As String
        Using md5 As MD5 = MD5.Create()
            Using stream As FileStream = File.OpenRead(filePath)
                Dim hashBytes = md5.ComputeHash(stream)
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant()
            End Using
        End Using
    End Function

    Public Function FormatFileSizeInKB(bytes As Long) As String
        Return (bytes / 1024).ToString("F2") & " KB"
    End Function

    Public Function FormatLoadTime(time As Long) As String
        If time < 1000 Then
            Return time & " ms"
        Else
            Return time / 1000 & " s"
        End If
    End Function

    Public Function FormatRsltCount(count As Integer) As String
        If count < 100 Then
            Return count.ToString()
        ElseIf count >= 100 And count < 200 Then
            Return "H"
        ElseIf count >= 200 And count < 300 Then
            Return "H2"
        ElseIf count >= 300 And count < 400 Then
            Return "H3"
        ElseIf count >= 400 And count < 500 Then
            Return "H4"
        ElseIf count >= 500 And count < 600 Then
            Return "H5"
        ElseIf count >= 600 And count < 700 Then
            Return "H6"
        ElseIf count >= 700 And count < 800 Then
            Return "H7"
        ElseIf count >= 800 And count < 900 Then
            Return "H8"
        ElseIf count >= 900 And count < 100 Then
            Return "H9"
        ElseIf count >= 1000 Then
            Return "K"
        Else
            Return "X"
        End If
    End Function

End Module