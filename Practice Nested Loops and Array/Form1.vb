Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        Dim people(4, 4) As String

        people(0, 0) = "Lewis"
        people(0, 1) = "Hamilton"
        people(0, 2) = "Male"
        people(0, 3) = "British"
        people(0, 4) = "F1 Driver"

        people(1, 0) = "Gordon"
        people(1, 1) = "Ramsay"
        people(1, 2) = "Male"
        people(1, 3) = "Scottish"
        people(1, 4) = "Wholesome Chef"

        people(2, 0) = "Margaret"
        people(2, 1) = "Hamilton"
        people(2, 2) = "Female"
        people(2, 3) = "American"
        people(2, 4) = "Software Engineer"

        people(3, 0) = "Charles"
        people(3, 1) = "Lechair"
        people(3, 2) = "Male"
        people(3, 3) = "Monegasque"
        people(3, 4) = "Intern in F1 Driver"

        people(4, 0) = "Hazeeq"
        people(4, 1) = "Haikal"
        people(4, 2) = "Male"
        people(4, 3) = "Malaysian"
        people(4, 4) = "Professional Menganggur"

        For i = 0 To people.GetLength(0) - 1
            For x = 0 To people.GetLength(1) - 1
                MessageBox.Show(people(i, x))
            Next
        Next

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim people(4, 4) As String

        people(0, 0) = "Lewis"
        people(0, 1) = "Hamilton"
        people(0, 2) = "Male"
        people(0, 3) = "British"
        people(0, 4) = "F1 Driver"

        people(1, 0) = "Gordon"
        people(1, 1) = "Ramsay"
        people(1, 2) = "Male"
        people(1, 3) = "Scottish"
        people(1, 4) = "Wholesome Chef"

        people(2, 0) = "Margaret"
        people(2, 1) = "Hamilton"
        people(2, 2) = "Female"
        people(2, 3) = "American"
        people(2, 4) = "Software Engineer"

        people(3, 0) = "Charles"
        people(3, 1) = "Lechair"
        people(3, 2) = "Male"
        people(3, 3) = "Monegasque"
        people(3, 4) = "Intern in F1 Driver"

        people(4, 0) = "Hazeeq"
        people(4, 1) = "Haikal"
        people(4, 2) = "Male"
        people(4, 3) = "Malaysian"
        people(4, 4) = "Professional Menganggur"

        For x = 0 To people.GetLength(1) - 1
            For i = 0 To people.GetLength(0) - 1
                MessageBox.Show(people(i, x))
            Next
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim people(4, 4) As String

        people(0, 0) = "Lewis"
        people(0, 1) = "Hamilton"
        people(0, 2) = "Male"
        people(0, 3) = "British"
        people(0, 4) = "F1 Driver"

        people(1, 0) = "Gordon"
        people(1, 1) = "Ramsay"
        people(1, 2) = "Male"
        people(1, 3) = "Scottish"
        people(1, 4) = "Wholesome Chef"

        people(2, 0) = "Margaret"
        people(2, 1) = "Hamilton"
        people(2, 2) = "Female"
        people(2, 3) = "American"
        people(2, 4) = "Software Engineer"

        people(3, 0) = "Charles"
        people(3, 1) = "Lechair"
        people(3, 2) = "Male"
        people(3, 3) = "Monegasque"
        people(3, 4) = "Intern in F1 Driver"

        people(4, 0) = "Hazeeq"
        people(4, 1) = "Haikal"
        people(4, 2) = "Male"
        people(4, 3) = "Malaysian"
        people(4, 4) = "Professional Menganggur"

        Dim joinedString As String

        For i = 0 To people.GetLength(0) - 1
            For x = 0 To people.GetLength(1) - 1
                joinedString = joinedString & people(i, x) & vbNewLine
            Next
            joinedString = joinedString & vbNewLine
        Next

        MessageBox.Show(joinedString)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim people(4, 4) As String

        people(0, 0) = "Lewis"
        people(0, 1) = "Hamilton"
        people(0, 2) = "Male"
        people(0, 3) = "British"
        people(0, 4) = "F1 Driver"

        people(1, 0) = "Gordon"
        people(1, 1) = "Ramsay"
        people(1, 2) = "Male"
        people(1, 3) = "Scottish"
        people(1, 4) = "Wholesome Chef"

        people(2, 0) = "Margaret"
        people(2, 1) = "Hamilton"
        people(2, 2) = "Female"
        people(2, 3) = "American"
        people(2, 4) = "Software Engineer"

        people(3, 0) = "Charles"
        people(3, 1) = "Lechair"
        people(3, 2) = "Male"
        people(3, 3) = "Monegasque"
        people(3, 4) = "Intern in F1 Driver"

        people(4, 0) = "Hazeeq"
        people(4, 1) = "Haikal"
        people(4, 2) = "Male"
        people(4, 3) = "Malaysian"
        people(4, 4) = "Professional Menganggur"

        Dim condition As Boolean
        Dim search As String

        condition = False
        search = InputBox("What do you want to search?")

        For i = 0 To people.GetLength(0) - 1
            For x = 0 To people.GetLength(1) - 1
                If people(i, x).ToUpper = search.ToUpper Then
                    condition = True
                    Exit For
                    Exit For
                End If
            Next
        Next

        If condition = True Then
            MessageBox.Show("Data found")
        Else
            MessageBox.Show("Data is not found")
        End If

    End Sub
End Class
