Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim num1 As Double
        Dim num2 As Double
        Dim sumOfNum As Double

        num1 = txtNum1.Text
        num2 = txtNum2.Text

        sumOfNum = num1 + num2
        MessageBox.Show(sumOfNum)

        sumOfNum = num1 - num2
        MessageBox.Show(sumOfNum)

        sumOfNum = num1 * num2
        MessageBox.Show(sumOfNum)

        sumOfNum = num1 / num2
        MessageBox.Show(sumOfNum)

        sumOfNum = num1 ^ num2
        MessageBox.Show(sumOfNum)

        sumOfNum = num1 \ num2
        MessageBox.Show(sumOfNum)

        sumOfNum = num1 Mod num2
        MessageBox.Show(sumOfNum)



    End Sub
End Class
