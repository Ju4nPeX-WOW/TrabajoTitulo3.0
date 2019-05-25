Public Class BsnDocumentos
    Public Sub ListFiles(ByVal folderPath As String, list As Object)
        Console.WriteLine(folderPath)
        list.Items.Clear()

        Dim fileNames As String() =
                System.IO.Directory.GetFiles(folderPath,
                    "*.pdf", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            list.Items.Add(fileName.Substring(Len(folderPath) + 1))
            Console.WriteLine(fileName)
        Next
    End Sub



    Public Sub OpenFile(ByVal folderPath As String, list As Object, pdf As Object)
        pdf.src = folderPath + "\" + list.SelectedItem
    End Sub
End Class
