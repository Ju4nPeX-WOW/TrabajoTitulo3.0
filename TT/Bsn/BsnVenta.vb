Public Class BsnVenta
    Protected DaoVenta As New DaoVenta()

    Public Sub realizarVenta(rutCliente As String, rutVendedor As String, subtotal As String, descuento As String, total As String, iva As Integer, medio_pago As Byte, tipo_venta As Byte)
        'insertar en Venta

        '           num_venta
        '           rut_cliente
        '           rut_empleado
        '           fecha ->DaoVenta como string converter(date,SYSDATE())
        '           hora  ->DaoVenta como string converter(time,SYSDATE())
        '           subtotal
        '           descuento
        '           total
        '           iva
        '           medio_pago
        '           factura
        '           boleta
        '           nota_credito
        '           nota_debito

        Dim columnas As String = ""
        columnas = "Rut_cliente,Rut_empleado,Fecha,Hora,Subtotal,Descuento,Total,Iva,Medio_pago,Factura,Boleta,Nota_credito,Nota_debito"
        Dim valores As String = ""
        valores = rutCliente & "," &
                  rutVendedor & "," &
                  "CONVERT(DATE,SYSDATETIME())" & "," &
                  "CONVERT(TIME,SYSDATETIME())" & "," &
                  subtotal & "," &
                  descuento & "," &
                  total & "," &
                  iva & "," &
                  medio_pago & ","
        If tipo_venta = 0 Then 'boleta
            '                   Factura       ,  Boleta   ,  Nota_credito , Nota_debito
            valores = valores & tipo_venta & "," & "1" & "," & "0" & "," & "0"
        Else 'factura
            '                  Factura       ,  Boleta   ,  Nota_credito , Nota_debito
            valores = valores & tipo_venta & "," & "0" & "," & "0" & "," & "0"
        End If

        DaoVenta.realizarVenta(columnas, valores)

    End Sub

    Public Sub detalleVenta(productosSeleccionados As DataGridView, subtotal As String, descuento As String, total As String, num_venta As String)

        'Insertar en Detalle_Venta
        '           Id_Producto ( con el for ) 
        '           cantidad
        '           Precio
        '           Subtotal //
        '           descuento //
        '           Total //
        Dim idProducto As String = ""
        Dim cantidad As String = ""
        Dim precio As String = ""


        For index = 0 To productosSeleccionados.Rows.Count - 1

            idProducto = productosSeleccionados.Rows(index).Cells(0).Value
            precio = productosSeleccionados.Rows(index).Cells(2).Value
            cantidad = productosSeleccionados.Rows(index).Cells(3).Value

            DaoVenta.detalleVenta(num_venta, idProducto, cantidad, precio, subtotal, descuento, total)
        Next
    End Sub

    Public Function obtenerUltimaVenta()
        Return DaoVenta.obtenerUltimaVenta()
    End Function

End Class
