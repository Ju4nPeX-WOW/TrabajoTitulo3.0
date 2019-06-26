<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoAjustes
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.cmbFiltroBusq = New System.Windows.Forms.ComboBox()
        Me.BtnExitCat = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvPrecios = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(456, 55)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(257, 25)
        Me.lblUsuario.TabIndex = 79
        Me.lblUsuario.Text = "HISTORIAL DE AJUSTES"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(239, 104)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(586, 20)
        Me.txtBusqueda.TabIndex = 78
        '
        'cmbFiltroBusq
        '
        Me.cmbFiltroBusq.FormattingEnabled = True
        Me.cmbFiltroBusq.Location = New System.Drawing.Point(23, 104)
        Me.cmbFiltroBusq.Name = "cmbFiltroBusq"
        Me.cmbFiltroBusq.Size = New System.Drawing.Size(210, 21)
        Me.cmbFiltroBusq.TabIndex = 77
        '
        'BtnExitCat
        '
        Me.BtnExitCat.Location = New System.Drawing.Point(1115, 8)
        Me.BtnExitCat.Name = "BtnExitCat"
        Me.BtnExitCat.Size = New System.Drawing.Size(35, 23)
        Me.BtnExitCat.TabIndex = 76
        Me.BtnExitCat.Text = "X"
        Me.BtnExitCat.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 146)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1127, 516)
        Me.TabControl1.TabIndex = 75
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvPrecios)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1119, 490)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Precios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvPrecios
        '
        Me.dgvPrecios.AllowUserToAddRows = False
        Me.dgvPrecios.AllowUserToDeleteRows = False
        Me.dgvPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrecios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrecios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvPrecios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPrecios.Location = New System.Drawing.Point(13, 19)
        Me.dgvPrecios.MultiSelect = False
        Me.dgvPrecios.Name = "dgvPrecios"
        Me.dgvPrecios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrecios.Size = New System.Drawing.Size(1100, 274)
        Me.dgvPrecios.TabIndex = 75
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvStock)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1119, 490)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Stock"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvStock.Location = New System.Drawing.Point(13, 19)
        Me.dgvStock.MultiSelect = False
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.Size = New System.Drawing.Size(1100, 274)
        Me.dgvStock.TabIndex = 74
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(850, 102)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 80
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'FrmHistoAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1173, 670)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cmbFiltroBusq)
        Me.Controls.Add(Me.BtnExitCat)
        Me.Controls.Add(Me.TabControl1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FrmHistoAjustes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents cmbFiltroBusq As ComboBox
    Friend WithEvents BtnExitCat As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnAceptar As Button
    Friend WithEvents dgvPrecios As DataGridView
    Friend WithEvents dgvStock As DataGridView
End Class
