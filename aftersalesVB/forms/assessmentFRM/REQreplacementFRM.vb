Imports System.Data.SqlClient

Public Class REQreplacementFRM
    Dim rid As String = reportFRM.id
    Dim sql As New sql
    Dim bs As New BindingSource
    Dim y As Boolean
    Dim category As String
    Private Sub REQreplacementFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If requestype.Text = "REQUEST FOR SCREEN REPAIR" Then
            y = False
            KryptonLabel5.Visible = False
            qty.Visible = False
            category = "screenrepair"
        ElseIf requestype.Text = "REQUEST FOR REPLACEMENTS" Then
            KryptonLabel5.Visible = True
            qty.Visible = True
            y = True
            category = "replacement"
        End If
        partsGRID.DataSource = bs
        loadrequest()
    End Sub
    Private Sub loadrequest()


        Dim str As String = "select * from replacementtb where rid = @rid and [REQUESTTYPE] = @REQUESTTYPE"


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
                                insert into replacementtb (id,rid,description,qty,remarks,[REQUESTTYPE])values(@id,@rid,@description,@qty,@remarks,@requesttype)"

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
                       
                               update replacementtb set description=@description,qty=@qty,remarks=@remarks,REQUESTTYPE=@requesttype where id = @id"

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
End Class