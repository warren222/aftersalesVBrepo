﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.positions = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'SAVE
        '
        Me.SAVE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SAVE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SAVE.Image = Nothing
        Me.SAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SAVE.Location = New System.Drawing.Point(352, 111)
        Me.SAVE.Name = "SAVE"
        Me.SAVE.Size = New System.Drawing.Size(68, 29)
        Me.SAVE.Style = MetroFramework.MetroColorStyle.Yellow
        Me.SAVE.TabIndex = 3
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
        Me.PERSONNEL.Location = New System.Drawing.Point(105, 76)
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
        Me.PERSONNEL.TabIndex = 1
        Me.PERSONNEL.UseCustomForeColor = True
        Me.PERSONNEL.UseSelectable = True
        Me.PERSONNEL.WaterMark = "Personnel"
        Me.PERSONNEL.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PERSONNEL.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'positions
        '
        '
        '
        '
        Me.positions.CustomButton.Image = Nothing
        Me.positions.CustomButton.Location = New System.Drawing.Point(213, 1)
        Me.positions.CustomButton.Name = ""
        Me.positions.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.positions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.positions.CustomButton.TabIndex = 1
        Me.positions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.positions.CustomButton.UseSelectable = True
        Me.positions.CustomButton.Visible = False
        Me.positions.DisplayIcon = True
        Me.positions.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.positions.ForeColor = System.Drawing.Color.Black
        Me.positions.Lines = New String(-1) {}
        Me.positions.Location = New System.Drawing.Point(105, 111)
        Me.positions.MaxLength = 32767
        Me.positions.Name = "positions"
        Me.positions.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.positions.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.positions.SelectedText = ""
        Me.positions.SelectionLength = 0
        Me.positions.SelectionStart = 0
        Me.positions.ShowClearButton = True
        Me.positions.Size = New System.Drawing.Size(241, 29)
        Me.positions.Style = MetroFramework.MetroColorStyle.Red
        Me.positions.TabIndex = 2
        Me.positions.UseCustomForeColor = True
        Me.positions.UseSelectable = True
        Me.positions.WaterMark = "Personnel"
        Me.positions.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.positions.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(31, 76)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(73, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 562
        Me.KryptonLabel5.Values.Text = "Fullname :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(31, 111)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 563
        Me.KryptonLabel1.Values.Text = "Position :"
        '
        'editpersonnelFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 162)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.positions)
        Me.Controls.Add(Me.SAVE)
        Me.Controls.Add(Me.PERSONNEL)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(443, 162)
        Me.MinimizeBox = False
        Me.Name = "editpersonnelFRM"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SAVE As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents PERSONNEL As MetroFramework.Controls.MetroTextBox
    Friend WithEvents positions As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
