Public Class FrmDesc

    Private _usuario As New Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected descuento As Descuento '------------------------>Recepción del usuario que usa el sistema

    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones
    Protected Validacion As New Validacionesv2

    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]
    Dim auxtermino As String = ""

    Private Sub cmbProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbProducto.KeyPress
        e.Handled = Validacion.IOtroNombre(e)
    End Sub

    Protected dataset As New DataSet
    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub
    Private Sub BtnExitDes_Click(sender As Object, e As EventArgs) Handles BtnExitDes.Click
        Me.Close()
    End Sub
    Private Sub BuildDGV()
        Me.dgvDescuentos.DefaultCellStyle.BackColor = Color.Beige
        Me.dgvDescuentos.ColumnCount = 5
        Me.dgvDescuentos.Columns(0).Name = "Id"
        Me.dgvDescuentos.Columns(1).Name = "Producto"
        Me.dgvDescuentos.Columns(2).Name = "Fecha Inicio"
        Me.dgvDescuentos.Columns(3).Name = "Fecha Termino"
        Me.dgvDescuentos.Columns(4).Name = "Condicion"
        'dgvDescuentos.Columns(1).DataPropertyName = "Nombre"
        dgvDescuentos.Columns(0).DataPropertyName = "Id_descuento"
        dgvDescuentos.Columns(1).DataPropertyName = "Nombre"
        dgvDescuentos.Columns(2).DataPropertyName = "Fecha_inicio"
        dgvDescuentos.Columns(3).DataPropertyName = "Fecha_termino"
        dgvDescuentos.Columns(4).DataPropertyName = "Condicion"
    End Sub
    Private Sub RellenarDataSet()
        dgvDescuentos.DataSource = Nothing
        dgvDescuentos.Refresh()
        Dim bsnDescuentos As New BsnDescuentos()
        dataset = bsnDescuentos.ObtenerDescuentos()
        dgvDescuentos.DataSource = dataset.Tables(0).DefaultView
        If dgvDescuentos.Rows.Count > 0 Then
            dgvDescuentos.Rows(0).Selected = False
        End If
    End Sub

    Private Sub RellenarCMB()
        Dim bsnproducto As New BsnProducto
        Dim dataset_1 As New DataSet

        dataset_1 = bsnproducto.ObtenerColumnasEspecificas("Nombre,Id_producto")
        cmbProducto.Items.Clear()

        cmbProducto.DataSource = dataset_1.Tables(0).DefaultView
        cmbProducto.DisplayMember = "Nombre"
        cmbProducto.ValueMember = "Id_producto"

        cmbP1Mayor.Items.Clear()
        cmbP2Mayor.Items.Clear()
        For i = 1 To 5
            cmbP1Mayor.Items.Add((i).ToString)
            cmbP2Mayor.Items.Add((i).ToString)
        Next

        cmbP1Porcentual.Items.Clear()
        cmbP2Porcentual.Items.Clear()
        For i = 1 To 100
            cmbP1Porcentual.Items.Add(i.ToString)
        Next
        For i = 1 To 10
            cmbP2Porcentual.Items.Add(i.ToString)
        Next
    End Sub
    Private Sub FrmDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'largo
        cmbProducto.MaxLength = Validacion.MaxOtroNombre
        reset()
        BuildDGV()
        RellenarDataSet()
        RellenarCMB()
    End Sub

    Private Sub DgvDescuentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescuentos.CellClick

        Dim bsnDescuentos As New BsnDescuentos()
        'MsgBox(bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells(4).Value.ToString))

        'Dim x = (bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells(4).Value.ToString, 1000, 10))
        'MsgBox(x(0).ToString & " " & x(1).ToString() & " " & x(2).ToString)        
        lblIdDescuento.Text = dgvDescuentos.CurrentRow.Cells(0).Value.ToString()  'numero correlativo de descuento...
        cmbProducto.Text = dgvDescuentos.CurrentRow.Cells(1).Value.ToString()
        dtpInicio.Value = DateTime.Now.ToString("dd/MM/yyyy")                     'fecha de inicio
        dtpTermino.Value = dgvDescuentos.CurrentRow.Cells(3).Value.ToString()     'Fecha de termino...        
        auxtermino = dgvDescuentos.CurrentRow.Cells(3).Value.ToString()


        Dim condicion As String = dgvDescuentos.CurrentRow.Cells(4).Value
        MsgBox(condicion)
        Dim cmbP1 As String = ""
        Dim cmbP2 As String = ""
        Dim tipo As String = ""


        cmbP1 = Integer.Parse(condicion.Substring(0, 2))
        tipo = condicion.Substring(2, 1)
        cmbP2 = Integer.Parse(condicion.Substring(3))

        If tipo.ToLower.Equals("x") Then
            cbxMayor.Checked = True
            cmbP1Mayor.SelectedItem = cmbP1
            cmbP2Mayor.SelectedItem = cmbP2
        Else
            cbxPorcentual.Checked = True
            cmbP1Porcentual.SelectedItem = cmbP1
            cmbP2Porcentual.SelectedItem = cmbP2
        End If


    End Sub

    Private Sub TsmAgregarCat_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        activeEditar = False
        activeEliminar = False

        cmbProducto.Enabled = True  'es por si es que se bloquea al editar, volver a activar el cmbproducto
        dtpInicio.Enabled = True    'idem
        dtpTermino.Enabled = True   
        pnlComponentes.Enabled = True

        'MsgBox(cmbProducto.SelectedValue)

    End Sub

    Private Sub TsmEditarCat_Click(sender As Object, e As EventArgs) Handles tsmExtender.Click
        activeAgregar = False
        activeEditar = True
        activeEliminar = False

        cmbProducto.Enabled = False 'si se esta editando, se bloquea este combobox porque no tiene sentido que edite otro producto que no sea el que eligio
        dtpInicio.Enabled = False   'no tiene sentido que se edite el de tiempo de inicio si lo que quiere es extenderlo, para eso el de termino lo edita.
        dtpTermino.Enabled = True
        pnlComponentes.Enabled = True

    End Sub

    Private Sub TsmFinalizarCat_Click(sender As Object, e As EventArgs) Handles tsmFinalizar.Click
        activeAgregar = False
        activeEditar = False
        activeEliminar = True

        Dim bsnDescuento As New BsnDescuentos
        bsnDescuento.DarFin(lblIdDescuento.Text)
        RellenarDataSet()
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = False
        'VALIDAR QUE NO SE EDITEN DESCUENTOS CADUCADOS -> ok        
        If activeAgregar Then   'si se esta agregando un descuento...
            If cmbProducto.SelectedIndex > 0 Then  '¿el combo producto tiene seleccionado un item?
                If cbxMayor.Checked And cmbP1Mayor.SelectedIndex >= 0 And cmbP2Mayor.SelectedIndex >= 0 Then
                    cumple = True
                ElseIf cbxPorcentual.Checked And cmbP2Porcentual.SelectedIndex > 0 And cmbP2Porcentual.SelectedIndex > 0 Then
                    cumple = True
                Else
                    MsgBox("Sr Usuario, Ingrese una condicion", vbInformation, "Faltan ingresar datos...")
                End If
            Else 'No tiene selecciondo un item... mensaje de error!
                MsgBox("Sr Usuario, seleccione un producto al cual se le realizara el descuento", vbInformation, "Falta ingresar datos...")
            End If


        ElseIf activeEditar Then
            If dtpTermino.Value.ToShortDateString >= DateTime.Now Then
                If Not dtpTermino.Value.ToShortDateString < auxtermino Then
                    cumple = True
                Else
                    MsgBox("SR USUARIO PUEDE REDUCIR EL TIMEPO DE VALIDES DEL DESCUENTO")
                End If
            Else
                MsgBox("SR USUARIO NO SE PUEDEN EXTENDER DESCUENTOS FINALIZADOS")
            End If
        End If
        Return cumple
    End Function

    Private Sub BtnAce_Click(sender As Object, e As EventArgs) Handles btnAce.Click
        'Respecto a validar:
        '   No deben poder editarse los descuentos que ya caducaron, no tiene sentido el editarlos
        '   Deben ser creados de nuevos, para saber si han caducado se tiene que evaluar la fecha de termino
        '   Dar termino un descuento, se queda el descuento hasta el dia actual, se finaliza así xD.
        If RealizarValidacion() Then

            Dim ObjetoDescuento As New Descuento()

            Dim id_des, id_prod, fec_ini, fec_ter, con As String
            id_des = ""
            'id_prod = ""
            'fec_ini = ""
            'fec_ter = ""
            'con = ""

            id_prod = cmbProducto.SelectedValue
            fec_ini = dtpInicio.Value.ToShortDateString
            fec_ter = dtpTermino.Value.ToShortDateString
            con = GetCondicion()
            MsgBox("CON: " & con)

            If activeAgregar Then
                'id_prod = cmbProducto.SelectedValue
                'fec_ini = dtpInicio.Value.ToShortDateString
                'fec_ter = dtpTermino.Value.ToShortDateString
                'con = GetCondicion()

            ElseIf activeEditar Then

                id_des = lblIdDescuento.Text
                'id_prod = cmbProducto.SelectedValue
                'fec_ini = dtpInicio.Value.ToShortDateString
                'fec_ter = dtpTermino.Value.ToShortDateString
                'con = GetCondicion()
            End If

            'Rellenemos El Objeto
            ObjetoDescuento.IdDescuento = id_des   'toma el la columna 0, id
            ObjetoDescuento.IdProducto = id_prod   'toma el valor del combobox... el selectedvalue
            ObjetoDescuento.FechaInicio = fec_ini   'dtpFecha inicio
            ObjetoDescuento.FechaTermino = fec_ter  'dtpFecha termino
            ObjetoDescuento.Condicion = con         'Condicion concantenada, string.

            Dim bsnDescuento As New BsnDescuentos

            If activeAgregar Then
                'bsnDescuento.AgregarDescuento(ObjetoDescuento)
                MsgBox("ID DESCUENTO: " & ObjetoDescuento.IdDescuento & " ID-PRODUCTO: " & ObjetoDescuento.IdProducto & " FECHA INICIO:" & ObjetoDescuento.FechaInicio & " FECHA TERMINO:" & ObjetoDescuento.FechaTermino & " Condicion: " & ObjetoDescuento.Condicion)
            ElseIf activeEditar Then
                'bsnDescuento.ModificarDescuento(ObjetoDescuento)
                MsgBox("ID DESCUENTO: " & ObjetoDescuento.IdDescuento & " ID-PRODUCTO: " & ObjetoDescuento.IdProducto & " FECHA INICIO:" & ObjetoDescuento.FechaInicio & " FECHA TERMINO:" & ObjetoDescuento.FechaTermino & " Condicion: " & ObjetoDescuento.Condicion)
            End If

            cmbP1Mayor.ResetText()
            cmbP2Mayor.ResetText()
            cmbProducto.ResetText()
            cmbP1Porcentual.ResetText()
            cmbP2Porcentual.ResetText()
            dtpInicio.ResetText()
            dtpTermino.ResetText()

            cbxMayor.CheckState = 0
            cbxPorcentual.CheckState = 0
            'MsgBox(cmbProducto.SelectedValue)
            RellenarDataSet()
            pnlComponentes.Enabled = False
        End If
    End Sub
    Private Function GetCondicion() 'retorna un string concatenado con numeroletranumero

        Dim tipo_descto, cantidad1, cantidad2, condicion As String 'tipo: X = 4X2, E = 10% dscto en la 4 unidad... p1 y p2 equivale a las cantidades
        tipo_descto = ""
        cantidad1 = ""
        cantidad2 = ""
        condicion = ""

        If cbxMayor.Checked Then
            tipo_descto = "X"
            cantidad1 = "0" & cmbP1Mayor.Text.ToString
            cantidad2 = "0" & cmbP2Mayor.Text.ToString
            condicion = cantidad1 & tipo_descto & cantidad2
        ElseIf cbxPorcentual.Checked Then
            tipo_descto = "E"
            cantidad1 = cmbP1Porcentual.Text.ToString
            cantidad2 = "0" & cmbP2Porcentual.Text.ToString
            condicion = cantidad1 & tipo_descto & cantidad2
        End If
        MsgBox("CONDIDIOCN: " & condicion)
        Return condicion      '04X02     o     10E4

    End Function
    Private Sub reset()
        Dim permiso As New Permisos
        tsmAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "AGREGAR", "")
        tsmExtender.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "EXTENDER", "")
        tsmFinalizar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "FINALIZAR", "")
    End Sub
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        pnlComponentes.Enabled = False

        cmbP1Mayor.ResetText()
        cmbP2Mayor.ResetText()

        cmbP1Porcentual.ResetText()
        cmbP2Porcentual.ResetText()

        cbxMayor.Checked = False
        cbxPorcentual.Checked = False


    End Sub
    Private Sub EstadoCheckBox(sender As Object, e As EventArgs) Handles cbxMayor.CheckedChanged, cbxPorcentual.CheckedChanged
        If cbxMayor.Checked Then    'seleccionado mayor por menor
            cbxPorcentual.Enabled = False
            cmbP1Porcentual.Enabled = False
            cmbP2Porcentual.Enabled = False

            cmbP1Porcentual.SelectedIndex = -1
            cmbP2Porcentual.SelectedIndex = -1
        ElseIf cbxPorcentual.Checked Then 'seleccionado porcentaje
            cbxMayor.Enabled = False
            cmbP1Mayor.Enabled = False
            cmbP2Mayor.Enabled = False

            cmbP1Mayor.SelectedIndex = -1
            cmbP2Mayor.SelectedIndex = -1
        ElseIf Not (cbxPorcentual.Checked And cbxMayor.Checked) Then
            'desbloqueamos la condicion de porcentaje
            cbxPorcentual.Enabled = True
            cmbP1Porcentual.Enabled = True
            cmbP2Porcentual.Enabled = True

            cmbP1Porcentual.SelectedIndex = -1
            cmbP2Porcentual.SelectedIndex = -1
            'desbloqueamos la condicion de mayor por
            cbxMayor.Enabled = True
            cmbP1Mayor.Enabled = True
            cmbP2Mayor.Enabled = True

            cmbP1Mayor.SelectedIndex = -1
            cmbP2Mayor.SelectedIndex = -1
        End If
    End Sub

End Class


