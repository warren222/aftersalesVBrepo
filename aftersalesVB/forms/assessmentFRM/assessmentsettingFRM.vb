Imports System.ComponentModel
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

    Private Sub assessmentsettingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gv.DataSource = bs
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

    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
            Case "ADD SYSTEM"
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
        End Select
    End Sub
    Dim systemval As String
    Dim partsval As String
    Dim categoryval As String
    Dim OTHERSYSTEMVAL As String
    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
                queries("LOAD SYSTEM", vbNull)
                bgw.ReportProgress(0)
            Case "ADD SYSTEM"
                Dim VAL As String = "'" & systemval & "','" & partsval & "','" & categoryval & "','" & OTHERSYSTEMVAL & "'"
                queries("ADD SYSTEM", VAL)
        End Select
    End Sub
    Private Sub queries(ByVal command As String, ByVal val As String)
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                With sqlcmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[SYSTEM_queries]"
                    .Parameters.AddWithValue("@command", command)
                    .Parameters.AddWithValue("@val", val)
                    .Parameters.AddWithValue("@system", systemval)
                End With
                Using da As SqlDataAdapter = New SqlDataAdapter
                    With da
                        .SelectCommand = sqlcmd
                        .SelectCommand.CommandTimeout = 30000
                        .Fill(ds, "SYSTEMTB")
                    End With
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
        partsbol = True
        categorybol = True
        PARTSTXT.SelectedIndex = -1
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Dim partsbol As Boolean = True
    Dim categorybol As Boolean = True

    Private Sub PARTSTXT_MouseDown(sender As Object, e As MouseEventArgs) Handles PARTSTXT.MouseDown, CATEGORYTXT.MouseDown, OTHERSYSTEMTXT.MouseDown
        Select Case sender.name
            Case "OTHERSYSTEMTXT"

                Dim str As String = "select Distinct othersystem from systemtb where system = '" & SYSTEMTXT.Text & "'"
                LOADDROPDOWNVAL(str, OTHERSYSTEMTXT, "OTHERSYSTEM")

            Case "PARTSTXT"
                If partsbol = True Then
                    Dim str As String = ""
                    If SYSTEMTXT.Text = "INSECT PROTECTION SYSTEM" Then
                        str = "select Distinct parts from systemtb where system = '" & SYSTEMTXT.Text & "' and othersystem = '" & OTHERSYSTEMTXT.Text & "'"
                    Else
                        str = "select Distinct parts from systemtb where system = '" & SYSTEMTXT.Text & "'"
                    End If
                    LOADDROPDOWNVAL(str, PARTSTXT, "parts")
                End If
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
                                partsbol = True
                                categorybol = True
                            End If
                        Case "PARTSTXT"
                            partsbol = False
                            categorybol = True
                        Case "CATEGORYTXT"
                            categorybol = False
                    End Select
                End Try
            End Using
        End Using
    End Sub
End Class