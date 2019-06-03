Public Class BsnDescuentos
    Protected daoDescuentos As New DaoDescuentos

    Public Function ObtenerDescuentos()
        Return daoDescuentos.ObtenerDescuentos()
    End Function

End Class
