Imports System.Data.OleDb


Public Class InstruccionesV2
    Private realizado As Boolean = False



    Public Function Seleccionar(tabla As String, columnas As String, condicion As String)
        Dim conexion As New Conexion
        Dim command As New OleDbCommand
        Dim dataset As New DataSet
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()

            command.CommandText = "SELECT " & columnas & " FROM " & tabla & condicion
            Console.WriteLine(command.CommandText)
            Dim reader As New OleDbDataAdapter
            reader.SelectCommand = command
            reader.Fill(dataset)

            conexion.CerrarConexion()


        Catch ex As Exception

            Console.WriteLine(ex)

        End Try

        Return dataset

    End Function


    Public Function Insertar(tabla As String, columnas As String, valores As String)
        Dim conexion As New Conexion
        Dim command As New OleDbCommand
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()
            command.CommandText = "INSERT INTO " & tabla & " (" & columnas & ") VALUES(" & valores & ")"
            MsgBox(command.CommandText)
            command.ExecuteNonQuery()
            conexion.CerrarConexion()
            realizado = True
        Catch ex As Exception
            realizado = False
            MsgBox("Se ha producido un error: " & ex.ToString)
        End Try
        Return realizado
    End Function

    ' MODIFICAR

    Public Function Modificar(tabla As String, columnaValor As String, condicion As String)
        Dim conexion As New Conexion
        Dim command As New OleDbCommand
        Dim dataset As New DataSet
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()

            command.CommandText = "UPDATE " & tabla & " SET " & columnaValor & " WHERE " & condicion

            Console.WriteLine(command.CommandText)
            command.ExecuteNonQuery()
            conexion.CerrarConexion()
            realizado = True
        Catch ex As Exception
            MsgBox("Se ha producido un error (Modificar): " & ex.ToString())
            realizado = False
        End Try

        Return realizado

    End Function





    ' ELIMINADO 
    Public Function Eliminar(tabla As String, condicion As String)
        Dim conexion As New Conexion
        Dim command As New OleDbCommand
        Dim dataset As New DataSet
        Try
            command.Connection = conexion.GetConexion()
            conexion.AbrirConexion()

            command.CommandText = "DELETE FROM " & tabla & " WHERE " & condicion
            Console.WriteLine(command.CommandText)

            command.ExecuteNonQuery()
            conexion.CerrarConexion()



            realizado = True

        Catch ex As Exception
            Console.WriteLine("SE HA PRODUCIDO UN ERROR AL ELIMINAR")
            Console.WriteLine(ex)

            realizado = False
        End Try

        Return realizado

    End Function






End Class


