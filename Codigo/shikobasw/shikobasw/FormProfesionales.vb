Imports ShikobaSW.Biz.BIZ.Entities
Imports ShikobaSW.Usuario.BLL

Public Class FormProfesionales
    Public unProfesional As New Profesional
    Private Sub FormProfesionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLogin.ShowDialog()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Gestorprofesional As New GestorProfesional
        Gestorprofesional.BuscarTurnosdiadelaFecha(unProfesional, unProfesional.Servicio, Date.Today)
        ' se genera la lista de informacion y se carga en la grilla 

    End Sub

    Private Sub BtnCargarComentarios_Click(sender As Object, e As EventArgs) Handles BtnCargarComentarios.Click
        Dim comentario As String = ""
        Dim turno As New Turno
        ' se hace un imput y se cargan los comentarios 
        turno.Comentarios = comentario
        GestorTurno.GuardarComentarios(turno)
    End Sub
End Class