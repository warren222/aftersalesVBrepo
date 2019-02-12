Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Data.SqlClient
Public Class scannedreportFRM
    Public Shared id As String
    Dim sql As New sql
    Dim objImage As MemoryStream
    Dim objwebClient As WebClient
    Dim srcBmp As Bitmap
    Dim newfilename As String
    Dim totalPages As Integer
    Dim currentPage As Integer = 0
    Dim nimage As String
    Dim imglist As New ArrayList
    Dim defloc As String
    Private Sub BROWSE_Click(sender As Object, e As EventArgs) Handles browsebttn.Click
        OpenFileDialog1.InitialDirectory = defloc
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            defloc = OpenFileDialog1.FileName.ToString.Replace("" & OpenFileDialog1.SafeFileName & "", "")
            imagepath.Text = OpenFileDialog1.FileName

            loadimagetopicturebox3(imagepath.Text)

            savebtn.Visible = True
            cancelbtn.Visible = True
        End If
    End Sub

    Private Sub imagepath_TextChanged(sender As Object, e As EventArgs) Handles imagepath.TextChanged

    End Sub
    Public Sub loadimagetopicturebox3(ByVal path As String)
        Dim objwebClient As WebClient
        Dim sURL As String = Trim(path)
        Try
            objwebClient = New WebClient()
            objImage = New MemoryStream(objwebClient.DownloadData(sURL))
            srcBmp = CType(Bitmap.FromStream(objImage), Bitmap)
            totalPages = CInt(srcBmp.GetFrameCount(FrameDimension.Page) - 1)
            srcBmp.SelectActiveFrame(FrameDimension.Page, currentPage)
            PictureBox1.Image = srcBmp
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Panel1.Visible = False
        Panel2.Visible = True
        If Panel2.Visible = True Then
            loadimagetopicturebox3(ComboBox1.Text)
            Dim pto As Integer = ComboBox1.Items.Count
            KryptonLabel2.Text = "" & ComboBox1.SelectedIndex + 1 & "" + " of " + "" & pto & ""
            Dim x As Integer = ComboBox1.Items.Count - 1
            If ComboBox1.SelectedIndex = x Then
                nxt.Enabled = False
            Else
                nxt.Enabled = True
            End If
            If ComboBox1.SelectedIndex = 0 Then
                prev.Enabled = False
            Else
                prev.Enabled = True
            End If
        End If
    End Sub
    Private Sub countimg()

        Dim str As String = "select isnull(count(isnull(img,0)),0)+1 from cinreporttb where cin = @cin and id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            nimage = rd(0).ToString
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("invalid image", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            countimg()
            Dim subPath As String = "\\Kmdisqlserver\kmdiimagefile2\AftersalesReports\" & mainform.tempcin & "\" & id & ""
            Dim IsExists As Boolean = System.IO.Directory.Exists(subPath)
            If Not IsExists Then
                System.IO.Directory.CreateDirectory(subPath)
            End If
            SaveFileDialog1.InitialDirectory = subPath
            SaveFileDialog1.FileName = OpenFileDialog1.SafeFileName
            SaveFileDialog1.Filter = "JPG Image|*.jpg|Tiff Image|*.tif"
            SaveFileDialog1.Title = "Save an Image File"
            Dim DialogResult As DialogResult = SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName <> "" Then
                Select Case SaveFileDialog1.FilterIndex
                    Case 1
                        If (DialogResult = DialogResult.OK) Then
                            addnewimage()
                            loadimglist()
                            My.Computer.FileSystem.CopyFile("" & imagepath.Text & "",
                                  "" & SaveFileDialog1.FileName & "",
                                  Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                  Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                        ElseIf (DialogResult = DialogResult.Cancel) Then
                        End If
                    Case 2
                        If (DialogResult = DialogResult.OK) Then
                            addnewimage()
                            loadimglist()
                            My.Computer.FileSystem.CopyFile("" & imagepath.Text & "",
                                 "" & SaveFileDialog1.FileName & "",
                                 Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                 Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
                        ElseIf (DialogResult = DialogResult.Cancel) Then
                        End If
                    Case 3
                        '     PictureBox3.Image.Save(fs,
                        'System.Drawing.Imaging.ImageFormat.Gif)
                End Select

                'fs.Close()
            End If
        End If
    End Sub
    Public Sub addnewimage()
        Dim x As String = SaveFileDialog1.FileName
        x = x.Replace("\\Kmdisqlserver\kmdiimagefile2\", "http://121.58.229.248:8083/")
        x = x.Replace("\", "/")
        Dim str As String = "insert into cinreporttb (cin,id,img)values(@cin,@id,@img)"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@img", x)
                    sqlcmd.ExecuteNonQuery()
                    MessageBox.Show("image added", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub loadimglist()
        Dim bs As New BindingSource
        Dim str As String = "select img FROM cinreporttb where id = @id and cin = @cin order by img asc"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    Dim ds As New DataSet
                    ds.Clear()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    Using da As SqlDataAdapter = New SqlDataAdapter
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "cinreporttb")
                        bs.DataSource = ds
                        bs.DataMember = "cinreporttb"
                        ComboBox1.DataSource = bs
                        ComboBox1.DisplayMember = "img"
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub scannedreportFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub scannedreportFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadimglist()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Panel2.Visible = True Then
            loadimagetopicturebox3(ComboBox1.Text)
            Dim pto As Integer = ComboBox1.Items.Count
            KryptonLabel2.Text = "" & ComboBox1.SelectedIndex + 1 & "" + " of " + "" & pto & ""

            Dim x As Integer = ComboBox1.Items.Count - 1
            If ComboBox1.SelectedIndex = x Then
                nxt.Enabled = False
            Else
                nxt.Enabled = True
            End If
            If ComboBox1.SelectedIndex = 0 Then
                prev.Enabled = False
            Else
                prev.Enabled = True
            End If
        End If
    End Sub

    Private Sub prev_Click(sender As Object, e As EventArgs) Handles prev.Click
        Dim x As Integer = ComboBox1.SelectedIndex
        If x > 0 Then
            ComboBox1.SelectedIndex = x - 1
        Else
            Return
        End If
    End Sub

    Private Sub nxt_Click(sender As Object, e As EventArgs) Handles nxt.Click
        Dim x As Integer = ComboBox1.SelectedIndex
        If x < ComboBox1.Items.Count - 1 Then
            ComboBox1.SelectedIndex = x + 1
        Else
            Return
        End If
    End Sub

    Private Sub first_Click(sender As Object, e As EventArgs) Handles first.Click
        If ComboBox1.Items.Count >= 1 Then
            ComboBox1.SelectedIndex = 0
        Else
        End If
    End Sub

    Private Sub last_Click(sender As Object, e As EventArgs) Handles last.Click
        Dim x As Integer = ComboBox1.Items.Count - 1
        ComboBox1.SelectedIndex = x
    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        PictureBox1.Image = Nothing
        Panel1.Visible = True
        Panel2.Visible = False
        PictureBox1.ImageLocation = ""
    End Sub
    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        If MessageBox.Show("Delete this image?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        deleteimg()
        loadimglist()
    End Sub
    Public Sub deleteimg()
        Dim str As String = "delete from cinreporttb where id=@id and cin=@cin and img=@img"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@id", id)
                    sqlcmd.Parameters.AddWithValue("@img", ComboBox1.Text)
                    sqlcmd.ExecuteNonQuery()

                    Dim path As String = ComboBox1.Text.Replace("/", "\")
                    path = path.Replace("http:\\121.58.229.248:8083\", "\\kmdisqlserver\KMDIIMAGEFILE2\")
                    My.Computer.FileSystem.DeleteFile(path)
                    MessageBox.Show("Image Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PictureBox1.Image = Nothing
                    KryptonLabel2.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class