Public Class DaoVenta
    Dim Instructions As New Instructions
    Dim tabla As String = "Ventas"
    Dim tabla2 As String = "Detalle_Venta"

    Public Sub realizarVenta(columnas As String, valores As String)
        MsgBox("COLUMNAS = " & columnas & vbCrLf & "VALORES = " & valores)
        Instructions.Insertar(tabla, columnas, valores)
    End Sub
    Public Sub detalleVenta(num_venta As String, idProducto As String, cantidad As String, precio As String, subtotal As String, descuento As String, total As String)
        Dim columnas As String = ""
        Dim valores As String = ""
        columnas = "Num_venta,Id_producto,Cantidad,Precio,Subtotal,Descuento,Total"
        valores = num_venta & "," & idProducto.Trim & "," & cantidad & "," & precio & "," & subtotal & "," & descuento & "," & total
        Instructions.Insertar(tabla2, columnas, valores)
        'Me da error, debe ser que char solo acepta ciertos caracteres
    End Sub
    Public Function obtenerUltimaVenta()
        Return Instructions.obtenerNumeroVenta()
    End Function

End Class
