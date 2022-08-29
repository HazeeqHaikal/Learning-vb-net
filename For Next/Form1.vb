Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim i As Integer
        Dim combine As String

        For i = 0 To -50 Step -5
            combine = combine & i & vbNewLine
        Next

        MessageBox.Show(combine)

    End Sub
End Class
