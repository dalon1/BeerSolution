Imports BeerLibrary

Public Class BeerMapper
    Implements IBeerMapper

    Public Function toBeer(stream As String) As Beer Implements IBeerMapper.toBeer
        Return toBeer(stream, Nothing)
    End Function

    Public Function toBeer(stream As String, ByRef log As String) As Beer Implements IBeerMapper.toBeer
        If stream Is Nothing Then
            Return Nothing
        End If

        Dim beer As New Beer
        Dim args() As String
        Try
            args = stream.Split(",")
            beer.Company = args(0)
            beer.Name = args(1)
            beer.Type = args(2)
            beer.Alcohol = args(3)
            beer.Calories = args(4)
            log += (New Log("Beer was added successfully!")).ToString()
        Catch ex As Exception
            log += (New Log("There was a problem adding the beer", ex)).ToString()
            Return Nothing
        End Try
        Return beer
    End Function

    Public Function toRecord(beer As Beer) As String Implements IBeerMapper.toRecord
        Throw New NotImplementedException()
    End Function

    Public Function toRecord(beer As Beer, ByRef log As String) As String Implements IBeerMapper.toRecord
        Throw New NotImplementedException()
    End Function
End Class
