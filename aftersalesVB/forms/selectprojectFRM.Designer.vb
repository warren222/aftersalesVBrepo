<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectprojectFRM
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectprojectFRM))
        Me.projectGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.projectTXT = New MetroFramework.Controls.MetroTextBox()
        CType(Me.projectGRID, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.projectGRID.ColumnHeadersHeight = 30
        Me.projectGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.projectGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.projectGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectGRID.Location = New System.Drawing.Point(20, 60)
        Me.projectGRID.MultiSelect = False
        Me.projectGRID.Name = "projectGRID"
        Me.projectGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.projectGRID.ReadOnly = True
        Me.projectGRID.RowHeadersVisible = False
        Me.projectGRID.RowHeadersWidth = 40
        Me.projectGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.projectGRID.RowTemplate.Height = 40
        Me.projectGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.projectGRID.Size = New System.Drawing.Size(732, 374)
        Me.projectGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.projectGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.projectGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.projectGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.projectGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(-1, 10, -1, 10)
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
        '
        '
        '
        Me.projectTXT.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.projectTXT.CustomButton.Location = New System.Drawing.Point(378, 2)
        Me.projectTXT.CustomButton.Name = ""
        Me.projectTXT.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.projectTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.projectTXT.CustomButton.TabIndex = 1
        Me.projectTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.projectTXT.CustomButton.UseSelectable = True
        Me.projectTXT.DisplayIcon = True
        Me.projectTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.projectTXT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.projectTXT.Lines = New String(-1) {}
        Me.projectTXT.Location = New System.Drawing.Point(294, 22)
        Me.projectTXT.MaxLength = 32767
        Me.projectTXT.Name = "projectTXT"
        Me.projectTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.projectTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.projectTXT.SelectedText = ""
        Me.projectTXT.SelectionLength = 0
        Me.projectTXT.SelectionStart = 0
        Me.projectTXT.ShowButton = True
        Me.projectTXT.ShowClearButton = True
        Me.projectTXT.Size = New System.Drawing.Size(408, 32)
        Me.projectTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.projectTXT.TabIndex = 484
        Me.projectTXT.UseCustomForeColor = True
        Me.projectTXT.UseSelectable = True
        Me.projectTXT.WaterMark = "Enter Project Name"
        Me.projectTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.projectTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'selectprojectFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 454)
        Me.Controls.Add(Me.projectTXT)
        Me.Controls.Add(Me.projectGRID)
        Me.Name = "selectprojectFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.projectGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents projectGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents projectTXT As MetroFramework.Controls.MetroTextBox
End Class
