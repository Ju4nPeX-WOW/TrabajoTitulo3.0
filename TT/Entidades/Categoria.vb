Public Class Categoria
    Protected _idCateg As String
    Protected _nomCateg As String
    Protected _codCateg As String

    Public Property IdCateg() As String
        Get
            Return _idCateg
        End Get
        Set(ByVal value As String)
            _idCateg = value
        End Set
    End Property
    Public Property NomCateg() As String
        Get
            Return _nomCateg
        End Get
        Set(ByVal value As String)
            _nomCateg = value
        End Set
    End Property
    Public Property CodCateg() As String
        Get
            Return _codCateg
        End Get
        Set(ByVal value As String)
            _codCateg = value
        End Set
    End Property







End Class
