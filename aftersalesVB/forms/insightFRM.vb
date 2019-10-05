Imports System.ComponentModel
Imports System.Data.SqlClient
Imports ComponentFactory.Krypton.Toolkit

Public Class insightFRM
    Dim sm As New sharedmethods
    Dim bgw As New BackgroundWorker
    Dim sql As New sql
    Dim action As String
    Public gv As New KryptonDataGridView
    Dim ds As New DataSet
    Public bs As New BindingSource

    Private Sub insightFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler bgw.DoWork, AddressOf bgw_dowork
        AddHandler bgw.ProgressChanged, AddressOf bgw_progresschanged
        AddHandler bgw.RunWorkerCompleted, AddressOf bgw_completed
        bgw.WorkerSupportsCancellation = True
        bgw.WorkerReportsProgress = True
        gv.DataSource = bs
        sm.insightinitialized()
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

            Case "LOAD PARTS"
                If systemtype = "INSECT PROTECTION SYSTEM" Then
                    gv.Columns("othersystem").Visible = True
                Else
                    gv.Columns("othersystem").Visible = False
                End If
                If systemtype = "FRAMING SYSTEM" Then
                    gv.Columns("CATEGORY").Visible = False
                Else
                    gv.Columns("CATEGORY").Visible = True
                End If
            Case "LOAD ISSUE"

        End Select

        If action = "LOAD SYSTEM" Or action = "LOAD PARTS" Or action = "LOAD ISSUE" Then
            gv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            gv.Columns("reports").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            gv.SelectAll()
            Dim rows As DataGridViewSelectedRowCollection = gv.SelectedRows
            Dim a As Integer
            For Each row As DataGridViewRow In rows
                a += Integer.Parse(Replace(row.Cells("reports").Value.ToString, ",", ""))
            Next
            totalvalue.Text = a
            gv.ClearSelection()
        End If

    End Sub

    Private Sub bgw_progresschanged(sender As Object, e As ProgressChangedEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
                gv.Columns.Clear()
                bs.DataSource = ds
                bs.DataMember = "SYSTEMTB"
                If Not Panel7.Controls.Contains(gv) Then
                    Panel7.Controls.Add(gv)
                End If
            Case "LOAD PARTS"
                gv.Columns.Clear()
                bs.DataSource = ds
                bs.DataMember = "SYSTEMTB"
                If Not Panel7.Controls.Contains(gv) Then
                    Panel7.Controls.Add(gv)
                End If
            Case "LOAD ISSUE"
                gv.Columns.Clear()
                bs.DataSource = ds
                bs.DataMember = "SYSTEMTB"
                If Not Panel7.Controls.Contains(gv) Then
                    Panel7.Controls.Add(gv)
                End If
        End Select


    End Sub

    Public Sub gv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If gv.RowCount >= 0 And e.RowIndex >= 0 Then
            Select Case gvdata
                Case "gv"
                    gvdata = "gv2"
                    starter("LOAD PARTS")
                Case "gv2"
                    gvdata = "gv3"
                    starter("LOAD ISSUE")
            End Select
        End If
    End Sub

    Public Sub gv_SelectionChanged(sender As Object, e As EventArgs)
        Dim rows As DataGridViewSelectedRowCollection = gv.SelectedRows
        For Each row As DataGridViewRow In rows

            Select Case gvdata
                Case "gv"
                    systemtype = row.Cells("system").Value.ToString
                    systemparts = ""
                    systemcategory = ""
                Case "gv2"
                    systemparts = row.Cells("parts").Value.ToString
                    systemcategory = row.Cells("category").Value.ToString
                Case "gv3"
            End Select

            Dim a As String = systemtype
            Dim b As String = systemparts
            Dim c As String = systemcategory
            Dim d As String
            Select Case gvdata
                Case "gv2"
                    d = a
                Case "gv3"
                    d = a + " > " + b + " > " + c
                Case Else
                    d = ""
            End Select
            descriptiontxt.Text = d
        Next

    End Sub

    Private Sub bgw_dowork(sender As Object, e As DoWorkEventArgs)
        Select Case action
            Case "LOAD SYSTEM"
                queries("LOAD SYSTEM")
                bgw.ReportProgress(0)
            Case "LOAD PARTS"
                queries("LOAD PARTS")
                bgw.ReportProgress(0)
            Case "LOAD ISSUE"
                queries("LOAD ISSUE")
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim gvdata As String
    Dim systemtype As String = ""
    Dim systemparts As String = ""
    Dim systemcategory As String = ""
    Private Sub queries(ByVal command As String)
        ds = New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = sqlcon.CreateCommand
                sqlcon.Open()
                With sqlcmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "[insightFRM_QUERIES]"
                    .Parameters.AddWithValue("@command", command)
                    .Parameters.AddWithValue("@system", systemtype)
                    .Parameters.AddWithValue("@PARTS", systemparts)
                    .Parameters.AddWithValue("@category", systemcategory)
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case gvdata
            Case "gv"
                gvdata = "gv"
                starter("LOAD SYSTEM")
            Case "gv2"
                gvdata = "gv"
                starter("LOAD SYSTEM")
            Case "gv3"
                gvdata = "gv2"
                starter("LOAD PARTS")
            Case Else
                gvdata = "gv"
                starter("LOAD SYSTEM")
        End Select

    End Sub

    Private Sub insightFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class