Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click

        'Variable Declarations
        Dim txtb1 As String
        Dim txtb2 As String
        Dim txtb3 As Integer
        Dim txtb4 As String
        Dim txtb5 As String
        Dim txtb6 As Integer
        Dim txtb7 As Integer
        Dim txtb8 As Integer
        Dim txtb9 As Integer

        'Paint Subtotal
        txtb1 = Tb1.Text
        txtb2 = Tb2.Text

        Tb3.Text = txtb1 * txtb2

        'Brush Subtotal
        txtb4 = Tb4.Text
        txtb5 = Tb5.Text

        Tb6.Text = txtb4 * txtb5

        'Subtotal
        txtb3 = Tb3.Text
        txtb6 = Tb6.Text

        Tb7.Text = txtb3 + txtb6

        'VAT @ 21%
        Tb8.Text = ((Tb7.Text / 100) * 21)

        'Total
        txtb7 = Tb7.Text
        txtb8 = Tb8.Text

        txtb9 = txtb8 + txtb7

        Tb9.Text = txtb9

    End Sub

End Class
