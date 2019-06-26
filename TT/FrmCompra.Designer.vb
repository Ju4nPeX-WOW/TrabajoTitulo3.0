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
        Me.BtnExitCat = New System.Windows.Forms.Button()
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
        Me.lblUsuario = New System.Windows.Forms.Label()
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
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExitCat
        '
        Me.BtnExitCat.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExitCat.Name = "BtnExitCat"
        Me.BtnExitCat.Size = New System.Drawing.Size(35, 23)
        Me.BtnExitCat.TabIndex = 77
        Me.BtnExitCat.Text = "X"
        Me.BtnExitCat.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(819, 579)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 80
        Me.Button2.Text = "ESCANEAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(657, 155)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(45, 13)
        Me.lblTotal.TabIndex = 87
        Me.lblTotal.Text = "TOTAL:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(708, 152)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(160, 20)
        Me.txtTotal.TabIndex = 86
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(708, 126)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(160, 20)
        Me.txtIva.TabIndex = 85
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(657, 131)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(45, 13)
        Me.lblIva.TabIndex = 84
        Me.lblIva.Text = "IVA      :"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(188, 157)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(79, 13)
        Me.lblRut.TabIndex = 83
        Me.lblRut.Text = "Rut Proveedor:"
        '
        'txtNumFolio
        '
        Me.txtNumFolio.Location = New System.Drawing.Point(273, 126)
        Me.txtNumFolio.Name = "txtNumFolio"
        Me.txtNumFolio.Size = New System.Drawing.Size(218, 20)
        Me.txtNumFolio.TabIndex = 82
        '
        'lblNumFolio
        '
        Me.lblNumFolio.AutoSize = True
        Me.lblNumFolio.Location = New System.Drawing.Point(188, 129)
        Me.lblNumFolio.Name = "lblNumFolio"
        Me.lblNumFolio.Size = New System.Drawing.Size(78, 13)
        Me.lblNumFolio.TabIndex = 81
        Me.lblNumFolio.Text = "Num_folio       :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(189, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Producto:"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(574, 607)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 96
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(280, 584)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(58, 13)
        Me.lblArchivo.TabIndex = 99
        Me.lblArchivo.Text = "ARCHIVO:"
        '
        'txtArchivo
        '
        Me.txtArchivo.Enabled = False
        Me.txtArchivo.Location = New System.Drawing.Point(344, 581)
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(460, 20)
        Me.txtArchivo.TabIndex = 100
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(456, 55)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(254, 25)
        Me.lblUsuario.TabIndex = 101
        Me.lblUsuario.Text = "INGRESO DE COMPRAS"
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(440, 157)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(51, 20)
        Me.txtDV.TabIndex = 105
        '
        'txtRutSnDV
        '
        Me.txtRutSnDV.Location = New System.Drawing.Point(273, 157)
        Me.txtRutSnDV.MaxLength = 8
        Me.txtRutSnDV.Name = "txtRutSnDV"
        Me.txtRutSnDV.Size = New System.Drawing.Size(145, 20)
        Me.txtRutSnDV.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "-"
        '
        'dgvBusqueda
        '
        Me.dgvBusqueda.AllowUserToAddRows = False
        Me.dgvBusqueda.AllowUserToDeleteRows = False
        Me.dgvBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBusqueda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvBusqueda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBusqueda.Location = New System.Drawing.Point(192, 317)
        Me.dgvBusqueda.MultiSelect = False
        Me.dgvBusqueda.Name = "dgvBusqueda"
        Me.dgvBusqueda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBusqueda.Size = New System.Drawing.Size(789, 111)
        Me.dgvBusqueda.TabIndex = 109
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(887, 237)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 31)
        Me.btnBuscar.TabIndex = 108
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(248, 237)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(633, 31)
        Me.txtBuscar.TabIndex = 107
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(887, 274)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(94, 40)
        Me.btnAgregar.TabIndex = 110
        Me.btnAgregar.Text = "Agregar al carro de compras"
        Me.btnAgregar.UseVisualStyleBackColor = True
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
        Me.dgvProductosSeleccionados.Location = New System.Drawing.Point(193, 434)
        Me.dgvProductosSeleccionados.MultiSelect = False
        Me.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados"
        Me.dgvProductosSeleccionados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductosSeleccionados.Size = New System.Drawing.Size(790, 133)
        Me.dgvProductosSeleccionados.TabIndex = 111
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
        Me.Descuento.HeaderText = "SubTotal"
        Me.Descuento.Name = "Descuento"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Orange
        Me.txtSubTotal.Location = New System.Drawing.Point(742, 285)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 117
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(665, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "SubTotal:"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.Orange
        Me.txtPrecio.Location = New System.Drawing.Point(323, 285)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 115
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(270, 288)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 114
        Me.lblPrecio.Text = "Precio:"
        '
        'txtCant
        '
        Me.txtCant.BackColor = System.Drawing.Color.Orange
        Me.txtCant.Location = New System.Drawing.Point(525, 285)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 113
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(458, 288)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(61, 13)
        Me.lblCant.TabIndex = 112
        Me.lblCant.Text = "Cantidad:"
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
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
        Me.Controls.Add(Me.lblUsuario)
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
        Me.Controls.Add(Me.BtnExitCat)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmCompra"
        CType(Me.dgvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductosSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnExitCat As Button
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
    Friend WithEvents lblUsuario As Label
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
End Class
