<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSplit
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSplit))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.UiTabControl1 = New Sunny.UI.UITabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ImageDock = New System.Windows.Forms.ImageList(Me.components)
        Me.ImagePin = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ButtonCopySelected = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnPin = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiTabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.PictureBox8)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(-2, -9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(374, 61)
        Me.Panel2.TabIndex = 129
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(113, 19)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(17, 26)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 121
        Me.PictureBox8.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(280, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 26)
        Me.Button2.TabIndex = 124
        Me.Button2.Text = "星标"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(136, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 26)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "发送到"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.CausesValidation = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(204, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 26)
        Me.Button3.TabIndex = 125
        Me.Button3.Text = "查找"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.CausesValidation = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(12, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 26)
        Me.Button5.TabIndex = 126
        Me.Button5.Text = "保存到..."
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'UiTabControl1
        '
        Me.UiTabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTabControl1.Controls.Add(Me.TabPage1)
        Me.UiTabControl1.Controls.Add(Me.TabPage2)
        Me.UiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.UiTabControl1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UiTabControl1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiTabControl1.ItemSize = New System.Drawing.Size(90, 26)
        Me.UiTabControl1.Location = New System.Drawing.Point(12, 63)
        Me.UiTabControl1.MainPage = ""
        Me.UiTabControl1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 12)
        Me.UiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        Me.UiTabControl1.Name = "UiTabControl1"
        Me.UiTabControl1.SelectedIndex = 0
        Me.UiTabControl1.ShowTabDivider = False
        Me.UiTabControl1.Size = New System.Drawing.Size(338, 417)
        Me.UiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.UiTabControl1.TabBackColor = System.Drawing.Color.White
        Me.UiTabControl1.TabIndex = 130
        Me.UiTabControl1.TabSelectedColor = System.Drawing.Color.Lavender
        Me.UiTabControl1.TabSelectedForeColor = System.Drawing.Color.DarkSlateBlue
        Me.UiTabControl1.TabSelectedHighColorSize = 0
        Me.UiTabControl1.TabUnSelectedColor = System.Drawing.Color.White
        Me.UiTabControl1.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiTabControl1.TipsFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(0, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(338, 391)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "词典分词"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(0, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(338, 391)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "自由复制"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(336, 389)
        Me.TextBox1.TabIndex = 3
        '
        'ImageDock
        '
        Me.ImageDock.ImageStream = CType(resources.GetObject("ImageDock.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageDock.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageDock.Images.SetKeyName(0, "Dock.ico")
        Me.ImageDock.Images.SetKeyName(1, "Docked.ico")
        '
        'ImagePin
        '
        Me.ImagePin.ImageStream = CType(resources.GetObject("ImagePin.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImagePin.TransparentColor = System.Drawing.Color.Transparent
        Me.ImagePin.Images.SetKeyName(0, "pin.ico")
        Me.ImagePin.Images.SetKeyName(1, "Pinned.ico")
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.ButtonCopySelected)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.BtnPin)
        Me.Panel1.Location = New System.Drawing.Point(-61, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 60)
        Me.Panel1.TabIndex = 131
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.CausesValidation = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(235, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 26)
        Me.Button4.TabIndex = 99
        Me.Button4.Text = "全选"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ButtonCopySelected
        '
        Me.ButtonCopySelected.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCopySelected.BackColor = System.Drawing.Color.White
        Me.ButtonCopySelected.CausesValidation = False
        Me.ButtonCopySelected.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonCopySelected.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.ButtonCopySelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.ButtonCopySelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ButtonCopySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCopySelected.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ButtonCopySelected.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ButtonCopySelected.Image = CType(resources.GetObject("ButtonCopySelected.Image"), System.Drawing.Image)
        Me.ButtonCopySelected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCopySelected.Location = New System.Drawing.Point(311, 13)
        Me.ButtonCopySelected.Name = "ButtonCopySelected"
        Me.ButtonCopySelected.Size = New System.Drawing.Size(100, 26)
        Me.ButtonCopySelected.TabIndex = 98
        Me.ButtonCopySelected.Text = "复制文本"
        Me.ButtonCopySelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCopySelected.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.CausesValidation = False
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox1.FlatAppearance.BorderSize = 0
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CheckBox1.ImageIndex = 0
        Me.CheckBox1.ImageList = Me.ImageDock
        Me.CheckBox1.Location = New System.Drawing.Point(105, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(26, 26)
        Me.CheckBox1.TabIndex = 58
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'BtnPin
        '
        Me.BtnPin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPin.Appearance = System.Windows.Forms.Appearance.Button
        Me.BtnPin.BackColor = System.Drawing.Color.Transparent
        Me.BtnPin.CausesValidation = False
        Me.BtnPin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPin.FlatAppearance.BorderSize = 0
        Me.BtnPin.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro
        Me.BtnPin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.BtnPin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BtnPin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPin.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnPin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.BtnPin.ImageIndex = 0
        Me.BtnPin.ImageList = Me.ImagePin
        Me.BtnPin.Location = New System.Drawing.Point(73, 13)
        Me.BtnPin.Name = "BtnPin"
        Me.BtnPin.Size = New System.Drawing.Size(26, 26)
        Me.BtnPin.TabIndex = 57
        Me.BtnPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPin.UseVisualStyleBackColor = False
        '
        'FormSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UiTabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormSplit"
        Me.Text = "FormSplit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiTabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents UiTabControl1 As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ImageDock As ImageList
    Friend WithEvents ImagePin As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents ButtonCopySelected As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnPin As CheckBox
End Class
