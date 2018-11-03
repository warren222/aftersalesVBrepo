Imports System.Data.SqlClient
Public Class reportFRM
    Dim sql As New sql
    Private Sub reportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadreport()
    End Sub
    Public Sub loadreport()
        Dim str As String = "select * from repottb where sid = @sid"
        Dim ds As New DataSet
        ds.clear
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "repottb")
                        reportGRID.DataSource = ds.Tables("repottb")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
End Class