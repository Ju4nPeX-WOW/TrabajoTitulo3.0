<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCate
    Inherits TT.FormBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.tsmAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblAuxCat = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.lblaux = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        CType(Me.dgvCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExitCat
        '
        Me.BtnExitCat.BackColor = System.Drawing.Color.Red
        Me.BtnExitCat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExitCat.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExitCat.Name = "BtnExitCat"
        Me.BtnExitCat.Size = New System.Drawing.Size(35, 23)
        Me.BtnExitCat.TabIndex = 70
        Me.BtnExitCat.Text = "X"
        Me.BtnExitCat.UseVisualStyleBackColor = False
        '
        'btnCanCat
        '
        Me.btnCanCat.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCanCat.Enabled = False
        Me.btnCanCat.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCanCat.Location = New System.Drawing.Point(607, 592)
        Me.btnCanCat.Name = "btnCanCat"
        Me.btnCanCat.Size = New System.Drawing.Size(201, 43)
        Me.btnCanCat.TabIndex = 73
        Me.btnCanCat.Text = "Cancelar"
        Me.btnCanCat.UseVisualStyleBackColor = False
        '
        'btnAceCat
        '
        Me.btnAceCat.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAceCat.Enabled = False
        Me.btnAceCat.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceCat.Location = New System.Drawing.Point(358, 592)
        Me.btnAceCat.Name = "btnAceCat"
        Me.btnAceCat.Size = New System.Drawing.Size(200, 43)
        Me.btnAceCat.TabIndex = 72
        Me.btnAceCat.Text = "Aceptar"
        Me.btnAceCat.UseVisualStyleBackColor = False
        '
        'dgvCateg
        '
        Me.dgvCateg.AllowUserToAddRows = False
        Me.dgvCateg.AllowUserToDeleteRows = False
        Me.dgvCateg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCateg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCateg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCateg.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCateg.Location = New System.Drawing.Point(58, 134)
        Me.dgvCateg.MultiSelect = False
        Me.dgvCateg.Name = "dgvCateg"
        Me.dgvCateg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCateg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCateg.Size = New System.Drawing.Size(500, 269)
        Me.dgvCateg.TabIndex = 71
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Enabled = False
        Me.lblId.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(213, 425)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(103, 19)
        Me.lblId.TabIndex = 77
        Me.lblId.Text = "ID CATEGORIA :"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Enabled = False
        Me.lblNombre.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(213, 468)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(70, 19)
        Me.lblNombre.TabIndex = 78
        Me.lblNombre.Text = "NOMBRE :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(289, 528)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(262, 27)
        Me.txtCodigo.TabIndex = 76
        '
        'dgvSubCat
        '
        Me.dgvSubCat.AllowUserToAddRows = False
        Me.dgvSubCat.AllowUserToDeleteRows = False
        Me.dgvSubCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSubCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSubCat.Location = New System.Drawing.Point(607, 134)
        Me.dgvSubCat.MultiSelect = False
        Me.dgvSubCat.Name = "dgvSubCat"
        Me.dgvSubCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSubCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSubCat.Size = New System.Drawing.Size(500, 269)
        Me.dgvSubCat.TabIndex = 79
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(289, 465)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(262, 27)
        Me.txtNombre.TabIndex = 80
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Enabled = False
        Me.lblCodigo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(213, 531)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(63, 19)
        Me.lblCodigo.TabIndex = 81
        Me.lblCodigo.Text = "CODIGO :"
        '
        'lblCateBase
        '
        Me.lblCateBase.AutoSize = True
        Me.lblCateBase.Enabled = False
        Me.lblCateBase.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateBase.Location = New System.Drawing.Point(603, 500)
        Me.lblCateBase.Name = "lblCateBase"
        Me.lblCateBase.Size = New System.Drawing.Size(121, 19)
        Me.lblCateBase.TabIndex = 82
        Me.lblCateBase.Text = "CATEGORIA BASE:"
        '
        'cmbCategorias
        '
        Me.cmbCategorias.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(607, 528)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(306, 27)
        Me.cmbCategorias.TabIndex = 83
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregar, Me.tsmEditar, Me.tsmEliminar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 78)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1175, 24)
        Me.MenuStrip1.TabIndex = 84
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'lblAuxCat
        '
        Me.lblAuxCat.AutoSize = True
        Me.lblAuxCat.Enabled = False
        Me.lblAuxCat.Location = New System.Drawing.Point(618, 528)
        Me.lblAuxCat.Name = "lblAuxCat"
        Me.lblAuxCat.Size = New System.Drawing.Size(0, 13)
        Me.lblAuxCat.TabIndex = 85
        Me.lblAuxCat.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(730, 499)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(183, 23)
        Me.CheckBox1.TabIndex = 86
        Me.CheckBox1.Text = "HACER CATEGORIA BASE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(592, 467)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(189, 23)
        Me.CheckBox3.TabIndex = 91
        Me.CheckBox3.Text = "Modificar Nivel Categoria:"
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'lblaux
        '
        Me.lblaux.AutoSize = True
        Me.lblaux.Enabled = False
        Me.lblaux.Location = New System.Drawing.Point(457, 407)
        Me.lblaux.Name = "lblaux"
        Me.lblaux.Size = New System.Drawing.Size(10, 13)
        Me.lblaux.TabIndex = 92
        Me.lblaux.Text = " "
        Me.lblaux.Visible = False
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.DarkBlue
        Me.LblTitulo.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitulo.Location = New System.Drawing.Point(0, 38)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(1173, 40)
        Me.LblTitulo.TabIndex = 122
        Me.LblTitulo.Text = "CATEGORIAS"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.lblaux)
        Me.Controls.Add(Me.CheckBox3)
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
        Me.Name = "FrmCate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.dgvCateg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents lblaux As Label
    Friend WithEvents LblTitulo As Label
End Class
