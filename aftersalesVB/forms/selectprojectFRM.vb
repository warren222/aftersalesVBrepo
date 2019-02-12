Imports System.Data.SqlClient
Public Class selectprojectFRM
    Dim sql As New sql
    Private Sub selectprojectFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fieldcombo.SelectedIndex = 0
        Me.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Me.Width, 0)
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
    End Sub

    Private Sub projectTXT_ButtonClick(sender As Object, e As EventArgs) Handles projectTXT.ButtonClick
        Dim FIELD As String = ""
        If fieldcombo.Text = "PROJECT NAME" Then
            FIELD = "PROJECT_LABEL like @pl"
        ElseIf fieldcombo.Text = "CLIENTS NAME" Then
            FIELD = "CLIENTS_NAME like @pl"
        ElseIf fieldcombo.Text = "COMPANY NAME" Then
            FIELD = "COMPANY_NAME like @pl"
        ElseIf fieldcombo.Text = "ADDRESS" Then
            FIELD = "FULLADD like @pl"
        ElseIf fieldcombo.Text = "SALES" Then
            FIELD = "ACCT_EXEC_INCHARGE like @p00l"
        ElseIf fieldcombo.Text = "ALL" Then
            FIELD = "
                    (PROJECT_LABEL like @pl OR 
                    CLIENTS_NAME like @pl OR
JOB_ORDER_NO like @pl OR
SUB_JO like @pl OR
JOB_ORDER_NO_DATE like @pl OR
                    COMPANY_NAME like @pl OR
                    FULLADD like @pl OR
                    ACCT_EXEC_INCHARGE like @pl)"
        End If



        Dim str As String = "select JOB_ORDER_NO AS JO,project_label as [PROJECT NAME],FULLADD AS ADDRESS from addendum_to_contract_tb
                             where " & FIELD & " and contract_type = 'original contract'"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@pl", "%" & projectTXT.Text & "%")
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "addendum_to_contract_tb")
                        projectGRID.DataSource = ds.Tables("addendum_to_contract_tb")
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub projectGRID_SelectionChanged(sender As Object, e As EventArgs) Handles projectGRID.SelectionChanged
        Dim SELECTEDITEMS As DataGridViewSelectedRowCollection = projectGRID.SelectedRows
        For Each row As DataGridViewRow In SELECTEDITEMS
            newcallinFRM.projectname.Text = row.Cells("project name").Value.ToString
            newcallinFRM.address.Text = row.Cells("address").Value.ToString
            newcallinFRM.jo.Text = row.Cells("jo").Value.ToString
        Next
    End Sub

    Private Sub projectGRID_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles projectGRID.CellDoubleClick
        Me.Close()
    End Sub

    Private Sub projectTXT_KeyDown(sender As Object, e As KeyEventArgs) Handles projectTXT.KeyDown
        If e.KeyData = Keys.Enter Then
            projectTXT.CustomButton.PerformClick()
        End If
    End Sub
End Class