#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region
Public Class Form7

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
            consulta = "SELECT* FROM examenes"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "examenes")
            dgv_Examenes.DataSource = datos
            dgv_Examenes.DataMember = "examenes"


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
        If (txt_Codigo.Text = "") Or (txt_Nombre.Text = "") Or (txt_Indica.Text = "") Or (txt_Fecha.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta1 As String = "SELECT * FROM pacientes WHERE idPaciente = '" & txt_Codigo.Text & "'"
                Dim adaptador1 As New MySqlDataAdapter(consulta1, conexion)
                Dim datos As New DataSet
                adaptador1.Fill(datos, "examenes")
                lista = datos.Tables("examenes").Rows.Count
                If lista <> 0 Then
                    MsgBox("Este éxamen que intenta agregar ya existe en la base de datos. ", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()

                Else
                    Dim entrada As String = "INSERT INTO examenes(idExamen, nombreExamen, indicacionesExamen, fechaExamen) VALUES('" + txt_Codigo.Text + "' , '" + txt_Nombre.Text.ToLower + "' , '" + txt_Indica.Text.ToLower + "' , '" + txt_Fecha.Text.ToLower + "')"
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
        If (txt_Codigo.Text = "") Or (txt_Nombre.Text = "") Or (txt_Indica.Text = "") Or (txt_Fecha.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim comando As New MySqlCommand("UPDATE examenes SET nombreExamen='" & txt_Nombre.Text.ToLower & "', indicacionesExamen='" & txt_Indica.Text.ToLower & "', fechaExamen='" & txt_Fecha.Text & "' WHERE idExamen=" & Conversion.Int(txt_Codigo.Text) & "", conexion)
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
        consulta("SELECT * FROM examenes", "examenes")
        dgv_Examenes.DataSource = datos.Tables("examenes")

    End Sub
#End Region

#Region "Datos hacia campos"
    Private Sub dgv_Examenes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Examenes.CellClick
        Try
            Dim i As Integer = dgv_Examenes.CurrentRow.Index
            txt_Codigo.Text = dgv_Examenes(0, i).Value
            txt_Nombre.Text = dgv_Examenes(1, i).Value
            txt_Indica.Text = dgv_Examenes(2, i).Value
            txt_Fecha.Text = dgv_Examenes(3, i).Value
            txt_Codigo.Enabled = False
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
        If (txt_Codigo.Text = "") Or (txt_Nombre.Text = "") Or (txt_Indica.Text = "") Or (txt_Fecha.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("DELETE FROM examenes WHERE idExamen =" & Conversion.Int(txt_Codigo.Text) & "", conexion)
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

#Region "Busqueda Examenes"
    Private Sub txt_BuscarEx_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarEx.TextChanged
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Dim entrada As String = "SELECT * FROM examenes WHERE idExamen LIKE '" & txt_BuscarEx.Text + "%" & "'"
            Dim adaptador As New MySqlDataAdapter(entrada, conexion)
            datos = New DataSet
            adaptador.Fill(datos)
            dgv_Examenes.DataSource = datos.Tables(0)

        Catch ex As Exception
            MsgBox("No se ha podido buscar")

        End Try
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
#End Region

#Region "Bloquear letras"
    Private Sub txt_Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Codigo.KeyPress
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

    Private Sub txt_BuscarEx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscarEx.KeyPress
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
        txt_Codigo.Enabled = True
        btn_Registrar.Enabled = True
    End Sub
#End Region

#Region "Limpiar Campos"
    Public Sub BorrarCampos()
        txt_Codigo.Text = ""
        txt_Nombre.Text = ""
        txt_Indica.Text = ""
        txt_Fecha.Text = ""
    End Sub
#End Region

End Class