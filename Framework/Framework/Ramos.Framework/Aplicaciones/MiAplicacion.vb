Namespace Aplicaciones

    Public Class MiAplicacion
        'NombreAplicacion Devuelve el nombre de la aplicaion
        'DirectorioAplicacion Devuelve el nombre de la carpeta del exe que se esta ejecutando

        ''' <summary>
        ''' Devuelve el nombre de la aplicacion
        ''' </summary>
        ''' <returns>Nombre de la aplicacion</returns>
        ''' <remarks></remarks>
        Public Shared Function NombreAplicacion() As String
            Return My.Application.Info.AssemblyName
        End Function
        ''' <summary>
        ''' Devuelve la path de la aplicacion
        ''' </summary>
        ''' <returns>La path de la aplicacion</returns>
        ''' <remarks></remarks>
        Public Shared Function DirectorioAplicacion() As String
            Return My.Application.Info.DirectoryPath
        End Function

    End Class

End Namespace

