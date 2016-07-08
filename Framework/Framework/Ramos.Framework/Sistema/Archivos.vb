Imports System
Imports System.IO
Imports System.Collections

Namespace Sistema

    Public Class Archivos

        'ListarArchivos(Path)
        'PesoDeArchivo(Path)
        'ObtenerFechaCreacion(Path)
        'LeerEnAscii(Path)
        'CrearCarpeta(Direccion)
        'EliminarCarpeta(Bool si es recursivo) Si es t te deja borrar todo. Si es f y esta llena no te deja


        Public Shared Function ListarArchivos(ByVal Path As String) As List(Of String)

            Return Directory.GetFiles(Path).ToList()

        End Function

        Public Shared Function PesoArchivo(ByVal Path As String) As String

            Dim fi As New FileInfo(Path)

            If fi.Exists Then
                If (fi.Length / 1024) > 1024 Then
                    Return Math.Round(((fi.Length / 1024) / 1024), 2).ToString() & " MB"
                Else
                    Return Math.Round((fi.Length / 1024), 2).ToString() & " KB"
                End If
            Else
                Return String.Empty
            End If

        End Function

        Public Shared Function ObtenerFechaCreacion(ByVal Path As String) As Date

            Return Directory.GetCreationTime(Path)

        End Function

        Public Shared Function LeerEnAscii(ByVal Path As String) As String

            Dim Texto As String
            Dim Archivo As New System.IO.StreamReader(Path)

            Texto = Archivo.ReadToEnd()
            Archivo.Close()
            Return Texto

        End Function


        Public Sub CrearCarpeta(ByVal Path As String)

            Directory.CreateDirectory(Path)
        End Sub

        Public Sub EliminarCarpeta(ByVal Path As String, ByVal Recursivo As Boolean)

            Directory.Delete(Path, Recursivo)
        End Sub


    End Class
End Namespace