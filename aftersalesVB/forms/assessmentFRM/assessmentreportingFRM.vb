Public Class assessmentreportingFRM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button5.Click, Button4.Click
        selectedsystemFRM.seelctedsystem.Text = sender.text
        selectedsystemFRM.Show()
    End Sub
End Class