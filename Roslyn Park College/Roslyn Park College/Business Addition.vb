Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btntotal.Click

        'Variable Declarations
        Dim txtsnum1 As Integer
        Dim txtsnum2 As Integer
        Dim txtsnum3 As Integer
        Dim txtsnum4 As Integer
        Dim txtsnum5 As Integer
        Dim txtsnum6 As Integer
        Dim txtsnum7 As Integer

        txtsnum1 = Ttsnum1.Text
        txtsnum2 = Ttsnum2.Text
        txtsnum3 = Ttsnum3.Text
        txtsnum4 = Ttsnum4.Text
        txtsnum5 = Ttsnum5.Text
        txtsnum6 = Ttsnum6.Text

        txtsnum7 = txtsnum1 + txtsnum2 + txtsnum3 + txtsnum4 + txtsnum5 + txtsnum6

        Ttsnum7.Text = txtsnum7

    End Sub
End Class
