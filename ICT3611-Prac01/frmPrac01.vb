Public Class Prac01

    Structure Person
        Public name As String
        Public age As Integer
    End Structure



    Private Sub btnDisplayMessage_Click(sender As Object, e As EventArgs) Handles btnDisplayMessage.Click

        Dim prs As Person

        If txtAge.Text = "" Or txtAge.Text = "" Then
            MsgBox("Please make sure you have provided your name and relevant age")
        Else
            prs.age = Integer.Parse(txtAge.Text)
            prs.name = txtName.Text

            Dim numMonthsOfAge As Integer
            Dim numDecadesInAge As Integer
            Dim remainderYearsOfAge As Integer

            numMonthsOfAge = prs.age * 12
            numDecadesInAge = prs.age / 10
            remainderYearsOfAge = prs.age Mod 10

            MsgBox("Hi " + prs.name + ",you are " + numMonthsOfAge.ToString() + " months old. This is also " + numDecadesInAge.ToString + " decades and " + remainderYearsOfAge.ToString + " years.")

        End If

    End Sub

    Private Sub btnDisplayAgeAsBinary_Click(sender As Object, e As EventArgs) Handles btnDisplayAgeAsBinary.Click
        If txtAge.Text = "" Then
            MsgBox("Please make sure you have provided a relevant age")
        Else
            Dim number As Integer
            Dim binaryTxt As String

            number = Integer.Parse(txtAge.Text)
            binaryTxt = ""

            While number > 0
                binaryTxt = (number Mod 2).ToString + binaryTxt
                number \= 2
            End While

            MsgBox("Age in binary is: " + binaryTxt)
        End If

    End Sub
End Class
