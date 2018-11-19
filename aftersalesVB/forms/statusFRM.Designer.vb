<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statusFRM
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
        Me.status = New MetroFramework.Controls.MetroComboBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.statusdate = New MetroFramework.Controls.MetroTextBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SuspendLayout()
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.ItemHeight = 23
        Me.status.Items.AddRange(New Object() {"Reschedule", "For Costing", "Done"})
        Me.status.Location = New System.Drawing.Point(251, 105)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(152, 29)
        Me.status.TabIndex = 474
        Me.status.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.status.UseSelectable = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(35, 77)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 488
        Me.KryptonLabel1.Values.Text = "Date Status"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CustomFormat = "yyyy-MMM-dd"
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MetroDateTime1.Location = New System.Drawing.Point(35, 105)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(189, 29)
        Me.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroDateTime1.TabIndex = 487
        Me.MetroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'statusdate
        '
        '
        '
        '
        Me.statusdate.CustomButton.Image = Nothing
        Me.statusdate.CustomButton.Location = New System.Drawing.Point(163, 2)
        Me.statusdate.CustomButton.Name = ""
        Me.statusdate.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.statusdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.statusdate.CustomButton.TabIndex = 1
        Me.statusdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.statusdate.CustomButton.UseSelectable = True
        Me.statusdate.CustomButton.Visible = False
        Me.statusdate.DisplayIcon = True
        Me.statusdate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.statusdate.ForeColor = System.Drawing.Color.White
        Me.statusdate.Lines = New String(-1) {}
        Me.statusdate.Location = New System.Drawing.Point(35, 140)
        Me.statusdate.MaxLength = 32767
        Me.statusdate.Multiline = True
        Me.statusdate.Name = "statusdate"
        Me.statusdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.statusdate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.statusdate.SelectedText = ""
        Me.statusdate.SelectionLength = 0
        Me.statusdate.SelectionStart = 0
        Me.statusdate.ShowClearButton = True
        Me.statusdate.Size = New System.Drawing.Size(189, 28)
        Me.statusdate.Style = MetroFramework.MetroColorStyle.Red
        Me.statusdate.TabIndex = 489
        Me.statusdate.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.statusdate.UseCustomForeColor = True
        Me.statusdate.UseSelectable = True
        Me.statusdate.WaterMark = "Enter Status Date"
        Me.statusdate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.statusdate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(251, 140)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(152, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 491
        Me.save.Text = "save"
        Me.save.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'statusFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 215)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.statusdate)
        Me.Controls.Add(Me.status)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "statusFRM"
        Me.Style = MetroFramework.MetroColorStyle.Red
        Me.Text = "Status"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents status As MetroFramework.Controls.MetroComboBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents statusdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
