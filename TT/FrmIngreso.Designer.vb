<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngreso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIngre = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtUsua = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.lblContra = New System.Windows.Forms.Label()
        Me.lblUsua = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngre
        '
        Me.btnIngre.BackColor = System.Drawing.Color.DarkBlue
        Me.btnIngre.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIngre.Location = New System.Drawing.Point(149, 201)
        Me.btnIngre.Name = "btnIngre"
        Me.btnIngre.Size = New System.Drawing.Size(168, 35)
        Me.btnIngre.TabIndex = 19
        Me.btnIngre.Text = "Ingresar"
        Me.btnIngre.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Location = New System.Drawing.Point(323, 201)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(168, 35)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtUsua
        '
        Me.txtUsua.BackColor = System.Drawing.Color.White
        Me.txtUsua.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsua.ForeColor = System.Drawing.Color.Black
        Me.txtUsua.Location = New System.Drawing.Point(151, 94)
        Me.txtUsua.Multiline = True
        Me.txtUsua.Name = "txtUsua"
        Me.txtUsua.Size = New System.Drawing.Size(340, 29)
        Me.txtUsua.TabIndex = 14
        Me.txtUsua.Text = "20107427"
        Me.txtUsua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContra
        '
        Me.txtContra.BackColor = System.Drawing.Color.White
        Me.txtContra.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.ForeColor = System.Drawing.Color.Black
        Me.txtContra.Location = New System.Drawing.Point(151, 144)
        Me.txtContra.Multiline = True
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(340, 29)
        Me.txtContra.TabIndex = 17
        Me.txtContra.Text = "admin"
        Me.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblContra
        '
        Me.lblContra.AutoSize = True
        Me.lblContra.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContra.ForeColor = System.Drawing.Color.Black
        Me.lblContra.Location = New System.Drawing.Point(35, 147)
        Me.lblContra.Name = "lblContra"
        Me.lblContra.Size = New System.Drawing.Size(105, 23)
        Me.lblContra.TabIndex = 16
        Me.lblContra.Text = "CONTRASEÑA    :"
        '
        'lblUsua
        '
        Me.lblUsua.AutoSize = True
        Me.lblUsua.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsua.ForeColor = System.Drawing.Color.Black
        Me.lblUsua.Location = New System.Drawing.Point(35, 97)
        Me.lblUsua.Name = "lblUsua"
        Me.lblUsua.Size = New System.Drawing.Size(106, 23)
        Me.lblUsua.TabIndex = 15
        Me.lblUsua.Text = "USUARIO             :"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DarkBlue
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(472, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(33, 26)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnMinimizar.FlatAppearance.BorderSize = 2
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMinimizar.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinimizar.Location = New System.Drawing.Point(433, 4)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(33, 27)
        Me.BtnMinimizar.TabIndex = 22
        Me.BtnMinimizar.Text = "_"
        Me.BtnMinimizar.UseVisualStyleBackColor = False
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.BackColor = System.Drawing.Color.DarkBlue
        Me.Lbl1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.White
        Me.Lbl1.Location = New System.Drawing.Point(11, 4)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(185, 23)
        Me.Lbl1.TabIndex = 23
        Me.Lbl1.Text = "Ferreteria Alberdi Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Lbl1)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 38)
        Me.Panel1.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(101, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 33)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "FERRETERIA ALBERDI"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(530, 38)
        Me.Panel2.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.DarkBlue
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(83, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DESARROLLADO POR JUAN PABLO CORTEZ Y KEVIN PERALTA"
        '
        'FrmIngreso
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(530, 308)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnIngre)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtUsua)
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.lblContra)
        Me.Controls.Add(Me.lblUsua)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmIngreso"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ferreteria Alberdi Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIngre As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtUsua As TextBox
    Friend WithEvents txtContra As TextBox
    Friend WithEvents lblContra As Label
    Friend WithEvents lblUsua As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
End Class
