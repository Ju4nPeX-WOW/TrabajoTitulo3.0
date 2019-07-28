Public Class BsnCliente
    Dim DaoCliente As New DaoCliente
    Dim dataset As New DataSet

    Public Sub agregarCliente(Cliente As Cliente)
        DaoCliente.agregarCliente(Cliente)
    End Sub

    Public Sub editarCliente(Cliente As Cliente)
        DaoCliente.editarCliente(Cliente)
    End Sub
    Public Sub eliminarCliente(Cliente As Cliente)
        DaoCliente.eliminarCliente(Cliente)

    End Sub

    Public Function obtenerTodosClientes()
        dataset = DaoCliente.obtenerClientesSinFalseDelete()
        Return dataset
    End Function
    Public Function ObtenerCliente(rut As String)
        dataset = DaoCliente.ObtenerCliente(rut)
        Return dataset
    End Function
End Class
