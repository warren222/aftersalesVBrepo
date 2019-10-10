<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class reportFRM
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
        Me.reportGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.servicing = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.calldategen = New MetroFramework.Controls.MetroDateTime()
        Me.dated = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.EVALUATION = New System.Windows.Forms.RichTextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.teamgv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.reportGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.teamgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportGRID
        '
        Me.reportGRID.AllowUserToAddRows = False
        Me.reportGRID.AllowUserToDeleteRows = False
        Me.reportGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.reportGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.reportGRID.ColumnHeadersHeight = 32
        Me.reportGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.reportGRID.Location = New System.Drawing.Point(0, 0)
        Me.reportGRID.MultiSelect = False
        Me.reportGRID.Name = "reportGRID"
        Me.reportGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.reportGRID.RowHeadersWidth = 30
        Me.reportGRID.RowTemplate.Height = 30
        Me.reportGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportGRID.Size = New System.Drawing.Size(479, 335)
        Me.reportGRID.StateCommon.Background.Color1 = System.Drawing.Color.Silver
        Me.reportGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.reportGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.reportGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.reportGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.reportGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.reportGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.reportGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.reportGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.reportGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.reportGRID.TabIndex = 557
        '
        'servicing
        '
        Me.servicing.Location = New System.Drawing.Point(42, 12)
        Me.servicing.Name = "servicing"
        Me.servicing.Size = New System.Drawing.Size(101, 34)
        Me.servicing.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.servicing.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicing.TabIndex = 560
        Me.servicing.Values.Text = "Servicing"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.reportGRID)
        Me.Panel1.Location = New System.Drawing.Point(3, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 337)
        Me.Panel1.TabIndex = 565
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 75)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(97, 20)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 566
        Me.KryptonLabel7.Values.Text = "List o reports :"
        '
        'newbtn
        '
        Me.newbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.newbtn.Location = New System.Drawing.Point(506, 101)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(70, 23)
        Me.newbtn.TabIndex = 567
        Me.newbtn.Text = "new"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(506, 130)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(70, 23)
        Me.refreshbtn.TabIndex = 568
        Me.refreshbtn.Text = "reload"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(506, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 569
        Me.Button1.Text = "preview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.Location = New System.Drawing.Point(506, 239)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(190, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 577
        Me.KryptonLabel3.Values.Text = "After Sales-Admin Evaluation :"
        '
        'calldategen
        '
        Me.calldategen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calldategen.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calldategen.CustomFormat = "yyyy-MMM-dd"
        Me.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calldategen.Location = New System.Drawing.Point(506, 400)
        Me.calldategen.MinimumSize = New System.Drawing.Size(4, 29)
        Me.calldategen.Name = "calldategen"
        Me.calldategen.Size = New System.Drawing.Size(130, 29)
        Me.calldategen.Style = MetroFramework.MetroColorStyle.Red
        Me.calldategen.TabIndex = 601
        '
        'dated
        '
        Me.dated.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.dated.CustomButton.Image = Nothing
        Me.dated.CustomButton.Location = New System.Drawing.Point(114, 1)
        Me.dated.CustomButton.Name = ""
        Me.dated.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.dated.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dated.CustomButton.TabIndex = 1
        Me.dated.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dated.CustomButton.UseSelectable = True
        Me.dated.CustomButton.Visible = False
        Me.dated.DisplayIcon = True
        Me.dated.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.dated.Lines = New String(-1) {}
        Me.dated.Location = New System.Drawing.Point(642, 400)
        Me.dated.MaxLength = 32767
        Me.dated.Name = "dated"
        Me.dated.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dated.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dated.SelectedText = ""
        Me.dated.SelectionLength = 0
        Me.dated.SelectionStart = 0
        Me.dated.ShowClearButton = True
        Me.dated.Size = New System.Drawing.Size(140, 27)
        Me.dated.Style = MetroFramework.MetroColorStyle.Teal
        Me.dated.TabIndex = 602
        Me.dated.UseCustomForeColor = True
        Me.dated.UseSelectable = True
        Me.dated.UseStyleColors = True
        Me.dated.WaterMark = "DATE"
        Me.dated.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dated.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel4.Location = New System.Drawing.Point(506, 374)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(118, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 603
        Me.KryptonLabel4.Values.Text = "Date Completion :"
        '
        'EVALUATION
        '
        Me.EVALUATION.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EVALUATION.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EVALUATION.Location = New System.Drawing.Point(506, 265)
        Me.EVALUATION.Name = "EVALUATION"
        Me.EVALUATION.Size = New System.Drawing.Size(407, 103)
        Me.EVALUATION.TabIndex = 604
        Me.EVALUATION.Text = ""
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(788, 400)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 27)
        Me.Button5.TabIndex = 605
        Me.Button5.Text = "save evaluation"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel1.Location = New System.Drawing.Point(667, 71)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(92, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 607
        Me.KryptonLabel1.Values.Text = "Select Team :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.teamgv)
        Me.Panel2.Location = New System.Drawing.Point(620, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(289, 115)
        Me.Panel2.TabIndex = 608
        '
        'teamgv
        '
        Me.teamgv.AllowUserToAddRows = False
        Me.teamgv.AllowUserToDeleteRows = False
        Me.teamgv.AllowUserToOrderColumns = True
        Me.teamgv.AllowUserToResizeColumns = False
        Me.teamgv.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.teamgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.teamgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.teamgv.ColumnHeadersHeight = 30
        Me.teamgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.teamgv.ColumnHeadersVisible = False
        Me.teamgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teamgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teamgv.Location = New System.Drawing.Point(0, 0)
        Me.teamgv.MultiSelect = False
        Me.teamgv.Name = "teamgv"
        Me.teamgv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.teamgv.ReadOnly = True
        Me.teamgv.RowHeadersVisible = False
        Me.teamgv.RowHeadersWidth = 40
        Me.teamgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.teamgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.teamgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.teamgv.Size = New System.Drawing.Size(289, 115)
        Me.teamgv.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke
        Me.teamgv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.teamgv.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.teamgv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.teamgv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.teamgv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.teamgv.StateCommon.HeaderColumn.Border.Width = 0
        Me.teamgv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.teamgv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.teamgv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.teamgv.TabIndex = 500
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(765, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 23)
        Me.Button2.TabIndex = 609
        Me.Button2.Text = "browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(838, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 23)
        Me.Button3.TabIndex = 610
        Me.Button3.Text = "save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'reportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(943, 462)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.EVALUATION)
        Me.Controls.Add(Me.KryptonLabel4)
        Me.Controls.Add(Me.calldategen)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.KryptonLabel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.KryptonLabel7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.servicing)
        Me.MinimizeBox = False
        Me.Name = "reportFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.reportGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.teamgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents reportGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents servicing As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents newbtn As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents calldategen As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dated As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents EVALUATION As RichTextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents teamgv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
