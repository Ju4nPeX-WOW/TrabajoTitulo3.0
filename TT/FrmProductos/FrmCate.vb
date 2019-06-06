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
    Private idaux As String = ""
    Private indexCodDGV1, indexCodDGV2, indexCodDGV3 As Short


    Protected dataset As New DataSet
    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    Private Sub FrmCate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RellenarDataSet()
        BloquearBotones()
        RellenarCMB(1, "")



    End Sub

    Public Sub DesbloquearBotones()
        'LABELES
        lblId.Enabled = True
        lblNombre.Enabled = True
        lblCodigo.Enabled = True
        lblCateBase.Enabled = True
        lblSubCate.Enabled = True

        'TXT , COMBO y NUD
        txtCodigo.Enabled = False
        txtNombre.Enabled = True

        cmbCategorias.Enabled = True
        cmbSubCategorias.Enabled = True

        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        btnAceCat.Enabled = True
        btnCanCat.Enabled = True


        CheckBox3.Visible = False
        CheckBox3.Enabled = False

    End Sub

    Public Sub BloquearBotones()
        'LABELES
        lblId.Enabled = False
        lblNombre.Enabled = False
        lblCodigo.Enabled = False
        lblCateBase.Enabled = False
        lblSubCate.Enabled = False

        'TXT , COMBO y NUD
        txtCodigo.Enabled = False
        txtNombre.Enabled = False

        cmbCategorias.Enabled = False
        cmbSubCategorias.Enabled = False

        CheckBox1.Enabled = False
        CheckBox2.Enabled = False

        btnAceCat.Enabled = False
        btnCanCat.Enabled = False
    End Sub

    Private Sub ObtenerDataSet(n As Short, dig As String)
        Dim bsnCategoria As New BsnCategoria()

        If n = 1 Then
            dataset = bsnCategoria.ObtenerCategoriasBase


            For i = 0 To dataset.Tables(0).Rows.Count - 1

                'MsgBox("Data set 1: " + dataset.Tables(0)(i)(2).ToString)
            Next
        ElseIf n = 2 Then
            dataset = bsnCategoria.ObtenerSubCategoria(dig)

            For i = 0 To dataset.Tables(0).Rows.Count - 1

                'MsgBox("Data set 2: " + dataset.Tables(0)(i)(2).ToString)
            Next
        ElseIf n = 3 Then
            dataset = bsnCategoria.ObtenerSubSubCategoria(dig)

            For i = 0 To dataset.Tables(0).Rows.Count - 1

                'MsgBox("Data set 3: " + dataset.Tables(0)(i)(2).ToString)
            Next

        End If



    End Sub

    Private Sub RellenarDataSet()
        ObtenerDataSet(1, "")
        Me.dgvCateg.DefaultCellStyle.BackColor = Color.Beige
        Me.dgvCateg.ColumnCount = 3
        Me.dgvCateg.Columns(0).Name = "Id"
        Me.dgvCateg.Columns(1).Name = "Nombre"
        Me.dgvCateg.Columns(2).Name = "Codigo"

        dgvCateg.Columns(1).DataPropertyName = "Nombre"
        dgvCateg.Columns(2).DataPropertyName = "Codigo"



        For i = 0 To dataset.Tables(0).Rows.Count - 1
            dgvCateg.Rows.Add(dataset.Tables(0)(i)(0).ToString, dataset.Tables(0)(i)(1).ToString, dataset.Tables(0)(i)(2).ToString)

            'MsgBox(dataset.Tables(0)(i)(2).ToString)
        Next

        If dgvCateg.Rows.Count > 0 Then
            dgvCateg.Rows(0).Selected = False
        End If

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

        Me.dgvSubCat.DefaultCellStyle.BackColor = Color.Beige
        Me.dgvSubCat.ColumnCount = 3
        Me.dgvSubCat.Columns(0).Name = "Id"
        Me.dgvSubCat.Columns(1).Name = "Nombre"
        Me.dgvSubCat.Columns(2).Name = "Codigo"

        dgvSubCat.Columns(1).DataPropertyName = "Nombre"
        dgvSubCat.Columns(2).DataPropertyName = "Codigo"

        idaux = dgvCateg.CurrentRow.Cells.Item(0).Value.ToString()

        RellenarDatos(dgvCateg.CurrentRow.Cells.Item(0).Value.ToString(),
                    dgvCateg.CurrentRow.Cells.Item(1).Value.ToString(),
                    dgvCateg.CurrentRow.Cells.Item(2).Value.ToString())

        SeleccionarCMB(cmbCategorias, dgvCateg.CurrentRow.Cells.Item(0).Value.ToString())

        ObtenerDataSet(2, ObtenerDigito(dgvCateg.CurrentRow.Cells.Item(2).Value.ToString(), 1))


        For i = 0 To dataset.Tables(0).Rows.Count - 1
            dgvSubCat.Rows.Add(dataset.Tables(0)(i)(0).ToString, dataset.Tables(0)(i)(1).ToString, dataset.Tables(0)(i)(2).ToString)

        Next

        If dgvSubCat.Rows.Count > 0 Then
            dgvSubCat.Rows(0).Selected = False
        End If





    End Sub


    Private Sub dgvSubCat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubCat.CellClick
        dgv1 = True
        dgv2 = True
        dgv3 = False
        indexCodDGV2 = dgvSubCat.CurrentRow.Index
        'MsgBox("Index 2 : " & indexCodDGV2)

        dgvSubSubCat.Rows.Clear()


        Me.dgvSubSubCat.DefaultCellStyle.BackColor = Color.Beige
        Me.dgvSubSubCat.ColumnCount = 3
        Me.dgvSubSubCat.Columns(0).Name = "Id"
        Me.dgvSubSubCat.Columns(1).Name = "Nombre"
        Me.dgvSubSubCat.Columns(2).Name = "Codigo"

        dgvSubSubCat.Columns(1).DataPropertyName = "Nombre"
        dgvSubSubCat.Columns(2).DataPropertyName = "Codigo"


        idaux = dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString()


        RellenarDatos(dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
                    dgvSubCat.CurrentRow.Cells.Item(1).Value.ToString(),
                    dgvSubCat.CurrentRow.Cells.Item(2).Value.ToString())

        SeleccionarCMB(cmbSubCategorias, dgvSubCat.CurrentRow.Cells.Item(0).Value.ToString())


        ObtenerDataSet(3, ObtenerDigito(dgvSubCat.CurrentRow.Cells.Item(2).Value.ToString(), 2))


        For i = 0 To dataset.Tables(0).Rows.Count - 1
            dgvSubSubCat.Rows.Add(dataset.Tables(0)(i)(0).ToString, dataset.Tables(0)(i)(1).ToString, dataset.Tables(0)(i)(2).ToString)

        Next

        If dgvSubSubCat.Rows.Count > 0 Then
            dgvSubSubCat.Rows(0).Selected = False
        End If





    End Sub


    Private Sub dgvSubSubCat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubSubCat.CellClick
        dgv1 = True
        dgv2 = True
        dgv3 = True
        indexCodDGV3 = dgvSubSubCat.CurrentRow.Index

        'MsgBox("Index 3 : " & indexCodDGV3)


        idaux = dgvSubSubCat.CurrentRow.Cells.Item(0).Value.ToString()


        RellenarDatos(dgvSubSubCat.CurrentRow.Cells.Item(0).Value.ToString(),
                    dgvSubSubCat.CurrentRow.Cells.Item(1).Value.ToString(),
                    dgvSubSubCat.CurrentRow.Cells.Item(2).Value.ToString())

    End Sub

    Private Sub RellenarCMB(n As Short, cod As String)
        cmbSubCategorias.Items.Clear()

        If n = 1 Then
            cmbCategorias.Items.Clear()
            For i = 0 To dataset.Tables(0).Rows.Count - 1

                cmbCategorias.Items.Add(dataset.Tables(0)(i)(0).ToString + " - " + dataset.Tables(0)(i)(1).ToString)

            Next

        ElseIf n = 2 Then
            ObtenerDataSet(2, ObtenerDigito(cod, 1))
            'MsgBox("RELLENANDO CMD 2 : " + cod + "- DIG: " + ObtenerDigito(cod, 1))

            For i = 0 To dataset.Tables(0).Rows.Count - 1

                cmbSubCategorias.Items.Add(dataset.Tables(0)(i)(0).ToString + " - " + dataset.Tables(0)(i)(1).ToString)

            Next

        End If

    End Sub
    Private Sub RellenarDatos(id As String, nombre As String, cod As String)
        lblaux.Text = id

        lblId.Text = "ID CATEGORIA :" + id
        txtNombre.Text = nombre
        txtCodigo.Text = cod
    End Sub
    Private Sub LimpiarDatos()
        lblId.Text = "ID CATEGORIA :"
        txtNombre.Text = ""
        txtCodigo.Text = ""

    End Sub




    Private Function ObtenerCod(name As String)
        Dim cod As String = "0"
        For i = 0 To dataset.Tables(0).Rows.Count - 1
            'MsgBox(dataset2.Tables(0)(i)(1).ToString)

            If dataset.Tables(0)(i)(1).ToString.Equals(name) Then
                cod = dataset.Tables(0)(i)(2).ToString

            End If
        Next
        Return cod
    End Function

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        ''agregar
        activeAgregar = True
        activeEditar = False
        activeEliminar = False

        DesbloquearBotones()
        txtNombre.Text = ""
        txtCodigo.Text = ""
        CheckBox3.Checked = True
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        ''editar
        activeAgregar = False
        activeEditar = True
        activeEliminar = False
        DesbloquearBotones()

        CheckBox1.Enabled = False
        CheckBox2.Enabled = False

        cmbCategorias.Enabled = False
        cmbSubCategorias.Enabled = False
        CheckBox3.Visible = True
        CheckBox3.Enabled = True

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        ''eliminar
        activeAgregar = False
        activeEditar = False
        activeEliminar = True



        Dim bsnCategoria As New BsnCategoria
        bsnCategoria.eliminarCategoria(idaux)



        Reset()


    End Sub

    Private Sub BtnAceCat_Click(sender As Object, e As EventArgs) Handles btnAceCat.Click
        Dim categoria As New Categoria

        Dim bsnCategoria As New BsnCategoria

        Dim id, dig As String
        id = ""
        dig = ""
        categoria.IdCateg = lblaux.Text
        categoria.NomCateg = txtNombre.Text

        If CheckBox3.Checked Then
            If CheckBox1.Checked Then

                categoria.CodCateg = bsnCategoria.ObtenerCodigoBaseDisponible

            ElseIf CheckBox2.Checked Then

                id = cmbCategorias.SelectedItem.ToString()
                id = id.Substring(0, InStr(1, id, "-") - 1)
                dig = bsnCategoria.ObtenerCodigo(id)
                dig = ObtenerDigito(dig, 1)

                categoria.CodCateg = bsnCategoria.ObtenerSubCodigoDisponible(dig)




            ElseIf (Not CheckBox1.Checked) And (Not CheckBox2.Checked) Then

                id = cmbSubCategorias.SelectedItem.ToString()
                id = id.Substring(0, InStr(1, id, "-") - 1)
                dig = bsnCategoria.ObtenerCodigo(id)
                dig = ObtenerDigito(dig, 2)


                categoria.CodCateg = bsnCategoria.ObtenerSubSubCodigoDisponible(dig)

            End If
        Else
            categoria.CodCateg = txtCodigo.Text
        End If





        If categoria.CodCateg.Equals("0") Then
            MsgBox("SR USUARIO: Excedio el limite permitido de Categorias")
        Else
            If activeAgregar Then 'Si se esta agregando un categoria       
                bsnCategoria.AgregarCategoria(categoria)
            ElseIf activeEditar Then
                MsgBox("MODIFICANDO PAPU")
                MsgBox("COD : " + categoria.CodCateg)
                bsnCategoria.EditarCategoria(categoria)

            End If

        End If




        Reset()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            cmbSubCategorias.Enabled = False
        Else
            cmbSubCategorias.Enabled = True
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            cmbCategorias.Enabled = False
            cmbSubCategorias.Enabled = False
            CheckBox2.Enabled = False
        Else
            cmbCategorias.Enabled = True
            cmbSubCategorias.Enabled = True
            CheckBox2.Enabled = True

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



    Private Sub Recargar()
        'INTENTAR PARA DESPUES
        CleanDGV()
        RellenarDataSet()

        RellenarCMB(1, "")

        If dgv1 And (Not dgv2) And (Not dgv3) Then
            MsgBox(indexCodDGV1)
            If Not activeEliminar Then
                dgvCateg.Rows(indexCodDGV1).Selected = True
            End If
        ElseIf dgv1 And dgv2 And (Not dgv3) Then
            MsgBox(indexCodDGV1)

            MsgBox(indexCodDGV2)

            If Not activeEliminar Then
                dgvCateg.Rows(indexCodDGV1).Selected = True
                dgvSubCat.Rows(indexCodDGV2).Selected = True
            Else
                dgvCateg.Rows(indexCodDGV1).Selected = True
            End If

        ElseIf dgv1 And dgv2 And dgv3 Then
            MsgBox(indexCodDGV1)

            MsgBox(indexCodDGV2)

            MsgBox(indexCodDGV3)

            If Not activeEliminar Then
                dgvCateg.Rows(indexCodDGV1).Selected = True
                dgvSubCat.Rows(indexCodDGV2).Selected = True
                dgvSubSubCat.Rows(indexCodDGV3).Selected = True
            Else
                dgvCateg.Rows(indexCodDGV1).Selected = True
                dgvSubCat.Rows(indexCodDGV2).Selected = True



            End If



        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            cmbCategorias.Enabled = True
            cmbSubCategorias.Enabled = True
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True

        Else
            cmbCategorias.Enabled = False
            cmbSubCategorias.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
        End If
    End Sub



    Private Sub Reset()
        CleanDGV()
        LimpiarDatos()

        RellenarDataSet()
        RellenarCMB(1, "")
        cmbCategorias.Text = ""
        cmbSubCategorias.Text = ""

        BloquearBotones()
    End Sub

    Public Sub SeleccionarCMB(cmb As ComboBox, idSeleccionado As String)
        Dim id As String
        Dim indice As Short
        For i = 0 To cmb.Items.Count - 1

            id = cmb.Items(i).ToString()
            id = id.Substring(0, InStr(1, id, "-") - 1)
            'MsgBox("Id del CMB: " + id)

            If idSeleccionado = Int(id) Then
                indice = i
            End If

        Next
        If indice >= 0 Then
            cmb.SelectedIndex = indice
        End If

    End Sub

End Class


