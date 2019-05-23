Imports TT

Public Class frmAgreCliente
    Dim Cliente As New Cliente
    Dim BsnCliente As New BsnCliente
    Dim DaoCliente As New DaoCliente

    Dim Empleado As New Empleado
    Dim BsnEmpleado As New BsnEmpleado
    Dim DaoEmpleado As New DaoEmpleado

    Dim Validaciones As New Validaciones


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'EVENTO AL AGREGAR UN USUARIO
        If Label5.Text.Equals("AGREGAR CLIENTE") Then 'Si el label indica agregar usuario

            If txtRutSnDV.Text = "" Or txtDV.Text = "" Or txtNombres.Text = "" Then
                MsgBox("Por favor complete los campos: RUT, DIGITO VERIFICADOR Y NOMBRE...", vbCritical)
            Else
                If Not Cliente.validarRut(txtRutSnDV.Text, txtDV.Text) Then
                    MsgBox("El RUT ingresado NO ES CORRECTO")
                Else
                    'Seteando el objeto clientes con sus caracteristicas
                    Cliente.Rut = txtRutSnDV.Text
                    Cliente.Nombres = txtNombres.Text
                    Cliente.ApelidoPaterno = txtApellidoP.Text
                    Cliente.ApellidoMaterno = txtApellidoM.Text
                    Cliente.Descuento = tbDescuento.Value

                    BsnCliente.agregarCliente(Cliente)

                End If
            End If


        ElseIf (Label5.Text.Equals("EDITAR CLIENTE")) Then 'si el label indica editar usuario
            MsgBox("editar")
            If txtRutSnDV.Text = "" Or txtDV.Text = "" Or txtNombres.Text = "" Or txtApellidoP.Text = "" Or txtApellidoM.Text = "" Or tbDescuento.Value = 0 Then
                MsgBox("Por favor complete los campos requeridos: Nombre...", vbCritical)
            Else

                Cliente.Rut = txtRutSnDV.Text
                Cliente.Nombres = txtNombres.Text
                Cliente.ApelidoPaterno = txtApellidoP.Text
                Cliente.ApellidoMaterno = txtApellidoM.Text
                Cliente.Descuento = tbDescuento.Value

                BsnCliente.editarCliente(Cliente)
            End If
        End If

        If (Label5.Text.Equals("AGREGAR EMPLEADO")) Then

            If txtRutSnDV.Text = "" Or txtDV.Text = "" Or txtNombres.Text = "" Or txtApellidoP.Text = "" Or txtApellidoM.Text = "" Or tbDescuento.Value = 0 Then
                MsgBox("Por favor complete los campos requeridos: RUT, DIGITO VERIFICADOR...", vbCritical)
            Else
                If Not Empleado.validarRut(txtRutSnDV.Text, txtDV.Text) Then
                    MsgBox("El RUT ingresado NO ES CORRECTO")
                Else
                    'Seteando el objeto clientes con sus caracteristicas
                    Empleado.Rut = txtRutSnDV.Text
                    Empleado.Nombres = txtNombres.Text
                    Empleado.ApelidoPaterno = txtApellidoP.Text
                    Empleado.ApellidoMaterno = txtApellidoM.Text

                    MsgBox("Usuario agregado correctamente", vbInformation)

                End If
            End If


        Else
            If (Label5.Text.Equals("EDITAR EMPLEADO")) Then

                Empleado.Rut = txtRutSnDV.Text
                Empleado.Nombres = txtNombres.Text
                Empleado.ApelidoPaterno = txtApellidoP.Text
                Empleado.ApellidoMaterno = txtApellidoM.Text

                BsnEmpleado.editarEmpleado(Empleado)

                MsgBox("Usuario editado correctamente", vbInformation)


            End If

        End If

    End Sub




















    Private Sub tbDescuento_Scroll(sender As Object, e As EventArgs) Handles tbDescuento.Scroll
        lblDescuento.Text = "DESCUENTO: " & tbDescuento.Value & " %"
    End Sub
    Private Sub soloLetras(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        Dim largo As Byte = txtNombres.Text.Length
        Dim condicion As Byte = 10
        If Not Validaciones.soloLetras(largo, e, 10) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtApellidoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoP.KeyPress
        Dim largo As Byte = txtApellidoP.Text.Length
        Dim condicion As Byte = 10
        If Not Validaciones.soloLetras(largo, e, 10) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtApellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoM.KeyPress
        Dim largo As Byte = txtApellidoM.Text.Length
        Dim condicion As Byte = 10
        If Not Validaciones.soloLetras(largo, e, 10) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtRutSnDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDV.KeyPress
        Dim largo As Byte = txtRutSnDV.Text.Length
        Dim condicion As Byte = 8
        If Not Validaciones.soloNumeros(largo, e, condicion) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim largo As Byte = txtRutSnDV.Text.Length
        Dim condicion As Byte = 1
        If Not Validaciones.numerosYLetras(largo, e, condicion) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()      'salir del programa
    End Sub
    Private Sub frmAgreCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class
