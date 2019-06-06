Public Class DaoDescuentos

    Dim instrucciones As New Instructions

    Public Function ObtenerDescuentos()
        Dim columnas As String = "Descuentos.Id_descuento, Productos.Nombre, Descuentos.Fecha_inicio , Descuentos.Fecha_termino , Descuentos.Condicion"
        Dim condicion As String = " INNER JOIN Productos ON Descuentos.Id_producto=Productos.Id_producto"
        Return instrucciones.Seleccionar("Descuentos", columnas, condicion)
    End Function
End Class



