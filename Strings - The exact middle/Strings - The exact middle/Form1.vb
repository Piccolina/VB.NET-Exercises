Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim odd As String
        Dim even As String

        odd = Mid(Tb1.Text, 3, 1)
        Tb2.Text = odd

        even = Mid(Tb1.Text, 3, 2)
        Tb2.Text = even

    End Sub
End Class
