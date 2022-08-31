Public Class Form1
    Private Sub btnOutput_Click(sender As Object, e As EventArgs) Handles btnOutput.Click

        Dim fruit(5) As String
        Dim i As Integer

        fruit(0) = "Pisang"
        fruit(1) = "Mempelam"
        fruit(2) = "Rambutan"
        fruit(3) = "Strawberry"
        fruit(4) = "Dragon fruit"
        fruit(5) = "Pineapple"

        For i = 0 To 5
            MessageBox.Show(fruit(i))
        Next

    End Sub
End Class
