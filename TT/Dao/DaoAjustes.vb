Public Class DaoAjustes
    Dim tabla As String
    Dim instructions As New Instructions
    Public Sub realizarAjusteSTOCK(columnas, valores)
        tabla = "Ajuste_stock"
        instructions.Insertar(tabla, columnas, valores)
    End Sub


End Class
