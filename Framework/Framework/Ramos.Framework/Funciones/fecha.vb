Namespace Funciones
    ' devuelve el dia de hoy
    ' Devuelve la fecha y hora de ahora
    ' Devuelve el ultimo dia del mes en la fecha especificada


    Public Class fecha
        ''' <summary>
        ''' devuelve el dia de hoy
        ''' </summary>
        ''' <returns>dd/mm/aa</returns>
        ''' <remarks></remarks>
        Public Shared Function Hoy() As Date
            Return Date.Today
        End Function
        ''' <summary>
        ''' devuelve el dia de hoy y la hora
        ''' </summary>
        ''' <returns>dd/mm/aa hh:mm:ss</returns>
        ''' <remarks></remarks>
        Public Shared Function Ahora() As Date
            Return Date.Now
        End Function
        Public Shared Function AnioActual() As Integer
            Dim fecha = Date.Now
            Return fecha.Year
        End Function
        ''' <summary>
        ''' Devuelve el ultimo dia del mes en la fecha especificada
        ''' </summary>
        ''' <param name="Mes">Mes</param>
        ''' <param name="Anio">Año</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function UltimoDiaDelMesEnFecha(ByVal Mes As Integer, ByVal Anio As Integer) As Date
            Return New DateTime(Anio, Mes, 1).AddMonths(1).AddDays(-1)
        End Function

    End Class


End Namespace