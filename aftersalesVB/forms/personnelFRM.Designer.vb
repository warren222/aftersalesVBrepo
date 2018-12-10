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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.personnelGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.refreshbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.personnelGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personnelGRID
        '
        Me.personnelGRID.AllowUserToAddRows = False
        Me.personnelGRID.AllowUserToDeleteRows = False
        Me.personnelGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.personnelGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.personnelGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.personnelGRID.ColumnHeadersHeight = 32
        Me.personnelGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.personnelGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.personnelGRID.Location = New System.Drawing.Point(23, 96)
        Me.personnelGRID.MultiSelect = False
        Me.personnelGRID.Name = "personnelGRID"
        Me.personnelGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.personnelGRID.RowHeadersWidth = 30
        Me.personnelGRID.RowTemplate.Height = 30
        Me.personnelGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.personnelGRID.Size = New System.Drawing.Size(440, 319)
        Me.personnelGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.personnelGRID.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control
        Me.personnelGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.personnelGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.personnelGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'refreshbtn
        '
        Me.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshbtn.Image = Nothing
        Me.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshbtn.Location = New System.Drawing.Point(23, 63)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(105, 27)
        Me.refreshbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshbtn.TabIndex = 557
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseCustomForeColor = True
        Me.refreshbtn.UseSelectable = True
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(134, 63)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(105, 27)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 558
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'personnelFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 435)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.personnelGRID)
        Me.MinimizeBox = False
        Me.Name = "personnelFRM"
        Me.Text = "Personnel"
        CType(Me.personnelGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents personnelGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents refreshbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
