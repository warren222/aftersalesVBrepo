<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newcallinFRM
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newcallinFRM))
        Me.calldate = New MetroFramework.Controls.MetroTextBox()
        Me.calldategen = New MetroFramework.Controls.MetroDateTime()
        Me.callername = New MetroFramework.Controls.MetroTextBox()
        Me.bodypnl = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.conversation = New System.Windows.Forms.RichTextBox()
        Me.notspecifiedchk = New System.Windows.Forms.CheckBox()
        Me.mechanismchk = New System.Windows.Forms.CheckBox()
        Me.glasschk = New System.Windows.Forms.CheckBox()
        Me.screenchk = New System.Windows.Forms.CheckBox()
        Me.doorchk = New System.Windows.Forms.CheckBox()
        Me.Windowchk = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.telno = New MetroFramework.Controls.MetroTextBox()
        Me.faxno = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.projectname = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.address = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.jo = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroTextButton4 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.MetroTextButton3 = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cin = New MetroFramework.Controls.MetroTextBox()
        Me.answerGV = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.questionGRID = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.updateBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.addBTN = New MetroFramework.Controls.MetroTextBox.MetroTextButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bodypnl.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.answerGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.questionGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'calldate
        '
        '
        '
        '
        Me.calldate.CustomButton.Image = Nothing
        Me.calldate.CustomButton.Location = New System.Drawing.Point(111, 1)
        Me.calldate.CustomButton.Name = ""
        Me.calldate.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.calldate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.calldate.CustomButton.TabIndex = 1
        Me.calldate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.calldate.CustomButton.UseSelectable = True
        Me.calldate.CustomButton.Visible = False
        Me.calldate.DisplayIcon = True
        Me.calldate.Lines = New String(-1) {}
        Me.calldate.Location = New System.Drawing.Point(227, 17)
        Me.calldate.MaxLength = 32767
        Me.calldate.Name = "calldate"
        Me.calldate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.calldate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.calldate.SelectedText = ""
        Me.calldate.SelectionLength = 0
        Me.calldate.SelectionStart = 0
        Me.calldate.ShowClearButton = True
        Me.calldate.Size = New System.Drawing.Size(137, 27)
        Me.calldate.Style = MetroFramework.MetroColorStyle.Teal
        Me.calldate.TabIndex = 12
        Me.calldate.UseCustomForeColor = True
        Me.calldate.UseSelectable = True
        Me.calldate.UseStyleColors = True
        Me.calldate.WaterMark = "Enter Call in Date"
        Me.calldate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.calldate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'calldategen
        '
        Me.calldategen.CustomFormat = "yyyy-MMM-dd"
        Me.calldategen.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.calldategen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.calldategen.Location = New System.Drawing.Point(95, 17)
        Me.calldategen.MinimumSize = New System.Drawing.Size(0, 25)
        Me.calldategen.Name = "calldategen"
        Me.calldategen.Size = New System.Drawing.Size(126, 25)
        Me.calldategen.Style = MetroFramework.MetroColorStyle.Red
        Me.calldategen.TabIndex = 11
        '
        'callername
        '
        '
        '
        '
        Me.callername.CustomButton.Image = Nothing
        Me.callername.CustomButton.Location = New System.Drawing.Point(243, 1)
        Me.callername.CustomButton.Name = ""
        Me.callername.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.callername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.callername.CustomButton.TabIndex = 1
        Me.callername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.callername.CustomButton.UseSelectable = True
        Me.callername.CustomButton.Visible = False
        Me.callername.DisplayIcon = True
        Me.callername.ForeColor = System.Drawing.SystemColors.ControlText
        Me.callername.Lines = New String(-1) {}
        Me.callername.Location = New System.Drawing.Point(95, 50)
        Me.callername.MaxLength = 32767
        Me.callername.Name = "callername"
        Me.callername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.callername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.callername.SelectedText = ""
        Me.callername.SelectionLength = 0
        Me.callername.SelectionStart = 0
        Me.callername.ShowClearButton = True
        Me.callername.Size = New System.Drawing.Size(269, 27)
        Me.callername.Style = MetroFramework.MetroColorStyle.Teal
        Me.callername.TabIndex = 14
        Me.callername.UseCustomForeColor = True
        Me.callername.UseSelectable = True
        Me.callername.UseStyleColors = True
        Me.callername.WaterMark = "Enter Caller Name"
        Me.callername.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.callername.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'bodypnl
        '
        Me.bodypnl.AutoScroll = True
        Me.bodypnl.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bodypnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bodypnl.Controls.Add(Me.Label4)
        Me.bodypnl.Controls.Add(Me.Panel4)
        Me.bodypnl.Controls.Add(Me.Panel3)
        Me.bodypnl.Controls.Add(Me.Label3)
        Me.bodypnl.Controls.Add(Me.Label2)
        Me.bodypnl.Controls.Add(Me.MetroTextButton4)
        Me.bodypnl.Controls.Add(Me.MetroTextButton3)
        Me.bodypnl.Controls.Add(Me.KryptonLabel4)
        Me.bodypnl.Controls.Add(Me.cin)
        Me.bodypnl.Controls.Add(Me.answerGV)
        Me.bodypnl.Controls.Add(Me.questionGRID)
        Me.bodypnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bodypnl.Location = New System.Drawing.Point(0, 0)
        Me.bodypnl.Name = "bodypnl"
        Me.bodypnl.Size = New System.Drawing.Size(890, 562)
        Me.bodypnl.TabIndex = 482
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 510
        Me.Label4.Text = "Concern :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.conversation)
        Me.Panel4.Controls.Add(Me.notspecifiedchk)
        Me.Panel4.Controls.Add(Me.mechanismchk)
        Me.Panel4.Controls.Add(Me.glasschk)
        Me.Panel4.Controls.Add(Me.screenchk)
        Me.Panel4.Controls.Add(Me.doorchk)
        Me.Panel4.Controls.Add(Me.Windowchk)
        Me.Panel4.Location = New System.Drawing.Point(16, 310)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(849, 221)
        Me.Panel4.TabIndex = 509
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 512
        Me.Label6.Text = "Conversation :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 511
        Me.Label5.Text = "Categories :"
        '
        'conversation
        '
        Me.conversation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conversation.Location = New System.Drawing.Point(42, 104)
        Me.conversation.Name = "conversation"
        Me.conversation.Size = New System.Drawing.Size(695, 96)
        Me.conversation.TabIndex = 6
        Me.conversation.Text = ""
        '
        'notspecifiedchk
        '
        Me.notspecifiedchk.AutoSize = True
        Me.notspecifiedchk.Location = New System.Drawing.Point(197, 54)
        Me.notspecifiedchk.Name = "notspecifiedchk"
        Me.notspecifiedchk.Size = New System.Drawing.Size(90, 17)
        Me.notspecifiedchk.TabIndex = 5
        Me.notspecifiedchk.Text = "Not Specified"
        Me.notspecifiedchk.UseVisualStyleBackColor = True
        '
        'mechanismchk
        '
        Me.mechanismchk.AutoSize = True
        Me.mechanismchk.Location = New System.Drawing.Point(197, 31)
        Me.mechanismchk.Name = "mechanismchk"
        Me.mechanismchk.Size = New System.Drawing.Size(80, 17)
        Me.mechanismchk.TabIndex = 4
        Me.mechanismchk.Text = "Mechanism"
        Me.mechanismchk.UseVisualStyleBackColor = True
        '
        'glasschk
        '
        Me.glasschk.AutoSize = True
        Me.glasschk.Location = New System.Drawing.Point(119, 54)
        Me.glasschk.Name = "glasschk"
        Me.glasschk.Size = New System.Drawing.Size(56, 17)
        Me.glasschk.TabIndex = 3
        Me.glasschk.Text = "GLass"
        Me.glasschk.UseVisualStyleBackColor = True
        '
        'screenchk
        '
        Me.screenchk.AutoSize = True
        Me.screenchk.Location = New System.Drawing.Point(119, 31)
        Me.screenchk.Name = "screenchk"
        Me.screenchk.Size = New System.Drawing.Size(60, 17)
        Me.screenchk.TabIndex = 2
        Me.screenchk.Text = "Screen"
        Me.screenchk.UseVisualStyleBackColor = True
        '
        'doorchk
        '
        Me.doorchk.AutoSize = True
        Me.doorchk.Location = New System.Drawing.Point(42, 54)
        Me.doorchk.Name = "doorchk"
        Me.doorchk.Size = New System.Drawing.Size(49, 17)
        Me.doorchk.TabIndex = 1
        Me.doorchk.Text = "Door"
        Me.doorchk.UseVisualStyleBackColor = True
        '
        'Windowchk
        '
        Me.Windowchk.AutoSize = True
        Me.Windowchk.Location = New System.Drawing.Point(42, 31)
        Me.Windowchk.Name = "Windowchk"
        Me.Windowchk.Size = New System.Drawing.Size(65, 17)
        Me.Windowchk.TabIndex = 0
        Me.Windowchk.Text = "Window"
        Me.Windowchk.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.KryptonLabel1)
        Me.Panel3.Controls.Add(Me.KryptonLabel11)
        Me.Panel3.Controls.Add(Me.calldategen)
        Me.Panel3.Controls.Add(Me.calldate)
        Me.Panel3.Controls.Add(Me.callername)
        Me.Panel3.Controls.Add(Me.telno)
        Me.Panel3.Controls.Add(Me.faxno)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.KryptonLabel2)
        Me.Panel3.Controls.Add(Me.KryptonLabel3)
        Me.Panel3.Location = New System.Drawing.Point(16, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(849, 224)
        Me.Panel3.TabIndex = 508
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(743, 141)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 23)
        Me.Button2.TabIndex = 576
        Me.Button2.Text = "clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(743, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 575
        Me.Button1.Text = "import"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(15, 17)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(38, 20)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 506
        Me.KryptonLabel1.Values.Text = "Date"
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Location = New System.Drawing.Point(15, 50)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Size = New System.Drawing.Size(74, 20)
        Me.KryptonLabel11.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel11.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel11.TabIndex = 507
        Me.KryptonLabel11.Values.Text = "Caller/Title"
        '
        'telno
        '
        '
        '
        '
        Me.telno.CustomButton.Image = Nothing
        Me.telno.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.telno.CustomButton.Name = ""
        Me.telno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.telno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.telno.CustomButton.TabIndex = 1
        Me.telno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.telno.CustomButton.UseSelectable = True
        Me.telno.CustomButton.Visible = False
        Me.telno.DisplayIcon = True
        Me.telno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.telno.Lines = New String(-1) {}
        Me.telno.Location = New System.Drawing.Point(504, 17)
        Me.telno.MaxLength = 32767
        Me.telno.Name = "telno"
        Me.telno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.telno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.telno.SelectedText = ""
        Me.telno.SelectionLength = 0
        Me.telno.SelectionStart = 0
        Me.telno.ShowClearButton = True
        Me.telno.Size = New System.Drawing.Size(233, 27)
        Me.telno.Style = MetroFramework.MetroColorStyle.Teal
        Me.telno.TabIndex = 489
        Me.telno.UseCustomForeColor = True
        Me.telno.UseSelectable = True
        Me.telno.UseStyleColors = True
        Me.telno.WaterMark = "Enter Tel No"
        Me.telno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.telno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'faxno
        '
        '
        '
        '
        Me.faxno.CustomButton.Image = Nothing
        Me.faxno.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.faxno.CustomButton.Name = ""
        Me.faxno.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.faxno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.faxno.CustomButton.TabIndex = 1
        Me.faxno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.faxno.CustomButton.UseSelectable = True
        Me.faxno.CustomButton.Visible = False
        Me.faxno.DisplayIcon = True
        Me.faxno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.faxno.Lines = New String(-1) {}
        Me.faxno.Location = New System.Drawing.Point(504, 50)
        Me.faxno.MaxLength = 32767
        Me.faxno.Name = "faxno"
        Me.faxno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.faxno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.faxno.SelectedText = ""
        Me.faxno.SelectionLength = 0
        Me.faxno.SelectionStart = 0
        Me.faxno.ShowClearButton = True
        Me.faxno.Size = New System.Drawing.Size(233, 27)
        Me.faxno.Style = MetroFramework.MetroColorStyle.Teal
        Me.faxno.TabIndex = 490
        Me.faxno.UseCustomForeColor = True
        Me.faxno.UseSelectable = True
        Me.faxno.UseStyleColors = True
        Me.faxno.WaterMark = "Enter Fax No"
        Me.faxno.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.faxno.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 505
        Me.Label1.Text = "Project details :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.KryptonLabel7)
        Me.Panel2.Controls.Add(Me.KryptonLabel8)
        Me.Panel2.Controls.Add(Me.projectname)
        Me.Panel2.Controls.Add(Me.KryptonLabel9)
        Me.Panel2.Controls.Add(Me.address)
        Me.Panel2.Controls.Add(Me.KryptonLabel10)
        Me.Panel2.Controls.Add(Me.jo)
        Me.Panel2.Controls.Add(Me.KryptonLabel5)
        Me.Panel2.Controls.Add(Me.KryptonLabel6)
        Me.Panel2.Location = New System.Drawing.Point(41, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(696, 100)
        Me.Panel2.TabIndex = 504
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Location = New System.Drawing.Point(12, 13)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(84, 18)
        Me.KryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel7.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel7.TabIndex = 498
        Me.KryptonLabel7.Values.Text = "Project Name"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Location = New System.Drawing.Point(118, 63)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Size = New System.Drawing.Size(15, 18)
        Me.KryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel8.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel8.TabIndex = 503
        Me.KryptonLabel8.Values.Text = ":"
        '
        'projectname
        '
        Me.projectname.Location = New System.Drawing.Point(144, 13)
        Me.projectname.Name = "projectname"
        Me.projectname.Size = New System.Drawing.Size(30, 18)
        Me.projectname.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.projectname.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.projectname.TabIndex = 484
        Me.projectname.Values.Text = "null"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Location = New System.Drawing.Point(118, 38)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Size = New System.Drawing.Size(15, 18)
        Me.KryptonLabel9.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel9.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel9.TabIndex = 502
        Me.KryptonLabel9.Values.Text = ":"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(144, 38)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(30, 18)
        Me.address.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.address.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.TabIndex = 485
        Me.address.Values.Text = "null"
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Location = New System.Drawing.Point(118, 13)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Size = New System.Drawing.Size(15, 18)
        Me.KryptonLabel10.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel10.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel10.TabIndex = 501
        Me.KryptonLabel10.Values.Text = ":"
        '
        'jo
        '
        Me.jo.Location = New System.Drawing.Point(144, 63)
        Me.jo.Name = "jo"
        Me.jo.Size = New System.Drawing.Size(30, 18)
        Me.jo.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.jo.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jo.TabIndex = 486
        Me.jo.Values.Text = "null"
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Location = New System.Drawing.Point(12, 63)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Size = New System.Drawing.Size(83, 18)
        Me.KryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel5.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel5.TabIndex = 500
        Me.KryptonLabel5.Values.Text = "Job Order No"
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Location = New System.Drawing.Point(12, 38)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Size = New System.Drawing.Size(54, 18)
        Me.KryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray
        Me.KryptonLabel6.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel6.TabIndex = 499
        Me.KryptonLabel6.Values.Text = "Address"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Location = New System.Drawing.Point(447, 17)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(49, 20)
        Me.KryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.TabIndex = 492
        Me.KryptonLabel2.Values.Text = "Tel No"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(445, 50)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(52, 20)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 493
        Me.KryptonLabel3.Values.Text = "Fax No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 507
        Me.Label3.Text = "For fill-up :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 506
        Me.Label2.Text = "Caller's Information :"
        '
        'MetroTextButton4
        '
        Me.MetroTextButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton4.Image = Nothing
        Me.MetroTextButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton4.Location = New System.Drawing.Point(439, 598)
        Me.MetroTextButton4.Name = "MetroTextButton4"
        Me.MetroTextButton4.Size = New System.Drawing.Size(48, 24)
        Me.MetroTextButton4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextButton4.TabIndex = 497
        Me.MetroTextButton4.Text = "+"
        Me.MetroTextButton4.UseCustomForeColor = True
        Me.MetroTextButton4.UseSelectable = True
        Me.MetroTextButton4.UseVisualStyleBackColor = True
        Me.MetroTextButton4.Visible = False
        '
        'MetroTextButton3
        '
        Me.MetroTextButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTextButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroTextButton3.Image = Nothing
        Me.MetroTextButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MetroTextButton3.Location = New System.Drawing.Point(25, 598)
        Me.MetroTextButton3.Name = "MetroTextButton3"
        Me.MetroTextButton3.Size = New System.Drawing.Size(48, 24)
        Me.MetroTextButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroTextButton3.TabIndex = 496
        Me.MetroTextButton3.Text = "+"
        Me.MetroTextButton3.UseCustomForeColor = True
        Me.MetroTextButton3.UseSelectable = True
        Me.MetroTextButton3.UseVisualStyleBackColor = True
        Me.MetroTextButton3.Visible = False
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Location = New System.Drawing.Point(652, 14)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Size = New System.Drawing.Size(31, 22)
        Me.KryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel4.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel4.TabIndex = 494
        Me.KryptonLabel4.Values.Text = "Cin"
        '
        'cin
        '
        '
        '
        '
        Me.cin.CustomButton.Image = Nothing
        Me.cin.CustomButton.Location = New System.Drawing.Point(138, 1)
        Me.cin.CustomButton.Name = ""
        Me.cin.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.cin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.cin.CustomButton.TabIndex = 1
        Me.cin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cin.CustomButton.UseSelectable = True
        Me.cin.CustomButton.Visible = False
        Me.cin.DisplayIcon = True
        Me.cin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cin.Lines = New String(-1) {}
        Me.cin.Location = New System.Drawing.Point(689, 14)
        Me.cin.MaxLength = 32767
        Me.cin.Name = "cin"
        Me.cin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cin.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cin.SelectedText = ""
        Me.cin.SelectionLength = 0
        Me.cin.SelectionStart = 0
        Me.cin.ShowClearButton = True
        Me.cin.Size = New System.Drawing.Size(164, 27)
        Me.cin.Style = MetroFramework.MetroColorStyle.Red
        Me.cin.TabIndex = 491
        Me.cin.UseCustomForeColor = True
        Me.cin.UseSelectable = True
        Me.cin.WaterMark = "CIN"
        Me.cin.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cin.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'answerGV
        '
        Me.answerGV.AllowUserToAddRows = False
        Me.answerGV.AllowUserToDeleteRows = False
        Me.answerGV.AllowUserToOrderColumns = True
        Me.answerGV.AllowUserToResizeColumns = False
        Me.answerGV.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.answerGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.answerGV.ColumnHeadersHeight = 30
        Me.answerGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.answerGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.answerGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.answerGV.Location = New System.Drawing.Point(439, 628)
        Me.answerGV.MultiSelect = False
        Me.answerGV.Name = "answerGV"
        Me.answerGV.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.answerGV.ReadOnly = True
        Me.answerGV.RowHeadersVisible = False
        Me.answerGV.RowHeadersWidth = 40
        Me.answerGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.answerGV.RowTemplate.Height = 27
        Me.answerGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.answerGV.Size = New System.Drawing.Size(420, 116)
        Me.answerGV.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.answerGV.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.answerGV.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGV.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.answerGV.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.answerGV.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.answerGV.StateCommon.HeaderColumn.Border.Width = 0
        Me.answerGV.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.answerGV.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.answerGV.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.answerGV.TabIndex = 483
        Me.answerGV.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'questionGRID
        '
        Me.questionGRID.AllowUserToAddRows = False
        Me.questionGRID.AllowUserToDeleteRows = False
        Me.questionGRID.AllowUserToOrderColumns = True
        Me.questionGRID.AllowUserToResizeColumns = False
        Me.questionGRID.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.questionGRID.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.questionGRID.ColumnHeadersHeight = 30
        Me.questionGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.questionGRID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.questionGRID.Location = New System.Drawing.Point(25, 628)
        Me.questionGRID.MultiSelect = False
        Me.questionGRID.Name = "questionGRID"
        Me.questionGRID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.questionGRID.ReadOnly = True
        Me.questionGRID.RowHeadersVisible = False
        Me.questionGRID.RowHeadersWidth = 40
        Me.questionGRID.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.questionGRID.RowTemplate.Height = 40
        Me.questionGRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.questionGRID.Size = New System.Drawing.Size(408, 116)
        Me.questionGRID.StateCommon.Background.Color1 = System.Drawing.Color.White
        Me.questionGRID.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList
        Me.questionGRID.StateCommon.DataCell.Border.DrawBorders = CType((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.questionGRID.StateCommon.DataCell.Content.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic)
        Me.questionGRID.StateCommon.DataCell.Content.Padding = New System.Windows.Forms.Padding(-1, 10, -1, 10)
        Me.questionGRID.StateCommon.HeaderColumn.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed
        Me.questionGRID.StateCommon.HeaderColumn.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.questionGRID.StateCommon.HeaderColumn.Border.Width = 0
        Me.questionGRID.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.questionGRID.StateCommon.HeaderColumn.Content.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionGRID.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias
        Me.questionGRID.TabIndex = 482
        Me.questionGRID.Visible = False
        '
        'updateBTN
        '
        Me.updateBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.updateBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.updateBTN.Image = Nothing
        Me.updateBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.updateBTN.Location = New System.Drawing.Point(774, 5)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Size = New System.Drawing.Size(92, 26)
        Me.updateBTN.Style = MetroFramework.MetroColorStyle.Green
        Me.updateBTN.TabIndex = 488
        Me.updateBTN.Text = "save"
        Me.updateBTN.UseSelectable = True
        Me.updateBTN.UseVisualStyleBackColor = True
        Me.updateBTN.Visible = False
        '
        'addBTN
        '
        Me.addBTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBTN.Image = CType(resources.GetObject("addBTN.Image"), System.Drawing.Image)
        Me.addBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addBTN.Location = New System.Drawing.Point(774, 5)
        Me.addBTN.Name = "addBTN"
        Me.addBTN.Size = New System.Drawing.Size(92, 26)
        Me.addBTN.Style = MetroFramework.MetroColorStyle.Red
        Me.addBTN.TabIndex = 487
        Me.addBTN.Text = "add"
        Me.addBTN.UseSelectable = True
        Me.addBTN.UseVisualStyleBackColor = True
        Me.addBTN.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.updateBTN)
        Me.Panel1.Controls.Add(Me.addBTN)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 562)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(890, 37)
        Me.Panel1.TabIndex = 483
        '
        'newcallinFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(890, 599)
        Me.Controls.Add(Me.bodypnl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MinimizeBox = False
        Me.Name = "newcallinFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.bodypnl.ResumeLayout(False)
        Me.bodypnl.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.answerGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.questionGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents calldate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents calldategen As MetroFramework.Controls.MetroDateTime
    Friend WithEvents callername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents bodypnl As Panel
    Friend WithEvents answerGV As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Private WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents questionGRID As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
    Friend WithEvents address As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents projectname As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents jo As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents addBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents updateBTN As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents faxno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents telno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cin As MetroFramework.Controls.MetroTextBox
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents MetroTextButton3 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents MetroTextButton4 As MetroFramework.Controls.MetroTextBox.MetroTextButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents conversation As RichTextBox
    Friend WithEvents notspecifiedchk As CheckBox
    Friend WithEvents mechanismchk As CheckBox
    Friend WithEvents glasschk As CheckBox
    Friend WithEvents screenchk As CheckBox
    Friend WithEvents doorchk As CheckBox
    Friend WithEvents Windowchk As CheckBox
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
