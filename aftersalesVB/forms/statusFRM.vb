Imports System.Data.SqlClient
Public Class statusFRM
    Dim sql As New sql
    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        statusdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        statusdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub statusFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim str As String = "update servicingtb set status = @status , statusdate = @statusdate where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", servicingFRM.id)
                    sqlcmd.Parameters.AddWithValue("@status", status.Text)
                    sqlcmd.Parameters.AddWithValue("@statusdate", statusdate.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        servicingFRM.refresh.PerformClick()
    End Sub
End Class