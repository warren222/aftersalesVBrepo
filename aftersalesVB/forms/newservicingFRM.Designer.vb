<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newservicingFRM
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
        Me.MetroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.metroTextButton1 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.personnel = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.assignedpersonnelTXT = New MetroFramework.Controls.MetroTextBox()
        Me.servicingdate = New MetroFramework.Controls.MetroTextBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SuspendLayout()
        '
        'MetroTextButton2
        '
        Me.MetroTextButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTextButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MetroTextButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton2.Image = Nothing
        Me.MetroTextButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton2.Location = New System.Drawing.Point(516, 98)
        Me.MetroTextButton2.Name = "MetroTextButton2"
        Me.MetroTextButton2.Size = New System.Drawing.Size(54, 28)
        Me.MetroTextButton2.Style = MetroFramework.MetroColorStyle.Yellow
        Me.MetroTextButton2.TabIndex = 489
        Me.MetroTextButton2.Text = "-"
        Me.MetroTextButton2.UseCustomBackColor = True
        Me.MetroTextButton2.UseCustomForeColor = True
        Me.MetroTextButton2.UseSelectable = True
        Me.MetroTextButton2.UseVisualStyleBackColor = False
        '
        'metroTextButton1
        '
        Me.metroTextButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.metroTextButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.metroTextButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.metroTextButton1.Image = Nothing
        Me.metroTextButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton1.Location = New System.Drawing.Point(450, 98)
        Me.metroTextButton1.Name = "metroTextButton1"
        Me.metroTextButton1.Size = New System.Drawing.Size(60, 28)
        Me.metroTextButton1.Style = MetroFramework.MetroColorStyle.Yellow
        Me.metroTextButton1.TabIndex = 488
        Me.metroTextButton1.Text = "+"
        Me.metroTextButton1.UseCustomBackColor = True
        Me.metroTextButton1.UseCustomForeColor = True
        Me.metroTextButton1.UseSelectable = True
        Me.metroTextButton1.UseVisualStyleBackColor = False
        '
        'personnel
        '
        Me.personnel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.personnel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.personnel.DropDownHeight = 200
        Me.personnel.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personnel.FormattingEnabled = True
        Me.personnel.IntegralHeight = False
        Me.personnel.Location = New System.Drawing.Point(251, 98)
        Me.personnel.Name = "personnel"
        Me.personnel.Size = New System.Drawing.Size(193, 28)
        Me.personnel.TabIndex = 487
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 70)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(98, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 485
        Me.KryptonLabel1.Values.Text = "Date Servicing"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CustomFormat = "yyyy-MMM-dd"
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MetroDateTime1.Location = New System.Drawing.Point(23, 98)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(189, 29)
        Me.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroDateTime1.TabIndex = 484
        '
        'assignedpersonnelTXT
        '
        '
        '
        '
        Me.assignedpersonnelTXT.CustomButton.Image = Nothing
        Me.assignedpersonnelTXT.CustomButton.Location = New System.Drawing.Point(249, 2)
        Me.assignedpersonnelTXT.CustomButton.Name = ""
        Me.assignedpersonnelTXT.CustomButton.Size = New System.Drawing.Size(67, 67)
        Me.assignedpersonnelTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.assignedpersonnelTXT.CustomButton.TabIndex = 1
        Me.assignedpersonnelTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.assignedpersonnelTXT.CustomButton.UseSelectable = True
        Me.assignedpersonnelTXT.CustomButton.Visible = False
        Me.assignedpersonnelTXT.DisplayIcon = True
        Me.assignedpersonnelTXT.Lines = New String(-1) {}
        Me.assignedpersonnelTXT.Location = New System.Drawing.Point(251, 132)
        Me.assignedpersonnelTXT.MaxLength = 32767
        Me.assignedpersonnelTXT.Multiline = True
        Me.assignedpersonnelTXT.Name = "assignedpersonnelTXT"
        Me.assignedpersonnelTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.assignedpersonnelTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.assignedpersonnelTXT.SelectedText = ""
        Me.assignedpersonnelTXT.SelectionLength = 0
        Me.assignedpersonnelTXT.SelectionStart = 0
        Me.assignedpersonnelTXT.ShowClearButton = True
        Me.assignedpersonnelTXT.Size = New System.Drawing.Size(319, 72)
        Me.assignedpersonnelTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.assignedpersonnelTXT.TabIndex = 483
        Me.assignedpersonnelTXT.UseCustomForeColor = True
        Me.assignedpersonnelTXT.UseSelectable = True
        Me.assignedpersonnelTXT.WaterMark = "Enter Assigned Personnel"
        Me.assignedpersonnelTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.assignedpersonnelTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'servicingdate
        '
        '
        '
        '
        Me.servicingdate.CustomButton.Image = Nothing
        Me.servicingdate.CustomButton.Location = New System.Drawing.Point(163, 2)
        Me.servicingdate.CustomButton.Name = ""
        Me.servicingdate.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.servicingdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.servicingdate.CustomButton.TabIndex = 1
        Me.servicingdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.servicingdate.CustomButton.UseSelectable = True
        Me.servicingdate.CustomButton.Visible = False
        Me.servicingdate.DisplayIcon = True
        Me.servicingdate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.servicingdate.Lines = New String(-1) {}
        Me.servicingdate.Location = New System.Drawing.Point(23, 133)
        Me.servicingdate.MaxLength = 32767
        Me.servicingdate.Multiline = True
        Me.servicingdate.Name = "servicingdate"
        Me.servicingdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.servicingdate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.servicingdate.SelectedText = ""
        Me.servicingdate.SelectionLength = 0
        Me.servicingdate.SelectionStart = 0
        Me.servicingdate.ShowClearButton = True
        Me.servicingdate.Size = New System.Drawing.Size(189, 28)
        Me.servicingdate.Style = MetroFramework.MetroColorStyle.Red
        Me.servicingdate.TabIndex = 486
        Me.servicingdate.UseCustomForeColor = True
        Me.servicingdate.UseSelectable = True
        Me.servicingdate.WaterMark = "Enter Servicing Date"
        Me.servicingdate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.servicingdate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(450, 215)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 490
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'newservicingFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 266)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.MetroTextButton2)
        Me.Controls.Add(Me.metroTextButton1)
        Me.Controls.Add(Me.personnel)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.assignedpersonnelTXT)
        Me.Controls.Add(Me.servicingdate)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(592, 266)
        Me.MinimizeBox = False
        Me.Name = "newservicingFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newservicingFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents metroTextButton1 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents personnel As ComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents assignedpersonnelTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents servicingdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
