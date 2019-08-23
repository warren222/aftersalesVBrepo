Imports Microsoft.Reporting.WinForms

Public Class ServicingRPTfrm
    Dim pj As String = servicingFRM.projectname.Text
    Dim address As String = servicingFRM.address.Text
    Public Shared specs As String
    Private Sub ServicingRPTfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim param1 As ReportParameter = New ReportParameter("project", pj)
        Dim param2 As ReportParameter = New ReportParameter("address", address)
        Dim param3 As ReportParameter = New ReportParameter("profilespecs", specs)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param1})
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param2})
        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {param3})
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class