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
        Me.btnAce = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dtpTermino = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaTermino = New System.Windows.Forms.Label()
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
        Me.pnlComponentes = New System.Windows.Forms.Panel()
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsDes.SuspendLayout()
        Me.pnlComponentes.SuspendLayout()
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
        Me.dgvDescuentos.Location = New System.Drawing.Point(49, 146)
        Me.dgvDescuentos.MultiSelect = False
        Me.dgvDescuentos.Name = "dgvDescuentos"
        Me.dgvDescuentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDescuentos.Size = New System.Drawing.Size(1058, 269)
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
        Me.mnsDes.UseWaitCursor = True
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
        'btnAce
        '
        Me.btnAce.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAce.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnAce.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAce.Location = New System.Drawing.Point(326, 179)
        Me.btnAce.Name = "btnAce"
        Me.btnAce.Size = New System.Drawing.Size(184, 43)
        Me.btnAce.TabIndex = 102
        Me.btnAce.Text = "Aceptar"
        Me.btnAce.UseVisualStyleBackColor = False
        '
        'btnCan
        '
        Me.btnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCan.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCan.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnCan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCan.Location = New System.Drawing.Point(621, 179)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(184, 43)
        Me.btnCan.TabIndex = 103
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.lblProducto.Location = New System.Drawing.Point(74, 27)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(68, 19)
        Me.lblProducto.TabIndex = 104
        Me.lblProducto.Text = "Producto:"
        '
        'cmbProducto
        '
        Me.cmbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbProducto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbProducto.Location = New System.Drawing.Point(215, 24)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(200, 27)
        Me.cmbProducto.TabIndex = 105
        '
        'dtpInicio
        '
        Me.dtpInicio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.dtpInicio.Location = New System.Drawing.Point(215, 71)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 27)
        Me.dtpInicio.TabIndex = 106
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.lblFechaInicio.Location = New System.Drawing.Point(74, 71)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(107, 19)
        Me.lblFechaInicio.TabIndex = 107
        Me.lblFechaInicio.Text = "Fecha de Inicio :"
        '
        'dtpTermino
        '
        Me.dtpTermino.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.dtpTermino.Location = New System.Drawing.Point(215, 120)
        Me.dtpTermino.Name = "dtpTermino"
        Me.dtpTermino.Size = New System.Drawing.Size(200, 27)
        Me.dtpTermino.TabIndex = 108
        '
        'lblFechaTermino
        '
        Me.lblFechaTermino.AutoSize = True
        Me.lblFechaTermino.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.lblFechaTermino.Location = New System.Drawing.Point(74, 126)
        Me.lblFechaTermino.Name = "lblFechaTermino"
        Me.lblFechaTermino.Size = New System.Drawing.Size(123, 19)
        Me.lblFechaTermino.TabIndex = 109
        Me.lblFechaTermino.Text = "Fecha de Termino :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(544, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 19)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Condicion :"
        '
        'cbxPorcentual
        '
        Me.cbxPorcentual.AutoSize = True
        Me.cbxPorcentual.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cbxPorcentual.Location = New System.Drawing.Point(579, 115)
        Me.cbxPorcentual.Name = "cbxPorcentual"
        Me.cbxPorcentual.Size = New System.Drawing.Size(112, 23)
        Me.cbxPorcentual.TabIndex = 111
        Me.cbxPorcentual.Text = "PORCENTUAL"
        Me.cbxPorcentual.UseVisualStyleBackColor = True
        '
        'cbxMayor
        '
        Me.cbxMayor.AutoSize = True
        Me.cbxMayor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cbxMayor.Location = New System.Drawing.Point(579, 55)
        Me.cbxMayor.Name = "cbxMayor"
        Me.cbxMayor.Size = New System.Drawing.Size(381, 23)
        Me.cbxMayor.TabIndex = 112
        Me.cbxMayor.Text = "MAYOR CONTENIDO DE PRODUCTO POR EL MISMO PRECIO"
        Me.cbxMayor.UseVisualStyleBackColor = True
        '
        'cmbP1Mayor
        '
        Me.cmbP1Mayor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP1Mayor.FormattingEnabled = True
        Me.cmbP1Mayor.Location = New System.Drawing.Point(601, 78)
        Me.cmbP1Mayor.Name = "cmbP1Mayor"
        Me.cmbP1Mayor.Size = New System.Drawing.Size(44, 27)
        Me.cmbP1Mayor.TabIndex = 113
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(649, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 19)
        Me.Label5.TabIndex = 114
        Me.Label5.Text = "productos por el precio de "
        '
        'cmbP2Mayor
        '
        Me.cmbP2Mayor.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP2Mayor.FormattingEnabled = True
        Me.cmbP2Mayor.Location = New System.Drawing.Point(828, 78)
        Me.cmbP2Mayor.Name = "cmbP2Mayor"
        Me.cmbP2Mayor.Size = New System.Drawing.Size(44, 27)
        Me.cmbP2Mayor.TabIndex = 115
        '
        'cmbP1Porcentual
        '
        Me.cmbP1Porcentual.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP1Porcentual.FormattingEnabled = True
        Me.cmbP1Porcentual.Location = New System.Drawing.Point(601, 138)
        Me.cmbP1Porcentual.Name = "cmbP1Porcentual"
        Me.cmbP1Porcentual.Size = New System.Drawing.Size(44, 27)
        Me.cmbP1Porcentual.TabIndex = 116
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(651, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 19)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "% descuento en la"
        '
        'cmbP2Porcentual
        '
        Me.cmbP2Porcentual.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.cmbP2Porcentual.FormattingEnabled = True
        Me.cmbP2Porcentual.Location = New System.Drawing.Point(776, 138)
        Me.cmbP2Porcentual.Name = "cmbP2Porcentual"
        Me.cmbP2Porcentual.Size = New System.Drawing.Size(44, 27)
        Me.cmbP2Porcentual.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(826, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "unidad."
        '
        'pnlComponentes
        '
        Me.pnlComponentes.Controls.Add(Me.Label7)
        Me.pnlComponentes.Controls.Add(Me.cmbP2Porcentual)
        Me.pnlComponentes.Controls.Add(Me.Label6)
        Me.pnlComponentes.Controls.Add(Me.cmbP1Porcentual)
        Me.pnlComponentes.Controls.Add(Me.cmbP2Mayor)
        Me.pnlComponentes.Controls.Add(Me.Label5)
        Me.pnlComponentes.Controls.Add(Me.cmbP1Mayor)
        Me.pnlComponentes.Controls.Add(Me.cbxMayor)
        Me.pnlComponentes.Controls.Add(Me.cbxPorcentual)
        Me.pnlComponentes.Controls.Add(Me.Label4)
        Me.pnlComponentes.Controls.Add(Me.lblFechaTermino)
        Me.pnlComponentes.Controls.Add(Me.dtpTermino)
        Me.pnlComponentes.Controls.Add(Me.lblFechaInicio)
        Me.pnlComponentes.Controls.Add(Me.dtpInicio)
        Me.pnlComponentes.Controls.Add(Me.cmbProducto)
        Me.pnlComponentes.Controls.Add(Me.lblProducto)
        Me.pnlComponentes.Controls.Add(Me.btnCan)
        Me.pnlComponentes.Controls.Add(Me.btnAce)
        Me.pnlComponentes.Enabled = False
        Me.pnlComponentes.Location = New System.Drawing.Point(53, 422)
        Me.pnlComponentes.Name = "pnlComponentes"
        Me.pnlComponentes.Size = New System.Drawing.Size(1054, 233)
        Me.pnlComponentes.TabIndex = 123
        '
        'FrmDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.pnlComponentes)
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
        Me.pnlComponentes.ResumeLayout(False)
        Me.pnlComponentes.PerformLayout()
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
    Friend WithEvents btnAce As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents lblProducto As Label
    Friend WithEvents cmbProducto As ComboBox
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpTermino As DateTimePicker
    Friend WithEvents lblFechaTermino As Label
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
    Friend WithEvents pnlComponentes As Panel
End Class
