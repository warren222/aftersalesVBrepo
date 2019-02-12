<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportassessmentFRM
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
        Me.assessmentGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        CType(Me.assessmentGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'assessmentGRID
        '
        Me.assessmentGRID.AllowUserToAddRows = False
        Me.assessmentGRID.AllowUserToDeleteRows = False
        Me.assessmentGRID.AllowUserToOrderColumns = True
        Me.assessmentGRID.AllowUserToResizeColumns = False
        Me.assessmentGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.assessmentGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.assessmentGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.assessmentGRID.ColumnHeadersHeight = 30
        Me.assessmentGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.assessmentGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.assessmentGRID.Location = New System.Drawing.Point(12, 38)
        Me.assessmentGRID.MultiSelect = False
        Me.assessmentGRID.Name = "assessmentGRID"
        Me.assessmentGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.assessmentGRID.ReadOnly = True
        Me.assessmentGRID.RowHeadersVisible = False
        Me.assessmentGRID.RowHeadersWidth = 40
        Me.assessmentGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.assessmentGRID.RowTemplate.Height = 40
        Me.assessmentGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.assessmentGRID.Size = New System.Drawing.Size(451, 200)
        Me.assessmentGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.assessmentGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.assessmentGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.assessmentGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.assessmentGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(-1, 10, -1, 10)
        Me.assessmentGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.assessmentGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.assessmentGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.assessmentGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.assessmentGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.assessmentGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.assessmentGRID.TabIndex = 483
        '
        'reportassessmentFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 261)
        Me.Controls.Add(Me.assessmentGRID)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reportassessmentFRM"
        CType(Me.assessmentGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents assessmentGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
