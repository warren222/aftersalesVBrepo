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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.KryptonLabel12 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.footerpnl = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.totalvalue = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.descriptiontxt = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.footerpnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Location = New System.Drawing.Point(12, 71)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(609, 211)
        Me.Panel7.TabIndex = 598
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(12, 38)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 27)
        Me.Button5.TabIndex = 601
        Me.Button5.Text = "BACK"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'KryptonLabel12
        '
        Me.KryptonLabel12.Location = New System.Drawing.Point(12, 12)
        Me.KryptonLabel12.Name = "KryptonLabel12"
        Me.KryptonLabel12.Size = New System.Drawing.Size(58, 20)
        Me.KryptonLabel12.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel12.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel12.TabIndex = 603
        Me.KryptonLabel12.Values.Text = "Insights"
        '
        'footerpnl
        '
        Me.footerpnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.footerpnl.Controls.Add(Me.totalvalue)
        Me.footerpnl.Controls.Add(Me.KryptonLabel1)
        Me.footerpnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.footerpnl.Location = New System.Drawing.Point(0, 311)
        Me.footerpnl.Name = "footerpnl"
        Me.footerpnl.Size = New System.Drawing.Size(636, 77)
        Me.footerpnl.TabIndex = 604
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(12, 17)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(87, 38)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.KryptonLabel1.TabIndex = 604
        Me.KryptonLabel1.Values.Text = "Total :"
        '
        'totalvalue
        '
        Me.totalvalue.Location = New System.Drawing.Point(105, 17)
        Me.totalvalue.Name = "totalvalue"
        Me.totalvalue.Size = New System.Drawing.Size(77, 38)
        Me.totalvalue.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.totalvalue.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalvalue.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.totalvalue.TabIndex = 605
        Me.totalvalue.Values.Text = "value"
        '
        'descriptiontxt
        '
        Me.descriptiontxt.Location = New System.Drawing.Point(93, 38)
        Me.descriptiontxt.Name = "descriptiontxt"
        Me.descriptiontxt.Size = New System.Drawing.Size(59, 20)
        Me.descriptiontxt.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.descriptiontxt.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptiontxt.TabIndex = 605
        Me.descriptiontxt.Values.Text = "Explorer"
        '
        'insightFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 388)
        Me.Controls.Add(Me.descriptiontxt)
        Me.Controls.Add(Me.footerpnl)
        Me.Controls.Add(Me.KryptonLabel12)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel7)
        Me.Name = "insightFRM"
        Me.footerpnl.ResumeLayout(False)
        Me.footerpnl.PerformLayout()
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
End Class
