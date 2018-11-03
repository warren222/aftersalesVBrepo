<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class personnelFRM
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
        Me.personnelGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.refresh = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.personnelGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personnelGRID
        '
        Me.personnelGRID.AllowUserToAddRows = False
        Me.personnelGRID.AllowUserToDeleteRows = False
        Me.personnelGRID.AllowUserToResizeRows = False
        Me.personnelGRID.ColumnHeadersHeight = 32
        Me.personnelGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.personnelGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.personnelGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.personnelGRID.Location = New System.Drawing.Point(20, 60)
        Me.personnelGRID.MultiSelect = False
        Me.personnelGRID.Name = "personnelGRID"
        Me.personnelGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.personnelGRID.RowHeadersWidth = 30
        Me.personnelGRID.RowTemplate.Height = 30
        Me.personnelGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.personnelGRID.Size = New System.Drawing.Size(443, 355)
        Me.personnelGRID.StateCommon.Background.Color1 = System.Drawing.Color.DimGray
        Me.personnelGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.personnelGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.personnelGRID.StateCommon.DataCell.Border.Width = 0
        Me.personnelGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personnelGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.personnelGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.personnelGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.personnelGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.personnelGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.personnelGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.personnelGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personnelGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.personnelGRID.TabIndex = 556
        '
        'refresh
        '
        Me.refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh.Image = Nothing
        Me.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refresh.Location = New System.Drawing.Point(0, 5)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(105, 29)
        Me.refresh.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refresh.TabIndex = 557
        Me.refresh.Text = "refresh"
        Me.refresh.UseCustomForeColor = True
        Me.refresh.UseSelectable = True
        Me.refresh.UseVisualStyleBackColor = True
        '
        'personnelFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 435)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.personnelGRID)
        Me.Name = "personnelFRM"
        CType(Me.personnelGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents personnelGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents refresh As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
