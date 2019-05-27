<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
    Inherits TT.FormTamaño

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.picEditar = New System.Windows.Forms.PictureBox()
        Me.picEliminar = New System.Windows.Forms.PictureBox()
        Me.picAgregar = New System.Windows.Forms.PictureBox()
        Me.txtProv = New System.Windows.Forms.TextBox()
        Me.cmbProv = New System.Windows.Forms.ComboBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.pnlComponentes = New System.Windows.Forms.Panel()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbDescuento = New System.Windows.Forms.TrackBar()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRutSnDV = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtApellidoM = New System.Windows.Forms.TextBox()
        Me.txtApellidoP = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComponentes.SuspendLayout()
        CType(Me.tbDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAcciones.SuspendLayout()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'picEditar
        '
        Me.picEditar.Image = CType(resources.GetObject("picEditar.Image"), System.Drawing.Image)
        Me.picEditar.Location = New System.Drawing.Point(70, 0)
        Me.picEditar.Name = "picEditar"
        Me.picEditar.Size = New System.Drawing.Size(39, 36)
        Me.picEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEditar.TabIndex = 74
        Me.picEditar.TabStop = False
        '
        'picEliminar
        '
        Me.picEliminar.Image = CType(resources.GetObject("picEliminar.Image"), System.Drawing.Image)
        Me.picEliminar.Location = New System.Drawing.Point(130, 0)
        Me.picEliminar.Name = "picEliminar"
        Me.picEliminar.Size = New System.Drawing.Size(39, 36)
        Me.picEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEliminar.TabIndex = 73
        Me.picEliminar.TabStop = False
        '
        'picAgregar
        '
        Me.picAgregar.Image = CType(resources.GetObject("picAgregar.Image"), System.Drawing.Image)
        Me.picAgregar.Location = New System.Drawing.Point(12, 0)
        Me.picAgregar.Name = "picAgregar"
        Me.picAgregar.Size = New System.Drawing.Size(39, 36)
        Me.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAgregar.TabIndex = 72
        Me.picAgregar.TabStop = False
        '
        'txtProv
        '
        Me.txtProv.Location = New System.Drawing.Point(228, 108)
        Me.txtProv.Name = "txtProv"
        Me.txtProv.Size = New System.Drawing.Size(911, 20)
        Me.txtProv.TabIndex = 71
        '
        'cmbProv
        '
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(12, 108)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(210, 21)
        Me.cmbProv.TabIndex = 70
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(542, 54)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(114, 25)
        Me.lblUsuario.TabIndex = 69
        Me.lblUsuario.Text = "CLIENTES"
        '
        'pnlComponentes
        '
        Me.pnlComponentes.Controls.Add(Me.lblDescuento)
        Me.pnlComponentes.Controls.Add(Me.btnCancelar)
        Me.pnlComponentes.Controls.Add(Me.btnAceptar)
        Me.pnlComponentes.Controls.Add(Me.Label4)
        Me.pnlComponentes.Controls.Add(Me.tbDescuento)
        Me.pnlComponentes.Controls.Add(Me.txtDV)
        Me.pnlComponentes.Controls.Add(Me.Label7)
        Me.pnlComponentes.Controls.Add(Me.txtRutSnDV)
        Me.pnlComponentes.Controls.Add(Me.Label6)
        Me.pnlComponentes.Controls.Add(Me.txtApellidoM)
        Me.pnlComponentes.Controls.Add(Me.txtApellidoP)
        Me.pnlComponentes.Controls.Add(Me.txtNombres)
        Me.pnlComponentes.Controls.Add(Me.Label3)
        Me.pnlComponentes.Controls.Add(Me.Label2)
        Me.pnlComponentes.Controls.Add(Me.Label1)
        Me.pnlComponentes.Location = New System.Drawing.Point(12, 380)
        Me.pnlComponentes.Name = "pnlComponentes"
        Me.pnlComponentes.Size = New System.Drawing.Size(1127, 272)
        Me.pnlComponentes.TabIndex = 76
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.Location = New System.Drawing.Point(264, 173)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(0, 13)
        Me.lblDescuento.TabIndex = 102
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(766, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(116, 45)
        Me.btnCancelar.TabIndex = 101
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(766, 145)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(116, 45)
        Me.btnAceptar.TabIndex = 100
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Descuento: "
        '
        'tbDescuento
        '
        Me.tbDescuento.Location = New System.Drawing.Point(182, 125)
        Me.tbDescuento.Maximum = 99
        Me.tbDescuento.Name = "tbDescuento"
        Me.tbDescuento.Size = New System.Drawing.Size(334, 45)
        Me.tbDescuento.TabIndex = 98
        Me.tbDescuento.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'txtDV
        '
        Me.txtDV.Location = New System.Drawing.Point(335, 30)
        Me.txtDV.MaxLength = 1
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(51, 20)
        Me.txtDV.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(319, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "-"
        '
        'txtRutSnDV
        '
        Me.txtRutSnDV.Location = New System.Drawing.Point(168, 30)
        Me.txtRutSnDV.MaxLength = 8
        Me.txtRutSnDV.Name = "txtRutSnDV"
        Me.txtRutSnDV.Size = New System.Drawing.Size(145, 20)
        Me.txtRutSnDV.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(111, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Rut:"
        '
        'txtApellidoM
        '
        Me.txtApellidoM.Location = New System.Drawing.Point(692, 93)
        Me.txtApellidoM.Name = "txtApellidoM"
        Me.txtApellidoM.Size = New System.Drawing.Size(324, 20)
        Me.txtApellidoM.TabIndex = 93
        '
        'txtApellidoP
        '
        Me.txtApellidoP.Location = New System.Drawing.Point(692, 67)
        Me.txtApellidoP.Name = "txtApellidoP"
        Me.txtApellidoP.Size = New System.Drawing.Size(324, 20)
        Me.txtApellidoP.TabIndex = 92
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(169, 67)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(410, 20)
        Me.txtNombres.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(598, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Apellido materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(597, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Apellido paterno: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(113, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Nombres: "
        '
        'pnlAcciones
        '
        Me.pnlAcciones.Controls.Add(Me.picAgregar)
        Me.pnlAcciones.Controls.Add(Me.picEliminar)
        Me.pnlAcciones.Controls.Add(Me.picEditar)
        Me.pnlAcciones.Location = New System.Drawing.Point(953, 337)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(186, 36)
        Me.pnlAcciones.TabIndex = 77
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AllowUserToDeleteRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClientes.Location = New System.Drawing.Point(12, 150)
        Me.dgvClientes.MultiSelect = False
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(1127, 181)
        Me.dgvClientes.TabIndex = 78
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 681)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.pnlAcciones)
        Me.Controls.Add(Me.pnlComponentes)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.txtProv)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.lblUsuario)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmClientes"
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComponentes.ResumeLayout(False)
        Me.pnlComponentes.PerformLayout()
        CType(Me.tbDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAcciones.ResumeLayout(False)
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents picEditar As PictureBox
    Friend WithEvents picEliminar As PictureBox
    Friend WithEvents picAgregar As PictureBox
    Friend WithEvents txtProv As TextBox
    Friend WithEvents cmbProv As ComboBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents pnlComponentes As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDescuento As TrackBar
    Friend WithEvents txtDV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRutSnDV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents lblDescuento As Label
    Friend WithEvents dgvClientes As DataGridView
End Class
