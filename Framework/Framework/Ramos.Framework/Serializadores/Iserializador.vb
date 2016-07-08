Namespace serializadores

    Public Interface Iserializador


        Function Serializar(ByVal unObjeto As Object) As String

        Function Deserealizar(Of T As New)(ByVal unObjetoSerializadoEnXml As String) As T

    End Interface

End Namespace