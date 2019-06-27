Imports System.ComponentModel

Public Class PrincipalForm
    Protected _aux As String
    Protected _callLog As Boolean = False

    Private _usuario As New Usuario

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
        Dim formVenta As New frmVenta
        formVenta.RecibirUsuario(_usuario)
        formVenta.ShowDialog()
    End Sub


    Private Sub PRODUCTOSToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem2.Click
        Dim formproducto As New frmProd2
        formproducto.RecibirUsuario(_usuario)
        formproducto.ShowDialog()


    End Sub

    Private Sub CATEGORIASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CATEGORIASToolStripMenuItem1.Click
        Dim formcategoria As New FrmCate
        formcategoria.RecibirUsuario(_usuario)
        formcategoria.ShowDialog()

        'Dim formcategoria As New cather
        'formcategoria.RecibirUsuario(usuario)
        'formcategoria.ShowDialog()
    End Sub

    Private Sub PROVEEDORESToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PROVEEDORESToolStripMenuItem2.Click
        Dim FrmProveedores As New FrmProvee
        FrmProveedores.RecibirUsuario(_usuario)
        FrmProveedores.ShowDialog()
    End Sub

    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click
        Dim FrmUsuario As New FrmUsers
        FrmUsuario.RecibirUsuario(_usuario)
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click
        Dim FrmTransacciones As New FrmHistoVenta
        FrmTransacciones.ShowDialog()
    End Sub

    Private Sub DESCUENTOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESCUENTOSToolStripMenuItem1.Click
        Dim formdescuento As New FrmDesc
        formdescuento.RecibirUsuario(_usuario)
        formdescuento.ShowDialog()
    End Sub

    Private Sub CLIENTESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CLIENTESToolStripMenuItem.Click

        Dim formClientes As New FrmClientes

        formClientes.ShowDialog()
    End Sub

    Private Sub EMPLEADOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EMPLEADOSToolStripMenuItem1.Click
        Dim formEmpleados As New FrmEmpleados

        formEmpleados.ShowDialog()
    End Sub

    Private Sub Principal_Help_Click(sender As Object, e As EventArgs) Handles Principal_Help.Click
        Dim formAcerca As New FrmAcerca

        formAcerca.ShowDialog()
    End Sub

    Private Sub COMPRASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPRASToolStripMenuItem.Click
        Dim formHistoCompras As New FrmHistoCompra

        formHistoCompras.ShowDialog()
    End Sub

    Private Sub AJUSTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AJUSTESToolStripMenuItem.Click
        Dim formHistoAjustes As New FrmHistoAjustes

        formHistoAjustes.ShowDialog()
    End Sub

    Private Sub Principal_Estadisticas_Click(sender As Object, e As EventArgs) Handles Principal_Estadisticas.Click
        Dim formEstadistica As New FrmStadict

        formEstadistica.ShowDialog()
    End Sub

    Private Sub Principal_Compra_Click(sender As Object, e As EventArgs) Handles Principal_Compra.Click
        Dim formCompra As New FrmCompra

        formCompra.ShowDialog()
    End Sub

    Private Sub BOLETAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOLETAToolStripMenuItem.Click
        Dim formBoleta As New FrmBoleta

        formBoleta.ShowDialog()
    End Sub

    Private Sub FACTURAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURAToolStripMenuItem.Click
        Dim formFacura As New FrmFactura
        formFacura.ShowDialog()
    End Sub

    Private Sub NOTACREDITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTACREDITOToolStripMenuItem.Click
        Dim formNotaCredito As New FrmNotaCredito
        formNotaCredito.ShowDialog()
    End Sub

    Private Sub NOTADEBITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTADEBITOToolStripMenuItem.Click
        Dim formNotaDebito As New FrmNotaDebito
        formNotaDebito.ShowDialog()
    End Sub

    Private Sub BtnResetCat_Click(sender As Object, e As EventArgs) Handles BtnResetCat.Click

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
    End Sub
End Class
