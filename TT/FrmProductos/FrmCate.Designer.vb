<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCate
    Inherits TT.FormTamaño

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCate))
        Me.BtnExitCat = New System.Windows.Forms.Button()
        Me.cmbBuscarCat = New System.Windows.Forms.ComboBox()
        Me.txtBuscarProdCat = New System.Windows.Forms.TextBox()
        Me.mnsCat = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSimpleEliminarCat = New System.Windows.Forms.Button()
        Me.btnCanCat = New System.Windows.Forms.Button()
        Me.btnAceCat = New System.Windows.Forms.Button()
        Me.dgvCateg = New System.Windows.Forms.DataGridView()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.mnsCat.SuspendLayout()
        CType(Me.dgvCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'cmbBuscarCat
        '
        Me.cmbBuscarCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarCat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBuscarCat.Items.AddRange(New Object() {"Nombre", "Categoria", "Precio"})
        Me.cmbBuscarCat.Location = New System.Drawing.Point(12, 75)
        Me.cmbBuscarCat.Name = "cmbBuscarCat"
        Me.cmbBuscarCat.Size = New System.Drawing.Size(210, 21)
        Me.cmbBuscarCat.TabIndex = 69
        '
        'txtBuscarProdCat
        '
        Me.txtBuscarProdCat.Location = New System.Drawing.Point(228, 76)
        Me.txtBuscarProdCat.Name = "txtBuscarProdCat"
        Me.txtBuscarProdCat.Size = New System.Drawing.Size(911, 20)
        Me.txtBuscarProdCat.TabIndex = 67
        '
        'mnsCat
        '
        Me.mnsCat.AutoSize = False
        Me.mnsCat.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsCat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregarCat, Me.tsmEditarCat, Me.tsmEliminarCat})
        Me.mnsCat.Location = New System.Drawing.Point(0, 40)
        Me.mnsCat.Name = "mnsCat"
        Me.mnsCat.Size = New System.Drawing.Size(1139, 24)
        Me.mnsCat.TabIndex = 68
        Me.mnsCat.Text = "MenuStrip1"
        Me.mnsCat.UseWaitCursor = True
        '
        'tsmAgregarCat
        '
        Me.tsmAgregarCat.Image = CType(resources.GetObject("tsmAgregarCat.Image"), System.Drawing.Image)
        Me.tsmAgregarCat.Name = "tsmAgregarCat"
        Me.tsmAgregarCat.Size = New System.Drawing.Size(77, 20)
        Me.tsmAgregarCat.Text = "Agregar"
        '
        'tsmEditarCat
        '
        Me.tsmEditarCat.Image = CType(resources.GetObject("tsmEditarCat.Image"), System.Drawing.Image)
        Me.tsmEditarCat.Name = "tsmEditarCat"
        Me.tsmEditarCat.Size = New System.Drawing.Size(65, 20)
        Me.tsmEditarCat.Text = "Editar"
        '
        'tsmEliminarCat
        '
        Me.tsmEliminarCat.Image = CType(resources.GetObject("tsmEliminarCat.Image"), System.Drawing.Image)
        Me.tsmEliminarCat.Name = "tsmEliminarCat"
        Me.tsmEliminarCat.Size = New System.Drawing.Size(78, 20)
        Me.tsmEliminarCat.Text = "Eliminar"
        '
        'btnSimpleEliminarCat
        '
        Me.btnSimpleEliminarCat.Enabled = False
        Me.btnSimpleEliminarCat.Location = New System.Drawing.Point(975, 567)
        Me.btnSimpleEliminarCat.Name = "btnSimpleEliminarCat"
        Me.btnSimpleEliminarCat.Size = New System.Drawing.Size(132, 43)
        Me.btnSimpleEliminarCat.TabIndex = 75
        Me.btnSimpleEliminarCat.Text = "ELIMINAR POR COMPLETO"
        Me.btnSimpleEliminarCat.UseVisualStyleBackColor = True
        Me.btnSimpleEliminarCat.Visible = False
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
        Me.dgvCateg.Size = New System.Drawing.Size(509, 269)
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
        Me.txtCodigo.Location = New System.Drawing.Point(216, 579)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(262, 20)
        Me.txtCodigo.TabIndex = 76
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(535, 115)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(604, 269)
        Me.DataGridView1.TabIndex = 79
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
        Me.lblCodigo.Location = New System.Drawing.Point(90, 582)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 13)
        Me.lblCodigo.TabIndex = 81
        Me.lblCodigo.Text = "CODIGO :"
        '
        'FrmCate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnSimpleEliminarCat)
        Me.Controls.Add(Me.btnCanCat)
        Me.Controls.Add(Me.btnAceCat)
        Me.Controls.Add(Me.dgvCateg)
        Me.Controls.Add(Me.BtnExitCat)
        Me.Controls.Add(Me.cmbBuscarCat)
        Me.Controls.Add(Me.txtBuscarProdCat)
        Me.Controls.Add(Me.mnsCat)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmCate"
        Me.mnsCat.ResumeLayout(False)
        Me.mnsCat.PerformLayout()
        CType(Me.dgvCateg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExitCat As Button
    Friend WithEvents cmbBuscarCat As ComboBox
    Friend WithEvents txtBuscarProdCat As TextBox
    Friend WithEvents mnsCat As MenuStrip
    Friend WithEvents tsmAgregarCat As ToolStripMenuItem
    Friend WithEvents tsmEditarCat As ToolStripMenuItem
    Friend WithEvents tsmEliminarCat As ToolStripMenuItem
    Friend WithEvents btnSimpleEliminarCat As Button
    Friend WithEvents btnCanCat As Button
    Friend WithEvents btnAceCat As Button
    Friend WithEvents dgvCateg As DataGridView
    Friend WithEvents lblId As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblCodigo As Label
End Class
