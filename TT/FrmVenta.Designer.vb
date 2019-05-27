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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtDescProd = New System.Windows.Forms.TextBox()
        Me.lblDescProd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.chkFactura = New System.Windows.Forms.CheckBox()
        Me.chkBoleta = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVend
        '
        Me.lblVend.AutoSize = True
        Me.lblVend.Location = New System.Drawing.Point(98, 77)
        Me.lblVend.Name = "lblVend"
        Me.lblVend.Size = New System.Drawing.Size(56, 13)
        Me.lblVend.TabIndex = 0
        Me.lblVend.Text = "Vendedor:"
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(553, 25)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(233, 31)
        Me.lblVenta.TabIndex = 2
        Me.lblVenta.Text = "Numero de Venta:"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(92, 107)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(62, 13)
        Me.lblRut.TabIndex = 4
        Me.lblRut.Text = "Rut Cliente:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(547, 79)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha:"
        '
        'txtSubto
        '
        Me.txtSubto.Location = New System.Drawing.Point(646, 520)
        Me.txtSubto.Name = "txtSubto"
        Me.txtSubto.Size = New System.Drawing.Size(117, 20)
        Me.txtSubto.TabIndex = 8
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(646, 546)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(117, 20)
        Me.txtDesc.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(646, 598)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(117, 20)
        Me.txtTotal.TabIndex = 10
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(646, 572)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(117, 20)
        Me.txtIva.TabIndex = 11
        '
        'lblSubto
        '
        Me.lblSubto.AutoSize = True
        Me.lblSubto.Location = New System.Drawing.Point(572, 520)
        Me.lblSubto.Name = "lblSubto"
        Me.lblSubto.Size = New System.Drawing.Size(49, 13)
        Me.lblSubto.TabIndex = 15
        Me.lblSubto.Text = "Subtotal:"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(572, 546)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(62, 13)
        Me.lblDesc.TabIndex = 16
        Me.lblDesc.Text = "Descuento:"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Location = New System.Drawing.Point(572, 575)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(27, 13)
        Me.lblIva.TabIndex = 17
        Me.lblIva.Text = "IVA:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(572, 605)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(865, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 31)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 31)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "PRODUCTOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Producto:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(151, 187)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(736, 21)
        Me.ComboBox2.TabIndex = 23
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(93, 235)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(61, 13)
        Me.lblCant.TabIndex = 24
        Me.lblCant.Text = "Cantidad:"
        '
        'txtCant
        '
        Me.txtCant.BackColor = System.Drawing.Color.Orange
        Me.txtCant.Location = New System.Drawing.Point(151, 232)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 25
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.Orange
        Me.txtPrecio.Location = New System.Drawing.Point(468, 232)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 27
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(422, 235)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 26
        Me.lblPrecio.Text = "Precio:"
        '
        'txtDescProd
        '
        Me.txtDescProd.BackColor = System.Drawing.Color.Orange
        Me.txtDescProd.Location = New System.Drawing.Point(696, 232)
        Me.txtDescProd.Name = "txtDescProd"
        Me.txtDescProd.Size = New System.Drawing.Size(100, 20)
        Me.txtDescProd.TabIndex = 29
        '
        'lblDescProd
        '
        Me.lblDescProd.AutoSize = True
        Me.lblDescProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescProd.Location = New System.Drawing.Point(625, 235)
        Me.lblDescProd.Name = "lblDescProd"
        Me.lblDescProd.Size = New System.Drawing.Size(72, 13)
        Me.lblDescProd.TabIndex = 28
        Me.lblDescProd.Text = "Descuento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(279, 232)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(314, 232)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(98, 263)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 108)
        Me.DataGridView1.TabIndex = 32
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(98, 390)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(789, 118)
        Me.DataGridView2.TabIndex = 33
        '
        'chkFactura
        '
        Me.chkFactura.AutoSize = True
        Me.chkFactura.Location = New System.Drawing.Point(346, 542)
        Me.chkFactura.Name = "chkFactura"
        Me.chkFactura.Size = New System.Drawing.Size(62, 17)
        Me.chkFactura.TabIndex = 34
        Me.chkFactura.Text = "Factura"
        Me.chkFactura.UseVisualStyleBackColor = True
        '
        'chkBoleta
        '
        Me.chkBoleta.AutoSize = True
        Me.chkBoleta.Location = New System.Drawing.Point(346, 575)
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
        Me.Label5.Location = New System.Drawing.Point(187, 552)
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
        Me.cmbVendedor.Location = New System.Drawing.Point(163, 74)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(301, 21)
        Me.cmbVendedor.TabIndex = 69
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(163, 102)
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
        Me.txtFecha.Location = New System.Drawing.Point(598, 74)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(160, 20)
        Me.txtFecha.TabIndex = 12
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1157, 631)
        Me.Controls.Add(Me.cmbClientes)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkBoleta)
        Me.Controls.Add(Me.chkFactura)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDescProd)
        Me.Controls.Add(Me.lblDescProd)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.ComboBox2)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lblCant As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtDescProd As TextBox
    Friend WithEvents lblDescProd As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents chkFactura As CheckBox
    Friend WithEvents chkBoleta As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents cmbVendedor As ComboBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Timer2 As Timer
End Class
