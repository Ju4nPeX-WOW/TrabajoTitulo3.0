Public Class Descuento
    Protected _idDescuento As String
    Protected _idProducto As String
    Protected _fechaInicio As String
    Protected _fechaTermino As String
    Protected _condicion As String



    Public Property IdDescuento() As String
        Get
            Return _idDescuento
        End Get
        Set(ByVal value As String)
            _idDescuento = value
        End Set
    End Property
    Public Property IdProducto() As String
        Get
            Return _idProducto
        End Get
        Set(ByVal value As String)
            _idProducto = value
        End Set
    End Property
    Public Property FechaInicio() As String
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As String)
            _fechaInicio = value
        End Set
    End Property

    Public Property FechaTermino() As String
        Get
            Return _fechaTermino 
        End Get
        Set(ByVal value As String)
            _fechaTermino = value
        End Set
    End Property
    Public Property Condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
        End Set
    End Property






End Class
