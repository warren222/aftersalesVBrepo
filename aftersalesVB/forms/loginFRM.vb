Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class loginFRM
    Dim sql As New sql
    Private Sub loginFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub loginFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Private Sub login()
        Dim str As String = "select FULLNAME,ASACCT from kmdi_acct_tb where username = @username and password COLLATE Latin1_General_CS_AS = @password and not asacct = ''"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@UserName", username.Text)
                    sqlcmd.Parameters.AddWithValue("@Password", Encrypt(password.Text))
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows = True Then
                            While rd.Read
                                accttype = rd(1).ToString
                                fullname = rd(0).ToString
                            End While
                            mainform.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Invalid Login", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        login()
    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyData = Keys.Enter Then
            save.PerformClick()
        End If
    End Sub
End Class