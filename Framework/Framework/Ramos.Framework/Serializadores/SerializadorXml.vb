Imports System.Xml.Serialization
Imports System.IO
Imports Ramos.Framework.Funciones

Namespace serializadores

    Public Class SerializadorXml
		Implements serializadores.Iserializador


        Public Function Serializar(ByVal unObjeto As Object) As String Implements Iserializador.Serializar

            Dim xmlSerializer As New XmlSerializer(unObjeto.GetType())

            Dim ms As New System.IO.MemoryStream

            xmlSerializer.Serialize(ms, unObjeto)

            Return Cadenas.StreamACadena(ms)

        End Function

        Public Function Deserealizar(Of T As New)(ByVal unObjetoSerializadoEnXml As String) As T Implements Iserializador.Deserealizar

            Dim xmlSerializer As New XmlSerializer(GetType(T))

            Dim resultado = xmlSerializer.Deserialize(New MemoryStream(Cadenas.CadenaABytes(unObjetoSerializadoEnXml)))

            Return CType(resultado, T)

        End Function



    End Class

End Namespace