Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim score As Integer

        If IsNumeric(txtGrade.Text) = True Then
            score = CInt(txtGrade.Text)
        Else
            MessageBox.Show("That is not a number")
            Exit Sub
        End If

        If score < 0 Or score > 100 Then
            MessageBox.Show("That is not a valid score. Enter a number between 0 and 100")
            Exit Sub
        End If

        If score >= 40 Then
            MessageBox.Show("You have passed the examination")
        Else
            MessageBox.Show("You have failed the examination")
        End If



        MessageBox.Show("All done")

    End Sub
End Class
