#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region

Public Class Form5

#Region "Variables"
    Private cmb As MySqlCommandBuilder
    Dim conexion As New MySqlConnection
    Dim datos As New DataSet
    Dim adaptador As New MySqlDataAdapter
    Dim lista As Byte
    Private Sub btn_Consultas_Click(sender As Object, e As EventArgs)
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
            consulta = "SELECT* FROM consultas"
            adaptador = New MySqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "consultas")
            dgv_Consultas.DataSource = datos
            dgv_Consultas.DataMember = "consultas"


        Catch ex As Exception
            MsgBox("Desconectado" + ex.ToString)
        End Try
    End Sub
#End Region

#Region "Load"
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
#End Region

#Region "Agregar Datos"
    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        If (txt_idconsul.Text = "") Or (txt_Fkidpacconsul.Text = "") Or (txt_Fkidmedconsul.Text = "") Or (txt_Fkidagendaconsul.Text = "") Or (txt_FkidExconsul.Text = "") Or (txt_FkidMedicaconsul.Text = "") Or (txt_Altura.Text = "") Or (txt_Peso.Text = "") Or (txt_Imc.Text = "") Or (txt_Freresp.Text = "") Or (txt_Presion.Text = "") Or (txt_Antec.Text = "") Or (txt_Explo.Text = "") Or (txt_Motivo.Text = "") Or (txt_Dx.Text = "") Or (txt_Indica.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim consulta1 As String = "SELECT * FROM consultas WHERE idConsulta = '" & txt_idconsul.Text & "'"
                Dim adaptador1 As New MySqlDataAdapter(consulta1, conexion)
                Dim datos As New DataSet
                adaptador1.Fill(datos, "consultas")
                lista = datos.Tables("consultas").Rows.Count

                If lista <> 0 Then
                    MsgBox("Esta consulta que intenta agregar ya existe en la base de datos. ", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()

                Else
                    Dim entrada As String = "INSERT INTO consultas(idConsulta, fkidPacConsulta, fkidMedConsulta, fkidAgendaConsulta, fkidExconsul, fkidMedicaConsul, alturaConsulta, pesoConsulta, imcConsulta, frecrespiConsulta, presionarteConsulta, antecedentesConsulta, explofisicaConsulta, motivoConsulta, dxConsulta, indicacionesConsulta) VALUES('" + txt_idconsul.Text + "' , '" + txt_Fkidpacconsul.Text.ToLower + "' , '" + txt_Fkidmedconsul.Text.ToLower + "' , '" + txt_Fkidagendaconsul.Text.ToLower + "','" + txt_FkidExconsul.Text.ToLower + "','" + txt_FkidMedicaconsul.Text.ToLower + "','" + txt_Altura.Text + "','" + txt_Peso.Text + "', '" + txt_Imc.Text + "', '" + txt_Freresp.Text + "', '" + txt_Presion.Text + "', '" + txt_Antec.Text + "', '" + txt_Explo.Text + "', '" + txt_Motivo.Text + "', '" + txt_Dx.Text + "', '" + txt_Indica.Text + "')"
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
        If (txt_idconsul.Text = "") Or (txt_Fkidpacconsul.Text = "") Or (txt_Fkidmedconsul.Text = "") Or (txt_Fkidagendaconsul.Text = "") Or (txt_FkidExconsul.Text = "") Or (txt_FkidMedicaconsul.Text = "") Or (txt_Altura.Text = "") Or (txt_Peso.Text = "") Or (txt_Imc.Text = "") Or (txt_Freresp.Text = "") Or (txt_Presion.Text = "") Or (txt_Antec.Text = "") Or (txt_Explo.Text = "") Or (txt_Motivo.Text = "") Or (txt_Dx.Text = "") Or (txt_Indica.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Try
                Dim comando As New MySqlCommand("UPDATE consultas SET fkidPacConsulta='" & txt_Fkidpacconsul.Text.ToLower & "', fkidMedConsulta='" & txt_Fkidmedconsul.Text.ToLower & "', fkidAgendaConsulta='" & txt_Fkidagendaconsul.Text & "', fkidExConsul='" & txt_FkidExconsul.Text & "', fkidMedicaconsul='" & txt_FkidMedicaconsul.Text & "', alturaConsulta='" & txt_Altura.Text & "', pesoConsulta='" & txt_Peso.Text.ToLower & "', imcConsulta='" & txt_Imc.Text.ToLower & "', , frecrespiConsulta='" & txt_Freresp.Text.ToLower & "', presionarteConsulta='" & txt_Presion.Text.ToLower & "', antecedentesConsulta='" & txt_Antec.Text.ToLower & "', explofisicaConsulta='" & txt_Explo.Text.ToLower & "', motivoConsulta='" & txt_Motivo.Text.ToLower & "', dxConsulta='" & txt_Dx.Text.ToLower & "', indicacionesConsulta='" & txt_Indica.Text.ToLower & "' WHERE idConsulta=" & Conversion.Int(txt_idconsul.Text) & "", conexion)
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
        consulta("SELECT * FROM consultas", "consultas")

    End Sub
#End Region

#Region "Datos hacia campos"
    Private Sub dgv_Consultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Consultas.CellClick
        Try
            Dim i As Integer = dgv_Consultas.CurrentRow.Index
            txt_idconsul.Text = dgv_Consultas(0, i).Value
            txt_Fkidpacconsul.Text = dgv_Consultas(1, i).Value
            txt_Fkidmedconsul.Text = dgv_Consultas(2, i).Value
            txt_Fkidagendaconsul.Text = dgv_Consultas(3, i).Value
            txt_FkidExconsul.Text = dgv_Consultas(4, i).Value
            txt_FkidMedicaconsul.Text = dgv_Consultas(5, i).Value
            txt_Altura.Text = dgv_Consultas(6, i).Value
            txt_Peso.Text = dgv_Consultas(7, i).Value
            txt_Imc.Text = dgv_Consultas(8, i).Value
            txt_Freresp.Text = dgv_Consultas(9, i).Value
            txt_Presion.Text = dgv_Consultas(10, i).Value
            txt_Antec.Text = dgv_Consultas(11, i).Value
            txt_Explo.Text = dgv_Consultas(12, i).Value
            txt_Motivo.Text = dgv_Consultas(13, i).Value
            txt_Dx.Text = dgv_Consultas(14, i).Value
            txt_Indica.Text = dgv_Consultas(15, i).Value
            txt_idconsul.Enabled = False
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
        If (txt_idconsul.Text = "") Or (txt_Fkidpacconsul.Text = "") Or (txt_Fkidmedconsul.Text = "") Or (txt_Fkidagendaconsul.Text = "") Or (txt_FkidExconsul.Text = "") Or (txt_FkidMedicaconsul.Text = "") Or (txt_Altura.Text = "") Or (txt_Peso.Text = "") Or (txt_Imc.Text = "") Or (txt_Freresp.Text = "") Or (txt_Presion.Text = "") Or (txt_Antec.Text = "") Or (txt_Explo.Text = "") Or (txt_Motivo.Text = "") Or (txt_Dx.Text = "") Or (txt_Indica.Text = "") Then
            MsgBox("Los campos no pueden estar vacios ", MsgBoxStyle.Information, "Confirmar")
        Else
            Dim comando As New MySqlCommand("DELETE FROM consultas WHERE idconsul =" & Conversion.Int(txt_idconsul.Text) & "", conexion)
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

#Region "Busqueda Consulta"
    Private Sub txt_Busqueda_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscarconsul.TextChanged
        If conexion.State = ConnectionState.Closed Then
            conexion.Open()
        End If
        Try
            Dim entrada As String = "SELECT * FROM consultas WHERE idConsulta LIKE '" & txt_Buscarconsul.Text + "%" & "'"
            Dim adaptador As New MySqlDataAdapter(entrada, conexion)
            datos = New DataSet
            adaptador.Fill(datos)
            dgv_Consultas.DataSource = datos.Tables(0)

        Catch ex As Exception
            MsgBox("No se ha podido buscar")

        End Try
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
#End Region

#Region "Bloquear letras"
    Private Sub txt_idconsul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_idconsul.KeyPress
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

    Private Sub txt_Busqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Buscarconsul.KeyPress
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
        txt_idconsul.Enabled = True
        btn_Registrar.Enabled = True
    End Sub
#End Region

#Region "Limpiar Campos"
    Public Sub BorrarCampos()
        txt_idconsul.Text = ""
        txt_Fkidpacconsul.Text = ""
        txt_Fkidmedconsul.Text = ""
        txt_Fkidagendaconsul.Text = ""
        txt_FkidExconsul.Text = ""
        txt_FkidMedicaconsul.Text = ""
        txt_Altura.Text = ""
        txt_Peso.Text = ""
        txt_Imc.Text = ""
        txt_Freresp.Text = ""
        txt_Presion.Text = ""
        txt_Antec.Text = ""
        txt_Explo.Text = ""
        txt_Motivo.Text = ""
        txt_Dx.Text = ""
        txt_Indica.Text = ""
    End Sub
#End Region

End Class