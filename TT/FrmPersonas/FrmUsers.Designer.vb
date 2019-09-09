<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsers))
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.dgvUsua = New System.Windows.Forms.DataGridView()
        Me.pnlComponentes = New System.Windows.Forms.Panel()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRutSnDv = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbPermisos = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.LblFranjaNaranja = New System.Windows.Forms.Label()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.mnsProd = New System.Windows.Forms.MenuStrip()
        Me.tsmEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbBusqueda = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvUsua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComponentes.SuspendLayout()
        Me.mnsProd.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(1104, 12)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(35, 23)
        Me.BtnExit.TabIndex = 75
        Me.BtnExit.Text = "X"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(197, 110)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(772, 33)
        Me.txtBusqueda.TabIndex = 79
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvUsua
        '
        Me.dgvUsua.AllowUserToAddRows = False
        Me.dgvUsua.AllowUserToDeleteRows = False
        Me.dgvUsua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsua.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvUsua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsua.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUsua.Location = New System.Drawing.Point(14, 162)
        Me.dgvUsua.MultiSelect = False
        Me.dgvUsua.Name = "dgvUsua"
        Me.dgvUsua.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvUsua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsua.Size = New System.Drawing.Size(1127, 269)
        Me.dgvUsua.TabIndex = 80
        '
        'pnlComponentes
        '
        Me.pnlComponentes.Controls.Add(Me.txtDV)
        Me.pnlComponentes.Controls.Add(Me.Label7)
        Me.pnlComponentes.Controls.Add(Me.txtRutSnDv)
        Me.pnlComponentes.Controls.Add(Me.btnCancelar)
        Me.pnlComponentes.Controls.Add(Me.btnAceptar)
        Me.pnlComponentes.Controls.Add(Me.cmbPermisos)
        Me.pnlComponentes.Controls.Add(Me.txtContraseña)
        Me.pnlComponentes.Controls.Add(Me.Label1)
        Me.pnlComponentes.Controls.Add(Me.Label3)
        Me.pnlComponentes.Controls.Add(Me.lblRut)
        Me.pnlComponentes.Enabled = False
        Me.pnlComponentes.Location = New System.Drawing.Point(16, 484)
        Me.pnlComponentes.Name = "pnlComponentes"
        Me.pnlComponentes.Size = New System.Drawing.Size(1127, 174)
        Me.pnlComponentes.TabIndex = 81
        '
        'txtDV
        '
        Me.txtDV.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDV.Location = New System.Drawing.Point(322, 54)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(51, 30)
        Me.txtDV.TabIndex = 100
        Me.txtDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(293, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 23)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "-"
        '
        'txtRutSnDv
        '
        Me.txtRutSnDv.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutSnDv.Location = New System.Drawing.Point(137, 54)
        Me.txtRutSnDv.MaxLength = 8
        Me.txtRutSnDv.Name = "txtRutSnDv"
        Me.txtRutSnDv.Size = New System.Drawing.Size(145, 30)
        Me.txtRutSnDv.TabIndex = 98
        Me.txtRutSnDv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Location = New System.Drawing.Point(790, 105)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(163, 43)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.DarkBlue
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAceptar.Location = New System.Drawing.Point(790, 29)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(163, 43)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'cmbPermisos
        '
        Me.cmbPermisos.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPermisos.FormattingEnabled = True
        Me.cmbPermisos.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbPermisos.Location = New System.Drawing.Point(491, 53)
        Me.cmbPermisos.Name = "cmbPermisos"
        Me.cmbPermisos.Size = New System.Drawing.Size(236, 31)
        Me.cmbPermisos.TabIndex = 7
        '
        'txtContraseña
        '
        Me.txtContraseña.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(137, 101)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(236, 30)
        Me.txtContraseña.TabIndex = 6
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(415, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Permisos:"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRut.Location = New System.Drawing.Point(85, 56)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(35, 23)
        Me.lblRut.TabIndex = 0
        Me.lblRut.Text = "Rut:"
        '
        'LblFranjaNaranja
        '
        Me.LblFranjaNaranja.BackColor = System.Drawing.Color.DarkOrange
        Me.LblFranjaNaranja.Location = New System.Drawing.Point(0, 78)
        Me.LblFranjaNaranja.Name = "LblFranjaNaranja"
        Me.LblFranjaNaranja.Size = New System.Drawing.Size(1173, 24)
        Me.LblFranjaNaranja.TabIndex = 123
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
        Me.LblTitulo.Text = "USUARIOS"
        Me.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mnsProd
        '
        Me.mnsProd.AutoSize = False
        Me.mnsProd.BackColor = System.Drawing.Color.DarkOrange
        Me.mnsProd.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsProd.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmEditar, Me.tsmEliminar})
        Me.mnsProd.Location = New System.Drawing.Point(0, 80)
        Me.mnsProd.Name = "mnsProd"
        Me.mnsProd.Size = New System.Drawing.Size(1173, 24)
        Me.mnsProd.TabIndex = 126
        Me.mnsProd.Text = "MenuStrip1"
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
        'cmbBusqueda
        '
        Me.cmbBusqueda.BackColor = System.Drawing.SystemColors.Info
        Me.cmbBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbBusqueda.Font = New System.Drawing.Font("Bahnschrift Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBusqueda.FormattingEnabled = True
        Me.cmbBusqueda.Items.AddRange(New Object() {"RUT EMPLEADO", "PERMISOS"})
        Me.cmbBusqueda.Location = New System.Drawing.Point(14, 110)
        Me.cmbBusqueda.Name = "cmbBusqueda"
        Me.cmbBusqueda.Size = New System.Drawing.Size(177, 33)
        Me.cmbBusqueda.TabIndex = 135
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.BackColor = System.Drawing.Color.DarkOrange
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(975, 108)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(167, 39)
        Me.btnBuscar.TabIndex = 137
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbBusqueda)
        Me.Controls.Add(Me.mnsProd)
        Me.Controls.Add(Me.LblFranjaNaranja)
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.pnlComponentes)
        Me.Controls.Add(Me.dgvUsua)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.BtnExit)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmUsers"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.dgvUsua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComponentes.ResumeLayout(False)
        Me.pnlComponentes.PerformLayout()
        Me.mnsProd.ResumeLayout(False)
        Me.mnsProd.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents dgvUsua As DataGridView
    Friend WithEvents pnlComponentes As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmbPermisos As ComboBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents txtDV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRutSnDv As TextBox
    Friend WithEvents LblFranjaNaranja As Label
    Friend WithEvents LblTitulo As Label
    Friend WithEvents mnsProd As MenuStrip
    Friend WithEvents tsmEditar As ToolStripMenuItem
    Friend WithEvents tsmEliminar As ToolStripMenuItem
    Friend WithEvents cmbBusqueda As ComboBox
    Friend WithEvents btnBuscar As Button
End Class
