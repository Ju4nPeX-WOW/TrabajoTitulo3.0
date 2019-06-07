Public Class FrmDesc

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
        Me.dgvDescuentos.Columns(1).Name = "Nombre"
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
        Dim txt = bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString, 1000, 10)
        Dim precio = txt(1)

        txt = txt(0)
        MsgBox(txt)
        MsgBox(precio)

        bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString)
        bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells.Item(4).Value.ToString, 1000, 10)


        'RellenarDatos(dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
        'dgvSubCat.CurrentRow.Cells.Item(1).Value.ToString(),
        '0dgvSubCat.CurrentRow.Cells.Item(2).Value.ToString())
    End Sub


End Class
