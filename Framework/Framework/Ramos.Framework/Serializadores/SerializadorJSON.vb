


Namespace serializadores


    Public Class SerializadorJSON
        Implements serializadores.Iserializador

        Public Function Deserealizar(Of T As New)(unObjetoSerializadoEnXml As String) As T Implements Iserializador.Deserealizar


        End Function

        Public Function Serializar(unObjeto As Object) As String Implements Iserializador.Serializar

        End Function
    End Class
End Namespace