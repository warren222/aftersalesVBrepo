<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newconcernFRM
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
        Me.concern = New MetroFramework.Controls.MetroTextBox()
        Me.item = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(443, 150)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 494
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'concern
        '
        '
        '
        '
        Me.concern.CustomButton.Image = Nothing
        Me.concern.CustomButton.Location = New System.Drawing.Point(509, 2)
        Me.concern.CustomButton.Name = ""
        Me.concern.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.concern.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.concern.CustomButton.TabIndex = 1
        Me.concern.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.concern.CustomButton.UseSelectable = True
        Me.concern.CustomButton.Visible = False
        Me.concern.DisplayIcon = True
        Me.concern.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.concern.ForeColor = System.Drawing.SystemColors.ControlText
        Me.concern.Lines = New String(-1) {}
        Me.concern.Location = New System.Drawing.Point(90, 112)
        Me.concern.MaxLength = 32767
        Me.concern.Name = "concern"
        Me.concern.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.concern.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.concern.SelectedText = ""
        Me.concern.SelectionLength = 0
        Me.concern.SelectionStart = 0
        Me.concern.ShowClearButton = True
        Me.concern.Size = New System.Drawing.Size(472, 32)
        Me.concern.Style = MetroFramework.MetroColorStyle.Red
        Me.concern.TabIndex = 493
        Me.concern.UseCustomForeColor = True
        Me.concern.UseSelectable = True
        Me.concern.WaterMark = "Concern"
        Me.concern.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.concern.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'item
        '
        '
        '
        '
        Me.item.CustomButton.Image = Nothing
        Me.item.CustomButton.Location = New System.Drawing.Point(127, 2)
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
        Me.item.Location = New System.Drawing.Point(90, 74)
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
        Me.item.TabIndex = 492
        Me.item.UseCustomForeColor = True
        Me.item.UseSelectable = True
        Me.item.WaterMark = "Item"
        Me.item.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.item.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(23, 112)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(61, 22)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 524
        Me.KryptonLabel5.Values.Text = "Concern"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 78)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(38, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 523
        Me.KryptonLabel1.Values.Text = "Item"
        '
        'newconcernFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 195)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.concern)
        Me.Controls.Add(Me.item)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(586, 195)
        Me.MinimizeBox = False
        Me.Name = "newconcernFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newconcernFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents concern As MetroFramework.Controls.MetroTextBox
    Friend WithEvents item As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
