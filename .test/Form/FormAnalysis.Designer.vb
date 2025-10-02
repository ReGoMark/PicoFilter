<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAnalysis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAnalysis))
        Me.TabAnalysis = New Sunny.UI.UITabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AnaLoadpngPercn = New System.Windows.Forms.Label()
        Me.AnaLoadgifPercn = New System.Windows.Forms.Label()
        Me.AnaLoadpngCount = New System.Windows.Forms.Label()
        Me.AnaLoadjpgPercn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AnaLoadicoPercn = New System.Windows.Forms.Label()
        Me.AnaLoadjpgCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnaLoadgifCount = New System.Windows.Forms.Label()
        Me.AnaLoadicoCount = New System.Windows.Forms.Label()
        Me.AnaLoadbmpPercn = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.AnaLoadbmpCount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AnaFiltCount = New System.Windows.Forms.Label()
        Me.AnaFiltPercn = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.AnaModifyTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AnaLoadCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.AnaCreateTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.AnaLoadtifCount = New System.Windows.Forms.Label()
        Me.AnaLoadtifPercn = New System.Windows.Forms.Label()
        Me.AnaLoadwebpCount = New System.Windows.Forms.Label()
        Me.AnaLoadwebpPercn = New System.Windows.Forms.Label()
        Me.AnaFilttifCount = New System.Windows.Forms.Label()
        Me.AnaFilttifPercn = New System.Windows.Forms.Label()
        Me.AnaFiltwebpCount = New System.Windows.Forms.Label()
        Me.AnaFiltwebpPercn = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.AnaFiltbmpCount = New System.Windows.Forms.Label()
        Me.AnaFiltbmpPercn = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.AnaFiltgifCount = New System.Windows.Forms.Label()
        Me.AnaFiltgifPercn = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.AnaFilticoCount = New System.Windows.Forms.Label()
        Me.AnaFilticoPercn = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.AnaFiltpngCount = New System.Windows.Forms.Label()
        Me.AnaFiltjpgCount = New System.Windows.Forms.Label()
        Me.AnaFiltpngPercn = New System.Windows.Forms.Label()
        Me.AnaFiltjpgPercn = New System.Windows.Forms.Label()
        Me.AnaLoadSizeAndTime = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.UiDoughnutChart1 = New Sunny.UI.UIDoughnutChart()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.UiComboBox1 = New Sunny.UI.UIComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ImageDock = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnPin = New System.Windows.Forms.CheckBox()
        Me.ImagePin = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabAnalysis.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabAnalysis
        '
        Me.TabAnalysis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabAnalysis.Controls.Add(Me.TabPage1)
        Me.TabAnalysis.Controls.Add(Me.TabPage2)
        Me.TabAnalysis.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabAnalysis.FillColor = System.Drawing.Color.White
        Me.TabAnalysis.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.TabAnalysis.ItemSize = New System.Drawing.Size(65, 26)
        Me.TabAnalysis.Location = New System.Drawing.Point(12, 12)
        Me.TabAnalysis.MainPage = ""
        Me.TabAnalysis.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        Me.TabAnalysis.Name = "TabAnalysis"
        Me.TabAnalysis.SelectedIndex = 0
        Me.TabAnalysis.ShowTabDivider = False
        Me.TabAnalysis.Size = New System.Drawing.Size(338, 469)
        Me.TabAnalysis.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabAnalysis.TabBackColor = System.Drawing.Color.White
        Me.TabAnalysis.TabIndex = 1
        Me.TabAnalysis.TabSelectedColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TabAnalysis.TabSelectedForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TabAnalysis.TabSelectedHighColorSize = 0
        Me.TabAnalysis.TabUnSelectedColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabAnalysis.TabUnSelectedForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TabAnalysis.TipsFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(0, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(338, 443)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "详细"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.31746!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.68254!))
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadpngPercn, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadgifPercn, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadpngCount, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadjpgPercn, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadicoPercn, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadjpgCount, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadgifCount, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadicoCount, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadbmpPercn, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadbmpCount, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltCount, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltPercn, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label35, 0, 22)
        Me.TableLayoutPanel1.Controls.Add(Me.Label45, 1, 22)
        Me.TableLayoutPanel1.Controls.Add(Me.Label51, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaModifyTime, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadCount, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label49, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaCreateTime, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.Label47, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.Label48, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label34, 0, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.Label53, 0, 20)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadtifCount, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadtifPercn, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadwebpCount, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadwebpPercn, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFilttifCount, 1, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFilttifPercn, 2, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltwebpCount, 1, 20)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltwebpPercn, 2, 20)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltbmpCount, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltbmpPercn, 2, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label29, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltgifCount, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltgifPercn, 2, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Label30, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFilticoCount, 1, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFilticoPercn, 2, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.Label33, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.Label32, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltpngCount, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltjpgCount, 1, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltpngPercn, 2, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaFiltjpgPercn, 2, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.AnaLoadSizeAndTime, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 7)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 24
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 433)
        Me.TableLayoutPanel1.TabIndex = 58
        '
        'AnaLoadpngPercn
        '
        Me.AnaLoadpngPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadpngPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadpngPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadpngPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadpngPercn.Location = New System.Drawing.Point(240, 169)
        Me.AnaLoadpngPercn.Name = "AnaLoadpngPercn"
        Me.AnaLoadpngPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadpngPercn.TabIndex = 16
        Me.AnaLoadpngPercn.Text = "Label17"
        Me.AnaLoadpngPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadgifPercn
        '
        Me.AnaLoadgifPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadgifPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadgifPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadgifPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadgifPercn.Location = New System.Drawing.Point(240, 112)
        Me.AnaLoadgifPercn.Name = "AnaLoadgifPercn"
        Me.AnaLoadgifPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadgifPercn.TabIndex = 20
        Me.AnaLoadgifPercn.Text = "Label21"
        Me.AnaLoadgifPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadpngCount
        '
        Me.AnaLoadpngCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadpngCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadpngCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadpngCount.Location = New System.Drawing.Point(88, 169)
        Me.AnaLoadpngCount.Name = "AnaLoadpngCount"
        Me.AnaLoadpngCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadpngCount.TabIndex = 10
        Me.AnaLoadpngCount.Text = "PNGCount"
        Me.AnaLoadpngCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadjpgPercn
        '
        Me.AnaLoadjpgPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadjpgPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadjpgPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadjpgPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.AnaLoadjpgPercn.Location = New System.Drawing.Point(240, 150)
        Me.AnaLoadjpgPercn.Name = "AnaLoadjpgPercn"
        Me.AnaLoadjpgPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadjpgPercn.TabIndex = 17
        Me.AnaLoadjpgPercn.Text = "Label18"
        Me.AnaLoadjpgPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(3, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "...PNG "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaLoadicoPercn
        '
        Me.AnaLoadicoPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadicoPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadicoPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadicoPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadicoPercn.Location = New System.Drawing.Point(240, 131)
        Me.AnaLoadicoPercn.Name = "AnaLoadicoPercn"
        Me.AnaLoadicoPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadicoPercn.TabIndex = 19
        Me.AnaLoadicoPercn.Text = "Label20"
        Me.AnaLoadicoPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadjpgCount
        '
        Me.AnaLoadjpgCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadjpgCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadjpgCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadjpgCount.Location = New System.Drawing.Point(88, 150)
        Me.AnaLoadjpgCount.Name = "AnaLoadjpgCount"
        Me.AnaLoadjpgCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadjpgCount.TabIndex = 11
        Me.AnaLoadjpgCount.Text = "JPGCount"
        Me.AnaLoadjpgCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(3, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "...JPG"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaLoadgifCount
        '
        Me.AnaLoadgifCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadgifCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadgifCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadgifCount.Location = New System.Drawing.Point(88, 112)
        Me.AnaLoadgifCount.Name = "AnaLoadgifCount"
        Me.AnaLoadgifCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadgifCount.TabIndex = 14
        Me.AnaLoadgifCount.Text = "GIFCount"
        Me.AnaLoadgifCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadicoCount
        '
        Me.AnaLoadicoCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadicoCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadicoCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadicoCount.Location = New System.Drawing.Point(88, 131)
        Me.AnaLoadicoCount.Name = "AnaLoadicoCount"
        Me.AnaLoadicoCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadicoCount.TabIndex = 13
        Me.AnaLoadicoCount.Text = "ICOCount"
        Me.AnaLoadicoCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadbmpPercn
        '
        Me.AnaLoadbmpPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadbmpPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadbmpPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadbmpPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadbmpPercn.Location = New System.Drawing.Point(240, 93)
        Me.AnaLoadbmpPercn.Name = "AnaLoadbmpPercn"
        Me.AnaLoadbmpPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadbmpPercn.TabIndex = 18
        Me.AnaLoadbmpPercn.Text = "Label19"
        Me.AnaLoadbmpPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label7.Location = New System.Drawing.Point(3, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "...GIF"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label8.Location = New System.Drawing.Point(3, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "筛选"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaLoadbmpCount
        '
        Me.AnaLoadbmpCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadbmpCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadbmpCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadbmpCount.Location = New System.Drawing.Point(88, 93)
        Me.AnaLoadbmpCount.Name = "AnaLoadbmpCount"
        Me.AnaLoadbmpCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadbmpCount.TabIndex = 12
        Me.AnaLoadbmpCount.Text = "BMPCount"
        Me.AnaLoadbmpCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(3, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 18)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "...BMP"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaFiltCount
        '
        Me.AnaFiltCount.AutoEllipsis = True
        Me.AnaFiltCount.BackColor = System.Drawing.Color.White
        Me.AnaFiltCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltCount.Location = New System.Drawing.Point(88, 236)
        Me.AnaFiltCount.Name = "AnaFiltCount"
        Me.AnaFiltCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFiltCount.TabIndex = 15
        Me.AnaFiltCount.Text = "Label16"
        Me.AnaFiltCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltPercn
        '
        Me.AnaFiltPercn.BackColor = System.Drawing.Color.White
        Me.AnaFiltPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFiltPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltPercn.Location = New System.Drawing.Point(240, 236)
        Me.AnaFiltPercn.Name = "AnaFiltPercn"
        Me.AnaFiltPercn.Size = New System.Drawing.Size(95, 20)
        Me.AnaFiltPercn.TabIndex = 21
        Me.AnaFiltPercn.Text = "Label22"
        Me.AnaFiltPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label35.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label35.Location = New System.Drawing.Point(3, 399)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(39, 20)
        Me.Label35.TabIndex = 52
        Me.Label35.Text = "星标"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.AutoEllipsis = True
        Me.Label45.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label45, 2)
        Me.Label45.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label45.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(88, 399)
        Me.Label45.Name = "Label45"
        Me.TableLayoutPanel1.SetRowSpan(Me.Label45, 2)
        Me.Label45.Size = New System.Drawing.Size(247, 37)
        Me.Label45.TabIndex = 54
        Me.Label45.Text = "此处显示标记词、星标数量"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label51.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label51.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label51.Location = New System.Drawing.Point(3, 42)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(79, 21)
        Me.Label51.TabIndex = 63
        Me.Label51.Text = "最后修改"
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaModifyTime
        '
        Me.AnaModifyTime.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.AnaModifyTime, 2)
        Me.AnaModifyTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaModifyTime.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaModifyTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaModifyTime.Location = New System.Drawing.Point(88, 42)
        Me.AnaModifyTime.Name = "AnaModifyTime"
        Me.AnaModifyTime.Size = New System.Drawing.Size(247, 21)
        Me.AnaModifyTime.TabIndex = 65
        Me.AnaModifyTime.Text = "ModifyTime"
        Me.AnaModifyTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(3, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "加载"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaLoadCount
        '
        Me.AnaLoadCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadCount.Location = New System.Drawing.Point(88, 73)
        Me.AnaLoadCount.Name = "AnaLoadCount"
        Me.AnaLoadCount.Size = New System.Drawing.Size(146, 20)
        Me.AnaLoadCount.TabIndex = 8
        Me.AnaLoadCount.Text = "LoadCount"
        Me.AnaLoadCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "概要"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label49.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label49.Location = New System.Drawing.Point(3, 21)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(69, 20)
        Me.Label49.TabIndex = 60
        Me.Label49.Text = "创建日期"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaCreateTime
        '
        Me.AnaCreateTime.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.AnaCreateTime, 2)
        Me.AnaCreateTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaCreateTime.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaCreateTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaCreateTime.Location = New System.Drawing.Point(88, 21)
        Me.AnaCreateTime.Name = "AnaCreateTime"
        Me.AnaCreateTime.Size = New System.Drawing.Size(247, 21)
        Me.AnaCreateTime.TabIndex = 61
        Me.AnaCreateTime.Text = "CreateTime"
        Me.AnaCreateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(3, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "...ICO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label47.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label47.Location = New System.Drawing.Point(3, 188)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 18)
        Me.Label47.TabIndex = 66
        Me.Label47.Text = "...TIF"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label48.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label48.Location = New System.Drawing.Point(3, 207)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(56, 18)
        Me.Label48.TabIndex = 67
        Me.Label48.Text = "...WBP"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label34.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label34.Location = New System.Drawing.Point(3, 351)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 18)
        Me.Label34.TabIndex = 68
        Me.Label34.Text = "...TIF"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label53.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label53.Location = New System.Drawing.Point(3, 370)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 18)
        Me.Label53.TabIndex = 69
        Me.Label53.Text = "...WBP"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaLoadtifCount
        '
        Me.AnaLoadtifCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadtifCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadtifCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadtifCount.Location = New System.Drawing.Point(88, 188)
        Me.AnaLoadtifCount.Name = "AnaLoadtifCount"
        Me.AnaLoadtifCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadtifCount.TabIndex = 70
        Me.AnaLoadtifCount.Text = "TIFCount"
        Me.AnaLoadtifCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadtifPercn
        '
        Me.AnaLoadtifPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadtifPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadtifPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadtifPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadtifPercn.Location = New System.Drawing.Point(240, 188)
        Me.AnaLoadtifPercn.Name = "AnaLoadtifPercn"
        Me.AnaLoadtifPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadtifPercn.TabIndex = 71
        Me.AnaLoadtifPercn.Text = "Label55"
        Me.AnaLoadtifPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadwebpCount
        '
        Me.AnaLoadwebpCount.BackColor = System.Drawing.Color.White
        Me.AnaLoadwebpCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadwebpCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadwebpCount.Location = New System.Drawing.Point(88, 207)
        Me.AnaLoadwebpCount.Name = "AnaLoadwebpCount"
        Me.AnaLoadwebpCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaLoadwebpCount.TabIndex = 72
        Me.AnaLoadwebpCount.Text = "WEBPCount"
        Me.AnaLoadwebpCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadwebpPercn
        '
        Me.AnaLoadwebpPercn.BackColor = System.Drawing.Color.White
        Me.AnaLoadwebpPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadwebpPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadwebpPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadwebpPercn.Location = New System.Drawing.Point(240, 207)
        Me.AnaLoadwebpPercn.Name = "AnaLoadwebpPercn"
        Me.AnaLoadwebpPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaLoadwebpPercn.TabIndex = 73
        Me.AnaLoadwebpPercn.Text = "Label57"
        Me.AnaLoadwebpPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFilttifCount
        '
        Me.AnaFilttifCount.BackColor = System.Drawing.Color.White
        Me.AnaFilttifCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFilttifCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFilttifCount.Location = New System.Drawing.Point(88, 351)
        Me.AnaFilttifCount.Name = "AnaFilttifCount"
        Me.AnaFilttifCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFilttifCount.TabIndex = 74
        Me.AnaFilttifCount.Text = "Label58"
        Me.AnaFilttifCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFilttifPercn
        '
        Me.AnaFilttifPercn.BackColor = System.Drawing.Color.White
        Me.AnaFilttifPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFilttifPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFilttifPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFilttifPercn.Location = New System.Drawing.Point(240, 351)
        Me.AnaFilttifPercn.Name = "AnaFilttifPercn"
        Me.AnaFilttifPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFilttifPercn.TabIndex = 75
        Me.AnaFilttifPercn.Text = "Label59"
        Me.AnaFilttifPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltwebpCount
        '
        Me.AnaFiltwebpCount.BackColor = System.Drawing.Color.White
        Me.AnaFiltwebpCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltwebpCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltwebpCount.Location = New System.Drawing.Point(88, 370)
        Me.AnaFiltwebpCount.Name = "AnaFiltwebpCount"
        Me.AnaFiltwebpCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFiltwebpCount.TabIndex = 76
        Me.AnaFiltwebpCount.Text = "Label60"
        Me.AnaFiltwebpCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltwebpPercn
        '
        Me.AnaFiltwebpPercn.BackColor = System.Drawing.Color.White
        Me.AnaFiltwebpPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFiltwebpPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltwebpPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltwebpPercn.Location = New System.Drawing.Point(240, 370)
        Me.AnaFiltwebpPercn.Name = "AnaFiltwebpPercn"
        Me.AnaFiltwebpPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFiltwebpPercn.TabIndex = 77
        Me.AnaFiltwebpPercn.Text = "Label61"
        Me.AnaFiltwebpPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label31.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label31.Location = New System.Drawing.Point(3, 256)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 18)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "...BMP"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaFiltbmpCount
        '
        Me.AnaFiltbmpCount.BackColor = System.Drawing.Color.White
        Me.AnaFiltbmpCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltbmpCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltbmpCount.Location = New System.Drawing.Point(88, 256)
        Me.AnaFiltbmpCount.Name = "AnaFiltbmpCount"
        Me.AnaFiltbmpCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFiltbmpCount.TabIndex = 31
        Me.AnaFiltbmpCount.Text = "Label26"
        Me.AnaFiltbmpCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltbmpPercn
        '
        Me.AnaFiltbmpPercn.BackColor = System.Drawing.Color.White
        Me.AnaFiltbmpPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFiltbmpPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltbmpPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltbmpPercn.Location = New System.Drawing.Point(240, 256)
        Me.AnaFiltbmpPercn.Name = "AnaFiltbmpPercn"
        Me.AnaFiltbmpPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFiltbmpPercn.TabIndex = 38
        Me.AnaFiltbmpPercn.Text = "Label38"
        Me.AnaFiltbmpPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label29.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label29.Location = New System.Drawing.Point(3, 275)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 18)
        Me.Label29.TabIndex = 28
        Me.Label29.Text = "...GIF"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaFiltgifCount
        '
        Me.AnaFiltgifCount.BackColor = System.Drawing.Color.White
        Me.AnaFiltgifCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltgifCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltgifCount.Location = New System.Drawing.Point(88, 275)
        Me.AnaFiltgifCount.Name = "AnaFiltgifCount"
        Me.AnaFiltgifCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFiltgifCount.TabIndex = 33
        Me.AnaFiltgifCount.Text = "Label24"
        Me.AnaFiltgifCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltgifPercn
        '
        Me.AnaFiltgifPercn.BackColor = System.Drawing.Color.White
        Me.AnaFiltgifPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFiltgifPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltgifPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltgifPercn.Location = New System.Drawing.Point(240, 275)
        Me.AnaFiltgifPercn.Name = "AnaFiltgifPercn"
        Me.AnaFiltgifPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFiltgifPercn.TabIndex = 40
        Me.AnaFiltgifPercn.Text = "Label36"
        Me.AnaFiltgifPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label30.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label30.Location = New System.Drawing.Point(3, 294)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 18)
        Me.Label30.TabIndex = 27
        Me.Label30.Text = "...ICO"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaFilticoCount
        '
        Me.AnaFilticoCount.BackColor = System.Drawing.Color.White
        Me.AnaFilticoCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFilticoCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFilticoCount.Location = New System.Drawing.Point(88, 294)
        Me.AnaFilticoCount.Name = "AnaFilticoCount"
        Me.AnaFilticoCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFilticoCount.TabIndex = 32
        Me.AnaFilticoCount.Text = "Label25"
        Me.AnaFilticoCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFilticoPercn
        '
        Me.AnaFilticoPercn.BackColor = System.Drawing.Color.White
        Me.AnaFilticoPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFilticoPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFilticoPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFilticoPercn.Location = New System.Drawing.Point(240, 294)
        Me.AnaFilticoPercn.Name = "AnaFilticoPercn"
        Me.AnaFilticoPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFilticoPercn.TabIndex = 39
        Me.AnaFilticoPercn.Text = "Label37"
        Me.AnaFilticoPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label33.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label33.Location = New System.Drawing.Point(3, 332)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 18)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "...PNG"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label32.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label32.Location = New System.Drawing.Point(3, 313)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 18)
        Me.Label32.TabIndex = 25
        Me.Label32.Text = "...JPG"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AnaFiltpngCount
        '
        Me.AnaFiltpngCount.BackColor = System.Drawing.Color.White
        Me.AnaFiltpngCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltpngCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltpngCount.Location = New System.Drawing.Point(88, 332)
        Me.AnaFiltpngCount.Name = "AnaFiltpngCount"
        Me.AnaFiltpngCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFiltpngCount.TabIndex = 29
        Me.AnaFiltpngCount.Text = "Label28"
        Me.AnaFiltpngCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltjpgCount
        '
        Me.AnaFiltjpgCount.BackColor = System.Drawing.Color.White
        Me.AnaFiltjpgCount.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltjpgCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltjpgCount.Location = New System.Drawing.Point(88, 313)
        Me.AnaFiltjpgCount.Name = "AnaFiltjpgCount"
        Me.AnaFiltjpgCount.Size = New System.Drawing.Size(146, 19)
        Me.AnaFiltjpgCount.TabIndex = 30
        Me.AnaFiltjpgCount.Text = "Label27"
        Me.AnaFiltjpgCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltpngPercn
        '
        Me.AnaFiltpngPercn.BackColor = System.Drawing.Color.White
        Me.AnaFiltpngPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFiltpngPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltpngPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltpngPercn.Location = New System.Drawing.Point(240, 332)
        Me.AnaFiltpngPercn.Name = "AnaFiltpngPercn"
        Me.AnaFiltpngPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFiltpngPercn.TabIndex = 36
        Me.AnaFiltpngPercn.Text = "Label40"
        Me.AnaFiltpngPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaFiltjpgPercn
        '
        Me.AnaFiltjpgPercn.BackColor = System.Drawing.Color.White
        Me.AnaFiltjpgPercn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaFiltjpgPercn.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaFiltjpgPercn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaFiltjpgPercn.Location = New System.Drawing.Point(240, 313)
        Me.AnaFiltjpgPercn.Name = "AnaFiltjpgPercn"
        Me.AnaFiltjpgPercn.Size = New System.Drawing.Size(95, 19)
        Me.AnaFiltjpgPercn.TabIndex = 37
        Me.AnaFiltjpgPercn.Text = "Label39"
        Me.AnaFiltjpgPercn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AnaLoadSizeAndTime
        '
        Me.AnaLoadSizeAndTime.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.SetColumnSpan(Me.AnaLoadSizeAndTime, 2)
        Me.AnaLoadSizeAndTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnaLoadSizeAndTime.Font = New System.Drawing.Font("Consolas", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.AnaLoadSizeAndTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.AnaLoadSizeAndTime.Location = New System.Drawing.Point(88, 0)
        Me.AnaLoadSizeAndTime.Name = "AnaLoadSizeAndTime"
        Me.AnaLoadSizeAndTime.Size = New System.Drawing.Size(247, 21)
        Me.AnaLoadSizeAndTime.TabIndex = 9
        Me.AnaLoadSizeAndTime.Text = "LoadSize"
        Me.AnaLoadSizeAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.UiDoughnutChart1)
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(0, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(338, 443)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "图表"
        '
        'UiDoughnutChart1
        '
        Me.UiDoughnutChart1.ChartStyleType = Sunny.UI.UIChartStyleType.[Default]
        Me.UiDoughnutChart1.FillColor = System.Drawing.Color.White
        Me.UiDoughnutChart1.Font = New System.Drawing.Font("微软雅黑", 9.0!)
        Me.UiDoughnutChart1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UiDoughnutChart1.LegendFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiDoughnutChart1.Location = New System.Drawing.Point(-3, 38)
        Me.UiDoughnutChart1.Margin = New System.Windows.Forms.Padding(0)
        Me.UiDoughnutChart1.MinimumSize = New System.Drawing.Size(1, 1)
        Me.UiDoughnutChart1.Name = "UiDoughnutChart1"
        Me.UiDoughnutChart1.Radius = 0
        Me.UiDoughnutChart1.RectColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiDoughnutChart1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None
        Me.UiDoughnutChart1.Size = New System.Drawing.Size(343, 405)
        Me.UiDoughnutChart1.Style = Sunny.UI.UIStyle.Custom
        Me.UiDoughnutChart1.SubFont = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiDoughnutChart1.TabIndex = 0
        Me.UiDoughnutChart1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UiDoughnutChart1.TextInterval = 10
        Me.UiDoughnutChart1.ZoomScaleDisabled = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label46, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.UiComboBox1, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, -1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(338, 36)
        Me.TableLayoutPanel2.TabIndex = 13
        '
        'Label46
        '
        Me.Label46.AutoEllipsis = True
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.White
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label46.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(3, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(247, 36)
        Me.Label46.TabIndex = 62
        Me.Label46.Text = "Label46"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UiComboBox1
        '
        Me.UiComboBox1.DataSource = Nothing
        Me.UiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        Me.UiComboBox1.FillColor = System.Drawing.Color.WhiteSmoke
        Me.UiComboBox1.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UiComboBox1.ItemFillColor = System.Drawing.Color.WhiteSmoke
        Me.UiComboBox1.ItemForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.UiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UiComboBox1.Items.AddRange(New Object() {"加载", "筛选"})
        Me.UiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UiComboBox1.Location = New System.Drawing.Point(257, 5)
        Me.UiComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UiComboBox1.MinimumSize = New System.Drawing.Size(63, 0)
        Me.UiComboBox1.Name = "UiComboBox1"
        Me.UiComboBox1.Padding = New System.Windows.Forms.Padding(0, 0, 30, 2)
        Me.UiComboBox1.Radius = 0
        Me.UiComboBox1.RectColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.UiComboBox1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom
        Me.UiComboBox1.Size = New System.Drawing.Size(77, 26)
        Me.UiComboBox1.SymbolSize = 20
        Me.UiComboBox1.TabIndex = 12
        Me.UiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.UiComboBox1.Watermark = ""
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
        Me.CheckBox1.Location = New System.Drawing.Point(44, 505)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(26, 26)
        Me.CheckBox1.TabIndex = 59
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
        Me.BtnPin.Location = New System.Drawing.Point(12, 505)
        Me.BtnPin.Name = "BtnPin"
        Me.BtnPin.Size = New System.Drawing.Size(26, 26)
        Me.BtnPin.TabIndex = 58
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
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.CausesValidation = False
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Khaki
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LemonChiffon
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("方正黑体_GBK", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Button2.Location = New System.Drawing.Point(285, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 26)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = "完成"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(-13, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(391, 502)
        Me.Panel1.TabIndex = 60
        '
        'FormAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(362, 543)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.BtnPin)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabAnalysis)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAnalysis"
        Me.Text = "Analysis"
        Me.TabAnalysis.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabAnalysis As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AnaLoadpngPercn As Label
    Friend WithEvents AnaLoadgifPercn As Label
    Friend WithEvents AnaLoadpngCount As Label
    Friend WithEvents AnaLoadjpgPercn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AnaLoadicoPercn As Label
    Friend WithEvents AnaLoadjpgCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AnaLoadgifCount As Label
    Friend WithEvents AnaLoadicoCount As Label
    Friend WithEvents AnaLoadbmpPercn As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents AnaLoadbmpCount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AnaFiltCount As Label
    Friend WithEvents AnaFiltPercn As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents AnaModifyTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AnaLoadCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents AnaCreateTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents AnaLoadtifCount As Label
    Friend WithEvents AnaLoadtifPercn As Label
    Friend WithEvents AnaLoadwebpCount As Label
    Friend WithEvents AnaLoadwebpPercn As Label
    Friend WithEvents AnaFilttifCount As Label
    Friend WithEvents AnaFilttifPercn As Label
    Friend WithEvents AnaFiltwebpCount As Label
    Friend WithEvents AnaFiltwebpPercn As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents AnaFiltbmpCount As Label
    Friend WithEvents AnaFiltbmpPercn As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents AnaFiltgifCount As Label
    Friend WithEvents AnaFiltgifPercn As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents AnaFilticoCount As Label
    Friend WithEvents AnaFilticoPercn As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents AnaFiltpngCount As Label
    Friend WithEvents AnaFiltjpgCount As Label
    Friend WithEvents AnaFiltpngPercn As Label
    Friend WithEvents AnaFiltjpgPercn As Label
    Friend WithEvents AnaLoadSizeAndTime As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents UiDoughnutChart1 As Sunny.UI.UIDoughnutChart
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label46 As Label
    Friend WithEvents UiComboBox1 As Sunny.UI.UIComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ImageDock As ImageList
    Friend WithEvents BtnPin As CheckBox
    Friend WithEvents ImagePin As ImageList
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
End Class
