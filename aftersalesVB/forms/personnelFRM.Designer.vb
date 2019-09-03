<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class personnelFRM
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.personnelGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.teamgv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.team = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.calldategen = New MetroFramework.Controls.MetroDateTime()
        Me.teamdate = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.personnelGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.teamgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'personnelGRID
        '
        Me.personnelGRID.AllowUserToAddRows = False
        Me.personnelGRID.AllowUserToDeleteRows = False
        Me.personnelGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.personnelGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.personnelGRID.ColumnHeadersHeight = 32
        Me.personnelGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.personnelGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.personnelGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.personnelGRID.Location = New System.Drawing.Point(0, 0)
        Me.personnelGRID.MultiSelect = False
        Me.personnelGRID.Name = "personnelGRID"
        Me.personnelGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.personnelGRID.RowHeadersWidth = 30
        Me.personnelGRID.RowTemplate.Height = 30
        Me.personnelGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.personnelGRID.Size = New System.Drawing.Size(147, 353)
        Me.personnelGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.personnelGRID.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control
        Me.personnelGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.personnelGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.personnelGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personnelGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.personnelGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.personnelGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.personnelGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.personnelGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.personnelGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.personnelGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personnelGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.personnelGRID.TabIndex = 556
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.personnelGRID)
        Me.Panel1.Location = New System.Drawing.Point(711, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 355)
        Me.Panel1.TabIndex = 559
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(711, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 560
        Me.Label1.Text = "manage :"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(711, 12)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(110, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 561
        Me.KryptonLabel5.Values.Text = "LIst of Personnel"
        '
        'newbtn
        '
        Me.newbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.newbtn.Location = New System.Drawing.Point(867, 52)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(105, 23)
        Me.newbtn.TabIndex = 562
        Me.newbtn.Text = "new"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(867, 81)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(105, 23)
        Me.refreshbtn.TabIndex = 563
        Me.refreshbtn.Text = "reload"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.teamgv)
        Me.Panel2.Location = New System.Drawing.Point(22, 199)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 206)
        Me.Panel2.TabIndex = 564
        '
        'teamgv
        '
        Me.teamgv.AllowUserToAddRows = False
        Me.teamgv.AllowUserToDeleteRows = False
        Me.teamgv.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.teamgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.teamgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.teamgv.ColumnHeadersHeight = 32
        Me.teamgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teamgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teamgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.teamgv.Location = New System.Drawing.Point(0, 0)
        Me.teamgv.MultiSelect = False
        Me.teamgv.Name = "teamgv"
        Me.teamgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.teamgv.RowHeadersWidth = 30
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.teamgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.teamgv.RowTemplate.Height = 30
        Me.teamgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.teamgv.Size = New System.Drawing.Size(551, 204)
        Me.teamgv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.teamgv.StateCommon.Background.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control
        Me.teamgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.teamgv.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.teamgv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamgv.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.teamgv.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.teamgv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.teamgv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.teamgv.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.teamgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.teamgv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamgv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.teamgv.TabIndex = 557
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(581, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 575
        Me.Button2.Text = "refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 26)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(83, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 565
        Me.KryptonLabel1.Values.Text = "Create team"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(15, 17)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(90, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 568
        Me.KryptonLabel3.Values.Text = "Team name :"
        '
        'team
        '
        '
        '
        '
        Me.team.CustomButton.Image = Nothing
        Me.team.CustomButton.Location = New System.Drawing.Point(227, 1)
        Me.team.CustomButton.Name = ""
        Me.team.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.team.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.team.CustomButton.TabIndex = 1
        Me.team.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.team.CustomButton.UseSelectable = True
        Me.team.CustomButton.Visible = False
        Me.team.DisplayIcon = True
        Me.team.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.team.ForeColor = System.Drawing.Color.Black
        Me.team.Lines = New String(-1) {}
        Me.team.Location = New System.Drawing.Point(111, 17)
        Me.team.MaxLength = 32767
        Me.team.Name = "team"
        Me.team.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.team.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.team.SelectedText = ""
        Me.team.SelectionLength = 0
        Me.team.SelectionStart = 0
        Me.team.ShowClearButton = True
        Me.team.Size = New System.Drawing.Size(255, 29)
        Me.team.Style = MetroFramework.MetroColorStyle.Red
        Me.team.TabIndex = 566
        Me.team.UseCustomForeColor = True
        Me.team.UseSelectable = True
        Me.team.WaterMark = "team"
        Me.team.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.team.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(58, 52)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(47, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 572
        Me.KryptonLabel4.Values.Text = "Date :"
        '
        'calldategen
        '
        Me.calldategen.CustomFormat = "yyyy-MMM-dd"
        Me.calldategen.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calldategen.Location = New System.Drawing.Point(111, 52)
        Me.calldategen.MinimumSize = New System.Drawing.Size(0, 25)
        Me.calldategen.Name = "calldategen"
        Me.calldategen.Size = New System.Drawing.Size(126, 25)
        Me.calldategen.Style = MetroFramework.MetroColorStyle.Red
        Me.calldategen.TabIndex = 570
        '
        'teamdate
        '
        '
        '
        '
        Me.teamdate.CustomButton.Image = Nothing
        Me.teamdate.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.teamdate.CustomButton.Name = ""
        Me.teamdate.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.teamdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.teamdate.CustomButton.TabIndex = 1
        Me.teamdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.teamdate.CustomButton.UseSelectable = True
        Me.teamdate.CustomButton.Visible = False
        Me.teamdate.DisplayIcon = True
        Me.teamdate.Lines = New String(-1) {}
        Me.teamdate.Location = New System.Drawing.Point(243, 52)
        Me.teamdate.MaxLength = 32767
        Me.teamdate.Name = "teamdate"
        Me.teamdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.teamdate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.teamdate.SelectedText = ""
        Me.teamdate.SelectionLength = 0
        Me.teamdate.SelectionStart = 0
        Me.teamdate.ShowClearButton = True
        Me.teamdate.Size = New System.Drawing.Size(123, 27)
        Me.teamdate.Style = MetroFramework.MetroColorStyle.Teal
        Me.teamdate.TabIndex = 571
        Me.teamdate.UseCustomForeColor = True
        Me.teamdate.UseSelectable = True
        Me.teamdate.UseStyleColors = True
        Me.teamdate.WaterMark = "team date"
        Me.teamdate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.teamdate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Controls.Add(Me.KryptonLabel4)
        Me.Panel3.Controls.Add(Me.team)
        Me.Panel3.Controls.Add(Me.calldategen)
        Me.Panel3.Controls.Add(Me.teamdate)
        Me.Panel3.Location = New System.Drawing.Point(23, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 104)
        Me.Panel3.TabIndex = 573
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(581, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 573
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(23, 174)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(80, 20)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 574
        Me.KryptonLabel2.Values.Text = "teams table"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(693, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1, 409)
        Me.Panel4.TabIndex = 575
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(581, 81)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 576
        Me.Button3.Text = "update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'personnelFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 424)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "personnelFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Personnel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.personnelGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.teamgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents personnelGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents newbtn As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents teamgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents team As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents calldategen As MetroFramework.Controls.MetroDateTime
    Friend WithEvents teamdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button3 As Button
End Class
