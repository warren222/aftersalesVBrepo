Imports System.Data.SqlClient
Public Class qsFRM
    Dim sql As New sql
    Public id As String
    Dim counter As String
    Private Sub qsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadquestionnaire()
    End Sub
    Public Sub loadquestionnaire()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String = "select QID,ITEM,QUESTION AS [(SPECIFICATION) QUESTION] from questionnairetb order by item asc"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        questionGRID.Columns.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "questionnairetb")
                        questionGRID.DataSource = ds.Tables("questionnairetb")
                        addcolumns()
                        questionGRID.Columns("qid").Visible = False
                        questionGRID.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        questionGRID.Columns("(SPECIFICATION) QUESTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using

            Dim str1 As String = "select isnull(count(qid),0)+1 from questionnairetb"
            Using sqlcmd As SqlCommand = New SqlCommand(str1, sqlcon)
                Using rd As SqlDataReader = sqlcmd.ExecuteReader
                    While rd.Read
                        counter = rd(0).ToString
                    End While
                End Using
            End Using
        End Using
        addone()
    End Sub
    Public Sub addone()
        If counter = "1" Then
            Dim str As String = "declare @id as integer = (select isnull(max(qid),0)+1 from questionnairetb)
                                 insert into questionnairetb (qid,item,question)values(@id,'','')"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Try
                        sqlcon.Open()
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
            loadquestionnaire()
        Else
            Return
        End If
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

        questionGRID.Columns.Insert(3, updatebtn)
        questionGRID.Columns.Insert(4, deletebtn)
        questionGRID.Columns.Insert(5, concernbtn)
    End Sub

    Private Sub qsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub questionGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles questionGRID.CellClick
        If questionGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                id = questionGRID.Item("qid", e.RowIndex).Value.ToString
                newqsFRM.question.Text = questionGRID.Item("(specification) question", e.RowIndex).Value.ToString
                newqsFRM.item.Text = questionGRID.Item("item", e.RowIndex).Value.ToString
                newqsFRM.Text = "Editing"
                newqsFRM.save.Text = "save"
                newqsFRM.ShowDialog()
            ElseIf e.ColumnIndex = 4 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete selected item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    id = questionGRID.Item("qid", e.RowIndex).Value.ToString
                    Dim str As String = "delete from questionnairetb where qid = @qid"
                    Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                        Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                            Try
                                sqlcon.Open()
                                sqlcmd.Parameters.AddWithValue("@qid", id)
                                sqlcmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End Using
                    End Using
                End If
                loadquestionnaire()
            ElseIf e.ColumnIndex = 5 Then
                id = questionGRID.Item("qid", e.RowIndex).Value.ToString
                concernFRM.Text = questionGRID.Item("(specification) question", e.RowIndex).Value.ToString
                concernFRM.ShowDialog()
            End If
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadquestionnaire()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newqsFRM.question.Text = ""
        newqsFRM.item.Text = ""
        newqsFRM.Text = "New"
        newqsFRM.save.Text = "add"
        newqsFRM.ShowDialog()
    End Sub
End Class