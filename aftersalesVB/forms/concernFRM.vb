Imports System.Data.SqlClient
Imports MetroFramework

Public Class concernFRM
    Dim sql As New sql
    Dim qid As String
    Dim aid As String
    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        If Not IsNumeric(itemTXT.Text) Then
            Return
        End If
        Dim str As String = "declare @id as integer = (select isnull(max(qid)+1,0) from questionnairetb)
                             insert into questionnairetb (qid,item,question) values (@id,@item,@question)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@item", itemTXT.Text)
                    sqlcmd.Parameters.AddWithValue("@question", questionTXT.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        refreshBTN.PerformClick()
    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click
        If Not IsNumeric(itemTXT.Text) Then
            Return
        End If
        Dim str As String = "update questionnairetb set item = @item , question = @question where qid = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@item", itemTXT.Text)
                    sqlcmd.Parameters.AddWithValue("@question", questionTXT.Text)
                    sqlcmd.Parameters.AddWithValue("@id", qid)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        refreshBTN.PerformClick()
    End Sub

    Private Sub deleteBTN_Click(sender As Object, e As EventArgs) Handles deleteBTN.Click
        If MetroMessageBox.Show(Me, "delete record?", "Continue...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim str As String = "delete from questionnairetb where qid = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", qid)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        refreshBTN.PerformClick()
    End Sub

    Private Sub refreshBTN_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        loadquestionnaire
    End Sub
    Public Sub loadquestionnaire()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String = "select * from questionnairetb order by item asc"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "questionnairetb")
                        questionGRID.DataSource = ds.Tables("questionnairetb")
                        questionGRID.Columns("qid").Visible = False
                        questionGRID.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using

    End Sub

    Private Sub questionGRID_SelectionChanged(sender As Object, e As EventArgs) Handles questionGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = questionGRID.SelectedRows
        For Each rows As DataGridViewRow In selecteditems
            qid = rows.Cells("qid").Value.ToString()
            itemTXT.Text = rows.Cells("item").Value.ToString()
            questionTXT.Text = rows.Cells("question").Value.ToString()
            question.Text = rows.Cells("question").Value.ToString()
        Next
    End Sub

    Private Sub questionGRID_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles questionGRID.CellDoubleClick
        loadanswer()
        metroTabControl1.SelectedIndex = 1
    End Sub
    Public Sub loadanswer()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String = "select * from answertb where qid = @qid"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@qid", qid)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "answertb")
                        answerGRID.DataSource = ds.Tables("answertb")
                        answerGRID.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        answerGRID.Columns("aid").Visible = False
                        answerGRID.Columns("qid").Visible = False
                        answerGRID.Columns("chk").Visible = False
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub concernFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs) Handles metroTextButton1.Click
        If Not IsNumeric(aitemTXT.Text) Then
            Return
        End If
        Dim str As String = "declare @id as integer = (select isnull(max(aid)+1,0) from answertb) insert into answertb (aid,qid,item,answer) values (@id,@qid,@item,@answer)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@qid", qid)
                    sqlcmd.Parameters.AddWithValue("@item", aitemTXT.Text)
                    sqlcmd.Parameters.AddWithValue("@answer", answerTXT.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        metroTextButton2.PerformClick()
    End Sub

    Private Sub metroTextButton3_Click(sender As Object, e As EventArgs) Handles metroTextButton3.Click
        If Not IsNumeric(aitemTXT.Text) Then
            Return
        End If
        Dim str As String = "update answertb set qid=@qid,item=@item,answer=@answer where aid = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", aid)
                    sqlcmd.Parameters.AddWithValue("@qid", qid)
                    sqlcmd.Parameters.AddWithValue("@item", aitemTXT.Text)
                    sqlcmd.Parameters.AddWithValue("@answer", answerTXT.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        metroTextButton2.PerformClick()
    End Sub

    Private Sub metroTextButton4_Click(sender As Object, e As EventArgs) Handles metroTextButton4.Click
        If MetroMessageBox.Show(Me, "delete record?", "Continue...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Dim str As String = "delete from answertb where aid = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", aid)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        metroTextButton2.PerformClick()
    End Sub

    Private Sub metroTextButton2_Click(sender As Object, e As EventArgs) Handles metroTextButton2.Click
        loadanswer()
    End Sub

    Private Sub concernFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, 0)
        loadquestionnaire()
    End Sub

    Private Sub answerGRID_SelectionChanged(sender As Object, e As EventArgs) Handles answerGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = answerGRID.SelectedRows
        For Each rows As DataGridViewRow In selecteditems
            aid = rows.Cells("aid").Value.ToString()
            aitemTXT.Text = rows.Cells("item").Value.ToString()
            answerTXT.Text = rows.Cells("answer").Value.ToString()
        Next
    End Sub

    Private Sub metroTabPage2_Click(sender As Object, e As EventArgs) Handles metroTabPage2.Click

    End Sub
End Class