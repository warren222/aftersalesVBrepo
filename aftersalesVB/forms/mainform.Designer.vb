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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.toprows = New MetroFramework.Controls.MetroComboBox()
        CType(Me.callinGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'newPNL
        '
        Me.newPNL.ActiveControl = Nothing
        Me.newPNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.newPNL.Location = New System.Drawing.Point(13, 5)
        Me.newPNL.Name = "newPNL"
        Me.newPNL.Size = New System.Drawing.Size(107, 71)
        Me.newPNL.Style = MetroFramework.MetroColorStyle.Green
        Me.newPNL.TabIndex = 467
        Me.newPNL.Text = "New"
        Me.newPNL.TileImage = CType(resources.GetObject("newPNL.TileImage"), System.Drawing.Image)
        Me.newPNL.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.newPNL.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.newPNL.UseSelectable = True
        Me.newPNL.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile1.Location = New System.Drawing.Point(13, 82)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroTile1.TabIndex = 468
        Me.MetroTile1.Text = "Accessories"
        Me.MetroTile1.TileImage = CType(resources.GetObject("MetroTile1.TileImage"), System.Drawing.Image)
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.MetroTile2.Location = New System.Drawing.Point(13, 159)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroTile2.TabIndex = 469
        Me.MetroTile2.Text = "Concern"
        Me.MetroTile2.TileImage = CType(resources.GetObject("MetroTile2.TileImage"), System.Drawing.Image)
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'searchtext
        '
        Me.searchtext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.searchtext.CustomButton.Image = Nothing
        Me.searchtext.CustomButton.Location = New System.Drawing.Point(352, 1)
        Me.searchtext.CustomButton.Name = ""
        Me.searchtext.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.searchtext.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.searchtext.CustomButton.TabIndex = 1
        Me.searchtext.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.searchtext.CustomButton.UseSelectable = True
        Me.searchtext.DisplayIcon = True
        Me.searchtext.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.searchtext.Lines = New String(-1) {}
        Me.searchtext.Location = New System.Drawing.Point(442, 20)
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
        Me.searchtext.WaterMark = "Concern"
        Me.searchtext.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.searchtext.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'fieldcombo
        '
        Me.fieldcombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fieldcombo.FormattingEnabled = True
        Me.fieldcombo.ItemHeight = 23
        Me.fieldcombo.Items.AddRange(New Object() {"PROJECT", "ADDRESS", "CALLER", "DATE", "JOB ORDER NO", "CIN"})
        Me.fieldcombo.Location = New System.Drawing.Point(284, 20)
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
        Me.reloadBTN.Location = New System.Drawing.Point(828, 20)
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
        Me.callinGRID.Size = New System.Drawing.Size(904, 340)
        Me.callinGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.callinGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.callinGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.callinGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.callinGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.callinGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
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
        Me.MetroTile3.Location = New System.Drawing.Point(13, 236)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTile3.TabIndex = 556
        Me.MetroTile3.Text = "Personnel"
        Me.MetroTile3.TileImage = CType(resources.GetObject("MetroTile3.TileImage"), System.Drawing.Image)
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.newPNL)
        Me.Panel1.Controls.Add(Me.MetroTile3)
        Me.Panel1.Controls.Add(Me.MetroTile1)
        Me.Panel1.Controls.Add(Me.MetroTile2)
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 410)
        Me.Panel1.TabIndex = 557
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.callinGRID)
        Me.Panel2.Location = New System.Drawing.Point(144, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(910, 419)
        Me.Panel2.TabIndex = 558
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.toprows)
        Me.Panel3.Controls.Add(Me.reloadBTN)
        Me.Panel3.Controls.Add(Me.searchtext)
        Me.Panel3.Controls.Add(Me.fieldcombo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(910, 69)
        Me.Panel3.TabIndex = 559
        '
        'toprows
        '
        Me.toprows.FormattingEnabled = True
        Me.toprows.ItemHeight = 23
        Me.toprows.Items.AddRange(New Object() {"100", "1,000", "5,000", "10,000", "50,000", "100,000", "500,000", "1,000,000", "1,500,000", "2,000,000"})
        Me.toprows.Location = New System.Drawing.Point(12, 20)
        Me.toprows.Name = "toprows"
        Me.toprows.Size = New System.Drawing.Size(102, 29)
        Me.toprows.TabIndex = 839
        Me.toprows.UseSelectable = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 484)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "mainform"
        Me.Text = "After Sales"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.callinGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

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
End Class
