<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportFRM
    Inherits System.Windows.Forms.Form

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
        Me.reportGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.servicing = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        CType(Me.reportGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'reportGRID
        '
        Me.reportGRID.AllowUserToAddRows = False
        Me.reportGRID.AllowUserToDeleteRows = False
        Me.reportGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.reportGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.reportGRID.ColumnHeadersHeight = 32
        Me.reportGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.reportGRID.Location = New System.Drawing.Point(0, 0)
        Me.reportGRID.MultiSelect = False
        Me.reportGRID.Name = "reportGRID"
        Me.reportGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.reportGRID.RowHeadersWidth = 30
        Me.reportGRID.RowTemplate.Height = 30
        Me.reportGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportGRID.Size = New System.Drawing.Size(827, 389)
        Me.reportGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.reportGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.reportGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.reportGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.reportGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.reportGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.reportGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.reportGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.reportGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.reportGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.reportGRID.TabIndex = 557
        '
        'servicing
        '
        Me.servicing.Location = New System.Drawing.Point(12, 12)
        Me.servicing.Name = "servicing"
        Me.servicing.Size = New System.Drawing.Size(101, 34)
        Me.servicing.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.servicing.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicing.TabIndex = 560
        Me.servicing.Values.Text = "Servicing"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.reportGRID)
        Me.Panel1.Location = New System.Drawing.Point(16, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 391)
        Me.Panel1.TabIndex = 565
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(16, 52)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(97, 20)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 566
        Me.KryptonLabel7.Values.Text = "List o reports :"
        '
        'newbtn
        '
        Me.newbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.newbtn.Location = New System.Drawing.Point(851, 79)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(120, 23)
        Me.newbtn.TabIndex = 567
        Me.newbtn.Text = "new"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(852, 108)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(118, 23)
        Me.refreshbtn.TabIndex = 568
        Me.refreshbtn.Text = "reload"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'reportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 478)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.KryptonLabel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.servicing)
        Me.MinimizeBox = False
        Me.Name = "reportFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.reportGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reportGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents servicing As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents newbtn As Button
    Friend WithEvents refreshbtn As Button
End Class
