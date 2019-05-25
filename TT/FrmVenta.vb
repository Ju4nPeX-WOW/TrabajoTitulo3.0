Public Class frmVenta
    Protected BsnEmpleado As New BsnEmpleado
    Protected DaoEmpleado As New DaoEmpleado

    Protected BsnCliente As New BsnCliente
    Protected DaoCliente As New DaoCliente



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rellenar combobox empleado
        Dim datasetEmpleados As DataSet = BsnEmpleado.obtenerTodosEmpleados
        cmbVendedor.DataSource = datasetEmpleados.Tables(0)
        cmbVendedor.DisplayMember = "NOMBRES"

        Dim datasetClientes As DataSet = BsnCliente.obtenerTodosClientes
        cmbClientes.DataSource = datasetClientes.Tables(0)
        cmbClientes.DisplayMember = "Rut_cliente"

        Timer1.Enabled = True

        cmbVendedor.Text = ""
        cmbClientes.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class