﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newqsFRM
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
        Me.question = New MetroFramework.Controls.MetroTextBox()
        Me.item = New MetroFramework.Controls.MetroTextBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'question
        '
        '
        '
        '
        Me.question.CustomButton.Image = Nothing
        Me.question.CustomButton.Location = New System.Drawing.Point(509, 2)
        Me.question.CustomButton.Name = ""
        Me.question.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.question.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.question.CustomButton.TabIndex = 1
        Me.question.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.question.CustomButton.UseSelectable = True
        Me.question.CustomButton.Visible = False
        Me.question.DisplayIcon = True
        Me.question.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.question.ForeColor = System.Drawing.SystemColors.ControlText
        Me.question.Lines = New String(-1) {}
        Me.question.Location = New System.Drawing.Point(24, 148)
        Me.question.MaxLength = 32767
        Me.question.Name = "question"
        Me.question.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.question.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.question.SelectedText = ""
        Me.question.SelectionLength = 0
        Me.question.SelectionStart = 0
        Me.question.ShowClearButton = True
        Me.question.Size = New System.Drawing.Size(539, 32)
        Me.question.Style = MetroFramework.MetroColorStyle.Red
        Me.question.TabIndex = 2
        Me.question.UseCustomForeColor = True
        Me.question.UseSelectable = True
        Me.question.WaterMark = "(Specification) Question"
        Me.question.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.question.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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
        Me.item.Location = New System.Drawing.Point(24, 87)
        Me.item.MaxLength = 32767
        Me.item.Name = "item"
        Me.item.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.item.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.item.SelectedText = ""
        Me.item.SelectionLength = 0
        Me.item.SelectionStart = 0
        Me.item.ShowClearButton = True
        Me.item.Size = New System.Drawing.Size(157, 32)
        Me.item.Style = MetroFramework.MetroColorStyle.Red
        Me.item.TabIndex = 1
        Me.item.UseCustomForeColor = True
        Me.item.UseSelectable = True
        Me.item.WaterMark = "Item"
        Me.item.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.item.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(444, 186)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 491
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(24, 64)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(38, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 521
        Me.KryptonLabel1.Values.Text = "Item"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(24, 121)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(160, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 522
        Me.KryptonLabel2.Values.Text = "(Specification) / Question"
        '
        'newqsFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 226)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.question)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(586, 226)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(586, 226)
        Me.Name = "newqsFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "W"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents question As MetroFramework.Controls.MetroTextBox
    Friend WithEvents item As MetroFramework.Controls.MetroTextBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
