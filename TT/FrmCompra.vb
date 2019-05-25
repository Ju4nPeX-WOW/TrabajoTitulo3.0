Public Class FrmCompra
    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub



    Private Sub escanearPro(ByVal nombreArchivo)
        'Al terminar el escaneo se generara un pdf, no un tif
        Dim fileName As String 'nombre del archivo que generaremos
        Dim N As Integer 'numero de escaneos seguidos que realizaremos, lo suyo es que sea 1, pero esto es a gusto del consumidor
        N = 1
        fileName = String.Format("C:\Users\kevin\Desktop\documentos\facturaCompra" + nombreArchivo + ".pdf", 1) 'ponemos la ruta, el nombre del archivo y el tipo de archivo (en este caso .pdf)
        Call EZTwain.LogFile(1)
        Call EZTwain.SetHideUI(1)


        If EZTwain.OpenDefaultSource() Then


            Call EZTwain.SelectFeeder(1) 'esta linea es la que define que es un escaner flatbed, para ponerlo ADF el 1 lo ponemos false (si no funciona ponganse en contacto conmigo)

            Call EZTwain.SetPixelType(2) 'yo escaneo en color (provad con otros numeros para ver otros tipos de escaneo, como el blanco-negro)


            Call EZTwain.SetBitDepth(1)

            Call EZTwain.SetResolution(300) 'resolucion de la imagen

            Call EZTwain.SetAutoScan(1) 'ESTA LINEA ES NUESTRA SALVADORA, ya que es la encargada de decirle al escaner que escanee y punto, sin mostrar ventanas adicionales ni nada, que escanee con los parametros que le hemos dado y ya esta

            Call EZTwain.SetRegion(0, 0, 10.1, 10.1) 'area que decidimos escanear 

            EZTwain.AcquireToFilename(Me.Handle, fileName) 'esta linea realiza el escaneo y la creacion del documento 
        End If
        If EZTwain.LastErrorCode() <> 0 Then
            Console.WriteLine(EZTwain.LastErrorCode())
            Call EZTwain.ReportLastError("Unable to scan.")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'escanearPro("prueba")
        Escaneapowea("compra1")

    End Sub

    Private Sub Escaneapowea(nombreArchivo As String)

        'Al terminar el escaneo se generara un pdf, no un tif
        Dim fileName As String 'nombre del archivo que generaremos

        fileName = String.Format("C:\Users\kevin\Desktop\TTV2\Trabajo Version 8\DOCUMENTOS\FACTURACOMPRA\" + nombreArchivo + ".pdf") 'ponemos la ruta, el nombre del archivo y el tipo de archivo (en este caso .pdf)
        'codigo 
        Call EZTwain.LogFile(1)
        'Call EZTwain.SetHideUI(1)
        'codigo 
        Call EZTwain.SetHideUI(False)
        Call EZTwain.SetIndicators(False)
        Call EZTwain.SetFileAppendFlag(False)

        If EZTwain.OpenSource("WIA-HP AIO Scanner") Then

            Call EZTwain.SetPixelType(0)     'yo escaneo en color (provad con otros numeros para ver otros tipos de escaneo, como el blanco-negro)
            Call EZTwain.SetBitDepth(1)
            Call EZTwain.SetResolution(150)  'resolucion de la imagen
            Call EZTwain.SetPaperSize(1)
            Call EZTwain.SetXferCount(1)
            Call EZTwain.SetAutoScan(1)      'ESTA LINEA ES NUESTRA SALVADORA, ya que es la encargada de decirle al escaner que escanee y punto, sin mostrar ventanas adicionales ni nada, que escanee con los parametros que le hemos dado y ya esta


            ' If you can't get a Window handle, use System.IntPtr.Zero:
            Call EZTwain.AcquireToFilename(Me.Handle, fileName) 'esta linea realiza el escaneo y la creacion del documento 
        End If
        If EZTwain.LastErrorCode() <> 0 Then
            Console.WriteLine(EZTwain.LastErrorCode())
            Call EZTwain.ReportLastError("Unable to scan.")
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
