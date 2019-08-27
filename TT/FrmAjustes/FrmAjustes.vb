Public Class FrmAjustes
    Dim activeAgregar As Boolean = False
    Dim BsnProducto As New BsnProducto
    Dim dataset As New DataSet
    Dim usuario As New Usuario
    Dim val2 As New Validacionesv2
    Dim btnSeleccionadoPrimeraVez As Boolean = False
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
        If dgvProd.Rows.Count > 0 Then
            If dgvProd.CurrentRow.Index >= 0 Then
                activeAgregar = True
                mnsAjustes.Enabled = False
                nupStock.Enabled = True
                cmbAvanzadoRazon.Enabled = True
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
        activeAgregar = False
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
        If validacion() Then
            Dim Producto As New Producto With {
                    .IdProducto = dgvProd.CurrentRow.Cells(0).Value,
                    .Stock = nupStock.Value.ToString
            }
            If activeAgregar Then 'Si selecciono agregar del menustrip   
                BsnProducto.RealizarAjuste(Producto, cmbAvanzadoRazon.SelectedIndex, usuario.Rut)
                recargarDGV()
                llenado()
            End If
            cmbAvanzadoRazon.SelectedIndex = -1
        End If
    End Sub
    Public Sub llenado()
        Dim id As String = ""
        Dim producto As String = ""
        Try
            lblIdProd.Text = dgvProd.CurrentRow.Cells(0).Value
            lblProducto.Text = dgvProd.CurrentRow.Cells(1).Value
            nupStock.Value = dgvProd.CurrentRow.Cells(3).Value
        Catch ex2 As NullReferenceException
            Console.WriteLine("No hay productos, el error generado:'{ex2}'")
        End Try
    End Sub
    Private Sub dgvProd_Click(sender As Object, e As EventArgs) Handles dgvProd.Click
        llenado()
    End Sub
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = val2.IPrecio(e)
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text <> "" Then
            btnSeleccionadoPrimeraVez = True
            Dim tipoBusqueda As String = cmbBusqueda.Text
            Dim tabla As String = "Productos"
            Select Case tipoBusqueda
                Case "Producto"
                    dataset = BsnProducto.BusquedaIncremental("Id_producto,nombre,precio,stock,codigo_producto", tabla, "nombre", txtBusqueda.Text)
                    dgvProd.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case "ID"
                    dataset = BsnProducto.BusquedaIncremental("Id_producto,nombre,precio,stock,codigo_producto", tabla, "Id_producto", txtBusqueda.Text)
                    dgvProd.DataSource = dataset.Tables(0).DefaultView
                    llenado()
                Case ""
                    MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
            End Select
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