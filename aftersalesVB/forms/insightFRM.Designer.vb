<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class insightFRM
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.footerpnl = New System.Windows.Forms.Panel()
        Me.totalvalue = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.descriptiontxt = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.windowRB = New System.Windows.Forms.RadioButton()
        Me.doorRB = New System.Windows.Forms.RadioButton()
        Me.bothRB = New System.Windows.Forms.RadioButton()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.yr = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.toplabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.footerpnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(0, 125)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(527, 214)
        Me.Panel7.TabIndex = 598
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(3, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 27)
        Me.Button5.TabIndex = 601
        Me.Button5.Text = "refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(93, 29)
        Me.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonLabel12.TabIndex = 603
        Me.KryptonLabel12.Values.Text = "INSIGHTS"
        '
        'footerpnl
        '
        Me.footerpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.footerpnl.Controls.Add(Me.totalvalue)
        Me.footerpnl.Controls.Add(Me.KryptonLabel1)
        Me.footerpnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footerpnl.Location = New System.Drawing.Point(0, 345)
        Me.footerpnl.Name = "footerpnl"
        Me.footerpnl.Size = New System.Drawing.Size(899, 43)
        Me.footerpnl.TabIndex = 604
        '
        'totalvalue
        '
        Me.totalvalue.Location = New System.Drawing.Point(105, 4)
        Me.totalvalue.Name = "totalvalue"
        Me.totalvalue.Size = New System.Drawing.Size(77, 38)
        Me.totalvalue.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.totalvalue.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalvalue.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.totalvalue.TabIndex = 605
        Me.totalvalue.Values.Text = "value"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 4)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(87, 38)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonLabel1.TabIndex = 604
        Me.KryptonLabel1.Values.Text = "Total :"
        '
        'descriptiontxt
        '
        Me.descriptiontxt.Location = New System.Drawing.Point(3, 38)
        Me.descriptiontxt.Name = "descriptiontxt"
        Me.descriptiontxt.Size = New System.Drawing.Size(83, 29)
        Me.descriptiontxt.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.descriptiontxt.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxt.TabIndex = 605
        Me.descriptiontxt.Values.Text = "Explorer"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.toplabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.yr)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(0, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 48)
        Me.Panel1.TabIndex = 606
        '
        'windowRB
        '
        Me.windowRB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.windowRB.AutoSize = True
        Me.windowRB.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowRB.Location = New System.Drawing.Point(725, 41)
        Me.windowRB.Name = "windowRB"
        Me.windowRB.Size = New System.Drawing.Size(80, 23)
        Me.windowRB.TabIndex = 606
        Me.windowRB.Text = "Window"
        Me.windowRB.UseVisualStyleBackColor = True
        '
        'doorRB
        '
        Me.doorRB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.doorRB.AutoSize = True
        Me.doorRB.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doorRB.Location = New System.Drawing.Point(826, 42)
        Me.doorRB.Name = "doorRB"
        Me.doorRB.Size = New System.Drawing.Size(58, 23)
        Me.doorRB.TabIndex = 607
        Me.doorRB.Text = "Door"
        Me.doorRB.UseVisualStyleBackColor = True
        '
        'bothRB
        '
        Me.bothRB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bothRB.AutoSize = True
        Me.bothRB.Checked = True
        Me.bothRB.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bothRB.Location = New System.Drawing.Point(645, 42)
        Me.bothRB.Name = "bothRB"
        Me.bothRB.Size = New System.Drawing.Size(57, 23)
        Me.bothRB.TabIndex = 608
        Me.bothRB.TabStop = True
        Me.bothRB.Text = "Both"
        Me.bothRB.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(533, 125)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(366, 214)
        Me.Chart1.TabIndex = 609
        Me.Chart1.Text = "Chart1"
        '
        'yr
        '
        Me.yr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.yr.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yr.Location = New System.Drawing.Point(803, 13)
        Me.yr.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.yr.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.yr.Name = "yr"
        Me.yr.Size = New System.Drawing.Size(64, 24)
        Me.yr.TabIndex = 606
        Me.yr.Value = New Decimal(New Integer() {1900, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(764, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 17)
        Me.Label1.TabIndex = 607
        Me.Label1.Text = "year"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.KryptonLabel12)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 35)
        Me.Panel2.TabIndex = 610
        '
        'toplabel
        '
        Me.toplabel.Location = New System.Drawing.Point(84, 11)
        Me.toplabel.Name = "toplabel"
        Me.toplabel.Size = New System.Drawing.Size(117, 29)
        Me.toplabel.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.toplabel.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri Light", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toplabel.TabIndex = 611
        Me.toplabel.Values.Text = "TOP SYSTEM"
        '
        'insightFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 388)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.bothRB)
        Me.Controls.Add(Me.descriptiontxt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.doorRB)
        Me.Controls.Add(Me.footerpnl)
        Me.Controls.Add(Me.windowRB)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "insightFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.footerpnl.ResumeLayout(False)
        Me.footerpnl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents KryptonLabel12 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents footerpnl As Panel
    Friend WithEvents totalvalue As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents descriptiontxt As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents windowRB As RadioButton
    Friend WithEvents doorRB As RadioButton
    Friend WithEvents bothRB As RadioButton
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents yr As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents toplabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
