<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Buscaragenda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Hora = New System.Windows.Forms.TextBox()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_Estatus = New System.Windows.Forms.ComboBox()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.Button()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Motivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_FkidMed = New System.Windows.Forms.TextBox()
        Me.txt_FkidPac = New System.Windows.Forms.TextBox()
        Me.txt_Numagenda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Agendas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Agendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(462, 674)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "DIRECCIÓN DE NOTIFICACIONES CLL 00 # 00 -100"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Buscaragenda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_Hora)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.txt_Estatus)
        Me.GroupBox1.Controls.Add(Me.btn_Editar)
        Me.GroupBox1.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.btn_Menu)
        Me.GroupBox1.Controls.Add(Me.btn_Registrar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_Motivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_FkidMed)
        Me.GroupBox1.Controls.Add(Me.txt_FkidPac)
        Me.GroupBox1.Controls.Add(Me.txt_Numagenda)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(323, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 390)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AGENDA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "BUSCAR AGENDA POR NÚMERO:"
        '
        'txt_Buscaragenda
        '
        Me.txt_Buscaragenda.Location = New System.Drawing.Point(207, 191)
        Me.txt_Buscaragenda.Name = "txt_Buscaragenda"
        Me.txt_Buscaragenda.Size = New System.Drawing.Size(470, 20)
        Me.txt_Buscaragenda.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "IDENTIFICACIÓN MÉDICO :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "IDENTIFICACIÓN PACIENTE:"
        '
        'txt_Hora
        '
        Me.txt_Hora.Location = New System.Drawing.Point(523, 160)
        Me.txt_Hora.Name = "txt_Hora"
        Me.txt_Hora.Size = New System.Drawing.Size(154, 20)
        Me.txt_Hora.TabIndex = 22
        '
        'txt_Fecha
        '
        Me.txt_Fecha.CustomFormat = "yyyy.MM.dd"
        Me.txt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Fecha.Location = New System.Drawing.Point(207, 162)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(242, 20)
        Me.txt_Fecha.TabIndex = 21
        Me.txt_Fecha.Value = New Date(2021, 10, 10, 14, 11, 27, 0)
        '
        'txt_Estatus
        '
        Me.txt_Estatus.FormattingEnabled = True
        Me.txt_Estatus.Items.AddRange(New Object() {"NO PRIORITARIA", "PRIORITARIA"})
        Me.txt_Estatus.Location = New System.Drawing.Point(207, 131)
        Me.txt_Estatus.Name = "txt_Estatus"
        Me.txt_Estatus.Size = New System.Drawing.Size(242, 21)
        Me.txt_Estatus.TabIndex = 20
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
        Me.Label7.Location = New System.Drawing.Point(476, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "HORA:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "FECHA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(465, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MOTIVO:"
        '
        'txt_Motivo
        '
        Me.txt_Motivo.Location = New System.Drawing.Point(523, 130)
        Me.txt_Motivo.Name = "txt_Motivo"
        Me.txt_Motivo.Size = New System.Drawing.Size(154, 20)
        Me.txt_Motivo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ESTATUS:"
        '
        'txt_FkidMed
        '
        Me.txt_FkidMed.Location = New System.Drawing.Point(207, 99)
        Me.txt_FkidMed.Name = "txt_FkidMed"
        Me.txt_FkidMed.Size = New System.Drawing.Size(470, 20)
        Me.txt_FkidMed.TabIndex = 5
        '
        'txt_FkidPac
        '
        Me.txt_FkidPac.Location = New System.Drawing.Point(207, 71)
        Me.txt_FkidPac.Name = "txt_FkidPac"
        Me.txt_FkidPac.Size = New System.Drawing.Size(470, 20)
        Me.txt_FkidPac.TabIndex = 3
        '
        'txt_Numagenda
        '
        Me.txt_Numagenda.Location = New System.Drawing.Point(207, 45)
        Me.txt_Numagenda.Name = "txt_Numagenda"
        Me.txt_Numagenda.Size = New System.Drawing.Size(470, 20)
        Me.txt_Numagenda.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGENDA N°:"
        '
        'dgv_Agendas
        '
        Me.dgv_Agendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Agendas.Location = New System.Drawing.Point(323, 437)
        Me.dgv_Agendas.Name = "dgv_Agendas"
        Me.dgv_Agendas.Size = New System.Drawing.Size(702, 219)
        Me.dgv_Agendas.TabIndex = 17
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.dgv_Agendas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "Form4"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Agendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Hora As TextBox
    Friend WithEvents txt_Fecha As DateTimePicker
    Friend WithEvents txt_Estatus As ComboBox
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_Menu As Button
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Motivo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_FkidMed As TextBox
    Friend WithEvents txt_Numagenda As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgv_Agendas As DataGridView
    Friend WithEvents txt_FkidPac As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Buscaragenda As TextBox
End Class
