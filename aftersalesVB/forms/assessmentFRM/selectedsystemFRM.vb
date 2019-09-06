Imports System.Data.SqlClient

Public Class selectedsystemFRM
    Dim sql As New sql
    Private Sub selectedsystemFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case seelctedsystem.Text
            Case "Framing System"
                CATEGORYlabel.Visible = False
                category.Visible = False
            Case "Glazing System"
                CATEGORYlabel.Text = "Glass specs"
            Case "Weather Tightness"
                CATEGORYlabel.Text = "Seals"
            Case "Mechanism"
                CATEGORYlabel.Text = "Hardware"
            Case "Insect Protection System"
                Label1.Visible = True
                OTHERSYSTEMTXT.Visible = True
                CATEGORYlabel.Text = "Insect Screens"
        End Select
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

    Private Sub solutionGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles solutionGV.CellClick
        If solutionGV.RowCount >= 0 And e.RowIndex >= 0 Then

        End If

    End Sub

    Private Sub possibleissue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles possibleissue.SelectedIndexChanged
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
            solutionGV.Rows.Insert(0, 0, row.Item("POSSIBLESOLUTION").ToString)
        Next

    End Sub
End Class