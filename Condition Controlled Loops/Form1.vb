Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim age As String
        Dim numAge As Integer

        Do While Not IsNumeric(age)
            age = InputBox("Please enter your age in years")
        Loop

        numAge = CInt(age)

        MessageBox.Show("Hello you are " & numAge & " years old")


    End Sub
End Class
