Public Class DaoUsuario
    Dim instrucciones As New Instructions
    Dim tabla As String = "Usuarios"
    Public Function ObtenerTodosLosUsuarios()

        Return instrucciones.SelectWithFalseDelete(tabla, "*", "")

    End Function

    Public Function ObtenerUsuariosEspecificos(condicion As String)
        Dim recondicion As String = " where " & condicion

        'Return instrucciones.SelectWithFalseDelete("Usuarios", "*", recondicion)
        Return instrucciones.Seleccionar("Usuarios", "*", recondicion)

    End Function
    Public Sub agregarUsuario(valores As String)
        Dim columnas As String = "Rut_empleado,contraseña,permisos"
        instrucciones.Insertar(tabla, columnas, valores)
    End Sub

    Public Sub editarUsuario(columnaValor As String, Usuario As Usuario)
        Dim condicion As String = " Rut_empleado= " & Usuario.Rut
        instrucciones.Modificar(tabla, columnaValor, condicion)
    End Sub

    Public Sub eliminarUsuario(rutEmpleado As String)
        Dim condicion As String = " Rut_empleado= " & rutEmpleado
        instrucciones.FalseDelete(tabla, condicion)
    End Sub



End Class
