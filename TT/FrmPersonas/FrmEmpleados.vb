Public Class FrmEmpleados
    Dim _usuario As New Usuario
    Dim empleado As New Empleado
    Dim usuario As New Usuario
    Dim BsnEmpleado As New BsnEmpleado
    Dim BsnUsuario As New BsnUsuario
    Dim validacion As New Validacionesv2
    Dim dataset As New DataSet
    Dim instructions As New Instructions

    Dim activeAgregar As Boolean = False
    Dim activeEditar As Boolean = False
    Dim btnSeleccionadoPrimeraVez As Boolean = False

    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub
    Private Sub formUsua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtRutSnDV.MaxLength = validacion.MaxRut
        txtDV.MaxLength = validacion.MaxRutVerificador
        txtNombres.MaxLength = validacion.MaxNombrePersona
        txtApellidoM.MaxLength = validacion.MaxApellido
        txtApellidoP.MaxLength = validacion.MaxApellido
        txtCelu.MaxLength = validacion.MaxTelefonoC
        txtFono.MaxLength = validacion.MaxTelefonoF
        cmbBusqueda.SelectedIndex = 0
        recargarDGV()
        pnlComponentes.Enabled = False
        llenado()
        Reset()
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
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
    Private Sub txtCelu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelu.KeyPress
        e.Handled = validacion.ITelefonoC(e)
    End Sub
    Private Sub txtFono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        e.Handled = validacion.ITelefonoF(e)
    End Sub
    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        e.Handled = validacion.IOtroNombre(e)
    End Sub
    Private Sub Reset()
        Dim permiso As New Permisos
        tsmAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "EMPLEADOS", "AGREGAR", "")
        tsmEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "EMPLEADOS", "EDITAR", "")
        tsmEliminar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "EMPLEADOS", "ELIMINAR", "")
    End Sub
    Public Sub recargarDGV()
        dataset = BsnEmpleado.obtenerTodosEmpleados()
        dgvEmpleados.DataSource = dataset.Tables(0).DefaultView
    End Sub

    Public Sub limpiarTextos()
        txtRutSnDV.Text = ""
        txtDV.Text = ""
        txtNombres.Text = ""
        txtApellidoM.Text = ""
        txtApellidoP.Text = ""
        txtFono.Text = ""
        txtCelu.Text = ""
    End Sub

    Public Sub llenado()
        If dgvEmpleados.Rows.Count > 0 Then
            Try
                'Si en la base de datos existen campos vacios, se representan como NULL, no como ''.
                'Entonces... si la fila seleccionada tiene un campo vacio desde la BD (o sea NULL) entonces
                'Referenciamos a la variable como '' o sea STRING.EMPTY;
                If dgvEmpleados.CurrentRow.Cells(0).Value.Equals(DBNull.Value) Then
                    txtRutSnDV.Text = String.Empty
                Else
                    txtRutSnDV.Text = dgvEmpleados.CurrentRow.Cells(0).Value.ToString().Trim()
                End If

                txtDV.Text = empleado.obtenerDV(txtRutSnDV.Text)

                If dgvEmpleados.CurrentRow.Cells(1).Value.Equals(DBNull.Value) Then
                    txtNombres.Text = String.Empty
                Else
                    txtNombres.Text = dgvEmpleados.CurrentRow.Cells(1).Value.ToString().Trim()
                End If

                If dgvEmpleados.CurrentRow.Cells(2).Value.Equals(DBNull.Value) Then
                    txtApellidoP.Text = String.Empty
                Else
                    txtApellidoP.Text = dgvEmpleados.CurrentRow.Cells(2).Value.ToString().Trim()
                End If
                If dgvEmpleados.CurrentRow.Cells(3).Value.Equals(DBNull.Value) Then
                    txtApellidoM.Text = String.Empty
                Else
                    txtApellidoM.Text = dgvEmpleados.CurrentRow.Cells(3).Value.ToString().Trim()
                End If
                If dgvEmpleados.CurrentRow.Cells(4).Value.Equals(DBNull.Value) Then
                    txtFono.Text = String.Empty
                Else
                    txtFono.Text = dgvEmpleados.CurrentRow.Cells(4).Value.ToString().Trim()
                End If
                If dgvEmpleados.CurrentRow.Cells(5).Value.Equals(DBNull.Value) Then
                    txtCelu.Text = String.Empty
                Else
                    txtCelu.Text = dgvEmpleados.CurrentRow.Cells(5).Value.ToString().Trim()
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error: " & ex.ToString)
            End Try
        End If
    End Sub
    Private Sub tsmAgregar_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        pnlComponentes.Enabled = True
        txtRutSnDV.Enabled = True
        txtDV.Enabled = True
        mnsProd.Enabled = False
        dgvEmpleados.Enabled = False
        limpiarTextos()
    End Sub
    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If dgvEmpleados.Rows.Count > 0 Then
            activeEditar = True
            pnlComponentes.Enabled = True
            txtRutSnDV.Enabled = False
            txtDV.Enabled = False
            dgvEmpleados.Enabled = False
            llenado()
        End If
    End Sub
    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        If dgvEmpleados.Rows.Count > 0 Then
            empleado.Rut = dgvEmpleados.CurrentRow.Cells(0).Value
            Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
            Dim response = MsgBox("¿Está seguro de eliminar?", style, "Confirmar eliminacion") '6->SI  7->NO'
            'MsgBox(response)
            If response = 6 Then
                BsnEmpleado.eliminarEmpleado(empleado)
                MsgBox("eliminado")
                limpiarTextos()
                recargarDGV()
            End If
        End If
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'realizar validacion
        If RealizarValidacion() Then
            'Seteando el objeto clientes con sus caracteristicas
            empleado.Rut = txtRutSnDV.Text
            empleado.Nombres = txtNombres.Text
            empleado.ApelidoPaterno = txtApellidoP.Text
            empleado.ApellidoMaterno = txtApellidoM.Text
            empleado.TelefonoCelular = txtCelu.Text
            empleado.TelefonoFijo = txtFono.Text
            If activeAgregar Then
                MsgBox("Agregaado")
                BsnEmpleado.agregarEmpleado(empleado) 'se agrega empleado
                Dim passEmpleado As String = empleado.Rut.ToString.Substring(0, 4)
                BsnUsuario.agregarUsuario(empleado.Rut, passEmpleado, 4) 'se agrega usuario
            End If
            If activeEditar Then
                MsgBox("Editado")
                BsnEmpleado.editarEmpleado(empleado)
            End If

            activeAgregar = False
            activeEditar = False
            pnlComponentes.Enabled = False
            dgvEmpleados.Enabled = True
            mnsProd.Enabled = True
            limpiarTextos()
            recargarDGV()
        End If
    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        mnsProd.Enabled = True
        dgvEmpleados.Enabled = True
        activeAgregar = False
        activeEditar = False
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
        ListaText.Add({"telefono fijo", txtFono.Text})
        ListaText.Add({"telefono celular", txtCelu.Text})

        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If receptor(0) Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL
            'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
            If validacion.ValidarRut(txtRutSnDV.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                cumple = True 'el rut es valido entonces se procede a ver si existe o no...
                If activeAgregar = True Then
                    Dim tabla As String = "Empleados"
                    Dim campo As String = "Rut_empleado"
                    Dim condicion As String = " Rut_empleado=" & txtRutSnDV.Text
                    Dim existe_en_bd As Byte = Instructions.obtenerUnicaFila(tabla, campo, condicion)
                    If existe_en_bd > 0 Then
                        cumple = False
                        MsgBox("El empleado ya se encuentra registrado en la base de datos", vbInformation, "Cliente ya registrado")
                    End If
                End If
            Else
                MsgBox("Sr administrador, el rut no es valido.", vbCritical, "Rut incorrecto")
                cumple = False
            End If
        Else
            MsgBox(receptor(1), vbInformation, "Existen campos requeridos vacios.")
        End If
        Return cumple
    End Function
    Private Sub dgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        llenado()
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
            Dim tipoBusqueda As String = cmbBusqueda.Text.ToLower()
            Dim tabla As String = "Empleados"
            Dim dataset_b As New DataSet
            Dim busqueda2 As New Busqueda2
            'MsgBox(txtBusqueda.Text)
            Select Case tipoBusqueda
                Case "rut empleado"
                    dataset_b = busqueda2.busquedaIncremental("Rut_empleado,Nombres,apellido_p,apellido_m,Telefono_f,Telefono_c", tabla, "Rut_empleado", txtBusqueda.Text)
                    dgvEmpleados.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "nombres"
                    dataset_b = busqueda2.busquedaIncremental("Rut_empleado,Nombres,apellido_p,apellido_m,Telefono_f,Telefono_c", tabla, "Nombres", txtBusqueda.Text)
                    dgvEmpleados.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "apellido paterno"
                    dataset_b = busqueda2.busquedaIncremental("Rut_empleado,Nombres,apellido_p,apellido_m,Telefono_f,Telefono_c", tabla, "Apellido_p", txtBusqueda.Text)
                    dgvEmpleados.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "apellido materno"
                    dataset_b = busqueda2.busquedaIncremental("Rut_empleado,Nombres,apellido_p,apellido_m,Telefono_f,Telefono_c", tabla, "Apellido_m", txtBusqueda.Text)
                    dgvEmpleados.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "telefono"
                    dataset_b = busqueda2.busquedaIncremental("Rut_empleado,Nombres,apellido_p,apellido_m,Telefono_f,Telefono_c", tabla, "Telefono_f", txtBusqueda.Text)
                    dgvEmpleados.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "telefono celular"
                    dataset_b = busqueda2.busquedaIncremental("Rut_empleado,Nombres,apellido_p,apellido_m,Telefono_f,Telefono_c", tabla, "Telefono_c", txtBusqueda.Text)
                    dgvEmpleados.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case ""
                    MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
            End Select
        End If
    End Sub
End Class