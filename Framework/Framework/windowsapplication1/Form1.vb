Imports Ramos.Framework.Funciones.Cadenas
Imports Ramos.Framework.Funciones.matematicas
Imports Ramos.Framework.Funciones.fecha



Public Class Form1

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        MsgBox(Reemplazar("hola mundo carapachinchin chi chin chiiiiin ", "mundo", "genio"))

        'arrange
        Dim unaLista As New List(Of String)
        unaLista.Add("Hola mundo para reemplazar")
        unaLista.Add("Hola mundo para reemplazar2")
        unaLista.Add("Hola mundo para reemplazar3")
        'act
        Dim actual = Reemplazar(unaLista, "mundo", "cambio")
        MsgBox(unaLista(0))
        MsgBox(unaLista(1))
        MsgBox(unaLista(2))

    End Sub
    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        MsgBox(Hoy)
        MsgBox(Ahora)
    End Sub
End Class
