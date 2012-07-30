Module Module1

    'http://www.dotnet4freshers.com/BubbleSort/frmBubbleSort.aspx
    Sub Main()

        System.Console.WriteLine("Enter any sequence of numbers" & _
        " followed by a space.")

        'read teh array to a string
        Dim OurArrayString As String = System.Console.ReadLine()

        Dim OurArray As String()
        'split the string to an array
        OurArray = OurArrayString.Split(" ")

        'Start Bubble sort algorithm
        Dim i As Integer
        Dim j As Integer

        For i = 0 To UBound(ourArray) Step 1
            'Ubound of an array will be the maximum index of that array

            'start another for loop
            For j = 0 To UBound(ourArray) - 1

                If CInt(ourArray(j + 1)) > CInt(ourArray(j)) Then
                    'Swapping the variables in the array
                    ourArray(j + 1) = CInt(ourArray(j + 1)) + CInt(ourArray(j))
                    ourArray(j) = CInt(ourArray(j + 1)) - CInt(ourArray(j))
                    ourArray(j + 1) = CInt(ourArray(j + 1)) - CInt(ourArray(j))
                End If

            Next
        Next

        'display the out in the console window
        Console.WriteLine("the sorted array will be")
        For Each x In OurArray
            Console.Write(x & " ")
        Next

        Console.ReadLine()


    End Sub

End Module
