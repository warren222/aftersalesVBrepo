Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class mainform
    Dim sql As New sql
    Public Shared tempcin As String
    Public Shared telno As String
    Public Shared faxno As String
    Dim bs As New BindingSource
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toprows.SelectedIndex = 0
        fieldcombo.SelectedIndex = 0
        reloadBTN.PerformClick()
    End Sub
    Public Sub loadcallin(ByVal field As String, ByVal txt As String)
        Dim TR As String
        Dim ROW As String = Trim(toprows.Text.Replace(",", ""))
        If toprows.Text = "MAX" Then
            TR = ""
        Else
            TR = " TOP " & ROW & " "
        End If

        Dim done As String
        If donecheckbox.Checked = True Then
            done = " and a.status = a.STATUS"
        Else
            done = " and not a.status = 'Done'"
        End If

        If field = "PROJECT" Then
            field = "B.PROJECT_LABEL"
        ElseIf field = "ADDRESS" Then
            field = "B.FULLADD"
        ElseIf field = "CALLER" Then
            field = "A.CALLER"
        ElseIf field = "DATE" Then
            field = "A.CDATE"
        ElseIf field = "JOB ORDER NO" Then
            field = "A.JO"
        ElseIf field = "CIN" Then
            field = "A.CIN"
        End If

        Dim str As String = "
                            select " & TR & "
                            a.AUTONUM,
                            a.STATUS,
                            A.CDATE as DATE,
                            A.CIN,
                            A.CALLER,
                            A.JO,
                            b.PROJECT_LABEL AS PROJECT,
                            B.FULLADD AS ADDRESS,
                            A.TELNO,
                            a.FAXNO
                            from callintb as a
                            inner join
                            HERETOSAVE.dbo.addendum_to_contract_tb as b
                            on b.job_order_no = a.jo
                            where " & field & " like '%" & txt & "%' " & done & " order by 
                            case when isdate(cdate)=1 then cast(cdate as date) else cdate end desc"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        callinGRID.Columns.Clear()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "callintb")
                        bs.DataSource = ds
                        bs.DataMember = "callintb"
                        callinGRID.DataSource = bs
                        addbtncolumns()
                        With callinGRID
                            .Columns("CALLER").Frozen = True
                            .Columns("autonum").Visible = False
                            .Columns("TELNO").Visible = False
                            .Columns("FAXNO").Visible = False
                            .Columns("concern").Width = 100
                            .Columns("servicing").Width = 100
                            .Columns("STATUS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("date").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("cin").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("caller").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("project").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("jo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("address").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With


                        For i As Integer = 0 To callinGRID.RowCount - 1
                            Dim a As String = callinGRID.Rows(i).Cells("STATUS").Value.ToString()
                            If a = "Done" Then
                                With callinGRID
                                    .Rows(i).Cells("STATUS").Style.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                                    .Rows(i).Cells("STATUS").Style.BackColor = System.Drawing.Color.Blue
                                    .Rows(i).Cells("STATUS").Style.ForeColor = System.Drawing.Color.White
                                    .Rows(i).Cells("STATUS").Style.SelectionBackColor = Color.Blue
                                    .Rows(i).Cells("STATUS").Style.SelectionForeColor = Color.White
                                End With
                            ElseIf a = "Reschedule" Then
                                With callinGRID
                                    .Rows(i).Cells("STATUS").Style.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                                    .Rows(i).Cells("STATUS").Style.BackColor = System.Drawing.Color.LimeGreen
                                    .Rows(i).Cells("STATUS").Style.ForeColor = System.Drawing.Color.White
                                    .Rows(i).Cells("STATUS").Style.SelectionBackColor = Color.LimeGreen
                                    .Rows(i).Cells("STATUS").Style.SelectionForeColor = Color.White
                                End With
                            ElseIf a = "For Costing" Then
                                With callinGRID
                                    .Rows(i).Cells("STATUS").Style.Font = New Font("Century Gothic", 10, FontStyle.Bold)
                                    .Rows(i).Cells("STATUS").Style.BackColor = System.Drawing.Color.Green
                                    .Rows(i).Cells("STATUS").Style.ForeColor = System.Drawing.Color.White
                                    .Rows(i).Cells("STATUS").Style.SelectionBackColor = Color.Green
                                    .Rows(i).Cells("STATUS").Style.SelectionForeColor = Color.White
                                End With
                            End If
                        Next

                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub addbtncolumns()
        Dim updatebtn As New DataGridViewButtonColumn
        Dim concernbtn As New DataGridViewButtonColumn
        Dim servicingbtn As New DataGridViewButtonColumn
        Dim quotationbtn As New DataGridViewButtonColumn
        concernbtn.Name = "concern"
        concernbtn.HeaderText = ""
        concernbtn.Text = "concern"
        concernbtn.UseColumnTextForButtonValue = True

        servicingbtn.Name = "servicing"
        servicingbtn.HeaderText = ""
        servicingbtn.Text = "servicing"
        servicingbtn.UseColumnTextForButtonValue = True

        With quotationbtn
            .Name = "quotation"
            .HeaderText = ""
            .Text = "quotation"
            .UseColumnTextForButtonValue = True
        End With
        With updatebtn
            .Name = "update"
            .HeaderText = ""
            .Text = "update"
            .UseColumnTextForButtonValue = True
        End With
        callinGRID.Columns.Insert(8, updatebtn)
        callinGRID.Columns.Insert(9, concernbtn)
        callinGRID.Columns.Insert(10, servicingbtn)
        callinGRID.Columns.Insert(11, quotationbtn)

    End Sub
    Private Sub newPNL_Click(sender As Object, e As EventArgs) Handles newPNL.Click

        newcallinFRM.Text = "New"
        newcallinFRM.addBTN.Visible = True
        newcallinFRM.updateBTN.Visible = False
        newcallinFRM.ShowDialog()
    End Sub

    Private Sub callinGRID_SelectionChanged(sender As Object, e As EventArgs) Handles callinGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = callinGRID.SelectedRows
        For Each row As DataGridViewRow In selecteditems
            tempcin = row.Cells("cin").Value.ToString
        Next
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        accessoriesFRM.ShowDialog()
    End Sub
    Public Sub storeqa()
        Dim str As String = "update answertb set chk = '0'
                             update answertb set chk = 1 where aid in (select aid from qatb where cin  = @cin)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@cin", tempcin)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        qsFRM.ShowDialog()
    End Sub

    Private Sub searchtext_ButtonClick(sender As Object, e As EventArgs) Handles searchtext.ButtonClick
        loadcallin(fieldcombo.Text, searchtext.Text)
    End Sub

    Private Sub reloadBTN_Click(sender As Object, e As EventArgs) Handles reloadBTN.Click
        loadcallin(fieldcombo.Text, "")
    End Sub
    Private Sub callinGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles callinGRID.CellClick
        If callinGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = callinGRID.Rows(e.RowIndex)
            If e.ColumnIndex = 8 Then
                newcallinFRM.Text = "Editing"
                newcallinFRM.telno.Text = row.Cells("TELNO").Value.ToString
                newcallinFRM.faxno.Text = row.Cells("FAXNO").Value.ToString
                newcallinFRM.calldate.Text = row.Cells("date").Value.ToString
                newcallinFRM.callername.Text = row.Cells("caller").Value.ToString
                newcallinFRM.projectname.Text = row.Cells("project").Value.ToString
                newcallinFRM.address.Text = row.Cells("address").Value.ToString
                newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
                storeqa()
                newcallinFRM.addBTN.Visible = False
                newcallinFRM.updateBTN.Visible = True
                newcallinFRM.ShowDialog()
            ElseIf e.ColumnIndex = 9 Then
                Dim param1 As ReportParameter = New ReportParameter("project", row.Cells("project").Value.ToString)
                Dim param2 As ReportParameter = New ReportParameter("address", row.Cells("address").Value.ToString)
                concernsummaryFRM.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
                concernsummaryFRM.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param2})
                concernsummaryFRM.ShowDialog()
            ElseIf e.ColumnIndex = 10 Then
                servicingFRM.projectname.Text = row.Cells("project").Value.ToString
                servicingFRM.address.Text = row.Cells("address").Value.ToString
                servicingFRM.jo.Text = row.Cells("jo").Value.ToString
                servicingFRM.ShowDialog()
            ElseIf e.ColumnIndex = 11 Then
                telno = row.Cells("telno").Value.ToString
                faxno = row.Cells("faxno").Value.ToString
                quotationFRM.projectname.Text = row.Cells("project").Value.ToString
                quotationFRM.address.Text = row.Cells("address").Value.ToString
                quotationFRM.jo.Text = row.Cells("jo").Value.ToString
                quotationFRM.ShowDialog()
            End If
        End If

    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        personnelFRM.ShowDialog()
    End Sub

    Private Sub callinGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles callinGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub
End Class
