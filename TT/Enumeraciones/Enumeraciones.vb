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
        Dim result As Integer = 19
        Return result
    End Function


    Public Function CODCAD1(num As Integer)
        Dim result As String = 0
        Dim list = {{10000, "A000"},
                    {11000, "B000"},
                    {12000, "C000"},
                    {13000, "D000"},
                    {14000, "E000"},
                    {15000, "F000"}}

        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 0) = num Then
                result = list(i, 1)
            End If
        Next
        Return result
    End Function

    Public Function CODCAD2(num As Integer)
        Dim result As String = 0
        Dim list = {{1000, "A00"},
                    {1100, "B00"},
                    {1200, "C00"},
                    {1300, "D00"},
                    {1400, "E00"},
                    {1500, "F00"}}

        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 0) = num Then
                result = list(i, 1)
            End If
        Next
        Return result
    End Function


End Class
