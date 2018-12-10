Imports System.Data.SqlClient
Public Class newacctFRM
    Dim sql As New sql
    Private Sub newacctFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If Me.Text = "New" Then
            add()
        ElseIf Me.Text = "Editing" Then
            edit()
        End If
        acctFRM.refreshbtn.PerformClick()
    End Sub
    Private Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from accttb)
                             insert into accttb (id,fullname,accttype,password)values(@id,@fullname,@accttype,@id)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@accttype", accttype.Text)
                    sqlcmd.Parameters.AddWithValue("@fullname", fullname.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Private Sub edit()
        Dim str As String = "update accttb set fullname=@fullname,accttype=@accttype where id=@id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@accttype", accttype.Text)
                    sqlcmd.Parameters.AddWithValue("@fullname", fullname.Text)
                    sqlcmd.Parameters.AddWithValue("@id", acctFRM.id)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newacctFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black
        End If
        ccolor(fullname, clr)
        ccolor(accttype, clr)

    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
End Class