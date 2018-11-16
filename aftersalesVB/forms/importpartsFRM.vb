Imports System.Data.SqlClient
Public Class importpartsFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Private Sub importpartsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub importpartsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Bottom - 37
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, 0)
        loadsuggestion("specification", specification)
        loadsuggestion("description", description)
        loadsuggestion("articleno", articleno)
        save.PerformClick()
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
    Public Sub loadparts()
        Dim str As String = "select ID,
                            SPECIFICATION,
                            ARTICLENO as [ARTICLE NO],
                            DESCRIPTION,
                            UNIT,
                            UNITPRICE AS [UNIT PRICE],
                            REMARKS
                            from ACCESSORIESTB 
                            where 
                            description like @description and
                            articleno like @articleno and
                            specification like @specification"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        partsGRID.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@description", "%" & description.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@articleno", "%" & articleno.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@specification", "%" & specification.Text & "%")
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        bs.DataSource = ds
                        bs.DataMember = "ACCESSORIESTB"
                        partsGRID.DataSource = bs

                        With partsGRID
                            .Columns("ID").Visible = False
                            .Columns("UNIT PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("SPECIFICATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("ARTICLE NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("UNIT").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("REMARKS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub partsGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles partsGRID.CellClick
        If partsGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = partsGRID.Rows(e.RowIndex)
            newpartsFRM.articleno.Text = row.Cells("article no").Value.ToString
            newpartsFRM.description.Text = row.Cells("description").Value.ToString
            newpartsFRM.unitprice.Text = row.Cells("unit price").Value.ToString
        End If
    End Sub

    Private Sub partsGRID_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles partsGRID.CellDoubleClick
        Me.Close()
    End Sub

    Private Sub partsGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles partsGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        loadparts()
    End Sub
End Class