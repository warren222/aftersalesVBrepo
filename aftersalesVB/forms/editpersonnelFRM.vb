Imports System.Data.SqlClient
Public Class editpersonnelFRM
    Dim sql As New sql
    Private Sub SAVE_Click(sender As Object, e As EventArgs) Handles SAVE.Click
        If SAVE.Text = "add" Then
            add()
        ElseIf SAVE.Text = "save" Then
            update()
        End If
        personnelFRM.refreshbtn.PerformClick()
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from personneltb)
                             insert into personneltb (id,personnel) values(@id,@personnel)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@personnel", PERSONNEL.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim str As String = "update personneltb set personnel  = @personnel where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", personnelFRM.id)
                    sqlcmd.Parameters.AddWithValue("@personnel", PERSONNEL.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub editpersonnelFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub editpersonnelFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class