Imports System.Data.SqlClient
Public Class reportFRM
    Dim sql As New sql
    Dim rcount As String
    Public id As String
    Private Sub reportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadreport()
    End Sub
    Public Sub loadreport()
        Dim str As String = "select * from reporttb where sid = @sid"
        Dim ds As New DataSet
        ds.clear
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        reportGRID.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reporttb")
                        reportGRID.DataSource = ds.Tables("reporttb")
                        addcolumns()
                        With reportGRID
                            .Columns("id").Visible = False
                            .Columns("sid").Visible = False
                            .Columns("location").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("specification").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("assessment").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using

            Dim str2 As String = "select isnull(count(id),0)+1 from reporttb where SID = @SID"
            Using sqlcmd As SqlCommand = New SqlCommand(str2, sqlcon)
                sqlcmd.Parameters.AddWithValue("@SID", servicingFRM.id)
                Using rd As SqlDataReader = sqlcmd.ExecuteReader
                    While rd.Read
                        rcount = rd(0).ToString
                    End While
                End Using
            End Using
        End Using
        insertreport()
    End Sub
    Public Sub addcolumns()


        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn

        With updatebtn
            .Name = "updatebtn"
            .HeaderText = ""
            .Text = "update"
            .UseColumnTextForButtonValue = True
        End With

        With deletebtn
            .Name = "deletebtn"
            .HeaderText = ""
            .Text = "delete"
            .UseColumnTextForButtonValue = True
        End With
        reportGRID.Columns.Insert(5, updatebtn)
        reportGRID.Columns.Insert(6, deletebtn)
    End Sub
    Public Sub insertreport()
        If rcount = 1 Then
            Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from reporttb)
                                 insert into reporttb (id,sid,location,specification,assessment)values(@id,@sid,'','','')"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
            loadreport()
        Else
            Return
        End If
    End Sub

    Private Sub reportFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub reportGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles reportGRID.CellClick
        If reportGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 5 Then
                id = reportGRID.Item("id", e.RowIndex).Value.ToString
                newreportFRM.location.Text = reportGRID.Item("location", e.RowIndex).Value.ToString
                newreportFRM.specification.Text = reportGRID.Item("specification", e.RowIndex).Value.ToString
                newreportFRM.assessment.Text = reportGRID.Item("assessment", e.RowIndex).Value.ToString
                newreportFRM.Text = "Editing"
                newreportFRM.save.Text = "save"
                newreportFRM.ShowDialog()
            ElseIf e.ColumnIndex = 6 Then
                id = reportGRID.Item("id", e.RowIndex).Value.ToString
                If MetroFramework.MetroMessageBox.Show(Me, "Delete selected report?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    Dim str As String = "delete from reporttb where id = @id"
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
                    refreshbtn.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadreport()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newreportFRM.location.Text = ""
        newreportFRM.specification.Text = ""
        newreportFRM.assessment.Text = ""
        newreportFRM.Text = "New"
        newreportFRM.save.Text = "add"
        newreportFRM.ShowDialog()
    End Sub
End Class