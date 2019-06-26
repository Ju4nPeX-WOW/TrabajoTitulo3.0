Public Class FrmCompra
    Dim validacion As New Validacionesv2
    Dim persona As New Persona
    Dim bsnproducto As New BsnProducto

    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Establecer nombre de archivo

        Dim nombreArchivo As String ' que sea numerosm y no admita espacios


        If (Not txtRutSnDV.Text.Equals("")) And (Not txtNumFolio.Text.Equals("")) Then
            nombreArchivo = txtRutSnDV.Text + "_" + txtNumFolio.Text
            EscanerPro(nombreArchivo)
        End If




    End Sub

    Private Sub EscanerPro(nombreArchivo As String)



        'Al terminar el escaneo se generara un pdf, no un tif
        Dim fileName As String 'nombre del archivo que generaremos 
        Dim nombre, ruta As String ' ruta del archivo
        nombre = nombreArchivo + ".pdf"
        ruta = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\DOCUMENTOS\FACTURACOMPRA\" + nombre

        fileName = String.Format(ruta) 'ponemos la ruta, el nombre del archivo y el tipo de archivo (en este caso .pdf)
        'codigo 
        Call EZTwain.LogFile(1)
        Call EZTwain.SetHideUI(1)
        'Call EZTwain.SetIndicators(False)
        'Call EZTwain.SetFileAppendFlag(False)

        If EZTwain.OpenDefaultSource() Then

            Call EZTwain.SetPixelType(1)     'yo escaneo en color (provad con otros numeros para ver otros tipos de escaneo, como el blanco-negro)
            Call EZTwain.SetBitDepth(1)
            Call EZTwain.SetResolution(150)  'resolucion de la imagen
            Call EZTwain.SetPaperSize(1)
            Call EZTwain.SetXferCount(1)
            Call EZTwain.SetAutoScan(1)      'ESTA LINEA ES NUESTRA SALVADORA, ya que es la encargada de decirle al escaner que escanee y punto, sin mostrar ventanas adicionales ni nada, que escanee con los parametros que le hemos dado y ya esta


            ' If you can't get a Window handle, use System.IntPtr.Zero:
            Call EZTwain.AcquireToFilename(Me.Handle, fileName) 'esta linea realiza el escaneo y la creacion del documento 
            txtArchivo.Text = nombre
        End If
        If EZTwain.LastErrorCode() <> 0 Then
            Console.WriteLine(EZTwain.LastErrorCode())
            Call EZTwain.ReportLastError("Unable to scan.")
        End If

    End Sub

    Private Sub FrmCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'establecer maximos
        txtNumFolio.MaxLength = validacion.MaxNumFolio
        txtRutSnDV.MaxLength = validacion.MaxRut
        txtDV.MaxLength = validacion.MaxRutVerificador
        txtIva.MaxLength = validacion.MaxPrecio
        txtTotal.MaxLength = validacion.MaxPrecio
        txtBuscar.MaxLength = validacion.MaxOtroNombre
        txtCant.MaxLength = validacion.MaxStock
        txtPrecio.MaxLength = validacion.MaxPrecio
        txtSubTotal.MaxLength = validacion.MaxPrecio


        Dim datasetProductos As DataSet = bsnproducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE")
        dgvBusqueda.DataSource = datasetProductos.Tables(0).DefaultView
    End Sub





    'VALIDACION AL MOMENTO DE INGRESAR
    Private Sub txtNumFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumFolio.KeyPress
        e.Handled = validacion.INumFolio(e)
    End Sub

    Private Sub txtRutSnDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDV.KeyPress
        e.Handled = validacion.IRut(e)
    End Sub

    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        e.Handled = validacion.IRutVerificador(e)
    End Sub

    Private Sub txtIva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIva.KeyPress
        e.Handled = validacion.IPrecio(e)
    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = validacion.IPrecio(e)
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
        e.Handled = validacion.IOtroNombre(e)
    End Sub
    Private Sub txtCant_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = validacion.IStock(e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = validacion.IPrecio(e)
    End Sub

    Private Sub txtSubTotal_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = validacion.IPrecio(e)
    End Sub
    Private Sub txtSubTotal_Click(sender As Object, e As EventArgs) Handles txtSubTotal.Click
        txtSubTotal.Text = (Integer.Parse(txtPrecio.Text) * Integer.Parse(txtCant.Text)).ToString
    End Sub


    'BOTON DE GUARDAR
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'DEBEMOS DE VALIDAR SI SE PROCEDE A REGISTRAR LA INFORMACION
        If RealizarValidacion() Then
            'GUARDAR DATOS

        End If
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE LOS CAMPOS NO ESTEN VACIOS
        Dim ListaText As New List(Of String())
        ListaText.Add({"numero de folio", txtNumFolio.Text})
        ListaText.Add({"rut", txtRutSnDV.Text})
        ListaText.Add({"digito verificador", txtDV.Text})
        ListaText.Add({"precio", txtIva.Text})
        ListaText.Add({"precio", txtTotal.Text})
        ListaText.Add({"nombre", txtBuscar.Text})
        ListaText.Add({"cantidad", txtCant.Text})
        ListaText.Add({"precio", txtPrecio.Text})
        ListaText.Add({"precio", txtSubTotal.Text})
        Dim receptor = validacion.Val(ListaText) '<- INGRESAR LISTA DE TXT BOX 
        If receptor(0) Then
            'VALIDAR QUE LOS CMD , SI EXISTEN U OTRO ELEMENTO CUMPLE CON LA VAL
            If Not txtArchivo.Text.Equals("") Or dgvProductosSeleccionados.RowCount <> 0 Then

                'VALIDAR QUE LOS DATOS CUMPLAN ESTRUTURA -> RUT O EMAIL
                If validacion.ValidarRut(txtRutSnDV.Text, txtDV.Text) Then '<- INGRESAR RUT Y DV
                    cumple = True
                Else
                    MsgBox("SR USUARIO EL RUT NO ES VALIDO")
                End If
            Else
                MsgBox("SR USUARIO FALTA QUE SELECCIONE LOS PRODUCTOS 
                        O QUE SUBA LA COPIA DE LA FACTURA          ")
            End If
        Else
            MsgBox(receptor(1))
        End If
        Return cumple
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscar.Text.Length > 0 Then
            Dim datasetIncremental As New DataSet
            datasetIncremental = bsnproducto.BusquedaIncremental("ID_PRODUCTO,NOMBRE", "Productos", "Nombre", txtBuscar.Text)
            dgvBusqueda.DataSource = datasetIncremental.Tables(0).DefaultView
        Else
            Dim datasetProductos As DataSet = bsnproducto.ObtenerColumnasEspecificas("ID_PRODUCTO,NOMBRE")
            dgvBusqueda.DataSource = datasetProductos.Tables(0).DefaultView

        End If
    End Sub

    Private Sub btnAgregar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnAgregar.MouseClick
        'Boton que lo que realiza es insertar el producto elegido en el datagridviewPRODUCTOS, hacia el datagridviewPRODUCTOSSELECCIONADOS.
        If dgvBusqueda.CurrentRow.Index > -1 And Not txtPrecio.Text.Equals("") And Not txtCant.Text.Equals("") And Not txtTotal.Text.Equals("") Then                                                                                                                                      'aqui iria el descuento raro
            'guardamos los datos del producto seleccionado en el primer datagridview en un arreglo fila() para luego insertarla en el segundo datagridview
            Dim fila() As String = {dgvBusqueda.Rows(dgvBusqueda.CurrentRow.Index).Cells(0).Value, dgvBusqueda.Rows(dgvBusqueda.CurrentRow.Index).Cells(1).Value, txtPrecio.Text, txtCant.Text, txtSubTotal.Text}
            Dim existe As Boolean = False
            If dgvProductosSeleccionados.Rows.Count > 0 Then
                For index = 0 To dgvProductosSeleccionados.Rows.Count - 1
                    If dgvProductosSeleccionados.Rows(index).Cells(1).Value.Equals(fila(1)) Then
                        dgvProductosSeleccionados.Rows(index).Cells(3).Value = (Integer.Parse(dgvProductosSeleccionados.Rows(index).Cells(3).Value) + Integer.Parse(fila(3))).ToString
                        existe = True
                    End If
                Next
                If existe = False Then
                    dgvProductosSeleccionados.Rows.Add(fila)
                End If

            Else
                'agregando el producto al segundo datagridview 
                dgvProductosSeleccionados.Rows.Add(fila)
            End If
        Else
            MsgBox("SR USUARIO COMPLETE LOS CAMPOS FALTANTES")

        End If
    End Sub






End Class
