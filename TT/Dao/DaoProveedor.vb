Public Class DaoProveedor
    Dim tabla As String = "Proveedores"
    Dim instrucciones As New Instructions

    Public Sub agregar(columnas As String, valores As String)
        instrucciones.Insertar(tabla, columnas, valores)
    End Sub

    Public Sub editar(col_val As String, condicion As String)
        instrucciones.Modificar(tabla, col_val, condicion)
    End Sub

    Public Sub eliminar(condicion As String)
        instrucciones.FalseDelete(tabla, condicion)
    End Sub

    Public Function obtenerProv()
        Return instrucciones.Seleccionar(tabla, "Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", " WHERE False_delete=0")
    End Function


End Class
