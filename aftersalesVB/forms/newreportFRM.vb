Imports System.Data.SqlClient
Imports MetroFramework

Public Class newreportFRM
    Dim sql As New sql
    Dim bs As New BindingSource
    Private Sub newreportFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If save.Text = "add" Then
            add()
        ElseIf save.Text = "save" Then
            update()
        End If
        reportFRM.refreshbtn.PerformClick()
    End Sub
    Public Sub add()
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from reporttb)
                             insert into reporttb (id,[sid],location,specification)values(@id,@sid,@location,@specification)

 INSERT INTO relrepass (repid,assid) SELECT @id,id FROM assessmenttb WHERE CHK=1
 UPDATE assessmenttb SET CHK=0"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@sid", servicingFRM.id)
                    sqlcmd.Parameters.AddWithValue("@location", locations.Text)
                    sqlcmd.Parameters.AddWithValue("@specification", specification.Text)
                    sqlcmd.ExecuteNonQuery()
                    MetroMessageBox.Show(Me, "Data saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim str As String = "update reporttb set location=@location,specification=@specification where id = @id


insert into relrepass (repid,assid) select @id,id from assessmenttb where chk = '1' and not id in (select assid from relrepass where repid = @id)
delete from relrepass where repid = @id and not assid in (select id from assessmenttb where chk = '1')"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", reportFRM.id)
                    sqlcmd.Parameters.AddWithValue("@location", locations.Text)
                    sqlcmd.Parameters.AddWithValue("@specification", specification.Text)
                    sqlcmd.ExecuteNonQuery()
                    MetroMessageBox.Show(Me, "Data saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub newreportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        Dim clr As Color
        If Me.Text = "Editing" Then
            clr = Color.Red
            fromid("update assessmenttb set chk=0  update assessmenttb set chk = 1 where id in (select ASSID FROM RELREPASS WHERE REPID = @REPID)")
        ElseIf Me.Text = "New" Then
            fromid("update assessmenttb set chk = 0")
            clr = Color.Black
        End If
        ccolor(specification, clr)
        ccolor(locations, clr)
        loadassessment()
    End Sub
    Private Sub fromid(ByVal QRY As String)
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(QRY, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@REPID", reportFRM.id)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub loadassessment()
        Dim str As String = "SELECT id,chk,ITEM,ASSESSMENT FROM ASSESSMENTTB order by item asc"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ASSESSMENTTB")
                        bs.DataSource = ds
                        bs.DataMember = "ASSESSMENTTB"
                        answerGV.DataSource = bs
                        With answerGV
                            .Columns("chk").Visible = False
                            .Columns("id").Visible = False
                            .Columns(Column1.Name).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("assessment").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                        If answerGV.RowCount >= 0 Then
                            For i As Integer = 0 To answerGV.RowCount - 1
                                Dim row As DataGridViewRow = answerGV.Rows(i)
                                Dim a As String = row.Cells("chk").Value.ToString
                                If a = "1" Then
                                    row.Cells(Column1.Name).Value = True
                                Else
                                    row.Cells(Column1.Name).Value = False
                                End If
                            Next
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
    Public Sub loadlocation()
        Dim str As String = "select distinct location from reporttb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reporttb")
                        locations.DataSource = ds.Tables("reporttb")
                        locations.DisplayMember = "location"
                        locations.SelectedIndex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub loadspecification()
        Dim str As String = "select distinct specification from reporttb"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "reporttb")
                        specification.DataSource = ds.Tables("reporttb")
                        specification.DisplayMember = "specification"
                        specification.SelectedIndex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub answerGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles answerGV.CellClick
        If answerGV.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim id As String = ""
            Dim m As String = ""
            Dim row As DataGridViewRow = answerGV.Rows(e.RowIndex)
            id = row.Cells("id").Value.ToString
            Dim chkd As Boolean = Convert.ToBoolean(row.Cells(Column1.Name).Value)
            If chkd = True Then
                row.Cells(Column1.Name).Value = False
                m = "0"
            Else
                row.Cells(Column1.Name).Value = True
                m = "1"
            End If
            Dim str As String = "update assessmenttb set chk = @m where id = @id"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@m", m)
                        sqlcmd.Parameters.AddWithValue("@id", id)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub MetroTextButton3_Click(sender As Object, e As EventArgs) Handles MetroTextButton3.Click
        newassessmentFRM.bol = True
        newassessmentFRM.Text = "New"
        newassessmentFRM.save.Text = "add"
        newassessmentFRM.ShowDialog()
    End Sub
End Class