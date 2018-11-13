Imports System.Data.SqlClient
Public Class mainform
    Dim sql As New sql
    Public Shared tempcin As String
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldcombo.SelectedIndex = 0
        reloadBTN.PerformClick()
    End Sub
    Public Sub loadcallin(ByVal field As String, ByVal txt As String)

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
                            select 
                            a.AUTONUM,
                            A.CDATE as DATE,
                            A.CIN,
                            A.CALLER,
                            A.JO,
                            b.PROJECT_LABEL AS PROJECT,
                            B.FULLADD AS ADDRESS 
                            from callintb as a
                            inner join
                            HERETOSAVE.dbo.addendum_to_contract_tb as b
                            on b.job_order_no = a.jo
                            where " & field & " like '%" & txt & "%'"
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
                        callinGRID.DataSource = ds.Tables("callintb")
                        addbtncolumns()
                        With callinGRID
                            .Columns("autonum").Visible = False
                            .Columns("concern").Width = 100
                            .Columns("servicing").Width = 100
                            .Columns("date").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("cin").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("caller").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("project").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("jo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("address").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
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
        callinGRID.Columns.Insert(7, updatebtn)
        callinGRID.Columns.Insert(8, concernbtn)
        callinGRID.Columns.Insert(9, servicingbtn)
        callinGRID.Columns.Insert(10, quotationbtn)

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
            If e.ColumnIndex = 7 Then
                newcallinFRM.Text = "Editing"
                newcallinFRM.calldate.Text = row.Cells("date").Value.ToString
                newcallinFRM.callername.Text = row.Cells("caller").Value.ToString
                newcallinFRM.projectname.Text = row.Cells("project").Value.ToString
                newcallinFRM.address.Text = row.Cells("address").Value.ToString
                newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
                storeqa()
                newcallinFRM.addBTN.Visible = False
                newcallinFRM.updateBTN.Visible = True
                newcallinFRM.ShowDialog()
            ElseIf e.ColumnIndex = 8 Then
                concernsummaryFRM.ShowDialog()
            ElseIf e.ColumnIndex = 9 Then
                servicingFRM.projectname.Text = row.Cells("project").Value.ToString
                servicingFRM.address.Text = row.Cells("address").Value.ToString
                servicingFRM.jo.Text = row.Cells("jo").Value.ToString
                servicingFRM.ShowDialog()
            ElseIf e.ColumnIndex = 10 Then
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
End Class
