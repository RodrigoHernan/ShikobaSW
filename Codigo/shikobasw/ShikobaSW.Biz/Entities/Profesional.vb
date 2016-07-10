Imports ShikobaSW.Biz.BIZ.Entities

Namespace BIZ.Entities

    Public Class Profesional

        Public Property IdProfesional As Integer
        Public Property IdServicioPrestado As Integer

        Public Property DNI As Integer
        Public Property Nombre As String
        Public Property Apellido As String
        Public Property email As String
        Public Property contraseña As String
        Public Property PorcentajePago As Integer
        Public Property Puntaje As Integer

        Public Property DiasQueAtiende As List(Of DiasQueAtiende)
        Public Property Servicio As New Servicio
        Public Property ListaTurnos As List(Of Turno)
        Public Property ListaProfecionalOSoPrePa As List(Of OsoPrePaQueAtiende)


    End Class

End Namespace