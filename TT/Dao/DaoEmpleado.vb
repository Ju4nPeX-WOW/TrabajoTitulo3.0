Public Class DaoEmpleado
    Dim dataset As New DataSet
    Dim instrucciones As New Instructions
    Dim tabla As String = "Empleados"
    Dim columnas As String
    Dim valores As String
    Dim condicion As String



    Public Sub agregarEmpleado(Empleado As Empleado)
        columnas = "RUT_EMPLEADO, NOMBRES, APELLIDO_P, APELLIDO_M, TELEFONO_F, TELEFONO_C, FALSE_DELETE "
        valores = Empleado.Rut & ",'" & Empleado.Nombres & "','" & Empleado.ApelidoPaterno & "','" & Empleado.ApellidoMaterno & "','" & Empleado.TelefonoFijo & "','" & Empleado.TelefonoCelular & "'," & "0"
        instrucciones.Insertar(tabla, columnas, valores)
    End Sub

    Public Sub editarEmpleado(Empleado As Empleado)
        valores = "NOMBRES='" & Empleado.Nombres & "'," & "APELLIDO_P = '" & Empleado.ApelidoPaterno & "',APELLIDO_M='" & Empleado.ApellidoMaterno & "', TELEFONO_F='" & Empleado.TelefonoFijo & "', TELEFONO_C='" & Empleado.TelefonoCelular & "'"
        condicion = " RUT_EMPLEADO = " & Empleado.Rut
        instrucciones.Modificar(tabla, valores, condicion)
    End Sub

    Public Sub eliminarEmpleado(Empleado As Empleado)
        condicion = " RUT_EMPLEADO = " & Empleado.Rut
        instrucciones.FalseDelete(tabla, condicion)
    End Sub

    Public Function obtenerTodosEmpleados()
        columnas = "RUT_EMPLEADO,NOMBRES,APELLIDO_P,APELLIDO_M,TELEFONO_F,TELEFONO_C"
        condicion = ""

        dataset = instrucciones.SelectWithFalseDelete(tabla, columnas, condicion)
        Return dataset
    End Function
End Class
