Public Class FrmDesc

    Private _usuario As New Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected descuento As Descuento '------------------------>Recepción del usuario que usa el sistema

    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones
    Protected Validacion As New Validacionesv2

    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    'Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]
    Dim auxtermino As String = ""  '???

    Private Sub cmbProducto_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = Validacion.IOtroNombre(e)
    End Sub

    Protected dataset As New DataSet
    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema         
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

        dataset_1 = bsnproducto.ObtenerColumnasEspecificas("Nombre,Id_producto") 'busca los productos con columnas especificas
        cmbProducto.Items.Clear()                                                'limpiamos los items del combo Producto para introducir los del dataset de aqui arriba xd

        cmbProducto.DataSource = dataset_1.Tables(0).DefaultView                 'asignamos el dataset al comboproducto
        cmbProducto.DisplayMember = "Nombre"                                     'va a mostrarse por pantalla el "nombre"    
        cmbProducto.ValueMember = "Id_producto"                                  'el valor del item seleccionado del cmb sera el "ID_Producto"

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
        cmbProducto.Text = dgvDescuentos.CurrentRow.Cells(1).Value.ToString()     'texto del cmbProducto 
        dtpInicio.Value = DateTime.Now.ToString("dd/MM/yyyy")                     'fecha de inicio
        dtpTermino.Value = dgvDescuentos.CurrentRow.Cells(3).Value.ToString()     'Fecha de termino...        
        auxtermino = dgvDescuentos.CurrentRow.Cells(3).Value.ToString()           'auxiliar de la fecha termino

        Dim condicion As String = dgvDescuentos.CurrentRow.Cells(4).Value         'la condicion del item seleccionado

        Dim cmbP1 As Integer = 0        'puede ser para el cmbP1mayor o cmbP1porcentual, depende del item seleccionado
        Dim cmbP2 As Integer = 0       'puede ser para el cmbP2mayor o cmbP2porcentual, depende del item seleccionado
        Dim tipo As String = ""         'Si es 'x', es al por mayor, sino es porcentual...

        'la variable condicion tira = "10X05"
        cmbP1 = Integer.Parse(condicion.Substring(0, 2)) '10
        tipo = condicion.Substring(2, 1)                 'X
        cmbP2 = Integer.Parse(condicion.Substring(3))    '05        

        If tipo.ToLower.Equals("x") Then
            'activa lo de mayor
            cbxMayor.Checked = True
            cbxPorcentual.Checked = False
        ElseIf tipo.ToLower.Equals("e") Then
            'activa lo de porcentual
            cbxMayor.Checked = False
            cbxPorcentual.Checked = True
        End If

        'MsgBox(tipo.ToLower)

        If tipo.ToLower.Equals("x") Then
            'activa lo de mayor y desactiva lo de porcentual
            cbxMayor.Checked = True
            cmbP1Mayor.SelectedIndex = cmbP1 - 1
            cmbP2Mayor.SelectedIndex = cmbP2 - 1

            'limpiamos lo de porcentual
            cbxPorcentual.Checked = False
            cmbP1Porcentual.SelectedIndex = -1
            cmbP2Porcentual.SelectedIndex = -1


        ElseIf tipo.ToLower.Equals("e") Then
            'limpiamos lo de porcentual  
            cbxMayor.Checked = False 'desactivando checkbox mayor
            cmbP1Mayor.SelectedIndex = -1   'reseteando el texto del combo mayor 1
            cmbP2Mayor.SelectedIndex = -1

            'activa lo de porcentaje y desactiva lo de mayor
            cbxPorcentual.Checked = True                'checkbox porcentual activado
            cmbP1Porcentual.SelectedIndex = cmbP1 - 1
            cmbP2Porcentual.SelectedIndex = cmbP2 - 1
        End If
    End Sub

    Private Sub TsmAgregarCat_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        activeEditar = False
        'activeEliminar = False

        cmbProducto.Enabled = True
        dtpInicio.Enabled = True
        dtpTermino.Enabled = True

        If cbxMayor.Checked Then
            cbxMayor.Enabled = True
            cmbP1Mayor.Enabled = True
            cmbP2Mayor.Enabled = True

            cbxPorcentual.Checked = False
            cbxPorcentual.Enabled = False
            cmbP1Porcentual.Enabled = False
            cmbP2Porcentual.Enabled = False
        ElseIf cbxPorcentual.Checked Then

            cbxPorcentual.Enabled = True
            cmbP1Porcentual.Enabled = True
            cmbP2Porcentual.Enabled = True

            cbxMayor.Checked = False
            cbxMayor.Enabled = False
            cmbP1Mayor.Enabled = False
            cmbP2Mayor.Enabled = False
        End If


        cmbP1Mayor.SelectedIndex = -1
        cmbP2Mayor.SelectedIndex = -1
        cmbProducto.SelectedIndex = -1
        cmbP1Porcentual.SelectedIndex = -1
        cmbP2Porcentual.SelectedIndex = -1
        dtpInicio.Value = DateTime.Now
        dtpTermino.Value = DateTime.Now

        btnAce.Enabled = True
        btnCan.Enabled = True
        'MsgBox(cmbProducto.SelectedValue)

    End Sub

    Private Sub TsmEditarCat_Click(sender As Object, e As EventArgs) Handles tsmExtender.Click
        activeAgregar = False
        activeEditar = True
        'activeEliminar = False

        cmbProducto.Enabled = False 'si se esta editando, se bloquea este combobox porque no tiene sentido que edite otro producto que no sea el que eligio
        dtpInicio.Enabled = False   'no tiene sentido que se edite el de tiempo de inicio si lo que quiere es extenderlo, para eso el de termino lo edita.
        dtpTermino.Enabled = True

        If cbxMayor.Checked Then
            cbxMayor.Enabled = True
            cmbP1Mayor.Enabled = True
            cmbP2Mayor.Enabled = True

            cbxPorcentual.Checked = False
            cbxPorcentual.Enabled = False
            cmbP1Porcentual.Enabled = False
            cmbP2Porcentual.Enabled = False
        ElseIf cbxPorcentual.Checked Then

            cbxPorcentual.Enabled = True
            cmbP1Porcentual.Enabled = True
            cmbP2Porcentual.Enabled = True

            cbxMayor.Checked = False
            cbxMayor.Enabled = False
            cmbP1Mayor.Enabled = False
            cmbP2Mayor.Enabled = False
        End If

        btnAce.Enabled = True
        btnCan.Enabled = True


    End Sub

    Private Sub TsmFinalizarCat_Click(sender As Object, e As EventArgs) Handles tsmFinalizar.Click
        activeAgregar = False
        activeEditar = False
        'activeEliminar = True
        Dim bsnDescuento As New BsnDescuentos
        bsnDescuento.DarFin(lblIdDescuento.Text)
        RellenarDataSet()
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = True

        Dim pal As String = ""
        Dim fecha_inicio As String = dtpInicio.Value.Date.ToString("yyyy-MM-dd")
        Dim fecha_termino As String = dtpTermino.Value.Date.ToString("yyyy-MM-dd")

        'VALIDAR QUE NO SE EDITEN DESCUENTOS CADUCADOS -> ok   

        If activeAgregar Then   'si se esta agregando un descuento...

            If cmbProducto.SelectedIndex >= 0 Then  '¿el combo producto tiene seleccionado un item?                
                If cbxMayor.Checked Then 'si esta seleccionado checkbox mayor                    
                    'SI se selecciono un indice mayor a -1 en cmbP1 y cmbP2 y ademas el comboP1 debe ser mayor al indice del p2 porque ejemplo:  2x3 dos productos por el precio de 3 ¿?¿? WHAT?                    
                    If Not (cmbP1Mayor.SelectedIndex > -1 And cmbP2Mayor.SelectedIndex > -1) Or Not (cmbP1Mayor.SelectedIndex > cmbP2Mayor.SelectedIndex) Then
                        pal = pal & "-Ingrese una condición válida" & vbCrLf
                        cumple = False
                    End If
                ElseIf cbxPorcentual.Checked Then
                    'SI se selecciono un indice mayor a -1 en cmbP1 y cmbP2 y ademas el comboP1 debe ser mayor al indice del p2 porque ejemplo:  2x3 dos productos por el precio de 3 ¿?¿? WHAT?
                    If Not (cmbP1Porcentual.SelectedIndex > -1 And cmbP2Porcentual.SelectedIndex > -1) Then
                        cumple = False
                        pal = pal & "-Ingrese una condición válida" & vbCrLf
                    End If
                End If

                If fecha_termino <= fecha_inicio Then 'la fecha de termino debe ser mayor que la fecha de inicio...
                    cumple = False
                    pal = pal & "-Seleccione una fecha superior a la fecha de inicio"
                End If
                If cumple = False Then 'Esto es para mostrar el mensaje de error...
                    MsgBox(pal, vbInformation, "Existen campos vacíos o incorrectos")
                End If
            Else 'No tiene seleccionado un item... mensaje de error!
                MsgBox("Sr Usuario, seleccione un producto al cual se le realizará el descuento", vbInformation, "Falta ingresar datos...")
                cumple = False
            End If
        ElseIf activeEditar Then
            Dim fecha_termino_asDate As String = dtpTermino.Value.Date.ToString("yyyy-MM-dd")  'del date picker que elige el usuario
            Dim auxiliar_fecha_termino_asDate As String = auxtermino                           'del datagridview.cells(4)

            If Not (fecha_termino_asDate >= auxiliar_fecha_termino_asDate And fecha_termino_asDate > DateTime.Now) Then
                cumple = False
                MsgBox("¡Usted esta reduciendo la fecha del descuento, solo se permite extender la fecha!. Si desea dar término a un descuento, seleccione el boton 'Finalizar descuento'", vbCritical, "Fecha no permitida...")
            End If
        End If

        MsgBox(cumple)
        Return cumple
    End Function

    Private Sub BtnAce_Click(sender As Object, e As EventArgs) Handles btnAce.Click
        'Respecto a validar:
        '   No deben poder editarse los descuentos que ya caducaron, no tiene sentido el editarlos
        '   Deben ser creados de nuevos, para saber si han caducado se tiene que evaluar la fecha de termino
        '   Dar termino un descuento, se queda el descuento hasta el dia actual, se finaliza así xD.
        If RealizarValidacion() Then

            Dim ObjetoDescuento As New Descuento() 'instancia objeto descuento
            Dim id_des, id_prod, fec_ini, fec_ter, con As String 'variables pertenecientes al objeto descuento

            id_des = "" 'solo al editar...
            id_prod = cmbProducto.SelectedValue             'value tirara el id del producto, selecteditem el texto del producto
            fec_ini = dtpInicio.Value.ToShortDateString     'fecha de inicio del descuento
            fec_ter = dtpTermino.Value.ToShortDateString    'fecha de termino 
            con = GetCondicion()                            '10X05'            


            If activeEditar Then
                id_des = lblIdDescuento.Text
            End If

            'Rellenemos El Objeto
            ObjetoDescuento.IdDescuento = id_des   'toma el la columna 0, id
            ObjetoDescuento.IdProducto = id_prod   'toma el valor del combobox... el selectedvalue
            ObjetoDescuento.FechaInicio = fec_ini   'dtpFecha inicio
            ObjetoDescuento.FechaTermino = fec_ter  'dtpFecha termino
            ObjetoDescuento.Condicion = con         'Condicion concantenada, string.

            Dim bsnDescuento As New BsnDescuentos
            If activeAgregar Then
                bsnDescuento.AgregarDescuento(ObjetoDescuento)
                MsgBox("Descuento agregado")
            ElseIf activeEditar Then
                bsnDescuento.ModificarDescuento(ObjetoDescuento)
                MsgBox("Descuento editado")
            End If

            cmbP1Mayor.SelectedIndex = -1
            cmbP2Mayor.SelectedIndex = -1
            cmbProducto.SelectedIndex = -1
            cmbP1Porcentual.SelectedIndex = -1
            cmbP2Porcentual.SelectedIndex = -1
            dtpInicio.Value = DateTime.Now
            dtpTermino.Value = DateTime.Now

            cmbProducto.Enabled = False
            dtpInicio.Enabled = False
            dtpTermino.Enabled = False

            cbxPorcentual.Enabled = False
            cmbP1Porcentual.Enabled = False
            cmbP2Porcentual.Enabled = False

            cbxPorcentual.Checked = False

            cbxMayor.Enabled = False
            cmbP1Mayor.Enabled = False
            cmbP2Mayor.Enabled = False

            activeAgregar = False
            activeEditar = False

            btnAce.Enabled = False
            btnCan.Enabled = False

            'MsgBox(cmbProducto.SelectedValue)
            RellenarDataSet()

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
        Return condicion      '04X02     o     10E4

    End Function
    Private Sub reset()
        Dim permiso As New Permisos
        tsmAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "AGREGAR", "")
        tsmExtender.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "EXTENDER", "")
        tsmFinalizar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "DESCUENTOS", "FINALIZAR", "")
    End Sub
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click

        cmbP1Mayor.SelectedIndex = -1
        cmbP2Mayor.SelectedIndex = -1
        cmbProducto.SelectedIndex = -1
        cmbP1Porcentual.SelectedIndex = -1
        cmbP2Porcentual.SelectedIndex = -1
        dtpInicio.Value = DateTime.Now
        dtpTermino.Value = DateTime.Now

        cmbProducto.Enabled = False
        dtpInicio.Enabled = False
        dtpTermino.Enabled = False

        cbxPorcentual.Enabled = False
        cmbP1Porcentual.Enabled = False
        cmbP2Porcentual.Enabled = False

        cbxPorcentual.Checked = False

        cbxMayor.Enabled = False
        cmbP1Mayor.Enabled = False
        cmbP2Mayor.Enabled = False

        activeAgregar = False
        activeEditar = False

        btnAce.Enabled = False
        btnCan.Enabled = False
    End Sub

    Private Sub cbxMayor_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMayor.CheckStateChanged
        'MsgBox("MAYOR CHANGED: " & cbxMayor.CheckState & " " & cbxPorcentual.CheckState)
        If activeEditar = True Or activeAgregar = True Then
            If cbxMayor.CheckState = 0 Then
                cbxMayor.Enabled = False
                cmbP1Mayor.Enabled = False
                cmbP2Mayor.Enabled = False

                cmbP1Mayor.SelectedIndex = -1
                cmbP2Mayor.SelectedIndex = -1

                cbxPorcentual.CheckState = 1
            Else
                If cbxMayor.CheckState = 1 Then
                    cbxMayor.Enabled = True
                    cmbP1Mayor.Enabled = True
                    cmbP2Mayor.Enabled = True

                End If
            End If
        End If
    End Sub

    Private Sub cbxPorcentual_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPorcentual.CheckStateChanged
        'MsgBox("porcentual: " & cbxMayor.CheckState & " " & cbxPorcentual.CheckState)
        If activeAgregar = True Or activeEditar = True Then
            If cbxPorcentual.CheckState = 0 Then
                cbxPorcentual.Enabled = False
                cmbP1Porcentual.Enabled = False
                cmbP2Porcentual.Enabled = False

                cmbP1Porcentual.SelectedIndex = -1
                cmbP2Porcentual.SelectedIndex = -1

                cbxMayor.CheckState = 1
            Else
                If cbxPorcentual.CheckState = 1 Then
                    cbxPorcentual.Enabled = True
                    cmbP1Porcentual.Enabled = True
                    cmbP2Porcentual.Enabled = True
                End If
            End If
        End If
    End Sub



    'FALTA LOS PUTOS CBX
End Class


