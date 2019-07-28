Public Class Testeo
    Private Sub Testeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''OBTENER DATA SET 
        Dim bsnProducto As New BsnProducto
        Dim dataset As New DataSet
        dataset = bsnProducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE,PRECIO,STOCK")

        Dim column = New DataColumn()

        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "DESCUENTOS"
        column.ReadOnly = False
        'Add the Column to the DataColumnCollection.
        dataset.Tables(0).Columns.Add(column)

        For i = 0 To dataset.Tables(0).Rows.Count - 1
            Dim bsnVenta As New BsnVenta
            Dim Descuento As String = bsnVenta.ObtenerCondicionDescuento(dataset.Tables(0)(i)(0).ToString)
            dataset.Tables(0)(i)("DESCUENTOS") = Descuento
        Next


        ''RELLENAR DGV
        EstructurarDGV(dgv1)
        dgv1.DataSource = dataset.Tables(0)
    End Sub

    Private Sub EstructurarDGV(dgv As Object)
        dgv1.Rows.Clear()
        dgv1.Rows.Clear()
        dgv1.Rows.Clear()
        dgv1.DefaultCellStyle.BackColor = Color.Beige
        dgv1.ColumnCount = 5
        dgv1.Columns(0).Name = "Id"
        dgv1.Columns(1).Name = "Nombre"
        dgv1.Columns(2).Name = "Precio"
        dgv1.Columns(3).Name = "Stock"
        dgv1.Columns(4).Name = "Descuento"

        dgv1.Columns(0).DataPropertyName = "Id_producto"
        dgv1.Columns(1).DataPropertyName = "Nombre"
        dgv1.Columns(2).DataPropertyName = "Precio"
        dgv1.Columns(3).DataPropertyName = "Stock"
        dgv1.Columns(4).DataPropertyName = "DESCUENTOS"

    End Sub


End Class