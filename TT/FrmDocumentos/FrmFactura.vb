Imports System.IO
Public Class FrmFactura
    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub






    ' This example uses classes from the System.IO namespace.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListFiles1("C:\Users\kevin\Desktop\TTV2\Trabajo Version 8\DOCUMENTOS\FACTURACOMPRA")
        ListFiles2("C:\Users\kevin\Desktop\TTV2\Trabajo Version 8\DOCUMENTOS\FACTURAVENTA")

    End Sub

    'direcctorio
    'C:\Users\kevin\Desktop\Casa

    Private Sub ListFiles1(ByVal folderPath As String)
        Console.WriteLine(folderPath)
        filesListBox1.Items.Clear()

        Dim fileNames As String() =
                System.IO.Directory.GetFiles(folderPath,
                    "*.pdf", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            filesListBox1.Items.Add(fileName)
            Console.WriteLine(fileName)
        Next
    End Sub

    Private Sub ListFiles2(ByVal folderPath As String)
        Console.WriteLine(folderPath)
        filesListBox2.Items.Clear()

        Dim fileNames As String() =
                System.IO.Directory.GetFiles(folderPath,
                    "*.pdf", System.IO.SearchOption.TopDirectoryOnly)

        For Each fileName As String In fileNames
            filesListBox2.Items.Add(fileName)
            Console.WriteLine(fileName)
        Next
    End Sub





    Private Sub filesListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles filesListBox1.MouseDoubleClick
        AxAcroPDF1.src = filesListBox1.SelectedItem
    End Sub
    Private Sub filesListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles filesListBox2.MouseDoubleClick
        AxAcroPDF2.src = filesListBox2.SelectedItem
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If filesListBox2.SelectedIndex <> 0 Then
            AxAcroPDF2.src = filesListBox2.SelectedItem
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If filesListBox1.SelectedIndex <> 0 Then
            AxAcroPDF1.src = filesListBox1.SelectedItem
        End If
    End Sub
End Class


