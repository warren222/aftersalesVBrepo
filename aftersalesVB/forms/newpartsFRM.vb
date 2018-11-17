Imports System.Data.SqlClient
Public Class newpartsFRM
    Dim WithEvents timer1 As New Timer
    Dim sql As New sql
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        zero(markup)
        zero(unitprice)
        zero(qty)
        zero(netamount)
        If save.Text = "add" Then
            add()
            partsFRM.refreshbtn.PerformClick()
        ElseIf save.Text = "save" Then
            update()
            partsFRM.refreshbtn.PerformClick()
        End If
    End Sub
    Public Sub add()
        Dim str As String = "
                    declare @id as integer = (select isnull(max(id),0)+1 from partstb)
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
        Dim str As String = "
                 
                    update partstb set articleno=@articleno,description=@description,markup=@markup,unitprice=@unitprice,qty=@qty,netamount=@netamount
                    where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", partsFRM.id)
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

    Public Sub zero(ByVal x As Object)
        If x.Text = "" Then
            x.Text = 0
        End If
    End Sub

    Private Sub newpartsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        timer1.Start()
        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black
        End If
        ccolor(articleno, clr)
        ccolor(description, clr)
        ccolor(markup, clr)
        ccolor(unitprice, clr)
        ccolor(qty, clr)
        ccolor(netamount, clr)
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
    Private Sub TIMER1_TICK(sender As Object, e As EventArgs) Handles timer1.Tick
        If IsNumeric(unitprice.Text) And IsNumeric(qty.Text) And IsNumeric(markup.Text) Then
            Dim net As Double = unitprice.Text * qty.Text
            Dim mup As Double = (markup.Text * 0.01) * net
            netamount.Text = net + mup
        Else
            netamount.Text = ""
        End If
    End Sub

    Private Sub newpartsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        importpartsFRM.Dispose()
        Me.Dispose()
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        importpartsFRM.Show()
    End Sub
End Class