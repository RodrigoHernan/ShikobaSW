Imports ShikobaSW.Biz.BIZ.Entities

Public Class TurnosdelCliente
    Dim Cliente As New Cliente


    Private Sub btnbuscarCliente_Click(sender As Object, e As EventArgs) Handles btnbuscarCliente.Click
        Dim gestorCliente As New Usuario.BLL.GestionCliente
        Cliente = gestorCliente.BuscarCliente(TxtDNiCliente.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GestorTurno As New Usuario.BLL.GestorTurno
        Dim turnos As New List(Of Turno)

        If RadioDiaDeLafecha.Checked = True Then
            turnos = GestorTurno.TraerTurnosClientefechaActual(Date.Now, Cliente)
        End If
        If RadioFechasfuturas.Checked = True Then
            turnos = GestorTurno.TraerTurnosClientefechaFutura(Cliente)
        End If
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = turnos

    End Sub

End Class