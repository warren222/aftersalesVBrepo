﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class concernsummaryFRM
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.QATBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.asdbDS = New aftersalesVB.asdbDS()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.QATBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.asdbDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QATBBindingSource
        '
        Me.QATBBindingSource.DataMember = "QATB"
        Me.QATBBindingSource.DataSource = Me.asdbDS
        '
        'asdbDS
        '
        Me.asdbDS.DataSetName = "asdbDS"
        Me.asdbDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.QATBBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "aftersalesVB.qareport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(666, 422)
        Me.ReportViewer1.TabIndex = 0
        '
        'concernsummaryFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 502)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "concernsummaryFRM"
        CType(Me.QATBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.asdbDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents QATBBindingSource As BindingSource
    Friend WithEvents asdbDS As asdbDS
End Class
