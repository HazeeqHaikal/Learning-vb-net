Public Class Form1
    Private Sub btnCheckTemp_Click(sender As Object, e As EventArgs) Handles btnCheckTemp.Click
        Dim temperature As Integer
        temperature = CInt(txtTemperature.Text)
        Dim windSpeed As Integer
        windSpeed = 25


        Select Case temperature
            Case Is = 0
                MessageBox.Show("Freezing")
            Case Is < 0
                MessageBox.Show("Sub zero")
                MessageBox.Show("We might get hypothermia")
                If windSpeed > 10 Then
                    MessageBox.Show("Things about to get real freezy")
                End If
            Case 1 To 10
                MessageBox.Show("Cold")
            Case 11 To 20
                MessageBox.Show("Warm")
            Case 21 To 30
                MessageBox.Show("Hot")
            Case Else
                MessageBox.Show("Blazing Hot")
        End Select


    End Sub
End Class
