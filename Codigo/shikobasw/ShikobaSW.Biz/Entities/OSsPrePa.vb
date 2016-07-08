Namespace BIZ.Entities

    	''' <summary>
	''' Esta clase contiene la informcion relacionada acerca de si posee Obra Social,
	''' Prepaga o es Particular. En caso de ser particular el idOSoPrePa es = a 1
	''' </summary>
    Public Class OsoPrePa

        Property IdOsoPrePa As Integer
        Property Nombre As String
        Property ListaProfesionales As List(Of OsoPrePaQueAtiende)

    End Class


End Namespace