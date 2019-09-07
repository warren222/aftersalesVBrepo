Public Class assessmentreportingFRM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button5.Click, Button4.Click
        selectedsystemFRM.kno.Text = kno
        selectedsystemFRM.seelctedsystem.Text = sender.text
        selectedsystemFRM.ShowDialog()
    End Sub
    Public Shared kno As String
    Private Sub assessmentreportingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class