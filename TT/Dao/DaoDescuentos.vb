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
        instrucciones.Modificar("Descuentos", "Fecha_termino = '" & DateTime.Now.ToString("dd/MM/yyyy") & "'", "Id_descuento = " & id_descuento)
    End Sub

    Public Sub AgregarDescuento(o As Descuento)
        Dim columnas As String = "Id_producto,Fecha_inicio,Fecha_termino,Condicion"
        Dim valores As String = o.IdProducto & ",'" & o.FechaInicio & "','" & o.FechaTermino & "','" & o.Condicion & "'"
        instrucciones.Insertar("Descuentos", columnas, valores)
    End Sub

    Public Sub ModificarDescuento(o As Descuento)
        Dim columnas As String = "Id_producto=" & o.IdProducto & ",Fecha_termino='" & o.FechaTermino & "' ,Condicion='" & o.Condicion & "'"
        Dim condicion As String = "Id_producto = " & o.IdDescuento

        instrucciones.Modificar("Descuentos", columnas, condicion)

    End Sub
End Class



