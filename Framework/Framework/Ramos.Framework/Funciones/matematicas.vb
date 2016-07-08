Namespace Funciones
    ' ingreso un numero y lo redondea la cantidad de decimales deseada.
    ' Entrega un numero aleatorio iniciando desde "DESDE" hasta "HASTA"
    ' rellena la cantidad de ceros a la izquierda para llegar a la cantidad de caracteres que indica "cantidad de ceros"
    ' devuelve el importe aplicando el descuento del porcentaje ingresado. (ejemplo: AplicarDescuento(100, 10) = 90)
    ' AplicarRecargo(ImporteNeto, PorcentajeRecargo) devuelve el importe aplicando el recargo ingresado. (Ejemplo: AplicarRecargo(100, 10) = 110




    Public Class matematicas
        ''' <summary>
        ''' ingreso un numero y lo redondea la cantidad de decimales deseada.
        ''' </summary>
        ''' <param name="unNumero">numero que se desea redondear</param>
        ''' <param name="cantidadDecimales">cantidad de decimales</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function redondear(ByVal unNumero As Decimal, ByVal cantidadDecimales As Integer) As Decimal
            Return Math.Round(unNumero, cantidadDecimales) 'esto se conoce como wrapper
        End Function
        ''' <summary>
        ''' Entrega un numero aleatorio iniciando desde "DESDE" hasta "HASTA"
        ''' </summary>
        ''' <param name="desde"></param>
        ''' <param name="hasta"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ObtenerNumeroAleatorio(ByVal desde As Integer, ByVal hasta As Integer) As Integer
            Dim rnd As New Random
            Dim resultado As Integer = rnd.Next(desde, hasta + 1)
            Return resultado
        End Function
        ''' <summary>
        ''' rellena la cantidad de ceros a la izquierda para llegar a la cantidad de caracteres que indica "cantidad de ceros"
        ''' ej: resultado = CerosAlaIzquierda(123, 5) ¨(resultado igual 00123)
        ''' </summary>
        ''' <param name="unNumero"></param>
        ''' <param name="CantidadCeros"></param>
        ''' <returns>string </returns>
        ''' <remarks></remarks>
        Public Shared Function CerosAlaIzquierda(ByVal unNumero As Integer, ByVal CantidadCeros As Integer) As String
            Return unNumero.ToString("D" & CantidadCeros)
        End Function

        ''' <summary>
        ''' devuelve el importe aplicando el descuento del porcentaje ingresado. (ejemplo: AplicarDescuento(100, 10) = 90)
        ''' </summary>
        ''' <param name="ImporteNeto"></param>
        ''' <param name="PorcentajeDescontar"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function AplicarDescuento(ByVal ImporteNeto As Integer, ByVal PorcentajeDescontar As Integer) As Integer
            Return ImporteNeto * (1 - PorcentajeDescontar / 100)
        End Function

        ' AplicarRecargo(ImporteNeto, PorcentajeRecargo) devuelve el importe aplicando el recargo ingresado. (Ejemplo: AplicarRecargo(100, 10) = 110
        Public Shared Function AplicarRecargo(ByVal ImporteNeto As Integer, ByVal PorcentajeRecargo As Integer) As Integer
            Return ImporteNeto * (1 + PorcentajeRecargo / 100)
        End Function
    End Class


End Namespace