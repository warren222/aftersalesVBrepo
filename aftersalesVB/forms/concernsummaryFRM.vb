Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class concernsummaryFRM
    Dim sql As New sql
    Private Sub concernsummaryFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim STR As String = " declare @jo as varchar(20) = (select jo from callintb where cin  = '" & mainform.tempcin & "')  
        '                      (SELECT * FROM QATB AS A 
        '                      INNER JOIN ANSWERTB AS B
        '                      ON A.AID = B.AID
        '                      INNER JOIN QUESTIONNAIRETB AS C
        '                      ON B.QID = C.QID
        '                      WHERE A.CIN in (select cin from callintb where jo = @jo)"
        Dim STR As String = " declare @jo as varchar(20) = (select jo from callintb where cin  = '" & mainform.tempcin & "')  
                              SELECT ABC.CIN,aBC.AID,ABc.QID,CTB.CDATE,ABC.ANSWER,ABC.QUESTION FROM 
						      (SELECT a.CIN,a.AID,c.QID,B.ANSWER,C.QUESTION FROM QATB AS A 
                              INNER JOIN ANSWERTB AS B
                              ON A.AID = B.AID
                              INNER JOIN QUESTIONNAIRETB AS C
                              ON B.QID = C.QID
                              WHERE A.CIN in (select cin from callintb where jo = @jo)) AS ABC
							  INNER JOIN CALLINTB AS CTB 
							  ON CTB.CIN = ABC.CIN ORDER BY CAST(CDATE AS DATE) ASC"
        Dim ds As New asdbDS
        ds.Clear()

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(STR, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds.QATB)
                        QATBBindingSource.DataSource = ds.QATB.DefaultView
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.ZoomMode = ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub concernsummaryFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class