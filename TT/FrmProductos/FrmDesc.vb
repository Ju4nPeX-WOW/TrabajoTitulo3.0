
Public Class FrmDesc

    Private _usuario As New Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected descuento As Descuento '------------------------>Recepción del usuario que usa el sistema

    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones
    Protected Validacion As New Validacionesv2
    Dim BsnProd As New BsnProducto
    Dim btnSeleccionadoPrimeraVez As Boolean = False

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
        llenado_descuento()
    End Sub

    Public Sub llenado_descuento()
        If dgvDescuentos.Rows.Count > 0 Then
            label.Text = dgvDescuentos.CurrentRow.Cells(0).Value
            txtProducto.Text = dgvDescuentos.CurrentRow.Cells(1).Value
            'dtpInicio.Value = DateTime.Now.ToString("dd/MM/yyyy")                     'fecha de inicio
            dtpInicio.Value = dgvDescuentos.CurrentRow.Cells(2).Value.ToString
            dtpTermino.Value = dgvDescuentos.CurrentRow.Cells(3).Value.ToString()     'Fecha de termino...        
            auxtermino = dgvDescuentos.CurrentRow.Cells(3).Value.ToString()           'auxiliar de la fecha termino
            Dim condicion As String = dgvDescuentos.CurrentRow.Cells(4).Value         'la condicion del item seleccionado

            Dim cmbP1 As Integer = condicion.Substring(0, 2)       'puede ser para el cmbP1mayor o cmbP1porcentual, depende del item seleccionado
            Dim tipo As String = condicion.Substring(2, 1)         'Si es 'x', es al por mayor, sino es porcentual...
            Dim cmbP2 As Integer = condicion.Substring(3)       'puede ser para el cmbP2mayor o cmbP2porcentual, depende del item seleccionado            

            'la variable condicion tira = "10X05"
            'cmbP1 = (condicion.Substring(0, 2)) '10
            'tipo = condicion.Substring(2, 1)                 'X
            'cmbP2 = (condicion.Substring(3))    '05        

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
                cmbP1Mayor.Text = cmbP1
                cmbP2Mayor.Text = cmbP2

                'limpiamos lo de porcentual
                cbxPorcentual.Checked = False
                cmbP1Porcentual.SelectedIndex = 0
                cmbP2Porcentual.SelectedIndex = 0


            ElseIf tipo.ToLower.Equals("e") Then
                'limpiamos lo de porcentual  
                cbxMayor.Checked = False 'desactivando checkbox mayor
                cmbP1Mayor.SelectedIndex = 0   'reseteando el texto del combo mayor 1
                cmbP2Mayor.SelectedIndex = 0

                'activa lo de porcentaje y desactiva lo de mayor
                cbxPorcentual.Checked = True                'checkbox porcentual activado
                cmbP1Porcentual.Text = cmbP1
                cmbP2Porcentual.Text = cmbP2
            End If
        End If
    End Sub

    Private Sub FrmDesc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'largo
        cmbBusqueda.SelectedIndex = 1
        txtProducto.MaxLength = Validacion.MaxApellido
        reset()
        BuildDGV()
        For i = 1 To 5
            cmbP1Mayor.Items.Add((i).ToString)
            cmbP2Mayor.Items.Add((i).ToString)
        Next
        For i = 1 To 100
            cmbP1Porcentual.Items.Add(i.ToString)
        Next
        For i = 1 To 10
            cmbP2Porcentual.Items.Add(i.ToString)
        Next
        RellenarDataSet()
        llenado_descuento()
        recargarDGV()   'carga el dgv productos
    End Sub

    Private Sub DgvDescuentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDescuentos.CellClick
        llenado_descuento()

        Dim bsnDescuentos As New BsnDescuentos()
        'MsgBox(bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells(4).Value.ToString))
        'Dim x = (bsnDescuentos.Condicion(dgvDescuentos.CurrentRow.Cells(4).Value.ToString, 1000, 10))
        'MsgBox(x(0).ToString & " " & x(1).ToString() & " " & x(2).ToString)        
    End Sub

    Private Sub TsmAgregarCat_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        activeAgregar = True
        activeEditar = False
        'activeEliminar = False
        mnsDes.Enabled = False
        'cmbProducto.Enabled = True
        dtpInicio.Enabled = True
        dtpTermino.Enabled = True

        '---
        dgvDescuentos.Enabled = False
        dgvProductos.Enabled = True
        recargarDGV()
        cmbBusqueda.Enabled = True
        txtBusqueda.Enabled = True
        btnBuscar.Enabled = True
        '---


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


        'cmbP1Mayor.SelectedIndex = -1
        'cmbP2Mayor.SelectedIndex = -1

        'cmbProducto.SelectedIndex = -1

        'cmbP1Porcentual.SelectedIndex = -1
        'cmbP2Porcentual.SelectedIndex = -1

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
        mnsDes.Enabled = False
        'cmbProducto.Enabled = False 'si se esta editando, se bloquea este combobox porque no tiene sentido que edite otro producto que no sea el que eligio
        dtpInicio.Enabled = False   'no tiene sentido que se edite el de tiempo de inicio si lo que quiere es extenderlo, para eso el de termino lo edita.
        dtpTermino.Enabled = True
        btnAce.Enabled = True
        btnCan.Enabled = True
        llenado_descuento()
    End Sub

    Private Sub TsmFinalizarCat_Click(sender As Object, e As EventArgs) Handles tsmFinalizar.Click
        'activeEliminar = True
        Dim bsnDescuento As New BsnDescuentos
        Dim responde = MsgBox("¿Esta seguro de finalizar el descuento?", vbInformation + vbYesNo, "Finalizar descuento")
        If responde = 6 Then
            Dim fecha_termino As Date = dgvDescuentos.CurrentRow.Cells(2).Value
            fecha_termino = fecha_termino.AddDays(-1)
            fecha_termino = fecha_termino.ToString("dd/MM/yyyy")
            MsgBox(fecha_termino)
            bsnDescuento.DarFin(label.Text, fecha_termino)
            MsgBox("Descuento finalizado correctamente", vbInformation, "Descuento finalizado")
            RellenarDataSet()
        End If
    End Sub

    Private Function RealizarValidacion()
        Dim cumple As Boolean = True

        Dim pal As String = ""
        Dim fecha_inicio As String = dtpInicio.Value.Date.ToString("yyyy-MM-dd")
        Dim fecha_termino As String = dtpTermino.Value.Date.ToString("yyyy-MM-dd")

        'VALIDAR QUE NO SE EDITEN DESCUENTOS CADUCADOS -> ok   

        If activeAgregar Then   'si se esta agregando un descuento...

            If label.Text <> "0" Then 'cmbProducto.SelectedIndex >= 0 Then  '¿el combo producto tiene seleccionado un item?                
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

                If dgvProductos.Enabled = True And cumple = True Then
                    'MsgBox("entre")
                    If dgvProductos.Rows.Count > 0 Then
                        Dim existe As Boolean = False 'si es que encuentra el producto del dgvProducto en el dgvDescuento
                        Dim prod_selec As String = dgvProductos.CurrentRow.Cells(1).Value 'obtiene el nombre del producto
                        Dim indice_encontrado As Integer
                        For index = 0 To dgvDescuentos.Rows.Count - 1   'recorremos dgvDescuento
                            MsgBox("dgvDesc: " & dgvDescuentos.Rows(index).Cells(1).Value & " DgvProd" & prod_selec)
                            If dgvDescuentos.Rows(index).Cells(1).Value.Equals(prod_selec) Then 'si dgvDescuento columna nombreproducto es igual al nombre de descuento selecc en dgvDescuetno
                                'MsgBox(dgvDescuentos.Rows(index).Cells(1).Value.Equals(descuento_selec))
                                existe = True 'si existe entonces 
                                MsgBox("existe")
                                indice_encontrado = dgvDescuentos.Rows(index).Index
                            End If
                        Next
                        'MsgBox("existe: " & existe)
                        If existe = False Then 'si no existe entonces se agrega
                            cumple = True
                        Else    'si existe
                            If existe = True Then
                                MsgBox("existeee")
                                Dim fecha_ini As String = dgvDescuentos.Rows(indice_encontrado).Cells(2).Value 'tomamos la fecha de inicio del descuento que existe
                                Dim fecha_ter As String = dgvDescuentos.Rows(indice_encontrado).Cells(3).Value 'tomamos la fecha de termino del descuento que existe
                                If fecha_ini > fecha_ter Then 'si la fecha de inicio es mayor a la fecha de termino entonces significa que ya no existe un descuento asociado al producto
                                    cumple = True 'cumple = true
                                Else
                                    cumple = False 'sino
                                    MsgBox("No se puede agregar un descuento porque existe un producto ya asociado a uno. Finalice el descuento para poder agregar", vbInformation, "Descuento ya asociado")
                                End If
                            End If
                        End If
                    End If
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

        'MsgBox(cumple)
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
            id_prod = label.Text             'value tirara el id del producto, selecteditem el texto del producto
            fec_ini = dtpInicio.Value.ToShortDateString     'fecha de inicio del descuento
            fec_ter = dtpTermino.Value.ToShortDateString    'fecha de termino 
            con = GetCondicion()                            '10X05'            
            If activeEditar Then
                id_des = label.Text
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
                MsgBox("Descuento agregado correctamente", vbInformation, "Descuento agregado")
            ElseIf activeEditar Then
                bsnDescuento.ModificarDescuento(ObjetoDescuento)
                MsgBox("Descuento modificado correctamente", vbInformation, "Descuento editado")
            End If
            'cmbP1Mayor.SelectedIndex = -1
            'cmbP2Mayor.SelectedIndex = -1
            'cmbProducto.SelectedIndex = -1
            'cmbP1Porcentual.SelectedIndex = -1
            'cmbP2Porcentual.SelectedIndex = -1
            dtpInicio.Value = DateTime.Now
            dtpTermino.Value = DateTime.Now

            'cmbProducto.Enabled = False
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
            mnsDes.Enabled = True
            RellenarDataSet()

            '---
            dgvDescuentos.Enabled = True
            dgvProductos.Enabled = False
            recargarDGV()
            cmbBusqueda.Enabled = False
            txtBusqueda.Enabled = False
            btnBuscar.Enabled = False
            llenado_descuento()
            '---

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
        cmbP1Mayor.SelectedIndex = 0
        cmbP2Mayor.SelectedIndex = 0
        'cmbProducto.SelectedIndex = -1
        cmbP1Porcentual.SelectedIndex = 0
        cmbP2Porcentual.SelectedIndex = 0
        dtpInicio.Value = DateTime.Now
        dtpTermino.Value = DateTime.Now
        'cmbProducto.Enabled = False
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
        '---
        dgvDescuentos.Enabled = True
        dgvProductos.Enabled = False
        recargarDGV()
        cmbBusqueda.Enabled = False
        txtBusqueda.Enabled = False
        btnBuscar.Enabled = False
        llenado_descuento()
        '---
        mnsDes.Enabled = True
    End Sub

    Private Sub cbxMayor_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMayor.CheckStateChanged
        'MsgBox("MAYOR CHANGED: " & cbxMayor.CheckState & " " & cbxPorcentual.CheckState)
        If activeEditar = True Or activeAgregar = True Then
            If cbxMayor.CheckState = 0 Then
                cbxMayor.Enabled = False
                cmbP1Mayor.Enabled = False
                cmbP2Mayor.Enabled = False
                cmbP1Mayor.SelectedIndex = 0
                cmbP2Mayor.SelectedIndex = 0
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

                cmbP1Porcentual.SelectedIndex = 0
                cmbP2Porcentual.SelectedIndex = 0

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
    Public Sub recargarDGV()
        If dgvProductos.Enabled = True Then
            dataset = BsnProd.ObtenerTodosLosProductos()
            dgvProductos.DataSource = dataset.Tables(0).DefaultView
            llenado()
        Else
            dgvProductos.DataSource = Nothing
        End If
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If btnSeleccionadoPrimeraVez = True Then
            If txtBusqueda.Text.Length = 0 Then
                recargarDGV()
                llenado()
            End If
        End If
    End Sub
    Public Sub llenado()
        If dgvProductos.Rows.Count > 0 Then
            label.Text = dgvProductos.CurrentRow.Cells(0).Value
            txtProducto.Text = dgvProductos.CurrentRow.Cells(1).Value
        Else
            label.Text = "0"
            txtProducto.Text = "Seleccione un producto de la tabla"
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text <> "" Then
            btnSeleccionadoPrimeraVez = True
            Dim tipoBusqueda As String = cmbBusqueda.Text.ToLower()
            Dim tabla As String = "Productos"
            Dim dataset_b As New DataSet
            Dim busqueda2 As New Busqueda2
            'MsgBox(txtBusqueda.Text)
            Select Case tipoBusqueda
                Case "id producto"
                    dataset_b = busqueda2.busquedaIncremental("Id_producto,Nombre", tabla, "Id_producto", txtBusqueda.Text)
                    dgvProductos.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case "producto"
                    dataset_b = busqueda2.busquedaIncremental("Id_producto,Nombre", tabla, "Nombre", txtBusqueda.Text)
                    dgvProductos.DataSource = dataset_b.Tables(0).DefaultView
                    llenado()
                Case ""
                    MsgBox("Seleccione un item de busqueda", vbInformation, "Item requerido")
            End Select
        End If
    End Sub
    Private Sub dgvProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        llenado()
    End Sub
End Class


