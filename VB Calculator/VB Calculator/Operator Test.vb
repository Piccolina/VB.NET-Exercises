Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim first As String
        Dim Second As String

        Dim oper1 As String


        first = Tb1.Text
        Second = Tb3.Text
        oper1 = Tb2.Text

        Tb4.Text = first + " " + oper1 + " " + Second + " = "

    End Sub
End Class
