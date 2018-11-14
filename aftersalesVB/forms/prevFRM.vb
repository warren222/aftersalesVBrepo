Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class prevFRM
    Dim sql As New sql
    Private Sub prevFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrep()
        Dim param1 As ReportParameter = New ReportParameter("project", quotationFRM.projectname.Text)
        Dim param2 As ReportParameter = New ReportParameter("address", quotationFRM.address.Text)
        Dim param3 As ReportParameter = New ReportParameter("ase", quotationFRM.ase)
        Dim param4 As ReportParameter = New ReportParameter("qdate", quotationFRM.d)
        With ReportViewer1.LocalReport
            .SetParameters(New ReportParameter() {param1})
            .SetParameters(New ReportParameter() {param2})
            .SetParameters(New ReportParameter() {param3})
            .SetParameters(New ReportParameter() {param4})
        End With
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub loadrep()
        Dim str As String = "select * from itemtb where aseno = @aseno"
        Dim ds As New asdbDS
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.ase)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds.ITEMTB)
                        ITEMTBBindingSource.DataSource = ds.ITEMTB.DefaultView
                    Catch ex As Exception

                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub prevFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class