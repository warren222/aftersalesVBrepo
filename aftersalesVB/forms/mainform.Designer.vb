<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.callinGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.newPNL = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        CType(Me.callinGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'callinGRID
        '
        Me.callinGRID.AllowUserToAddRows = False
        Me.callinGRID.AllowUserToDeleteRows = False
        Me.callinGRID.AllowUserToOrderColumns = True
        Me.callinGRID.AllowUserToResizeColumns = False
        Me.callinGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.callinGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.callinGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.callinGRID.ColumnHeadersHeight = 30
        Me.callinGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.callinGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.callinGRID.Location = New System.Drawing.Point(180, 42)
        Me.callinGRID.MultiSelect = False
        Me.callinGRID.Name = "callinGRID"
        Me.callinGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.callinGRID.ReadOnly = True
        Me.callinGRID.RowHeadersWidth = 40
        Me.callinGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.callinGRID.RowTemplate.Height = 27
        Me.callinGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.callinGRID.Size = New System.Drawing.Size(573, 419)
        Me.callinGRID.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke
        Me.callinGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.callinGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.callinGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.callinGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.callinGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.callinGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.callinGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.callinGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.callinGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.callinGRID.TabIndex = 466
        '
        'newPNL
        '
        Me.newPNL.ActiveControl = Nothing
        Me.newPNL.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.newPNL.Location = New System.Drawing.Point(23, 103)
        Me.newPNL.Name = "newPNL"
        Me.newPNL.Size = New System.Drawing.Size(107, 71)
        Me.newPNL.Style = MetroFramework.MetroColorStyle.Lime
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
        Me.MetroTile1.Location = New System.Drawing.Point(23, 180)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile1.TabIndex = 468
        Me.MetroTile1.Text = "Edit"
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
        Me.MetroTile2.Location = New System.Drawing.Point(23, 257)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(107, 71)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroTile2.TabIndex = 469
        Me.MetroTile2.Text = "Q and A"
        Me.MetroTile2.TileImage = CType(resources.GetObject("MetroTile2.TileImage"), System.Drawing.Image)
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseTileImage = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 484)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.newPNL)
        Me.Controls.Add(Me.callinGRID)
        Me.Name = "mainform"
        Me.Text = "Form1"
        CType(Me.callinGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents callinGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents newPNL As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
End Class
