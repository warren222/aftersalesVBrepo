Imports System.Data
Imports System.Data.SqlClient

Public Class myteamFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim bs2 As New BindingSource


    Private Sub myteamFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GVteam.DataSource = bs
        KryptonDataGridView2.DataSource = bs2
        getdata()
        getcboxdata()
        Button3.PerformClick()
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
        If tboxteam.Text = "" Then
            MessageBox.Show("Warning", "TEAM NAME IS REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Continue", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
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
        End If
    End Sub

    Private Sub getcboxdata()
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
    End Sub

    Private Sub btnmsave_Click(sender As Object, e As EventArgs) Handles btnmsave.Click
        KryptonDataGridView1.Rows.Insert(0, New String() {cboxpersonnel.SelectedValue.ToString, cboxpersonnel.Text})
    End Sub
    Dim g2selectedrow As String
    Private Sub KryptonDataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles KryptonDataGridView1.SelectionChanged, KryptonDataGridView2.SelectionChanged
        Select Case sender.name
            Case "KryptonDataGridView1"
                Dim rows As DataGridViewSelectedRowCollection = KryptonDataGridView1.SelectedRows
                pidcollection.Clear()
                pidcollection = New ArrayList(rows.Count)
                For Each row As DataGridViewRow In rows
                    pidcollection.Add(row.Cells(0).Value.ToString)
                Next
            Case "KryptonDataGridView2"
                Dim rows As DataGridViewSelectedRowCollection = KryptonDataGridView2.SelectedRows
                For Each row As DataGridViewRow In rows
                    g2selectedrow = row.Cells("tid").Value.ToString
                Next
        End Select

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


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Try
                Dim str As String = "select 
TID,
TEAMNAME,
STUFF((SELECT CHAR(10)+','+FULLNAME FROM TBLteamMember as a
left join tblpersonnel as b
on a.PID = b.PID WHERE A.TID = D.TID
FOR XML PATH('')),1,2,'') AS MEMBERS
from TBLteam AS d"
                Dim sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Dim da As SqlDataAdapter = New SqlDataAdapter
                da.SelectCommand = sqlcmd
                da.Fill(ds, "TBLteamMember")
                bs2.DataSource = ds
                bs2.DataMember = "TBLteamMember"
                KryptonDataGridView2.Columns("tid").Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Continue", "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Try
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                sqlcon.Open()
                Dim str As String = "update servicingtb set teamid = '" & g2selectedrow & "' where id = '" & servicingFRM.id & "'"
                Dim sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                sqlcmd.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            servicingFRM.tid = g2selectedrow
            getdata()
        End Try

    End Sub

    Private Sub GVteam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVteam.CellContentClick

    End Sub

    Private Sub KryptonDataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles KryptonDataGridView2.CellContentClick

    End Sub
End Class