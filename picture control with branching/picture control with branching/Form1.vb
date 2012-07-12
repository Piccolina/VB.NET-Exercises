Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim choice As String
        choice = TextBox1.Text
        choice = UCase(choice)

        If choice = "SUN" Then
            PictureBox1.Load("E:\Exercises\picture control with branching\sun.jpg")
        ElseIf choice = "RAIN" Then
            PictureBox1.Load("E:\Exercises\picture control with branching\rain.jpg")
        Else

            MsgBox("No picture")
        End If
    End Sub
End Class
