Public Class Producto
    Protected _idProducto As Integer
    Protected _nombre As String
    Protected _precio As Integer
    Protected _stock As Short
    Protected _stockCritico As Short

    Protected _categorias() As String

    Public Property IdProducto()
        Get
            Return _idProducto
        End Get
        Set(value)
            _idProducto = value
        End Set
    End Property
    Public Property Nombre()
        Get
            Return _nombre
        End Get
        Set(value)
            _nombre = value
        End Set
    End Property
    Public Property Precio()
        Get
            Return _precio
        End Get
        Set(value)
            _precio = value

        End Set
    End Property
    Public Property Stock()
        Get
            Return _stock
        End Get
        Set(value)
            _stock = value
        End Set
    End Property
    Public Property StockCritico()
        Get
            Return _stockCritico
        End Get
        Set(value)
            _stockCritico = value
        End Set
    End Property

End Class
