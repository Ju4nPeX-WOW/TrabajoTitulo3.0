Public Class BsnCategoria
    Protected daoCategoria As New DaoCategoria
    Protected dataset As New DataSet
    Protected valorColumna As String

    Public Function ObtenerCategorias()
        dataset = daoCategoria.ObtenerCategorias
        Return dataset
    End Function


    Public Sub modificarCategoria(Categoria As Categoria)
        valorColumna = " Id_categoria ='" & Categoria.IdCateg() & "' nombre='" & Categoria.NomCateg & "' codigo='" & Categoria.CodCateg & "'"
    End Sub

    Public Sub agregarCategoria(Categoria As Categoria)
        valorColumna = "'" & Categoria.NomCateg & "','" & Categoria.CodCateg & "'"
        daoCategoria.agregarCategoria(valorColumna)

    End Sub

    Public Sub editarCategoria(Categoria As Categoria)
        valorColumna = "nombre='" & Categoria.NomCateg & "', codigo=" & Categoria.CodCateg
        daoCategoria.editarCategoria(valorColumna, Categoria)
    End Sub

    Public Sub eliminarCategoria(Categoria As Categoria)
        Dim valorColumna = "Id_categoria =" & Categoria.IdCateg
        daoCategoria.eliminarCategoria(valorColumna)
    End Sub

End Class
