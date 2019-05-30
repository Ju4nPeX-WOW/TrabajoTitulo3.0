Public Class frmVenta
    Protected BsnEmpleado As New BsnEmpleado
    Protected DaoEmpleado As New DaoEmpleado

    Protected BsnCliente As New BsnCliente
    Protected DaoCliente As New DaoCliente



    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'rellenar combobox empleado
        Dim datasetEmpleados As DataSet = BsnEmpleado.obtenerTodosEmpleados
        cmbVendedor.DataSource = datasetEmpleados.Tables(0)
        cmbVendedor.DisplayMember = "NOMBRES"

        Dim datasetClientes As DataSet = BsnCliente.obtenerTodosClientes
        cmbClientes.DataSource = datasetClientes.Tables(0)
        cmbClientes.DisplayMember = "Rut_cliente"

        Timer1.Enabled = True

        cmbVendedor.Text = ""
        cmbClientes.Text = ""

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtFecha.Text = DateTime.Now

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub txtDescProd_TextChanged(sender As Object, e As EventArgs) Handles txtDescProd.TextChanged

    End Sub

    Private Sub lblDescProd_Click(sender As Object, e As EventArgs) Handles lblDescProd.Click

    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub lblPrecio_Click(sender As Object, e As EventArgs) Handles lblPrecio.Click

    End Sub

    Private Sub txtCant_TextChanged(sender As Object, e As EventArgs) Handles txtCant.TextChanged

    End Sub

    Private Sub lblCant_Click(sender As Object, e As EventArgs) Handles lblCant.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmbVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendedor.SelectedIndexChanged

    End Sub

    Private Sub txtFecha_TextChanged(sender As Object, e As EventArgs) Handles txtFecha.TextChanged

    End Sub

    Private Sub lblRut_Click(sender As Object, e As EventArgs) Handles lblRut.Click

    End Sub

    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged

    End Sub

    Private Sub lblVend_Click(sender As Object, e As EventArgs) Handles lblVend.Click

    End Sub

    Private Sub lblFecha_Click(sender As Object, e As EventArgs) Handles lblFecha.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub chkBoleta_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoleta.CheckedChanged

    End Sub

    Private Sub chkFactura_CheckedChanged(sender As Object, e As EventArgs) Handles chkFactura.CheckedChanged

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub lblIva_Click(sender As Object, e As EventArgs) Handles lblIva.Click

    End Sub

    Private Sub lblDesc_Click(sender As Object, e As EventArgs) Handles lblDesc.Click

    End Sub

    Private Sub lblSubto_Click(sender As Object, e As EventArgs) Handles lblSubto.Click

    End Sub

    Private Sub txtIva_TextChanged(sender As Object, e As EventArgs) Handles txtIva.TextChanged

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub

    Private Sub txtSubto_TextChanged(sender As Object, e As EventArgs) Handles txtSubto.TextChanged

    End Sub

    Private Sub lblVenta_Click(sender As Object, e As EventArgs) Handles lblVenta.Click

    End Sub
End Class