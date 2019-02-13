Imports System.Data.SqlClient
Public Class editaddressFRM
    Dim sql As New sql
    Public Shared parentjo As String
    Private Sub editaddressFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub editaddressFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadaddress()
    End Sub

    Private Sub sam()
        unitno.Text = unitno.Text.Replace("'", "")
        unitno.Text = unitno.Text.Replace("""", "")
        establishment.Text = establishment.Text.Replace("'", "")
        establishment.Text = establishment.Text.Replace("""", "")
        no.Text = no.Text.Replace("'", "")
        no.Text = no.Text.Replace("""", "")
        street.Text = street.Text.Replace("'", "")
        street.Text = street.Text.Replace("""", "")
        village.Text = village.Text.Replace("'", "")
        village.Text = village.Text.Replace("""", "")
        brgymunicipality.Text = brgymunicipality.Text.Replace("'", "")
        brgymunicipality.Text = brgymunicipality.Text.Replace("""", "")
        towndistrict.Text = towndistrict.Text.Replace("'", "")
        towndistrict.Text = towndistrict.Text.Replace("""", "")
        province.Text = province.Text.Replace("'", "")
        province.Text = province.Text.Replace("""", "")
        area.Text = area.Text.Replace("'", "")
        area.Text = area.Text.Replace("""", "")

        unitno.Text = unitno.Text.Replace(",", "")
        establishment.Text = establishment.Text.Replace(",", "")
        no.Text = no.Text.Replace(",", "")
        street.Text = street.Text.Replace(",", "")
        village.Text = village.Text.Replace(",", "")
        brgymunicipality.Text = brgymunicipality.Text.Replace(",", "")
        towndistrict.Text = towndistrict.Text.Replace(",", "")
        province.Text = province.Text.Replace(",", "")

        unitno.Text = Trim(unitno.Text)
        establishment.Text = Trim(establishment.Text)
        no.Text = Trim(no.Text)
        street.Text = Trim(street.Text)
        village.Text = Trim(village.Text)
        brgymunicipality.Text = Trim(brgymunicipality.Text)
        towndistrict.Text = Trim(towndistrict.Text)
        province.Text = Trim(province.Text)

        If unitno.Text = "" Then
            unitno.Text = ""
        Else
            If street.Text = "" And village.Text = "" And brgymunicipality.Text = "" And towndistrict.Text = "" And province.Text = "" Then
                unitno.Text = unitno.Text
            ElseIf street.Text = "" And village.Text = "" And brgymunicipality.Text = "" And towndistrict.Text = "" Then
                unitno.Text = unitno.Text + " "
            ElseIf street.Text = "" And village.Text = "" And brgymunicipality.Text = "" Then
                unitno.Text = unitno.Text + " "
            ElseIf street.Text = "" And village.Text = "" Then
                unitno.Text = unitno.Text + " "
            ElseIf street.Text = "" Then
                unitno.Text = unitno.Text + " "
            Else
                unitno.Text = unitno.Text + " "
            End If

        End If

        If no.Text = "" Then
            no.Text = ""
        Else
            If street.Text = "" And village.Text = "" And brgymunicipality.Text = "" And towndistrict.Text = "" And province.Text = "" Then
                no.Text = no.Text
            ElseIf street.Text = "" And village.Text = "" And brgymunicipality.Text = "" And towndistrict.Text = "" Then
                no.Text = no.Text + " "
            ElseIf street.Text = "" And village.Text = "" And brgymunicipality.Text = "" Then
                no.Text = no.Text + " "
            ElseIf street.Text = "" And village.Text = "" Then
                no.Text = no.Text + " "
            ElseIf street.Text = "" Then
                no.Text = no.Text + " "
            Else
                no.Text = no.Text + " "
            End If

        End If

        If street.Text = "" Then
            street.Text = ""
        Else
            If village.Text = "" And brgymunicipality.Text = "" And towndistrict.Text = "" And province.Text = "" Then
                street.Text = street.Text
            ElseIf village.Text = "" And brgymunicipality.Text = "" And towndistrict.Text = "" Then
                street.Text = street.Text + ", "
            ElseIf village.Text = "" And brgymunicipality.Text = "" Then
                street.Text = street.Text + ", "
            ElseIf village.Text = "" Then
                street.Text = street.Text + ", "
            Else
                street.Text = street.Text + ", "
            End If

        End If


        If establishment.Text = "" Then
            establishment.Text = ""
        Else
            If brgymunicipality.Text = "" And towndistrict.Text = "" And province.Text = "" Then
                establishment.Text = establishment.Text
            ElseIf brgymunicipality.Text = "" And towndistrict.Text = "" Then
                establishment.Text = establishment.Text + ", "
            ElseIf brgymunicipality.Text = "" Then
                establishment.Text = establishment.Text + ", "
            Else
                establishment.Text = establishment.Text + ", "
            End If

        End If


        If village.Text = "" Then
            village.Text = ""
        Else
            If brgymunicipality.Text = "" And towndistrict.Text = "" And province.Text = "" Then
                village.Text = village.Text
            ElseIf brgymunicipality.Text = "" And towndistrict.Text = "" Then
                village.Text = village.Text + ", "
            ElseIf brgymunicipality.Text = "" Then
                village.Text = village.Text + ", "
            Else
                village.Text = village.Text + ", "
            End If
        End If

        If brgymunicipality.Text = "" Then
            brgymunicipality.Text = ""
        Else
            If towndistrict.Text = "" And province.Text = "" Then
                brgymunicipality.Text = brgymunicipality.Text
            ElseIf towndistrict.Text = "" Then
                brgymunicipality.Text = brgymunicipality.Text + ", "
            Else
                brgymunicipality.Text = brgymunicipality.Text + ", "
            End If

        End If

        If towndistrict.Text = "" Then
            towndistrict.Text = ""
        Else
            If province.Text = "" Then
                towndistrict.Text = towndistrict.Text
            Else
                towndistrict.Text = towndistrict.Text + ", "
            End If

        End If
        savechanges()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        If MessageBox.Show("Do you want to update this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            MessageBox.Show("Update cancelled.", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        sam()
        mainform.reloadBTN.PerformClick()
    End Sub
    Private Sub loadaddress()
        Dim str As String = "select unitno,establishment,no,street,village,BRGY_MUNICIPALITY,TOWN_DISTRICT,province,area
                             from addendum_to_contract_tb where job_order_no = @parentjo"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@parentjo", parentjo)
                    Using rd As SqlDataReader = sqlcmd.ExecuteReader
                        While rd.Read
                            unitno.Text = rd(0).ToString
                            establishment.Text = rd(1).ToString
                            no.Text = rd(2).ToString
                            street.Text = rd(3).ToString
                            village.Text = rd(4).ToString
                            brgymunicipality.Text = rd(5).ToString
                            towndistrict.Text = rd(6).ToString
                            province.Text = rd(7).ToString
                            area.Text = rd(8).ToString
                        End While
                    End Using
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
    Private Sub savechanges()
        Dim str As String = "   update addendum_to_contract_tb set
                                unitno=@unitno,
                                establishment=@establishment,
                                no=@no,
                                street=@street,
                                village=@village,
                                BRGY_MUNICIPALITY=@brgy,
                                TOWN_DISTRICT=@town,
                                province=@province,
                                area=@area 
                                where parentjono = @parentjo"
        Using sqlcon As SqlConnection = New SqlConnection(sql.sqlcon2str)
            Using sqlcmd As SqlCommand = New SqlCommand(str, sqlcon)
                Try
                    sqlcon.Open()
                    sqlcmd.Parameters.AddWithValue("@unitno", unitno.Text)
                    sqlcmd.Parameters.AddWithValue("@establishment", establishment.Text)
                    sqlcmd.Parameters.AddWithValue("@no", no.Text)
                    sqlcmd.Parameters.AddWithValue("@street", street.Text)
                    sqlcmd.Parameters.AddWithValue("@village", village.Text)
                    sqlcmd.Parameters.AddWithValue("@brgy", brgymunicipality.Text)
                    sqlcmd.Parameters.AddWithValue("@town", towndistrict.Text)
                    sqlcmd.Parameters.AddWithValue("@province", province.Text)
                    sqlcmd.Parameters.AddWithValue("@area", area.Text)
                    sqlcmd.Parameters.AddWithValue("@parentjo", parentjo)
                    sqlcmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End Using
        End Using
    End Sub
End Class