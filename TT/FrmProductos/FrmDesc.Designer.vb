<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesc))
        Me.btnSimpleEliminarCat = New System.Windows.Forms.Button()
        Me.TabControl1Cat = New System.Windows.Forms.TabControl()
        Me.tbpSimpleCat = New System.Windows.Forms.TabPage()
        Me.lblSimpleRazon = New System.Windows.Forms.Label()
        Me.lblSimpleStock = New System.Windows.Forms.Label()
        Me.cmbSimpleRazon = New System.Windows.Forms.ComboBox()
        Me.lblSimpleStockCrit = New System.Windows.Forms.Label()
        Me.lblSimplePrecio = New System.Windows.Forms.Label()
        Me.lblSimpleCat = New System.Windows.Forms.Label()
        Me.lblSimpleProd = New System.Windows.Forms.Label()
        Me.lblSimpleId = New System.Windows.Forms.Label()
        Me.nupSimpleCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblSimpleCantidad = New System.Windows.Forms.Label()
        Me.tbpAvanzadoCat = New System.Windows.Forms.TabPage()
        Me.lblAvanzadoId = New System.Windows.Forms.Label()
        Me.lblAvanzadoRazon = New System.Windows.Forms.Label()
        Me.lblAvanzadoStock = New System.Windows.Forms.Label()
        Me.cmbAvanzadoRazon = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAvanzadoCat = New System.Windows.Forms.ComboBox()
        Me.lblAvanzadoCat = New System.Windows.Forms.Label()
        Me.lblAvanzadoStockCrit = New System.Windows.Forms.Label()
        Me.lblAvanzadoPrecio = New System.Windows.Forms.Label()
        Me.lblAvanzadoProd = New System.Windows.Forms.Label()
        Me.txtAvanzadoStockCrit = New System.Windows.Forms.TextBox()
        Me.txtAvanzadoPrecio = New System.Windows.Forms.TextBox()
        Me.txtAvanzadoStock = New System.Windows.Forms.TextBox()
        Me.txtAvanzadoProd = New System.Windows.Forms.TextBox()
        Me.btnCanCat = New System.Windows.Forms.Button()
        Me.btnAceCat = New System.Windows.Forms.Button()
        Me.dgvCat = New System.Windows.Forms.DataGridView()
        Me.BtnExitDes = New System.Windows.Forms.Button()
        Me.cmbBuscarCat = New System.Windows.Forms.ComboBox()
        Me.txtBuscarProdCat = New System.Windows.Forms.TextBox()
        Me.mnsDes = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1Cat.SuspendLayout()
        Me.tbpSimpleCat.SuspendLayout()
        CType(Me.nupSimpleCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAvanzadoCat.SuspendLayout()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsDes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpleEliminarCat
        '
        Me.btnSimpleEliminarCat.Enabled = False
        Me.btnSimpleEliminarCat.Location = New System.Drawing.Point(975, 567)
        Me.btnSimpleEliminarCat.Name = "btnSimpleEliminarCat"
        Me.btnSimpleEliminarCat.Size = New System.Drawing.Size(132, 43)
        Me.btnSimpleEliminarCat.TabIndex = 84
        Me.btnSimpleEliminarCat.Text = "ELIMINAR POR COMPLETO"
        Me.btnSimpleEliminarCat.UseVisualStyleBackColor = True
        Me.btnSimpleEliminarCat.Visible = False
        '
        'TabControl1Cat
        '
        Me.TabControl1Cat.Controls.Add(Me.tbpSimpleCat)
        Me.TabControl1Cat.Controls.Add(Me.tbpAvanzadoCat)
        Me.TabControl1Cat.Enabled = False
        Me.TabControl1Cat.Location = New System.Drawing.Point(12, 398)
        Me.TabControl1Cat.Name = "TabControl1Cat"
        Me.TabControl1Cat.SelectedIndex = 0
        Me.TabControl1Cat.Size = New System.Drawing.Size(909, 250)
        Me.TabControl1Cat.TabIndex = 83
        Me.TabControl1Cat.Visible = False
        '
        'tbpSimpleCat
        '
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleRazon)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleStock)
        Me.tbpSimpleCat.Controls.Add(Me.cmbSimpleRazon)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleStockCrit)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimplePrecio)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleCat)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleProd)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleId)
        Me.tbpSimpleCat.Controls.Add(Me.nupSimpleCantidad)
        Me.tbpSimpleCat.Controls.Add(Me.lblSimpleCantidad)
        Me.tbpSimpleCat.Location = New System.Drawing.Point(4, 22)
        Me.tbpSimpleCat.Name = "tbpSimpleCat"
        Me.tbpSimpleCat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSimpleCat.Size = New System.Drawing.Size(901, 224)
        Me.tbpSimpleCat.TabIndex = 0
        Me.tbpSimpleCat.Text = "Simple"
        Me.tbpSimpleCat.UseVisualStyleBackColor = True
        '
        'lblSimpleRazon
        '
        Me.lblSimpleRazon.AutoSize = True
        Me.lblSimpleRazon.Enabled = False
        Me.lblSimpleRazon.Location = New System.Drawing.Point(34, 158)
        Me.lblSimpleRazon.Name = "lblSimpleRazon"
        Me.lblSimpleRazon.Size = New System.Drawing.Size(84, 13)
        Me.lblSimpleRazon.TabIndex = 76
        Me.lblSimpleRazon.Text = "RAZON            :"
        '
        'lblSimpleStock
        '
        Me.lblSimpleStock.AutoSize = True
        Me.lblSimpleStock.Enabled = False
        Me.lblSimpleStock.Location = New System.Drawing.Point(421, 130)
        Me.lblSimpleStock.Name = "lblSimpleStock"
        Me.lblSimpleStock.Size = New System.Drawing.Size(94, 13)
        Me.lblSimpleStock.TabIndex = 75
        Me.lblSimpleStock.Text = "STOCK                :"
        '
        'cmbSimpleRazon
        '
        Me.cmbSimpleRazon.Enabled = False
        Me.cmbSimpleRazon.FormattingEnabled = True
        Me.cmbSimpleRazon.Location = New System.Drawing.Point(138, 155)
        Me.cmbSimpleRazon.Name = "cmbSimpleRazon"
        Me.cmbSimpleRazon.Size = New System.Drawing.Size(140, 21)
        Me.cmbSimpleRazon.TabIndex = 74
        '
        'lblSimpleStockCrit
        '
        Me.lblSimpleStockCrit.AutoSize = True
        Me.lblSimpleStockCrit.Enabled = False
        Me.lblSimpleStockCrit.Location = New System.Drawing.Point(421, 155)
        Me.lblSimpleStockCrit.Name = "lblSimpleStockCrit"
        Me.lblSimpleStockCrit.Size = New System.Drawing.Size(95, 13)
        Me.lblSimpleStockCrit.TabIndex = 73
        Me.lblSimpleStockCrit.Text = "STOCK CRITICO :"
        '
        'lblSimplePrecio
        '
        Me.lblSimplePrecio.AutoSize = True
        Me.lblSimplePrecio.Enabled = False
        Me.lblSimplePrecio.Location = New System.Drawing.Point(421, 65)
        Me.lblSimplePrecio.Name = "lblSimplePrecio"
        Me.lblSimplePrecio.Size = New System.Drawing.Size(92, 13)
        Me.lblSimplePrecio.TabIndex = 68
        Me.lblSimplePrecio.Text = "PRECIO              :"
        '
        'lblSimpleCat
        '
        Me.lblSimpleCat.AutoSize = True
        Me.lblSimpleCat.Enabled = False
        Me.lblSimpleCat.Location = New System.Drawing.Point(34, 65)
        Me.lblSimpleCat.Name = "lblSimpleCat"
        Me.lblSimpleCat.Size = New System.Drawing.Size(84, 13)
        Me.lblSimpleCat.TabIndex = 67
        Me.lblSimpleCat.Text = "CATEGORIA    :"
        '
        'lblSimpleProd
        '
        Me.lblSimpleProd.AutoSize = True
        Me.lblSimpleProd.Enabled = False
        Me.lblSimpleProd.Location = New System.Drawing.Point(34, 24)
        Me.lblSimpleProd.Name = "lblSimpleProd"
        Me.lblSimpleProd.Size = New System.Drawing.Size(89, 13)
        Me.lblSimpleProd.TabIndex = 63
        Me.lblSimpleProd.Text = "PRODUCTO     : "
        '
        'lblSimpleId
        '
        Me.lblSimpleId.AutoSize = True
        Me.lblSimpleId.Enabled = False
        Me.lblSimpleId.Location = New System.Drawing.Point(613, 24)
        Me.lblSimpleId.Name = "lblSimpleId"
        Me.lblSimpleId.Size = New System.Drawing.Size(88, 13)
        Me.lblSimpleId.TabIndex = 58
        Me.lblSimpleId.Text = "ID PRODUCTO :"
        '
        'nupSimpleCantidad
        '
        Me.nupSimpleCantidad.Enabled = False
        Me.nupSimpleCantidad.Location = New System.Drawing.Point(138, 113)
        Me.nupSimpleCantidad.Name = "nupSimpleCantidad"
        Me.nupSimpleCantidad.Size = New System.Drawing.Size(140, 20)
        Me.nupSimpleCantidad.TabIndex = 56
        '
        'lblSimpleCantidad
        '
        Me.lblSimpleCantidad.AutoSize = True
        Me.lblSimpleCantidad.Enabled = False
        Me.lblSimpleCantidad.Location = New System.Drawing.Point(34, 115)
        Me.lblSimpleCantidad.Name = "lblSimpleCantidad"
        Me.lblSimpleCantidad.Size = New System.Drawing.Size(83, 13)
        Me.lblSimpleCantidad.TabIndex = 55
        Me.lblSimpleCantidad.Text = "CANTIDAD      :"
        '
        'tbpAvanzadoCat
        '
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoId)
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoRazon)
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoStock)
        Me.tbpAvanzadoCat.Controls.Add(Me.cmbAvanzadoRazon)
        Me.tbpAvanzadoCat.Controls.Add(Me.Label4)
        Me.tbpAvanzadoCat.Controls.Add(Me.cmbAvanzadoCat)
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoCat)
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoStockCrit)
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoPrecio)
        Me.tbpAvanzadoCat.Controls.Add(Me.lblAvanzadoProd)
        Me.tbpAvanzadoCat.Controls.Add(Me.txtAvanzadoStockCrit)
        Me.tbpAvanzadoCat.Controls.Add(Me.txtAvanzadoPrecio)
        Me.tbpAvanzadoCat.Controls.Add(Me.txtAvanzadoStock)
        Me.tbpAvanzadoCat.Controls.Add(Me.txtAvanzadoProd)
        Me.tbpAvanzadoCat.Location = New System.Drawing.Point(4, 22)
        Me.tbpAvanzadoCat.Name = "tbpAvanzadoCat"
        Me.tbpAvanzadoCat.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAvanzadoCat.Size = New System.Drawing.Size(901, 224)
        Me.tbpAvanzadoCat.TabIndex = 1
        Me.tbpAvanzadoCat.Text = "Avanzado"
        Me.tbpAvanzadoCat.UseVisualStyleBackColor = True
        '
        'lblAvanzadoId
        '
        Me.lblAvanzadoId.AutoSize = True
        Me.lblAvanzadoId.Enabled = False
        Me.lblAvanzadoId.Location = New System.Drawing.Point(77, 19)
        Me.lblAvanzadoId.Name = "lblAvanzadoId"
        Me.lblAvanzadoId.Size = New System.Drawing.Size(88, 13)
        Me.lblAvanzadoId.TabIndex = 61
        Me.lblAvanzadoId.Text = "ID PRODUCTO :"
        '
        'lblAvanzadoRazon
        '
        Me.lblAvanzadoRazon.AutoSize = True
        Me.lblAvanzadoRazon.Enabled = False
        Me.lblAvanzadoRazon.Location = New System.Drawing.Point(77, 156)
        Me.lblAvanzadoRazon.Name = "lblAvanzadoRazon"
        Me.lblAvanzadoRazon.Size = New System.Drawing.Size(45, 13)
        Me.lblAvanzadoRazon.TabIndex = 72
        Me.lblAvanzadoRazon.Text = "RAZON"
        '
        'lblAvanzadoStock
        '
        Me.lblAvanzadoStock.AutoSize = True
        Me.lblAvanzadoStock.Enabled = False
        Me.lblAvanzadoStock.Location = New System.Drawing.Point(388, 106)
        Me.lblAvanzadoStock.Name = "lblAvanzadoStock"
        Me.lblAvanzadoStock.Size = New System.Drawing.Size(43, 13)
        Me.lblAvanzadoStock.TabIndex = 71
        Me.lblAvanzadoStock.Text = "STOCK"
        '
        'cmbAvanzadoRazon
        '
        Me.cmbAvanzadoRazon.Enabled = False
        Me.cmbAvanzadoRazon.FormattingEnabled = True
        Me.cmbAvanzadoRazon.Location = New System.Drawing.Point(80, 175)
        Me.cmbAvanzadoRazon.Name = "cmbAvanzadoRazon"
        Me.cmbAvanzadoRazon.Size = New System.Drawing.Size(140, 21)
        Me.cmbAvanzadoRazon.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(-133, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "RAZON"
        '
        'cmbAvanzadoCat
        '
        Me.cmbAvanzadoCat.Enabled = False
        Me.cmbAvanzadoCat.FormattingEnabled = True
        Me.cmbAvanzadoCat.Location = New System.Drawing.Point(80, 122)
        Me.cmbAvanzadoCat.Name = "cmbAvanzadoCat"
        Me.cmbAvanzadoCat.Size = New System.Drawing.Size(140, 21)
        Me.cmbAvanzadoCat.TabIndex = 67
        '
        'lblAvanzadoCat
        '
        Me.lblAvanzadoCat.AutoSize = True
        Me.lblAvanzadoCat.Enabled = False
        Me.lblAvanzadoCat.Location = New System.Drawing.Point(77, 106)
        Me.lblAvanzadoCat.Name = "lblAvanzadoCat"
        Me.lblAvanzadoCat.Size = New System.Drawing.Size(69, 13)
        Me.lblAvanzadoCat.TabIndex = 66
        Me.lblAvanzadoCat.Text = "CATEGORIA"
        '
        'lblAvanzadoStockCrit
        '
        Me.lblAvanzadoStockCrit.AutoSize = True
        Me.lblAvanzadoStockCrit.Enabled = False
        Me.lblAvanzadoStockCrit.Location = New System.Drawing.Point(388, 156)
        Me.lblAvanzadoStockCrit.Name = "lblAvanzadoStockCrit"
        Me.lblAvanzadoStockCrit.Size = New System.Drawing.Size(89, 13)
        Me.lblAvanzadoStockCrit.TabIndex = 65
        Me.lblAvanzadoStockCrit.Text = "STOCK CRITICO"
        '
        'lblAvanzadoPrecio
        '
        Me.lblAvanzadoPrecio.AutoSize = True
        Me.lblAvanzadoPrecio.Enabled = False
        Me.lblAvanzadoPrecio.Location = New System.Drawing.Point(384, 19)
        Me.lblAvanzadoPrecio.Name = "lblAvanzadoPrecio"
        Me.lblAvanzadoPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblAvanzadoPrecio.TabIndex = 64
        Me.lblAvanzadoPrecio.Text = "PRECIO"
        '
        'lblAvanzadoProd
        '
        Me.lblAvanzadoProd.AutoSize = True
        Me.lblAvanzadoProd.Enabled = False
        Me.lblAvanzadoProd.Location = New System.Drawing.Point(77, 63)
        Me.lblAvanzadoProd.Name = "lblAvanzadoProd"
        Me.lblAvanzadoProd.Size = New System.Drawing.Size(68, 13)
        Me.lblAvanzadoProd.TabIndex = 62
        Me.lblAvanzadoProd.Text = "PRODUCTO"
        '
        'txtAvanzadoStockCrit
        '
        Me.txtAvanzadoStockCrit.Enabled = False
        Me.txtAvanzadoStockCrit.Location = New System.Drawing.Point(387, 173)
        Me.txtAvanzadoStockCrit.Name = "txtAvanzadoStockCrit"
        Me.txtAvanzadoStockCrit.Size = New System.Drawing.Size(262, 20)
        Me.txtAvanzadoStockCrit.TabIndex = 60
        '
        'txtAvanzadoPrecio
        '
        Me.txtAvanzadoPrecio.Enabled = False
        Me.txtAvanzadoPrecio.Location = New System.Drawing.Point(387, 35)
        Me.txtAvanzadoPrecio.Name = "txtAvanzadoPrecio"
        Me.txtAvanzadoPrecio.Size = New System.Drawing.Size(262, 20)
        Me.txtAvanzadoPrecio.TabIndex = 59
        '
        'txtAvanzadoStock
        '
        Me.txtAvanzadoStock.Enabled = False
        Me.txtAvanzadoStock.Location = New System.Drawing.Point(387, 123)
        Me.txtAvanzadoStock.Name = "txtAvanzadoStock"
        Me.txtAvanzadoStock.Size = New System.Drawing.Size(262, 20)
        Me.txtAvanzadoStock.TabIndex = 58
        '
        'txtAvanzadoProd
        '
        Me.txtAvanzadoProd.Enabled = False
        Me.txtAvanzadoProd.Location = New System.Drawing.Point(80, 79)
        Me.txtAvanzadoProd.Name = "txtAvanzadoProd"
        Me.txtAvanzadoProd.Size = New System.Drawing.Size(569, 20)
        Me.txtAvanzadoProd.TabIndex = 57
        '
        'btnCanCat
        '
        Me.btnCanCat.Enabled = False
        Me.btnCanCat.Location = New System.Drawing.Point(975, 509)
        Me.btnCanCat.Name = "btnCanCat"
        Me.btnCanCat.Size = New System.Drawing.Size(132, 43)
        Me.btnCanCat.TabIndex = 82
        Me.btnCanCat.Text = "Cancelar"
        Me.btnCanCat.UseVisualStyleBackColor = True
        '
        'btnAceCat
        '
        Me.btnAceCat.Enabled = False
        Me.btnAceCat.Location = New System.Drawing.Point(975, 444)
        Me.btnAceCat.Name = "btnAceCat"
        Me.btnAceCat.Size = New System.Drawing.Size(132, 43)
        Me.btnAceCat.TabIndex = 81
        Me.btnAceCat.Text = "Aceptar"
        Me.btnAceCat.UseVisualStyleBackColor = True
        '
        'dgvCat
        '
        Me.dgvCat.AllowUserToAddRows = False
        Me.dgvCat.AllowUserToDeleteRows = False
        Me.dgvCat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCat.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvCat.Location = New System.Drawing.Point(12, 115)
        Me.dgvCat.MultiSelect = False
        Me.dgvCat.Name = "dgvCat"
        Me.dgvCat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCat.Size = New System.Drawing.Size(1127, 269)
        Me.dgvCat.TabIndex = 80
        '
        'BtnExitDes
        '
        Me.BtnExitDes.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExitDes.Name = "BtnExitDes"
        Me.BtnExitDes.Size = New System.Drawing.Size(35, 23)
        Me.BtnExitDes.TabIndex = 79
        Me.BtnExitDes.Text = "X"
        Me.BtnExitDes.UseVisualStyleBackColor = True
        '
        'cmbBuscarCat
        '
        Me.cmbBuscarCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscarCat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBuscarCat.Items.AddRange(New Object() {"Nombre", "Categoria", "Precio"})
        Me.cmbBuscarCat.Location = New System.Drawing.Point(12, 75)
        Me.cmbBuscarCat.Name = "cmbBuscarCat"
        Me.cmbBuscarCat.Size = New System.Drawing.Size(210, 21)
        Me.cmbBuscarCat.TabIndex = 78
        '
        'txtBuscarProdCat
        '
        Me.txtBuscarProdCat.Location = New System.Drawing.Point(228, 76)
        Me.txtBuscarProdCat.Name = "txtBuscarProdCat"
        Me.txtBuscarProdCat.Size = New System.Drawing.Size(911, 20)
        Me.txtBuscarProdCat.TabIndex = 76
        '
        'mnsDes
        '
        Me.mnsDes.AutoSize = False
        Me.mnsDes.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsDes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregarCat, Me.tsmEditarCat, Me.tsmEliminarCat})
        Me.mnsDes.Location = New System.Drawing.Point(0, 40)
        Me.mnsDes.Name = "mnsDes"
        Me.mnsDes.Size = New System.Drawing.Size(1139, 24)
        Me.mnsDes.TabIndex = 77
        Me.mnsDes.Text = "MenuStrip1"
        Me.mnsDes.UseWaitCursor = True
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
        'FrmDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.btnSimpleEliminarCat)
        Me.Controls.Add(Me.TabControl1Cat)
        Me.Controls.Add(Me.btnCanCat)
        Me.Controls.Add(Me.btnAceCat)
        Me.Controls.Add(Me.dgvCat)
        Me.Controls.Add(Me.BtnExitDes)
        Me.Controls.Add(Me.cmbBuscarCat)
        Me.Controls.Add(Me.txtBuscarProdCat)
        Me.Controls.Add(Me.mnsDes)
        Me.Name = "FrmDesc"
        Me.TabControl1Cat.ResumeLayout(False)
        Me.tbpSimpleCat.ResumeLayout(False)
        Me.tbpSimpleCat.PerformLayout()
        CType(Me.nupSimpleCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAvanzadoCat.ResumeLayout(False)
        Me.tbpAvanzadoCat.PerformLayout()
        CType(Me.dgvCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsDes.ResumeLayout(False)
        Me.mnsDes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpleEliminarCat As Button
    Friend WithEvents TabControl1Cat As TabControl
    Friend WithEvents tbpSimpleCat As TabPage
    Friend WithEvents lblSimpleRazon As Label
    Friend WithEvents lblSimpleStock As Label
    Friend WithEvents cmbSimpleRazon As ComboBox
    Friend WithEvents lblSimpleStockCrit As Label
    Friend WithEvents lblSimplePrecio As Label
    Friend WithEvents lblSimpleCat As Label
    Friend WithEvents lblSimpleProd As Label
    Friend WithEvents lblSimpleId As Label
    Friend WithEvents nupSimpleCantidad As NumericUpDown
    Friend WithEvents lblSimpleCantidad As Label
    Friend WithEvents tbpAvanzadoCat As TabPage
    Friend WithEvents lblAvanzadoId As Label
    Friend WithEvents lblAvanzadoRazon As Label
    Friend WithEvents lblAvanzadoStock As Label
    Friend WithEvents cmbAvanzadoRazon As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbAvanzadoCat As ComboBox
    Friend WithEvents lblAvanzadoCat As Label
    Friend WithEvents lblAvanzadoStockCrit As Label
    Friend WithEvents lblAvanzadoPrecio As Label
    Friend WithEvents lblAvanzadoProd As Label
    Friend WithEvents txtAvanzadoStockCrit As TextBox
    Friend WithEvents txtAvanzadoPrecio As TextBox
    Friend WithEvents txtAvanzadoStock As TextBox
    Friend WithEvents txtAvanzadoProd As TextBox
    Friend WithEvents btnCanCat As Button
    Friend WithEvents btnAceCat As Button
    Friend WithEvents dgvCat As DataGridView
    Friend WithEvents BtnExitDes As Button
    Friend WithEvents cmbBuscarCat As ComboBox
    Friend WithEvents txtBuscarProdCat As TextBox
    Friend WithEvents mnsDes As MenuStrip
    Friend WithEvents tsmAgregarCat As ToolStripMenuItem
    Friend WithEvents tsmEditarCat As ToolStripMenuItem
    Friend WithEvents tsmEliminarCat As ToolStripMenuItem
End Class
