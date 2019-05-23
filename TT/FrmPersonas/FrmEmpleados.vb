Public Class FrmEmpleados

    Dim empleado As New Empleado

    Dim BsnEmpleado As New BsnEmpleado
    Dim dataset As New DataSet

    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        'EVENTO CLICK EN AGREGAR

        frmAgreEmple.ShowDialog()
        recargarDGV()

    End Sub

    Private Sub picEditar_Click(sender As Object, e As EventArgs) Handles picEditar.Click
        'EVENTO CLICK EN EDITAR 

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

        Dim frmAgreEmpl As New frmAgreEmple

        frmAgreEmpl.Label5.Text = "EDITAR EMPLEADO"
        frmAgreEmpl.txtRutSnDV.Enabled = False
        frmAgreEmpl.txtDV.Enabled = False

        frmAgreEmpl.txtRutSnDV.Text = empleado.Rut
        frmAgreEmpl.txtDV.Text = empleado.obtenerDV(empleado.Rut)
        frmAgreEmpl.txtNombres.Text = empleado.Nombres
        frmAgreEmpl.txtApellidoP.Text = empleado.ApelidoPaterno
        frmAgreEmpl.txtApellidoM.Text = empleado.ApellidoMaterno
        frmAgreEmpl.txtFono.Text = empleado.TelefonoFijo
        frmAgreEmpl.txtCelular.Text = empleado.TelefonoCelular
        frmAgreEmpl.btnAgregar.Text = "Editar"

        frmAgreEmpl.ShowDialog()
        recargarDGV()


    End Sub

    Private Sub picEliminar_Click(sender As Object, e As EventArgs) Handles picEliminar.Click
        'EVENTO CLICK EN ELIMINAR
        empleado.Rut = dgvEmpleados.CurrentRow.Cells(0).Value

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
        'MsgBox(response)
        If response = 6 Then
            BsnEmpleado.eliminarEmpleado(empleado)
            recargarDGV()
        End If

    End Sub

    Public Sub recargarDGV()

        dataset = BsnEmpleado.obtenerTodosEmpleados()
        dgvEmpleados.DataSource = dataset.Tables(0).DefaultView



    End Sub
    Private Sub formUsua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recargarDGV()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class


