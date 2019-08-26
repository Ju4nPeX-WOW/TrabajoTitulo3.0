
Public Class BsnProducto

    Protected dataset As New DataSet
    Protected adapter As New OleDb.OleDbDataAdapter




    Public Function ObtenerTodosLosProductos()
        Dim daoProducto As New DaoProducto
        Return daoProducto.ObtenerTodosLosProductos()
    End Function

    Public Function ObtenerObjetoProducto(id_producto As String)
        Dim daoProducto As New DaoProducto
        Dim dataset As New DataSet

        dataset = daoProducto.ObtenerProductosEspecificos(" Id_producto = " & id_producto)
        Console.WriteLine("IIIID" & dataset.Tables(0)(0)(0))
        Dim producto As New Producto
        producto.IdProducto = Integer.Parse(dataset.Tables(0)(0)(0))
        producto.Nombre = dataset.Tables(0)(0)(1)
        producto.Precio = Integer.Parse(dataset.Tables(0)(0)(2))
        producto.Stock = Integer.Parse(dataset.Tables(0)(0)(3))
        producto.StockCritico = Integer.Parse(dataset.Tables(0)(0)(4))

        Return producto
    End Function

    Public Function ObtenerProductosEspecificos(condicion As String)
        Dim daoProducto As New DaoProducto
        Return daoProducto.ObtenerProductosEspecificos(condicion)
    End Function

    Public Function ObtenerColumnasEspecificas(columnas As String)
        Dim daoProducto As New DaoProducto
        Return daoProducto.ObtenerColumnasEspecificas(columnas)
    End Function

    Public Function BusquedaIncremental(columnas As String, tabla As String, columnaBusqueda As String, texto As String)
        Dim daoProducto As New DaoProducto
        dataset = daoProducto.busquedaIncremental(columnas, tabla, columnaBusqueda, texto)
        Return dataset
    End Function

    Public Sub AgregarProducto(producto As Producto, razon As String, rut_usuario As Integer)
        Dim enumeraciones As New Enumeraciones
        Dim daoProducto As New DaoProducto
        Dim valores As String
        valores = "'" & producto.Nombre.ToString & "'," & producto.Precio & "," & producto.Stock & "," & producto.StockCritico
        Console.WriteLine(valores)

        RealizarAjuste(producto, enumeraciones.RazonAjusteStock(razon), rut_usuario)
        daoProducto.AgregarProducto(valores)

    End Sub
    Public Sub ModificarProducto(producto As Producto, razon As String, rut_usuario As Integer)

        Dim enumeraciones As New Enumeraciones
        Dim daoProducto As New DaoProducto
        Dim valorColumna As String
        valorColumna = "Nombre='" & producto.Nombre & "',Precio=" & producto.Precio & ",Stock=" & producto.Stock & ",Stock_critico=" & producto.StockCritico
        RealizarAjuste(producto, enumeraciones.RazonAjusteStock(razon), rut_usuario)
        daoProducto.ModificarProducto(valorColumna, producto.IdProducto)
    End Sub

    Private Sub AjustarPrecioProducto(id_producto As Integer, precio As Integer, rut_usuario As Integer)
        Dim daoProducto As New DaoProducto
        Dim valores As String
        valores = id_producto & ",SYSDATETIME( ),SYSDATETIME( )," & precio & "," & rut_usuario 'Id_producto,Fecha,Hora,Cantidad,Razon,Stock
        daoProducto.AjustarPrecio(valores)
    End Sub
    Private Sub AjustarStockProducto(id_producto As Integer, cantidad As Integer, razon As Short, stock As Integer, rut_usuario As Integer)
        Dim daoProducto As New DaoProducto
        Dim valores As String
        valores = id_producto & ",SYSDATETIME( ),SYSDATETIME( )," & cantidad & "," & razon & "," & stock & "," & rut_usuario
        daoProducto.AjustarStock(valores)




    End Sub
    Public Sub EliminarProducto(producto As Producto, rut_usuario As Integer)
        Dim daoProducto As New DaoProducto
        daoProducto.EliminarProducto(producto.IdProducto)
        AjustarStockProducto(producto.IdProducto, producto.Stock, 6, 0, rut_usuario)
    End Sub


    Public Sub RealizarAjuste(producto As Producto, razon As Short, rut_usuario As Integer)
        'ObtenerProductosEspecificos valores originales para hacer las comparaciones entre objetos
        'tengo el id del producto, con lo cual puedo obtener dos valores, que son precios y stock
        'Dim productoOrig As New Producto
        Dim dataset As New DataSet
        dataset = ObtenerProductosEspecificos(" Id_producto = " & producto.IdProducto)
        MsgBox(producto.Precio & " != " & dataset.Tables(0)(0)(2))
        If producto.Precio <> dataset.Tables(0)(0)(2) Then
            MsgBox("INVOCAR A AJUSTE PRECIO")
            'AjustarPrecioProducto(producto.IdProducto, producto.Precio, rut_usuario)
        End If
        MsgBox(producto.Stock & " != " & dataset.Tables(0)(0)(3))
        If producto.Stock <> dataset.Tables(0)(0)(3) Then
            MsgBox("INVOCAR A AJUSTE STOCK")
            Dim cantidad As Integer
            cantidad = dataset.Tables(0)(0)(3) - producto.Stock
            If cantidad < 0 Then
                cantidad = cantidad * -1
            End If
            'AjustarStockProducto(producto.IdProducto, cantidad, razon, producto.Stock, rut_usuario)
        End If
    End Sub

    Public Function ObtenerStockCritico()
        Dim daoProducto As New DaoProducto
        Dim datasetx As New DataSet
        Dim text As String = ""

        datasetx = daoProducto.ObtenerStockCritico()
        Try
            For i = 0 To datasetx.Tables(0).Rows.Count - 1
                text = text + datasetx.Tables(0)(i)(0).ToString + "( " + datasetx.Tables(0)(i)(1).ToString + " unidades )"
                If i <> datasetx.Tables(0).Rows.Count - 1 Then
                    text = text + "-"
                End If
            Next

        Catch ex As Exception
            text = ""
        End Try
        Console.WriteLine(text)

        Return text
    End Function


End Class
