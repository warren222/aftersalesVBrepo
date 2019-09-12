Imports System.Data.SqlClient
Public Class newassessmentFRM
    Dim SQL As New sql
    Dim str As String = ""
    Public Shared bol As Boolean = False

    Private Sub newassessmentFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Select Case save.Text
            Case "add"
                str = "
                        declare @newid as integer = (select isnull(max(id),0)+1 from assessmenttb)
                        insert into assessmenttb (id,item,assessment)values(@newid,@item,@assessment)"
                saved()
            Case "save"
                str = "update assessmenttb set item=@item,assessment = @assessment where id = @id"
                saved()
        End Select
        Select Case bol
            Case True

            Case False
                assessmentFRM.refreshbtn.PerformClick()
        End Select

    End Sub
    Private Sub saved()
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", assessmentFRM.id)
                    sqlcmd.Parameters.AddWithValue("@item", item.Text)
                    sqlcmd.Parameters.AddWithValue("@assessment", assessment.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newassessmentFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black
        End If
        ccolor(item, clr)
        ccolor(assessment, clr)
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
End Class