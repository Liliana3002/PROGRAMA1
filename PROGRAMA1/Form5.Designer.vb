<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.txt_FkidMedicaconsul = New System.Windows.Forms.TextBox()
        Me.txt_FkidExconsul = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_Indica = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_Dx = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_Motivo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_Explo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_Antec = New System.Windows.Forms.TextBox()
        Me.txt_Presion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Imc = New System.Windows.Forms.TextBox()
        Me.txt_Peso = New System.Windows.Forms.TextBox()
        Me.txt_Freresp = New System.Windows.Forms.TextBox()
        Me.txt_Altura = New System.Windows.Forms.TextBox()
        Me.txt_Fkidagendaconsul = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.Button()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Buscarconsul = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Fkidmedconsul = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Fkidpacconsul = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_idconsul = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Consultas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Consultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(479, 677)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DIRECCIÓN DE NOTIFICACIONES CLL 00 # 00 -100"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txt_FkidMedicaconsul)
        Me.GroupBox1.Controls.Add(Me.txt_FkidExconsul)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_Indica)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_Dx)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_Motivo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_Explo)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_Antec)
        Me.GroupBox1.Controls.Add(Me.txt_Presion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_Imc)
        Me.GroupBox1.Controls.Add(Me.txt_Peso)
        Me.GroupBox1.Controls.Add(Me.txt_Freresp)
        Me.GroupBox1.Controls.Add(Me.txt_Altura)
        Me.GroupBox1.Controls.Add(Me.txt_Fkidagendaconsul)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btn_Editar)
        Me.GroupBox1.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.btn_Menu)
        Me.GroupBox1.Controls.Add(Me.btn_Registrar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_Buscarconsul)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Fkidmedconsul)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Fkidpacconsul)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_idconsul)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(702, 477)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONSULTAS"
        '
        'txt_FkidMedicaconsul
        '
        Me.txt_FkidMedicaconsul.Location = New System.Drawing.Point(206, 296)
        Me.txt_FkidMedicaconsul.Name = "txt_FkidMedicaconsul"
        Me.txt_FkidMedicaconsul.Size = New System.Drawing.Size(469, 20)
        Me.txt_FkidMedicaconsul.TabIndex = 46
        '
        'txt_FkidExconsul
        '
        Me.txt_FkidExconsul.Location = New System.Drawing.Point(205, 270)
        Me.txt_FkidExconsul.Name = "txt_FkidExconsul"
        Me.txt_FkidExconsul.Size = New System.Drawing.Size(469, 20)
        Me.txt_FkidExconsul.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 299)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "MEDICAMENTOS:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 273)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "ÉXAMENES:"
        '
        'txt_Indica
        '
        Me.txt_Indica.Location = New System.Drawing.Point(205, 242)
        Me.txt_Indica.Name = "txt_Indica"
        Me.txt_Indica.Size = New System.Drawing.Size(470, 20)
        Me.txt_Indica.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 245)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "INDICACIONES:"
        '
        'txt_Dx
        '
        Me.txt_Dx.Location = New System.Drawing.Point(205, 216)
        Me.txt_Dx.Name = "txt_Dx"
        Me.txt_Dx.Size = New System.Drawing.Size(470, 20)
        Me.txt_Dx.TabIndex = 39
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "DIAGNÓSTICO:"
        '
        'txt_Motivo
        '
        Me.txt_Motivo.Location = New System.Drawing.Point(560, 189)
        Me.txt_Motivo.Name = "txt_Motivo"
        Me.txt_Motivo.Size = New System.Drawing.Size(115, 20)
        Me.txt_Motivo.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(429, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "MOTIVO DE CONSULTA:"
        '
        'txt_Explo
        '
        Me.txt_Explo.Location = New System.Drawing.Point(205, 189)
        Me.txt_Explo.Name = "txt_Explo"
        Me.txt_Explo.Size = New System.Drawing.Size(209, 20)
        Me.txt_Explo.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 192)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 13)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "EXPLORACIÓN FÍSICA:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(429, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "ANTECEDENTES:"
        '
        'txt_Antec
        '
        Me.txt_Antec.Location = New System.Drawing.Point(524, 160)
        Me.txt_Antec.Name = "txt_Antec"
        Me.txt_Antec.Size = New System.Drawing.Size(151, 20)
        Me.txt_Antec.TabIndex = 31
        '
        'txt_Presion
        '
        Me.txt_Presion.Location = New System.Drawing.Point(205, 160)
        Me.txt_Presion.Name = "txt_Presion"
        Me.txt_Presion.Size = New System.Drawing.Size(209, 20)
        Me.txt_Presion.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 163)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "PRESIÓN ARTERIAL."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(429, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "IMC:"
        '
        'txt_Imc
        '
        Me.txt_Imc.Location = New System.Drawing.Point(466, 134)
        Me.txt_Imc.Name = "txt_Imc"
        Me.txt_Imc.Size = New System.Drawing.Size(209, 20)
        Me.txt_Imc.TabIndex = 27
        '
        'txt_Peso
        '
        Me.txt_Peso.Location = New System.Drawing.Point(466, 108)
        Me.txt_Peso.Name = "txt_Peso"
        Me.txt_Peso.Size = New System.Drawing.Size(209, 20)
        Me.txt_Peso.TabIndex = 26
        '
        'txt_Freresp
        '
        Me.txt_Freresp.Location = New System.Drawing.Point(205, 134)
        Me.txt_Freresp.Name = "txt_Freresp"
        Me.txt_Freresp.Size = New System.Drawing.Size(209, 20)
        Me.txt_Freresp.TabIndex = 23
        '
        'txt_Altura
        '
        Me.txt_Altura.Location = New System.Drawing.Point(205, 108)
        Me.txt_Altura.Name = "txt_Altura"
        Me.txt_Altura.Size = New System.Drawing.Size(209, 20)
        Me.txt_Altura.TabIndex = 22
        '
        'txt_Fkidagendaconsul
        '
        Me.txt_Fkidagendaconsul.Location = New System.Drawing.Point(507, 82)
        Me.txt_Fkidagendaconsul.Name = "txt_Fkidagendaconsul"
        Me.txt_Fkidagendaconsul.Size = New System.Drawing.Size(168, 20)
        Me.txt_Fkidagendaconsul.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(429, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "N° AGENDA:"
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.ForeColor = System.Drawing.Color.White
        Me.btn_Editar.Location = New System.Drawing.Point(480, 417)
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
        Me.btn_Nuevo.Location = New System.Drawing.Point(480, 353)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(252, 353)
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
        Me.btn_Buscar.Location = New System.Drawing.Point(252, 417)
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
        Me.btn_Menu.Location = New System.Drawing.Point(26, 417)
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
        Me.btn_Registrar.Location = New System.Drawing.Point(26, 353)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(195, 40)
        Me.btn_Registrar.TabIndex = 14
        Me.btn_Registrar.Text = "REGISTRAR"
        Me.btn_Registrar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "BUSCAR CÓDIGO DE CONSULTA:"
        '
        'txt_Buscarconsul
        '
        Me.txt_Buscarconsul.Location = New System.Drawing.Point(205, 322)
        Me.txt_Buscarconsul.Name = "txt_Buscarconsul"
        Me.txt_Buscarconsul.Size = New System.Drawing.Size(470, 20)
        Me.txt_Buscarconsul.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "FRECUENCIA RESPIRATORIA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(429, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PESO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ALTURA:"
        '
        'txt_Fkidmedconsul
        '
        Me.txt_Fkidmedconsul.Location = New System.Drawing.Point(205, 82)
        Me.txt_Fkidmedconsul.Name = "txt_Fkidmedconsul"
        Me.txt_Fkidmedconsul.Size = New System.Drawing.Size(209, 20)
        Me.txt_Fkidmedconsul.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "IDENTIFICACIÓN MÉDICO:"
        '
        'txt_Fkidpacconsul
        '
        Me.txt_Fkidpacconsul.Location = New System.Drawing.Point(205, 54)
        Me.txt_Fkidpacconsul.Name = "txt_Fkidpacconsul"
        Me.txt_Fkidpacconsul.Size = New System.Drawing.Size(470, 20)
        Me.txt_Fkidpacconsul.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IDENTIFICACIÓN DEL PACIENTE:"
        '
        'txt_idconsul
        '
        Me.txt_idconsul.Location = New System.Drawing.Point(205, 28)
        Me.txt_idconsul.Name = "txt_idconsul"
        Me.txt_idconsul.Size = New System.Drawing.Size(470, 20)
        Me.txt_idconsul.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° CONSULTA:"
        '
        'dgv_Consultas
        '
        Me.dgv_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Consultas.Location = New System.Drawing.Point(12, 525)
        Me.dgv_Consultas.Name = "dgv_Consultas"
        Me.dgv_Consultas.Size = New System.Drawing.Size(1346, 139)
        Me.dgv_Consultas.TabIndex = 17
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.dgv_Consultas)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form5"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Consultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Editar As Button
    Friend WithEvents btn_Nuevo As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_Menu As Button
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Buscarconsul As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Fkidmedconsul As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Fkidpacconsul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_idconsul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_Indica As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_Dx As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_Motivo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_Explo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Antec As TextBox
    Friend WithEvents txt_Presion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_Imc As TextBox
    Friend WithEvents txt_Peso As TextBox
    Friend WithEvents txt_Freresp As TextBox
    Friend WithEvents txt_Altura As TextBox
    Friend WithEvents txt_Fkidagendaconsul As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents dgv_Consultas As DataGridView
    Friend WithEvents txt_FkidMedicaconsul As TextBox
    Friend WithEvents txt_FkidExconsul As TextBox
End Class
