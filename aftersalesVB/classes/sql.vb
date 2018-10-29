Imports System.Data.SqlClient
Public Class sql
    Public sqlcon1 As New SqlConnection With {.ConnectionString = "data source='192.168.1.21,49107';
                                                                   initial catalog='ASDB';
                                                                   network library='DBMSSOCN';
                                                                   user id='kmdiadmin';
                                                                   password='kmdiadmin';"}
    Public sqlcon2 As New SqlConnection With {.ConnectionString = "data source='192.168.1.21,49107';
                                                                   initial catalog='heretosave';
                                                                   network library='DBMSSOCN';
                                                                   user id='kmdiadmin';
                                                                   password='kmdiadmin';"}
    Public sqlcon1str As String = sqlcon1.ConnectionString.ToString
    Public sqlcon2str As String = sqlcon2.ConnectionString.ToString
End Class
