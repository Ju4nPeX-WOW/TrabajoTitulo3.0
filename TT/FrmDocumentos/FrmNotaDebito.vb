Public Class FrmNotaDebito
    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    ' This example uses classes from the System.IO namespace.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListFiles("C:\Users\kevin\Desktop\TTV2\Trabajo Version 8\DOCUMENTOS\NOTADEBITO")
    End Sub

    'direcctorio
    'C:\Users\kevin\Desktop\Casa

    Private Sub ListFiles(ByVal folderPath As String)
        Console.WriteLine(folderPath)
        filesListBox.Items.Clear()

        Dim fileNames As String() =
            System.IO.Directory.GetFiles(folderPath,
                "*.pdf", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            filesListBox.Items.Add(fileName)
            Console.WriteLine(fileName)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If filesListBox.SelectedIndex <> 0 Then
            AxAcroPDF1.src = filesListBox.SelectedItem
        End If

    End Sub



    Private Sub filesListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles filesListBox.MouseDoubleClick
        AxAcroPDF1.src = filesListBox.SelectedItem
    End Sub
End Class
