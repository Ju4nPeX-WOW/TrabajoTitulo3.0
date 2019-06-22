Public Class FrmCate


    Protected usuario As Usuario '------------------------>Recepción del usuario que usa el sistema
    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones


    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]


    Protected dgv1 As Boolean = False  'cuando el usuario selecciona un item del dgv1 se torna verdadero
    Protected dgv2 As Boolean = False   'cuando el usuario selecciona un item del dgv2 se torna verdadero
    Protected dgv3 As Boolean = False 'cuando el usuario selecciona un item del dgv3 se torna verdadero


    'Otras Variables
    Private AfectoSubCat As Boolean = False
    Private idaux As String = ""
    Private indexCodDGV1, indexCodDGV2, indexCodDGV3 As Short


    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    Private Sub FrmCate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CREACION DE COLECCIONES
        listaDeObjetosForm = CrearColeccion() 'se carga la lista con los objetos del formulario
        listaTSMDelForm = CrearColeccionTMS() 'se carga la lista con los tsm
        listaDeObjetosRellenables = CrearColeccionRellenable()

        'SE ESTABLECEN CONFIGURACION POR DEFECTO
        Reset()

    End Sub

    Private Function CrearColeccion()
        Dim coleccion As New List(Of Object)
        'LABELES
        coleccion.AddRange({lblId, lblNombre, lblCodigo, lblCateBase, lblSubCate})

        'TXT , COMBO y NUD
        coleccion.AddRange({txtNombre,
                           btnAceCat, btnCanCat})

        Return coleccion

    End Function
    Private Function CrearColeccionRellenable()
        Dim coleccion As New List(Of Object)

        coleccion.AddRange({lblaux, lblId, txtNombre, txtCodigo})

        Return coleccion

    End Function
    Private Function CrearColeccionTMS()
        Dim coleccion As New List(Of Object)

        coleccion.AddRange({tsmAgregar, tsmEditar, tsmEliminar})

        Return coleccion

    End Function


    Private Sub ObtenerDataSet(n As Short, dig As String)
        Dim bsnCategoria As New BsnCategoria()

        If n = 1 Then
            dataset_padre = bsnCategoria.ObtenerCategoriasBase


            For i = 0 To dataset_padre.Tables(0).Rows.Count - 1

                'MsgBox("Data set 1: " + dataset.Tables(0)(i)(2).ToString)
            Next
        ElseIf n = 2 Then
            dataset_padre = bsnCategoria.ObtenerSubCategoria(dig)

            For i = 0 To dataset_padre.Tables(0).Rows.Count - 1

                'MsgBox("Data set 2: " + dataset.Tables(0)(i)(2).ToString)
            Next
        ElseIf n = 3 Then
            dataset_padre = bsnCategoria.ObtenerSubSubCategoria(dig)

            For i = 0 To dataset_padre.Tables(0).Rows.Count - 1

                'MsgBox("Data set 3: " + dataset.Tables(0)(i)(2).ToString)
            Next

        End If



    End Sub

    Private Sub EstructurarDGV(dgv As Object)
        dgv.DefaultCellStyle.BackColor = Color.Beige
        dgv.ColumnCount = 3
        dgv.Columns(0).Name = "Id"
        dgv.Columns(1).Name = "Nombre"
        dgv.Columns(2).Name = "Codigo"

        dgv.Columns(1).DataPropertyName = "Nombre"
        dgv.Columns(2).DataPropertyName = "Codigo"

    End Sub


    Private Sub CleanDGV()
        dgvCateg.Rows.Clear()
        dgvSubCat.Rows.Clear()
        dgvSubSubCat.Rows.Clear()


    End Sub

    Private Sub dgvCateg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCateg.CellClick
        dgv1 = True
        dgv2 = False
        dgv3 = False
        indexCodDGV1 = dgvCateg.CurrentRow.Index
        'MsgBox("Index 1 : " & indexCodDGV1)
        dgvSubCat.Rows.Clear()

        EstructurarDGV(dgvSubCat) 'Estructurar y Dar formato al datagrid view

        idaux = dgvCateg.CurrentRow.Cells.Item(0).Value.ToString()
        Dim l = {dgvCateg.CurrentRow.Cells.Item(0).Value.ToString(),
                "ID CATEGORIA :" + dgvCateg.CurrentRow.Cells.Item(0).Value.ToString(),
                dgvCateg.CurrentRow.Cells.Item(1).Value.ToString(),
                dgvCateg.CurrentRow.Cells.Item(2).Value.ToString()}

        MyBase.RellenarDatos(listaDeObjetosRellenables, l) 'Se rellenan los label's y textbox's con el item seleccionado

        MyBase.SeleccionarCMB(cmbCategorias, dgvCateg.CurrentRow.Cells.Item(0).Value.ToString())

        ObtenerDataSet(2, ObtenerDigito(dgvCateg.CurrentRow.Cells.Item(2).Value.ToString(), 1))

        EstadoVar() ' Variable que uso para ver si al eliminar categoria, no afecto a subs categorias . Lo mismo con mover de nivel al editar

        MyBase.RellenarDGV(dataset_padre, dgvSubCat)

        If Not activeAgregar Then
            CheckBox3.Checked = False 'quitar el check al MODIFICAR NIVEL CAT
        End If
    End Sub


    Private Sub dgvSubCat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCat.CellClick
        dgv1 = True
        dgv2 = True
        dgv3 = False
        indexCodDGV2 = dgvSubCat.CurrentRow.Index
        'MsgBox("Index 2 : " & indexCodDGV2)

        dgvSubSubCat.Rows.Clear()

        EstructurarDGV(dgvSubSubCat) 'Estructurar y Dar formato al datagrid view

        idaux = dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString()

        Dim l = {dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
                "ID CATEGORIA :" + dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
                dgvSubCat.CurrentRow.Cells.Item(1).Value.ToString(),
                dgvSubCat.CurrentRow.Cells.Item(2).Value.ToString()}

        MyBase.RellenarDatos(listaDeObjetosRellenables, l) 'Se rellenan los label's y textbox's con el item seleccionado
        If Not activeAgregar Then
            CheckBox3.Checked = False 'quitar el check al MODIFICAR NIVEL CAT
        End If


        MyBase.SeleccionarCMB(cmbSubCategorias, dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString())

        ObtenerDataSet(3, ObtenerDigito(dgvSubCat.CurrentRow.Cells.Item(2).Value.ToString(), 2))

        EstadoVar() ' Variable que uso para ver si al eliminar categoria, no afecto a subs categorias
        ' Igual si modifico su nivel 


        MyBase.RellenarDGV(dataset_padre, dgvSubSubCat)

    End Sub


    Private Sub dgvSubSubCat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubSubCat.CellClick
        dgv1 = True
        dgv2 = True
        dgv3 = True
        indexCodDGV3 = dgvSubSubCat.CurrentRow.Index

        'MsgBox("Index 3 : " & indexCodDGV3)


        idaux = dgvSubSubCat.CurrentRow.Cells.Item(0).Value.ToString()

        Dim l = {dgvSubSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
                "ID CATEGORIA :" + dgvSubSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
                dgvSubSubCat.CurrentRow.Cells.Item(1).Value.ToString(),
                dgvSubSubCat.CurrentRow.Cells.Item(2).Value.ToString()}

        AfectoSubCat = True

        MyBase.RellenarDatos(listaDeObjetosRellenables, l) 'Se rellenan los label's y textbox's con el item seleccionado
        If Not activeAgregar Then
            CheckBox3.Checked = False 'quitar el check al MODIFICAR NIVEL CAT
        End If


    End Sub

    Private Sub RellenarCMB(n As Short, cod As String)
        cmbSubCategorias.Text = ""
        cmbSubCategorias.Items.Clear()

        If n = 1 Then
            cmbCategorias.Items.Clear()
            For i = 0 To dataset_padre.Tables(0).Rows.Count - 1

                cmbCategorias.Items.Add(dataset_padre.Tables(0)(i)(0).ToString + " - " + dataset_padre.Tables(0)(i)(1).ToString)

            Next

        ElseIf n = 2 Then
            ObtenerDataSet(2, ObtenerDigito(cod, 1))
            'MsgBox("RELLENANDO CMD 2 : " + cod + "- DIG: " + ObtenerDigito(cod, 1))

            For i = 0 To dataset_padre.Tables(0).Rows.Count - 1

                cmbSubCategorias.Items.Add(dataset_padre.Tables(0)(i)(0).ToString + " - " + dataset_padre.Tables(0)(i)(1).ToString)

            Next

        End If

    End Sub


    Private Function ObtenerCod(name As String)
        Dim cod As String = "0"
        For i = 0 To dataset_padre.Tables(0).Rows.Count - 1
            'MsgBox(dataset2.Tables(0)(i)(1).ToString)

            If dataset_padre.Tables(0)(i)(1).ToString.Equals(name) Then
                cod = dataset_padre.Tables(0)(i)(2).ToString

            End If
        Next
        Return cod
    End Function

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        MyBase.OpcionesMenuStrip(listaTSMDelForm, "bloqueadas")

        ''agregar
        activeAgregar = True
        activeEditar = False
        activeEliminar = False

        MyBase.DesbloquearBotones(listaDeObjetosForm)

        MyBase.BloquearBotones(ColeccionNivelCategoria)
        CheckBox3.Enabled = False

        dgvCateg.ClearSelection()
        dgvSubCat.Rows.Clear()
        dgvSubSubCat.Rows.Clear()

        MyBase.LimpiarDatos(listaDeObjetosRellenables, {"", "ID CATEGORIA :", "", ""})
        cmbCategorias.Text = ""
        cmbSubCategorias.Items.Clear()
        CheckBox3.Checked = True

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        If lblaux.Text.Equals("") Then
            MsgBox("SELECCIONE ELEMENTO")
        Else
            MyBase.OpcionesMenuStrip(listaTSMDelForm, "bloqueadas")
            MyBase.BloquearBotones(ColeccionNivelCategoria)

            ''editar
            activeAgregar = False
            activeEditar = True
            activeEliminar = False
            MyBase.DesbloquearBotones(listaDeObjetosForm)

            'Desabilitar()
            CheckBox3.Visible = True
            CheckBox3.Enabled = True
            CheckBox3.Checked = False
            'HabilitarNiveles()

        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        ''eliminar
        activeAgregar = False
        activeEditar = False
        activeEliminar = True


        If Validaciones.ConfirmarEliminacion = 6 Then
            If AfectoSubCat Then
                Dim bsnCategoria As New BsnCategoria
                bsnCategoria.EliminarCategoria(idaux)



                Reset()

            ElseIf Not AfectoSubCat Then
                MsgBox("No se puede eliminar la categoria tiene sub categorias
                    Por Favor elimine las sub categorias primero")
            End If
        End If



    End Sub

    Private Sub BtnAceCat_Click(sender As Object, e As EventArgs) Handles btnAceCat.Click
        Dim categoria As New Categoria
        Dim bsnCategoria As New BsnCategoria

        ''Declaramos las var auxiliares
        Dim _id, _nombre, _codigo As String



        ''Primero el Id
        If activeAgregar Then
            _id = ""
        ElseIf activeEditar Then
            _id = lblaux.Text
        End If

        ''Segundo el nombre
        _nombre = txtNombre.Text


        '' ID DEL CMB SELECCIONADO
        Dim idCMB As String = ""
        If CheckBox3.Checked And Not CheckBox1.Checked Then

            idCMB = cmbCategorias.SelectedItem.ToString()
            idCMB = idCMB.Substring(0, InStr(1, idCMB, "-") - 1)

            If Not CheckBox2.Checked Then

                idCMB = cmbSubCategorias.SelectedItem.ToString()
                idCMB = idCMB.Substring(0, InStr(1, idCMB, "-") - 1)

            End If
        End If
        'MsgBox("ID CMB CMB " & idCMB)


        ''LO COMPLICADO -> CODIGO
        If activeAgregar Then
            _codigo = ObtenerCodigoAInsertar("", idCMB)
        Else
            If activeEditar And CheckBox3.Checked Then
                _codigo = ObtenerCodigoAInsertar(txtCodigo.Text, idCMB)


            Else
                _codigo = txtCodigo.Text


            End If
        End If

        ''Cargar datos en objeto Categoria
        categoria.IdCateg = _id
        categoria.NomCateg = _nombre
        categoria.CodCateg = _codigo


        If categoria.CodCateg.Equals("0") Then
            MsgBox("SR USUARIO: Excedio el limite permitido de Categorias")
        Else
            If activeAgregar Then 'Si se esta agregando un categoria       
                bsnCategoria.AgregarCategoria(categoria)
            ElseIf activeEditar And Not lblaux.Text.Equals("") Then ''la parte lblaux -> deberia eliminarse


                'MsgBox("CODIGO CATEGORIA : " + categoria.CodCateg)
                bsnCategoria.EditarCategoria(categoria)

            End If

        End If

        Reset()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'CHECK BOX 2
        If cmbSubCategorias.Items.Count = 0 Then
            CheckBox2.Checked = True
        End If
        'MsgBox(cmbSubCategorias.Items.Count)

        If Not CheckBox2.Checked Then
            cmbSubCategorias.Enabled = True

        Else
            cmbSubCategorias.Enabled = False
        End If


    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If cmbCategorias.Items.Count = 0 Then
            CheckBox1.Checked = True
        End If

        If Not CheckBox1.Checked Then
            If txtCodigo.Text.Equals("") Then
                cmbCategorias.SelectedIndex = 0

            End If

        End If
        'CHECK BOX 1 
        If Not CheckBox1.Checked And cmbCategorias.Items.Count <> 0 Then
            cmbCategorias.Enabled = True
            CheckBox2.Enabled = True
            CheckBox2.Checked = True
        Else
            cmbCategorias.Enabled = False
            CheckBox2.Enabled = False
            'CheckBox2.Checked = False
            cmbSubCategorias.Enabled = False
        End If


    End Sub

    Private Sub cmbSubCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubCategorias.SelectedIndexChanged
        Dim id As String = cmbSubCategorias.SelectedItem.ToString()
        id = id.Substring(0, InStr(1, id, "-") - 1)
        'MsgBox("Id : " + id)
    End Sub



    Private Sub cmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategorias.SelectedIndexChanged
        Dim bsnCategorias As New BsnCategoria
        Dim id As String = cmbCategorias.SelectedItem.ToString()
        id = id.Substring(0, InStr(1, id, "-") - 1)
        'MsgBox("Id : " + id)

        RellenarCMB(2, bsnCategorias.ObtenerCodigo(id))
    End Sub

    Private Function ObtenerDigito(cod As String, n As Short)

        Dim dig As String = cod(0) + cod(1)

        If Not (n = 2) Then
            If dig(1) Like "0" Then
                dig = dig(0)
                'MsgBox("Digito dentro de obtener digito : " + dig)

            Else
                dig = dig(1)
                'MsgBox("Digito dentro de obtener digito : " + dig)
            End If
        End If



        Return dig
    End Function

    Private Sub btnCanCat_Click(sender As Object, e As EventArgs) Handles btnCanCat.Click
        Reset()


    End Sub


    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked Then
            If activeEditar Then
                If Not AfectoSubCat Then
                    CheckBox3.Checked = False 'quitar el check al MODIFICAR NIVEL CAT

                    MsgBox("No se puede modificar nivel de la categoria , ya que tiene sub categorias ")
                End If
            End If

        End If
        'CHECK BOX 3
        If CheckBox3.Checked Then
            'LO QUE SUCEDE AL ESTAR CHECKED

            CheckBox1.Enabled = True
            CheckBox1.Checked = True
        Else
            MyBase.BloquearBotones(ColeccionNivelCategoria)
        End If
    End Sub



    Private Sub Reset()
        'Limpiar DGV
        CleanDGV()
        'Estructurar y Rellenar DGV
        EstructurarDGV(dgvCateg)
        ObtenerDataSet(1, "")
        MyBase.RellenarDGV(dataset_padre, dgvCateg)
        RellenarCMB(1, "")
        'Limpiar TXT's - LABEL's - CMB's
        MyBase.LimpiarDatos(listaDeObjetosRellenables, {"", "ID CATEGORIA :", "", ""})
        cmbCategorias.Text = ""
        cmbSubCategorias.Text = ""
        'BLOQUEOS
        MyBase.BloquearBotones(listaDeObjetosForm)
        MyBase.BloquearBotones(ColeccionNivelCategoria)
        CheckBox3.Enabled = False
        MyBase.OpcionesMenuStrip(listaTSMDelForm, "desbloqueadas")
        CheckBox3.Visible = False
        CheckBox3.Checked = False

    End Sub


    'ELIMINAR : que si contiene sub categorias no se borre
    Private Sub EstadoVar()
        If dataset_padre.Tables(0).Rows.Count = 0 Then
            AfectoSubCat = True
        Else
            AfectoSubCat = False
        End If
    End Sub

    Private Function ColeccionNivelCategoria()
        Dim CNC As New List(Of Object)
        CNC.AddRange({CheckBox1, CheckBox2, cmbCategorias, cmbSubCategorias})
        Return CNC
    End Function

    '########################################################################################################
    '###############  MEJORA MEJORA MEJORA MEJORA MEJORA MEJORA MEJORA ######################################
    '########################################################################################################


    Function DeterminarNivelCategoria(c As String)
        'SE DETERNMINA EL NIVEL DE LA CATERIA A MODIFICAR
        Dim nivel As Byte = 0
        If Not c.Substring(3, 1).Equals("0") Then
            nivel = 3
        ElseIf Not c.Substring(2, 1).Equals("0") Then
            nivel = 3
        ElseIf Not c.Substring(1, 1).Equals("0") Then
            nivel = 2
        ElseIf Not c.Substring(0, 1).Equals("0") Then
            nivel = 1
        End If

        'MsgBox("La categoria esta en el nivel: " & nivel)
        Return nivel
    End Function

    Function ObtenerCodigoAInsertar(cod As String, id_cmb As String)
        'MsgBox("DENTRO De OBTENER CODIGO -> ENTRADA COD: " & cod & " ID_CMB: " & id_cmb)
        Dim bsnCategoria As New BsnCategoria

        Dim NivelCat As Byte = 0
        If activeEditar Then
            NivelCat = DeterminarNivelCategoria(cod)

        End If
        Dim meCod As String = cod
        Dim CMBCod As String = ""
        If activeEditar And Not CheckBox1.Checked Then
            CMBCod = bsnCategoria.ObtenerCodigo(id_cmb)
        End If
        Dim codFinal As String = ""

        If CheckBox3.Checked Then
            If CheckBox1.Checked Then
                'MsgBox(meCod.Substring(1, 3))



                If NivelCat = 1 Then
                    'MANTENER COD 
                    codFinal = meCod
                Else
                    codFinal = bsnCategoria.ObtenerCodigoBaseDisponible

                End If
                ''ObtenerCodCat()
                'MsgBox(codFinal)



            Else
                'definimos 
                Dim dig As String = ""

                ''Seleccionar Item Del CMD CAT
                If CheckBox2.Checked Then
                    'MsgBox("2 IDCMB" & id_cmb)

                    dig = bsnCategoria.ObtenerCodigo(id_cmb)
                    dig = ObtenerDigito(dig, 1)

                    If activeEditar Then
                        If NivelCat = 2 And meCod.Substring(0, 1).Equals(CMBCod.Substring(0, 1)) Then
                            'MANTENER COD 
                            codFinal = meCod
                        Else
                            codFinal = bsnCategoria.ObtenerSubCodigoDisponible(dig)

                        End If
                    Else
                        codFinal = bsnCategoria.ObtenerSubCodigoDisponible(dig)


                    End If
                    '' obtener digito

                    ''ObtenerSubCodCat()
                    'MsgBox(codFinal)


                Else
                    ''Seleccionar Item Del CMD SUBCAT
                    '' obtener dig

                    dig = bsnCategoria.ObtenerCodigo(id_cmb)
                    dig = ObtenerDigito(dig, 2)
                    If activeEditar Then
                        If NivelCat = 3 And meCod.Substring(0, 2).Equals(CMBCod.Substring(0, 2)) Then
                            'MANTENER COD 
                            codFinal = meCod

                        Else
                            codFinal = bsnCategoria.ObtenerSubSubCodigoDisponible(dig)

                        End If
                    Else
                        codFinal = bsnCategoria.ObtenerSubSubCodigoDisponible(dig)

                    End If


                    ''ObtenerSubSubCat()




                End If
            End If
        End If
        Return codFinal
    End Function

End Class


