﻿Public Class BsnVenta
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

    Public Sub detalleVenta(productosSeleccionados As DataGridView, subtotal As String, descuento As String, total As String, num_venta As String, rut_vendedor As String)

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

            Dim bsnproductos As New BsnProducto
            Dim producto As Producto
            producto = bsnproductos.ObtenerObjetoProducto(idProducto)
            producto.Stock = producto.Stock - cantidad
            Dim num As New Enumeraciones
            bsnproductos.ModificarProducto(producto, num.RazonAjusteStock("Vendido"), rut_vendedor)

            DaoVenta.detalleVenta(num_venta, idProducto, cantidad, precio, subtotal, descuento, total)
        Next
    End Sub

    Public Function obtenerUltimaVenta()
        Dim ultimaVenta As Integer = 0
        Dim dataset As New DataSet
        dataset = DaoVenta.obtenerUltimaVenta()
        Try
            If dataset.Tables(0).Rows.Count <> 0 Then
                ultimaVenta = dataset.Tables(0)(0)(0)
                MsgBox(ultimaVenta)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)
        End Try
        Return ultimaVenta
    End Function

    Public Function ObtenerCondicionDescuento(IDProducto As String)
        Dim bsnDescuento As New BsnDescuentos
        Dim condicion As String = ""
        Dim condicioncodificada As String = bsnDescuento.GetCondicionDescuentoActivoProducto(IDProducto)
        If condicioncodificada.Length <> 0 Then
            condicion = bsnDescuento.Condicion(condicioncodificada)
        End If
        Return condicion
    End Function


    Public Function ObtenerDescuento(IDProducto As String, precio As Integer, cantidad As Integer)
        Dim bsnDescuento As New BsnDescuentos
        Dim condicion = {}
        Dim condicioncodificada As String = bsnDescuento.GetCondicionDescuentoActivoProducto(IDProducto)
        If condicioncodificada.Length <> 0 Then
            condicion = bsnDescuento.Condicion(condicioncodificada, precio, cantidad)
        End If
        Return condicion
    End Function




End Class
