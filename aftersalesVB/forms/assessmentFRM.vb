Imports System.Data.SqlClient
Imports MetroFramework

Public Class assessmentFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Public id As String = ""
    Private Sub assessmentFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        refreshbtn.PerformClick()
    End Sub
    Private Sub loadtb()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String = "select * from assessmenttb order by item asc"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    assessmentGRID.Columns.Clear()
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "assessmenttb")
                        bs.DataSource = ds
                        bs.DataMember = "assessmenttb"
                        assessmentGRID.DataSource = bs
                        addbtn()
                        With assessmentGRID
                            .Columns("id").Visible = False
                            .Columns("chk").Visible = False
                        End With
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Private Sub addbtn()
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

        assessmentGRID.Columns.Insert(3, updatebtn)
        assessmentGRID.Columns.Insert(4, deletebtn)
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadtb()
    End Sub

    Private Sub assessmentGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles assessmentGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub assessmentFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newassessmentFRM.Text = "New"
        newassessmentFRM.save.Text = "add"
        newassessmentFRM.ShowDialog()
    End Sub

    Private Sub assessmentGRID_SelectionChanged(sender As Object, e As EventArgs) Handles assessmentGRID.SelectionChanged

    End Sub

    Private Sub assessmentGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles assessmentGRID.CellClick
        If assessmentGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = assessmentGRID.Rows(e.RowIndex)
            id = row.Cells("id").Value.ToString
            Select Case e.ColumnIndex
                Case 3
                    newassessmentFRM.item.Text = row.Cells("item").Value.ToString
                    newassessmentFRM.assessment.Text = row.Cells("assessment").Value.ToString
                    newassessmentFRM.Text = "Editing"
                    newassessmentFRM.save.Text = "save"
                    newassessmentFRM.ShowDialog()
                Case 4
                    If MetroMessageBox.Show(Me, "Confirm", "Delete this record?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                        Exit Sub
                    End If
                    execquery("DELETE FROM ASSESSMENTTB WHERE ID = @ID")
                    refreshbtn.PerformClick()
            End Select
        End If
    End Sub
    Private Sub execquery(ByVal QRY As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(QRY, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@ID", id)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class