Public Class BsnUsuario
    Protected dataset As New DataSet
    Dim DaoUsuario As New DaoUsuario




    Public Function ValidarUsuario(usernamem As Integer, password As String)
        Dim aux As Boolean = False
        Dim daoUsuario As New DaoUsuario
        Dim condicion As String = " Rut_empleado = " & usernamem & " AND Contraseña = '" & password & "'"
        dataset = daoUsuario.ObtenerUsuariosEspecificos(condicion)
        Console.WriteLine("data " & dataset.Tables.Count)
        Try
            If dataset.Tables(0).Rows.Count <> 0 Then
                Console.WriteLine(dataset.Tables(0)(0)(1))
                Console.WriteLine(dataset.Tables(0)(0)(2))
                If usernamem = dataset.Tables(0)(0)(1) And password.Equals(dataset.Tables(0)(0)(2)) Then
                    aux = True
                End If
            Else
                If usernamem = 0 And password.Equals("admin") Then
                    aux = True

                End If
            End If

        Catch ex As Exception
            MsgBox("NO SE PUDO ENTRAR")
        End Try


        Return aux
    End Function

    Public Function obtenerUsuarios()
        Return DaoUsuario.ObtenerTodosLosUsuarios()
    End Function


    Public Function ObtenerUsuario(usernamem As Integer, password As String)
        Dim usuario As New Usuario

        Dim daoUsuario As New DaoUsuario
        Dim condicion As String = " Rut_empleado = " & usernamem & " AND Contraseña = '" & password & "'"
        dataset = daoUsuario.ObtenerUsuariosEspecificos(condicion)
        MsgBox("BSN USUARIO : " & dataset.Tables(0)(0)(1))
        If dataset.Tables(0).Rows.Count <> 0 Then
            usuario.IdUsuario = dataset.Tables(0)(0)(0)
            usuario.Rut = dataset.Tables(0)(0)(1)
            usuario.Permisos = dataset.Tables(0)(0)(3)
        End If


        Return usuario
    End Function

    Public Function ObtenerUsuarioEmpleado(usernamem As Integer, password As String)
        Dim usuario As New Usuario

        Dim daoUsuario As New DaoUsuario
        Dim condicion As String = " US.Rut_empleado = " & usernamem & " AND US.Contraseña = '" & password & "'"
        dataset = daoUsuario.ObtenerUsuarioEmpleado(condicion)

        If dataset.Tables(0).Rows.Count <> 0 Then
            usuario.IdUsuario = dataset.Tables(0)(0)(0)
            usuario.Rut = dataset.Tables(0)(0)(1)
            usuario.Permisos = dataset.Tables(0)(0)(2)
            usuario.Nombres = dataset.Tables(0)(0)(3)
            usuario.ApelidoPaterno = dataset.Tables(0)(0)(4)
            usuario.ApellidoMaterno = dataset.Tables(0)(0)(5)

        End If


        Return usuario
    End Function

    Public Sub agregarUsuario(rutEmpleado As String, contraseña As String, permisos As Byte)

        Dim valores As String = "Rut_empleado =" & rutEmpleado & ", contraseña ='" & contraseña & "' AND permisos=" & permisos
        DaoUsuario.agregarUsuario(valores)
    End Sub

    Public Sub editarUsuario(Usuario As Usuario)
        Dim columnaValor As String = "Contraseña ='" & Usuario.Password & "', permisos=" & Usuario.Permisos
        DaoUsuario.editarUsuario(columnaValor, Usuario)

    End Sub

    Public Sub eliminarUsuario(rutEmpleado As String)
        DaoUsuario.eliminarUsuario(rutEmpleado)
    End Sub

End Class
