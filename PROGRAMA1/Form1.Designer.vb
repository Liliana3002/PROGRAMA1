<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Contraseña = New System.Windows.Forms.TextBox()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.btn_Registrarse = New System.Windows.Forms.Button()
        Me.btn_Recuperar = New System.Windows.Forms.Button()
        Me.btn_Ingresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.txt_Contraseña)
        Me.GroupBox1.Controls.Add(Me.txt_Usuario)
        Me.GroupBox1.Controls.Add(Me.btn_Registrarse)
        Me.GroupBox1.Controls.Add(Me.btn_Recuperar)
        Me.GroupBox1.Controls.Add(Me.btn_Ingresar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(310, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 397)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO"
        '
        'txt_Contraseña
        '
        Me.txt_Contraseña.Location = New System.Drawing.Point(233, 148)
        Me.txt_Contraseña.Name = "txt_Contraseña"
        Me.txt_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Contraseña.Size = New System.Drawing.Size(400, 31)
        Me.txt_Contraseña.TabIndex = 6
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(233, 87)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(400, 31)
        Me.txt_Usuario.TabIndex = 5
        '
        'btn_Registrarse
        '
        Me.btn_Registrarse.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Registrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registrarse.ForeColor = System.Drawing.Color.White
        Me.btn_Registrarse.Location = New System.Drawing.Point(525, 245)
        Me.btn_Registrarse.Name = "btn_Registrarse"
        Me.btn_Registrarse.Size = New System.Drawing.Size(166, 42)
        Me.btn_Registrarse.TabIndex = 4
        Me.btn_Registrarse.Text = "REGISTRASE"
        Me.btn_Registrarse.UseVisualStyleBackColor = False
        '
        'btn_Recuperar
        '
        Me.btn_Recuperar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Recuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Recuperar.ForeColor = System.Drawing.Color.White
        Me.btn_Recuperar.Location = New System.Drawing.Point(219, 245)
        Me.btn_Recuperar.Name = "btn_Recuperar"
        Me.btn_Recuperar.Size = New System.Drawing.Size(286, 42)
        Me.btn_Recuperar.TabIndex = 3
        Me.btn_Recuperar.Text = "RECUPERAR CONTRASEÑA"
        Me.btn_Recuperar.UseVisualStyleBackColor = False
        '
        'btn_Ingresar
        '
        Me.btn_Ingresar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Ingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ingresar.ForeColor = System.Drawing.Color.White
        Me.btn_Ingresar.Location = New System.Drawing.Point(29, 245)
        Me.btn_Ingresar.Name = "btn_Ingresar"
        Me.btn_Ingresar.Size = New System.Drawing.Size(166, 42)
        Me.btn_Ingresar.TabIndex = 2
        Me.btn_Ingresar.Text = "INGRESAR"
        Me.btn_Ingresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CONTASEÑA:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.AutoSize = True
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(80, 83)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(106, 24)
        Me.txt_Nombre.TabIndex = 0
        Me.txt_Nombre.Text = "USUARIO:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(239, 207)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(191, 29)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Ver contraseña"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1327, 506)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Nombre As Label
    Friend WithEvents btn_Ingresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Registrarse As Button
    Friend WithEvents btn_Recuperar As Button
    Friend WithEvents txt_Contraseña As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
