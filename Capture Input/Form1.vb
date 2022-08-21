Public Class Form1
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Dim sFirstName As String
        Dim sLastName As String
        Dim sGender As String

        sFirstName = txtFirstName.Text
        sLastName = txtLastName.Text
        sGender = txtGender.Text

        MessageBox.Show("Hello " & sFirstName & " " & sLastName & ". You are a " & sGender)


    End Sub
End Class
