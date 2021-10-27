#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region
Public Class Form8

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
            consulta = "SELECT* FROM historias_clinicas"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "historias_clinicas")
            dgv_Hc.DataSource = datos
            dgv_Hc.DataMember = "historias_clinicas"

        Catch ex As Exception
            MsgBox("Desconectado" + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
#End Region

#Region "Agregar Datos"
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        If (txt_Idhc.Text = "") Or (txt_Fkidpachc.Text = "") Or (txt_Fkidconsulhc.Text = "") Or (txt_Fecha.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta1 As String = "SELECT * FROM historias_clinicas WHERE idhc = '" & txt_Idhc.Text & "'"
                Dim adaptador1 As New MySqlDataAdapter(consulta1, conexion)
                Dim datos As New DataSet
                adaptador1.Fill(datos, "historias_clinicas")
                lista = datos.Tables("historias_clinicas").Rows.Count
                If lista <> 0 Then
                    MsgBox("Esta historia clínica que intenta agregar ya existe en la base de datos. ", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()

                Else
                    Dim entrada As String = "INSERT INTO historias_clinicas(idhc, fkidPachc, fkidConsulhc, fechaHc) VALUES('" + txt_Idhc.Text + "' , '" + txt_Fkidpachc.Text.ToLower + "' , '" + txt_Fkidconsulhc.Text.ToLower + "' , '" + txt_Fecha.Text.ToLower + "')"
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
        If (txt_Idhc.Text = "") Or (txt_Idhc.Text = "") Or (txt_Fkidpachc.Text = "") Or (txt_Fkidconsulhc.Text = "") Or (txt_Fecha.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim comando As New MySqlCommand("UPDATE historias_clinicas SET fkidPachc='" & txt_Fkidpachc.Text.ToLower & "', fkidConsulhc='" & txt_Fkidconsulhc.Text.ToLower & "', fechaHc='" & txt_Fecha.Text & "' WHERE idhc=" & Conversion.Int(txt_Idhc.Text) & "", conexion)
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
        consulta("SELECT * FROM historias_clinicas", "historias_clinicas")
        dgv_Hc.DataSource = datos.Tables("historias_clinicas")

    End Sub
#End Region

#Region "Datos hacia campos"
    Private Sub dgv_Hc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Hc.CellClick
        Try
            Dim i As Integer = dgv_Hc.CurrentRow.Index
            txt_Idhc.Text = dgv_Hc(0, i).Value
            txt_Fkidpachc.Text = dgv_Hc(1, i).Value
            txt_Fkidconsulhc.Text = dgv_Hc(2, i).Value
            txt_Fecha.Text = dgv_Hc(3, i).Value
            txt_Idhc.Enabled = False
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
        If (txt_Idhc.Text = "") Or (txt_Fkidpachc.Text = "") Or (txt_Fecha.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("DELETE FROM historias_clinicas WHERE idhc=" & Conversion.Int(txt_Idhc.Text) & "", conexion)
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

#Region "Busqueda de Historia Clínica"
    Private Sub txt_BuscarHc_TextChanged(sender As Object, e As EventArgs) Handles txt_BuscarHc.TextChanged
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Dim entrada As String = "SELECT * FROM idhc WHERE idhc LIKE '" & txt_BuscarHc.Text + "%" & "'"
            Dim adaptador As New MySqlDataAdapter(entrada, conexion)
            datos = New DataSet
            adaptador.Fill(datos)
            dgv_Hc.DataSource = datos.Tables(0)

        Catch ex As Exception
            MsgBox("No se ha podido buscar")

        End Try
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
#End Region

#Region "Bloquear letras"
    Private Sub txt_Idhc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Idhc.KeyPress
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

    Private Sub txt_BuscarHc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_BuscarHc.KeyPress
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
        txt_Idhc.Enabled = True
        btn_Registrar.Enabled = True
    End Sub
#End Region

#Region "Limpiar Campos"
    Public Sub BorrarCampos()
        txt_Idhc.Text = ""
        txt_Fkidpachc.Text = ""
        txt_Fkidconsulhc.Text = ""
        txt_Fecha.Text = ""
    End Sub

#End Region

End Class