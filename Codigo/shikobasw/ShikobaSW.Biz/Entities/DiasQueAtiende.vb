Namespace BIZ.Entities

    	''' <summary>
	''' Esta clase contiene la informcion relacionada acerca de si posee Obra Social,
	''' Prepaga o es Particular. En caso de ser particular el idOSoPrePa es = a 1
	''' </summary>
    Public Class DiasQueAtiende
        Public Property idDiasQueAtiende As Integer
        Public Property IdProfesional As Integer
        Public Property HoraEntrada As TimeSpan
        Public Property HoraSalida As TimeSpan '  en sql usa datetime
        Public Property Dia As Integer

    End Class


End Namespace
