Public Class BsnAjustes
    Dim BsnProducto As New BsnProducto
    Dim DaoAjustes As New DaoAjustes
    Dim enumeraciones As New Enumeraciones

    Dim valores As String
    Dim columnas As String


    Public Sub realizarAjusteSTOCK(producto As Producto, stock_nup As String, razon As String, rut As String)
        'SE AGREGA EN AJUSTE_STOCK COMO HISTORIAL 
        'SE MODIFICA EL PRODUCTO AUMENTANDO O DISMINUYENDO EL STOCK

        'razon es selectedindex
        'stock_dgv es el stock que escoge el empleado
        'rut es el rut del empleado ingresado        
        Dim valores As String
        Dim ajuste_pos_o_neg As String = stock_nup 'Indica si es ajuste negativo o positivo - + al momento de insercion
        If razon = 0 Or razon = 4 Then 'stock positivo
            producto.Stock = producto.Stock + stock_nup
        Else
            producto.Stock = (producto.Stock - stock_nup)
            ajuste_pos_o_neg = ajuste_pos_o_neg * -1
        End If

        columnas = "Id_producto,Fecha,Hora,Cantidad,Razon,Stock,Rut_empleado"
        valores = producto.IdProducto & ",SYSDATETIME( ),SYSDATETIME( )," & ajuste_pos_o_neg & "," & razon & "," & producto.Stock & "," & rut
        DaoAjustes.realizarAjusteSTOCK(columnas, valores) 'realiza la insercion a tabla ajuste_stock
        BsnProducto.ModificarProducto(producto, razon, rut)
    End Sub


End Class
