Imports System.Data.SqlClient

Public Class selectedsystemFRM
    Dim sql As New sql
    Private Sub selectedsystemFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case seelctedsystem.Text
            Case "Framing System"
                invicategory(False)
                invicolor(True)
                loadcolors(pf)
                invi(False)
            Case "Glazing System"
                CATEGORYlabel.Text = "Glass specs"
                invicategory(True)
                invi(False)
                invicolor(False)
            Case "Weather Tightness"
                CATEGORYlabel.Text = "Seals"
                invicategory(True)
                invi(False)
                invicolor(False)
            Case "Mechanism"
                CATEGORYlabel.Text = "Hardware"
                invicategory(True)
                invi(False)
                invicolor(False)
            Case "Insect Protection System"
                invicategory(True)
                invi(True)
                invicolor(False)
                CATEGORYlabel.Text = "Insect Screens"
        End Select
        Label15.Text = CATEGORYlabel.Text
        sumgv.DataSource = sumbs
        loadsum()


    End Sub

    Private Sub invi(ByVal bol As Boolean)
        Label1.Visible = bol
        OTHERSYSTEMTXT.Visible = bol
    End Sub
    Private Sub invicolor(ByVal bol As Boolean)
        Label16.Visible = bol
        pf.Visible = bol
    End Sub
    Private Sub invicategory(ByVal bol As Boolean)
        CATEGORYlabel.Visible = bol
        category.Visible = bol
    End Sub
    Public Sub loadcolors(ByVal ob As Object)
        ob.Items.Clear()
        Dim words As String()
        Dim comma As Char = ","
        words = mainform.ccolor.Split(comma)
        Dim word As String
        For Each word In words
            If word.Contains(",") Then
                word = word.Replace(",", "")
            End If
            ob.Items.Add(word)
        Next
    End Sub
    Dim sumbs As New BindingSource
    Private Sub loadsum()
        Dim ds As New DataSet
        ds.Clear()
        Dim str As String
        Select Case seelctedsystem.Text
            Case "Framing System"
                str = "Select id,'  **  '+PARTS+' '+isnull(color,'')+''+'  >>>  '+QUALITYASPECT+'  >>  '+POSSIBLEISSUE+'  >  '+POSSIBLESOLUTION from ASSESSMENTREPORTTB where rid = @rid and system = @system"
            Case "Insect Protection System"
                str = "select id,'  *** '+OTHERSYSTEM + '  **  '+PARTS+'  *  '+CATEGORY+'  >>>  '+QUALITYASPECT+'  >>  '+POSSIBLEISSUE+'  >  '+POSSIBLESOLUTION from ASSESSMENTREPORTTB where rid = @rid and system = @system"
            Case Else
                str = "select id,'  **  '+PARTS+'  *  '+CATEGORY+'  >>>  '+QUALITYASPECT+'  >>  '+POSSIBLEISSUE+'  >  '+POSSIBLESOLUTION from ASSESSMENTREPORTTB where rid = @rid and system = @system"

        End Select

        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd
                        .Parameters.AddWithValue("@rid", reportFRM.id)
                        .Parameters.AddWithValue("@system", seelctedsystem.Text)
                    End With
                    Dim da As SqlDataAdapter = New SqlDataAdapter()
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "ASSESSMENTREPORTTB")

                    sumbs.DataSource = ds
                    sumbs.DataMember = "ASSESSMENTREPORTTB"

                    sumgv.Columns("id").Visible = False
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Dim partsbol As Boolean = True
    Dim categorybol As Boolean = True

    Dim possibleissuebol As Boolean = True
    Private Sub systemtype_MouseDown(sender As Object, e As MouseEventArgs) Handles parts.MouseDown, category.MouseDown, OTHERSYSTEMTXT.MouseDown, qualityaspect.MouseDown, possibleissue.MouseDown
        Select Case sender.name
            Case "OTHERSYSTEMTXT"
                Dim str As String = "select Distinct othersystem from systemtb where system = '" & seelctedsystem.Text & "'"
                LOADDROPDOWNVAL(str, OTHERSYSTEMTXT, "OTHERSYSTEM", "systemtb")
            Case "parts"
                If partsbol = True Then
                    Dim str As String = ""
                    If seelctedsystem.Text = "Insect Protection System" Then
                        str = "select Distinct parts from systemtb where system = '" & seelctedsystem.Text & "' and othersystem = '" & OTHERSYSTEMTXT.Text & "'"
                    Else
                        str = "select Distinct parts from systemtb where system = '" & seelctedsystem.Text & "'"
                    End If
                    LOADDROPDOWNVAL(str, parts, "parts", "systemtb")
                End If
            Case "category"
                If categorybol = True Then
                    Dim str As String = "select distinct category from  systemtb where system = '" & seelctedsystem.Text & "'"
                    LOADDROPDOWNVAL(str, category, "category", "systemtb")
                End If
            Case "qualityaspect"

                Dim str As String = "select distinct QUALITYASPECT from  assessmenttb where system = '" & seelctedsystem.Text & "'"
                LOADDROPDOWNVAL(str, qualityaspect, "QUALITYASPECT", "assessmenttb")

            Case "possibleissue"
                If possibleissuebol = True Then
                    Dim str As String = "select distinct possibleissue from  assessmenttb where system = '" & seelctedsystem.Text & "' and QUALITYASPECT ='" & qualityaspect.Text & "'"
                    LOADDROPDOWNVAL(str, possibleissue, "possibleissue", "assessmenttb")
                End If
        End Select
    End Sub

    Private Sub LOADDROPDOWNVAL(ByVal COMMAND As String, ByVal obj As Object, ByVal datamember As String, ByVal tb As String)
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(COMMAND, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, tb)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    obj.DataSource = ds.Tables(tb)
                    obj.DisplayMember = datamember
                    Select Case obj.name
                        Case "OTHERSYSTEMTXT"
                            If seelctedsystem.Text = "Insect Protection System" Then
                                parts.SelectedIndex = -1
                                partsbol = True
                                categorybol = True
                            End If
                        Case "parts"
                            partsbol = False
                            categorybol = True
                        Case "category"
                            categorybol = False
                        Case "qualityaspect"
                            possibleissue.SelectedIndex = -1
                            possibleissuebol = True
                        Case "possibleissue"
                            possibleissuebol = False
                    End Select
                End Try
            End Using
        End Using
    End Sub
    Dim BS As New BindingSource
    Private Sub possibleissue_TextChanged(sender As Object, e As EventArgs) Handles possibleissue.TextChanged
        'Dim DS As New DataSet
        'DS.Clear()
        'Dim str As String = "SELECT * FROM ASSESSMENTTB WHERE SYSTEM = @SYSTEM AND QUALITYASPECT=@QUALITYASPECT AND POSSIBLEISSUE=@POSSIBLEISSUE"
        'Using SQLCON As SqlConnection = New SqlConnection(sql.sqlcon1str)
        '    Using SQLCMD As SqlCommand = New SqlCommand(str, SQLCON)
        '        Try
        '            SQLCON.Open()
        '            With SQLCMD
        '                .Parameters.AddWithValue("@SYSTEM", seelctedsystem.Text)
        '                .Parameters.AddWithValue("@QUALITYASPECT", qualityaspect.Text)
        '                .Parameters.AddWithValue("@POSSIBLEISSUE", possibleissue.Text)
        '            End With
        '            Dim DA As SqlDataAdapter = New SqlDataAdapter
        '            With DA
        '                .SelectCommand = SQLCMD
        '                .SelectCommand.CommandTimeout = 30000
        '                .Fill(DS, "ASSESSMENTTB")
        '                BS.DataSource = DS
        '                BS.DataMember = "ASSESSMENTTB"
        '            End With
        '            With solutionGV
        '                .Columns("ID").Visible = False
        '                .Columns("SYSTEM").Visible = False
        '                .Columns("QUALITYASPECT").Visible = False
        '                .Columns("POSSIBLEISSUE").Visible = False
        '                .Columns("chk").Visible = False
        '            End With
        '            If solutionGV.RowCount >= 0 Then
        '                For i As Integer = 0 To solutionGV.RowCount - 1
        '                    Dim row As DataGridViewRow = solutionGV.Rows(i)
        '                    Dim a As String = row.Cells("chk").Value.ToString
        '                    If a = "1" Then
        '                        row.Cells(Column1.Name).Value = True
        '                    Else
        '                        row.Cells(Column1.Name).Value = False
        '                    End If
        '                Next
        '            End If
        '        Catch ex As Exception

        '        End Try
        '    End Using
        'End Using
    End Sub
    Dim idarray As New ArrayList
    Private Sub solutionGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles solutionGV.CellClick
        If solutionGV.RowCount >= 0 And e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = solutionGV.Rows(e.RowIndex)
            Dim chkd As Boolean = Convert.ToBoolean(Row.Cells(Column1.Name).Value)
            If chkd = True Then
                row.Cells(Column1.Name).Value = False
                idarray.Remove(row.Cells("id").Value.ToString)
            Else
                row.Cells(Column1.Name).Value = True
                idarray.Add(row.Cells("id").Value.ToString)
            End If
        End If
    End Sub

    Private Sub possibleissue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles possibleissue.SelectedIndexChanged
        idarray = New ArrayList
        Dim DS As New DataSet
        DS.Clear()
        Dim str As String = "SELECT * FROM ASSESSMENTTB WHERE SYSTEM = @SYSTEM AND QUALITYASPECT=@QUALITYASPECT AND POSSIBLEISSUE=@POSSIBLEISSUE"
        Using SQLCON As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using SQLCMD As SqlCommand = New SqlCommand(str, SQLCON)
                Try
                    SQLCON.Open()
                    With SQLCMD
                        .Parameters.AddWithValue("@SYSTEM", seelctedsystem.Text)
                        .Parameters.AddWithValue("@QUALITYASPECT", qualityaspect.Text)
                        .Parameters.AddWithValue("@POSSIBLEISSUE", possibleissue.Text)
                    End With
                    Dim DA As SqlDataAdapter = New SqlDataAdapter
                    With DA
                        .SelectCommand = SQLCMD
                        .SelectCommand.CommandTimeout = 30000
                        .Fill(DS, "ASSESSMENTTB")
                    End With
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
        solutionGV.Rows.Clear()
        Dim tb As DataTable
        tb = DS.Tables("ASSESSMENTTB")
        For i As Integer = 0 To tb.Rows.Count - 1
            Dim row As DataRow = tb.Rows(i)
            solutionGV.Rows.Insert(0, 0, row.Item("POSSIBLESOLUTION").ToString, row.Item("id").ToString)
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim x As String = seelctedsystem.Text
            If x = "Glazing System" Or x = "Weather Tightness" Or x = "Mechanism" Then
                If parts.Text = "" Or category.Text = "" Or qualityaspect.Text = "" Or possibleissue.Text = "" Then
                    MessageBox.Show("Please fill all fields", "Unsaved", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            ElseIf x = "Framing System" Then
                If parts.Text = "" Or pf.Text = "" Or qualityaspect.Text = "" Or possibleissue.Text = "" Then
                    MessageBox.Show("Please fill all fields", "Unsaved", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            ElseIf x = "Insect Protection System" Then
                If OTHERSYSTEMTXT.Text = "" Or parts.Text = "" Or category.Text = "" Or qualityaspect.Text = "" Or possibleissue.Text = "" Then
                    MessageBox.Show("Please fill all fields", "Unsaved", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            For i As Integer = 0 To idarray.Count - 1
                    addassessment(idarray(i))
                Next
        Catch ex As Exception
        Finally
            loadsum()
        End Try

    End Sub
    Private Sub addassessment(ByVal assid As String)
        Dim str As String = "
                                declare @system as varchar(max) = (select system from assessmenttb where id = @assid)
                                declare @QUALITYASPECT as varchar(max) = (select QUALITYASPECT from assessmenttb where id = @assid)
                                declare @POSSIBLEISSUE as varchar(max) = (select POSSIBLEISSUE from assessmenttb where id = @assid)
                                declare @POSSIBLESOLUTION as varchar(max) = (select POSSIBLESOLUTION from assessmenttb where id = @assid)

                                declare @id as integer = (select isnull(max(isnull(id,0)),0)+1 from ASSESSMENTREPORTTB)

                                insert into assessmentreporttb(
                                ID,
                                RID,
                                SYSTEM,
                                OTHERSYSTEM,
                                PARTS,
                                CATEGORY,
                                QUALITYASPECT,
                                POSSIBLEISSUE,
                                POSSIBLESOLUTION,
                                COLOR)
                                values
                                (@id,
                                @rid,
                                @system,
                                @OTHERSYSTEM,
                                @PARTS,
                                @CATEGORY,
                                @QUALITYASPECT,
                                @POSSIBLEISSUE,
                                @POSSIBLESOLUTION,
                                @COLOR)
                                "
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    With sqlcmd
                        .Parameters.AddWithValue("@assid", assid)
                        .Parameters.AddWithValue("@rid", reportFRM.id)
                        .Parameters.AddWithValue("@OTHERSYSTEM", OTHERSYSTEMTXT.Text)
                        .Parameters.AddWithValue("@PARTS", parts.Text)
                        .Parameters.AddWithValue("@CATEGORY", category.Text)
                        .Parameters.AddWithValue("@COLOR", pf.Text)
                    End With
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub

    Private Sub selectedsystemFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
    Dim idd As String = ""
    Private Sub sumgv_SelectionChanged(sender As Object, e As EventArgs) Handles sumgv.SelectionChanged
        Dim rows As DataGridViewSelectedRowCollection = sumgv.SelectedRows
        For Each row As DataGridViewRow In rows
            idd = row.Cells("id").Value.ToString
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "delete from ASSESSMENTREPORTTB where id = @id"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@id", idd)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                Finally
                    loadsum()
                End Try
            End Using
        End Using
    End Sub

    Private Sub addtooltip(ByVal sender As Object)

        Dim txt As String = ""
        Select Case sender.name
            Case "parts"
                If seelctedsystem.Text = "Glazing System" Then
                    If (parts.Text = "COATED (SINGLE)" Or parts.Text = "COATED (DUAL)") Then
                        txt = "lowE, reflective"
                    ElseIf (parts.Text = "FILMED (SINGLE)" Or parts.Text = "FILMED (DUAL)") Then
                        txt = "frosting, safety, Security, solar heat protection"
                    Else
                        txt = ""
                    End If
                ElseIf seelctedsystem.text = "Mechanism" Then
                    If parts.Text = "HINGE" Then
                        txt = "1. Friction Stay
2. 2D Hinge
3. 3D Hinge
4. Butt-hinge
5. S/P Hinge"
                    Else
                        txt = ""
                    End If
                Else
                End If
            Case "category"
                If seelctedsystem.Text = "Glazing System" Then
                    If category.Text = "DOUBLE" Then
                        txt = "IGU/Laminated"
                    Else
                        txt = ""
                    End If
                Else
                End If
            Case "OTHERSYSTEMTXT"
                Select Case OTHERSYSTEMTXT.Text
                    Case "Roll up System"
                        txt = "Roll-up/Chain Driven - System 41, 46, 67/Zipped"
                    Case "Sideroll System"
                        txt = "Sideroll/Built-in Screen/Rollout Maxxy"
                    Case "Plisse System"
                        txt = "Standard/Advance/Train/Plisse Rd/Train Rd/SR (a.k.a. Zigzag)/Magnum"
                    Case "Sliding System"
                        txt = "Sliding with: Regular / Tuff Mesh / Pet Mesh / Security mesh  #11 & #12"
                    Case "Casement System"
                        txt = "Inward casement screen/ Inward Awning / Araknis"
                    Case "Fixed System"
                        txt = "Piconet / Built-in Fixed Screen / Fixed Framed Screen"
                End Select
        End Select
        ToolTip2.SetToolTip(sender, txt)
    End Sub

    Private Sub parts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles parts.SelectedIndexChanged, category.SelectedIndexChanged, OTHERSYSTEMTXT.SelectedIndexChanged
        addtooltip(sender)
    End Sub
End Class