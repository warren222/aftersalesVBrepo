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

    Private Sub systemtype_MouseDown(sender As Object, e As MouseEventArgs) Handles parts.MouseDown, category.MouseDown, OTHERSYSTEMTXT.MouseDown
        Select Case sender.name
            Case "OTHERSYSTEMTXT"
                Dim str As String = "select Distinct othersystem from systemtb where system = '" & seelctedsystem.Text & "'"
                LOADDROPDOWNVAL(str, OTHERSYSTEMTXT, "OTHERSYSTEM")
            Case "parts"
                If partsbol = True Then
                    Dim str As String = ""
                    If seelctedsystem.Text = "Insect Protection System" Then
                        str = "select Distinct parts from systemtb where system = '" & seelctedsystem.Text & "' and othersystem = '" & OTHERSYSTEMTXT.Text & "'"
                    Else
                        str = "select Distinct parts from systemtb where system = '" & seelctedsystem.Text & "'"
                    End If
                    LOADDROPDOWNVAL(str, parts, "parts")
                End If
            Case "category"
                If categorybol = True Then
                    Dim str As String = "select distinct category from  systemtb where system = '" & seelctedsystem.Text & "'"
                    LOADDROPDOWNVAL(str, category, "category")
                End If
        End Select
    End Sub

    Private Sub LOADDROPDOWNVAL(ByVal COMMAND As String, ByVal obj As Object, ByVal datamember As String)
        Dim ds As New DataSet
        ds.Clear()
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon1str)
            Using sqlcmd As SqlCommand = New SqlCommand(COMMAND, sqlcon)
                Try
                    sqlcon.Open()
                    Dim da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = sqlcmd
                    da.SelectCommand.CommandTimeout = 30000
                    da.Fill(ds, "systemtb")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    obj.DataSource = ds.Tables("systemtb")
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
                    End Select
                End Try
            End Using
        End Using
    End Sub
End Class