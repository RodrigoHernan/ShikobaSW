Imports System.Windows.Forms

Public Class TextValidaCaracterNulo

    Public Event Caracternulo()

    Public Property Texto() As String
        Get
            Return TextBox1.Text
        End Get
        Set(ByVal value As String)
            TextBox1.Text = value
        End Set
    End Property

    Private Sub TextboxSoloNumero_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize

        TextBox1.Width = Me.Width
        Me.Height = TextBox1.Height

    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TextBox1.TextChanged
        If ValidarCaracter() Then
            RaiseEvent Caracternulo()
        End If
    End Sub


    Private Sub TextValidaCaracterNulo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ValidarCaracter()
    End Sub

    Private Function ValidarCaracter() As Boolean
        If TextBox1.Text = Nothing Then
            TextBox1.BackColor = Drawing.Color.Red
            Return True
        Else
            TextBox1.BackColor = Drawing.Color.White
            Return False
        End If
    End Function

End Class
