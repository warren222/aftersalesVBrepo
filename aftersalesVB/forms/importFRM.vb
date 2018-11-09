Imports System.Data.SqlClient
Public Class importFRM
    Dim sql As New sql
    Private Sub importFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Bottom - 37
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, 0)
        loadkno()
    End Sub
    Public Sub loadkno()
        Dim str As String = "select a.KMDI_NO as [K#],ITEM_NO AS [ITEM NO],WDW_NO AS [WDW NO],LOCATION,DESCRIPTION from KMDI_FABRICATION_TB as a 
                             inner join ADDENDUM_TO_CONTRACT_TB as b on 
                             a.job_order_no = b.JOB_ORDER_NO where b.LOCK=0 and b.PARENTJONO = @jo and a.STATUS=''"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@jo", quotationFRM.jo.Text)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "KMDI_FABRICATION_TB")
                        knoGRID.DataSource = ds.Tables("KMDI_FABRICATION_TB")
                        With knoGRID
                            .Columns("K#").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("ITEM NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("WDW NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("LOCATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub importFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub knoGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles knoGRID.CellClick
        If knoGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = knoGRID.Rows(e.RowIndex)
            newitemFRM.kno.Text = row.Cells("K#").Value.ToString
            newitemFRM.itemno.Text = row.Cells("ITEM NO").Value.ToString
            newitemFRM.wdwloc.Text = row.Cells("WDW NO").Value.ToString + " / " + row.Cells("LOCATION").Value.ToString
        End If
    End Sub

    Private Sub knoGRID_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles knoGRID.CellDoubleClick
        Me.Close()
    End Sub
End Class