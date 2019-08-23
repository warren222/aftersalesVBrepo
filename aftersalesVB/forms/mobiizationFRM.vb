Imports System.Data.SqlClient
Public Class mobiizationFRM
    Dim sql As New sql
    Dim ds As New DataSet
    Dim bs As New BindingSource
    Dim da As SqlDataAdapter
    Public id As String
    Private Sub mobiizationFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mobGRID.DataSource = bs
        refreshbtn.PerformClick()
    End Sub
    Private Sub loaddata()
        Dim str As String = "   select 
 B.ID      
,C.TEAM
      ,b.[DATED]
      ,[PLATENO]
      ,[SMILEAGE]
      ,[EMILEAGE]
      ,[TOLLFEE]
      ,[BUSFARE]
      ,[AIRFARE]
      ,[MEALS]
      ,[OVERTIME]
      ,b.teamid
	  
	  from  MOBILIZATIONTB as b
	  left join TEAMTB as c 
	  on b.teamid = c.id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    ds = New DataSet
                    ds.Clear()
                    da = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "mobilizationtb")
                    bs.DataSource = ds
                    bs.DataMember = "mobilizationtb"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        loadteam()
    End Sub
    Private Sub loadteam()
        Dim bsb As New BindingSource
        Dim str As String = "
select * into #tbsb from (select max(DATED) as dated,TEAM from teamtb group by TEAM) as tb
select dated,team, (select id from teamtb where dated = tb.dated and team = tb.team) as id from #tbsb as tb"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    ds = New DataSet
                    ds.Clear()
                    da = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "tb")
                    bsb.DataSource = ds
                    bsb.DataMember = "tb"
                    teamcombo.DataSource = bsb
                    teamcombo.DisplayMember = "team"
                    teamid.DataBindings.Clear()
                    teamid.DataBindings.Add("text", bsb, "id")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addone()
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loaddata()
    End Sub
    Private Sub addone()
        Dim str As String = "
declare @id as integer =  (select isnull(max(isnull(id,0)),0)+1 from mobilizationtb)

insert into mobilizationtb
(ID
,DATED
,PLATENO
,SMILEAGE
,EMILEAGE
,TOLLFEE
,BUSFARE
,AIRFARE
,MEALS
,OVERTIME
,teamid
)values
(@id
,@dated
,@plateno
,@SMILEAGE
,@EMILEAGE
,@TOLLFEE
,@BUSFARE
,@AIRFARE
,@MEALS
,@OVERTIME
,@teamid)
"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@dated", dated.Text)
                    sqlcmd.Parameters.AddWithValue("@plateno", plateno.Text)
                    sqlcmd.Parameters.AddWithValue("@SMILEAGE", smileage.Text)
                    sqlcmd.Parameters.AddWithValue("@EMILEAGE", emileage.Text)
                    sqlcmd.Parameters.AddWithValue("@TOLLFEE", tollfee.Text)
                    sqlcmd.Parameters.AddWithValue("@BUSFARE", busfare.Text)
                    sqlcmd.Parameters.AddWithValue("@AIRFARE", airfare.Text)
                    sqlcmd.Parameters.AddWithValue("@MEALS", meals.Text)
                    sqlcmd.Parameters.AddWithValue("@overtime", overtime.Text)
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        loaddata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
            Exit Sub
        End If
        updateone()
    End Sub
    Private Sub updateone()
        Dim str As String = "
update mobilizationtb
set 
DATED=@dated
,PLATENO=@plateno
,SMILEAGE=@sMILEAGE
,EMILEAGE=@eMILEAGE
,TOLLFEE=@TOLLFEE
,BUSFARE=@BUSFARE
,AIRFARE=@AIRFARE
,MEALS=@MEALS
,OVERTIME=@OVERTIME
,TEAMID=@teamid
where id = @id
"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(Str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@dated", dated.Text)
                    sqlcmd.Parameters.AddWithValue("@plateno", plateno.Text)
                    sqlcmd.Parameters.AddWithValue("@SMILEAGE", smileage.Text)
                    sqlcmd.Parameters.AddWithValue("@EMILEAGE", emileage.Text)
                    sqlcmd.Parameters.AddWithValue("@TOLLFEE", tollfee.Text)
                    sqlcmd.Parameters.AddWithValue("@BUSFARE", busfare.Text)
                    sqlcmd.Parameters.AddWithValue("@AIRFARE", airfare.Text)
                    sqlcmd.Parameters.AddWithValue("@MEALS", meals.Text)
                    sqlcmd.Parameters.AddWithValue("@overtime", overtime.Text)
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        loaddata()
    End Sub

    Private Sub mobGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mobGRID.CellClick
        If mobGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim ROWS As DataGridViewRow = mobGRID.Rows(e.RowIndex)
            id = ROWS.Cells("id").Value.ToString
            dated.Text = ROWS.Cells("dated").Value.ToString
            plateno.Text = ROWS.Cells("plateno").Value.ToString
            smileage.Text = ROWS.Cells("SMILEAGE").Value.ToString
            emileage.Text = ROWS.Cells("EMILEAGE").Value.ToString
            tollfee.Text = ROWS.Cells("TOLLFEE").Value.ToString
            busfare.Text = ROWS.Cells("BUSFARE").Value.ToString
            airfare.Text = ROWS.Cells("AIRFARE").Value.ToString
            meals.Text = ROWS.Cells("MEALS").Value.ToString
            overtime.Text = ROWS.Cells("overtime").Value.ToString
            teamcombo.Text = ROWS.Cells("team").Value.ToString
            teamid.Text = ROWS.Cells("teamid").Value.ToString
        End If
    End Sub

    Private Sub calldategen_MouseDown(sender As Object, e As MouseEventArgs) Handles calldategen.MouseDown
        dated.Text = calldategen.Text
    End Sub

    Private Sub calldategen_ValueChanged(sender As Object, e As EventArgs) Handles calldategen.ValueChanged
        dated.Text = calldategen.Text
    End Sub

    Private Sub insertbtn_Click(sender As Object, e As EventArgs) Handles insertbtn.Click
        Dim str As String = "
                            declare @id as integer = (select isnull(max(isnull(id,0)),0)+1 from relmobser)
                            insert into relmobser (id,mobid,serid)values(@id,@mobid,@serid)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Try
                sqlcon.Open()
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    With sqlcmd
                        .Parameters.AddWithValue("@serid", servicingFRM.id)
                        .Parameters.AddWithValue("@mobid", id)
                    End With
                    sqlcmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                reportFRM.Button3.PerformClick()
                If MessageBox.Show("Action completed
do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.Close()
                Else
                End If
            End Try
        End Using

    End Sub
End Class