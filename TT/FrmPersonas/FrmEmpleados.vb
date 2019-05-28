Public Class FrmEmpleados

    Dim empleado As New Empleado
    Dim BsnEmpleado As New BsnEmpleado
    Dim dataset As New DataSet

    Dim activeAgregar As Boolean = False
    Dim activeEditar As Boolean = False
    Public Sub recargarDGV()
        dataset = BsnEmpleado.obtenerTodosEmpleados()
        dgvEmpleados.DataSource = dataset.Tables(0).DefaultView
    End Sub
    Private Sub formUsua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recargarDGV()
        pnlComponentes.Enabled = False
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



    End Sub

    Private Sub picEliminar_Click_1(sender As Object, e As EventArgs) Handles picEliminar.Click
        'EVENTO CLICK EN ELIMINAR
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
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If activeAgregar Then
            If txtRutSnDV.Text = "" Or txtDV.Text = "" Or txtNombres.Text = "" Then
                MsgBox("Por favor complete los campos requeridos...", vbCritical)
            Else
                If Not empleado.validarRut(txtRutSnDV.Text, txtDV.Text) Then
                    MsgBox("El RUT ingresado NO ES CORRECTO")
                Else
                    'Seteando el objeto clientes con sus caracteristicas
                    empleado.Rut = txtRutSnDV.Text
                    empleado.Nombres = txtNombres.Text
                    empleado.ApelidoPaterno = txtApellidoP.Text
                    empleado.ApellidoMaterno = txtApellidoM.Text
                    empleado.TelefonoCelular = txtCelu.Text
                    empleado.TelefonoFijo = txtFono.Text

                    BsnEmpleado.agregarEmpleado(empleado)

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
                End If
            End If
        End If

        If activeEditar Then
            If txtRutSnDV.Text = "" Or txtDV.Text = "" Or txtNombres.Text = "" Then
                MsgBox("Por favor complete los campos requeridos...", vbCritical)
            Else

                empleado.Rut = txtRutSnDV.Text
                empleado.Nombres = txtNombres.Text
                empleado.ApelidoPaterno = txtApellidoP.Text
                empleado.ApellidoMaterno = txtApellidoM.Text
                empleado.TelefonoCelular = txtCelu.Text
                empleado.TelefonoFijo = txtFono.Text

                BsnEmpleado.editarEmpleado(empleado)

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

            End If

        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        pnlAcciones.Enabled = True
    End Sub
End Class


