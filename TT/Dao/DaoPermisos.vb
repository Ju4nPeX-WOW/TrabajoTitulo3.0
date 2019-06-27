Public Class DaoPermisos
    Public Function Obtener(v As String, a As String, sa As String)
        Dim instrucciones As New Instructions
        Dim condicion As String = " where ventana = '" & v & "' and accion = '" & a & "' and subaccion = '" & sa & "'"
        'Console.Write(condicion)
        Return instrucciones.Seleccionar("PERMISOS", "p", condicion)
    End Function
End Class
