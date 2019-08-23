Imports System.Data.SqlClient

Public Class newservicingFRM
    Dim SQL As New sql
    Dim scount As String
    Dim suffix As String
    Private Sub newservicingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
        Else
            clr = Color.Black

        End If
        ccolor(servicingdate, clr)
        ccolor(TEAM, clr)

    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub




    Public Sub loadteam()
        Dim str As String = "select * into #tbsb from (select max(DATED) as dated,TEAM from teamtb group by TEAM) as tb
select dated,team, (select id from teamtb where dated = tb.dated and team = tb.team) as id from #tbsb as tb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "tb")
                        TEAM.DataSource = ds.Tables("tb")
                        TEAM.DisplayMember = "TEAM"
                        'TEAM.SelectedIndex = -1

                        teamid.DataBindings.Clear()
                        teamid.DataBindings.Add("text", ds.Tables("tb"), "id")

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
                              insert into servicingtb (id,cin,servicing,sdate,assignedpersonnel,teamid)values(@id,@cin,@servicing,@sdate,@team,@teamid)"
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
                sqlcmd.Parameters.AddWithValue("@team", TEAM.Text)
                sqlcmd.Parameters.AddWithValue("@teamid", teamid.Text)
                sqlcmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub update()
        Dim str As String = "update servicingtb set sdate=@sdate,assignedpersonnel=@team,teamid=@teamid where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", servicingFRM.id)
                    sqlcmd.Parameters.AddWithValue("@sdate", servicingdate.Text)
                    sqlcmd.Parameters.AddWithValue("@team", TEAM.Text)
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub TEAM_MouseDown(sender As Object, e As MouseEventArgs) Handles TEAM.MouseDown

    End Sub
End Class