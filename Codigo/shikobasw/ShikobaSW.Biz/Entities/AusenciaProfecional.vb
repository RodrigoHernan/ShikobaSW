Imports ShikobaSW.Biz.BIZ.Entities

Namespace BIZ.Entities




    Public Class AusenciaProfesional
        Public Property IdAusenciaProfesional As Integer
        Public Property IdProfesionial As Integer
        Public Property DiaInicioAuscencia As Date
        Public Property DiaFinAuscencia As Date
        Public Property HorarioInicio As TimeSpan
        Public Property HorarioFin As TimeSpan
        Public Property Motivo As String
        Public Property URLCertificado As String
        ''' <summary>
        ''' esta property cuando esta en false indica que no fue cargado el certificado de auscencia 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CertificadoCargado As Boolean = False
        Public Property unProfesional As New Profesional

    End Class

End Namespace