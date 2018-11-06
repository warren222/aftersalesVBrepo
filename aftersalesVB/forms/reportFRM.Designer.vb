<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reportFRM
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
        Me.reportGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.refreshbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.servicing = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.reportGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportGRID
        '
        Me.reportGRID.AllowUserToAddRows = False
        Me.reportGRID.AllowUserToDeleteRows = False
        Me.reportGRID.AllowUserToResizeRows = False
        Me.reportGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reportGRID.ColumnHeadersHeight = 32
        Me.reportGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.reportGRID.Location = New System.Drawing.Point(23, 96)
        Me.reportGRID.MultiSelect = False
        Me.reportGRID.Name = "reportGRID"
        Me.reportGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.reportGRID.RowHeadersWidth = 30
        Me.reportGRID.RowTemplate.Height = 30
        Me.reportGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportGRID.Size = New System.Drawing.Size(703, 371)
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
        'refreshbtn
        '
        Me.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshbtn.Image = Nothing
        Me.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshbtn.Location = New System.Drawing.Point(23, 62)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(119, 24)
        Me.refreshbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshbtn.TabIndex = 558
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseCustomForeColor = True
        Me.refreshbtn.UseSelectable = True
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'servicing
        '
        Me.servicing.Location = New System.Drawing.Point(23, 22)
        Me.servicing.Name = "servicing"
        Me.servicing.Size = New System.Drawing.Size(101, 34)
        Me.servicing.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.servicing.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicing.TabIndex = 560
        Me.servicing.Values.Text = "Servicing"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(627, 53)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(99, 37)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 563
        Me.KryptonLabel1.Values.Text = "Reports"
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 62)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 24)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 564
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'reportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 490)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.servicing)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.reportGRID)
        Me.Name = "reportFRM"
        CType(Me.reportGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reportGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents refreshbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents servicing As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
