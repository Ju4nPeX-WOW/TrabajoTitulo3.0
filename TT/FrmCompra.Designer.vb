<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCompra
    Inherits TT.FormTamaño

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
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblArchivo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button2.Location = New System.Drawing.Point(789, 446)
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
        Me.lblIva.Size = New System.Drawing.Size(27, 13)
        Me.lblIva.TabIndex = 84
        Me.lblIva.Text = "IVA:"
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
        Me.txtNumFolio.Size = New System.Drawing.Size(301, 20)
        Me.txtNumFolio.TabIndex = 82
        '
        'lblNumFolio
        '
        Me.lblNumFolio.AutoSize = True
        Me.lblNumFolio.Location = New System.Drawing.Point(192, 129)
        Me.lblNumFolio.Name = "lblNumFolio"
        Me.lblNumFolio.Size = New System.Drawing.Size(57, 13)
        Me.lblNumFolio.TabIndex = 81
        Me.lblNumFolio.Text = "Num_folio:"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(273, 157)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(301, 20)
        Me.txtRut.TabIndex = 88
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(195, 319)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 108)
        Me.DataGridView1.TabIndex = 95
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.Orange
        Me.txtPrecio.Location = New System.Drawing.Point(461, 288)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 94
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(415, 291)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 13)
        Me.lblPrecio.TabIndex = 93
        Me.lblPrecio.Text = "Precio:"
        '
        'txtCant
        '
        Me.txtCant.BackColor = System.Drawing.Color.Orange
        Me.txtCant.Location = New System.Drawing.Point(248, 288)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 92
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(190, 291)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(61, 13)
        Me.lblCant.TabIndex = 91
        Me.lblCant.Text = "Cantidad:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(248, 243)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(736, 21)
        Me.ComboBox2.TabIndex = 90
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
        Me.btn_guardar.Location = New System.Drawing.Point(519, 524)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 96
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BackColor = System.Drawing.Color.Orange
        Me.txtSubTotal.Location = New System.Drawing.Point(706, 288)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubTotal.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(629, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "SubPrecio:"
        '
        'lblArchivo
        '
        Me.lblArchivo.AutoSize = True
        Me.lblArchivo.Location = New System.Drawing.Point(254, 449)
        Me.lblArchivo.Name = "lblArchivo"
        Me.lblArchivo.Size = New System.Drawing.Size(46, 13)
        Me.lblArchivo.TabIndex = 99
        Me.lblArchivo.Text = "Archivo:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(306, 446)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(472, 20)
        Me.TextBox1.TabIndex = 100
        '
        'FrmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblArchivo)
        Me.Controls.Add(Me.txtSubTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtRut)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtRut As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents lblCant As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblArchivo As Label
    Friend WithEvents TextBox1 As TextBox
End Class
