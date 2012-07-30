Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim numbers_array(5) As Integer
        Dim number_entered As Integer
        Dim x As Integer

        number_entered = TextBox1.Text

        'initialising the array (giving it values)
        numbers_array(0) = 5
        numbers_array(1) = 8
        numbers_array(2) = 6
        numbers_array(3) = 7
        numbers_array(4) = 3


        For x = 0 To 4
            If number_entered = numbers_array(x) Then GoTo Found
        Next x
        MsgBox("Your no. is not in the array")
        GoTo End_Search

Found:
        MsgBox("Your no. has been found in position " & x & " of the array")
End_Search:
        MsgBox("Your search is finished!")
    End Sub
End Class
