Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim age As String
        Dim msg As String

        age = Tb1.Text
        msg = Tb2.Text

        If age <= 13 Then
            Tb2.Text = "you are a child"
        ElseIf age <= 21 Then
            Tb2.Text = "you are a teenager"
        ElseIf age <= 65 Then
            Tb2.Text = "you are an adult"
        ElseIf age > 65 Then
            Tb2.Text = "you are old"
        End If

    End Sub
End Class
