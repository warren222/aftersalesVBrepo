Imports System.Data.SqlClient
Public Class newaccessoriesFRM
    Dim sql As New sql
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        zero(unitprice)
        If save.Text = "add" Then
            add()
            accessoriesFRM.refreshBTN.PerformClick()
        Else save.Text = "save"
            updateme()
            accessoriesFRM.refreshBTN.PerformClick()
        End If
    End Sub
    Public Sub zero(ByVal x As Object)
        If x.Text = "" Then
            x.Text = 0
        End If
    End Sub
    Public Sub add()

        Dim str As String = "
                            declare @id as integer  =  (select isnull(max(id),0)+1 from accessoriestb)
                            insert into accessoriestb 
                            (ID,
                            SPECIFICATION,
                            ARTICLENO,
                            DESCRIPTION,
                            UNIT,
                            UNITPRICE,
                            REMARKS)
                            values 
                            (@ID,
                            @SPECIFICATION,
                            @ARTICLENO,
                            @DESCRIPTION,
                            @UNIT,
                            @UNITPRICE,
                            @REMARKS)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@SPECIFICATION", specification.Text)
                    sqlcmd.Parameters.AddWithValue("@ARTICLENO", articleno.Text)
                    sqlcmd.Parameters.AddWithValue("@DESCRIPTION", description.Text)
                    sqlcmd.Parameters.AddWithValue("@UNIT", unit.Text)
                    sqlcmd.Parameters.AddWithValue("@UNITPRICE", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@REMARKS", remarks.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub updateme()
        Dim str As String = "
                            update accessoriestb set
                            SPECIFICATION=@SPECIFICATION,
                            ARTICLENO=@ARTICLENO,
                            DESCRIPTION=@DESCRIPTION,
                            UNIT=@UNIT,
                            UNITPRICE=@UNITPRICE,
                            REMARKS=@REMARKS
                            where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", accessoriesFRM.id)
                    sqlcmd.Parameters.AddWithValue("@SPECIFICATION", specification.Text)
                    sqlcmd.Parameters.AddWithValue("@ARTICLENO", articleno.Text)
                    sqlcmd.Parameters.AddWithValue("@DESCRIPTION", description.Text)
                    sqlcmd.Parameters.AddWithValue("@UNIT", unit.Text)
                    sqlcmd.Parameters.AddWithValue("@UNITPRICE", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@REMARKS", remarks.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newaccessoriesFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub newaccessoriesFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadspecs()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String = "select distinct specification from accessoriestb"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "accessoriestb")
                        specification.DataSource = ds.Tables("accessoriestb")
                        specification.DisplayMember = "specification"
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub specification_MouseDown(sender As Object, e As MouseEventArgs) Handles specification.MouseDown
        Dim i As Integer = specification.SelectedIndex
        loadspecs()
        If specification.Items.Count - 1 < i Then
            specification.SelectedIndex = -1
        Else
            specification.SelectedIndex = i
        End If
    End Sub
End Class