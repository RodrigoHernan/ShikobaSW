Imports ShikobaSW.Biz
Imports Ramos.Framework.Persistencia

Namespace DAL



    Public Class Servicio
        ''' <summary>
        ''' Trae una lista con todos los servicios disponibles
        ''' </summary>
        ''' <returns>lista de biz.Servicio</returns>
        ''' <remarks></remarks>
        Function TraerTodos() As List(Of Biz.BIZ.Entities.Servicio)
            Dim ListaServicios As New List(Of Biz.BIZ.Entities.Servicio)
            Dim c As New Conexion()
            c.ConexionIniciar()
            c.TransaccionIniciar()
            ListaServicios = c.EjecutarTupla(Of Biz.BIZ.Entities.Servicio)("select * from Servicio ", New List(Of Parametro))

            c.TransaccionAceptar()
            c.conexionFinalizar()


            Return ListaServicios
        End Function
        ''' <summary>
        ''' Busca en la tabla Servicio el tiempo estimado en minutos de cada servicio
        ''' </summary>
        ''' <param name="Servicio">clase servicio que se desea buscar el tiempo estimaddo</param>
        ''' <returns>tiempo estimado en minutos</returns>
        ''' <remarks></remarks>
        Public Shared Function TiempoServicio(ByVal Servicio As Biz.BIZ.Entities.Servicio) As Long

            Dim LP As New List(Of Parametro)
            LP.Add(New Parametro("@IdTiempoEstimado", Servicio.IdServicio))  
            Dim c As New Conexion()
            c.ConexionIniciar()
            c.TransaccionIniciar()
            Dim T = c.EjecutarEscalar(Of Integer)("select Tiempo from TiempoEstimado where IdTiempoEstimado=@IdTiempoEstimado ", LP)

            c.TransaccionAceptar()
            c.conexionFinalizar()


            Return T

        End Function


    End Class

End Namespace
