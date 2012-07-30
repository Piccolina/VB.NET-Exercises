Public Class Form1

    Private Sub Bn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim numNumbers As String
        Dim numbers As String

        If Not TextBox1.Text = "" Then
            ListBox1.Items.Add(TextBox1.Text)
            ReDim Preserve numbers(numNumbers)
            numbers(numNumbers) = CDbl(TextBox1.Text)
            numNumbers += 1
        End If
    End Sub

    Private Sub Bn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn2.Click
        BubbleSort(numbers)
        For Each x In numbers
            ListBox2.Items.Add(numbers(x).ToString())
        Next
    End Sub
End Class

Private Sub BubbleSort(ByRef numbers() As Integer)
    Dim temp
    Dim switch = True
    While switch
        switch = False
        For x = 0 To numbers.Length - 2
            If numbers(x) > numbers(x + 1) Then
                temp = numbers(x)
                numbers(x) = numbers(x + 1)
                numbers(x + 1) = temp
                switch = True
            End If
        Next
    End While
End Sub

Private Sub BubbleSortDesc(ByRef numbers() As Integer)
    Dim temp
    Dim switch = True
    While switch
        switch = False
        For x = 0 To numbers.Length - 2
            If numbers(x) < numbers(x + 1) Then
                temp = numbers(x)
                numbers(x) = numbers(x - 1)
                numbers(x - 1) = temp
                switch = True
            End If
        Next
    End While
End Sub