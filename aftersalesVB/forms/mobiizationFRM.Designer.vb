<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mobiizationFRM
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mobGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.smileage = New MetroFramework.Controls.MetroTextBox()
        Me.emileage = New MetroFramework.Controls.MetroTextBox()
        Me.tollfee = New MetroFramework.Controls.MetroTextBox()
        Me.busfare = New MetroFramework.Controls.MetroTextBox()
        Me.airfare = New MetroFramework.Controls.MetroTextBox()
        Me.overtime = New MetroFramework.Controls.MetroTextBox()
        Me.meals = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.plateno = New MetroFramework.Controls.MetroTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.calldategen = New MetroFramework.Controls.MetroDateTime()
        Me.dated = New MetroFramework.Controls.MetroTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.insertbtn = New System.Windows.Forms.Button()
        Me.teamcombo = New System.Windows.Forms.ComboBox()
        Me.teamid = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.mobGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MOBILIZATION COST"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.mobGRID)
        Me.Panel1.Location = New System.Drawing.Point(367, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 511)
        Me.Panel1.TabIndex = 1
        '
        'mobGRID
        '
        Me.mobGRID.AllowUserToAddRows = False
        Me.mobGRID.AllowUserToDeleteRows = False
        Me.mobGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.mobGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.mobGRID.ColumnHeadersHeight = 32
        Me.mobGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mobGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mobGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.mobGRID.Location = New System.Drawing.Point(0, 0)
        Me.mobGRID.Name = "mobGRID"
        Me.mobGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.mobGRID.RowHeadersWidth = 30
        Me.mobGRID.RowTemplate.Height = 30
        Me.mobGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.mobGRID.Size = New System.Drawing.Size(564, 509)
        Me.mobGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.mobGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.mobGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.mobGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.mobGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.mobGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.mobGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.mobGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.mobGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.mobGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.mobGRID.TabIndex = 561
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inhouse Service :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Gas (MILEAGE) :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Start :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "End :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Toll Fees :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Bus Fare :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Air Fare :"
        '
        'smileage
        '
        '
        '
        '
        Me.smileage.CustomButton.Image = Nothing
        Me.smileage.CustomButton.Location = New System.Drawing.Point(76, 1)
        Me.smileage.CustomButton.Name = ""
        Me.smileage.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.smileage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.smileage.CustomButton.TabIndex = 1
        Me.smileage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.smileage.CustomButton.UseSelectable = True
        Me.smileage.CustomButton.Visible = False
        Me.smileage.DisplayIcon = True
        Me.smileage.Lines = New String(-1) {}
        Me.smileage.Location = New System.Drawing.Point(21, 192)
        Me.smileage.MaxLength = 32767
        Me.smileage.Name = "smileage"
        Me.smileage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.smileage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.smileage.SelectedText = ""
        Me.smileage.SelectionLength = 0
        Me.smileage.SelectionStart = 0
        Me.smileage.ShowClearButton = True
        Me.smileage.Size = New System.Drawing.Size(102, 27)
        Me.smileage.Style = MetroFramework.MetroColorStyle.Teal
        Me.smileage.TabIndex = 508
        Me.smileage.UseCustomForeColor = True
        Me.smileage.UseSelectable = True
        Me.smileage.UseStyleColors = True
        Me.smileage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.smileage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'emileage
        '
        '
        '
        '
        Me.emileage.CustomButton.Image = Nothing
        Me.emileage.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.emileage.CustomButton.Name = ""
        Me.emileage.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.emileage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.emileage.CustomButton.TabIndex = 1
        Me.emileage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.emileage.CustomButton.UseSelectable = True
        Me.emileage.CustomButton.Visible = False
        Me.emileage.DisplayIcon = True
        Me.emileage.Lines = New String(-1) {}
        Me.emileage.Location = New System.Drawing.Point(129, 192)
        Me.emileage.MaxLength = 32767
        Me.emileage.Name = "emileage"
        Me.emileage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.emileage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.emileage.SelectedText = ""
        Me.emileage.SelectionLength = 0
        Me.emileage.SelectionStart = 0
        Me.emileage.ShowClearButton = True
        Me.emileage.Size = New System.Drawing.Size(109, 27)
        Me.emileage.Style = MetroFramework.MetroColorStyle.Teal
        Me.emileage.TabIndex = 509
        Me.emileage.UseCustomForeColor = True
        Me.emileage.UseSelectable = True
        Me.emileage.UseStyleColors = True
        Me.emileage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.emileage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tollfee
        '
        '
        '
        '
        Me.tollfee.CustomButton.Image = Nothing
        Me.tollfee.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.tollfee.CustomButton.Name = ""
        Me.tollfee.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tollfee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tollfee.CustomButton.TabIndex = 1
        Me.tollfee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tollfee.CustomButton.UseSelectable = True
        Me.tollfee.CustomButton.Visible = False
        Me.tollfee.DisplayIcon = True
        Me.tollfee.Lines = New String(-1) {}
        Me.tollfee.Location = New System.Drawing.Point(129, 231)
        Me.tollfee.MaxLength = 32767
        Me.tollfee.Name = "tollfee"
        Me.tollfee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tollfee.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tollfee.SelectedText = ""
        Me.tollfee.SelectionLength = 0
        Me.tollfee.SelectionStart = 0
        Me.tollfee.ShowClearButton = True
        Me.tollfee.Size = New System.Drawing.Size(109, 27)
        Me.tollfee.Style = MetroFramework.MetroColorStyle.Teal
        Me.tollfee.TabIndex = 510
        Me.tollfee.UseCustomForeColor = True
        Me.tollfee.UseSelectable = True
        Me.tollfee.UseStyleColors = True
        Me.tollfee.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tollfee.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'busfare
        '
        '
        '
        '
        Me.busfare.CustomButton.Image = Nothing
        Me.busfare.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.busfare.CustomButton.Name = ""
        Me.busfare.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.busfare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.busfare.CustomButton.TabIndex = 1
        Me.busfare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.busfare.CustomButton.UseSelectable = True
        Me.busfare.CustomButton.Visible = False
        Me.busfare.DisplayIcon = True
        Me.busfare.Lines = New String(-1) {}
        Me.busfare.Location = New System.Drawing.Point(129, 264)
        Me.busfare.MaxLength = 32767
        Me.busfare.Name = "busfare"
        Me.busfare.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.busfare.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.busfare.SelectedText = ""
        Me.busfare.SelectionLength = 0
        Me.busfare.SelectionStart = 0
        Me.busfare.ShowClearButton = True
        Me.busfare.Size = New System.Drawing.Size(109, 27)
        Me.busfare.Style = MetroFramework.MetroColorStyle.Teal
        Me.busfare.TabIndex = 511
        Me.busfare.UseCustomForeColor = True
        Me.busfare.UseSelectable = True
        Me.busfare.UseStyleColors = True
        Me.busfare.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.busfare.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'airfare
        '
        '
        '
        '
        Me.airfare.CustomButton.Image = Nothing
        Me.airfare.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.airfare.CustomButton.Name = ""
        Me.airfare.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.airfare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.airfare.CustomButton.TabIndex = 1
        Me.airfare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.airfare.CustomButton.UseSelectable = True
        Me.airfare.CustomButton.Visible = False
        Me.airfare.DisplayIcon = True
        Me.airfare.Lines = New String(-1) {}
        Me.airfare.Location = New System.Drawing.Point(129, 297)
        Me.airfare.MaxLength = 32767
        Me.airfare.Name = "airfare"
        Me.airfare.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.airfare.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.airfare.SelectedText = ""
        Me.airfare.SelectionLength = 0
        Me.airfare.SelectionStart = 0
        Me.airfare.ShowClearButton = True
        Me.airfare.Size = New System.Drawing.Size(109, 27)
        Me.airfare.Style = MetroFramework.MetroColorStyle.Teal
        Me.airfare.TabIndex = 512
        Me.airfare.UseCustomForeColor = True
        Me.airfare.UseSelectable = True
        Me.airfare.UseStyleColors = True
        Me.airfare.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.airfare.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'overtime
        '
        '
        '
        '
        Me.overtime.CustomButton.Image = Nothing
        Me.overtime.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.overtime.CustomButton.Name = ""
        Me.overtime.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.overtime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.overtime.CustomButton.TabIndex = 1
        Me.overtime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.overtime.CustomButton.UseSelectable = True
        Me.overtime.CustomButton.Visible = False
        Me.overtime.DisplayIcon = True
        Me.overtime.Lines = New String(-1) {}
        Me.overtime.Location = New System.Drawing.Point(129, 390)
        Me.overtime.MaxLength = 32767
        Me.overtime.Name = "overtime"
        Me.overtime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.overtime.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.overtime.SelectedText = ""
        Me.overtime.SelectionLength = 0
        Me.overtime.SelectionStart = 0
        Me.overtime.ShowClearButton = True
        Me.overtime.Size = New System.Drawing.Size(109, 27)
        Me.overtime.Style = MetroFramework.MetroColorStyle.Teal
        Me.overtime.TabIndex = 516
        Me.overtime.UseCustomForeColor = True
        Me.overtime.UseSelectable = True
        Me.overtime.UseStyleColors = True
        Me.overtime.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.overtime.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'meals
        '
        '
        '
        '
        Me.meals.CustomButton.Image = Nothing
        Me.meals.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.meals.CustomButton.Name = ""
        Me.meals.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.meals.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.meals.CustomButton.TabIndex = 1
        Me.meals.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.meals.CustomButton.UseSelectable = True
        Me.meals.CustomButton.Visible = False
        Me.meals.DisplayIcon = True
        Me.meals.Lines = New String(-1) {}
        Me.meals.Location = New System.Drawing.Point(129, 357)
        Me.meals.MaxLength = 32767
        Me.meals.Name = "meals"
        Me.meals.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.meals.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.meals.SelectedText = ""
        Me.meals.SelectionLength = 0
        Me.meals.SelectionStart = 0
        Me.meals.ShowClearButton = True
        Me.meals.Size = New System.Drawing.Size(109, 27)
        Me.meals.Style = MetroFramework.MetroColorStyle.Teal
        Me.meals.TabIndex = 515
        Me.meals.UseCustomForeColor = True
        Me.meals.UseSelectable = True
        Me.meals.UseStyleColors = True
        Me.meals.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.meals.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 514
        Me.Label9.Text = "Overtime :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 513
        Me.Label10.Text = "Meals :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.teamid)
        Me.Panel2.Controls.Add(Me.teamcombo)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.plateno)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.calldategen)
        Me.Panel2.Controls.Add(Me.dated)
        Me.Panel2.Controls.Add(Me.overtime)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.meals)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.airfare)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.busfare)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tollfee)
        Me.Panel2.Controls.Add(Me.smileage)
        Me.Panel2.Controls.Add(Me.emileage)
        Me.Panel2.Location = New System.Drawing.Point(14, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(266, 511)
        Me.Panel2.TabIndex = 517
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 439)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 595
        Me.Label15.Text = "TEAM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 330)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 594
        Me.Label14.Text = "(Others)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 13)
        Me.Label13.TabIndex = 592
        Me.Label13.Text = "Plate# :"
        '
        'plateno
        '
        '
        '
        '
        Me.plateno.CustomButton.Image = Nothing
        Me.plateno.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.plateno.CustomButton.Name = ""
        Me.plateno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.plateno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.plateno.CustomButton.TabIndex = 1
        Me.plateno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.plateno.CustomButton.UseSelectable = True
        Me.plateno.CustomButton.Visible = False
        Me.plateno.DisplayIcon = True
        Me.plateno.Lines = New String(-1) {}
        Me.plateno.Location = New System.Drawing.Point(129, 102)
        Me.plateno.MaxLength = 32767
        Me.plateno.Name = "plateno"
        Me.plateno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.plateno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.plateno.SelectedText = ""
        Me.plateno.SelectionLength = 0
        Me.plateno.SelectionStart = 0
        Me.plateno.ShowClearButton = True
        Me.plateno.Size = New System.Drawing.Size(109, 27)
        Me.plateno.Style = MetroFramework.MetroColorStyle.Teal
        Me.plateno.TabIndex = 593
        Me.plateno.UseCustomForeColor = True
        Me.plateno.UseSelectable = True
        Me.plateno.UseStyleColors = True
        Me.plateno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.plateno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 591
        Me.Label11.Text = "Date"
        '
        'calldategen
        '
        Me.calldategen.CustomFormat = "yyyy-MMM-dd"
        Me.calldategen.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calldategen.Location = New System.Drawing.Point(21, 47)
        Me.calldategen.MinimumSize = New System.Drawing.Size(0, 25)
        Me.calldategen.Name = "calldategen"
        Me.calldategen.Size = New System.Drawing.Size(102, 25)
        Me.calldategen.Style = MetroFramework.MetroColorStyle.Red
        Me.calldategen.TabIndex = 589
        '
        'dated
        '
        '
        '
        '
        Me.dated.CustomButton.Image = Nothing
        Me.dated.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.dated.CustomButton.Name = ""
        Me.dated.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.dated.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dated.CustomButton.TabIndex = 1
        Me.dated.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dated.CustomButton.UseSelectable = True
        Me.dated.CustomButton.Visible = False
        Me.dated.DisplayIcon = True
        Me.dated.Lines = New String(-1) {}
        Me.dated.Location = New System.Drawing.Point(129, 47)
        Me.dated.MaxLength = 32767
        Me.dated.Name = "dated"
        Me.dated.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dated.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dated.SelectedText = ""
        Me.dated.SelectionLength = 0
        Me.dated.SelectionStart = 0
        Me.dated.ShowClearButton = True
        Me.dated.Size = New System.Drawing.Size(109, 27)
        Me.dated.Style = MetroFramework.MetroColorStyle.Teal
        Me.dated.TabIndex = 590
        Me.dated.UseCustomForeColor = True
        Me.dated.UseSelectable = True
        Me.dated.UseStyleColors = True
        Me.dated.WaterMark = "DATE"
        Me.dated.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dated.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(286, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 588
        Me.Button3.Text = "update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(939, 61)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshbtn.TabIndex = 587
        Me.refreshbtn.Text = "refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(286, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 586
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(365, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 589
        Me.Label12.Text = "Mobilization Data :"
        '
        'insertbtn
        '
        Me.insertbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.insertbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.insertbtn.Location = New System.Drawing.Point(939, 90)
        Me.insertbtn.Name = "insertbtn"
        Me.insertbtn.Size = New System.Drawing.Size(75, 23)
        Me.insertbtn.TabIndex = 590
        Me.insertbtn.Text = "insert"
        Me.insertbtn.UseVisualStyleBackColor = True
        Me.insertbtn.Visible = False
        '
        'teamcombo
        '
        Me.teamcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.teamcombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamcombo.FormattingEnabled = True
        Me.teamcombo.Location = New System.Drawing.Point(71, 434)
        Me.teamcombo.Name = "teamcombo"
        Me.teamcombo.Size = New System.Drawing.Size(167, 24)
        Me.teamcombo.TabIndex = 596
        '
        'teamid
        '
        '
        '
        '
        Me.teamid.CustomButton.Image = Nothing
        Me.teamid.CustomButton.Location = New System.Drawing.Point(83, 1)
        Me.teamid.CustomButton.Name = ""
        Me.teamid.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.teamid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.teamid.CustomButton.TabIndex = 1
        Me.teamid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.teamid.CustomButton.UseSelectable = True
        Me.teamid.CustomButton.Visible = False
        Me.teamid.DisplayIcon = True
        Me.teamid.Enabled = False
        Me.teamid.Lines = New String(-1) {}
        Me.teamid.Location = New System.Drawing.Point(129, 464)
        Me.teamid.MaxLength = 32767
        Me.teamid.Name = "teamid"
        Me.teamid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.teamid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.teamid.SelectedText = ""
        Me.teamid.SelectionLength = 0
        Me.teamid.SelectionStart = 0
        Me.teamid.ShowClearButton = True
        Me.teamid.Size = New System.Drawing.Size(109, 27)
        Me.teamid.Style = MetroFramework.MetroColorStyle.Teal
        Me.teamid.TabIndex = 597
        Me.teamid.UseCustomForeColor = True
        Me.teamid.UseSelectable = True
        Me.teamid.UseStyleColors = True
        Me.teamid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.teamid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'mobiizationFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 591)
        Me.Controls.Add(Me.insertbtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mobiizationFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.mobGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mobGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents smileage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents emileage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tollfee As MetroFramework.Controls.MetroTextBox
    Friend WithEvents busfare As MetroFramework.Controls.MetroTextBox
    Friend WithEvents airfare As MetroFramework.Controls.MetroTextBox
    Friend WithEvents overtime As MetroFramework.Controls.MetroTextBox
    Friend WithEvents meals As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents calldategen As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dated As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents plateno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents insertbtn As Button
    Friend WithEvents teamid As MetroFramework.Controls.MetroTextBox
    Friend WithEvents teamcombo As ComboBox
End Class
