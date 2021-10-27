#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region

Public Class Form9

#Region "Variables"
    Private cmb As MySqlCommandBuilder
    Dim conexion As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte
    Private Sub btn_Paciente_Click(sender As Object, e As EventArgs)
        Dim f2 As New Form2
        Dim f3 As New Form3
        Dim f4 As New Form4
        Dim f5 As New Form5
        Dim f6 As New Form6
        Dim f7 As New Form7
        Dim f8 As New Form8
        Dim f9 As New Form9
    End Sub
#End Region

#Region "Botones ir al formulario correspondiente"
    Private Sub btn_Menu_Click(sender As Object, e As EventArgs) Handles btn_Menu.Click
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub
#End Region

#Region "Conexion Base de Datos"
    Public Sub Conectar()
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=root;port=3306;database=hospital;sslmode=none"
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT* FROM medicos"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "medicos")
            'dgv_Pacientes.DataSource = datos
            'dgv_Pacientes.DataMember = "medicos"


        Catch ex As Exception
            MsgBox("Desconectado" + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
#End Region

#Region "Agregar Datos"
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        If (txt_Nomusuario.Text = "") Or (txt_Contrase.Text = "") Or (txt_Nuevacont.Text = "") Or (txt_Nombre.Text = "") Or (txt_Fechanacmedico.Text = "") Or (txt_Genero.Text = "") Or (txt_Correo.Text = "") Or (txt_Telefono.Text = "") Or (txt_Especialidad.Text = "") Or (txt_Fechareg.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta1 As String = "SELECT * FROM medicos WHERE idmedico = '" & txt_Nomusuario.Text & "'"
                Dim adaptador1 As New MySqlDataAdapter(consulta1, conexion)
                Dim datos As New DataSet
                adaptador1.Fill(datos, "medicos")
                lista = datos.Tables("medicos").Rows.Count
                If lista <> 0 Then
                    MsgBox("Este usuario ya existe en la base de datos. ", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    'MostrarDatos()

                Else
                    Dim entrada As String = "INSERT INTO medicos(idmedico, nombreMedico, fechanacMedico, generoMedico, telefonoMedico, correoMedico, EspecialidadMedico, fecharegMedico, contraseñaMedico, nuevacontraseMedico) VALUES('" + txt_Nomusuario.Text + "' , '" + txt_Nombre.Text.ToLower + "' , '" + txt_Fechanacmedico.Text.ToLower + "' , '" + txt_Genero.Text.ToLower + "' , '" + txt_Telefono.Text.ToLower + "', '" + txt_Correo.Text.ToLower + "' , '" + txt_Especialidad.Text.ToLower + "' , '" + txt_Fechareg.Text.ToLower + "', '" + txt_Contrase.Text.ToLower + "', '" + txt_Nuevacont.Text.ToLower + "')"
                    Dim DT As New DataTable
                    Dim adaptador As New MySqlDataAdapter(entrada, conexion)
                    adaptador.Fill(DT)
                    conexion.Close()
                    MsgBox("Insertado correctamente", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    'MostrarDatos()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conexion.Dispose()
            End Try

        End If
    End Sub
#End Region

#Region "Botón editar"
    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btn_Editar.Click
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        If (txt_Nomusuario.Text = "") Or (txt_Contrase.Text = "") Or (txt_Nuevacont.Text = "") Or (txt_Nombre.Text = "") Or (txt_Fechanacmedico.Text = "") Or (txt_Genero.Text = "") Or (txt_Correo.Text = "") Or (txt_Telefono.Text = "") Or (txt_Especialidad.Text = "") Or (txt_Fechareg.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim comando As New MySqlCommand("UPDATE medicos SET idmedico='" & txt_Nomusuario.Text.ToLower & "', contraseñaMedico='" & txt_Fechanacmedico.Text.ToLower & "', nuevacontraseMedico='" & txt_Genero.Text & "', nombreMedico='" & txt_Nombre.Text & "'  WHERE idmedico=" & Conversion.Int(txt_Nomusuario.Text) & "", conexion)
                comando.ExecuteNonQuery()
                MsgBox("Los datos se han actualizado exitosamente ", MsgBoxStyle.Information, "Confirmar")
                BorrarCampos()
                'MostrarDatos()
                btn_Registrar.Enabled = True
                If conexion.State = ConnectionState.Open Then
                    conexion.Close()
                End If
            Catch ex As Exception
                MsgBox("Error" + ex.ToString)
                Me.Close()
            End Try

        End If
    End Sub
#End Region

#Region "Limpiar Campos"
    Public Sub BorrarCampos()
        txt_Nomusuario.Text = ""
        txt_Contrase.Text = ""
        txt_Nuevacont.Text = ""
        txt_Nombre.Text = ""
        txt_Fechanacmedico.Text = ""
        txt_Genero.Text = ""
        txt_Correo.Text = ""
        txt_Telefono.Text = ""
        txt_Especialidad.Text = ""
        txt_Fechareg.Text = ""
    End Sub
#End Region


End Class