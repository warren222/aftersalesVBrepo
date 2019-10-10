<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quotationFRM
    Inherits System.Windows.Forms.Form

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
        Me.quGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.jo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.address = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.projectname = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.quGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'quGRID
        '
        Me.quGRID.AllowUserToAddRows = False
        Me.quGRID.AllowUserToDeleteRows = False
        Me.quGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.quGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.quGRID.ColumnHeadersHeight = 32
        Me.quGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.quGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.quGRID.Location = New System.Drawing.Point(0, 0)
        Me.quGRID.Name = "quGRID"
        Me.quGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.quGRID.RowHeadersWidth = 30
        Me.quGRID.RowTemplate.Height = 30
        Me.quGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.quGRID.Size = New System.Drawing.Size(1049, 283)
        Me.quGRID.StateCommon.Background.Color1 = System.Drawing.Color.Silver
        Me.quGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.quGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.quGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.quGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Maroon
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
        Me.newbtn.Location = New System.Drawing.Point(148, 148)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(119, 24)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Blue
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
        Me.refreshBTN.Location = New System.Drawing.Point(23, 148)
        Me.refreshBTN.Name = "refreshBTN"
        Me.refreshBTN.Size = New System.Drawing.Size(119, 24)
        Me.refreshBTN.Style = MetroFramework.MetroColorStyle.Blue
        Me.refreshBTN.TabIndex = 564
        Me.refreshBTN.Text = "refresh"
        Me.refreshBTN.UseCustomForeColor = True
        Me.refreshBTN.UseSelectable = True
        Me.refreshBTN.UseVisualStyleBackColor = True
        '
        'jo
        '
        Me.jo.Location = New System.Drawing.Point(23, 113)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(93, 22)
        Me.jo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.jo.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jo.TabIndex = 568
        Me.jo.Values.Text = "Job Order No"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(23, 81)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(70, 26)
        Me.address.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.address.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.TabIndex = 567
        Me.address.Values.Text = "Address"
        '
        'projectname
        '
        Me.projectname.Location = New System.Drawing.Point(23, 41)
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(949, 135)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(125, 37)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 569
        Me.KryptonLabel1.Values.Text = "Quotation"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.quGRID)
        Me.Panel1.Location = New System.Drawing.Point(23, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 285)
        Me.Panel1.TabIndex = 570
        '
        'quotationFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1097, 486)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.projectname)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.refreshBTN)
        Me.Controls.Add(Me.jo)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.newbtn)
        Me.MinimizeBox = False
        Me.Name = "quotationFRM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.quGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Panel1 As Panel
End Class
