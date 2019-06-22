Public Class FrmUsers
    Dim dataset As New DataSet
    Dim BsnUsuario As New BsnUsuario

    Dim BsnEmpleado As New BsnEmpleado

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dataset = BsnUsuario.obtenerUsuarios()
        dgvUsua.DataSource = dataset.Tables(0).DefaultView



    End Sub

    Public Sub recargarDGV()
        dataset = BsnUsuario.obtenerUsuarios()
        dgvUsua.DataSource = dataset.Tables(0).DefaultView
    End Sub

    Private Sub picEliminar_Click(sender As Object, e As EventArgs) Handles picEliminar.Click
        If dgvUsua.Rows.Count > 0 Then
            If dgvUsua.CurrentRow.Index > -1 Then
                Dim rut_empleado As String = dgvUsua.CurrentRow.Cells(1).Value
                Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
                Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
                'MsgBox(response)

                If response = 6 Then
                    BsnUsuario.eliminarUsuario(rut_empleado)
                    Dim Empleado As New Empleado
                    Empleado.Rut = rut_empleado
                    BsnEmpleado.eliminarEmpleado(Empleado)

                    txtRut.Text = ""
                    txtContraseña.Text = ""
                    cmbPermisos.ResetText()
                    recargarDGV()
                End If
            End If
        End If
    End Sub

    Private Sub picEditar_Click(sender As Object, e As EventArgs) Handles picEditar.Click
        If dgvUsua.Rows.Count > 0 Then
            pnlComponentes.Enabled = True
            If dgvUsua.CurrentRow.Index > -1 Then
                Dim fila() As String = {dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(0).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(1).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(2).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(3).Value}
                txtRut.Text = fila(1)
                txtContraseña.Text = fila(2)
                'setear el combobox    
                'MsgBox(fila(0) & " " & fila(1) & " " & fila(2) & " " & fila(3))
                cmbPermisos.SelectedIndex = CInt(fila(3)) - 1
            End If
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If dgvUsua.Rows.Count > 0 Then
            Dim pal As String = ""
            Dim contador As Byte = 0
            Dim isCorrect As Boolean = True


            If txtContraseña.Text = "" Then
                contador = contador + 1
                pal = pal & contador & "-Por favor complete la contraseña..." & vbCrLf
                isCorrect = False
            End If

            If cmbPermisos.SelectedIndex <= -1 Then
                contador = contador + 1
                pal = pal & contador & "-Por favor seleccione permisos para el usuario..."
                isCorrect = False
            End If

            If Not isCorrect Then
                MsgBox(pal)
            Else
                Dim Usuario As New Usuario
                Usuario.Rut = txtRut.Text
                Usuario.Password = txtContraseña.Text
                Usuario.Permisos = cmbPermisos.Text
                BsnUsuario.editarUsuario(Usuario)

                txtRut.Text = ""
                txtContraseña.Text = ""
                cmbPermisos.ResetText()
                recargarDGV()
            End If

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        pnlComponentes.Enabled = False
    End Sub

    Private Sub dgvUsua_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsua.SelectionChanged
        If dgvUsua.CurrentRow.Index > -1 Then
            Dim fila() As String = {dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(0).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(1).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(2).Value, dgvUsua.Rows(dgvUsua.CurrentRow.Index).Cells(3).Value}
            txtRut.Text = fila(1)
            txtContraseña.Text = fila(2)
            'setear el combobox    
            'MsgBox(fila(0) & " " & fila(1) & " " & fila(2) & " " & fila(3))
            cmbPermisos.SelectedIndex = CInt(fila(3)) - 1
        End If
    End Sub
End Class
