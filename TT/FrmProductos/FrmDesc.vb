Public Class FrmDesc

    Protected usuario As Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected descuento As Descuento '------------------------>Recepción del usuario que usa el sistema

    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones


    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]




    Protected dataset As New DataSet
    Private Sub BtnExitDes_Click(sender As Object, e As EventArgs) Handles BtnExitDes.Click
        Me.Close()
    End Sub


    Private Sub RellenarDataSet()

        Dim bsnDescuentos As New BsnDescuentos()
        dataset = bsnDescuentos.ObtenerDescuentos()


        dgvDescuentos.Rows.Clear()


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
        RellenarDataSet()
        RellenarCMB()
    End Sub

    Private Sub dgvDescuentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescuentos.CellClick

        Dim bsnDescuentos As New BsnDescuentos()



        MsgBox(bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString))

        bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString)
        bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString, 1000, 10)



        lblIdDescuento.Text = dgvDescuentos.CurrentRow.Cells.Item(0).Value.ToString()
        dtpInicio.Value = DateTime.Now.ToString("dd/MM/yyyy")
        dtpTermino.Value = dgvDescuentos.CurrentRow.Cells.Item(3).Value.ToString()



    End Sub

    Private Sub tsmAgregarCat_Click(sender As Object, e As EventArgs) Handles tsmAgregarCat.Click
        activeAgregar = True
        activeEditar = False
        activeEliminar = False

    End Sub

    Private Sub tsmEditarCat_Click(sender As Object, e As EventArgs) Handles tsmEditarCat.Click
        activeAgregar = False
        activeEditar = True
        activeEliminar = False
    End Sub

    Private Sub tsmEliminarCat_Click(sender As Object, e As EventArgs) Handles tsmEliminarCat.Click
        activeAgregar = False
        activeEditar = False
        activeEliminar = True

        Dim bsnDescuento As New BsnDescuentos
        bsnDescuento.DarFin(lblIdDescuento.Text)


    End Sub

    Private Sub btnAce_Click(sender As Object, e As EventArgs) Handles btnAce.Click

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
            fec_ini = dgvDescuentos.CurrentRow.Cells.Item(2).Value.ToString()
            fec_ter = dgvDescuentos.CurrentRow.Cells.Item(3).Value.ToString()
            con = condicion

        ElseIf activeEditar Then
            id_des = lblIdDescuento.Text
            id_prod = cmbProducto.SelectedItem.ToString()
            id_prod = id_prod.Substring(0, InStr(1, id_prod, "-") - 1)
            fec_ter = dgvDescuentos.CurrentRow.Cells.Item(3).Value.ToString()
            con = condicion
        End If

        'Rellenemos El Objeto
        ObjetoDescuento.IdDescuento = id_des
        ObjetoDescuento.IdProducto = id_prod
        ObjetoDescuento.FechaInicio = fec_ini
        ObjetoDescuento.FechaTermino = fec_ter
        ObjetoDescuento.Condicion = con


    End Sub
End Class
