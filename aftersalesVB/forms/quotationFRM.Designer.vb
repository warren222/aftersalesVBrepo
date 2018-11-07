<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quotationFRM
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
        Me.quGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.jo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.address = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.projectname = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.quGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'quGRID
        '
        Me.quGRID.AllowUserToAddRows = False
        Me.quGRID.AllowUserToDeleteRows = False
        Me.quGRID.AllowUserToResizeRows = False
        Me.quGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quGRID.ColumnHeadersHeight = 32
        Me.quGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.quGRID.Location = New System.Drawing.Point(23, 186)
        Me.quGRID.Name = "quGRID"
        Me.quGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.quGRID.RowHeadersWidth = 30
        Me.quGRID.RowTemplate.Height = 30
        Me.quGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.quGRID.Size = New System.Drawing.Size(703, 277)
        Me.quGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.quGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.quGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.quGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.quGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.quGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.quGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.quGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.quGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.quGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.quGRID.TabIndex = 559
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(148, 156)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 24)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Yellow
        Me.newbtn.TabIndex = 565
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
        Me.refreshBTN.Location = New System.Drawing.Point(23, 156)
        Me.refreshBTN.Name = "refreshBTN"
        Me.refreshBTN.Size = New System.Drawing.Size(119, 24)
        Me.refreshBTN.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refreshBTN.TabIndex = 564
        Me.refreshBTN.Text = "refresh"
        Me.refreshBTN.UseCustomForeColor = True
        Me.refreshBTN.UseSelectable = True
        Me.refreshBTN.UseVisualStyleBackColor = True
        '
        'jo
        '
        Me.jo.Location = New System.Drawing.Point(23, 121)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(93, 22)
        Me.jo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.jo.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jo.TabIndex = 568
        Me.jo.Values.Text = "Job Order No"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(23, 89)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(70, 26)
        Me.address.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.address.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.TabIndex = 567
        Me.address.Values.Text = "Address"
        '
        'projectname
        '
        Me.projectname.Location = New System.Drawing.Point(23, 49)
        Me.projectname.Name = "projectname"
        Me.projectname.Size = New System.Drawing.Size(145, 34)
        Me.projectname.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectname.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectname.TabIndex = 566
        Me.projectname.Values.Text = "Project Name"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(615, 143)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(125, 37)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 569
        Me.KryptonLabel1.Values.Text = "Quotation"
        '
        'quotationFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 486)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.jo)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.projectname)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.quGRID)
        Me.Name = "quotationFRM"
        CType(Me.quGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents quGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents refreshBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents jo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents address As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents projectname As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
