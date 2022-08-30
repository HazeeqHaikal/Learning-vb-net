Public Class Form1
    Private Sub btnGO_Click(sender As Object, e As EventArgs) Handles btnGO.Click

        Dim i As Integer

        Do
            i = i + 1
            MessageBox.Show("Hello " & i)
        Loop Until i = 5

        MessageBox.Show("Finished loop")

    End Sub
End Class
