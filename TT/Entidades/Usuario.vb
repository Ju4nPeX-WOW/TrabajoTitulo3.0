
Public Class Usuario
    Inherits Persona
    Protected _blanckUsuario As Boolean = True
    Protected _idUsuario As Short
    Protected _permisos As Short


    Public Property IdUsuario()
        Get
            Return _idUsuario
        End Get
        Set(value)
            _idUsuario = value
        End Set
    End Property

    Public Property Permisos()
        Get
            Return _permisos
        End Get
        Set(value)
            _permisos = value
        End Set
    End Property

    Public Property BlanckUsuario()
        Get
            Return _blanckUsuario
        End Get
        Set(value)
            _blanckUsuario = value
        End Set
    End Property
End Class
