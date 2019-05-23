Imports System.ComponentModel

Public Class frmProd2

    Protected usuario As Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones


    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]



    Protected dataset As New DataSet
    Protected dataset2 As New DataSet


    'SECCION DE VALIDACION
    Protected condicion As Byte
    Protected largo As Short


    Public Sub RecibirUsuario(objeto As Usuario)
        usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema
        'MsgBox("ID-USUARIO : " & usuario.IdUsuario)


    End Sub


    Public Sub DesbloquearBotonesProd(page As String) 'Metodo para tabProductos


        'page equivale a la pestaña seleccionada en el tabcontrol1
        'MsgBox(TabControl1.SelectedTab.Text)
        If page.Equals("Simple") Or page.Equals("Simple-y-Avanzado") Then        'equivale al tabSimple
            'MsgBox("entre 1")
            'LABELES
            lblSimpleId.Enabled = True
            lblSimpleProd.Enabled = True
            lblSimpleCat.Enabled = True
            lblSimpleId.Enabled = True
            lblSimplePrecio.Enabled = True
            lblSimpleStock.Enabled = True
            lblSimpleStockCrit.Enabled = True
            lblSimpleCantidad.Enabled = True
            lblSimpleRazon.Enabled = True
            'TXT , COMBO y NUD
            cmbSimpleRazon.Enabled = True
            nupSimpleCantidad.Enabled = True

        End If
        If page.Equals("Avanzado") Or page.Equals("Simple-y-Avanzado") Then     'equivale al tabAvanzado
            'MsgBox("entre")
            'LABELES
            lblAvanzadoId.Enabled = True
            lblAvanzadoProd.Enabled = True
            lblAvanzadoCat.Enabled = True
            lblAvanzadoRazon.Enabled = True
            lblAvanzadoPrecio.Enabled = True
            lblAvanzadoStock.Enabled = True
            lblAvanzadoStockCrit.Enabled = True
            'TXT Y COMBO
            txtAvanzadoProd.Enabled = True
            cmbAvanzadoCat.Enabled = True
            cmbAvanzadoRazon.Enabled = True
            txtAvanzadoPrecio.Enabled = True
            txtAvanzadoStock.Enabled = True
            txtAvanzadoStockCrit.Enabled = True
        End If

        'BOTONES
        btnAce.Enabled = True
        btnCan.Enabled = True
    End Sub

    Public Sub bloquearBotonesProd(page As String) 'Metodo para tabProductos
        'page equivale a la pestaña seleccionada, en el tabControl1
        If page.Equals("Simple") Or page.Equals("Simple-y-Avanzado") Then
            'LABELES
            lblSimpleId.Enabled = False
            lblSimpleProd.Enabled = False
            lblSimpleCat.Enabled = False
            lblSimpleId.Enabled = False
            lblSimplePrecio.Enabled = False
            lblSimpleStock.Enabled = False
            lblSimpleStockCrit.Enabled = False
            lblSimpleCantidad.Enabled = False
            lblSimpleRazon.Enabled = False
            'TXT , COMBO y NUD
            cmbSimpleRazon.Enabled = False
            nupSimpleCantidad.Enabled = False
            'Otro            
            btnSimpleEliminar.Enabled = False
            btnSimpleEliminar.Visible = False

        End If
        If page.Equals("Avanzado") Or page.Equals("Simple-y-Avanzado") Then
            'LABELES
            lblAvanzadoId.Enabled = False
            lblAvanzadoProd.Enabled = False
            lblAvanzadoCat.Enabled = False
            lblAvanzadoRazon.Enabled = False
            lblAvanzadoPrecio.Enabled = False
            lblAvanzadoStock.Enabled = False
            lblAvanzadoStockCrit.Enabled = False
            'TXT Y COMBO
            txtAvanzadoProd.Enabled = False
            cmbAvanzadoCat.Enabled = False
            cmbAvanzadoRazon.Enabled = False
            txtAvanzadoPrecio.Enabled = False
            txtAvanzadoStock.Enabled = False
            txtAvanzadoStockCrit.Enabled = False
        End If

        'BOTONES
        btnAce.Enabled = False
        btnCan.Enabled = False
    End Sub

    Public Sub OpcionesMenuStripProd(estado As String)
        If (estado = "bloqueadas") Then
            tsmAgregar.Enabled = False
            tsmEditar.Enabled = False
            tsmEliminar.Enabled = False
        ElseIf (estado = "desbloqueadas") Then
            tsmAgregar.Enabled = True
            tsmEditar.Enabled = True
            tsmEliminar.Enabled = True
        End If
    End Sub
    Public Sub LimpiarControl1(page As String)
        If page.Equals("Simple") Or page.Equals("Simple-y-Avanzado") Then
            '//LIMPIAR SIMPLE
            lblSimpleProd.Text = "PRODUCTO     : "
            lblSimpleCat.Text = "CATEGORIA    : "
            lblSimpleId.Text = "ID PRODUCTO : "
            lblSimplePrecio.Text = "PRECIO              :"
            lblSimpleStock.Text = "STOCK               :"
            lblSimpleStockCrit.Text = "STOCK CRITICO       :"
            nupSimpleCantidad.Value = 0
            cmbSimpleRazon.SelectedIndex = -1
        End If
        If page.Equals("Avanzado") Or page.Equals("Simple-y-Avanzado") Then
            '//LIMPIAR AVANZADO
            txtAvanzadoProd.Text = ""
            lblAvanzadoId.Text = "ID PRODUCTO : "
            txtAvanzadoPrecio.Text = ""
            txtAvanzadoStock.Text = ""
            txtAvanzadoStockCrit.Text = ""
            cmbAvanzadoRazon.SelectedIndex = -1

        End If
    End Sub
    Public Sub name_no_definido()
        cmbAvanzadoRazon.Items.Clear() 'Limpieza del combobox Razon AVANZADO pero para administradores, se eliminan todos los items
        cmbSimpleRazon.Items.Clear()   'Limpieza del combobox Razon pero para USUARIOS, se eliminan los items

        TabControl1.Enabled = True 'Tabcontrol1 es en el que el usuario puede modificar el precio o escribir en los textbox 
        tbpSimple.Enabled = True   'TabcontrolSimple habilitado para interactuar
        tbpAvanzado.Enabled = True 'TabcontrolAvanzado habilitado para interactuar

        Dim enumeracion As New Enumeraciones
        If (Not activeAgregar) And (Not activeEditar) And (Not activeEliminar) Then 'Si es que no se presiona ningun boton del menuStrip o se presiona aceptar/cancelar            
            LimpiarControl1("Simple-y-Avanzado")              'Limpiar los componentes de los tab avanzado y simple
            TabControl1.Enabled = False                       'Bloqueo del tabcontrol1 ya que no se selecciona ninguna funcion agregar editar eliminar
            TabControl1.SelectedTab = tbpSimple               'El predeterminado para mostrar el tabsimple
            bloquearBotonesProd("Simple-y-Avanzado")
            OpcionesMenuStripProd("desbloqueadas")  'se desbloquean las opciones AGREGAR - EDITAR - ELIMINAR

        ElseIf activeAgregar Then                       'Si se presiona el boton agregar del menu strip  

            TabControl1.SelectedTab = tbpSimple         'se selecciona por defecto el tab simple para mostrar
            DesbloquearBotonesProd("Simple-y-Avanzado") 'desbloqueo de botones para usuarios
            'en agregar avanzado no debe aparecer el id
            lblAvanzadoId.Visible = False
            LimpiarControl1("Avanzado")
            'Limpiar control avanzado equivale a limpiar TODO los txt y labeles

        ElseIf activeEditar Then                 'Si se apreta el boton editar del menu strip

            TabControl1.SelectedTab = tbpAvanzado   'se selecciona por defecto el tab avanzado.
            'tbpSimple.Visible = False
            tbpSimple.Enabled = False               'pestaña simple bloqueada, no se puede presionar            
            bloquearBotonesProd("Simple")           'bloquear los botones de la seccion simple            
            DesbloquearBotonesProd("Avanzado")      'desbloquear los botones de la seccion avamzada            

            txtAvanzadoStock.Enabled = False
            cmbAvanzadoRazon.Enabled = False
            lblAvanzadoRazon.Enabled = False

        ElseIf activeEliminar Then 'activar para eliminar

            TabControl1.SelectedTab = tbpSimple     'tab predeterminado en simple
            bloquearBotonesProd("Avanzado")         'bloquear la seccion avanzada
            DesbloquearBotonesProd("Simple")        'desbloquear la seccion simple

            'MsgBox(usuario.Permisos)
            If usuario.Permisos = 3 Then            'Si el usuario es ADMINISTRADOR
                btnSimpleEliminar.Visible = True    'el boton de eliminar por completo se hace visible
                btnSimpleEliminar.Enabled = True    'se le activa el boton de eliminar por completo
            Else
                If usuario.Permisos <> 3 Then           'Si el usuario es un empleado
                    btnSimpleEliminar.Visible = False   'No se le muestra el boton eliminar por completo
                    btnSimpleEliminar.Enabled = False   'No se le activa el boton eliminar por completo
                End If
            End If

        End If
    End Sub
    Private Sub frmProd2_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'MsgBox("permiso" & usuario.Permisos)
        name_no_definido()                                      'Al iniciar el form, se bloquean todos los componentes excepto los menuStrip
        RellenarDataSet()                                       'Se rellena un dataset con todos los productos



        TabControl1.SelectedTab = tbpSimple
        If usuario.Permisos < 2 Then
            TabControl1.Visible = False
            btnAce.Visible = False
            btnCan.Visible = False
            OpcionesMenuStripProd("bloqueadas")
        Else
            TabControl1.Visible = True
            btnAce.Visible = True
            btnCan.Visible = True
            OpcionesMenuStripProd("desbloquedas")
        End If



    End Sub



    '#####################################################
    '             SELECCION DEL USUARIO EN MENUSTRIP AL
    '             HACER CLICK EN AGREGAR EDITAR O ELIMINAR
    '             
    '             al hacer click en uno de estos, se vuelve true
    '             y los otros quedan en false
    '#####################################################

    Private Sub tsmAgregar_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        'si se apreta agregar, activeAgregar se vuelve true mientras que editar y eliminar estan en false
        activeAgregar = True
        activeEditar = False
        activeEliminar = False
        MsgBox("Agregando")
        name_no_definido()
        RellenarCmbRazon()
        OpcionesMenuStripProd("bloqueadas")
    End Sub

    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        activeAgregar = False
        activeEditar = True
        activeEliminar = False
        MsgBox("Editan")
        name_no_definido()
        RellenarCmbRazon()
        OpcionesMenuStripProd("bloqueadas")
    End Sub

    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        activeAgregar = False
        activeEditar = False
        activeEliminar = True
        MsgBox("Elimi")
        name_no_definido()
        RellenarCmbRazon()
        OpcionesMenuStripProd("bloqueadas")
    End Sub

    '#####################################################
    '           BOTONES ACEPTAR-ELIMINAR
    '#####################################################
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click

        activeAgregar = False
        activeEditar = False
        activeEliminar = False
        name_no_definido()

    End Sub

    Private Sub RellenarDataSet()
        Dim bsnProducto As New BsnProducto()
        Dim bsnCategoria As New BsnCategoria()
        dataset = bsnProducto.ObtenerTodosLosProductos()
        Me.dgvProd.DefaultCellStyle.BackColor = Color.Beige
        dgvProd.DataSource = dataset.Tables(0).DefaultView
        'Me.dgvProd.Columns(2).DefaultCellStyle.Format = "c"

        dataset2 = bsnCategoria.ObtenerCategorias()
        For i = 0 To dataset2.Tables(0).Rows.Count - 1
            cmbAvanzadoCat.Items.Add(dataset2.Tables(0)(i)(1))
        Next


        If dgvProd.Rows.Count > 0 Then
            dgvProd.Rows(0).Selected = False
        End If

    End Sub

    Public Function RellenarObjeto(page As String)
        'MsgBox("Page: " & page)

        If page.Equals("Simple") Then '---> Agregar y eliminar stock
            Dim producto2 As New Producto
            'Simple ---> obtener objeto de la bd
            Dim bsnProducto As New BsnProducto

            producto2 = bsnProducto.ObtenerObjetoProducto(aux)
            If activeAgregar Then
                producto2.Stock = producto2.Stock + Integer.Parse(nupSimpleCantidad.Text)
            ElseIf activeEliminar Then
                producto2.Stock = producto2.Stock - Integer.Parse(nupSimpleCantidad.Text)
            End If
            Return producto2
        Else
            If page.Equals("Avanzado") Then
                Dim producto2 As New Producto
                'Avanzado --> rellenar desde los txt 
                producto2.IdProducto = aux
                producto2.Nombre = txtAvanzadoProd.Text
                producto2.Precio = Integer.Parse(txtAvanzadoPrecio.Text)
                producto2.Stock = Integer.Parse(txtAvanzadoStock.Text)
                producto2.StockCritico = Integer.Parse(txtAvanzadoStockCrit.Text)
                Return producto2

            End If
        End If

        Return ""
    End Function

    Private Sub btnAce_Click(sender As Object, e As EventArgs) Handles btnAce.Click
        Dim producto As Producto
        If activeAgregar Then   'Si se esta agregando un producto            
            Dim bsnProducto As New BsnProducto

            If TabControl1.SelectedTab.Text.Equals("Simple") Then
                'si es tab es simple, quiere decir que el usuario esta agregando cantidad, por lo que 
                'se modifica el stock del producto, no es que se agregue uno a la coleccion.
                'se obtiene el producto seleccionado en el dgv. El elemento seleccionado pasa como 'aux'
                'y luego en rellenarObjeto, solo se obtiene el producto y se suma o eliminar stock

                If Not (validacionesAlClickearAceptar("Simple")) Then
                    MsgBox("Por favor complete los campos faltantes...")
                    Return
                Else
                    producto = RellenarObjeto(TabControl1.SelectedTab.Text) ' - -> retorna objeto??            
                    bsnProducto.ModificarProducto(producto, cmbAvanzadoRazon.SelectedItem, usuario.Rut)
                End If
            ElseIf TabControl1.SelectedTab.Text.Equals("Avanzado") Then
                'Aqui si se agrega el producto a la coleccion
                'el objeto 'producto' es una "rellenacion" de los txt y cmb del tab avanzado
                MsgBox("avanzado")
                If Not (validacionesAlClickearAceptar("Avanzado")) Then
                    MsgBox("Por favor complete los campos faltantes...")
                    Return
                Else
                    MsgBox("correcto")
                    producto = RellenarObjeto(TabControl1.SelectedTab.Text) ' - -> retorna objeto??            
                    bsnProducto.AgregarProducto(producto, cmbAvanzadoRazon.SelectedItem, usuario.Rut)  'si es avanzado, es para agregar un producto
                End If

            End If

        ElseIf activeEditar Then
            MsgBox("MODIFICANDO PRODUCTO ")
            Dim bsnProducto As New BsnProducto
            MsgBox("rellenar ob")

            If Not (validacionesAlClickearAceptar("Avanzado")) Then
                MsgBox("Por favor complete los campos faltantes...")
                Return
            Else
                MsgBox("correcto")
                producto = RellenarObjeto(TabControl1.SelectedTab.Text)
                bsnProducto.ModificarProducto(producto, cmbAvanzadoRazon.SelectedItem, usuario.Rut)
            End If
        ElseIf activeEliminar Then
            MsgBox("Eliminar --> Version Modificar ")
            MsgBox(nupSimpleCantidad.Text)
            MsgBox("ELIMINANDO PRODUCTO")
            Dim bsnProducto As New BsnProducto
            If Not (validacionesAlClickearAceptar("Simple")) Then
                MsgBox("Por favor complete los campos faltantes...")
                Return
            Else
                producto = RellenarObjeto(TabControl1.SelectedTab.Text)
                bsnProducto.ModificarProducto(producto, cmbAvanzadoRazon.SelectedItem, usuario.Rut)
            End If

        End If

        LimpiarControl1("Simple-y-Avanzado")
        RellenarDataSet()
        activeAgregar = False
        activeEditar = False
        activeEliminar = False
        name_no_definido()
    End Sub

    Private Sub btnSimpleEliminar_Click(sender As Object, e As EventArgs) Handles btnSimpleEliminar.Click
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("¿Está seguro de eliminar?", style, "ALERTA DE ELIMINACION") '6->SI  7->NO'
        'MsgBox(response)

        If response = 6 Then
            Dim bsnProducto As New BsnProducto
            Dim producto As New Producto
            producto = RellenarObjeto(TabControl1.SelectedTab.Text) ' - -> retorna objeto??
            bsnProducto.EliminarProducto(producto, usuario.Rut)
            RellenarDataSet()
        End If
        activeAgregar = False
        activeEditar = False
        activeEliminar = False
        name_no_definido()
    End Sub
    Private Sub RellenarCmbRazon()
        cmbAvanzadoRazon.Items.Clear()
        If activeAgregar Then
            MsgBox("Llenado de CMB en Agregar")
            cmbAvanzadoRazon.Items.Add("Comprado")
            cmbAvanzadoRazon.Items.Add("Econtrado")

            cmbSimpleRazon.Items.Add("Comprado")
            cmbSimpleRazon.Items.Add("Econtrado")

        ElseIf activeEditar Then
            MsgBox("Llenado de CMB en Editar")
            cmbAvanzadoRazon.Items.Add("Comprado")
            cmbAvanzadoRazon.Items.Add("Vendido")
            cmbAvanzadoRazon.Items.Add("Extraviado")
            cmbAvanzadoRazon.Items.Add("Deteriodado")
            cmbAvanzadoRazon.Items.Add("Econtrado")

            cmbSimpleRazon.Items.Add("Comprado")
            cmbSimpleRazon.Items.Add("Vendido")
            cmbSimpleRazon.Items.Add("Extraviado")
            cmbSimpleRazon.Items.Add("Deteriodado")
            cmbSimpleRazon.Items.Add("Econtrado")

        ElseIf activeEliminar Then
            MsgBox("Llenado de CMB en Eliminar")

            cmbSimpleRazon.Items.Add("Vendido")
            cmbSimpleRazon.Items.Add("Extraviado")
            cmbSimpleRazon.Items.Add("Deteriodado")



        End If

    End Sub

    'FIN TAB PRODUCTOS

    Public Sub RellenarControl1(page As String, indice As Short)
        If page.Equals("Simple") Or page.Equals("Simple-y-Avanzado") Then
            '//RELLENAR SIMPLE
            lblSimpleId.Text = "ID PRODUCTO : " & dgvProd.Rows(indice).Cells(0).Value.ToString()
            lblSimpleProd.Text = "PRODUCTO     : " & dgvProd.Rows(indice).Cells(1).Value.ToString()
            lblSimplePrecio.Text = "PRECIO              :$" & dgvProd.Rows(indice).Cells(2).Value.ToString()
            lblSimpleStock.Text = "STOCK               :" & dgvProd.Rows(indice).Cells(3).Value.ToString()
            lblSimpleStockCrit.Text = "STOCK CRITICO       :" & dgvProd.Rows(indice).Cells(4).Value.ToString()
            lblSimpleCat.Text = "CATEGORIA    : "
        End If
        If page.Equals("Avanzado") Or page.Equals("Simple-y-Avanzado") Then
            '//RELLENAR AVANZADO
            lblAvanzadoId.Text = "ID PRODUCTO : " & dgvProd.Rows(indice).Cells(0).Value.ToString()
            txtAvanzadoProd.Text = dgvProd.Rows(indice).Cells(1).Value.ToString()
            txtAvanzadoPrecio.Text = dgvProd.Rows(indice).Cells(2).Value.ToString()
            txtAvanzadoStock.Text = dgvProd.Rows(indice).Cells(3).Value.ToString()
            txtAvanzadoStockCrit.Text = dgvProd.Rows(indice).Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub dgvProd_Click(sender As Object, e As EventArgs) Handles dgvProd.Click
        Dim indice As Short = dgvProd.CurrentRow.Index     'Fila seleccionada
        RellenarControl1("Simple-y-Avanzado", indice)
        aux = dgvProd.Rows(indice).Cells(0).Value       'tomamos el primer campo que corresponde al id del producto        
    End Sub

    Private Sub SeleccionTabControl1(sender As Object, e As EventArgs)
        '################ EVENTO #################
        '       Cuando se cambia de pestaña
        '#########################################
        If activeEditar Then
            tbpSimple.Visible = False
            tbpAvanzado.Visible = True
            TabControl1.SelectedTab = tbpAvanzado
        Else
            If activeEliminar Then
                tbpAvanzado.Visible = False
                tbpSimple.Visible = True
                TabControl1.SelectedTab = tbpSimple
            End If
        End If
    End Sub



    '#######################################
    '       VALIDACION
    '#######################################
    Private Sub txtAvanzadoPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        condicion = 10
        largo = txtAvanzadoPrecio.Text.Length
        If Not (Validaciones.soloNumeros(largo, e, condicion)) Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtAvanzadoProd_KeyPress(sender As Object, e As KeyPressEventArgs)
        condicion = 10
        largo = txtAvanzadoProd.Text.Length
        If Not (Validaciones.numerosYLetras(largo, e, condicion)) Then
            e.Handled = True
        End If

    End Sub
    Private Sub txtAvanzadoStock_KeyPress(sender As Object, e As KeyPressEventArgs)
        condicion = 10
        largo = txtAvanzadoStock.Text.Length
        If Not (Validaciones.soloNumeros(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtAvanzadoStockCrit_KeyPress(sender As Object, e As KeyPressEventArgs)
        condicion = 10
        largo = txtAvanzadoStockCrit.Text.Length
        If Not (Validaciones.soloNumeros(largo, e, condicion)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub cmbSimpleRazon_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim index As Short = cmbSimpleRazon.SelectedIndex
        Dim correcto As Boolean = Validaciones.distintoACeroIndexCmb(index)

    End Sub

    Public Function validacionesAlClickearAceptar(page As String)
        Dim correcto As Boolean = True
        If (page.Equals("Simple")) Then     'si esta en la pestaña simple
            'solo el combobox razon
            If (cmbSimpleRazon.SelectedIndex = -1) Then
                correcto = False
            End If
        Else
            MsgBox(txtAvanzadoPrecio.Text.Length & " txtavanzadoprecio")
            If (page.Equals("Avanzado")) Then   'si esta en la pantalla avanzada
                If (txtAvanzadoPrecio.Text = "" Or txtAvanzadoProd.Text = "" Or txtAvanzadoStock.Text = "" Or txtAvanzadoStockCrit.Text = "" Or cmbAvanzadoCat.SelectedIndex = -1 Or cmbAvanzadoRazon.SelectedIndex = -1) Then
                    correcto = False
                    MsgBox("incorrecto")
                End If
            End If
        End If
        Return correcto
    End Function


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Me.Close()
        'Me.Dispose()
    End Sub


End Class