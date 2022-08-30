Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Dim name As String

        Do While True
            name = InputBox("Please enter your name")
            If name = "hazeeq" Then
                MessageBox.Show("Hi " & name)
                Exit Do
            End If
        Loop

    End Sub
End Class
