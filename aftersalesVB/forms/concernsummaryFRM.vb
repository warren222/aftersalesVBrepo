Imports System.Data.SqlClient
Public Class concernsummaryFRM
    Dim sql As New sql
    Private Sub concernsummaryFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim STR As String = "  
                              SELECT * FROM QATB AS A 
                              INNER JOIN ANSWERTB AS B
                              ON A.AID = B.AID
                              INNER JOIN QUESTIONNAIRETB AS C
                              ON B.QID = C.QID
                              WHERE A.CIN = '" & mainform.tempcin & "'"
        Dim ds As New asdbDS
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(STR, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds.QATB)
                        QATBBindingSource.DataSource = ds.QATB.DefaultView
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class