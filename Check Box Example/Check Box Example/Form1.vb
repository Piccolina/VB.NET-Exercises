Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If CheckBox1.Checked Then
            MsgBox("Hello!")
        End If

        If CheckBox2.Checked Then
            Me.BackColor = Color.Brown
        End If
    End Sub
End Class
