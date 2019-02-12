Imports System.Data.SqlClient
Public Class reportassessmentFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Private Sub reportassessmentFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub loaddata()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String = "select b.ASSESSMENT FROM RELREPASS AS A INNER JOIN ASSESSMENTTB as b ON A.ASSID = B.ID WHERE A.REPID = @repid "
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@repid", reportFRM.id)
                    Using da As SqlDataAdapter = New SqlDataAdapter()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "RELREPASS")
                        bs.DataSource = ds
                        bs.DataMember = "RELREPASS"
                        assessmentGRID.DataSource = bs
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub reportassessmentFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
End Class