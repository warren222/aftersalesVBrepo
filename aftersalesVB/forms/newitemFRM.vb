Imports System.Data.SqlClient
Public Class newitemFRM
    Dim sql As New sql
    Dim WithEvents timer1 As New Timer
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
    Private Sub TIMER1_TICK(sender As Object, e As EventArgs) Handles timer1.Tick
        If IsNumeric(unitprice.Text) And IsNumeric(qty.Text) Then
            netamount.Text = unitprice.Text * qty.Text
        Else
            netamount.Text = ""
        End If
    End Sub
    Public Sub zero(ByVal x As Object)
        If x.Text = "" Then
            x.Text = 0
        End If
    End Sub
    Public Sub add()
        zero(unitprice)
        zero(qty)
        zero(netamount)
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from itemtb)
insert into itemtb (id,aseno,ITEM,kno,wdwloc,parts,unitprice,qty,netprice)
values(@id,@aseno,@item,@kno,@loc,@parts,@unitprice,@qty,@netprice)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    sqlcmd.Parameters.AddWithValue("@item", itemno.Text)
                    sqlcmd.Parameters.AddWithValue("@kno", kno.Text)
                    sqlcmd.Parameters.AddWithValue("@parts", parts.Text)
                    sqlcmd.Parameters.AddWithValue("@loc", wdwloc.Text)
                    sqlcmd.Parameters.AddWithValue("@unitprice", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@qty", qty.Text)
                    sqlcmd.Parameters.AddWithValue("@netprice", netamount.Text)
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
wdwloc=@loc,parts=@parts,
unitprice=@unitprice,
qty=@qty,netprice=@netprice"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", itemFRM.id)
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    sqlcmd.Parameters.AddWithValue("@item", itemno.Text)
                    sqlcmd.Parameters.AddWithValue("@kno", kno.Text)
                    sqlcmd.Parameters.AddWithValue("@loc", wdwloc.Text)
                    sqlcmd.Parameters.AddWithValue("@parts", parts.Text)
                    sqlcmd.Parameters.AddWithValue("@unitprice", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@qty", qty.Text)
                    sqlcmd.Parameters.AddWithValue("@netprice", netamount.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newitemFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timer1.Start()
    End Sub
End Class