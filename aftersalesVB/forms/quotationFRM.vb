Imports System.Data.SqlClient
Public Class quotationFRM
    Dim sql As New sql
    Public id As String
    Public aseno As String
    Private Sub quotationFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub quotationFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadquotation()
    End Sub
    Public Sub loadquotation()
        Dim str As String = "select ID,
                             CIN,
                             ASENO,
                             QDATE as [DATE],
                             OTHERCHARGES
                             from quotationtb where cin = @cin"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        quGRID.Columns.Clear()
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                        da.Fill(ds, "quotationtb")
                        quGRID.DataSource = ds.Tables("quotationtb")
                        addcolumns()
                        With quGRID
                            .Columns("ID").Visible = False
                            .Columns("CIN").Visible = False
                            .Columns("OTHERCHARGES").Visible = False
                        End With
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
        Dim itembtn As New DataGridViewButtonColumn
        With updatebtn
            .Text = "update"
            .Name = "updatebtn"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .Text = "delete"
            .Name = "deletebtn"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With itembtn
            .Text = "item"
            .Name = "itembtn"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With quGRID
            .Columns.Insert(5, updatebtn)
            .Columns.Insert(6, deletebtn)
            .Columns.Insert(7, itembtn)
        End With
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newquFRM.Text = "New"
        newquFRM.save.Text = "add"
        newquFRM.ShowDialog()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        loadquotation()
    End Sub

    Private Sub quGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles quGRID.CellClick
        If quGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 5 Then
                id = quGRID.Item("id", e.RowIndex).Value.ToString
                newquFRM.qudate.Text = quGRID.Item("date", e.RowIndex).Value.ToString
                newquFRM.aseno.Text = quGRID.Item("aseno", e.RowIndex).Value.ToString
                newquFRM.Text = "Editing"
                newquFRM.save.Text = "save"
                newquFRM.ShowDialog()
            ElseIf e.ColumnIndex = 6 Then
                id = quGRID.Item("id", e.RowIndex).Value.ToString
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & quGRID.Item("aseno", e.RowIndex).Value.ToString & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    Dim str As String = "delete from quotationtb where id = @id"
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
                    loadquotation()
                End If
            ElseIf e.ColumnIndex = 7 Then
                aseno = quGRID.Item("ASENO", e.RowIndex).Value.ToString
                itemFRM.Text = quGRID.Item("ASENO", e.RowIndex).Value.ToString
                itemFRM.ShowDialog()
            End If
        End If
    End Sub
End Class