Imports System.IO

Namespace Sistema

    Public Class Unidades

        'ListarDiscos

        ''' <summary>
        ''' Lista los discos que estan presentes en el sistema
        ''' </summary>
        ''' <returns>Discos en el sistema</returns>
        ''' <remarks></remarks>
        Public Shared Function ListarDiscos() As List(Of String)

            Dim Unidades() As String = Directory.GetLogicalDrives
            Dim Resultado As New List(Of String)

            Resultado.AddRange(Unidades)

            Return Resultado

        End Function

    End Class

End Namespace