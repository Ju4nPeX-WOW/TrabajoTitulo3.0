<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrincipalForm
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.Principal_Venta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Compra = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CATEGORIASToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DESCUENTOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Personas = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPLEADOSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORESToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Estadisticas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Documentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOLETAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTACREDITOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTADEBITOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Historial = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUSTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Principal_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnResetCat = New System.Windows.Forms.Button()
        Me.TimerStock = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_EstadoStock = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Principal_Venta, Me.Principal_Compra, Me.Principal_Productos, Me.Principal_Personas, Me.Principal_Estadisticas, Me.Principal_Documentos, Me.Principal_Historial, Me.Principal_Help, Me.SALIRToolStripMenuItem})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 40)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(202, 360)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'Principal_Venta
        '
        Me.Principal_Venta.Image = Global.TT.My.Resources.Resources.coin
        Me.Principal_Venta.Name = "Principal_Venta"
        Me.Principal_Venta.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Venta.Size = New System.Drawing.Size(71, 40)
        Me.Principal_Venta.Text = "VENTA"
        '
        'Principal_Compra
        '
        Me.Principal_Compra.Image = Global.TT.My.Resources.Resources.coin
        Me.Principal_Compra.Name = "Principal_Compra"
        Me.Principal_Compra.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Compra.Size = New System.Drawing.Size(85, 40)
        Me.Principal_Compra.Text = "COMPRA"
        '
        'Principal_Productos
        '
        Me.Principal_Productos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PRODUCTOSToolStripMenuItem2, Me.CATEGORIASToolStripMenuItem1, Me.DESCUENTOSToolStripMenuItem1})
        Me.Principal_Productos.Image = Global.TT.My.Resources.Resources.product
        Me.Principal_Productos.Name = "Principal_Productos"
        Me.Principal_Productos.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Productos.Size = New System.Drawing.Size(103, 40)
        Me.Principal_Productos.Text = "PRODUCTOS"
        '
        'PRODUCTOSToolStripMenuItem2
        '
        Me.PRODUCTOSToolStripMenuItem2.Name = "PRODUCTOSToolStripMenuItem2"
        Me.PRODUCTOSToolStripMenuItem2.Size = New System.Drawing.Size(146, 22)
        Me.PRODUCTOSToolStripMenuItem2.Text = "PRODUCTOS"
        '
        'CATEGORIASToolStripMenuItem1
        '
        Me.CATEGORIASToolStripMenuItem1.Name = "CATEGORIASToolStripMenuItem1"
        Me.CATEGORIASToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.CATEGORIASToolStripMenuItem1.Text = "CATEGORIAS"
        '
        'DESCUENTOSToolStripMenuItem1
        '
        Me.DESCUENTOSToolStripMenuItem1.Name = "DESCUENTOSToolStripMenuItem1"
        Me.DESCUENTOSToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.DESCUENTOSToolStripMenuItem1.Text = "DESCUENTOS"
        '
        'Principal_Personas
        '
        Me.Principal_Personas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOSToolStripMenuItem, Me.EMPLEADOSToolStripMenuItem1, Me.CLIENTESToolStripMenuItem, Me.PROVEEDORESToolStripMenuItem2})
        Me.Principal_Personas.Image = Global.TT.My.Resources.Resources.team
        Me.Principal_Personas.Name = "Principal_Personas"
        Me.Principal_Personas.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Personas.Size = New System.Drawing.Size(93, 40)
        Me.Principal_Personas.Text = "PERSONAS"
        '
        'USUARIOSToolStripMenuItem
        '
        Me.USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        Me.USUARIOSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.USUARIOSToolStripMenuItem.Text = "USUARIOS"
        '
        'EMPLEADOSToolStripMenuItem1
        '
        Me.EMPLEADOSToolStripMenuItem1.Name = "EMPLEADOSToolStripMenuItem1"
        Me.EMPLEADOSToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EMPLEADOSToolStripMenuItem1.Text = "EMPLEADOS"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'PROVEEDORESToolStripMenuItem2
        '
        Me.PROVEEDORESToolStripMenuItem2.Name = "PROVEEDORESToolStripMenuItem2"
        Me.PROVEEDORESToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.PROVEEDORESToolStripMenuItem2.Text = "PROVEEDORES"
        '
        'Principal_Estadisticas
        '
        Me.Principal_Estadisticas.Image = Global.TT.My.Resources.Resources.graph
        Me.Principal_Estadisticas.Name = "Principal_Estadisticas"
        Me.Principal_Estadisticas.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Estadisticas.Size = New System.Drawing.Size(110, 40)
        Me.Principal_Estadisticas.Text = "ESTADISTICAS"
        '
        'Principal_Documentos
        '
        Me.Principal_Documentos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOLETAToolStripMenuItem, Me.FACTURAToolStripMenuItem, Me.NOTACREDITOToolStripMenuItem, Me.NOTADEBITOToolStripMenuItem})
        Me.Principal_Documentos.Image = Global.TT.My.Resources.Resources.document2
        Me.Principal_Documentos.Name = "Principal_Documentos"
        Me.Principal_Documentos.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Documentos.Size = New System.Drawing.Size(115, 40)
        Me.Principal_Documentos.Text = "DOCUMENTOS"
        '
        'BOLETAToolStripMenuItem
        '
        Me.BOLETAToolStripMenuItem.Name = "BOLETAToolStripMenuItem"
        Me.BOLETAToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.BOLETAToolStripMenuItem.Text = "BOLETA"
        '
        'FACTURAToolStripMenuItem
        '
        Me.FACTURAToolStripMenuItem.Name = "FACTURAToolStripMenuItem"
        Me.FACTURAToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FACTURAToolStripMenuItem.Text = "FACTURA"
        '
        'NOTACREDITOToolStripMenuItem
        '
        Me.NOTACREDITOToolStripMenuItem.Name = "NOTACREDITOToolStripMenuItem"
        Me.NOTACREDITOToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NOTACREDITOToolStripMenuItem.Text = "NOTA CREDITO"
        '
        'NOTADEBITOToolStripMenuItem
        '
        Me.NOTADEBITOToolStripMenuItem.Name = "NOTADEBITOToolStripMenuItem"
        Me.NOTADEBITOToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NOTADEBITOToolStripMenuItem.Text = "NOTA DEBITO"
        '
        'Principal_Historial
        '
        Me.Principal_Historial.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VENTASToolStripMenuItem, Me.COMPRASToolStripMenuItem, Me.AJUSTESToolStripMenuItem})
        Me.Principal_Historial.Image = Global.TT.My.Resources.Resources.history
        Me.Principal_Historial.Name = "Principal_Historial"
        Me.Principal_Historial.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Historial.Size = New System.Drawing.Size(92, 40)
        Me.Principal_Historial.Text = "HISTORIAL"
        '
        'VENTASToolStripMenuItem
        '
        Me.VENTASToolStripMenuItem.Name = "VENTASToolStripMenuItem"
        Me.VENTASToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.VENTASToolStripMenuItem.Text = "VENTAS"
        '
        'COMPRASToolStripMenuItem
        '
        Me.COMPRASToolStripMenuItem.Name = "COMPRASToolStripMenuItem"
        Me.COMPRASToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.COMPRASToolStripMenuItem.Text = "COMPRAS"
        '
        'AJUSTESToolStripMenuItem
        '
        Me.AJUSTESToolStripMenuItem.Name = "AJUSTESToolStripMenuItem"
        Me.AJUSTESToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AJUSTESToolStripMenuItem.Text = "AJUSTES"
        '
        'Principal_Help
        '
        Me.Principal_Help.Image = Global.TT.My.Resources.Resources.help
        Me.Principal_Help.Name = "Principal_Help"
        Me.Principal_Help.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.Principal_Help.Size = New System.Drawing.Size(109, 40)
        Me.Principal_Help.Text = "HELP CENTER"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Image = Global.TT.My.Resources.Resources.exit_1_
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 4, 20)
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(65, 40)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'BtnResetCat
        '
        Me.BtnResetCat.Location = New System.Drawing.Point(22, 435)
        Me.BtnResetCat.Name = "BtnResetCat"
        Me.BtnResetCat.Size = New System.Drawing.Size(128, 23)
        Me.BtnResetCat.TabIndex = 4
        Me.BtnResetCat.Text = "Resetear Categorias"
        Me.BtnResetCat.UseVisualStyleBackColor = True
        '
        'TimerStock
        '
        Me.TimerStock.Interval = 150
        '
        'lbl_EstadoStock
        '
        Me.lbl_EstadoStock.AutoEllipsis = True
        Me.lbl_EstadoStock.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_EstadoStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_EstadoStock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_EstadoStock.Font = New System.Drawing.Font("Lucida Console", 8.5!)
        Me.lbl_EstadoStock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_EstadoStock.Location = New System.Drawing.Point(0, 690)
        Me.lbl_EstadoStock.Name = "lbl_EstadoStock"
        Me.lbl_EstadoStock.Size = New System.Drawing.Size(1053, 20)
        Me.lbl_EstadoStock.TabIndex = 5
        Me.lbl_EstadoStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 710)
        Me.Controls.Add(Me.lbl_EstadoStock)
        Me.Controls.Add(Me.BtnResetCat)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "PrincipalForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents Principal_Venta As ToolStripMenuItem
    Friend WithEvents Principal_Productos As ToolStripMenuItem
    Friend WithEvents PRODUCTOSToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CATEGORIASToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DESCUENTOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Principal_Personas As ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMPLEADOSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Principal_Estadisticas As ToolStripMenuItem
    Friend WithEvents Principal_Documentos As ToolStripMenuItem
    Friend WithEvents Principal_Historial As ToolStripMenuItem
    Friend WithEvents Principal_Help As ToolStripMenuItem
    Friend WithEvents Principal_Compra As ToolStripMenuItem
    Friend WithEvents PROVEEDORESToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents BOLETAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FACTURAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOTACREDITOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NOTADEBITOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENTASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COMPRASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUSTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnResetCat As Button
    Friend WithEvents TimerStock As Timer
    Friend WithEvents lbl_EstadoStock As Label
End Class
