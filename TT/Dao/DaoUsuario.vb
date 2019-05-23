Public Class DaoUsuario


    Public Function ObtenerTodosLosUsuarios()
        Dim instrucciones As New Instructions
        Return instrucciones.SelectWithFalseDelete("Usuarios", "Id_usuario,Rut_empleado,Contraseña,Permisos", "")

    End Function

    Public Function ObtenerUsuariosEspecificos(condicion As String)
        Dim instrucciones As New Instructions
        Dim recondicion As String = " where " & condicion

        'Return instrucciones.SelectWithFalseDelete("Usuarios", "*", recondicion)
        Return instrucciones.Seleccionar("Usuarios", "*", recondicion)

    End Function



End Class
