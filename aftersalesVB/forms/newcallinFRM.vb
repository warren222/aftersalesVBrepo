Imports System.Data.SqlClient
Imports MetroFramework

Public Class newcallinFRM
    Dim sql As New sql
    Dim qid As String
    Dim qbs As New BindingSource
    Dim abs As New BindingSource
    Public Shared concern As String = ""
    Private Sub newcallinFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Height = Screen.PrimaryScreen.Bounds.Height - 37
        loadconcern()
        Dim clr As Color




        If Me.Text = "Editing" Then
            clr = Color.Red
            cin.Visible = True
            KryptonLabel4.Visible = True
            If concern.Contains("Window") Then
                Windowchk.Checked = True
            End If
            If concern.Contains("Door") Then
                doorchk.Checked = True
            End If
            If concern.Contains("Screen") Then
                screenchk.Checked = True
            End If
            If concern.Contains("Glass") Then
                glasschk.Checked = True
            End If
            If concern.Contains("Mechanism") Then
                mechanismchk.Checked = True
            End If
            If concern.Contains("Not Specified") Then
                notspecifiedchk.Checked = True
            End If
        Else
            clr = Color.Black
            cin.Visible = False
            KryptonLabel4.Visible = False
        End If
        ccolor(calldate, clr)
        ccolor(callername, clr)
        ccolor(telno, clr)
        ccolor(faxno, clr)
        ccolor(cin, clr)
        ccolor(conversation, clr)
    End Sub
    Private Sub ccolor(ByVal ob As Object, ByVal c As Color)
        ob.ForeColor = c
    End Sub
    Public Sub loadconcern()
        questionGRID.ClearSelection()
        Dim str As String
        If Me.Text = "New" Then
            str = "update answertb set chk = '0'
                   select qid,ITEM,QUESTION AS [(Specification) Question] from questionnairetb order by item asc"
        Else
            str = "select qid,ITEM,QUESTION AS [(Specification) Question] from questionnairetb order by item asc"
        End If

        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "questionnairetb")
                        qbs.DataSource = ds
                        qbs.DataMember = "questionnairetb"
                        questionGRID.DataSource = qbs
                        setcolumns(questionGRID)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End Using
    End Sub
    Public Sub setcolumns(ByVal dg As DataGridView)
        dg.Columns("qid").Visible = False
        dg.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dg.Columns("(Specification) Question").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub

    Private Sub questionGRID_SelectionChanged(sender As Object, e As EventArgs) Handles questionGRID.SelectionChanged
        Dim selecteditems As DataGridViewSelectedRowCollection = questionGRID.SelectedRows
        For Each row As DataGridViewRow In selecteditems
            qid = row.Cells("qid").Value.ToString
            qsFRM.id = row.Cells("qid").Value.ToString
        Next
        loadanswer()
    End Sub

    Public Sub loadanswer()
        Dim str As String = "SELECT aid,qid,chk,ITEM,ANSWER AS CONCERN FROM ANSWERTB WHERE QID = @qid"
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Using da As SqlDataAdapter = New SqlDataAdapter()
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@qid", qid)
                        da.SelectCommand = sqlcmd
                        da.Fill(ds, "ANSWERTB")
                        abs.DataSource = ds
                        abs.DataMember = "ANSWERTB"
                        answerGV.DataSource = abs
                        answerGV.Columns("aid").Visible = False
                        answerGV.Columns("qid").Visible = False
                        answerGV.Columns("chk").Visible = False
                        answerGV.Columns(Column1.Name).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        answerGV.Columns("item").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        answerGV.Columns("CONCERN").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
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

    Private Sub answerGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles answerGV.CellClick
        If answerGV.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim aid As String = ""
            Dim m As String = ""
            Dim row As DataGridViewRow = answerGV.Rows(e.RowIndex)
            aid = row.Cells("aid").Value.ToString
            Dim chkd As Boolean = Convert.ToBoolean(row.Cells(Column1.Name).Value)
            If chkd = True Then
                row.Cells(Column1.Name).Value = False
                m = "0"
            Else
                row.Cells(Column1.Name).Value = True
                m = "1"
            End If
            Dim str As String = "update answertb set chk = @m where aid = @aid"
            Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
                Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                    Try
                        sqlcon.Open()
                        sqlcmd.Parameters.AddWithValue("@m", m)
                        sqlcmd.Parameters.AddWithValue("@aid", aid)
                        sqlcmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub metroTextButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As selectprojectFRM = New selectprojectFRM
        f.ShowDialog()
    End Sub

    Private Sub addBTN_Click(sender As Object, e As EventArgs) Handles addBTN.Click
        If jo.Text = "Job Order No" Then
            MetroMessageBox.Show(Me, "Select Project", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim wndwtxt As String
        Dim doortxt As String
        Dim screentxt As String
        Dim glasstxt As String
        Dim mechanismtxt As String
        Dim notspecifiedtxt As String
        concern = ""
        If Windowchk.Checked = True Then
            wndwtxt = " Window "
        End If
        If doorchk.Checked = True Then
            doortxt = " Door "
        End If
        If screenchk.Checked = True Then
            screentxt = " Screen "
        End If
        If glasschk.Checked = True Then
            glasstxt = " Glass "
        End If
        If mechanismchk.Checked = True Then
            mechanismtxt = " Mechanism "
        End If
        If notspecifiedchk.Checked = True Then
            notspecifiedtxt = " Not Specified "
        End If
        concern = wndwtxt + doortxt + screentxt + glasstxt + mechanismtxt + notspecifiedtxt
        Dim str As String = "Declare @autonum as integer = (select isnull(max(autonum),0)+1 from callintb)
                                insert into callintb
                                (autonum,
                                cdate,
                                cin,
                                caller,
                                jo,
                                TELNO,
                                FAXNO,
                                concern,
                                conversation)
                                values
                                (@autonum,
                                @cdate,
                                ((left(CONVERT([varchar](7),@autonum),(2))+'-')+right(CONVERT([varchar](7),@autonum),(5))),                           
                                @caller,
                                @jo,
                                @TELNO,
                                @FAXNO,
                                @concern,
                                @conversation)
                                INSERT INTO QATB (CIN,AID) SELECT ((left(CONVERT([varchar](7),@autonum),(2))+'-')+right(CONVERT([varchar](7),@autonum),(5))),AID FROM ANSWERTB WHERE CHK=1
                                UPDATE ANSWERTB SET CHK=0"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd.Parameters
                        .AddWithValue("@jo", jo.Text)
                        .AddWithValue("@cdate", calldate.Text)
                        .AddWithValue("@caller", callername.Text)
                        .AddWithValue("@TELNO", telno.Text)
                        .AddWithValue("@FAXNO", faxno.Text)
                        .AddWithValue("@concern", concern)
                        .AddWithValue("@conversation", conversation.Text)
                    End With
                    sqlcmd.ExecuteNonQuery()
                    MetroMessageBox.Show(Me, "Record Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        mainform.reloadBTN.PerformClick()
    End Sub

    Private Sub calldategen_ValueChanged(sender As Object, e As EventArgs) Handles calldategen.ValueChanged
        calldate.Text = calldategen.Text
    End Sub

    Private Sub calldategen_MouseDown(sender As Object, e As MouseEventArgs) Handles calldategen.MouseDown
        calldate.Text = calldategen.Text
    End Sub

    Private Sub newcallinFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainform.callinGRID.ClearSelection()
        Me.Dispose()
    End Sub

    Private Sub updateBTN_Click(sender As Object, e As EventArgs) Handles updateBTN.Click
        If jo.Text = "Job Order No" Then
            MetroMessageBox.Show(Me, "Select Project", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim bol As Boolean
        Dim find As String = "select * from callintb where cin=@newcin and not cin=@cin"
        Using SQLCON As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(find, SQLCON)
                Try
                    SQLCON.Open()
                    sqlcmd.Parameters.AddWithValue("cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("newcin", cin.Text)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        If rd.HasRows = True Then
                            bol = True
                        Else
                            bol = False
                        End If
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using

        Dim anum As String = cin.Text.Replace("-", "")
        If bol = True Then
            MetroMessageBox.Show(Me, "Duplicate CIN#!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not IsNumeric(anum) Then
            MetroMessageBox.Show(Me, "Invalid CIN# Format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim wndwtxt As String
        Dim doortxt As String
        Dim screentxt As String
        Dim glasstxt As String
        Dim mechanismtxt As String
        Dim notspecifiedtxt As String
        concern = ""
        If Windowchk.Checked = True Then
            wndwtxt = " Window "
        End If
        If doorchk.Checked = True Then
            doortxt = " Door "
        End If
        If screenchk.Checked = True Then
            screentxt = " Screen "
        End If
        If glasschk.Checked = True Then
            glasstxt = " Glass "
        End If
        If mechanismchk.Checked = True Then
            mechanismtxt = " Mechanism "
        End If
        If notspecifiedchk.Checked = True Then
            notspecifiedtxt = " Not Specified "
        End If
        concern = wndwtxt + doortxt + screentxt + glasstxt + mechanismtxt + notspecifiedtxt

        Dim str As String = "
                            update callintb set
                            cdate=@cdate,
                            caller=@caller,
                            jo=@jo,
                            TELNO=@TELNO,
                            FAXNO=@FAXNO,
                            concern = @concern,
                            conversation=@conversation
                            where cin = @cin
                            insert into qatb (cin,aid) select @cin,aid from answertb where chk = '1' and not aid in (select aid from qatb where cin = @cin)
                            delete from qatb where cin = @cin and not aid in (select aid from answertb where chk = '1')

                            update callintb set cin=@newcin,autonum=@anum where cin = @cin
                            update qatb set cin=@newcin where cin = @cin
                            update quotationtb set cin=@newcin where cin = @cin
                            update servicingtb set cin=@newcin where cin = @cin"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@cdate", calldate.Text)
                    sqlcmd.Parameters.AddWithValue("@caller", callername.Text)
                    sqlcmd.Parameters.AddWithValue("@jo", jo.Text)
                    sqlcmd.Parameters.AddWithValue("@cin", mainform.tempcin)
                    sqlcmd.Parameters.AddWithValue("@newcin", cin.Text)
                    sqlcmd.Parameters.AddWithValue("@anum", anum)
                    sqlcmd.Parameters.AddWithValue("@TELNO", telno.Text)
                    sqlcmd.Parameters.AddWithValue("@FAXNO", faxno.Text)
                    sqlcmd.Parameters.AddWithValue("@concern", concern)
                    sqlcmd.Parameters.AddWithValue("@conversation", conversation.Text)
                    sqlcmd.ExecuteNonQuery()
                    MetroMessageBox.Show(Me, "Data Updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        mainform.reloadBTN.PerformClick()
    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        projectname.Text = "null"
        address.Text = "null"
        jo.Text = "null"
    End Sub

    Private Sub MetroTextButton3_Click(sender As Object, e As EventArgs) Handles MetroTextButton3.Click
        newqsFRM.fromcallin = True
        newqsFRM.question.Text = ""
        newqsFRM.item.Text = ""
        newqsFRM.Text = "New"
        newqsFRM.save.Text = "add"
        newqsFRM.ShowDialog()
    End Sub

    Private Sub MetroTextButton4_Click(sender As Object, e As EventArgs) Handles MetroTextButton4.Click
        newconcernFRM.fromcallin = True
        newconcernFRM.item.Text = ""
        newconcernFRM.concern.Text = ""
        newconcernFRM.Text = "New"
        newconcernFRM.save.Text = "add"
        newconcernFRM.ShowDialog()
    End Sub
End Class