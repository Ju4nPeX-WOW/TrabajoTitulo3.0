Imports System.ComponentModel

Public Class FrmIngreso
    Dim validacion As New Validacionesv2

    Dim Validaciones As New Validaciones()
    Dim bsnUsuario As New BsnUsuario


    Private Sub btnIngre_Click(sender As Object, e As EventArgs) Handles btnIngre.Click
        If Not (txtUsua.Text = "" Or txtContra.Text = "") Then
            If bsnUsuario.ValidarUsuario(txtUsua.Text, txtContra.Text) Then
                MsgBox("Ingreso Correcto")
                'Pienso que podría mandar la instancia de objeto del usuario para usar la info en el menu de opciones, y ver que opciones tiene el usuario
                Dim formprincipal As New PrincipalForm()
                formprincipal.RecibirUsuario(bsnUsuario.ObtenerUsuarioEmpleado(txtUsua.Text, txtContra.Text))


                Me.Hide()
                formprincipal.Show()
            Else
                MsgBox("Ingreso Incorrecto")
            End If
        Else
            MsgBox("Por favor rellene los campos vacios", vbOKOnly + vbInformation, "")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        '#Pedir Confirmacion
        Dim Msg, Style, Title, Response
        Msg = "¿Desea salir del programa?"                 ' Define mensaje del recuadro.
        Style = vbYesNo + vbQuestion + vbDefaultButton1    ' Define botones de la ventana.               
        Title = ""
        ' Ventana
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' Usuario elige si
            Application.Exit()
        End If
    End Sub

    Private Sub txtUsua_KeyPress(sender As Object, evento As KeyPressEventArgs) Handles txtUsua.KeyPress
        evento.Handled = validacion.MaxRut
    End Sub
    Private Sub txtContra_KeyPress(sender As Object, evento As KeyPressEventArgs) Handles txtContra.KeyPress
        evento.Handled = validacion.MaxPassword
    End Sub


End Class