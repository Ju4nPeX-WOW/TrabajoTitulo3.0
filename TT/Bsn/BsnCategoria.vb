Public Class BsnCategoria
    Protected daoCategoria As New DaoCategoria
    Protected dataset As New DataSet
    Protected valorColumna As String

    Public Function ObtenerCategorias()
        dataset = daoCategoria.ObtenerCategorias
        Return dataset
    End Function

    Public Function ObtenerCategoriasBase()
        dataset = daoCategoria.ObtenerCategoriasBase



        Return dataset
    End Function

    Public Function ObtenerSubCategoria(dig As String)
        Return daoCategoria.ObtenerSubCategorias(dig)
    End Function

    Public Function ObtenerSubSubCategoria(dig As String)
        Return daoCategoria.ObtenerSubSubCategorias(dig)
    End Function






    Public Sub AgregarCategoria(Categoria As Categoria)
        valorColumna = "'" & Categoria.NomCateg & "','" & Categoria.CodCateg & "'"
        daoCategoria.agregarCategoria(valorColumna)

    End Sub

    Public Sub EditarCategoria(Categoria As Categoria)
        valorColumna = "nombre='" & Categoria.NomCateg & "', codigo=" & Categoria.CodCateg
        daoCategoria.EditarCategoria(valorColumna, Categoria.IdCateg)
    End Sub

    Public Sub EliminarCategoria(id As String)
        Dim valorColumna = "Id_categoria =" & id
        daoCategoria.eliminarCategoria(valorColumna)
    End Sub

    Public Function ObtenerCodigoBaseDisponible()
        Dim cod As String = "0"
        dataset = ObtenerCategoriasBase()
        Dim cont2 As Integer
        cont2 = 0
        Dim found As Boolean
        found = False

        If dataset.Tables(0).Rows.Count = 0 Then
            cod = "1000"
        Else
            cont2 = 0

            While Not (found)
                cont2 = cont2 + 1000

                For i = 0 To dataset.Tables(0).Rows.Count - 1
                    Console.WriteLine("CONT2 : " + cont2.ToString + "    " + dataset.Tables(0)(i)(2).ToString)
                    If (cont2.ToString).Equals(dataset.Tables(0)(i)(2).ToString) Then

                        found = True

                    End If

                Next

                If found Then
                    found = False
                    If cont2 = 9000 Then
                        found = True
                    End If
                Else
                    found = True
                    cod = cont2.ToString
                    Console.WriteLine("COD : " + cod)
                End If


            End While

        End If
        Return cod

    End Function

    Public Function ObtenerSubCodigoDisponible(dig As String)
        Dim cod As String = "0"
        dataset = ObtenerSubCategoria(dig)
        Dim cont2 As Integer
        cont2 = 0
        Dim found As Boolean
        found = False
        Console.WriteLine("Dig : " + dig + "  - Cantidad : " + dataset.Tables(0).Rows.Count.ToString)
        If dataset.Tables(0).Rows.Count = 0 Then
            cod = dig + "100"
        Else
            cont2 = 0

            While Not (found)
                cont2 = cont2 + 100

                For i = 0 To dataset.Tables(0).Rows.Count - 1
                    Console.WriteLine("?? : " + dataset.Tables(0)(i)(0).ToString)
                    Console.WriteLine("ID : " + dataset.Tables(0)(i)(1).ToString)
                    Console.WriteLine("Nombre : " + dataset.Tables(0)(i)(2).ToString)
                    Console.WriteLine("COD : " + dataset.Tables(0)(i)(3).ToString)

                    Console.WriteLine("CONT2 : " + dig + cont2.ToString + "   COD ? : " + dataset.Tables(0)(i)(0).ToString)
                    If (dig + cont2.ToString).Equals(dataset.Tables(0)(i)(0).ToString) Then

                        found = True

                    End If



                Next

                If found Then
                    found = False
                    If cont2 = 900 Then
                        found = True
                    End If
                Else
                    found = True
                    cod = dig + cont2.ToString
                    Console.WriteLine("COD : " + cod)
                End If


            End While

        End If
        Return cod







    End Function

    Public Function ObtenerSubSubCodigoDisponible(dig As String)
        Dim cod As String = "0"
        dataset = ObtenerSubSubCategoria(dig)
        Dim cont2 As Integer
        cont2 = 0
        Dim found As Boolean
        found = False
        Console.WriteLine("Dig : " + dig + "  - Cantidad : " + dataset.Tables(0).Rows.Count.ToString)
        If dataset.Tables(0).Rows.Count = 0 Then
            cod = dig + "01"
        Else
            cont2 = 0

            While Not (found)
                cont2 = cont2 + 1
                Dim a As String = cont2.ToString
                If Len(cont2.ToString) < 2 Then
                    a = "0" + cont2.ToString

                End If

                For i = 0 To dataset.Tables(0).Rows.Count - 1

                    Console.WriteLine("?? : " + dataset.Tables(0)(i)(0).ToString)
                    Console.WriteLine("ID : " + dataset.Tables(0)(i)(1).ToString)
                    Console.WriteLine("Nombre : " + dataset.Tables(0)(i)(2).ToString)
                    Console.WriteLine("COD : " + dataset.Tables(0)(i)(3).ToString)

                    Console.WriteLine("CONT2 : " + dig + a + "   COD ? : " + dataset.Tables(0)(i)(0).ToString)
                    If (dig + a).Equals(dataset.Tables(0)(i)(0).ToString) Then

                        found = True

                    End If



                Next

                If found Then
                    found = False
                    If cont2 = 99 Then
                        found = True
                    End If
                Else
                    found = True
                    cod = dig + a
                    Console.WriteLine("COD : " + cod)
                End If


            End While

        End If


        Return cod

    End Function


    Public Function ObtenerCodigo(ID As String)
        dataset = daoCategoria.ObtenerCodigo(ID)
        Dim cod As String
        cod = dataset.Tables(0)(0)(0).ToString
        Console.Write(cod)
        Return cod
    End Function

End Class
