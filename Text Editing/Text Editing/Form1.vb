Public Class Form1

    Private Sub Copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Copy.Click
        TextBox2.Text = TextBox1.Text
    End Sub

    Private Sub Cut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cut.Click
        TextBox3.Text = TextBox1.Text
        'Clear first two textboxs
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
