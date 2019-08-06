Public Class FrmNotaDebito


    Dim folderPath1 As String

    Dim bsnDocumento As New BsnDocumentos

    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    ' This example uses classes from the System.IO namespace.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        folderPath1 = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\DOCUMENTOS\NOTADEBITO"

        bsnDocumento.ListFiles(folderPath1, filesListBox)
    End Sub




    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        If filesListBox.SelectedIndex <> 0 Then
            bsnDocumento.OpenFile(folderPath1, filesListBox, AxAcroPDF1)
        End If
    End Sub


    Private Sub filesListBox_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles filesListBox.MouseDoubleClick
        bsnDocumento.OpenFile(folderPath1, filesListBox, AxAcroPDF1)

    End Sub

    Private Sub BtnExitCat_Click_1(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub
End Class
