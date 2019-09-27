<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REQreplacementFRM
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.REPLACEMENTTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.asdbDS = New aftersalesVB.asdbDS()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.reqdate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.remarks = New MetroFramework.Controls.MetroTextBox()
        Me.qty = New MetroFramework.Controls.MetroTextBox()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.description = New MetroFramework.Controls.MetroTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.partsGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.requestype = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.knogv = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.specification = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.REPLACEMENTTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asdbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'REPLACEMENTTBBindingSource
        '
        Me.REPLACEMENTTBBindingSource.DataMember = "REPLACEMENTTB"
        Me.REPLACEMENTTBBindingSource.DataSource = Me.asdbDS
        '
        'asdbDS
        '
        Me.asdbDS.DataSetName = "asdbDS"
        Me.asdbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.KryptonLabel8)
        Me.Panel3.Controls.Add(Me.reqdate)
        Me.Panel3.Controls.Add(Me.MetroDateTime1)
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Controls.Add(Me.remarks)
        Me.Panel3.Controls.Add(Me.qty)
        Me.Panel3.Controls.Add(Me.KryptonLabel4)
        Me.Panel3.Controls.Add(Me.KryptonLabel5)
        Me.Panel3.Controls.Add(Me.description)
        Me.Panel3.Location = New System.Drawing.Point(3, 39)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(538, 135)
        Me.Panel3.TabIndex = 602
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(42, 86)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(38, 20)
        Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 570
        Me.KryptonLabel8.Values.Text = "Date"
        '
        'reqdate
        '
        '
        '
        '
        Me.reqdate.CustomButton.Image = Nothing
        Me.reqdate.CustomButton.Location = New System.Drawing.Point(160, 2)
        Me.reqdate.CustomButton.Name = ""
        Me.reqdate.CustomButton.Size = New System.Drawing.Size(23, 23)
        Me.reqdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.reqdate.CustomButton.TabIndex = 1
        Me.reqdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.reqdate.CustomButton.UseSelectable = True
        Me.reqdate.CustomButton.Visible = False
        Me.reqdate.DisplayIcon = True
        Me.reqdate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.reqdate.Lines = New String(-1) {}
        Me.reqdate.Location = New System.Drawing.Point(226, 87)
        Me.reqdate.MaxLength = 32767
        Me.reqdate.Multiline = True
        Me.reqdate.Name = "reqdate"
        Me.reqdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.reqdate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.reqdate.SelectedText = ""
        Me.reqdate.SelectionLength = 0
        Me.reqdate.SelectionStart = 0
        Me.reqdate.ShowClearButton = True
        Me.reqdate.Size = New System.Drawing.Size(186, 28)
        Me.reqdate.Style = MetroFramework.MetroColorStyle.Red
        Me.reqdate.TabIndex = 569
        Me.reqdate.UseCustomForeColor = True
        Me.reqdate.UseSelectable = True
        Me.reqdate.WaterMark = "Date"
        Me.reqdate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.reqdate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.CustomFormat = "yyyy-MMM-dd"
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MetroDateTime1.Location = New System.Drawing.Point(86, 86)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(134, 29)
        Me.MetroDateTime1.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroDateTime1.TabIndex = 568
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(18, 53)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(62, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 522
        Me.KryptonLabel3.Values.Text = "Remarks"
        '
        'remarks
        '
        '
        '
        '
        Me.remarks.CustomButton.Image = Nothing
        Me.remarks.CustomButton.Location = New System.Drawing.Point(401, 1)
        Me.remarks.CustomButton.Name = ""
        Me.remarks.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.remarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.remarks.CustomButton.TabIndex = 1
        Me.remarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.remarks.CustomButton.UseSelectable = True
        Me.remarks.CustomButton.Visible = False
        Me.remarks.DisplayIcon = True
        Me.remarks.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.remarks.Lines = New String(-1) {}
        Me.remarks.Location = New System.Drawing.Point(86, 53)
        Me.remarks.MaxLength = 32767
        Me.remarks.Multiline = True
        Me.remarks.Name = "remarks"
        Me.remarks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.remarks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.remarks.SelectedText = ""
        Me.remarks.SelectionLength = 0
        Me.remarks.SelectionStart = 0
        Me.remarks.ShowClearButton = True
        Me.remarks.Size = New System.Drawing.Size(427, 27)
        Me.remarks.Style = MetroFramework.MetroColorStyle.Teal
        Me.remarks.TabIndex = 521
        Me.remarks.UseCustomForeColor = True
        Me.remarks.UseSelectable = True
        Me.remarks.UseStyleColors = True
        Me.remarks.WaterMark = "Remarks"
        Me.remarks.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.remarks.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'qty
        '
        '
        '
        '
        Me.qty.CustomButton.Image = Nothing
        Me.qty.CustomButton.Location = New System.Drawing.Point(74, 1)
        Me.qty.CustomButton.Name = ""
        Me.qty.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.qty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.qty.CustomButton.TabIndex = 1
        Me.qty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.qty.CustomButton.UseSelectable = True
        Me.qty.CustomButton.Visible = False
        Me.qty.DisplayIcon = True
        Me.qty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.qty.Lines = New String(-1) {}
        Me.qty.Location = New System.Drawing.Point(413, 20)
        Me.qty.MaxLength = 32767
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.qty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.qty.SelectedText = ""
        Me.qty.SelectionLength = 0
        Me.qty.SelectionStart = 0
        Me.qty.ShowClearButton = True
        Me.qty.Size = New System.Drawing.Size(100, 27)
        Me.qty.Style = MetroFramework.MetroColorStyle.Teal
        Me.qty.TabIndex = 5
        Me.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.qty.UseCustomForeColor = True
        Me.qty.UseSelectable = True
        Me.qty.UseStyleColors = True
        Me.qty.WaterMark = "Quantity"
        Me.qty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.qty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(3, 20)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 520
        Me.KryptonLabel4.Values.Text = "Description"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(371, 20)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(36, 20)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 513
        Me.KryptonLabel5.Values.Text = "Qty:"
        '
        'description
        '
        '
        '
        '
        Me.description.CustomButton.Image = Nothing
        Me.description.CustomButton.Location = New System.Drawing.Point(253, 1)
        Me.description.CustomButton.Name = ""
        Me.description.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.description.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.description.CustomButton.TabIndex = 1
        Me.description.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.description.CustomButton.UseSelectable = True
        Me.description.CustomButton.Visible = False
        Me.description.DisplayIcon = True
        Me.description.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.description.Lines = New String(-1) {}
        Me.description.Location = New System.Drawing.Point(86, 20)
        Me.description.MaxLength = 32767
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.description.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.description.SelectedText = ""
        Me.description.SelectionLength = 0
        Me.description.SelectionStart = 0
        Me.description.ShowClearButton = True
        Me.description.Size = New System.Drawing.Size(279, 27)
        Me.description.Style = MetroFramework.MetroColorStyle.Teal
        Me.description.TabIndex = 2
        Me.description.UseCustomForeColor = True
        Me.description.UseSelectable = True
        Me.description.UseStyleColors = True
        Me.description.WaterMark = "Description"
        Me.description.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.description.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(547, 68)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 604
        Me.Button4.Text = "update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(547, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 603
        Me.Button1.Text = "add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'refreshbtn
        '
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.refreshbtn.Location = New System.Drawing.Point(547, 206)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(75, 23)
        Me.refreshbtn.TabIndex = 606
        Me.refreshbtn.Text = "reload"
        Me.refreshbtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.partsGRID)
        Me.Panel1.Location = New System.Drawing.Point(2, 206)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 137)
        Me.Panel1.TabIndex = 605
        '
        'partsGRID
        '
        Me.partsGRID.AllowUserToAddRows = False
        Me.partsGRID.AllowUserToDeleteRows = False
        Me.partsGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.partsGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.partsGRID.ColumnHeadersHeight = 32
        Me.partsGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.partsGRID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.partsGRID.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.partsGRID.Location = New System.Drawing.Point(0, 0)
        Me.partsGRID.Name = "partsGRID"
        Me.partsGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.partsGRID.RowHeadersWidth = 30
        Me.partsGRID.RowTemplate.Height = 30
        Me.partsGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.partsGRID.Size = New System.Drawing.Size(536, 135)
        Me.partsGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.partsGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.partsGRID.StateCommon.DataCell.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.partsGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsGRID.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.partsGRID.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.partsGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.partsGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.partsGRID.StateCommon.HeaderColumn.Border.Rounding = 0
        Me.partsGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White
        Me.partsGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partsGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.partsGRID.TabIndex = 561
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(3, 180)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(168, 20)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 607
        Me.KryptonLabel6.Values.Text = "Request For Replacements"
        '
        'requestype
        '
        Me.requestype.Location = New System.Drawing.Point(3, 3)
        Me.requestype.Name = "requestype"
        Me.requestype.Size = New System.Drawing.Size(196, 20)
        Me.requestype.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.requestype.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestype.TabIndex = 608
        Me.requestype.Values.Text = "REQUEST FOR REPLACEMENTS"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1104, 432)
        Me.Panel2.TabIndex = 609
        '
        'Panel9
        '
        Me.Panel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel9.Controls.Add(Me.KryptonLabel1)
        Me.Panel9.Controls.Add(Me.Panel5)
        Me.Panel9.Location = New System.Drawing.Point(1143, 6)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(845, 349)
        Me.Panel9.TabIndex = 616
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(3, 13)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 612
        Me.KryptonLabel1.Values.Text = "Form Preview"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.Controls.Add(Me.ReportViewer1)
        Me.Panel5.Location = New System.Drawing.Point(3, 39)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(820, 304)
        Me.Panel5.TabIndex = 613
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.REPLACEMENTTBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "aftersalesVB.replreqRPT.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(820, 304)
        Me.ReportViewer1.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel8.Controls.Add(Me.requestype)
        Me.Panel8.Controls.Add(Me.Panel1)
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Controls.Add(Me.refreshbtn)
        Me.Panel8.Controls.Add(Me.Button1)
        Me.Panel8.Controls.Add(Me.Button2)
        Me.Panel8.Controls.Add(Me.KryptonLabel6)
        Me.Panel8.Controls.Add(Me.Panel3)
        Me.Panel8.Location = New System.Drawing.Point(502, 6)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(635, 349)
        Me.Panel8.TabIndex = 615
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(547, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 609
        Me.Button2.Text = "remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.KryptonLabel7)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(12, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(484, 349)
        Me.Panel4.TabIndex = 614
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(3, 3)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(184, 20)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 598
        Me.KryptonLabel7.Values.Text = "Select Accessories / Materials"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.knogv)
        Me.Panel7.Location = New System.Drawing.Point(3, 173)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(475, 170)
        Me.Panel7.TabIndex = 597
        '
        'knogv
        '
        Me.knogv.AllowUserToAddRows = False
        Me.knogv.AllowUserToDeleteRows = False
        Me.knogv.AllowUserToOrderColumns = True
        Me.knogv.AllowUserToResizeColumns = False
        Me.knogv.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.knogv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.knogv.ColumnHeadersHeight = 30
        Me.knogv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.knogv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.knogv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.knogv.Location = New System.Drawing.Point(0, 0)
        Me.knogv.MultiSelect = False
        Me.knogv.Name = "knogv"
        Me.knogv.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.knogv.ReadOnly = True
        Me.knogv.RowHeadersWidth = 40
        Me.knogv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.knogv.RowTemplate.Height = 27
        Me.knogv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.knogv.Size = New System.Drawing.Size(473, 168)
        Me.knogv.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.knogv.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.knogv.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.knogv.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.knogv.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.knogv.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.knogv.StateCommon.HeaderColumn.Border.Width = 0
        Me.knogv.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.knogv.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.knogv.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.knogv.TabIndex = 499
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.KryptonLabel2)
        Me.Panel6.Controls.Add(Me.Button5)
        Me.Panel6.Controls.Add(Me.KryptonLabel10)
        Me.Panel6.Controls.Add(Me.specification)
        Me.Panel6.Controls.Add(Me.ComboBox2)
        Me.Panel6.Controls.Add(Me.KryptonLabel11)
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Location = New System.Drawing.Point(4, 39)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(474, 113)
        Me.Panel6.TabIndex = 599
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel2.Location = New System.Drawing.Point(20, 9)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(85, 20)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 523
        Me.KryptonLabel2.Values.Text = "Specification"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(381, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 600
        Me.Button5.Text = "Find"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel10.Location = New System.Drawing.Point(39, 43)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(66, 20)
        Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 521
        Me.KryptonLabel10.Values.Text = "Article no"
        '
        'specification
        '
        Me.specification.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.specification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.specification.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specification.FormattingEnabled = True
        Me.specification.Location = New System.Drawing.Point(111, 11)
        Me.specification.Name = "specification"
        Me.specification.Size = New System.Drawing.Size(254, 26)
        Me.specification.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(111, 43)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(254, 26)
        Me.ComboBox2.TabIndex = 1
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel11.Location = New System.Drawing.Point(28, 75)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(77, 20)
        Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 522
        Me.KryptonLabel11.Values.Text = "Description"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 75)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(254, 26)
        Me.ComboBox1.TabIndex = 2
        '
        'REQreplacementFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1104, 432)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "REQreplacementFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Green
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.REPLACEMENTTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asdbDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.partsGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.knogv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents remarks As MetroFramework.Controls.MetroTextBox
    Friend WithEvents qty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents description As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents refreshbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents partsGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents requestype As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents specification As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents knogv As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents REPLACEMENTTBBindingSource As BindingSource
    Friend WithEvents asdbDS As asdbDS
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents reqdate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
End Class
