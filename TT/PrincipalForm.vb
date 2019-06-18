Imports System.ComponentModel

Public Class PrincipalForm
    Protected usuario As Usuario
    Protected _aux As String
    Protected _callLog As Boolean = False

    Public Sub RecibirUsuario(objeto As Usuario)
        MsgBox("")
        usuario = objeto
        MsgBox("ID-USUARIO : " & usuario.IdUsuario)
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
        formVenta.ShowDialog()
    End Sub


    Private Sub PRODUCTOSToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem2.Click
        Dim formproducto As New frmProd2
        formproducto.RecibirUsuario(usuario)
        formproducto.ShowDialog()


    End Sub

    Private Sub CATEGORIASToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CATEGORIASToolStripMenuItem1.Click
        Dim formcategoria As New FrmCate
        'formcategoria.RecibirUsuario(usuario)
        formcategoria.ShowDialog()

        'Dim formcategoria As New cather
        'formcategoria.RecibirUsuario(usuario)
        'formcategoria.ShowDialog()
    End Sub

    Private Sub PROVEEDORESToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PROVEEDORESToolStripMenuItem2.Click
        Dim FrmProveedores As New FrmProvee
        FrmProveedores.ShowDialog()
    End Sub

    Private Sub USUARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles USUARIOSToolStripMenuItem.Click
        Dim FrmUsuario As New FrmUsers
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click
        Dim FrmTransacciones As New FrmHistoVenta
        FrmTransacciones.ShowDialog()
    End Sub

    Private Sub DESCUENTOSToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DESCUENTOSToolStripMenuItem1.Click
        Dim formdescuento As New FrmDesc
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
End Class
