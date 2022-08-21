Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome")
        MsgBox("To")
        MsgBox("VB.")
        MsgBox("Next")

        MessageBox.Show("Different message")

    End Sub

    Private Sub btnVariable_Click(sender As Object, e As EventArgs) Handles btnVariable.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Hazeeq"
        stLastName = "Haikal"

        MessageBox.Show("Hello and welcome " & stFirstName & " " & stLastName & vbCrLf & "I hope youre doing well")

        stFirstName = "Nurin"
        stLastName = "Afrina"

        MessageBox.Show("Hello and welcome " & stFirstName & " " & stLastName & vbCrLf & "I hope youre doing well")

    End Sub
End Class
