Public Class StringFunctions

    Public Sub New()

    End Sub

    Public Function JoinFromWhiteSpace(ByVal TextToSplit As String, ByVal IsWithUpper As Boolean) As String
        'Cümledeki boþluklarý keser ve istenirse kelimelerin ilk karakterlerini büyütür..
        Dim result As String = ""

        If Trim(TextToSplit).Length = 0 Then
            Return result
            Exit Function
        End If

        Dim arr As ArrayList = New ArrayList

        arr.Add(TextToSplit.Split(" "))
        For Each str As String In arr.Item(0)
            If IsWithUpper = True AndAlso Trim(str).Length <> 0 Then
                str = str.Substring(0, 1).ToUpper & str.Substring(1).ToString
            ElseIf IsWithUpper = False AndAlso Trim(str).Length <> 0 Then
                str = str.ToString
            End If
            result &= str
        Next

        'result = result.Substring(0, 1).ToUpper & result.Substring(1)

        Return result
    End Function
End Class
