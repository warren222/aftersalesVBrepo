<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMpersonnel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GVpersonnel = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnpedit = New System.Windows.Forms.Button()
        Me.btnpdelete = New System.Windows.Forms.Button()
        Me.btnpreload = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tboxfullname = New MetroFramework.Controls.MetroTextBox()
        Me.btnpcancel = New System.Windows.Forms.Button()
        Me.cboxposition = New System.Windows.Forms.ComboBox()
        Me.btnpsave = New System.Windows.Forms.Button()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GVteam = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btntedit = New System.Windows.Forms.Button()
        Me.btntdelete = New System.Windows.Forms.Button()
        Me.btntreload = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.tboxteamname = New MetroFramework.Controls.MetroTextBox()
        Me.btntcancel = New System.Windows.Forms.Button()
        Me.btntsave = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.GVmember = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnmdelete = New System.Windows.Forms.Button()
        Me.btnmreload = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.tboxteam = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboxpersonnel = New System.Windows.Forms.ComboBox()
        Me.btnmsave = New System.Windows.Forms.Button()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GVpersonnel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GVteam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.GVmember, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 422)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(150, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(758, 422)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(750, 384)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personnel"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GVpersonnel)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(300, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 378)
        Me.Panel2.TabIndex = 619
        '
        'GVpersonnel
        '
        Me.GVpersonnel.AllowUserToAddRows = False
        Me.GVpersonnel.AllowUserToDeleteRows = False
        Me.GVpersonnel.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GVpersonnel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GVpersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GVpersonnel.ColumnHeadersHeight = 32
        Me.GVpersonnel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GVpersonnel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVpersonnel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GVpersonnel.Location = New System.Drawing.Point(0, 28)
        Me.GVpersonnel.Name = "GVpersonnel"
        Me.GVpersonnel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GVpersonnel.RowHeadersWidth = 30
        Me.GVpersonnel.RowTemplate.Height = 35
        Me.GVpersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVpersonnel.Size = New System.Drawing.Size(447, 350)
        Me.GVpersonnel.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GVpersonnel.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GVpersonnel.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVpersonnel.StateCommon.DataCell.Border.Width = 0
        Me.GVpersonnel.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVpersonnel.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVpersonnel.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVpersonnel.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GVpersonnel.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVpersonnel.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GVpersonnel.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GVpersonnel.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVpersonnel.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GVpersonnel.TabIndex = 618
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnpedit)
        Me.Panel3.Controls.Add(Me.btnpdelete)
        Me.Panel3.Controls.Add(Me.btnpreload)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(447, 28)
        Me.Panel3.TabIndex = 0
        '
        'btnpedit
        '
        Me.btnpedit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpedit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpedit.ForeColor = System.Drawing.Color.White
        Me.btnpedit.Location = New System.Drawing.Point(268, 0)
        Me.btnpedit.Name = "btnpedit"
        Me.btnpedit.Size = New System.Drawing.Size(72, 26)
        Me.btnpedit.TabIndex = 616
        Me.btnpedit.Text = "edit"
        Me.btnpedit.UseVisualStyleBackColor = False
        '
        'btnpdelete
        '
        Me.btnpdelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpdelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpdelete.ForeColor = System.Drawing.Color.White
        Me.btnpdelete.Location = New System.Drawing.Point(346, 0)
        Me.btnpdelete.Name = "btnpdelete"
        Me.btnpdelete.Size = New System.Drawing.Size(72, 26)
        Me.btnpdelete.TabIndex = 614
        Me.btnpdelete.Text = "delete"
        Me.btnpdelete.UseVisualStyleBackColor = False
        '
        'btnpreload
        '
        Me.btnpreload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpreload.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpreload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpreload.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreload.ForeColor = System.Drawing.Color.White
        Me.btnpreload.Location = New System.Drawing.Point(190, 0)
        Me.btnpreload.Name = "btnpreload"
        Me.btnpreload.Size = New System.Drawing.Size(72, 26)
        Me.btnpreload.TabIndex = 613
        Me.btnpreload.Text = "reload"
        Me.btnpreload.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel4.Controls.Add(Me.KryptonLabel3)
        Me.Panel4.Controls.Add(Me.tboxfullname)
        Me.Panel4.Controls.Add(Me.btnpcancel)
        Me.Panel4.Controls.Add(Me.cboxposition)
        Me.Panel4.Controls.Add(Me.btnpsave)
        Me.Panel4.Controls.Add(Me.KryptonLabel1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(297, 378)
        Me.Panel4.TabIndex = 620
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(23, 51)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 570
        Me.KryptonLabel3.Values.Text = "Fullname :"
        '
        'tboxfullname
        '
        '
        '
        '
        Me.tboxfullname.CustomButton.Image = Nothing
        Me.tboxfullname.CustomButton.Location = New System.Drawing.Point(227, 1)
        Me.tboxfullname.CustomButton.Name = ""
        Me.tboxfullname.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tboxfullname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tboxfullname.CustomButton.TabIndex = 1
        Me.tboxfullname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tboxfullname.CustomButton.UseSelectable = True
        Me.tboxfullname.CustomButton.Visible = False
        Me.tboxfullname.DisplayIcon = True
        Me.tboxfullname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tboxfullname.ForeColor = System.Drawing.Color.Black
        Me.tboxfullname.Lines = New String(-1) {}
        Me.tboxfullname.Location = New System.Drawing.Point(24, 77)
        Me.tboxfullname.MaxLength = 32767
        Me.tboxfullname.Name = "tboxfullname"
        Me.tboxfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tboxfullname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tboxfullname.SelectedText = ""
        Me.tboxfullname.SelectionLength = 0
        Me.tboxfullname.SelectionStart = 0
        Me.tboxfullname.ShowClearButton = True
        Me.tboxfullname.Size = New System.Drawing.Size(255, 29)
        Me.tboxfullname.Style = MetroFramework.MetroColorStyle.Red
        Me.tboxfullname.TabIndex = 569
        Me.tboxfullname.UseCustomForeColor = True
        Me.tboxfullname.UseSelectable = True
        Me.tboxfullname.WaterMark = "name"
        Me.tboxfullname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tboxfullname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnpcancel
        '
        Me.btnpcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpcancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpcancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpcancel.ForeColor = System.Drawing.Color.White
        Me.btnpcancel.Location = New System.Drawing.Point(24, 228)
        Me.btnpcancel.Name = "btnpcancel"
        Me.btnpcancel.Size = New System.Drawing.Size(72, 25)
        Me.btnpcancel.TabIndex = 616
        Me.btnpcancel.Text = "cancel"
        Me.btnpcancel.UseVisualStyleBackColor = False
        Me.btnpcancel.Visible = False
        '
        'cboxposition
        '
        Me.cboxposition.FormattingEnabled = True
        Me.cboxposition.Location = New System.Drawing.Point(24, 144)
        Me.cboxposition.Name = "cboxposition"
        Me.cboxposition.Size = New System.Drawing.Size(255, 25)
        Me.cboxposition.TabIndex = 571
        '
        'btnpsave
        '
        Me.btnpsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnpsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpsave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpsave.ForeColor = System.Drawing.Color.White
        Me.btnpsave.Location = New System.Drawing.Point(23, 197)
        Me.btnpsave.Name = "btnpsave"
        Me.btnpsave.Size = New System.Drawing.Size(72, 25)
        Me.btnpsave.TabIndex = 617
        Me.btnpsave.Text = "add"
        Me.btnpsave.UseVisualStyleBackColor = False
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(24, 118)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 572
        Me.KryptonLabel1.Values.Text = "Position :"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(750, 384)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Team"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GVteam)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(300, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(447, 378)
        Me.Panel5.TabIndex = 621
        '
        'GVteam
        '
        Me.GVteam.AllowUserToAddRows = False
        Me.GVteam.AllowUserToDeleteRows = False
        Me.GVteam.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GVteam.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GVteam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GVteam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.GVteam.ColumnHeadersHeight = 32
        Me.GVteam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GVteam.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVteam.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GVteam.Location = New System.Drawing.Point(0, 28)
        Me.GVteam.Name = "GVteam"
        Me.GVteam.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GVteam.RowHeadersWidth = 30
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GVteam.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GVteam.RowTemplate.Height = 35
        Me.GVteam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVteam.Size = New System.Drawing.Size(447, 350)
        Me.GVteam.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GVteam.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GVteam.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVteam.StateCommon.DataCell.Border.Width = 0
        Me.GVteam.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVteam.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVteam.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVteam.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GVteam.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVteam.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GVteam.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GVteam.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVteam.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GVteam.TabIndex = 618
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel6.Controls.Add(Me.btntedit)
        Me.Panel6.Controls.Add(Me.btntdelete)
        Me.Panel6.Controls.Add(Me.btntreload)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(447, 28)
        Me.Panel6.TabIndex = 0
        '
        'btntedit
        '
        Me.btntedit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntedit.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntedit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntedit.ForeColor = System.Drawing.Color.White
        Me.btntedit.Location = New System.Drawing.Point(268, 0)
        Me.btntedit.Name = "btntedit"
        Me.btntedit.Size = New System.Drawing.Size(72, 26)
        Me.btntedit.TabIndex = 616
        Me.btntedit.Text = "edit"
        Me.btntedit.UseVisualStyleBackColor = False
        '
        'btntdelete
        '
        Me.btntdelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntdelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntdelete.ForeColor = System.Drawing.Color.White
        Me.btntdelete.Location = New System.Drawing.Point(346, 0)
        Me.btntdelete.Name = "btntdelete"
        Me.btntdelete.Size = New System.Drawing.Size(72, 26)
        Me.btntdelete.TabIndex = 614
        Me.btntdelete.Text = "delete"
        Me.btntdelete.UseVisualStyleBackColor = False
        '
        'btntreload
        '
        Me.btntreload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntreload.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntreload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntreload.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntreload.ForeColor = System.Drawing.Color.White
        Me.btntreload.Location = New System.Drawing.Point(190, 0)
        Me.btntreload.Name = "btntreload"
        Me.btntreload.Size = New System.Drawing.Size(72, 26)
        Me.btntreload.TabIndex = 613
        Me.btntreload.Text = "reload"
        Me.btntreload.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel7.Controls.Add(Me.KryptonLabel2)
        Me.Panel7.Controls.Add(Me.tboxteamname)
        Me.Panel7.Controls.Add(Me.btntcancel)
        Me.Panel7.Controls.Add(Me.btntsave)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(297, 378)
        Me.Panel7.TabIndex = 622
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(23, 51)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 570
        Me.KryptonLabel2.Values.Text = "Team Name :"
        '
        'tboxteamname
        '
        '
        '
        '
        Me.tboxteamname.CustomButton.Image = Nothing
        Me.tboxteamname.CustomButton.Location = New System.Drawing.Point(227, 1)
        Me.tboxteamname.CustomButton.Name = ""
        Me.tboxteamname.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tboxteamname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tboxteamname.CustomButton.TabIndex = 1
        Me.tboxteamname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tboxteamname.CustomButton.UseSelectable = True
        Me.tboxteamname.CustomButton.Visible = False
        Me.tboxteamname.DisplayIcon = True
        Me.tboxteamname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tboxteamname.ForeColor = System.Drawing.Color.Black
        Me.tboxteamname.Lines = New String(-1) {}
        Me.tboxteamname.Location = New System.Drawing.Point(24, 77)
        Me.tboxteamname.MaxLength = 32767
        Me.tboxteamname.Name = "tboxteamname"
        Me.tboxteamname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tboxteamname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tboxteamname.SelectedText = ""
        Me.tboxteamname.SelectionLength = 0
        Me.tboxteamname.SelectionStart = 0
        Me.tboxteamname.ShowClearButton = True
        Me.tboxteamname.Size = New System.Drawing.Size(255, 29)
        Me.tboxteamname.Style = MetroFramework.MetroColorStyle.Red
        Me.tboxteamname.TabIndex = 569
        Me.tboxteamname.UseCustomForeColor = True
        Me.tboxteamname.UseSelectable = True
        Me.tboxteamname.WaterMark = "name"
        Me.tboxteamname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tboxteamname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btntcancel
        '
        Me.btntcancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntcancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntcancel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntcancel.ForeColor = System.Drawing.Color.White
        Me.btntcancel.Location = New System.Drawing.Point(24, 228)
        Me.btntcancel.Name = "btntcancel"
        Me.btntcancel.Size = New System.Drawing.Size(72, 25)
        Me.btntcancel.TabIndex = 616
        Me.btntcancel.Text = "cancel"
        Me.btntcancel.UseVisualStyleBackColor = False
        Me.btntcancel.Visible = False
        '
        'btntsave
        '
        Me.btntsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btntsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntsave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntsave.ForeColor = System.Drawing.Color.White
        Me.btntsave.Location = New System.Drawing.Point(24, 197)
        Me.btntsave.Name = "btntsave"
        Me.btntsave.Size = New System.Drawing.Size(72, 25)
        Me.btntsave.TabIndex = 617
        Me.btntsave.Text = "add"
        Me.btntsave.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(Me.Panel10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(750, 384)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Member"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.GVmember)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(300, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(447, 378)
        Me.Panel8.TabIndex = 621
        '
        'GVmember
        '
        Me.GVmember.AllowUserToAddRows = False
        Me.GVmember.AllowUserToDeleteRows = False
        Me.GVmember.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.GVmember.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GVmember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GVmember.ColumnHeadersHeight = 32
        Me.GVmember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GVmember.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVmember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GVmember.Location = New System.Drawing.Point(0, 28)
        Me.GVmember.Name = "GVmember"
        Me.GVmember.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.GVmember.RowHeadersWidth = 30
        Me.GVmember.RowTemplate.Height = 35
        Me.GVmember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVmember.Size = New System.Drawing.Size(447, 350)
        Me.GVmember.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.GVmember.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.GVmember.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVmember.StateCommon.DataCell.Border.Width = 0
        Me.GVmember.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVmember.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVmember.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.GVmember.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.GVmember.StateCommon.HeaderColumn.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.GVmember.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.GVmember.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.GVmember.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GVmember.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.GVmember.TabIndex = 618
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.Panel9.Controls.Add(Me.btnmdelete)
        Me.Panel9.Controls.Add(Me.btnmreload)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(447, 28)
        Me.Panel9.TabIndex = 0
        '
        'btnmdelete
        '
        Me.btnmdelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmdelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmdelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmdelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmdelete.ForeColor = System.Drawing.Color.White
        Me.btnmdelete.Location = New System.Drawing.Point(346, 0)
        Me.btnmdelete.Name = "btnmdelete"
        Me.btnmdelete.Size = New System.Drawing.Size(72, 26)
        Me.btnmdelete.TabIndex = 614
        Me.btnmdelete.Text = "delete"
        Me.btnmdelete.UseVisualStyleBackColor = False
        '
        'btnmreload
        '
        Me.btnmreload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmreload.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmreload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmreload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmreload.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmreload.ForeColor = System.Drawing.Color.White
        Me.btnmreload.Location = New System.Drawing.Point(268, 0)
        Me.btnmreload.Name = "btnmreload"
        Me.btnmreload.Size = New System.Drawing.Size(72, 26)
        Me.btnmreload.TabIndex = 613
        Me.btnmreload.Text = "reload"
        Me.btnmreload.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel10.Controls.Add(Me.tboxteam)
        Me.Panel10.Controls.Add(Me.KryptonLabel5)
        Me.Panel10.Controls.Add(Me.cboxpersonnel)
        Me.Panel10.Controls.Add(Me.btnmsave)
        Me.Panel10.Controls.Add(Me.KryptonLabel6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(3, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(297, 378)
        Me.Panel10.TabIndex = 622
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
        Me.tboxteam.Enabled = False
        Me.tboxteam.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tboxteam.ForeColor = System.Drawing.Color.Black
        Me.tboxteam.Lines = New String(-1) {}
        Me.tboxteam.Location = New System.Drawing.Point(23, 77)
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
        Me.tboxteam.TabIndex = 618
        Me.tboxteam.UseCustomForeColor = True
        Me.tboxteam.UseSelectable = True
        Me.tboxteam.WaterMark = "name"
        Me.tboxteam.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tboxteam.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(23, 51)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 570
        Me.KryptonLabel5.Values.Text = "Team Name :"
        '
        'cboxpersonnel
        '
        Me.cboxpersonnel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxpersonnel.FormattingEnabled = True
        Me.cboxpersonnel.Location = New System.Drawing.Point(24, 144)
        Me.cboxpersonnel.Name = "cboxpersonnel"
        Me.cboxpersonnel.Size = New System.Drawing.Size(255, 25)
        Me.cboxpersonnel.TabIndex = 571
        '
        'btnmsave
        '
        Me.btnmsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnmsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmsave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmsave.ForeColor = System.Drawing.Color.White
        Me.btnmsave.Location = New System.Drawing.Point(24, 197)
        Me.btnmsave.Name = "btnmsave"
        Me.btnmsave.Size = New System.Drawing.Size(72, 25)
        Me.btnmsave.TabIndex = 617
        Me.btnmsave.Text = "add"
        Me.btnmsave.UseVisualStyleBackColor = False
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(24, 118)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 572
        Me.KryptonLabel6.Values.Text = "Personnel :"
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Button1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 375)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(758, 47)
        Me.Panel11.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRMpersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FRMpersonnel"
        Me.Text = "FRMpersonnel"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GVpersonnel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GVteam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.GVmember, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tboxfullname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboxposition As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GVpersonnel As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents btnpcancel As Button
    Friend WithEvents btnpsave As Button
    Friend WithEvents btnpdelete As Button
    Friend WithEvents btnpreload As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GVteam As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btntdelete As Button
    Friend WithEvents btntreload As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents tboxteamname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btntcancel As Button
    Friend WithEvents btntsave As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents GVmember As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnmdelete As Button
    Friend WithEvents btnmreload As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboxpersonnel As ComboBox
    Friend WithEvents btnmsave As Button
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents btnpedit As Button
    Friend WithEvents btntedit As Button
    Friend WithEvents tboxteam As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button1 As Button
End Class
