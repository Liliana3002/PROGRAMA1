Public Class Form2
#Region "Botones ir al formulario correspondiente"
    Private Sub btn_Menu_Click(sender As Object, e As EventArgs) 
        Dim f2 As New Form2
        f2.Show()
        Me.Hide()
    End Sub
    Private Sub btn_Paciente_Click(sender As Object, e As EventArgs) Handles btn_Paciente.Click
        Dim f3 As New Form3
        f3.Show()
        Me.Hide()
    End Sub
    Private Sub btn_Agendas_Click(sender As Object, e As EventArgs) Handles btn_Agendas.Click
        Dim f4 As New Form4
        f4.Show()
        Me.Hide()
    End Sub
    Private Sub btn_Consultas_Click(sender As Object, e As EventArgs) Handles btn_Consultas.Click
        Dim f5 As New Form5
        f5.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Medicamentos_Click(sender As Object, e As EventArgs) Handles btn_Medicamentos.Click
        Dim f6 As New Form6
        f6.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Examenes_Click(sender As Object, e As EventArgs) Handles btn_Examenes.Click
        Dim f7 As New Form7
        f7.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Hc_Click(sender As Object, e As EventArgs) Handles btn_Hc.Click
        Dim f8 As New Form8
        f8.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Sistema_Click(sender As Object, e As EventArgs) Handles btn_Sistema.Click
        Dim f9 As New Form9
        f9.Show()
        Me.Hide()
    End Sub
#End Region

End Class