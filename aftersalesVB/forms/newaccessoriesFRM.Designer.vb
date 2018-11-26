<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newaccessoriesFRM
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
        Me.articleno = New MetroFramework.Controls.MetroTextBox()
        Me.description = New MetroFramework.Controls.MetroTextBox()
        Me.unit = New MetroFramework.Controls.MetroTextBox()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.unitprice = New MetroFramework.Controls.MetroTextBox()
        Me.remarks = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(518, 205)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 514
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'articleno
        '
        '
        '
        '
        Me.articleno.CustomButton.Image = Nothing
        Me.articleno.CustomButton.Location = New System.Drawing.Point(250, 2)
        Me.articleno.CustomButton.Name = ""
        Me.articleno.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.articleno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.articleno.CustomButton.TabIndex = 1
        Me.articleno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.articleno.CustomButton.UseSelectable = True
        Me.articleno.CustomButton.Visible = False
        Me.articleno.DisplayIcon = True
        Me.articleno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.articleno.Lines = New String(-1) {}
        Me.articleno.Location = New System.Drawing.Point(131, 127)
        Me.articleno.MaxLength = 32767
        Me.articleno.Multiline = True
        Me.articleno.Name = "articleno"
        Me.articleno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.articleno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.articleno.SelectedText = ""
        Me.articleno.SelectionLength = 0
        Me.articleno.SelectionStart = 0
        Me.articleno.ShowClearButton = True
        Me.articleno.Size = New System.Drawing.Size(276, 28)
        Me.articleno.Style = MetroFramework.MetroColorStyle.Red
        Me.articleno.TabIndex = 2
        Me.articleno.UseCustomForeColor = True
        Me.articleno.UseSelectable = True
        Me.articleno.WaterMark = "Articleno"
        Me.articleno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.articleno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'description
        '
        '
        '
        '
        Me.description.CustomButton.Image = Nothing
        Me.description.CustomButton.Location = New System.Drawing.Point(250, 2)
        Me.description.CustomButton.Name = ""
        Me.description.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.description.CustomButton.TabIndex = 1
        Me.description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.description.CustomButton.UseSelectable = True
        Me.description.CustomButton.Visible = False
        Me.description.DisplayIcon = True
        Me.description.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.description.Lines = New String(-1) {}
        Me.description.Location = New System.Drawing.Point(131, 161)
        Me.description.MaxLength = 32767
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.description.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.description.SelectedText = ""
        Me.description.SelectionLength = 0
        Me.description.SelectionStart = 0
        Me.description.ShowClearButton = True
        Me.description.Size = New System.Drawing.Size(276, 28)
        Me.description.Style = MetroFramework.MetroColorStyle.Red
        Me.description.TabIndex = 3
        Me.description.UseCustomForeColor = True
        Me.description.UseSelectable = True
        Me.description.WaterMark = "Description"
        Me.description.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.description.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'unit
        '
        '
        '
        '
        Me.unit.CustomButton.Image = Nothing
        Me.unit.CustomButton.Location = New System.Drawing.Point(112, 2)
        Me.unit.CustomButton.Name = ""
        Me.unit.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.unit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.unit.CustomButton.TabIndex = 1
        Me.unit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.unit.CustomButton.UseSelectable = True
        Me.unit.CustomButton.Visible = False
        Me.unit.DisplayIcon = True
        Me.unit.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.unit.Lines = New String(-1) {}
        Me.unit.Location = New System.Drawing.Point(499, 93)
        Me.unit.MaxLength = 32767
        Me.unit.Multiline = True
        Me.unit.Name = "unit"
        Me.unit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unit.SelectedText = ""
        Me.unit.SelectionLength = 0
        Me.unit.SelectionStart = 0
        Me.unit.ShowClearButton = True
        Me.unit.Size = New System.Drawing.Size(138, 28)
        Me.unit.Style = MetroFramework.MetroColorStyle.Red
        Me.unit.TabIndex = 4
        Me.unit.UseCustomForeColor = True
        Me.unit.UseSelectable = True
        Me.unit.WaterMark = "Unit"
        Me.unit.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.unit.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'specification
        '
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.DropDownHeight = 200
        Me.specification.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.IntegralHeight = False
        Me.specification.Location = New System.Drawing.Point(131, 93)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(276, 28)
        Me.specification.TabIndex = 1
        '
        'unitprice
        '
        '
        '
        '
        Me.unitprice.CustomButton.Image = Nothing
        Me.unitprice.CustomButton.Location = New System.Drawing.Point(112, 2)
        Me.unitprice.CustomButton.Name = ""
        Me.unitprice.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.unitprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.unitprice.CustomButton.TabIndex = 1
        Me.unitprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.unitprice.CustomButton.UseSelectable = True
        Me.unitprice.CustomButton.Visible = False
        Me.unitprice.DisplayIcon = True
        Me.unitprice.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.unitprice.Lines = New String(-1) {}
        Me.unitprice.Location = New System.Drawing.Point(499, 127)
        Me.unitprice.MaxLength = 32767
        Me.unitprice.Multiline = True
        Me.unitprice.Name = "unitprice"
        Me.unitprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unitprice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unitprice.SelectedText = ""
        Me.unitprice.SelectionLength = 0
        Me.unitprice.SelectionStart = 0
        Me.unitprice.ShowClearButton = True
        Me.unitprice.Size = New System.Drawing.Size(138, 28)
        Me.unitprice.Style = MetroFramework.MetroColorStyle.Red
        Me.unitprice.TabIndex = 5
        Me.unitprice.UseCustomForeColor = True
        Me.unitprice.UseSelectable = True
        Me.unitprice.WaterMark = "Unit Price"
        Me.unitprice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.unitprice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'remarks
        '
        '
        '
        '
        Me.remarks.CustomButton.Image = Nothing
        Me.remarks.CustomButton.Location = New System.Drawing.Point(112, 2)
        Me.remarks.CustomButton.Name = ""
        Me.remarks.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.remarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.remarks.CustomButton.TabIndex = 1
        Me.remarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.remarks.CustomButton.UseSelectable = True
        Me.remarks.CustomButton.Visible = False
        Me.remarks.DisplayIcon = True
        Me.remarks.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.remarks.Lines = New String(-1) {}
        Me.remarks.Location = New System.Drawing.Point(499, 161)
        Me.remarks.MaxLength = 32767
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.remarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.remarks.SelectedText = ""
        Me.remarks.SelectionLength = 0
        Me.remarks.SelectionStart = 0
        Me.remarks.ShowClearButton = True
        Me.remarks.Size = New System.Drawing.Size(138, 28)
        Me.remarks.Style = MetroFramework.MetroColorStyle.Red
        Me.remarks.TabIndex = 6
        Me.remarks.UseCustomForeColor = True
        Me.remarks.UseSelectable = True
        Me.remarks.WaterMark = "Remarks"
        Me.remarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.remarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(37, 93)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(88, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 518
        Me.KryptonLabel1.Values.Text = "Specification"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(424, 93)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(36, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 519
        Me.KryptonLabel2.Values.Text = "Unit"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(424, 127)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(69, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 520
        Me.KryptonLabel3.Values.Text = "Unit Price"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(424, 161)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(63, 22)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 521
        Me.KryptonLabel4.Values.Text = "Remarks"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(37, 127)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(71, 22)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 522
        Me.KryptonLabel5.Values.Text = "Article No"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(37, 161)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(80, 22)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 523
        Me.KryptonLabel6.Values.Text = "Description"
        '
        'newaccessoriesFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 264)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.KryptonLabel5)
        Me.Controls.Add(Me.KryptonLabel4)
        Me.Controls.Add(Me.KryptonLabel3)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.remarks)
        Me.Controls.Add(Me.unitprice)
        Me.Controls.Add(Me.specification)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.articleno)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.unit)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(662, 264)
        Me.MinimizeBox = False
        Me.Name = "newaccessoriesFRM"
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "newaccessoriesFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents articleno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents description As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents specification As ComboBox
    Friend WithEvents unitprice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents remarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
