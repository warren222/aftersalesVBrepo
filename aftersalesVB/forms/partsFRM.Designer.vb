<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class partsFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.partsGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.knogv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.netamount = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.qty = New MetroFramework.Controls.MetroTextBox()
        Me.markup = New MetroFramework.Controls.MetroTextBox()
        Me.unitprice = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.description = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.articleno = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel13 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'partsGRID
        '
        Me.partsGRID.AllowUserToAddRows = False
        Me.partsGRID.AllowUserToDeleteRows = False
        Me.partsGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.partsGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.partsGRID.ColumnHeadersHeight = 32
        Me.partsGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.partsGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partsGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.partsGRID.Location = New System.Drawing.Point(0, 0)
        Me.partsGRID.Name = "partsGRID"
        Me.partsGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.partsGRID.RowHeadersWidth = 30
        Me.partsGRID.RowTemplate.Height = 30
        Me.partsGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.partsGRID.Size = New System.Drawing.Size(529, 205)
        Me.partsGRID.StateCommon.Background.Color1 = System.Drawing.Color.DarkGray
        Me.partsGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.partsGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.partsGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.partsGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.partsGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.partsGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.partsGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.partsGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.partsGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.partsGRID.TabIndex = 561
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.partsGRID)
        Me.Panel1.Location = New System.Drawing.Point(24, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(531, 207)
        Me.Panel1.TabIndex = 571
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.Location = New System.Drawing.Point(653, 192)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 585
        Me.KryptonLabel2.Values.Text = "Price List"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.knogv)
        Me.Panel2.Location = New System.Drawing.Point(652, 217)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 274)
        Me.Panel2.TabIndex = 584
        '
        'knogv
        '
        Me.knogv.AllowUserToAddRows = False
        Me.knogv.AllowUserToDeleteRows = False
        Me.knogv.AllowUserToOrderColumns = True
        Me.knogv.AllowUserToResizeColumns = False
        Me.knogv.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.knogv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.knogv.ColumnHeadersHeight = 30
        Me.knogv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.knogv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.knogv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.knogv.Location = New System.Drawing.Point(0, 0)
        Me.knogv.MultiSelect = False
        Me.knogv.Name = "knogv"
        Me.knogv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.knogv.ReadOnly = True
        Me.knogv.RowHeadersWidth = 40
        Me.knogv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.knogv.RowTemplate.Height = 27
        Me.knogv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.knogv.Size = New System.Drawing.Size(473, 272)
        Me.knogv.StateCommon.Background.Color1 = System.Drawing.Color.DarkGray
        Me.knogv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.knogv.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.knogv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.knogv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.knogv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.knogv.StateCommon.HeaderColumn.Border.Width = 0
        Me.knogv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.knogv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knogv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.knogv.TabIndex = 499
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Controls.Add(Me.netamount)
        Me.Panel3.Controls.Add(Me.KryptonLabel6)
        Me.Panel3.Controls.Add(Me.qty)
        Me.Panel3.Controls.Add(Me.markup)
        Me.Panel3.Controls.Add(Me.unitprice)
        Me.Panel3.Controls.Add(Me.KryptonLabel4)
        Me.Panel3.Controls.Add(Me.KryptonLabel5)
        Me.Panel3.Controls.Add(Me.description)
        Me.Panel3.Controls.Add(Me.KryptonLabel7)
        Me.Panel3.Controls.Add(Me.KryptonLabel8)
        Me.Panel3.Controls.Add(Me.articleno)
        Me.Panel3.Location = New System.Drawing.Point(24, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(531, 171)
        Me.Panel3.TabIndex = 587
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(31, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 518
        Me.KryptonLabel3.Values.Text = "Article no"
        '
        'netamount
        '
        '
        '
        '
        Me.netamount.CustomButton.Image = Nothing
        Me.netamount.CustomButton.Location = New System.Drawing.Point(90, 1)
        Me.netamount.CustomButton.Name = ""
        Me.netamount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.netamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.netamount.CustomButton.TabIndex = 1
        Me.netamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.netamount.CustomButton.UseSelectable = True
        Me.netamount.CustomButton.Visible = False
        Me.netamount.DisplayIcon = True
        Me.netamount.Enabled = False
        Me.netamount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.netamount.Lines = New String(-1) {}
        Me.netamount.Location = New System.Drawing.Point(381, 119)
        Me.netamount.MaxLength = 32767
        Me.netamount.Multiline = True
        Me.netamount.Name = "netamount"
        Me.netamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.netamount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.netamount.SelectedText = ""
        Me.netamount.SelectionLength = 0
        Me.netamount.SelectionStart = 0
        Me.netamount.ShowClearButton = True
        Me.netamount.Size = New System.Drawing.Size(116, 27)
        Me.netamount.Style = MetroFramework.MetroColorStyle.Teal
        Me.netamount.TabIndex = 6
        Me.netamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.netamount.UseCustomForeColor = True
        Me.netamount.UseSelectable = True
        Me.netamount.UseStyleColors = True
        Me.netamount.WaterMark = "Net Amount"
        Me.netamount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.netamount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(31, 78)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(78, 20)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 522
        Me.KryptonLabel6.Values.Text = "Markup(%)"
        '
        'qty
        '
        '
        '
        '
        Me.qty.CustomButton.Image = Nothing
        Me.qty.CustomButton.Location = New System.Drawing.Point(48, 1)
        Me.qty.CustomButton.Name = ""
        Me.qty.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.qty.CustomButton.TabIndex = 1
        Me.qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.qty.CustomButton.UseSelectable = True
        Me.qty.CustomButton.Visible = False
        Me.qty.DisplayIcon = True
        Me.qty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.qty.Lines = New String(-1) {}
        Me.qty.Location = New System.Drawing.Point(423, 76)
        Me.qty.MaxLength = 32767
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.qty.SelectedText = ""
        Me.qty.SelectionLength = 0
        Me.qty.SelectionStart = 0
        Me.qty.ShowClearButton = True
        Me.qty.Size = New System.Drawing.Size(74, 27)
        Me.qty.Style = MetroFramework.MetroColorStyle.Teal
        Me.qty.TabIndex = 5
        Me.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.qty.UseCustomForeColor = True
        Me.qty.UseSelectable = True
        Me.qty.UseStyleColors = True
        Me.qty.WaterMark = "Quantity"
        Me.qty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.qty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'markup
        '
        '
        '
        '
        Me.markup.CustomButton.Image = Nothing
        Me.markup.CustomButton.Location = New System.Drawing.Point(48, 1)
        Me.markup.CustomButton.Name = ""
        Me.markup.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.markup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.markup.CustomButton.TabIndex = 1
        Me.markup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.markup.CustomButton.UseSelectable = True
        Me.markup.CustomButton.Visible = False
        Me.markup.DisplayIcon = True
        Me.markup.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.markup.Lines = New String() {"30"}
        Me.markup.Location = New System.Drawing.Point(181, 77)
        Me.markup.MaxLength = 32767
        Me.markup.Multiline = True
        Me.markup.Name = "markup"
        Me.markup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.markup.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.markup.SelectedText = ""
        Me.markup.SelectionLength = 0
        Me.markup.SelectionStart = 0
        Me.markup.ShowClearButton = True
        Me.markup.Size = New System.Drawing.Size(74, 27)
        Me.markup.Style = MetroFramework.MetroColorStyle.Teal
        Me.markup.TabIndex = 3
        Me.markup.Text = "30"
        Me.markup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.markup.UseCustomForeColor = True
        Me.markup.UseSelectable = True
        Me.markup.UseStyleColors = True
        Me.markup.WaterMark = "Markup"
        Me.markup.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.markup.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'unitprice
        '
        '
        '
        '
        Me.unitprice.CustomButton.Image = Nothing
        Me.unitprice.CustomButton.Location = New System.Drawing.Point(116, 1)
        Me.unitprice.CustomButton.Name = ""
        Me.unitprice.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.unitprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.unitprice.CustomButton.TabIndex = 1
        Me.unitprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.unitprice.CustomButton.UseSelectable = True
        Me.unitprice.CustomButton.Visible = False
        Me.unitprice.DisplayIcon = True
        Me.unitprice.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.unitprice.Lines = New String(-1) {}
        Me.unitprice.Location = New System.Drawing.Point(113, 112)
        Me.unitprice.MaxLength = 32767
        Me.unitprice.Multiline = True
        Me.unitprice.Name = "unitprice"
        Me.unitprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unitprice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unitprice.SelectedText = ""
        Me.unitprice.SelectionLength = 0
        Me.unitprice.SelectionStart = 0
        Me.unitprice.ShowClearButton = True
        Me.unitprice.Size = New System.Drawing.Size(142, 27)
        Me.unitprice.Style = MetroFramework.MetroColorStyle.Teal
        Me.unitprice.TabIndex = 4
        Me.unitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.unitprice.UseCustomForeColor = True
        Me.unitprice.UseSelectable = True
        Me.unitprice.UseStyleColors = True
        Me.unitprice.WaterMark = "Unit Price"
        Me.unitprice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.unitprice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(145, 12)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 520
        Me.KryptonLabel4.Values.Text = "Description"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(333, 78)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 513
        Me.KryptonLabel5.Values.Text = "Qty:"
        '
        'description
        '
        '
        '
        '
        Me.description.CustomButton.Image = Nothing
        Me.description.CustomButton.Location = New System.Drawing.Point(326, 1)
        Me.description.CustomButton.Name = ""
        Me.description.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.description.CustomButton.TabIndex = 1
        Me.description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.description.CustomButton.UseSelectable = True
        Me.description.CustomButton.Visible = False
        Me.description.DisplayIcon = True
        Me.description.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.description.Lines = New String(-1) {}
        Me.description.Location = New System.Drawing.Point(145, 38)
        Me.description.MaxLength = 32767
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.description.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.description.SelectedText = ""
        Me.description.SelectionLength = 0
        Me.description.SelectionStart = 0
        Me.description.ShowClearButton = True
        Me.description.Size = New System.Drawing.Size(352, 27)
        Me.description.Style = MetroFramework.MetroColorStyle.Teal
        Me.description.TabIndex = 2
        Me.description.UseCustomForeColor = True
        Me.description.UseSelectable = True
        Me.description.UseStyleColors = True
        Me.description.WaterMark = "Description"
        Me.description.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.description.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(283, 119)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(86, 20)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 514
        Me.KryptonLabel7.Values.Text = "Net Amount:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(31, 112)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(72, 20)
        Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 515
        Me.KryptonLabel8.Values.Text = "Unit Price:"
        '
        'articleno
        '
        '
        '
        '
        Me.articleno.CustomButton.Image = Nothing
        Me.articleno.CustomButton.Location = New System.Drawing.Point(82, 1)
        Me.articleno.CustomButton.Name = ""
        Me.articleno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.articleno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.articleno.CustomButton.TabIndex = 1
        Me.articleno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.articleno.CustomButton.UseSelectable = True
        Me.articleno.CustomButton.Visible = False
        Me.articleno.DisplayIcon = True
        Me.articleno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.articleno.Lines = New String(-1) {}
        Me.articleno.Location = New System.Drawing.Point(31, 38)
        Me.articleno.MaxLength = 32767
        Me.articleno.Multiline = True
        Me.articleno.Name = "articleno"
        Me.articleno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.articleno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.articleno.SelectedText = ""
        Me.articleno.SelectionLength = 0
        Me.articleno.SelectionStart = 0
        Me.articleno.ShowClearButton = True
        Me.articleno.Size = New System.Drawing.Size(108, 27)
        Me.articleno.Style = MetroFramework.MetroColorStyle.Teal
        Me.articleno.TabIndex = 1
        Me.articleno.UseCustomForeColor = True
        Me.articleno.UseSelectable = True
        Me.articleno.UseStyleColors = True
        Me.articleno.WaterMark = "Article no"
        Me.articleno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.articleno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(24, 258)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(195, 20)
        Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 588
        Me.KryptonLabel9.Values.Text = "Manage Accessories / Materials"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(561, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 589
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(561, 285)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshbtn.TabIndex = 590
        Me.refreshbtn.Text = "reload"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(643, 38)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 449)
        Me.Panel4.TabIndex = 591
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.LightGray
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.KryptonLabel1)
        Me.Panel6.Controls.Add(Me.KryptonLabel10)
        Me.Panel6.Controls.Add(Me.specification)
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Controls.Add(Me.KryptonLabel11)
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Location = New System.Drawing.Point(653, 64)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(474, 113)
        Me.Panel6.TabIndex = 593
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(33, 11)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 523
        Me.KryptonLabel1.Values.Text = "Specification"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel10.Location = New System.Drawing.Point(33, 43)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 521
        Me.KryptonLabel10.Values.Text = "Article no"
        '
        'specification
        '
        Me.specification.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.Location = New System.Drawing.Point(124, 11)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(327, 26)
        Me.specification.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(124, 43)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(327, 26)
        Me.ComboBox2.TabIndex = 1
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel11.Location = New System.Drawing.Point(33, 75)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 522
        Me.KryptonLabel11.Values.Text = "Description"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(124, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(327, 26)
        Me.ComboBox1.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(1132, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 594
        Me.Button3.Text = "Find"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(561, 94)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 595
        Me.Button4.Text = "update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel12.Location = New System.Drawing.Point(653, 38)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 596
        Me.KryptonLabel12.Values.Text = "Search Key"
        '
        'KryptonLabel13
        '
        Me.KryptonLabel13.Location = New System.Drawing.Point(25, 27)
        Me.KryptonLabel13.Name = "KryptonLabel13"
        Me.KryptonLabel13.Size = New System.Drawing.Size(46, 20)
        Me.KryptonLabel13.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel13.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel13.TabIndex = 597
        Me.KryptonLabel13.Values.Text = "TITLE"
        '
        'partsFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1220, 515)
        Me.Controls.Add(Me.KryptonLabel13)
        Me.Controls.Add(Me.KryptonLabel12)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KryptonLabel9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "partsFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents partsGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents knogv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents netamount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents qty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents markup As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unitprice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents description As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents articleno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents specification As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel13 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
