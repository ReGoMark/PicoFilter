<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTreeview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTreeview))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnNode = New System.Windows.Forms.Button()
        Me.ProgressBarOut = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TbxOpen = New Sunny.UI.UITextBox()
        Me.BtnDetail = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.BtnUp = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageNode = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ImageDock = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnPin = New System.Windows.Forms.CheckBox()
        Me.ImagePin = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnExtr = New System.Windows.Forms.Button()
        Me.BtnJump = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BtnNode)
        Me.Panel3.Controls.Add(Me.ProgressBarOut)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.TbxOpen)
        Me.Panel3.Controls.Add(Me.BtnDetail)
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.BtnUp)
        Me.Panel3.Location = New System.Drawing.Point(-16, -14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(423, 100)
        Me.Panel3.TabIndex = 29
        '
        'BtnNode
        '
        Me.BtnNode.BackColor = System.Drawing.Color.White
        Me.BtnNode.CausesValidation = False
        Me.BtnNode.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnNode.FlatAppearance.BorderSize = 0
        Me.BtnNode.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.BtnNode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.BtnNode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNode.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnNode.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnNode.Location = New System.Drawing.Point(26, 58)
        Me.BtnNode.Name = "BtnNode"
        Me.BtnNode.Size = New System.Drawing.Size(113, 26)
        Me.BtnNode.TabIndex = 66
        Me.BtnNode.Text = "展开全部节点"
        Me.BtnNode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnNode.UseVisualStyleBackColor = False
        '
        'ProgressBarOut
        '
        Me.ProgressBarOut.Location = New System.Drawing.Point(8, 10)
        Me.ProgressBarOut.Margin = New System.Windows.Forms.Padding(10)
        Me.ProgressBarOut.Name = "ProgressBarOut"
        Me.ProgressBarOut.Size = New System.Drawing.Size(375, 10)
        Me.ProgressBarOut.TabIndex = 29
        Me.ProgressBarOut.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(145, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(17, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'TbxOpen
        '
        Me.TbxOpen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TbxOpen.FillColor = System.Drawing.Color.WhiteSmoke
        Me.TbxOpen.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TbxOpen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TbxOpen.Location = New System.Drawing.Point(27, 24)
        Me.TbxOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TbxOpen.MinimumSize = New System.Drawing.Size(1, 16)
        Me.TbxOpen.Name = "TbxOpen"
        Me.TbxOpen.Padding = New System.Windows.Forms.Padding(5)
        Me.TbxOpen.Radius = 0
        Me.TbxOpen.ReadOnly = True
        Me.TbxOpen.RectColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.TbxOpen.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.TbxOpen.ShowText = False
        Me.TbxOpen.Size = New System.Drawing.Size(250, 26)
        Me.TbxOpen.SymbolColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TbxOpen.TabIndex = 61
        Me.TbxOpen.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TbxOpen.Watermark = "显示当前路径"
        Me.TbxOpen.WatermarkActiveColor = System.Drawing.Color.LightGray
        Me.TbxOpen.WatermarkColor = System.Drawing.Color.DarkGray
        '
        'BtnDetail
        '
        Me.BtnDetail.Appearance = System.Windows.Forms.Appearance.Button
        Me.BtnDetail.BackColor = System.Drawing.Color.White
        Me.BtnDetail.CausesValidation = False
        Me.BtnDetail.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnDetail.FlatAppearance.BorderSize = 0
        Me.BtnDetail.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.BtnDetail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDetail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDetail.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnDetail.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnDetail.Image = CType(resources.GetObject("BtnDetail.Image"), System.Drawing.Image)
        Me.BtnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDetail.Location = New System.Drawing.Point(269, 58)
        Me.BtnDetail.Name = "BtnDetail"
        Me.BtnDetail.Size = New System.Drawing.Size(95, 26)
        Me.BtnDetail.TabIndex = 63
        Me.BtnDetail.Text = "详细节点"
        Me.BtnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BtnDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDetail.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox2.CausesValidation = False
        Me.CheckBox2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.CheckBox2.FlatAppearance.BorderSize = 0
        Me.CheckBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lavender
        Me.CheckBox2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CheckBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.CheckBox2.Image = CType(resources.GetObject("CheckBox2.Image"), System.Drawing.Image)
        Me.CheckBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox2.Location = New System.Drawing.Point(168, 58)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(95, 26)
        Me.CheckBox2.TabIndex = 64
        Me.CheckBox2.Text = "单一节点"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'BtnUp
        '
        Me.BtnUp.BackColor = System.Drawing.Color.White
        Me.BtnUp.CausesValidation = False
        Me.BtnUp.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnUp.FlatAppearance.BorderSize = 0
        Me.BtnUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.BtnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.BtnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUp.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnUp.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnUp.Image = CType(resources.GetObject("BtnUp.Image"), System.Drawing.Image)
        Me.BtnUp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUp.Location = New System.Drawing.Point(284, 24)
        Me.BtnUp.Name = "BtnUp"
        Me.BtnUp.Size = New System.Drawing.Size(80, 26)
        Me.BtnUp.TabIndex = 3
        Me.BtnUp.Text = "上一级"
        Me.BtnUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUp.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.TreeView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageNode
        Me.TreeView1.LineColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.TreeView1.Location = New System.Drawing.Point(12, 97)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.Size = New System.Drawing.Size(338, 383)
        Me.TreeView1.TabIndex = 30
        '
        'ImageNode
        '
        Me.ImageNode.ImageStream = CType(resources.GetObject("ImageNode.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageNode.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageNode.Images.SetKeyName(0, "unfolder_black.ico")
        Me.ImageNode.Images.SetKeyName(1, "folder_black.ico")
        Me.ImageNode.Images.SetKeyName(2, "images_black.ico")
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.BtnPin)
        Me.Panel1.Controls.Add(Me.BtnExtr)
        Me.Panel1.Controls.Add(Me.BtnJump)
        Me.Panel1.Location = New System.Drawing.Point(-6, 492)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 73)
        Me.Panel1.TabIndex = 31
        '
        'CheckBox3
        '
        Me.CheckBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox3.CausesValidation = False
        Me.CheckBox3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CheckBox3.FlatAppearance.BorderSize = 0
        Me.CheckBox3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gainsboro
        Me.CheckBox3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.CheckBox3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.CheckBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox3.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.CheckBox3.ImageIndex = 0
        Me.CheckBox3.ImageList = Me.ImageDock
        Me.CheckBox3.Location = New System.Drawing.Point(50, 13)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(26, 26)
        Me.CheckBox3.TabIndex = 58
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CheckBox3.UseVisualStyleBackColor = False
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
        Me.BtnPin.Location = New System.Drawing.Point(18, 13)
        Me.BtnPin.Name = "BtnPin"
        Me.BtnPin.Size = New System.Drawing.Size(26, 26)
        Me.BtnPin.TabIndex = 57
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
        'BtnExtr
        '
        Me.BtnExtr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExtr.BackColor = System.Drawing.Color.White
        Me.BtnExtr.CausesValidation = False
        Me.BtnExtr.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnExtr.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.BtnExtr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.BtnExtr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnExtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExtr.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnExtr.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnExtr.Image = CType(resources.GetObject("BtnExtr.Image"), System.Drawing.Image)
        Me.BtnExtr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExtr.Location = New System.Drawing.Point(110, 13)
        Me.BtnExtr.Name = "BtnExtr"
        Me.BtnExtr.Size = New System.Drawing.Size(100, 26)
        Me.BtnExtr.TabIndex = 4
        Me.BtnExtr.Text = "全部提取"
        Me.BtnExtr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnExtr.UseVisualStyleBackColor = False
        '
        'BtnJump
        '
        Me.BtnJump.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnJump.BackColor = System.Drawing.Color.White
        Me.BtnJump.CausesValidation = False
        Me.BtnJump.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnJump.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.BtnJump.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.BtnJump.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.BtnJump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJump.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.BtnJump.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.BtnJump.Image = CType(resources.GetObject("BtnJump.Image"), System.Drawing.Image)
        Me.BtnJump.Location = New System.Drawing.Point(216, 13)
        Me.BtnJump.Name = "BtnJump"
        Me.BtnJump.Size = New System.Drawing.Size(140, 26)
        Me.BtnJump.TabIndex = 4
        Me.BtnJump.Text = "转到 PicoFilter"
        Me.BtnJump.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnJump.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnJump.UseVisualStyleBackColor = False
        '
        'FormTreeview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(362, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormTreeview"
        Me.Text = "FormTreeView"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnNode As Button
    Friend WithEvents ProgressBarOut As ProgressBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TbxOpen As Sunny.UI.UITextBox
    Friend WithEvents BtnDetail As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BtnUp As Button
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents ImageDock As ImageList
    Friend WithEvents BtnPin As CheckBox
    Friend WithEvents ImagePin As ImageList
    Friend WithEvents BtnExtr As Button
    Friend WithEvents BtnJump As Button
    Friend WithEvents ImageNode As ImageList
End Class
