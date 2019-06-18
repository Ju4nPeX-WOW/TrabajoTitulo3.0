Public Class Validaciones

    Protected _correcto As Boolean = True
    'c
    Public Function soloNumeros(largo As Byte, caracterIngresado As KeyPressEventArgs, condicion As Byte)
        If (largo < condicion) Then 'largo: equivale a los caracteres ingresados en "x" txtbox .length
            If ((caracterIngresado.KeyChar >= "0" And caracterIngresado.KeyChar <= "9") Or caracterIngresado.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then 'si ingresa un numero                
                _correcto = True
            Else                                                            'si ingresa una letra
                _correcto = False
            End If
        Else
            If (caracterIngresado.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then 'si presiona la tecla retroceso
                _correcto = True
            Else
                _correcto = False
            End If
        End If
        Return _correcto
    End Function


    Public Function soloLetras(largo As Byte, caracterIngresado As KeyPressEventArgs, condicion As Byte)
        If (largo < condicion) Then 'largo: equivale a los caracteres ingresados en "x" txtbox .length
            If (caracterIngresado.KeyChar >= "0" And caracterIngresado.KeyChar <= "9") Then
                _correcto = False
            Else
                _correcto = True
            End If
        Else
            If (caracterIngresado.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then 'si presiona la tecla retroceso
                _correcto = True
            Else
                _correcto = False
            End If
        End If
        Return _correcto
    End Function

    Public Function numerosYLetras(caractTxtLen As Byte, e As KeyPressEventArgs, condicion As Byte)
        'Acepta numeros y letras, pero la variable condicion es para especificar el maximo
        'que puede escribir el usuario en el textbox

        If (caractTxtLen > condicion) Then
            If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then 'si presiona la tecla retroceso
                _correcto = True
            Else
                _correcto = False
            End If
        Else
            _correcto = True
        End If
        Return _correcto
    End Function

    Public Function distintoACeroIndexCmb(index As Short)
        If (index = 0) Then
            _correcto = False
        Else
            _correcto = True
        End If
        Return _correcto
    End Function

    Public Function ConfirmarEliminacion()
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
        Return response
    End Function

    Public Function ConfirmarConContraseña()
        Dim solicitarPassword As New PasswordDialogBox
        Dim key = False
        solicitarPassword.ShowDialog()

        If solicitarPassword.Password.Equals("admin") Then
            key = True
        End If
        Return key
    End Function
End Class
