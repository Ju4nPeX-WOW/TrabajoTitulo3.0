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

    Public Function LimiteMax(elemento As String)
        Dim result As Short = 0
        Dim list = {{"rut", 8},
                    {"password", 8},
                    {"nombre persona", 20},
                    {"apellido", 20},
                    {"telefono fijo", 8},
                    {"telefono celular", 9},
                    {"email", 30},
                    {"direccion", 30},
                    {"numero de venta", 6},
                    {"precio", 7},
                    {"numero de folio", 7},
                    {"nombre", 50},
                    {"codigo producto", 13},
                    {"stock", 3},
                    {"stock critico", 3},
                    {"digito verificador", 1}}


        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 0).ToString.Equals(elemento) Then
                result = list(i, 1)
            End If
        Next
        Return result
    End Function


    Public Function LimiteMin(elemento As String)
        Dim result As Short = 0
        Dim list = {{"rut", 8},
                    {"password", 8},
                    {"nombre persona", 5},
                    {"apellido", 1},
                    {"telefono fijo", 8},
                    {"telefono celular", 9},
                    {"email", 10},
                    {"direccion", 5},
                    {"numero de venta", 6},
                    {"precio", 3},
                    {"numero de folio", 7},
                    {"nombre", 5},
                    {"codigo producto", 13},
                    {"stock", 1},
                    {"stock critico", 1},
                    {"digito verificador", 1}}

        Console.WriteLine(list.Length)
        For i = 0 To list.GetUpperBound(0)
            Console.WriteLine(i)
            If list(i, 0).ToString.Equals(elemento) Then
                result = list(i, 1)
            End If
        Next
        Return result
    End Function

End Class
