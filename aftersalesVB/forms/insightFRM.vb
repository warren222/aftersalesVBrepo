Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
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
        sm.insightinitialized()
        yr.Text = Today.Year
        gv.DataSource = bs

    End Sub
    Private Sub starter(ByVal act As String)
        If Not bgw.IsBusy = True Then
            action = act
            yrtxt = yr.Text
            bgw.RunWorkerAsync()
        Else
            MsgBox("busy")
        End If
    End Sub
    Dim cstyle As SeriesChartType
    Private Sub bgw_completed(sender As Object, e As RunWorkerCompletedEventArgs)

        Select Case action
            Case "LOAD SYSTEM"
                cstyle = SeriesChartType.StackedBar
                XVAL = "SYSTEM"
                TITLETXT = "SYSTEM CHART"
                starter("LOAD CHART")
            Case "LOAD PARTS"
                If systemtype = "INSECT PROTECTION SYSTEM" Then
                    gv.Columns("SCREEN SYSTEM").Visible = True
                Else
                    gv.Columns("SCREEN SYSTEM").Visible = False
                End If
                If systemtype = "FRAMING SYSTEM" Then
                    gv.Columns("CATEGORY").Visible = False
                Else
                    gv.Columns("CATEGORY").Visible = True
                End If
            Case "LOAD ISSUE"
                cstyle = SeriesChartType.Pyramid
                gv.Columns("PISSUE").Visible = False
                XVAL = "PISSUE"
                TITLETXT = "TOP ISSUE CHART"
                starter("LOAD CHART")
            Case "LOAD SOLUTION"
                cstyle = SeriesChartType.Pie
                XVAL = "SOLUTION"
                TITLETXT = "TOP SOLUTION CHART"
                starter("LOAD CHART")
        End Select

        If action = "LOAD SYSTEM" Or action = "LOAD PARTS" Or action = "LOAD ISSUE" Or action = "LOAD CHART" Or action = "LOAD SOLUTION" Then
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
            Case "LOAD SOLUTION"
                gv.Columns.Clear()
                bs.DataSource = ds
                bs.DataMember = "SYSTEMTB"
                If Not Panel7.Controls.Contains(gv) Then
                    Panel7.Controls.Add(gv)
                End If
            Case "LOAD CHART"

                Chart1.Series.Clear()

                Chart1.DataSource = bs
                Dim CArea As ChartArea = Chart1.ChartAreas(0)
                CArea.BackColor = Color.Azure
                CArea.ShadowColor = Color.Red
                CArea.Area3DStyle.Enable3D = True
                Chart1.Series.Add("Series1")
                Chart1.Series("Series1").XValueMember = "" & XVAL & ""
                Chart1.Series("Series1").YValueMembers = "REPORTS"

                Chart1.Series("Series1").Font = New System.Drawing.Font("Century Gothic", 11.0F, System.Drawing.FontStyle.Regular)
                Chart1.Series("Series1").YValueType = ChartValueType.Auto

                Chart1.Series("Series1").ChartType = cstyle
                Chart1.Series("Series1").IsValueShownAsLabel = True
                Chart1.Series("Series1").LabelForeColor = Color.Black
                Chart1.Series("Series1").LabelFormat = "N0"
                If Chart1.Series("Series1").ChartType = SeriesChartType.StackedBar Then
                    Chart1.Series("Series1").LegendText = "REPORTS"
                End If

                Chart1.Titles.Clear()
                Dim T As Title = Chart1.Titles.Add("" & TitleTXT & "")
                T.ForeColor = Color.White
                T.BackColor = Color.Black
                T.Font = New System.Drawing.Font("Century Gothic", 15.0F, System.Drawing.FontStyle.Regular)
                T.BorderColor = Color.Black
        End Select


    End Sub

    Friend Shared Sub gv_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs)
        Dim sql As New sql
        sql.rownum(sender, e)
    End Sub

    Public Sub gv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If gv.RowCount >= 0 And e.RowIndex >= 0 Then
            Select Case gvdata
                Case "gv"
                    gvdata = "gv2"
                    starter("LOAD PARTS")
                    Button5.Text = "back"
                    toplabel.Text = "PARTS"
                Case "gv2"
                    gvdata = "gv3"
                    starter("LOAD ISSUE")
                    Button5.Text = "back"
                    toplabel.Text = "TOP ISSUE"
                Case "gv3"
                    gvdata = "gv4"
                    starter("LOAD SOLUTION")
                    Button5.Text = "back"
                    toplabel.Text = "TOP SOLUTION"
                Case "gv4"

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
                    systemqualityaspect = row.Cells("quality aspect").Value.ToString
                    systemissue = row.Cells("issue").Value.ToString
            End Select

            Dim a As String = systemtype
            Dim b As String = systemparts
            Dim c As String = systemcategory
            Dim d As String
            Dim F As String = systemqualityaspect
            Dim G As String = systemissue
            Select Case gvdata
                Case "gv2"
                    d = a
                Case "gv3"
                    d = a + "  >  " + b + "  >  " + c
                Case "gv4"
                    d = a + "  >  " + b + "  >  " + c + "  >  " + F + "  >  " + G
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
            Case "LOAD SOLUTION"
                queries("LOAD SOLUTION")
                bgw.ReportProgress(0)
            Case "LOAD CHART"
                bgw.ReportProgress(0)
        End Select
    End Sub
    Dim gvdata As String
    Dim systemtype As String = ""
    Dim systemparts As String = ""
    Dim systemcategory As String = ""
    Dim systemspecification As String = ""
    Dim systemqualityaspect As String = ""
    Dim systemissue As String = ""
    Dim yrtxt As String = ""
    Dim XVAL As String = ""
    Dim TITLETXT As String = ""
    Private Sub queries(ByVal command As String)

        If bothRB.Checked = True Then
            systemspecification = ""
        ElseIf windowRB.Checked = True Then
            systemspecification = "Window"
        ElseIf doorRB.Checked = True Then
            systemspecification = "Door"
        End If

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
                    .Parameters.AddWithValue("@specification", systemspecification)
                    .Parameters.AddWithValue("@year", yrtxt)
                    .Parameters.AddWithValue("@qualityaspect", systemqualityaspect)
                    .Parameters.AddWithValue("@issue", systemissue)
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
            Case "gv4"
                gvdata = "gv3"
                starter("LOAD ISSUE")
            Case Else
                gvdata = "gv"
                starter("LOAD SYSTEM")
        End Select

        Select Case gvdata
            Case "gv"
                toplabel.Text = "TOP SYSTEM"
                Button5.Text = "refresh"
            Case "gv2"
                toplabel.Text = "PARTS"
                Button5.Text = "back"
            Case "gv3"
                toplabel.Text = "TOP ISSUE"
                Button5.Text = "back"
            Case "gv4"
                toplabel.Text = "TOP SOLUTION"
                Button5.Text = "back"
            Case Else
                toplabel.Text = "TOP SYSTEM"
                Button5.Text = "refresh"
        End Select
    End Sub

    Private Sub insightFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class