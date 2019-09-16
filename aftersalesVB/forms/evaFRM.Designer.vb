<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class evaFRM
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EVALUATION = New System.Windows.Forms.RichTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.calldategen = New MetroFramework.Controls.MetroDateTime()
        Me.dated = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 13)
        Me.Label13.TabIndex = 594
        Me.Label13.Text = "EVALUATION :"
        '
        'EVALUATION
        '
        Me.EVALUATION.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EVALUATION.Location = New System.Drawing.Point(138, 107)
        Me.EVALUATION.Name = "EVALUATION"
        Me.EVALUATION.Size = New System.Drawing.Size(523, 166)
        Me.EVALUATION.TabIndex = 595
        Me.EVALUATION.Text = ""
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(667, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 597
        Me.Button3.Text = "save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 600
        Me.Label11.Text = "DATE COMPLETION"
        '
        'calldategen
        '
        Me.calldategen.CustomFormat = "yyyy-MMM-dd"
        Me.calldategen.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calldategen.Location = New System.Drawing.Point(138, 59)
        Me.calldategen.MinimumSize = New System.Drawing.Size(0, 25)
        Me.calldategen.Name = "calldategen"
        Me.calldategen.Size = New System.Drawing.Size(102, 25)
        Me.calldategen.Style = MetroFramework.MetroColorStyle.Red
        Me.calldategen.TabIndex = 598
        '
        'dated
        '
        '
        '
        '
        Me.dated.CustomButton.Image = Nothing
        Me.dated.CustomButton.Location = New System.Drawing.Point(126, 1)
        Me.dated.CustomButton.Name = ""
        Me.dated.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.dated.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.dated.CustomButton.TabIndex = 1
        Me.dated.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dated.CustomButton.UseSelectable = True
        Me.dated.CustomButton.Visible = False
        Me.dated.DisplayIcon = True
        Me.dated.Lines = New String(-1) {}
        Me.dated.Location = New System.Drawing.Point(246, 59)
        Me.dated.MaxLength = 32767
        Me.dated.Name = "dated"
        Me.dated.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.dated.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dated.SelectedText = ""
        Me.dated.SelectionLength = 0
        Me.dated.SelectionStart = 0
        Me.dated.ShowClearButton = True
        Me.dated.Size = New System.Drawing.Size(152, 27)
        Me.dated.Style = MetroFramework.MetroColorStyle.Teal
        Me.dated.TabIndex = 599
        Me.dated.UseCustomForeColor = True
        Me.dated.UseSelectable = True
        Me.dated.UseStyleColors = True
        Me.dated.WaterMark = "DATE"
        Me.dated.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.dated.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'evaFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 290)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.calldategen)
        Me.Controls.Add(Me.dated)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.EVALUATION)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "evaFRM"
        Me.Text = "EVALUATION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents EVALUATION As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents calldategen As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dated As MetroFramework.Controls.MetroTextBox
End Class
