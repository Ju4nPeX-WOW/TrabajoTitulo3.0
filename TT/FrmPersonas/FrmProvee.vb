Public Class FrmProvee
    Dim _usuario As Usuario
    Public Sub RecibirUsuario(objeto As Empleado)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema
        'MsgBox("ID-USUARIO : " & usuario.IdUsuario)


    End Sub

    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub

    Private Sub FrmProvee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reset()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub reset()
        Dim permiso As New Permisos
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PROVEEDORES", "AGREGAR", "")
        picEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "PROVEEDORES", "EDITAR", "")
        picEliminar = permiso.OtorgarAcceso(_usuario.Permisos, "PROVEEDORES", "ELIMINAR", "")
    End Sub
End Class
