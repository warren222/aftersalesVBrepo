﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServicingScheduleFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ServicingScheduleFRM))
        Me.gvpnl = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.project = New MetroFramework.Controls.MetroTextBox()
        Me.donecheckbox = New MetroFramework.Controls.MetroToggle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'gvpnl
        '
        Me.gvpnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gvpnl.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gvpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gvpnl.Location = New System.Drawing.Point(15, 122)
        Me.gvpnl.Name = "gvpnl"
        Me.gvpnl.Size = New System.Drawing.Size(860, 264)
        Me.gvpnl.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM dd, yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(167, 78)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 23)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMM dd, yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(324, 78)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(119, 23)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Begin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(881, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DATE FILTER"
        '
        'project
        '
        '
        '
        '
        Me.project.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.project.CustomButton.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.project.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.project.CustomButton.Location = New System.Drawing.Point(352, 1)
        Me.project.CustomButton.Name = ""
        Me.project.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.project.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.project.CustomButton.TabIndex = 1
        Me.project.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.project.CustomButton.UseSelectable = True
        Me.project.CustomButton.UseVisualStyleBackColor = False
        Me.project.CustomButton.Visible = False
        Me.project.DisplayIcon = True
        Me.project.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.project.Lines = New String(-1) {}
        Me.project.Location = New System.Drawing.Point(460, 72)
        Me.project.MaxLength = 32767
        Me.project.Name = "project"
        Me.project.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.project.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.project.SelectedText = ""
        Me.project.SelectionLength = 0
        Me.project.SelectionStart = 0
        Me.project.ShowClearButton = True
        Me.project.Size = New System.Drawing.Size(380, 29)
        Me.project.Style = MetroFramework.MetroColorStyle.Red
        Me.project.TabIndex = 473
        Me.project.UseCustomForeColor = True
        Me.project.UseSelectable = True
        Me.project.WaterMark = "Search"
        Me.project.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.project.WaterMarkFont = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'donecheckbox
        '
        Me.donecheckbox.AutoSize = True
        Me.donecheckbox.Checked = True
        Me.donecheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.donecheckbox.Location = New System.Drawing.Point(29, 78)
        Me.donecheckbox.Name = "donecheckbox"
        Me.donecheckbox.Size = New System.Drawing.Size(80, 17)
        Me.donecheckbox.Style = MetroFramework.MetroColorStyle.Red
        Me.donecheckbox.TabIndex = 841
        Me.donecheckbox.Tag = ""
        Me.donecheckbox.Text = "On"
        Me.donecheckbox.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 842
        Me.Label5.Text = "PROJECT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 24)
        Me.Label3.TabIndex = 843
        Me.Label3.Text = "Servicing Schedule"
        '
        'ServicingScheduleFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 398)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.donecheckbox)
        Me.Controls.Add(Me.project)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.gvpnl)
        Me.Name = "ServicingScheduleFRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvpnl As Panel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents project As MetroFramework.Controls.MetroTextBox
    Friend WithEvents donecheckbox As MetroFramework.Controls.MetroToggle
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
End Class
