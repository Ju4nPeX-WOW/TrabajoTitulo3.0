Public Class FrmProvee
    Dim _usuario As Usuario
    Dim dataset As New DataSet
    Dim BsnProv As New BsnProveedores

    Dim activeAgregar As Boolean = False
    Dim activeEditar As Boolean = False
    Dim val2 As New Validacionesv2
    Dim Proveedor As New Proveedor

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
        txtRutSnDV.MaxLength = val2.MaxRut
        txtNombres.MaxLength = val2.MaxNombrePersona
        txtApellidoM.MaxLength = val2.MaxApellido
        txtApellidoP.MaxLength = val2.MaxApellido
        txtCelu.MaxLength = val2.MaxTelefonoC
        txtFono.MaxLength = val2.MaxTelefonoF
        txtEmail.MaxLength = val2.MaxEmail
        txtDireccion.MaxLength = val2.MaxDireccion

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pnlComponentes.Enabled = True
        pnlAcciones.Enabled = False
        activeAgregar = True
        limpieza()
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        pnlComponentes.Enabled = True
        activeEditar = True
        pnlAcciones.Enabled = False
        If dgvProveedor.CurrentRow.Index >= 0 Then
            llenado()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        activeEditar = False
        activeAgregar = False
        pnlAcciones.Enabled = True

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
            txtEmail.text = dgvProveedor.CurrentRow.Cells(6).Value
            txtDireccion.Text = dgvProveedor.CurrentRow.Cells(7).Value
            txtDV.Text = Proveedor.obtenerDV(txtRutSnDV.Text)
        Catch ex2 As NullReferenceException
            Console.WriteLine("No hay productos, el error generado:'{ex2}'")
        End Try
    End Sub

    Public Sub limpieza()
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
        If dgvProveedor.CurrentRow.Index >= 0 Then
            llenado()
        End If
    End Sub

    Public Function realizarValidacion()
        Dim isCorrect As Boolean = True
        Dim pal As String = ""
        If txtRutSnDV.Text = "" Or txtDV.Text = "" Then
            isCorrect = False
            pal = pal & "-Complete rut/digito verificador" & vbLf
        End If
        If txtNombres.Text = "" Then
            isCorrect = False
            pal = pal & "-Complete el nombre del proveedor" & vbLf
        End If
        If Not (Proveedor.validarRut(txtRutSnDV.Text, txtDV.Text)) Then
            isCorrect = False
            pal = pal & "-El rut/digito verificador es incorrecto" & vbCrLf
        End If
        If Not (isCorrect) Then
            MsgBox(pal, vbInformation, "Complete los campos")
        End If

        Return isCorrect
    End Function

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If realizarValidacion() Then
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
            End If
            activeAgregar = False
            activeEditar = False
            pnlComponentes.Enabled = False
            pnlAcciones.Enabled = True
            recargarDGV()
        End If
    End Sub

    Private Sub dgvProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProveedor.CellClick
        llenado()
    End Sub
    Private Sub txtRutSnDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDV.KeyPress
        e.Handled = val2.IRut(e)
    End Sub
    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        e.Handled = val2.IRutVerificador(e)
    End Sub
    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        e.Handled = val2.INombrePersona(e)
    End Sub
    Private Sub txtCelu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelu.KeyPress
        e.Handled = val2.ITelefonoC(e)
    End Sub
    Private Sub txtFono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        e.Handled = val2.ITelefonoF(e)
    End Sub
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        e.Handled = val2.IEmail(e)
    End Sub
    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        e.Handled = val2.IDireccion(e)
    End Sub
    Private Sub txtApellidoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoP.KeyPress
        e.Handled = val2.IApellido(e)
    End Sub
    Private Sub txtApellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoM.KeyPress
        e.Handled = val2.IApellido(e)
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
            Dim BsnInstructions As New Instructions
            Select Case tipoBusqueda
                Case "RUT PROVEEDOR"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Rut_proveedor", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "NOMBRES"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Nombres", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "APELLIDO PATERNO"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Apellido_p", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "APELLIDO MATERNO"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Apellido_m", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "TELEFONO"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Telefono_f", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "CELULAR"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Telefono_c", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "EMAIL"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Email", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "DIRECCION"
                    dataset = BsnInstructions.busquedaIncremental("*", tabla, "Direccion", txtBusqueda.Text)
                    dgvProveedor.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case ""
                    MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
            End Select
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If dgvProveedor.Rows.Count > 0 Then
            Proveedor.Rut = dgvProveedor.CurrentRow.Cells(0).Value
            Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
            Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
            'MsgBox(response)
            If response = 6 Then
                BsnProv.eliminarProv(Proveedor)
                txtRutSnDV.Text = ""
                txtDV.Text = ""
                txtNombres.Text = ""
                txtApellidoP.Text = ""
                txtApellidoM.Text = ""
                txtCelu.Text = ""
                txtFono.Text = ""
                recargarDGV()
                llenado()
            End If
        End If
    End Sub
End Class
