Imports System.Data.SqlClient
Namespace Persistencia
    ''' <summary>
    ''' Dicho proveedor permite realizar una conexion a una base de datos SQLServer de windows
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ProveedorSql
		Implements Persistencia.IProveedorBD


        Private _sqlConnection As SqlConnection
        Private _sqlTransansaction As SqlTransaction
        Private _servidor As String
        Private _catalogo As String
        Private _usuario As String
        Private _clave As String


        Public Sub New(ByVal servidor As String, ByVal catalogo As String)
            Me._servidor = servidor
            Me._catalogo = catalogo
        End Sub

        Public Sub ConexionIniciar() Implements IProveedorBD.ConexionIniciar

            _sqlConnection = New SqlConnection(Me.ObtenerCadenaConexion(_servidor, _catalogo))
            _sqlConnection.Open()

        End Sub

        Public Sub ConexionFinalizar() Implements IProveedorBD.ConexionFinalizar


            _sqlConnection.Close()

        End Sub

        Public Sub TransaccionIniciar() Implements IProveedorBD.TransaccionIniciar

            _sqlTransansaction = _sqlConnection.BeginTransaction()

        End Sub

        Public Sub TransaccionAceptar() Implements IProveedorBD.TransaccionAceptar

            _sqlTransansaction.Commit()

        End Sub

        Public Sub TransaccionCancelar() Implements IProveedorBD.TransaccionCancelar

            _sqlTransansaction.Rollback()

        End Sub

        Public Sub EjecutarSinResultado(ByVal query As String, ByVal parametros As List(Of Parametro)) Implements IProveedorBD.EjecutarSinResultado

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            unComando.ExecuteNonQuery()

        End Sub

        Public Function EjecutarEscalar(Of T)(ByVal query As String, ByVal parametros As List(Of Parametro)) As Object Implements IProveedorBD.EjecutarEscalar
            '  Public Function EjecutarEscalar(query As String, parametros As List(Of Parametro)) As Object Implements IProveedorBD.EjecutarEscalar

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection

            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            ' Return CType(unComando.ExecuteScalar(), T)
            Return unComando.ExecuteScalar()

        End Function


        Public Function EjecutarTupla(Of T As New)(ByVal query As String, ByVal parametros As List(Of Parametro)) As List(Of T) Implements IProveedorBD.EjecutarTupla

            Dim unComando As New SqlCommand

            'Preconfig...
            unComando.Connection = _sqlConnection
            unComando.Transaction = _sqlTransansaction

            unComando.CommandType = CommandType.Text
            unComando.CommandText = query

            For Each item In parametros

                Dim unParametro As New SqlParameter(item.NombreParametro, item.Valor)
                unComando.Parameters.Add(unParametro)

            Next

            'Ejecucion...
            Dim resultadoDataReader = unComando.ExecuteReader()

            Return MappearResultado(Of T)(resultadoDataReader)

        End Function


        Private Function ObtenerCadenaConexion(ByVal server As String, ByVal catalogo As String, ByVal usuario As String, ByVal clave As String) As String

            Return String.Format("Server={0};Database={1};User Id={2};Password={3};", server, catalogo, usuario, clave)

        End Function

        Private Function ObtenerCadenaConexion(ByVal server As String, ByVal catalogo As String) As String


            Return String.Format("Server={0};Database={1};Trusted_Connection=True;", server, catalogo)

        End Function

        Private Function MappearResultado(Of T As New)(ByVal resultadoDataReader As SqlDataReader) As List(Of T)


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