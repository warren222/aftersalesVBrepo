<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newreportFRM
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KNO = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.itemno = New MetroFramework.Controls.MetroTextBox()
        Me.locations = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.knogv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'specification
        '
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.DropDownHeight = 200
        Me.specification.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.IntegralHeight = False
        Me.specification.Items.AddRange(New Object() {"Window", "Door"})
        Me.specification.Location = New System.Drawing.Point(136, 166)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(194, 28)
        Me.specification.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(28, 161)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(97, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 496
        Me.KryptonLabel1.Values.Text = "Window/Door"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(27, 78)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 498
        Me.KryptonLabel2.Values.Text = "Location"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(27, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(28, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 508
        Me.KryptonLabel3.Values.Text = "K#"
        '
        'KNO
        '
        '
        '
        '
        Me.KNO.CustomButton.Image = Nothing
        Me.KNO.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.KNO.CustomButton.Name = ""
        Me.KNO.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.KNO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.KNO.CustomButton.TabIndex = 1
        Me.KNO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.KNO.CustomButton.UseSelectable = True
        Me.KNO.CustomButton.Visible = False
        Me.KNO.DisplayIcon = True
        Me.KNO.Lines = New String(-1) {}
        Me.KNO.Location = New System.Drawing.Point(135, 12)
        Me.KNO.MaxLength = 32767
        Me.KNO.Name = "KNO"
        Me.KNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.KNO.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.KNO.SelectedText = ""
        Me.KNO.SelectionLength = 0
        Me.KNO.SelectionStart = 0
        Me.KNO.ShowClearButton = True
        Me.KNO.Size = New System.Drawing.Size(194, 27)
        Me.KNO.Style = MetroFramework.MetroColorStyle.Teal
        Me.KNO.TabIndex = 507
        Me.KNO.UseCustomForeColor = True
        Me.KNO.UseSelectable = True
        Me.KNO.UseStyleColors = True
        Me.KNO.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KNO.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(27, 45)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(48, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 510
        Me.KryptonLabel4.Values.Text = "Item#"
        '
        'itemno
        '
        '
        '
        '
        Me.itemno.CustomButton.Image = Nothing
        Me.itemno.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.itemno.CustomButton.Name = ""
        Me.itemno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.itemno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.itemno.CustomButton.TabIndex = 1
        Me.itemno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.itemno.CustomButton.UseSelectable = True
        Me.itemno.CustomButton.Visible = False
        Me.itemno.DisplayIcon = True
        Me.itemno.Lines = New String(-1) {}
        Me.itemno.Location = New System.Drawing.Point(136, 45)
        Me.itemno.MaxLength = 32767
        Me.itemno.Name = "itemno"
        Me.itemno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itemno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.itemno.SelectedText = ""
        Me.itemno.SelectionLength = 0
        Me.itemno.SelectionStart = 0
        Me.itemno.ShowClearButton = True
        Me.itemno.Size = New System.Drawing.Size(194, 27)
        Me.itemno.Style = MetroFramework.MetroColorStyle.Teal
        Me.itemno.TabIndex = 509
        Me.itemno.UseCustomForeColor = True
        Me.itemno.UseSelectable = True
        Me.itemno.UseStyleColors = True
        Me.itemno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.itemno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'locations
        '
        '
        '
        '
        Me.locations.CustomButton.Image = Nothing
        Me.locations.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.locations.CustomButton.Name = ""
        Me.locations.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.locations.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.locations.CustomButton.TabIndex = 1
        Me.locations.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.locations.CustomButton.UseSelectable = True
        Me.locations.CustomButton.Visible = False
        Me.locations.DisplayIcon = True
        Me.locations.Lines = New String(-1) {}
        Me.locations.Location = New System.Drawing.Point(135, 78)
        Me.locations.MaxLength = 32767
        Me.locations.Name = "locations"
        Me.locations.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.locations.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.locations.SelectedText = ""
        Me.locations.SelectionLength = 0
        Me.locations.SelectionStart = 0
        Me.locations.ShowClearButton = True
        Me.locations.Size = New System.Drawing.Size(194, 27)
        Me.locations.Style = MetroFramework.MetroColorStyle.Teal
        Me.locations.TabIndex = 511
        Me.locations.UseCustomForeColor = True
        Me.locations.UseSelectable = True
        Me.locations.UseStyleColors = True
        Me.locations.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.locations.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.knogv)
        Me.Panel2.Location = New System.Drawing.Point(447, 53)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(467, 378)
        Me.Panel2.TabIndex = 512
        '
        'knogv
        '
        Me.knogv.AllowUserToAddRows = False
        Me.knogv.AllowUserToDeleteRows = False
        Me.knogv.AllowUserToOrderColumns = True
        Me.knogv.AllowUserToResizeColumns = False
        Me.knogv.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.knogv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.knogv.ColumnHeadersHeight = 30
        Me.knogv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.knogv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.knogv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.knogv.Location = New System.Drawing.Point(0, 0)
        Me.knogv.MultiSelect = False
        Me.knogv.Name = "knogv"
        Me.knogv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.knogv.ReadOnly = True
        Me.knogv.RowHeadersWidth = 40
        Me.knogv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.knogv.RowTemplate.Height = 27
        Me.knogv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.knogv.Size = New System.Drawing.Size(465, 376)
        Me.knogv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.knogv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.knogv.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.knogv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.knogv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.knogv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.knogv.StateCommon.HeaderColumn.Border.Width = 0
        Me.knogv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.knogv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knogv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.knogv.TabIndex = 499
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Controls.Add(Me.specification)
        Me.Panel3.Controls.Add(Me.KryptonLabel1)
        Me.Panel3.Controls.Add(Me.locations)
        Me.Panel3.Controls.Add(Me.KryptonLabel2)
        Me.Panel3.Controls.Add(Me.KryptonLabel4)
        Me.Panel3.Controls.Add(Me.KNO)
        Me.Panel3.Controls.Add(Me.itemno)
        Me.Panel3.Location = New System.Drawing.Point(37, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(346, 227)
        Me.Panel3.TabIndex = 514
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(447, 27)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(256, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 515
        Me.KryptonLabel5.Values.Text = "LIst of k#(s) from project (KMDI System)"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(920, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 516
        Me.Button1.Text = "reload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.save.Location = New System.Drawing.Point(838, 478)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(75, 23)
        Me.save.TabIndex = 518
        Me.save.Text = "save"
        Me.save.UseVisualStyleBackColor = True
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(38, 27)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(94, 20)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 519
        Me.KryptonLabel7.Values.Text = "Report Details"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(422, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 421)
        Me.Panel4.TabIndex = 520
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(0, 466)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1010, 1)
        Me.Panel5.TabIndex = 521
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(920, 478)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 522
        Me.Button2.Text = "cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'newreportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 513)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.KryptonLabel7)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newreportFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents specification As ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KNO As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents itemno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents locations As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents knogv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents save As Button
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button2 As Button
End Class
