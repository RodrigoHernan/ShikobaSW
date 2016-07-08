Imports Ramos.Framework.Funciones
Imports System.Text.RegularExpressions

Namespace Funciones
    ' Si la fecha ingresada es mayor a HOY, devuelve true
    ' Si la cadena = String.Empty devuelve true
    ' Si el texto es fecha, retorna true, sino tira false
    ' Si el texto es numero, retorna true, sino false

    ' Devuelve TRUE si el mail es valido
    ' Verifica que se corresponda con una direccion IP
    ' Verifica que la contraseña tenga minimo 8 caracteres con letras mayusculas minusculas, numeros y/o simbolos.
    ' Verifiva que la Fecha sea Valida
    ' Verifica el numero de tarjeta de Credito


    Public Class validadores
        ''' <summary>
        ''' Si la fecha ingresada es mayor a HOY, devuelve true
        ''' </summary>
        ''' <param name="unaFecha"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function FechaMayorAHoy(ByVal unaFecha As String) As Boolean
            Dim fechaAux As Date
            Try


                fechaAux = unaFecha
                If unaFecha < fecha.Hoy Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
        ''' <summary>
        ''' Si la cadena = String.Empty devuelve true
        ''' </summary>
        ''' <param name="unaCadena"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CadenaEstaVacia(ByVal unaCadena As Date) As Boolean
            If unaCadena = String.Empty Then
                Return True
            Else : Return False
            End If
        End Function
        ''' <summary>
        ''' Si el texto es fecha, retorna true, sino tira false
        ''' </summary>
        ''' <param name="unTexto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function EsFechaValida(ByVal unTexto As String) As Boolean
            Dim fecha As Date
            Try
                fecha = unTexto
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function
        ''' <summary>
        ''' Si el texto es numero, retorna true, sino false
        ''' </summary>
        ''' <param name="unTexto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function EsNumeroValido(ByVal unTexto As Object) As Boolean
            Dim aux As Double
            Try
                aux = unTexto

                Return True

            Catch ex As Exception
                Return False
            End Try
        End Function

        ''' <summary>
        ''' Devuelve TRUE si el mail es valido
        ''' </summary>
        ''' <param name="Valor">string de mail </param>
        ''' <returns>True si es valido</returns>
        ''' <remarks></remarks>
        Public Shared Function VerificarEmail(ByVal Valor As String) As Boolean
            Dim patron As New Regex("\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")
            Return patron.IsMatch(Valor)
        End Function

        ''' <summary>
        ''' Verifica que se corresponda con una direccion IP
        ''' </summary>
        ''' <returns>True si es valido</returns>
        ''' <remarks></remarks>
        Public Shared Function VerificarIP(ByVal Valor As String) As Boolean
            Dim patron As New Regex("^(?:25[0-5]|2[0-4]\d|1\d\d|[1-9]\d|\d)(?:[.](?:25[0-5]|2[0-4]\d|1\d\d|[1-9]\d|\d)){3}$")
            Return patron.IsMatch(Valor)
        End Function
        ''' <summary>
        ''' Verifica que la contraseña tenga minimo 8 caracteres con letras mayusculas minusculas, numeros y/o simbolos.
        ''' </summary>
        ''' <returns>True si es valido</returns>
        ''' <remarks></remarks>
        Public Shared Function VerificarPassword(ByVal Valor As String) As Boolean
            Dim patron As New Regex("(?=^.{8,}$)((?=.*d)|(?=.*W+))(?![.n])(?=.*[A-Z])(?=.*[a-z]).*$")
            Return patron.IsMatch(Valor)
        End Function

        ''' <summary>
        ''' Verifiva que la Fecha sea Valida
        ''' </summary>
        ''' <param name="Valor"></param>
        ''' <returns>True si es valido</returns>
        ''' <remarks></remarks>
        Public Shared Function VerificarFecha(ByVal Valor As String) As Boolean
            Dim patron As New Regex("^(19|20)\d\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])$")
            Return patron.IsMatch(Valor)
        End Function

        ''' <summary>
        ''' Verifica el numero de tarjeta de Credito
        ''' </summary>
        ''' <param name="Valor">True si es valido</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function VerificarTarjeta(ByVal Valor As String) As Boolean
            Dim patron As New Regex("^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|6(?:011|5[0-9]{2})[0-9]{12}|(?:2131|1800|35\d{3})\d{11})$")
            Return patron.IsMatch(Valor)
        End Function


    End Class

End Namespace