Imports BeerLibrary
Imports System.IO

Public Class BeerProvider
    Implements IBeerProvider
    Dim beerMapper As New BeerMapper
    Public Sub AddBeer(ByRef beers As List(Of Beer), ByRef beer As Beer) Implements IBeerProvider.AddBeer
        Throw New NotImplementedException()
    End Sub

    Public Sub AddBeer(ByRef beers As List(Of Beer), ByRef beer As Beer, ByRef log As String) Implements IBeerProvider.AddBeer
        Throw New NotImplementedException()
    End Sub

    Public Sub UpdateBeer(ByRef beers As List(Of Beer), ByRef beer As Beer) Implements IBeerProvider.UpdateBeer
        Throw New NotImplementedException()
    End Sub

    Public Sub UpdateBeer(ByRef beers As List(Of Beer), ByRef beer As Beer, ByRef log As String) Implements IBeerProvider.UpdateBeer
        Throw New NotImplementedException()
    End Sub

    Public Sub Save(path As String, ByRef beers As List(Of Beer)) Implements IBeerProvider.Save
        Throw New NotImplementedException()
    End Sub

    Public Sub Save(path As String, ByRef beers As List(Of Beer), ByRef log As String) Implements IBeerProvider.Save
        Dim ln As String
        Using writer As StreamWriter = New StreamWriter(path)
            For Each beer As Beer In beers
                ln = String.Format("{0},{1},{2},{3},{4}", beer.Company, beer.Name, beer.Type, beer.Alcohol, beer.Calories)
                writer.WriteLine(ln)
            Next
            log += (New Log("New Document has been Created")).ToString()
        End Using
    End Sub

    Public Function GetAll(path As String) As List(Of Beer) Implements IBeerProvider.GetAll
        Throw New NotImplementedException()
    End Function

    Public Function GetAll(path As String, ByRef log As String) As List(Of Beer) Implements IBeerProvider.GetAll
        Dim beers As New List(Of Beer)
        Dim ln As String
        Dim beer As Beer
        Using reader As StreamReader = New StreamReader(path)
            ln = reader.ReadLine
            Do While (Not ln Is Nothing)
                beer = beerMapper.toBeer(ln, log)
                If beer IsNot Nothing Then
                    beers.Add(beer)
                End If
                ln = reader.ReadLine
            Loop
        End Using
        Return beers
    End Function

    Public Function GetById(ByRef beers As List(Of Beer), id As String) As Beer Implements IBeerProvider.GetById
        Throw New NotImplementedException()
    End Function

    Public Function GetById(ByRef beers As List(Of Beer), id As String, ByRef log As String) As Beer Implements IBeerProvider.GetById
        Throw New NotImplementedException()
    End Function

    Public Function Delete(ByRef beers As List(Of Beer), id As String) As Boolean Implements IBeerProvider.Delete
        Throw New NotImplementedException()
    End Function

    Public Function Delete(ByRef beers As List(Of Beer), id As String, ByRef log As String) As Boolean Implements IBeerProvider.Delete
        Throw New NotImplementedException()
    End Function
End Class
