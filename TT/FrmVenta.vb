Public Class frmVenta
    Private _usuario As New Usuario

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
    Dim permiso As Boolean = False
    Dim descuentoCliente As Short = 0

    Dim Instructions As New Instructions 'es una clase y no es publica
    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        TxtDescuentoAdicional.MaxLength = 5
        txtBuscar.MaxLength = Validacion.MaxOtroNombre
        txtRutSnDV.MaxLength = Validacion.MaxRut
        txtDV.MaxLength = Validacion.MaxRutVerificador
        MsgBox(BsnVenta.obtenerUltimaVenta)
        lblTransaccion.Text = (BsnVenta.obtenerUltimaVenta + 1).ToString
        MsgBox(_usuario.Nombres)
        txtVendedor.Text = _usuario.Nombres + " " + _usuario.ApelidoPaterno + " " + _usuario.ApellidoMaterno
        'rellenar combobox empleado
        Dim datasetEmpleados As DataSet = BsnEmpleado.obtenerTodosEmpleados
        'cmbVendedor.DataSource = datasetEmpleados.Tables(0)
        'cmbVendedor.DisplayMember = "Rut_Empleado"

        'CLIENTES
        Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE,PRECIO,STOCK")
        Dim column = New DataColumn()

        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "DESCUENTOS"
        column.ReadOnly = False
        'Add the Column to the DataColumnCollection.
        datasetProductos.Tables(0).Columns.Add(column)

        For i = 0 To datasetProductos.Tables(0).Rows.Count - 1
            Dim bsnVenta As New BsnVenta
            Dim Descuento As String = bsnVenta.ObtenerCondicionDescuento(datasetProductos.Tables(0)(i)(0).ToString)
            datasetProductos.Tables(0)(i)("DESCUENTOS") = Descuento
        Next


        ''RELLENAR DGV
        EstructurarDGVProductos(dgvProductos)
        dgvProductos.DataSource = datasetProductos.Tables(0)


        Timer1.Enabled = True
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
            datasetIncremental = BsnProducto.BusquedaIncremental("ID_PRODUCTO,NOMBRE,PRECIO,STOCK", "Productos", "Nombre", txtBuscar.Text)
            dgvProductos.DataSource = datasetIncremental.Tables(0).DefaultView
        End If
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text.Length = 0 Then
            Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE,PRECIO,STOCK")
            dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView
        End If
    End Sub
    Public Sub calculoTotal()
        Dim subtotal As Integer = 0
        Dim descuento As Integer = 0
        Dim descCliente As Integer = 0
        Dim total As Integer = 0

        For index = 0 To (dgvProductosSeleccionados.Rows.Count - 1) Step 1
            subtotal = subtotal + dgvProductosSeleccionados.Rows(index).Cells(4).Value
            descuento = descuento + dgvProductosSeleccionados.Rows(index).Cells(5).Value
        Next
        txtSubto.Text = subtotal
        txtDesc.Text = descuento

        descCliente = subtotal - descuento
        descCliente = Math.Round((descCliente * descuentoCliente) / 100)
        TxtDescuentoCliente.Text = descCliente.ToString
        ''revisar el descuento adicional
        total = subtotal - descuento - descCliente - Integer.Parse(TxtDescuentoAdicional.Text)
        If total < 0 Then
            total = 0
        End If
        If total <> 0 Then
            total = total + ((total * Enumeraciones.getIVA()) / 100)
        End If
        txtTotal.Text = total

    End Sub

    Private Sub dgvProductosSeleccionados_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvProductosSeleccionados.UserDeletingRow
        'evento que sucede cuando se esta eliminando una fila del dgvPRODUCTOSSELECCIONADOS->CARRITO DE COMPRAS (cuando se apreta el boton suprimir)
        'Dim subtotal As Integer = Integer.Parse(txtSubto.Text)
        'Dim total As Integer = 0
        'SubTotal = subtotal - (dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value * dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value)
        'txtSubto.Text = subtotal

        'Total = subtotal + ((subtotal * 19) / 100)
        'txtTotal.Text = total
        calculoTotal()

    End Sub
    Private Sub disminuirCantidad_MouseClick(sender As Object, e As MouseEventArgs) Handles disminuirCantidad.MouseClick
        'Evento que ocurre cuando se selecciona el boton de disminuir la cantidad
        If dgvProductosSeleccionados.Rows.Count > 0 Then
            dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value - 1
            RefreshRow()

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

            RefreshRow()
            calculoTotal()
        Else
            MsgBox("Por favor agregue productos al carro de compras...")
        End If
    End Sub

    Private Sub btnAgregar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseClick
        'Boton que lo que realiza es insertar el producto elegido en el datagridviewPRODUCTOS, hacia el datagridviewPRODUCTOSSELECCIONADOS.
        If dgvProductos.CurrentRow.Index > -1 Then                                                                                                                                      'aqui iria el descuento raro
            If nmudCantidad.Value > 0 Then
                'obtener descuento 
                Dim bsnVenta As New BsnVenta
                Dim Descuento As Array = bsnVenta.ObtenerDescuento(dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(0).Value.ToString, dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(2).Value.ToString, nmudCantidad.Value.ToString)
                'TOTAL
                Dim subtotal = dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(2).Value * nmudCantidad.Value
                Dim total = (dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(2).Value * nmudCantidad.Value) - Integer.Parse(Descuento(2))
                'guardamos los datos del producto seleccionado en el primer datagridview en un arreglo fila() para luego insertarla en el segundo datagridview
                Dim fila() As String = {dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(0).Value, dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(1).Value, dgvProductos.Rows(dgvProductos.CurrentRow.Index).Cells(2).Value, nmudCantidad.Value, subtotal, Descuento(2), total}
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
        'Validar ->
        If RealizarValidacion() Then
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

            BsnVenta.realizarVenta(txtRutSnDV.Text, _usuario.Rut, txtSubto.Text, txtDesc.Text, txtTotal.Text, Enumeraciones.getIVA, medio_pago, tipo_venta)
            'Insertar en Detalle_Venta
            '           Id_Producto ( con el for ) 
            '           cantidad
            '           Precio
            '           Subtotal
            '           descuento
            '           Total

            BsnVenta.detalleVenta(dgvProductosSeleccionados, txtSubto.Text, txtDesc.Text, txtTotal.Text, BsnVenta.obtenerUltimaVenta, _usuario.Rut)
            lblTransaccion.Text = (BsnVenta.obtenerUltimaVenta + 1).ToString
            txtRutSnDV.Clear()
            txtDV.Clear()
            txtNombreCliente.Clear()
            txtBuscar.Clear()
            dgvProductosSeleccionados.Rows.Clear()
            dgvProductos.ClearSelection()
            cmbTipoVenta.Text = "Seleccione un tipo de venta..."
            cmbMetodoPago.Text = "Seleccione un metodo de pago..."
            txtSubto.Clear()
            txtDesc.Clear()
            txtTotal.Clear()
            nmudCantidad.Value = 1
            Dim datasetProductos As DataSet = BsnProducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE,PRECIO,STOCK,STOCK_CRITICO")
            dgvProductos.DataSource = datasetProductos.Tables(0).DefaultView

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

    Private Function RealizarValidacion()

        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        'Dim ListaText As New List(Of String())
        'ListaText.Add({"rut", txtRutSnDV.Text})
        'ListaText.Add({"digito verificador", txtDV.Text})
        'ListaText.Add({"nombre", txtBuscar.Text})

        'Dim receptor = Validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If True Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL
            If Not (dgvProductosSeleccionados.RowCount = 0) Then

                'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
                Dim noCliente As Boolean = False
                If txtRutSnDV.Text.Length = 0 Then
                    noCliente = True
                    txtRutSnDV.Text = "00000000"
                    txtDV.Text = "0"
                End If
                MsgBox("no cliente:" & noCliente)
                If Validacion.ValidarRut(txtRutSnDV.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                    cumple = True

                    Dim pal As String = ""
                    Dim contador As Byte = 1

                    If cmbTipoVenta.SelectedIndex < 0 Then
                        pal = pal & contador & "- Seleccione un tipo de venta. " & vbCrLf
                        contador = contador + 1
                        cumple = False
                    End If

                    If cmbMetodoPago.SelectedIndex < 0 Then
                        pal = pal & contador & "-Seleccione un metodo de pago. " & vbCrLf
                        cumple = False
                    End If

                    If Not cumple Then
                        MsgBox(pal, vbInformation, "Error")
                    End If
                Else
                    MsgBox("SR USUARIO EL RUT NO ES VALIDO")
                End If
            Else
                MsgBox("SR USUARIO FALTA QUE SELECCIONE LOS PRODUCTOS")
            End If
        Else
            MsgBox("receptor(1)")
        End If
        Return cumple
    End Function

    Private Sub RefreshRow()
        Dim bsnVenta As New BsnVenta
        'ID - CANTIDAD - PRECIO
        Dim id = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(0).Value.ToString
        Dim cant = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(3).Value
        Dim precio = dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(2).Value

        'PREPARAR EL SUBTOTAL - DESCUENTO  - TOTAL 
        Dim subtotal = precio * cant
        Dim Descuento As Array = bsnVenta.ObtenerDescuento(id, precio, cant)
        Dim total = subtotal - Integer.Parse(Descuento(2))

        'ACTUALIZAR EL SUBTOTAL - DESCUENTO  - TOTAL 
        dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(4).Value = subtotal
        dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(5).Value = Descuento(2)
        dgvProductosSeleccionados.Rows(dgvProductosSeleccionados.CurrentRow.Index).Cells(6).Value = total

    End Sub
    Private Sub EstructurarDGVProductos(dgv As Object)
        dgv.Rows.Clear()
        dgv.DefaultCellStyle.BackColor = Color.Beige
        dgv.ColumnCount = 5
        dgv.Columns(0).Name = "Id"
        dgv.Columns(1).Name = "Nombre"
        dgv.Columns(2).Name = "Precio"
        dgv.Columns(3).Name = "Stock"
        dgv.Columns(4).Name = "Descuento"

        dgv.Columns(0).DataPropertyName = "Id_producto"
        dgv.Columns(1).DataPropertyName = "Nombre"
        dgv.Columns(2).DataPropertyName = "Precio"
        dgv.Columns(3).DataPropertyName = "Stock"
        dgv.Columns(4).DataPropertyName = "DESCUENTOS"

    End Sub

    Private Sub txtDV_TextChanged(sender As Object, e As EventArgs) Handles txtDV.TextChanged
        Dim datasetClientes As DataSet = BsnCliente.ObtenerCliente(txtRutSnDV.Text)
        'cmbClientes.DataSource = datasetClientes.Tables(0)
        'cmbClientes.DisplayMember = "Rut_cliente"
        Try
            If datasetClientes.Tables(0).Rows.Count <> 0 Then

                If datasetClientes.Tables(0)(0)(4) > 0 Then
                    LblDescuentoCliente.Visible = True
                    LblDescuentoCliente.Text = datasetClientes.Tables(0)(0)(4) & "% descuento"
                    descuentoCliente = datasetClientes.Tables(0)(0)(4)
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub




    Private Sub TxtDescuentoAdicional_Click(sender As Object, e As EventArgs) Handles TxtDescuentoAdicional.Click
        Dim validar As New Validaciones

        If validar.ConfirmarConContraseña Then
            MsgBox("valido")
            permiso = True
            LblDescuentoAdicional.Enabled = True
        Else
            permiso = False

            MsgBox("NO CUENTA CON LOS PERMISOS PARA REALIZAR LA OPERACION")

        End If

    End Sub



    Private Sub TxtDescuentoAdicional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescuentoAdicional.KeyPress
        If permiso Then

            e.Handled = Validacion.IPrecio(e)
        End If


    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        calculoTotal()

    End Sub
End Class