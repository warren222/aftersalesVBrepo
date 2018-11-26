<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newacctFRM
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
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.fullname = New MetroFramework.Controls.MetroTextBox()
        Me.password = New MetroFramework.Controls.MetroTextBox()
        Me.accttype = New MetroFramework.Controls.MetroComboBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SuspendLayout()
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(23, 158)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 529
        Me.KryptonLabel6.Values.Text = "Password"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(23, 124)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(72, 22)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 528
        Me.KryptonLabel5.Values.Text = "Full Name"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 90)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(94, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 527
        Me.KryptonLabel1.Values.Text = "Account Type"
        '
        'fullname
        '
        '
        '
        '
        Me.fullname.CustomButton.Image = Nothing
        Me.fullname.CustomButton.Location = New System.Drawing.Point(250, 2)
        Me.fullname.CustomButton.Name = ""
        Me.fullname.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.fullname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.fullname.CustomButton.TabIndex = 1
        Me.fullname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.fullname.CustomButton.UseSelectable = True
        Me.fullname.CustomButton.Visible = False
        Me.fullname.DisplayIcon = True
        Me.fullname.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.fullname.Lines = New String(-1) {}
        Me.fullname.Location = New System.Drawing.Point(140, 124)
        Me.fullname.MaxLength = 32767
        Me.fullname.Multiline = True
        Me.fullname.Name = "fullname"
        Me.fullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fullname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fullname.SelectedText = ""
        Me.fullname.SelectionLength = 0
        Me.fullname.SelectionStart = 0
        Me.fullname.ShowClearButton = True
        Me.fullname.Size = New System.Drawing.Size(276, 28)
        Me.fullname.Style = MetroFramework.MetroColorStyle.Red
        Me.fullname.TabIndex = 525
        Me.fullname.UseCustomForeColor = True
        Me.fullname.UseSelectable = True
        Me.fullname.WaterMark = "Fullname"
        Me.fullname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.fullname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'password
        '
        '
        '
        '
        Me.password.CustomButton.Image = Nothing
        Me.password.CustomButton.Location = New System.Drawing.Point(250, 2)
        Me.password.CustomButton.Name = ""
        Me.password.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password.CustomButton.TabIndex = 1
        Me.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password.CustomButton.UseSelectable = True
        Me.password.CustomButton.Visible = False
        Me.password.DisplayIcon = True
        Me.password.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.password.Lines = New String(-1) {}
        Me.password.Location = New System.Drawing.Point(140, 158)
        Me.password.MaxLength = 32767
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password.SelectedText = ""
        Me.password.SelectionLength = 0
        Me.password.SelectionStart = 0
        Me.password.ShowClearButton = True
        Me.password.Size = New System.Drawing.Size(276, 28)
        Me.password.Style = MetroFramework.MetroColorStyle.Red
        Me.password.TabIndex = 526
        Me.password.UseCustomForeColor = True
        Me.password.UseSelectable = True
        Me.password.WaterMark = "password"
        Me.password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'accttype
        '
        Me.accttype.FormattingEnabled = True
        Me.accttype.ItemHeight = 23
        Me.accttype.Items.AddRange(New Object() {"Admin", "After Sales", "Guest"})
        Me.accttype.Location = New System.Drawing.Point(140, 89)
        Me.accttype.Name = "accttype"
        Me.accttype.Size = New System.Drawing.Size(276, 29)
        Me.accttype.TabIndex = 530
        Me.accttype.UseSelectable = True
        '
        'save
        '
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(297, 206)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 531
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'newacctFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 270)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.accttype)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.password)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newacctFRM"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "newacctFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents fullname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents accttype As MetroFramework.Controls.MetroComboBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
