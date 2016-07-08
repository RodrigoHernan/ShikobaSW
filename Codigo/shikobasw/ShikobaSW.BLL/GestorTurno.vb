Imports ShikobaSW.Biz



Namespace BLL
    Public Class GestorTurno
        ''' <summary>
        ''' Trae Todo los turnos DISPONIBLES para el dia, Turno, servicio y el OSoPrePa solicitado
        ''' </summary>
        ''' <param name="Fecha">fecha que se desea buscar</param>
        ''' <param name="IdOSoPrePa">Id de Obra social, Prepaga o particular</param>
        ''' <param name="Servicio">Servicio solicitado</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function TraerTurnosFecha(ByVal Fecha As Date, ByVal IdOSoPrePa As Integer, ByVal Servicio As Biz.BIZ.Entities.Servicio) As List(Of Biz.BIZ.Entities.Turno)
            Dim ListaTurnos As New List(Of Biz.BIZ.Entities.Turno)
            Dim DALTurnos As New DAL.DAL.Turno

            comprobarfecha(Fecha)

            ListaTurnos = DALTurnos.TraerTurnosDisponiblesFecha(Fecha, IdOSoPrePa, Servicio)
            Return ListaTurnos
        End Function
        Public Function TraerTurnosClientefechaActual(ByVal Fecha As Date, ByVal cliente As Biz.BIZ.Entities.Cliente) As List(Of Biz.BIZ.Entities.Turno)
            Dim ListaTurnos As New List(Of Biz.BIZ.Entities.Turno)
            Dim DALTurnos As New DAL.DAL.Turno

            comprobarfecha(Fecha)

            ListaTurnos = DALTurnos.TraerTurnosClientefechaActual(Fecha, cliente)
            Return ListaTurnos
        End Function
        Public Function TraerTurnosClientefechaFutura(Cliente As Biz.BIZ.Entities.Cliente) As List(Of Biz.BIZ.Entities.Turno)
            Dim ListaTurnos As New List(Of Biz.BIZ.Entities.Turno)
            Dim DALTurnos As New DAL.DAL.Turno

            ListaTurnos = DALTurnos.TraerTurnosClientefechaFutura(Cliente)
            Return ListaTurnos
        End Function

        ''' <summary>
        ''' comprueba que la fecha enviada sea mayor al dia de la fecha, en caso contrario llama a la excepcion ExFechaInvalida
        ''' </summary>
        ''' <param name="Fecha">fecha a comprobar</param>
        ''' <remarks></remarks>
        Public Sub comprobarfecha(ByVal Fecha As Date)
            If Fecha < Today Then
                Throw New Biz.BIZ.exceptions.ExFechaInvalida
            End If
        End Sub
        ''' <summary>
        ''' Guarda en la tabla turnos el turno enviado  
        ''' </summary>
        ''' <param name="unTurno"></param>
        ''' <remarks></remarks>
        Public Sub Guardar(ByVal unTurno As Biz.BIZ.Entities.Turno)
            Dim dalTurno As New DAL.DAL.Turno
            'comprobar datos del turno
            dalTurno.Guardar(unTurno)



        End Sub

        Public Sub EnviarMail(ByVal unTurno As Biz.BIZ.Entities.Turno, ByVal unCliente As Biz.BIZ.Entities.Cliente)
            ' Throw New NotImplementedException
        End Sub

        Shared Sub GuardarComentarios(unturno As Biz.BIZ.Entities.Turno)
            Dim DalTurno As New DAL.DAL.Turno
            unturno.Estado = 3
            DalTurno.ModificarTurno(unturno)
        End Sub




    End Class
End Namespace
