Public Class FrmDesc

    Private _usuario As New Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected descuento As Descuento '------------------------>Recepción del usuario que usa el sistema

    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones
    Protected Validacion As New Validacionesv2

    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]
    Dim auxtermino As String = ""



    Protected dataset As New DataSet
    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub


    Private Sub BtnExitDes_Click(sender As Object, e As EventArgs) Handles BtnExitDes.Click
        Me.Close()
    End Sub

    Private Sub BuildDGV()
        Me.dgvDescuentos.DefaultCellStyle.BackColor = Color.Beige
        Me.dgvDescuentos.ColumnCount = 5
        Me.dgvDescuentos.Columns(0).Name = "Id"
        Me.dgvDescuentos.Columns(1).Name = "Producto"
        Me.dgvDescuentos.Columns(2).Name = "Fecha Inicio"
        Me.dgvDescuentos.Columns(3).Name = "Fecha Termino"
        Me.dgvDescuentos.Columns(4).Name = "Condicion"


        'dgvDescuentos.Columns(1).DataPropertyName = "Nombre"

        dgvDescuentos.Columns(0).DataPropertyName = "Id_descuento"
        dgvDescuentos.Columns(1).DataPropertyName = "Nombre"
        dgvDescuentos.Columns(2).DataPropertyName = "Fecha_inicio"
        dgvDescuentos.Columns(3).DataPropertyName = "Fecha_termino"
        dgvDescuentos.Columns(4).DataPropertyName = "Condicion"



    End Sub
    Private Sub RellenarDataSet()
        dgvDescuentos.DataSource = Nothing
        dgvDescuentos.Refresh()

        Dim bsnDescuentos As New BsnDescuentos()
        dataset = bsnDescuentos.ObtenerDescuentos()

        dgvDescuentos.DataSource = dataset.Tables(0).DefaultView



        If dgvDescuentos.Rows.Count > 0 Then
            dgvDescuentos.Rows(0).Selected = False
        End If


    End Sub

    Private Sub RellenarCMB()
        Dim bsnproducto As New BsnProducto
        Dim dataset_1 As New DataSet
        dataset_1 = bsnproducto.ObtenerColumnasEspecificas("Id_producto,Nombre")

        cmbProducto.Items.Clear()
        For i = 0 To dataset_1.Tables(0).Rows.Count - 1
            cmbProducto.Items.Add(dataset_1.Tables(0)(i)(0).ToString + " - " + dataset_1.Tables(0)(i)(1))
        Next

        cmbP1Mayor.Items.Clear()
        cmbP2Mayor.Items.Clear()
        For i = 1 To 5
            cmbP1Mayor.Items.Add((i).ToString)
            cmbP2Mayor.Items.Add((i).ToString)

        Next

        cmbP1Porcentual.Items.Clear()
        cmbP2Porcentual.Items.Clear()
        For i = 1 To 100
            cmbP1Porcentual.Items.Add(i.ToString)
        Next
        For i = 1 To 10
            cmbP2Porcentual.Items.Add(i.ToString)
        Next
    End Sub





    Private Sub FrmDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'largo
        cmbProducto.MaxLength = Validacion.MaxOtroNombre


        reset()


        BuildDGV()
        RellenarDataSet()
        RellenarCMB()
    End Sub

    Private Sub DgvDescuentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescuentos.CellClick

        Dim bsnDescuentos As New BsnDescuentos()



        MsgBox(bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString))

        bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString)
        bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString, 1000, 10)



        lblIdDescuento.Text = dgvDescuentos.CurrentRow.Cells.Item(0).Value.ToString()
        dtpInicio.Value = DateTime.Now.ToString("dd/MM/yyyy")
        dtpTermino.Value = dgvDescuentos.CurrentRow.Cells.Item(3).Value.ToString()
        auxTermino = dgvDescuentos.CurrentRow.Cells.Item(3).Value.ToString()



    End Sub

    Private Sub TsmAgregarCat_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        activeEditar = False
        activeEliminar = False

        btnAce.Enabled = True
        btnCan.Enabled = True



    End Sub

    Private Sub TsmEditarCat_Click(sender As Object, e As EventArgs) Handles tsmExtender.Click
        activeAgregar = False
        activeEditar = True
        activeEliminar = False

        dtpTermino.Enabled = True
        btnAce.Enabled = True
        btnCan.Enabled = True

    End Sub

    Private Sub TsmFinalizarCat_Click(sender As Object, e As EventArgs) Handles tsmFinalizar.Click
        activeAgregar = False
        activeEditar = False
        activeEliminar = True

        Dim bsnDescuento As New BsnDescuentos
        bsnDescuento.DarFin(lblIdDescuento.Text)


        RellenarDataSet()


    End Sub

    Private Sub BtnAce_Click(sender As Object, e As EventArgs) Handles btnAce.Click
        'Respecto a validar:
        '   No deben poder editarse los descuentos que ya caducaron, no tiene sentido el editarlos
        '   Deben ser creados de nuevos, para saber si han caducado se tiene que evaluar la fecha de termino
        '   Dar termino un descuento, se queda el descuento hasta el dia actual, se finaliza así xD.
        If RealizarValidacion() Then

            Dim ObjetoDescuento As New Descuento()

            Dim id_des, id_prod, fec_ini, fec_ter, con As String
            id_des = ""
            id_prod = ""
            fec_ini = ""
            fec_ter = ""
            con = ""

            If activeAgregar Then
                id_prod = cmbProducto.SelectedItem.ToString()
                id_prod = id_prod.Substring(0, InStr(1, id_prod, "-") - 1)
                fec_ini = dtpInicio.Value.ToShortDateString
                fec_ter = dtpTermino.Value.ToShortDateString
                con = GetCondicion()

            ElseIf activeEditar Then
                id_des = lblIdDescuento.Text
                id_prod = cmbProducto.SelectedItem.ToString()
                id_prod = id_prod.Substring(0, InStr(1, id_prod, "-") - 1)
                fec_ini = dtpInicio.Value.ToShortDateString
                fec_ter = dtpTermino.Value.ToShortDateString
                con = GetCondicion()
            End If

            'Rellenemos El Objeto
            ObjetoDescuento.IdDescuento = id_des
            ObjetoDescuento.IdProducto = id_prod
            ObjetoDescuento.FechaInicio = fec_ini
            ObjetoDescuento.FechaTermino = fec_ter
            ObjetoDescuento.Condicion = con

            Dim bsnDescuento As New BsnDescuentos

            If activeAgregar Then
                bsnDescuento.AgregarDescuento(ObjetoDescuento)
            ElseIf activeEditar Then
                bsnDescuento.ModificarDescuento(ObjetoDescuento)
            End If

        End If

        RellenarDataSet()

        btnAce.Enabled = False
        btnCan.Enabled = False

    End Sub

    Private Function GetCondicion()
        Dim tipo, p1, p2 As String
        tipo = ""
        p1 = ""
        p2 = ""
        If cbxMayor.Checked Then
            tipo = "X"
            p1 = "0" + cmbP1Mayor.SelectedItem.ToString
            p2 = "0" + cmbP2Mayor.SelectedItem.ToString

        ElseIf cbxPorcentual.Checked Then
            tipo = "E"
            p1 = cmbP1Porcentual.SelectedItem.ToString
            p2 = "0" + cmbP2Porcentual.SelectedItem.ToString
        End If

        Return p1 + tipo + p2

    End Function



    Private Sub cmbProducto_TextChanged(sender As Object, e As EventArgs) Handles cmbProducto.TextChanged
        Dim datasetIncremental As New DataSet
        Dim bsnproducto As New BsnProducto
        datasetIncremental = BsnProducto.BusquedaIncremental("ID_PRODUCTO,NOMBRE", "Productos", "Nombre", cmbProducto.Text)
        cmbProducto.DataSource = datasetIncremental.Tables(0).DefaultView
    End Sub

    Private Sub cmbProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProducto.KeyPress
        e.Handled = Validacion.IOtroNombre(e)
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE NO SE EDITEN DESCUENTOS CADUCADOS
        If activeAgregar Then
            If cmbProducto.SelectedIndex > 0 Then
                If cbxMayor.Checked And cmbP1Mayor.SelectedIndex > 0 And cmbP2Mayor.SelectedIndex > 0 Then
                    cumple = True

                ElseIf cbxPorcentual.Checked And cmbP2Porcentual.SelectedIndex > 0 And cmbP2Porcentual.SelectedIndex > 0 Then
                    cumple = True
                Else
                    MsgBox("SR USUARIO INGRESE CORRECTAMENTE LA CONDICION")
                End If
            Else
                MsgBox("SR USUARIO SELECCIONE EL PRODUCTO AL CUAL APLICARA DESCUENTO")
            End If



        ElseIf activeEditar Then
            If dtpTermino.Value.ToShortDateString >= DateTime.Now Then
                If Not dtpTermino.Value.ToShortDateString < auxtermino Then
                    cumple = True
                Else
                    MsgBox("SR USUARIO PUEDE REDUCIR EL TIMEPO DE VALIDES DEL DESCUENTO")
                End If
            Else
                MsgBox("SR USUARIO NO SE PUEDEN EXTENDER DESCUENTOS FINALIZADOS")
            End If

        End If
        Return cumple
    End Function
    Private Sub reset()
        Dim permiso As New Permisos

        tsmAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "AGREGAR", "")
        tsmExtender.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "EXTENDER", "")
        tsmFinalizar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "FINALIZAR", "")

    End Sub

    Private Sub lblProducto_Click(sender As Object, e As EventArgs) Handles lblProducto.Click

    End Sub

    Private Sub lblFechaInicio_Click(sender As Object, e As EventArgs) Handles lblFechaInicio.Click

    End Sub

    Private Sub lblFechaTermino_Click(sender As Object, e As EventArgs) Handles lblFechaTermino.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub cbxMayor_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMayor.CheckedChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class


