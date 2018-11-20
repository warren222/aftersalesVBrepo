Imports System.Data.SqlClient
Public Class newquFRM
    Dim sql As New sql
    Public tempaseno As String
    Private Sub newquFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If Not IsNumeric(othercharges.Text) Then
            Return
            MetroFramework.MetroMessageBox.Show(Me, "", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If save.Text = "add" Then
            add()
            quotationFRM.refreshBTN.PerformClick()
        ElseIf save.Text = "save" Then
            update()
            quotationFRM.refreshBTN.PerformClick()
        End If
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from quotationtb)
                             insert into quotationtb (id,cin,aseno,qdate,othercharges)values(@id,@cin,@aseno,@qdate,@othercharges)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@aseno", aseno.Text)
                    sqlcmd.Parameters.AddWithValue("@qdate", qudate.Text)
                    sqlcmd.Parameters.AddWithValue("@othercharges", othercharges.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim dup As Boolean
        Dim find As String = "select * from quotationtb where not id = @id and aseno = @aseno"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(find, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", quotationFRM.id)
                    sqlcmd.Parameters.AddWithValue("@aseno", aseno.Text)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows = True Then
                            dup = True
                        Else
                            dup = False
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        If dup = True Then
            MetroFramework.MetroMessageBox.Show(Me, "Duplicate ASENO detected!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim str As String = "
                            update itemtb set aseno = @aseno where aseno = @tempaseno
                            update quotationtb set aseno=@aseno,qdate=@qdate,othercharges=@othercharges where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", quotationFRM.id)
                    sqlcmd.Parameters.AddWithValue("@aseno", aseno.Text)
                    sqlcmd.Parameters.AddWithValue("@tempaseno", tempaseno)
                    sqlcmd.Parameters.AddWithValue("@qdate", qudate.Text)
                    sqlcmd.Parameters.AddWithValue("@othercharges", othercharges.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        qudate.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        qudate.Text = MetroDateTime1.Text
    End Sub

    Private Sub newquFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black
        End If
        ccolor(qudate, clr)
        ccolor(aseno, clr)
        ccolor(othercharges, clr)
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
End Class