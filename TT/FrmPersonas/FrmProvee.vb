Public Class FrmProvee
    Dim _usuario As Usuario
    Dim dataset As New DataSet
    Dim BsnProv As New BsnProveedores

    Dim activeAgregar As Boolean = False
    Dim activeEditar As Boolean = False
    Dim validacion As New Validacionesv2
    Dim Proveedor As New Proveedor
    Dim instructions As New Instructions

    Dim btnSeleccionadoPrimeraVez As Boolean = False

    Public Sub RecibirUsuario(objeto As Empleado)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema
        'MsgBox("ID-USUARIO : " & usuario.IdUsuario)
    End Sub

    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub

    Private Sub FrmProvee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRutSnDV.MaxLength = validacion.MaxRut
        txtNombres.MaxLength = validacion.MaxNombrePersona
        txtApellidoM.MaxLength = validacion.MaxApellido
        txtApellidoP.MaxLength = validacion.MaxApellido
        txtCelu.MaxLength = validacion.MaxTelefonoC
        txtFono.MaxLength = validacion.MaxTelefonoF
        txtEmail.MaxLength = validacion.MaxEmail
        txtDireccion.MaxLength = validacion.MaxDireccion
        cmbBusqueda.SelectedIndex = 0

        recargarDGV()
        reset()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub reset()
        Dim permiso As New Permisos
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PROVEEDORES", "AGREGAR", "")
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PROVEEDORES", "EDITAR", "")
        picEliminar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PROVEEDORES", "ELIMINAR", "")
    End Sub

    Public Sub llenado()
        Dim id As String = ""
        Dim producto As String = ""
        Try
            txtRutSnDV.Text = dgvProveedor.CurrentRow.Cells(0).Value
            txtNombres.Text = dgvProveedor.CurrentRow.Cells(1).Value
            txtApellidoP.Text = dgvProveedor.CurrentRow.Cells(2).Value
            txtApellidoM.Text = dgvProveedor.CurrentRow.Cells(3).Value
            txtFono.Text = dgvProveedor.CurrentRow.Cells(4).Value
            txtCelu.Text = dgvProveedor.CurrentRow.Cells(5).Value
            txtEmail.Text = dgvProveedor.CurrentRow.Cells(6).Value
            txtDireccion.Text = dgvProveedor.CurrentRow.Cells(7).Value
            txtDV.Text = Proveedor.obtenerDV(txtRutSnDV.Text)
        Catch ex2 As NullReferenceException
            Console.WriteLine("No hay productos, el error generado:'{ex2}'")
        End Try
    End Sub

    Public Sub limpiarTextos()
        txtRutSnDV.Text = ""
        txtNombres.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        txtFono.Text = ""
        txtCelu.Text = ""
        txtEmail.Text = ""
        txtDireccion.Text = ""
        txtDV.Text = ""
    End Sub
    Public Sub recargarDGV()
        dataset = BsnProv.obtenerProv()
        dgvProveedor.DataSource = dataset.Tables(0).DefaultView
        If dgvProveedor.Rows.Count > 0 Then
            llenado()
        End If
    End Sub

    Private Sub dgvProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedor.CellClick
        llenado()
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
    Private Sub txtCelu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelu.KeyPress
        e.Handled = validacion.ITelefonoC(e)
    End Sub
    Private Sub txtFono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        e.Handled = validacion.ITelefonoF(e)
    End Sub
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        e.Handled = validacion.IEmail(e)
    End Sub
    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        e.Handled = validacion.IDireccion(e)
    End Sub
    Private Sub txtApellidoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoP.KeyPress
        e.Handled = validacion.IApellido(e)
    End Sub
    Private Sub txtApellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoM.KeyPress
        e.Handled = validacion.IApellido(e)
    End Sub
    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        e.Handled = validacion.IOtroNombre(e)
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If btnSeleccionadoPrimeraVez = True Then
            If txtBusqueda.Text.Length = 0 Then
                recargarDGV()
                llenado()
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text <> "" Then
            btnSeleccionadoPrimeraVez = True
            Dim tipoBusqueda As String = cmbBusqueda.Text
            Dim tabla As String = "Proveedores"
            Dim busqueda2 As New Busqueda2
            Select Case tipoBusqueda
                Case "RUT PROVEEDOR"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Rut_proveedor", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "NOMBRES"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Nombres", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "APELLIDO PATERNO"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Apellido_p", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "APELLIDO MATERNO"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Apellido_m", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "TELEFONO"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Telefono_f", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "CELULAR"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Telefono_c", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "EMAIL"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Email", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "DIRECCION"
                    dataset = busqueda2.busquedaIncremental("Rut_proveedor,Nombres,Apellido_p,Apellido_m,Telefono_f,Telefono_c,Email,Direccion", tabla, "Direccion", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case ""
                    MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
            End Select
        End If
    End Sub
    Private Sub tsmAgregar_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        If dgvProveedor.Rows.Count > 0 Then
            pnlComponentes.Enabled = True
            activeAgregar = True
            dgvProveedor.Enabled = False
            mnsProd.Enabled = False
            txtRutSnDV.Enabled = True
            txtDV.Enabled = True
            limpiarTextos()
        End If
    End Sub
    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If dgvProveedor.Rows.Count > 0 Then
            pnlComponentes.Enabled = True
            activeEditar = True
            mnsProd.Enabled = False
            dgvProveedor.Enabled = False
            txtRutSnDV.Enabled = False
            txtDV.Enabled = False
            llenado()
        End If
    End Sub
    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        If dgvProveedor.Rows.Count > 0 Then
            Proveedor.Rut = dgvProveedor.CurrentRow.Cells(0).Value
            Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
            Dim response = MsgBox("¿Está seguro de eliminar al proveedor " & Proveedor.Rut & " ?", style, "Confirmar eliminacion") '6->SI  7->NO'
            'MsgBox(response)
            If response = 6 Then
                BsnProv.eliminarProv(Proveedor)
                limpiarTextos()
                recargarDGV()
                llenado()
            End If
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
        ListaText.Add({"telefono celular", txtCelu.Text})
        ListaText.Add({"telefono fijo", txtFono.Text})
        ListaText.Add({"email", txtEmail.Text})
        ListaText.Add({"direccion", txtDireccion.Text})

        'ListaText.Add({"combobox", cmbDescuento.Text})
        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If receptor(0) Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL
            'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
            If validacion.ValidarRut(txtRutSnDV.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                cumple = True 'el rut es valido entonces se procede a ver si existe o no...
                If activeAgregar = True Then
                    Dim tabla As String = "Proveedores"
                    Dim campo As String = "Rut_proveedor"
                    Dim condicion As String = " Rut_proveedor=" & txtRutSnDV.Text
                    Dim existe_en_bd As Byte = Instructions.obtenerUnicaFila(tabla, campo, condicion)
                    If existe_en_bd > 0 Then
                        cumple = False
                        MsgBox("El proveedor ya se encuentra registrado en la base de datos", vbInformation, "Proveedor ya registrado")
                    End If
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

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If RealizarValidacion() Then
            If activeAgregar Then
                Dim proveedor As New Proveedor
                proveedor.Rut = txtRutSnDV.Text
                proveedor.Nombres = txtNombres.Text
                proveedor.ApelidoPaterno = txtApellidoP.Text
                proveedor.ApellidoMaterno = txtApellidoM.Text
                proveedor.TelefonoCelular = txtCelu.Text
                proveedor.TelefonoFijo = txtFono.Text
                proveedor.Email = txtEmail.Text
                proveedor.Direccion = txtDireccion.Text
                MsgBox("Proveedor agregado correctamente", vbInformation, "Proveedor agregado")
                BsnProv.agregarProv(proveedor)
            End If
            If activeEditar Then
                Dim proveedor As New Proveedor
                proveedor.Rut = txtRutSnDV.Text
                proveedor.Nombres = txtNombres.Text
                proveedor.ApelidoPaterno = txtApellidoP.Text
                proveedor.ApellidoMaterno = txtApellidoM.Text
                proveedor.TelefonoCelular = txtCelu.Text
                proveedor.TelefonoFijo = txtFono.Text
                proveedor.Email = txtEmail.Text
                proveedor.Direccion = txtDireccion.Text
                BsnProv.editarProv(proveedor)
                MsgBox("Proveedor editado correctamente", vbInformation, "Proveedor editado")
            End If
            activeAgregar = False
            activeEditar = False
            pnlComponentes.Enabled = False
            dgvProveedor.Enabled = True
            mnsProd.Enabled = True
            recargarDGV()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        activeEditar = False
        activeAgregar = False
        mnsProd.Enabled = True
        dgvProveedor.Enabled = True
    End Sub
End Class
