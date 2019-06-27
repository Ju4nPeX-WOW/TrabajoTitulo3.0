Public Class FrmEmpleados
    Dim _usuario As New Usuario
    Dim empleado As New Empleado
    Dim usuario As New Usuario
    Dim BsnEmpleado As New BsnEmpleado
    Dim BsnUsuario As New BsnUsuario
    Dim validacion As New Validacionesv2
    Dim dataset As New DataSet

    Dim activeAgregar As Boolean = False
    Dim activeEditar As Boolean = False

    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub


    Public Sub recargarDGV()
        dataset = BsnEmpleado.obtenerTodosEmpleados()
        dgvEmpleados.DataSource = dataset.Tables(0).DefaultView
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


        recargarDGV()
        pnlComponentes.Enabled = False
        Reset()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub picAgregar_Click_1(sender As Object, e As EventArgs) Handles picAgregar.Click
        activeAgregar = True
        pnlAcciones.Enabled = False
        pnlComponentes.Enabled = True

        txtRutSnDV.Text = ""
        txtDV.Text = ""
        txtNombres.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        txtCelu.Text = ""
        txtFono.Text = ""

    End Sub

    Private Sub picEditar_Click_1(sender As Object, e As EventArgs) Handles picEditar.Click
        If dgvEmpleados.Rows.Count > 0 Then
            activeEditar = True

            pnlComponentes.Enabled = True
            pnlAcciones.Enabled = False
            Try
                If dgvEmpleados.CurrentRow.Cells(0).Value.Equals(DBNull.Value) Then
                    empleado.Rut = String.Empty
                Else
                    empleado.Rut = dgvEmpleados.CurrentRow.Cells(0).Value
                End If

                If dgvEmpleados.CurrentRow.Cells(1).Value.Equals(DBNull.Value) Then
                    empleado.Nombres = String.Empty
                Else
                    empleado.Nombres = dgvEmpleados.CurrentRow.Cells(1).Value
                End If

                If dgvEmpleados.CurrentRow.Cells(2).Value.Equals(DBNull.Value) Then
                    empleado.ApelidoPaterno = String.Empty
                Else
                    empleado.ApelidoPaterno = dgvEmpleados.CurrentRow.Cells(2).Value
                End If

                If dgvEmpleados.CurrentRow.Cells(3).Value.Equals(DBNull.Value) Then
                    empleado.ApellidoMaterno = String.Empty
                Else
                    empleado.ApellidoMaterno = dgvEmpleados.CurrentRow.Cells(3).Value
                End If

                If dgvEmpleados.CurrentRow.Cells(4).Value.Equals(DBNull.Value) Then
                    empleado.TelefonoFijo = String.Empty
                Else
                    empleado.TelefonoFijo = dgvEmpleados.CurrentRow.Cells(4).Value
                End If

                If dgvEmpleados.CurrentRow.Cells(5).Value.Equals(DBNull.Value) Then
                    empleado.TelefonoCelular = String.Empty
                Else
                    empleado.TelefonoCelular = dgvEmpleados.CurrentRow.Cells(5).Value
                End If
            Catch ex As Exception
                MsgBox("Existe un error:     " & ex.ToString)
            End Try

            txtRutSnDV.Text = empleado.Rut
            txtDV.Text = empleado.obtenerDV(empleado.Rut)
            txtNombres.Text = empleado.Nombres
            txtApellidoP.Text = empleado.ApelidoPaterno
            txtApellidoM.Text = empleado.ApellidoMaterno
            txtFono.Text = empleado.TelefonoFijo
            txtCelu.Text = empleado.TelefonoCelular
        End If
    End Sub

    Private Sub picEliminar_Click_1(sender As Object, e As EventArgs) Handles picEliminar.Click
        'EVENTO CLICK EN ELIMINAR
        If dgvEmpleados.Rows.Count > 0 Then
            pnlAcciones.Enabled = False
            empleado.Rut = dgvEmpleados.CurrentRow.Cells(0).Value
            Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
            Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
            'MsgBox(response)
            If response = 6 Then
                BsnEmpleado.eliminarEmpleado(empleado)
                txtRutSnDV.Text = ""
                txtDV.Text = ""
                txtNombres.Text = ""
                txtApellidoP.Text = ""
                txtApellidoM.Text = ""
                txtCelu.Text = ""
                txtFono.Text = ""
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

                BsnEmpleado.agregarEmpleado(empleado)
                Dim passEmpleado As String = empleado.Rut.ToString.Substring(0, 4)
                BsnUsuario.agregarUsuario(empleado.Rut, passEmpleado, 4)


            End If

            If activeEditar Then

                BsnEmpleado.editarEmpleado(empleado)



            End If
        End If

        activeAgregar = False
        activeEditar = False
        pnlAcciones.Enabled = True
        pnlComponentes.Enabled = False

        txtRutSnDV.Text = ""
        txtDV.Text = ""
        txtNombres.Text = ""
        txtApellidoP.Text = ""
        txtApellidoM.Text = ""
        txtCelu.Text = ""
        txtFono.Text = ""

        recargarDGV()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        pnlAcciones.Enabled = True
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

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        Dim ListaText As New List(Of String())
        ListaText.Add({"rut", txtRutSnDV.Text})
        ListaText.Add({"digito verificador", txtDV.Text})
        ListaText.Add({"nombre persona", txtNombres.Text})
        ListaText.Add({"apellido", txtApellidoM.Text})
        ListaText.Add({"apellido", txtApellidoP.Text})
        ListaText.Add({"telefono fijo", txtCelu.Text})
        ListaText.Add({"telefono celular", txtFono.Text})



        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If receptor(0) Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL

            'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
            If validacion.ValidarRut(txtRutSnDV.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                cumple = True
            Else
                MsgBox("SR ADMINISTRADOR EL RUT NO ES VALIDO")
            End If
        Else
            MsgBox(receptor(1))
        End If


        Return cumple
    End Function

    Private Sub Reset()
        Dim permiso As New Permisos
        picAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "EMPLEADOS", "AGREGAR", "")
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "EMPLEADOS", "EDITAR", "")
        picEliminar = permiso.OtorgarAcceso(_usuario.Permisos, "EMPLEADOS", "ELIMINAR", "")
    End Sub


End Class