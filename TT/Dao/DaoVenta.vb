Public Class DaoVenta
    Dim Instructions As New Instructions
    Dim tabla As String = "Ventas"

    Public Sub realizarVenta(columnas As String, valores As String)
        MsgBox("COLUMNAS = " & columnas & vbCrLf & "VALORES = " & valores)
        'Instructions.Insertar(tabla, columnas, valores)
    End Sub


End Class
