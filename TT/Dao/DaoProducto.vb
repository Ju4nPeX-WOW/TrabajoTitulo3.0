Public Class DaoProducto

    ' NO ESTA HECHO PARA RETORNAR PRODUCTOS SEUDO BORRADOS

    Public Function ObtenerTodosLosProductos()
        Dim instrucciones As New Instructions
        Dim tabla = "Productos as p 
LEFT JOIN Producto_Categoria as pc ON p.Id_producto = pc.Id_producto
LEFT JOIN Categorias as c ON c.Id_categoria = pc.Id_categoria 
WHERE p.False_delete = 0"
        Dim columnas = "p.Id_producto as Id ,
	p.Nombre as Producto, 
	c.Nombre as Categoria, 
	p.Precio ,p.Stock , p.Stock_critico"
        Return instrucciones.Seleccionar(tabla, columnas, "")

    End Function

    Public Function ObtenerProductosEspecificos(condicion As String)
        Dim instrucciones As New Instructions
        Dim recondicion As String = " AND " & condicion

        Return instrucciones.SelectWithFalseDelete("Productos", "*", recondicion)

    End Function
    Public Function ObtenerColumnasEspecificas(columnas)
        Dim instrucciones As New Instructions
        Return instrucciones.Seleccionar("Productos", columnas, " WHERE FALSE_DELETE = 0")
    End Function
    Public Sub ModificarProducto(valorColumn As String, idproducto As String)
        Dim instrucciones As New Instructions
        Dim recondicion As String = "Id_producto = " & idproducto
        instrucciones.Modificar("Productos", valorColumn, recondicion)

    End Sub

    Public Function busquedaIncremental(columnas, tabla, columnaBusqueda, texto)
        Dim instrucciones As New Instructions
        Return instrucciones.busquedaIncremental(columnas, "Productos", columnaBusqueda, texto)
    End Function

    Public Sub AgregarProducto(valores As String)
        Dim instrucciones As New Instructions
        instrucciones.Insertar("Productos", "Nombre,Precio,Stock,Stock_critico", valores)
    End Sub

    Public Sub EliminarProducto(idProducto As String)
        Dim instrucciones As New Instructions
        Dim recondicion As String = "Id_producto = " & idProducto
        instrucciones.FalseDelete("Productos", recondicion)
    End Sub


    Public Sub AjustarPrecio(valores As String)
        Dim instrucciones As New Instructions
        Console.WriteLine(valores)
        instrucciones.Insertar("Ajuste_Precios", "Id_producto,Fecha,Hora,Precio,Rut_empleado", valores)
    End Sub

    Public Sub AjustarStock(valores As String)
        Dim instrucciones As New Instructions
        Console.WriteLine(valores)
        instrucciones.Insertar("Ajuste_Stock", "Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado", valores)
    End Sub

    Public Function ObtenerStockCritico()
        Dim instrucciones As New Instructions
        Dim text = instrucciones.SelectWithFalseDelete("Productos", "Nombre,Stock", "and (Productos.Stock <= Productos.Stock_critico)")
        Return text
    End Function

End Class
