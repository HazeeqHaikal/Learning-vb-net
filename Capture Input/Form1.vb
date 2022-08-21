Public Class Form1
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click

        Dim sFirstName As String
        Dim sLastName As String
        Dim sGender As String
        Dim sOccupation As String

        sFirstName = txtFirstName.Text
        sLastName = txtLastName.Text
        sGender = txtGender.Text

        sOccupation = lstOccupation.SelectedItem

        MessageBox.Show("Hello " & sFirstName & " " & sLastName & ". You are a " & sGender & " " & sOccupation)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOccupation.Items.Add("Artist")
        lstOccupation.Items.Add("Actor")
        lstOccupation.Items.Add("Astronaut")
    End Sub
End Class
