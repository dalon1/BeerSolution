Imports BeerLibrary

Public Class BeerMainForm
    Public beers As New List(Of Beer)
    Public beerProvider As New BeerProvider
    Private Sub btnFileExplorer_Click(sender As Object, e As EventArgs) Handles btnFileExplorer.Click
        'Dim path As String
        Using ofd As New OpenFileDialog
            ofd.Filter = "Text (*.txt)|*.txt"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'path = ofd.FileName
                txtFilePath.Text = ofd.FileName
                beers = beerProvider.GetAll(ofd.FileName, txtLogs.Text)
                PopulateBeerGDV(beers)
            End If
        End Using
    End Sub

    Public Sub PopulateBeerGDV(beers As List(Of Beer))
        gdvBeers.DataSource = beers
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim path As String
        Using fbd As New FolderBrowserDialog
            If fbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ' This should be handle in a provider level
                path = String.Format("{0}/beer-data-{1}.txt", fbd.SelectedPath, DateTime.Now.ToString("yyymmddHHmmssffffff"))
                beers = gdvBeers.DataSource
                beerProvider.Save(path, beers, txtLogs.Text)
            End If
        End Using
    End Sub
End Class
