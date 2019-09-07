Imports System.ComponentModel
Imports System.IO

Public Class PrincipalForm

    Protected _aux As String
    Protected _callLog As Boolean = False
    Private fileStock As String
    Dim limCaracter As Short = 0
    Private ciclo As Short = 0
    Private ciclop As Short = 0
    Dim nlimp As Integer = 0
    Dim key As Boolean = True
    'Dim nlimp As Integer = 0

    Private _usuario As New Usuario
    Private _alto, _ancho, _posicionX, _posicionY As Integer

    Public Sub RecibirUsuario(objeto As Usuario)
        MsgBox("")
        _usuario = objeto
        'MsgBox("ID: " & _empleado.IdUsuario)
        'MsgBox("RUT: " & _empleado.Rut)
        'MsgBox("PERMISO: " & _empleado.Permisos)
        'MsgBox("NOMBRE: " & _empleado.Nombres)
        'MsgBox("APELLIDO: " & _empleado.ApellidoMaterno)
        'MsgBox("APELLIDO: " & _empleado.ApellidoMaterno)




    End Sub
    Public Sub DoCall()
        _callLog = True
    End Sub

    Public Property Aux()
        Get
            Return ""
        End Get
        Set(value)
            _aux = value
        End Set
    End Property





    Private Sub PrincipalForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        '#Pedir Confirmacion
        Dim Msg, Style, Title, Response
        Msg = "¿Desea cerrar sesión?"                 ' Define mensaje del recuadro.
        Style = vbYesNo + vbQuestion + vbDefaultButton1    ' Define botones de la ventana.               
        Title = ""
        ' Ventana
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' Usuario elige si
            Dim formlogeo As New FrmIngreso
            formlogeo.Show()
            Me.Dispose()

        End If

    End Sub

    Private Sub Principal_Venta_Click(sender As Object, e As EventArgs) Handles Principal_Venta.Click
        Dim form As New frmVenta
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub
    Private Sub AJUSTESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AJUSTESToolStripMenuItem1.Click
        Dim form As New FrmAjustes
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub
    Private Sub PRODUCTOSToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem2.Click
        Dim form As New frmProd2
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()


    End Sub

    Private Sub CATEGORIASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CATEGORIASToolStripMenuItem1.Click
        Dim form As New FrmCate3
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub PROVEEDORESToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PROVEEDORESToolStripMenuItem2.Click
        Dim form As New FrmProvee
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click
        Dim form As New FrmUsers
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click
        Dim form As New FrmHistoVenta
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub DESCUENTOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESCUENTOSToolStripMenuItem1.Click
        Dim form As New FrmDesc
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub CLIENTESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click

        Dim form As New FrmClientes
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub EMPLEADOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EMPLEADOSToolStripMenuItem1.Click
        Dim form As New FrmEmpleados
        form.RecibirUsuario(_usuario)
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub Principal_Help_Click(sender As Object, e As EventArgs) Handles Principal_Help.Click
        Dim form As New FrmAcerca
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub COMPRASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRASToolStripMenuItem.Click
        Dim form As New FrmHistoCompra
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub AJUSTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AJUSTESToolStripMenuItem.Click
        Dim form As New FrmHistoAjustes
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub Principal_Estadisticas_Click(sender As Object, e As EventArgs) Handles Principal_Estadisticas.Click
        Dim form As New FrmStadict
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub Principal_Compra_Click(sender As Object, e As EventArgs) Handles Principal_Compra.Click
        Dim form As New FrmCompra
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub BOLETAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOLETAToolStripMenuItem.Click
        Dim form As New FrmBoleta
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub FACTURAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURAToolStripMenuItem.Click
        Dim form As New FrmFactura
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub NOTACREDITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTACREDITOToolStripMenuItem.Click
        Dim form As New FrmNotaCredito
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub NOTADEBITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTADEBITOToolStripMenuItem.Click
        Dim form As New FrmNotaDebito
        form.Dimencion_Locacion(_alto, _ancho, _posicionX, _posicionY)
        form.ShowDialog()
    End Sub

    Private Sub BtnResetCat_Click(sender As Object, e As EventArgs)

        Dim DD As New DefaultData
        DD.EstablecerCategorias()
    End Sub

    Private Sub BloquearTodo()
        Principal_Compra.Enabled = False
        Principal_Productos.Enabled = False
        PRODUCTOSToolStripMenuItem2.Enabled = False
        CATEGORIASToolStripMenuItem1.Enabled = False
        DESCUENTOSToolStripMenuItem1.Enabled = False
        Principal_Personas.Enabled = False
        USUARIOSToolStripMenuItem.Enabled = False
        EMPLEADOSToolStripMenuItem1.Enabled = False
        CLIENTESToolStripMenuItem.Enabled = False
        PROVEEDORESToolStripMenuItem2.Enabled = False
        Principal_Estadisticas.Enabled = False
        Principal_Documentos.Enabled = False
        Principal_Historial.Enabled = False
        Principal_Help.Enabled = False


    End Sub

    Private Sub Permisos()
        Dim permiso As New Permisos
        Principal_Compra.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "COMPRA", "")
        Principal_Productos.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PRODUCTOS", "")
        PRODUCTOSToolStripMenuItem2.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PRODUCTOS", "PRODUCTOS")
        CATEGORIASToolStripMenuItem1.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PRODUCTOS", "CATEGORIAS")
        DESCUENTOSToolStripMenuItem1.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PRODUCTOS", "DESCUENTOS")
        Principal_Personas.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PERSONAS", "")
        USUARIOSToolStripMenuItem.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PERSONAS", "USUARIOS")
        EMPLEADOSToolStripMenuItem1.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PERSONAS", "EMPLEADOS")
        CLIENTESToolStripMenuItem.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PERSONAS", "CLIENTES")
        PROVEEDORESToolStripMenuItem2.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "PERSONAS", "PROVEEDORES")
        Principal_Estadisticas.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "ESTADISTICAS", "")
        Principal_Documentos.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "DOCUMENTOS", "")
        Principal_Historial.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "HISTORIAL", "")
        Principal_Help.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PRINCIPAL", "HELPCENTER", "")
    End Sub

    Private Sub PrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BloquearTodo()
        Permisos()
        Dim archivo As New Archivos
        Dim bsnproducto As New BsnProducto
        archivo.ActualizacionStockCritico(bsnproducto.ObtenerStockCritico())

        fileStock = OpenFile()
        TimerStock.Enabled = True
        TmrArchivo.Enabled = True

        Dimencion() '--> OBTENEMOS DIMENCION RELACION RESOLUCION

    End Sub

    Private Sub TimerStock_Tick(sender As Object, e As EventArgs) Handles TimerStock.Tick
        'obtener maximo de caractereres
        Dim x = Math.Truncate(lbl_EstadoStock.Width / 7.04) - 1

        ciclop = ciclop + 1


        If fileStock.Length <> 0 Then
            If ciclo < fileStock.Length Then


                lbl_EstadoStock.Text = lbl_EstadoStock.Text + fileStock.Substring(ciclo, 1)
                ciclo = ciclo + 1

            Else
                'limpiar 
                lbl_EstadoStock.Text = lbl_EstadoStock.Text + " "
                nlimp = nlimp + 1



            End If


        End If


        If lbl_EstadoStock.Text.Length > x Then
            If lbl_EstadoStock.Text.Length <> 0 Then
                lbl_EstadoStock.Text = lbl_EstadoStock.Text.Substring(1)
            End If

        End If


        If nlimp > x Then
            ciclo = 0
            nlimp = 0
            lbl_EstadoStock.Text = ""
            fileStock = OpenFile()




        End If


        TimerStock.Start()



    End Sub



    Private Function OpenFile()
        Dim folderPath = My.Computer.FileSystem.SpecialDirectories.Desktop + "\TrabajoTitulo3.0\Files\StockCritico.txt"
        Dim archivo As New StreamReader(folderPath)
        Dim mensaje = archivo.ReadToEnd
        archivo.Close()
        Return mensaje
    End Function

    Private Sub TmrArchivo_Tick(sender As Object, e As EventArgs) Handles TmrArchivo.Tick
        Dim archivo As New Archivos
        Dim bsnproducto As New BsnProducto
        archivo.ActualizacionStockCritico(bsnproducto.ObtenerStockCritico())
    End Sub
    Private Sub Dimencion()
        Dim h, w, x, y As Integer
        Dim c As String
        'Alto y Ancho
        h = PictureBox1.Height
        w = PictureBox1.Width


        'Locacion
        c = PictureBox1.Location.ToString  'c cadena formato : {x=nn,y=nn}
        Dim posicion_aux = InStr(1, c, "=") 'primera posicion del =
        x = c.Substring(posicion_aux, (InStr(1, c, ",") - posicion_aux - 1))
        'c = c.Substring()
        y = c.Substring(InStr(posicion_aux + 1, c, "="), c.Length - InStr(posicion_aux + 1, c, "=") - 1)

        _alto = h
        _ancho = w
        _posicionX = x
        _posicionY = y + lbl_EstadoStock.Height + 3


    End Sub
End Class
