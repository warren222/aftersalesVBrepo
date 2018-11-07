<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newitemFRM
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
        Me.kno = New MetroFramework.Controls.MetroTextBox()
        Me.metroTextButton2 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.kryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.kryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.itemno = New MetroFramework.Controls.MetroTextBox()
        Me.wdwloc = New MetroFramework.Controls.MetroTextBox()
        Me.parts = New MetroFramework.Controls.MetroTextBox()
        Me.unitprice = New MetroFramework.Controls.MetroTextBox()
        Me.qty = New MetroFramework.Controls.MetroTextBox()
        Me.netamount = New MetroFramework.Controls.MetroTextBox()
        Me.save = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SuspendLayout()
        '
        'kno
        '
        '
        '
        '
        Me.kno.CustomButton.Image = Nothing
        Me.kno.CustomButton.Location = New System.Drawing.Point(80, 2)
        Me.kno.CustomButton.Name = ""
        Me.kno.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.kno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.kno.CustomButton.TabIndex = 1
        Me.kno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.kno.CustomButton.UseSelectable = True
        Me.kno.CustomButton.Visible = False
        Me.kno.DisplayIcon = True
        Me.kno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.kno.Lines = New String(-1) {}
        Me.kno.Location = New System.Drawing.Point(23, 150)
        Me.kno.MaxLength = 32767
        Me.kno.Multiline = True
        Me.kno.Name = "kno"
        Me.kno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.kno.SelectedText = ""
        Me.kno.SelectionLength = 0
        Me.kno.SelectionStart = 0
        Me.kno.ShowClearButton = True
        Me.kno.Size = New System.Drawing.Size(106, 28)
        Me.kno.Style = MetroFramework.MetroColorStyle.Red
        Me.kno.TabIndex = 508
        Me.kno.UseCustomForeColor = True
        Me.kno.UseSelectable = True
        Me.kno.WaterMark = "k #"
        Me.kno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'metroTextButton2
        '
        Me.metroTextButton2.BackColor = System.Drawing.Color.DarkGray
        Me.metroTextButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.metroTextButton2.Image = Nothing
        Me.metroTextButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.metroTextButton2.Location = New System.Drawing.Point(23, 116)
        Me.metroTextButton2.Name = "metroTextButton2"
        Me.metroTextButton2.Size = New System.Drawing.Size(106, 28)
        Me.metroTextButton2.Style = MetroFramework.MetroColorStyle.Silver
        Me.metroTextButton2.TabIndex = 507
        Me.metroTextButton2.Text = "import"
        Me.metroTextButton2.UseCustomBackColor = True
        Me.metroTextButton2.UseSelectable = True
        Me.metroTextButton2.UseVisualStyleBackColor = False
        '
        'kryptonLabel3
        '
        Me.kryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonLabel3.Location = New System.Drawing.Point(435, 122)
        Me.kryptonLabel3.Name = "kryptonLabel3"
        Me.kryptonLabel3.Size = New System.Drawing.Size(72, 22)
        Me.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel3.TabIndex = 506
        Me.kryptonLabel3.Values.Text = "Unit Price:"
        '
        'kryptonLabel5
        '
        Me.kryptonLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonLabel5.Location = New System.Drawing.Point(433, 190)
        Me.kryptonLabel5.Name = "kryptonLabel5"
        Me.kryptonLabel5.Size = New System.Drawing.Size(87, 22)
        Me.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel5.TabIndex = 505
        Me.kryptonLabel5.Values.Text = "Net Amount:"
        '
        'kryptonLabel4
        '
        Me.kryptonLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.kryptonLabel4.Location = New System.Drawing.Point(433, 156)
        Me.kryptonLabel4.Name = "kryptonLabel4"
        Me.kryptonLabel4.Size = New System.Drawing.Size(35, 22)
        Me.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel4.TabIndex = 504
        Me.kryptonLabel4.Values.Text = "Qty:"
        '
        'itemno
        '
        '
        '
        '
        Me.itemno.CustomButton.Image = Nothing
        Me.itemno.CustomButton.Location = New System.Drawing.Point(80, 2)
        Me.itemno.CustomButton.Name = ""
        Me.itemno.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.itemno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.itemno.CustomButton.TabIndex = 1
        Me.itemno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.itemno.CustomButton.UseSelectable = True
        Me.itemno.CustomButton.Visible = False
        Me.itemno.DisplayIcon = True
        Me.itemno.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.itemno.Lines = New String(-1) {}
        Me.itemno.Location = New System.Drawing.Point(23, 184)
        Me.itemno.MaxLength = 32767
        Me.itemno.Multiline = True
        Me.itemno.Name = "itemno"
        Me.itemno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.itemno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.itemno.SelectedText = ""
        Me.itemno.SelectionLength = 0
        Me.itemno.SelectionStart = 0
        Me.itemno.ShowClearButton = True
        Me.itemno.Size = New System.Drawing.Size(106, 28)
        Me.itemno.Style = MetroFramework.MetroColorStyle.Red
        Me.itemno.TabIndex = 498
        Me.itemno.UseCustomForeColor = True
        Me.itemno.UseSelectable = True
        Me.itemno.WaterMark = "Item #"
        Me.itemno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.itemno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'wdwloc
        '
        '
        '
        '
        Me.wdwloc.CustomButton.Image = Nothing
        Me.wdwloc.CustomButton.Location = New System.Drawing.Point(236, 2)
        Me.wdwloc.CustomButton.Name = ""
        Me.wdwloc.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.wdwloc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.wdwloc.CustomButton.TabIndex = 1
        Me.wdwloc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.wdwloc.CustomButton.UseSelectable = True
        Me.wdwloc.CustomButton.Visible = False
        Me.wdwloc.DisplayIcon = True
        Me.wdwloc.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.wdwloc.Lines = New String(-1) {}
        Me.wdwloc.Location = New System.Drawing.Point(23, 220)
        Me.wdwloc.MaxLength = 32767
        Me.wdwloc.Multiline = True
        Me.wdwloc.Name = "wdwloc"
        Me.wdwloc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.wdwloc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.wdwloc.SelectedText = ""
        Me.wdwloc.SelectionLength = 0
        Me.wdwloc.SelectionStart = 0
        Me.wdwloc.ShowClearButton = True
        Me.wdwloc.Size = New System.Drawing.Size(262, 28)
        Me.wdwloc.Style = MetroFramework.MetroColorStyle.Red
        Me.wdwloc.TabIndex = 499
        Me.wdwloc.UseCustomForeColor = True
        Me.wdwloc.UseSelectable = True
        Me.wdwloc.WaterMark = "Wdw / Door Location"
        Me.wdwloc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.wdwloc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'parts
        '
        '
        '
        '
        Me.parts.CustomButton.Image = Nothing
        Me.parts.CustomButton.Location = New System.Drawing.Point(184, 2)
        Me.parts.CustomButton.Name = ""
        Me.parts.CustomButton.Size = New System.Drawing.Size(91, 91)
        Me.parts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.parts.CustomButton.TabIndex = 1
        Me.parts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.parts.CustomButton.UseSelectable = True
        Me.parts.CustomButton.Visible = False
        Me.parts.DisplayIcon = True
        Me.parts.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.parts.Lines = New String(-1) {}
        Me.parts.Location = New System.Drawing.Point(135, 116)
        Me.parts.MaxLength = 32767
        Me.parts.Multiline = True
        Me.parts.Name = "parts"
        Me.parts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.parts.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.parts.SelectedText = ""
        Me.parts.SelectionLength = 0
        Me.parts.SelectionStart = 0
        Me.parts.ShowClearButton = True
        Me.parts.Size = New System.Drawing.Size(278, 96)
        Me.parts.Style = MetroFramework.MetroColorStyle.Red
        Me.parts.TabIndex = 500
        Me.parts.UseCustomForeColor = True
        Me.parts.UseSelectable = True
        Me.parts.WaterMark = "Parts / Accessories Used"
        Me.parts.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.parts.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'unitprice
        '
        '
        '
        '
        Me.unitprice.CustomButton.Image = Nothing
        Me.unitprice.CustomButton.Location = New System.Drawing.Point(138, 2)
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
        Me.unitprice.Location = New System.Drawing.Point(533, 116)
        Me.unitprice.MaxLength = 32767
        Me.unitprice.Multiline = True
        Me.unitprice.Name = "unitprice"
        Me.unitprice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.unitprice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.unitprice.SelectedText = ""
        Me.unitprice.SelectionLength = 0
        Me.unitprice.SelectionStart = 0
        Me.unitprice.ShowClearButton = True
        Me.unitprice.Size = New System.Drawing.Size(164, 28)
        Me.unitprice.Style = MetroFramework.MetroColorStyle.Red
        Me.unitprice.TabIndex = 501
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
        Me.qty.CustomButton.Location = New System.Drawing.Point(137, 2)
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
        Me.qty.Location = New System.Drawing.Point(534, 150)
        Me.qty.MaxLength = 32767
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.qty.SelectedText = ""
        Me.qty.SelectionLength = 0
        Me.qty.SelectionStart = 0
        Me.qty.ShowClearButton = True
        Me.qty.Size = New System.Drawing.Size(163, 28)
        Me.qty.Style = MetroFramework.MetroColorStyle.Red
        Me.qty.TabIndex = 502
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
        Me.netamount.CustomButton.Location = New System.Drawing.Point(137, 2)
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
        Me.netamount.Location = New System.Drawing.Point(534, 184)
        Me.netamount.MaxLength = 32767
        Me.netamount.Multiline = True
        Me.netamount.Name = "netamount"
        Me.netamount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.netamount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.netamount.SelectedText = ""
        Me.netamount.SelectionLength = 0
        Me.netamount.SelectionStart = 0
        Me.netamount.ShowClearButton = True
        Me.netamount.Size = New System.Drawing.Size(163, 28)
        Me.netamount.Style = MetroFramework.MetroColorStyle.Red
        Me.netamount.TabIndex = 503
        Me.netamount.UseCustomForeColor = True
        Me.netamount.UseSelectable = True
        Me.netamount.WaterMark = "Net Amount"
        Me.netamount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.netamount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'save
        '
        Me.save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.save.Image = Nothing
        Me.save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.save.Location = New System.Drawing.Point(578, 236)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(119, 28)
        Me.save.Style = MetroFramework.MetroColorStyle.Yellow
        Me.save.TabIndex = 509
        Me.save.Text = "add"
        Me.save.UseCustomForeColor = True
        Me.save.UseSelectable = True
        Me.save.UseVisualStyleBackColor = True
        '
        'newitemFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 283)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.kno)
        Me.Controls.Add(Me.metroTextButton2)
        Me.Controls.Add(Me.kryptonLabel3)
        Me.Controls.Add(Me.kryptonLabel5)
        Me.Controls.Add(Me.kryptonLabel4)
        Me.Controls.Add(Me.itemno)
        Me.Controls.Add(Me.wdwloc)
        Me.Controls.Add(Me.parts)
        Me.Controls.Add(Me.unitprice)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.netamount)
        Me.Name = "newitemFRM"
        Me.Text = "newitemFRM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents kno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents metroTextButton2 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents kryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents kryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents itemno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents wdwloc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents parts As MetroFramework.Controls.MetroTextBox
    Friend WithEvents unitprice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents qty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents netamount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents save As MetroFramework.Controls.MetroTextBox.MetroTextButton
End Class
