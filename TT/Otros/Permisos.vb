Public Class Permisos

    Public Function OtorgarAcceso(p As String, v As String, a As String, sa As String)
        Dim acceso As Boolean = False
        Dim daoPermisos As New DaoPermisos
        Dim dataset As New DataSet
        dataset = daoPermisos.Obtener(v, a, sa)
        Try
            'MsgBox("PPP_>: " & dataset.Tables(0)(0)(0))
            If Short.Parse(p) > dataset.Tables(0)(0)(0) Then
                acceso = True
            End If
        Catch ex As Exception
            acceso = False
        End Try

        Return acceso

    End Function
End Class
