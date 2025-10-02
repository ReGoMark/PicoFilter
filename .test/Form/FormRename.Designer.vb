<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRename
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRename))
        Me.ImageDock = New System.Windows.Forms.ImageList(Me.components)
        Me.ImagePin = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnApplySelected = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnPin = New System.Windows.Forms.CheckBox()
        Me.btnApplyAll = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabAna = New Sunny.UI.UITabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.moreButton = New System.Windows.Forms.Button()
        Me.TbxOpen = New Sunny.UI.UITextBox()
        Me.mnsButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CbxFormat = New Sunny.UI.UIComboBox()
        Me.UiIntegerUpDown2 = New Sunny.UI.UIIntegerUpDown()
        Me.UiIntegerUpDown1 = New Sunny.UI.UIIntegerUpDown()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListViewLoad = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabAna.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.btnReset)
        Me.Panel2.Controls.Add(Me.btnApplySelected)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.BtnPin)
        Me.Panel2.Controls.Add(Me.btnApplyAll)
        Me.Panel2.Location = New System.Drawing.Point(-61, 492)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 60)
        Me.Panel2.TabIndex = 121
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
        Me.btnReset.TabIndex = 60
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
        Me.btnApplySelected.TabIndex = 59
        Me.btnApplySelected.Text = "预览"
        Me.btnApplySelected.UseVisualStyleBackColor = False
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
        'btnApplyAll
        '
        Me.btnApplyAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyAll.BackColor = System.Drawing.Color.Transparent
        Me.btnApplyAll.CausesValidation = False
        Me.btnApplyAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnApplyAll.FlatAppearance.BorderSize = 0
        Me.btnApplyAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.btnApplyAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnApplyAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnApplyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyAll.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnApplyAll.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnApplyAll.Image = CType(resources.GetObject("btnApplyAll.Image"), System.Drawing.Image)
        Me.btnApplyAll.Location = New System.Drawing.Point(199, 13)
        Me.btnApplyAll.Name = "btnApplyAll"
        Me.btnApplyAll.Size = New System.Drawing.Size(70, 26)
        Me.btnApplyAll.TabIndex = 22
        Me.btnApplyAll.Text = "全选"
        Me.btnApplyAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApplyAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApplyAll.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TabAna)
        Me.Panel1.Location = New System.Drawing.Point(-27, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 127)
        Me.Panel1.TabIndex = 122
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Location = New System.Drawing.Point(175, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(225, 46)
        Me.Panel3.TabIndex = 135
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Button2.Location = New System.Drawing.Point(130, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 25)
        Me.Button2.TabIndex = 126
        Me.Button2.Text = "转存"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.CausesValidation = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(54, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 26)
        Me.Button1.TabIndex = 127
        Me.Button1.Text = "覆盖"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.TabPage1.Controls.Add(Me.BtnDel)
        Me.TabPage1.Controls.Add(Me.btnLoad)
        Me.TabPage1.Controls.Add(Me.moreButton)
        Me.TabPage1.Controls.Add(Me.TbxOpen)
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
        Me.PictureBox7.Location = New System.Drawing.Point(141, 40)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(17, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 132
        Me.PictureBox7.TabStop = False
        '
        'BtnDel
        '
        Me.BtnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDel.BackColor = System.Drawing.Color.White
        Me.BtnDel.CausesValidation = False
        Me.BtnDel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDel.FlatAppearance.BorderSize = 0
        Me.BtnDel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.BtnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnDel.Image = CType(resources.GetObject("BtnDel.Image"), System.Drawing.Image)
        Me.BtnDel.Location = New System.Drawing.Point(268, 40)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(70, 26)
        Me.BtnDel.TabIndex = 131
        Me.BtnDel.Text = "移除"
        Me.BtnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDel.UseVisualStyleBackColor = False
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
        Me.btnLoad.Size = New System.Drawing.Size(135, 26)
        Me.btnLoad.TabIndex = 118
        Me.btnLoad.Text = "拉取/拖入/浏览"
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
        Me.moreButton.Location = New System.Drawing.Point(164, 40)
        Me.moreButton.Name = "moreButton"
        Me.moreButton.Size = New System.Drawing.Size(26, 26)
        Me.moreButton.TabIndex = 77
        Me.moreButton.UseVisualStyleBackColor = False
        '
        'TbxOpen
        '
        Me.TbxOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbxOpen.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbxOpen.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TbxOpen.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TbxOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TbxOpen.Location = New System.Drawing.Point(0, 8)
        Me.TbxOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxOpen.MinimumSize = New System.Drawing.Size(1, 16)
        Me.TbxOpen.Name = "TbxOpen"
        Me.TbxOpen.Padding = New System.Windows.Forms.Padding(5)
        Me.TbxOpen.Radius = 0
        Me.TbxOpen.RectColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.TbxOpen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.TbxOpen.ShowText = False
        Me.TbxOpen.Size = New System.Drawing.Size(338, 26)
        Me.TbxOpen.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TbxOpen.TabIndex = 62
        Me.TbxOpen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TbxOpen.Watermark = "显示当前路径"
        Me.TbxOpen.WatermarkActiveColor = System.Drawing.Color.LightGray
        Me.TbxOpen.WatermarkColor = System.Drawing.Color.DarkGray
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
        Me.mnsButton.Location = New System.Drawing.Point(196, 40)
        Me.mnsButton.Name = "mnsButton"
        Me.mnsButton.Size = New System.Drawing.Size(26, 26)
        Me.mnsButton.TabIndex = 78
        Me.mnsButton.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.CbxFormat)
        Me.TabPage2.Controls.Add(Me.UiIntegerUpDown2)
        Me.TabPage2.Controls.Add(Me.UiIntegerUpDown1)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Location = New System.Drawing.Point(0, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(338, 69)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "命名"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.CausesValidation = False
        Me.Button10.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Button10.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button10.Image = CType(resources.GetObject("Button10.Image"), System.Drawing.Image)
        Me.Button10.Location = New System.Drawing.Point(0, 8)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(26, 26)
        Me.Button10.TabIndex = 134
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 26)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "序号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.CausesValidation = False
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Button7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(32, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(26, 26)
        Me.Button7.TabIndex = 130
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'CbxFormat
        '
        Me.CbxFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbxFormat.DataSource = Nothing
        Me.CbxFormat.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        Me.CbxFormat.FillColor = System.Drawing.Color.WhiteSmoke
        Me.CbxFormat.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CbxFormat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CbxFormat.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CbxFormat.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxFormat.ItemRectColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxFormat.Items.AddRange(New Object() {"1024×1024", "128×128", "16×16", "24×24", "256×256", "32×32", "512×512", "64×64"})
        Me.CbxFormat.ItemSelectBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxFormat.ItemSelectForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CbxFormat.Location = New System.Drawing.Point(33, 8)
        Me.CbxFormat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxFormat.MinimumSize = New System.Drawing.Size(63, 0)
        Me.CbxFormat.Name = "CbxFormat"
        Me.CbxFormat.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.CbxFormat.Radius = 0
        Me.CbxFormat.RectColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CbxFormat.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.CbxFormat.Size = New System.Drawing.Size(305, 26)
        Me.CbxFormat.Sorted = True
        Me.CbxFormat.SymbolSize = 20
        Me.CbxFormat.TabIndex = 129
        Me.CbxFormat.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.CbxFormat.Watermark = "设置命名格式"
        Me.CbxFormat.WatermarkActiveColor = System.Drawing.Color.LightGray
        Me.CbxFormat.WatermarkColor = System.Drawing.Color.DarkGray
        '
        'UiIntegerUpDown2
        '
        Me.UiIntegerUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiIntegerUpDown2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UiIntegerUpDown2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.UiIntegerUpDown2.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiIntegerUpDown2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown2.Location = New System.Drawing.Point(129, 40)
        Me.UiIntegerUpDown2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiIntegerUpDown2.Maximum = 100.0R
        Me.UiIntegerUpDown2.Minimum = 5.0R
        Me.UiIntegerUpDown2.MinimumSize = New System.Drawing.Size(1, 16)
        Me.UiIntegerUpDown2.Name = "UiIntegerUpDown2"
        Me.UiIntegerUpDown2.Padding = New System.Windows.Forms.Padding(5)
        Me.UiIntegerUpDown2.Radius = 0
        Me.UiIntegerUpDown2.RectColor = System.Drawing.Color.WhiteSmoke
        Me.UiIntegerUpDown2.RectHoverColor = System.Drawing.Color.Gainsboro
        Me.UiIntegerUpDown2.RectPressColor = System.Drawing.Color.LemonChiffon
        Me.UiIntegerUpDown2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.UiIntegerUpDown2.ShowText = False
        Me.UiIntegerUpDown2.Size = New System.Drawing.Size(100, 26)
        Me.UiIntegerUpDown2.Step = 5
        Me.UiIntegerUpDown2.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown2.SymbolHoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown2.SymbolPressColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown2.SymbolSize = 10
        Me.UiIntegerUpDown2.TabIndex = 131
        Me.UiIntegerUpDown2.Text = "1"
        Me.UiIntegerUpDown2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.UiIntegerUpDown2.Value = 1
        '
        'UiIntegerUpDown1
        '
        Me.UiIntegerUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UiIntegerUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UiIntegerUpDown1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.UiIntegerUpDown1.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiIntegerUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.Location = New System.Drawing.Point(237, 40)
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
        Me.UiIntegerUpDown1.Size = New System.Drawing.Size(100, 26)
        Me.UiIntegerUpDown1.Step = 5
        Me.UiIntegerUpDown1.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.SymbolHoverColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.SymbolPressColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiIntegerUpDown1.SymbolSize = 10
        Me.UiIntegerUpDown1.TabIndex = 130
        Me.UiIntegerUpDown1.Text = "5"
        Me.UiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.UiIntegerUpDown1.Value = 5
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.CausesValidation = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(0, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 26)
        Me.Button5.TabIndex = 122
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ListViewLoad
        '
        Me.ListViewLoad.AllowColumnReorder = True
        Me.ListViewLoad.AllowDrop = True
        Me.ListViewLoad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListViewLoad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewLoad.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListViewLoad.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
        Me.ListViewLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ListViewLoad.FullRowSelect = True
        Me.ListViewLoad.HideSelection = False
        Me.ListViewLoad.Location = New System.Drawing.Point(12, 123)
        Me.ListViewLoad.Margin = New System.Windows.Forms.Padding(3, 6, 3, 12)
        Me.ListViewLoad.Name = "ListViewLoad"
        Me.ListViewLoad.Size = New System.Drawing.Size(338, 357)
        Me.ListViewLoad.TabIndex = 123
        Me.ListViewLoad.UseCompatibleStateImageBehavior = False
        Me.ListViewLoad.View = System.Windows.Forms.View.Details
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
        '
        'FormRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 543)
        Me.Controls.Add(Me.ListViewLoad)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FormRename"
        Me.Text = "FormRename"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabAna.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageDock As ImageList
    Friend WithEvents ImagePin As ImageList
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReset As Button
    Friend WithEvents btnApplySelected As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnPin As CheckBox
    Friend WithEvents btnApplyAll As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabAna As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents BtnDel As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents moreButton As Button
    Friend WithEvents TbxOpen As Sunny.UI.UITextBox
    Friend WithEvents mnsButton As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button10 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents CbxFormat As Sunny.UI.UIComboBox
    Friend WithEvents UiIntegerUpDown2 As Sunny.UI.UIIntegerUpDown
    Friend WithEvents UiIntegerUpDown1 As Sunny.UI.UIIntegerUpDown
    Friend WithEvents Button5 As Button
    Friend WithEvents ListViewLoad As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
