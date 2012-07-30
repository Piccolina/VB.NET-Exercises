Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click

        Dim starter As Double
        Dim main As Double
        Dim Dessert As Double

        Dim Tea As Double
        Dim Coffee As Double
        Dim HotChocolate As Double

        Dim wine As Double
        Dim bill As Double

        'Starters
        If Cb1.Text = "Garlic Mushrooms" Then
            starter = 4.35
            Tb1.Text = starter

        ElseIf Cb1.Text = "Caesar Salad" Then
            starter = 4.55
            Tb1.Text = starter

        ElseIf Cb1.Text = "Cheesy Garlic Bread" Then
            starter = 3.85
            Tb1.Text = starter

        ElseIf Cb1.Text = "Tomato Soup" Then
            starter = 3.95
            Tb1.Text = starter
        End If

        'Main 
        If Cb2.Text = "Spaghetti Bolognese" Then
            main = "€9.95"
            Tb2.Text = main

        ElseIf Cb2.Text = "Mixed Seafood Pasta" Then
            main = "€12.55"
            Tb2.Text = main

        ElseIf Cb2.Text = "Vegetarian Pizza" Then
            main = "€10.65"
            Tb2.Text = main

        ElseIf Cb2.Text = "Chicken and Mushroom Tagatelli" Then
            main = "€11.95"
            Tb2.Text = main

        ElseIf Cb2.Text = "Sirloin Steak and Chips" Then
            main = "€18.95"
            Tb2.Text = main
        End If


        'Dessert
        If Cb3.Text = "Strawberry Cheesecake" Then
            Dessert = "€4.95"
            Tb3.Text = Dessert

        ElseIf Cb3.Text = "Chocolate Fudge Cake" Then
            Dessert = "€4.65"
            Tb3.Text = Dessert

        ElseIf Cb3.Text = "Tiramisu" Then
            Dessert = "€4.55"
            Tb3.Text = Dessert

        ElseIf Cb3.Text = "Mixed Ice-Cream" Then
            Dessert = "€3.50"
            Tb3.Text = Dessert
        End If

        'Tea & Coffee & Hot Chocolate
        If Ckb1.Checked Then
            Tea = 1.95
        End If


        If Ckb2.Checked Then
            Coffee = 1.85
        End If

        If Ckb3.Checked Then
            HotChocolate = 2.25
        End If

        'Wine
        If Rb1.Checked = True Then
            wine = 4.95
        ElseIf Rb2.Checked = True Then
            wine = 15.55
        End If

        bill = starter + main + Tea + Dessert + Coffee + HotChocolate + wine
        Tb4.Text = bill
    End Sub
End Class
