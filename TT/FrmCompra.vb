Public Class FrmCompra
    Dim validacion As New Validacionesv2
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
        txtCant.MaxLength = validacion.MaxStock
        txtPrecio = validacion.MaxPrecio
        txtSubTotal = validacion.MaxPrecio



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

    Private Sub txtCant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCant.KeyPress
        e.Handled = validacion.IStock(e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.Handled = validacion.IPrecio(e)
    End Sub

    Private Sub txtSubTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubTotal.KeyPress
        e.Handled = validacion.IPrecio(e)
    End Sub
End Class
