Imports System.Text
Imports System.IO

Namespace Funciones


    Public Class Cadenas
        ' entrega el largo de una cadena cantidad de caracteres.
        ' compara los dos string si el resultado es positivo la primer cadena es mayor. si es negativo la segunda cadena es mayor
        ' convierte toda la cadena en mayuscula
        ' convierte toda la cadena en minuscula
        ' recibe una lista de strings y un caracter y devuelve un string separado por dicho caracter
        ' Toma una cadena de string y la convierte en una lista de strings separandolo por un caracter especial
        ' Toma una lista de strings y le agrega caracteres especiales a la izquierda y a la derecha. devuelva la lista decorada
        ' analiza una una cadena y borra los datos ubicados a la izquierda de la misma ''' resultado= BorrarBasuraIzquierda(qwer@hola,@) (resultado = hola
        ' analiza una una cadena y borra los datos ubicados a la derecha de la misma 
        ' analiza una una cadena y borra los datos ubicados entre las marcas
        ' reemplaza segmentos de una cadena  ''' ej resultado= Reemplazar("hola mundo","mundo", "cambio") | resultado= "hola cambio"
        ' ingresas el booleano, si es true devuelve si y si es false devuelve no 
        ' reemplaza segmentos de una cadena | ej resultado= Reemplazar("hola mundo","mundo", "cambio") | resultado= "hola cambio"
        ' Retorna el nombre del tipo de la variable | ej:NombredelTipoVariable("hola") resultado: string
        ' transforma a integer
        ' Transforma de stream a cadena 
        ' Devuelve el codigo ASCII de un string
        ' Devuelve el codigo string de un ASCII

        ' ME FALTA VERIFICAR EL ULTIMO PERO PARECE IMPORTANTE 




        Private Shared Property aux As String

        ''' <summary>
        ''' entrega el largo de una cadena cantidad de caracteres.
        ''' </summary>
        ''' <param name="unaCadena">string a medir</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function largo(ByVal unaCadena As String) As Integer
            Return Len(unaCadena) 'esto se conoce como wrapper
        End Function
        ''' <summary>
        ''' compara los dos string si el resultado es positivo la primer cadena es mayor. si es negativo la segunda cadena es mayor
        ''' </summary>
        ''' <param name="unaCadena">primer string a comparar</param>
        ''' <param name="otraCadena">segundo string a comparar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CompararCadena(ByVal unaCadena As String, ByVal otraCadena As String) As Integer
            Return String.Compare(unaCadena, otraCadena) 'esto se conoce como wrapper
        End Function
        ''' <summary>
        ''' convierte toda la cadena en mayuscula
        ''' </summary>
        ''' <param name="unaCadena"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function MAYUSCULA(ByVal unaCadena As String) As String
            Return UCase(unaCadena) 'esto se conoce como wrapper
        End Function
        ''' <summary>
        ''' convierte toda la cadena en minuscula
        ''' </summary>
        ''' <param name="unaCadena"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function minuscula(ByVal unaCadena As String) As String
            Return LCase(unaCadena) 'esto se conoce como wrapper
        End Function
        ''' <summary>
        ''' recibe una lista de strings y un caracter y devuelve un string separado por dicho caracter
        ''' </summary>
        ''' <param name="listaCadena">lista de cadenas a unir</param>
        ''' <param name="unaCadena">caracter separador </param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function UnirLista(ByVal unaCadena As String, ByVal listaCadena As List(Of String)) As String
            Return String.Join(unaCadena, listaCadena)
        End Function
        ''' <summary>
        ''' Toma una cadena de string y la convierte en una lista de strings separandolo por un caracter especial
        ''' </summary>
        ''' <param name="listaCadena">cadena a separa</param>
        ''' <param name="unCaracter">caracter especial que separa la cadena</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function SepararLista(ByVal listaCadena As String, ByVal unCaracter As Char) As List(Of String)

            Dim aux = Split(listaCadena, unCaracter).ToList

            Return aux
        End Function
        ''' <summary>
        ''' Toma una lista de strings y le agrega caracteres especiales a la izquierda y a la derecha. devuelva la lista decorada
        ''' </summary>
        ''' <param name="listaCadena">lista a decorar</param>
        ''' <param name="DecoradoIzquierodo">caracter que se va a agregar a la izquierda</param>
        ''' <param name="DecoradoDerecho">caracter que se va a agregar a la derecha</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function DecorarLista(ByVal listaCadena As List(Of String), ByVal DecoradoIzquierodo As String, ByVal DecoradoDerecho As String) As List(Of String)
            Dim AUX As New List(Of String)

            For Each item In listaCadena
                AUX.Add(DecoradoIzquierodo & item & DecoradoDerecho)
            Next

            Return AUX
        End Function
        ''' <summary>
        ''' analiza una una cadena y borra los datos ubicados a la izquierda de la misma 
        ''' resultado= BorrarBasuraIzquierda(qwer@hola,@) (resultado = hola
        ''' </summary>
        ''' <param name="listaCadena">cadena a analizar</param>
        ''' <param name="unCaracter">parametro a comparar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function BorrarBasuraIzquierda(ByVal listaCadena As String, ByVal unCaracter As String) As String
            Dim aux As Integer
            aux = Len(listaCadena) - InStr(1, listaCadena, unCaracter)
            Return Right(listaCadena, aux)
        End Function
        ''' <summary>
        ''' analiza una una cadena y borra los datos ubicados a la derecha de la misma 
        ''' resultado= BorrarBasuraDerecha(hola@qwer,@) (resultado = hola
        ''' </summary>
        ''' <param name="listaCadena">cadena a analizar</param>
        ''' <param name="unCaracter">parametro a comparar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function BorrarBasuraDerecha(ByVal listaCadena As String, ByVal unCaracter As String) As String
            Dim aux As Integer
            aux = InStrRev(listaCadena, unCaracter)

            Return Left(listaCadena, aux - 1)
        End Function
        ''' <summary>
        ''' analiza una una cadena y borra los datos ubicados entre las marcas
        ''' resultado= EntreMarcas(asdfa@hola@kajshd,@) (resultado = hola
        ''' </summary>
        ''' <param name="listaCadena">cadena a analizar</param>
        ''' <param name="PrimerMarca">parametro a comparar</param>
        ''' <param name="SegundaMarca">parametro a comparar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function EntreMarcas(ByVal listaCadena As String, ByVal PrimerMarca As Char, ByVal SegundaMarca As Char) As String
            listaCadena = BorrarBasuraIzquierda(listaCadena, PrimerMarca)
            Return BorrarBasuraDerecha(listaCadena, SegundaMarca)
        End Function
        ''' <summary>
        ''' ingresas el booleano, si es true devuelve si y si es false devuelve no 
        ''' </summary>
        ''' <param name="Acomprar"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function SioNO(ByVal Acomprar As Boolean) As String
            If Acomprar = True Then
                Return "si"
            Else : Return "no"
            End If

        End Function
        ''' <summary>
        ''' reemplaza segmentos de una cadena
        ''' ej resultado= Reemplazar("hola mundo","mundo", "cambio") | resultado= "hola cambio"
        ''' </summary>
        ''' <param name="CadenaAnalizar">Cadena a analizar</param>
        ''' <param name="CadenaBuscar">valor que se desea borrar para reemplazar</param>
        ''' <param name="CadenaReemplazar">valor que reemplaza al anterior</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Reemplazar(ByVal CadenaAnalizar As String, ByVal CadenaBuscar As String, ByVal CadenaReemplazar As String) As String
            Dim aux As Integer = InStr(CadenaAnalizar, CadenaBuscar)
            Dim CadenaIzquierda As String = Left(CadenaAnalizar, aux - 1)
            Dim CadenaDerecha As String = Right(CadenaAnalizar, largo(CadenaAnalizar) - aux - Len(CadenaBuscar) + 1)


            Return CadenaIzquierda & CadenaReemplazar & CadenaDerecha

        End Function
        Public Shared Function Reemplazar(ByVal CadenaAnalizar As List(Of String), ByVal CadenaBuscar As String, ByVal CadenaReemplazar As String) As List(Of String)
            Dim aux As New List(Of String)
            Dim indice As Integer = 0
            For Each item In CadenaAnalizar
                aux(indice) = Reemplazar(item, CadenaBuscar, CadenaReemplazar)
                indice = indice + 1
            Next

            Return aux
        End Function
        ''' <summary>
        ''' Retorna el nombre del tipo de la variable | ej:NombredelTipoVariable("hola") resultado: string
        ''' </summary>
        ''' <param name="unObjeto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function NombredelTipoVariable(ByVal unObjeto As Object) As String
            Return unObjeto.GetType.Name 'esto se conoce como wrapper
        End Function
        ''' <summary>
        ''' transforma a integer
        ''' </summary>
        ''' <param name="unObjeto"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function ConvertiraInteger(ByVal unObjeto As String) As Integer
            Return CInt(unObjeto)
        End Function
        ''' <summary>
        ''' Transforma de stream a cadena 
        ''' </summary>
        ''' <param name="stream"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function StreamACadena(ByVal stream As Stream) As String

            Dim bytes(stream.Length) As Byte

            stream.Position = 0
            stream.Read(bytes, 0, stream.Length)

            Return BytesACadena(bytes)

        End Function
        ''' <summary>
        ''' Devuelve el codigo ASCII de un string
        ''' </summary>
        ''' <param name="cadena"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function CadenaABytes(ByVal cadena As String) As Byte()

            Return Encoding.ASCII.GetBytes(cadena)

        End Function
        ''' <summary>
        ''' Devuelve el codigo string de un ASCII
        ''' </summary>
        ''' <param name="bytes"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function BytesACadena(ByVal bytes As Byte()) As String

            Return Encoding.ASCII.GetString(bytes)

        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="pConsulta"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        '''
        Public Shared Function ObtenerParametrosEnQuery(ByVal pConsulta As String) As List(Of String)

            Dim resultado As New List(Of String)

            Dim inicio As Integer = InStr(pConsulta, "@")

            Do While inicio > 0

                Dim arrayFinal(4) As Integer
                arrayFinal(0) = InStr(inicio, pConsulta, " ")
                arrayFinal(1) = InStr(inicio, pConsulta, ",")
                arrayFinal(2) = InStr(inicio, pConsulta, ")")
                arrayFinal(3) = InStr(inicio, pConsulta, ";")
                arrayFinal(4) = InStr(inicio, pConsulta, vbNewLine)

                Array.Sort(arrayFinal)

                Dim valorMinimo As Integer = Int32.MinValue
                If arrayFinal(4) > 0 Then valorMinimo = arrayFinal(4)
                If arrayFinal(3) > 0 Then valorMinimo = arrayFinal(3)
                If arrayFinal(2) > 0 Then valorMinimo = arrayFinal(2)
                If arrayFinal(1) > 0 Then valorMinimo = arrayFinal(1)
                If arrayFinal(0) > 0 Then valorMinimo = arrayFinal(0)
                If arrayFinal(0) = 0 And arrayFinal(1) = 0 And arrayFinal(2) = 0 And arrayFinal(3) = 0 And arrayFinal(4) = 0 Then valorMinimo = pConsulta.Length + 1

                resultado.Add(Mid(pConsulta, inicio, valorMinimo - inicio))

                inicio = InStr(valorMinimo + 1, pConsulta, "@")

            Loop

            Return resultado

        End Function
    End Class
End Namespace