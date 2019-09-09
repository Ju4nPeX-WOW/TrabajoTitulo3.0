Public Class DaoUsuario
    Dim instrucciones As New Instructions
    Dim tabla As String = "Usuarios"
    Public Function ObtenerTodosLosUsuarios()

        Return instrucciones.SelectWithFalseDelete(tabla, "Id_usuario,Rut_empleado,Contraseña,Permisos", "")

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

    Public Function ObtenerUsuarioEmpleado(condicion As String)
        Dim recondicion As String = " As US
        Left Join EMPLEADOS AS EM ON US.Rut_empleado = EM.Rut_empleado
        WHERE US.False_delete!= 1 and " & condicion
        Dim columnas As String = "US.Id_usuario , US.Rut_empleado , US.Permisos ,EM.Nombres , Apellido_p , Apellido_m "
        'Return instrucciones.SelectWithFalseDelete("Usuarios", "*", recondicion)
        Return instrucciones.Seleccionar("Usuarios", columnas, recondicion)


    End Function


End Class
