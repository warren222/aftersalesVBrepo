Imports System.Data.SqlClient
Public Class statusFRM
    Dim sql As New sql
    Public Shared source As String
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
        Dim id As String
        If source = "ServicingFRM" Then
            id = servicingFRM.id
        ElseIf source = "ServicingScheduleFRM" Then
            id = ServicingScheduleFRM.id
        End If
        Dim str As String = "update servicingtb set status = @status , statusdate = @statusdate where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@status", status.Text)
                    sqlcmd.Parameters.AddWithValue("@statusdate", statusdate.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        If source = "ServicingFRM" Then
            servicingFRM.refresh.PerformClick()
        ElseIf source = "ServicingScheduleFRM" Then
            ServicingScheduleFRM.Button1.PerformClick()
        End If

    End Sub

    Private Sub statusFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class