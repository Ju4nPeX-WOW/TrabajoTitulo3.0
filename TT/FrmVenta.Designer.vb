<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVenta
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.lblVend = New System.Windows.Forms.Label()
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtSubto = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.lblSubto = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTransaccion = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.agregarCantidad = New System.Windows.Forms.PictureBox()
        Me.disminuirCantidad = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvProductosSeleccionados = New System.Windows.Forms.DataGridView()
        Me.codProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.nmudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipoVenta = New System.Windows.Forms.ComboBox()
        Me.btnRealizarVenta = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.txtRutSnDV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        CType(Me.agregarCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.disminuirCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVend
        '
        Me.lblVend.AutoSize = True
        Me.lblVend.Location = New System.Drawing.Point(58, 70)
        Me.lblVend.Name = "lblVend"
        Me.lblVend.Size = New System.Drawing.Size(56, 13)
        Me.lblVend.TabIndex = 0
        Me.lblVend.Text = "Vendedor:"
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(513, 18)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(233, 31)
        Me.lblVenta.TabIndex = 2
        Me.lblVenta.Text = "Numero de Venta:"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(52, 100)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(62, 13)
        Me.lblRut.TabIndex = 4
        Me.lblRut.Text = "Rut Cliente:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(507, 72)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha:"
        '
        'txtSubto
        '
        Me.txtSubto.Enabled = False
        Me.txtSubto.Location = New System.Drawing.Point(519, 520)
        Me.txtSubto.Name = "txtSubto"
        Me.txtSubto.Size = New System.Drawing.Size(117, 20)
        Me.txtSubto.TabIndex = 8
        Me.txtSubto.Text = "0"
        '
        'txtDesc
        '
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(519, 546)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(117, 20)
        Me.txtDesc.TabIndex = 9
        Me.txtDesc.Text = "0"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(519, 599)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(117, 20)
        Me.txtTotal.TabIndex = 10
        Me.txtTotal.Text = "0"
        '
        'txtIva
        '
        Me.txtIva.Enabled = False
        Me.txtIva.Location = New System.Drawing.Point(519, 572)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(117, 20)
        Me.txtIva.TabIndex = 11
        Me.txtIva.Text = "19%"
        '
        'lblSubto
        '
        Me.lblSubto.AutoSize = True
        Me.lblSubto.Location = New System.Drawing.Point(446, 522)
        Me.lblSubto.Name = "lblSubto"
        Me.lblSubto.Size = New System.Drawing.Size(49, 13)
        Me.lblSubto.TabIndex = 15
        Me.lblSubto.Text = "Subtotal:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(445, 546)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(62, 13)
        Me.lblDesc.TabIndex = 16
        Me.lblDesc.Text = "Descuento:"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(445, 575)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(27, 13)
        Me.lblIva.TabIndex = 17
        Me.lblIva.Text = "IVA:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(446, 602)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total:"
        '
        'lblTransaccion
        '
        Me.lblTransaccion.AutoSize = True
        Me.lblTransaccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransaccion.Location = New System.Drawing.Point(752, 18)
        Me.lblTransaccion.Name = "lblTransaccion"
        Me.lblTransaccion.Size = New System.Drawing.Size(29, 31)
        Me.lblTransaccion.TabIndex = 20
        Me.lblTransaccion.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 31)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "PRODUCTOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Producto:"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(590, 164)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(61, 13)
        Me.lblCant.TabIndex = 24
        Me.lblCant.Text = "Cantidad:"
        '
        'agregarCantidad
        '
        Me.agregarCantidad.Image = CType(resources.GetObject("agregarCantidad.Image"), System.Drawing.Image)
        Me.agregarCantidad.Location = New System.Drawing.Point(750, 410)
        Me.agregarCantidad.Name = "agregarCantidad"
        Me.agregarCantidad.Size = New System.Drawing.Size(29, 22)
        Me.agregarCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.agregarCantidad.TabIndex = 30
        Me.agregarCantidad.TabStop = False
        '
        'disminuirCantidad
        '
        Me.disminuirCantidad.Image = CType(resources.GetObject("disminuirCantidad.Image"), System.Drawing.Image)
        Me.disminuirCantidad.Location = New System.Drawing.Point(785, 410)
        Me.disminuirCantidad.Name = "disminuirCantidad"
        Me.disminuirCantidad.Size = New System.Drawing.Size(29, 22)
        Me.disminuirCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.disminuirCantidad.TabIndex = 31
        Me.disminuirCantidad.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 522)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 24)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Tipo de venta:"
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(35, 23)
        Me.BtnExit.TabIndex = 67
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(558, 67)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(160, 20)
        Me.txtFecha.TabIndex = 12
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(119, 155)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(361, 31)
        Me.txtBuscar.TabIndex = 71
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(486, 155)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(84, 31)
        Me.btnBuscar.TabIndex = 72
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.Location = New System.Drawing.Point(57, 204)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(789, 111)
        Me.dgvProductos.TabIndex = 73
        '
        'dgvProductosSeleccionados
        '
        Me.dgvProductosSeleccionados.AllowUserToAddRows = False
        Me.dgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codProducto, Me.Nombre, Me.Precio, Me.Cantidad, Me.Descuento})
        Me.dgvProductosSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvProductosSeleccionados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductosSeleccionados.Location = New System.Drawing.Point(57, 355)
        Me.dgvProductosSeleccionados.MultiSelect = False
        Me.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados"
        Me.dgvProductosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosSeleccionados.Size = New System.Drawing.Size(639, 133)
        Me.dgvProductosSeleccionados.TabIndex = 74
        '
        'codProducto
        '
        Me.codProducto.HeaderText = "Codigo producto"
        Me.codProducto.Name = "codProducto"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(752, 150)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 40)
        Me.btnAgregar.TabIndex = 75
        Me.btnAgregar.Text = "Agregar al carro de compras"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'nmudCantidad
        '
        Me.nmudCantidad.Location = New System.Drawing.Point(657, 162)
        Me.nmudCantidad.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nmudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmudCantidad.Name = "nmudCantidad"
        Me.nmudCantidad.Size = New System.Drawing.Size(89, 20)
        Me.nmudCantidad.TabIndex = 76
        Me.nmudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(57, 491)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(729, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Para eliminar un producto de la lista, seleccione un producto de la lista y presi" &
    "one la tecla suprimir(supr)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(702, 384)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Aumentar/Disminuir Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 31)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Carro de compras"
        '
        'cmbTipoVenta
        '
        Me.cmbTipoVenta.FormattingEnabled = True
        Me.cmbTipoVenta.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbTipoVenta.Location = New System.Drawing.Point(220, 525)
        Me.cmbTipoVenta.Name = "cmbTipoVenta"
        Me.cmbTipoVenta.Size = New System.Drawing.Size(187, 21)
        Me.cmbTipoVenta.TabIndex = 80
        Me.cmbTipoVenta.Text = "Seleccione un tipo de venta..."
        '
        'btnRealizarVenta
        '
        Me.btnRealizarVenta.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarVenta.Location = New System.Drawing.Point(679, 530)
        Me.btnRealizarVenta.Name = "btnRealizarVenta"
        Me.btnRealizarVenta.Size = New System.Drawing.Size(167, 73)
        Me.btnRealizarVenta.TabIndex = 81
        Me.btnRealizarVenta.Text = "Realizar venta"
        Me.btnRealizarVenta.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 24)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Metodo de pago:"
        '
        'cmbMetodoPago
        '
        Me.cmbMetodoPago.FormattingEnabled = True
        Me.cmbMetodoPago.Items.AddRange(New Object() {"Efectivo", "Debito", "Credito"})
        Me.cmbMetodoPago.Location = New System.Drawing.Point(220, 564)
        Me.cmbMetodoPago.Name = "cmbMetodoPago"
        Me.cmbMetodoPago.Size = New System.Drawing.Size(187, 21)
        Me.cmbMetodoPago.TabIndex = 83
        Me.cmbMetodoPago.Text = "Seleccione un metodo de pago..."
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(290, 99)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(51, 20)
        Me.txtDV.TabIndex = 101
        '
        'txtRutSnDV
        '
        Me.txtRutSnDV.Location = New System.Drawing.Point(123, 99)
        Me.txtRutSnDV.MaxLength = 8
        Me.txtRutSnDV.Name = "txtRutSnDV"
        Me.txtRutSnDV.Size = New System.Drawing.Size(145, 20)
        Me.txtRutSnDV.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "-"
        '
        'txtVendedor
        '
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Location = New System.Drawing.Point(120, 67)
        Me.txtVendedor.MaxLength = 8
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(221, 20)
        Me.txtVendedor.TabIndex = 102
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Location = New System.Drawing.Point(497, 99)
        Me.txtNombreCliente.MaxLength = 8
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(221, 20)
        Me.txtNombreCliente.TabIndex = 104
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(393, 102)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(82, 13)
        Me.lblNombreCliente.TabIndex = 103
        Me.lblNombreCliente.Text = "Nombre Cliente:"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1157, 631)
        Me.Controls.Add(Me.txtNombreCliente)
        Me.Controls.Add(Me.lblNombreCliente)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.txtDV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRutSnDV)
        Me.Controls.Add(Me.cmbMetodoPago)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnRealizarVenta)
        Me.Controls.Add(Me.cmbTipoVenta)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmudCantidad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvProductosSeleccionados)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.disminuirCantidad)
        Me.Controls.Add(Me.agregarCantidad)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTransaccion)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblSubto)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtSubto)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.lblVenta)
        Me.Controls.Add(Me.lblVend)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(150, 45)
        Me.Name = "frmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "frmVenta"
        CType(Me.agregarCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.disminuirCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVend As Label
    Friend WithEvents lblVenta As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtSubto As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents lblSubto As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTransaccion As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCant As Label
    Friend WithEvents agregarCantidad As PictureBox
    Friend WithEvents disminuirCantidad As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvProductosSeleccionados As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents nmudCantidad As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTipoVenta As ComboBox
    Friend WithEvents btnRealizarVenta As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbMetodoPago As ComboBox
    Friend WithEvents codProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents txtDV As TextBox
    Friend WithEvents txtRutSnDV As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVendedor As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents lblNombreCliente As Label
End Class
