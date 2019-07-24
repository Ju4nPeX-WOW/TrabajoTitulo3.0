Imports System.IO
Public Class Archivos

    Public Function LecturaCategorias()
        ':::Ruta donde crearemos nuestro archivo txt
        Dim ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\SQL\"
        ':::Nombre del archivo
        Dim archivo As String = "DefaultCategories.txt"
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim leer As New StreamReader(ruta & archivo)

        ':::Crear List
        Dim array(3) As String
        Dim Lista As New List(Of String())

        Try
            While leer.Peek <> -1
                ':::Leemos cada linea del archivo TXT
                Dim linea As String = leer.ReadLine()
                ':::Validamos que la linea no este vacia
                If String.IsNullOrEmpty(linea) Then
                    Continue While
                End If
                ':::Ver si omitimos o no la linea

                If Not (linea.Substring(0, 1).Equals("#")) And Not (linea.Substring(0, 1).Equals("-")) Then
                    ':::Agregramos los registros encontrados
                    array = linea.Split(";")
                    Lista.Add({array(0), array(1)})
                End If
            End While

            leer.Close()
            ':::Total de registros cargados al ListBox
            Console.WriteLine("Registros Preparados: " & Lista.Count)
        Catch ex As Exception
            MsgBox("NO SE ENCONTRARON DATOS POR DEFECTO" & ex.Message)
        End Try

        Return Lista
    End Function
    Public Sub ActualizacionStockCritico(text As String)
        ':::Ruta donde crearemos nuestro archivo txt
        Dim ruta As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\Files\"
        ':::Nombre del archivo
        Dim archivo As String = "StockCritico.txt"
        ':::Creamos nuestro objeto de tipo StreamReader que nos permite leer archivos
        Dim escribir As New StreamWriter(ruta & archivo)

        ':::Determinar si hay productos bajo stock
        Dim texto As String = ""
        If text.Length = 0 Then
            texto = ""
        ElseIf text.Length > 1 Then
            texto = "ALERTA!! LOS SIGUIENTES PRODUCTOS ESTAN CON STOCK CRITICO: " + text.ToUpper
        End If

        ':::Realizamos la escritura
        escribir.Write(texto)

        ':::Cerramos el archivo
        escribir.Close()


    End Sub


End Class
