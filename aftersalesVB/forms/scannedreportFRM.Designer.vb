<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scannedreportFRM
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imagepath = New System.Windows.Forms.TextBox()
        Me.browsebttn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.savebtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.cancelbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.nxt = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.prev = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.first = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.last = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.deletebtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.newbtn = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(23, 92)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(906, 399)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'imagepath
        '
        Me.imagepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imagepath.Enabled = False
        Me.imagepath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagepath.Location = New System.Drawing.Point(104, 18)
        Me.imagepath.Name = "imagepath"
        Me.imagepath.Size = New System.Drawing.Size(618, 26)
        Me.imagepath.TabIndex = 1
        '
        'browsebttn
        '
        Me.browsebttn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.browsebttn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.browsebttn.Image = Nothing
        Me.browsebttn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.browsebttn.Location = New System.Drawing.Point(23, 16)
        Me.browsebttn.Name = "browsebttn"
        Me.browsebttn.Size = New System.Drawing.Size(75, 29)
        Me.browsebttn.Style = MetroFramework.MetroColorStyle.Red
        Me.browsebttn.TabIndex = 482
        Me.browsebttn.Text = "browse"
        Me.browsebttn.UseCustomForeColor = True
        Me.browsebttn.UseSelectable = True
        Me.browsebttn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'savebtn
        '
        Me.savebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.savebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.savebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.savebtn.Image = Nothing
        Me.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.savebtn.Location = New System.Drawing.Point(728, 16)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(68, 29)
        Me.savebtn.Style = MetroFramework.MetroColorStyle.Silver
        Me.savebtn.TabIndex = 483
        Me.savebtn.Text = "save"
        Me.savebtn.UseCustomForeColor = True
        Me.savebtn.UseSelectable = True
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'cancelbtn
        '
        Me.cancelbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cancelbtn.Image = Nothing
        Me.cancelbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cancelbtn.Location = New System.Drawing.Point(802, 16)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(68, 29)
        Me.cancelbtn.Style = MetroFramework.MetroColorStyle.Silver
        Me.cancelbtn.TabIndex = 484
        Me.cancelbtn.Text = "cancel"
        Me.cancelbtn.UseCustomForeColor = True
        Me.cancelbtn.UseSelectable = True
        Me.cancelbtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(418, 185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 485
        '
        'nxt
        '
        Me.nxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nxt.Image = Nothing
        Me.nxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nxt.Location = New System.Drawing.Point(636, 15)
        Me.nxt.Name = "nxt"
        Me.nxt.Size = New System.Drawing.Size(68, 29)
        Me.nxt.Style = MetroFramework.MetroColorStyle.Purple
        Me.nxt.TabIndex = 487
        Me.nxt.Text = "next"
        Me.nxt.UseCustomForeColor = True
        Me.nxt.UseSelectable = True
        Me.nxt.UseVisualStyleBackColor = True
        '
        'prev
        '
        Me.prev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.prev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.prev.Image = Nothing
        Me.prev.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.prev.Location = New System.Drawing.Point(189, 15)
        Me.prev.Name = "prev"
        Me.prev.Size = New System.Drawing.Size(68, 29)
        Me.prev.Style = MetroFramework.MetroColorStyle.Purple
        Me.prev.TabIndex = 486
        Me.prev.Text = "preview"
        Me.prev.UseCustomForeColor = True
        Me.prev.UseSelectable = True
        Me.prev.UseVisualStyleBackColor = True
        '
        'first
        '
        Me.first.Cursor = System.Windows.Forms.Cursors.Hand
        Me.first.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.first.Image = Nothing
        Me.first.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.first.Location = New System.Drawing.Point(115, 15)
        Me.first.Name = "first"
        Me.first.Size = New System.Drawing.Size(68, 29)
        Me.first.Style = MetroFramework.MetroColorStyle.Silver
        Me.first.TabIndex = 489
        Me.first.Text = "first"
        Me.first.UseCustomForeColor = True
        Me.first.UseSelectable = True
        Me.first.UseVisualStyleBackColor = True
        '
        'last
        '
        Me.last.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.last.Cursor = System.Windows.Forms.Cursors.Hand
        Me.last.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.last.Image = Nothing
        Me.last.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.last.Location = New System.Drawing.Point(710, 15)
        Me.last.Name = "last"
        Me.last.Size = New System.Drawing.Size(68, 29)
        Me.last.Style = MetroFramework.MetroColorStyle.Silver
        Me.last.TabIndex = 488
        Me.last.Text = "last"
        Me.last.UseCustomForeColor = True
        Me.last.UseSelectable = True
        Me.last.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cancelbtn)
        Me.Panel1.Controls.Add(Me.imagepath)
        Me.Panel1.Controls.Add(Me.browsebttn)
        Me.Panel1.Controls.Add(Me.savebtn)
        Me.Panel1.Location = New System.Drawing.Point(22, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(907, 59)
        Me.Panel1.TabIndex = 490
        Me.Panel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.deletebtn)
        Me.Panel2.Controls.Add(Me.newbtn)
        Me.Panel2.Controls.Add(Me.nxt)
        Me.Panel2.Controls.Add(Me.last)
        Me.Panel2.Controls.Add(Me.KryptonLabel2)
        Me.Panel2.Controls.Add(Me.first)
        Me.Panel2.Controls.Add(Me.prev)
        Me.Panel2.Location = New System.Drawing.Point(22, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 59)
        Me.Panel2.TabIndex = 491
        '
        'deletebtn
        '
        Me.deletebtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.deletebtn.Image = Nothing
        Me.deletebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.deletebtn.Location = New System.Drawing.Point(802, 15)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(68, 29)
        Me.deletebtn.Style = MetroFramework.MetroColorStyle.Red
        Me.deletebtn.TabIndex = 493
        Me.deletebtn.Text = "delete"
        Me.deletebtn.UseCustomForeColor = True
        Me.deletebtn.UseSelectable = True
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'newbtn
        '
        Me.newbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.newbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.newbtn.Image = Nothing
        Me.newbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.newbtn.Location = New System.Drawing.Point(23, 15)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(68, 29)
        Me.newbtn.Style = MetroFramework.MetroColorStyle.Red
        Me.newbtn.TabIndex = 492
        Me.newbtn.Text = "new"
        Me.newbtn.UseCustomForeColor = True
        Me.newbtn.UseSelectable = True
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.AutoSize = False
        Me.KryptonLabel2.Location = New System.Drawing.Point(263, 8)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(367, 43)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.White
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center
        Me.KryptonLabel2.TabIndex = 490
        Me.KryptonLabel2.Values.Text = "img.jpg"
        '
        'scannedreportFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 504)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "scannedreportFRM"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imagepath As TextBox
    Friend WithEvents browsebttn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents savebtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents cancelbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents nxt As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents prev As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents first As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents last As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents deletebtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents newbtn As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
