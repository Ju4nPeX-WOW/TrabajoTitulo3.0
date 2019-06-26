Public Class FrmClientes
    Dim Cliente As New Cliente
    Dim BsnCliente As New BsnCliente
    Dim dataset As New DataSet
    Dim validacion As New Validacionesv2
    Dim activeAgregar = False
    Dim activeEditar = False
    Dim activeEliminar = False

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        'EVENTO CLICK EN AGREGAR
        activeAgregar = True
        pnlComponentes.Enabled = True
        pnlAcciones.Enabled = False
    End Sub

    Private Sub picEditar_Click(sender As Object, e As EventArgs) Handles picEditar.Click
        pnlComponentes.Enabled = True
        pnlAcciones.Enabled = False

        txtRutSnDV.Enabled = False
        txtDV.Enabled = False

        activeEditar = True
        dgvClientes.Enabled = False


        'EVENTO CLICK EN EDITAR 
        Try

            If dgvClientes.CurrentRow.Cells(0).Value.Equals(DBNull.Value) Then
                Cliente.Rut = String.Empty
            Else
                Cliente.Rut = dgvClientes.CurrentRow.Cells(0).Value
            End If


            If dgvClientes.CurrentRow.Cells(1).Value.Equals(DBNull.Value) Then
                Cliente.Nombres = String.Empty
            Else
                Cliente.Nombres = dgvClientes.CurrentRow.Cells(1).Value
            End If

            If dgvClientes.CurrentRow.Cells(2).Value.Equals(DBNull.Value) Then
                Cliente.ApelidoPaterno = String.Empty
            Else
                Cliente.ApelidoPaterno = dgvClientes.CurrentRow.Cells(2).Value
            End If


            If dgvClientes.CurrentRow.Cells(3).Value.Equals(DBNull.Value) Then
                Cliente.ApellidoMaterno = String.Empty
            Else
                Cliente.ApellidoMaterno = dgvClientes.CurrentRow.Cells(3).Value
            End If


            If dgvClientes.CurrentRow.Cells(4).Value.Equals(DBNull.Value) Then
                Cliente.Descuento = String.Empty
            Else
                Cliente.Descuento = dgvClientes.CurrentRow.Cells(4).Value
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try

        txtRutSnDV.Text = Cliente.Rut
        txtDV.Text = Cliente.obtenerDV(Cliente.Rut)
        txtNombres.Text = Cliente.Nombres
        txtApellidoP.Text = Cliente.ApelidoPaterno
        txtApellidoM.Text = Cliente.ApellidoMaterno
        tbDescuento.Value = Cliente.Descuento

        lblDescuento.Text = "Descuento: " & tbDescuento.Value


    End Sub

    Private Sub picEliminar_Click(sender As Object, e As EventArgs) Handles picEliminar.Click
        'EVENTO CLICK EN ELIMINAR

        Cliente.Rut = dgvClientes.CurrentRow.Cells(0).Value
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
        'MsgBox(response)
        If response = 6 Then
            BsnCliente.eliminarCliente(Cliente)
            recargarDGV()
        End If
    End Sub

    Public Sub recargarDGV()
        'tab en clientes            
        dataset = BsnCliente.obtenerTodosClientes() 'obtiene todos los usuarios
        dgvClientes.DataSource = dataset.Tables(0).DefaultView 'los pone en el datagridview clientes
    End Sub
    Private Sub formUsua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtRutSnDV.MaxLength = validacion.MaxRut
        txtDV.MaxLength = validacion.MaxRutVerificador
        txtNombres.MaxLength = validacion.MaxNombrePersona
        txtApellidoM.MaxLength = validacion.MaxApellido
        txtApellidoP.MaxLength = validacion.MaxApellido

        pnlComponentes.Enabled = False
        recargarDGV()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
        pnlAcciones.Enabled = True
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
            Cliente.Descuento = tbDescuento.Value

            If activeAgregar Then
                BsnCliente.agregarCliente(Cliente)


            End If

            If activeEditar Then
                BsnCliente.editarCliente(Cliente)

            End If
        End If


        pnlComponentes.Enabled = True
        pnlAcciones.Enabled = True
        activeEditar = False
        activeAgregar = False
        dgvClientes.Enabled = True
        recargarDGV()
    End Sub

    Private Sub tbDescuento_Scroll(sender As Object, e As EventArgs) Handles tbDescuento.Scroll
        lblDescuento.Text = "Descuento: " & tbDescuento.Value
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

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        Dim ListaText As New List(Of String())
        ListaText.Add({"rut", txtRutSnDV.Text})
        ListaText.Add({"digito verificador", txtDV.Text})
        ListaText.Add({"nombre persona", txtNombres.Text})
        ListaText.Add({"apellido", txtApellidoM.Text})
        ListaText.Add({"apellido", txtApellidoP.Text})


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

End Class
