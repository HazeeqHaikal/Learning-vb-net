Public Class Form1
    Private Sub btnLinear_Click(sender As Object, e As EventArgs) Handles btnLinear.Click

        Dim search As String
        Dim fruit(9) As String

        fruit(0) = "Durian"
        fruit(1) = "Mangosteen"
        fruit(3) = "Mango"
        fruit(4) = "Banana"
        fruit(5) = "Grape"
        fruit(6) = "Pineapple"
        fruit(7) = "Apple"
        fruit(8) = "Orange"
        fruit(9) = "Lime"

        search = InputBox("Which fruits are you looking for?")

        Dim i As Integer
        Dim condition As Boolean
        condition = False

        For i = 0 To fruit.Length - 1
            If UCase(fruit(i)) = UCase(search) Then
                condition = True
                Exit For
            End If
        Next

        If condition = True Then
            MessageBox.Show("Found it")
        Else
            MessageBox.Show("That fruit doesnt exist")
        End If

    End Sub
End Class
