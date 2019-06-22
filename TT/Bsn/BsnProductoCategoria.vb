Public Class BsnProductoCategoria
    Dim daoProductoCategoria As New DaoProductoCategoria

    Public Sub RelacionarProductoconCategoria(nombrecat As String, id_producto As String)

        daoProductoCategoria.RelacionarProductoconCategoria(nombrecat, id_producto)

    End Sub

End Class
