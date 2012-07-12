Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bn1.Click
        Dim choice As String
        Dim horoscopes As String
        choice = Tb1.Text
        choice = UCase(choice)

        'Horoscopess Pictures
        Select Case choice 
            Case "ARIES"
                Pb1.Load("E:\Exercises\Star Signs\20px-Aries.svg.png")
            Case "TAURUS"
                Pb1.Load("E:\Exercises\Star Signs\20px-Taurus.svg.png")
            Case "GEMINI"
                Pb1.Load("E:\Exercises\Star Signs\20px-Gemini.svg.png")
            Case "CANCER"
                Pb1.Load("E:\Exercises\Star Signs\20px-Cancer.svg.png")
            Case "LEO"
                Pb1.Load("E:\Exercises\Star Signs\20px-Leo.svg.png")
            Case "VIRGO"
                Pb1.Load("E:\Exercises\Star Signs\20px-Virgo.svg.png")
            Case "LIBRA"
                Pb1.Load("E:\Exercises\Star Signs\20px-Libra.svg.png")
            Case "SCORPIO"
                Pb1.Load("E:\Exercises\Star Signs\20px-Scorpio.svg.png")
            Case "SAGITTARIUS"
                Pb1.Load("E:\Exercises\Star Signs\20px-Sagittarius.svg.png")
            Case "CAPRICORN"
                Pb1.Load("E:\Exercises\Star Signs\20px-Capricorn.svg.png")
            Case "AQUARIUS"
                Pb1.Load("E:\Exercises\Star Signs\20px-Aquarius.svg.png")
            Case "PISCES"
                Pb1.Load("E:\Exercises\Star Signs\20px-Pisces.svg.png")
        End Select

        horoscopes = "Conversations are lively today, words flowing back and forth with a natural rhythm. It seems as if there is a really good connection between you and your friends, but something significant isn't being addressed. The more questions you ask in your process of discovery, the less you realise you know. Instead of searching for answers now, simply relax and enjoy the light-hearted interactions. You can continue your search for meaning tomorrow."
        Tb2.Text = horoscopes

    End Sub
End Class
