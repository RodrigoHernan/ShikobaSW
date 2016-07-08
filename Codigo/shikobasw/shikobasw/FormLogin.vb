Imports ShikobaSW.Biz.BIZ.Entities
Imports ShikobaSW.Usuario

Public Class FormLogin
    Dim unProfesional As New Profesional
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        unProfesional.email = TextValidaEmail1.Texto
        unProfesional.contraseña = TextValidaCaracterNulo1.Texto

        Dim GestorProfesional As New BLL.GestorProfesional
        GestorProfesional.VerificarProfesiona(unProfesional)
        FormProfesionales.unprofesional = unProfesional
        Me.Close()
    End Sub
End Class