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


End Class
