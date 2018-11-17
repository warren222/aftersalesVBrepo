Imports System.Data.SqlClient

Public Class newservicingFRM
    Dim SQL As New sql
    Dim scount As String
    Dim suffix As String
    Private Sub newservicingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadpersonnel()
        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black
        End If
        ccolor(servicingdate, clr)
        ccolor(assignedpersonnelTXT, clr)
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs) Handles metroTextButton1.Click
        If assignedpersonnelTXT.Text.Contains(personnel.Text) Then
            MessageBox.Show("Already exist")
        Else
            assignedpersonnelTXT.Text += " ," + personnel.Text
            If assignedpersonnelTXT.Text.Substring(0, 2) = " ," Then
                assignedpersonnelTXT.Text = Trim(assignedpersonnelTXT.Text.Remove(0, 2))
            End If
        End If
    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles MetroTextButton2.Click
        If Not personnel.Text = "" Then
            If assignedpersonnelTXT.Text.Contains(personnel.Text) Then
                assignedpersonnelTXT.Text = assignedpersonnelTXT.Text.Replace(personnel.Text, "")
            End If
            If assignedpersonnelTXT.Text.Length >= 2 Then
                If assignedpersonnelTXT.Text.Substring(0, 2) = " ," Then
                    assignedpersonnelTXT.Text = Trim(assignedpersonnelTXT.Text.Remove(0, 2))
                End If
                If assignedpersonnelTXT.Text.Substring(assignedpersonnelTXT.Text.Length - 2, 2) = " ," Then
                    assignedpersonnelTXT.Text = Trim(assignedpersonnelTXT.Text.Remove(assignedpersonnelTXT.Text.Length - 2, 2))
                End If
                If assignedpersonnelTXT.Text.Contains(", ,") Then
                    assignedpersonnelTXT.Text = Trim(assignedpersonnelTXT.Text.Replace(", ,", ","))
                End If
            End If
        End If
    End Sub
    Public Sub loadpersonnel()
        Dim str As String = "select * from personneltb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "personneltb")
                        personnel.DataSource = ds.Tables("personneltb")
                        personnel.DisplayMember = "personnel"
                        personnel.SelectedIndex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        servicingdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        servicingdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub newservicingFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            add()
        ElseIf save.Text = "save" Then
            update()
        End If
        servicingFRM.refresh.PerformClick()
    End Sub
    Public Sub add()
        Dim str As String = " declare @id as integer = (select isnull(max(id),0)+1 from servicingtb)
                              insert into servicingtb (id,cin,servicing,sdate,assignedpersonnel)values(@id,@cin,@servicing,@sdate,@assignedpersonnel)"
        Dim str2 As String = "select isnull(count(id),0)+1 from servicingtb where cin = @cin"
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str2, sqlcon)
                sqlcon.Open()
                sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                Using rd As SqlDataReader = sqlcmd.ExecuteReader
                    While rd.Read
                        scount = rd(0).ToString
                    End While
                End Using
            End Using
            Dim x As String
            Select Case scount
                Case 1
                    x = "st"
                Case 2
                    x = "nd"
                Case 3
                    x = "rd"
                Case Else
                    x = "th"
            End Select
            suffix = "" & scount & "" & x & " Servicing Schedule"

            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                sqlcmd.Parameters.AddWithValue("@servicing", suffix)
                sqlcmd.Parameters.AddWithValue("@sdate", servicingdate.Text)
                sqlcmd.Parameters.AddWithValue("@assignedpersonnel", assignedpersonnelTXT.Text)
                sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub update()
        Dim str As String = "update servicingtb set sdate=@sdate,assignedpersonnel=@assignedpersonnel where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", servicingFRM.id)
                    sqlcmd.Parameters.AddWithValue("@sdate", servicingdate.Text)
                    sqlcmd.Parameters.AddWithValue("@assignedpersonnel", assignedpersonnelTXT.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class