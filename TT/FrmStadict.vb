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
        cha.Titles(0).Font = New Font("Tahoma", 15, FontStyle.Bold)
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
End Class


