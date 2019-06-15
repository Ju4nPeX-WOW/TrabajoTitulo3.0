Public Class DaoEstadistica
    Dim instrucciones As New Instructions
    Dim dataset As New DataSet


    Public Function ProductoValor()
        dataset = instrucciones.SelectWithFalseDelete("Productos", "Nombre,Precio as Valor", "")
        Return dataset
    End Function

End Class
