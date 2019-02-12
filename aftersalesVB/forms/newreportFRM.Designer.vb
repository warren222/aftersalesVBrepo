<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newreportFRM
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
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.locations = New System.Windows.Forms.ComboBox()
        Me.answerGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MetroTextButton3 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.answerGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(323, 373)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 492
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'specification
        '
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.DropDownHeight = 200
        Me.specification.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.IntegralHeight = False
        Me.specification.Location = New System.Drawing.Point(249, 124)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(193, 28)
        Me.specification.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(249, 96)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 496
        Me.KryptonLabel1.Values.Text = "Specification"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(37, 96)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 498
        Me.KryptonLabel2.Values.Text = "Location"
        '
        'locations
        '
        Me.locations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.locations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.locations.DropDownHeight = 200
        Me.locations.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.locations.FormattingEnabled = True
        Me.locations.IntegralHeight = False
        Me.locations.Location = New System.Drawing.Point(37, 124)
        Me.locations.Name = "locations"
        Me.locations.Size = New System.Drawing.Size(193, 28)
        Me.locations.TabIndex = 1
        '
        'answerGV
        '
        Me.answerGV.AllowUserToAddRows = False
        Me.answerGV.AllowUserToDeleteRows = False
        Me.answerGV.AllowUserToOrderColumns = True
        Me.answerGV.AllowUserToResizeColumns = False
        Me.answerGV.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.answerGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.answerGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.answerGV.ColumnHeadersHeight = 30
        Me.answerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.answerGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.answerGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.answerGV.Location = New System.Drawing.Point(37, 200)
        Me.answerGV.MultiSelect = False
        Me.answerGV.Name = "answerGV"
        Me.answerGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.answerGV.ReadOnly = True
        Me.answerGV.RowHeadersVisible = False
        Me.answerGV.RowHeadersWidth = 40
        Me.answerGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.answerGV.RowTemplate.Height = 27
        Me.answerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.answerGV.Size = New System.Drawing.Size(405, 154)
        Me.answerGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.answerGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.answerGV.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.answerGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.answerGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.answerGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.answerGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.answerGV.TabIndex = 499
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'MetroTextButton3
        '
        Me.MetroTextButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton3.Image = Nothing
        Me.MetroTextButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton3.Location = New System.Drawing.Point(37, 170)
        Me.MetroTextButton3.Name = "MetroTextButton3"
        Me.MetroTextButton3.Size = New System.Drawing.Size(48, 24)
        Me.MetroTextButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextButton3.TabIndex = 500
        Me.MetroTextButton3.Text = "+"
        Me.MetroTextButton3.UseCustomForeColor = True
        Me.MetroTextButton3.UseSelectable = True
        Me.MetroTextButton3.UseVisualStyleBackColor = True
        '
        'newreportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 412)
        Me.Controls.Add(Me.MetroTextButton3)
        Me.Controls.Add(Me.answerGV)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.locations)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.specification)
        Me.Controls.Add(Me.save)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newreportFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newreportFRM"
        CType(Me.answerGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents specification As ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents locations As ComboBox
    Friend WithEvents answerGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents MetroTextButton3 As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
