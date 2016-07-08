Imports ShikobaSW.Biz.BIZ.Entities
Imports ShikobaSW
Imports ShikobaSW.Usuario
Imports ShikobaSW.Biz.BIZ.exceptions


Public Class Agregar_Turno
    Public unCliente As New Biz.BIZ.Entities.Cliente
    Private Sub BtnBuscarDNI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnBuscarDNI.Click

        Dim GestorCliente As New Usuario.BLL.GestionCliente
        unCliente = GestorCliente.BuscarCliente(TextDNI.Text)

        LblDomicilio.Text = unCliente.domicilio
        LblNumero.Text = unCliente.NumeroTelefono
        lblNombreyApellido.Text = unCliente.Nombre & " " & unCliente.Apellido
        LblOsoPrePa.Text = unCliente.unOsPrePa.Nombre

        Dim unServicio As New Servicio
        Dim DALServicio As New DAL.DAL.Servicio

        ComboServicios.DataSource = DALServicio.TraerTodos()
        ComboServicios.DisplayMember = "Nombre"

    End Sub


    Private Sub BuscarTurnos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BuscarTurnos.Click
        ' el Recepcionista ingresa una fecha elegida 
        Dim GestorTurno As New BLL.GestorTurno
        Dim Fecha As Date = Calendario1.Value

        Try


            ComboTurnosDisponibles.DataSource = GestorTurno.TraerTurnosFecha(Fecha, unCliente.IdOsoPrePa, ComboServicios.SelectedItem)
            ComboTurnosDisponibles.DisplayMember = "HorarioEntrada"
            ComboTurnosDisponibles.Visible = True

        Catch ex As Biz.BIZ.exceptions.ExceptionNoHayTurnosDisponibles
            MsgBox("no hay turnos disponibles para la fecha solicitada")
        Catch ex As Biz.BIZ.exceptions.ExFechaInvalida
            MsgBox("seleccione una fecha valida")
        End Try

    End Sub

    Private Sub BtnRegistrarTurno_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRegistrarTurno.Click
        Dim GestorTurno As New BLL.GestorTurno
        Dim unTurno As New Biz.BIZ.Entities.Turno
        unTurno = ComboTurnosDisponibles.SelectedItem
        unTurno.Dia = Calendario1.Value
        unTurno.IdCliente = unCliente.DNI
        unTurno.Estado = 1
        unTurno.EsSobreturno = txtEsSobreturno.Checked

        Try
            GestorTurno.Guardar(unTurno)
            MsgBox("el turno se guardo correctamente")
            GestorTurno.EnviarMail(unTurno, unCliente)
            NoelegirTurno()
        Catch ex As exDatosNOGuardados
            MsgBox("No se pudieron guardar los datos correctacmente")
        End Try





    End Sub

    Private Sub Calendario1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Calendario1.ValueChanged
        NoelegirTurno()
    End Sub


    Private Sub ComboServicios_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ComboServicios.SelectedIndexChanged
        NoelegirTurno()
    End Sub
    Private Sub NoelegirTurno()
        ComboTurnosDisponibles.Visible = False
        ComboTurnosDisponibles.Text = ""
    End Sub


    Private Sub txtEsSobreturno_CheckedChanged(sender As Object, e As EventArgs) Handles txtEsSobreturno.CheckedChanged
        If txtEsSobreturno.Checked = True Then
            'se ponen todos los visores de turno ocultos 
            MsgBox(sender.ToString)

        End If
    End Sub


    Private Sub Agregar_Turno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class