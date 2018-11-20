<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newcallinFRM
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newcallinFRM))
        Me.calldate = New MetroFramework.Controls.MetroTextBox()
        Me.calldategen = New MetroFramework.Controls.MetroDateTime()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.callername = New MetroFramework.Controls.MetroTextBox()
        Me.metroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.faxno = New MetroFramework.Controls.MetroTextBox()
        Me.telno = New MetroFramework.Controls.MetroTextBox()
        Me.jo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.address = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.projectname = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.answerGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.questionGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.updateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.addBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.cin = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.answerGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.questionGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calldate
        '
        '
        '
        '
        Me.calldate.CustomButton.Image = Nothing
        Me.calldate.CustomButton.Location = New System.Drawing.Point(246, 2)
        Me.calldate.CustomButton.Name = ""
        Me.calldate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.calldate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.calldate.CustomButton.TabIndex = 1
        Me.calldate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.calldate.CustomButton.UseSelectable = True
        Me.calldate.CustomButton.Visible = False
        Me.calldate.DisplayIcon = True
        Me.calldate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.calldate.Lines = New String(-1) {}
        Me.calldate.Location = New System.Drawing.Point(160, 64)
        Me.calldate.MaxLength = 32767
        Me.calldate.Name = "calldate"
        Me.calldate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.calldate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.calldate.SelectedText = ""
        Me.calldate.SelectionLength = 0
        Me.calldate.SelectionStart = 0
        Me.calldate.ShowClearButton = True
        Me.calldate.Size = New System.Drawing.Size(276, 32)
        Me.calldate.Style = MetroFramework.MetroColorStyle.Red
        Me.calldate.TabIndex = 12
        Me.calldate.UseCustomForeColor = True
        Me.calldate.UseSelectable = True
        Me.calldate.WaterMark = "Enter Call in Date"
        Me.calldate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.calldate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'calldategen
        '
        Me.calldategen.CustomFormat = "yyyy-MMM-dd"
        Me.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calldategen.Location = New System.Drawing.Point(28, 64)
        Me.calldategen.MinimumSize = New System.Drawing.Size(0, 29)
        Me.calldategen.Name = "calldategen"
        Me.calldategen.Size = New System.Drawing.Size(126, 29)
        Me.calldategen.Style = MetroFramework.MetroColorStyle.Red
        Me.calldategen.TabIndex = 11
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(28, 25)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(150, 26)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 13
        Me.KryptonLabel1.Values.Text = "Callers Information"
        '
        'callername
        '
        '
        '
        '
        Me.callername.CustomButton.Image = Nothing
        Me.callername.CustomButton.Location = New System.Drawing.Point(378, 2)
        Me.callername.CustomButton.Name = ""
        Me.callername.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.callername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.callername.CustomButton.TabIndex = 1
        Me.callername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.callername.CustomButton.UseSelectable = True
        Me.callername.CustomButton.Visible = False
        Me.callername.DisplayIcon = True
        Me.callername.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.callername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.callername.Lines = New String(-1) {}
        Me.callername.Location = New System.Drawing.Point(28, 102)
        Me.callername.MaxLength = 32767
        Me.callername.Name = "callername"
        Me.callername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.callername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.callername.SelectedText = ""
        Me.callername.SelectionLength = 0
        Me.callername.SelectionStart = 0
        Me.callername.ShowClearButton = True
        Me.callername.Size = New System.Drawing.Size(408, 32)
        Me.callername.Style = MetroFramework.MetroColorStyle.Red
        Me.callername.TabIndex = 14
        Me.callername.UseCustomForeColor = True
        Me.callername.UseSelectable = True
        Me.callername.WaterMark = "Enter Caller Name"
        Me.callername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.callername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'metroTextButton1
        '
        Me.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.metroTextButton1.Image = Nothing
        Me.metroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton1.Location = New System.Drawing.Point(28, 163)
        Me.metroTextButton1.Name = "metroTextButton1"
        Me.metroTextButton1.Size = New System.Drawing.Size(150, 24)
        Me.metroTextButton1.Style = MetroFramework.MetroColorStyle.Silver
        Me.metroTextButton1.TabIndex = 481
        Me.metroTextButton1.Text = "select project"
        Me.metroTextButton1.UseCustomForeColor = True
        Me.metroTextButton1.UseSelectable = True
        Me.metroTextButton1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.KryptonLabel4)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.KryptonLabel2)
        Me.Panel1.Controls.Add(Me.cin)
        Me.Panel1.Controls.Add(Me.faxno)
        Me.Panel1.Controls.Add(Me.telno)
        Me.Panel1.Controls.Add(Me.jo)
        Me.Panel1.Controls.Add(Me.address)
        Me.Panel1.Controls.Add(Me.projectname)
        Me.Panel1.Controls.Add(Me.answerGV)
        Me.Panel1.Controls.Add(Me.questionGRID)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.metroTextButton1)
        Me.Panel1.Controls.Add(Me.calldategen)
        Me.Panel1.Controls.Add(Me.callername)
        Me.Panel1.Controls.Add(Me.calldate)
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 588)
        Me.Panel1.TabIndex = 482
        '
        'faxno
        '
        '
        '
        '
        Me.faxno.CustomButton.Image = Nothing
        Me.faxno.CustomButton.Location = New System.Drawing.Point(294, 2)
        Me.faxno.CustomButton.Name = ""
        Me.faxno.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.faxno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.faxno.CustomButton.TabIndex = 1
        Me.faxno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.faxno.CustomButton.UseSelectable = True
        Me.faxno.CustomButton.Visible = False
        Me.faxno.DisplayIcon = True
        Me.faxno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.faxno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.faxno.Lines = New String(-1) {}
        Me.faxno.Location = New System.Drawing.Point(538, 102)
        Me.faxno.MaxLength = 32767
        Me.faxno.Name = "faxno"
        Me.faxno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.faxno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.faxno.SelectedText = ""
        Me.faxno.SelectionLength = 0
        Me.faxno.SelectionStart = 0
        Me.faxno.ShowClearButton = True
        Me.faxno.Size = New System.Drawing.Size(324, 32)
        Me.faxno.Style = MetroFramework.MetroColorStyle.Red
        Me.faxno.TabIndex = 490
        Me.faxno.UseCustomForeColor = True
        Me.faxno.UseSelectable = True
        Me.faxno.WaterMark = "Enter Fax No"
        Me.faxno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.faxno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'telno
        '
        '
        '
        '
        Me.telno.CustomButton.Image = Nothing
        Me.telno.CustomButton.Location = New System.Drawing.Point(294, 2)
        Me.telno.CustomButton.Name = ""
        Me.telno.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.telno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.telno.CustomButton.TabIndex = 1
        Me.telno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.telno.CustomButton.UseSelectable = True
        Me.telno.CustomButton.Visible = False
        Me.telno.DisplayIcon = True
        Me.telno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.telno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.telno.Lines = New String(-1) {}
        Me.telno.Location = New System.Drawing.Point(538, 64)
        Me.telno.MaxLength = 32767
        Me.telno.Name = "telno"
        Me.telno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.telno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.telno.SelectedText = ""
        Me.telno.SelectionLength = 0
        Me.telno.SelectionStart = 0
        Me.telno.ShowClearButton = True
        Me.telno.Size = New System.Drawing.Size(324, 32)
        Me.telno.Style = MetroFramework.MetroColorStyle.Red
        Me.telno.TabIndex = 489
        Me.telno.UseCustomForeColor = True
        Me.telno.UseSelectable = True
        Me.telno.WaterMark = "Enter Tel No"
        Me.telno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.telno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'jo
        '
        Me.jo.Location = New System.Drawing.Point(28, 279)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(93, 22)
        Me.jo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.jo.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jo.TabIndex = 486
        Me.jo.Values.Text = "Job Order No"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(28, 247)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(70, 26)
        Me.address.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.address.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.TabIndex = 485
        Me.address.Values.Text = "Address"
        '
        'projectname
        '
        Me.projectname.Location = New System.Drawing.Point(28, 207)
        Me.projectname.Name = "projectname"
        Me.projectname.Size = New System.Drawing.Size(145, 34)
        Me.projectname.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectname.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectname.TabIndex = 484
        Me.projectname.Values.Text = "Project Name"
        '
        'answerGV
        '
        Me.answerGV.AllowUserToAddRows = False
        Me.answerGV.AllowUserToDeleteRows = False
        Me.answerGV.AllowUserToOrderColumns = True
        Me.answerGV.AllowUserToResizeColumns = False
        Me.answerGV.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.answerGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.answerGV.ColumnHeadersHeight = 30
        Me.answerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.answerGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.answerGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.answerGV.Location = New System.Drawing.Point(442, 323)
        Me.answerGV.MultiSelect = False
        Me.answerGV.Name = "answerGV"
        Me.answerGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.answerGV.ReadOnly = True
        Me.answerGV.RowHeadersVisible = False
        Me.answerGV.RowHeadersWidth = 40
        Me.answerGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.answerGV.RowTemplate.Height = 27
        Me.answerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.answerGV.Size = New System.Drawing.Size(420, 433)
        Me.answerGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.answerGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.answerGV.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.answerGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.answerGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.answerGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.answerGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.answerGV.TabIndex = 483
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'questionGRID
        '
        Me.questionGRID.AllowUserToAddRows = False
        Me.questionGRID.AllowUserToDeleteRows = False
        Me.questionGRID.AllowUserToOrderColumns = True
        Me.questionGRID.AllowUserToResizeColumns = False
        Me.questionGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.questionGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.questionGRID.ColumnHeadersHeight = 30
        Me.questionGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.questionGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.questionGRID.Location = New System.Drawing.Point(28, 323)
        Me.questionGRID.MultiSelect = False
        Me.questionGRID.Name = "questionGRID"
        Me.questionGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.questionGRID.ReadOnly = True
        Me.questionGRID.RowHeadersVisible = False
        Me.questionGRID.RowHeadersWidth = 40
        Me.questionGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.questionGRID.RowTemplate.Height = 40
        Me.questionGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.questionGRID.Size = New System.Drawing.Size(408, 433)
        Me.questionGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.questionGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.questionGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.questionGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.questionGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(-1, 10, -1, 10)
        Me.questionGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.questionGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.questionGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.questionGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.questionGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.questionGRID.TabIndex = 482
        '
        'updateBTN
        '
        Me.updateBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBTN.Image = Nothing
        Me.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.updateBTN.Location = New System.Drawing.Point(797, 664)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Size = New System.Drawing.Size(98, 35)
        Me.updateBTN.Style = MetroFramework.MetroColorStyle.Green
        Me.updateBTN.TabIndex = 488
        Me.updateBTN.Text = "save"
        Me.updateBTN.UseSelectable = True
        Me.updateBTN.UseVisualStyleBackColor = True
        Me.updateBTN.Visible = False
        '
        'addBTN
        '
        Me.addBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBTN.Image = CType(resources.GetObject("addBTN.Image"), System.Drawing.Image)
        Me.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addBTN.Location = New System.Drawing.Point(797, 664)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(98, 35)
        Me.addBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.addBTN.TabIndex = 487
        Me.addBTN.Text = "add"
        Me.addBTN.UseSelectable = True
        Me.addBTN.UseVisualStyleBackColor = True
        Me.addBTN.Visible = False
        '
        'cin
        '
        '
        '
        '
        Me.cin.CustomButton.Image = Nothing
        Me.cin.CustomButton.Location = New System.Drawing.Point(134, 2)
        Me.cin.CustomButton.Name = ""
        Me.cin.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.cin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cin.CustomButton.TabIndex = 1
        Me.cin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cin.CustomButton.UseSelectable = True
        Me.cin.CustomButton.Visible = False
        Me.cin.DisplayIcon = True
        Me.cin.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.cin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cin.Lines = New String(-1) {}
        Me.cin.Location = New System.Drawing.Point(698, 25)
        Me.cin.MaxLength = 32767
        Me.cin.Name = "cin"
        Me.cin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cin.SelectedText = ""
        Me.cin.SelectionLength = 0
        Me.cin.SelectionStart = 0
        Me.cin.ShowClearButton = True
        Me.cin.Size = New System.Drawing.Size(164, 32)
        Me.cin.Style = MetroFramework.MetroColorStyle.Red
        Me.cin.TabIndex = 491
        Me.cin.UseCustomForeColor = True
        Me.cin.UseSelectable = True
        Me.cin.WaterMark = "CIN"
        Me.cin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(479, 64)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(51, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 492
        Me.KryptonLabel2.Values.Text = "Tel No"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(479, 102)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(53, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 493
        Me.KryptonLabel3.Values.Text = "Fax No"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(661, 25)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(31, 22)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 494
        Me.KryptonLabel4.Values.Text = "Cin"
        '
        'newcallinFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 722)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.updateBTN)
        Me.Controls.Add(Me.addBTN)
        Me.Name = "newcallinFRM"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.answerGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.questionGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents calldate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents calldategen As MetroFramework.Controls.MetroDateTime
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents callername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents metroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents answerGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents questionGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents address As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents projectname As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents jo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents addBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents updateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents faxno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents telno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
