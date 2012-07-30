Public Class Form1

    Dim PriceFruit As Single
    Dim TotalFrozen As Single
    Dim TotalMeat As Single
    Dim Plastic As Single
    Dim Subtotal As Single
    Dim Deduction As Single
    Dim Delivery As Single
    Dim TotalBill As Single
    Dim Change As Single
    Dim Clubcardlast As Integer

    Private Sub DunnesStores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate County combo box
        cboCounty.Items.Add("Dublin")
        cboCounty.Items.Add("Wicklow")
        cboCounty.Items.Add("Cork")
        cboCounty.Items.Add("Limerick")
        cboCounty.Items.Add("Donegal")
        cboCounty.Items.Add("Leitrim")
        cboCounty.Items.Add("Sligo")
        cboCounty.Items.Add("Mayo")
        cboCounty.Items.Add("Galway")
        cboCounty.Items.Add("Meath")
        cboCounty.Items.Add("Westmeath")
        cboCounty.Items.Add("Carlow")
        cboCounty.Items.Add("Kilkenny")
        cboCounty.Items.Add("Kildare")
        cboCounty.Items.Add("Louth")
        cboCounty.Items.Add("Offaly")
        cboCounty.Items.Add("Kerry")
        cboCounty.Items.Add("Laois")
        cboCounty.Items.Add("Athlone")
        cboCounty.Items.Add("Cavan")
        cboCounty.Items.Add("Monaghan")
        cboCounty.Items.Add("Clare")
        cboCounty.Items.Add("Roscommon")
        cboCounty.Items.Add("Longford")
        cboCounty.Items.Add("Waterford")
        cboCounty.Items.Add("Wexford")
        cboCounty.Items.Add("Fermanagh")
        cboCounty.Items.Add("Antrim")
        cboCounty.Items.Add("Tyrone")
        cboCounty.Items.Add("Down")
        cboCounty.Items.Add("Armagh")
        cboCounty.Items.Add("Derry")
    End Sub
    Private Sub txtClubcard_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tb12.Enter
        If Len(Tb12.Text) <> 6 Then
            MsgBox("Please Enter a valid 6-digit Clubcard Number")
        End If
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If Tb1.Text = "" Or Tb12.Text = "" Or Tb11.Text = "" Then
            MsgBox("You must fill out all of the first four fields.")
        ElseIf Tb1.Text <> "" And Tb12.Text <> "" And CboCounty.SelectedIndex >= 0 And Tb11.Text <> "" Then
            PriceFruit = Tb10.Text * Tb3.Text   'total Fruit price
            Plastic = Tb7.Text * 0.22 'total plastic bag price
            TotalFrozen = Tb8.Text
            TotalMeat = Tb9.Text
            Subtotal = PriceFruit + TotalFrozen + TotalMeat + Plastic
            Tb6.Text = Subtotal

            If CboCounty.SelectedIndex > 1 Then
                Delivery = 5.0
            Else
                Delivery = 0
            End If
            Tb4.Text = Delivery



            Clubcardlast = Mid(Tb12.Text, 6, 1) 'find last digit of clubcard
            If Clubcardlast = "2" Or Clubcardlast = "3" Or Clubcardlast = "4" Then
                Deduction = 10%
                Tb5.Text = Deduction
                TotalBill = Subtotal * 0.9
            ElseIf Clubcardlast = "5" Then
                Deduction = 12%
                Tb5.Text = Deduction
                TotalBill = Subtotal * 0.88
            Else
                Deduction = 0
                Tb5.Text = 0
            End If
            Tb14.Text = TotalBill
            Change = Tb11.Text - TotalBill
            Tb13.Text = Change


            'If total bill exceeds budget change both boxes to red
            If TotalBill > Tb11.Text Then
                Tb14.BackColor = Color.Red
                Tb11.BackColor = Color.Red
            End If

        End If



    End Sub

End Class
