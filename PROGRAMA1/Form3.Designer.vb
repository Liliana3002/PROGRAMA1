<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.txt_Genero = New System.Windows.Forms.ComboBox()
        Me.txt_Telef = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.Button()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Fechanac = New System.Windows.Forms.DateTimePicker()
        Me.txt_BuscarPac = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_Correo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_IdPac = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv_Pacientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txt_Genero)
        Me.GroupBox1.Controls.Add(Me.txt_Telef)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btn_Editar)
        Me.GroupBox1.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.btn_Menu)
        Me.GroupBox1.Controls.Add(Me.btn_Registrar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_Fechanac)
        Me.GroupBox1.Controls.Add(Me.txt_BuscarPac)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_Correo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Apellido)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_IdPac)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(348, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 390)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PACIENTE"
        '
        'txt_Genero
        '
        Me.txt_Genero.FormattingEnabled = True
        Me.txt_Genero.Items.AddRange(New Object() {"F", "M"})
        Me.txt_Genero.Location = New System.Drawing.Point(523, 129)
        Me.txt_Genero.Name = "txt_Genero"
        Me.txt_Genero.Size = New System.Drawing.Size(154, 21)
        Me.txt_Genero.TabIndex = 22
        '
        'txt_Telef
        '
        Me.txt_Telef.Location = New System.Drawing.Point(523, 156)
        Me.txt_Telef.Name = "txt_Telef"
        Me.txt_Telef.Size = New System.Drawing.Size(154, 20)
        Me.txt_Telef.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(450, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "TELÉFONO:"
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.ForeColor = System.Drawing.Color.White
        Me.btn_Editar.Location = New System.Drawing.Point(482, 323)
        Me.btn_Editar.Name = "btn_Editar"
        Me.btn_Editar.Size = New System.Drawing.Size(195, 40)
        Me.btn_Editar.TabIndex = 19
        Me.btn_Editar.Text = "EDITAR"
        Me.btn_Editar.UseVisualStyleBackColor = False
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.ForeColor = System.Drawing.Color.White
        Me.btn_Nuevo.Location = New System.Drawing.Point(482, 259)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(195, 40)
        Me.btn_Nuevo.TabIndex = 18
        Me.btn_Nuevo.Text = "NUEVO"
        Me.btn_Nuevo.UseVisualStyleBackColor = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Eliminar.ForeColor = System.Drawing.Color.White
        Me.btn_Eliminar.Location = New System.Drawing.Point(254, 259)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(195, 40)
        Me.btn_Eliminar.TabIndex = 17
        Me.btn_Eliminar.Text = "ELIMINAR"
        Me.btn_Eliminar.UseVisualStyleBackColor = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.ForeColor = System.Drawing.Color.White
        Me.btn_Buscar.Location = New System.Drawing.Point(254, 323)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(195, 40)
        Me.btn_Buscar.TabIndex = 16
        Me.btn_Buscar.Text = "BUSCAR"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'btn_Menu
        '
        Me.btn_Menu.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Menu.ForeColor = System.Drawing.Color.White
        Me.btn_Menu.Location = New System.Drawing.Point(28, 323)
        Me.btn_Menu.Name = "btn_Menu"
        Me.btn_Menu.Size = New System.Drawing.Size(195, 40)
        Me.btn_Menu.TabIndex = 15
        Me.btn_Menu.Text = "MENÚ"
        Me.btn_Menu.UseVisualStyleBackColor = False
        '
        'btn_Registrar
        '
        Me.btn_Registrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Registrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Registrar.ForeColor = System.Drawing.Color.White
        Me.btn_Registrar.Location = New System.Drawing.Point(28, 259)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(195, 40)
        Me.btn_Registrar.TabIndex = 14
        Me.btn_Registrar.Text = "REGISTRAR"
        Me.btn_Registrar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "BUSCAR PACIENTE POR CÉDULA:"
        '
        'txt_Fechanac
        '
        Me.txt_Fechanac.CustomFormat = "yyyy.MM.dd"
        Me.txt_Fechanac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Fechanac.Location = New System.Drawing.Point(207, 127)
        Me.txt_Fechanac.Name = "txt_Fechanac"
        Me.txt_Fechanac.Size = New System.Drawing.Size(228, 20)
        Me.txt_Fechanac.TabIndex = 12
        Me.txt_Fechanac.Value = New Date(2021, 10, 10, 13, 53, 58, 0)
        '
        'txt_BuscarPac
        '
        Me.txt_BuscarPac.Location = New System.Drawing.Point(207, 191)
        Me.txt_BuscarPac.Name = "txt_BuscarPac"
        Me.txt_BuscarPac.Size = New System.Drawing.Size(470, 20)
        Me.txt_BuscarPac.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CORREO ELECTRÓNICO:"
        '
        'txt_Correo
        '
        Me.txt_Correo.Location = New System.Drawing.Point(207, 158)
        Me.txt_Correo.Name = "txt_Correo"
        Me.txt_Correo.Size = New System.Drawing.Size(228, 20)
        Me.txt_Correo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "GÉNERO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FECHA DE NACIMIENTO:"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(207, 99)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(470, 20)
        Me.txt_Apellido.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IDENTIFICACIÓN:"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(207, 71)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(470, 20)
        Me.txt_Nombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "APELLIDOS:"
        '
        'txt_IdPac
        '
        Me.txt_IdPac.Location = New System.Drawing.Point(207, 45)
        Me.txt_IdPac.Name = "txt_IdPac"
        Me.txt_IdPac.Size = New System.Drawing.Size(470, 20)
        Me.txt_IdPac.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOMBRES:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(492, 671)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "DIRECCIÓN DE NOTIFICACIONES CLL 00 # 00 -100"
        '
        'dgv_Pacientes
        '
        Me.dgv_Pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Pacientes.Location = New System.Drawing.Point(348, 449)
        Me.dgv_Pacientes.Name = "dgv_Pacientes"
        Me.dgv_Pacientes.Size = New System.Drawing.Size(713, 198)
        Me.dgv_Pacientes.TabIndex = 13
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.dgv_Pacientes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Fechanac As DateTimePicker
    Friend WithEvents txt_BuscarPac As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_Correo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_IdPac As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_Menu As Button
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_Telef As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgv_Pacientes As DataGridView
    Friend WithEvents txt_Genero As ComboBox
End Class
