Imports System.Data.SqlClient
Public Class itemFRM
    Dim sql As New sql
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
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "itemtb")
                        itemGRID.DataSource = ds.Tables("itemtb")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
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
End Class