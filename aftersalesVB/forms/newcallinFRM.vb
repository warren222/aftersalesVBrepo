﻿Imports System.Data.SqlClient
Imports MetroFramework

Public Class newcallinFRM
    Dim sql As New sql
    Dim qid As String
    Private Sub newcallinFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(0, 0)
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadconcern()
    End Sub
    Public Sub loadconcern()
        questionGRID.ClearSelection()
        Dim str As String
        If Me.Text = "New" Then
            str = "update answertb set chk = '0'
                             select * from questionnairetb order by item asc"
        Else
            str = "select * from questionnairetb order by item asc"
        End If

        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "questionnairetb")
                        questionGRID.DataSource = ds.Tables("questionnairetb")
                        setcolumns(questionGRID)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub setcolumns(ByVal dg As DataGridView)
        dg.Columns("qid").Visible = False
        dg.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dg.Columns("question").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub questionGRID_SelectionChanged(sender As Object, e As EventArgs) Handles questionGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = questionGRID.SelectedRows
        For Each row As DataGridViewRow In selecteditems
            qid = row.Cells("qid").Value.ToString
        Next
        loadanswer()
    End Sub
    Public Sub loadanswer()
        Dim str As String = "SELECT * FROM ANSWERTB WHERE QID = @qid"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@qid", qid)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ANSWERTB")
                        answerGV.DataSource = ds.Tables("ANSWERTB")
                        answerGV.Columns("aid").Visible = False
                        answerGV.Columns("qid").Visible = False
                        answerGV.Columns("chk").Visible = False
                        answerGV.Columns(Column1.Name).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        answerGV.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        answerGV.Columns("answer").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        If answerGV.RowCount >= 0 Then
                            For i As Integer = 0 To answerGV.RowCount - 1
                                Dim row As DataGridViewRow = answerGV.Rows(i)
                                Dim a As String = row.Cells("chk").Value.ToString
                                If a = "1" Then
                                    row.Cells(Column1.Name).Value = True
                                Else
                                    row.Cells(Column1.Name).Value = False
                                End If
                            Next
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub answerGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles answerGV.CellClick
        If answerGV.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim aid As String = ""
            Dim m As String = ""
            Dim row As DataGridViewRow = answerGV.Rows(e.RowIndex)
            aid = row.Cells("aid").Value.ToString
            Dim chkd As Boolean = Convert.ToBoolean(row.Cells(Column1.Name).Value)
            If chkd = True Then
                row.Cells(Column1.Name).Value = False
                m = "0"
            Else
                row.Cells(Column1.Name).Value = True
                m = "1"
            End If
            Dim str As String = "update answertb set chk = @m where aid = @aid"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@m", m)
                        sqlcmd.Parameters.AddWithValue("@aid", aid)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs) Handles metroTextButton1.Click
        Dim f As selectprojectFRM = New selectprojectFRM
        f.ShowDialog()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        Dim str As String = "Declare @autonum as integer = (select isnull(max(autonum),0)+1 from callintb)
                                insert into callintb
                                (autonum,
                                cdate,
                                cin,
                                caller,
                                jo)
                                values
                                (@autonum,
                                @cdate,
                                ((left(CONVERT([varchar](7),@autonum),(2))+'-')+right(CONVERT([varchar](7),@autonum),(5))),                           
                                @caller,
                                @jo)
                                INSERT INTO QATB (CIN,AID) SELECT ((left(CONVERT([varchar](7),@autonum),(2))+'-')+right(CONVERT([varchar](7),@autonum),(5))),AID FROM ANSWERTB WHERE CHK=1
                                UPDATE ANSWERTB SET CHK=0"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd.Parameters
                        .AddWithValue("@jo", jo.Text)
                        .AddWithValue("@cdate", calldate.Text)
                        .AddWithValue("@caller", callername.Text)
                    End With
                    sqlcmd.ExecuteNonQuery()
                    MetroMessageBox.Show(Me, "Record Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub calldategen_ValueChanged(sender As Object, e As EventArgs) Handles calldategen.ValueChanged
        calldate.Text = calldategen.Text
    End Sub

    Private Sub calldategen_MouseDown(sender As Object, e As MouseEventArgs) Handles calldategen.MouseDown
        calldate.Text = calldategen.Text
    End Sub

    Private Sub newcallinFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click
        Dim str As String = "
                            update callintb set
                            cdate=@cdate,
                            caller=@caller,
                            jo=@jo
                            where cin = @cin
                            insert into qatb (cin,aid) select @cin,aid from answertb where chk = '1' and not aid in (select aid from qatb where cin = @cin)
                            delete from qatb where cin = @cin and not aid in (select aid from answertb where chk = '1')"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cdate", calldate.Text)
                    sqlcmd.Parameters.AddWithValue("@caller", callername.Text)
                    sqlcmd.Parameters.AddWithValue("@jo", jo.Text)
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.ExecuteNonQuery()
                    MetroMessageBox.Show(Me, "Data Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class