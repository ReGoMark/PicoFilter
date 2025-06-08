Public Class Form4
    ' 存储裁剪后的二维码图像
    Private qrCode As Bitmap = Nothing

    ' 在窗体加载时确保图片框的 AllowDrop 设置为 True
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.AllowDrop = True
        PictureBox2.AllowDrop = True
        PictureBox3.AllowDrop = False ' 预览框禁止拖入

        ' 设置PictureBox2的默认图像
        PictureBox2.Image = My.Resources.qr_normal ' 默认图像资源（根据需要调整路径或默认图像）
    End Sub

    ' 图片1加载后处理裁剪
    Private Sub PictureBox1_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox1.DragEnter
        ' 确保鼠标指针在拖放时为可接受的状态
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy ' 允许复制操作
        Else
            e.Effect = DragDropEffects.None ' 禁止非文件拖入
        End If
    End Sub

    ' 图片1拖放事件
    Private Sub PictureBox1_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox1.DragDrop
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length > 0 Then
            ' 加载并显示图片1
            PictureBox1.Image = New Bitmap(files(0))
        End If
    End Sub

    ' 图片2加载后处理拖放
    Private Sub PictureBox2_DragEnter(sender As Object, e As DragEventArgs) Handles PictureBox2.DragEnter
        ' 确保鼠标指针在拖放时为可接受的状态
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy ' 允许复制操作
        Else
            e.Effect = DragDropEffects.None ' 禁止非文件拖入
        End If
    End Sub

    ' 图片2拖放事件
    Private Sub PictureBox2_DragDrop(sender As Object, e As DragEventArgs) Handles PictureBox2.DragDrop
        Dim files As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        If files.Length > 0 Then
            ' 加载并显示图片2
            PictureBox2.Image = New Bitmap(files(0))
        End If
    End Sub

    ' 开始裁切并合并
    Private Sub btnCutAndPaste_Click(sender As Object, e As EventArgs) Handles btnCutAndPaste.Click
        ' 获取图片1和图片2
        Dim image1 As Bitmap = CType(PictureBox1.Image, Bitmap)
        Dim image2 As Bitmap = CType(PictureBox2.Image, Bitmap)

        If image1 Is Nothing Then
            MessageBox.Show("请先加载图片1")
            Return
        End If

        If image2 Is Nothing Then
            MessageBox.Show("请先加载图片2")
            Return
        End If

        ' 设置裁剪区域：图片1的二维码区域（起始位置：182,262，结束位置：540,620）
        ' 确保裁切区域是正方形：宽度和高度相等
        Dim width As Integer = 540 - 182
        Dim height As Integer = 620 - 262
        Dim size As Integer = Math.Min(width, height) ' 获取裁剪区域的最小边长

        ' 重新调整裁切区域为正方形
        Dim qrLocation As New Rectangle(182, 262, size, size)

        ' 裁剪图片1中的二维码部分
        qrCode = image1.Clone(qrLocation, image1.PixelFormat)

        ' 设置目标粘贴区域：在图片2上粘贴的位置和大小（515x515）
        Dim pasteArea As New Rectangle(157, 201, 515, 515)

        ' 创建一个新的图像来显示合并效果
        Dim mergedImage As New Bitmap(image2.Width, image2.Height)

        ' 使用Graphics绘制合并效果
        Using g As Graphics = Graphics.FromImage(mergedImage)
            g.DrawImage(image2, 0, 0)  ' 绘制图片2
            ' 拉伸裁剪的二维码到目标区域 (515x515)
            g.DrawImage(qrCode, pasteArea)
        End Using

        ' 在PictureBox3上预览合并效果
        PictureBox3.Image = mergedImage
    End Sub

    ' 保存合并后的图片
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If PictureBox3.Image Is Nothing Then
            MessageBox.Show("没有合并的图片")
            Return
        End If

        ' 打开保存对话框
        Using saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PNG Files (*.png)|*.png"
            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' 保存合并后的图片
                PictureBox3.Image.Save(saveDialog.FileName, Imaging.ImageFormat.Png)
                MessageBox.Show("图片已保存")
            End If
        End Using
    End Sub
End Class
