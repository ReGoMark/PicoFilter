<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.ListViewPre = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxStart = New System.Windows.Forms.NumericUpDown()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.xlsxButton = New System.Windows.Forms.Button()
        Me.topButton = New System.Windows.Forms.CheckBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.absbButton = New System.Windows.Forms.CheckBox()
        Me.bksbutton = New System.Windows.Forms.Button()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.moreButton = New System.Windows.Forms.Button()
        Me.mnsButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.Panel1.SuspendLayout()
        CType(Me.TextBoxStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListViewPre
        '
        Me.ListViewPre.AllowColumnReorder = True
        Me.ListViewPre.AllowDrop = True
        Me.ListViewPre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewPre.BackColor = System.Drawing.Color.White
        Me.ListViewPre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListViewPre.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListViewPre.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
        Me.ListViewPre.ForeColor = System.Drawing.Color.Black
        Me.ListViewPre.FullRowSelect = True
        Me.ListViewPre.HideSelection = False
        Me.ListViewPre.Location = New System.Drawing.Point(36, 102)
        Me.ListViewPre.Name = "ListViewPre"
        Me.ListViewPre.Size = New System.Drawing.Size(329, 354)
        Me.ListViewPre.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.ListViewPre, "拖入文件夹或拉取数据；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "双击项预览。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ListViewPre.UseCompatibleStateImageBehavior = False
        Me.ListViewPre.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "#"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "文件名"
        Me.ColumnHeader2.Width = 240
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyButton.BackColor = System.Drawing.Color.White
        Me.ApplyButton.CausesValidation = False
        Me.ApplyButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.ApplyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.ApplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.ApplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ApplyButton.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ApplyButton.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ApplyButton.Image = CType(resources.GetObject("ApplyButton.Image"), System.Drawing.Image)
        Me.ApplyButton.Location = New System.Drawing.Point(127, 497)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(72, 26)
        Me.ApplyButton.TabIndex = 57
        Me.ApplyButton.Text = "全部"
        Me.ApplyButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ApplyButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.ApplyButton, "全部重命名预览。")
        Me.ApplyButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.CausesValidation = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Location = New System.Drawing.Point(303, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 26)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "覆盖"
        Me.ToolTip1.SetToolTip(Me.Button1, "覆盖原始文件名。")
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Location = New System.Drawing.Point(293, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 26)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "另存为"
        Me.ToolTip1.SetToolTip(Me.Button2, "保存重命名文件的副本。")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.CausesValidation = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.Location = New System.Drawing.Point(276, 497)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 26)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "取消"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.TextBoxStart)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 436)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 36)
        Me.Panel1.TabIndex = 60
        '
        'TextBoxStart
        '
        Me.TextBoxStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxStart.BackColor = System.Drawing.Color.GhostWhite
        Me.TextBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxStart.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.TextBoxStart.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TextBoxStart.Location = New System.Drawing.Point(194, 7)
        Me.TextBoxStart.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.TextBoxStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TextBoxStart.Name = "TextBoxStart"
        Me.TextBoxStart.Size = New System.Drawing.Size(65, 23)
        Me.TextBoxStart.TabIndex = 89
        Me.TextBoxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.TextBoxStart, "设置序号起点，最大支持5位整数。")
        Me.TextBoxStart.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.CausesValidation = False
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(299, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(26, 26)
        Me.Button6.TabIndex = 87
        Me.ToolTip1.SetToolTip(Me.Button6, "序号和日期命名")
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.CausesValidation = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(267, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(26, 26)
        Me.Button5.TabIndex = 86
        Me.ToolTip1.SetToolTip(Me.Button5, "序号命名")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"(无)", "{index}_{date}", "{0index}_{0date}", "{index}_{date}_{name}", "{0index}_{0date}_{name}", "{date}_{index}", "{0date}_{0index}", "{date}_{index}_{name}", "{0date}_{0index}_{name}"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 24)
        Me.ComboBox1.TabIndex = 88
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(146, 297)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 26)
        Me.Panel2.TabIndex = 78
        Me.Panel2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(211, 17)
        Me.TextBox1.TabIndex = 50
        '
        'xlsxButton
        '
        Me.xlsxButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.xlsxButton.BackColor = System.Drawing.Color.White
        Me.xlsxButton.CausesValidation = False
        Me.xlsxButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.xlsxButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.xlsxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlsxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.xlsxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xlsxButton.Font = New System.Drawing.Font("方正黑体_GBK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.xlsxButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.xlsxButton.Image = CType(resources.GetObject("xlsxButton.Image"), System.Drawing.Image)
        Me.xlsxButton.Location = New System.Drawing.Point(-2170, 11)
        Me.xlsxButton.Name = "xlsxButton"
        Me.xlsxButton.Size = New System.Drawing.Size(26, 26)
        Me.xlsxButton.TabIndex = 67
        Me.xlsxButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.xlsxButton.UseVisualStyleBackColor = False
        '
        'topButton
        '
        Me.topButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.topButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.topButton.BackColor = System.Drawing.Color.GhostWhite
        Me.topButton.CausesValidation = False
        Me.topButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.topButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.topButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.topButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.topButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.topButton.Font = New System.Drawing.Font("方正黑体_GBK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.topButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.topButton.ImageIndex = 0
        Me.topButton.ImageList = Me.ImageList2
        Me.topButton.Location = New System.Drawing.Point(12, 497)
        Me.topButton.Name = "topButton"
        Me.topButton.Size = New System.Drawing.Size(26, 26)
        Me.topButton.TabIndex = 69
        Me.topButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.topButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.topButton, "置顶窗体")
        Me.topButton.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "top.ico")
        Me.ImageList2.Images.SetKeyName(1, "topped.ico")
        '
        'absbButton
        '
        Me.absbButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.absbButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.absbButton.BackColor = System.Drawing.Color.GhostWhite
        Me.absbButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.absbButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.absbButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.absbButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.absbButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.absbButton.Font = New System.Drawing.Font("方正黑体_GBK", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.absbButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.absbButton.Image = CType(resources.GetObject("absbButton.Image"), System.Drawing.Image)
        Me.absbButton.Location = New System.Drawing.Point(44, 497)
        Me.absbButton.Name = "absbButton"
        Me.absbButton.Size = New System.Drawing.Size(26, 26)
        Me.absbButton.TabIndex = 68
        Me.absbButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.absbButton, "吸附窗体（右）")
        Me.absbButton.UseVisualStyleBackColor = False
        '
        'bksbutton
        '
        Me.bksbutton.BackColor = System.Drawing.Color.White
        Me.bksbutton.CausesValidation = False
        Me.bksbutton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.bksbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.bksbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bksbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bksbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bksbutton.Font = New System.Drawing.Font("等线", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.bksbutton.ForeColor = System.Drawing.Color.SlateBlue
        Me.bksbutton.Image = CType(resources.GetObject("bksbutton.Image"), System.Drawing.Image)
        Me.bksbutton.Location = New System.Drawing.Point(151, 38)
        Me.bksbutton.Name = "bksbutton"
        Me.bksbutton.Size = New System.Drawing.Size(26, 26)
        Me.bksbutton.TabIndex = 72
        Me.ToolTip1.SetToolTip(Me.bksbutton, "移除选定项。")
        Me.bksbutton.UseVisualStyleBackColor = False
        '
        'loadButton
        '
        Me.loadButton.BackColor = System.Drawing.Color.White
        Me.loadButton.CausesValidation = False
        Me.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.loadButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.loadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.loadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadButton.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.loadButton.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.loadButton.Image = CType(resources.GetObject("loadButton.Image"), System.Drawing.Image)
        Me.loadButton.Location = New System.Drawing.Point(12, 12)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(109, 26)
        Me.loadButton.TabIndex = 73
        Me.loadButton.Text = "拉取/浏览"
        Me.loadButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.loadButton, "按住Shift后点击按钮浏览文件夹；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "点击按钮拉取数据；" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "拖动文件夹到列表加载数据；")
        Me.loadButton.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.CausesValidation = False
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button4.Location = New System.Drawing.Point(205, 497)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 26)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "还原"
        Me.ToolTip1.SetToolTip(Me.Button4, "点击后还原文件原始名称。")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'moreButton
        '
        Me.moreButton.BackColor = System.Drawing.Color.White
        Me.moreButton.CausesValidation = False
        Me.moreButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.moreButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.moreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.moreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.moreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.moreButton.Font = New System.Drawing.Font("等线", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.moreButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.moreButton.Image = CType(resources.GetObject("moreButton.Image"), System.Drawing.Image)
        Me.moreButton.Location = New System.Drawing.Point(183, 38)
        Me.moreButton.Name = "moreButton"
        Me.moreButton.Size = New System.Drawing.Size(26, 26)
        Me.moreButton.TabIndex = 75
        Me.ToolTip1.SetToolTip(Me.moreButton, "向上移动")
        Me.moreButton.UseVisualStyleBackColor = False
        '
        'mnsButton
        '
        Me.mnsButton.BackColor = System.Drawing.Color.White
        Me.mnsButton.CausesValidation = False
        Me.mnsButton.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite
        Me.mnsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.mnsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mnsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.mnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mnsButton.Font = New System.Drawing.Font("等线", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.mnsButton.ForeColor = System.Drawing.Color.SlateBlue
        Me.mnsButton.Image = CType(resources.GetObject("mnsButton.Image"), System.Drawing.Image)
        Me.mnsButton.Location = New System.Drawing.Point(215, 38)
        Me.mnsButton.Name = "mnsButton"
        Me.mnsButton.Size = New System.Drawing.Size(26, 26)
        Me.mnsButton.TabIndex = 76
        Me.ToolTip1.SetToolTip(Me.mnsButton, "向下移动")
        Me.mnsButton.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.CausesValidation = False
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(95, 497)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(26, 26)
        Me.Button7.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.Button7, "仅选中项的重命名预览。")
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.MetroProgressBar1)
        Me.Panel3.Controls.Add(Me.bksbutton)
        Me.Panel3.Controls.Add(Me.mnsButton)
        Me.Panel3.Controls.Add(Me.moreButton)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.ListViewPre)
        Me.Panel3.Location = New System.Drawing.Point(-26, -28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(440, 514)
        Me.Panel3.TabIndex = 78
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Location = New System.Drawing.Point(36, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(329, 26)
        Me.Panel4.TabIndex = 92
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TextBox2.Location = New System.Drawing.Point(3, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox2.Size = New System.Drawing.Size(323, 17)
        Me.TextBox2.TabIndex = 50
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressBar1.Location = New System.Drawing.Point(22, 21)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(358, 11)
        Me.MetroProgressBar1.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroProgressBar1.TabIndex = 90
        Me.MetroProgressBar1.Visible = False
        '
        'Form6
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(353, 535)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.xlsxButton)
        Me.Controls.Add(Me.topButton)
        Me.Controls.Add(Me.absbButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "命名"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TextBoxStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewPre As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ApplyButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents xlsxButton As Button
    Friend WithEvents topButton As CheckBox
    Friend WithEvents absbButton As CheckBox
    Friend WithEvents bksbutton As Button
    Friend WithEvents loadButton As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents moreButton As Button
    Friend WithEvents mnsButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBoxStart As NumericUpDown
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox2 As TextBox
End Class
