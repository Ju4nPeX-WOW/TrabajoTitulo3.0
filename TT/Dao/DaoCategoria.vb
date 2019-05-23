Public Class DaoCategoria


    Dim instrucciones As New Instructions
    Public Function ObtenerTodasCategorias()
        Return instrucciones.Seleccionar("Categorias", "*", "")
    End Function

    Public Sub agregarCategoria(valorColumna As String)
        instrucciones.Insertar("Categorias", "nombre,codigo", valorColumna)
    End Sub

    Public Sub editarCategoria(valorColumna As String, Categoria As Categoria)
        'condicion es igual al identificador de la categoria para que en instrucciones,
        'el where sea igual a condicion... where = condicion
        Dim condicion As String = " Id_categoria =" & Categoria.IdCateg
        instrucciones.Modificar("Categorias", valorColumna, condicion)

    End Sub

    Public Sub eliminarCategoria(valorColumna As String)
        instrucciones.Eliminar("Categorias", valorColumna)
    End Sub

End Class
