<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.bksbutton = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.移除选中项DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.还原列宽OToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnApplySelected = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnApplyAll = New System.Windows.Forms.Button()
        Me.topButton = New System.Windows.Forms.CheckBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.absbButton = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.rbICO = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cobQuality = New System.Windows.Forms.NumericUpDown()
        Me.rbPNG = New System.Windows.Forms.RadioButton()
        Me.rbJPG = New System.Windows.Forms.RadioButton()
        Me.rbBMP = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroProgressBar1 = New MetroFramework.Controls.MetroProgressBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip6 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.撤销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.剪切ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.复制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.粘贴ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.全选ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.cobQuality, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ContextMenuStrip6.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.White
        Me.btnLoad.CausesValidation = False
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLoad.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnLoad.Image = CType(resources.GetObject("btnLoad.Image"), System.Drawing.Image)
        Me.btnLoad.Location = New System.Drawing.Point(12, 12)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(109, 26)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "拉取/浏览"
        Me.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnLoad, "筛选页拉取(点击)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "拖入文件夹(列表)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "浏览文件夹(SHIFT+点击)(右键)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "加载页拉取(CTRL+点击)(中键)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'bksbutton
        '
        Me.bksbutton.BackColor = System.Drawing.Color.White
        Me.bksbutton.CausesValidation = False
        Me.bksbutton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.bksbutton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.bksbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bksbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.bksbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bksbutton.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.bksbutton.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.bksbutton.Image = CType(resources.GetObject("bksbutton.Image"), System.Drawing.Image)
        Me.bksbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bksbutton.Location = New System.Drawing.Point(155, 47)
        Me.bksbutton.Name = "bksbutton"
        Me.bksbutton.Size = New System.Drawing.Size(26, 26)
        Me.bksbutton.TabIndex = 2
        Me.bksbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.bksbutton, "移除选定项")
        Me.bksbutton.UseVisualStyleBackColor = False
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCopy.BackColor = System.Drawing.Color.White
        Me.btnCopy.CausesValidation = False
        Me.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCopy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopy.Location = New System.Drawing.Point(296, 47)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(73, 26)
        Me.btnCopy.TabIndex = 3
        Me.btnCopy.Text = "副本"
        Me.btnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnCopy, "保存转换副本到...")
        Me.btnCopy.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AllowDrop = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip3
        Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(329, 354)
        Me.ListView1.TabIndex = 5
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
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem17, Me.ToolStripSeparator3, Me.移除选中项DToolStripMenuItem, Me.ToolStripMenuItem14, Me.ToolStripSeparator5, Me.ToolStripMenuItem9, Me.还原列宽OToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(175, 136)
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ToolStripMenuItem17.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(174, 24)
        Me.ToolStripMenuItem17.Text = "预览(&V)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(171, 6)
        '
        '移除选中项DToolStripMenuItem
        '
        Me.移除选中项DToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.移除选中项DToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.移除选中项DToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.移除选中项DToolStripMenuItem.Image = CType(resources.GetObject("移除选中项DToolStripMenuItem.Image"), System.Drawing.Image)
        Me.移除选中项DToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.移除选中项DToolStripMenuItem.Name = "移除选中项DToolStripMenuItem"
        Me.移除选中项DToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.移除选中项DToolStripMenuItem.Text = "移除选中项(&D)"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem14.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ToolStripMenuItem14.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(174, 24)
        Me.ToolStripMenuItem14.Text = "选中所有项(&N)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(171, 6)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem9.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(174, 24)
        Me.ToolStripMenuItem9.Text = "列宽自适应(&I)"
        '
        '还原列宽OToolStripMenuItem
        '
        Me.还原列宽OToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.还原列宽OToolStripMenuItem.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.还原列宽OToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.还原列宽OToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.还原列宽OToolStripMenuItem.Name = "还原列宽OToolStripMenuItem"
        Me.还原列宽OToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.还原列宽OToolStripMenuItem.Text = "列宽复原(&O)"
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
        Me.btnApplySelected.Location = New System.Drawing.Point(205, 497)
        Me.btnApplySelected.Name = "btnApplySelected"
        Me.btnApplySelected.Size = New System.Drawing.Size(65, 26)
        Me.btnApplySelected.TabIndex = 15
        Me.btnApplySelected.Text = "应用"
        Me.btnApplySelected.UseVisualStyleBackColor = False
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
        Me.btnReset.Location = New System.Drawing.Point(276, 497)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(65, 26)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "还原"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnApplyAll
        '
        Me.btnApplyAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApplyAll.BackColor = System.Drawing.Color.White
        Me.btnApplyAll.CausesValidation = False
        Me.btnApplyAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.btnApplyAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.btnApplyAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.btnApplyAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnApplyAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApplyAll.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.btnApplyAll.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btnApplyAll.Image = CType(resources.GetObject("btnApplyAll.Image"), System.Drawing.Image)
        Me.btnApplyAll.Location = New System.Drawing.Point(173, 497)
        Me.btnApplyAll.Name = "btnApplyAll"
        Me.btnApplyAll.Size = New System.Drawing.Size(26, 26)
        Me.btnApplyAll.TabIndex = 14
        Me.btnApplyAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnApplyAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnApplyAll, "全选")
        Me.btnApplyAll.UseVisualStyleBackColor = False
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
        Me.topButton.TabIndex = 12
        Me.topButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.topButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.absbButton.TabIndex = 13
        Me.absbButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.absbButton.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 396)
        Me.Panel1.TabIndex = 82
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
        Me.Button3.Location = New System.Drawing.Point(264, 328)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 26)
        Me.Button3.TabIndex = 81
        Me.Button3.Text = "取消"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(292, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "背景"
        Me.Label3.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel5.Controls.Add(Me.colorButton)
        Me.Panel5.Controls.Add(Me.rbICO)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.cobQuality)
        Me.Panel5.Controls.Add(Me.rbPNG)
        Me.Panel5.Controls.Add(Me.rbJPG)
        Me.Panel5.Controls.Add(Me.rbBMP)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(0, 360)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(329, 36)
        Me.Panel5.TabIndex = 89
        '
        'colorButton
        '
        Me.colorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colorButton.BackColor = System.Drawing.Color.White
        Me.colorButton.CausesValidation = False
        Me.colorButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.colorButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.colorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.colorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colorButton.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.colorButton.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.colorButton.Location = New System.Drawing.Point(192, 8)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(39, 20)
        Me.colorButton.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.colorButton, "设置透明通道填充色")
        Me.colorButton.UseVisualStyleBackColor = False
        Me.colorButton.Visible = False
        '
        'rbICO
        '
        Me.rbICO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbICO.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbICO.BackColor = System.Drawing.Color.GhostWhite
        Me.rbICO.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbICO.FlatAppearance.BorderSize = 0
        Me.rbICO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.rbICO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbICO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbICO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbICO.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbICO.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbICO.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbICO.Location = New System.Drawing.Point(141, 5)
        Me.rbICO.Name = "rbICO"
        Me.rbICO.Size = New System.Drawing.Size(45, 26)
        Me.rbICO.TabIndex = 9
        Me.rbICO.Text = "ICO"
        Me.rbICO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbICO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.rbICO, "转换为ICO格式")
        Me.rbICO.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(301, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "%"
        '
        'cobQuality
        '
        Me.cobQuality.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cobQuality.BackColor = System.Drawing.Color.GhostWhite
        Me.cobQuality.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cobQuality.Enabled = False
        Me.cobQuality.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.cobQuality.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.cobQuality.Location = New System.Drawing.Point(237, 9)
        Me.cobQuality.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.cobQuality.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cobQuality.Name = "cobQuality"
        Me.cobQuality.Size = New System.Drawing.Size(61, 21)
        Me.cobQuality.TabIndex = 11
        Me.cobQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.cobQuality, "设置转换为JPEG格式质量")
        Me.cobQuality.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'rbPNG
        '
        Me.rbPNG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbPNG.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPNG.BackColor = System.Drawing.Color.Transparent
        Me.rbPNG.Checked = True
        Me.rbPNG.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbPNG.FlatAppearance.BorderSize = 0
        Me.rbPNG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.rbPNG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbPNG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbPNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbPNG.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbPNG.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbPNG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbPNG.Location = New System.Drawing.Point(6, 5)
        Me.rbPNG.Name = "rbPNG"
        Me.rbPNG.Size = New System.Drawing.Size(45, 26)
        Me.rbPNG.TabIndex = 6
        Me.rbPNG.TabStop = True
        Me.rbPNG.Text = "PNG"
        Me.rbPNG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbPNG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.rbPNG, "转换为PNG格式")
        Me.rbPNG.UseVisualStyleBackColor = False
        '
        'rbJPG
        '
        Me.rbJPG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbJPG.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbJPG.BackColor = System.Drawing.Color.GhostWhite
        Me.rbJPG.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbJPG.FlatAppearance.BorderSize = 0
        Me.rbJPG.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.rbJPG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbJPG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbJPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbJPG.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbJPG.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbJPG.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbJPG.Location = New System.Drawing.Point(51, 5)
        Me.rbJPG.Name = "rbJPG"
        Me.rbJPG.Size = New System.Drawing.Size(45, 26)
        Me.rbJPG.TabIndex = 7
        Me.rbJPG.Text = "JPG"
        Me.rbJPG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbJPG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.rbJPG, "转换为JPG格式")
        Me.rbJPG.UseVisualStyleBackColor = False
        '
        'rbBMP
        '
        Me.rbBMP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rbBMP.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbBMP.BackColor = System.Drawing.Color.GhostWhite
        Me.rbBMP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbBMP.FlatAppearance.BorderSize = 0
        Me.rbBMP.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.rbBMP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.rbBMP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.rbBMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbBMP.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.rbBMP.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.rbBMP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbBMP.Location = New System.Drawing.Point(96, 5)
        Me.rbBMP.Name = "rbBMP"
        Me.rbBMP.Size = New System.Drawing.Size(45, 26)
        Me.rbBMP.TabIndex = 8
        Me.rbBMP.Text = "BMP"
        Me.rbBMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbBMP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.rbBMP, "转换为BMP格式")
        Me.rbBMP.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "填充"
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
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(217, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 26)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "保存"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "覆盖转换文件")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MetroProgressBar1
        '
        Me.MetroProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroProgressBar1.Location = New System.Drawing.Point(18, 31)
        Me.MetroProgressBar1.Name = "MetroProgressBar1"
        Me.MetroProgressBar1.Size = New System.Drawing.Size(379, 10)
        Me.MetroProgressBar1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroProgressBar1.TabIndex = 90
        Me.MetroProgressBar1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.MetroProgressBar1)
        Me.Panel3.Controls.Add(Me.bksbutton)
        Me.Panel3.Controls.Add(Me.btnCopy)
        Me.Panel3.Location = New System.Drawing.Point(-30, -37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(437, 523)
        Me.Panel3.TabIndex = 91
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Location = New System.Drawing.Point(40, 79)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(329, 26)
        Me.Panel2.TabIndex = 91
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
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.White
        Me.ContextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 28)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 24)
        Me.ToolStripMenuItem1.Text = "移除选中项(&D)"
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
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(353, 535)
        Me.Controls.Add(Me.btnApplyAll)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnApplySelected)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.topButton)
        Me.Controls.Add(Me.absbButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "转换"
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.cobQuality, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnLoad As Button
    Friend WithEvents bksbutton As Button
    Friend WithEvents btnCopy As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnApplySelected As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnApplyAll As Button
    Friend WithEvents topButton As CheckBox
    Friend WithEvents absbButton As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel5 As Panel
    Friend WithEvents rbPNG As RadioButton
    Friend WithEvents rbJPG As RadioButton
    Friend WithEvents rbBMP As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cobQuality As NumericUpDown
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents MetroProgressBar1 As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents colorButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem17 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents 移除选中项DToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents 还原列宽OToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents ContextMenuStrip6 As ContextMenuStrip
    Friend WithEvents 撤销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents 剪切ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 复制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 粘贴ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents 全选ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbICO As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
