Imports System.Data.SqlClient
Public Class quotationstatusFRM
    Dim SQL As New sql
    Private Sub quotationstatusFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub statusdate_Click(sender As Object, e As EventArgs) Handles statusdate.Click

    End Sub

    Private Sub quotationstatusFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        statusdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        statusdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim sd As String = statusdate.Text
        Select Case statusdate.Text
            Case ""
                sd = "pending"
            Case Else
                sd = sd
        End Select
        up(sd)
        quotationFRM.refreshBTN.PerformClick()
    End Sub
    Private Sub up(ByVal sd As String)
        Dim str As String = "update quotationtb set accepted = @sd where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", quotationFRM.id)
                    sqlcmd.Parameters.AddWithValue("@sd", sd)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class
