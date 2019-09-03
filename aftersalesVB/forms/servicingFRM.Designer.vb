<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class servicingFRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.servicingGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.jo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.address = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.projectname = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.servicingdate = New MetroFramework.Controls.MetroTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.remarks = New MetroFramework.Controls.MetroTextBox()
        Me.refresh = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.servicingGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'servicingGRID
        '
        Me.servicingGRID.AllowUserToAddRows = False
        Me.servicingGRID.AllowUserToDeleteRows = False
        Me.servicingGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.servicingGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.servicingGRID.ColumnHeadersHeight = 32
        Me.servicingGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.servicingGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.servicingGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.servicingGRID.Location = New System.Drawing.Point(0, 0)
        Me.servicingGRID.MultiSelect = False
        Me.servicingGRID.Name = "servicingGRID"
        Me.servicingGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.servicingGRID.RowHeadersWidth = 30
        Me.servicingGRID.RowTemplate.Height = 30
        Me.servicingGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.servicingGRID.Size = New System.Drawing.Size(871, 250)
        Me.servicingGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.servicingGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.servicingGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.servicingGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicingGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.servicingGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.servicingGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.servicingGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.servicingGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.servicingGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.servicingGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.servicingGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.servicingGRID.TabIndex = 556
        '
        'jo
        '
        Me.jo.Location = New System.Drawing.Point(12, 84)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(93, 22)
        Me.jo.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.jo.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jo.TabIndex = 561
        Me.jo.Values.Text = "Job Order No"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(12, 52)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(70, 26)
        Me.address.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.address.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.TabIndex = 560
        Me.address.Values.Text = "Address"
        '
        'projectname
        '
        Me.projectname.Location = New System.Drawing.Point(12, 12)
        Me.projectname.Name = "projectname"
        Me.projectname.Size = New System.Drawing.Size(135, 31)
        Me.projectname.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.projectname.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectname.TabIndex = 559
        Me.projectname.Values.Text = "Project Name"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(11, 211)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(169, 29)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 562
        Me.KryptonLabel1.Values.Text = "Servicing Schedule"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.servicingGRID)
        Me.Panel1.Location = New System.Drawing.Point(11, 245)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 252)
        Me.Panel1.TabIndex = 564
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(7, 7)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(98, 22)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 566
        Me.KryptonLabel2.Values.Text = "Servicing Date"
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CustomFormat = "yyyy-MMM-dd"
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MetroDateTime1.Location = New System.Drawing.Point(7, 35)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(134, 29)
        Me.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroDateTime1.TabIndex = 565
        '
        'servicingdate
        '
        '
        '
        '
        Me.servicingdate.CustomButton.Image = Nothing
        Me.servicingdate.CustomButton.Location = New System.Drawing.Point(160, 2)
        Me.servicingdate.CustomButton.Name = ""
        Me.servicingdate.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.servicingdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.servicingdate.CustomButton.TabIndex = 1
        Me.servicingdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.servicingdate.CustomButton.UseSelectable = True
        Me.servicingdate.CustomButton.Visible = False
        Me.servicingdate.DisplayIcon = True
        Me.servicingdate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.servicingdate.Lines = New String(-1) {}
        Me.servicingdate.Location = New System.Drawing.Point(147, 36)
        Me.servicingdate.MaxLength = 32767
        Me.servicingdate.Multiline = True
        Me.servicingdate.Name = "servicingdate"
        Me.servicingdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.servicingdate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.servicingdate.SelectedText = ""
        Me.servicingdate.SelectionLength = 0
        Me.servicingdate.SelectionStart = 0
        Me.servicingdate.ShowClearButton = True
        Me.servicingdate.Size = New System.Drawing.Size(186, 28)
        Me.servicingdate.Style = MetroFramework.MetroColorStyle.Red
        Me.servicingdate.TabIndex = 567
        Me.servicingdate.UseCustomForeColor = True
        Me.servicingdate.UseSelectable = True
        Me.servicingdate.WaterMark = "Enter Servicing Date"
        Me.servicingdate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.servicingdate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.remarks)
        Me.Panel2.Controls.Add(Me.KryptonLabel2)
        Me.Panel2.Controls.Add(Me.servicingdate)
        Me.Panel2.Controls.Add(Me.MetroDateTime1)
        Me.Panel2.Location = New System.Drawing.Point(12, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(871, 79)
        Me.Panel2.TabIndex = 568
        '
        'remarks
        '
        '
        '
        '
        Me.remarks.CustomButton.Image = Nothing
        Me.remarks.CustomButton.Location = New System.Drawing.Point(303, 2)
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
        Me.remarks.Location = New System.Drawing.Point(347, 36)
        Me.remarks.MaxLength = 32767
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.remarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.remarks.SelectedText = ""
        Me.remarks.SelectionLength = 0
        Me.remarks.SelectionStart = 0
        Me.remarks.ShowClearButton = True
        Me.remarks.Size = New System.Drawing.Size(329, 28)
        Me.remarks.Style = MetroFramework.MetroColorStyle.Red
        Me.remarks.TabIndex = 577
        Me.remarks.UseCustomForeColor = True
        Me.remarks.UseSelectable = True
        Me.remarks.WaterMark = "Remarks"
        Me.remarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.remarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'refresh
        '
        Me.refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refresh.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refresh.Location = New System.Drawing.Point(891, 245)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(92, 23)
        Me.refresh.TabIndex = 575
        Me.refresh.Text = "reload"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(889, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 23)
        Me.Button2.TabIndex = 574
        Me.Button2.Text = "add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(889, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 576
        Me.Button1.Text = "update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel3.AutoSize = False
        Me.KryptonLabel3.Location = New System.Drawing.Point(854, 12)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(129, 31)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel3.TabIndex = 577
        Me.KryptonLabel3.Values.Text = "CIN"
        '
        'servicingFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(995, 509)
        Me.Controls.Add(Me.KryptonLabel3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.projectname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.KryptonLabel1)
        Me.Controls.Add(Me.jo)
        Me.MinimizeBox = False
        Me.Name = "servicingFRM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.servicingGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents servicingGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents jo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents address As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents projectname As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents servicingdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents refresh As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents remarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
