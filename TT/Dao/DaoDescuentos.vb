Public Class DaoDescuentos

    Dim instrucciones As New Instructions

    Public Function ObtenerDescuentos()
        Return instrucciones.Seleccionar("Descuentos", "*", "")
    End Function
End Class
