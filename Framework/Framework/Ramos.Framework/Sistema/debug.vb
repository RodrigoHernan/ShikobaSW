Namespace Sistema

    Public Class Debug

        'Escribir(Texto a escribir) Escribe el texto a la consola de Debug

        ''' <summary>
        ''' Escribe en la consola un texto
        ''' </summary>
        ''' <param name="Texto">Texto a escribir</param>
        ''' <remarks></remarks>
        Public Shared Sub Escribir(ByVal Texto As String)
            Console.WriteLine(Texto)
        End Sub

    End Class

End Namespace
