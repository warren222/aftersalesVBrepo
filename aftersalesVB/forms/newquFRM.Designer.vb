﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newquFRM
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
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.qudate = New MetroFramework.Controls.MetroTextBox()
        Me.aseno = New MetroFramework.Controls.MetroTextBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.othercharges = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.particular = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CustomFormat = "yyyy-MMM-dd"
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MetroDateTime1.Location = New System.Drawing.Point(23, 106)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(126, 29)
        Me.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroDateTime1.TabIndex = 32
        '
        'qudate
        '
        '
        '
        '
        Me.qudate.CustomButton.Image = Nothing
        Me.qudate.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.qudate.CustomButton.Name = ""
        Me.qudate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.qudate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.qudate.CustomButton.TabIndex = 1
        Me.qudate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.qudate.CustomButton.UseSelectable = True
        Me.qudate.CustomButton.Visible = False
        Me.qudate.DisplayIcon = True
        Me.qudate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.qudate.Lines = New String(-1) {}
        Me.qudate.Location = New System.Drawing.Point(155, 106)
        Me.qudate.MaxLength = 32767
        Me.qudate.Multiline = True
        Me.qudate.Name = "qudate"
        Me.qudate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qudate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.qudate.SelectedText = ""
        Me.qudate.SelectionLength = 0
        Me.qudate.SelectionStart = 0
        Me.qudate.ShowClearButton = True
        Me.qudate.Size = New System.Drawing.Size(153, 29)
        Me.qudate.Style = MetroFramework.MetroColorStyle.Red
        Me.qudate.TabIndex = 1
        Me.qudate.UseCustomForeColor = True
        Me.qudate.UseSelectable = True
        Me.qudate.WaterMark = "Quotation Date"
        Me.qudate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.qudate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'aseno
        '
        '
        '
        '
        Me.aseno.CustomButton.Image = Nothing
        Me.aseno.CustomButton.Location = New System.Drawing.Point(125, 1)
        Me.aseno.CustomButton.Name = ""
        Me.aseno.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.aseno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.aseno.CustomButton.TabIndex = 1
        Me.aseno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.aseno.CustomButton.UseSelectable = True
        Me.aseno.CustomButton.Visible = False
        Me.aseno.DisplayIcon = True
        Me.aseno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.aseno.Lines = New String(-1) {}
        Me.aseno.Location = New System.Drawing.Point(155, 141)
        Me.aseno.MaxLength = 32767
        Me.aseno.Multiline = True
        Me.aseno.Name = "aseno"
        Me.aseno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.aseno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.aseno.SelectedText = ""
        Me.aseno.SelectionLength = 0
        Me.aseno.SelectionStart = 0
        Me.aseno.ShowClearButton = True
        Me.aseno.Size = New System.Drawing.Size(153, 29)
        Me.aseno.Style = MetroFramework.MetroColorStyle.Red
        Me.aseno.TabIndex = 2
        Me.aseno.UseCustomForeColor = True
        Me.aseno.UseSelectable = True
        Me.aseno.WaterMark = "ASE NO"
        Me.aseno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.aseno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(333, 270)
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
        Me.KryptonLabel1.Location = New System.Drawing.Point(23, 78)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(105, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 492
        Me.KryptonLabel1.Values.Text = "Quotation Date"
        '
        'othercharges
        '
        '
        '
        '
        Me.othercharges.CustomButton.Image = Nothing
        Me.othercharges.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.othercharges.CustomButton.Name = ""
        Me.othercharges.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.othercharges.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.othercharges.CustomButton.TabIndex = 1
        Me.othercharges.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.othercharges.CustomButton.UseSelectable = True
        Me.othercharges.CustomButton.Visible = False
        Me.othercharges.DisplayIcon = True
        Me.othercharges.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.othercharges.Lines = New String() {"0"}
        Me.othercharges.Location = New System.Drawing.Point(155, 190)
        Me.othercharges.MaxLength = 32767
        Me.othercharges.Multiline = True
        Me.othercharges.Name = "othercharges"
        Me.othercharges.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.othercharges.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.othercharges.SelectedText = ""
        Me.othercharges.SelectionLength = 0
        Me.othercharges.SelectionStart = 0
        Me.othercharges.ShowClearButton = True
        Me.othercharges.Size = New System.Drawing.Size(297, 29)
        Me.othercharges.Style = MetroFramework.MetroColorStyle.Red
        Me.othercharges.TabIndex = 3
        Me.othercharges.Text = "0"
        Me.othercharges.UseCustomForeColor = True
        Me.othercharges.UseSelectable = True
        Me.othercharges.WaterMark = "Enter Other charges"
        Me.othercharges.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.othercharges.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(23, 190)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(99, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 494
        Me.KryptonLabel2.Values.Text = "Other Charges"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(23, 225)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 496
        Me.KryptonLabel3.Values.Text = "Particular"
        '
        'particular
        '
        '
        '
        '
        Me.particular.CustomButton.Image = Nothing
        Me.particular.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.particular.CustomButton.Name = ""
        Me.particular.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.particular.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.particular.CustomButton.TabIndex = 1
        Me.particular.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.particular.CustomButton.UseSelectable = True
        Me.particular.CustomButton.Visible = False
        Me.particular.DisplayIcon = True
        Me.particular.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.particular.Lines = New String(-1) {}
        Me.particular.Location = New System.Drawing.Point(155, 225)
        Me.particular.MaxLength = 32767
        Me.particular.Multiline = True
        Me.particular.Name = "particular"
        Me.particular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.particular.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.particular.SelectedText = ""
        Me.particular.SelectionLength = 0
        Me.particular.SelectionStart = 0
        Me.particular.ShowClearButton = True
        Me.particular.Size = New System.Drawing.Size(297, 29)
        Me.particular.Style = MetroFramework.MetroColorStyle.Red
        Me.particular.TabIndex = 495
        Me.particular.UseCustomForeColor = True
        Me.particular.UseSelectable = True
        Me.particular.WaterMark = "Enter Particular"
        Me.particular.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.particular.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(23, 141)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(42, 22)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 497
        Me.KryptonLabel4.Values.Text = "ASE#"
        '
        'newquFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 318)
        Me.Controls.Add(Me.KryptonLabel4)
        Me.Controls.Add(Me.KryptonLabel3)
        Me.Controls.Add(Me.particular)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.othercharges)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.aseno)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.qudate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "newquFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newquFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Public WithEvents qudate As MetroFramework.Controls.MetroTextBox
    Public WithEvents aseno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Public WithEvents othercharges As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Public WithEvents particular As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
