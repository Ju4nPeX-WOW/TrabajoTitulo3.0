Public Class DaoCliente
    Dim Instrucciones As New Instructions
    Protected dataset As New DataSet
    Protected condicion As String
    Protected tabla As String = "Clientes"
    Protected columnas As String
    Protected valores As String

    Public Function obtenerClientesSinFalseDelete()
        columnas = "*"
        condicion = ""
        dataset = Instrucciones.SelectWithFalseDelete(tabla, columnas, condicion)
        Return dataset
    End Function
    Public Sub agregarCliente(Cliente As Cliente)
        columnas = "RUT_CLIENTE,NOMBRES,APELLIDO_P,APELLIDO_M,DESCUENTO"
        valores = Cliente.Rut & ",'" & Cliente.Nombres & "','" & Cliente.ApelidoPaterno & "','" & Cliente.ApellidoMaterno & "'," & Cliente.Descuento
        Instrucciones.Insertar(tabla, columnas, valores)
    End Sub
    Public Sub editarCliente(Cliente As Cliente)
        columnas = " NOMBRES='" & Cliente.Nombres & "', APELLIDO_P='" & Cliente.ApelidoPaterno & "', APELLIDO_M= '" & Cliente.ApellidoMaterno & "', DESCUENTO= " & Cliente.Descuento
        condicion = " RUT_CLIENTE = " & Cliente.Rut
        Instrucciones.Modificar(tabla, columnas, condicion)
    End Sub

    Public Sub eliminarCliente(Cliente As Cliente)
        'eliminado   - suaveeeeeeeeeeeeeee
        '            - exaaaaaacto.
        condicion = "RUT_CLIENTE=" & Cliente.Rut
        Instrucciones.FalseDelete(tabla, condicion)
    End Sub

    Public Function ObtenerCliente(rut As String)
        columnas = "*"
        condicion = " and Rut_cliente = " & rut
        dataset = Instrucciones.SelectWithFalseDelete(tabla, columnas, condicion)
        Return dataset
    End Function



End Class
