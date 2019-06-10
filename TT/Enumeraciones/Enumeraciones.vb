Public Class Enumeraciones


    Public Function RazonAjusteStock(razon As String)
        Dim result As Short = 0
        Dim list = {{"Comprado", 1},
                    {"Vendido", 2},
                    {"Extraviado", 3},
                    {"Deteriodado", 4},
                    {"Encontrado", 5},
                    {"Eliminado", 6}}

        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 0).ToString.Equals(razon) Then
                result = list(i, 1)
            End If
        Next
        Return result



    End Function


    Public Function MedioPago(pago As String)
        Dim result As Short = 0
        Dim list = {{"Efectivo", 1},
                    {"Debito", 2},
                    {"Credito", 3}}
        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 0).ToString.Equals(pago) Then
                result = list(i, 1)
            End If
        Next
        Return result
    End Function

    Public Function Permisos(permiso As Short)
        Dim result As String = ""
        Dim list = {{"Empleado lvl 1", 1},
                    {"Empleado lvl 2", 2},
                    {"Administrador", 3}}
        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 1) = permiso Then
                result = list(i, 0)
            End If
        Next
        Return result
    End Function

    Public Function getIVA()
        Dim result As String = "0.19"
        Return result
    End Function




End Class
