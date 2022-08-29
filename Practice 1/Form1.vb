Public Class Form1
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click

        Dim max As Integer
        Dim oddOrEven As String
        Dim i As Integer
        Dim combine As String

        max = InputBox("What number do you want to count up to?")
        oddOrEven = InputBox("Count in odd or even number order?")

        If oddOrEven = "odd" Then
            For i = 1 To max Step 2
                combine = combine & i & vbNewLine
            Next
        Else
            For i = 0 To max Step 2
                combine = combine & i & vbNewLine
            Next
        End If

        MessageBox.Show(combine)

    End Sub
End Class
