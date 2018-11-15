Imports System.Data.SqlClient
Public Class newquFRM
    Dim sql As New sql
    Private Sub newquFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            add()
            quotationFRM.refreshBTN.PerformClick()
        ElseIf save.Text = "save" Then
            update()
            quotationFRM.refreshBTN.PerformClick()
        End If
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from quotationtb)
                             insert into quotationtb (id,cin,aseno,qdate,othercharges)values(@id,@cin,@aseno,@qdate,@othercharges)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@aseno", aseno.Text)
                    sqlcmd.Parameters.AddWithValue("@qdate", qudate.Text)
                    sqlcmd.Parameters.AddWithValue("@othercharges", othercharges.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim str As String = "update quotationtb set aseno=@aseno,qdate=@qdate,othercharges=@othercharges where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", quotationFRM.id)
                    sqlcmd.Parameters.AddWithValue("@aseno", aseno.Text)
                    sqlcmd.Parameters.AddWithValue("@qdate", qudate.Text)
                    sqlcmd.Parameters.AddWithValue("@othercharges", othercharges.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        qudate.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        qudate.Text = MetroDateTime1.Text
    End Sub
End Class