<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesc))
        Me.dgvDescuentos = New System.Windows.Forms.DataGridView()
        Me.BtnExitDes = New System.Windows.Forms.Button()
        Me.mnsDes = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExtender = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFinalizar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblIdDescuento = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbP2Porcentual = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbP1Porcentual = New System.Windows.Forms.ComboBox()
        Me.cmbP2Mayor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbP1Mayor = New System.Windows.Forms.ComboBox()
        Me.cbxMayor = New System.Windows.Forms.CheckBox()
        Me.cbxPorcentual = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFechaTermino = New System.Windows.Forms.Label()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnAce = New System.Windows.Forms.Button()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.cmbBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsDes.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDescuentos
        '
        Me.dgvDescuentos.AllowUserToAddRows = False
        Me.dgvDescuentos.AllowUserToDeleteRows = False
        Me.dgvDescuentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDescuentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDescuentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDescuentos.Location = New System.Drawing.Point(49, 126)
        Me.dgvDescuentos.MultiSelect = False
        Me.dgvDescuentos.Name = "dgvDescuentos"
        Me.dgvDescuentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDescuentos.Size = New System.Drawing.Size(1058, 113)
        Me.dgvDescuentos.TabIndex = 80
        '
        'BtnExitDes
        '
        Me.BtnExitDes.BackColor = System.Drawing.Color.Red
        Me.BtnExitDes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExitDes.Location = New System.Drawing.Point(1126, 6)
        Me.BtnExitDes.Name = "BtnExitDes"
        Me.BtnExitDes.Size = New System.Drawing.Size(35, 23)
        Me.BtnExitDes.TabIndex = 79
        Me.BtnExitDes.Text = "X"
        Me.BtnExitDes.UseVisualStyleBackColor = False
        '
        'mnsDes
        '
        Me.mnsDes.AutoSize = False
        Me.mnsDes.BackColor = System.Drawing.Color.DarkOrange
        Me.mnsDes.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsDes.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnsDes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregar, Me.tsmExtender, Me.tsmFinalizar})
        Me.mnsDes.Location = New System.Drawing.Point(0, 78)
        Me.mnsDes.Name = "mnsDes"
        Me.mnsDes.Size = New System.Drawing.Size(1173, 24)
        Me.mnsDes.TabIndex = 77
        Me.mnsDes.Text = "MenuStrip1"
        '
        'tsmAgregar
        '
        Me.tsmAgregar.Image = CType(resources.GetObject("tsmAgregar.Image"), System.Drawing.Image)
        Me.tsmAgregar.Name = "tsmAgregar"
        Me.tsmAgregar.Size = New System.Drawing.Size(77, 20)
        Me.tsmAgregar.Text = "Agregar"
        '
        'tsmExtender
        '
        Me.tsmExtender.Image = CType(resources.GetObject("tsmExtender.Image"), System.Drawing.Image)
        Me.tsmExtender.Name = "tsmExtender"
        Me.tsmExtender.Size = New System.Drawing.Size(81, 20)
        Me.tsmExtender.Text = "Extender"
        '
        'tsmFinalizar
        '
        Me.tsmFinalizar.Image = CType(resources.GetObject("tsmFinalizar.Image"), System.Drawing.Image)
        Me.tsmFinalizar.Name = "tsmFinalizar"
        Me.tsmFinalizar.Size = New System.Drawing.Size(134, 20)
        Me.tsmFinalizar.Text = "Finalizar descuento"
        '
        'lblIdDescuento
        '
        Me.lblIdDescuento.AutoSize = True
        Me.lblIdDescuento.Location = New System.Drawing.Point(580, 406)
        Me.lblIdDescuento.Name = "lblIdDescuento"
        Me.lblIdDescuento.Size = New System.Drawing.Size(0, 13)
        Me.lblIdDescuento.TabIndex = 102
        Me.lblIdDescuento.Visible = False
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
        Me.LblTitulo.Text = "DESCUENTOS"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(914, 573)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "unidad."
        '
        'cmbP2Porcentual
        '
        Me.cmbP2Porcentual.Enabled = False
        Me.cmbP2Porcentual.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP2Porcentual.FormattingEnabled = True
        Me.cmbP2Porcentual.Location = New System.Drawing.Point(864, 570)
        Me.cmbP2Porcentual.Name = "cmbP2Porcentual"
        Me.cmbP2Porcentual.Size = New System.Drawing.Size(44, 27)
        Me.cmbP2Porcentual.TabIndex = 139
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(739, 573)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 19)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "% descuento en la"
        '
        'cmbP1Porcentual
        '
        Me.cmbP1Porcentual.Enabled = False
        Me.cmbP1Porcentual.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP1Porcentual.FormattingEnabled = True
        Me.cmbP1Porcentual.Location = New System.Drawing.Point(689, 570)
        Me.cmbP1Porcentual.Name = "cmbP1Porcentual"
        Me.cmbP1Porcentual.Size = New System.Drawing.Size(44, 27)
        Me.cmbP1Porcentual.TabIndex = 137
        '
        'cmbP2Mayor
        '
        Me.cmbP2Mayor.Enabled = False
        Me.cmbP2Mayor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP2Mayor.FormattingEnabled = True
        Me.cmbP2Mayor.Location = New System.Drawing.Point(916, 510)
        Me.cmbP2Mayor.Name = "cmbP2Mayor"
        Me.cmbP2Mayor.Size = New System.Drawing.Size(44, 27)
        Me.cmbP2Mayor.TabIndex = 136
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(737, 513)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 19)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "productos por el precio de "
        '
        'cmbP1Mayor
        '
        Me.cmbP1Mayor.Enabled = False
        Me.cmbP1Mayor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP1Mayor.FormattingEnabled = True
        Me.cmbP1Mayor.Location = New System.Drawing.Point(689, 510)
        Me.cmbP1Mayor.Name = "cmbP1Mayor"
        Me.cmbP1Mayor.Size = New System.Drawing.Size(44, 27)
        Me.cmbP1Mayor.TabIndex = 134
        '
        'cbxMayor
        '
        Me.cbxMayor.AutoSize = True
        Me.cbxMayor.Checked = True
        Me.cbxMayor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxMayor.Enabled = False
        Me.cbxMayor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cbxMayor.Location = New System.Drawing.Point(667, 487)
        Me.cbxMayor.Name = "cbxMayor"
        Me.cbxMayor.Size = New System.Drawing.Size(381, 23)
        Me.cbxMayor.TabIndex = 133
        Me.cbxMayor.Text = "MAYOR CONTENIDO DE PRODUCTO POR EL MISMO PRECIO"
        Me.cbxMayor.UseVisualStyleBackColor = True
        '
        'cbxPorcentual
        '
        Me.cbxPorcentual.AutoSize = True
        Me.cbxPorcentual.Enabled = False
        Me.cbxPorcentual.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cbxPorcentual.Location = New System.Drawing.Point(667, 547)
        Me.cbxPorcentual.Name = "cbxPorcentual"
        Me.cbxPorcentual.Size = New System.Drawing.Size(112, 23)
        Me.cbxPorcentual.TabIndex = 132
        Me.cbxPorcentual.Text = "PORCENTUAL"
        Me.cbxPorcentual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(632, 459)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Condicion :"
        '
        'lblFechaTermino
        '
        Me.lblFechaTermino.AutoSize = True
        Me.lblFechaTermino.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.lblFechaTermino.Location = New System.Drawing.Point(100, 558)
        Me.lblFechaTermino.Name = "lblFechaTermino"
        Me.lblFechaTermino.Size = New System.Drawing.Size(123, 19)
        Me.lblFechaTermino.TabIndex = 130
        Me.lblFechaTermino.Text = "Fecha de Termino :"
        '
        'dtpTermino
        '
        Me.dtpTermino.Enabled = False
        Me.dtpTermino.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.dtpTermino.Location = New System.Drawing.Point(241, 552)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(200, 27)
        Me.dtpTermino.TabIndex = 129
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(100, 503)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(107, 19)
        Me.lblFechaInicio.TabIndex = 128
        Me.lblFechaInicio.Text = "Fecha de Inicio :"
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.dtpInicio.Location = New System.Drawing.Point(241, 503)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 27)
        Me.dtpInicio.TabIndex = 127
        '
        'btnCan
        '
        Me.btnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCan.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCan.Enabled = False
        Me.btnCan.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnCan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCan.Location = New System.Drawing.Point(647, 611)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(184, 43)
        Me.btnCan.TabIndex = 124
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'btnAce
        '
        Me.btnAce.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAce.Enabled = False
        Me.btnAce.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnAce.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAce.Location = New System.Drawing.Point(352, 611)
        Me.btnAce.Name = "btnAce"
        Me.btnAce.Size = New System.Drawing.Size(184, 43)
        Me.btnAce.TabIndex = 123
        Me.btnAce.Text = "Aceptar"
        Me.btnAce.UseVisualStyleBackColor = False
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvProductos.Enabled = False
        Me.dgvProductos.Location = New System.Drawing.Point(49, 300)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(1058, 119)
        Me.dgvProductos.TabIndex = 141
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(915, 256)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(170, 39)
        Me.btnBuscar.TabIndex = 144
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Enabled = False
        Me.txtBusqueda.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(241, 261)
        Me.txtBusqueda.MaxLength = 40
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(657, 33)
        Me.txtBusqueda.TabIndex = 143
        '
        'cmbBusqueda
        '
        Me.cmbBusqueda.BackColor = System.Drawing.SystemColors.Info
        Me.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBusqueda.Enabled = False
        Me.cmbBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBusqueda.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusqueda.FormattingEnabled = True
        Me.cmbBusqueda.Items.AddRange(New Object() {"ID PRODUCTO", "PRODUCTO"})
        Me.cmbBusqueda.Location = New System.Drawing.Point(49, 261)
        Me.cmbBusqueda.Name = "cmbBusqueda"
        Me.cmbBusqueda.Size = New System.Drawing.Size(187, 33)
        Me.cmbBusqueda.TabIndex = 142
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(241, 459)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(367, 30)
        Me.txtProducto.TabIndex = 146
        Me.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(237, 434)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(97, 19)
        Me.label.TabIndex = 147
        Me.label.Text = "ID DEL PRODUCTO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 18)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "ID Producto:"
        '
        'FrmDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbBusqueda)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbP2Porcentual)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbP1Porcentual)
        Me.Controls.Add(Me.cmbP2Mayor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbP1Mayor)
        Me.Controls.Add(Me.cbxMayor)
        Me.Controls.Add(Me.cbxPorcentual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblFechaTermino)
        Me.Controls.Add(Me.dtpTermino)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAce)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.lblIdDescuento)
        Me.Controls.Add(Me.dgvDescuentos)
        Me.Controls.Add(Me.BtnExitDes)
        Me.Controls.Add(Me.mnsDes)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmDesc"
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsDes.ResumeLayout(False)
        Me.mnsDes.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDescuentos As DataGridView
    Friend WithEvents BtnExitDes As Button
    Friend WithEvents mnsDes As MenuStrip
    Friend WithEvents tsmAgregar As ToolStripMenuItem
    Friend WithEvents tsmExtender As ToolStripMenuItem
    Friend WithEvents tsmFinalizar As ToolStripMenuItem
    Friend WithEvents lblIdDescuento As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbP2Porcentual As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbP1Porcentual As ComboBox
    Friend WithEvents cmbP2Mayor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbP1Mayor As ComboBox
    Friend WithEvents cbxMayor As CheckBox
    Friend WithEvents cbxPorcentual As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFechaTermino As Label
    Friend WithEvents dtpTermino As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents btnCan As Button
    Friend WithEvents btnAce As Button
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents cmbBusqueda As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents label As Label
    Friend WithEvents Label2 As Label
End Class
