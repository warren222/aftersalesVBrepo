<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acctFRM
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
        Me.acctGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.acctGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'acctGRID
        '
        Me.acctGRID.AllowUserToAddRows = False
        Me.acctGRID.AllowUserToDeleteRows = False
        Me.acctGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.acctGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.acctGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.acctGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.acctGRID.ColumnHeadersHeight = 32
        Me.acctGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.acctGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.acctGRID.Location = New System.Drawing.Point(23, 111)
        Me.acctGRID.Name = "acctGRID"
        Me.acctGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.acctGRID.RowHeadersWidth = 30
        Me.acctGRID.RowTemplate.Height = 30
        Me.acctGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.acctGRID.Size = New System.Drawing.Size(609, 333)
        Me.acctGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.acctGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.acctGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.acctGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.acctGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.acctGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.acctGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.acctGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.acctGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.acctGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.acctGRID.TabIndex = 557
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 78)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 27)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 560
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshbtn.Image = Nothing
        Me.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshbtn.Location = New System.Drawing.Point(23, 78)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(119, 27)
        Me.refreshbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshbtn.TabIndex = 559
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseCustomForeColor = True
        Me.refreshbtn.UseSelectable = True
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'acctFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 467)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.acctGRID)
        Me.MinimizeBox = False
        Me.Name = "acctFRM"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Manage Accounts"
        CType(Me.acctGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents acctGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents refreshbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
