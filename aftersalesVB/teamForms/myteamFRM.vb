Imports System.Data
Imports System.Data.SqlClient

Public Class myteamFRM
    Dim sql As New sql
    Dim bs As New BindingSource


    Private Sub myteamFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVteam.DataSource = bs
        getdata()
    End Sub
    Private Sub getdata()
        Try
            Dim ds As New DataSet
            ds.Clear()
            Dim str As String = "select FULLNAME from tblteammember as a
left join 
tblteam as b
on a.tid = b.tid
left join TBLpersonnel as c
on a.pid = c.PID

where a.tid = @tid"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                sqlcon.Open()
                Dim sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                sqlcmd.Parameters.AddWithValue("@tid", servicingFRM.tid)
                Dim da As SqlDataAdapter = New SqlDataAdapter
                da.SelectCommand = sqlcmd
                da.Fill(ds, "tblteammember")
                bs.DataSource = ds
                bs.DataMember = "tblteammember"
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Dim pidcollection As New ArrayList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim teamname As String = tboxteam.Text
        KryptonDataGridView1.SelectAll()
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                sqlcon.Open()

                Dim newtid As String = ""
                Dim qry As String = "
                                    declare @tid as integer = (select isnull(max(isnull(tid,0)),0)+1 from TBLteam)
	                                insert into TBLteam (tid,teamname)values(@tid,@teamname)
                                    select tid from TBLteam where tid = @tid"
                Using sqlcmd As SqlCommand = New SqlCommand(qry, sqlcon)
                    With sqlcmd
                        .Parameters.AddWithValue("@teamname", tboxteam.Text)
                    End With
                    Using dr As SqlDataReader = sqlcmd.ExecuteReader
                        While dr.Read
                            newtid = dr(0).ToString
                        End While
                    End Using
                End Using
                Try
                    For i As Integer = 0 To pidcollection.Count - 1
                        Dim qry2 As String = "
                                    declare @id as integer = (select isnull(max(isnull(id,0)),0)+1 from TBLteamMember)
	                                insert into TBLteamMember (id,tid,pid)values(@id,@tid,@pid)
                                    update servicingtb set teamid  = @tid where id = @sid"
                        Using sqlcmd As SqlCommand = New SqlCommand(qry2, sqlcon)
                            With sqlcmd
                                .Parameters.AddWithValue("@tid", newtid)
                                .Parameters.AddWithValue("@pid", pidcollection(i).ToString)
                                .Parameters.AddWithValue("@sid", servicingFRM.id)
                            End With
                            sqlcmd.ExecuteNonQuery()
                        End Using
                    Next
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    servicingFRM.tid = newtid
                    getdata()
                End Try
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

        End Try
    End Sub

    Private Sub cboxpersonnel_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxpersonnel.MouseDown
        If cboxpersonnel.Items.Count > 0 Then
        Else
            Try
                Dim str As String = "select pid,fullname from TBLpersonnel"
                Dim ds As New DataSet
                ds.Clear()
                Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter(str, sqlcon)
                    da.Fill(ds, "TBLpersonnel")
                    cboxpersonnel.DataSource = ds.Tables("TBLpersonnel")
                    cboxpersonnel.ValueMember = "PID"
                    cboxpersonnel.DisplayMember = "FULLNAME"
                    cboxpersonnel.SelectedIndex = -1
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub btnmsave_Click(sender As Object, e As EventArgs) Handles btnmsave.Click
        KryptonDataGridView1.Rows.Insert(0, New String() {cboxpersonnel.SelectedValue.ToString, cboxpersonnel.Text})
    End Sub

    Private Sub KryptonDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView1.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
        pidcollection.Clear()
        pidcollection = New ArrayList(rows.Count)
        For Each row As DataGridViewRow In rows
            pidcollection.Add(row.Cells(0).Value.ToString)
        Next
    End Sub

    Private Sub myteamFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        servicingFRM.refresh.PerformClick()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rows As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
        For Each row As DataGridViewRow In rows
            KryptonDataGridView1.Rows.RemoveAt(row.Index)
        Next
    End Sub
End Class