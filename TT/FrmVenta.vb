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

        Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas(" NOMBRE,PRECIO,STOCK,STOCK_CRITICO")
        dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView

        Timer1.Enabled = True
        cmbVendedor.Text = ""
        cmbClientes.Text = ""
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFecha.Text = DateTime.Now
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
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
    Public Sub calculoTotal()
        Dim total As Integer = 0
        For index = 0 To (dgvProductosSeleccionados.Rows.Count - 1) Step 1
            total = total + (dgvProductosSeleccionados.Rows(index).Cells(1).Value * dgvProductosSeleccionados.Rows(index).Cells(2).Value)
        Next
        txtTotal.Text = total
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Boton que lo que realiza es insertar el producto elegido en el datagridviewPRODUCTOS, hacia el datagridviewPRODUCTOSSELECCIONADOS.
        If dgvProductos.CurrentRow.Index > -1 Then                                                                                                                                      'aqui iria el descuento raro
            If nmudCantidad.Value > 0 Then
                Dim fila() As String = {dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(0).Value, dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(1).Value, nmudCantidad.Value}
                'agregando al otro datagridview
                dgvProductosSeleccionados.Rows.Add(fila)
                dgvProductosSeleccionados.ClearSelection()
                'una vez que se ha agregado, se realiza el calculo del total del precio y se llenan los txt
                calculoTotal()
            Else
                MsgBox("Ingrese una cantidad")
            End If
        End If
    End Sub
    Private Sub dgvProductosSeleccionados_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvProductosSeleccionados.UserDeletingRow
        'evento que sucede cuando se esta eliminando una fila del dgvPRODUCTOSSELECCIONADOS->CARRITO DE COMPRAS (cuando se apreta el boton suprimir)
        Dim total = Integer.Parse(txtTotal.Text)
        total = total - (dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(1).Value * dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value)
        txtTotal.Text = total
    End Sub
    Private Sub disminuirCantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles disminuirCantidad.MouseClick
        'Evento que ocurre cuando se selecciona el boton de disminuir la cantidad
        If dgvProductosSeleccionados.Rows.Count > 0 Then
            dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value - 1
            If dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value = 0 Then
                'si el usuario disminuyo el producto hasta que llego a cero, pues, se elimina de la tabla
                dgvProductosSeleccionados.Rows.RemoveAt(dgvProductosSeleccionados.CurrentRow.Index)
                calculoTotal()
            Else
                calculoTotal()
            End If
        Else
            MsgBox("Por favor agregue productos al carro de compras...")
        End If
    End Sub

    Private Sub agregarCantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles agregarCantidad.MouseClick
        If dgvProductosSeleccionados.Rows.Count > 0 Then
            dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value + 1
            calculoTotal()
        Else
            MsgBox("Por favor agregue productos al carro de compras...")
        End If
    End Sub
End Class