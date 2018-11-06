Imports System.Data.SqlClient
Public Class newconcernFRM
    Dim sql As New sql
    Private Sub newconcernFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            If Not IsNumeric(item.Text) Then
                Return
            End If
            add()
            concernFRM.refreshbtn.PerformClick()
        ElseIf save.Text = "save" Then
            If Not IsNumeric(item.Text) Then
                Return
            End If
            update1()
            concernFRM.refreshbtn.PerformClick()
        End If
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(aid),0)+1 from answertb)
                             insert into answertb (aid,qid,chk,item,answer)values(@id,@qid,'0',@item,@answer)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@qid", qsFRM.id)
                    sqlcmd.Parameters.AddWithValue("@item", item.Text)
                    sqlcmd.Parameters.AddWithValue("@answer", concern.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update1()
        Dim str As String = "
                             update answertb set item = @item , answer = @answer where aid = @aid"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@aid", concernFRM.aid)
                    sqlcmd.Parameters.AddWithValue("@item", item.Text)
                    sqlcmd.Parameters.AddWithValue("@answer", concern.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class