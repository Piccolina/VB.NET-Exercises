Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click

        Dim str1 As String
        Dim str2 As String
        Dim str3 As String
        Dim str4 As String
        Dim str5 As String
        Dim str6 As String

        Dim length As String

        str1 = Tb1.Text
        length = str1.Length

        'First Five letters
        str2 = Mid(str1, 1, 5)
        Tb2.Text = str2

        'last three letters
        str3 = Mid(str1, (length - 2))
        Tb3.Text = str3

        'Any six letters
        str4 = Mid(str1, (length - 5))
        Tb4.Text = str4

        'Capital Letters
        str5 = UCase(str1)
        Tb5.Text = str5

        'Small Letters
        str6 = LCase(str1)
        Tb6.Text = str6

    End Sub
End Class
