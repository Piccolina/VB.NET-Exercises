Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim first As String
        Dim afirst As String

        Dim Last As String
        Dim aLast As String

        first = Tb1.Text
        Last = Tb3.Text

        'first 2 letters
        afirst = Mid(first, 1, 2)

        'First 2 letters of last name 
        aLast = Mid(Last, 1, 2)
        'email txtbox
        Tb5.Text = afirst + aLast + "@compprog.ie"

        'Accommodation
        If Tb4.Text = "yes" Then
            Tb4.Text = "Good Luck with your accommodation"
            Tb5.Text = "accomm" + "ireland" + "@compprog.ie"

        ElseIf Tb4.Text = "no" Then
            Tb5.Text = "accomm" + "ireland" + "@compprog.ie"
            Tb6.Text = Tb5.Text
        Else
            MsgBox("You must enter Yes or No in this box")

        End If

    End Sub
End Class
