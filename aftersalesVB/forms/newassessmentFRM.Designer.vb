<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newassessmentFRM
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
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.assessment = New MetroFramework.Controls.MetroTextBox()
        Me.item = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(23, 109)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(82, 22)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 529
        Me.KryptonLabel5.Values.Text = "Assessment"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 75)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(38, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 528
        Me.KryptonLabel1.Values.Text = "Item"
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(464, 148)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 527
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'assessment
        '
        '
        '
        '
        Me.assessment.CustomButton.Image = Nothing
        Me.assessment.CustomButton.Location = New System.Drawing.Point(442, 2)
        Me.assessment.CustomButton.Name = ""
        Me.assessment.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.assessment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.assessment.CustomButton.TabIndex = 1
        Me.assessment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.assessment.CustomButton.UseSelectable = True
        Me.assessment.CustomButton.Visible = False
        Me.assessment.DisplayIcon = True
        Me.assessment.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.assessment.ForeColor = System.Drawing.SystemColors.ControlText
        Me.assessment.Lines = New String(-1) {}
        Me.assessment.Location = New System.Drawing.Point(111, 109)
        Me.assessment.MaxLength = 32767
        Me.assessment.Name = "assessment"
        Me.assessment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.assessment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.assessment.SelectedText = ""
        Me.assessment.SelectionLength = 0
        Me.assessment.SelectionStart = 0
        Me.assessment.ShowClearButton = True
        Me.assessment.Size = New System.Drawing.Size(472, 32)
        Me.assessment.Style = MetroFramework.MetroColorStyle.Red
        Me.assessment.TabIndex = 526
        Me.assessment.UseCustomForeColor = True
        Me.assessment.UseSelectable = True
        Me.assessment.WaterMark = "Assessment"
        Me.assessment.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.assessment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'item
        '
        '
        '
        '
        Me.item.CustomButton.Image = Nothing
        Me.item.CustomButton.Location = New System.Drawing.Point(140, 2)
        Me.item.CustomButton.Name = ""
        Me.item.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.item.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.item.CustomButton.TabIndex = 1
        Me.item.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.item.CustomButton.UseSelectable = True
        Me.item.CustomButton.Visible = False
        Me.item.DisplayIcon = True
        Me.item.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.item.Lines = New String(-1) {}
        Me.item.Location = New System.Drawing.Point(111, 71)
        Me.item.MaxLength = 32767
        Me.item.Name = "item"
        Me.item.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.item.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.item.SelectedText = ""
        Me.item.SelectionLength = 0
        Me.item.SelectionStart = 0
        Me.item.ShowClearButton = True
        Me.item.Size = New System.Drawing.Size(170, 32)
        Me.item.Style = MetroFramework.MetroColorStyle.Red
        Me.item.TabIndex = 525
        Me.item.UseCustomForeColor = True
        Me.item.UseSelectable = True
        Me.item.WaterMark = "Item"
        Me.item.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.item.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'newassessmentFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 199)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.assessment)
        Me.Controls.Add(Me.item)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newassessmentFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents assessment As MetroFramework.Controls.MetroTextBox
    Friend WithEvents item As MetroFramework.Controls.MetroTextBox
End Class
