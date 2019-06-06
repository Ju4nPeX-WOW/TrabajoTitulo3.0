Public Class DaoCategoria


    Dim instrucciones As New Instructions
    Public Function ObtenerTodasCategorias()
        Return instrucciones.Seleccionar("Categorias", "*", "order by Codigo")
    End Function
    Public Function ObtenerCategorias()
        Return instrucciones.SelectWithFalseDelete("Categorias", "*", "order by Codigo ")
    End Function

    Public Function ObtenerCategoriasBase()
        Return instrucciones.SelectWithFalseDelete("Categorias", "*", "and Codigo Like '_000' ")
    End Function

    Public Function ObtenerSubCategorias(dig As String)
        Return instrucciones.SelectWithFalseDelete("Categorias", "*", "and Codigo Like '" + dig + "[^0]00'")
    End Function
    Public Function ObtenerSubSubCategorias(dig As String)
        Return instrucciones.SelectWithFalseDelete("Categorias", "*", "and Codigo Like '" + dig + "_[^0]'")
    End Function

    Public Sub AgregarCategoria(valorColumna As String)
        instrucciones.Insertar("Categorias", "nombre,codigo", valorColumna)
    End Sub

    Public Sub EditarCategoria(valorColumna As String, ID As String)
        'condicion es igual al identificador de la categoria para que en instrucciones,
        'el where sea igual a condicion... where = condicion
        Dim condicion As String = " Id_categoria =" & ID
        instrucciones.Modificar("Categorias", valorColumna, condicion)

    End Sub

    Public Sub EliminarCategoria(valorColumna As String)
        instrucciones.Eliminar("Categorias", valorColumna)
    End Sub

    Public Function ObtenerCodigo(ID As String)
        Return instrucciones.SelectWithFalseDelete("Categorias", "Codigo", "and Id_categoria = " + ID)
    End Function

End Class
