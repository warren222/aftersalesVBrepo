Imports System.Data.SqlClient
Public Class newpartsFRM
    Dim WithEvents timer1 As New Timer
    Dim sql As New sql
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            add()
            partsFRM.refreshbtn.PerformClick()
        ElseIf save.Text = "save" Then

        End If
    End Sub
    Public Sub add()
        Dim str As String = "
                    declare @id as integegr = (select isnull(max(id),0)+1 from partstb)
                    insert into partstb (id,iid,articleno,description,markup,unitprice,qty,netamount)
                    values (@id,@iid,@articleno,@description,@markup,@unitprice,@qty,@netamount)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@iid", itemFRM.id)
                    sqlcmd.Parameters.AddWithValue("@articleno", articleno.Text)
                    sqlcmd.Parameters.AddWithValue("@description", description.Text)
                    sqlcmd.Parameters.AddWithValue("@markup", markup.Text)
                    sqlcmd.Parameters.AddWithValue("@unitprice", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@qty", qty.Text)
                    sqlcmd.Parameters.AddWithValue("@netamount", netamount.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()

    End Sub

    Public Sub zero(ByVal x As Object)
        If x.Text = "" Then
            x.Text = 0
        End If
    End Sub

    Private Sub newpartsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Start()
    End Sub
    Private Sub TIMER1_TICK(sender As Object, e As EventArgs) Handles timer1.Tick
        If IsNumeric(unitprice.Text) And IsNumeric(qty.Text) Then
            netamount.Text = unitprice.Text * qty.Text
        Else
            netamount.Text = ""
        End If
    End Sub
End Class