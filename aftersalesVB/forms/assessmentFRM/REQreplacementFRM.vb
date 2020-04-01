Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class REQreplacementFRM
    Dim rid As String = reportFRM.id
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim bs2 As New BindingSource
    Dim y As Boolean

    Dim category As String
    Private Sub REQreplacementFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsuggestion("specification", specification)
        loadsuggestion("description", ComboBox1)
        loadsuggestion("articleno", ComboBox2)

        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth

        If requestype.Text = "REQUEST FORM FOR SCREEN REPAIR" Then
            y = False
            KryptonLabel5.Visible = False
            qty.Visible = False
            category = "screenrepair"
        ElseIf requestype.Text = "REQUEST FORM FOR REPLACEMENTS" Then
            KryptonLabel5.Visible = True
            qty.Visible = True
            y = True
            category = "replacement"
        End If
        partsGRID.DataSource = bs
        knogv.DataSource = bs2
        loadrequest()
        loadreport()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Public Sub loadsuggestion(ByVal col As String, ByVal od As Object)
        Dim str As String = "select distinct " & col & " from ACCESSORIESTB order by " & col & " asc"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        od.datasource = ds.Tables("ACCESSORIESTB")
                        od.displaymember = "" & col & ""
                        od.selectedindex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub loadrequest()


        Dim str As String = "select ID,
RID,
DESCRIPTION,
QTY,
REMARKS,
REQUESTTYPE,
DATED AS [DATE]
 from replacementtb where rid = @rid and [REQUESTTYPE] = @REQUESTTYPE"


        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@rid", rid)
                    sqlcmd.Parameters.AddWithValue("@REQUESTTYPE", category)
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        With da
                            .SelectCommand = sqlcmd
                            .SelectCommand.CommandTimeout = 30000
                            .Fill(ds, "replacementtb")
                            bs.DataSource = ds
                            bs.DataMember = "replacementtb"
                        End With
                    End Using
                    With partsGRID
                        .Columns("id").Visible = False
                        .Columns("requesttype").Visible = False
                        .Columns("rid").Visible = False
                        If y = True Then
                            .Columns("qty").Visible = True
                        ElseIf y = False Then
                            .Columns("qty").Visible = False
                        End If
                    End With

                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If qty.Text = "" Then
            qty.Text = 0
        End If
        If Not IsNumeric(qty.Text) Then
            MessageBox.Show("qty not numeric", "detected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim str As String = "
                                declare @id as integer = (select isnull(max(isnull(id,0)),0)+1 from replacementtb)
                                insert into replacementtb (id,rid,description,qty,remarks,[REQUESTTYPE],[DATED])values(@id,@rid,@description,@qty,@remarks,@requesttype,@DATED)"

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd.Parameters
                        .AddWithValue("@rid", rid)
                        .AddWithValue("@description", description.Text)
                        .AddWithValue("@remarks", remarks.Text)
                        .AddWithValue("@qty", qty.Text)
                        .AddWithValue("@requesttype", category)
                        .AddWithValue("@DATED", reqdate.Text)
                    End With
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    loadrequest()
                End Try
            End Using
        End Using
    End Sub
    Dim id As String
    Private Sub partsGRID_SelectionChanged(sender As Object, e As EventArgs) Handles partsGRID.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = partsGRID.SelectedRows
        For Each Row As DataGridViewRow In rows
            id = Row.Cells("id").Value.ToString
            description.Text = Row.Cells("description").Value.ToString
            remarks.Text = Row.Cells("remarks").Value.ToString
            qty.Text = Row.Cells("qty").Value.ToString
            reqdate.Text = Row.Cells("DATE").Value.ToString
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If qty.Text = "" Then
            qty.Text = 0
        End If
        If Not IsNumeric(qty.Text) Then
            MessageBox.Show("qty not numeric", "detected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim str As String = "
                       
                               update replacementtb set description=@description,qty=@qty,remarks=@remarks,REQUESTTYPE=@requesttype,dated=@dated where id = @id"

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd.Parameters
                        .AddWithValue("@id", id)
                        .AddWithValue("@description", description.Text)
                        .AddWithValue("@remarks", remarks.Text)
                        .AddWithValue("@qty", qty.Text)
                        .AddWithValue("@requesttype", category)
                        .AddWithValue("@DATED", reqdate.Text)
                    End With
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    loadrequest()
                End Try
            End Using
        End Using
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadrequest()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("delete record?", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Dim str As String = "delete from replacementtb where id = @id"

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd.Parameters
                        .AddWithValue("@id", id)
                    End With
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    loadrequest()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        loadaccessories()
    End Sub
    Public Sub loadaccessories()
        Dim str As String = "select ID,
                            SPECIFICATION,
                            ARTICLENO as [ARTICLE NO],
                            DESCRIPTION,
                            UNIT,
                            UNITPRICE AS [UNIT PRICE],
                            REMARKS
                            from ACCESSORIESTB 
                            where 
                            description like @description and
                            articleno like @articleno and
                            specification like @specification"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        knogv.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@description", "%" & ComboBox1.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@articleno", "%" & ComboBox2.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@specification", "%" & specification.Text & "%")
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        bs2.DataSource = ds
                        bs2.DataMember = "ACCESSORIESTB"


                        With knogv
                            .Columns("ID").Visible = False
                            .Columns("UNIT PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("SPECIFICATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("ARTICLE NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("UNIT").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("REMARKS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub knogv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles knogv.CellClick
        If knogv.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = knogv.Rows(e.RowIndex)
            description.Text = row.Cells("description").Value.ToString
        End If
    End Sub

    Private Sub REQreplacementFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Private Sub loadreport()
        Try
            Dim PARAM1 As ReportParameter = New ReportParameter("project", servicingFRM.projectname.Text)
            Dim PARAM2 As ReportParameter = New ReportParameter("requested", fullname)
            Dim PARAM3 As ReportParameter = New ReportParameter("requesttype", requestype.Text)
            With ReportViewer1.LocalReport
                .SetParameters(New ReportParameter() {PARAM1})
                .SetParameters(New ReportParameter() {PARAM2})
                .SetParameters(New ReportParameter() {PARAM3})
            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim str As String = "
                            select b.KNO,ITEMNO,LOCATION,[DESCRIPTION],A.REMARKS,qty from replacementtb as a

                            left join REPORTTB as b

                            on a.rid=b.ID

                            where b.[SID] =  @sid and [REQUESTTYPE] = @REQUESTTYPE
                            "
        Dim ds As New asdbDS
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                    sqlcmd.Parameters.AddWithValue("@REQUESTTYPE", category)
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        With da
                            .SelectCommand = sqlcmd
                            .SelectCommand.CommandTimeout = 30000
                            .Fill(ds.REPLACEMENTTB)
                            REPLACEMENTTBBindingSource.DataSource = ds.REPLACEMENTTB.DefaultView
                        End With
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ReportViewer1_ReportRefresh(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.ReportRefresh
        loadreport()
    End Sub

    Private Sub MetroDateTime1_ValueChanged(sender As Object, e As EventArgs) Handles MetroDateTime1.ValueChanged, MetroDateTime1.MouseDown
        reqdate.Text = MetroDateTime1.Text
    End Sub
End Class