Namespace Persistencia
    ''' <summary>
    ''' Contiene los parametros que deben ser enviados a la conexion 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Parametro
        ''' <summary>
        ''' en su inicializacion de deben cargar los siguientes parametros
        ''' </summary>
        ''' <param name="nombreParametro">Nombre del parametro que se desea enviar</param>
        ''' <param name="valor">valor del parametro a enviar</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal nombreParametro As String, ByVal valor As Object)

            Me.NombreParametro = nombreParametro
            Me.Valor = valor

        End Sub

        Property NombreParametro As String

        Property Valor As Object

    End Class

End Namespace