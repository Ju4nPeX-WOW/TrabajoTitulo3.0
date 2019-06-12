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

    Public Sub DesbloquearBotones()
        'LABELES

        'TXT , COMBO y NUD




        btnAce.Enabled = True
        btnCan.Enabled = True
    End Sub

    Public Sub BloquearBotones()
        'LABELES

        'TXT , COMBO y NUD

        btnAce.Enabled = False
        btnAce.Enabled = False
    End Sub

    Private Sub FrmDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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



    End Sub

    Private Sub TsmAgregarCat_Click(sender As Object, e As EventArgs) Handles tsmAgregarCat.Click
        activeAgregar = True
        activeEditar = False
        activeEliminar = False

        DesbloquearBotones()

    End Sub

    Private Sub TsmEditarCat_Click(sender As Object, e As EventArgs) Handles tsmEditarCat.Click
        activeAgregar = False
        activeEditar = True
        activeEliminar = False

        DesbloquearBotones()
    End Sub

    Private Sub TsmEliminarCat_Click(sender As Object, e As EventArgs) Handles tsmEliminarCat.Click
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
        RellenarDataSet()

        BloquearBotones()

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
End Class
