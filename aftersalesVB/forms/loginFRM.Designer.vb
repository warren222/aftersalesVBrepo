<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginFRM
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
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.password = New MetroFramework.Controls.MetroTextBox()
        Me.username = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(261, 204)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(116, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 518
        Me.save.Text = "Log In"
        Me.save.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(47, 134)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 517
        Me.KryptonLabel9.Values.Text = "password"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(47, 100)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(70, 22)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 516
        Me.KryptonLabel6.Values.Text = "username"
        '
        'password
        '
        '
        '
        '
        Me.password.CustomButton.Image = Nothing
        Me.password.CustomButton.Location = New System.Drawing.Point(178, 2)
        Me.password.CustomButton.Name = ""
        Me.password.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.password.CustomButton.TabIndex = 1
        Me.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.password.CustomButton.UseSelectable = True
        Me.password.CustomButton.Visible = False
        Me.password.DisplayIcon = True
        Me.password.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.password.Lines = New String(-1) {}
        Me.password.Location = New System.Drawing.Point(173, 134)
        Me.password.MaxLength = 32767
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.password.SelectedText = ""
        Me.password.SelectionLength = 0
        Me.password.SelectionStart = 0
        Me.password.ShowClearButton = True
        Me.password.Size = New System.Drawing.Size(204, 28)
        Me.password.Style = MetroFramework.MetroColorStyle.Red
        Me.password.TabIndex = 515
        Me.password.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.password.UseCustomForeColor = True
        Me.password.UseSelectable = True
        Me.password.WaterMark = "Enter Password"
        Me.password.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.password.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'username
        '
        '
        '
        '
        Me.username.CustomButton.Image = Nothing
        Me.username.CustomButton.Location = New System.Drawing.Point(178, 2)
        Me.username.CustomButton.Name = ""
        Me.username.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.username.CustomButton.TabIndex = 1
        Me.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.username.CustomButton.UseSelectable = True
        Me.username.CustomButton.Visible = False
        Me.username.DisplayIcon = True
        Me.username.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.username.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.username.Lines = New String(-1) {}
        Me.username.Location = New System.Drawing.Point(173, 100)
        Me.username.MaxLength = 32767
        Me.username.Multiline = True
        Me.username.Name = "username"
        Me.username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.username.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.username.SelectedText = ""
        Me.username.SelectionLength = 0
        Me.username.SelectionStart = 0
        Me.username.ShowClearButton = True
        Me.username.Size = New System.Drawing.Size(204, 28)
        Me.username.Style = MetroFramework.MetroColorStyle.Red
        Me.username.TabIndex = 514
        Me.username.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.username.UseCustomForeColor = True
        Me.username.UseSelectable = True
        Me.username.WaterMark = "Enter UserName"
        Me.username.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.username.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'loginFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 255)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.KryptonLabel9)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.username)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginFRM"
        Me.Opacity = 0.92R
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "After Sales Log In"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents password As MetroFramework.Controls.MetroTextBox
    Friend WithEvents username As MetroFramework.Controls.MetroTextBox
End Class
