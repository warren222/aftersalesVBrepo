<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newreportFRM
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
        Me.assessment = New MetroFramework.Controls.MetroTextBox()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.location = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(449, 218)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 492
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
        Me.assessment.CustomButton.Location = New System.Drawing.Point(229, 2)
        Me.assessment.CustomButton.Name = ""
        Me.assessment.CustomButton.Size = New System.Drawing.Size(87, 87)
        Me.assessment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.assessment.CustomButton.TabIndex = 1
        Me.assessment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.assessment.CustomButton.UseSelectable = True
        Me.assessment.CustomButton.Visible = False
        Me.assessment.DisplayIcon = True
        Me.assessment.Lines = New String(-1) {}
        Me.assessment.Location = New System.Drawing.Point(249, 122)
        Me.assessment.MaxLength = 32767
        Me.assessment.Multiline = True
        Me.assessment.Name = "assessment"
        Me.assessment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.assessment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.assessment.SelectedText = ""
        Me.assessment.SelectionLength = 0
        Me.assessment.SelectionStart = 0
        Me.assessment.ShowClearButton = True
        Me.assessment.Size = New System.Drawing.Size(319, 92)
        Me.assessment.Style = MetroFramework.MetroColorStyle.Red
        Me.assessment.TabIndex = 3
        Me.assessment.UseCustomForeColor = True
        Me.assessment.UseSelectable = True
        Me.assessment.WaterMark = "Enter Assessment"
        Me.assessment.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.assessment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'specification
        '
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.DropDownHeight = 200
        Me.specification.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.IntegralHeight = False
        Me.specification.Location = New System.Drawing.Point(37, 186)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(193, 28)
        Me.specification.TabIndex = 2
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(37, 158)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 496
        Me.KryptonLabel1.Values.Text = "Specification"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(37, 96)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 498
        Me.KryptonLabel2.Values.Text = "Location"
        '
        'location
        '
        Me.location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.location.DropDownHeight = 200
        Me.location.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.location.FormattingEnabled = True
        Me.location.IntegralHeight = False
        Me.location.Location = New System.Drawing.Point(37, 124)
        Me.location.Name = "location"
        Me.location.Size = New System.Drawing.Size(193, 28)
        Me.location.TabIndex = 1
        '
        'newreportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 269)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.location)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.specification)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.assessment)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(599, 269)
        Me.MinimizeBox = False
        Me.Name = "newreportFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newreportFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents assessment As MetroFramework.Controls.MetroTextBox
    Friend WithEvents specification As ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents location As ComboBox
End Class
