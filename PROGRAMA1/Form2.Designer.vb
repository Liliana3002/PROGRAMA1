<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Sistema = New System.Windows.Forms.Button()
        Me.btn_Hc = New System.Windows.Forms.Button()
        Me.btn_Examenes = New System.Windows.Forms.Button()
        Me.btn_Medicamentos = New System.Windows.Forms.Button()
        Me.btn_Consultas = New System.Windows.Forms.Button()
        Me.btn_Agendas = New System.Windows.Forms.Button()
        Me.btn_Paciente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_Sistema)
        Me.GroupBox1.Controls.Add(Me.btn_Hc)
        Me.GroupBox1.Controls.Add(Me.btn_Examenes)
        Me.GroupBox1.Controls.Add(Me.btn_Medicamentos)
        Me.GroupBox1.Controls.Add(Me.btn_Consultas)
        Me.GroupBox1.Controls.Add(Me.btn_Agendas)
        Me.GroupBox1.Controls.Add(Me.btn_Paciente)
        Me.GroupBox1.Location = New System.Drawing.Point(239, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(911, 488)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MENÚ PRINCIPAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "DIRECCIÓN DE NOTIFICACIONES CLL 00 # 00 -100"
        '
        'btn_Sistema
        '
        Me.btn_Sistema.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Sistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Sistema.ForeColor = System.Drawing.Color.White
        Me.btn_Sistema.Location = New System.Drawing.Point(367, 324)
        Me.btn_Sistema.Name = "btn_Sistema"
        Me.btn_Sistema.Size = New System.Drawing.Size(195, 40)
        Me.btn_Sistema.TabIndex = 9
        Me.btn_Sistema.Text = "SISTEMA"
        Me.btn_Sistema.UseVisualStyleBackColor = False
        '
        'btn_Hc
        '
        Me.btn_Hc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Hc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Hc.ForeColor = System.Drawing.Color.White
        Me.btn_Hc.Location = New System.Drawing.Point(602, 228)
        Me.btn_Hc.Name = "btn_Hc"
        Me.btn_Hc.Size = New System.Drawing.Size(195, 40)
        Me.btn_Hc.TabIndex = 8
        Me.btn_Hc.Text = "HISTORIA CLÍNICA"
        Me.btn_Hc.UseVisualStyleBackColor = False
        '
        'btn_Examenes
        '
        Me.btn_Examenes.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Examenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Examenes.ForeColor = System.Drawing.Color.White
        Me.btn_Examenes.Location = New System.Drawing.Point(367, 228)
        Me.btn_Examenes.Name = "btn_Examenes"
        Me.btn_Examenes.Size = New System.Drawing.Size(195, 40)
        Me.btn_Examenes.TabIndex = 7
        Me.btn_Examenes.Text = "ÉXAMENES"
        Me.btn_Examenes.UseVisualStyleBackColor = False
        '
        'btn_Medicamentos
        '
        Me.btn_Medicamentos.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Medicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Medicamentos.ForeColor = System.Drawing.Color.White
        Me.btn_Medicamentos.Location = New System.Drawing.Point(110, 228)
        Me.btn_Medicamentos.Name = "btn_Medicamentos"
        Me.btn_Medicamentos.Size = New System.Drawing.Size(195, 40)
        Me.btn_Medicamentos.TabIndex = 6
        Me.btn_Medicamentos.Text = "MEDICAMENTOS"
        Me.btn_Medicamentos.UseVisualStyleBackColor = False
        '
        'btn_Consultas
        '
        Me.btn_Consultas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Consultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Consultas.ForeColor = System.Drawing.Color.White
        Me.btn_Consultas.Location = New System.Drawing.Point(602, 110)
        Me.btn_Consultas.Name = "btn_Consultas"
        Me.btn_Consultas.Size = New System.Drawing.Size(195, 40)
        Me.btn_Consultas.TabIndex = 5
        Me.btn_Consultas.Text = "CONSULTAS"
        Me.btn_Consultas.UseVisualStyleBackColor = False
        '
        'btn_Agendas
        '
        Me.btn_Agendas.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Agendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Agendas.ForeColor = System.Drawing.Color.White
        Me.btn_Agendas.Location = New System.Drawing.Point(367, 110)
        Me.btn_Agendas.Name = "btn_Agendas"
        Me.btn_Agendas.Size = New System.Drawing.Size(195, 40)
        Me.btn_Agendas.TabIndex = 4
        Me.btn_Agendas.Text = "AGENDAS"
        Me.btn_Agendas.UseVisualStyleBackColor = False
        '
        'btn_Paciente
        '
        Me.btn_Paciente.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Paciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Paciente.ForeColor = System.Drawing.Color.White
        Me.btn_Paciente.Location = New System.Drawing.Point(110, 110)
        Me.btn_Paciente.Name = "btn_Paciente"
        Me.btn_Paciente.Size = New System.Drawing.Size(195, 40)
        Me.btn_Paciente.TabIndex = 3
        Me.btn_Paciente.Text = "PACIENTES"
        Me.btn_Paciente.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Form2"
        Me.Text = "CENTRO MÉDICO ADSI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Consultas As Button
    Friend WithEvents btn_Agendas As Button
    Friend WithEvents btn_Paciente As Button
    Friend WithEvents btn_Hc As Button
    Friend WithEvents btn_Examenes As Button
    Friend WithEvents btn_Medicamentos As Button
    Friend WithEvents btn_Sistema As Button
    Friend WithEvents Label1 As Label
End Class
