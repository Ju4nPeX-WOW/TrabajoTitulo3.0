<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesc
    Inherits TT.FormBase

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
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnAce = New System.Windows.Forms.Button()
        Me.dgvDescuentos = New System.Windows.Forms.DataGridView()
        Me.BtnExitDes = New System.Windows.Forms.Button()
        Me.cmbBuscarCat = New System.Windows.Forms.ComboBox()
        Me.txtBuscarProdCat = New System.Windows.Forms.TextBox()
        Me.mnsDes = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminarCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaTermino = New System.Windows.Forms.Label()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxPorcentual = New System.Windows.Forms.CheckBox()
        Me.cbxMayor = New System.Windows.Forms.CheckBox()
        Me.cmbP1Mayor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbP2Mayor = New System.Windows.Forms.ComboBox()
        Me.cmbP1Porcentual = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbP2Porcentual = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblIdDescuento = New System.Windows.Forms.Label()
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsDes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCan
        '
        Me.btnCan.Enabled = False
        Me.btnCan.Location = New System.Drawing.Point(975, 509)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(132, 43)
        Me.btnCan.TabIndex = 82
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnAce
        '
        Me.btnAce.Enabled = False
        Me.btnAce.Location = New System.Drawing.Point(975, 444)
        Me.btnAce.Name = "btnAce"
        Me.btnAce.Size = New System.Drawing.Size(132, 43)
        Me.btnAce.TabIndex = 81
        Me.btnAce.Text = "Aceptar"
        Me.btnAce.UseVisualStyleBackColor = True
        '
        'dgvDescuentos
        '
        Me.dgvDescuentos.AllowUserToAddRows = False
        Me.dgvDescuentos.AllowUserToDeleteRows = False
        Me.dgvDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDescuentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDescuentos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvDescuentos.Location = New System.Drawing.Point(12, 115)
        Me.dgvDescuentos.MultiSelect = False
        Me.dgvDescuentos.Name = "dgvDescuentos"
        Me.dgvDescuentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDescuentos.Size = New System.Drawing.Size(1127, 269)
        Me.dgvDescuentos.TabIndex = 80
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
        Me.tsmEliminarCat.Text = "Finalizar"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(85, 444)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(53, 13)
        Me.lblProducto.TabIndex = 85
        Me.lblProducto.Text = "Producto:"
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Location = New System.Drawing.Point(190, 441)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(200, 21)
        Me.cmbProducto.TabIndex = 86
        '
        'dtpInicio
        '
        Me.dtpInicio.Location = New System.Drawing.Point(190, 485)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpInicio.TabIndex = 87
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(85, 485)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(86, 13)
        Me.lblFechaInicio.TabIndex = 88
        Me.lblFechaInicio.Text = "Fecha de Inicio :"
        '
        'lblFechaTermino
        '
        Me.lblFechaTermino.AutoSize = True
        Me.lblFechaTermino.Location = New System.Drawing.Point(85, 542)
        Me.lblFechaTermino.Name = "lblFechaTermino"
        Me.lblFechaTermino.Size = New System.Drawing.Size(99, 13)
        Me.lblFechaTermino.TabIndex = 90
        Me.lblFechaTermino.Text = "Fecha de Termino :"
        '
        'dtpTermino
        '
        Me.dtpTermino.Location = New System.Drawing.Point(190, 542)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(200, 20)
        Me.dtpTermino.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(432, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Condicion :"
        '
        'cbxPorcentual
        '
        Me.cbxPorcentual.AutoSize = True
        Me.cbxPorcentual.Location = New System.Drawing.Point(455, 527)
        Me.cbxPorcentual.Name = "cbxPorcentual"
        Me.cbxPorcentual.Size = New System.Drawing.Size(99, 17)
        Me.cbxPorcentual.TabIndex = 92
        Me.cbxPorcentual.Text = "PORCENTUAL"
        Me.cbxPorcentual.UseVisualStyleBackColor = True
        '
        'cbxMayor
        '
        Me.cbxMayor.AutoSize = True
        Me.cbxMayor.Location = New System.Drawing.Point(455, 467)
        Me.cbxMayor.Name = "cbxMayor"
        Me.cbxMayor.Size = New System.Drawing.Size(338, 17)
        Me.cbxMayor.TabIndex = 93
        Me.cbxMayor.Text = "MAYOR CONTENIDO DE PRODUCTO POR EL MISMO PRECIO"
        Me.cbxMayor.UseVisualStyleBackColor = True
        '
        'cmbP1Mayor
        '
        Me.cmbP1Mayor.FormattingEnabled = True
        Me.cmbP1Mayor.Location = New System.Drawing.Point(474, 490)
        Me.cmbP1Mayor.Name = "cmbP1Mayor"
        Me.cmbP1Mayor.Size = New System.Drawing.Size(44, 21)
        Me.cmbP1Mayor.TabIndex = 94
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(525, 493)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "productos por el precio de "
        '
        'cmbP2Mayor
        '
        Me.cmbP2Mayor.FormattingEnabled = True
        Me.cmbP2Mayor.Location = New System.Drawing.Point(663, 490)
        Me.cmbP2Mayor.Name = "cmbP2Mayor"
        Me.cmbP2Mayor.Size = New System.Drawing.Size(44, 21)
        Me.cmbP2Mayor.TabIndex = 97
        '
        'cmbP1Porcentual
        '
        Me.cmbP1Porcentual.FormattingEnabled = True
        Me.cmbP1Porcentual.Location = New System.Drawing.Point(477, 550)
        Me.cmbP1Porcentual.Name = "cmbP1Porcentual"
        Me.cmbP1Porcentual.Size = New System.Drawing.Size(44, 21)
        Me.cmbP1Porcentual.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(527, 553)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "% descuento en la"
        '
        'cmbP2Porcentual
        '
        Me.cmbP2Porcentual.FormattingEnabled = True
        Me.cmbP2Porcentual.Location = New System.Drawing.Point(627, 550)
        Me.cmbP2Porcentual.Name = "cmbP2Porcentual"
        Me.cmbP2Porcentual.Size = New System.Drawing.Size(44, 21)
        Me.cmbP2Porcentual.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(677, 553)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "unidad."
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
        'FrmDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.lblIdDescuento)
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
        Me.Controls.Add(Me.cmbProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAce)
        Me.Controls.Add(Me.dgvDescuentos)
        Me.Controls.Add(Me.BtnExitDes)
        Me.Controls.Add(Me.cmbBuscarCat)
        Me.Controls.Add(Me.txtBuscarProdCat)
        Me.Controls.Add(Me.mnsDes)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmDesc"
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsDes.ResumeLayout(False)
        Me.mnsDes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCan As Button
    Friend WithEvents btnAce As Button
    Friend WithEvents dgvDescuentos As DataGridView
    Friend WithEvents BtnExitDes As Button
    Friend WithEvents cmbBuscarCat As ComboBox
    Friend WithEvents txtBuscarProdCat As TextBox
    Friend WithEvents mnsDes As MenuStrip
    Friend WithEvents tsmAgregarCat As ToolStripMenuItem
    Friend WithEvents tsmEditarCat As ToolStripMenuItem
    Friend WithEvents tsmEliminarCat As ToolStripMenuItem
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents lblFechaTermino As Label
    Friend WithEvents dtpTermino As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxPorcentual As CheckBox
    Friend WithEvents cbxMayor As CheckBox
    Friend WithEvents cmbP1Mayor As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbP2Mayor As ComboBox
    Friend WithEvents cmbP1Porcentual As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbP2Porcentual As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblIdDescuento As Label
End Class
