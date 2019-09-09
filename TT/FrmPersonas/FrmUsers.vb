Public Class FrmUsers
    Private _usuario As New Usuario
    Dim dataset As New DataSet
    Dim BsnUsuario As New BsnUsuario
    Dim validacion As New Validacionesv2
    Dim BsnEmpleado As New BsnEmpleado
    Dim activeEditar As Boolean = False
    Dim btnSeleccionadoPrimeraVez As Boolean = False

    Private Sub reset()
        Dim permiso As New Permisos
        tsmEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "USUARIOS", "EDITAR", "")
        tsmEliminar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "USUARIOS", "ELIMINAR", "")
    End Sub
    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDv.KeyPress
        e.Handled = validacion.IRut(e)
    End Sub
    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        e.Handled = validacion.IRutVerificador(e)
    End Sub
    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        e.Handled = validacion.IPassword(e)
    End Sub
    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        e.Handled = validacion.IOtroNombre(e)
    End Sub
    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtRutSnDv.MaxLength = validacion.MaxRut
        txtDV.MaxLength = validacion.MaxRutVerificador
        txtContraseña.MaxLength = validacion.MaxPassword
        recargarDGV()
        cmbPermisos.SelectedIndex = 0
        cmbBusqueda.SelectedIndex = 0
        llenado()
        reset()
    End Sub

    Public Sub recargarDGV()
        dataset = BsnUsuario.obtenerUsuarios()
        dgvUsua.DataSource = dataset.Tables(0).DefaultView
        If dgvUsua.Rows.Count > 0 Then

        End If
    End Sub
    Public Sub limpiarTextos()
        txtRutSnDv.Text = ""
        txtDV.Text = ""
        txtContraseña.Text = ""
        cmbPermisos.SelectedIndex = 0
    End Sub
    Public Sub llenado()
        If dgvUsua.Rows.Count > 0 Then
            Try
                'Si en la base de datos existen campos vacios, se representan como NULL, no como ''.
                'Entonces... si la fila seleccionada tiene un campo vacio desde la BD (o sea NULL) entonces
                'Referenciamos a la variable como '' o sea STRING.EMPTY;
                If dgvUsua.CurrentRow.Cells(1).Value.Equals(DBNull.Value) Then
                    txtRutSnDv.Text = String.Empty
                Else
                    txtRutSnDv.Text = dgvUsua.CurrentRow.Cells(1).Value.ToString().Trim()
                End If

                txtDV.Text = _usuario.obtenerDV(txtRutSnDv.Text)
                If dgvUsua.CurrentRow.Cells(2).Value.Equals(DBNull.Value) Then
                    txtContraseña.Text = String.Empty
                Else
                    txtContraseña.Text = dgvUsua.CurrentRow.Cells(2).Value.ToString.Trim()
                End If
                If dgvUsua.CurrentRow.Cells(3).Value.Equals(DBNull.Value) Then
                    cmbPermisos.SelectedIndex = 0
                Else
                    cmbPermisos.Text = dgvUsua.CurrentRow.Cells(3).Value
                End If
            Catch ex As Exception
                MsgBox("Ha ocurrido un error: " & ex.ToString)
            End Try
        End If
    End Sub
    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        Dim ListaText As New List(Of String())
        ListaText.Add({"rut", txtRutSnDv.Text})
        ListaText.Add({"digito verificador", txtDV.Text})
        ListaText.Add({"password", txtContraseña.Text})
        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX         
        If receptor(0) Then
            cumple = True
        Else
            MsgBox(receptor(1), vbInformation, "Existen campos requeridos vacios.")
        End If
        Return cumple
    End Function
    Private Sub dgvUsua_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsua.CellClick
        llenado()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        mnsProd.Enabled = True
        dgvUsua.Enabled = True
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'PRIMERO VALIDAR
        If RealizarValidacion() Then
            If activeEditar = True Then
                Dim Usuario As New Usuario
                Usuario.Rut = txtRutSnDv.Text
                Usuario.Password = txtContraseña.Text
                Usuario.Permisos = cmbPermisos.Text
                BsnUsuario.editarUsuario(Usuario)
                MsgBox("Usuario editado correctamente", vbInformation, "Usuario editado")
            End If
            limpiarTextos()
            recargarDGV()
            pnlComponentes.Enabled = False
            mnsProd.Enabled = True
            activeEditar = False
            dgvUsua.Enabled = True
        End If
    End Sub
    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If dgvUsua.Rows.Count > 0 Then
            activeEditar = True
            pnlComponentes.Enabled = True
            mnsProd.Enabled = False
            txtRutSnDv.Enabled = False
            txtDV.Enabled = False
            dgvUsua.Enabled = False
            If dgvUsua.CurrentRow.Index > -1 Then
                Dim fila() As String = {dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(0).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(1).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(2).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(3).Value}
                txtRutSnDv.Text = fila(1)
                txtContraseña.Text = fila(2)
                'setear el combobox    
                cmbPermisos.Text = fila(3)
            End If
        End If
    End Sub
    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        If dgvUsua.Rows.Count > 0 Then
            If dgvUsua.CurrentRow.Index > -1 Then
                Dim rut_empleado As String = dgvUsua.CurrentRow.Cells(1).Value
                Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
                Dim response = MsgBox("¿Está seguro de eliminar?", style, "Confirmar eliminacion") '6->SI  7->NO'
                'MsgBox(response)
                If response = 6 Then
                    Dim Empleado As New Empleado
                    Empleado.Rut = rut_empleado
                    BsnUsuario.eliminarUsuario(rut_empleado) 'el usuario se elimina de USUARIO Y EMPLEADO
                    BsnEmpleado.eliminarEmpleado(Empleado)   'el usuario se elimina de USUARIO Y EMPLEADO
                    MsgBox("Empleado eliminado correctamente", vbInformation, "Empleado eliminado")
                    limpiarTextos()
                    recargarDGV()
                End If
            End If
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text <> "" Then
            btnSeleccionadoPrimeraVez = True
            Dim tipoBusqueda As String = cmbBusqueda.Text.ToLower()
            Dim tabla As String = "Usuarios"
            Dim dataset_b As New DataSet
            Dim busqueda2 As New Busqueda2
            'MsgBox(txtBusqueda.Text)
            Try
                Select Case tipoBusqueda
                    Case "rut empleado"
                        dataset_b = busqueda2.busquedaIncremental("Id_usuario,Rut_empleado,Contraseña,Permisos", tabla, "Rut_empleado", txtBusqueda.Text)
                        dgvUsua.DataSource = dataset_b.Tables(0).DefaultView
                        llenado()
                    Case "permisos"
                        dataset_b = busqueda2.busquedaIncremental("Id_usuario,Rut_empleado,Contraseña,Permisos", tabla, "Permisos", txtBusqueda.Text)
                        dgvUsua.DataSource = dataset_b.Tables(0).DefaultView
                        llenado()
                    Case ""
                        MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
                End Select
            Catch ex As Exception

            End Try
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
