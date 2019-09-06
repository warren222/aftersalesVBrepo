<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectedsystemFRM
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OTHERSYSTEMTXT = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.possibleissue = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CATEGORYlabel = New System.Windows.Forms.Label()
        Me.category = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.qualityaspect = New System.Windows.Forms.ComboBox()
        Me.parts = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.seelctedsystem = New System.Windows.Forms.Label()
        Me.solutionGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PossibleSolution = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.solutionGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.OTHERSYSTEMTXT)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.possibleissue)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.CATEGORYlabel)
        Me.Panel2.Controls.Add(Me.category)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.qualityaspect)
        Me.Panel2.Controls.Add(Me.parts)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(18, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(785, 411)
        Me.Panel2.TabIndex = 13
        '
        'OTHERSYSTEMTXT
        '
        Me.OTHERSYSTEMTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OTHERSYSTEMTXT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OTHERSYSTEMTXT.FormattingEnabled = True
        Me.OTHERSYSTEMTXT.Location = New System.Drawing.Point(134, 20)
        Me.OTHERSYSTEMTXT.Name = "OTHERSYSTEMTXT"
        Me.OTHERSYSTEMTXT.Size = New System.Drawing.Size(250, 27)
        Me.OTHERSYSTEMTXT.TabIndex = 22
        Me.OTHERSYSTEMTXT.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Screen System"
        Me.Label1.Visible = False
        '
        'possibleissue
        '
        Me.possibleissue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.possibleissue.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.possibleissue.FormattingEnabled = True
        Me.possibleissue.Location = New System.Drawing.Point(553, 53)
        Me.possibleissue.Name = "possibleissue"
        Me.possibleissue.Size = New System.Drawing.Size(208, 27)
        Me.possibleissue.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Possible Issue/Concern"
        '
        'CATEGORYlabel
        '
        Me.CATEGORYlabel.AutoSize = True
        Me.CATEGORYlabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CATEGORYlabel.Location = New System.Drawing.Point(18, 86)
        Me.CATEGORYlabel.Name = "CATEGORYlabel"
        Me.CATEGORYlabel.Size = New System.Drawing.Size(96, 17)
        Me.CATEGORYlabel.TabIndex = 15
        Me.CATEGORYlabel.Text = "Select Category"
        '
        'category
        '
        Me.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.category.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category.FormattingEnabled = True
        Me.category.Location = New System.Drawing.Point(134, 86)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(161, 27)
        Me.category.TabIndex = 16
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(685, 328)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "save"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Select Possible Solution"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.solutionGV)
        Me.Panel3.Location = New System.Drawing.Point(403, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(358, 177)
        Me.Panel3.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select Parts"
        '
        'qualityaspect
        '
        Me.qualityaspect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.qualityaspect.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qualityaspect.FormattingEnabled = True
        Me.qualityaspect.Location = New System.Drawing.Point(553, 20)
        Me.qualityaspect.Name = "qualityaspect"
        Me.qualityaspect.Size = New System.Drawing.Size(208, 27)
        Me.qualityaspect.TabIndex = 11
        '
        'parts
        '
        Me.parts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.parts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parts.FormattingEnabled = True
        Me.parts.Location = New System.Drawing.Point(134, 53)
        Me.parts.Name = "parts"
        Me.parts.Size = New System.Drawing.Size(250, 27)
        Me.parts.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Select Quality Aspect"
        '
        'seelctedsystem
        '
        Me.seelctedsystem.AutoSize = True
        Me.seelctedsystem.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seelctedsystem.Location = New System.Drawing.Point(12, 9)
        Me.seelctedsystem.Name = "seelctedsystem"
        Me.seelctedsystem.Size = New System.Drawing.Size(191, 33)
        Me.seelctedsystem.TabIndex = 14
        Me.seelctedsystem.Text = "Selected System"
        '
        'solutionGV
        '
        Me.solutionGV.AllowUserToAddRows = False
        Me.solutionGV.AllowUserToDeleteRows = False
        Me.solutionGV.AllowUserToOrderColumns = True
        Me.solutionGV.AllowUserToResizeColumns = False
        Me.solutionGV.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.solutionGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.solutionGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.solutionGV.ColumnHeadersHeight = 30
        Me.solutionGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.solutionGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.PossibleSolution})
        Me.solutionGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.solutionGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.solutionGV.Location = New System.Drawing.Point(0, 0)
        Me.solutionGV.MultiSelect = False
        Me.solutionGV.Name = "solutionGV"
        Me.solutionGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.solutionGV.ReadOnly = True
        Me.solutionGV.RowHeadersVisible = False
        Me.solutionGV.RowHeadersWidth = 40
        Me.solutionGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.solutionGV.RowTemplate.Height = 27
        Me.solutionGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.solutionGV.Size = New System.Drawing.Size(356, 175)
        Me.solutionGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.solutionGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.solutionGV.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.solutionGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.solutionGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.solutionGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.solutionGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.solutionGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.solutionGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solutionGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.solutionGV.TabIndex = 500
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 7
        '
        'PossibleSolution
        '
        Me.PossibleSolution.HeaderText = "PossibleSolution"
        Me.PossibleSolution.Name = "PossibleSolution"
        Me.PossibleSolution.ReadOnly = True
        Me.PossibleSolution.Width = 132
        '
        'selectedsystemFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 468)
        Me.Controls.Add(Me.seelctedsystem)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "selectedsystemFRM"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.solutionGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents CATEGORYlabel As Label
    Friend WithEvents category As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents qualityaspect As ComboBox
    Friend WithEvents parts As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents seelctedsystem As Label
    Friend WithEvents possibleissue As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents OTHERSYSTEMTXT As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents solutionGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents PossibleSolution As DataGridViewTextBoxColumn
End Class
