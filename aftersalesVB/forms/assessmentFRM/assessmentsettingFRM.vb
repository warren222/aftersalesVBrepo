﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit

Public Class assessmentsettingFRM
    Dim bgw As New BackgroundWorker
    Dim sql As New sql
    Dim action As String
    Public gv As New KryptonDataGridView
    Dim ds As New DataSet
    Public bs As New BindingSource
    Dim sm As New sharedmethods

    Public gv2 As New KryptonDataGridView
    Dim bs2 As New BindingSource
    Private Sub assessmentsettingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gv.DataSource = bs
        gv2.DataSource = bs2
        sm.assessmentsettingFRMinitialize()
        SYSTEMTXT.SelectedIndex = 0
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            bgw.RunWorkerAsync()
        Else
            MsgBox("busy")
        End If
    End Sub
    Dim id As String

    Public Sub gv_SelectionChanged(sender As Object, e As EventArgs)
        Dim rows As DataGridViewSelectedRowCollection = gv.SelectedRows
        For Each row As DataGridViewRow In rows
            id = row.Cells("id").Value.ToString
        Next
    End Sub

    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
                starter("FORMAT SYSTEM")
            Case "ADD SYSTEM"
                systemval = SYSTEMTXT.Text
                starter("LOAD SYSTEM")
            Case "ADD ASSESSMENT"
                systemval = SYSTEMTXT.Text
                starter("LOAD ASSESSMENT")
            Case "DELETE SYSTEM"
                systemval = SYSTEMTXT.Text
                starter("LOAD SYSTEM")
        End Select
    End Sub

    Private Sub bgw_progresschanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
                bs.DataSource = ds
                bs.DataMember = "SYSTEMTB"
                If Not Panel2.Controls.Contains(gv) Then
                    Panel2.Controls.Add(gv)
                End If
            Case "LOAD ASSESSMENT"
                bs2.DataSource = ds
                bs2.DataMember = "ASSESSMENTTB"
                If Not Panel3.Controls.Contains(gv2) Then
                    Panel3.Controls.Add(gv2)
                End If
            Case "FORMAT SYSTEM"
                With gv
                    .Columns("id").Visible = False
                    .Columns("system").Visible = False
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                End With
        End Select
    End Sub
    Dim systemval As String
    Dim partsval As String
    Dim categoryval As String
    Dim OTHERSYSTEMVAL As String

    Dim qualityaspectVAL As String
    Dim possibleissueVAL As String
    Dim posibblesolutionVAL As String
    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
                queries("LOAD SYSTEM", vbNull)
                bgw.ReportProgress(0)
            Case "ADD SYSTEM"
                Dim VAL As String = "'" & systemval & "','" & partsval & "','" & categoryval & "','" & OTHERSYSTEMVAL & "'"
                queries("ADD SYSTEM", VAL)
            Case "DELETE SYSTEM"
                queries("DELETE SYSTEM", id)
            Case "FORMAT SYSTEM"
                bgw.ReportProgress(0)
            Case "LOAD ASSESSMENT"
                queries("LOAD ASSESSMENT", vbNull)
                bgw.ReportProgress(0)
            Case "ADD ASSESSMENT"
                Dim VAL As String = "'" & systemval & "','" & qualityaspectVAL & "','" & possibleissueVAL & "','" & posibblesolutionVAL & "'"
                queries("ADD ASSESSMENT", VAL)
        End Select
    End Sub
    Private Sub queries(ByVal command As String, ByVal val As String)
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                With sqlcmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[SYSTEM_queries]"
                    .Parameters.AddWithValue("@command", command)
                    .Parameters.AddWithValue("@val", val)
                    .Parameters.AddWithValue("@system", systemval)
                End With
                Using da As SqlDataAdapter = New SqlDataAdapter
                    If command = "LOAD SYSTEM" Then
                        With da
                            .SelectCommand = sqlcmd
                            .SelectCommand.CommandTimeout = 30000
                            .Fill(ds, "SYSTEMTB")
                        End With
                    ElseIf command = "LOAD ASSESSMENT" Then
                        With da
                            .SelectCommand = sqlcmd
                            .SelectCommand.CommandTimeout = 30000
                            .Fill(ds, "assessmenttb")
                        End With
                    Else
                        sqlcmd.ExecuteNonQuery()
                    End If

                End Using
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        systemval = SYSTEMTXT.Text
        starter("LOAD SYSTEM")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        systemval = SYSTEMTXT.Text
        partsval = PARTSTXT.Text
        categoryval = CATEGORYTXT.Text
        OTHERSYSTEMVAL = OTHERSYSTEMTXT.Text
        starter("ADD SYSTEM")
    End Sub

    Private Sub SYSTEMTXT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SYSTEMTXT.SelectedIndexChanged
        Button2.PerformClick()
        categorybol = True
        CATEGORYTXT.SelectedIndex = -1
        OTHERSYSTEMTXT.SelectedIndex = -1
        Select Case SYSTEMTXT.Text
            Case "FRAMING SYSTEM"
                Label2.Visible = False
                CATEGORYTXT.Text = ""
                CATEGORYTXT.Visible = False
                Label4.Visible = False
                OTHERSYSTEMTXT.Text = ""
                OTHERSYSTEMTXT.Visible = False
            Case "GLAZING SYSTEM"
                Label2.Text = "Glass Specs"
                Label2.Visible = True
                CATEGORYTXT.Visible = True
                Label4.Visible = False
                OTHERSYSTEMTXT.Text = ""
                OTHERSYSTEMTXT.Visible = False
            Case "MECHANISM"
                Label2.Text = "Hardware"
                Label2.Visible = True
                CATEGORYTXT.Visible = True
                Label4.Visible = False
                OTHERSYSTEMTXT.Text = ""
                OTHERSYSTEMTXT.Visible = False
            Case "WEATHER TIGHTNESS"
                Label2.Text = "Seals"
                Label2.Visible = True
                CATEGORYTXT.Visible = True
                Label4.Visible = False
                OTHERSYSTEMTXT.Text = ""
                OTHERSYSTEMTXT.Visible = False
            Case "INSECT PROTECTION SYSTEM"
                Label2.Text = "Insect Screens"
                Label2.Visible = True
                CATEGORYTXT.Visible = True
                Label4.Visible = True
                OTHERSYSTEMTXT.Visible = True
        End Select
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Dim categorybol As Boolean = True

    Private Sub PARTSTXT_MouseDown(sender As Object, e As MouseEventArgs) Handles CATEGORYTXT.MouseDown, OTHERSYSTEMTXT.MouseDown
        Select Case sender.name
            Case "OTHERSYSTEMTXT"
                Dim str As String = "select Distinct othersystem from systemtb where system = '" & SYSTEMTXT.Text & "'"
                LOADDROPDOWNVAL(str, OTHERSYSTEMTXT, "OTHERSYSTEM")
            Case "CATEGORYTXT"
                If categorybol = True Then
                    Dim str As String = "select distinct category from  systemtb where system = '" & SYSTEMTXT.Text & "'"
                    LOADDROPDOWNVAL(str, CATEGORYTXT, "category")
                End If
        End Select
    End Sub
    Private Sub LOADDROPDOWNVAL(ByVal COMMAND As String, ByVal obj As Object, ByVal datamember As String)
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(COMMAND, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "systemtb")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    obj.DataSource = ds.Tables("systemtb")
                    obj.DisplayMember = datamember
                    Select Case obj.name
                        Case "OTHERSYSTEMTXT"
                            If SYSTEMTXT.Text = "INSECT PROTECTION SYSTEM" Then
                                categorybol = True
                            End If
                        Case "CATEGORYTXT"
                            categorybol = False
                    End Select
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        starter("DELETE SYSTEM")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        systemval = SYSTEMTXT.Text
        starter("LOAD ASSESSMENT")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        qualityaspectVAL = qualityaspect.Text
        possibleissueVAL = possibleissue.Text
        posibblesolutionVAL = posibblesolution.Text
        starter("ADD ASSESSMENT")
    End Sub
End Class