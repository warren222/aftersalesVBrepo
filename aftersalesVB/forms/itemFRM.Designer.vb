<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.itemGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.wdwloc = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kno = New MetroFramework.Controls.MetroTextBox()
        Me.itemno = New MetroFramework.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.knogv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.netprice = New MetroFramework.Controls.MetroTextBox()
        Me.unitprice = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.totalamount = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.othercharges = New MetroFramework.Controls.MetroTextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ActualPrice = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.particular = New MetroFramework.Controls.MetroTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.itemGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'itemGRID
        '
        Me.itemGRID.AllowUserToAddRows = False
        Me.itemGRID.AllowUserToDeleteRows = False
        Me.itemGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.itemGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.itemGRID.ColumnHeadersHeight = 32
        Me.itemGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.itemGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.itemGRID.Location = New System.Drawing.Point(0, 0)
        Me.itemGRID.Name = "itemGRID"
        Me.itemGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.itemGRID.RowHeadersWidth = 30
        Me.itemGRID.RowTemplate.Height = 30
        Me.itemGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.itemGRID.Size = New System.Drawing.Size(404, 198)
        Me.itemGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.itemGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.itemGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.itemGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.itemGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.itemGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.itemGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.itemGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.itemGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.itemGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.itemGRID.TabIndex = 560
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.itemGRID)
        Me.Panel1.Location = New System.Drawing.Point(24, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 200)
        Me.Panel1.TabIndex = 571
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(437, 135)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshbtn.TabIndex = 578
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(435, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 577
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(24, 12)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(45, 20)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 580
        Me.KryptonLabel7.Values.Text = "K#(s)"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonLabel5)
        Me.Panel3.Controls.Add(Me.wdwloc)
        Me.Panel3.Controls.Add(Me.KryptonLabel8)
        Me.Panel3.Controls.Add(Me.KryptonLabel9)
        Me.Panel3.Controls.Add(Me.kno)
        Me.Panel3.Controls.Add(Me.itemno)
        Me.Panel3.Location = New System.Drawing.Point(23, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 81)
        Me.Panel3.TabIndex = 579
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(14, 26)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(28, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 508
        Me.KryptonLabel5.Values.Text = "K#"
        '
        'wdwloc
        '
        '
        '
        '
        Me.wdwloc.CustomButton.Image = Nothing
        Me.wdwloc.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.wdwloc.CustomButton.Name = ""
        Me.wdwloc.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.wdwloc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.wdwloc.CustomButton.TabIndex = 1
        Me.wdwloc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.wdwloc.CustomButton.UseSelectable = True
        Me.wdwloc.CustomButton.Visible = False
        Me.wdwloc.DisplayIcon = True
        Me.wdwloc.Lines = New String(-1) {}
        Me.wdwloc.Location = New System.Drawing.Point(331, 26)
        Me.wdwloc.MaxLength = 32767
        Me.wdwloc.Name = "wdwloc"
        Me.wdwloc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.wdwloc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.wdwloc.SelectedText = ""
        Me.wdwloc.SelectionLength = 0
        Me.wdwloc.SelectionStart = 0
        Me.wdwloc.ShowClearButton = True
        Me.wdwloc.Size = New System.Drawing.Size(194, 27)
        Me.wdwloc.Style = MetroFramework.MetroColorStyle.Teal
        Me.wdwloc.TabIndex = 511
        Me.wdwloc.UseCustomForeColor = True
        Me.wdwloc.UseSelectable = True
        Me.wdwloc.UseStyleColors = True
        Me.wdwloc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wdwloc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(262, 26)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 498
        Me.KryptonLabel8.Values.Text = "Location"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(144, 26)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 510
        Me.KryptonLabel9.Values.Text = "Item#"
        '
        'kno
        '
        '
        '
        '
        Me.kno.CustomButton.Image = Nothing
        Me.kno.CustomButton.Location = New System.Drawing.Point(64, 1)
        Me.kno.CustomButton.Name = ""
        Me.kno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.kno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.kno.CustomButton.TabIndex = 1
        Me.kno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.kno.CustomButton.UseSelectable = True
        Me.kno.CustomButton.Visible = False
        Me.kno.DisplayIcon = True
        Me.kno.Lines = New String(-1) {}
        Me.kno.Location = New System.Drawing.Point(48, 26)
        Me.kno.MaxLength = 32767
        Me.kno.Name = "kno"
        Me.kno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.kno.SelectedText = ""
        Me.kno.SelectionLength = 0
        Me.kno.SelectionStart = 0
        Me.kno.ShowClearButton = True
        Me.kno.Size = New System.Drawing.Size(90, 27)
        Me.kno.Style = MetroFramework.MetroColorStyle.Teal
        Me.kno.TabIndex = 507
        Me.kno.UseCustomForeColor = True
        Me.kno.UseSelectable = True
        Me.kno.UseStyleColors = True
        Me.kno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'itemno
        '
        '
        '
        '
        Me.itemno.CustomButton.Image = Nothing
        Me.itemno.CustomButton.Location = New System.Drawing.Point(32, 1)
        Me.itemno.CustomButton.Name = ""
        Me.itemno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.itemno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.itemno.CustomButton.TabIndex = 1
        Me.itemno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.itemno.CustomButton.UseSelectable = True
        Me.itemno.CustomButton.Visible = False
        Me.itemno.DisplayIcon = True
        Me.itemno.Lines = New String(-1) {}
        Me.itemno.Location = New System.Drawing.Point(198, 26)
        Me.itemno.MaxLength = 32767
        Me.itemno.Name = "itemno"
        Me.itemno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itemno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.itemno.SelectedText = ""
        Me.itemno.SelectionLength = 0
        Me.itemno.SelectionStart = 0
        Me.itemno.ShowClearButton = True
        Me.itemno.Size = New System.Drawing.Size(58, 27)
        Me.itemno.Style = MetroFramework.MetroColorStyle.Teal
        Me.itemno.TabIndex = 509
        Me.itemno.UseCustomForeColor = True
        Me.itemno.UseSelectable = True
        Me.itemno.UseStyleColors = True
        Me.itemno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.itemno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(1018, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 583
        Me.Button2.Text = "reload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.Location = New System.Drawing.Point(538, 12)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(256, 20)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 582
        Me.KryptonLabel2.Values.Text = "LIst of k#(s) from project (KMDI System)"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.knogv)
        Me.Panel2.Location = New System.Drawing.Point(537, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(475, 422)
        Me.Panel2.TabIndex = 581
        '
        'knogv
        '
        Me.knogv.AllowUserToAddRows = False
        Me.knogv.AllowUserToDeleteRows = False
        Me.knogv.AllowUserToOrderColumns = True
        Me.knogv.AllowUserToResizeColumns = False
        Me.knogv.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.knogv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
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
        Me.knogv.Size = New System.Drawing.Size(473, 420)
        Me.knogv.StateCommon.Background.Color1 = System.Drawing.Color.White
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
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(520, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 449)
        Me.Panel4.TabIndex = 584
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(435, 67)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 585
        Me.Button3.Text = "update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 58)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(89, 17)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 586
        Me.KryptonLabel1.Values.Text = "Total Net Price :"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(11, 29)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(91, 17)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 587
        Me.KryptonLabel3.Values.Text = "Total Unit Price :"
        '
        'netprice
        '
        '
        '
        '
        Me.netprice.CustomButton.Image = Nothing
        Me.netprice.CustomButton.Location = New System.Drawing.Point(89, 2)
        Me.netprice.CustomButton.Name = ""
        Me.netprice.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.netprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.netprice.CustomButton.TabIndex = 1
        Me.netprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.netprice.CustomButton.UseSelectable = True
        Me.netprice.CustomButton.Visible = False
        Me.netprice.DisplayIcon = True
        Me.netprice.Enabled = False
        Me.netprice.Lines = New String(-1) {}
        Me.netprice.Location = New System.Drawing.Point(105, 55)
        Me.netprice.MaxLength = 32767
        Me.netprice.Name = "netprice"
        Me.netprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.netprice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.netprice.SelectedText = ""
        Me.netprice.SelectionLength = 0
        Me.netprice.SelectionStart = 0
        Me.netprice.ShowClearButton = True
        Me.netprice.Size = New System.Drawing.Size(111, 24)
        Me.netprice.Style = MetroFramework.MetroColorStyle.Teal
        Me.netprice.TabIndex = 589
        Me.netprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.netprice.UseCustomForeColor = True
        Me.netprice.UseSelectable = True
        Me.netprice.UseStyleColors = True
        Me.netprice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.netprice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'unitprice
        '
        '
        '
        '
        Me.unitprice.CustomButton.Image = Nothing
        Me.unitprice.CustomButton.Location = New System.Drawing.Point(89, 2)
        Me.unitprice.CustomButton.Name = ""
        Me.unitprice.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.unitprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.unitprice.CustomButton.TabIndex = 1
        Me.unitprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.unitprice.CustomButton.UseSelectable = True
        Me.unitprice.CustomButton.Visible = False
        Me.unitprice.DisplayIcon = True
        Me.unitprice.Enabled = False
        Me.unitprice.Lines = New String(-1) {}
        Me.unitprice.Location = New System.Drawing.Point(105, 26)
        Me.unitprice.MaxLength = 32767
        Me.unitprice.Name = "unitprice"
        Me.unitprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unitprice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unitprice.SelectedText = ""
        Me.unitprice.SelectionLength = 0
        Me.unitprice.SelectionStart = 0
        Me.unitprice.ShowClearButton = True
        Me.unitprice.Size = New System.Drawing.Size(111, 24)
        Me.unitprice.Style = MetroFramework.MetroColorStyle.Teal
        Me.unitprice.TabIndex = 590
        Me.unitprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.unitprice.UseCustomForeColor = True
        Me.unitprice.UseSelectable = True
        Me.unitprice.UseStyleColors = True
        Me.unitprice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.unitprice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(11, 3)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(67, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 591
        Me.KryptonLabel4.Values.Text = "Summary"
        '
        'totalamount
        '
        '
        '
        '
        Me.totalamount.CustomButton.Image = Nothing
        Me.totalamount.CustomButton.Location = New System.Drawing.Point(89, 2)
        Me.totalamount.CustomButton.Name = ""
        Me.totalamount.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.totalamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.totalamount.CustomButton.TabIndex = 1
        Me.totalamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.totalamount.CustomButton.UseSelectable = True
        Me.totalamount.CustomButton.Visible = False
        Me.totalamount.DisplayIcon = True
        Me.totalamount.Enabled = False
        Me.totalamount.Lines = New String(-1) {}
        Me.totalamount.Location = New System.Drawing.Point(105, 85)
        Me.totalamount.MaxLength = 32767
        Me.totalamount.Name = "totalamount"
        Me.totalamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalamount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.totalamount.SelectedText = ""
        Me.totalamount.SelectionLength = 0
        Me.totalamount.SelectionStart = 0
        Me.totalamount.ShowClearButton = True
        Me.totalamount.Size = New System.Drawing.Size(111, 24)
        Me.totalamount.Style = MetroFramework.MetroColorStyle.Teal
        Me.totalamount.TabIndex = 594
        Me.totalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.totalamount.UseCustomForeColor = True
        Me.totalamount.UseSelectable = True
        Me.totalamount.UseStyleColors = True
        Me.totalamount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.totalamount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(260, 3)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(95, 17)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 593
        Me.KryptonLabel6.Values.Text = "+Other Charges :"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(11, 85)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(83, 17)
        Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 592
        Me.KryptonLabel10.Values.Text = "Total Amount :"
        '
        'othercharges
        '
        '
        '
        '
        Me.othercharges.CustomButton.Image = Nothing
        Me.othercharges.CustomButton.Location = New System.Drawing.Point(89, 2)
        Me.othercharges.CustomButton.Name = ""
        Me.othercharges.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.othercharges.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.othercharges.CustomButton.TabIndex = 1
        Me.othercharges.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.othercharges.CustomButton.UseSelectable = True
        Me.othercharges.CustomButton.Visible = False
        Me.othercharges.DisplayIcon = True
        Me.othercharges.Lines = New String(-1) {}
        Me.othercharges.Location = New System.Drawing.Point(260, 25)
        Me.othercharges.MaxLength = 32767
        Me.othercharges.Name = "othercharges"
        Me.othercharges.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.othercharges.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.othercharges.SelectedText = ""
        Me.othercharges.SelectionLength = 0
        Me.othercharges.SelectionStart = 0
        Me.othercharges.ShowClearButton = True
        Me.othercharges.Size = New System.Drawing.Size(111, 24)
        Me.othercharges.Style = MetroFramework.MetroColorStyle.Teal
        Me.othercharges.TabIndex = 595
        Me.othercharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.othercharges.UseCustomForeColor = True
        Me.othercharges.UseSelectable = True
        Me.othercharges.UseStyleColors = True
        Me.othercharges.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.othercharges.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Button5)
        Me.Panel5.Controls.Add(Me.ActualPrice)
        Me.Panel5.Controls.Add(Me.KryptonLabel12)
        Me.Panel5.Controls.Add(Me.KryptonLabel11)
        Me.Panel5.Controls.Add(Me.particular)
        Me.Panel5.Controls.Add(Me.Button4)
        Me.Panel5.Controls.Add(Me.KryptonLabel4)
        Me.Panel5.Controls.Add(Me.totalamount)
        Me.Panel5.Controls.Add(Me.unitprice)
        Me.Panel5.Controls.Add(Me.KryptonLabel6)
        Me.Panel5.Controls.Add(Me.KryptonLabel1)
        Me.Panel5.Controls.Add(Me.KryptonLabel10)
        Me.Panel5.Controls.Add(Me.KryptonLabel3)
        Me.Panel5.Controls.Add(Me.othercharges)
        Me.Panel5.Controls.Add(Me.netprice)
        Me.Panel5.Location = New System.Drawing.Point(25, 340)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(405, 119)
        Me.Panel5.TabIndex = 596
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(222, 86)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 23)
        Me.Button5.TabIndex = 601
        Me.Button5.Text = "="
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ActualPrice
        '
        '
        '
        '
        Me.ActualPrice.CustomButton.Image = Nothing
        Me.ActualPrice.CustomButton.Location = New System.Drawing.Point(89, 2)
        Me.ActualPrice.CustomButton.Name = ""
        Me.ActualPrice.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.ActualPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.ActualPrice.CustomButton.TabIndex = 1
        Me.ActualPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.ActualPrice.CustomButton.UseSelectable = True
        Me.ActualPrice.CustomButton.Visible = False
        Me.ActualPrice.DisplayIcon = True
        Me.ActualPrice.Lines = New String() {"0"}
        Me.ActualPrice.Location = New System.Drawing.Point(260, 86)
        Me.ActualPrice.MaxLength = 32767
        Me.ActualPrice.Name = "ActualPrice"
        Me.ActualPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ActualPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.ActualPrice.SelectedText = ""
        Me.ActualPrice.SelectionLength = 0
        Me.ActualPrice.SelectionStart = 0
        Me.ActualPrice.ShowClearButton = True
        Me.ActualPrice.Size = New System.Drawing.Size(111, 24)
        Me.ActualPrice.Style = MetroFramework.MetroColorStyle.Teal
        Me.ActualPrice.TabIndex = 600
        Me.ActualPrice.Text = "0"
        Me.ActualPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ActualPrice.UseCustomForeColor = True
        Me.ActualPrice.UseSelectable = True
        Me.ActualPrice.UseStyleColors = True
        Me.ActualPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ActualPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(260, 63)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(74, 17)
        Me.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 599
        Me.KryptonLabel12.Values.Text = "Actual Price :"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(377, 3)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(68, 17)
        Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 597
        Me.KryptonLabel11.Values.Text = "Particulars :"
        '
        'particular
        '
        '
        '
        '
        Me.particular.CustomButton.Image = Nothing
        Me.particular.CustomButton.Location = New System.Drawing.Point(201, 2)
        Me.particular.CustomButton.Name = ""
        Me.particular.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.particular.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.particular.CustomButton.TabIndex = 1
        Me.particular.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.particular.CustomButton.UseSelectable = True
        Me.particular.CustomButton.Visible = False
        Me.particular.DisplayIcon = True
        Me.particular.Lines = New String(-1) {}
        Me.particular.Location = New System.Drawing.Point(377, 25)
        Me.particular.MaxLength = 32767
        Me.particular.Name = "particular"
        Me.particular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.particular.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.particular.SelectedText = ""
        Me.particular.SelectionLength = 0
        Me.particular.SelectionStart = 0
        Me.particular.ShowClearButton = True
        Me.particular.Size = New System.Drawing.Size(223, 24)
        Me.particular.Style = MetroFramework.MetroColorStyle.Teal
        Me.particular.TabIndex = 598
        Me.particular.UseCustomForeColor = True
        Me.particular.UseSelectable = True
        Me.particular.UseStyleColors = True
        Me.particular.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.particular.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(525, 86)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 596
        Me.Button4.Text = "save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'itemFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 471)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.KryptonLabel7)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "itemFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.itemGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents wdwloc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents itemno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents knogv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents netprice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unitprice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents totalamount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents othercharges As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents particular As MetroFramework.Controls.MetroTextBox
    Friend WithEvents ActualPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Button5 As Button
End Class
