#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region

Public Class Form3

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
            consulta = "SELECT* FROM pacientes"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "pacientes")
            dgv_Pacientes.DataSource = datos
            dgv_Pacientes.DataMember = "pacientes"


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
        If (txt_IdPac.Text = "") Or (txt_Nombre.Text = "") Or (txt_Apellido.Text = "") Or (txt_Fechanac.Text = "") Or (txt_Genero.Text = "") Or (txt_Correo.Text = "") Or (txt_Telef.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta1 As String = "SELECT * FROM pacientes WHERE idPaciente = '" & txt_IdPac.Text & "'"
                Dim adaptador1 As New MySqlDataAdapter(consulta1, conexion)
                Dim datos As New DataSet
                adaptador1.Fill(datos, "pacientes")
                lista = datos.Tables("pacientes").Rows.Count
                If lista <> 0 Then
                    MsgBox("Este paciente que intenta agregar ya existe en la base de datos. ", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()

                Else
                    Dim entrada As String = "INSERT INTO pacientes(idPaciente, nombrePac, apellidosPac, fechanacPac, generoPac, correoPac, telefPac) VALUES('" + txt_IdPac.Text + "' , '" + txt_Nombre.Text.ToLower + "' , '" + txt_Apellido.Text.ToLower + "' , '" + txt_Fechanac.Text.ToLower + "','" + txt_Genero.Text + "','" + txt_Correo.Text + "', '" + txt_Telef.Text + "')"
                    Dim DT As New DataTable
                    Dim adaptador As New MySqlDataAdapter(entrada, conexion)
                    adaptador.Fill(DT)
                    conexion.Close()
                    MsgBox("Insertado correctamente", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()
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
        If (txt_IdPac.Text = "") Or (txt_Nombre.Text = "") Or (txt_Apellido.Text = "") Or (txt_Fechanac.Text = "") Or (txt_Genero.Text = "") Or (txt_Correo.Text = "") Or (txt_Telef.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim comando As New MySqlCommand("UPDATE pacientes SET nombrePac='" & txt_Nombre.Text.ToLower & "', apellidosPac='" & txt_Apellido.Text.ToLower & "', fechanacPac='" & txt_Fechanac.Text & "', generoPac='" & txt_Genero.Text & "', correoPac='" & txt_Correo.Text.ToLower & "', telefPac='" & txt_Telef.Text.ToLower & "' WHERE idPaciente=" & Conversion.Int(txt_IdPac.Text) & "", conexion)
                comando.ExecuteNonQuery()
                MsgBox("Los datos se han actualizado exitosamente ", MsgBoxStyle.Information, "Confirmar")
                BorrarCampos()
                MostrarDatos()
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

#Region "DataGriedView"
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        datos.Tables.Clear()
        adaptador = New MySqlDataAdapter(sql, conexion)
        cmb = New MySqlCommandBuilder(adaptador)
        adaptador.Fill(datos, tabla)
    End Sub
    Public Sub MostrarDatos()
        consulta("SELECT * FROM pacientes", "pacientes")
        dgv_Pacientes.DataSource = datos.Tables("pacientes")

    End Sub
#End Region

#Region "Datos hacia campos"
    Private Sub dgv_Pacientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Pacientes.CellClick
        Try
            Dim i As Integer = dgv_Pacientes.CurrentRow.Index
            txt_IdPac.Text = dgv_Pacientes(0, i).Value
            txt_Nombre.Text = dgv_Pacientes(1, i).Value
            txt_Apellido.Text = dgv_Pacientes(2, i).Value
            txt_Fechanac.Text = dgv_Pacientes(3, i).Value
            txt_Genero.Text = dgv_Pacientes(4, i).Value
            txt_Correo.Text = dgv_Pacientes(5, i).Value
            txt_Telef.Text = dgv_Pacientes(6, i).Value
            txt_IdPac.Enabled = False
            btn_Registrar.Enabled = False
        Catch ex As Exception
            MsgBox("Estos datos no se permiten modificar")
        End Try
    End Sub
#End Region

#Region "Eliminar datos"
    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        If (txt_IdPac.Text = "") Or (txt_Nombre.Text = "") Or (txt_Apellido.Text = "") Or (txt_Fechanac.Text = "") Or (txt_Genero.Text = "") Or (txt_Correo.Text = "") Or (txt_Telef.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("DELETE FROM pacientes WHERE idPaciente =" & Conversion.Int(txt_IdPac.Text) & "", conexion)
            comando.ExecuteNonQuery()
            MsgBox("Los datos se han eliminado exitosamente")
            BorrarCampos()
            MostrarDatos()
            btn_Registrar.Enabled = True
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End If
    End Sub
#End Region

#Region "Busqueda Paciente"
    Private Sub txt_Busqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarPac.TextChanged
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Dim entrada As String = "SELECT * FROM pacientes WHERE idPaciente LIKE '" & txt_BuscarPac.Text + "%" & "'"
            Dim adaptador As New MySqlDataAdapter(entrada, conexion)
            datos = New DataSet
            adaptador.Fill(datos)
            dgv_Pacientes.DataSource = datos.Tables(0)

        Catch ex As Exception
            MsgBox("No se ha podido buscar")

        End Try
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
#End Region

#Region "Bloquear letras"
    Private Sub txt_Identificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_IdPac.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscarPac.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btn_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_Nuevo.Click
        BorrarCampos()
        txt_IdPac.Enabled = True
        btn_Registrar.Enabled = True
    End Sub
#End Region

#Region "Limpiar Campos"
    Public Sub BorrarCampos()
        txt_IdPac.Text = ""
        txt_Nombre.Text = ""
        txt_Apellido.Text = ""
        txt_Fechanac.Text = ""
        txt_Genero.Text = ""
        txt_Correo.Text = ""
        txt_Telef.Text = ""
    End Sub
#End Region

End Class