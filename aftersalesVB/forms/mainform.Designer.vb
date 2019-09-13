<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.newPNL = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.searchtext = New MetroFramework.Controls.MetroTextBox()
        Me.fieldcombo = New MetroFramework.Controls.MetroComboBox()
        Me.reloadBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.callinGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroTile6 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile4 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroToggle1 = New MetroFramework.Controls.MetroToggle()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.toprows = New MetroFramework.Controls.MetroComboBox()
        Me.donecheckbox = New MetroFramework.Controls.MetroToggle()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.mymenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.callinGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.mymenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'newPNL
        '
        Me.newPNL.ActiveControl = Nothing
        Me.newPNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.newPNL.Location = New System.Drawing.Point(10, 5)
        Me.newPNL.Name = "newPNL"
        Me.newPNL.Size = New System.Drawing.Size(107, 71)
        Me.newPNL.Style = MetroFramework.MetroColorStyle.Green
        Me.newPNL.TabIndex = 467
        Me.newPNL.Text = "New"
        Me.newPNL.TileImage = CType(resources.GetObject("newPNL.TileImage"), System.Drawing.Image)
        Me.newPNL.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newPNL.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.newPNL.UseSelectable = True
        Me.newPNL.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile1.Location = New System.Drawing.Point(10, 82)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile1.TabIndex = 468
        Me.MetroTile1.Text = "Accessories"
        Me.MetroTile1.TileImage = CType(resources.GetObject("MetroTile1.TileImage"), System.Drawing.Image)
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile2.Location = New System.Drawing.Point(10, 490)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile2.TabIndex = 469
        Me.MetroTile2.Text = "Concern"
        Me.MetroTile2.TileImage = CType(resources.GetObject("MetroTile2.TileImage"), System.Drawing.Image)
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        Me.MetroTile2.Visible = False
        '
        'searchtext
        '
        Me.searchtext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.searchtext.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.searchtext.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.searchtext.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.searchtext.CustomButton.Location = New System.Drawing.Point(352, 1)
        Me.searchtext.CustomButton.Name = ""
        Me.searchtext.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.searchtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchtext.CustomButton.TabIndex = 1
        Me.searchtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchtext.CustomButton.UseSelectable = True
        Me.searchtext.CustomButton.UseVisualStyleBackColor = False
        Me.searchtext.DisplayIcon = True
        Me.searchtext.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.searchtext.Lines = New String(-1) {}
        Me.searchtext.Location = New System.Drawing.Point(459, 20)
        Me.searchtext.MaxLength = 32767
        Me.searchtext.Name = "searchtext"
        Me.searchtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchtext.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.searchtext.SelectedText = ""
        Me.searchtext.SelectionLength = 0
        Me.searchtext.SelectionStart = 0
        Me.searchtext.ShowButton = True
        Me.searchtext.ShowClearButton = True
        Me.searchtext.Size = New System.Drawing.Size(380, 29)
        Me.searchtext.Style = MetroFramework.MetroColorStyle.Red
        Me.searchtext.TabIndex = 472
        Me.searchtext.UseCustomForeColor = True
        Me.searchtext.UseSelectable = True
        Me.searchtext.WaterMark = "Search"
        Me.searchtext.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchtext.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'fieldcombo
        '
        Me.fieldcombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fieldcombo.FormattingEnabled = True
        Me.fieldcombo.ItemHeight = 23
        Me.fieldcombo.Items.AddRange(New Object() {"All", "PROJECT", "ADDRESS", "CALLER", "DATE", "JOB ORDER NO", "CIN"})
        Me.fieldcombo.Location = New System.Drawing.Point(301, 20)
        Me.fieldcombo.Name = "fieldcombo"
        Me.fieldcombo.Size = New System.Drawing.Size(152, 29)
        Me.fieldcombo.TabIndex = 473
        Me.fieldcombo.UseSelectable = True
        '
        'reloadBTN
        '
        Me.reloadBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reloadBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reloadBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reloadBTN.Image = Nothing
        Me.reloadBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.reloadBTN.Location = New System.Drawing.Point(845, 20)
        Me.reloadBTN.Name = "reloadBTN"
        Me.reloadBTN.Size = New System.Drawing.Size(68, 29)
        Me.reloadBTN.Style = MetroFramework.MetroColorStyle.Yellow
        Me.reloadBTN.TabIndex = 481
        Me.reloadBTN.Text = "reload"
        Me.reloadBTN.UseCustomForeColor = True
        Me.reloadBTN.UseSelectable = True
        Me.reloadBTN.UseVisualStyleBackColor = True
        '
        'callinGRID
        '
        Me.callinGRID.AllowUserToAddRows = False
        Me.callinGRID.AllowUserToDeleteRows = False
        Me.callinGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.callinGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.callinGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.callinGRID.ColumnHeadersHeight = 32
        Me.callinGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.callinGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.callinGRID.Location = New System.Drawing.Point(3, 70)
        Me.callinGRID.Name = "callinGRID"
        Me.callinGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.callinGRID.RowHeadersWidth = 30
        Me.callinGRID.RowTemplate.Height = 30
        Me.callinGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.callinGRID.Size = New System.Drawing.Size(921, 490)
        Me.callinGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.callinGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.callinGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.callinGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.callinGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.callinGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.callinGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.callinGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.callinGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.callinGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.callinGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.callinGRID.TabIndex = 555
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile3.Location = New System.Drawing.Point(10, 236)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTile3.TabIndex = 556
        Me.MetroTile3.Text = "Personnel"
        Me.MetroTile3.TileImage = CType(resources.GetObject("MetroTile3.TileImage"), System.Drawing.Image)
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MetroTile6)
        Me.Panel1.Controls.Add(Me.MetroTile4)
        Me.Panel1.Controls.Add(Me.MetroTile5)
        Me.Panel1.Controls.Add(Me.newPNL)
        Me.Panel1.Controls.Add(Me.MetroTile3)
        Me.Panel1.Controls.Add(Me.MetroTile1)
        Me.Panel1.Controls.Add(Me.MetroTile2)
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(126, 561)
        Me.Panel1.TabIndex = 557
        '
        'MetroTile6
        '
        Me.MetroTile6.ActiveControl = Nothing
        Me.MetroTile6.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile6.Location = New System.Drawing.Point(10, 390)
        Me.MetroTile6.Name = "MetroTile6"
        Me.MetroTile6.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile6.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile6.TabIndex = 560
        Me.MetroTile6.Text = "Windows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Doors"
        Me.MetroTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile6.UseSelectable = True
        Me.MetroTile6.UseTileImage = True
        '
        'MetroTile4
        '
        Me.MetroTile4.ActiveControl = Nothing
        Me.MetroTile4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile4.Location = New System.Drawing.Point(10, 313)
        Me.MetroTile4.Name = "MetroTile4"
        Me.MetroTile4.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile4.Style = MetroFramework.MetroColorStyle.Brown
        Me.MetroTile4.TabIndex = 559
        Me.MetroTile4.Text = "Schedule"
        Me.MetroTile4.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile4.UseSelectable = True
        Me.MetroTile4.UseTileImage = True
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile5.Location = New System.Drawing.Point(10, 159)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Black
        Me.MetroTile5.TabIndex = 558
        Me.MetroTile5.Text = "Assessment"
        Me.MetroTile5.TileImage = CType(resources.GetObject("MetroTile5.TileImage"), System.Drawing.Image)
        Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.callinGRID)
        Me.Panel2.Location = New System.Drawing.Point(132, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(927, 569)
        Me.Panel2.TabIndex = 558
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Controls.Add(Me.MetroToggle1)
        Me.Panel3.Controls.Add(Me.KryptonLabel1)
        Me.Panel3.Controls.Add(Me.toprows)
        Me.Panel3.Controls.Add(Me.donecheckbox)
        Me.Panel3.Controls.Add(Me.reloadBTN)
        Me.Panel3.Controls.Add(Me.searchtext)
        Me.Panel3.Controls.Add(Me.fieldcombo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(927, 69)
        Me.Panel3.TabIndex = 559
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(10, 35)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(33, 18)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 843
        Me.KryptonLabel3.Values.Text = "Dark"
        '
        'MetroToggle1
        '
        Me.MetroToggle1.AutoSize = True
        Me.MetroToggle1.Location = New System.Drawing.Point(53, 36)
        Me.MetroToggle1.Name = "MetroToggle1"
        Me.MetroToggle1.Size = New System.Drawing.Size(80, 17)
        Me.MetroToggle1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroToggle1.TabIndex = 842
        Me.MetroToggle1.Tag = ""
        Me.MetroToggle1.Text = "Off"
        Me.MetroToggle1.UseSelectable = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(10, 12)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(36, 18)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 841
        Me.KryptonLabel1.Values.Text = "Done"
        '
        'toprows
        '
        Me.toprows.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toprows.FormattingEnabled = True
        Me.toprows.ItemHeight = 23
        Me.toprows.Items.AddRange(New Object() {"100", "1,000", "5,000", "10,000", "50,000", "100,000", "500,000", "1,000,000", "1,500,000", "2,000,000", "MAX"})
        Me.toprows.Location = New System.Drawing.Point(173, 20)
        Me.toprows.Name = "toprows"
        Me.toprows.Size = New System.Drawing.Size(122, 29)
        Me.toprows.TabIndex = 839
        Me.toprows.UseSelectable = True
        '
        'donecheckbox
        '
        Me.donecheckbox.AutoSize = True
        Me.donecheckbox.Checked = True
        Me.donecheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.donecheckbox.Location = New System.Drawing.Point(52, 12)
        Me.donecheckbox.Name = "donecheckbox"
        Me.donecheckbox.Size = New System.Drawing.Size(80, 17)
        Me.donecheckbox.Style = MetroFramework.MetroColorStyle.Red
        Me.donecheckbox.TabIndex = 840
        Me.donecheckbox.Tag = ""
        Me.donecheckbox.Text = "On"
        Me.donecheckbox.UseSelectable = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(13, 20)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(148, 35)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 842
        Me.KryptonLabel2.Values.Text = "AFTER SALES"
        '
        'mymenu
        '
        Me.mymenu.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.mymenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ServicingToolStripMenuItem, Me.QuotationToolStripMenuItem, Me.EditAddressToolStripMenuItem})
        Me.mymenu.Name = "mymenu"
        Me.mymenu.Size = New System.Drawing.Size(140, 92)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ServicingToolStripMenuItem
        '
        Me.ServicingToolStripMenuItem.Name = "ServicingToolStripMenuItem"
        Me.ServicingToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ServicingToolStripMenuItem.Text = "Servicing"
        '
        'QuotationToolStripMenuItem
        '
        Me.QuotationToolStripMenuItem.Name = "QuotationToolStripMenuItem"
        Me.QuotationToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.QuotationToolStripMenuItem.Text = "Quotation"
        '
        'EditAddressToolStripMenuItem
        '
        Me.EditAddressToolStripMenuItem.Name = "EditAddressToolStripMenuItem"
        Me.EditAddressToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EditAddressToolStripMenuItem.Text = "Edit Address"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 634)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "mainform"
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.callinGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.mymenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newPNL As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents searchtext As MetroFramework.Controls.MetroTextBox
    Friend WithEvents fieldcombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents reloadBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents callinGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents toprows As MetroFramework.Controls.MetroComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents donecheckbox As MetroFramework.Controls.MetroToggle
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroToggle1 As MetroFramework.Controls.MetroToggle
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile4 As MetroFramework.Controls.MetroTile
    Friend WithEvents mymenu As ContextMenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServicingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuotationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditAddressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetroTile6 As MetroFramework.Controls.MetroTile
End Class
