
Module Utils
    Function get_RandomNumbers() As Integer()
        Dim rnd_Integers(4) As Integer

        For i = 0 To 2
            Randomize()
            rnd_Integers(i) = Int((9 + 1) * Rnd())
        Next

        Return rnd_Integers

    End Function
End Module
