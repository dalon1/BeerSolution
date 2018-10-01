Public Interface IBeerMapper
    Function toBeer(ByVal stream As String) As Beer
    Function toBeer(ByVal stream As String, ByRef log As String) As Beer
    Function toRecord(ByVal beer As Beer) As String
    Function toRecord(ByVal beer As Beer, ByRef log As String) As String
End Interface
