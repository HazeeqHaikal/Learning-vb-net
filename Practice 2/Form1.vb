Public Class Form1
    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click


        Dim data(4) As Integer

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            MessageBox.Show(data(i))
        Next


    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

        Dim data(4) As Integer
        Dim joinedString As String

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            joinedString = joinedString & data(i) & vbNewLine
        Next

        MessageBox.Show(joinedString)

    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        Dim data(4) As Integer
        Dim total As Integer

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            total = total + data(i)
        Next

        MessageBox.Show(total)

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        Dim data(4) As Integer
        Dim total As Integer
        Dim average As Double

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            total = total + data(i)
        Next

        average = total / data.Length

        MessageBox.Show(average)

    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

        Dim data(4) As Integer
        Dim total As Integer

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            If data(i) > 20 Then
                total = total + data(i)
            End If
        Next

        MessageBox.Show(total)

    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click

        Dim data(4) As Integer
        Dim max As Integer

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            If data(i) > max Then
                max = data(i)
            End If
        Next

        MessageBox.Show(max)

    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click

        Dim data(4) As Integer
        Dim min As Integer

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            If i = 0 Then
                min = data(i)
            ElseIf data(i) < min Then
                min = data(i)
            End If
        Next

        MessageBox.Show(min)

    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

        Dim data(4) As Integer
        Dim joinedString As String

        data(0) = 5
        data(1) = 7
        data(2) = 33
        data(3) = 22
        data(4) = 8

        For i = 0 To data.Length - 1
            data(i) = data(i) * 2
            joinedString = joinedString & data(i) & vbNewLine
        Next

        MessageBox.Show(joinedString)

    End Sub
End Class
