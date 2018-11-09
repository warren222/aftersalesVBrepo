<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newpartsFRM
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
        Me.kryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.unitprice = New MetroFramework.Controls.MetroTextBox()
        Me.qty = New MetroFramework.Controls.MetroTextBox()
        Me.netamount = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.articleno = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.description = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.markup = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'save
        '
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(622, 227)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 516
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'kryptonLabel3
        '
        Me.kryptonLabel3.Location = New System.Drawing.Point(509, 112)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(72, 22)
        Me.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel3.TabIndex = 515
        Me.kryptonLabel3.Values.Text = "Unit Price:"
        '
        'kryptonLabel5
        '
        Me.kryptonLabel5.Location = New System.Drawing.Point(507, 180)
        Me.kryptonLabel5.Name = "kryptonLabel5"
        Me.kryptonLabel5.Size = New System.Drawing.Size(87, 22)
        Me.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel5.TabIndex = 514
        Me.kryptonLabel5.Values.Text = "Net Amount:"
        '
        'kryptonLabel4
        '
        Me.kryptonLabel4.Location = New System.Drawing.Point(507, 146)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(35, 22)
        Me.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel4.TabIndex = 513
        Me.kryptonLabel4.Values.Text = "Qty:"
        '
        'unitprice
        '
        '
        '
        '
        Me.unitprice.CustomButton.Image = Nothing
        Me.unitprice.CustomButton.Location = New System.Drawing.Point(116, 2)
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
        Me.unitprice.Location = New System.Drawing.Point(599, 106)
        Me.unitprice.MaxLength = 32767
        Me.unitprice.Multiline = True
        Me.unitprice.Name = "unitprice"
        Me.unitprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unitprice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unitprice.SelectedText = ""
        Me.unitprice.SelectionLength = 0
        Me.unitprice.SelectionStart = 0
        Me.unitprice.ShowClearButton = True
        Me.unitprice.Size = New System.Drawing.Size(142, 28)
        Me.unitprice.Style = MetroFramework.MetroColorStyle.Red
        Me.unitprice.TabIndex = 510
        Me.unitprice.UseCustomForeColor = True
        Me.unitprice.UseSelectable = True
        Me.unitprice.WaterMark = "Unit Price"
        Me.unitprice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.unitprice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'qty
        '
        '
        '
        '
        Me.qty.CustomButton.Image = Nothing
        Me.qty.CustomButton.Location = New System.Drawing.Point(115, 2)
        Me.qty.CustomButton.Name = ""
        Me.qty.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.qty.CustomButton.TabIndex = 1
        Me.qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.qty.CustomButton.UseSelectable = True
        Me.qty.CustomButton.Visible = False
        Me.qty.DisplayIcon = True
        Me.qty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.qty.Lines = New String(-1) {}
        Me.qty.Location = New System.Drawing.Point(600, 140)
        Me.qty.MaxLength = 32767
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.qty.SelectedText = ""
        Me.qty.SelectionLength = 0
        Me.qty.SelectionStart = 0
        Me.qty.ShowClearButton = True
        Me.qty.Size = New System.Drawing.Size(141, 28)
        Me.qty.Style = MetroFramework.MetroColorStyle.Red
        Me.qty.TabIndex = 511
        Me.qty.UseCustomForeColor = True
        Me.qty.UseSelectable = True
        Me.qty.WaterMark = "Quantity"
        Me.qty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.qty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'netamount
        '
        '
        '
        '
        Me.netamount.CustomButton.Image = Nothing
        Me.netamount.CustomButton.Location = New System.Drawing.Point(115, 2)
        Me.netamount.CustomButton.Name = ""
        Me.netamount.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.netamount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.netamount.CustomButton.TabIndex = 1
        Me.netamount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.netamount.CustomButton.UseSelectable = True
        Me.netamount.CustomButton.Visible = False
        Me.netamount.DisplayIcon = True
        Me.netamount.Enabled = False
        Me.netamount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.netamount.Lines = New String(-1) {}
        Me.netamount.Location = New System.Drawing.Point(600, 174)
        Me.netamount.MaxLength = 32767
        Me.netamount.Multiline = True
        Me.netamount.Name = "netamount"
        Me.netamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.netamount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.netamount.SelectedText = ""
        Me.netamount.SelectionLength = 0
        Me.netamount.SelectionStart = 0
        Me.netamount.ShowClearButton = True
        Me.netamount.Size = New System.Drawing.Size(141, 28)
        Me.netamount.Style = MetroFramework.MetroColorStyle.Red
        Me.netamount.TabIndex = 512
        Me.netamount.UseCustomForeColor = True
        Me.netamount.UseSelectable = True
        Me.netamount.WaterMark = "Net Amount"
        Me.netamount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.netamount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(22, 135)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(68, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 518
        Me.KryptonLabel1.Values.Text = "Article no"
        '
        'articleno
        '
        '
        '
        '
        Me.articleno.CustomButton.Image = Nothing
        Me.articleno.CustomButton.Location = New System.Drawing.Point(138, 2)
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
        Me.articleno.Location = New System.Drawing.Point(112, 129)
        Me.articleno.MaxLength = 32767
        Me.articleno.Multiline = True
        Me.articleno.Name = "articleno"
        Me.articleno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.articleno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.articleno.SelectedText = ""
        Me.articleno.SelectionLength = 0
        Me.articleno.SelectionStart = 0
        Me.articleno.ShowClearButton = True
        Me.articleno.Size = New System.Drawing.Size(164, 28)
        Me.articleno.Style = MetroFramework.MetroColorStyle.Red
        Me.articleno.TabIndex = 517
        Me.articleno.UseCustomForeColor = True
        Me.articleno.UseSelectable = True
        Me.articleno.WaterMark = "Article no"
        Me.articleno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.articleno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(22, 180)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(78, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 520
        Me.KryptonLabel2.Values.Text = "Description"
        '
        'description
        '
        '
        '
        '
        Me.description.CustomButton.Image = Nothing
        Me.description.CustomButton.Location = New System.Drawing.Point(352, 2)
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
        Me.description.Location = New System.Drawing.Point(112, 174)
        Me.description.MaxLength = 32767
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.description.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.description.SelectedText = ""
        Me.description.SelectionLength = 0
        Me.description.SelectionStart = 0
        Me.description.ShowClearButton = True
        Me.description.Size = New System.Drawing.Size(378, 28)
        Me.description.Style = MetroFramework.MetroColorStyle.Red
        Me.description.TabIndex = 519
        Me.description.UseCustomForeColor = True
        Me.description.UseSelectable = True
        Me.description.WaterMark = "Description"
        Me.description.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.description.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(509, 78)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(56, 22)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 522
        Me.KryptonLabel6.Values.Text = "Markup"
        '
        'markup
        '
        '
        '
        '
        Me.markup.CustomButton.Image = Nothing
        Me.markup.CustomButton.Location = New System.Drawing.Point(116, 2)
        Me.markup.CustomButton.Name = ""
        Me.markup.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.markup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.markup.CustomButton.TabIndex = 1
        Me.markup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.markup.CustomButton.UseSelectable = True
        Me.markup.CustomButton.Visible = False
        Me.markup.DisplayIcon = True
        Me.markup.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.markup.Lines = New String(-1) {}
        Me.markup.Location = New System.Drawing.Point(599, 72)
        Me.markup.MaxLength = 32767
        Me.markup.Multiline = True
        Me.markup.Name = "markup"
        Me.markup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.markup.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.markup.SelectedText = ""
        Me.markup.SelectionLength = 0
        Me.markup.SelectionStart = 0
        Me.markup.ShowClearButton = True
        Me.markup.Size = New System.Drawing.Size(142, 28)
        Me.markup.Style = MetroFramework.MetroColorStyle.Red
        Me.markup.TabIndex = 521
        Me.markup.UseCustomForeColor = True
        Me.markup.UseSelectable = True
        Me.markup.WaterMark = "Markup"
        Me.markup.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.markup.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'newpartsFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 278)
        Me.Controls.Add(Me.KryptonLabel6)
        Me.Controls.Add(Me.markup)
        Me.Controls.Add(Me.KryptonLabel2)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.articleno)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.kryptonLabel3)
        Me.Controls.Add(Me.kryptonLabel5)
        Me.Controls.Add(Me.kryptonLabel4)
        Me.Controls.Add(Me.unitprice)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.netamount)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(766, 278)
        Me.MinimizeBox = False
        Me.Name = "newpartsFRM"
        Me.Text = "newpartsFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents kryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents unitprice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents qty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents netamount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents articleno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents description As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents markup As MetroFramework.Controls.MetroTextBox
End Class
