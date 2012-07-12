Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim first As String
        Dim Second As String
        Dim third As String
        Dim fourth As String

        first = Tb1.Text
        Second = Tb2.Text
        third = Tb3.Text

        If Second = "+" Then
            Second = "+"
            fourth = first + third
        ElseIf Second = "-" Then
            Second = "-"
            fourth = first - third
        ElseIf Second = "/" Then
            Second = "/"
            fourth = first / third
        ElseIf Second = "*" Then
            Second = "*"
            fourth = first * third
        Else
            MsgBox("Please enter valid operator")
        End If

        Tb4.Text = first + " " + Second + " " + third + " = " + fourth
    End Sub
End Class
