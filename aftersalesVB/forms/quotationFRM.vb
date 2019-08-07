Imports System.Data.SqlClient
Public Class quotationFRM
    Dim sql As New sql
    Public id As String
    Public aseno As String
    Public ase As String
    Public d As String
    Public oth As String
    Dim bs As New BindingSource

    Private Sub quotationFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub quotationFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadquotation()
    End Sub
    Public Sub loadquotation()
        Dim str As String = "select ID,
                             CIN,
                             ASENO,
                             QDATE as [DATE],
                             OTHERCHARGES as [OTHER CHARGES],
                             PARTICULAR,ACCEPTED
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
                        bs.DataSource = ds
                        bs.DataMember = "quotationtb"
                        quGRID.DataSource = bs

                        addcolumns()
                        With quGRID
                            .Columns("ID").Visible = False
                            .Columns("CIN").Visible = False
                            .Columns("ACCEPTED").Visible = False
                            .Columns("other charges").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("other charges").DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub addcolumns()
        Dim acceptedbtn As New DataGridViewButtonColumn
        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn
        Dim itembtn As New DataGridViewButtonColumn
        Dim prevbtn As New DataGridViewButtonColumn
        With acceptedbtn
            .Text = "accepted"
            .Name = "acceptedbtn"
            .HeaderText = "ACCEPTED"
            .UseColumnTextForButtonValue = False
        End With
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
            .Text = "items"
            .Name = "itembtn"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With prevbtn
            .Text = "preview"
            .Name = "prevbtn"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With quGRID
            .Columns.Insert(0, acceptedbtn)
            .Columns.Insert(7, itembtn)
            .Columns.Insert(8, prevbtn)
            .Columns.Insert(9, updatebtn)
            .Columns.Insert(10, deletebtn)
        End With

        For i As Integer = 0 To quGRID.RowCount - 1
            quGRID.Rows(i).Cells.Item(0).Value = quGRID.Item("accepted", i).Value.ToString
        Next
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
            id = quGRID.Item("id", e.RowIndex).Value.ToString
            If e.ColumnIndex = 0 Then
                quotationstatusFRM.ShowDialog()
            ElseIf e.ColumnIndex = 9 Then
                newquFRM.aseno.Enabled = False
                newquFRM.qudate.Text = quGRID.Item("date", e.RowIndex).Value.ToString
                newquFRM.aseno.Text = quGRID.Item("aseno", e.RowIndex).Value.ToString
                newquFRM.tempaseno = quGRID.Item("aseno", e.RowIndex).Value.ToString
                newquFRM.particular.Text = quGRID.Item("PARTICULAR", e.RowIndex).Value.ToString
                newquFRM.othercharges.Text = quGRID.Item("other charges", e.RowIndex).Value.ToString
                newquFRM.Text = "Editing"
                newquFRM.save.Text = "save"
                newquFRM.ShowDialog()
            ElseIf e.ColumnIndex = 8 Then
                d = quGRID.Item("date", e.RowIndex).Value.ToString
                ase = quGRID.Item("aseno", e.RowIndex).Value.ToString
                oth = quGRID.Item("other charges", e.RowIndex).Value.ToString
                prevFRM.ShowDialog()
            ElseIf e.ColumnIndex = 10 Then

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
                itemFRM.KryptonLabel7.Text = quGRID.Item("ASENO", e.RowIndex).Value.ToString
                itemFRM.ShowDialog()
            End If
        End If
    End Sub

    Private Sub quGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles quGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub
End Class