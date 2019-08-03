Imports System.Data.SqlClient
Public Class memberFRM
    Public Shared teamid As String
    Dim sql As New sql
    Dim bs As New BindingSource
    Private Sub memberFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gv.DataSource = bs
        loadname()
        Button2.PerformClick()
    End Sub
    Public Sub loadname()
        Dim ds As New DataSet
        ds.Clear()

        Dim str As String = "select distinct PERSONNEL,position  from personneltb"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "personneltb")
                    fullname.DataSource = ds.Tables("personneltb")
                    fullname.DisplayMember = "PERSONNEL"
                    positions.DataBindings.Clear()
                    positions.DataBindings.Add("text", ds.Tables("personneltb"), "position")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        add()
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from personneltb)
                             insert into personneltb (id,personnel,position,teamid) values(@id,@personnel,@position,@teamid)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@personnel", fullname.Text)
                    sqlcmd.Parameters.AddWithValue("@position", positions.Text)
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        Button2.PerformClick()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "select * from personneltb where teamid = @teamid"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@teamid", teamid)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "personneltb")
                        bs.DataSource = ds
                        bs.DataMember = "personneltb"
                        gv.Columns("ID").Visible = False
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Dim id As String
    Private Sub gv_SelectionChanged(sender As Object, e As EventArgs) Handles gv.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = gv.SelectedRows
        For Each row As DataGridViewRow In rows
            id = row.Cells("id").Value.ToString
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "delete from personneltb where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        Button2.PerformClick()
    End Sub
End Class