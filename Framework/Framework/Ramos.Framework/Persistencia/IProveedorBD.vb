Namespace Persistencia

    Public Interface IProveedorBD
        Sub Conexioniniciar()
        Sub conexionFinalizar()
        Sub TransaccionIniciar()
        Sub TransaccionAceptar()
        Sub TransaccionCancelar()

        Sub EjecutarSinResultado(ByVal query As String, ByVal Parametros As List(Of Parametro))
        Function EjecutarEscalar(Of t)(ByVal query As String, ByVal Parametros As List(Of Parametro)) As Object
        Function EjecutarTupla(Of t As New)(ByVal query As String, ByVal Parametros As List(Of Parametro)) As List(Of t)

    End Interface

End Namespace