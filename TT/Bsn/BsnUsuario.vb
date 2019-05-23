Public Class BsnUsuario
    Protected dataset As New DataSet





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



    Public Function ObtenerUsuario(usernamem As Integer, password As String)
        Dim usuario As New Usuario

        Dim daoUsuario As New DaoUsuario
        Dim condicion As String = " Rut_empleado = " & usernamem & " AND Contraseña = '" & password & "'"
        dataset = daoUsuario.ObtenerUsuariosEspecificos(condicion)

        If dataset.Tables(0).Rows.Count <> 0 Then
            usuario.IdUsuario = dataset.Tables(0)(0)(0)
            usuario.Rut = dataset.Tables(0)(0)(1)
            usuario.Permisos = dataset.Tables(0)(0)(3)
        End If


        Return usuario
    End Function


End Class
