Imports ShikobaSW.Biz.BIZ.exceptions
Imports Ramos.Framework.Persistencia
Imports ShikobaSW.Biz.BIZ
Imports Ramos.Framework.Funciones

Namespace DAL

    Public Class Turno
        ''' <summary>
        ''' 'se genera la lista de turnos totales segun el dia de la semana, el servicio y el OSoPrePa
        ''' </summary>
        ''' <param name="Fecha">fecha a la cual se desea traer los turnos disponibles</param>
        ''' <param name="OSoPrePa">numero de ObraSocial/Prepaga/Particular del cual se desea buscar los turnos disponibles</param>
        ''' <param name="servicio">Servicio que se desea buscar los turnos disponibles</param>
        ''' <returns>Lista de Turnos disponibles list (of Turnos) </returns>
        ''' <remarks></remarks>
        Public Function TraerTurnosDisponiblesFecha(ByVal Fecha As Date, ByVal OSoPrePa As Integer, ByVal servicio As Biz.BIZ.Entities.Servicio) As Object
            Dim ListaTurnos As New List(Of Biz.BIZ.Entities.Turno)

            Dim listaTurnoqueatiende As New List(Of Biz.BIZ.Entities.DiasQueAtiende)
            Dim listaParametros As New List(Of Parametro)
            listaParametros.Add(New Parametro("@dia", Fecha.DayOfWeek.GetHashCode))
            listaParametros.Add(New Parametro("@IdOsoPrePa", OSoPrePa))
            listaParametros.Add(New Parametro("@IdServicioPrestado", servicio.IdServicio))
            Dim c As New Conexion()
            c.ConexionIniciar()
            c.TransaccionIniciar()
            Dim HorasDisponibles As New List(Of Biz.BIZ.Entities.DiasQueAtiende)
            'horas que atiende el profesional
            HorasDisponibles = c.EjecutarTupla(Of Entities.DiasQueAtiende)("SELECT d.idDiasQueAtiende, d.HoraEntrada, d.HoraSalida, d.IdProfesional from DiasQueAtiende d,Profesional p, OsoPrePaQueAtiende O where Dia=@dia and IdOsoPrePa=@IdOsoPrePa and p.IdProfesional = d.IdProfesional and o.IdProfesional = p.IdProfesional and p.IdServicioPrestado =  @IdServicioPrestado", listaParametros)

            'se seleccionan los horarios completos disponibles para esa fecha 
            Dim CuantoDuraCadaTurno As New TimeSpan(0, DAL.Servicio.TiempoServicio(servicio), 0)

            For Each item In HorasDisponibles
                Dim cantidadTurnos = (item.HoraSalida - item.HoraEntrada).TotalMinutes / CuantoDuraCadaTurno.Minutes

                For i = 0 To cantidadTurnos - 1

                    Dim t As New Biz.BIZ.Entities.Turno
                    t.IdServicio = servicio.IdServicio
                    t.HorarioEntrada = New TimeSpan(item.HoraEntrada.Ticks + CuantoDuraCadaTurno.Ticks * i)
                    t.HorarioSalida = New TimeSpan(item.HoraEntrada.Ticks + CuantoDuraCadaTurno.Ticks * (i + 1))
                    t.NumeroDeTurno = matematicas.ObtenerNumeroAleatorio(0, 1) & t.HorarioEntrada.ToString
                    t.IdProfesional = item.IdProfesional
                    ListaTurnos.Add(t)
                Next
            Next
            'se trae los turnos ocupados segun la fecha
            Dim TOcupados As New List(Of Biz.BIZ.Entities.Turno)(TraerTurnosOcupados(Fecha, c))

            ' se resta el 1ro con el segundo y se devuelve la lista de turnos disponibles 
            For Each item In TOcupados
                ListaTurnos.RemoveAll(Function(t As Biz.BIZ.Entities.Turno) t.HorarioEntrada >= item.HorarioEntrada And t.HorarioSalida <= item.HorarioSalida)
                ListaTurnos.RemoveAll(Function(t As Biz.BIZ.Entities.Turno) t.HorarioEntrada <= item.HorarioEntrada And t.HorarioSalida >= item.HorarioSalida)
            Next



            c.TransaccionAceptar()
            c.conexionFinalizar()

            Return ListaTurnos
        End Function
        ''' <summary>
        ''' Guarda en la base de datos el turno seleccionado 
        ''' </summary>
        ''' <param name="unTurno">Turno que se desea guardar</param>
        ''' <remarks></remarks>
        Public Sub Guardar(ByVal unTurno As Biz.BIZ.Entities.Turno)
            Dim LP As New List(Of Parametro)
            LP.Add(New Parametro("@Dia", unTurno.Dia))
            LP.Add(New Parametro("@HorarioEntrada", unTurno.HorarioEntrada))
            LP.Add(New Parametro("@HorarioSalida", unTurno.HorarioSalida))
            LP.Add(New Parametro("@NumeroDeTurno", unTurno.NumeroDeTurno))
            LP.Add(New Parametro("@Comentarios", unTurno.Comentarios))
            LP.Add(New Parametro("@IdCliente", unTurno.IdCliente))
            LP.Add(New Parametro("@IdProfesional", unTurno.IdProfesional))
            LP.Add(New Parametro("@EsSobreturno", unTurno.IdProfesional))
            LP.Add(New Parametro("@IdServicio", unTurno.IdServicio))
            LP.Add(New Parametro("@Estado", unTurno.Estado))
            Dim c As New Conexion()

            Try
               c.ConexionIniciar()
                c.TransaccionIniciar()
                c.EjecutarSinResultado("Insert into Turno values (@Dia,@HorarioEntrada,@HorarioSalida,@NumeroDeTurno,@Comentarios,@IdCliente,@IdProfesional,@EsSobreturno,@IdServicio,@Estado)", LP)
                c.TransaccionAceptar()
                c.conexionFinalizar()


            Catch ex As Exception
                c.TransaccionCancelar()
                Throw New exDatosNOGuardados
            End Try
        End Sub
        ''' <summary>
        ''' Trae todos los turnos Ocupados. Se debe establecer una conexion antes 
        ''' </summary>
        ''' <param name="Fecha">Fecha que se desea traer los turnos ocupados</param>
        ''' <param name="c">conexion establecida de la bd</param>
        ''' <returns>lista de turnos ocupados</returns>
        ''' <remarks></remarks>
        Private Function TraerTurnosOcupados(ByVal Fecha As Date, ByVal c As Conexion) As List(Of Biz.BIZ.Entities.Turno)
            Dim TOcupados As New List(Of Biz.BIZ.Entities.Turno)
            Dim LP As New List(Of Parametro)
            LP.Add(New Parametro("@Dia", Fecha.Date))
            TOcupados = c.EjecutarTupla(Of Biz.BIZ.Entities.Turno)("SELECT * FROM Turno Where Dia=@Dia", LP)

            Return TOcupados
        End Function

        Function TraerTurnosClientefechaActual(Fecha As Date, cliente As Entities.Cliente) As List(Of Entities.Turno)
            Dim c As New Conexion
            Dim Turnos As New List(Of Biz.BIZ.Entities.Turno)
            Dim LP As New List(Of Parametro)
            LP.Add(New Parametro("@Dia", Fecha.Date))
            LP.Add(New Parametro("@IdCliente", cliente.DNI))
            c.ConexionIniciar()
            c.TransaccionIniciar()
            Turnos = c.EjecutarTupla(Of Biz.BIZ.Entities.Turno)("SELECT * FROM Turno Where Dia=@Dia and IdCliente = @IdCliente", LP)
            'traer los turnos ocupados para la fecha actual 
            c.TransaccionAceptar()
            c.conexionFinalizar()

            Return Turnos
        End Function

        Function TraerTurnosClientefechaFutura(Cliente As Entities.Cliente) As List(Of Entities.Turno)
            Dim c As New Conexion
            Dim Turnos As New List(Of Biz.BIZ.Entities.Turno)
            Dim LP As New List(Of Parametro)
            LP.Add(New Parametro("@Dia", Date.Today))
            LP.Add(New Parametro("@IdCliente", Cliente.DNI))
            c.ConexionIniciar()
            c.TransaccionIniciar()
            Turnos = c.EjecutarTupla(Of Biz.BIZ.Entities.Turno)("SELECT * FROM Turno Where Dia > @Dia and IdCliente = @IdCliente", LP)
            'traer los turnos ocupados para las fechas futuras 
            c.TransaccionAceptar()
            c.conexionFinalizar()

            Return Turnos
        End Function

        Sub ModificarTurno(unturno As Entities.Turno)
            'no probado si funciona 
            Dim LP As New List(Of Parametro)
            LP.Add(New Parametro("@IdTurno", unturno.IdTurno))
            LP.Add(New Parametro("@Dia", unturno.Dia))
            LP.Add(New Parametro("@HorarioEntrada", unturno.HorarioEntrada))
            LP.Add(New Parametro("@HorarioSalida", unturno.HorarioSalida))
            LP.Add(New Parametro("@NumeroDeTurno", unturno.NumeroDeTurno))
            LP.Add(New Parametro("@Comentarios", unturno.Comentarios))
            LP.Add(New Parametro("@IdCliente", unturno.IdCliente))
            LP.Add(New Parametro("@IdProfesional", unturno.IdProfesional))
            LP.Add(New Parametro("@EsSobreturno", unturno.IdProfesional))
            LP.Add(New Parametro("@IdServicio", unturno.IdServicio))
            LP.Add(New Parametro("@Estado", unturno.Estado))
            Dim c As New Conexion()

            Try
                c.ConexionIniciar()
                c.TransaccionIniciar()
                c.EjecutarSinResultado("update Articulo set  Dia=@Dia Comentarios=@Comentarios Estado=@Estado  where IdTurno=@IdTurno", LP)
                c.TransaccionAceptar()
                c.conexionFinalizar()


            Catch ex As Exception
                c.TransaccionCancelar()
                Throw New exDatosNOGuardados
            End Try
        End Sub

    End Class


End Namespace
