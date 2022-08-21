Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        MsgBox("Welcome")
        MsgBox("To")
        MsgBox("VB.")
        MsgBox("Next")

        MessageBox.Show("Different message")

    End Sub

    Private Sub btnVariable_Click(sender As Object, e As EventArgs) Handles btnVariable.Click

        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Hazeeq"
        stLastName = "Haikal"

        MessageBox.Show("Hello and welcome " & stFirstName & " " & stLastName & vbCrLf & "I hope youre doing well")

        stFirstName = "Nurin"
        stLastName = "Afrina"

        MessageBox.Show("Hello and welcome " & stFirstName & " " & stLastName & vbCrLf & "I hope youre doing well")

    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click

        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColour As String
        Dim bTaxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dDateRegistered As Date
        Dim formatTaxed As String

        stMake = "Ferrari"
        stModel = "250 GTO"
        iDoors = 4
        stColour = "Blue"
        bTaxed = True
        formatTaxed = bTaxed.ToString().Replace("True", "taxed").Replace("False", "not taxed")
        iEngineSize = 1200
        decPrice = 24000000.98
        dDateRegistered = #8/29/2024#


        MessageBox.Show("The car is " & stMake & " " & stModel & vbNewLine & "It has " & iDoors & " doors." & vbNewLine & "The car color is " & stColour & vbNewLine & "It is " & formatTaxed & vbNewLine & "The engine size is " & iEngineSize & " CC" & vbNewLine & "The price is RM " & decPrice & vbNewLine & "The car is registered on " & dDateRegistered)

    End Sub
End Class
