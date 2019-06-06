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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.agregarCantidad = New System.Windows.Forms.PictureBox()
        Me.disminuirCantidad = New System.Windows.Forms.PictureBox()
        Me.chkFactura = New System.Windows.Forms.CheckBox()
        Me.chkBoleta = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.dgvProductosSeleccionados = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.nmudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.lblVend.Location = New System.Drawing.Point(167, 74)
        Me.lblVend.Name = "lblVend"
        Me.lblVend.Size = New System.Drawing.Size(56, 13)
        Me.lblVend.TabIndex = 0
        Me.lblVend.Text = "Vendedor:"
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(622, 22)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(233, 31)
        Me.lblVenta.TabIndex = 2
        Me.lblVenta.Text = "Numero de Venta:"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(161, 104)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(62, 13)
        Me.lblRut.TabIndex = 4
        Me.lblRut.Text = "Rut Cliente:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(616, 76)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha:"
        '
        'txtSubto
        '
        Me.txtSubto.Enabled = False
        Me.txtSubto.Location = New System.Drawing.Point(628, 524)
        Me.txtSubto.Name = "txtSubto"
        Me.txtSubto.Size = New System.Drawing.Size(117, 20)
        Me.txtSubto.TabIndex = 8
        '
        'txtDesc
        '
        Me.txtDesc.Enabled = False
        Me.txtDesc.Location = New System.Drawing.Point(628, 550)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(117, 20)
        Me.txtDesc.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(628, 602)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(117, 20)
        Me.txtTotal.TabIndex = 10
        Me.txtTotal.Text = "0"
        '
        'txtIva
        '
        Me.txtIva.Enabled = False
        Me.txtIva.Location = New System.Drawing.Point(628, 576)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(117, 20)
        Me.txtIva.TabIndex = 11
        '
        'lblSubto
        '
        Me.lblSubto.AutoSize = True
        Me.lblSubto.Location = New System.Drawing.Point(555, 526)
        Me.lblSubto.Name = "lblSubto"
        Me.lblSubto.Size = New System.Drawing.Size(49, 13)
        Me.lblSubto.TabIndex = 15
        Me.lblSubto.Text = "Subtotal:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(554, 550)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(62, 13)
        Me.lblDesc.TabIndex = 16
        Me.lblDesc.Text = "Descuento:"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(554, 579)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(27, 13)
        Me.lblIva.TabIndex = 17
        Me.lblIva.Text = "IVA:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(554, 609)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(934, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 31)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 31)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "PRODUCTOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Producto:"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(977, 208)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(61, 13)
        Me.lblCant.TabIndex = 24
        Me.lblCant.Text = "Cantidad:"
        '
        'agregarCantidad
        '
        Me.agregarCantidad.Image = CType(resources.GetObject("agregarCantidad.Image"), System.Drawing.Image)
        Me.agregarCantidad.Location = New System.Drawing.Point(979, 416)
        Me.agregarCantidad.Name = "agregarCantidad"
        Me.agregarCantidad.Size = New System.Drawing.Size(29, 22)
        Me.agregarCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.agregarCantidad.TabIndex = 30
        Me.agregarCantidad.TabStop = False
        '
        'disminuirCantidad
        '
        Me.disminuirCantidad.Image = CType(resources.GetObject("disminuirCantidad.Image"), System.Drawing.Image)
        Me.disminuirCantidad.Location = New System.Drawing.Point(1014, 416)
        Me.disminuirCantidad.Name = "disminuirCantidad"
        Me.disminuirCantidad.Size = New System.Drawing.Size(29, 22)
        Me.disminuirCantidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.disminuirCantidad.TabIndex = 31
        Me.disminuirCantidad.TabStop = False
        '
        'chkFactura
        '
        Me.chkFactura.AutoSize = True
        Me.chkFactura.Location = New System.Drawing.Point(328, 546)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(62, 17)
        Me.chkFactura.TabIndex = 34
        Me.chkFactura.Text = "Factura"
        Me.chkFactura.UseVisualStyleBackColor = True
        '
        'chkBoleta
        '
        Me.chkBoleta.AutoSize = True
        Me.chkBoleta.Location = New System.Drawing.Point(328, 579)
        Me.chkBoleta.Name = "chkBoleta"
        Me.chkBoleta.Size = New System.Drawing.Size(56, 17)
        Me.chkBoleta.TabIndex = 35
        Me.chkBoleta.Text = "Boleta"
        Me.chkBoleta.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 556)
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
        'cmbVendedor
        '
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(232, 71)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(301, 21)
        Me.cmbVendedor.TabIndex = 69
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(232, 99)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(301, 21)
        Me.cmbClientes.TabIndex = 70
        '
        'Timer1
        '
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(667, 71)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(160, 20)
        Me.txtFecha.TabIndex = 12
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(228, 159)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(637, 20)
        Me.txtBuscar.TabIndex = 71
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(885, 158)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(71, 21)
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
        Me.dgvProductos.Location = New System.Drawing.Point(166, 193)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(789, 133)
        Me.dgvProductos.TabIndex = 73
        '
        'dgvProductosSeleccionados
        '
        Me.dgvProductosSeleccionados.AllowUserToAddRows = False
        Me.dgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Precio, Me.Cantidad, Me.Descuento})
        Me.dgvProductosSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvProductosSeleccionados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductosSeleccionados.Location = New System.Drawing.Point(166, 366)
        Me.dgvProductosSeleccionados.MultiSelect = False
        Me.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados"
        Me.dgvProductosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosSeleccionados.Size = New System.Drawing.Size(789, 133)
        Me.dgvProductosSeleccionados.TabIndex = 74
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
        Me.btnAgregar.Location = New System.Drawing.Point(979, 253)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(160, 49)
        Me.btnAgregar.TabIndex = 75
        Me.btnAgregar.Text = "Agregar al carro de compras"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'nmudCantidad
        '
        Me.nmudCantidad.Location = New System.Drawing.Point(979, 227)
        Me.nmudCantidad.Name = "nmudCantidad"
        Me.nmudCantidad.Size = New System.Drawing.Size(160, 20)
        Me.nmudCantidad.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(191, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(729, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "Para eliminar un producto de la lista, seleccione un producto de la lista y presi" &
    "one la tecla suprimir(supr)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(976, 391)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 13)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Aumentar/Disminuir Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(725, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(230, 31)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Carro de compras"
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1157, 631)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nmudCantidad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvProductosSeleccionados)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkBoleta)
        Me.Controls.Add(Me.chkFactura)
        Me.Controls.Add(Me.disminuirCantidad)
        Me.Controls.Add(Me.agregarCantidad)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCant As Label
    Friend WithEvents agregarCantidad As PictureBox
    Friend WithEvents disminuirCantidad As PictureBox
    Friend WithEvents chkFactura As CheckBox
    Friend WithEvents chkBoleta As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents cmbVendedor As ComboBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents dgvProductosSeleccionados As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents nmudCantidad As NumericUpDown
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
