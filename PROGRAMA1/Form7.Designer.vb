<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Nombre = New System.Windows.Forms.ComboBox()
        Me.btn_Editar = New System.Windows.Forms.Button()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Menu = New System.Windows.Forms.Button()
        Me.btn_Registrar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_BuscarEx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Indica = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Codigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Examenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_Examenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(436, 671)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(435, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "DIRECCIÓN DE NOTIFICACIONES CLL 00 # 00 -100"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.Controls.Add(Me.btn_Editar)
        Me.GroupBox1.Controls.Add(Me.btn_Nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_Eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_Buscar)
        Me.GroupBox1.Controls.Add(Me.btn_Menu)
        Me.GroupBox1.Controls.Add(Me.btn_Registrar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_Fecha)
        Me.GroupBox1.Controls.Add(Me.txt_BuscarEx)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_Indica)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Codigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(301, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 390)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ÉXAMENES"
        '
        'txt_Nombre
        '
        Me.txt_Nombre.FormattingEnabled = True
        Me.txt_Nombre.Items.AddRange(New Object() {"HEMOGRAMA", "HEMOGLOBINA", "HEMATOCRITO", "ESP", "PARCIAL DE ORINA", "COPROLÓGICO", "COPROSCÓPICO", "COLESTEROL", "TRIGLICERIDO", "CREATININA", "GPT", "GOT", "HDL", "LDL", "VLDL", "ACIDO URICO", "VDRL", "RPR", ""})
        Me.txt_Nombre.Location = New System.Drawing.Point(207, 71)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(470, 21)
        Me.txt_Nombre.TabIndex = 47
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
        Me.Label7.Location = New System.Drawing.Point(25, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "BUSCAR ÉXAMEN POR CÓDIGO:"
        '
        'txt_Fecha
        '
        Me.txt_Fecha.CustomFormat = "yyyy.MM.dd"
        Me.txt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Fecha.Location = New System.Drawing.Point(449, 45)
        Me.txt_Fecha.Name = "txt_Fecha"
        Me.txt_Fecha.Size = New System.Drawing.Size(228, 20)
        Me.txt_Fecha.TabIndex = 12
        Me.txt_Fecha.Value = New Date(2021, 10, 11, 8, 52, 21, 0)
        '
        'txt_BuscarEx
        '
        Me.txt_BuscarEx.Location = New System.Drawing.Point(207, 125)
        Me.txt_BuscarEx.Name = "txt_BuscarEx"
        Me.txt_BuscarEx.Size = New System.Drawing.Size(470, 20)
        Me.txt_BuscarEx.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(370, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FECHA:"
        '
        'txt_Indica
        '
        Me.txt_Indica.Location = New System.Drawing.Point(207, 99)
        Me.txt_Indica.Name = "txt_Indica"
        Me.txt_Indica.Size = New System.Drawing.Size(470, 20)
        Me.txt_Indica.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "INDICACIONES:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE:"
        '
        'txt_Codigo
        '
        Me.txt_Codigo.Location = New System.Drawing.Point(207, 45)
        Me.txt_Codigo.Name = "txt_Codigo"
        Me.txt_Codigo.Size = New System.Drawing.Size(157, 20)
        Me.txt_Codigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CÓDIGO:"
        '
        'dgv_Examenes
        '
        Me.dgv_Examenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Examenes.Location = New System.Drawing.Point(438, 436)
        Me.dgv_Examenes.Name = "dgv_Examenes"
        Me.dgv_Examenes.Size = New System.Drawing.Size(433, 210)
        Me.dgv_Examenes.TabIndex = 17
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1283, 749)
        Me.Controls.Add(Me.dgv_Examenes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form7"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_Examenes, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_Fecha As DateTimePicker
    Friend WithEvents txt_BuscarEx As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Indica As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Codigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_Examenes As DataGridView
    Friend WithEvents txt_Nombre As ComboBox
End Class
