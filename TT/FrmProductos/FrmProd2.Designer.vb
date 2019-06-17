<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProd2
    Inherits FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProd2))
        Me.btnSimpleEliminar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpSimple = New System.Windows.Forms.TabPage()
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
        Me.tbpAvanzado = New System.Windows.Forms.TabPage()
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
        Me.cmbBuscar = New System.Windows.Forms.ComboBox()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnAce = New System.Windows.Forms.Button()
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.txtBuscarProd = New System.Windows.Forms.TextBox()
        Me.mnsProd = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.tbpSimple.SuspendLayout()
        CType(Me.nupSimpleCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpAvanzado.SuspendLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpleEliminar
        '
        Me.btnSimpleEliminar.Enabled = False
        Me.btnSimpleEliminar.Location = New System.Drawing.Point(975, 567)
        Me.btnSimpleEliminar.Name = "btnSimpleEliminar"
        Me.btnSimpleEliminar.Size = New System.Drawing.Size(132, 43)
        Me.btnSimpleEliminar.TabIndex = 65
        Me.btnSimpleEliminar.Text = "ELIMINAR POR COMPLETO"
        Me.btnSimpleEliminar.UseVisualStyleBackColor = True
        Me.btnSimpleEliminar.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpSimple)
        Me.TabControl1.Controls.Add(Me.tbpAvanzado)
        Me.TabControl1.Enabled = False
        Me.TabControl1.Location = New System.Drawing.Point(12, 398)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(909, 250)
        Me.TabControl1.TabIndex = 64
        Me.TabControl1.Visible = False
        '
        'tbpSimple
        '
        Me.tbpSimple.Controls.Add(Me.lblSimpleRazon)
        Me.tbpSimple.Controls.Add(Me.lblSimpleStock)
        Me.tbpSimple.Controls.Add(Me.cmbSimpleRazon)
        Me.tbpSimple.Controls.Add(Me.lblSimpleStockCrit)
        Me.tbpSimple.Controls.Add(Me.lblSimplePrecio)
        Me.tbpSimple.Controls.Add(Me.lblSimpleCat)
        Me.tbpSimple.Controls.Add(Me.lblSimpleProd)
        Me.tbpSimple.Controls.Add(Me.lblSimpleId)
        Me.tbpSimple.Controls.Add(Me.nupSimpleCantidad)
        Me.tbpSimple.Controls.Add(Me.lblSimpleCantidad)
        Me.tbpSimple.Location = New System.Drawing.Point(4, 22)
        Me.tbpSimple.Name = "tbpSimple"
        Me.tbpSimple.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSimple.Size = New System.Drawing.Size(901, 224)
        Me.tbpSimple.TabIndex = 0
        Me.tbpSimple.Text = "Simple"
        Me.tbpSimple.UseVisualStyleBackColor = True
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
        'tbpAvanzado
        '
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoId)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoRazon)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoStock)
        Me.tbpAvanzado.Controls.Add(Me.cmbAvanzadoRazon)
        Me.tbpAvanzado.Controls.Add(Me.Label4)
        Me.tbpAvanzado.Controls.Add(Me.cmbAvanzadoCat)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoCat)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoStockCrit)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoPrecio)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoProd)
        Me.tbpAvanzado.Controls.Add(Me.txtAvanzadoStockCrit)
        Me.tbpAvanzado.Controls.Add(Me.txtAvanzadoPrecio)
        Me.tbpAvanzado.Controls.Add(Me.txtAvanzadoStock)
        Me.tbpAvanzado.Controls.Add(Me.txtAvanzadoProd)
        Me.tbpAvanzado.Location = New System.Drawing.Point(4, 22)
        Me.tbpAvanzado.Name = "tbpAvanzado"
        Me.tbpAvanzado.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAvanzado.Size = New System.Drawing.Size(901, 224)
        Me.tbpAvanzado.TabIndex = 1
        Me.tbpAvanzado.Text = "Avanzado"
        Me.tbpAvanzado.UseVisualStyleBackColor = True
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
        'cmbBuscar
        '
        Me.cmbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBuscar.Items.AddRange(New Object() {"Nombre", "Categoria", "Precio"})
        Me.cmbBuscar.Location = New System.Drawing.Point(12, 75)
        Me.cmbBuscar.Name = "cmbBuscar"
        Me.cmbBuscar.Size = New System.Drawing.Size(210, 21)
        Me.cmbBuscar.TabIndex = 63
        '
        'btnCan
        '
        Me.btnCan.Enabled = False
        Me.btnCan.Location = New System.Drawing.Point(975, 509)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(132, 43)
        Me.btnCan.TabIndex = 62
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnAce
        '
        Me.btnAce.Enabled = False
        Me.btnAce.Location = New System.Drawing.Point(975, 444)
        Me.btnAce.Name = "btnAce"
        Me.btnAce.Size = New System.Drawing.Size(132, 43)
        Me.btnAce.TabIndex = 61
        Me.btnAce.Text = "Aceptar"
        Me.btnAce.UseVisualStyleBackColor = True
        '
        'dgvProd
        '
        Me.dgvProd.AllowUserToAddRows = False
        Me.dgvProd.AllowUserToDeleteRows = False
        Me.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProd.Location = New System.Drawing.Point(12, 115)
        Me.dgvProd.MultiSelect = False
        Me.dgvProd.Name = "dgvProd"
        Me.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProd.Size = New System.Drawing.Size(1127, 269)
        Me.dgvProd.TabIndex = 58
        '
        'txtBuscarProd
        '
        Me.txtBuscarProd.Location = New System.Drawing.Point(228, 76)
        Me.txtBuscarProd.Name = "txtBuscarProd"
        Me.txtBuscarProd.Size = New System.Drawing.Size(911, 20)
        Me.txtBuscarProd.TabIndex = 59
        '
        'mnsProd
        '
        Me.mnsProd.AutoSize = False
        Me.mnsProd.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregar, Me.tsmEditar, Me.tsmEliminar})
        Me.mnsProd.Location = New System.Drawing.Point(0, 40)
        Me.mnsProd.Name = "mnsProd"
        Me.mnsProd.Size = New System.Drawing.Size(1139, 24)
        Me.mnsProd.TabIndex = 60
        Me.mnsProd.Text = "MenuStrip1"
        '
        'tsmAgregar
        '
        Me.tsmAgregar.Image = CType(resources.GetObject("tsmAgregar.Image"), System.Drawing.Image)
        Me.tsmAgregar.Name = "tsmAgregar"
        Me.tsmAgregar.Size = New System.Drawing.Size(77, 20)
        Me.tsmAgregar.Text = "Agregar"
        '
        'tsmEditar
        '
        Me.tsmEditar.Image = CType(resources.GetObject("tsmEditar.Image"), System.Drawing.Image)
        Me.tsmEditar.Name = "tsmEditar"
        Me.tsmEditar.Size = New System.Drawing.Size(65, 20)
        Me.tsmEditar.Text = "Editar"
        '
        'tsmEliminar
        '
        Me.tsmEliminar.Image = CType(resources.GetObject("tsmEliminar.Image"), System.Drawing.Image)
        Me.tsmEliminar.Name = "tsmEliminar"
        Me.tsmEliminar.Size = New System.Drawing.Size(78, 20)
        Me.tsmEliminar.Text = "Eliminar"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(35, 23)
        Me.BtnExit.TabIndex = 66
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'frmProd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnSimpleEliminar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cmbBuscar)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAce)
        Me.Controls.Add(Me.dgvProd)
        Me.Controls.Add(Me.txtBuscarProd)
        Me.Controls.Add(Me.mnsProd)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProd2"
        Me.Text = "frmProd2"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpSimple.ResumeLayout(False)
        Me.tbpSimple.PerformLayout()
        CType(Me.nupSimpleCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpAvanzado.ResumeLayout(False)
        Me.tbpAvanzado.PerformLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsProd.ResumeLayout(False)
        Me.mnsProd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpleEliminar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpSimple As TabPage
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
    Friend WithEvents tbpAvanzado As TabPage
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
    Friend WithEvents cmbBuscar As ComboBox
    Friend WithEvents btnCan As Button
    Friend WithEvents btnAce As Button
    Friend WithEvents dgvProd As DataGridView
    Friend WithEvents txtBuscarProd As TextBox
    Friend WithEvents mnsProd As MenuStrip
    Friend WithEvents tsmAgregar As ToolStripMenuItem
    Friend WithEvents tsmEditar As ToolStripMenuItem
    Friend WithEvents tsmEliminar As ToolStripMenuItem
    Friend WithEvents BtnExit As Button
End Class
