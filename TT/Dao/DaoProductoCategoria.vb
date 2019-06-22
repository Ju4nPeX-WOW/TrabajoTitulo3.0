Public Class DaoProductoCategoria
    Dim instrucion As New Instructions

    Public Sub RelacionarProductoconCategoria(nombre As String, id_prod As String)
        Dim valores = "(SELECT Id_categoria FROM Categorias WHERE nombre = '" & nombre & "')," & id_prod


        instrucion.Insertar("Producto_Categoria", "Id_categoria,Id_producto", valores)

    End Sub
End Class
