Imports System.IO.Directory
Imports Ramos.Framework.Funciones.Cadenas

Namespace Funciones



    Public Class Directorios
        Public Shared Function DireccionActual() As String
            Return GetCurrentDirectory()
        End Function
        ''' <summary>
        ''' Trae una matriz de string con todas las subcarpetas
        ''' </summary>
        ''' <param name="Direccion">Direccion a Analizar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function TraerSubcarpetas(ByVal Direccion As String) As String()
            Return GetDirectories(Direccion)
        End Function
        ''' <summary>
        ''' Trae una matriz de string con todas las subcarpetas
        ''' </summary>
        ''' <param name="Direccion">Direccion a Analizar</param>
        ''' <param name="CadenaDeBusqueda">cadena de busqueda que debe coincidir con los nombres de los archivos de Direccion</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function TraerSubcarpetas(ByVal Direccion As String, ByVal CadenaDeBusqueda As String) As String()
            Return GetDirectories(Direccion, CadenaDeBusqueda)
        End Function


        Public Shared Function SubirUnaCarpeta(ByVal Direccion As String) As String


            Return BorrarBasuraDerecha(Direccion, "\")

        End Function

    End Class


End Namespace
