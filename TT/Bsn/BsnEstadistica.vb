Public Class BsnEstadistica
    Dim daoEstadistica As New DaoEstadistica

    Public Function ProductoValor()
        Return daoEstadistica.ProductoValor()
    End Function

End Class
