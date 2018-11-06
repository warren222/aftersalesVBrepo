Imports System.Data.SqlClient
Public Class newqsFRM
    Dim sql As New sql
    Private Sub newqsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            If Not IsNumeric(item.Text) Then
                Return
            End If
            add()
            qsFRM.refreshbtn.PerformClick()
        ElseIf save.Text = "save" Then
            If Not IsNumeric(item.Text) Then
                Return
            End If
            update1()
            qsFRM.refreshbtn.PerformClick()
        End If

    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(qid),0)+1 from questionnairetb)
                             insert into questionnairetb (qid,item,question)values(@id,@item,@question)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@item", item.Text)
                    sqlcmd.Parameters.AddWithValue("@question", question.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update1()
        Dim str As String = "
                             update questionnairetb set item = @item , question = @question where qid = @qid"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@qid", qsFRM.id)
                    sqlcmd.Parameters.AddWithValue("@item", item.Text)
                    sqlcmd.Parameters.AddWithValue("@question", question.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class