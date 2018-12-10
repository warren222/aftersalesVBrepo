<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class concernFRM
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
        Me.refreshbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.answerGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.answerGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'refreshbtn
        '
        Me.refreshbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refreshbtn.Image = Nothing
        Me.refreshbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshbtn.Location = New System.Drawing.Point(23, 63)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(119, 27)
        Me.refreshbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshbtn.TabIndex = 559
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseCustomForeColor = True
        Me.refreshbtn.UseSelectable = True
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'answerGRID
        '
        Me.answerGRID.AllowUserToAddRows = False
        Me.answerGRID.AllowUserToDeleteRows = False
        Me.answerGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.answerGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.answerGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.answerGRID.ColumnHeadersHeight = 32
        Me.answerGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.answerGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.answerGRID.Location = New System.Drawing.Point(23, 96)
        Me.answerGRID.Name = "answerGRID"
        Me.answerGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.answerGRID.RowHeadersWidth = 30
        Me.answerGRID.RowTemplate.Height = 30
        Me.answerGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.answerGRID.Size = New System.Drawing.Size(703, 347)
        Me.answerGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.answerGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.answerGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.answerGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.answerGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.answerGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.answerGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.answerGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.answerGRID.TabIndex = 558
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(621, 53)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(105, 37)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 563
        Me.KryptonLabel1.Values.Text = "Concern"
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 63)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 27)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 564
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'concernFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 452)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.answerGRID)
        Me.MinimizeBox = False
        Me.Name = "concernFRM"
        Me.Text = "W"
        CType(Me.answerGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refreshbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents answerGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
