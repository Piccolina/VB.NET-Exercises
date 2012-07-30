Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click

        Dim windows As Double
        Dim breakdown As Double
        Dim noclaims As Double

        Dim discount As Double

        If Cb1.Checked Then
            windows = 35
            Tb4.Text = windows + 300
        End If

        If Cb2.Checked Then
            breakdown = 125
            Tb4.Text = breakdown + 300
        End If

        If Cb3.Checked Then
            noclaims = 65
            Tb4.Text = noclaims + 300
        End If

        If Rbn2.Checked Then
            discount = ((300 / 100) * 5)
            Tb4.Text = discount + noclaims + breakdown + windows
        End If

    End Sub
End Class
