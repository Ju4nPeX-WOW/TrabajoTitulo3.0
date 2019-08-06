<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCate2
    Inherits TT.FormBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnExitCat = New System.Windows.Forms.Button()
        Me.btnCanCat = New System.Windows.Forms.Button()
        Me.btnAceCat = New System.Windows.Forms.Button()
        Me.dgvCateg = New System.Windows.Forms.DataGridView()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dgvSubCat = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCateBase = New System.Windows.Forms.Label()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblAuxCat = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.cmbSubCategorias = New System.Windows.Forms.ComboBox()
        Me.lblSubCate = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.lblaux = New System.Windows.Forms.Label()
        Me.tsmAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvSubSubCat = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvSubSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExitCat
        '
        Me.BtnExitCat.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExitCat.Name = "BtnExitCat"
        Me.BtnExitCat.Size = New System.Drawing.Size(35, 23)
        Me.BtnExitCat.TabIndex = 70
        Me.BtnExitCat.Text = "X"
        Me.BtnExitCat.UseVisualStyleBackColor = True
        '
        'btnCanCat
        '
        Me.btnCanCat.Enabled = False
        Me.btnCanCat.Location = New System.Drawing.Point(975, 509)
        Me.btnCanCat.Name = "btnCanCat"
        Me.btnCanCat.Size = New System.Drawing.Size(132, 43)
        Me.btnCanCat.TabIndex = 73
        Me.btnCanCat.Text = "Cancelar"
        Me.btnCanCat.UseVisualStyleBackColor = True
        '
        'btnAceCat
        '
        Me.btnAceCat.Enabled = False
        Me.btnAceCat.Location = New System.Drawing.Point(975, 444)
        Me.btnAceCat.Name = "btnAceCat"
        Me.btnAceCat.Size = New System.Drawing.Size(132, 43)
        Me.btnAceCat.TabIndex = 72
        Me.btnAceCat.Text = "Aceptar"
        Me.btnAceCat.UseVisualStyleBackColor = True
        '
        'dgvCateg
        '
        Me.dgvCateg.AllowUserToAddRows = False
        Me.dgvCateg.AllowUserToDeleteRows = False
        Me.dgvCateg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCateg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCateg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCateg.Location = New System.Drawing.Point(12, 115)
        Me.dgvCateg.MultiSelect = False
        Me.dgvCateg.Name = "dgvCateg"
        Me.dgvCateg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCateg.Size = New System.Drawing.Size(360, 269)
        Me.dgvCateg.TabIndex = 71
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Enabled = False
        Me.lblId.Location = New System.Drawing.Point(90, 430)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(89, 13)
        Me.lblId.TabIndex = 77
        Me.lblId.Text = "ID CATEGORIA :"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Enabled = False
        Me.lblNombre.Location = New System.Drawing.Point(90, 487)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(60, 13)
        Me.lblNombre.TabIndex = 78
        Me.lblNombre.Text = "NOMBRE :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(216, 544)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(262, 20)
        Me.txtCodigo.TabIndex = 76
        '
        'dgvSubCat
        '
        Me.dgvSubCat.AllowUserToAddRows = False
        Me.dgvSubCat.AllowUserToDeleteRows = False
        Me.dgvSubCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvSubCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubCat.Location = New System.Drawing.Point(394, 115)
        Me.dgvSubCat.MultiSelect = False
        Me.dgvSubCat.Name = "dgvSubCat"
        Me.dgvSubCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSubCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubCat.Size = New System.Drawing.Size(360, 269)
        Me.dgvSubCat.TabIndex = 79
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(216, 484)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(262, 20)
        Me.txtNombre.TabIndex = 80
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Enabled = False
        Me.lblCodigo.Location = New System.Drawing.Point(90, 547)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 13)
        Me.lblCodigo.TabIndex = 81
        Me.lblCodigo.Text = "CODIGO :"
        '
        'lblCateBase
        '
        Me.lblCateBase.AutoSize = True
        Me.lblCateBase.Enabled = False
        Me.lblCateBase.Location = New System.Drawing.Point(90, 608)
        Me.lblCateBase.Name = "lblCateBase"
        Me.lblCateBase.Size = New System.Drawing.Size(103, 13)
        Me.lblCateBase.TabIndex = 82
        Me.lblCateBase.Text = "CATEGORIA BASE:"
        '
        'cmbCategorias
        '
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(216, 637)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(262, 21)
        Me.cmbCategorias.TabIndex = 83
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregar, Me.tsmEditar, Me.tsmEliminar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 40)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1139, 24)
        Me.MenuStrip1.TabIndex = 84
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblAuxCat
        '
        Me.lblAuxCat.AutoSize = True
        Me.lblAuxCat.Enabled = False
        Me.lblAuxCat.Location = New System.Drawing.Point(513, 547)
        Me.lblAuxCat.Name = "lblAuxCat"
        Me.lblAuxCat.Size = New System.Drawing.Size(0, 13)
        Me.lblAuxCat.TabIndex = 85
        Me.lblAuxCat.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(216, 608)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(159, 17)
        Me.CheckBox1.TabIndex = 86
        Me.CheckBox1.Text = "HACER CATEGORIA BASE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(659, 608)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(153, 17)
        Me.CheckBox2.TabIndex = 90
        Me.CheckBox2.Text = "HACER SUB CATEGORIA"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'cmbSubCategorias
        '
        Me.cmbSubCategorias.FormattingEnabled = True
        Me.cmbSubCategorias.Location = New System.Drawing.Point(659, 637)
        Me.cmbSubCategorias.Name = "cmbSubCategorias"
        Me.cmbSubCategorias.Size = New System.Drawing.Size(262, 21)
        Me.cmbSubCategorias.TabIndex = 89
        '
        'lblSubCate
        '
        Me.lblSubCate.AutoSize = True
        Me.lblSubCate.Enabled = False
        Me.lblSubCate.Location = New System.Drawing.Point(533, 608)
        Me.lblSubCate.Name = "lblSubCate"
        Me.lblSubCate.Size = New System.Drawing.Size(97, 13)
        Me.lblSubCate.TabIndex = 88
        Me.lblSubCate.Text = "SUB CATEGORIA:"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(93, 579)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(147, 17)
        Me.CheckBox3.TabIndex = 91
        Me.CheckBox3.Text = "Modificar Nivel Categoria:"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'lblaux
        '
        Me.lblaux.AutoSize = True
        Me.lblaux.Enabled = False
        Me.lblaux.Location = New System.Drawing.Point(457, 430)
        Me.lblaux.Name = "lblaux"
        Me.lblaux.Size = New System.Drawing.Size(10, 13)
        Me.lblaux.TabIndex = 92
        Me.lblaux.Text = " "
        Me.lblaux.Visible = False
        '
        'tsmAgregar
        '
        Me.tsmAgregar.Image = Global.TT.My.Resources.Resources.add
        Me.tsmAgregar.Name = "tsmAgregar"
        Me.tsmAgregar.Size = New System.Drawing.Size(77, 20)
        Me.tsmAgregar.Text = "Agregar"
        '
        'tsmEditar
        '
        Me.tsmEditar.Image = Global.TT.My.Resources.Resources.document
        Me.tsmEditar.Name = "tsmEditar"
        Me.tsmEditar.Size = New System.Drawing.Size(65, 20)
        Me.tsmEditar.Text = "Editar"
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Image = Global.TT.My.Resources.Resources.delete
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.Size = New System.Drawing.Size(78, 20)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'dgvSubSubCat
        '
        Me.dgvSubSubCat.AllowUserToAddRows = False
        Me.dgvSubSubCat.AllowUserToDeleteRows = False
        Me.dgvSubSubCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubSubCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvSubSubCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubSubCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubSubCat.Location = New System.Drawing.Point(779, 115)
        Me.dgvSubSubCat.MultiSelect = False
        Me.dgvSubSubCat.Name = "dgvSubSubCat"
        Me.dgvSubSubCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSubSubCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubSubCat.Size = New System.Drawing.Size(360, 269)
        Me.dgvSubSubCat.TabIndex = 87
        '
        'FrmCate2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.lblaux)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.cmbSubCategorias)
        Me.Controls.Add(Me.lblSubCate)
        Me.Controls.Add(Me.dgvSubSubCat)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblAuxCat)
        Me.Controls.Add(Me.cmbCategorias)
        Me.Controls.Add(Me.lblCateBase)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgvSubCat)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnCanCat)
        Me.Controls.Add(Me.btnAceCat)
        Me.Controls.Add(Me.dgvCateg)
        Me.Controls.Add(Me.BtnExitCat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmCate2"
        CType(Me.dgvCateg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvSubSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExitCat As Button
    Friend WithEvents btnCanCat As Button
    Friend WithEvents btnAceCat As Button
    Friend WithEvents dgvCateg As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dgvSubCat As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblCateBase As Label
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents tsmAgregar As ToolStripMenuItem
    Friend WithEvents tsmEditar As ToolStripMenuItem
    Friend WithEvents tsmEliminar As ToolStripMenuItem
    Friend WithEvents lblAuxCat As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents cmbSubCategorias As ComboBox
    Friend WithEvents lblSubCate As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents lblaux As Label
    Friend WithEvents dgvSubSubCat As DataGridView
End Class
