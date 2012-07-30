Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim ppsn As String
        Dim hrsworked As Integer = Tb3.Text

        Dim Hardware As Double
        Dim Grocery As Double
        Dim Confectionery As Double

        Dim GrossPay As Double
        Dim Tax As Double

        ppsn = Tb2.Text

        If ppsn.Length < 7 Then
            MsgBox("Enter Valid PPSN no:")
        End If

        If cb2.Text = "Part-Time" Then
            Hardware = 7.65
            Grocery = 6.55
            Confectionery = 5.65

        ElseIf cb2.Text = "Full-Time" Then
            Hardware = 8.95
            Grocery = 7.95
            Confectionery = 6.95
        End If


        If cb1.Text = "Hardware" Then
            GrossPay = Hardware * hrsworked
            Tb4.Text = GrossPay

            Tax = ((160 / 100) * 20) + (((GrossPay - 160) / 100) * 42)
            Tb5.Text = Tax
        End If

        If cb1.Text = "Grocery" Then
            GrossPay = Grocery * hrsworked
            Tb4.Text = GrossPay


            Tax = ((160 / 100) * 20) + (((GrossPay - 160) / 100) * 42)
            Tb5.Text = Tax
        End If

        If cb1.Text = "Confectionery" Then
            GrossPay = Confectionery * hrsworked
            Tb4.Text = GrossPay

            Tax = ((160 / 100) * 20) + (((GrossPay - 160) / 100) * 42)
            Tb5.Text = Tax
            '    Tb6.Text = Tb4.Text + Tb5.Text
        End If

        'If (GrossPay > 160) Then
        '    Tax = ((160 / 100) * 20)
        '    Tb4.Text = Tax
        'ElseIf (GrossPay <= 160) Then
        '    Tax = (((GrossPay - 160) / 100) * 42)
        '    Tb4.Text = Tax
        'End If

    End Sub
End Class
