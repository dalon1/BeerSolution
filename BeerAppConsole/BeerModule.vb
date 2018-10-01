Imports System.IO
Imports BeerLibrary

Module BeerModule

    Sub Main()
        Dim beers As New List(Of Beer)
        Dim path As String, dir As String
        path = "C:\Users\Dannel\Development\vb_net_projects\logs\beer-data.txt"
        dir = "C:\Users\Dannel\Development\vb_net_projects\logs\"
        ReadFile(path, beers)

        'AddBeer(beers)
        'SaveFile(dir + "beer-data-1.txt", beers)

        For Each beer In beers
            Console.WriteLine("{0}, {1}", beer.Company, beer.Name)
        Next beer
        Console.WriteLine(New Log("Dannel is here", New Exception))
        Console.WriteLine(New Log("Dannel is success"))
        Console.ReadKey()
    End Sub

    Sub ReadFile(ByVal path As String, ByRef beers As List(Of Beer))
        Dim ln As String
        Dim beer As Beer
        Using reader As StreamReader = New StreamReader(path)
            ln = reader.ReadLine
            Do While (Not ln Is Nothing)
                beer = MapToBeer(ln)
                If beer IsNot Nothing Then
                    beers.Add(beer)
                End If
                ln = reader.ReadLine
            Loop
        End Using
    End Sub

    Function MapToBeer(ByVal stream As String) As Beer

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
            Console.WriteLine("LOG-SUCCESS-{0}: Beer was successfully retrieved!", DateTime.Now.ToString("yyymmddHHmmssffffff"))
        Catch ex As Exception
            Console.WriteLine("LOG-ERROR-{0}: There was an error populating the beer object", DateTime.Now.ToString("yyymmddHHmmssffffff"))
            Console.WriteLine("{0}CausedBy: {1}{2}", vbTab, ex.Message, vbNewLine)
            Return Nothing
        End Try
        Return beer
    End Function

    'Sub AddBeer(ByRef beers As List(Of Beer))
    '    Dim questions() As String = {"What's the", "How much/many"}
    '    Dim args() As String = {"Company", "Name", "Type", "Alcohol", "Calories"}
    '    Dim beer As New Beer
    '    Try
    '        beer.Company = StringUtils.GetValue(String.Format("{0} {1}?", questions(0), args(0)))
    '        beer.Name = StringUtils.GetValue(String.Format("{0} {1}?", questions(0), args(1)))
    '        beer.Type = StringUtils.GetValue(String.Format("{0} {1}?", questions(0), args(2)))
    '        beer.Alcohol = Double.Parse(StringUtils.GetValue(String.Format("{0} {1}?", questions(1), args(3))))
    '        beer.Calories = Integer.Parse(StringUtils.GetValue(String.Format("{0} {1}?", questions(1), args(4))))
    '        beers.Add(beer)
    '    Catch ex As Exception
    '        Console.WriteLine("LOG-ERROR-{0}: There was an error creating the beer object", DateTime.Now.ToString("yyymmddHHmmssffffff"))
    '        Console.WriteLine("{0}CausedBy: {1}{2}", vbTab, ex.Message, vbNewLine)
    '    End Try
    'End Sub

    Sub SaveFile(ByVal path As String, ByRef beers As List(Of Beer))
        Dim ln As String
        Using writer As StreamWriter = New StreamWriter(path)
            For Each beer As Beer In beers
                ln = String.Format("{0},{1},{2},{3},{4}", beer.Company, beer.Name, beer.Type, beer.Alcohol, beer.Calories)
                writer.WriteLine(ln)
            Next
        End Using
    End Sub
End Module
