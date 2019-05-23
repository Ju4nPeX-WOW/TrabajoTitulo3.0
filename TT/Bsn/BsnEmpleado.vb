Public Class BsnEmpleado
    Dim DaoEmpleado As New DaoEmpleado
    Dim dataset As New DataSet

    Public Sub agregarEmpleado(Empleado As Empleado)
        DaoEmpleado.agregarEmpleado(Empleado)
    End Sub
    Public Sub editarEmpleado(Empleado As Empleado)
        DaoEmpleado.editarEmpleado(Empleado)
    End Sub
    Public Sub eliminarEmpleado(Empleado As Empleado)
        DaoEmpleado.eliminarEmpleado(Empleado)
    End Sub
    Public Function obtenerTodosEmpleados()
        dataset = DaoEmpleado.obtenerTodosEmpleados()
        Return dataset
    End Function
End Class
