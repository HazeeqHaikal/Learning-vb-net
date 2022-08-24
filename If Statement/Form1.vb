Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim country As String
        country = txtCountry.Text

        If country.ToLower() = "malaysia" Then
            MessageBox.Show("Selamat pagi")
            MessageBox.Show("Jangan lupa makan nasi lemak")
        ElseIf country.ToLower() = "australia" Then
            MessageBox.Show("G'day mate")
        ElseIf country.ToLower() = "japan" Then
            MessageBox.Show("Konichiwa")
        Else
            MessageBox.Show("Hello there from whenever you are")
        End If

        MessageBox.Show("You are from " & country)

    End Sub
End Class
