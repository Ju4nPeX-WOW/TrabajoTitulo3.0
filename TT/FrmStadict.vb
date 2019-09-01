Imports iText.Kernel.Pdf
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Element.Cell
Imports iText.Layout.Element.Table
Public Class FrmStadict
    Dim dd As New DataSet
    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs)


        Me.Close()
    End Sub

    Private Sub FrmStadict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AbrirPrograma()
        dd = DDATASET()

        CC(Chart1)
        CC(Chart2)
        CC(Chart3)
        CC(Chart4)

    End Sub






    Private Sub AbrirPrograma()
        Dim process As New Process

        Dim ProgramAux As String = My.Computer.FileSystem.SpecialDirectories.Desktop + "\holi.txt"

        Console.WriteLine(ProgramAux)

        Process.Start(ProgramAux)

    End Sub

    Private Function DDATASET()
        Dim dataset As New DataSet
        dataset.Tables.Add("TABLA")
        dataset.Tables(0).Columns.Add("Nombre")
        dataset.Tables(0).Columns.Add("Valor")
        dataset.Tables(0).Rows.Add("PRODUCTO1", 100)
        dataset.Tables(0).Rows.Add("PRODUCTO2", 500)
        Return dataset
    End Function

    Private Sub CC(cha As DataVisualization.Charting.Chart)
        Dim dataset As New DataSet '--------------> Definimos el DatasSet
        Dim miDataTable As New DataTable
        miDataTable.Columns.Add("Nombre")
        miDataTable.Columns.Add("Valor")
        'DsTablas.Tables.Add(Tabla)
        Dim bsnEstadistica As New BsnEstadistica
        dataset = bsnEstadistica.ProductoValor()
        'Limpiar el contenido del grafico antes de enlazar con los nuevos datos
        cha.Series.Clear()
        cha.Titles.Clear()
        'Activar las opciones para visualizar la grafica en 3D
        cha.ChartAreas(0).Area3DStyle.Enable3D = True
        'Agregar el titulo de la grafica
        cha.Titles.Add("Comparativa de Valores de Productos")
        'Agregar el series de la grafica
        cha.Series.Add("Valor")
        'Cambiar el tipo de letra para la grafica
        '       cha.Titles(0).Font = New Font("Tahoma", 15, FontStyle.Bold)
        'Cambiar opciones de rotación y profundidad de la grafica en 3D
        cha.ChartAreas(0).Area3DStyle.Rotation = 20
        cha.ChartAreas(0).Area3DStyle.PointDepth = 75
        cha.ChartAreas(0).Area3DStyle.PointGapDepth = 35
        'Paso 3, Rellenar MiDataTable
        Dim fila As DataRow
        'Guardamos los datos en un datatable usare un for me conviene
        For i = 0 To dataset.Tables(0).Rows.Count - 1
            fila = miDataTable.NewRow()
            fila("Nombre") = dataset.Tables(0)(i)(0).ToString()
            fila("Valor") = dataset.Tables(0)(i)(1)
            miDataTable.Rows.Add(fila)
        Next
        'Paso 3, Generar la grafica con el DataView
        Dim miView As DataView = New DataView(miDataTable) 'Enviamos a un dataview el datatable
        For x = 0 To miView.Count - 1
            'Tomamos los datos de DataView para la gráfica
            Console.WriteLine(miView(x)("Nombre"))
            Console.WriteLine(miView(x)("Valor"))
            cha.Series(0).Points.AddXY(miView(x)("Nombre"), miView(x)("Valor"))
        Next
        'Cambiar el tipo de grafico a Pastel
        cha.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Pie
        'Mostrar como etiqueta de datos, los valores totales que alimentan la grafica
        cha.Series(0).IsValueShownAsLabel = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub

    Private Sub BtnExitCat_Click_1(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim destino As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim writer = New PdfWriter(destino & "\test.pdf")
        Dim pdfDoc = New PdfDocument(writer)

        pdfDoc.AddNewPage()

        Dim document = New Document(pdfDoc)


        document.Add(New Paragraph("Productos").SetUnderline().SetTextAlignment(Properties.TextAlignment.CENTER).SetWidthPercent(100))

        document.Add(New Paragraph("FECHA DE CREACION: " & iText.IO.Util.DateTimeUtil.GetCurrentTime).SetTextAlignment(Properties.TextAlignment.RIGHT))
        Dim pointColumnWidth() = {150.0F, 150.0F, 150.0F, 150.0F}
        Dim table = New Table(pointColumnWidth).UseAllAvailableWidth()




        document.Add(New Paragraph("A continuacion se muestran los productos con bajo stock").SetTextAlignment(Properties.TextAlignment.LEFT))
        'HEADER CELL TABLE
        Dim cell1 = New Cell()
        cell1.Add("ID DE PRODUCTO")
        table.AddCell(cell1)
        cell1.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell1.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell1.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell2 = New Cell()
        cell2.Add("PRODUCTO")
        table.AddCell(cell2)
        cell2.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell2.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell2.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell3 = New Cell()
        cell3.Add("STOCK")
        table.AddCell(cell3)
        cell3.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell3.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell3.SetTextAlignment(Properties.TextAlignment.CENTER)


        Dim cell4 = New Cell()
        cell4.Add("PRECIO")
        table.AddCell(cell4)
        cell4.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell4.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell4.SetTextAlignment(Properties.TextAlignment.CENTER)


        Dim dataset As New DataSet
        Dim BsnProducto As New BsnProducto

        dataset = BsnProducto.ObtenerColumnasYProductosEspecificos("ID_PRODUCTO,NOMBRE,STOCK,PRECIO", " WHERE STOCK <= 100 AND FALSE_DELETE = 0") 'cambiar STOCK A STOCK <=STOCK_CRITICO

        For Each row In dataset.Tables(0).Rows
            For Each column In dataset.Tables(0).Columns
                table.AddCell(row(column))
            Next
        Next
        document.Add(table)
        document.Add(New Paragraph("Este documento a sido generado automaticamente por Ferreteria Alberdi").SetUnderline().SetTextAlignment(Properties.TextAlignment.CENTER))
        document.Close()
        MsgBox("Documento generado correctamente", vbInformation, "PDF Generado")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim destino As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim writer = New PdfWriter(destino & "\test.pdf")
        Dim pdfDoc = New PdfDocument(writer)

        pdfDoc.AddNewPage()

        Dim document = New Document(pdfDoc)


        document.Add(New Paragraph("Clientes").SetUnderline().SetTextAlignment(Properties.TextAlignment.CENTER).SetWidthPercent(100))

        document.Add(New Paragraph("FECHA DE CREACION: " & iText.IO.Util.DateTimeUtil.GetCurrentTime).SetTextAlignment(Properties.TextAlignment.RIGHT))
        Dim pointColumnWidth() = {150.0F, 150.0F, 150.0F, 150.0F, 150.0F}
        Dim table = New Table(pointColumnWidth).UseAllAvailableWidth()




        document.Add(New Paragraph("A continuacion se muestran los clientes registrados").SetTextAlignment(Properties.TextAlignment.LEFT))
        'HEADER CELL TABLE
        Dim cell1 = New Cell()
        cell1.Add("RUT CLIENTE")
        table.AddCell(cell1)
        cell1.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell1.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell1.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell2 = New Cell()
        cell2.Add("APELLIDO PATERNO")
        table.AddCell(cell2)
        cell2.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell2.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell2.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell3 = New Cell()
        cell3.Add("APELLIDO MATERNO")
        table.AddCell(cell3)
        cell3.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell3.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell3.SetTextAlignment(Properties.TextAlignment.CENTER)


        Dim cell4 = New Cell()
        cell4.Add("NOMBRES")
        table.AddCell(cell4)
        cell4.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell4.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell4.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell5 = New Cell()
        cell5.Add("DESCUENTO")
        table.AddCell(cell5)
        cell5.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell5.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell5.SetTextAlignment(Properties.TextAlignment.CENTER)


        Dim dataset As New DataSet
        Dim instrucciones As New Instructions

        Dim tabla As String = "Clientes"

        dataset = instrucciones.Seleccionar("Clientes", "Rut_Cliente,Apellido_p,Apellido_m,Nombres,Descuento", " WHERE False_delete =0")


        For Each row In dataset.Tables(0).Rows
            For Each column In dataset.Tables(0).Columns

                table.AddCell(row(column))
            Next
        Next
        document.Add(table)
        document.Add(New Paragraph("Este documento a sido generado automaticamente por Ferreteria Alberdi").SetUnderline().SetTextAlignment(Properties.TextAlignment.CENTER))
        document.Close()
        MsgBox("Documento generado correctamente", vbInformation, "PDF Generado")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim destino As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Dim fecha = DateTime.Now().ToString("dd-MM-yyyy")

        Dim hora = DateTime.Now().Hour
        Dim minu = DateTime.Now().Minute
        Dim segun = DateTime.Now().Second

        Dim hora_min_seg As String = "[" & hora & minu & segun & "]"

        Dim writer = New PdfWriter(destino & "\" & fecha & hora_min_seg & ".pdf")
        Dim pdfDoc = New PdfDocument(writer)


        pdfDoc.AddNewPage()

        Dim Document = New Document(pdfDoc, iText.Kernel.Geom.PageSize.A4.Rotate())

        Document.Add(New Paragraph("Ventas").SetUnderline().SetTextAlignment(Properties.TextAlignment.CENTER).SetWidthPercent(100))


        document.Add(New Paragraph("FECHA DE CREACION: " & iText.IO.Util.DateTimeUtil.GetCurrentTime).SetTextAlignment(Properties.TextAlignment.RIGHT))
        Dim pointColumnWidth = {2.0F, 4.0F, 4.0F, 3.0F, 2.0F, 3.0F, 3.0F, 3.0F, 3.0F, 3.0F, 1.0F, 1.0F}
        Dim table = New Table(pointColumnWidth)




        document.Add(New Paragraph("A continuacion se muestran las ventas registradas").SetTextAlignment(Properties.TextAlignment.LEFT))
        'HEADER CELL TABLE
        Dim cell1 = New Cell()
        cell1.Add("Numero Venta")
        table.AddCell(cell1)
        cell1.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell1.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell1.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell2 = New Cell()
        cell2.Add("Rut Cliente")
        table.AddCell(cell2)
        cell2.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell2.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell2.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell3 = New Cell()
        cell3.Add("Fecha")
        table.AddCell(cell3)
        cell3.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell3.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell3.SetTextAlignment(Properties.TextAlignment.CENTER)


        Dim cell4 = New Cell()
        cell4.Add("Subtotal")
        table.AddCell(cell4)
        cell4.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell4.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell4.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell6 = New Cell()
        cell6.Add("Descuento")
        table.AddCell(cell6)
        cell6.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell6.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell6.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell7 = New Cell()
        cell7.Add("Total")
        table.AddCell(cell7)
        cell7.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell7.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell7.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell8 = New Cell()
        cell8.Add("Iva")
        table.AddCell(cell8)
        cell8.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell8.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell8.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell9 = New Cell()
        cell9.Add("Medio Pago")
        table.AddCell(cell9)
        cell9.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell9.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell9.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell10 = New Cell()
        cell10.Add("Factura")
        table.AddCell(cell10)
        cell10.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell10.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell10.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell11 = New Cell()
        cell11.Add("Boleta")
        table.AddCell(cell11)
        cell11.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell11.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell11.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell12 = New Cell()
        cell12.Add("Nota credito")
        table.AddCell(cell12)
        cell12.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell12.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell12.SetTextAlignment(Properties.TextAlignment.CENTER)

        Dim cell13 = New Cell()
        cell13.Add("Nota debito")
        table.AddCell(cell13)
        cell13.SetBackgroundColor(iText.Kernel.Colors.Color.BLACK)
        cell13.SetFontColor(iText.Kernel.Colors.Color.WHITE)
        cell13.SetTextAlignment(Properties.TextAlignment.CENTER)


        Dim dataset As New DataSet
        Dim instrucciones As New Instructions

        dataset = instrucciones.Seleccionar("Ventas", "Num_venta,Rut_cliente,Fecha,Subtotal,Descuento,Total,Iva,medio_pago,factura,boleta,nota_credito,nota_debito", "")


        For Each row In dataset.Tables(0).Rows
            For Each column In dataset.Tables(0).Columns

                table.AddCell(row(column))
            Next
        Next
        document.Add(table)
        document.Add(New Paragraph("Este documento a sido generado automaticamente por Ferreteria Alberdi").SetUnderline().SetTextAlignment(Properties.TextAlignment.CENTER))
        document.Close()
        MsgBox("Documento generado correctamente", vbInformation, "PDF Generado")
    End Sub
End Class


