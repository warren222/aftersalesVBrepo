Imports System.Data.SqlClient
Public Class newitemFRM
    Dim sql As New sql

    Private Sub newitemFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            add()
            itemFRM.refreshbtn.PerformClick()
        ElseIf save.Text = "save" Then
            update()
            itemFRM.refreshbtn.PerformClick()
        End If
    End Sub


    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from itemtb)
insert into itemtb (id,aseno,ITEM,kno,wdwloc)
values(@id,@aseno,@item,@kno,@loc)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    sqlcmd.Parameters.AddWithValue("@item", itemno.Text)
                    sqlcmd.Parameters.AddWithValue("@kno", kno.Text)
                    sqlcmd.Parameters.AddWithValue("@loc", wdwloc.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim str As String = "
update itemtb set
ITEM=@item,kno=@kno,
wdwloc=@loc WHERE ID = @ID"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", itemFRM.id)
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    sqlcmd.Parameters.AddWithValue("@item", itemno.Text)
                    sqlcmd.Parameters.AddWithValue("@kno", kno.Text)
                    sqlcmd.Parameters.AddWithValue("@loc", wdwloc.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newitemFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub metroTextButton2_Click(sender As Object, e As EventArgs) Handles metroTextButton2.Click
        importFRM.ShowDialog()
    End Sub
End Class