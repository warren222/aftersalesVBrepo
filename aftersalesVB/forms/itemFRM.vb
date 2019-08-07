Imports System.Data.SqlClient
Public Class itemFRM
    Dim sql As New sql
    Public id As String
    Dim bs As New BindingSource
    Dim bs2 As New BindingSource
    Private Sub itemFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Bottom - 37
        loaditems()
        knogv.DataSource = bs2
    End Sub
    Public Sub loaditems()
        Dim str As String = "select 
ID,
ASENO,
ITEM,
KNO AS [K#],
WDWLOC as [WDW/DOOR LOCATION],
PARTS
from itemtb where aseno = @aseno

"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    Try
                        itemGRID.Columns.Clear()
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@qid", quotationFRM.id)
                        sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "itemtb")
                        bs.DataSource = ds
                        bs.DataMember = "itemtb"
                        itemGRID.DataSource = bs
                        addcolumns()
                        With itemGRID
                            .Columns("ID").Visible = False
                            .Columns("ASENO").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("ITEM").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("K#").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                            .Columns("WDW/DOOR LOCATION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        End With
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
        totalsummary()
    End Sub
    Public Sub addcolumns()

        Dim deletebtn As New DataGridViewButtonColumn
        Dim partsbtn As New DataGridViewButtonColumn

        With deletebtn
            .Text = "delete"
            .HeaderText = ""
            .Name = "deletebtn"
            .UseColumnTextForButtonValue = True
        End With
        With partsbtn
            .Text = "parts"
            .HeaderText = ""
            .Name = "partsbtn"
            .UseColumnTextForButtonValue = True
        End With
        With itemGRID
            .Columns.Insert(6, partsbtn)

            .Columns.Insert(7, deletebtn)
        End With
    End Sub

    Private Sub itemFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loaditems()
    End Sub
    Private Sub totalsummary()
        Dim str As String = "declare @unitprice as decimal(10,2) = (select 
                                                                      sum(b.UNITPRICE*b.qty) from ITEMTB as a
                                                                      inner join partstb as b on a.id = b.iid and a.aseno = @aseno)
                             declare @netprice as decimal(10,2) = (select 
                                                                      sum(b.NETAMOUNT) from ITEMTB as a
                                                                      inner join partstb as b on a.id = b.iid and a.aseno = @aseno)

                             select @unitprice,@netprice
"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            unitprice.Text = rd(0).ToString
                            netprice.Text = rd(1).ToString
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub itemGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles itemGRID.CellClick
        If itemGRID.RowCount >= 0 And e.RowIndex >= 0 Then

            id = itemGRID.Item("id", e.RowIndex).Value.ToString
            kno.Text = itemGRID.Item("k#", e.RowIndex).Value.ToString
            itemno.Text = itemGRID.Item("item", e.RowIndex).Value.ToString
            wdwloc.Text = itemGRID.Item("WDW/DOOR LOCATION", e.RowIndex).Value.ToString
            If e.ColumnIndex = 6 Then
                id = itemGRID.Item("id", e.RowIndex).Value.ToString
                partsFRM.KryptonLabel13.Text = "" & itemGRID.Item("k#", e.RowIndex).Value.ToString & ", " & itemGRID.Item("item", e.RowIndex).Value.ToString & ", " & itemGRID.Item("WDW/DOOR LOCATION", e.RowIndex).Value.ToString & ""
                partsFRM.ShowDialog()
            ElseIf e.ColumnIndex = 7 Then
                If MetroFramework.MetroMessageBox.Show(Me, "Delete " & itemGRID.Item("k#", e.RowIndex).Value.ToString & "", "Confirmatioon", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                    Return
                Else
                    id = itemGRID.Item("id", e.RowIndex).Value.ToString
                    Dim str As String = "delete from itemtb where id = @id"
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
                    loaditems()
                End If
            End If
        End If
    End Sub


    Private Sub itemGRID_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles itemGRID.RowPostPaint
        sql.rownum(sender, e)
    End Sub

    Private Sub KryptonLabel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String = "select a.kmdi_no,a.item_no,a.location,a.description from KMDI_FABRICATION_TB as a
                            inner join ADDENDUM_TO_CONTRACT_TB as b
                            on a.job_order_no = b.job_order_no
                            where a.[status] = '' and b.lock = 0
                            and b.parentjono = @jo

                            union all

                            select a.kmdi_no,a.item_no,a.location,a.description from KMDI_screenFAB_TB as a
                            inner join ADDENDUM_TO_CONTRACT_TB as b
                            on a.job_order_no = b.job_order_no
                            where a.[status] = '' and b.lock = 0
                            and b.parentjono = @jo"
        Dim ds As New DataSet

        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@jo", mainform.jo)
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.SelectCommand.CommandTimeout = 30000
                        da.Fill(ds, "kmdi_fabrication_tb")
                    End Using
                    bs2.DataSource = ds
                    bs2.DataMember = "kmdi_fabrication_tb"
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    sqlcon.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "declare @id as integer = (select isnull(max(id),0)+1 from itemtb)
                            insert into itemtb (id,aseno,ITEM,kno,wdwloc)
                            values(@id,@aseno,@item,@kno,@loc)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    sqlcmd.Parameters.AddWithValue("@item", itemno.Text)
                    sqlcmd.Parameters.AddWithValue("@kno", kno.Text)
                    sqlcmd.Parameters.AddWithValue("@loc", wdwloc.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        refreshbtn.PerformClick()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim str As String = "
                            update itemtb set
                            ITEM=@item,kno=@kno,
                            wdwloc=@loc WHERE ID = @ID"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@aseno", quotationFRM.aseno)
                    sqlcmd.Parameters.AddWithValue("@item", itemno.Text)
                    sqlcmd.Parameters.AddWithValue("@kno", kno.Text)
                    sqlcmd.Parameters.AddWithValue("@loc", wdwloc.Text)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        refreshbtn.PerformClick()
    End Sub

    Private Sub knogv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles knogv.CellClick
        If knogv.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim ROW As DataGridViewRow = knogv.Rows(e.RowIndex)
            kno.Text = ROW.Cells("KMDI_NO").Value.ToString
            itemno.Text = ROW.Cells("ITEM_NO").Value.ToString
            wdwloc.Text = ROW.Cells("LOCATION").Value.ToString
        End If
    End Sub
End Class