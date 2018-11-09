Imports System.Data.SqlClient

Public Class partsFRM
    Dim sql As New sql
    Public id As String
    Private Sub partsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub partsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadparts()
    End Sub
    Public Sub loadparts()
        Dim str As String = "select * from partstb where iid = @iid"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@iid", itemFRM.id)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "PARTSTB")
                        partsGRID.DataSource = ds.Tables("PARTSTB")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadparts()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newpartsFRM.Text = "New"
        newpartsFRM.save.Text = "add"
        newpartsFRM.ShowDialog()
    End Sub
End Class