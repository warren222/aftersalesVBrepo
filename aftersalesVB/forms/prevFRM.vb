Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class prevFRM
    Dim sql As New sql
    Public Sub re()
        If quotationFRM.oth = "" Then
            quotationFRM.oth = 0
        End If
        Dim param1 As ReportParameter = New ReportParameter("project", quotationFRM.projectname.Text)
        Dim param2 As ReportParameter = New ReportParameter("address", quotationFRM.address.Text)
        Dim param3 As ReportParameter = New ReportParameter("ase", quotationFRM.ase)
        Dim param4 As ReportParameter = New ReportParameter("qdate", quotationFRM.d)
        Dim param5 As ReportParameter = New ReportParameter("telno", mainform.telno)
        Dim param6 As ReportParameter = New ReportParameter("faxno", mainform.faxno)
        Dim param7 As ReportParameter = New ReportParameter("oth", quotationFRM.oth)
        Dim param8 As ReportParameter = New ReportParameter("dear", dear.Text)
        Dim param9 As ReportParameter = New ReportParameter("note", note.Text)
        Dim param10 As ReportParameter = New ReportParameter("scopeofworks", scopeofworks.Text)
        Dim param11 As ReportParameter = New ReportParameter("preparedby", preparedby.Text)
        Dim param12 As ReportParameter = New ReportParameter("approvedby", approvedby.Text)
        Dim param13 As ReportParameter = New ReportParameter("VISI", CheckBox1.Checked)
        With ReportViewer1.LocalReport
            .SetParameters(New ReportParameter() {param1})
            .SetParameters(New ReportParameter() {param2})
            .SetParameters(New ReportParameter() {param3})
            .SetParameters(New ReportParameter() {param4})
            .SetParameters(New ReportParameter() {param5})
            .SetParameters(New ReportParameter() {param6})
            .SetParameters(New ReportParameter() {param7})
            .SetParameters(New ReportParameter() {param8})
            .SetParameters(New ReportParameter() {param9})
            .SetParameters(New ReportParameter() {param10})
            .SetParameters(New ReportParameter() {param11})
            .SetParameters(New ReportParameter() {param12})
            .SetParameters(New ReportParameter() {param13})
        End With
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub prevFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadrep()
        re()
    End Sub
    Public Sub loadrep()
        Dim str As String = "select 
  a.ASENO,a.ITEM,a.KNO,a.WDWLOC,b.UNITPRICE,b.qty,b.NETAMOUNT,b.MARKUP,b.ARTICLENO,b.DESCRIPTION from ITEMTB as a
  inner join partstb as b on a.id = b.iid where A.aseno = @aseno"
        Dim ds As New asdbDS
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.ase)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds.ITEMTB)
                        ITEMTBBindingSource.DataSource = ds.ITEMTB.DefaultView
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub prevFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub ReportViewer1_ReportRefresh(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ReportViewer1.ReportRefresh
        re()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        re()
    End Sub
End Class