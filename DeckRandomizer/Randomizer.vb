Imports MersenneTwister

Public Class Randomizer
    Shared st As Integer = 0
    Shared Sub RandomizeDeck(ByRef tmpCardDeck As String())
        Dim x As Integer
        Dim swap As String
        Dim r As Random
        Try
            r = New Random()
            For i As Integer = 0 To tmpCardDeck.GetUpperBound(0)
                x = r.Next(0, tmpCardDeck.GetUpperBound(0) + 1)
                swap = tmpCardDeck(x)
                tmpCardDeck(x) = tmpCardDeck(i)
                tmpCardDeck(i) = swap
            Next i

        Catch ex As Exception
            'HandleAllExceptions(ex)
        Finally
            r = Nothing
        End Try
    End Sub

    Shared Sub RandomizeDeckMT(ByRef tmpCardDeck As String())
        Dim x As Integer
        Dim swap As String
        Dim r As MTRandom
        Try
            r = New MTRandom()

            For i As Integer = 0 To tmpCardDeck.GetUpperBound(0)
                r.init_random(False)
                x = r.genrand_intRange(0 + st, tmpCardDeck.GetUpperBound(0) + st) - st
                ' x = r.genrand_intRange(0, i)
                swap = tmpCardDeck(x)
                tmpCardDeck(x) = tmpCardDeck(i)
                tmpCardDeck(i) = swap
                st = st + 1
            Next i


        Catch ex As Exception
            'HandleAllExceptions(ex)
        Finally
            r = Nothing
        End Try
    End Sub
End Class
