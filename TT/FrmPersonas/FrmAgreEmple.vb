Public Class frmAgreEmple

    Dim Empleado As New Empleado
    Dim instrucciones As New Instructions
    Dim BsnEmpleado As New BsnEmpleado
    Dim Validaciones As New Validaciones
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (Label5.Text.Equals("AGREGAR EMPLEADO")) Then 'AGREGANDO EL EMPLEADO
            If txtRutSnDV.Text = "" Or txtNombres.Text = "" Then
                MsgBox("Por favor complete los campos")
            Else
                If Not (Empleado.validarRut(txtRutSnDV.Text, txtDV.Text)) Then
                    MsgBox("El RUT ingresado no es valido")
                Else
                    Empleado.Rut = txtRutSnDV.Text
                    Empleado.Nombres = txtNombres.Text

                    If Empleado.ApelidoPaterno = "" Then
                        Empleado.ApelidoPaterno = String.Empty
                    Else
                        Empleado.ApelidoPaterno = txtApellidoP.Text
                    End If


                    If Empleado.ApellidoMaterno = "" Then
                        Empleado.ApellidoMaterno = String.Empty
                    Else
                        Empleado.ApellidoMaterno = txtApellidoM.Text
                    End If

                    If Empleado.TelefonoFijo = "" Then
                        Empleado.TelefonoFijo = String.Empty
                    Else
                        Empleado.TelefonoFijo = txtFono.Text
                    End If

                    If Empleado.TelefonoCelular = "" Then
                        Empleado.TelefonoCelular = String.Empty
                    Else
                        Empleado.TelefonoCelular = txtCelular.Text
                    End If

                    BsnEmpleado.agregarEmpleado(Empleado)
                End If
            End If
        Else
            If (Label5.Text.Equals("EDITAR EMPLEADO")) Then

                Empleado.Rut = txtRutSnDV.Text
                If txtNombres.Text = "" Then
                    MsgBox("Por favor, complete el nombre...")
                Else
                    Empleado.Nombres = txtNombres.Text

                    If Empleado.ApelidoPaterno = "" Then
                        Empleado.ApelidoPaterno = String.Empty
                    Else
                        Empleado.ApelidoPaterno = txtApellidoP.Text
                    End If

                    If Empleado.ApelidoPaterno = "" Then
                        Empleado.ApelidoPaterno = String.Empty
                    Else
                        Empleado.ApelidoPaterno = txtApellidoP.Text
                    End If


                    If Empleado.ApellidoMaterno = "" Then
                        Empleado.ApellidoMaterno = String.Empty
                    Else
                        Empleado.ApellidoMaterno = txtApellidoM.Text
                    End If

                    If Empleado.TelefonoFijo = "" Then
                        Empleado.TelefonoFijo = String.Empty
                    Else
                        Empleado.TelefonoFijo = txtFono.Text
                    End If

                    If Empleado.TelefonoCelular = "" Then
                        Empleado.TelefonoCelular = String.Empty
                    Else
                        Empleado.TelefonoCelular = txtCelular.Text
                    End If

                    BsnEmpleado.editarEmpleado(Empleado)

                End If


            End If


        End If
    End Sub



    Private Sub txtApellidoM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoM.KeyPress
        Dim largo As Integer = txtApellidoM.Text.Length
        Dim condicion As Byte = 10

        If Not (Validaciones.soloLetras(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDV.KeyPress
        Dim largo As Integer = txtDV.Text.Length
        Dim condicion As Byte = 1

        If Not (Validaciones.numerosYLetras(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
        Dim largo As Integer = txtNombres.Text.Length
        Dim condicion As Byte = 10

        If Not (Validaciones.soloLetras(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellidoP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidoP.KeyPress
        Dim largo As Integer = txtApellidoP.Text.Length
        Dim condicion As Byte = 10

        If Not (Validaciones.soloLetras(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRutSnDV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRutSnDV.KeyPress
        Dim largo As Integer = txtRutSnDV.Text.Length
        Dim condicion As Byte = 10

        If Not (Validaciones.soloNumeros(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFono.KeyPress
        Dim largo As Integer = txtFono.Text.Length
        Dim condicion As Byte = 10

        If Not (Validaciones.numerosYLetras(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress
        Dim largo As Integer = txtCelular.Text.Length
        Dim condicion As Byte = 10
        If Not (Validaciones.numerosYLetras(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub


End Class