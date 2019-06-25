Imports System.Data.OleDb

Public Class Conexion
    Protected conexion As New OleDbConnection
    Protected stringConexion As String = "Provider=sqloledb;" &
                     "Data Source=(local);" & 'en tu caso seria KEVIN-PC o algo asi 
                     "Initial Catalog=BDALBERDI;" &
                     "User Id=admin;Password=admin"

    Public Function getStringConexion()
        Dim conexion = "Data Source=(local)\BASEDEDATOS;" & 'en tu caso seria KEVIN-PC o algo asi 
                     "Initial Catalog=BDALBERDI;" &
                     "User Id=admin;Password=admin"
        Return conexion
    End Function

    Public Sub AbrirConexion()
        Try
            conexion.ConnectionString = stringConexion
            conexion.Open()
            Console.WriteLine("Conexion exitosa")
        Catch ex As Exception
            Console.WriteLine("Conexion no exitosa")
        End Try


    End Sub

    Public Sub CerrarConexion()
        conexion.Close()

    End Sub

    Public Function GetConexion()
        conexion.ConnectionString = stringConexion
        Console.WriteLine("holi1")
        Return conexion
    End Function

End Class

