<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REQreplacementFRM
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.remarks = New MetroFramework.Controls.MetroTextBox()
        Me.qty = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.description = New MetroFramework.Controls.MetroTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.partsGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.requestype = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Controls.Add(Me.remarks)
        Me.Panel3.Controls.Add(Me.qty)
        Me.Panel3.Controls.Add(Me.KryptonLabel4)
        Me.Panel3.Controls.Add(Me.KryptonLabel5)
        Me.Panel3.Controls.Add(Me.description)
        Me.Panel3.Location = New System.Drawing.Point(15, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 101)
        Me.Panel3.TabIndex = 602
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(18, 53)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(62, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 522
        Me.KryptonLabel3.Values.Text = "Remarks"
        '
        'remarks
        '
        '
        '
        '
        Me.remarks.CustomButton.Image = Nothing
        Me.remarks.CustomButton.Location = New System.Drawing.Point(401, 1)
        Me.remarks.CustomButton.Name = ""
        Me.remarks.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.remarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.remarks.CustomButton.TabIndex = 1
        Me.remarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.remarks.CustomButton.UseSelectable = True
        Me.remarks.CustomButton.Visible = False
        Me.remarks.DisplayIcon = True
        Me.remarks.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.remarks.Lines = New String(-1) {}
        Me.remarks.Location = New System.Drawing.Point(86, 53)
        Me.remarks.MaxLength = 32767
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.remarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.remarks.SelectedText = ""
        Me.remarks.SelectionLength = 0
        Me.remarks.SelectionStart = 0
        Me.remarks.ShowClearButton = True
        Me.remarks.Size = New System.Drawing.Size(427, 27)
        Me.remarks.Style = MetroFramework.MetroColorStyle.Teal
        Me.remarks.TabIndex = 521
        Me.remarks.UseCustomForeColor = True
        Me.remarks.UseSelectable = True
        Me.remarks.UseStyleColors = True
        Me.remarks.WaterMark = "Remarks"
        Me.remarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.remarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'qty
        '
        '
        '
        '
        Me.qty.CustomButton.Image = Nothing
        Me.qty.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.qty.CustomButton.Name = ""
        Me.qty.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.qty.CustomButton.TabIndex = 1
        Me.qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.qty.CustomButton.UseSelectable = True
        Me.qty.CustomButton.Visible = False
        Me.qty.DisplayIcon = True
        Me.qty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.qty.Lines = New String(-1) {}
        Me.qty.Location = New System.Drawing.Point(413, 20)
        Me.qty.MaxLength = 32767
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.qty.SelectedText = ""
        Me.qty.SelectionLength = 0
        Me.qty.SelectionStart = 0
        Me.qty.ShowClearButton = True
        Me.qty.Size = New System.Drawing.Size(100, 27)
        Me.qty.Style = MetroFramework.MetroColorStyle.Teal
        Me.qty.TabIndex = 5
        Me.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.qty.UseCustomForeColor = True
        Me.qty.UseSelectable = True
        Me.qty.UseStyleColors = True
        Me.qty.WaterMark = "Quantity"
        Me.qty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.qty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 20)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 520
        Me.KryptonLabel4.Values.Text = "Description"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(371, 20)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 513
        Me.KryptonLabel5.Values.Text = "Qty:"
        '
        'description
        '
        '
        '
        '
        Me.description.CustomButton.Image = Nothing
        Me.description.CustomButton.Location = New System.Drawing.Point(253, 1)
        Me.description.CustomButton.Name = ""
        Me.description.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.description.CustomButton.TabIndex = 1
        Me.description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.description.CustomButton.UseSelectable = True
        Me.description.CustomButton.Visible = False
        Me.description.DisplayIcon = True
        Me.description.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.description.Lines = New String(-1) {}
        Me.description.Location = New System.Drawing.Point(86, 20)
        Me.description.MaxLength = 32767
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.description.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.description.SelectedText = ""
        Me.description.SelectionLength = 0
        Me.description.SelectionStart = 0
        Me.description.ShowClearButton = True
        Me.description.Size = New System.Drawing.Size(279, 27)
        Me.description.Style = MetroFramework.MetroColorStyle.Teal
        Me.description.TabIndex = 2
        Me.description.UseCustomForeColor = True
        Me.description.UseSelectable = True
        Me.description.UseStyleColors = True
        Me.description.WaterMark = "Description"
        Me.description.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.description.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(559, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 604
        Me.Button4.Text = "update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(559, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 603
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(557, 185)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshbtn.TabIndex = 606
        Me.refreshbtn.Text = "reload"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.partsGRID)
        Me.Panel1.Location = New System.Drawing.Point(14, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 223)
        Me.Panel1.TabIndex = 605
        '
        'partsGRID
        '
        Me.partsGRID.AllowUserToAddRows = False
        Me.partsGRID.AllowUserToDeleteRows = False
        Me.partsGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.partsGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.partsGRID.ColumnHeadersHeight = 32
        Me.partsGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.partsGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partsGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.partsGRID.Location = New System.Drawing.Point(0, 0)
        Me.partsGRID.Name = "partsGRID"
        Me.partsGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.partsGRID.RowHeadersWidth = 30
        Me.partsGRID.RowTemplate.Height = 30
        Me.partsGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.partsGRID.Size = New System.Drawing.Size(536, 221)
        Me.partsGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.partsGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.partsGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.partsGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.partsGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.partsGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.partsGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.partsGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.partsGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.partsGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.partsGRID.TabIndex = 561
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(14, 158)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(168, 20)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 607
        Me.KryptonLabel6.Values.Text = "Request For Replacements"
        '
        'requestype
        '
        Me.requestype.Location = New System.Drawing.Point(15, 15)
        Me.requestype.Name = "requestype"
        Me.requestype.Size = New System.Drawing.Size(196, 20)
        Me.requestype.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.requestype.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestype.TabIndex = 608
        Me.requestype.Values.Text = "REQUEST FOR REPLACEMENTS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.requestype)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.KryptonLabel6)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.refreshbtn)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1104, 432)
        Me.Panel2.TabIndex = 609
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(557, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 609
        Me.Button2.Text = "remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(557, 243)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 610
        Me.Button3.Text = "print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'REQreplacementFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1104, 432)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "REQreplacementFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Green
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents remarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents qty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents description As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents partsGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents requestype As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
