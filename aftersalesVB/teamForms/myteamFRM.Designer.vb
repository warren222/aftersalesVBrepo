<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class myteamFRM
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GVteam = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KryptonDataGridView1 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fullname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tboxteam = New MetroFramework.Controls.MetroTextBox()
        Me.btnmsave = New System.Windows.Forms.Button()
        Me.cboxpersonnel = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.KryptonDataGridView2 = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.GVteam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GVteam
        '
        Me.GVteam.AllowUserToAddRows = False
        Me.GVteam.AllowUserToDeleteRows = False
        Me.GVteam.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GVteam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GVteam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GVteam.ColumnHeadersHeight = 32
        Me.GVteam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GVteam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVteam.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GVteam.Location = New System.Drawing.Point(0, 76)
        Me.GVteam.Name = "GVteam"
        Me.GVteam.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GVteam.RowHeadersWidth = 30
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GVteam.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GVteam.RowTemplate.Height = 35
        Me.GVteam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVteam.Size = New System.Drawing.Size(327, 372)
        Me.GVteam.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GVteam.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GVteam.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVteam.StateCommon.DataCell.Border.Width = 0
        Me.GVteam.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVteam.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVteam.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVteam.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GVteam.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVteam.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GVteam.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GVteam.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVteam.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GVteam.TabIndex = 619
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GVteam)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 448)
        Me.Panel1.TabIndex = 620
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.KryptonLabel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(327, 76)
        Me.Panel3.TabIndex = 621
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 36)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(151, 29)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 623
        Me.KryptonLabel1.Values.Text = "Assigned Team"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 29)
        Me.Button1.TabIndex = 621
        Me.Button1.Text = "assign new team"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.KryptonDataGridView1)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(327, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 448)
        Me.Panel2.TabIndex = 622
        '
        'KryptonDataGridView1
        '
        Me.KryptonDataGridView1.AllowUserToAddRows = False
        Me.KryptonDataGridView1.AllowUserToDeleteRows = False
        Me.KryptonDataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.KryptonDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.KryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.KryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.KryptonDataGridView1.ColumnHeadersHeight = 32
        Me.KryptonDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.fullname})
        Me.KryptonDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.KryptonDataGridView1.Location = New System.Drawing.Point(0, 142)
        Me.KryptonDataGridView1.Name = "KryptonDataGridView1"
        Me.KryptonDataGridView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonDataGridView1.RowHeadersWidth = 30
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KryptonDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.KryptonDataGridView1.RowTemplate.Height = 35
        Me.KryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KryptonDataGridView1.Size = New System.Drawing.Size(404, 263)
        Me.KryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.KryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonDataGridView1.StateCommon.DataCell.Border.Width = 0
        Me.KryptonDataGridView1.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.KryptonDataGridView1.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonDataGridView1.TabIndex = 627
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'fullname
        '
        Me.fullname.HeaderText = "fullname"
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 405)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(404, 43)
        Me.Panel5.TabIndex = 629
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.KryptonLabel2)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Controls.Add(Me.KryptonLabel5)
        Me.Panel4.Controls.Add(Me.KryptonLabel6)
        Me.Panel4.Controls.Add(Me.tboxteam)
        Me.Panel4.Controls.Add(Me.btnmsave)
        Me.Panel4.Controls.Add(Me.cboxpersonnel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(404, 142)
        Me.Panel4.TabIndex = 628
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(29, 11)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(176, 29)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 628
        Me.KryptonLabel2.Values.Text = "Create New Team"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(184, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 25)
        Me.Button2.TabIndex = 627
        Me.Button2.Text = "remove"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(33, 45)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 622
        Me.KryptonLabel5.Values.Text = "Team Name :"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(33, 76)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 624
        Me.KryptonLabel6.Values.Text = "Personnel :"
        '
        'tboxteam
        '
        '
        '
        '
        Me.tboxteam.CustomButton.Image = Nothing
        Me.tboxteam.CustomButton.Location = New System.Drawing.Point(227, 1)
        Me.tboxteam.CustomButton.Name = ""
        Me.tboxteam.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tboxteam.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tboxteam.CustomButton.TabIndex = 1
        Me.tboxteam.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tboxteam.CustomButton.UseSelectable = True
        Me.tboxteam.CustomButton.Visible = False
        Me.tboxteam.DisplayIcon = True
        Me.tboxteam.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tboxteam.ForeColor = System.Drawing.Color.Black
        Me.tboxteam.Lines = New String(-1) {}
        Me.tboxteam.Location = New System.Drawing.Point(130, 41)
        Me.tboxteam.MaxLength = 32767
        Me.tboxteam.Name = "tboxteam"
        Me.tboxteam.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tboxteam.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tboxteam.SelectedText = ""
        Me.tboxteam.SelectionLength = 0
        Me.tboxteam.SelectionStart = 0
        Me.tboxteam.ShowClearButton = True
        Me.tboxteam.Size = New System.Drawing.Size(255, 29)
        Me.tboxteam.Style = MetroFramework.MetroColorStyle.Red
        Me.tboxteam.TabIndex = 626
        Me.tboxteam.UseCustomForeColor = True
        Me.tboxteam.UseSelectable = True
        Me.tboxteam.WaterMark = "name"
        Me.tboxteam.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tboxteam.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnmsave
        '
        Me.btnmsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmsave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmsave.ForeColor = System.Drawing.Color.White
        Me.btnmsave.Location = New System.Drawing.Point(313, 106)
        Me.btnmsave.Name = "btnmsave"
        Me.btnmsave.Size = New System.Drawing.Size(72, 25)
        Me.btnmsave.TabIndex = 625
        Me.btnmsave.Text = "add"
        Me.btnmsave.UseVisualStyleBackColor = False
        '
        'cboxpersonnel
        '
        Me.cboxpersonnel.DropDownHeight = 200
        Me.cboxpersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxpersonnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxpersonnel.FormattingEnabled = True
        Me.cboxpersonnel.IntegralHeight = False
        Me.cboxpersonnel.Location = New System.Drawing.Point(130, 76)
        Me.cboxpersonnel.Name = "cboxpersonnel"
        Me.cboxpersonnel.Size = New System.Drawing.Size(255, 24)
        Me.cboxpersonnel.TabIndex = 623
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.KryptonDataGridView2)
        Me.Panel6.Controls.Add(Me.Panel8)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(731, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(384, 448)
        Me.Panel6.TabIndex = 623
        '
        'KryptonDataGridView2
        '
        Me.KryptonDataGridView2.AllowUserToAddRows = False
        Me.KryptonDataGridView2.AllowUserToDeleteRows = False
        Me.KryptonDataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.KryptonDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.KryptonDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.KryptonDataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.KryptonDataGridView2.ColumnHeadersHeight = 32
        Me.KryptonDataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.KryptonDataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonDataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.KryptonDataGridView2.Location = New System.Drawing.Point(0, 65)
        Me.KryptonDataGridView2.MultiSelect = False
        Me.KryptonDataGridView2.Name = "KryptonDataGridView2"
        Me.KryptonDataGridView2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.KryptonDataGridView2.RowHeadersWidth = 30
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KryptonDataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.KryptonDataGridView2.RowTemplate.Height = 35
        Me.KryptonDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.KryptonDataGridView2.Size = New System.Drawing.Size(384, 340)
        Me.KryptonDataGridView2.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView2.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.KryptonDataGridView2.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonDataGridView2.StateCommon.DataCell.Border.Width = 0
        Me.KryptonDataGridView2.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.KryptonDataGridView2.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonDataGridView2.TabIndex = 620
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 405)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(384, 43)
        Me.Panel8.TabIndex = 631
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(221, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(139, 29)
        Me.Button4.TabIndex = 621
        Me.Button4.Text = "assign selected team"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Button3)
        Me.Panel7.Controls.Add(Me.KryptonLabel3)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(384, 65)
        Me.Panel7.TabIndex = 630
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(284, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 29)
        Me.Button3.TabIndex = 630
        Me.Button3.Text = "refresh"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(176, 21)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(102, 29)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 629
        Me.KryptonLabel3.Values.Text = "Team List"
        '
        'myteamFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1115, 448)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "myteamFRM"
        Me.Text = "myteamFRM"
        CType(Me.GVteam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.KryptonDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.KryptonDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GVteam As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KryptonDataGridView1 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents tboxteam As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboxpersonnel As ComboBox
    Friend WithEvents btnmsave As Button
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents KryptonDataGridView2 As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel7 As Panel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents fullname As DataGridViewTextBoxColumn
End Class
