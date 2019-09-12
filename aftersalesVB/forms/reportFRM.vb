Imports System.Data.SqlClient
Public Class reportFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim bs1 As New BindingSource
    Dim bs2 As New BindingSource
    Public id As String = ""
    Private Sub reportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportGRID.DataSource = bs
        mobgv.DataSource = bs1
        teamgv.DataSource = bs2
        Button3.PerformClick()
        loadreport()
    End Sub
    Public Sub loadreport()
        Dim str As String = "select * from reporttb where sid = @sid"
        Dim ds As New DataSet
        ds.clear
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        reportGRID.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reporttb")
                        bs.DataSource = ds
                        bs.DataMember = "reporttb"

                        addcolumns()
                        With reportGRID
                            .Columns("id").Visible = False
                            .Columns("sid").Visible = False
                            .Columns("location").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("specification").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub addcolumns()
        Dim assessmentbtn As New DataGridViewButtonColumn
        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn
        With assessmentbtn
            .Name = "assessmentbtn"
            .HeaderText = ""
            .Text = "assessment"
            .UseColumnTextForButtonValue = True
        End With
        With updatebtn
            .Name = "updatebtn"
            .HeaderText = ""
            .Text = "update"
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .Name = "deletebtn"
            .HeaderText = ""
            .Text = "delete"
            .UseColumnTextForButtonValue = True
        End With
        reportGRID.Columns.Insert(6, assessmentbtn)
        reportGRID.Columns.Insert(7, updatebtn)
        reportGRID.Columns.Insert(8, deletebtn)
    End Sub

    Private Sub reportFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub reportGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles reportGRID.CellClick
        If reportGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            id = reportGRID.Item("id", e.RowIndex).Value.ToString
            If e.ColumnIndex = 6 Then
                'reportassessmentFRM.ShowDialog()
                Dim a As String = reportGRID.Item("kno", e.RowIndex).Value.ToString
                Dim b As String = reportGRID.Item("itemno", e.RowIndex).Value.ToString()
                Dim c As String = reportGRID.Item("specification", e.RowIndex).Value.ToString()
                Dim d As String = reportGRID.Item("location", e.RowIndex).Value.ToString
                assessmentreportingFRM.kno = c + " / " + a + " / " + b + " / " + d

                assessmentreportingFRM.Show()
            ElseIf e.ColumnIndex = 7 Then
                newreportFRM.locations.Text = reportGRID.Item("location", e.RowIndex).Value.ToString
                newreportFRM.specification.Text = reportGRID.Item("specification", e.RowIndex).Value.ToString
                newreportFRM.KNO.Text = reportGRID.Item("kno", e.RowIndex).Value.ToString
                newreportFRM.itemno.Text = reportGRID.Item("itemno", e.RowIndex).Value.ToString
                newreportFRM.Text = "Editing"
                newreportFRM.save.Text = "save"
                newreportFRM.ShowDialog()
            ElseIf e.ColumnIndex = 8 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete selected report?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    Dim str As String = "delete from reporttb where id = @id"
                    Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                        Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                            Try
                                sqlcon.Open()
                                sqlcmd.Parameters.AddWithValue("@id", id)
                                sqlcmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End Using
                    End Using
                    refreshbtn.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadreport()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newreportFRM.locations.Text = ""
        newreportFRM.specification.Text = ""
        newreportFRM.Text = "New"
        newreportFRM.save.Text = "add"
        newreportFRM.ShowDialog()
    End Sub

    Private Sub reportGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles reportGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub reportGRID_SelectionChanged(sender As Object, e As EventArgs) Handles reportGRID.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = reportGRID.SelectedRows
        For Each row As DataGridViewRow In rows
            id = row.Cells("id").Value.ToString
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "
SELECT A.ID,[SPECIFICATION],[KNO],[ITEMNO],[LOCATION],B.[SYSTEM],'  **  '+PARTS+' '+isnull(color,'')+''+'  >>>  '+QUALITYASPECT+'  >>  '+POSSIBLEISSUE+'  >  '+POSSIBLESOLUTION AS ASSESSMENT
FROM [REPORTTB] as a 
INNER JOIN [ASSESSMENTREPORTTB] AS B
ON A.ID=B.RID WHERE B.[SYSTEM] = 'Framing System' and a.[SID] = @sid
union all
select A.ID,[SPECIFICATION],[KNO],[ITEMNO],[LOCATION],B.[SYSTEM],'  *** '+OTHERSYSTEM + '  **  '+PARTS+'  *  '+CATEGORY+'  >>>  '+QUALITYASPECT+'  >>  '+POSSIBLEISSUE+'  >  '+POSSIBLESOLUTION AS ASSESSMENT
FROM [REPORTTB] as a 
INNER JOIN [ASSESSMENTREPORTTB] AS B
ON A.ID=B.RID WHERE B.[SYSTEM] = 'Insect Protection System' and a.[SID] = @sid
union all
select A.ID,[SPECIFICATION],[KNO],[ITEMNO],[LOCATION],B.[SYSTEM],'  **  '+PARTS+'  *  '+CATEGORY+'  >>>  '+QUALITYASPECT+'  >>  '+POSSIBLEISSUE+'  >  '+POSSIBLESOLUTION AS ASSESSMENT
FROM [REPORTTB] as a 
INNER JOIN [ASSESSMENTREPORTTB] AS B
ON A.ID=B.RID WHERE not B.[SYSTEM] = 'Insect Protection System' and not B.[SYSTEM] = 'Framing System' and a.[SID] = @sid
"
        Dim DS As New asdbDS
        DS.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                    Console.WriteLine(servicingFRM.id)
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(DS.ASSESSMENTTB)
                    ServicingRPTfrm.ASSESSMENTTBBindingSource.DataSource = DS.ASSESSMENTTB.DefaultView
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        ServicingRPTfrm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mobiizationFRM.insertbtn.Visible = True
        mobiizationFRM.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "
       select a.id
      ,TEAM
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
	  
	  from (RELMOBSER as a
	  inner join MOBILIZATIONTB as b
	  on a.MOBID=b.ID)
	  left join TEAMTB as c 
	  on b.teamid = c.id
	  where a.serid = @sid"
        Dim DS As New DataSet
        DS.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(Str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(DS, "relmobser")
                    bs1.DataSource = DS
                    bs1.DataMember = "relmobser"
                    With mobgv
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                        .Columns("id").Visible = False
                        .Columns("teamid").Visible = False
                    End With
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using

    End Sub
    Private Sub loadteam()
        Dim str As String = "
        select PERSONNEL,POSITION from PERSONNELTB where TEAMID = @teamid "
        Dim DS As New DataSet
        DS.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid)
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(DS, "PERSONNELTB")
                    bs2.DataSource = DS
                    bs2.DataMember = "PERSONNELTB"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Dim teamid As String
    Dim mobid As String
    Private Sub mobgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles mobgv.CellClick
        If mobgv.RowCount >= 0 And e.RowIndex >= 0 Then
            teamid = mobgv.Item("teamid", e.RowIndex).Value.ToString
            mobid = mobgv.Item("id", e.RowIndex).Value.ToString
            KryptonLabel2.Text = mobgv.Item("team", e.RowIndex).Value.ToString
            loadteam()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("delete record", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If
        Try
            Dim str As String = "delete from relmobser where id = @id"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", mobid)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Button3.PerformClick()
        End Try
    End Sub
End Class