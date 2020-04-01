Imports System.Data.SqlClient
Imports MetroFramework
Imports System.ComponentModel

Public Class FRMpersonnel
    Dim bgw As New BackgroundWorker
    Dim sql As New sql
    Dim action As String
    Dim ds As New DataSet
    Dim bspersonnel As New BindingSource
    Dim bsteam As New BindingSource
    Dim bsmember As New BindingSource
    Dim _tb As String


    Dim _fullname As String
    Dim _position As String

    Dim _teamname As String

    Dim _mtid As String = ""
    Dim _mpid As String
    Dim _mid As String

    Dim bol(2) As Boolean
    Private Sub FRMpersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_ProgressChanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_RunWorkerCompleted
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        GVpersonnel.DataSource = bspersonnel
        GVteam.DataSource = bsteam
        GVmember.DataSource = bsmember

        For i As Integer = 0 To 1
            bol(i) = True
        Next

        btnpreload.PerformClick()
    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy Then
            action = act
            bgw.RunWorkerAsync()
        Else
            MessageBox.Show("i am busy, try again!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs)
        Select Case action
            Case "GET DATA"
                Select Case _tb
                    Case "TBLpersonnel"
                        With GVpersonnel
                            .Columns("PID").Visible = False
                        End With
                        autosizecolumns(GVpersonnel)
                    Case "TBLteam"
                        With GVteam
                            .Columns("TID").Visible = False
                        End With
                        autosizecolumns(GVteam)
                    Case "TBLteamMember"
                        With GVmember
                            .Columns("ID").Visible = False
                        End With
                        autosizecolumns(GVmember)
                End Select
            Case "ADD PERSONNEL"
                tboxfullname.Text = ""
                cboxposition.Text = ""
                starter("GET DATA")
            Case "UPDATE PERSONNEL"
                btnpcancel.PerformClick()
                starter("GET DATA")
            Case "DELETE PERSONNEL"
                starter("GET DATA")
            Case "ADD TEAM"
                tboxteamname.Text = ""
                starter("GET DATA")
            Case "UPDATE TEAM"
                btntcancel.PerformClick()
                starter("GET DATA")
            Case "DELETE TEAM"
                starter("GET DATA")
            Case "ADD MEMBER"
                starter("GET DATA")
            Case "DELETE MEMBER"
                starter("GET DATA")
        End Select
    End Sub
    Private Sub autosizecolumns(gv As DataGridView)
        For i As Integer = 0 To gv.ColumnCount - 1
            gv.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Next
    End Sub

    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "GET DATA"
                Select Case _tb
                    Case "TBLpersonnel"
                        bspersonnel.DataSource = ds
                        bspersonnel.DataMember = _tb
                    Case "TBLteam"
                        GVteam.Columns.Clear()
                        bsteam.DataSource = ds
                        bsteam.DataMember = _tb
                        addbtn()
                    Case "TBLteamMember"
                        bsmember.DataSource = ds
                        bsmember.DataMember = _tb
                End Select
        End Select
    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "GET DATA"
                If _tb = "TBLteamMember" Then
                    db(action, _tb, _mtid)
                Else
                    db(action, _tb, "")
                End If
                bgw.ReportProgress(0)
            Case "ADD PERSONNEL"
                Dim val As String = "values(@id,'" & _fullname & "','" & _position & "')"
                db(action, _tb, val)
            Case "UPDATE PERSONNEL"
                Dim val As String = "SET FULLNAME = '" & _fullname & "',POSITION = '" & _position & "' WHERE PID = '" & _pid & "'"
                db(action, _tb, val)
            Case "DELETE PERSONNEL"
                db(action, _tb, _pid)
            Case "ADD TEAM"
                Dim val As String = "values(@id,'" & _teamname & "')"
                db(action, _tb, val)
            Case "UPDATE TEAM"
                Dim val As String = "SET TEAMNAME = '" & _teamname & "' WHERE TID = '" & _tid & "'"
                db(action, _tb, val)
            Case "DELETE TEAM"
                db(action, _tb, _tid)

            Case "ADD MEMBER"
                Dim val As String = "values(@id,'" & _mtid & "','" & _mpid & "')"
                db(action, _tb, val)
            Case "DELETE MEMBER"
                db(action, _tb, _mid)
        End Select
    End Sub
    Private Sub addbtn()
        Dim btn As New DataGridViewButtonColumn
        With btn
            .Name = "btn"
            .Text = "edit members"
            .HeaderText = ""
            .UseColumnTextForButtonValue = True
        End With
        GVteam.Columns.Insert(2, btn)
    End Sub

    Private Sub btnpclick(sender As Object, e As EventArgs) Handles btnpreload.Click,
        btnpsave.Click,
        btnpdelete.Click,
        btnpcancel.Click,
        btnpedit.Click
        Select Case sender.name
            Case "btnpreload"
                _tb = "TBLpersonnel"
                starter("GET DATA")
            Case "btnpsave"
                Select Case btnpsave.Text
                    Case "save"
                        _fullname = tboxfullname.Text
                        _position = cboxposition.Text
                        _tb = "TBLpersonnel"
                        starter("UPDATE PERSONNEL")
                    Case "add"
                        _fullname = tboxfullname.Text
                        _position = cboxposition.Text
                        _tb = "TBLpersonnel"
                        starter("ADD PERSONNEL")
                End Select
            Case "btnpcancel"
                tboxfullname.Text = ""
                cboxposition.Text = ""
                btnpsave.Text = "add"
                btnpcancel.Visible = False
                GVpersonnel.Enabled = True
            Case "btnpedit"
                tboxfullname.Text = _fullname
                cboxposition.Text = _position
                btnpsave.Text = "save"
                btnpcancel.Visible = True
                GVpersonnel.Enabled = False
            Case "btnpdelete"
                If MessageBox.Show("Are you sure you want to delete this person's record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                _tb = "TBLpersonnel"
                starter("DELETE PERSONNEL")
        End Select
    End Sub
    Private Sub btntclick(sender As Object, e As EventArgs) Handles btntsave.Click,
        btntreload.Click, btntdelete.Click, btntcancel.Click, btntedit.Click
        Select Case sender.name
            Case "btntreload"
                _tb = "TBLteam"
                starter("GET DATA")
            Case "btntsave"
                Select Case btntsave.Text
                    Case "add"
                        _teamname = tboxteamname.Text
                        _tb = "TBLteam"
                        starter("ADD TEAM")
                    Case "save"
                        _teamname = tboxteamname.Text
                        _tb = "TBLteam"
                        starter("UPDATE TEAM")
                End Select
            Case "btntdelete"
                If MessageBox.Show("Are you sure you want to delete this team?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                _tb = "TBLteam"
                starter("DELETE TEAM")
            Case "btntcancel"
                tboxteamname.Text = ""
                btntsave.Text = "add"
                btntcancel.Visible = False
                GVteam.Enabled = True
            Case "btntedit"
                tboxteamname.Text = _teamname
                btntsave.Text = "save"
                btntcancel.Visible = True
                GVteam.Enabled = False
        End Select
    End Sub
    Private Sub db(ByVal command As String, ByVal tbl As String, ByVal val As String)
        Try
            ds = New DataSet
            ds.Clear()
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                    With sqlcmd
                        .CommandText = "[stpTeam]"
                        .CommandTimeout = 30000
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("command", command)
                        .Parameters.AddWithValue("tbl", tbl)
                        .Parameters.AddWithValue("val", val)
                    End With
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    With da
                        .SelectCommand = sqlcmd
                        .Fill(ds, tbl)
                    End With
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Dim _pid As String
    Dim _tid As String
    Private Sub GVpersonnel_SelectionChanged(sender As Object, e As EventArgs) Handles GVpersonnel.SelectionChanged,
         GVteam.SelectionChanged, GVmember.SelectionChanged
        Select Case sender.name
            Case "GVpersonnel"
                Dim rows As DataGridViewSelectedRowCollection = GVpersonnel.SelectedRows
                For Each row As DataGridViewRow In rows
                    _pid = row.Cells("pid").Value.ToString
                    _fullname = row.Cells("fullname").Value.ToString
                    _position = row.Cells("position").Value.ToString
                Next
            Case "GVteam"
                Dim rows As DataGridViewSelectedRowCollection = GVteam.SelectedRows
                For Each row As DataGridViewRow In rows
                    _tid = row.Cells("tid").Value.ToString
                    _teamname = row.Cells("teamname").Value.ToString
                Next
            Case "GVmember"
                Dim rows As DataGridViewSelectedRowCollection = GVmember.SelectedRows
                For Each row As DataGridViewRow In rows
                    _mid = row.Cells("ID").Value.ToString
                Next
        End Select
    End Sub

    Private Sub btnmlick(sender As Object, e As EventArgs) Handles btnmreload.Click, btnmsave.Click, btnmdelete.Click
        Select Case sender.name
            Case "btnmreload"
                If _mtid = "" Then
                Else
                    _tb = "TBLteamMember"
                    starter("GET DATA")
                End If
            Case "btnmsave"
                _mpid = cboxpersonnel.SelectedValue.ToString
                _tb = "TBLteamMember"
                starter("ADD MEMBER")
            Case "btnmdelete"
                If MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Exit Sub
                End If
                _tb = "TBLteamMember"
                starter("DELETE MEMBER")
        End Select
    End Sub

    Private Sub GVteam_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVteam.CellClick
        If GVteam.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = GVteam.Rows(e.RowIndex)
            Select Case e.ColumnIndex
                Case 2
                    _mtid = _tid
                    tboxteam.Text = row.Cells("teamname").Value.ToString
                    TabControl1.SelectedIndex = 2
                    btnmreload.PerformClick()
            End Select
        End If
    End Sub

    Private Sub cboxpersonnel_MouseDown(sender As Object, e As MouseEventArgs) Handles cboxpersonnel.MouseDown
        Try
            Dim str As String = "select pid,fullname from TBLpersonnel
where not pid in (select pid from TBLteamMember where tid = '" & _mtid & "')"
            Dim ds As New DataSet
            ds.Clear()
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                sqlcon.Open()
                Dim da As SqlDataAdapter = New SqlDataAdapter(str, sqlcon)
                da.Fill(ds, "TBLpersonnel")
                cboxpersonnel.DataSource = ds.Tables("TBLpersonnel")
                cboxpersonnel.ValueMember = "PID"
                cboxpersonnel.DisplayMember = "FULLNAME"
                cboxpersonnel.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                If bol(0) = True Then
                    btnpreload.PerformClick()
                    bol(0) = False
                End If
            Case 1
                If bol(1) = True Then
                    btntreload.PerformClick()
                    bol(1) = False
                End If
        End Select
    End Sub

    Private Sub GVpersonnel_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles GVpersonnel.RowPostPaint, GVteam.RowPostPaint, GVmember.RowPostPaint
        sql.rownum(sender, e)
    End Sub
End Class