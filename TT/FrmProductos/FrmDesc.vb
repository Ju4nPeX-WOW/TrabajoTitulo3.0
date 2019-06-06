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

    Private Sub FrmDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDataSet()
    End Sub


End Class
