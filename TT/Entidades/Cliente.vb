Public Class Cliente
    Inherits Persona 'hereda nombres y apellidos de persona 
    Protected _descuento As Byte
    Public Property Descuento() As Byte
        Get
            Return _descuento
        End Get
        Set(ByVal value As Byte)
            _descuento = value
        End Set
    End Property
End Class
