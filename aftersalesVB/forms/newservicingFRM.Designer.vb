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
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.servicingdate = New MetroFramework.Controls.MetroTextBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.TEAM = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.teamid = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
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
        Me.save.Location = New System.Drawing.Point(410, 133)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(62, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 490
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'TEAM
        '
        Me.TEAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TEAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TEAM.DropDownHeight = 200
        Me.TEAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TEAM.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEAM.FormattingEnabled = True
        Me.TEAM.IntegralHeight = False
        Me.TEAM.Location = New System.Drawing.Point(279, 98)
        Me.TEAM.Name = "TEAM"
        Me.TEAM.Size = New System.Drawing.Size(193, 28)
        Me.TEAM.TabIndex = 491
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(279, 70)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(97, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 492
        Me.KryptonLabel2.Values.Text = "ASSIGN TEAM"
        '
        'teamid
        '
        '
        '
        '
        Me.teamid.CustomButton.Image = Nothing
        Me.teamid.CustomButton.Location = New System.Drawing.Point(99, 2)
        Me.teamid.CustomButton.Name = ""
        Me.teamid.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.teamid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.teamid.CustomButton.TabIndex = 1
        Me.teamid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.teamid.CustomButton.UseSelectable = True
        Me.teamid.CustomButton.Visible = False
        Me.teamid.DisplayIcon = True
        Me.teamid.Enabled = False
        Me.teamid.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.teamid.Lines = New String(-1) {}
        Me.teamid.Location = New System.Drawing.Point(279, 132)
        Me.teamid.MaxLength = 32767
        Me.teamid.Multiline = True
        Me.teamid.Name = "teamid"
        Me.teamid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.teamid.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.teamid.SelectedText = ""
        Me.teamid.SelectionLength = 0
        Me.teamid.SelectionStart = 0
        Me.teamid.ShowClearButton = True
        Me.teamid.Size = New System.Drawing.Size(125, 28)
        Me.teamid.Style = MetroFramework.MetroColorStyle.Red
        Me.teamid.TabIndex = 493
        Me.teamid.UseCustomForeColor = True
        Me.teamid.UseSelectable = True
        Me.teamid.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.teamid.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'newservicingFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 212)
        Me.Controls.Add(Me.teamid)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.TEAM)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.servicingdate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newservicingFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newservicingFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents servicingdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents TEAM As ComboBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents teamid As MetroFramework.Controls.MetroTextBox
End Class
