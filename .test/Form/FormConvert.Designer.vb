<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConvert
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConvert))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnApplySelected = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ImageDock = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnPin = New System.Windows.Forms.CheckBox()
        Me.ImagePin = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TabAna = New Sunny.UI.UITabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.moreButton = New System.Windows.Forms.Button()
        Me.UiTextBox1 = New Sunny.UI.UITextBox()
        Me.mnsButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rbPNG = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.rbJPG = New System.Windows.Forms.RadioButton()
        Me.rbBMP = New System.Windows.Forms.RadioButton()
        Me.rbICO = New System.Windows.Forms.RadioButton()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.UiIntegerUpDown1 = New Sunny.UI.UIIntegerUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabAna.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.BtnPin)
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnApplySelected)
        Me.Panel3.Controls.Add(Me.Button10)
        Me.Panel3.Location = New System.Drawing.Point(-61, 492)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(487, 60)
        Me.Panel3.TabIndex = 100
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.CausesValidation = False
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReset.Location = New System.Drawing.Point(346, 13)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(65, 26)
        Me.btnReset.TabIndex = 26
        Me.btnReset.Text = "还原"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnApplySelected
        '
        Me.btnApplySelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplySelected.BackColor = System.Drawing.Color.White
        Me.btnApplySelected.CausesValidation = False
        Me.btnApplySelected.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnApplySelected.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.btnApplySelected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnApplySelected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnApplySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplySelected.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnApplySelected.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnApplySelected.Location = New System.Drawing.Point(275, 13)
        Me.btnApplySelected.Name = "btnApplySelected"
        Me.btnApplySelected.Size = New System.Drawing.Size(65, 26)
        Me.btnApplySelected.TabIndex = 25
        Me.btnApplySelected.Text = "预览"
        Me.btnApplySelected.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.CausesValidation = False
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(199, 13)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(70, 26)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "全选"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = False
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
        Me.CheckBox1.TabIndex = 60
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'ImageDock
        '
        Me.ImageDock.ImageStream = CType(resources.GetObject("ImageDock.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageDock.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageDock.Images.SetKeyName(0, "Dock.ico")
        Me.ImageDock.Images.SetKeyName(1, "Docked.ico")
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
        Me.BtnPin.TabIndex = 59
        Me.BtnPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnPin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPin.UseVisualStyleBackColor = False
        '
        'ImagePin
        '
        Me.ImagePin.ImageStream = CType(resources.GetObject("ImagePin.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImagePin.TransparentColor = System.Drawing.Color.Transparent
        Me.ImagePin.Images.SetKeyName(0, "pin.ico")
        Me.ImagePin.Images.SetKeyName(1, "Pinned.ico")
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 120)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(338, 357)
        Me.ListView1.TabIndex = 101
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "文件名"
        Me.ColumnHeader2.Width = 120
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "格式"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "转换"
        Me.ColumnHeader4.Width = 59
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.TabAna)
        Me.Panel5.Location = New System.Drawing.Point(-27, -13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(422, 127)
        Me.Panel5.TabIndex = 136
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Location = New System.Drawing.Point(198, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(202, 46)
        Me.Panel4.TabIndex = 135
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.CausesValidation = False
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.Location = New System.Drawing.Point(107, 21)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 25)
        Me.Button7.TabIndex = 126
        Me.Button7.Text = "转存"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.CausesValidation = False
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.Location = New System.Drawing.Point(31, 20)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(70, 26)
        Me.Button8.TabIndex = 127
        Me.Button8.Text = "覆盖"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'TabAna
        '
        Me.TabAna.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabAna.Controls.Add(Me.TabPage1)
        Me.TabAna.Controls.Add(Me.TabPage2)
        Me.TabAna.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabAna.FillColor = System.Drawing.Color.White
        Me.TabAna.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TabAna.ItemSize = New System.Drawing.Size(65, 26)
        Me.TabAna.Location = New System.Drawing.Point(37, 23)
        Me.TabAna.MainPage = ""
        Me.TabAna.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        Me.TabAna.Name = "TabAna"
        Me.TabAna.SelectedIndex = 0
        Me.TabAna.ShowTabDivider = False
        Me.TabAna.Size = New System.Drawing.Size(338, 95)
        Me.TabAna.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabAna.TabBackColor = System.Drawing.Color.White
        Me.TabAna.TabIndex = 134
        Me.TabAna.TabSelectedColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabAna.TabSelectedForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TabAna.TabSelectedHighColorSize = 0
        Me.TabAna.TabUnSelectedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabAna.TabUnSelectedForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TabAna.TipsFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.PictureBox7)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.btnLoad)
        Me.TabPage1.Controls.Add(Me.moreButton)
        Me.TabPage1.Controls.Add(Me.UiTextBox1)
        Me.TabPage1.Controls.Add(Me.mnsButton)
        Me.TabPage1.Location = New System.Drawing.Point(0, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(338, 69)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "开始"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(106, 40)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(17, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 132
        Me.PictureBox7.TabStop = False
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.CausesValidation = False
        Me.Button9.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(268, 40)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(70, 26)
        Me.Button9.TabIndex = 131
        Me.Button9.Text = "移除"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.White
        Me.btnLoad.CausesValidation = False
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLoad.FlatAppearance.BorderSize = 0
        Me.btnLoad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Location = New System.Drawing.Point(0, 40)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(100, 26)
        Me.btnLoad.TabIndex = 118
        Me.btnLoad.Text = "拖入/浏览"
        Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'moreButton
        '
        Me.moreButton.BackColor = System.Drawing.Color.Transparent
        Me.moreButton.CausesValidation = False
        Me.moreButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.moreButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.moreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.moreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moreButton.Font = New System.Drawing.Font("等线", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.moreButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.moreButton.Image = CType(resources.GetObject("moreButton.Image"), System.Drawing.Image)
        Me.moreButton.Location = New System.Drawing.Point(129, 40)
        Me.moreButton.Name = "moreButton"
        Me.moreButton.Size = New System.Drawing.Size(26, 26)
        Me.moreButton.TabIndex = 77
        Me.moreButton.UseVisualStyleBackColor = False
        '
        'UiTextBox1
        '
        Me.UiTextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UiTextBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.UiTextBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiTextBox1.Location = New System.Drawing.Point(0, 8)
        Me.UiTextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiTextBox1.MinimumSize = New System.Drawing.Size(1, 16)
        Me.UiTextBox1.Name = "UiTextBox1"
        Me.UiTextBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.UiTextBox1.Radius = 0
        Me.UiTextBox1.RectColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UiTextBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.UiTextBox1.ShowText = False
        Me.UiTextBox1.Size = New System.Drawing.Size(338, 26)
        Me.UiTextBox1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiTextBox1.TabIndex = 62
        Me.UiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.UiTextBox1.Watermark = "显示当前路径"
        Me.UiTextBox1.WatermarkActiveColor = System.Drawing.Color.LightGray
        Me.UiTextBox1.WatermarkColor = System.Drawing.Color.DarkGray
        '
        'mnsButton
        '
        Me.mnsButton.BackColor = System.Drawing.Color.Transparent
        Me.mnsButton.CausesValidation = False
        Me.mnsButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.mnsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.mnsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mnsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.mnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mnsButton.Font = New System.Drawing.Font("等线", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.mnsButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.mnsButton.Image = CType(resources.GetObject("mnsButton.Image"), System.Drawing.Image)
        Me.mnsButton.Location = New System.Drawing.Point(161, 40)
        Me.mnsButton.Name = "mnsButton"
        Me.mnsButton.Size = New System.Drawing.Size(26, 26)
        Me.mnsButton.TabIndex = 78
        Me.mnsButton.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.colorButton)
        Me.TabPage2.Controls.Add(Me.UiIntegerUpDown1)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(0, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(338, 69)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "转换"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(183, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 26)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "%"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(218, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 135
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(0, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 26)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "目标格式"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.rbPNG)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.rbJPG)
        Me.Panel2.Controls.Add(Me.rbBMP)
        Me.Panel2.Controls.Add(Me.rbICO)
        Me.Panel2.Location = New System.Drawing.Point(81, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 26)
        Me.Panel2.TabIndex = 133
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.RadioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton2.Location = New System.Drawing.Point(215, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(42, 26)
        Me.RadioButton2.TabIndex = 136
        Me.RadioButton2.Text = "WBP"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'rbPNG
        '
        Me.rbPNG.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPNG.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbPNG.Checked = True
        Me.rbPNG.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbPNG.FlatAppearance.BorderSize = 0
        Me.rbPNG.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rbPNG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbPNG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbPNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbPNG.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbPNG.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbPNG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbPNG.Location = New System.Drawing.Point(129, 0)
        Me.rbPNG.Name = "rbPNG"
        Me.rbPNG.Size = New System.Drawing.Size(42, 26)
        Me.rbPNG.TabIndex = 6
        Me.rbPNG.TabStop = True
        Me.rbPNG.Text = "PNG"
        Me.rbPNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPNG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbPNG.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton1.Location = New System.Drawing.Point(172, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(42, 26)
        Me.RadioButton1.TabIndex = 135
        Me.RadioButton1.Text = "TIF"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'rbJPG
        '
        Me.rbJPG.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbJPG.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbJPG.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbJPG.FlatAppearance.BorderSize = 0
        Me.rbJPG.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rbJPG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbJPG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbJPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbJPG.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbJPG.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbJPG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbJPG.Location = New System.Drawing.Point(86, 0)
        Me.rbJPG.Name = "rbJPG"
        Me.rbJPG.Size = New System.Drawing.Size(42, 26)
        Me.rbJPG.TabIndex = 7
        Me.rbJPG.Text = "JPG"
        Me.rbJPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbJPG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbJPG.UseVisualStyleBackColor = False
        '
        'rbBMP
        '
        Me.rbBMP.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbBMP.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbBMP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbBMP.FlatAppearance.BorderSize = 0
        Me.rbBMP.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rbBMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbBMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbBMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbBMP.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbBMP.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbBMP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbBMP.Location = New System.Drawing.Point(0, 0)
        Me.rbBMP.Name = "rbBMP"
        Me.rbBMP.Size = New System.Drawing.Size(42, 26)
        Me.rbBMP.TabIndex = 8
        Me.rbBMP.Text = "BMP"
        Me.rbBMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbBMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbBMP.UseVisualStyleBackColor = False
        '
        'rbICO
        '
        Me.rbICO.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbICO.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rbICO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbICO.FlatAppearance.BorderSize = 0
        Me.rbICO.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.rbICO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbICO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbICO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbICO.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbICO.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbICO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbICO.Location = New System.Drawing.Point(43, 0)
        Me.rbICO.Name = "rbICO"
        Me.rbICO.Size = New System.Drawing.Size(42, 26)
        Me.rbICO.TabIndex = 9
        Me.rbICO.Text = "ICO"
        Me.rbICO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbICO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rbICO.UseVisualStyleBackColor = False
        '
        'colorButton
        '
        Me.colorButton.BackColor = System.Drawing.Color.Transparent
        Me.colorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.colorButton.CausesValidation = False
        Me.colorButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.colorButton.FlatAppearance.BorderSize = 0
        Me.colorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.colorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.colorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colorButton.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.colorButton.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.colorButton.Image = CType(resources.GetObject("colorButton.Image"), System.Drawing.Image)
        Me.colorButton.Location = New System.Drawing.Point(312, 40)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(26, 26)
        Me.colorButton.TabIndex = 10
        Me.colorButton.UseVisualStyleBackColor = False
        '
        'UiIntegerUpDown1
        '
        Me.UiIntegerUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UiIntegerUpDown1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.UiIntegerUpDown1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiIntegerUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.Location = New System.Drawing.Point(81, 40)
        Me.UiIntegerUpDown1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiIntegerUpDown1.Maximum = 100.0R
        Me.UiIntegerUpDown1.Minimum = 5.0R
        Me.UiIntegerUpDown1.MinimumSize = New System.Drawing.Size(1, 16)
        Me.UiIntegerUpDown1.Name = "UiIntegerUpDown1"
        Me.UiIntegerUpDown1.Padding = New System.Windows.Forms.Padding(5)
        Me.UiIntegerUpDown1.Radius = 0
        Me.UiIntegerUpDown1.RectColor = System.Drawing.Color.WhiteSmoke
        Me.UiIntegerUpDown1.RectHoverColor = System.Drawing.Color.Gainsboro
        Me.UiIntegerUpDown1.RectPressColor = System.Drawing.Color.LemonChiffon
        Me.UiIntegerUpDown1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.UiIntegerUpDown1.ShowText = False
        Me.UiIntegerUpDown1.Size = New System.Drawing.Size(95, 26)
        Me.UiIntegerUpDown1.Step = 5
        Me.UiIntegerUpDown1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.SymbolHoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.SymbolPressColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.SymbolSize = 10
        Me.UiIntegerUpDown1.TabIndex = 22
        Me.UiIntegerUpDown1.Text = "100"
        Me.UiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.UiIntegerUpDown1.Value = 100
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(241, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "填充色"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 26)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "目标质量"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormConvert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 543)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormConvert"
        Me.Text = "FormConvert"
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TabAna.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ImageDock As ImageList
    Friend WithEvents BtnPin As CheckBox
    Friend WithEvents ImagePin As ImageList
    Friend WithEvents btnReset As Button
    Friend WithEvents btnApplySelected As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents TabAna As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents moreButton As Button
    Friend WithEvents UiTextBox1 As Sunny.UI.UITextBox
    Friend WithEvents mnsButton As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbPNG As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents rbJPG As RadioButton
    Friend WithEvents rbBMP As RadioButton
    Friend WithEvents rbICO As RadioButton
    Friend WithEvents colorButton As Button
    Friend WithEvents UiIntegerUpDown1 As Sunny.UI.UIIntegerUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
