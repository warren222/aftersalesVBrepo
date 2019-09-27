<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prevFRM
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prevFRM))
        Me.ITEMTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.asdbDS = New aftersalesVB.asdbDS()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dear = New System.Windows.Forms.TextBox()
        Me.note = New System.Windows.Forms.TextBox()
        Me.scopeofworks = New System.Windows.Forms.TextBox()
        Me.preparedby = New System.Windows.Forms.TextBox()
        Me.approvedby = New System.Windows.Forms.TextBox()
        Me.kryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ITEMTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asdbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ITEMTBBindingSource
        '
        Me.ITEMTBBindingSource.DataMember = "ITEMTB"
        Me.ITEMTBBindingSource.DataSource = Me.asdbDS
        '
        'asdbDS
        '
        Me.asdbDS.DataSetName = "asdbDS"
        Me.asdbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ITEMTBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "aftersalesVB.qreport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(482, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(902, 508)
        Me.ReportViewer1.TabIndex = 0
        '
        'dear
        '
        Me.dear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dear.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dear.Location = New System.Drawing.Point(13, 38)
        Me.dear.Multiline = True
        Me.dear.Name = "dear"
        Me.dear.Size = New System.Drawing.Size(455, 155)
        Me.dear.TabIndex = 40
        Me.dear.Text = resources.GetString("dear.Text")
        '
        'note
        '
        Me.note.BackColor = System.Drawing.Color.WhiteSmoke
        Me.note.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.note.Location = New System.Drawing.Point(21, 258)
        Me.note.Multiline = True
        Me.note.Name = "note"
        Me.note.Size = New System.Drawing.Size(455, 47)
        Me.note.TabIndex = 41
        Me.note.Text = "For any question, please feel free to call us at our office telephone nos. 715-87" &
    "77, 912-4333, 913-2542 or 913-2524 or fax no. 912-1892."
        '
        'scopeofworks
        '
        Me.scopeofworks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.scopeofworks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.scopeofworks.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scopeofworks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scopeofworks.Location = New System.Drawing.Point(21, 369)
        Me.scopeofworks.Multiline = True
        Me.scopeofworks.Name = "scopeofworks"
        Me.scopeofworks.Size = New System.Drawing.Size(455, 47)
        Me.scopeofworks.TabIndex = 42
        Me.scopeofworks.Text = "Labor Cost - Php 600/day/person x 2 for 1 day (Php 1,200.00 Labor Cost - FREE of " &
    "CHARGE)"
        '
        'preparedby
        '
        Me.preparedby.BackColor = System.Drawing.Color.WhiteSmoke
        Me.preparedby.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.preparedby.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preparedby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.preparedby.Location = New System.Drawing.Point(21, 502)
        Me.preparedby.Multiline = True
        Me.preparedby.Name = "preparedby"
        Me.preparedby.Size = New System.Drawing.Size(189, 47)
        Me.preparedby.TabIndex = 43
        Me.preparedby.Text = "Ms. Amy Aquino" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aftersales Coordinator"
        '
        'approvedby
        '
        Me.approvedby.BackColor = System.Drawing.Color.WhiteSmoke
        Me.approvedby.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.approvedby.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approvedby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.approvedby.Location = New System.Drawing.Point(233, 502)
        Me.approvedby.Multiline = True
        Me.approvedby.Name = "approvedby"
        Me.approvedby.Size = New System.Drawing.Size(189, 47)
        Me.approvedby.TabIndex = 44
        Me.approvedby.Text = "Ms. Genalyn Garcia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VP-Gen. Manager"
        '
        'kryptonLabel2
        '
        Me.kryptonLabel2.Location = New System.Drawing.Point(56, 474)
        Me.kryptonLabel2.Name = "kryptonLabel2"
        Me.kryptonLabel2.Size = New System.Drawing.Size(83, 22)
        Me.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.kryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kryptonLabel2.TabIndex = 493
        Me.kryptonLabel2.Values.Text = "Prepared By"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Location = New System.Drawing.Point(265, 474)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(86, 22)
        Me.KryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel1.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 494
        Me.KryptonLabel1.Values.Text = "Approved By"
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(21, 341)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(110, 22)
        Me.KryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.KryptonLabel3.StateCommon.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 495
        Me.KryptonLabel3.Values.Text = "Scope of Work(s)"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 15)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox1.TabIndex = 496
        Me.CheckBox1.Text = "No Signature"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.ReportViewer1)
        Me.Panel1.Controls.Add(Me.dear)
        Me.Panel1.Controls.Add(Me.KryptonLabel3)
        Me.Panel1.Controls.Add(Me.note)
        Me.Panel1.Controls.Add(Me.KryptonLabel1)
        Me.Panel1.Controls.Add(Me.scopeofworks)
        Me.Panel1.Controls.Add(Me.kryptonLabel2)
        Me.Panel1.Controls.Add(Me.preparedby)
        Me.Panel1.Controls.Add(Me.approvedby)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 519)
        Me.Panel1.TabIndex = 497
        '
        'prevFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 599)
        Me.Controls.Add(Me.Panel1)
        Me.MinimizeBox = False
        Me.Name = "prevFRM"
        CType(Me.ITEMTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asdbDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ITEMTBBindingSource As BindingSource
    Friend WithEvents asdbDS As asdbDS
    Private WithEvents dear As TextBox
    Private WithEvents note As TextBox
    Private WithEvents scopeofworks As TextBox
    Private WithEvents preparedby As TextBox
    Private WithEvents approvedby As TextBox
    Friend WithEvents kryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As Panel
End Class
