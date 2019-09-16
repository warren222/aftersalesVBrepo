Imports System.Data.SqlClient


Public Class evaFRM
    Dim sql As New sql
    Private Sub evaFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MessageBox.Show("save changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        EVALUATION.Text = EVALUATION.Text.Replace("'", "`")
        UPDATESUB()
    End Sub
    Dim sid As String = servicingFRM.id
    Private Sub UPDATESUB()
        Dim STR As String = "

DECLARE @SID AS VARCHAR(100) = '" & sid & "'
DECLARE @COMPLETION AS VARCHAR(max) = '" & dated.Text & "'
DECLARE @EVALUATION AS VARCHAR(max) = '" & EVALUATION.Text & "'
DECLARE @COUNT AS INTEGER = (SELECT COUNT(ISNULL(ID,0)) FROM EVALUATIONTB WHERE SID = @SID)


DECLARE @QRY AS VARCHAR(MAX)
				SET @QRY=
				(
				CASE WHEN @COUNT >0 THEN
				'UPDATE EVALUATIONTB SET EVALUATION = '''+@EVALUATION+''', COMPLETION = '''+@COMPLETION+''' WHERE SID = '''+@SID+''''
				ELSE

				'DECLARE @ID AS INTEGER = (SELECT ISNULL(MAX(ISNULL(ID,0)),0)+1 FROM EVALUATIONTB)
				INSERT INTO EVALUATIONTB (ID,SID,EVALUATION,COMPLETION)VALUES(@ID,'''+@SID+''','''+@EVALUATION+''','''+@COMPLETION+''')'
				END
				)

				EXEC(@QRY)
"
        Using SQLCON As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using SQLCMD As SqlCommand = New SqlCommand(STR, SQLCON)
                Try
                    SQLCON.Open()
                    SQLCMD.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    MessageBox.Show("changes saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            End Using
        End Using
    End Sub

    Private Sub evaFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadform()
    End Sub
    Private Sub loadform()
        Dim str As String = "select evaluation,completion from evaluationtb where sid = @sid"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@sid", sid)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            EVALUATION.Text = rd(0).ToString
                            dated.Text = rd(1).ToString
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub calldategen_ValueChanged(sender As Object, e As EventArgs) Handles calldategen.ValueChanged, calldategen.MouseDown
        dated.Text = calldategen.Text
    End Sub
End Class