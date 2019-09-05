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
    Dim tempcin As String = mainform.tempcin
    Public id As String
    Private Sub ServicingScheduleFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True

        gv.DataSource = bs
        sm.ServicingScheduleFRMinitialize()
        Button1.PerformClick()
    End Sub
    Private Sub cellclick()
        Dim rows As DataGridViewSelectedRowCollection = gv.SelectedRows
        For Each row As DataGridViewRow In rows
            mainform.tempcin = row.Cells("cin").Value.ToString
            servicingFRM.projectname.Text = row.Cells("project").Value.ToString
            servicingFRM.address.Text = row.Cells("address").Value.ToString
            servicingFRM.jo.Text = row.Cells("jo").Value.ToString
            servicingFRM.KryptonLabel3.Text = row.Cells("cin").Value.ToString
            id = row.Cells("id").Value.ToString
            statusFRM.statusdate.Text = row.Cells("status date").Value.ToString
            statusFRM.status.Text = row.Cells("status").Value.ToString
            servicingFRM.id = row.Cells("id").Value.ToString
            reportFRM.servicing.Text = row.Cells("servicing").Value.ToString
        Next
    End Sub


    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "LOAD SCHEDULE"
                starter("FORMAT SCHEDULE")
            Case "FORMAT SCHEDULE"
                For i As Integer = 0 To gv.RowCount - 1
                    With gv
                        .Rows(i).Cells("date").Style.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                    End With
                Next
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
                    .Columns("project").Width = 200
                    .Columns("address").Width = 250
                    .Columns("date").Width = 100
                    .Columns("remarks").Width = 200
                    .Columns("SERVICING").Width = 150
                    .Columns("cin").Width = 100
                    .Columns("id").Visible = False
                    .Columns("status date").Visible = False
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
        If donecheckbox.Checked = False Then
            sdate = Date.MinValue
            edate = Date.MaxValue
        End If
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                With sqlcmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[Servicing_Schedule_queries]"
                    .Parameters.AddWithValue("@command", command)
                    .Parameters.AddWithValue("@sdate", sdate)
                    .Parameters.AddWithValue("@edate", edate)
                    .Parameters.AddWithValue("@project", project.Text)
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
        mainform.tempcin = tempcin
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        starter("LOAD SCHEDULE")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cellclick()
        servicingFRM.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cellclick()
        statusFRM.source = "ServicingScheduleFRM"
        statusFRM.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cellclick()
        reportFRM.ShowDialog()
    End Sub
End Class