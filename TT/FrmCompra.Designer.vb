<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompra
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.txtNumFolio = New System.Windows.Forms.TextBox()
        Me.lblNumFolio = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.txtRutSnDV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvBusqueda = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvProductosSeleccionados = New System.Windows.Forms.DataGridView()
        Me.codProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.LblFranjaNaranja = New System.Windows.Forms.Label()
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(827, 570)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 32)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "ESCANEAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(590, 168)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(59, 23)
        Me.lblTotal.TabIndex = 87
        Me.lblTotal.Text = "TOTAL:"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(680, 165)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(160, 30)
        Me.txtTotal.TabIndex = 86
        '
        'txtIva
        '
        Me.txtIva.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(680, 119)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(160, 30)
        Me.txtIva.TabIndex = 85
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(595, 122)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(54, 23)
        Me.lblIva.TabIndex = 84
        Me.lblIva.Text = "IVA      :"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(130, 168)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(118, 23)
        Me.lblRut.TabIndex = 83
        Me.lblRut.Text = "Rut Proveedor:"
        '
        'txtNumFolio
        '
        Me.txtNumFolio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumFolio.Location = New System.Drawing.Point(273, 119)
        Me.txtNumFolio.Name = "txtNumFolio"
        Me.txtNumFolio.Size = New System.Drawing.Size(218, 30)
        Me.txtNumFolio.TabIndex = 82
        '
        'lblNumFolio
        '
        Me.lblNumFolio.AutoSize = True
        Me.lblNumFolio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumFolio.Location = New System.Drawing.Point(130, 119)
        Me.lblNumFolio.Name = "lblNumFolio"
        Me.lblNumFolio.Size = New System.Drawing.Size(108, 23)
        Me.lblNumFolio.TabIndex = 81
        Me.lblNumFolio.Text = "Num_folio       :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 23)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Producto:"
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_guardar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_guardar.Location = New System.Drawing.Point(500, 612)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(198, 33)
        Me.btn_guardar.TabIndex = 96
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArchivo.Location = New System.Drawing.Point(172, 575)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(76, 23)
        Me.lblArchivo.TabIndex = 99
        Me.lblArchivo.Text = "ARCHIVO:"
        '
        'txtArchivo
        '
        Me.txtArchivo.Enabled = False
        Me.txtArchivo.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(254, 572)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(557, 30)
        Me.txtArchivo.TabIndex = 100
        '
        'txtDV
        '
        Me.txtDV.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDV.Location = New System.Drawing.Point(440, 165)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(51, 30)
        Me.txtDV.TabIndex = 105
        '
        'txtRutSnDV
        '
        Me.txtRutSnDV.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutSnDV.Location = New System.Drawing.Point(273, 165)
        Me.txtRutSnDV.MaxLength = 8
        Me.txtRutSnDV.Name = "txtRutSnDV"
        Me.txtRutSnDV.Size = New System.Drawing.Size(139, 30)
        Me.txtRutSnDV.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(418, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 23)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "-"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.AllowUserToResizeColumns = False
        Me.dgvBusqueda.AllowUserToResizeRows = False
        Me.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvBusqueda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBusqueda.Location = New System.Drawing.Point(80, 304)
        Me.dgvBusqueda.MultiSelect = False
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(1007, 111)
        Me.dgvBusqueda.TabIndex = 109
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkBlue
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(955, 218)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 31)
        Me.btnBuscar.TabIndex = 108
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(210, 218)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(709, 31)
        Me.txtBuscar.TabIndex = 107
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.DarkGreen
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(834, 262)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(176, 30)
        Me.btnAgregar.TabIndex = 110
        Me.btnAgregar.Text = "Agregar al carro de compras"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvProductosSeleccionados
        '
        Me.dgvProductosSeleccionados.AllowUserToAddRows = False
        Me.dgvProductosSeleccionados.AllowUserToDeleteRows = False
        Me.dgvProductosSeleccionados.AllowUserToResizeColumns = False
        Me.dgvProductosSeleccionados.AllowUserToResizeRows = False
        Me.dgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductosSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codProducto, Me.Nombre, Me.Precio, Me.Cantidad, Me.Descuento})
        Me.dgvProductosSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvProductosSeleccionados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductosSeleccionados.Location = New System.Drawing.Point(80, 425)
        Me.dgvProductosSeleccionados.MultiSelect = False
        Me.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados"
        Me.dgvProductosSeleccionados.ReadOnly = True
        Me.dgvProductosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosSeleccionados.Size = New System.Drawing.Size(1007, 133)
        Me.dgvProductosSeleccionados.TabIndex = 111
        '
        'codProducto
        '
        Me.codProducto.HeaderText = "Codigo producto"
        Me.codProducto.Name = "codProducto"
        Me.codProducto.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.HeaderText = "SubTotal"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Orange
        Me.txtSubTotal.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(713, 262)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 30)
        Me.txtSubTotal.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(626, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 23)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "SubTotal:"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.Orange
        Me.txtPrecio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(250, 262)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 30)
        Me.txtPrecio.TabIndex = 115
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(183, 265)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(61, 23)
        Me.lblPrecio.TabIndex = 114
        Me.lblPrecio.Text = "Precio:"
        '
        'txtCant
        '
        Me.txtCant.BackColor = System.Drawing.Color.Orange
        Me.txtCant.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.Location = New System.Drawing.Point(484, 262)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 30)
        Me.txtCant.TabIndex = 113
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(389, 265)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(79, 23)
        Me.lblCant.TabIndex = 112
        Me.lblCant.Text = "Cantidad:"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(1123, 6)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(35, 23)
        Me.BtnExit.TabIndex = 118
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSeleccionar.Location = New System.Drawing.Point(960, 570)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(127, 32)
        Me.BtnSeleccionar.TabIndex = 119
        Me.BtnSeleccionar.Text = "SELECCIONAR"
        Me.BtnSeleccionar.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.DarkBlue
        Me.LblTitulo.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitulo.Location = New System.Drawing.Point(0, 38)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(1173, 40)
        Me.LblTitulo.TabIndex = 120
        Me.LblTitulo.Text = "REGISTRAR COMPRA"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblFranjaNaranja
        '
        Me.LblFranjaNaranja.BackColor = System.Drawing.Color.DarkOrange
        Me.LblFranjaNaranja.Location = New System.Drawing.Point(0, 78)
        Me.LblFranjaNaranja.Name = "LblFranjaNaranja"
        Me.LblFranjaNaranja.Size = New System.Drawing.Size(1173, 24)
        Me.LblFranjaNaranja.TabIndex = 121
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.LblFranjaNaranja)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.dgvProductosSeleccionados)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvBusqueda)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.txtDV)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRutSnDV)
        Me.Controls.Add(Me.txtArchivo)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.lblRut)
        Me.Controls.Add(Me.txtNumFolio)
        Me.Controls.Add(Me.lblNumFolio)
        Me.Controls.Add(Me.Button2)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmCompra"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtIva As TextBox
    Friend WithEvents lblIva As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents txtNumFolio As TextBox
    Friend WithEvents lblNumFolio As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lblArchivo As Label
    Friend WithEvents txtArchivo As TextBox
    Friend WithEvents txtDV As TextBox
    Friend WithEvents txtRutSnDV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvBusqueda As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents dgvProductosSeleccionados As DataGridView
    Friend WithEvents codProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents lblCant As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents LblTitulo As Label
    Friend WithEvents LblFranjaNaranja As Label
End Class
