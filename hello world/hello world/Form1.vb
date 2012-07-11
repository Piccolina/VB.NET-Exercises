Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim fnum As Single
        Dim snum As Single
        Dim total As Single

        fnum = TextBox1.Text
        snum = TextBox2.Text

        total = fnum + snum

        TextBox3.Text = total

    End Sub
End Class
