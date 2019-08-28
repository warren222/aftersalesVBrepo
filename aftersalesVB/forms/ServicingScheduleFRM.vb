Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit

Public Class ServicingScheduleFRM
    Dim bgw As New BackgroundWorker
    Dim sql As New sql
    Dim action As String
    Public gv As New KryptonDataGridView
    Dim ds As New DataSet
    Public bs As New BindingSource
    Dim sm As New sharedmethods
    Private Sub ServicingScheduleFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True

        gv.DataSource = bs
        sm.ServicingScheduleFRMinitialize()
    End Sub

    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "LOAD SCHEDULE"
                starter("FORMAT SCHEDULE")
            Case "FORMAT SCHEDULE"

        End Select
    End Sub

    Private Sub bgw_progresschanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "LOAD SCHEDULE"
                bs.DataSource = ds
                bs.DataMember = "servicingtb"
                If Not gvpnl.Controls.Contains(gv) Then
                    gvpnl.Controls.Add(gv)
                End If
            Case "FORMAT SCHEDULE"
                With gv
                    .Columns("project").Width = 150
                    .Columns("address").Width = 250
                    .Columns("date").Width = 100
                    .Columns("remarks").Width = 200
                    .Columns("SERVICING").Width = 200
                    '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                End With
        End Select
    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "LOAD SCHEDULE"
                queries("LOAD SCHEDULE")
                bgw.ReportProgress(0)
            Case "FORMAT SCHEDULE"
                bgw.ReportProgress(0)
        End Select
    End Sub

    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            bgw.RunWorkerAsync()
        Else
            MsgBox("busy")
        End If
    End Sub
    Private Sub queries(ByVal command As String)
        ds = New DataSet
        Dim sdate As String = DateTimePicker1.Text
        Dim edate As String = DateTimePicker2.Text
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                With sqlcmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Servicing_Schedule_queries]"
                    .Parameters.AddWithValue("@command", command)
                    .Parameters.AddWithValue("@sdate", sdate)
                    .Parameters.AddWithValue("@edate", edate)

                End With
                Using da As SqlDataAdapter = New SqlDataAdapter
                    With da
                        .SelectCommand = sqlcmd
                        .SelectCommand.CommandTimeout = 30000
                        .Fill(ds, "servicingtb")
                    End With
                End Using
            End Using
        End Using
    End Sub

    Private Sub ServicingScheduleFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        starter("LOAD SCHEDULE")
    End Sub
End Class