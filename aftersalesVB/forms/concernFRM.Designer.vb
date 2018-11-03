<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class concernFRM
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.metroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.metroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.itemTXT = New MetroFramework.Controls.MetroTextBox()
        Me.questionTXT = New MetroFramework.Controls.MetroTextBox()
        Me.deleteBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.refreshBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.updateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.addBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.questionGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.metroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.question = New MetroFramework.Controls.MetroTextBox()
        Me.answerTXT = New MetroFramework.Controls.MetroTextBox()
        Me.aitemTXT = New MetroFramework.Controls.MetroTextBox()
        Me.metroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.metroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.metroTextButton4 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.metroTextButton3 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.answerGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.metroTabControl1.SuspendLayout()
        Me.metroTabPage1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.questionGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.metroTabPage2.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.answerGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'metroTabControl1
        '
        Me.metroTabControl1.Controls.Add(Me.metroTabPage1)
        Me.metroTabControl1.Controls.Add(Me.metroTabPage2)
        Me.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall
        Me.metroTabControl1.ItemSize = New System.Drawing.Size(150, 34)
        Me.metroTabControl1.Location = New System.Drawing.Point(-2, 25)
        Me.metroTabControl1.Name = "metroTabControl1"
        Me.metroTabControl1.SelectedIndex = 1
        Me.metroTabControl1.Size = New System.Drawing.Size(884, 679)
        Me.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.metroTabControl1.TabIndex = 473
        Me.metroTabControl1.UseSelectable = True
        '
        'metroTabPage1
        '
        Me.metroTabPage1.BackColor = System.Drawing.Color.White
        Me.metroTabPage1.Controls.Add(Me.panel2)
        Me.metroTabPage1.Controls.Add(Me.questionGRID)
        Me.metroTabPage1.HorizontalScrollbarBarColor = True
        Me.metroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.metroTabPage1.HorizontalScrollbarSize = 10
        Me.metroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.metroTabPage1.Name = "metroTabPage1"
        Me.metroTabPage1.Size = New System.Drawing.Size(876, 637)
        Me.metroTabPage1.TabIndex = 0
        Me.metroTabPage1.Text = "Concern"
        Me.metroTabPage1.UseCustomBackColor = True
        Me.metroTabPage1.VerticalScrollbarBarColor = True
        Me.metroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.metroTabPage1.VerticalScrollbarSize = 10
        '
        'panel2
        '
        Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel2.Controls.Add(Me.itemTXT)
        Me.panel2.Controls.Add(Me.questionTXT)
        Me.panel2.Controls.Add(Me.deleteBTN)
        Me.panel2.Controls.Add(Me.refreshBTN)
        Me.panel2.Controls.Add(Me.updateBTN)
        Me.panel2.Controls.Add(Me.addBTN)
        Me.panel2.Location = New System.Drawing.Point(13, 13)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(862, 95)
        Me.panel2.TabIndex = 472
        '
        'itemTXT
        '
        '
        '
        '
        Me.itemTXT.CustomButton.Image = Nothing
        Me.itemTXT.CustomButton.Location = New System.Drawing.Point(46, 2)
        Me.itemTXT.CustomButton.Name = ""
        Me.itemTXT.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.itemTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.itemTXT.CustomButton.TabIndex = 1
        Me.itemTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.itemTXT.CustomButton.UseSelectable = True
        Me.itemTXT.CustomButton.Visible = False
        Me.itemTXT.DisplayIcon = True
        Me.itemTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.itemTXT.Lines = New String(-1) {}
        Me.itemTXT.Location = New System.Drawing.Point(18, 15)
        Me.itemTXT.MaxLength = 32767
        Me.itemTXT.Name = "itemTXT"
        Me.itemTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itemTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.itemTXT.SelectedText = ""
        Me.itemTXT.SelectionLength = 0
        Me.itemTXT.SelectionStart = 0
        Me.itemTXT.ShowClearButton = True
        Me.itemTXT.Size = New System.Drawing.Size(74, 30)
        Me.itemTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.itemTXT.TabIndex = 470
        Me.itemTXT.UseCustomForeColor = True
        Me.itemTXT.UseSelectable = True
        Me.itemTXT.WaterMark = "Item No"
        Me.itemTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.itemTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'questionTXT
        '
        Me.questionTXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.questionTXT.CustomButton.Image = Nothing
        Me.questionTXT.CustomButton.Location = New System.Drawing.Point(719, 2)
        Me.questionTXT.CustomButton.Name = ""
        Me.questionTXT.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.questionTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.questionTXT.CustomButton.TabIndex = 1
        Me.questionTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.questionTXT.CustomButton.UseSelectable = True
        Me.questionTXT.CustomButton.Visible = False
        Me.questionTXT.DisplayIcon = True
        Me.questionTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.questionTXT.Lines = New String(-1) {}
        Me.questionTXT.Location = New System.Drawing.Point(98, 15)
        Me.questionTXT.MaxLength = 32767
        Me.questionTXT.Name = "questionTXT"
        Me.questionTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.questionTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.questionTXT.SelectedText = ""
        Me.questionTXT.SelectionLength = 0
        Me.questionTXT.SelectionStart = 0
        Me.questionTXT.ShowClearButton = True
        Me.questionTXT.Size = New System.Drawing.Size(747, 30)
        Me.questionTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.questionTXT.TabIndex = 471
        Me.questionTXT.UseCustomForeColor = True
        Me.questionTXT.UseSelectable = True
        Me.questionTXT.WaterMark = "Concern"
        Me.questionTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.questionTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'deleteBTN
        '
        Me.deleteBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBTN.Image = Nothing
        Me.deleteBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deleteBTN.Location = New System.Drawing.Point(657, 51)
        Me.deleteBTN.Name = "deleteBTN"
        Me.deleteBTN.Size = New System.Drawing.Size(91, 31)
        Me.deleteBTN.Style = MetroFramework.MetroColorStyle.Orange
        Me.deleteBTN.TabIndex = 467
        Me.deleteBTN.Text = "delete"
        Me.deleteBTN.UseSelectable = True
        Me.deleteBTN.UseVisualStyleBackColor = True
        '
        'refreshBTN
        '
        Me.refreshBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBTN.Image = Nothing
        Me.refreshBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.refreshBTN.Location = New System.Drawing.Point(754, 51)
        Me.refreshBTN.Name = "refreshBTN"
        Me.refreshBTN.Size = New System.Drawing.Size(91, 31)
        Me.refreshBTN.Style = MetroFramework.MetroColorStyle.Orange
        Me.refreshBTN.TabIndex = 19
        Me.refreshBTN.Text = "refresh"
        Me.refreshBTN.UseSelectable = True
        Me.refreshBTN.UseVisualStyleBackColor = True
        '
        'updateBTN
        '
        Me.updateBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBTN.Image = Nothing
        Me.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.updateBTN.Location = New System.Drawing.Point(560, 51)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Size = New System.Drawing.Size(91, 31)
        Me.updateBTN.Style = MetroFramework.MetroColorStyle.Orange
        Me.updateBTN.TabIndex = 468
        Me.updateBTN.Text = "update"
        Me.updateBTN.UseSelectable = True
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'addBTN
        '
        Me.addBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBTN.Image = Nothing
        Me.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addBTN.Location = New System.Drawing.Point(463, 51)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(91, 31)
        Me.addBTN.Style = MetroFramework.MetroColorStyle.Orange
        Me.addBTN.TabIndex = 469
        Me.addBTN.Text = "add"
        Me.addBTN.UseSelectable = True
        Me.addBTN.UseVisualStyleBackColor = True
        '
        'questionGRID
        '
        Me.questionGRID.AllowUserToAddRows = False
        Me.questionGRID.AllowUserToDeleteRows = False
        Me.questionGRID.AllowUserToOrderColumns = True
        Me.questionGRID.AllowUserToResizeColumns = False
        Me.questionGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.questionGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.questionGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.questionGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.questionGRID.ColumnHeadersHeight = 32
        Me.questionGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.questionGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.questionGRID.Location = New System.Drawing.Point(13, 114)
        Me.questionGRID.MultiSelect = False
        Me.questionGRID.Name = "questionGRID"
        Me.questionGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.questionGRID.ReadOnly = True
        Me.questionGRID.RowHeadersVisible = False
        Me.questionGRID.RowHeadersWidth = 40
        Me.questionGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.questionGRID.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple
        Me.questionGRID.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.questionGRID.RowTemplate.Height = 35
        Me.questionGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.questionGRID.Size = New System.Drawing.Size(863, 527)
        Me.questionGRID.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke
        Me.questionGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.questionGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.questionGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.questionGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(-1, 10, -1, 10)
        Me.questionGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.questionGRID.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None
        Me.questionGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.questionGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.DimGray
        Me.questionGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.questionGRID.TabIndex = 466
        '
        'metroTabPage2
        '
        Me.metroTabPage2.Controls.Add(Me.panel1)
        Me.metroTabPage2.Controls.Add(Me.answerGRID)
        Me.metroTabPage2.HorizontalScrollbarBarColor = True
        Me.metroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.metroTabPage2.HorizontalScrollbarSize = 10
        Me.metroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.metroTabPage2.Name = "metroTabPage2"
        Me.metroTabPage2.Size = New System.Drawing.Size(876, 637)
        Me.metroTabPage2.TabIndex = 1
        Me.metroTabPage2.Text = "Problem"
        Me.metroTabPage2.VerticalScrollbarBarColor = True
        Me.metroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.metroTabPage2.VerticalScrollbarSize = 10
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel1.Controls.Add(Me.question)
        Me.panel1.Controls.Add(Me.answerTXT)
        Me.panel1.Controls.Add(Me.aitemTXT)
        Me.panel1.Controls.Add(Me.metroTextButton2)
        Me.panel1.Controls.Add(Me.metroTextButton1)
        Me.panel1.Controls.Add(Me.metroTextButton4)
        Me.panel1.Controls.Add(Me.metroTextButton3)
        Me.panel1.Location = New System.Drawing.Point(10, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(861, 133)
        Me.panel1.TabIndex = 480
        '
        'question
        '
        Me.question.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.question.CustomButton.Image = Nothing
        Me.question.CustomButton.Location = New System.Drawing.Point(800, 2)
        Me.question.CustomButton.Name = ""
        Me.question.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.question.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.question.CustomButton.TabIndex = 1
        Me.question.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.question.CustomButton.UseSelectable = True
        Me.question.CustomButton.Visible = False
        Me.question.DisplayIcon = True
        Me.question.Enabled = False
        Me.question.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.question.Lines = New String(-1) {}
        Me.question.Location = New System.Drawing.Point(15, 14)
        Me.question.MaxLength = 32767
        Me.question.Name = "question"
        Me.question.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.question.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.question.SelectedText = ""
        Me.question.SelectionLength = 0
        Me.question.SelectionStart = 0
        Me.question.ShowClearButton = True
        Me.question.Size = New System.Drawing.Size(828, 30)
        Me.question.Style = MetroFramework.MetroColorStyle.Red
        Me.question.TabIndex = 479
        Me.question.UseCustomForeColor = True
        Me.question.UseSelectable = True
        Me.question.WaterMark = "Concern"
        Me.question.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.question.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'answerTXT
        '
        Me.answerTXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.answerTXT.CustomButton.Image = Nothing
        Me.answerTXT.CustomButton.Location = New System.Drawing.Point(719, 2)
        Me.answerTXT.CustomButton.Name = ""
        Me.answerTXT.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.answerTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.answerTXT.CustomButton.TabIndex = 1
        Me.answerTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.answerTXT.CustomButton.UseSelectable = True
        Me.answerTXT.CustomButton.Visible = False
        Me.answerTXT.DisplayIcon = True
        Me.answerTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.answerTXT.Lines = New String(-1) {}
        Me.answerTXT.Location = New System.Drawing.Point(96, 52)
        Me.answerTXT.MaxLength = 32767
        Me.answerTXT.Name = "answerTXT"
        Me.answerTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.answerTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.answerTXT.SelectedText = ""
        Me.answerTXT.SelectionLength = 0
        Me.answerTXT.SelectionStart = 0
        Me.answerTXT.ShowClearButton = True
        Me.answerTXT.Size = New System.Drawing.Size(747, 30)
        Me.answerTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.answerTXT.TabIndex = 477
        Me.answerTXT.UseCustomForeColor = True
        Me.answerTXT.UseSelectable = True
        Me.answerTXT.WaterMark = "Problem"
        Me.answerTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.answerTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'aitemTXT
        '
        '
        '
        '
        Me.aitemTXT.CustomButton.Image = Nothing
        Me.aitemTXT.CustomButton.Location = New System.Drawing.Point(45, 2)
        Me.aitemTXT.CustomButton.Name = ""
        Me.aitemTXT.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.aitemTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.aitemTXT.CustomButton.TabIndex = 1
        Me.aitemTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.aitemTXT.CustomButton.UseSelectable = True
        Me.aitemTXT.CustomButton.Visible = False
        Me.aitemTXT.DisplayIcon = True
        Me.aitemTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.aitemTXT.Lines = New String(-1) {}
        Me.aitemTXT.Location = New System.Drawing.Point(15, 52)
        Me.aitemTXT.MaxLength = 32767
        Me.aitemTXT.Name = "aitemTXT"
        Me.aitemTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.aitemTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.aitemTXT.SelectedText = ""
        Me.aitemTXT.SelectionLength = 0
        Me.aitemTXT.SelectionStart = 0
        Me.aitemTXT.ShowClearButton = True
        Me.aitemTXT.Size = New System.Drawing.Size(73, 30)
        Me.aitemTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.aitemTXT.TabIndex = 476
        Me.aitemTXT.UseCustomForeColor = True
        Me.aitemTXT.UseSelectable = True
        Me.aitemTXT.WaterMark = "Item No"
        Me.aitemTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.aitemTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'metroTextButton2
        '
        Me.metroTextButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metroTextButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton2.Image = Nothing
        Me.metroTextButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton2.Location = New System.Drawing.Point(767, 90)
        Me.metroTextButton2.Name = "metroTextButton2"
        Me.metroTextButton2.Size = New System.Drawing.Size(76, 31)
        Me.metroTextButton2.Style = MetroFramework.MetroColorStyle.Orange
        Me.metroTextButton2.TabIndex = 472
        Me.metroTextButton2.Text = "refresh"
        Me.metroTextButton2.UseSelectable = True
        Me.metroTextButton2.UseVisualStyleBackColor = True
        '
        'metroTextButton1
        '
        Me.metroTextButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton1.Image = Nothing
        Me.metroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton1.Location = New System.Drawing.Point(521, 90)
        Me.metroTextButton1.Name = "metroTextButton1"
        Me.metroTextButton1.Size = New System.Drawing.Size(76, 31)
        Me.metroTextButton1.Style = MetroFramework.MetroColorStyle.Orange
        Me.metroTextButton1.TabIndex = 475
        Me.metroTextButton1.Text = "add"
        Me.metroTextButton1.UseSelectable = True
        Me.metroTextButton1.UseVisualStyleBackColor = True
        '
        'metroTextButton4
        '
        Me.metroTextButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metroTextButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton4.Image = Nothing
        Me.metroTextButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton4.Location = New System.Drawing.Point(685, 90)
        Me.metroTextButton4.Name = "metroTextButton4"
        Me.metroTextButton4.Size = New System.Drawing.Size(76, 31)
        Me.metroTextButton4.Style = MetroFramework.MetroColorStyle.Orange
        Me.metroTextButton4.TabIndex = 473
        Me.metroTextButton4.Text = "delete"
        Me.metroTextButton4.UseSelectable = True
        Me.metroTextButton4.UseVisualStyleBackColor = True
        '
        'metroTextButton3
        '
        Me.metroTextButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metroTextButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton3.Image = Nothing
        Me.metroTextButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton3.Location = New System.Drawing.Point(603, 90)
        Me.metroTextButton3.Name = "metroTextButton3"
        Me.metroTextButton3.Size = New System.Drawing.Size(76, 31)
        Me.metroTextButton3.Style = MetroFramework.MetroColorStyle.Orange
        Me.metroTextButton3.TabIndex = 474
        Me.metroTextButton3.Text = "update"
        Me.metroTextButton3.UseSelectable = True
        Me.metroTextButton3.UseVisualStyleBackColor = True
        '
        'answerGRID
        '
        Me.answerGRID.AllowUserToAddRows = False
        Me.answerGRID.AllowUserToDeleteRows = False
        Me.answerGRID.AllowUserToOrderColumns = True
        Me.answerGRID.AllowUserToResizeColumns = False
        Me.answerGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.answerGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.answerGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.answerGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.answerGRID.ColumnHeadersHeight = 30
        Me.answerGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.answerGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.answerGRID.Location = New System.Drawing.Point(0, 151)
        Me.answerGRID.MultiSelect = False
        Me.answerGRID.Name = "answerGRID"
        Me.answerGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.answerGRID.ReadOnly = True
        Me.answerGRID.RowHeadersVisible = False
        Me.answerGRID.RowHeadersWidth = 40
        Me.answerGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.answerGRID.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Purple
        Me.answerGRID.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.answerGRID.RowTemplate.Height = 35
        Me.answerGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.answerGRID.Size = New System.Drawing.Size(880, 490)
        Me.answerGRID.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke
        Me.answerGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.answerGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.answerGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(-1, 10, -1, 10)
        Me.answerGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.answerGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.answerGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.answerGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.answerGRID.TabIndex = 478
        '
        'concernFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 727)
        Me.Controls.Add(Me.metroTabControl1)
        Me.Name = "concernFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.metroTabControl1.ResumeLayout(False)
        Me.metroTabPage1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.questionGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.metroTabPage2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        CType(Me.answerGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents metroTabControl1 As MetroFramework.Controls.MetroTabControl
    Private WithEvents metroTabPage1 As MetroFramework.Controls.MetroTabPage
    Private WithEvents panel2 As Panel
    Friend WithEvents itemTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents deleteBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents updateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents refreshBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents questionTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents addBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents questionGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents metroTabPage2 As MetroFramework.Controls.MetroTabPage
    Private WithEvents panel1 As Panel
    Friend WithEvents question As MetroFramework.Controls.MetroTextBox
    Friend WithEvents answerTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents aitemTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents metroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents metroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents metroTextButton4 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents metroTextButton3 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents answerGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
