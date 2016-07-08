Imports ShikobaSW.Biz.BIZ.Entities

Namespace BIZ.Entities


    Public Class Turno

        Public Property IdTurno As Integer
        Public Property Dia As Date
        Public Property HorarioEntrada As TimeSpan
        Public Property HorarioSalida As TimeSpan
        Public Property NumeroDeTurno As String
        Public Property Comentarios As String = " "
        Public Property IdCliente As Integer
        Public Property IdProfesional As Integer
        Public Property IdServicio As Integer
        ''' <summary>
        ''' en caso de ser true o 1 significa que es un sobreturno
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property EsSobreturno As Boolean = False
        ''' <summary>
        ''' esta property indica el estado en que se encuentra el servicio 
        ''' </summary>
        ''' <value>1: Reservado 2: En Espera 3:Concretado 4: No Concretado</value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Estado As Integer 
        Public Property Servicio As New Servicio


    End Class
End Namespace