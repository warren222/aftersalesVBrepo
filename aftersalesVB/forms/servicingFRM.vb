Imports System.Data.SqlClient

Public Class servicingFRM
    Dim sql As New sql
    Dim scount As String
    Dim suffix As String
    Public Shared id As String
    Dim bs As New BindingSource

    Private Sub servicingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadservicing()
    End Sub
    Public Sub loadservicing()
        Dim str As String = "select ID,
                            CIN,
                            STATUS,
                            STATUSDATE AS [STATUS DATE],
                            SERVICING,
                            SDATE AS [SERVICING DATE],
                            REMARKS
                            from servicingtb where cin = @cin ORDER BY SERVICING desc"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        servicingGRID.Columns.Clear()
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "servicingtb")
                        bs.DataSource = ds
                        bs.DataMember = "servicingtb"
                        servicingGRID.DataSource = bs
                        addbtn()
                        servicingGRID.Columns("STATUS DATE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        servicingGRID.Columns("SERVICING").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        servicingGRID.Columns("SERVICING DATE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        servicingGRID.Columns("REMARKS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        'servicingGRID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                        servicingGRID.Columns("id").Visible = False
                        servicingGRID.Columns("cin").Visible = False
                        servicingGRID.Columns("STATUS").Visible = False
                        servicingGRID.Columns("rd").Width = 100
                        servicingGRID.Columns("statusbtn").Width = 100
                        servicingGRID.Columns("reportbtn").Width = 100
                        servicingGRID.Columns("deletebtn").Width = 100
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using

            Dim str2 As String = "select isnull(count(id),0)+1 from servicingtb where cin = @cin"
            Using sqlcmd As SqlCommand = New SqlCommand(str2, sqlcon)
                sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                Using rd As SqlDataReader = sqlcmd.ExecuteReader
                    While rd.Read
                        scount = rd(0).ToString
                    End While
                End Using
            End Using
        End Using
        updatestatus()
    End Sub
    Public Sub updatestatus()
        Dim c As String = ""
        Dim str As String = "SELECT id , x=SUBSTRING(servicing, PATINDEX('%[0-9]%', servicing), PATINDEX('%[0-9][^0-9]%', servicing + 't') - PATINDEX('%[0-9]%', 
                                servicing) + 1)
					            FROM SERVICINGTB where cin = @cin order by x asc "
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            c = rd(0).ToString
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
            Dim STR2 As String = "
                                declare @status as varchar(100) = (select case when status is null then '' else status end from servicingtb where id  = @id)
                                update callintb set status = @status where cin = @cin
                                update callintb set status = '' where status is null"
            Using sqlcmd As SqlCommand = New SqlCommand(STR2, sqlcon)
                Try
                    sqlcmd.Parameters.AddWithValue("id", c)
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub addbtn()
        Dim statusbtn As New DataGridViewButtonColumn
        Dim reportbtn As New DataGridViewButtonColumn
        Dim rd As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn

        Dim prevreportbtn As New DataGridViewButtonColumn

        statusbtn.Name = "statusbtn"
        statusbtn.HeaderText = "STATUS"

        reportbtn.Name = "reportbtn"
        reportbtn.HeaderText = ""
        reportbtn.Text = "edit report"

        rd.Name = "rd"
        rd.HeaderText = ""
        rd.Text = "scanned report"

        deletebtn.Name = "deletebtn"
        deletebtn.HeaderText = ""
        deletebtn.Text = "delete"



        prevreportbtn.Name = "evabtn"
        prevreportbtn.HeaderText = ""
        prevreportbtn.Text = "report prev"

        statusbtn.UseColumnTextForButtonValue = False
        reportbtn.UseColumnTextForButtonValue = True
        rd.UseColumnTextForButtonValue = True
        deletebtn.UseColumnTextForButtonValue = True

        prevreportbtn.UseColumnTextForButtonValue = True
        servicingGRID.Columns.Insert(0, statusbtn)
        servicingGRID.Columns.Insert(8, reportbtn)
        servicingGRID.Columns.Insert(9, prevreportbtn)
        servicingGRID.Columns.Insert(10, rd)

        servicingGRID.Columns.Insert(11, deletebtn)


        For i As Integer = 0 To servicingGRID.RowCount - 1
            servicingGRID.Rows(i).Cells.Item(0).Value = servicingGRID.Item("STATUS", i).Value.ToString
        Next

    End Sub


    Public Sub suffixvalue()
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

    End Sub

    Private Sub servicingGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles servicingGRID.CellClick
        If servicingGRID.RowCount >= 0 And e.RowIndex >= 0 Then



            id = servicingGRID.Item("id", e.RowIndex).Value.ToString
            servicingdate.Text = servicingGRID.Item("servicing date", e.RowIndex).Value.ToString
            remarks.Text = servicingGRID.Item("REMARKS", e.RowIndex).Value.ToString
            If e.ColumnIndex = 0 Then
                statusFRM.source = "ServicingFRM"
                id = servicingGRID.Item("id", e.RowIndex).Value.ToString
                statusFRM.statusdate.Text = servicingGRID.Item("status date", e.RowIndex).Value.ToString
                statusFRM.status.Text = servicingGRID.Item("status", e.RowIndex).Value.ToString
                statusFRM.ShowDialog()
            ElseIf e.ColumnIndex = 8 Then
                id = servicingGRID.Item("id", e.RowIndex).Value.ToString
                reportFRM.servicing.Text = servicingGRID.Item("servicing", e.RowIndex).Value.ToString
                reportFRM.ShowDialog()
            ElseIf e.ColumnIndex = 9 Then
                id = servicingGRID.Item("id", e.RowIndex).Value.ToString
                loadreport()
            ElseIf e.ColumnIndex = 10 Then
                id = servicingGRID.Item("id", e.RowIndex).Value.ToString
                scannedreportFRM.id = servicingGRID.Item("servicing", e.RowIndex).Value.ToString
                scannedreportFRM.ShowDialog()
            ElseIf e.ColumnIndex = 11 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & servicingGRID.Item("servicing", e.RowIndex).Value.ToString & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    id = servicingGRID.Item("id", e.RowIndex).Value.ToString
                    Dim str As String = "delete from servicingtb where id  = @id"
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
                    refresh.PerformClick()
                End If
            End If
            End If
    End Sub
    Private Sub loadreport()
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
                    sqlcmd.Parameters.AddWithValue("@sid", id)
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
    Private Sub servicingFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'mainform.searchtext.CustomButton.PerformClick()
        Me.Dispose()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        loadservicing()
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub servicingGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles servicingGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        add()
    End Sub
    Public Sub add()
        Try
            Dim str As String = " declare @id as integer = (select isnull(max(id),0)+1 from servicingtb)

                                  declare @sss as integer  = (select isnull(max(id),0) from servicingtb where cin = @cin)
                                  update servicingtb set [status]='Reschedule',statusdate=@sdate where id = @sss
                                  insert into servicingtb (id,cin,servicing,sdate,remarks,status)values(@id,@cin,@servicing,@sdate,@remarks,'Scheduled')"

            Dim str2 As String = "select isnull(count(id),0)+1 from servicingtb where cin = @cin"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
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
                    sqlcmd.Parameters.AddWithValue("@remarks", remarks.Text)
                    sqlcmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            refresh.PerformClick()
        End Try
    End Sub
    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged
        servicingdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub MetroDateTime1_MouseDown(sender As Object, e As MouseEventArgs) Handles MetroDateTime1.MouseDown
        servicingdate.Text = MetroDateTime1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("save changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If
        updates()
    End Sub
    Public Sub updates()
        Dim str As String = "update servicingtb set sdate=@sdate,remarks=@remarks where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@sdate", servicingdate.Text)
                    sqlcmd.Parameters.AddWithValue("@remarks", remarks.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    refresh.PerformClick()
                End Try
            End Using
        End Using
    End Sub
End Class