Imports System.Data.SqlClient
Public Class accessoriesFRM
    Dim sql As New sql
    Public id As String
    Dim bs As New BindingSource
    Private Sub accessoriesFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub refreshBTN_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        loadaccessories()
    End Sub
    Public Sub loadsuggestion(ByVal col As String, ByVal od As Object)
        Dim str As String = "select distinct " & col & " from ACCESSORIESTB order by " & col & " asc"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        od.datasource = ds.Tables("ACCESSORIESTB")
                        od.displaymember = "" & col & ""
                        od.selectedindex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub loadaccessories()
        Dim str As String = "select ID,
                            SPECIFICATION,
                            ARTICLENO,
                            DESCRIPTION,
                            UNIT,
                            UNITPRICE as [UNIT PRICE],
                            REMARKS
                            from accessoriestb
                            where 
                            description like @description and
                            articleno like @articleno and
                            specification like @specification
"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        accessoriesGRID.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@description", "%" & description.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@articleno", "%" & articleno.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@specification", "%" & specification.Text & "%")
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "accessoriestb")
                        bs.DataSource = ds
                        bs.DataMember = "accessoriestb"
                        accessoriesGRID.DataSource = bs
                        addbuttons()
                        With accessoriesGRID
                            .Columns("id").Visible = False
                            .Columns("SPECIFICATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("ARTICLENO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("UNIT").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("UNIT PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("REMARKS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using

    End Sub
    Public Sub addbuttons()
        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn
        With updatebtn
            .Name = "updatebtn"
            .Text = "update"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .Name = "deletebtn"
            .Text = "delete"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        With accessoriesGRID
            .Columns.Insert(7, updatebtn)
            .Columns.Insert(8, deletebtn)
        End With
    End Sub
    Private Sub accessoriesFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cc()
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        refreshBTN.PerformClick()
    End Sub
    Public Sub cc()
        loadsuggestion("specification", specification)
        loadsuggestion("description", description)
        loadsuggestion("articleno", articleno)
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newaccessoriesFRM.Text = "New"
        newaccessoriesFRM.save.Text = "add"
        newaccessoriesFRM.ShowDialog()
    End Sub

    Private Sub accessoriesGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles accessoriesGRID.CellClick
        If accessoriesGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = accessoriesGRID.Rows(e.RowIndex)
            If e.ColumnIndex = 7 Then
                id = row.Cells("id").Value.ToString
                newaccessoriesFRM.specification.Text = row.Cells("specification").Value.ToString
                newaccessoriesFRM.articleno.Text = row.Cells("articleno").Value.ToString
                newaccessoriesFRM.description.Text = row.Cells("description").Value.ToString
                newaccessoriesFRM.unit.Text = row.Cells("unit").Value.ToString
                newaccessoriesFRM.unitprice.Text = row.Cells("unit price").Value.ToString
                newaccessoriesFRM.remarks.Text = row.Cells("remarks").Value.ToString
                newaccessoriesFRM.Text = "Editing"
                newaccessoriesFRM.save.Text = "save"
                newaccessoriesFRM.ShowDialog()
            ElseIf e.ColumnIndex = 8 Then
                id = row.Cells("id").Value.ToString
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & row.Cells("articleno").Value.ToString & "", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    Dim str As String = "delete from accessoriestb where id = @id"
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
                End If
                refreshBTN.PerformClick()
            End If
        End If
    End Sub

    Private Sub accessoriesGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles accessoriesGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        loadaccessories()
    End Sub
End Class