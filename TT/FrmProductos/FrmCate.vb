Public Class FrmCate

    Protected usuario As Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones


    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]




    Protected dataset2 As New DataSet







    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    Private Sub FrmCate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDataSet()
    End Sub

    Private Sub RellenarDataSet()
        Dim bsnCategoria As New BsnCategoria()
        dataset2 = bsnCategoria.ObtenerCategorias()
        Me.dgvCateg.DefaultCellStyle.BackColor = Color.Beige
        Me.dgvCateg.ColumnCount = 3
        Me.dgvCateg.Columns(0).Name = "Id"
        Me.dgvCateg.Columns(1).Name = "Nombre"
        Me.dgvCateg.Columns(2).Name = "Codigo"

        dgvCateg.Columns(0).DataPropertyName = "Nombre"
        dgvCateg.Columns(1).DataPropertyName = "Codigo"

        For i = 0 To dataset2.Tables(0).Rows.Count - 1
            dgvCateg.Rows.Add(dataset2.Tables(0)(i)(0).ToString, dataset2.Tables(0)(i)(1).ToString, dataset2.Tables(0)(i)(3).ToString)

        Next

        'dgvCateg.Columns(1) = dataset2.Tables(0).Columns(1).
        'dgvCateg.DataSource = dataset2.Tables(0).Columns(1)
        'Me.dgvProd.Columns(2).DefaultCellStyle.Format = "c"



        If dgvCateg.Rows.Count > 0 Then
            dgvCateg.Rows(0).Selected = False
        End If

    End Sub
End Class


