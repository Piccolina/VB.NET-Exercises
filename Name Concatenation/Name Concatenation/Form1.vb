Public Class Form1

    Private Sub bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bn1.Click

        'Variable Declarations
        Dim FirstName As String
        Dim SecondName As String

        FirstName = Tb1.Text
        SecondName = Tb2.Text

        Tb3.Text = " Hello, " + FirstName + " " + SecondName

    End Sub
End Class
