Public Class DaoDescuentos

    Dim instrucciones As New Instructions

    Public Function ObtenerDescuentos()
        Dim columnas As String = "Descuentos.Id_descuento, Productos.Nombre, Descuentos.Fecha_inicio , Descuentos.Fecha_termino , Descuentos.Condicion"
        Dim condicion As String = " INNER JOIN Productos ON Descuentos.Id_producto=Productos.Id_producto"
        Return instrucciones.Seleccionar("Descuentos", columnas, condicion)
    End Function

    Public Function ObtenerIdProducto(id_descuento As String)
        Dim columnas As String = "Id_producto"
        Dim condicion As String = " Id_descuento = " & id_descuento
        Return instrucciones.Seleccionar("Descuentos", columnas, condicion)
    End Function

    Public Sub DarFin(id_descuento As String)
        instrucciones.Modificar("Descuentos", "Fecha_termino = " & DateTime.Now.ToString("dd/MM/yyyy"), "Id_descuento = " & id_descuento)
    End Sub
End Class



