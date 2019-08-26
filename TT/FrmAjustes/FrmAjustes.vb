Public Class FrmAjustes

    Dim activeAgregar As Boolean = False
    Dim activeEditar As Boolean = False

    Dim BsnProducto As New BsnProducto
    Dim dataset As New DataSet
    Dim usuario As New Usuario

    Public Sub RecibirUsuario(objeto As Empleado)
        usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema
        'MsgBox("ID-USUARIO : " & usuario.IdUsuario)
    End Sub

    Public Sub recargarDGV()
        dataset = BsnProducto.ObtenerColumnasEspecificas("Id_producto,nombre,precio,stock,codigo_producto")
        dgvProd.DataSource = dataset.Tables(0).DefaultView
    End Sub
    Private Sub FrmAjustes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recargarDGV()
        llenado()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Dispose()
    End Sub

    Private Sub tsmAgregar_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        mnsAjustes.Enabled = False
        nupStock.Enabled = True
        cmbAvanzadoRazon.Enabled = True
        txtPrecio.Enabled = True
        btnAce.Enabled = True
        btnCan.Enabled = True
    End Sub
    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If dgvProd.Rows.Count > 0 Then
            If dgvProd.CurrentRow.Index >= 0 Then
                activeEditar = True
                mnsAjustes.Enabled = False
                nupStock.Enabled = True
                cmbAvanzadoRazon.Enabled = True
                txtPrecio.Enabled = True
                btnAce.Enabled = True
                btnCan.Enabled = True
            Else
                MsgBox("Seleccione un item de la lista", vbInformation, "Información")
            End If
        Else
            MsgBox("No se registran productos en la base de datos", vbInformation, "Base de datos sin productos")
        End If
    End Sub

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        mnsAjustes.Enabled = True
        nupStock.Enabled = False
        cmbAvanzadoRazon.Enabled = False
        btnAce.Enabled = False
        btnCan.Enabled = False
        txtPrecio.Enabled = False
        activeAgregar = False
        activeEditar = False
    End Sub

    Public Function validacion()
        Dim isCorrect As Boolean = False
        Dim pal As String = ""
        If cmbAvanzadoRazon.SelectedIndex < 0 Or nupStock.Value.Equals(0) Then 'mensajes de error
            If cmbAvanzadoRazon.SelectedIndex < 0 Then
                pal = pal & "-Seleccione razón de producto" & vbCrLf
            End If
            If nupStock.Value.Equals(0) Or nupStock.Value.Equals(dgvProd.CurrentRow.Cells(2).Value) Then
                pal = pal & "-Seleccione una cantidad de stock"
            End If
            MsgBox(pal, vbInformation, "Complete los campos")
        Else
            isCorrect = True
        End If
        Return isCorrect 'retornara false siempre y cuando no cumpla las condiciones
    End Function

    Private Sub btnAce_Click(sender As Object, e As EventArgs) Handles btnAce.Click
        If activeAgregar Then 'Si selecciono agregar del menustrip            
            'validar comborazon
            'validar numericupdown
            Dim Producto As New Producto
            If validacion() Then

                Producto.IdProducto = dgvProd.CurrentRow.Cells(0).Value
                Producto.Precio = txtPrecio.Text
                Producto.Stock = nupStock.Value.ToString

                BsnProducto.RealizarAjuste(Producto, cmbAvanzadoRazon.SelectedIndex, usuario.Rut)
                recargarDGV()
                llenado()
            End If
        ElseIf activeEditar Then
            Dim Producto As New Producto
            If validacion() Then

                Producto.IdProducto = dgvProd.CurrentRow.Cells(0).Value
                Producto.Precio = txtPrecio.Text
                Producto.Stock = nupStock.Value.ToString

                BsnProducto.RealizarAjuste(Producto, cmbAvanzadoRazon.SelectedIndex, usuario.Rut)
                recargarDGV()
                llenado()
            End If
        End If
    End Sub

    Public Sub llenado()
        Dim id As String = ""
        Dim producto As String = ""
        Try
            lblIdProd.Text = dgvProd.CurrentRow.Cells(0).Value
            lblProducto.Text = dgvProd.CurrentRow.Cells(1).Value
            txtPrecio.Text = dgvProd.CurrentRow.Cells(2).Value
            nupStock.Value = dgvProd.CurrentRow.Cells(3).Value
        Catch ex2 As NullReferenceException
            Console.WriteLine("No hay productos, el error generado:'{ex2}'")
        End Try
    End Sub
    Private Sub dgvProd_Click(sender As Object, e As EventArgs) Handles dgvProd.Click
        llenado()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class