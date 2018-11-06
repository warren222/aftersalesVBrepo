Imports System.Data.SqlClient
Imports MetroFramework

Public Class concernFRM
    Dim sql As New sql

    Public aid As String

    Private Sub concernFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadconcern()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadconcern()
    End Sub
    Public Sub loadconcern()
        Dim str As String = "select aid,qid,chk,ITEM,ANSWER AS CONCERN from answertb where qid = @qid"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        answerGRID.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@qid", qsFRM.id)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "answertb")
                        answerGRID.DataSource = ds.Tables("answertb")
                        addcolumns()
                        answerGRID.Columns("aid").Visible = False
                        answerGRID.Columns("qid").Visible = False
                        answerGRID.Columns("chk").Visible = False
                        answerGRID.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        answerGRID.Columns("CONCERN").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub addcolumns()

        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn
        Dim concernbtn As New DataGridViewButtonColumn

        With updatebtn
            .HeaderText = ""
            .Name = "updatebtn"
            .Text = "update"
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .HeaderText = ""
            .Name = "deletebtn"
            .Text = "delete"
            .UseColumnTextForButtonValue = True
        End With
        With concernbtn
            .HeaderText = ""
            .Name = "concernbtn"
            .Text = "concern"
            .UseColumnTextForButtonValue = True
        End With

        answerGRID.Columns.Insert(5, updatebtn)
        answerGRID.Columns.Insert(6, deletebtn)

    End Sub

    Private Sub concernFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub answerGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles answerGRID.CellClick
        If answerGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 5 Then
                aid = answerGRID.Item("aid", e.RowIndex).Value.ToString
                newconcernFRM.item.Text = answerGRID.Item("item", e.RowIndex).Value.ToString
                newconcernFRM.concern.Text = answerGRID.Item("concern", e.RowIndex).Value.ToString
                newconcernFRM.Text = "Editing"
                newconcernFRM.save.Text = "save"
                newconcernFRM.ShowDialog()
            ElseIf e.ColumnIndex = 6 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete selected item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    aid = answerGRID.Item("aid", e.RowIndex).Value.ToString
                    Dim str As String = "delete from answertb where aid = @aid"
                    Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                        Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                            Try
                                sqlcon.Open()
                                sqlcmd.Parameters.AddWithValue("@aid", aid)
                                sqlcmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End Using
                    End Using
                End If
                loadconcern()
            End If
        End If
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newconcernFRM.item.Text = ""
        newconcernFRM.concern.Text = ""
        newconcernFRM.Text = "New"
        newconcernFRM.save.Text = "add"
        newconcernFRM.ShowDialog()
    End Sub
End Class