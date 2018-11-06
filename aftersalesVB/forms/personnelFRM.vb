Imports System.Data.SqlClient
Public Class personnelFRM
    Dim SQL As New sql

    Public id As String
    Public Sub loadpersonnel()
        Dim str As String = "select * from personneltb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        personnelGRID.Columns.Clear()
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "personneltb")
                        personnelGRID.DataSource = ds.Tables("personneltb")
                        addbtn()
                        personnelGRID.Columns("ID").Visible = False
                        personnelGRID.Columns("PERSONNEL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        personnelGRID.Columns("UPDATEBTN").Width = 70
                        personnelGRID.Columns("DELETEBTN").Width = 70
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using

    End Sub
    Public Sub addbtn()

        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn

        updatebtn.Name = "updatebtn"
        updatebtn.HeaderText = ""
        updatebtn.Text = "update"

        deletebtn.Name = "deletebtn"
        deletebtn.HeaderText = ""
        deletebtn.Text = "delete"

        updatebtn.UseColumnTextForButtonValue = True
        deletebtn.UseColumnTextForButtonValue = True

        personnelGRID.Columns.Insert(2, updatebtn)
        personnelGRID.Columns.Insert(3, deletebtn)
    End Sub

    Private Sub personnelFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadpersonnel()
    End Sub


    Private Sub personnelGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles personnelGRID.CellClick
        If personnelGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 2 Then
                id = personnelGRID.Item("id", e.RowIndex).Value.ToString
                editpersonnelFRM.PERSONNEL.Text = personnelGRID.Item("personnel", e.RowIndex).Value.ToString
                editpersonnelFRM.Text = "Editing"
                editpersonnelFRM.SAVE.Text = "save"
                editpersonnelFRM.ShowDialog()
            ElseIf e.ColumnIndex = 3 Then
                id = personnelGRID.Item("id", e.RowIndex).Value.ToString
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & personnelGRID.Item("personnel", e.RowIndex).Value.ToString & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    Dim str As String = "delete from personneltb where id = @id"
                    Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
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
                    refreshbtn.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadpersonnel()
    End Sub

    Private Sub personnelFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        editpersonnelFRM.PERSONNEL.Text = ""
        editpersonnelFRM.Text = "New"
        editpersonnelFRM.SAVE.Text = "add"
        editpersonnelFRM.ShowDialog()
    End Sub
End Class