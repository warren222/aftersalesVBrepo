Imports System.Data.SqlClient
Public Class itemFRM
    Dim sql As New sql
    Public id As String
    Private Sub itemFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaditems()
    End Sub
    Public Sub loaditems()
        Dim str As String = "select * from itemtb where aseno = @aseno"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        itemGRID.Columns.Clear()
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "itemtb")
                        itemGRID.DataSource = ds.Tables("itemtb")
                        addcolumns()
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

        With updatebtn
            .Text = "update"
            .HeaderText = ""
            .Name = "updtebtn"
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .Text = "delete"
            .HeaderText = ""
            .Name = "deletebtn"
            .UseColumnTextForButtonValue = True
        End With
        With itemGRID
            .Columns.Insert(9, updatebtn)
            .Columns.Insert(10, deletebtn)
        End With
    End Sub

    Private Sub itemFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loaditems()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newitemFRM.Text = "New"
        newitemFRM.save.Text = "add"
        newitemFRM.ShowDialog()
    End Sub
    Private Sub itemGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles itemGRID.CellClick
        If itemGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 9 Then
                id = itemGRID.Item("id", e.RowIndex).Value.ToString
                newitemFRM.kno.Text = itemGRID.Item("kno", e.RowIndex).Value.ToString
                newitemFRM.itemno.Text = itemGRID.Item("item", e.RowIndex).Value.ToString
                newitemFRM.wdwloc.Text = itemGRID.Item("wdwloc", e.RowIndex).Value.ToString
                newitemFRM.parts.Text = itemGRID.Item("parts", e.RowIndex).Value.ToString
                newitemFRM.unitprice.Text = itemGRID.Item("unitprice", e.RowIndex).Value.ToString
                newitemFRM.qty.Text = itemGRID.Item("qty", e.RowIndex).Value.ToString
                newitemFRM.netamount.Text = itemGRID.Item("netprice", e.RowIndex).Value.ToString
                newitemFRM.Text = "Editing"
                newitemFRM.save.Text = "save"
                newitemFRM.ShowDialog()
            ElseIf e.ColumnIndex = 10 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & itemGRID.Item("kno", e.RowIndex).Value.ToString & "", "Confirmatioon", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                    Return
                Else
                    id = itemGRID.Item("id", e.RowIndex).Value.ToString
                    Dim str As String = "delete from itemtb where id = @id"
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
                    loaditems()
                End If
            End If
        End If
    End Sub
End Class