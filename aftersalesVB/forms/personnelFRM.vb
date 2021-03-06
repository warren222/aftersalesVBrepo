﻿Imports System.Data.SqlClient
Public Class personnelFRM
    Dim SQL As New sql
    Dim bs As New BindingSource
    Dim ds As New DataSet
    Dim teambs As New BindingSource
    Public id As String
    Public Sub loadpersonnel()
        Dim str As String = "select DISTINCT ID,PERSONNEL,POSITION from personneltb where teamid = '' or teamid is null"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        personnelGRID.Columns.Clear()
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "personneltb")
                        bs.DataSource = ds
                        bs.DataMember = "personneltb"
                        personnelGRID.DataSource = bs
                        addbtn()
                        personnelGRID.Columns("ID").Visible = False
                        personnelGRID.Columns("PERSONNEL").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        personnelGRID.Columns("UPDATEBTN").Width = 70
                        personnelGRID.Columns("DELETEBTN").Width = 70
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using

    End Sub
    Public Sub addbtn()

        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn

        updatebtn.Name = "updatebtn"
        updatebtn.HeaderText = ""
        updatebtn.Text = "update"

        deletebtn.Name = "deletebtn"
        deletebtn.HeaderText = ""
        deletebtn.Text = "delete"

        updatebtn.UseColumnTextForButtonValue = True
        deletebtn.UseColumnTextForButtonValue = True

        personnelGRID.Columns.Insert(3, updatebtn)
        personnelGRID.Columns.Insert(4, deletebtn)
    End Sub
    Public Shared caller As String
    Private Sub personnelFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        teamgv.DataSource = teambs
        loadpersonnel()
        Button2.PerformClick()
    End Sub


    Private Sub personnelGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles personnelGRID.CellClick
        If personnelGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 3 Then
                id = personnelGRID.Item("id", e.RowIndex).Value.ToString
                editpersonnelFRM.PERSONNEL.Text = personnelGRID.Item("personnel", e.RowIndex).Value.ToString
                editpersonnelFRM.positions.Text = personnelGRID.Item("position", e.RowIndex).Value.ToString
                editpersonnelFRM.Text = "Editing"
                editpersonnelFRM.SAVE.Text = "save"
                editpersonnelFRM.ShowDialog()
            ElseIf e.ColumnIndex = 4 Then
                id = personnelGRID.Item("id", e.RowIndex).Value.ToString
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & personnelGRID.Item("personnel", e.RowIndex).Value.ToString & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    Dim str As String = "delete from personneltb where id = @id"
                    Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
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
        loadpersonnel()
    End Sub

    Private Sub personnelFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If caller = reportFRM.Name.ToString Then
            reportFRM.loadteam()
        End If
        Me.Dispose()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        editpersonnelFRM.PERSONNEL.Text = ""
        editpersonnelFRM.Text = "New"
        editpersonnelFRM.SAVE.Text = "add"
        editpersonnelFRM.ShowDialog()
    End Sub

    Private Sub personnelGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles personnelGRID.RowPostPaint
        SQL.rownum(sender, e)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "select ID,TEAM,DATED,STUFF((SELECT ' ,'+PERSONNEL+char(10) FROM PERSONNELTB WHERE TEAMID = A.ID FOR XML PATH('')),1,2,'') AS MEMBERS from teamtb AS A"
        ds = New DataSet
        ds.Clear()
        teamgv.Columns.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Using da As SqlDataAdapter = New SqlDataAdapter()
                        With da
                            .SelectCommand = sqlcmd
                            .SelectCommand.CommandTimeout = 30000
                            .Fill(ds, "teamtb")
                            teambs.DataSource = ds
                            teambs.DataMember = "teamtb"
                            teamgv.Columns("id").Visible = False
                        End With
                    End Using
                    Dim btn As New DataGridViewButtonColumn
                    With btn
                        .Name = "btn"
                        .HeaderText = ""
                        .Text = "EDIT MEMBERS"
                        .UseColumnTextForButtonValue = True
                    End With
                    teamgv.Columns.Insert(4, btn)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try

            End Using
        End Using
    End Sub


    Private Sub calldategen_MouseDown(sender As Object, e As MouseEventArgs) Handles calldategen.MouseDown
        teamdate.Text = calldategen.Text
    End Sub

    Private Sub calldategen_ValueChanged(sender As Object, e As EventArgs) Handles calldategen.ValueChanged
        teamdate.Text = calldategen.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "declare @id as integer = (select isnull(max(isnull(id,0)),0)+1 from teamtb)

                            insert into teamtb
                            (id,team,dated)values(@id,@team,@dated)"
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@team", team.Text)
                    sqlcmd.Parameters.AddWithValue("@dated", teamdate.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try

            End Using
        End Using
        Button2.PerformClick()
    End Sub
    Dim teamid As String
    Private Sub teamgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles teamgv.CellClick
        If teamgv.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim rows As DataGridViewRow = teamgv.Rows(e.RowIndex)
            teamid = rows.Cells("id").Value.ToString
            team.Text = rows.Cells("team").Value.ToString
            teamdate.Text = rows.Cells("dated").Value.ToString
            reportFRM.teamid = teamid
            If e.ColumnIndex = 4 Then
                memberFRM.teamid = rows.Cells("id").Value.ToString
                memberFRM.teamname.Text = rows.Cells("team").Value.ToString
                memberFRM.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "
                            update teamtb
                            set team=@team,dated=@dated where id = @id"
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(SQL.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", teamid)
                    sqlcmd.Parameters.AddWithValue("@team", team.Text)
                    sqlcmd.Parameters.AddWithValue("@dated", teamdate.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try

            End Using
        End Using

        team.Text = ""
        teamdate.Text = ""
        Button2.PerformClick()
    End Sub
End Class