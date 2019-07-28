Public Class Validacionesv2

    'QUE RETORNE UN BOOLEAN Y UN STRING EN UN LIST (BOOLEAN,STINGS)
    'BOOLEAN PARA EL CONTROL 
    'STRING CON LA INDICACION DEL ERROR
    'PARA IMPLEMENTAR IDEALMENTE :
    '   DIM RECEPTOR AS LIST = VALIDACION.FUNCTION()
    '   KEY AS BOOLEAN = RECEPTOR(0)
    '   ADVERTENCIA AS STRINGS = RECEPTOR(1)
    '   If KEY then:
    '       'lo que procede
    '   elseif not key 
    'msg(advertencia)

    'largo
    Dim msg_default As String = "El campo "
    Dim bol As Boolean = True

    Dim Num As New Enumeraciones
    'DEFINAMOS LOS MAXIMOS
    Public Function MaxRut()
        Return Num.LimiteMax("rut")
    End Function
    Public Function MaxRutVerificador()
        Return Num.LimiteMax("digito verificador")
    End Function
    Public Function MaxPassword()
        Return Num.LimiteMax("password")
    End Function
    Public Function MaxNombrePersona()
        Return Num.LimiteMax("nombre persona")
    End Function
    Public Function MaxApellido()
        Return Num.LimiteMax("apellido")
    End Function
    Public Function MaxTelefonoF()
        Return Num.LimiteMax("telefono fijo")
    End Function
    Public Function MaxTelefonoC()
        Return Num.LimiteMax("telefono celular")
    End Function
    Public Function MaxEmail()
        Return Num.LimiteMax("email")
    End Function
    Public Function MaxDireccion()
        Return Num.LimiteMax("direccion")
    End Function
    Public Function MaxNumVenta()
        Return Num.LimiteMax("numero de venta")
    End Function
    Public Function MaxPrecio()
        Return Num.LimiteMax("precio")
    End Function
    Public Function MaxNumFolio()
        Return Num.LimiteMax("numero de folio")
    End Function
    Public Function MaxOtroNombre()
        Return Num.LimiteMax("nombre")
    End Function
    Public Function MaxCodProducto()
        Return Num.LimiteMax("codigo producto")
    End Function
    Public Function MaxStock()
        Return Num.LimiteMax("stock")
    End Function
    Public Function MaxStockCritico()
        Return Num.LimiteMax("stock critico")
    End Function



    'TIPO DE STRING
    Public Function IRut(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True
        End If
        Return bol
    End Function
    Public Function IRutVerificador(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = "K" Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function IPassword(e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function INombrePersona(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function IApellido(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function ITelefonoF(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function ITelefonoC(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function IEmail(e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function IDireccion(e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function INumVenta(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function IPrecio(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function INumFolio(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function

    Public Function IOtroNombre(e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = "+" Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function ICodProducto(e As KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function IStock(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function
    Public Function IStockCritico(e As KeyPressEventArgs)
        If IsNumeric(e.KeyChar) Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Then ' ---> 
            bol = False
        Else
            bol = True

        End If
        Return bol
    End Function


    'VALIDACIONES AL ACEPTAR

    Public Function Val(lista As List(Of String()))
        Dim cumple As Boolean = True
        Dim aviso As String = ""
        For i = 0 To lista.Count - 1
            'Primero que no este en blanco
            If lista(i)(1).Equals("") Then
                cumple = False
                aviso = "HAY ELEMENTOS VACIOS POR FAVOR LLENAR TODOS LOS CAMPOS"
            Else
                'Que cumplan con lo minimo establecido
                If Not lista(i)(1).Length >= Num.LimiteMin(lista(i)(0)) Then
                    cumple = False
                    aviso = aviso + msg_default + lista(i)(0) + " debe tener al menos " & Num.LimiteMin(lista(i)(0))

                End If
            End If
        Next

        Return {cumple, aviso}
    End Function

    Public Function ValidarRut(rut As String, dv As String)
        Dim persona As New Persona
        Dim correcto As Boolean = persona.validarRut(rut, dv)
        Return correcto
    End Function

End Class
