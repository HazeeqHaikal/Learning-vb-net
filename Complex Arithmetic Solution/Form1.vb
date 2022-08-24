Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim price As Decimal
        Dim quantity As Integer
        Dim totalCost As Decimal
        Dim discount As Decimal
        Dim postage As Decimal
        Dim result As Decimal

        price = 35.58
        quantity = 7
        discount = 2
        postage = 3
        totalCost = (price - discount) * quantity + postage

        MessageBox.Show("RM" & totalCost)

        result = 9 + 8 - 2
        MessageBox.Show(result)

        result = 9 - 2 + 8
        MessageBox.Show(result)

        result = 9 + 2 - 8
        MessageBox.Show(result)

        result = 9 * 2 / 8
        MessageBox.Show(result)

        result = 9 / 8 * 2
        MessageBox.Show(result)

        result = 9 * 8 / 2
        MessageBox.Show(result)



    End Sub
End Class
