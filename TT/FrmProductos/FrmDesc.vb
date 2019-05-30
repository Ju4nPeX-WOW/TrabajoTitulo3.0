Public Class FrmDesc

    Protected dataset2 As New DataSet
    Private Sub BtnExitDes_Click(sender As Object, e As EventArgs) Handles BtnExitDes.Click
        Me.Close()
    End Sub


    Private Sub RellenarDataSet()
        Dim bsnDescuentos As New BsnDescuentos()
        dataset2 = bsnDescuentos.ObtenerDescuentos()
        'Me.dgvDescuentos.DefaultCellStyle.BackColor = Color.Beige
        'Me.dgvDescuentos.ColumnCount = 3
        'Me.dgvDescuentos.Columns(0).Name = "Id"
        'Me.dgvDescuentos.Columns(1).Name = "Nombre"
        'Me.dgvDescuentos.Columns(2).Name = "Codigo"

        'dgvDescuentos.Columns(0).DataPropertyName = "Nombre"
        'dgvDescuentos.Columns(1).DataPropertyName = "Codigo"

        'For i = 0 To dataset2.Tables(0).Rows.Count - 1
        'dgvDescuentos.Rows.Add(dataset2.Tables(0)(i)(0).ToString, dataset2.Tables(0)(i)(1).ToString, dataset2.Tables(0)(i)(3).ToString)

        'Next

        'dgvCateg.Columns(1) = dataset2.Tables(0).Columns(1).
        dgvDescuentos.DataSource = dataset2.Tables(0).DefaultView
        'Me.dgvProd.Columns(2).DefaultCellStyle.Format = "c"



        If dgvDescuentos.Rows.Count > 0 Then
            dgvDescuentos.Rows(0).Selected = False
        End If

    End Sub

    Private Sub FrmDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDataSet()
    End Sub
End Class
