<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class importpartsFRM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.partsGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.description = New System.Windows.Forms.ComboBox()
        Me.articleno = New System.Windows.Forms.ComboBox()
        Me.specification = New System.Windows.Forms.ComboBox()
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'partsGRID
        '
        Me.partsGRID.AllowUserToAddRows = False
        Me.partsGRID.AllowUserToDeleteRows = False
        Me.partsGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.partsGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.partsGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.partsGRID.ColumnHeadersHeight = 32
        Me.partsGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.partsGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.partsGRID.Location = New System.Drawing.Point(23, 182)
        Me.partsGRID.MultiSelect = False
        Me.partsGRID.Name = "partsGRID"
        Me.partsGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.partsGRID.RowHeadersWidth = 30
        Me.partsGRID.RowTemplate.Height = 30
        Me.partsGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.partsGRID.Size = New System.Drawing.Size(639, 304)
        Me.partsGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
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
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.save)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.description)
        Me.Panel1.Controls.Add(Me.articleno)
        Me.Panel1.Controls.Add(Me.specification)
        Me.Panel1.Location = New System.Drawing.Point(8, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 113)
        Me.Panel1.TabIndex = 562
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(549, 74)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(102, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Silver
        Me.save.TabIndex = 524
        Me.save.Text = "find"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(104, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(86, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 523
        Me.KryptonLabel3.Values.Text = "Specification"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(122, 44)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 521
        Me.KryptonLabel1.Values.Text = "Article no"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.Location = New System.Drawing.Point(112, 76)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 522
        Me.KryptonLabel2.Values.Text = "Description"
        '
        'description
        '
        Me.description.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.FormattingEnabled = True
        Me.description.Location = New System.Drawing.Point(196, 76)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(331, 26)
        Me.description.TabIndex = 2
        '
        'articleno
        '
        Me.articleno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.articleno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.articleno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.articleno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.articleno.FormattingEnabled = True
        Me.articleno.Location = New System.Drawing.Point(196, 44)
        Me.articleno.Name = "articleno"
        Me.articleno.Size = New System.Drawing.Size(331, 26)
        Me.articleno.TabIndex = 1
        '
        'specification
        '
        Me.specification.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.Location = New System.Drawing.Point(196, 12)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(331, 26)
        Me.specification.TabIndex = 0
        '
        'importpartsFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 509)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.partsGRID)
        Me.Name = "importpartsFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Select Accessories"
        Me.TopMost = True
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents partsGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents description As ComboBox
    Friend WithEvents articleno As ComboBox
    Friend WithEvents specification As ComboBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
