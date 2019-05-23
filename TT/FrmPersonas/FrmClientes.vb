Public Class FrmClientes
    Dim Cliente As New Cliente
    Dim BsnCliente As New BsnCliente
    Dim dataset As New DataSet

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub



    Private Sub picAgregar_Click(sender As Object, e As EventArgs) Handles picAgregar.Click
        'EVENTO CLICK EN AGREGAR

        frmAgreCliente.ShowDialog()    'form de agregar
        recargarDGV()
    End Sub

    Private Sub picEditar_Click(sender As Object, e As EventArgs) Handles picEditar.Click
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

        Dim frmAgre As New frmAgreCliente

        frmAgre.Label5.Text = "EDITAR CLIENTE"
        frmAgre.txtRutSnDV.Enabled = False
        frmAgre.txtDV.Enabled = False

        frmAgre.txtRutSnDV.Text = Cliente.Rut
        frmAgre.txtDV.Text = Cliente.obtenerDV(Cliente.Rut)
        frmAgre.txtNombres.Text = Cliente.Nombres
        frmAgre.txtApellidoM.Text = Cliente.ApellidoMaterno
        frmAgre.txtApellidoP.Text = Cliente.ApelidoPaterno
        frmAgre.tbDescuento.Value = Cliente.Descuento
        frmAgre.lblDescuento.Text = "DESCUENTO: " & Cliente.Descuento
        frmAgre.btnAgregar.Text = "Editar"

        frmAgre.ShowDialog()
        recargarDGV()

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
        recargarDGV()
    End Sub

End Class
