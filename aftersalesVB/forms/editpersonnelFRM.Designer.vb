<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editpersonnelFRM
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
        Me.SAVE = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.PERSONNEL = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'SAVE
        '
        Me.SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SAVE.Image = Nothing
        Me.SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SAVE.Location = New System.Drawing.Point(344, 63)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(68, 29)
        Me.SAVE.Style = MetroFramework.MetroColorStyle.Yellow
        Me.SAVE.TabIndex = 483
        Me.SAVE.Text = "SAVE"
        Me.SAVE.UseCustomForeColor = True
        Me.SAVE.UseSelectable = True
        Me.SAVE.UseVisualStyleBackColor = True
        '
        'PERSONNEL
        '
        '
        '
        '
        Me.PERSONNEL.CustomButton.Image = Nothing
        Me.PERSONNEL.CustomButton.Location = New System.Drawing.Point(287, 1)
        Me.PERSONNEL.CustomButton.Name = ""
        Me.PERSONNEL.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.PERSONNEL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PERSONNEL.CustomButton.TabIndex = 1
        Me.PERSONNEL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PERSONNEL.CustomButton.UseSelectable = True
        Me.PERSONNEL.CustomButton.Visible = False
        Me.PERSONNEL.DisplayIcon = True
        Me.PERSONNEL.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PERSONNEL.ForeColor = System.Drawing.Color.Black
        Me.PERSONNEL.Lines = New String(-1) {}
        Me.PERSONNEL.Location = New System.Drawing.Point(23, 63)
        Me.PERSONNEL.MaxLength = 32767
        Me.PERSONNEL.Name = "PERSONNEL"
        Me.PERSONNEL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PERSONNEL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PERSONNEL.SelectedText = ""
        Me.PERSONNEL.SelectionLength = 0
        Me.PERSONNEL.SelectionStart = 0
        Me.PERSONNEL.ShowClearButton = True
        Me.PERSONNEL.Size = New System.Drawing.Size(315, 29)
        Me.PERSONNEL.Style = MetroFramework.MetroColorStyle.Red
        Me.PERSONNEL.TabIndex = 482
        Me.PERSONNEL.UseCustomForeColor = True
        Me.PERSONNEL.UseSelectable = True
        Me.PERSONNEL.WaterMark = "Personnel"
        Me.PERSONNEL.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PERSONNEL.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'editpersonnelFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 119)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.PERSONNEL)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(443, 119)
        Me.MinimizeBox = False
        Me.Name = "editpersonnelFRM"
        Me.Opacity = 0.9R
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SAVE As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents PERSONNEL As MetroFramework.Controls.MetroTextBox
End Class
