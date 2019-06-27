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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.picEditar = New System.Windows.Forms.PictureBox()
        Me.picEliminar = New System.Windows.Forms.PictureBox()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.dgvUsua = New System.Windows.Forms.DataGridView()
        Me.pnlComponentes = New System.Windows.Forms.Panel()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmbPermisos = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRut = New System.Windows.Forms.Label()
        Me.picAgregar = New System.Windows.Forms.PictureBox()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComponentes.SuspendLayout()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(542, 54)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(120, 25)
        Me.lblUsuario.TabIndex = 69
        Me.lblUsuario.Text = "USUARIOS"
        '
        'picEditar
        '
        Me.picEditar.Image = CType(resources.GetObject("picEditar.Image"), System.Drawing.Image)
        Me.picEditar.Location = New System.Drawing.Point(1010, 442)
        Me.picEditar.Name = "picEditar"
        Me.picEditar.Size = New System.Drawing.Size(39, 36)
        Me.picEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEditar.TabIndex = 74
        Me.picEditar.TabStop = False
        '
        'picEliminar
        '
        Me.picEliminar.Image = CType(resources.GetObject("picEliminar.Image"), System.Drawing.Image)
        Me.picEliminar.Location = New System.Drawing.Point(1055, 442)
        Me.picEliminar.Name = "picEliminar"
        Me.picEliminar.Size = New System.Drawing.Size(39, 36)
        Me.picEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEliminar.TabIndex = 73
        Me.picEliminar.TabStop = False
        '
        'txtProv
        '
        Me.txtProv.Location = New System.Drawing.Point(228, 108)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(911, 20)
        Me.txtProv.TabIndex = 79
        '
        'cmbProv
        '
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(12, 108)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(210, 21)
        Me.cmbProv.TabIndex = 78
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
        Me.pnlComponentes.Controls.Add(Me.txtRut)
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
        Me.txtDV.Location = New System.Drawing.Point(228, 54)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(51, 20)
        Me.txtDV.TabIndex = 100
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(212, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "-"
        '
        'txtRut
        '
        Me.txtRut.Location = New System.Drawing.Point(61, 54)
        Me.txtRut.MaxLength = 8
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(145, 20)
        Me.txtRut.TabIndex = 98
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(790, 105)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(163, 43)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(790, 29)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(163, 43)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmbPermisos
        '
        Me.cmbPermisos.FormattingEnabled = True
        Me.cmbPermisos.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbPermisos.Location = New System.Drawing.Point(385, 105)
        Me.cmbPermisos.Name = "cmbPermisos"
        Me.cmbPermisos.Size = New System.Drawing.Size(236, 21)
        Me.cmbPermisos.TabIndex = 7
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(385, 54)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(236, 20)
        Me.txtContraseña.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Permisos:"
        '
        'lblRut
        '
        Me.lblRut.AutoSize = True
        Me.lblRut.Location = New System.Drawing.Point(30, 59)
        Me.lblRut.Name = "lblRut"
        Me.lblRut.Size = New System.Drawing.Size(27, 13)
        Me.lblRut.TabIndex = 0
        Me.lblRut.Text = "Rut:"
        '
        'picAgregar
        '
        Me.picAgregar.Image = CType(resources.GetObject("picAgregar.Image"), System.Drawing.Image)
        Me.picAgregar.Location = New System.Drawing.Point(965, 442)
        Me.picAgregar.Name = "picAgregar"
        Me.picAgregar.Size = New System.Drawing.Size(39, 36)
        Me.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAgregar.TabIndex = 82
        Me.picAgregar.TabStop = False
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.picAgregar)
        Me.Controls.Add(Me.pnlComponentes)
        Me.Controls.Add(Me.dgvUsua)
        Me.Controls.Add(Me.txtProv)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.picEditar)
        Me.Controls.Add(Me.picEliminar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmUsers"
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComponentes.ResumeLayout(False)
        Me.pnlComponentes.PerformLayout()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents picEditar As PictureBox
    Friend WithEvents picEliminar As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtProv As TextBox
    Friend WithEvents cmbProv As ComboBox
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
    Friend WithEvents txtRut As TextBox
    Friend WithEvents picAgregar As PictureBox
End Class
