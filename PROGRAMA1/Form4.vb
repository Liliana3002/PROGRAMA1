#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region
Public Class Form4
#Region "Variables"
    Private cmb As MySqlCommandBuilder
    Dim conexion As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte
    Private Sub btnPacientes_Click(sender As Object, e As EventArgs)
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
            consulta = "SELECT* FROM agendas"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "agendas")
            dgv_Agendas.DataSource = datos
            dgv_Agendas.DataMember = "agendas"


        Catch ex As Exception
            MsgBox("Desconectado" + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
#End Region

#Region "Agregar Datos"
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        If (txt_Numagenda.Text = "") Or (txt_FkidPac.Text = "") Or (txt_FkidMed.Text = "") Or (txt_Estatus.Text = "") Or (txt_Motivo.Text = "") Or (txt_Fecha.Text = "") Or (txt_Hora.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta1 As String = "SELECT * FROM agendas WHERE idAgenda = '" & txt_Numagenda.Text & "'"
                Dim adaptador1 As New MySqlDataAdapter(consulta1, conexion)
                Dim datos As New DataSet
                adaptador1.Fill(datos, "agendas")
                lista = datos.Tables("agendas").Rows.Count
                If lista <> 0 Then
                    MsgBox("Esta agenda que intenta agregar ya existe en la base de datos. ", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()

                Else
                    Dim entrada As String = "INSERT INTO agendas(idAgenda, fkidpacAgenda, fkidMedAgenda, estatusAgenda, motivoAgenda, fechaAgenda, horaAgenda) VALUES('" + txt_Numagenda.Text + "' , '" + txt_FkidPac.Text.ToLower + "' , '" + txt_FkidMed.Text.ToLower + "' , '" + txt_Estatus.Text.ToLower + "','" + txt_Motivo.Text + "','" + txt_Fecha.Text + "', '" + txt_Hora.Text + "')"
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
        If (txt_Numagenda.Text = "") Or (txt_FkidPac.Text = "") Or (txt_FkidMed.Text = "") Or (txt_Estatus.Text = "") Or (txt_Motivo.Text = "") Or (txt_Fecha.Text = "") Or (txt_Hora.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim comando As New MySqlCommand("UPDATE agendas SET fkidpacAgenda='" & txt_FkidPac.Text.ToLower & "', fkidMedAgenda='" & txt_FkidMed.Text.ToLower & "', estatusAgenda='" & txt_Estatus.Text & "', motivoAgenda='" & txt_Motivo.Text & "', fechaAgenda='" & txt_Fecha.Text.ToLower & "', horaAgenda='" & txt_Hora.Text.ToLower & "' WHERE idAgenda=" & Conversion.Int(txt_Numagenda.Text) & "", conexion)
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
        consulta("SELECT * FROM agendas", "agendas")
        dgv_Agendas.DataSource = datos.Tables("agendas")

    End Sub
#End Region

#Region "Datos hacia campos"
    Private Sub dgv_Agendas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Agendas.CellClick
        Try
            Dim i As Integer = dgv_Agendas.CurrentRow.Index
            txt_Numagenda.Text = dgv_Agendas(0, i).Value
            txt_FkidPac.Text = dgv_Agendas(1, i).Value
            txt_FkidMed.Text = dgv_Agendas(2, i).Value
            txt_Estatus.Text = dgv_Agendas(3, i).Value
            txt_Motivo.Text = dgv_Agendas(4, i).Value
            txt_Fecha.Text = dgv_Agendas(5, i).Value
            txt_Hora.Text = dgv_Agendas(6, i).Value
            txt_Numagenda.Enabled = False
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
        If (txt_Numagenda.Text = "") Or (txt_FkidPac.Text = "") Or (txt_FkidMed.Text = "") Or (txt_Estatus.Text = "") Or (txt_Motivo.Text = "") Or (txt_Fecha.Text = "") Or (txt_Hora.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("DELETE FROM agendas WHERE idAgenda =" & Conversion.Int(txt_Numagenda.Text) & "", conexion)
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

#Region "Busqueda Agenda"
    Private Sub txt_Busqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscaragenda.TextChanged
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Dim entrada As String = "SELECT * FROM agendas WHERE idAgenda LIKE '" & txt_Buscaragenda.Text + "%" & "'"
            Dim adaptador As New MySqlDataAdapter(entrada, conexion)
            datos = New DataSet
            adaptador.Fill(datos)
            dgv_Agendas.DataSource = datos.Tables(0)

        Catch ex As Exception
            MsgBox("No se ha podido buscar")

        End Try
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub

#End Region

#Region "Bloquear letras"
    Private Sub txt_Numagenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Numagenda.KeyPress
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

    Private Sub txt_Busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Buscaragenda.KeyPress
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
        txt_Numagenda.Enabled = True
        btn_Registrar.Enabled = True
    End Sub
#End Region

#Region "Limpiar Campos"
    Public Sub BorrarCampos()
        txt_Numagenda.Text = ""
        txt_FkidPac.Text = ""
        txt_FkidMed.Text = ""
        txt_Estatus.Text = ""
        txt_Motivo.Text = ""
        txt_Fecha.Text = ""
        txt_Hora.Text = ""
    End Sub
#End Region

End Class