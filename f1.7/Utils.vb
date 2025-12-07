
Module Utils
    Function get_RandomNumbers() As Integer()
        Dim rnd_Integers(4) As Integer

        For i = 0 To 2
            Randomize()
            rnd_Integers(i) = Int((9 + 1) * Rnd())
        Next

        Return rnd_Integers

    End Function

    Function calc_Win(result As Integer()) As Integer
        Dim numOfSevens = 0
        Dim balance = 0

        For i As Integer = 0 To 2
            If result(i) = 8 Then
                numOfSevens += 1
            End If
        Next

        If (numOfSevens = 0) Then
            Return -500
        ElseIf numOfSevens = 1 Then
            Return 1000
        ElseIf numOfSevens = 2 Then
            Return 2000
        ElseIf numOfSevens = 3 Then
            Return 100000
        End If

        Return -100000000

    End Function
End Module
