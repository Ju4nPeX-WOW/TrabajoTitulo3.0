Public Class frmVenta
    Protected BsnEmpleado As New BsnEmpleado
    Protected DaoEmpleado As New DaoEmpleado

    Protected BsnCliente As New BsnCliente
    Protected DaoCliente As New DaoCliente

    Protected BsnProducto As New BsnProducto
    Protected DaoProducto As New DaoProducto



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

        Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas(" NOMBRE,PRECIO,STOCK,STOCK_CRITICO ")
        dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView


        Timer1.Enabled = True
        cmbVendedor.Text = ""
        cmbClientes.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFecha.Text = DateTime.Now
    End Sub

    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        If dgvProductos.Rows.Count > 0 Then
            txtPrecio.Text = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(1).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBuscar.Text.Length > 0 Then
            Dim datasetIncremental As New DataSet
            datasetIncremental = BsnProducto.BusquedaIncremental("NOMBRE,PRECIO,STOCK,STOCK_CRITICO", "Productos", "Nombre", txtBuscar.Text)
            dgvProductos.DataSource = datasetIncremental.Tables(0).DefaultView
        End If


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text.Length = 0 Then
            Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas(" NOMBRE,PRECIO,STOCK,STOCK_CRITICO ")
            dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView

        End If
    End Sub
End Class