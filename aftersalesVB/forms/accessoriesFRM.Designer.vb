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
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.accessoriesGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        CType(Me.accessoriesGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 63)
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
        Me.refreshBTN.Location = New System.Drawing.Point(23, 63)
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
        Me.accessoriesGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accessoriesGRID.ColumnHeadersHeight = 32
        Me.accessoriesGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accessoriesGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.accessoriesGRID.Location = New System.Drawing.Point(23, 93)
        Me.accessoriesGRID.Name = "accessoriesGRID"
        Me.accessoriesGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.accessoriesGRID.RowHeadersWidth = 30
        Me.accessoriesGRID.RowTemplate.Height = 30
        Me.accessoriesGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.accessoriesGRID.Size = New System.Drawing.Size(915, 397)
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
        'accessoriesFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 513)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.accessoriesGRID)
        Me.Name = "accessoriesFRM"
        Me.Text = "Accessories"
        CType(Me.accessoriesGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents refreshBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents accessoriesGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
