Public Class DefaultData
    Dim validar As New Validaciones

    Public Sub EstablecerCategorias()
        If validar.ConfirmarConContraseña Then
            Dim archi As New Archivos

            Dim lista As List(Of String()) = archi.LecturaCategorias()

            If lista.Count <> 0 Then
                Dim bsnCat As New BsnCategoria
                ''limpiar tabla
                bsnCat.EliminarTodo()
                ''rellenar tabla
                bsnCat.InsertarTodo(lista)
            End If


        Else
            MsgBox("NO CUENTA CON LOS PERMISOS PARA REALIZAR LA OPERACION")

        End If
    End Sub

End Class
