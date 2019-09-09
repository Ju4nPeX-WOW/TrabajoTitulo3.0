<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAjustes
    Inherits TT.FormBase

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
        Me.dgvProd = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblAvanzadoRazon = New System.Windows.Forms.Label()
        Me.lblAvanzadoStock = New System.Windows.Forms.Label()
        Me.cmbAvanzadoRazon = New System.Windows.Forms.ComboBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.mnsAjustes = New System.Windows.Forms.MenuStrip()
        Me.tsmAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbBusqueda = New System.Windows.Forms.ComboBox()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnAce = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblIdProd = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.nupStock = New System.Windows.Forms.NumericUpDown()
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsAjustes.SuspendLayout()
        CType(Me.nupStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgvProd.TabIndex = 59
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(176, 407)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(734, 41)
        Me.txtBusqueda.TabIndex = 60
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvanzadoRazon
        '
        Me.lblAvanzadoRazon.AutoSize = True
        Me.lblAvanzadoRazon.Enabled = False
        Me.lblAvanzadoRazon.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoRazon.Location = New System.Drawing.Point(614, 474)
        Me.lblAvanzadoRazon.Name = "lblAvanzadoRazon"
        Me.lblAvanzadoRazon.Size = New System.Drawing.Size(73, 25)
        Me.lblAvanzadoRazon.TabIndex = 76
        Me.lblAvanzadoRazon.Text = "RAZON:"
        '
        'lblAvanzadoStock
        '
        Me.lblAvanzadoStock.AutoSize = True
        Me.lblAvanzadoStock.Enabled = False
        Me.lblAvanzadoStock.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvanzadoStock.Location = New System.Drawing.Point(619, 528)
        Me.lblAvanzadoStock.Name = "lblAvanzadoStock"
        Me.lblAvanzadoStock.Size = New System.Drawing.Size(71, 25)
        Me.lblAvanzadoStock.TabIndex = 75
        Me.lblAvanzadoStock.Text = "STOCK:"
        '
        'cmbAvanzadoRazon
        '
        Me.cmbAvanzadoRazon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAvanzadoRazon.Enabled = False
        Me.cmbAvanzadoRazon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAvanzadoRazon.FormattingEnabled = True
        Me.cmbAvanzadoRazon.Items.AddRange(New Object() {"Comprado", "Vendido", "Extraviado", "Deteriodado", "Encontrado", "Eliminado"})
        Me.cmbAvanzadoRazon.Location = New System.Drawing.Point(697, 471)
        Me.cmbAvanzadoRazon.Name = "cmbAvanzadoRazon"
        Me.cmbAvanzadoRazon.Size = New System.Drawing.Size(259, 32)
        Me.cmbAvanzadoRazon.TabIndex = 74
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Red
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(35, 23)
        Me.BtnExit.TabIndex = 77
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.DarkBlue
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(0, 38)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1173, 40)
        Me.lblTitulo.TabIndex = 123
        Me.lblTitulo.Text = "Ajustes"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnsAjustes
        '
        Me.mnsAjustes.AutoSize = False
        Me.mnsAjustes.BackColor = System.Drawing.Color.DarkOrange
        Me.mnsAjustes.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsAjustes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmAgregar})
        Me.mnsAjustes.Location = New System.Drawing.Point(0, 78)
        Me.mnsAjustes.Name = "mnsAjustes"
        Me.mnsAjustes.Size = New System.Drawing.Size(1173, 24)
        Me.mnsAjustes.TabIndex = 124
        Me.mnsAjustes.Text = "MenuStrip1"
        '
        'tsmAgregar
        '
        Me.tsmAgregar.Image = Global.TT.My.Resources.Resources.document
        Me.tsmAgregar.Name = "tsmAgregar"
        Me.tsmAgregar.Size = New System.Drawing.Size(109, 20)
        Me.tsmAgregar.Text = "Realizar ajuste"
        '
        'cmbBusqueda
        '
        Me.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBusqueda.Font = New System.Drawing.Font("Bahnschrift Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusqueda.FormattingEnabled = True
        Me.cmbBusqueda.Items.AddRange(New Object() {"Producto", "ID"})
        Me.cmbBusqueda.Location = New System.Drawing.Point(26, 407)
        Me.cmbBusqueda.Name = "cmbBusqueda"
        Me.cmbBusqueda.Size = New System.Drawing.Size(138, 43)
        Me.cmbBusqueda.TabIndex = 125
        '
        'btnCan
        '
        Me.btnCan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCan.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCan.Enabled = False
        Me.btnCan.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnCan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCan.Location = New System.Drawing.Point(525, 599)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(184, 43)
        Me.btnCan.TabIndex = 127
        Me.btnCan.Text = "Cancelar"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'btnAce
        '
        Me.btnAce.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAce.Enabled = False
        Me.btnAce.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnAce.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAce.Location = New System.Drawing.Point(230, 599)
        Me.btnAce.Name = "btnAce"
        Me.btnAce.Size = New System.Drawing.Size(184, 43)
        Me.btnAce.TabIndex = 126
        Me.btnAce.Text = "Aceptar"
        Me.btnAce.UseVisualStyleBackColor = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(21, 482)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(123, 25)
        Me.label.TabIndex = 128
        Me.label.Text = "ID PRODUCTO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 547)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 25)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "PRODUCTO:"
        '
        'lblIdProd
        '
        Me.lblIdProd.AutoSize = True
        Me.lblIdProd.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdProd.Location = New System.Drawing.Point(170, 482)
        Me.lblIdProd.Name = "lblIdProd"
        Me.lblIdProd.Size = New System.Drawing.Size(350, 25)
        Me.lblIdProd.TabIndex = 130
        Me.lblIdProd.Text = "Aqui iria el ID que se pasa mediante codigo"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(130, 544)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(154, 25)
        Me.lblProducto.TabIndex = 131
        Me.lblProducto.Text = "Nombre producto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(937, 405)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(193, 43)
        Me.btnBuscar.TabIndex = 132
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'nupStock
        '
        Me.nupStock.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.nupStock.Enabled = False
        Me.nupStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nupStock.Location = New System.Drawing.Point(698, 525)
        Me.nupStock.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nupStock.Minimum = New Decimal(New Integer() {999, 0, 0, -2147483648})
        Me.nupStock.Name = "nupStock"
        Me.nupStock.Size = New System.Drawing.Size(259, 29)
        Me.nupStock.TabIndex = 133
        Me.nupStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FrmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.nupStock)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.lblIdProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAce)
        Me.Controls.Add(Me.cmbBusqueda)
        Me.Controls.Add(Me.mnsAjustes)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.lblAvanzadoRazon)
        Me.Controls.Add(Me.lblAvanzadoStock)
        Me.Controls.Add(Me.cmbAvanzadoRazon)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dgvProd)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmAjustes"
        Me.Text = "sssss"
        CType(Me.dgvProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnsAjustes.ResumeLayout(False)
        Me.mnsAjustes.PerformLayout()
        CType(Me.nupStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProd As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents lblAvanzadoRazon As Label
    Friend WithEvents lblAvanzadoStock As Label
    Friend WithEvents cmbAvanzadoRazon As ComboBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents mnsAjustes As MenuStrip
    Friend WithEvents cmbBusqueda As ComboBox
    Friend WithEvents btnCan As Button
    Friend WithEvents btnAce As Button
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblIdProd As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents nupStock As NumericUpDown
    Friend WithEvents tsmAgregar As ToolStripMenuItem
End Class
