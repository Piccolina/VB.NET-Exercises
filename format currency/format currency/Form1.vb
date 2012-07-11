Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Total As Single
        Total = 2.3
        TextBox1.Text = Total
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim Total As Single
        Total = 2.3
        TextBox1.Text = FormatCurrency(Total, 2)
    End Sub
End Class
