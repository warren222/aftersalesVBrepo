Imports System.Data.SqlClient
Public Class reportFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim teambs As New BindingSource

    Public id As String = ""
    Public Shared teamid As String
    Private Sub reportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportGRID.DataSource = bs
        teamgv.DataSource = teambs
        loadreport()
        loadeva()
        loadteam()
    End Sub
    Private Sub loadeva()
        Dim str As String = "select evaluation,completion from evaluationtb where sid = @sid"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            EVALUATION.Text = rd(0).ToString
                            dated.Text = rd(1).ToString
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
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
                            .Columns("kno").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("itemno").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("location").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("specification").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("mobilizationcost").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
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
        reportGRID.Columns.Insert(7, assessmentbtn)
        reportGRID.Columns.Insert(8, updatebtn)
        reportGRID.Columns.Insert(9, deletebtn)
    End Sub

    Private Sub reportFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If reloadbol = True Then
            servicingFRM.refresh.PerformClick()
        End If
        Me.Dispose()
    End Sub

    Private Sub reportGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles reportGRID.CellClick
        If reportGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            id = reportGRID.Item("id", e.RowIndex).Value.ToString
            If e.ColumnIndex = 7 Then
                'reportassessmentFRM.ShowDialog()
                Dim a As String = reportGRID.Item("kno", e.RowIndex).Value.ToString
                Dim b As String = reportGRID.Item("itemno", e.RowIndex).Value.ToString()
                Dim c As String = reportGRID.Item("specification", e.RowIndex).Value.ToString()
                Dim d As String = reportGRID.Item("location", e.RowIndex).Value.ToString
                assessmentreportingFRM.kno = c + " / " + a + " / " + b + " / " + d

                assessmentreportingFRM.Show()
            ElseIf e.ColumnIndex = 8 Then
                newreportFRM.mobilization.Text = reportGRID.Item("mobilizationcost", e.RowIndex).Value.ToString
                newreportFRM.locations.Text = reportGRID.Item("location", e.RowIndex).Value.ToString
                newreportFRM.specification.Text = reportGRID.Item("specification", e.RowIndex).Value.ToString
                newreportFRM.KNO.Text = reportGRID.Item("kno", e.RowIndex).Value.ToString
                newreportFRM.itemno.Text = reportGRID.Item("itemno", e.RowIndex).Value.ToString
                newreportFRM.Text = "Editing"
                newreportFRM.save.Text = "save"
                newreportFRM.ShowDialog()
            ElseIf e.ColumnIndex = 9 Then
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
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(DS.ASSESSMENTTB)
                    ServicingRPTfrm.ASSESSMENTTBBindingSource.DataSource = DS.ASSESSMENTTB.DefaultView
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    ServicingRPTfrm.Show()
                End Try
            End Using
        End Using
    End Sub
    Private Sub calldategen_MouseDown(sender As Object, e As MouseEventArgs) Handles calldategen.MouseDown, calldategen.ValueChanged
        dated.Text = calldategen.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show("save changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        EVALUATION.Text = EVALUATION.Text.Replace("'", "`")
        UPDATESUB()
    End Sub
    Private Sub UPDATESUB()
        Dim STR As String = "

DECLARE @SID AS VARCHAR(100) = '" & servicingFRM.id & "'
DECLARE @COMPLETION AS VARCHAR(max) = '" & dated.Text & "'
DECLARE @EVALUATION AS VARCHAR(max) = '" & EVALUATION.Text & "'
DECLARE @COUNT AS INTEGER = (SELECT COUNT(ISNULL(ID,0)) FROM EVALUATIONTB WHERE SID = @SID)


DECLARE @QRY AS VARCHAR(MAX)
				SET @QRY=
				(
				CASE WHEN @COUNT >0 THEN
				'UPDATE EVALUATIONTB SET EVALUATION = '''+@EVALUATION+''', COMPLETION = '''+@COMPLETION+''' WHERE SID = '''+@SID+''''
				ELSE

				'DECLARE @ID AS INTEGER = (SELECT ISNULL(MAX(ISNULL(ID,0)),0)+1 FROM EVALUATIONTB)
				INSERT INTO EVALUATIONTB (ID,SID,EVALUATION,COMPLETION)VALUES(@ID,'''+@SID+''','''+@EVALUATION+''','''+@COMPLETION+''')'
				END
				)

				EXEC(@QRY)
"
        Using SQLCON As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using SQLCMD As SqlCommand = New SqlCommand(STR, SQLCON)
                Try
                    SQLCON.Open()
                    SQLCMD.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    MessageBox.Show("evaluation saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        personnelFRM.caller = Me.Name.ToString
        personnelFRM.Show()
    End Sub
    Public Sub loadteam()
        Dim ds As New DataSet
        ds.Clear
        Dim str As String = "
select a.id,personnel,position,TEAMID,b.TEAM from PERSONNELTB as a
left join TEAMTB as b
on a.TEAMID = b.ID where a.teamid=@teamid"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid)
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "personneltb")
                    teambs.DataSource = ds
                    teambs.DataMember = "personneltb"
                    With teamgv
                        .Columns("id").Visible = False
                        .Columns("teamid").Visible = False
                        .Columns("team").Visible = False
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                    End With
                    teamgv.ClearSelection()
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows = True Then
                            With rd.Read
                                KryptonLabel1.Text = rd(4).ToString
                            End With
                            rd.Close()
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally

                End Try
            End Using
        End Using
    End Sub
    Dim reloadbol As Boolean = False
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "update servicingtb set teamid=@teamid where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@teamid", teamid)
                    sqlcmd.Parameters.AddWithValue("@id", servicingFRM.id)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    MessageBox.Show("team saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    reloadbol = True
                End Try
            End Using
        End Using
    End Sub
End Class