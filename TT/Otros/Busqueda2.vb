Public Class Busqueda2
    Private _pattern As String

    Property Pattern()
        Get
            Return _pattern
        End Get
        Set(value)
            _pattern = value
            StructurePattern()
        End Set
    End Property

    Private Sub StructurePattern()
        _pattern = _pattern.ToLower()
        Dim newPattern As String = ""
        ''recorrer la palabra 
        For i = 0 To _pattern.Length - 1
            If _pattern(i) Like "*[aáeéiíoóuú]" Then ' ------------> funciona
                'MsgBox("Sr se encontro coincidencia = " & _pattern(i))
                'las opciones en las vocales dar la opción con el acento ej o -> [oó]
                If _pattern(i) Like "*[aá]" Then
                    newPattern = newPattern + "[aá]"
                End If
                If _pattern(i) Like "*[eé]" Then
                    newPattern = newPattern + "[eé]"
                End If
                If _pattern(i) Like "*[ií]" Then
                    newPattern = newPattern + "[ií]"
                End If
                If _pattern(i) Like "*[oó]" Then
                    newPattern = newPattern + "[oó]"
                End If
                If _pattern(i) Like "*[uú]" Then
                    newPattern = newPattern + "[uú]"
                End If
            Else
                newPattern = newPattern + _pattern(i)
            End If
        Next

        'guardar el nuevo _pattern 
        _pattern = "'%" + newPattern + "%'"
        'MsgBox("RESULTADO: " & newPattern)

    End Sub


    Public Function RealizarBusqueda(tabla As String, campo As String)
        Dim dataset As New DataSet
        Dim instruccion As New Instructions
        Try
            dataset = instruccion.Seleccionar(tabla, "*", " where " & campo & " like " + _pattern)
            MsgBox("LA BÚSQUEDA ARROJO " & dataset.Tables(0).Rows.Count & " RESULTADOS")
        Catch ex As Exception
            MsgBox("LA BÚSQUEDA NO ARROJO RESULTADOS")
        End Try

        Return dataset

    End Function


End Class
