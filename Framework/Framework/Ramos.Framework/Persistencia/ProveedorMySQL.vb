Imports MySql.Data.MySqlClient

Namespace Persistencia

    ''' <summary>
    ''' Este proveedor permite realizar una conexion a un proveedor my SQL
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ProveedorMySQL
		Implements Persistencia.IProveedorBD


        Private _sqlConnection As MySqlConnection
        Private _sqlTransansaction As MySqlTransaction
        Private _servidor As String
        Private _catalogo As String
        Private _usuario As String
        Private _clave As String = Nothing


        Public Sub New(ByVal servidor As String, ByVal catalogo As String)
            Me._servidor = servidor
            Me._catalogo = catalogo
            Me._clave = Nothing
        End Sub

        Public Sub New(ByVal servidor As String, ByVal catalogo As String, ByVal usuario As String, ByVal clave As String)
            Me._servidor = servidor
            Me._catalogo = catalogo
            Me._usuario = usuario
            Me._clave = clave
        End Sub


        Public Sub conexionFinalizar() Implements IProveedorBD.conexionFinalizar
            _sqlConnection.Close()
        End Sub

        Public Sub Conexioniniciar() Implements IProveedorBD.Conexioniniciar
            _sqlConnection = New MySqlConnection()
            ''verificar el tema del puerto para conectarse
            If _clave = Nothing Then
                _sqlConnection.ConnectionString = Me.ObtenerCadenaConexion(_servidor, _catalogo)
            Else
                _sqlConnection.ConnectionString = Me.ObtenerCadenaConexion(_servidor, _catalogo, _usuario, _clave)
            End If

            _sqlConnection.Open()
        End Sub

        Public Function EjecutarEscalar(Of t)(ByVal query As String, ByVal Parametros As List(Of Parametro)) As Object Implements IProveedorBD.EjecutarEscalar
            Dim unComando As New MySqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection

            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In Parametros

                Dim unParametro As New MySqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            Return CType(unComando.ExecuteScalar(), t)
        End Function


        Public Sub EjecutarSinResultado(ByVal query As String, ByVal Parametros As List(Of Parametro)) Implements IProveedorBD.EjecutarSinResultado

            Dim unComando As New MySqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In Parametros

                Dim unParametro As New MySqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            unComando.ExecuteNonQuery()

        End Sub

        Public Function EjecutarTupla(Of t As New)(ByVal query As String, ByVal Parametros As List(Of Parametro)) As List(Of t) Implements IProveedorBD.EjecutarTupla
            Dim unComando As New MySqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In Parametros

                Dim unParametro As New MySqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            Dim resultadoDataReader = unComando.ExecuteReader()

            Return MappearResultado(Of t)(resultadoDataReader)
        End Function

        Public Sub TransaccionAceptar() Implements IProveedorBD.TransaccionAceptar
            _sqlTransansaction.Commit()
        End Sub

        Public Sub TransaccionCancelar() Implements IProveedorBD.TransaccionCancelar
            _sqlTransansaction.Rollback()

        End Sub

        Public Sub TransaccionIniciar() Implements IProveedorBD.TransaccionIniciar
            _sqlTransansaction = _sqlConnection.BeginTransaction()
        End Sub







        '' funciones alternativas
        Private Function ObtenerCadenaConexion(ByVal server As String, ByVal catalogo As String, ByVal usuario As String, ByVal clave As String) As String

            Return String.Format("Data Source={0};Database={1};Uid={2};Password={3};", server, catalogo, usuario, clave)
        End Function

        Private Function ObtenerCadenaConexion(ByVal server As String, ByVal catalogo As String) As String


            Return String.Format("Data Source={0};Database={1};Trusted_Connection=True;", server, catalogo)

        End Function

        Private Function MappearResultado(Of T As New)(ByVal resultadoDataReader As MySqlDataReader) As List(Of T)


            Dim resultado As New List(Of T)

            'Recorro todos los rows.
            Do While resultadoDataReader.Read()

                'Creo un T.
                Dim unT As New T

                'Recorro las columnas de la tabla.
                For i = 0 To resultadoDataReader.FieldCount - 1

                    'A una instancia de T, pegarle cada una de estas propiedades...
                    Dim nombreColumna = resultadoDataReader.GetName(i)

                    'Obtengo la property
                    Dim propiedadInfo = unT.GetType().GetProperty(nombreColumna)

                    'Le pego el valor a esa property.
                    propiedadInfo.SetValue(unT, resultadoDataReader.GetValue(i))

                Next

                resultado.Add(unT)

            Loop

            resultadoDataReader.Close()
            Return resultado

        End Function

    End Class
End Namespace