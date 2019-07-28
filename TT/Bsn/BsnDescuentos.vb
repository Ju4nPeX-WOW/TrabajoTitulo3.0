Public Class BsnDescuentos
    Protected daoDescuentos As New DaoDescuentos

    Public Function ObtenerDescuentos()

        Return daoDescuentos.ObtenerDescuentos()
    End Function

    Public Sub AgregarDescuento(objeto As Descuento)
        daoDescuentos.AgregarDescuento(objeto)
    End Sub

    Public Sub ModificarDescuento(objeto As Descuento)
        daoDescuentos.ModificarDescuento(objeto)
    End Sub

    Public Function Condicion(Cod As String)
        Dim tipo, p1, p2 As String
        p1 = Int(Cod.Substring(0, 2))
        tipo = Cod.Substring(2, 1)
        p2 = Int(Cod.Substring(3, 2))
        Dim text = ""
        If tipo.Equals("X") Then

            text = (p1).ToString + " productos al precio de " + (p2).ToString
            Console.WriteLine(text)
        ElseIf tipo.Equals("E") Then
            text = (p1).ToString + "% de descuento en la " + (p2).ToString + "ta unidad"
            Console.WriteLine(text)
        End If

        Return text

    End Function



    Public Function Condicion(cod As String, precio As Integer, cant As Integer)
        Dim p1 = Int(cod.Substring(0, 2))
        Dim tipo = cod.Substring(2, 1)
        Dim p2 = Int(cod.Substring(3, 2))

        Dim text = {}
        Dim txt = ""
        Dim cont = 0
        Dim total = 0
        Dim l = 0

        If tipo.Equals("X") Then
            For i = 0 To cant - 1
                l += 1
                If p1 = l Then
                    cont += 1
                    total += (p1 - p2) * precio
                    txt = p1.ToString + "x" + p2.ToString
                    l = 0
                End If

            Next
        ElseIf tipo.Equals("E") Then
            For i = 0 To cant - 1
                l += 1
                If p2 = l Then
                    cont += 1
                    total += precio / p1
                    txt = p1.ToString + "%X" + p2.ToString
                    l = 0
                End If

            Next


        End If
        text = {cont.ToString, txt, total.ToString}

        Return text

    End Function


    Public Sub DarFin(id_descuento As String)
        daoDescuentos.DarFin(id_descuento)
    End Sub

    Public Function ObtenerIdProducto(id_descuento As String)
        Return daoDescuentos.ObtenerIdProducto(id_descuento)
    End Function

    Public Function GetCondicionDescuentoActivoProducto(ID As String)
        Dim daoDescuento As New DaoDescuentos
        Dim dataset As New DataSet
        Dim cod As String = ""

        dataset = daoDescuento.GetDescuentoActivoProducto(ID)

        Try
            If dataset.Tables(0).Rows.Count <> 0 Then
                cod = dataset.Tables(0)(0)(4).ToString
            End If
        Catch ex As Exception
            Console.WriteLine("NO SE ENCONTRO DESCUENTO ACTIVO")
            cod = ""

        End Try

        Return cod
    End Function

End Class
