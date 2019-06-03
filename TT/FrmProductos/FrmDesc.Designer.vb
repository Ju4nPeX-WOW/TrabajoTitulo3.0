<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesc))
        Me.btnSimpleEliminar = New System.Windows.Forms.Button()
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
        CType(Me.dgvDescuentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnsDes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSimpleEliminar
        '
        Me.btnSimpleEliminar.Enabled = False
        Me.btnSimpleEliminar.Location = New System.Drawing.Point(975, 567)
        Me.btnSimpleEliminar.Name = "btnSimpleEliminar"
        Me.btnSimpleEliminar.Size = New System.Drawing.Size(132, 43)
        Me.btnSimpleEliminar.TabIndex = 84
        Me.btnSimpleEliminar.Text = "ELIMINAR POR COMPLETO"
        Me.btnSimpleEliminar.UseVisualStyleBackColor = True
        Me.btnSimpleEliminar.Visible = False
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
        Me.tsmEliminarCat.Text = "Eliminar"
        '
        'FrmDesc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.btnSimpleEliminar)
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

    Friend WithEvents btnSimpleEliminar As Button
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
End Class
