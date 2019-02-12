Imports System.Data.SqlClient
Public Class sql
    Public sqlcon1 As New SqlConnection With {.ConnectionString = "data source='192.168.1.21,49107';
                                                                   initial catalog='ASDB';
                                                                   network library='DBMSSOCN';
                                                                   user id='kmdiadmin';
                                                                   password='kmdiadmin';"}
    Public sqlcon2 As New SqlConnection With {.ConnectionString = "data source='192.168.1.21,49107';
                                                                   initial catalog='kmdidata';
                                                                   network library='DBMSSOCN';
                                                                   user id='kmdiadmin';
                                                                   password='kmdiadmin';"}
    Public sqlcon1str As String = sqlcon1.ConnectionString.ToString
    Public sqlcon2str As String = sqlcon2.ConnectionString.ToString
    Public Sub rownum(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        e.PaintHeader(DataGridViewPaintParts.Background)
        Dim rowIdx As String = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Microsoft Sans Serif", 8.0!,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat = New StringFormat()
        centerFormat.Alignment = StringAlignment.Far
        centerFormat.LineAlignment = StringAlignment.Near
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub
End Class
