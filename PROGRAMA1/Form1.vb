#Region "Importanciones"
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
#End Region

Public Class Form1

#Region "Conexion Base de Datos"
    Dim conexion As New MySqlConnection
    Public Sub Conectar()
        Try
            conexion.ConnectionString = "server=localhost;user=root;password=root;port=3306;database=hospital;sslmode=none"
            conexion.Open()
            Dim consulta As String
            consulta = "SELECT* FROM usuarios"


        Catch ex As Exception
            MsgBox("Desconectado" + ex.ToString)
        End Try
    End Sub

    Private Sub Form1_Load(Sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
    Private Sub btn_Ingresar_Click(sender As Object, e As EventArgs) Handles btn_Ingresar.Click
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
            End If
            Dim query As String = String.Empty
            query = "SELECT *FROM medicos WHERE idmedico='" & txt_Usuario.Text & "' AND contraseñaMedico='" & txt_Contraseña.Text & "'"
            Dim mysqlcommand As MySqlCommand
            mysqlcommand = New MySqlCommand(query, conexion)
            Dim tabla As MySqlDataReader
            tabla = mysqlcommand.ExecuteReader
            Dim cantidad As Integer = 0
            While tabla.Read
                cantidad += 1
            End While

            If cantidad = 1 Then
                MsgBox("INGRESO EXITOSO")
                Me.Hide()
                Form2.Show()
            ElseIf cantidad < 1 Then
                MsgBox("Este usuario no existe en el sistema")
            ElseIf txt_Usuario.Text = "" Or txt_Contraseña.Text = "" Then
                MsgBox("Los campos no pueden estar vacíos")
            Else
                MsgBox("usuario o contraseña incorrectos")
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

        If CheckBox1.Checked = True Then

            If txt_Contraseña.PasswordChar = "*" Then
                txt_Contraseña.PasswordChar = ""
            Else
                txt_Contraseña.PasswordChar = "*"
            End If
        End If
    End Sub
#End Region

End Class
