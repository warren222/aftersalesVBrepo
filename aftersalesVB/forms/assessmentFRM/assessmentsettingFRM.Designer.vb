<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assessmentsettingFRM
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(assessmentsettingFRM))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SYSTEMTXT = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CATEGORYTXT = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OTHERSYSTEMTXT = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.seelctedsystem = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.possibleissue = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.qualityaspect = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.posibblesolution = New MetroFramework.Controls.MetroTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PARTSTXT = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System"
        '
        'SYSTEMTXT
        '
        Me.SYSTEMTXT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SYSTEMTXT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYSTEMTXT.FormattingEnabled = True
        Me.SYSTEMTXT.Items.AddRange(New Object() {"FRAMING SYSTEM", "GLAZING SYSTEM", "MECHANISM", "WEATHER TIGHTNESS", "INSECT PROTECTION SYSTEM"})
        Me.SYSTEMTXT.Location = New System.Drawing.Point(121, 74)
        Me.SYSTEMTXT.Name = "SYSTEMTXT"
        Me.SYSTEMTXT.Size = New System.Drawing.Size(245, 27)
        Me.SYSTEMTXT.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Parts"
        '
        'CATEGORYTXT
        '
        Me.CATEGORYTXT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CATEGORYTXT.FormattingEnabled = True
        Me.CATEGORYTXT.Location = New System.Drawing.Point(121, 214)
        Me.CATEGORYTXT.Name = "CATEGORYTXT"
        Me.CATEGORYTXT.Size = New System.Drawing.Size(152, 27)
        Me.CATEGORYTXT.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(121, 278)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 150)
        Me.Panel2.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(461, 278)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 27)
        Me.Button4.TabIndex = 850
        Me.Button4.Text = "add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(461, 344)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 27)
        Me.Button3.TabIndex = 849
        Me.Button3.Text = "delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(461, 377)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 27)
        Me.Button2.TabIndex = 848
        Me.Button2.Text = "reload"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OTHERSYSTEMTXT
        '
        Me.OTHERSYSTEMTXT.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OTHERSYSTEMTXT.FormattingEnabled = True
        Me.OTHERSYSTEMTXT.Location = New System.Drawing.Point(121, 148)
        Me.OTHERSYSTEMTXT.Name = "OTHERSYSTEMTXT"
        Me.OTHERSYSTEMTXT.Size = New System.Drawing.Size(245, 27)
        Me.OTHERSYSTEMTXT.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Screen System"
        '
        'seelctedsystem
        '
        Me.seelctedsystem.AutoSize = True
        Me.seelctedsystem.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seelctedsystem.Location = New System.Drawing.Point(3, 9)
        Me.seelctedsystem.Name = "seelctedsystem"
        Me.seelctedsystem.Size = New System.Drawing.Size(359, 33)
        Me.seelctedsystem.TabIndex = 851
        Me.seelctedsystem.Text = "Window / Door System Settings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 851
        Me.Label5.Text = "Data Table"
        '
        'possibleissue
        '
        Me.possibleissue.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.possibleissue.FormattingEnabled = True
        Me.possibleissue.Location = New System.Drawing.Point(169, 181)
        Me.possibleissue.Name = "possibleissue"
        Me.possibleissue.Size = New System.Drawing.Size(208, 27)
        Me.possibleissue.TabIndex = 856
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 17)
        Me.Label6.TabIndex = 855
        Me.Label6.Text = "Possible Issue/Concern"
        '
        'qualityaspect
        '
        Me.qualityaspect.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qualityaspect.FormattingEnabled = True
        Me.qualityaspect.Location = New System.Drawing.Point(169, 148)
        Me.qualityaspect.Name = "qualityaspect"
        Me.qualityaspect.Size = New System.Drawing.Size(208, 27)
        Me.qualityaspect.TabIndex = 854
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 17)
        Me.Label7.TabIndex = 853
        Me.Label7.Text = "Select Quality Aspect"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 857
        Me.Label8.Text = "Possible Solution"
        '
        'posibblesolution
        '
        '
        '
        '
        Me.posibblesolution.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.posibblesolution.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.posibblesolution.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.posibblesolution.CustomButton.Location = New System.Drawing.Point(180, 1)
        Me.posibblesolution.CustomButton.Name = ""
        Me.posibblesolution.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.posibblesolution.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.posibblesolution.CustomButton.TabIndex = 1
        Me.posibblesolution.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.posibblesolution.CustomButton.UseSelectable = True
        Me.posibblesolution.CustomButton.UseVisualStyleBackColor = False
        Me.posibblesolution.CustomButton.Visible = False
        Me.posibblesolution.DisplayIcon = True
        Me.posibblesolution.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.posibblesolution.Lines = New String(-1) {}
        Me.posibblesolution.Location = New System.Drawing.Point(169, 214)
        Me.posibblesolution.MaxLength = 32767
        Me.posibblesolution.Name = "posibblesolution"
        Me.posibblesolution.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.posibblesolution.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.posibblesolution.SelectedText = ""
        Me.posibblesolution.SelectionLength = 0
        Me.posibblesolution.SelectionStart = 0
        Me.posibblesolution.ShowClearButton = True
        Me.posibblesolution.Size = New System.Drawing.Size(208, 29)
        Me.posibblesolution.Style = MetroFramework.MetroColorStyle.Red
        Me.posibblesolution.TabIndex = 858
        Me.posibblesolution.UseCustomForeColor = True
        Me.posibblesolution.UseSelectable = True
        Me.posibblesolution.WaterMark = "Enter Solution Here"
        Me.posibblesolution.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.posibblesolution.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 863
        Me.Label9.Text = "Data Table"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(486, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 27)
        Me.Button1.TabIndex = 862
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(486, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(70, 27)
        Me.Button5.TabIndex = 860
        Me.Button5.Text = "reload"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(486, 311)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 27)
        Me.Button6.TabIndex = 861
        Me.Button6.Text = "delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(169, 278)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 150)
        Me.Panel3.TabIndex = 859
        '
        'PARTSTXT
        '
        '
        '
        '
        Me.PARTSTXT.CustomButton.Image = Nothing
        Me.PARTSTXT.CustomButton.Location = New System.Drawing.Point(219, 2)
        Me.PARTSTXT.CustomButton.Name = ""
        Me.PARTSTXT.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.PARTSTXT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.PARTSTXT.CustomButton.TabIndex = 1
        Me.PARTSTXT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.PARTSTXT.CustomButton.UseSelectable = True
        Me.PARTSTXT.CustomButton.Visible = False
        Me.PARTSTXT.DisplayIcon = True
        Me.PARTSTXT.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.PARTSTXT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PARTSTXT.Lines = New String(-1) {}
        Me.PARTSTXT.Location = New System.Drawing.Point(121, 181)
        Me.PARTSTXT.MaxLength = 32767
        Me.PARTSTXT.Multiline = True
        Me.PARTSTXT.Name = "PARTSTXT"
        Me.PARTSTXT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PARTSTXT.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.PARTSTXT.SelectedText = ""
        Me.PARTSTXT.SelectionLength = 0
        Me.PARTSTXT.SelectionStart = 0
        Me.PARTSTXT.ShowClearButton = True
        Me.PARTSTXT.Size = New System.Drawing.Size(245, 28)
        Me.PARTSTXT.Style = MetroFramework.MetroColorStyle.Red
        Me.PARTSTXT.TabIndex = 864
        Me.PARTSTXT.UseCustomForeColor = True
        Me.PARTSTXT.UseSelectable = True
        Me.PARTSTXT.WaterMark = "Enter Parts here"
        Me.PARTSTXT.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.PARTSTXT.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.seelctedsystem)
        Me.Panel1.Controls.Add(Me.PARTSTXT)
        Me.Panel1.Controls.Add(Me.CATEGORYTXT)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SYSTEMTXT)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.OTHERSYSTEMTXT)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 450)
        Me.Panel1.TabIndex = 865
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel2.Controls.Add(Me.qualityaspect)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.possibleissue)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.posibblesolution)
        Me.SplitContainer1.Size = New System.Drawing.Size(1126, 450)
        Me.SplitContainer1.SplitterDistance = 552
        Me.SplitContainer1.TabIndex = 866
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(461, 311)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(70, 27)
        Me.Button7.TabIndex = 865
        Me.Button7.Text = "update"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'assessmentsettingFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1126, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "assessmentsettingFRM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SYSTEMTXT As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CATEGORYTXT As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents OTHERSYSTEMTXT As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents seelctedsystem As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents possibleissue As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents qualityaspect As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents posibblesolution As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PARTSTXT As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Button7 As Button
End Class
