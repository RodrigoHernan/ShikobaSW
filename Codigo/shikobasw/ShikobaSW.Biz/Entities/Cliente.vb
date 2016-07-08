Imports ShikobaSW.Biz.BIZ.Entities

Namespace BIZ.Entities


    Public Class Cliente
        Property DNI As Integer
        Property Nombre As String
        Property Apellido As String
        Property Domicilio As String
        Property NumeroTelefono As String
        Property IdOsoPrePa As Integer
        Property NumeroDeCuenta As String
        Property Estado As Boolean ' en caso de estar en 1 significa que el cliente esta en falta 

        Property Turnos As List(Of Turno)
        Property unOsPrePa As New OsoPrePa

    End Class

End Namespace



'
