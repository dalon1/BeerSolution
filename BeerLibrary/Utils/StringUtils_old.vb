Module StringUtils_old
    Public Function GetValue(ByVal prompt As String) As String
        Console.Write("{0}: ", prompt)
        Return Console.ReadLine()
    End Function
End Module
