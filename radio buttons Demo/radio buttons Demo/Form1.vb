Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            MsgBox("Your tv must be really old")
        ElseIf RadioButton2.Checked = True Then
            MsgBox("You have a new-ish tv")
        End If
    End Sub
End Class
