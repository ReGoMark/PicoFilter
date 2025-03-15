<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCutAndPaste = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sltLblLT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(12, 275)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(330, 196)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSave.Location = New System.Drawing.Point(276, 497)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(65, 26)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "保存"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCutAndPaste
        '
        Me.btnCutAndPaste.BackColor = System.Drawing.Color.White
        Me.btnCutAndPaste.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCutAndPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCutAndPaste.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnCutAndPaste.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCutAndPaste.Location = New System.Drawing.Point(205, 497)
        Me.btnCutAndPaste.Name = "btnCutAndPaste"
        Me.btnCutAndPaste.Size = New System.Drawing.Size(65, 26)
        Me.btnCutAndPaste.TabIndex = 7
        Me.btnCutAndPaste.Text = "贴合"
        Me.btnCutAndPaste.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(159, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(329, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(330, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'sltLblLT
        '
        Me.sltLblLT.AutoSize = True
        Me.sltLblLT.BackColor = System.Drawing.Color.Transparent
        Me.sltLblLT.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.sltLblLT.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.sltLblLT.Location = New System.Drawing.Point(13, 13)
        Me.sltLblLT.Name = "sltLblLT"
        Me.sltLblLT.Size = New System.Drawing.Size(97, 16)
        Me.sltLblLT.TabIndex = 43
        Me.sltLblLT.Text = "前景（裁切）"
        Me.sltLblLT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(245, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "后景（底板）"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label18.Location = New System.Drawing.Point(12, 256)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 16)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "导出预览"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label44.Location = New System.Drawing.Point(40, 499)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(159, 20)
        Me.Label44.TabIndex = 85
        Me.Label44.Text = "专栏文末二维码替换。"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form4
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(353, 535)
        Me.Controls.Add(Me.sltLblLT)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btnCutAndPaste)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PicoCode Alpha"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCutAndPaste As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents sltLblLT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label44 As Label
End Class
