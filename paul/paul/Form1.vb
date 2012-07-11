Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'Variable Declarations
        Dim fName As String
        Dim sName As String
        Dim fullName As String

        'Getting values for variables from textboxes
        fName = TextBox1.Text
        sName = TextBox2.Text

        'Concatenating the variables
        fullName = fName & "" & sName

        'Displaying output
        TextBox3.Text = fullName

    End Sub
End Class
