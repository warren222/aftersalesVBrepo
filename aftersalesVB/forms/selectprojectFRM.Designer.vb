<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectprojectFRM
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectprojectFRM))
        Me.projectGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.projectTXT = New MetroFramework.Controls.MetroTextBox()
        Me.fieldcombo = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.projectGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'projectGRID
        '
        Me.projectGRID.AllowUserToAddRows = False
        Me.projectGRID.AllowUserToDeleteRows = False
        Me.projectGRID.AllowUserToOrderColumns = True
        Me.projectGRID.AllowUserToResizeColumns = False
        Me.projectGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.projectGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.projectGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.projectGRID.ColumnHeadersHeight = 25
        Me.projectGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.projectGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.projectGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectGRID.Location = New System.Drawing.Point(0, 0)
        Me.projectGRID.MultiSelect = False
        Me.projectGRID.Name = "projectGRID"
        Me.projectGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.projectGRID.ReadOnly = True
        Me.projectGRID.RowHeadersVisible = False
        Me.projectGRID.RowHeadersWidth = 40
        Me.projectGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.projectGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.projectGRID.Size = New System.Drawing.Size(558, 332)
        Me.projectGRID.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke
        Me.projectGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.projectGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.projectGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(0)
        Me.projectGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.projectGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.projectGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.projectGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.projectGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.projectGRID.TabIndex = 483
        '
        'projectTXT
        '
        Me.projectTXT.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.projectTXT.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.projectTXT.CustomButton.Location = New System.Drawing.Point(289, 1)
        Me.projectTXT.CustomButton.Name = ""
        Me.projectTXT.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.projectTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.projectTXT.CustomButton.TabIndex = 1
        Me.projectTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.projectTXT.CustomButton.UseSelectable = True
        Me.projectTXT.DisplayIcon = True
        Me.projectTXT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.projectTXT.Lines = New String(-1) {}
        Me.projectTXT.Location = New System.Drawing.Point(267, 23)
        Me.projectTXT.MaxLength = 32767
        Me.projectTXT.Name = "projectTXT"
        Me.projectTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.projectTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.projectTXT.SelectedText = ""
        Me.projectTXT.SelectionLength = 0
        Me.projectTXT.SelectionStart = 0
        Me.projectTXT.ShowButton = True
        Me.projectTXT.ShowClearButton = True
        Me.projectTXT.Size = New System.Drawing.Size(315, 27)
        Me.projectTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.projectTXT.TabIndex = 484
        Me.projectTXT.UseCustomBackColor = True
        Me.projectTXT.UseCustomForeColor = True
        Me.projectTXT.UseSelectable = True
        Me.projectTXT.WaterMark = "Enter Project Name"
        Me.projectTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'fieldcombo
        '
        Me.fieldcombo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.fieldcombo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.fieldcombo.FormattingEnabled = True
        Me.fieldcombo.ItemHeight = 19
        Me.fieldcombo.Items.AddRange(New Object() {"ALL", "PROJECT NAME", "CLIENTS NAME", "COMPANY NAME", "ADDRESS", "SALES"})
        Me.fieldcombo.Location = New System.Drawing.Point(88, 23)
        Me.fieldcombo.Name = "fieldcombo"
        Me.fieldcombo.Size = New System.Drawing.Size(173, 25)
        Me.fieldcombo.TabIndex = 485
        Me.fieldcombo.UseCustomBackColor = True
        Me.fieldcombo.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.projectGRID)
        Me.Panel1.Location = New System.Drawing.Point(22, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(560, 334)
        Me.Panel1.TabIndex = 486
        '
        'addBTN
        '
        Me.addBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBTN.Image = Nothing
        Me.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addBTN.Location = New System.Drawing.Point(594, 90)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(107, 25)
        Me.addBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.addBTN.TabIndex = 488
        Me.addBTN.Text = "ok"
        Me.addBTN.UseSelectable = True
        Me.addBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 489
        Me.Label1.Text = "Select project from contract :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 490
        Me.Label2.Text = "keyword :"
        '
        'selectprojectFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 454)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.projectTXT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fieldcombo)
        Me.Controls.Add(Me.addBTN)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "selectprojectFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Import"
        CType(Me.projectGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents projectGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents projectTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents fieldcombo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents addBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
