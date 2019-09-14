Imports System.Data.SqlClient
Imports MetroFramework
Imports Microsoft.Reporting.WinForms

Public Class mainform
    Dim sql As New sql
    Public Shared tempcin As String
    Public Shared telno As String
    Public Shared faxno As String
    Dim bs As New BindingSource
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toprows.SelectedIndex = 10
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



        Dim condition As String
        Select Case field
            Case "All"
                condition = "(b.PROJECT_LABEL like '%" & txt & "%' or b.fulladd like '%" & txt & "%' 
                              or a.caller like '%" & txt & "%' or a.cdate like '%" & txt & "%'
                              or a.jo like '%" & txt & "%' or a.cin like '%" & txt & "%')"
            Case Else
                condition = "" & field & " like '%" & txt & "%'"
        End Select
        Dim str As String = "
                            select " & TR & "
                            a.AUTONUM,
                            a.STATUS,
                            A.CDATE as DATE,
                            A.CIN,
                            A.CALLER,
                            A.JO,
                            b.PROJECT_LABEL AS PROJECT,
                            b.job_order_no_date as [JO DATE],
                            b.profile_finish as [PROFILE FINISH],
                            B.FULLADD AS ADDRESS,
                            A.TELNO,
                            a.FAXNO,
                            a.CONCERN,
                            A.CONVERSATION
                            from callintb as a
                            inner join
                            heretosave.dbo.addendum_to_contract_tb as b
                            on b.job_order_no = a.jo
                            where " & condition & " " & done & " order by 
                            case when isdate(cdate)=1 then cast(cdate as date) else cdate end asc, autonum asc"
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
                        'addbtncolumns()
                        With callinGRID
                            .Columns("CALLER").Frozen = True
                            .Columns("autonum").Visible = False
                            .Columns("TELNO").Visible = False
                            .Columns("FAXNO").Visible = False
                            .Columns("concern").Visible = False
                            .Columns("conversation").Visible = False
                            '.Columns("VALIDATED").Visible = False
                            '.Columns("concernbtn").Width = 100
                            '.Columns("servicing").Width = 100
                            .Columns("STATUS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("profile finish").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("jo date").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
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
        Dim validatebtn As New DataGridViewButtonColumn
        Dim addressbtn As New DataGridViewButtonColumn

        addressbtn.Name = "address"
        addressbtn.HeaderText = ""
        addressbtn.Text = "editaddress"
        addressbtn.UseColumnTextForButtonValue = True

        concernbtn.Name = "concernbtn"
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
        With validatebtn
            .Name = "validatebtn"
            .HeaderText = "VALIDATED"
            .Text = ""
            .UseColumnTextForButtonValue = False
        End With
        callinGRID.Columns.Insert(10, updatebtn)
        callinGRID.Columns.Insert(11, validatebtn)
        callinGRID.Columns.Insert(12, concernbtn)
        callinGRID.Columns.Insert(13, servicingbtn)
        callinGRID.Columns.Insert(14, quotationbtn)
        callinGRID.Columns.Insert(15, addressbtn)

        For I As Integer = 0 To callinGRID.RowCount - 1
            callinGRID.Rows(I).Cells.Item(11).Value = callinGRID.Item("validated", I).Value.ToString
        Next

    End Sub
    Private Sub newPNL_Click(sender As Object, e As EventArgs) Handles newPNL.Click

        newcallinFRM.Text = "New"
        newcallinFRM.addBTN.Visible = True
        newcallinFRM.updateBTN.Visible = False
        newcallinFRM.ShowDialog()
    End Sub
    Public ccolor As String
    Private Sub callinGRID_SelectionChanged(sender As Object, e As EventArgs) Handles callinGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = callinGRID.SelectedRows
        For Each row As DataGridViewRow In selecteditems
            tempcin = row.Cells("cin").Value.ToString
            ccolor = row.Cells("profile finish").Value.ToString
            jo = row.Cells("jo").Value.ToString
            newcallinFRM.cin.Text = row.Cells("CIN").Value.ToString
            newcallinFRM.telno.Text = row.Cells("TELNO").Value.ToString
            newcallinFRM.faxno.Text = row.Cells("FAXNO").Value.ToString
            newcallinFRM.calldate.Text = row.Cells("date").Value.ToString
            newcallinFRM.callername.Text = row.Cells("caller").Value.ToString
            newcallinFRM.projectname.Text = row.Cells("project").Value.ToString
            newcallinFRM.address.Text = row.Cells("address").Value.ToString
            newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
            newcallinFRM.concern = row.Cells("concern").Value.ToString
            newcallinFRM.conversation.Text = row.Cells("conversation").Value.ToString

            servicingFRM.projectname.Text = row.Cells("project").Value.ToString
            servicingFRM.address.Text = row.Cells("address").Value.ToString
            servicingFRM.jo.Text = row.Cells("jo").Value.ToString

            telno = row.Cells("telno").Value.ToString
            faxno = row.Cells("faxno").Value.ToString
            quotationFRM.projectname.Text = row.Cells("project").Value.ToString
            quotationFRM.address.Text = row.Cells("address").Value.ToString
            quotationFRM.jo.Text = row.Cells("jo").Value.ToString

            editaddressFRM.parentjo = row.Cells("jo").Value.ToString
        Next
    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Select Case accttype
            Case "Admin"
                accessoriesFRM.ShowDialog()
            Case Else
                MetroMessageBox.Show(Me, "Invalid access", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select
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
        If callinGRID.RowCount <= 0 Then
            loadcallin(fieldcombo.Text, "")
        Else

            loadcallin(fieldcombo.Text, "")
            'callinGRID.FirstDisplayedScrollingColumnIndex = 3
        End If
    End Sub
    Public jo As String
    Private Sub callinGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles callinGRID.CellClick
        If callinGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = callinGRID.Rows(e.RowIndex)
            jo = row.Cells("jo").Value.ToString
            newcallinFRM.cin.Text = row.Cells("CIN").Value.ToString
            newcallinFRM.telno.Text = row.Cells("TELNO").Value.ToString
            newcallinFRM.faxno.Text = row.Cells("FAXNO").Value.ToString
            newcallinFRM.calldate.Text = row.Cells("date").Value.ToString
            newcallinFRM.callername.Text = row.Cells("caller").Value.ToString
            newcallinFRM.projectname.Text = row.Cells("project").Value.ToString
            newcallinFRM.address.Text = row.Cells("address").Value.ToString
            newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
            newcallinFRM.concern = row.Cells("concern").Value.ToString
            newcallinFRM.conversation.Text = row.Cells("conversation").Value.ToString

            servicingFRM.projectname.Text = row.Cells("project").Value.ToString
            servicingFRM.address.Text = row.Cells("address").Value.ToString
            servicingFRM.jo.Text = row.Cells("jo").Value.ToString
            servicingFRM.KryptonLabel3.Text = row.Cells("cin").Value.ToString
            ServicingRPTfrm.specs = row.Cells("profile finish").Value.ToString
            telno = row.Cells("telno").Value.ToString
            faxno = row.Cells("faxno").Value.ToString
            quotationFRM.projectname.Text = row.Cells("project").Value.ToString
            quotationFRM.address.Text = row.Cells("address").Value.ToString
            quotationFRM.jo.Text = row.Cells("jo").Value.ToString

            editaddressFRM.parentjo = row.Cells("jo").Value.ToString
        End If




        'If callinGRID.RowCount >= 0 And e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow = callinGRID.Rows(e.RowIndex)
        '    jo = row.Cells("jo").Value.ToString
        '    If e.ColumnIndex = 10 Then
        '        newcallinFRM.Text = "Editing"
        '        newcallinFRM.cin.Text = row.Cells("CIN").Value.ToString
        '        newcallinFRM.telno.Text = row.Cells("TELNO").Value.ToString
        '        newcallinFRM.faxno.Text = row.Cells("FAXNO").Value.ToString
        '        newcallinFRM.calldate.Text = row.Cells("date").Value.ToString
        '        newcallinFRM.callername.Text = row.Cells("caller").Value.ToString
        '        newcallinFRM.projectname.Text = row.Cells("project").Value.ToString
        '        newcallinFRM.address.Text = row.Cells("address").Value.ToString
        '        newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
        '        newcallinFRM.concern = row.Cells("concern").Value.ToString
        '        newcallinFRM.conversation.Text = row.Cells("conversation").Value.ToString
        '        storeqa()
        '        newcallinFRM.addBTN.Visible = False
        '        newcallinFRM.updateBTN.Visible = True
        '        newcallinFRM.ShowDialog()
        '    ElseIf e.ColumnIndex = 11 Then
        '        Dim vali As String
        '        Select Case row.Cells("validated").Value.ToString
        '            Case "no"
        '                vali = "yes"
        '            Case "yes"
        '                vali = "no"
        '        End Select
        '        If MetroFramework.MetroMessageBox.Show(Me, "" & row.Cells("project").Value.ToString & "" & vbCrLf & "" & row.Cells("address").Value.ToString & "" & vbCrLf & "Continue?", "Validated : Mark as " & vali & "?", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
        '            Return
        '        End If


        '        Dim str As String = "update callintb set validated=@vali where cin = @cin"
        '        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
        '            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
        '                Try
        '                    sqlcon.Open()
        '                    sqlcmd.Parameters.AddWithValue("cin", tempcin)
        '                    sqlcmd.Parameters.AddWithValue("vali", vali)
        '                    sqlcmd.ExecuteNonQuery()
        '                Catch ex As Exception
        '                    MsgBox(ex.ToString)
        '                End Try
        '            End Using
        '        End Using
        '        reloadBTN.PerformClick()
        '    ElseIf e.ColumnIndex = 12 Then
        '        Dim param1 As ReportParameter = New ReportParameter("project", row.Cells("project").Value.ToString)
        '        Dim param2 As ReportParameter = New ReportParameter("address", row.Cells("address").Value.ToString)
        '        concernsummaryFRM.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
        '        concernsummaryFRM.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param2})
        '        concernsummaryFRM.ShowDialog()
        '    ElseIf e.ColumnIndex = 13 Then
        '        servicingFRM.projectname.Text = row.Cells("project").Value.ToString
        '        servicingFRM.address.Text = row.Cells("address").Value.ToString
        '        servicingFRM.jo.Text = row.Cells("jo").Value.ToString
        '        servicingFRM.ShowDialog()
        '    ElseIf e.ColumnIndex = 14 Then
        '        telno = row.Cells("telno").Value.ToString
        '        faxno = row.Cells("faxno").Value.ToString
        '        quotationFRM.projectname.Text = row.Cells("project").Value.ToString
        '        quotationFRM.address.Text = row.Cells("address").Value.ToString
        '        quotationFRM.jo.Text = row.Cells("jo").Value.ToString
        '        quotationFRM.ShowDialog()
        '    ElseIf e.ColumnIndex = 15 Then
        '        editaddressFRM.parentjo = row.Cells("jo").Value.ToString
        '        editaddressFRM.ShowDialog()
        '    End If
        'End If

    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        personnelFRM.ShowDialog()
    End Sub

    Private Sub callinGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles callinGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub MetroToggle1_Click(sender As Object, e As EventArgs) Handles MetroToggle1.Click
        If MetroToggle1.Checked = False Then
            Me.Theme = MetroFramework.MetroThemeStyle.Light
            KryptonLabel2.StateCommon.ShortText.Color1 = Color.Black
            Panel1.BackColor = Color.White
        Else
            Me.Theme = MetroFramework.MetroThemeStyle.Dark
            KryptonLabel2.StateCommon.ShortText.Color1 = Color.White
            Panel1.BackColor = Color.FromArgb(0, 0, 64)
        End If
        Me.Refresh()
    End Sub
    Private Sub searchtext_KeyDown(sender As Object, e As KeyEventArgs) Handles searchtext.KeyDown
        If e.KeyData = Keys.Enter Then
            searchtext.CustomButton.PerformClick()
        End If
    End Sub



    Private Sub mainform_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        loginFRM.Close()
        Me.Dispose()

    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        ServicingScheduleFRM.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        newcallinFRM.Text = "Editing"
        storeqa()
        newcallinFRM.addBTN.Visible = False
        newcallinFRM.updateBTN.Visible = True
        newcallinFRM.ShowDialog()
    End Sub

    Private Sub ServicingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicingToolStripMenuItem.Click
        servicingFRM.ShowDialog()
    End Sub

    Private Sub QuotationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuotationToolStripMenuItem.Click
        quotationFRM.ShowDialog()
    End Sub

    Private Sub EditAddressToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditAddressToolStripMenuItem.Click
        editaddressFRM.ShowDialog()
    End Sub

    Private Sub callinGRID_MouseDown(sender As Object, e As MouseEventArgs) Handles callinGRID.MouseDown
        If e.Button = MouseButtons.Right Then
            mymenu.Show(callinGRID, e.X, e.Y)
        End If
    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        'mobiizationFRM.Show()
        assessmentsettingFRM.Show()
    End Sub
End Class
