Imports System.IO

Namespace Funciones

    Public Class Archivo
        ''' <summary>
        ''' Toma un archivo .txt y lo carga en un string es necesario indicarle que es un tipo .txt
        ''' </summary>
        ''' <param name="direccion"></param>
        ''' <returns>Cadena con el .txt</returns>
        ''' <remarks></remarks>
        Public Shared Function cargarstring(ByVal direccion As String) As String
            Return System.IO.File.ReadAllText(direccion)
        End Function
        ''' <summary>
        ''' guarda en la direccion escrita todo el contenido en un archivo plano
        ''' </summary>
        ''' <param name="ruta"></param>
        ''' <param name="contenido"></param>
        ''' <remarks></remarks>
        Public Shared Sub GuardarEnString(ByVal ruta As String, ByVal contenido As String)

            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(contenido)
            escritor.Flush()
            escritor.Close()

        End Sub

    End Class

End Namespace
