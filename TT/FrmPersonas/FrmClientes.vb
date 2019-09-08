Public Class FrmClientes
    Dim Cliente As New Cliente
    Dim BsnCliente As New BsnCliente
    Dim dataset As New DataSet
    Dim validacion As New Validacionesv2
    Dim activeAgregar = False
    Dim activeEditar = False
    Dim activeEliminar = False
    Dim _usuario As New Usuario
    Dim btnSeleccionadoPrimeraVez As Boolean = False
    Dim instructions As New Instructions
    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Public Sub recargarDGV()
        dataset = BsnCliente.obtenerTodosClientes()            'obtiene todos los usuarios
        dgvClientes.DataSource = dataset.Tables(0).DefaultView 'los pone en el datagridview clientes        
    End Sub

    Public Sub limpiarTextos()
        txtRutSnDV.Text = ""
        txtDV.Text = ""
        txtNombres.Text = ""
        txtApellidoM.Text = ""
        txtApellidoP.Text = ""
        cmbDescuento.SelectedIndex = 0
    End Sub

    Public Sub llenado()
        If dgvClientes.Rows.Count > 0 Then
            Try
                'Si en la base de datos existen campos vacios, se representan como NULL, no como ''.
                'Entonces... si la fila seleccionada tiene un campo vacio desde la BD (o sea NULL) entonces
                'Referenciamos a la variable como '' o sea STRING.EMPTY;
                If dgvClientes.CurrentRow.Cells(0).Value.Equals(DBNull.Value) Then
                    txtRutSnDV.Text = String.Empty
                Else
                    txtRutSnDV.Text = dgvClientes.CurrentRow.Cells(0).Value
                End If

                txtDV.Text = Cliente.obtenerDV(txtRutSnDV.Text)

                If dgvClientes.CurrentRow.Cells(1).Value.Equals(DBNull.Value) Then
                    txtNombres.Text = String.Empty
                Else
                    txtNombres.Text = dgvClientes.CurrentRow.Cells(1).Value
                End If

                If dgvClientes.CurrentRow.Cells(2).Value.Equals(DBNull.Value) Then
                    txtApellidoP.Text = String.Empty
                Else
                    txtApellidoP.Text = dgvClientes.CurrentRow.Cells(2).Value
                End If
                If dgvClientes.CurrentRow.Cells(3).Value.Equals(DBNull.Value) Then
                    txtApellidoM.Text = String.Empty
                Else
                    txtApellidoM.Text = dgvClientes.CurrentRow.Cells(3).Value
                End If
                If dgvClientes.CurrentRow.Cells(4).Value.Equals(DBNull.Value) Then
                    cmbDescuento.SelectedIndex = 0
                Else
                    cmbDescuento.Text = dgvClientes.CurrentRow.Cells(4).Value
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error: " & ex.ToString)
            End Try
        End If
    End Sub
    Private Sub formUsua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtRutSnDV.MaxLength = validacion.MaxRut            'definen el maximo de caracteres que ocupa
        txtDV.MaxLength = validacion.MaxRutVerificador      'definen el maximo de caracteres que ocupa
        txtNombres.MaxLength = validacion.MaxNombrePersona  'definen el maximo de caracteres que ocupa
        txtApellidoM.MaxLength = validacion.MaxApellido     'definen el maximo de caracteres que ocupa
        txtApellidoP.MaxLength = validacion.MaxApellido     'definen el maximo de caracteres que ocupa
        pnlComponentes.Enabled = False                      'componentes donde estan txt lbl y btn inactivo
        cmbDescuento.SelectedIndex = 0
        cmbBusqueda.SelectedIndex = 0
        recargarDGV() 'lo que hace es el llamado a la base de datos y ponerlo en el dgv
        llenado()
        reset() 'permisos.
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        activeEditar = False
        activeAgregar = False
        txtRutSnDV.Enabled = True
        txtDV.Enabled = True
        dgvClientes.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'VALIDAR 
        If RealizarValidacion() Then
            'Seteando el objeto clientes con sus caracteristicas
            Cliente.Rut = txtRutSnDV.Text
            Cliente.Nombres = txtNombres.Text
            Cliente.ApelidoPaterno = txtApellidoP.Text
            Cliente.ApellidoMaterno = txtApellidoM.Text
            Cliente.Descuento = cmbDescuento.Text
            If activeAgregar Then
                MsgBox("agregado")
                BsnCliente.agregarCliente(Cliente)
            End If
            If activeEditar Then
                MsgBox("editado")
                BsnCliente.editarCliente(Cliente)
            End If
            pnlComponentes.Enabled = False
            activeEditar = False
            activeAgregar = False
            dgvClientes.Enabled = True
            recargarDGV()
            limpiarTextos()
            llenado()
        End If
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        Dim ListaText As New List(Of String())
        ListaText.Add({"rut", txtRutSnDV.Text})
        ListaText.Add({"digito verificador", txtDV.Text})
        ListaText.Add({"nombre persona", txtNombres.Text})
        ListaText.Add({"apellido", txtApellidoM.Text})
        ListaText.Add({"apellido", txtApellidoP.Text})
        'ListaText.Add({"combobox", cmbDescuento.Text})
        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If receptor(0) Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL
            'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
            If validacion.ValidarRut(txtRutSnDV.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                cumple = True 'el rut es valido entonces se procede a ver si existe o no...
                If activeAgregar = True Then
                    Dim hola As Byte = instructions.obtenerUnicaFila("Clientes", "20107427")
                    Dim rut As String = txtRutSnDV.Text
                    For index = 0 To dgvClientes.Rows.Count - 1
                        If dgvClientes.Rows(index).Cells(0).Value = rut Then
                            cumple = False
                            MsgBox("El cliente ya existe en la base de datos, ingrese otro rut de cliente para ingresarlo a la base de datos.", vbInformation, "Cliente ya registrado")
                        End If
                    Next
                End If
            Else
                MsgBox("Sr administrador, el rut no es valido.", vbCritical, "Rut incorrecto")
                cumple = False
            End If
        Else
            MsgBox(receptor(1), vbInformation, "Campos vacios...")
        End If
        'If cmbDescuento.SelectedIndex < 0 Then
        'cumple = False
        'MsgBox("Seleccione descuento de cliente")
        'End If
        Return cumple
    End Function

    Private Sub tsmAgregar_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        pnlComponentes.Enabled = True
        dgvClientes.Enabled = False
        limpiarTextos()
    End Sub

    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If dgvClientes.Rows.Count > 0 Then
            pnlComponentes.Enabled = True 'se activa el panel que contiene todos los botones y labels y textbox
            txtRutSnDV.Enabled = False    'para que no pueda editar el rut sin el DV
            txtDV.Enabled = False         'para que no DV.
            activeEditar = True           'active editar es true y se ocupa para que al momento de aceptar se diferencie de agregar.
            dgvClientes.Enabled = False
            llenado()
        Else
            MsgBox("No hay clientes para editar. agregue uno para poder utilizar esta funcion", vbInformation, "No existen clientes en la base de datos")
        End If
    End Sub

    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        'EVENTO CLICK EN ELIMINAR
        If dgvClientes.Rows.Count > 0 Then
            If dgvClientes.CurrentRow.Index >= 0 Then
                llenado()
                Cliente.Rut = dgvClientes.CurrentRow.Cells(0).Value
                Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
                Dim response = MsgBox("¿Está seguro de eliminar al cliente: " & dgvClientes.CurrentRow.Cells(0).Value & " ?. Una vez realizada la operacion, no se puede recuperar.", style, "Confirmar accion de eliminacion") '6->SI  7->NO'
                'MsgBox(response)
                If response = 6 Then
                    BsnCliente.eliminarCliente(Cliente)
                    recargarDGV()
                End If
            End If
        Else
            MsgBox("No hay clientes para eliminar. agregue uno para poder utilizar esta funcion", vbInformation, "No existen clientes en la base de datos")
        End If
    End Sub

    Private Sub txtRutSnDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDV.KeyPress
        e.Handled = validacion.IRut(e)
    End Sub

    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        e.Handled = validacion.IRutVerificador(e)
    End Sub

    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        e.Handled = validacion.INombrePersona(e)
    End Sub

    Private Sub txtApellidoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoP.KeyPress
        e.Handled = validacion.IApellido(e)
    End Sub

    Private Sub txtApellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoM.KeyPress
        e.Handled = validacion.IApellido(e)
    End Sub
    Private Sub reset()
        Dim permiso As New Permisos
        tsmAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "CLIENTES", "AGREGAR", "")
        tsmEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "CLIENTES", "EDITAR", "")
        tsmEliminar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "CLIENTES", "ELIMINAR", "")
    End Sub
    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        llenado()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text <> "" Then
            btnSeleccionadoPrimeraVez = True
            Dim tipoBusqueda As String = cmbBusqueda.Text.ToLower()
            Dim tabla As String = "Clientes"
            Dim dataset_b As New DataSet
            'MsgBox(txtBusqueda.Text)
            Select Case tipoBusqueda
                Case "rut cliente"
                    dataset_b = instructions.busquedaIncremental("Rut_cliente,Nombres,apellido_p,apellido_m,Descuento", tabla, "Rut_cliente", txtBusqueda.Text)
                    dgvClientes.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "nombres"
                    dataset_b = instructions.busquedaIncremental("Rut_cliente,Nombres,apellido_p,apellido_m,Descuento", tabla, "Nombres", txtBusqueda.Text)
                    dgvClientes.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "apellido paterno"
                    dataset_b = instructions.busquedaIncremental("Rut_cliente,Nombres,apellido_p,apellido_m,Descuento", tabla, "Apellido_p", txtBusqueda.Text)
                    dgvClientes.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "apellido materno"
                    dataset_b = instructions.busquedaIncremental("Rut_cliente,Nombres,apellido_p,apellido_m,Descuento", tabla, "Apellido_m", txtBusqueda.Text)
                    dgvClientes.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "descuento"
                    dataset_b = instructions.busquedaIncremental("Rut_cliente,Nombres,apellido_p,apellido_m,Descuento", tabla, "Descuento", txtBusqueda.Text)
                    dgvClientes.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case ""
                    MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
            End Select
        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If btnSeleccionadoPrimeraVez = True Then
            If txtBusqueda.Text.Length = 0 Then
                recargarDGV()
                llenado()
            End If
        End If
    End Sub
End Class
