Public Class Persona
    Protected _rut As String
    Protected _dv As Char
    Protected _nombres As String
    Protected _apellidoPaterno As String
    Protected _apellidoMaterno As String
    Protected _telefonoFijo As String
    Protected _telefonoCelular As String
    Protected _email As String
    Protected _direccion As String


    Public Property Rut()
        Get
            Return _rut
        End Get
        Set(value)
            _rut = value
        End Set
    End Property

    Public Property DV()
        Get
            Return _dv
        End Get
        Set(value)
            _dv = value '# podría llamar a funcion de calculo
        End Set
    End Property

    Public Property Nombres
        Get
            Return _nombres
        End Get
        Set(value)
            _nombres = value
        End Set
    End Property
    Public Property ApelidoPaterno
        Get
            Return _apellidoPaterno
        End Get
        Set(value)
            _apellidoPaterno = value
        End Set
    End Property
    Public Property ApellidoMaterno
        Get
            Return _apellidoMaterno
        End Get
        Set(value)
            _apellidoMaterno = value
        End Set
    End Property
    Public Property TelefonoFijo
        Get
            Return _telefonoFijo
        End Get
        Set(value)

            _telefonoFijo = value
        End Set
    End Property
    Public Property TelefonoCelular
        Get
            Return _telefonoCelular
        End Get
        Set(value)
            _telefonoCelular = value
        End Set
    End Property
    Public Property Email
        Get
            Return _email
        End Get
        Set(value)
            _email = value
        End Set
    End Property
    Public Property Direccion
        Get
            Return _direccion
        End Get
        Set(value)
            _direccion = value
        End Set
    End Property


    Public Function validarRut(rut As String, dv As Char)
        dv = dv.ToString.ToUpper
        Dim correcto As Boolean = False

        Dim sum As Short
        Dim secuencia As Byte = 2

        Dim dig_rut As Byte
        Dim resto As Short
        Dim dv2 As Char

        For index = rut.Trim.Length() - 1 To 0 Step -1
            dig_rut = Char.GetNumericValue(rut.ElementAt(index)) * secuencia

            If secuencia = 7 Then
                secuencia = 2
            Else
                secuencia = secuencia + 1
            End If
            sum = sum + dig_rut
        Next
        MsgBox(sum)
        resto = sum Mod 11
        resto = 11 - resto

        MsgBox(resto)
        If resto = 10 Then
            dv2 = "K"
        Else
            If resto = 11 Then
                dv2 = "0"
            Else
                dv2 = resto.ToString
            End If
        End If

        MsgBox(dv2)

        If dv2.Equals(dv) Then
            correcto = True
        Else
            correcto = False
        End If
        Return correcto
    End Function
    Public Function obtenerDV(rut As String)
        Dim sum As Short
        Dim secuencia As Byte = 2

        Dim dig_rut As Byte
        Dim resto As Short
        Dim dv2 As Char
        For index = rut.Trim.Length() - 1 To 0 Step -1
            dig_rut = Char.GetNumericValue(rut.ElementAt(index)) * secuencia
            If secuencia = 7 Then
                secuencia = 2
            Else
                secuencia = secuencia + 1
            End If
            sum = sum + dig_rut
        Next
        resto = sum Mod 11
        resto = 11 - resto
        If resto = 10 Then
            dv2 = "K"
        Else
            If resto = 11 Then
                dv2 = "0"
            Else
                dv2 = resto.ToString
            End If
        End If
        'MsgBox("dv2 comprobando: " & dv2)
        Return dv2
    End Function
End Class
