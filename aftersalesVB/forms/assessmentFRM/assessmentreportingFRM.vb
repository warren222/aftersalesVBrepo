Public Class assessmentreportingFRM
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button5.Click, Button4.Click
        selectedsystemFRM.kno.Text = kno
        selectedsystemFRM.seelctedsystem.Text = sender.text
        selectedsystemFRM.ShowDialog()
    End Sub
    Public Shared kno As String
    Private Sub assessmentreportingFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        REQreplacementFRM.requestype.Text = "REQUEST FORM FOR SCREEN REPAIR"
        REQreplacementFRM.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        REQreplacementFRM.requestype.Text = "REQUEST FORM FOR REPLACEMENTS"
        REQreplacementFRM.ShowDialog()
    End Sub
End Class