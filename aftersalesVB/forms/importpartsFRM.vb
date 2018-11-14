Imports System.Data.SqlClient
Public Class importpartsFRM
    Dim sql As New sql
    Private Sub importpartsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub importpartsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Bottom - 37
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, 0)
        loadparts()
    End Sub
    Public Sub loadparts()
        Dim str As String = "select * from ACCESSORIESTB"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        partsGRID.Columns.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        partsGRID.DataSource = ds.Tables("ACCESSORIESTB")
                        partsGRID.Columns("ID").Visible = False

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
            newpartsFRM.articleno.Text = row.Cells("articleno").Value.ToString
            newpartsFRM.description.Text = row.Cells("description").Value.ToString
            newpartsFRM.unitprice.Text = row.Cells("unitprice").Value.ToString
        End If
    End Sub
End Class