Imports System.Data.SqlClient
Public Class mainform
    Dim sql As New sql
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadcallin()
    End Sub
    Public Sub loadcallin()
        Dim str As String = "
select 
a.AUTONUM,
A.CDATE,
A.CIN,
A.CALLER,
A.JO,
b.PROJECT_LABEL AS PROJECT,
B.FULLADD AS ADDRESS 
from callintb as a
inner join
HERETOSAVE.dbo.addendum_to_contract_tb as b
on b.job_order_no = a.jo"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "callintb")
                        callinGRID.DataSource = ds.Tables("callintb")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub newPNL_Click(sender As Object, e As EventArgs) Handles newPNL.Click

        newcallinFRM.Text = "New"
        newcallinFRM.ShowDialog()
    End Sub

    Private Sub callinGRID_SelectionChanged(sender As Object, e As EventArgs) Handles callinGRID.SelectionChanged

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        newcallinFRM.Text = "Edit"
        Dim selecteditems As DataGridViewSelectedRowCollection = callinGRID.SelectedRows
        For Each row As DataGridViewRow In selecteditems
            newcallinFRM.calldate.Text = row.Cells("cdate").Value.ToString
            newcallinFRM.callername.Text = row.Cells("caller").Value.ToString
            newcallinFRM.projectname.Text = row.Cells("project").Value.ToString
            newcallinFRM.address.Text = row.Cells("address").Value.ToString
            newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
        Next
        newcallinFRM.ShowDialog()
    End Sub
End Class
