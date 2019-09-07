Public Class FrmCate3


    Private _usuario As New Usuario    '------------------------>Recepción del usuario que usa el sistema
    Protected aux As Short       '------------------------>auxiliar donde guarda el id
    Protected Validaciones As New Validaciones


    Protected activeAgregar As Boolean = False  'cuando el usuario presiona el boton del menu strip agregar se torna verdadero
    Protected activeEditar As Boolean = False   'cuando el usuario presiona el boton del menu strip editar se torna verdadero
    Protected activeEliminar As Boolean = False 'cuando el usuario presiona el boton del menu strip eliminar se torna verdadero
    'Esto no quiere decir que se bloqueen, sino que en los procedimientos tsm[Agregar-editar-eliminar]




    'Otras Variables
    Dim idaux As Short
    Private validacion As New Validacionesv2



    Public Sub RecibirUsuario(objeto As Usuario)
        _usuario = objeto 'del form ingreso se recibe el objeto que es el usuario que ingreso al sistema 
        MsgBox(_usuario.Nombres)
    End Sub

    Private Sub BtnExitCat_Click(sender As Object, e As EventArgs) Handles BtnExitCat.Click
        Me.Close()
    End Sub

    Private Sub FrmCate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Reset()
    End Sub

    Private Sub Reset()
        ' Restablecemos a la configuracion inicial 

        'LIMPIAR DGV
        dgvCateg.DataSource = Nothing
        dgvCateg.Rows.Clear()
        dgvCateg.Columns.Clear()
        ' ESTRUCTURAR DATAGRIDVIEW FORMATO COLUMNAS ETC
        dgvCateg.DefaultCellStyle.BackColor = Color.Beige
        dgvCateg.ColumnCount = 3
        dgvCateg.Columns(0).Name = "Id"
        dgvCateg.Columns(1).Name = "Nombre"
        dgvCateg.Columns(2).Name = "Codigo"
        dgvCateg.Columns(0).DataPropertyName = "Id_categoria"
        dgvCateg.Columns(1).DataPropertyName = "Nombre"
        dgvCateg.Columns(2).DataPropertyName = "Codigo"

        ' RELLENAR DATAGRIDVIEW

        Dim dataset, dataset2 As New DataSet
        Dim bsn, bsn2 As New BsnCategoria
        dataset = bsn.ObtenerCategorias

        dgvCateg.DataSource = dataset.Tables(0)

        ' RELLENAR CMB
        dataset2 = bsn2.ObtenerCategoriasBase
        cmbCategorias.DisplayMember = dataset2.Tables(0).Columns(1).ToString()
        cmbCategorias.ValueMember = dataset2.Tables(0).Columns(0).ToString()

        cmbCategorias.DataSource = dataset2.Tables(0)
        ' LIMPIAR ELEMENTOS

        lblaux.Text = ""
        lblId.Text = "ID_CATEGORIA :"
        txtNombre.Text = ""
        txtCodigo.Text = ""
        cmbCategorias.Text = ""



        ' BLOQUEOS

        lblId.Enabled = False
        lblNombre.Enabled = False
        lblCodigo.Enabled = False
        txtNombre.Enabled = False
        btnAceCat.Enabled = False
        btnCanCat.Enabled = False
        CheckBox1.Enabled = False
        cmbCategorias.Enabled = False

        'seleccionar por defecto el primero
        'dgvCateg.Rows(0).Selected = True
        'bloque por permisos
        Dim permiso As New Permisos
        tsmAgregar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "CATEGORIAS", "AGREGAR", "")
        tsmEditar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "CATEGORIAS", "EDITAR", "")
        tsmEliminar.Enabled = permiso.OtorgarAcceso(_usuario.Permisos, "CATEGORIAS", "ELIMINAR", "")

    End Sub







    Private Sub tsmAgregar_Click(sender As Object, e As EventArgs) Handles tsmAgregar.Click
        'bloquear tms
        tsmAgregar.Enabled = False
        tsmEditar.Enabled = False
        tsmEliminar.Enabled = False
        'cambios de flag
        activeAgregar = True
        activeEditar = False

        'desbloquear
        lblId.Enabled = True
        lblNombre.Enabled = True
        CheckBox1.Enabled = True
        txtNombre.Enabled = True
        btnAceCat.Enabled = True
        btnCanCat.Enabled = True

    End Sub
    Private Sub tsmEditar_Click(sender As Object, e As EventArgs) Handles tsmEditar.Click
        'bloquear tms
        tsmAgregar.Enabled = False
        tsmEditar.Enabled = False
        tsmEliminar.Enabled = False
        'cambios de flag
        activeAgregar = False
        activeEditar = True

        'desbloquear
        lblId.Enabled = True
        lblNombre.Enabled = True
        CheckBox1.Enabled = True
        txtNombre.Enabled = True
        btnAceCat.Enabled = True
        btnCanCat.Enabled = True



    End Sub

    Private Sub tsmEliminar_Click(sender As Object, e As EventArgs) Handles tsmEliminar.Click
        'validar que hay una categoria seleccionadad

        'solicitar confirmacion del usuario
        Dim bsnNegocio As New BsnCategoria
        bsnNegocio.EliminarCategoria(lblaux.Text)

        Reset()
    End Sub

    Private Sub btnAceCat_Click(sender As Object, e As EventArgs) Handles btnAceCat.Click
        Dim objeto As New Categoria
        Dim bsn As New BsnCategoria

        objeto.NomCateg = txtNombre.Text
        If CheckBox1.Checked Then
            objeto.CodCateg = txtCodigo.Text
        Else
            MsgBox("entra")
            txtCodigo.Text = bsn.ObtenerSubCodigoDisponible("Z")
        End If

        If activeAgregar Then
            'Se agrega
            bsn.AgregarCategoria(objeto)
        ElseIf activeEditar Then
            'se modifica
            objeto.IdCateg = lblaux.Text
            bsn.EditarCategoria(objeto)
        End If
        Reset()


    End Sub

    Private Sub btnCanCat_Click(sender As Object, e As EventArgs) Handles btnCanCat.Click
        Reset()
    End Sub

    Private Sub dgvCateg_SelectionChanged(sender As Object, e As EventArgs) Handles dgvCateg.SelectionChanged
        Try
            idaux = dgvCateg.CurrentRow.Cells.Item(0).Value.ToString()


            lblaux.Text = dgvCateg.CurrentRow.Cells.Item(0).Value.ToString()
            lblId.Text = "ID CATEGORIA :" + dgvCateg.CurrentRow.Cells.Item(0).Value.ToString()
            txtNombre.Text = dgvCateg.CurrentRow.Cells.Item(1).Value.ToString()
            txtCodigo.Text = dgvCateg.CurrentRow.Cells.Item(2).Value.ToString()


            cmbCategorias.SelectedValue = lblaux.Text


        Catch ex As Exception

        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            cmbCategorias.Enabled = True
        Else
            cmbCategorias.Enabled = False
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        Dim DD As New DefaultData
        DD.EstablecerCategorias()
        Reset()

    End Sub

    Private Sub cmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategorias.SelectedIndexChanged
        Dim bsn As New BsnCategoria
        Dim dig = bsn.ObtenerCodigo(cmbCategorias.SelectedValue)
        dig = dig.substring(0, 1)
        txtCodigo.Text = bsn.ObtenerSubCodigoDisponible(dig)
    End Sub
End Class