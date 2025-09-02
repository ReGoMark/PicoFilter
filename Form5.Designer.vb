<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGoUp = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.topButton = New System.Windows.Forms.CheckBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.absbButton = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.sltLabel0 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip6 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.撤销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuStrip6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 26)
        Me.Panel1.TabIndex = 36
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.GhostWhite
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TextBox1.Location = New System.Drawing.Point(3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(323, 17)
        Me.TextBox1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TextBox1, "此处显示当前路径" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "要浏览或选择一个位置，请转到PicoFilter")
        '
        'btnGoUp
        '
        Me.btnGoUp.BackColor = System.Drawing.Color.White
        Me.btnGoUp.CausesValidation = False
        Me.btnGoUp.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGoUp.FlatAppearance.BorderSize = 0
        Me.btnGoUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.btnGoUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnGoUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnGoUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoUp.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnGoUp.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnGoUp.Image = CType(resources.GetObject("btnGoUp.Image"), System.Drawing.Image)
        Me.btnGoUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGoUp.Location = New System.Drawing.Point(24, 37)
        Me.btnGoUp.Name = "btnGoUp"
        Me.btnGoUp.Size = New System.Drawing.Size(90, 28)
        Me.btnGoUp.TabIndex = 1
        Me.btnGoUp.Text = "上一级"
        Me.btnGoUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnGoUp, "返回上一级目录(BACKSPACE)")
        Me.btnGoUp.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 22)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(366, 10)
        Me.ProgressBar1.Style = MetroFramework.MetroColorStyle.Silver
        Me.ProgressBar1.TabIndex = 53
        Me.ProgressBar1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.BackColor = System.Drawing.Color.White
        Me.CheckBox1.CausesValidation = False
        Me.CheckBox1.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.CheckBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.CheckBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.CheckBox1.Image = CType(resources.GetObject("CheckBox1.Image"), System.Drawing.Image)
        Me.CheckBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Location = New System.Drawing.Point(177, 497)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(73, 26)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "详细"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "在概览中显示图像文件")
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip3
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 1
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TreeView1.Location = New System.Drawing.Point(0, 32)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 1
        Me.TreeView1.Size = New System.Drawing.Size(329, 352)
        Me.TreeView1.TabIndex = 5
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem17, Me.ToolStripSeparator3, Me.ToolStripMenuItem6, Me.ToolStripMenuItem5, Me.ToolStripSeparator2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripSeparator1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(211, 218)
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ToolStripMenuItem17.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem17.Image = CType(resources.GetObject("ToolStripMenuItem17.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem17.Text = "跳转(&D)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(207, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem6.Text = "启用单点模式(&S)"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem5.Text = "禁用单点模式(&E)"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem3.Text = "启用详细模式(&D)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem4.Text = "禁用详细模式(&F)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem2.Text = "展开全部节点(&N)"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(210, 24)
        Me.ToolStripMenuItem1.Text = "折叠全部节点(&X)"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "unfolder_black.ico")
        Me.ImageList1.Images.SetKeyName(1, "folder_black.ico")
        Me.ImageList1.Images.SetKeyName(2, "images_black.ico")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(120, 38)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 26)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "跳转"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button2, "立即加载到 PicoFilter(RETURN)")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.CausesValidation = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button5.Location = New System.Drawing.Point(256, 497)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 26)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "展开全部"
        Me.Button5.UseVisualStyleBackColor = False
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
        Me.topButton.TabIndex = 6
        Me.topButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.topButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.topButton, "置顶窗体")
        Me.topButton.UseVisualStyleBackColor = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "pin.ico")
        Me.ImageList2.Images.SetKeyName(1, "pinned.ico")
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
        Me.absbButton.TabIndex = 7
        Me.absbButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.absbButton, "吸附窗体（左）")
        Me.absbButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Controls.Add(Me.sltLabel0)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 428)
        Me.Panel2.TabIndex = 58
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.GhostWhite
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 390)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(329, 38)
        Me.TableLayoutPanel1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoEllipsis = True
        Me.Label2.BackColor = System.Drawing.Color.GhostWhite
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.ImageIndex = 0
        Me.Label2.Location = New System.Drawing.Point(34, 0)
        Me.Label2.Name = "Label2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label2, 2)
        Me.Label2.Size = New System.Drawing.Size(292, 38)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "当前"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GhostWhite
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.ImageIndex = 1
        Me.Label1.ImageList = Me.ImageList3
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label1, 2)
        Me.Label1.Size = New System.Drawing.Size(25, 38)
        Me.Label1.TabIndex = 40
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "unfolder.ico")
        Me.ImageList3.Images.SetKeyName(1, "folder.ico")
        Me.ImageList3.Images.SetKeyName(2, "images.ico")
        '
        'sltLabel0
        '
        Me.sltLabel0.AutoEllipsis = True
        Me.sltLabel0.BackColor = System.Drawing.Color.GhostWhite
        Me.sltLabel0.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.sltLabel0.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.sltLabel0.ImageIndex = 0
        Me.sltLabel0.Location = New System.Drawing.Point(0, 366)
        Me.sltLabel0.Name = "sltLabel0"
        Me.sltLabel0.Size = New System.Drawing.Size(329, 18)
        Me.sltLabel0.TabIndex = 38
        Me.sltLabel0.Text = "当前"
        Me.sltLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sltLabel0.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.CausesValidation = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(250, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 26)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "遍历提取"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button3, "遍历所有目录的图像文件提取")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.BackColor = System.Drawing.Color.White
        Me.CheckBox2.CausesValidation = False
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.CheckBox2.Image = CType(resources.GetObject("CheckBox2.Image"), System.Drawing.Image)
        Me.CheckBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Location = New System.Drawing.Point(98, 497)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(73, 26)
        Me.CheckBox2.TabIndex = 62
        Me.CheckBox2.Text = "单点"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "只保留选中的目录")
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.btnGoUp)
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Location = New System.Drawing.Point(-14, -28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(428, 514)
        Me.Panel3.TabIndex = 61
        '
        'ContextMenuStrip6
        '
        Me.ContextMenuStrip6.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip6.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ContextMenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.撤销ToolStripMenuItem, Me.ToolStripSeparator14, Me.剪切ToolStripMenuItem, Me.复制ToolStripMenuItem, Me.粘贴ToolStripMenuItem, Me.删除ToolStripMenuItem, Me.ToolStripSeparator15, Me.全选ToolStripMenuItem})
        Me.ContextMenuStrip6.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip6.Size = New System.Drawing.Size(132, 160)
        '
        '撤销ToolStripMenuItem
        '
        Me.撤销ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.撤销ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.撤销ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.撤销ToolStripMenuItem.Image = CType(resources.GetObject("撤销ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.撤销ToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.撤销ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem"
        Me.撤销ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.撤销ToolStripMenuItem.Text = "撤销(&U)"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(128, 6)
        '
        '剪切ToolStripMenuItem
        '
        Me.剪切ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.剪切ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.剪切ToolStripMenuItem.Image = CType(resources.GetObject("剪切ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.剪切ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem"
        Me.剪切ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.剪切ToolStripMenuItem.Text = "剪切(&P)"
        '
        '复制ToolStripMenuItem
        '
        Me.复制ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.复制ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.复制ToolStripMenuItem.Image = CType(resources.GetObject("复制ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.复制ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem"
        Me.复制ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.复制ToolStripMenuItem.Text = "复制(&C)"
        '
        '粘贴ToolStripMenuItem
        '
        Me.粘贴ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.粘贴ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.粘贴ToolStripMenuItem.Image = CType(resources.GetObject("粘贴ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.粘贴ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem"
        Me.粘贴ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
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
        Me.删除ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.删除ToolStripMenuItem.Text = "删除(&D)"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(128, 6)
        '
        '全选ToolStripMenuItem
        '
        Me.全选ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.全选ToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.全选ToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.全选ToolStripMenuItem.Image = CType(resources.GetObject("全选ToolStripMenuItem.Image"), System.Drawing.Image)
        Me.全选ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem"
        Me.全选ToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.全选ToolStripMenuItem.Text = "全选(&A)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(207, 6)
        '
        'Form5
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(353, 535)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.topButton)
        Me.Controls.Add(Me.absbButton)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "概览"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuStrip6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnGoUp As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents topButton As CheckBox
    Friend WithEvents absbButton As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents sltLabel0 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem17 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents 撤销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents 剪切ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents 全选ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
