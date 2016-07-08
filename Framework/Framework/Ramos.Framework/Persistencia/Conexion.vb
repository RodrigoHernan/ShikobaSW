
Namespace Persistencia


    ''' <summary>
    ''' La clase conexion proporciona valores para la conexion a una base de datos los parametros deben ingresarse al archivo conexion.txt dentro de la carpeta debug
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Conexion


        Private _estrategiaConexion As IProveedorBD
        Private _ConfiguracionDb As New ConfiguracionDb

        Public Sub New()
            _ConfiguracionDb.LeerDatosConexion("conexion.txt")
            Select Case _ConfiguracionDb.estrategiaElegida

                Case "ProveedorSQL"
                    _estrategiaConexion = New ProveedorSql(_ConfiguracionDb.Servidor, _ConfiguracionDb.Catalogo)

                Case "MySql"
                    _estrategiaConexion = New ProveedorMySQL(_ConfiguracionDb.Servidor, _ConfiguracionDb.Catalogo)

                Case "ACCESS"
                    _estrategiaConexion = New ProveedorACCESS(_ConfiguracionDb.Servidor, _ConfiguracionDb.Catalogo)

            End Select

        End Sub
        Public Sub ConexionIniciar()

            _estrategiaConexion.Conexioniniciar()

        End Sub

        Public Sub conexionFinalizar()

            _estrategiaConexion.conexionFinalizar()

        End Sub
        Public Sub TransaccionIniciar()

            _estrategiaConexion.TransaccionIniciar()

        End Sub

        Public Sub TransaccionAceptar()

            _estrategiaConexion.TransaccionAceptar()

        End Sub

        Public Sub TransaccionCancelar()

            _estrategiaConexion.TransaccionCancelar()

        End Sub

        Public Sub EjecutarSinResultado(ByVal query As String, ByVal parametros As List(Of Parametro))

            _estrategiaConexion.EjecutarSinResultado(query, parametros)

        End Sub
        Public Function EjecutarEscalar(Of T)(ByVal query As String, ByVal parametros As List(Of Parametro)) As T
            Return _estrategiaConexion.EjecutarEscalar(Of T)(query, parametros)
        End Function

        Public Function EjecutarTupla(Of T As New)(ByVal query As String, ByVal parametros As List(Of Parametro)) As List(Of T)
            Return _estrategiaConexion.EjecutarTupla(Of T)(query, parametros)
        End Function


    End Class
End Namespace