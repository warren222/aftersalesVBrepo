Imports System.Data.SqlClient
Public Class acctFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Public id As String
    Private Sub acctFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadacct()
    End Sub
    Private Sub loadacct()
        Dim str As String = "select ID,
                                FULLNAME,
                                ACCTTYPE as [ACCOUNT TYPE],
                                PASSWORD
                                from accttb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        acctGRID.Columns.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "accttb")
                        bs.DataSource = ds
                        bs.DataMember = "accttb"
                        acctGRID.DataSource = bs
                        addbutton()
                        acctGRID.Columns("id").Visible = False
                        acctGRID.Columns("password").Visible = False
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub addbutton()
        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn
        With updatebtn
            .Text = "update"
            .Name = "update"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .Text = "delete"
            .Name = "delete"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        acctGRID.Columns.Insert(4, updatebtn)
        acctGRID.Columns.Insert(5, deletebtn)
    End Sub

    Private Sub acctFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newacctFRM.Text = "New"
        newacctFRM.ShowDialog()
    End Sub

    Private Sub acctGRID_SelectionChanged(sender As Object, e As EventArgs) Handles acctGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = acctGRID.SelectedRows
        For Each row As DataGridViewRow In selecteditems
            id = row.Cells("id").Value.ToString
        Next
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadacct()
    End Sub

    Private Sub acctGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles acctGRID.CellClick
        If acctGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = acctGRID.Rows(e.RowIndex)
            id = row.Cells("id").Value.ToString
            If e.ColumnIndex = 4 Then
                newacctFRM.Text = "Editing"
                newacctFRM.save.Text = "save"
                newacctFRM.accttype.Text = row.Cells("ACCOUNT TYPE").Value.ToString
                newacctFRM.fullname.Text = row.Cells("fullname").Value.ToString
                newacctFRM.ShowDialog()
            ElseIf e.ColumnIndex = 5 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                End If
                Dim str As String = "delete from accttb where id = @id"
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
                loadacct()
            End If
        End If
    End Sub
End Class