<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Fkidconsulhc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_BuscarHc = New System.Windows.Forms.TextBox()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.Button()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Fkidpachc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Idhc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Hc = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Hc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(471, 666)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DIRECCIÓN DE NOTIFICACIONES CLL 00 # 00 -100"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_Fkidconsulhc)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_BuscarHc)
        Me.GroupBox1.Controls.Add(Me.btn_Editar)
        Me.GroupBox1.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.btn_Menu)
        Me.GroupBox1.Controls.Add(Me.btn_Registrar)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Fkidpachc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Idhc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(321, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(718, 390)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HISTORIA CLÍNICA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "N° CONSULTA:"
        '
        'txt_Fkidconsulhc
        '
        Me.txt_Fkidconsulhc.Location = New System.Drawing.Point(207, 144)
        Me.txt_Fkidconsulhc.Name = "txt_Fkidconsulhc"
        Me.txt_Fkidconsulhc.Size = New System.Drawing.Size(221, 20)
        Me.txt_Fkidconsulhc.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "BUSCAR HISTORIA CLÍNICA:"
        '
        'txt_BuscarHc
        '
        Me.txt_BuscarHc.Location = New System.Drawing.Point(207, 180)
        Me.txt_BuscarHc.Name = "txt_BuscarHc"
        Me.txt_BuscarHc.Size = New System.Drawing.Size(221, 20)
        Me.txt_BuscarHc.TabIndex = 20
        '
        'btn_Editar
        '
        Me.btn_Editar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Editar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Editar.ForeColor = System.Drawing.Color.White
        Me.btn_Editar.Location = New System.Drawing.Point(482, 310)
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
        Me.btn_Nuevo.Location = New System.Drawing.Point(482, 246)
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
        Me.btn_Eliminar.Location = New System.Drawing.Point(254, 246)
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
        Me.btn_Buscar.Location = New System.Drawing.Point(254, 310)
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
        Me.btn_Menu.Location = New System.Drawing.Point(28, 310)
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
        Me.btn_Registrar.Location = New System.Drawing.Point(28, 246)
        Me.btn_Registrar.Name = "btn_Registrar"
        Me.btn_Registrar.Size = New System.Drawing.Size(195, 40)
        Me.btn_Registrar.TabIndex = 14
        Me.btn_Registrar.Text = "REGISTRAR"
        Me.btn_Registrar.UseVisualStyleBackColor = False
        '
        'txt_Fecha
        '
        Me.txt_Fecha.CustomFormat = "yyyy.MM.dd"
        Me.txt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Fecha.Location = New System.Drawing.Point(207, 41)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(221, 20)
        Me.txt_Fecha.TabIndex = 12
        Me.txt_Fecha.Value = New Date(2021, 10, 14, 15, 58, 50, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FECHA:"
        '
        'txt_Fkidpachc
        '
        Me.txt_Fkidpachc.Location = New System.Drawing.Point(207, 108)
        Me.txt_Fkidpachc.Name = "txt_Fkidpachc"
        Me.txt_Fkidpachc.Size = New System.Drawing.Size(221, 20)
        Me.txt_Fkidpachc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "IDENTIFICACIÓN DEL PACIENTE:"
        '
        'txt_Idhc
        '
        Me.txt_Idhc.Location = New System.Drawing.Point(207, 75)
        Me.txt_Idhc.Name = "txt_Idhc"
        Me.txt_Idhc.Size = New System.Drawing.Size(221, 20)
        Me.txt_Idhc.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° HISTORIA CLÍNICA:"
        '
        'dgv_Hc
        '
        Me.dgv_Hc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Hc.Location = New System.Drawing.Point(472, 430)
        Me.dgv_Hc.Name = "dgv_Hc"
        Me.dgv_Hc.Size = New System.Drawing.Size(434, 201)
        Me.dgv_Hc.TabIndex = 17
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.dgv_Hc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form8"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Hc, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_Fecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Fkidpachc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Idhc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_Hc As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_BuscarHc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Fkidconsulhc As TextBox
End Class
