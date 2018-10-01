Public Interface IBeerProvider
    Function GetAll(ByVal path As String) As List(Of Beer)
    Function GetAll(ByVal path As String, ByRef log As String) As List(Of Beer)
    Function GetById(ByRef beers As List(Of Beer), ByVal id As String) As Beer
    Function GetById(ByRef beers As List(Of Beer), ByVal id As String, ByRef log As String) As Beer
    Sub AddBeer(ByRef beers As List(Of Beer), ByRef beer As Beer)
    Sub AddBeer(ByRef beers As List(Of Beer), ByRef beer As Beer, ByRef log As String)
    Sub UpdateBeer(ByRef beers As List(Of Beer), ByRef beer As Beer)
    Sub UpdateBeer(ByRef beers As List(Of Beer), ByRef beer As Beer, ByRef log As String)
    Function Delete(ByRef beers As List(Of Beer), ByVal id As String) As Boolean
    Function Delete(ByRef beers As List(Of Beer), ByVal id As String, ByRef log As String) As Boolean
    Sub Save(ByVal path As String, ByRef beers As List(Of Beer))
    Sub Save(ByVal path As String, ByRef beers As List(Of Beer), ByRef log As String)
End Interface
