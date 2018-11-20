<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accessoriesFRM
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
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.accessoriesGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.description = New System.Windows.Forms.ComboBox()
        Me.articleno = New System.Windows.Forms.ComboBox()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.MetroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.accessoriesGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 165)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 24)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 568
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'refreshBTN
        '
        Me.refreshBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshBTN.Image = Nothing
        Me.refreshBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshBTN.Location = New System.Drawing.Point(23, 165)
        Me.refreshBTN.Name = "refreshBTN"
        Me.refreshBTN.Size = New System.Drawing.Size(119, 24)
        Me.refreshBTN.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshBTN.TabIndex = 567
        Me.refreshBTN.Text = "refresh"
        Me.refreshBTN.UseCustomForeColor = True
        Me.refreshBTN.UseSelectable = True
        Me.refreshBTN.UseVisualStyleBackColor = True
        '
        'accessoriesGRID
        '
        Me.accessoriesGRID.AllowUserToAddRows = False
        Me.accessoriesGRID.AllowUserToDeleteRows = False
        Me.accessoriesGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.accessoriesGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.accessoriesGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accessoriesGRID.ColumnHeadersHeight = 32
        Me.accessoriesGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accessoriesGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.accessoriesGRID.Location = New System.Drawing.Point(23, 195)
        Me.accessoriesGRID.Name = "accessoriesGRID"
        Me.accessoriesGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.accessoriesGRID.RowHeadersWidth = 30
        Me.accessoriesGRID.RowTemplate.Height = 30
        Me.accessoriesGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.accessoriesGRID.Size = New System.Drawing.Size(915, 306)
        Me.accessoriesGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.accessoriesGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.accessoriesGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.accessoriesGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accessoriesGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.accessoriesGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.accessoriesGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.accessoriesGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.accessoriesGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.accessoriesGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.accessoriesGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accessoriesGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.accessoriesGRID.TabIndex = 566
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(221, 14)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(86, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 574
        Me.KryptonLabel3.Values.Text = "Specification"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(32, 14)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 572
        Me.KryptonLabel1.Values.Text = "Article no"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.Location = New System.Drawing.Point(477, 14)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 573
        Me.KryptonLabel2.Values.Text = "Description"
        '
        'description
        '
        Me.description.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.description.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.description.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.description.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.description.FormattingEnabled = True
        Me.description.Location = New System.Drawing.Point(477, 42)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(331, 26)
        Me.description.TabIndex = 571
        '
        'articleno
        '
        Me.articleno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.articleno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.articleno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.articleno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.articleno.FormattingEnabled = True
        Me.articleno.Location = New System.Drawing.Point(32, 42)
        Me.articleno.Name = "articleno"
        Me.articleno.Size = New System.Drawing.Size(183, 26)
        Me.articleno.TabIndex = 570
        '
        'specification
        '
        Me.specification.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.Location = New System.Drawing.Point(221, 42)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(250, 26)
        Me.specification.TabIndex = 569
        '
        'MetroTextButton1
        '
        Me.MetroTextButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton1.Image = Nothing
        Me.MetroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton1.Location = New System.Drawing.Point(814, 42)
        Me.MetroTextButton1.Name = "MetroTextButton1"
        Me.MetroTextButton1.Size = New System.Drawing.Size(88, 26)
        Me.MetroTextButton1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroTextButton1.TabIndex = 575
        Me.MetroTextButton1.Text = "find"
        Me.MetroTextButton1.UseCustomForeColor = True
        Me.MetroTextButton1.UseSelectable = True
        Me.MetroTextButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.MetroTextButton1)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.specification)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.articleno)
        Me.Panel1.Controls.Add(Me.description)
        Me.Panel1.Location = New System.Drawing.Point(0, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 81)
        Me.Panel1.TabIndex = 576
        '
        'accessoriesFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 513)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.accessoriesGRID)
        Me.Name = "accessoriesFRM"
        Me.Text = "Accessories / Materials"
        CType(Me.accessoriesGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents refreshBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents accessoriesGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents description As ComboBox
    Friend WithEvents articleno As ComboBox
    Friend WithEvents specification As ComboBox
    Friend WithEvents MetroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Panel1 As Panel
End Class
