Imports System.IO
Public Class FrmFactura
    Dim choise = 1
    Dim folderPath1, folderPath2 As String

    Dim bsnDocumento As New BsnDocumentos



    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub






    ' This example uses classes from the System.IO namespace.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        folderPath1 = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\DOCUMENTOS\FACTURACOMPRA"
        folderPath2 = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\DOCUMENTOS\FACTURAVENTA"

        bsnDocumento.ListFiles(folderPath1, filesListBox1)
        bsnDocumento.ListFiles(folderPath2, filesListBox2)

    End Sub




    Private Sub filesListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles filesListBox1.MouseDoubleClick
        bsnDocumento.OpenFile(folderPath1, filesListBox1, AxAcroPDF1)
        choise = 1
    End Sub
    Private Sub filesListBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles filesListBox2.MouseDoubleClick
        bsnDocumento.OpenFile(folderPath2, filesListBox2, AxAcroPDF2)
        choise = 2
    End Sub

    Private Sub btnAbrirF_Click(sender As Object, e As EventArgs) Handles btnAbrirF.Click
        If filesListBox2.SelectedIndex <> 0 Then
            bsnDocumento.OpenFile(folderPath2, filesListBox2, AxAcroPDF2)
        End If
    End Sub

    Private Sub btnAbrirC_Click(sender As Object, e As EventArgs) Handles btnAbrirC.Click
        If filesListBox1.SelectedIndex <> 0 Then
            bsnDocumento.OpenFile(folderPath1, filesListBox1, AxAcroPDF1)
        End If

    End Sub


End Class


