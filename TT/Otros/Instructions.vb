Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Class Instructions

    Protected conexion As New Conexion
    Protected command As New OleDbCommand
    Protected dataset As New DataSet
    Protected sentencia As String



    'SELECCION SIMPLE
    Public Function Seleccionar(tabla As String, columnas As String, condicion As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()

            sentencia = "Select " & columnas & " from " & tabla & condicion
            MsgBox(sentencia)
            command.CommandText = sentencia
            Console.WriteLine(sentencia)
            Dim reader As New OleDbDataAdapter
            reader.SelectCommand = command
            reader.Fill(dataset)

            conexion.CerrarConexion()


        Catch ex As Exception

            Console.WriteLine(ex)

        End Try

        Return dataset

    End Function

    'SELECCION CON LOGICA FD
    Public Function SelectWithFalseDelete(tabla As String, columnas As String, condicion As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()
            sentencia = "SELECT " & columnas & " FROM " & tabla & " WHERE False_delete = 0 " & condicion
            MsgBox(sentencia)
            command.CommandText = sentencia
            Dim reader As New OleDbDataAdapter
            dataset.Clear()
            reader.SelectCommand = command
            reader.Fill(dataset)

            conexion.CerrarConexion()


        Catch ex As Exception
            MsgBox("SE HA PRODUCIDO UN ERROR EN 'SelectWithFalseDelete' " & ex.ToString)


        End Try
        Return dataset
    End Function


    Public Sub Insertar(tabla As String, columnas As String, valores As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()
            sentencia = "INSERT INTO " & tabla & " (" & columnas & ") VALUES(" & valores & ")"
            command.CommandText = sentencia
            MsgBox(sentencia)   'sentencia
            command.ExecuteNonQuery()
            conexion.CerrarConexion()
        Catch ex As Exception
            MsgBox("Se ha producido un error: " & ex.ToString)
        End Try
    End Sub

    ' MODIFICAR

    Public Sub Modificar(tabla As String, columnaValor As String, condicion As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()


            sentencia = "UPDATE " & tabla & " SET " & columnaValor & " WHERE " & condicion
            command.CommandText = sentencia


            MsgBox(sentencia)
            Console.WriteLine(sentencia)
            command.ExecuteNonQuery()
            conexion.CerrarConexion()
        Catch ex As Exception
            MsgBox("Se ha producido un error (Modificar): " & ex.ToString())
        End Try


    End Sub


    ' ELIMINADO LOGICO
    Public Sub FalseDelete(tabla As String, condicion As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()

            sentencia = "UPDATE " & tabla & " SET False_delete = 1 WHERE " & condicion
            command.CommandText = sentencia
            Console.WriteLine(sentencia)
            command.ExecuteNonQuery()

            conexion.CerrarConexion()


        Catch ex As Exception
            Console.WriteLine("SE HA PRODUCIDO UN ERROR EN 'False_delete'")
            Console.WriteLine(ex)

        End Try
    End Sub

    Public Function busquedaIncremental(columnas As String, tabla As String, columnaBusqueda As String, texto As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()
            sentencia = "SELECT " & columnas & " FROM " & tabla & " WHERE " & columnaBusqueda & " LIKE '%" & texto & "%'"
            command.CommandText = sentencia
            MsgBox(sentencia)
            Dim reader As New OleDbDataAdapter
            dataset.Clear()
            reader.SelectCommand = command
            reader.Fill(dataset)
            conexion.CerrarConexion()

        Catch ex As Exception
            MsgBox("Error: " & ex.ToString)

        End Try
        Return dataset
    End Function


    ' ELIMINADO 
    Public Sub Eliminar(tabla As String, condicion As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()
            sentencia = "DELETE FROM " & tabla & " WHERE " & condicion
            command.CommandText = sentencia
            MsgBox(sentencia)
            command.ExecuteNonQuery()

            conexion.CerrarConexion()


        Catch ex As Exception
            Console.WriteLine("SE HA PRODUCIDO UN ERROR AL ELIMINAR")
            Console.WriteLine(ex)

        End Try

    End Sub

    Public Sub EliminarTodo(tabla As String)
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()
            sentencia = "DELETE FROM " & tabla
            command.CommandText = sentencia
            MsgBox(sentencia)
            command.ExecuteNonQuery()

            conexion.CerrarConexion()


        Catch ex As Exception
            Console.WriteLine("SE HA PRODUCIDO UN ERROR AL ELIMINAR")
            Console.WriteLine(ex)

        End Try

    End Sub


    Public Function obtenerNumeroVenta()

        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing

        Dim ultimaVenta As Integer = 0
        Try
            cnn = New SqlConnection(conexion.getStringConexion)
            cmd = New SqlCommand("SELECT NUM_VENTA FROM VENTAS WHERE NUM_VENTA = (SELECT MAX(NUM_VENTA) FROM VENTAS)", cnn)
            cnn.Open()
            ultimaVenta = CInt(cmd.ExecuteScalar())
            cnn.Close()
        Catch ex As Exception
            MsgBox("error: " & ex.ToString)
        End Try
        Return ultimaVenta
    End Function

End Class

