Imports System.Data.SqlClient

Public Class partsFRM
    Dim WithEvents timer1 As New Timer
    Dim sql As New sql
    Public id As String
    Dim bs As New BindingSource
    Dim bs2 As New BindingSource
    Private Sub partsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        itemFRM.refreshbtn.PerformClick()
        Me.Dispose()
    End Sub

    Private Sub partsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadsuggestion("specification", specification)
        loadsuggestion("description", ComboBox1)
        loadsuggestion("articleno", ComboBox2)

        loadparts()
        timer1.Start()
        partsGRID.DataSource = bs
        knogv.DataSource = bs2
    End Sub
    Public Sub loadsuggestion(ByVal col As String, ByVal od As Object)
        Dim str As String = "select distinct " & col & " from ACCESSORIESTB order by " & col & " asc"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        od.datasource = ds.Tables("ACCESSORIESTB")
                        od.displaymember = "" & col & ""
                        od.selectedindex = -1
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Private Sub TIMER1_TICK(sender As Object, e As EventArgs) Handles timer1.Tick
        If IsNumeric(unitprice.Text) And IsNumeric(qty.Text) And IsNumeric(markup.Text) Then
            Dim net As Double = unitprice.Text * qty.Text
            Dim mup As Double = (markup.Text * 0.01) * net
            netamount.Text = net + mup
        Else
            netamount.Text = ""
        End If
    End Sub
    Public Sub loadparts()
        Dim str As String = "
declare @parts as varchar(1000) = (select c=stuff((select ', '+[DESCRIPTION] from PARTSTB where iid = @iid for xml path('')),1,2,''))
select 
ID,
IID,
ARTICLENO as [ARTICLE NO],
DESCRIPTION,
MARKUP,
UNITPRICE AS [UNIT PRICE],
QTY,
NETAMOUNT AS [NET AMOUNT]
 from partstb where iid = @iid
update itemtb set parts=@parts where id = @iid"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        partsGRID.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@iid", itemFRM.id)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "PARTSTB")
                        bs.DataSource = ds
                        bs.DataMember = "PARTSTB"
                        partsGRID.DataSource = bs
                        addcolumns()
                        With partsGRID
                            .Columns("ID").Visible = False
                            .Columns("IID").Visible = False
                            .Columns("ARTICLE NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("MARKUP").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("UNIT PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("QTY").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("NET AMOUNT").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub addcolumns()

        Dim deletebtn As New DataGridViewButtonColumn

        With deletebtn
            .Text = "delete"
            .HeaderText = ""
            .Name = "deletebtn"
            .UseColumnTextForButtonValue = True
        End With
        With partsGRID.Columns
            .Insert(8, deletebtn)
        End With
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadparts()
    End Sub
    Private Sub partsGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles partsGRID.CellClick
        If partsGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            id = partsGRID.Item("id", e.RowIndex).Value.ToString
            articleno.Text = partsGRID.Item("article no", e.RowIndex).Value.ToString
            description.Text = partsGRID.Item("description", e.RowIndex).Value.ToString
            markup.Text = partsGRID.Item("markup", e.RowIndex).Value.ToString
            unitprice.Text = partsGRID.Item("UNIT PRICE", e.RowIndex).Value.ToString
            qty.Text = partsGRID.Item("QTY", e.RowIndex).Value.ToString
            netamount.Text = partsGRID.Item("NET AMOUNT", e.RowIndex).Value.ToString

            If e.ColumnIndex = 8 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & partsGRID.Item("article no", e.RowIndex).Value.ToString & "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    id = partsGRID.Item("id", e.RowIndex).Value.ToString
                    Dim str As String = "delete from partstb where id = @id"
                    Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                        Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                            Try
                                sqlcon.Open()
                                sqlcmd.Parameters.AddWithValue("@id", id)
                                sqlcmd.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.ToString)
                            End Try
                        End Using
                    End Using
                    refreshbtn.PerformClick()
                End If
            End If
        End If
    End Sub

    Private Sub partsGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles partsGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub KryptonLabel2_Paint(sender As Object, e As PaintEventArgs) Handles KryptonLabel2.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        zero(markup)
        zero(unitprice)
        zero(qty)
        zero(netamount)
        add()
        refreshbtn.PerformClick()
    End Sub
    Public Sub add()
        Dim str As String = "
                    declare @id as integer = (select isnull(max(id),0)+1 from partstb)
                    insert into partstb (id,iid,articleno,description,markup,unitprice,qty,netamount)
                    values (@id,@iid,@articleno,@description,@markup,@unitprice,@qty,@netamount)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@iid", itemFRM.id)
                    sqlcmd.Parameters.AddWithValue("@articleno", articleno.Text)
                    sqlcmd.Parameters.AddWithValue("@description", description.Text)
                    sqlcmd.Parameters.AddWithValue("@markup", markup.Text)
                    sqlcmd.Parameters.AddWithValue("@unitprice", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@qty", qty.Text)
                    sqlcmd.Parameters.AddWithValue("@netamount", netamount.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Public Sub update()
        Dim str As String = "
                 
                    update partstb set articleno=@articleno,description=@description,markup=@markup,unitprice=@unitprice,qty=@qty,netamount=@netamount
                    where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@articleno", articleno.Text)
                    sqlcmd.Parameters.AddWithValue("@description", description.Text)
                    sqlcmd.Parameters.AddWithValue("@markup", markup.Text)
                    sqlcmd.Parameters.AddWithValue("@unitprice", unitprice.Text)
                    sqlcmd.Parameters.AddWithValue("@qty", qty.Text)
                    sqlcmd.Parameters.AddWithValue("@netamount", netamount.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Public Sub zero(ByVal x As Object)
        If x.Text = "" Then
            x.Text = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        zero(markup)
        zero(unitprice)
        zero(qty)
        zero(netamount)
        update()
        refreshbtn.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        loadaccessories()
    End Sub
    Public Sub loadaccessories()
        Dim str As String = "select ID,
                            SPECIFICATION,
                            ARTICLENO as [ARTICLE NO],
                            DESCRIPTION,
                            UNIT,
                            UNITPRICE AS [UNIT PRICE],
                            REMARKS
                            from ACCESSORIESTB 
                            where 
                            description like @description and
                            articleno like @articleno and
                            specification like @specification"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        sqlcon.Open()
                        knogv.Columns.Clear()
                        sqlcmd.Parameters.AddWithValue("@description", "%" & ComboBox1.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@articleno", "%" & ComboBox2.Text & "%")
                        sqlcmd.Parameters.AddWithValue("@specification", "%" & specification.Text & "%")
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ACCESSORIESTB")
                        bs2.DataSource = ds
                        bs2.DataMember = "ACCESSORIESTB"


                        With knogv
                            .Columns("ID").Visible = False
                            .Columns("UNIT PRICE").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("SPECIFICATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("ARTICLE NO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("DESCRIPTION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("UNIT").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("REMARKS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub

    Private Sub knogv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles knogv.CellClick
        If knogv.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = knogv.Rows(e.RowIndex)
            articleno.Text = row.Cells("article no").Value.ToString
            description.Text = row.Cells("description").Value.ToString
            unitprice.Text = row.Cells("unit price").Value.ToString
        End If
    End Sub
End Class