Imports System.Data.SqlClient
Public Class newreportFRM
    Dim sql As New sql
    Private Sub newreportFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            add()
        ElseIf save.Text = "save" Then
            update()
        End If
        reportFRM.refreshbtn.PerformClick()
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from reporttb)
                             insert into reporttb (id,[sid],location,specification,assessment)values(@id,@sid,@location,@specification,@assessment)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                    sqlcmd.Parameters.AddWithValue("@location", location.Text)
                    sqlcmd.Parameters.AddWithValue("@specification", specification.Text)
                    sqlcmd.Parameters.AddWithValue("@assessment", assessment.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim str As String = "update reporttb set location=@location,specification=@specification,assessment=@assessment where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", reportFRM.id)
                    sqlcmd.Parameters.AddWithValue("@location", location.Text)
                    sqlcmd.Parameters.AddWithValue("@specification", specification.Text)
                    sqlcmd.Parameters.AddWithValue("@assessment", assessment.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newreportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black
        End If
        ccolor(specification, clr)
        ccolor(location, clr)
        ccolor(assessment, clr)
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
    Public Sub loadlocation()
        Dim str As String = "select distinct location from reporttb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reporttb")
                        location.DataSource = ds.Tables("reporttb")
                        location.DisplayMember = "location"
                        location.SelectedIndex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub loadspecification()
        Dim str As String = "select distinct specification from reporttb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reporttb")
                        specification.DataSource = ds.Tables("reporttb")
                        specification.DisplayMember = "specification"
                        specification.SelectedIndex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
End Class