Public Class DaoHistoAjustes
    Dim Instructions As New Instructions

    Public Function obtHistPrecios()
        Return Instructions.Seleccionar("Ajuste_Precios", "Id_producto,Fecha,Hora,Precio,Rut_empleado", "")
    End Function

    Public Function obtHistStock()
        Return Instructions.Seleccionar("Ajuste_Stock", "Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado", "")
    End Function
End Class
