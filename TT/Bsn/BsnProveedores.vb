Public Class BsnProveedores

    Dim condicion As String
    Dim valores As String
    Dim columnas As String
    Dim col_val As String
    Dim DaoProv As New DaoProveedor

    Dim dataset As New DataSet()
    Public Sub agregarProv(prov As Proveedor)
        columnas = "Rut_proveedor,nombres,apellido_p,apellido_m,telefono_f,telefono_c,email,direccion,false_delete"
        valores = prov.Rut & ",'" & prov.Nombres & "','" & prov.ApelidoPaterno & "','" & prov.ApellidoMaterno & "','" & prov.TelefonoFijo & "','" & prov.TelefonoCelular & "','" & prov.Email & "','" & prov.Direccion & "'," & 0
        DaoProv.agregar(columnas, valores)
    End Sub


    Public Sub editarProv(prov As Proveedor)
        col_val = "Nombres='" & prov.Nombres & "',Apellido_p='" & prov.ApelidoPaterno & "',Apellido_m='" & prov.ApellidoMaterno & "',Telefono_f='" & prov.TelefonoFijo & "',Telefono_c='" & prov.TelefonoCelular & "',Email='" & prov.Email & "',Direccion='" & prov.Direccion & "',False_delete=" & 0
        condicion = " RUT_PROVEEDOR = " & prov.Rut
        DaoProv.editar(col_val, condicion)
    End Sub

    Public Sub eliminarProv(prov As Proveedor)
        condicion = " RUT_PROVEEDOR =" & prov.Rut
        DaoProv.eliminar(condicion)
    End Sub

    Public Function obtenerProv()
        Return DaoProv.obtenerProv()
    End Function



End Class
