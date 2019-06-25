Public Class frmVenta
    Protected BsnEmpleado As New BsnEmpleado
    Protected DaoEmpleado As New DaoEmpleado

    Protected BsnCliente As New BsnCliente
    Protected DaoCliente As New DaoCliente

    Protected BsnProducto As New BsnProducto
    Protected DaoProducto As New DaoProducto

    Protected BsnVenta As New BsnVenta
    Protected DaoVenta As New DaoVenta

    Protected Enumeraciones As New Enumeraciones

    Dim Validacion As New Validacionesv2
    Dim Instructions As New Instructions 'es una clase y no es publica

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtBuscar.MaxLength = Validacion.MaxOtroNombre
        txtRutSnDV.MaxLength = Validacion.MaxRut
        txtDV.MaxLength = Validacion.MaxRutVerificador

        lblTransaccion.Text = (BsnVenta.obtenerUltimaVenta + 1).ToString

        'rellenar combobox empleado
        Dim datasetEmpleados As DataSet = BsnEmpleado.obtenerTodosEmpleados
        'cmbVendedor.DataSource = datasetEmpleados.Tables(0)
        'cmbVendedor.DisplayMember = "Rut_Empleado"

        Dim datasetClientes As DataSet = BsnCliente.obtenerTodosClientes
        'cmbClientes.DataSource = datasetClientes.Tables(0)
        'cmbClientes.DisplayMember = "Rut_cliente"

        Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE,PRECIO,STOCK,STOCK_CRITICO")
        dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView

        Timer1.Enabled = True
        txtVendedor.Text = ""
        txtRutSnDV.Text = ""
        txtDV.Text = ""
        txtNombreCliente.Text = ""

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFecha.Text = DateTime.Now
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Length > 0 Then
            Dim datasetIncremental As New DataSet
            datasetIncremental = BsnProducto.BusquedaIncremental("ID_PRODUCTO,NOMBRE,PRECIO,STOCK,STOCK_CRITICO", "Productos", "Nombre", txtBuscar.Text)
            dgvProductos.DataSource = datasetIncremental.Tables(0).DefaultView
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text.Length = 0 Then
            Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE,PRECIO,STOCK,STOCK_CRITICO ")
            dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView
        End If
    End Sub
    Public Sub calculoTotal()
        Dim subtotal As Integer = 0
        Dim descuento As Integer = 0 'aqui NASA
        Dim total As Integer = 0

        For index = 0 To (dgvProductosSeleccionados.Rows.Count - 1) Step 1
            subtotal = subtotal + (dgvProductosSeleccionados.Rows(index).Cells(2).Value * dgvProductosSeleccionados.Rows(index).Cells(3).Value)
        Next
        txtSubto.Text = subtotal

        total = subtotal + ((subtotal * Enumeraciones.getIVA()) / 100)
        txtTotal.Text = total

    End Sub

    Private Sub dgvProductosSeleccionados_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvProductosSeleccionados.UserDeletingRow
        'evento que sucede cuando se esta eliminando una fila del dgvPRODUCTOSSELECCIONADOS->CARRITO DE COMPRAS (cuando se apreta el boton suprimir)
        Dim subtotal As Integer = Integer.Parse(txtSubto.Text)
        Dim total As Integer = 0
        subtotal = subtotal - (dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value * dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value)
        txtSubto.Text = subtotal

        total = subtotal + ((subtotal * 19) / 100)
        txtTotal.Text = total
    End Sub
    Private Sub disminuirCantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles disminuirCantidad.MouseClick
        'Evento que ocurre cuando se selecciona el boton de disminuir la cantidad
        If dgvProductosSeleccionados.Rows.Count > 0 Then
            dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value - 1
            If dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value = 0 Then
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
            dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value + 1
            calculoTotal()
        Else
            MsgBox("Por favor agregue productos al carro de compras...")
        End If
    End Sub

    Private Sub btnAgregar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseClick
        'Boton que lo que realiza es insertar el producto elegido en el datagridviewPRODUCTOS, hacia el datagridviewPRODUCTOSSELECCIONADOS.
        If dgvProductos.CurrentRow.Index > -1 Then                                                                                                                                      'aqui iria el descuento raro
            If nmudCantidad.Value > 0 Then
                'guardamos los datos del producto seleccionado en el primer datagridview en un arreglo fila() para luego insertarla en el segundo datagridview
                Dim fila() As String = {dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(0).Value, dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(1).Value, dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(2).Value, nmudCantidad.Value}
                Dim existe As Boolean = False
                If dgvProductosSeleccionados.Rows.Count > 0 Then
                    For index = 0 To dgvProductosSeleccionados.Rows.Count - 1
                        If dgvProductosSeleccionados.Rows(index).Cells(1).Value.Equals(fila(1)) Then
                            dgvProductosSeleccionados.Rows(index).Cells(3).Value = (Integer.Parse(dgvProductosSeleccionados.Rows(index).Cells(3).Value) + Integer.Parse(fila(3))).ToString
                            existe = True
                        End If
                    Next
                    If existe = False Then
                        dgvProductosSeleccionados.Rows.Add(fila)
                    End If

                Else
                    'agregando el producto al segundo datagridview 
                    dgvProductosSeleccionados.Rows.Add(fila)
                End If


                'una vez que se ha agregado, se realiza el calculo del total del precio y se llenan los txt
                calculoTotal()
            Else
                MsgBox("Ingrese una cantidad")
            End If
        End If
    End Sub

    Private Sub btnRealizarVenta_Click(sender As Object, e As EventArgs) Handles btnRealizarVenta.Click
        Dim pal As String = ""
        Dim contador As Byte = 1
        Dim isCorrect As Boolean = True



        If dgvProductosSeleccionados.Rows.Count <= 0 Then
            pal = pal & contador & "- Ingrese productos en carro de compras. " & vbCrLf
            contador = contador + 1
            isCorrect = False
        End If

        If cmbTipoVenta.SelectedIndex < 0 Then
            pal = pal & contador & "- Seleccione un tipo de venta. " & vbCrLf
            contador = contador + 1
            isCorrect = False
        End If

        If cmbMetodoPago.SelectedIndex < 0 Then
            pal = pal & contador & "-Seleccione un metodo de pago. " & vbCrLf
            isCorrect = False
        End If

        If Not isCorrect Then
            MsgBox(pal, vbInformation, "Error")
        Else
            'insertar en Venta

            '           num_venta
            '           rut_cliente
            '           rut_empleado
            '           fecha ->DaoVenta como string converter(date,SYSDATE())
            '           hora  ->DaoVenta como string converter(time,SYSDATE())
            '           subtotal
            '           descuento
            '           total
            '           iva
            '           medio_pago
            '           factura -> en BsnVenta
            '           boleta -> en BsnVenta
            '           nota_credito -> en BsnVenta
            '           nota_debito -> en BsnVenta
            Dim medio_pago As Byte = Enumeraciones.MedioPago(cmbMetodoPago.Text)
            Dim tipo_venta As Byte = cmbTipoVenta.SelectedIndex '-> dentro de bsnVenta if-> 1 boleta

            BsnVenta.realizarVenta(txtRutSnDV.Text, txtVendedor.Text, txtSubto.Text, txtDesc.Text, txtTotal.Text, Enumeraciones.getIVA, medio_pago, tipo_venta)
            'Insertar en Detalle_Venta
            '           Id_Producto ( con el for ) 
            '           cantidad
            '           Precio
            '           Subtotal
            '           descuento
            '           Total

            BsnVenta.detalleVenta(dgvProductosSeleccionados, txtSubto.Text, txtDesc.Text, txtTotal.Text, BsnVenta.obtenerUltimaVenta)
            lblTransaccion.Text = (BsnVenta.obtenerUltimaVenta + 1).ToString
        End If
    End Sub





    'VALIDACION AL MOMENTO
    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        e.Handled = Validacion.IOtroNombre(e)
    End Sub

    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        e.Handled = Validacion.IRutVerificador(e)
    End Sub

    Private Sub txtRutSnDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDV.KeyPress
        e.Handled = Validacion.IRut(e)

    End Sub
End Class