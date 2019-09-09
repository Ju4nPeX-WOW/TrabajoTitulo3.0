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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSimpleRazon = New System.Windows.Forms.Label()
        Me.lblSimpleStock = New System.Windows.Forms.Label()
        Me.lblSimpleStockCrit = New System.Windows.Forms.Label()
        Me.lblSimplePrecio = New System.Windows.Forms.Label()
        Me.lblSimpleCat = New System.Windows.Forms.Label()
        Me.lblSimpleProd = New System.Windows.Forms.Label()
        Me.lblSimpleId = New System.Windows.Forms.Label()
        Me.lblSimpleCantidad = New System.Windows.Forms.Label()
        Me.tbpAvanzado = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAvanzadoId = New System.Windows.Forms.Label()
        Me.lblAvanzadoRazon = New System.Windows.Forms.Label()
        Me.lblAvanzadoStock = New System.Windows.Forms.Label()
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
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnAce = New System.Windows.Forms.Button()
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.mnsProd = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbpSimple.SuspendLayout()
        Me.tbpAvanzado.SuspendLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpleEliminar
        '
        Me.btnSimpleEliminar.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSimpleEliminar.Enabled = False
        Me.btnSimpleEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpleEliminar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpleEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSimpleEliminar.Location = New System.Drawing.Point(952, 567)
        Me.btnSimpleEliminar.Name = "btnSimpleEliminar"
        Me.btnSimpleEliminar.Size = New System.Drawing.Size(132, 43)
        Me.btnSimpleEliminar.TabIndex = 65
        Me.btnSimpleEliminar.Text = "ELIMINAR POR COMPLETO"
        Me.btnSimpleEliminar.UseVisualStyleBackColor = False
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
        Me.tbpSimple.Controls.Add(Me.Label7)
        Me.tbpSimple.Controls.Add(Me.Label6)
        Me.tbpSimple.Controls.Add(Me.Label5)
        Me.tbpSimple.Controls.Add(Me.Label3)
        Me.tbpSimple.Controls.Add(Me.Label2)
        Me.tbpSimple.Controls.Add(Me.Label1)
        Me.tbpSimple.Controls.Add(Me.lblSimpleRazon)
        Me.tbpSimple.Controls.Add(Me.lblSimpleStock)
        Me.tbpSimple.Controls.Add(Me.lblSimpleStockCrit)
        Me.tbpSimple.Controls.Add(Me.lblSimplePrecio)
        Me.tbpSimple.Controls.Add(Me.lblSimpleCat)
        Me.tbpSimple.Controls.Add(Me.lblSimpleProd)
        Me.tbpSimple.Controls.Add(Me.lblSimpleId)
        Me.tbpSimple.Controls.Add(Me.lblSimpleCantidad)
        Me.tbpSimple.Location = New System.Drawing.Point(4, 22)
        Me.tbpSimple.Name = "tbpSimple"
        Me.tbpSimple.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSimple.Size = New System.Drawing.Size(901, 224)
        Me.tbpSimple.TabIndex = 0
        Me.tbpSimple.Text = "Simple"
        Me.tbpSimple.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 23)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "ID PRODUCTO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 23)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "STOCK CRITICO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(478, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 23)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "STOCK:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(478, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "PRECIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "CATEGORIA:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "PRODUCTO:"
        '
        'lblSimpleRazon
        '
        Me.lblSimpleRazon.AutoSize = True
        Me.lblSimpleRazon.Enabled = False
        Me.lblSimpleRazon.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleRazon.Location = New System.Drawing.Point(782, 44)
        Me.lblSimpleRazon.Name = "lblSimpleRazon"
        Me.lblSimpleRazon.Size = New System.Drawing.Size(90, 23)
        Me.lblSimpleRazon.TabIndex = 76
        Me.lblSimpleRazon.Text = "RAZON            :"
        '
        'lblSimpleStock
        '
        Me.lblSimpleStock.AutoSize = True
        Me.lblSimpleStock.Enabled = False
        Me.lblSimpleStock.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleStock.Location = New System.Drawing.Point(538, 118)
        Me.lblSimpleStock.Name = "lblSimpleStock"
        Me.lblSimpleStock.Size = New System.Drawing.Size(82, 23)
        Me.lblSimpleStock.TabIndex = 75
        Me.lblSimpleStock.Text = "AQUI STOCK"
        '
        'lblSimpleStockCrit
        '
        Me.lblSimpleStockCrit.AutoSize = True
        Me.lblSimpleStockCrit.Enabled = False
        Me.lblSimpleStockCrit.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleStockCrit.Location = New System.Drawing.Point(539, 157)
        Me.lblSimpleStockCrit.Name = "lblSimpleStockCrit"
        Me.lblSimpleStockCrit.Size = New System.Drawing.Size(134, 23)
        Me.lblSimpleStockCrit.TabIndex = 73
        Me.lblSimpleStockCrit.Text = "AQUI STOCK CRITICO"
        '
        'lblSimplePrecio
        '
        Me.lblSimplePrecio.AutoSize = True
        Me.lblSimplePrecio.Enabled = False
        Me.lblSimplePrecio.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimplePrecio.Location = New System.Drawing.Point(539, 78)
        Me.lblSimplePrecio.Name = "lblSimplePrecio"
        Me.lblSimplePrecio.Size = New System.Drawing.Size(87, 23)
        Me.lblSimplePrecio.TabIndex = 68
        Me.lblSimplePrecio.Text = "AQUI PRECIO"
        '
        'lblSimpleCat
        '
        Me.lblSimpleCat.AutoSize = True
        Me.lblSimpleCat.Enabled = False
        Me.lblSimpleCat.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleCat.Location = New System.Drawing.Point(192, 116)
        Me.lblSimpleCat.Name = "lblSimpleCat"
        Me.lblSimpleCat.Size = New System.Drawing.Size(110, 23)
        Me.lblSimpleCat.TabIndex = 67
        Me.lblSimpleCat.Text = "AQUI CATEGORIA"
        '
        'lblSimpleProd
        '
        Me.lblSimpleProd.AutoSize = True
        Me.lblSimpleProd.Enabled = False
        Me.lblSimpleProd.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleProd.Location = New System.Drawing.Point(192, 78)
        Me.lblSimpleProd.Name = "lblSimpleProd"
        Me.lblSimpleProd.Size = New System.Drawing.Size(131, 23)
        Me.lblSimpleProd.TabIndex = 63
        Me.lblSimpleProd.Text = "AQUI NOMBRE PROD"
        '
        'lblSimpleId
        '
        Me.lblSimpleId.AutoSize = True
        Me.lblSimpleId.Enabled = False
        Me.lblSimpleId.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleId.Location = New System.Drawing.Point(117, 39)
        Me.lblSimpleId.Name = "lblSimpleId"
        Me.lblSimpleId.Size = New System.Drawing.Size(91, 23)
        Me.lblSimpleId.TabIndex = 58
        Me.lblSimpleId.Text = "AQUI ID PROD"
        '
        'lblSimpleCantidad
        '
        Me.lblSimpleCantidad.AutoSize = True
        Me.lblSimpleCantidad.Enabled = False
        Me.lblSimpleCantidad.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleCantidad.Location = New System.Drawing.Point(782, 21)
        Me.lblSimpleCantidad.Name = "lblSimpleCantidad"
        Me.lblSimpleCantidad.Size = New System.Drawing.Size(90, 23)
        Me.lblSimpleCantidad.TabIndex = 55
        Me.lblSimpleCantidad.Text = "CANTIDAD      :"
        '
        'tbpAvanzado
        '
        Me.tbpAvanzado.Controls.Add(Me.Label8)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoId)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoRazon)
        Me.tbpAvanzado.Controls.Add(Me.lblAvanzadoStock)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 23)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "ID PRODUCTO:"
        '
        'lblAvanzadoId
        '
        Me.lblAvanzadoId.AutoSize = True
        Me.lblAvanzadoId.Enabled = False
        Me.lblAvanzadoId.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoId.Location = New System.Drawing.Point(128, 13)
        Me.lblAvanzadoId.Name = "lblAvanzadoId"
        Me.lblAvanzadoId.Size = New System.Drawing.Size(84, 23)
        Me.lblAvanzadoId.TabIndex = 61
        Me.lblAvanzadoId.Text = "AQUI PRODU"
        '
        'lblAvanzadoRazon
        '
        Me.lblAvanzadoRazon.AutoSize = True
        Me.lblAvanzadoRazon.Enabled = False
        Me.lblAvanzadoRazon.Location = New System.Drawing.Point(800, 38)
        Me.lblAvanzadoRazon.Name = "lblAvanzadoRazon"
        Me.lblAvanzadoRazon.Size = New System.Drawing.Size(45, 13)
        Me.lblAvanzadoRazon.TabIndex = 72
        Me.lblAvanzadoRazon.Text = "RAZON"
        '
        'lblAvanzadoStock
        '
        Me.lblAvanzadoStock.AutoSize = True
        Me.lblAvanzadoStock.Enabled = False
        Me.lblAvanzadoStock.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoStock.Location = New System.Drawing.Point(549, 109)
        Me.lblAvanzadoStock.Name = "lblAvanzadoStock"
        Me.lblAvanzadoStock.Size = New System.Drawing.Size(50, 23)
        Me.lblAvanzadoStock.TabIndex = 71
        Me.lblAvanzadoStock.Text = "STOCK"
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
        Me.cmbAvanzadoCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAvanzadoCat.Enabled = False
        Me.cmbAvanzadoCat.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbAvanzadoCat.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAvanzadoCat.FormattingEnabled = True
        Me.cmbAvanzadoCat.Location = New System.Drawing.Point(111, 144)
        Me.cmbAvanzadoCat.Name = "cmbAvanzadoCat"
        Me.cmbAvanzadoCat.Size = New System.Drawing.Size(350, 31)
        Me.cmbAvanzadoCat.TabIndex = 67
        '
        'lblAvanzadoCat
        '
        Me.lblAvanzadoCat.AutoSize = True
        Me.lblAvanzadoCat.Enabled = False
        Me.lblAvanzadoCat.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoCat.Location = New System.Drawing.Point(27, 147)
        Me.lblAvanzadoCat.Name = "lblAvanzadoCat"
        Me.lblAvanzadoCat.Size = New System.Drawing.Size(78, 23)
        Me.lblAvanzadoCat.TabIndex = 66
        Me.lblAvanzadoCat.Text = "CATEGORIA"
        '
        'lblAvanzadoStockCrit
        '
        Me.lblAvanzadoStockCrit.AutoSize = True
        Me.lblAvanzadoStockCrit.Enabled = False
        Me.lblAvanzadoStockCrit.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoStockCrit.Location = New System.Drawing.Point(497, 147)
        Me.lblAvanzadoStockCrit.Name = "lblAvanzadoStockCrit"
        Me.lblAvanzadoStockCrit.Size = New System.Drawing.Size(102, 23)
        Me.lblAvanzadoStockCrit.TabIndex = 65
        Me.lblAvanzadoStockCrit.Text = "STOCK CRITICO"
        '
        'lblAvanzadoPrecio
        '
        Me.lblAvanzadoPrecio.AutoSize = True
        Me.lblAvanzadoPrecio.Enabled = False
        Me.lblAvanzadoPrecio.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoPrecio.Location = New System.Drawing.Point(29, 109)
        Me.lblAvanzadoPrecio.Name = "lblAvanzadoPrecio"
        Me.lblAvanzadoPrecio.Size = New System.Drawing.Size(55, 23)
        Me.lblAvanzadoPrecio.TabIndex = 64
        Me.lblAvanzadoPrecio.Text = "PRECIO"
        '
        'lblAvanzadoProd
        '
        Me.lblAvanzadoProd.AutoSize = True
        Me.lblAvanzadoProd.Enabled = False
        Me.lblAvanzadoProd.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoProd.Location = New System.Drawing.Point(29, 66)
        Me.lblAvanzadoProd.Name = "lblAvanzadoProd"
        Me.lblAvanzadoProd.Size = New System.Drawing.Size(76, 23)
        Me.lblAvanzadoProd.TabIndex = 62
        Me.lblAvanzadoProd.Text = "PRODUCTO"
        '
        'txtAvanzadoStockCrit
        '
        Me.txtAvanzadoStockCrit.Enabled = False
        Me.txtAvanzadoStockCrit.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvanzadoStockCrit.Location = New System.Drawing.Point(605, 147)
        Me.txtAvanzadoStockCrit.Name = "txtAvanzadoStockCrit"
        Me.txtAvanzadoStockCrit.Size = New System.Drawing.Size(181, 30)
        Me.txtAvanzadoStockCrit.TabIndex = 60
        '
        'txtAvanzadoPrecio
        '
        Me.txtAvanzadoPrecio.Enabled = False
        Me.txtAvanzadoPrecio.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvanzadoPrecio.Location = New System.Drawing.Point(111, 106)
        Me.txtAvanzadoPrecio.Name = "txtAvanzadoPrecio"
        Me.txtAvanzadoPrecio.Size = New System.Drawing.Size(188, 30)
        Me.txtAvanzadoPrecio.TabIndex = 59
        '
        'txtAvanzadoStock
        '
        Me.txtAvanzadoStock.Enabled = False
        Me.txtAvanzadoStock.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvanzadoStock.Location = New System.Drawing.Point(605, 106)
        Me.txtAvanzadoStock.Name = "txtAvanzadoStock"
        Me.txtAvanzadoStock.Size = New System.Drawing.Size(181, 30)
        Me.txtAvanzadoStock.TabIndex = 58
        '
        'txtAvanzadoProd
        '
        Me.txtAvanzadoProd.Enabled = False
        Me.txtAvanzadoProd.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvanzadoProd.Location = New System.Drawing.Point(111, 66)
        Me.txtAvanzadoProd.Name = "txtAvanzadoProd"
        Me.txtAvanzadoProd.Size = New System.Drawing.Size(675, 30)
        Me.txtAvanzadoProd.TabIndex = 57
        '
        'btnCan
        '
        Me.btnCan.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCan.Enabled = False
        Me.btnCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCan.Location = New System.Drawing.Point(952, 509)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(132, 43)
        Me.btnCan.TabIndex = 62
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'btnAce
        '
        Me.btnAce.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAce.Enabled = False
        Me.btnAce.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAce.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAce.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAce.Location = New System.Drawing.Point(952, 444)
        Me.btnAce.Name = "btnAce"
        Me.btnAce.Size = New System.Drawing.Size(132, 43)
        Me.btnAce.TabIndex = 61
        Me.btnAce.Text = "Aceptar"
        Me.btnAce.UseVisualStyleBackColor = False
        '
        'dgvProd
        '
        Me.dgvProd.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgvProd.AllowUserToAddRows = False
        Me.dgvProd.AllowUserToDeleteRows = False
        Me.dgvProd.AllowUserToResizeColumns = False
        Me.dgvProd.AllowUserToResizeRows = False
        Me.dgvProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProd.Location = New System.Drawing.Point(12, 115)
        Me.dgvProd.MultiSelect = False
        Me.dgvProd.Name = "dgvProd"
        Me.dgvProd.ReadOnly = True
        Me.dgvProd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProd.Size = New System.Drawing.Size(1127, 269)
        Me.dgvProd.TabIndex = 58
        '
        'mnsProd
        '
        Me.mnsProd.AutoSize = False
        Me.mnsProd.BackColor = System.Drawing.Color.DarkOrange
        Me.mnsProd.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregar, Me.tsmEditar, Me.tsmEliminar})
        Me.mnsProd.Location = New System.Drawing.Point(0, 78)
        Me.mnsProd.Name = "mnsProd"
        Me.mnsProd.Size = New System.Drawing.Size(1173, 24)
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
        'LblTitulo
        '
        Me.LblTitulo.BackColor = System.Drawing.Color.DarkBlue
        Me.LblTitulo.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblTitulo.Location = New System.Drawing.Point(0, 38)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(1173, 40)
        Me.LblTitulo.TabIndex = 122
        Me.LblTitulo.Text = "Productos"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmProd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.btnSimpleEliminar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAce)
        Me.Controls.Add(Me.dgvProd)
        Me.Controls.Add(Me.mnsProd)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProd2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmProd2"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpSimple.ResumeLayout(False)
        Me.tbpSimple.PerformLayout()
        Me.tbpAvanzado.ResumeLayout(False)
        Me.tbpAvanzado.PerformLayout()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsProd.ResumeLayout(False)
        Me.mnsProd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSimpleEliminar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbpSimple As TabPage
    Friend WithEvents lblSimpleStock As Label
    Friend WithEvents lblSimpleStockCrit As Label
    Friend WithEvents lblSimplePrecio As Label
    Friend WithEvents lblSimpleCat As Label
    Friend WithEvents lblSimpleProd As Label
    Friend WithEvents lblSimpleId As Label
    Friend WithEvents lblSimpleCantidad As Label
    Friend WithEvents tbpAvanzado As TabPage
    Friend WithEvents lblAvanzadoId As Label
    Friend WithEvents lblAvanzadoStock As Label
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
    Friend WithEvents btnCan As Button
    Friend WithEvents btnAce As Button
    Friend WithEvents dgvProd As DataGridView
    Friend WithEvents mnsProd As MenuStrip
    Friend WithEvents tsmAgregar As ToolStripMenuItem
    Friend WithEvents tsmEditar As ToolStripMenuItem
    Friend WithEvents tsmEliminar As ToolStripMenuItem
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblTitulo As Label
    Friend WithEvents lblSimpleRazon As Label
    Friend WithEvents lblAvanzadoRazon As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
