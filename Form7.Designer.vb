<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.conjButton = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonCopySelected = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.topButton = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.absbButton = New System.Windows.Forms.CheckBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip6 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.撤销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.ContextMenuStrip6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.MetroTabControl1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-14, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 496)
        Me.Panel1.TabIndex = 0
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Regular
        Me.MetroTabControl1.Location = New System.Drawing.Point(24, 52)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(329, 431)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTabControl1.TabIndex = 90
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.FlowLayoutPanel1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(321, 389)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "词典拆分   "
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.conjButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label44)
        Me.FlowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(321, 386)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'conjButton
        '
        Me.conjButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.conjButton.BackColor = System.Drawing.Color.White
        Me.conjButton.CausesValidation = False
        Me.conjButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.conjButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.conjButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.conjButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.conjButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.conjButton.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.conjButton.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.conjButton.Image = CType(resources.GetObject("conjButton.Image"), System.Drawing.Image)
        Me.conjButton.Location = New System.Drawing.Point(3, 3)
        Me.conjButton.Name = "conjButton"
        Me.conjButton.Size = New System.Drawing.Size(114, 26)
        Me.conjButton.TabIndex = 95
        Me.conjButton.Text = "包含连接符"
        Me.conjButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.conjButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.conjButton, "包含原始的连接字符。")
        Me.conjButton.UseVisualStyleBackColor = False
        Me.conjButton.Visible = False
        '
        'Label44
        '
        Me.Label44.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label44.BackColor = System.Drawing.Color.GhostWhite
        Me.Label44.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label44.Location = New System.Drawing.Point(3, 32)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(307, 26)
        Me.Label44.TabIndex = 91
        Me.Label44.Text = "选取文本以实现快速复制、查找和星标。"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label44.Visible = False
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.TextBox1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 40)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(321, 387)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "手动选取   "
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(2, 9)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(315, 377)
        Me.TextBox1.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.CausesValidation = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(24, 20)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 26)
        Me.Button5.TabIndex = 95
        Me.Button5.Text = "保存文本"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.CausesValidation = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(265, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 26)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "到星标"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "发送到「星标」标记框")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(177, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 26)
        Me.Button2.TabIndex = 91
        Me.Button2.Text = "到查找"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "发送到「查找」文本框")
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.ButtonCopySelected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonCopySelected.Location = New System.Drawing.Point(182, 497)
        Me.ButtonCopySelected.Name = "ButtonCopySelected"
        Me.ButtonCopySelected.Size = New System.Drawing.Size(88, 26)
        Me.ButtonCopySelected.TabIndex = 89
        Me.ButtonCopySelected.Text = "复制选中"
        Me.ButtonCopySelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCopySelected.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "完成"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'topButton
        '
        Me.topButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.topButton.ImageList = Me.ImageList1
        Me.topButton.Location = New System.Drawing.Point(12, 497)
        Me.topButton.Name = "topButton"
        Me.topButton.Size = New System.Drawing.Size(26, 26)
        Me.topButton.TabIndex = 93
        Me.topButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.topButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.topButton, "置顶窗体")
        Me.topButton.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "pin.ico")
        Me.ImageList1.Images.SetKeyName(1, "pinned.ico")
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
        Me.absbButton.TabIndex = 95
        Me.absbButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.absbButton, "吸附窗体（左）")
        Me.absbButton.UseVisualStyleBackColor = False
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
        Me.Button4.Location = New System.Drawing.Point(150, 497)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(26, 26)
        Me.Button4.TabIndex = 94
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button4, "全选")
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip6
        '
        Me.ContextMenuStrip6.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip6.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ContextMenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤销ToolStripMenuItem, Me.ToolStripSeparator14, Me.剪切ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.粘贴ToolStripMenuItem, Me.删除ToolStripMenuItem, Me.ToolStripSeparator15, Me.全选ToolStripMenuItem})
        Me.ContextMenuStrip6.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip6.Size = New System.Drawing.Size(130, 160)
        '
        '撤销ToolStripMenuItem
        '
        Me.撤销ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.撤销ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.撤销ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.撤销ToolStripMenuItem.Image = CType(resources.GetObject("撤销ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤销ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.撤销ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem"
        Me.撤销ToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.撤销ToolStripMenuItem.Text = "撤销(&U)"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(126, 6)
        '
        '剪切ToolStripMenuItem
        '
        Me.剪切ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.剪切ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.剪切ToolStripMenuItem.Image = CType(resources.GetObject("剪切ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem"
        Me.剪切ToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.剪切ToolStripMenuItem.Text = "剪切(&P)"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.复制ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.复制ToolStripMenuItem.Image = CType(resources.GetObject("复制ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.复制ToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴ToolStripMenuItem
        '
        Me.粘贴ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.粘贴ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.粘贴ToolStripMenuItem.Image = CType(resources.GetObject("粘贴ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem"
        Me.粘贴ToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.粘贴ToolStripMenuItem.Text = "粘贴(&T)"
        '
        '删除ToolStripMenuItem
        '
        Me.删除ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.删除ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.删除ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.删除ToolStripMenuItem.Image = CType(resources.GetObject("删除ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.删除ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem"
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.删除ToolStripMenuItem.Text = "删除(&D)"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(126, 6)
        '
        '全选ToolStripMenuItem
        '
        Me.全选ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.全选ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.全选ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.全选ToolStripMenuItem.Image = CType(resources.GetObject("全选ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.全选ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem"
        Me.全选ToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.全选ToolStripMenuItem.Text = "全选(&A)"
        '
        'Form7
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(353, 535)
        Me.Controls.Add(Me.absbButton)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.topButton)
        Me.Controls.Add(Me.ButtonCopySelected)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "拆分"
        Me.Panel1.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ContextMenuStrip6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonCopySelected As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents topButton As CheckBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label44 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents conjButton As CheckBox
    Friend WithEvents absbButton As CheckBox
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents 撤销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents 剪切ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents 全选ToolStripMenuItem As ToolStripMenuItem
End Class
