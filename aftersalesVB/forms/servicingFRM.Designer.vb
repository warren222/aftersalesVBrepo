<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class servicingFRM
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
        Me.servicingGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.refresh = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.jo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.address = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.projectname = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        CType(Me.servicingGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'servicingGRID
        '
        Me.servicingGRID.AllowUserToAddRows = False
        Me.servicingGRID.AllowUserToDeleteRows = False
        Me.servicingGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.servicingGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.servicingGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.servicingGRID.ColumnHeadersHeight = 32
        Me.servicingGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.servicingGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.servicingGRID.Location = New System.Drawing.Point(23, 190)
        Me.servicingGRID.MultiSelect = False
        Me.servicingGRID.Name = "servicingGRID"
        Me.servicingGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.servicingGRID.RowHeadersWidth = 30
        Me.servicingGRID.RowTemplate.Height = 30
        Me.servicingGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.servicingGRID.Size = New System.Drawing.Size(832, 521)
        Me.servicingGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.servicingGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.servicingGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.servicingGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicingGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Olive
        Me.servicingGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.servicingGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.servicingGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.servicingGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.servicingGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.servicingGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicingGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.servicingGRID.TabIndex = 556
        '
        'refresh
        '
        Me.refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.refresh.Image = Nothing
        Me.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refresh.Location = New System.Drawing.Point(23, 156)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(119, 24)
        Me.refresh.Style = MetroFramework.MetroColorStyle.Yellow
        Me.refresh.TabIndex = 557
        Me.refresh.Text = "refresh"
        Me.refresh.UseCustomForeColor = True
        Me.refresh.UseSelectable = True
        Me.refresh.UseVisualStyleBackColor = True
        '
        'jo
        '
        Me.jo.Location = New System.Drawing.Point(23, 121)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(93, 22)
        Me.jo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.jo.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jo.TabIndex = 561
        Me.jo.Values.Text = "Job Order No"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(23, 89)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(70, 26)
        Me.address.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.address.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.TabIndex = 560
        Me.address.Values.Text = "Address"
        '
        'projectname
        '
        Me.projectname.Location = New System.Drawing.Point(23, 49)
        Me.projectname.Name = "projectname"
        Me.projectname.Size = New System.Drawing.Size(145, 34)
        Me.projectname.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectname.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectname.TabIndex = 559
        Me.projectname.Values.Text = "Project Name"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(636, 147)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(219, 37)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 562
        Me.KryptonLabel1.Values.Text = "Servicing Schedule"
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
        Me.newbtn.TabIndex = 563
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'servicingFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 723)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.jo)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.projectname)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.servicingGRID)
        Me.MinimizeBox = False
        Me.Name = "servicingFRM"
        Me.Style = MetroFramework.MetroColorStyle.Brown
        CType(Me.servicingGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents servicingGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents refresh As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents jo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents address As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents projectname As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
