﻿Imports System.Data.SqlClient

Public Class servicingFRM
    Dim sql As New sql
    Dim scount As String
    Dim suffix As String
    Public id As String
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
                            ASSIGNEDPERSONNEL AS [ASSIGNED PERSONNEL],
                            teamid
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
                        servicingGRID.Columns("ASSIGNED PERSONNEL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        servicingGRID.Columns("id").Visible = False
                        servicingGRID.Columns("cin").Visible = False
                        servicingGRID.Columns("STATUS").Visible = False
                        servicingGRID.Columns("teamid").Visible = False
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
        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn

        statusbtn.Name = "statusbtn"
        statusbtn.HeaderText = "STATUS"

        reportbtn.Name = "reportbtn"
        reportbtn.HeaderText = ""
        reportbtn.Text = "report"

        rd.Name = "rd"
        rd.HeaderText = ""
        rd.Text = "scanned report"

        updatebtn.Name = "updatebtn"
        updatebtn.HeaderText = ""
        updatebtn.Text = "update"

        deletebtn.Name = "deletebtn"
        deletebtn.HeaderText = ""
        deletebtn.Text = "delete"

        statusbtn.UseColumnTextForButtonValue = False
        reportbtn.UseColumnTextForButtonValue = True
        rd.UseColumnTextForButtonValue = True
        updatebtn.UseColumnTextForButtonValue = True
        deletebtn.UseColumnTextForButtonValue = True

        servicingGRID.Columns.Insert(0, statusbtn)
        servicingGRID.Columns.Insert(8, reportbtn)
        servicingGRID.Columns.Insert(9, rd)
        servicingGRID.Columns.Insert(10, updatebtn)
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

            If e.ColumnIndex = 0 Then
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
                scannedreportFRM.id = servicingGRID.Item("servicing", e.RowIndex).Value.ToString
                scannedreportFRM.ShowDialog()
            ElseIf e.ColumnIndex = 10 Then
                newservicingFRM.loadteam()
                newservicingFRM.Text = "Editing"
                newservicingFRM.save.Text = "save"
                id = servicingGRID.Item("id", e.RowIndex).Value.ToString
                newservicingFRM.servicingdate.Text = servicingGRID.Item("servicing date", e.RowIndex).Value.ToString
                newservicingFRM.TEAM.Text = servicingGRID.Item("ASSIGNED PERSONNEL", e.RowIndex).Value.ToString
                newservicingFRM.teamid.Text = servicingGRID.Item("teamid", e.RowIndex).Value.ToString
                newservicingFRM.ShowDialog()
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

    Private Sub servicingFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'mainform.searchtext.CustomButton.PerformClick()
        Me.Dispose()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        loadservicing()
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newservicingFRM.loadteam()
        newservicingFRM.Text = "New"
        newservicingFRM.save.Text = "add"
        newservicingFRM.servicingdate.Text = ""
        newservicingFRM.ShowDialog()
    End Sub

    Private Sub servicingGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles servicingGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub
End Class