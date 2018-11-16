Imports System.Data.SqlClient

Public Class partsFRM
    Dim sql As New sql
    Public id As String
    Dim bs As New BindingSource
    Private Sub partsFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub partsFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadparts()
    End Sub
    Public Sub loadparts()
        Dim str As String = "

declare @unitprice as decimal(10,2) = (select sum(unitprice) from partstb where iid = @iid)
declare @qty as decimal(10,2) = (select sum(qty) from partstb where iid = @iid)
declare @netamount as decimal(10,2) = (select sum(netamount) from partstb where iid = @iid)
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
update itemtb set unitprice =@unitprice,qty=@qty,netprice=@netamount,parts=@parts where id = @iid"
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
        Dim updatebtn As New DataGridViewButtonColumn
        Dim deletebtn As New DataGridViewButtonColumn

        With updatebtn
            .Text = "update"
            .HeaderText = ""
            .Name = "updatebtn"
            .UseColumnTextForButtonValue = True
        End With
        With deletebtn
            .Text = "delete"
            .HeaderText = ""
            .Name = "deletebtn"
            .UseColumnTextForButtonValue = True
        End With
        With partsGRID.Columns
            .Insert(8, updatebtn)
            .Insert(9, deletebtn)
        End With
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        loadparts()
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        newpartsFRM.Text = "New"
        newpartsFRM.save.Text = "add"
        newpartsFRM.ShowDialog()
    End Sub

    Private Sub partsGRID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles partsGRID.CellClick
        If partsGRID.RowCount >= 0 And e.RowIndex >= 0 Then
            If e.ColumnIndex = 8 Then
                newpartsFRM.Text = "Editing"
                newpartsFRM.save.Text = "save"
                id = partsGRID.Item("id", e.RowIndex).Value.ToString
                newpartsFRM.articleno.Text = partsGRID.Item("article no", e.RowIndex).Value.ToString
                newpartsFRM.description.Text = partsGRID.Item("description", e.RowIndex).Value.ToString
                newpartsFRM.markup.Text = partsGRID.Item("markup", e.RowIndex).Value.ToString
                newpartsFRM.unitprice.Text = partsGRID.Item("UNIT PRICE", e.RowIndex).Value.ToString
                newpartsFRM.qty.Text = partsGRID.Item("QTY", e.RowIndex).Value.ToString
                newpartsFRM.netamount.Text = partsGRID.Item("NET AMOUNT", e.RowIndex).Value.ToString
                newpartsFRM.ShowDialog()
            ElseIf e.ColumnIndex = 9 Then
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
End Class